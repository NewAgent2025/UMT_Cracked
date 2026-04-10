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
            while (true) // LOOP FOREVER UNTIL EXIT
            {
                Console.Clear();
                Console.WriteLine("=== Xbox 360 MCR Tool (SAFE VERSION) ===");

                Console.WriteLine("1. Extract ALL .mcr");
                Console.WriteLine("2. Compile ALL chunk folders");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");

                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                if (option == 3)
                {
                    Console.WriteLine("Exiting...");
                    break; // EXIT PROGRAM
                }

                Console.Write("Enter world folder: ");
                string root = Console.ReadLine().Trim('"');

                if (!Directory.Exists(root))
                {
                    Console.WriteLine("Folder not found.");
                    Console.ReadKey();
                    continue;
                }

                string output = Path.Combine(root, "MCR_OUTPUT");
                Directory.CreateDirectory(output);

                if (option == 1)
                    ExtractAll(root, output);
                else if (option == 2)
                    CompileAll(root, output);

                Console.WriteLine("Done!");
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
            }
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
            var folders = Directory.GetDirectories(root, "*", SearchOption.AllDirectories);

            foreach (var folder in folders)
            {
                var chunks = Directory.GetFiles(folder, "chunk_*");

                if (chunks.Length == 0)
                    continue;

                string outFile = Path.Combine(output, Path.GetFileName(folder) + ".mcr");

                Console.WriteLine($"Compiling: {outFile}");

                RebuildMCR(folder, outFile);
            }
        }

        private static void RebuildMCR(string folder, string outFile)
        {
            var files = Directory.GetFiles(folder, "chunk_*")
                .OrderBy(f => GetChunkIndex(f))
                .ToList();

            using (var bw = new BinaryWriter(File.Open(outFile, FileMode.Create)))
            {
                // Reserve header
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

                // Write header table
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