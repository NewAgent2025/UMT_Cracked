using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WiiUMCRTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Wii U MCR AUTO TOOL (EXTRACT ONLY) ===");

            string root = Path.Combine(Directory.GetCurrentDirectory(), "UMT_Cracked_Convertion");

            if (!Directory.Exists(root))
            {
                Console.WriteLine("UMT_Cracked_Convertion folder not found. STOPPING.");
                return;
            }

            // Find Wii folders
            var wiiFolders = Directory.GetDirectories(root)
                .Where(d => Path.GetFileName(d).Contains("_Wii_"))
                .OrderByDescending(d => d)
                .ToList();

            if (wiiFolders.Count == 0)
            {
                Console.WriteLine("No _Wii folders found. STOPPING.");
                return;
            }

            string newestFolder = wiiFolders.First();
            Console.WriteLine($"Using newest folder: {Path.GetFileName(newestFolder)}");

            string outputFolder = Path.Combine(newestFolder, "MCR_OUTPUT");
            Directory.CreateDirectory(outputFolder);

            // Allowed files
            string[] files =
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

            string[] dim1Files =
            {
                Path.Combine("DIM1", "r.0.0.mcr"),
                Path.Combine("DIM1", "r.0.-1.mcr"),
                Path.Combine("DIM1", "r.-1.0.mcr"),
                Path.Combine("DIM1", "r.-1.-1.mcr")
            };

            List<string> allTargets = new List<string>();
            allTargets.AddRange(files);
            allTargets.AddRange(dim1Files);

            int processed = 0;

            foreach (var relativePath in allTargets)
            {
                string fullPath = Path.Combine(newestFolder, relativePath);

                if (!File.Exists(fullPath))
                {
                    Console.WriteLine($"Skipping missing: {relativePath}");
                    continue;
                }

                Console.WriteLine($"Processing: {relativePath}");

                string outDir = Path.Combine(outputFolder,
                    Path.GetDirectoryName(relativePath) ?? "",
                    Path.GetFileNameWithoutExtension(relativePath));

                Directory.CreateDirectory(outDir);

                ProcessMCR(fullPath, outDir);
                processed++;
            }

            if (processed == 0)
            {
                Console.WriteLine("No valid MCR files found. STOPPING.");
                return;
            }

            Console.WriteLine("\nDONE.");
            Console.ReadKey();
        }

        static void ProcessMCR(string path, string outDir)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] locTable = new byte[4096];
                fs.Read(locTable, 0, 4096);

                for (int i = 0; i < 1024; i++)
                {
                    int offset = (locTable[i * 4] << 16) | (locTable[i * 4 + 1] << 8) | locTable[i * 4 + 2];
                    int sectors = locTable[i * 4 + 3];

                    if (offset == 0 || sectors == 0)
                        continue;

                    long pos = offset * 4096L;
                    int length = sectors * 4096;

                    if (pos + length > fs.Length)
                        continue;

                    byte[] chunk = new byte[length];
                    fs.Position = pos;
                    fs.Read(chunk, 0, length);

                    // === SIZE FIX ===
                    if (chunk.Length < 4096)
                    {
                        Array.Resize(ref chunk, 4096);
                    }

                    string chunkFile = Path.Combine(outDir, $"chunk_{i}.bin");
                    File.WriteAllBytes(chunkFile, chunk);

                    // === HEADER (BYTE 6 & 7) ===
                    if (chunk.Length >= 8)
                    {
                        byte[] headerBytes = new byte[2];
                        headerBytes[0] = chunk[6];
                        headerBytes[1] = chunk[7];

                        string headerFile = Path.Combine(outDir, $"chunk_{i}_header.bin");
                        File.WriteAllBytes(headerFile, headerBytes);
                    }
                }
            }
        }
    }
}