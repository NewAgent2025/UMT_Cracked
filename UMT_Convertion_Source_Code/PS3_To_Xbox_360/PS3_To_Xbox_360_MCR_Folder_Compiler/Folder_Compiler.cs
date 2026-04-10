using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Xbox360MCRTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Xbox 360 MCR Tool (AUTO MODE) ===");

            string root = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UMT_Cracked_Convertion");

            if (!Directory.Exists(root))
            {
                Console.WriteLine("UMT_Cracked_Convertion not found.");
                return;
            }

            var ps3Folders = Directory.GetDirectories(root)
                .Where(f => f.Contains("_PS3"))
                .ToList();

            if (ps3Folders.Count == 0)
            {
                Console.WriteLine("No _PS3 folders found. Stopping.");
                return;
            }

            string newestFolder = ps3Folders
                .OrderByDescending(f => ExtractDate(f))
                .First();

            Console.WriteLine($"Newest folder: {newestFolder}");

            string mcrOutput = Path.Combine(newestFolder, "MCR_OUTPUT");

            if (!Directory.Exists(mcrOutput))
            {
                Console.WriteLine("MCR_OUTPUT not found.");
                return;
            }

            string outputRoot = Path.Combine(root, "BLANK_X360_WORLD_DONT_DELETE");

            if (!Directory.Exists(outputRoot))
            {
                Console.WriteLine("BLANK_X360_WORLD_DONT_DELETE not found.");
                return;
            }

            // ==================== COMPILE ====================
            Console.WriteLine("Compiling...");
            CompileAll(mcrOutput, mcrOutput);

            // ==================== COPY ROOT MCR FILES ====================
            CopyOnlyMCRFiles(mcrOutput, outputRoot);

            // ==================== COPY DIM1 ====================
            CopyDIM1Folder(newestFolder, outputRoot);

            // ==================== DELETE SOURCE ====================
            Console.WriteLine("Deleting source MCR_OUTPUT...");
            Directory.Delete(mcrOutput, true);

            Console.WriteLine("DONE!");
        }

        // ==================== DATE ====================
        private static DateTime ExtractDate(string folder)
        {
            string name = Path.GetFileName(folder);
            var parts = name.Split('_');

            if (parts.Length >= 3)
            {
                string datePart = parts[parts.Length - 2];
                string timePart = parts[parts.Length - 1];
                if (DateTime.TryParseExact(datePart + timePart,
                    "yyyyMMddHHmmss",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime dt))
                {
                    return dt;
                }
            }

            return DateTime.MinValue;
        }

        // ==================== COPY ROOT MCR ====================
        private static void CopyOnlyMCRFiles(string sourceDir, string targetDir)
        {
            string[] allowedFiles = new string[]
            {
                "DIM-1r.0.0.mcr",
                "DIM-1r.0.-1.mcr",
                "DIM-1r.-1.0.mcr",
                "DIM-1r.-1.-1.mcr",

                "r.0.0.mcr",
                "r.0.-1.mcr",
                "r.-1.0.mcr",
                "r.-1.-1.mcr"
            };

            foreach (var file in allowedFiles)
            {
                string sourcePath = Path.Combine(sourceDir, file);
                string targetPath = Path.Combine(targetDir, file);

                if (File.Exists(sourcePath))
                {
                    Console.WriteLine($"Copying: {file}");
                    File.Copy(sourcePath, targetPath, true);
                }
            }
        }

        // ==================== COPY DIM1 ====================
        private static void CopyDIM1Folder(string sourceRoot, string targetRoot)
        {
            string sourceDIM1 = Path.Combine(sourceRoot, "DIM1");
            string targetDIM1 = Path.Combine(targetRoot, "DIM1");

            if (!Directory.Exists(sourceDIM1))
            {
                Console.WriteLine("DIM1 folder not found.");
                return;
            }

            Directory.CreateDirectory(targetDIM1);

            var files = Directory.GetFiles(sourceDIM1, "*.mcr", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(targetDIM1, name);

                Console.WriteLine($"Copying DIM1: {name}");

                File.Copy(file, dest, true);
            }
        }

        // ==================== COMPILE ====================
        private static void CompileAll(string root, string output)
        {
            string[] validFolders = new string[]
            {
                "DIM-1r.0.0", "DIM-1r.0.-1", "DIM-1r.-1.0", "DIM-1r.-1.-1",
                "DIM1r.0.0", "DIM1r.0.-1", "DIM1r.-1.0", "DIM1r.-1.-1",

                Path.Combine("DIM-1", "r.0.0"),
                Path.Combine("DIM-1", "r.0.-1"),
                Path.Combine("DIM-1", "r.-1.0"),
                Path.Combine("DIM-1", "r.-1.-1"),

                Path.Combine("DIM1", "r.0.0"),
                Path.Combine("DIM1", "r.0.-1"),
                Path.Combine("DIM1", "r.-1.0"),
                Path.Combine("DIM1", "r.-1.-1"),

                "r.0.0", "r.0.-1", "r.-1.0", "r.-1.-1"
            };

            foreach (var relative in validFolders)
            {
                string fullPath = Path.Combine(root, relative);

                if (!Directory.Exists(fullPath))
                    continue;

                var chunks = Directory.GetFiles(fullPath, "chunk_*");

                if (chunks.Length == 0)
                    continue;

                string outFile = Path.Combine(output, relative + ".mcr");

                string dir = Path.GetDirectoryName(outFile);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                Console.WriteLine($"Compiling: {outFile}");

                RebuildMCR(fullPath, outFile);
            }
        }

        private static void RebuildMCR(string folder, string outFile)
        {
            var files = Directory.GetFiles(folder, "chunk_*")
                .OrderBy(f => GetChunkIndex(f))
                .ToList();

            using (var bw = new BinaryWriter(File.Open(outFile, FileMode.Create)))
            {
                bw.Write(new byte[8192]);

                var entries = new List<(int idx, uint offset, byte len)>();

                foreach (var file in files)
                {
                    int idx = GetChunkIndex(file);
                    byte[] data = File.ReadAllBytes(file);

                    long start = bw.BaseStream.Position;

                    bw.Write(data);

                    int padding = (4096 - (int)(bw.BaseStream.Position % 4096)) % 4096;
                    if (padding > 0)
                        bw.Write(new byte[padding]);

                    int sectors = (int)Math.Ceiling((data.Length + padding) / 4096.0);

                    entries.Add((idx, (uint)(start / 4096), (byte)sectors));
                }

                bw.BaseStream.Position = 0;

                for (int i = 0; i < 1024; i++)
                {
                    var entry = entries.FirstOrDefault(e => e.idx == i);

                    if (entry.len != 0)
                    {
                        bw.Write((byte)((entry.offset >> 16) & 0xFF));
                        bw.Write((byte)((entry.offset >> 8) & 0xFF));
                        bw.Write((byte)(entry.offset & 0xFF));
                        bw.Write(entry.len);
                    }
                    else
                    {
                        bw.Write(new byte[4]);
                    }
                }
            }
        }

        private static int GetChunkIndex(string path)
        {
            string name = Path.GetFileNameWithoutExtension(path);
            string[] parts = name.Split('_');

            if (parts.Length < 2)
                return 0;

            if (int.TryParse(parts[1], out int index))
                return index;

            return 0;
        }
    }
}