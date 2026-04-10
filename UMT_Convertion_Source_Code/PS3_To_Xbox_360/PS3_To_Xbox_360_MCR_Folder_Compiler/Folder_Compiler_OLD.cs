using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Xbox360MCRTool
{
    class Program
    {
        // ==================== MAIN ====================
        static void Main(string[] args)
        {
            Console.WriteLine("=== Xbox 360 MCR Tool (SAFE VERSION) ===");

            Console.WriteLine("1. Extract ALL .mcr");
            Console.WriteLine("2. Compile ONLY region folders");
            Console.Write("Choose: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
                return;

            Console.Write("Enter world folder: ");
            string root = Console.ReadLine().Trim('"');

            if (!Directory.Exists(root))
            {
                Console.WriteLine("Folder not found.");
                return;
            }

            // ==================== FIX OUTPUT PATH ====================
            string baseOutput;

            if (Path.GetFileName(root).Equals("MCR_OUTPUT", StringComparison.OrdinalIgnoreCase))
            {
                baseOutput = root;
            }
            else
            {
                baseOutput = Path.Combine(root, "MCR_OUTPUT");
            }

            string output = Path.Combine(baseOutput, "MCR_OUTPUT");

            Directory.CreateDirectory(output);

            // ==================== RUN ====================
            if (option == 1)
                ExtractAll(root, output);
            else if (option == 2)
                CompileAll(root, output);
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        // ==================== EXTRACT ====================
        private static void ExtractAll(string root, string output)
        {
            var files = Directory.GetFiles(root, "*.mcr", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine($"Extracting: {file}");

                string outFolder = Path.Combine(output, Path.GetFileNameWithoutExtension(file));
                Directory.CreateDirectory(outFolder);

                ExtractMCR(file, outFolder);
            }
        }

        private static void ExtractMCR(string mcrPath, string outFolder)
        {
            using (var fs = new FileStream(mcrPath, FileMode.Open))
            {
                byte[] table = new byte[4096];
                fs.Read(table, 0, 4096);

                for (int i = 0; i < 1024; i++)
                {
                    int offset = (table[i * 4] << 16) | (table[i * 4 + 1] << 8) | table[i * 4 + 2];
                    int length = table[i * 4 + 3];

                    if (offset == 0 || length == 0)
                        continue;

                    byte[] chunk = new byte[length * 4096];

                    fs.Position = offset * 4096L;
                    fs.Read(chunk, 0, chunk.Length);

                    File.WriteAllBytes(Path.Combine(outFolder, $"chunk_{i}.bin"), chunk);
                }
            }
        }

        // ==================== COMPILE ====================
        private static void CompileAll(string root, string output)
        {
            string[] validFolders = new string[]
            {
                // ===== YOUR FORMAT (NO SLASH) =====
                "DIM-1r.0.0", "DIM-1r.0.-1", "DIM-1r.-1.0", "DIM-1r.-1.-1",
                "DIM1r.0.0", "DIM1r.0.-1", "DIM1r.-1.0", "DIM1r.-1.-1",

                // ===== NORMAL FORMAT =====
                Path.Combine("DIM-1", "r.0.0"),
                Path.Combine("DIM-1", "r.0.-1"),
                Path.Combine("DIM-1", "r.-1.0"),
                Path.Combine("DIM-1", "r.-1.-1"),

                Path.Combine("DIM1", "r.0.0"),
                Path.Combine("DIM1", "r.0.-1"),
                Path.Combine("DIM1", "r.-1.0"),
                Path.Combine("DIM1", "r.-1.-1"),

                // ===== ROOT =====
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

                // 🔥 FIX: CLEAN OUTPUT PATH (NO DOUBLE OUTPUT FOLDER BUG)
                string outFile = Path.Combine(output, relative + ".mcr");

                string outDir = Path.GetDirectoryName(outFile);
                if (!Directory.Exists(outDir))
                    Directory.CreateDirectory(outDir);

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
                // Reserve header (8KB)
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

                // Write header
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

        // ==================== HELPERS ====================
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