using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace PS3MCRTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PS3 MCR Extractor (AUTO+STRICT MODE) ===");

            string inputFolder = "";

            // =========================
            // COMMAND LINE MODE
            // =========================
            if (args.Length >= 2 && args[0].ToLower() == "-d")
            {
                inputFolder = args[1].Trim('"');
                Console.WriteLine("Mode: Command Line (-d)");
                Console.WriteLine("Input: " + inputFolder);
            }
            else
            {
                // =========================
                // AUTO DETECT MODE
                // =========================
                string baseFolder = "UMT_Cracked_Convertion";

                if (!Directory.Exists(baseFolder))
                {
                    Console.WriteLine("❌ Base folder not found: " + baseFolder);
                    return;
                }

                var ps3Folders = Directory.GetDirectories(baseFolder)
                    .Where(d => Path.GetFileName(d).Contains("_PS3"))
                    .Select(d => new DirectoryInfo(d))
                    .OrderByDescending(d => d.CreationTime)
                    .ToList();

                if (ps3Folders.Count == 0)
                {
                    Console.WriteLine("❌ No _PS3 folders found.");
                    return;
                }

                inputFolder = ps3Folders.First().FullName;

                Console.WriteLine("✔ Auto-selected newest folder:");
                Console.WriteLine(inputFolder);
            }

            // =========================
            // SAFETY CHECK
            // =========================
            if (!Directory.Exists(inputFolder))
            {
                Console.WriteLine("❌ Folder does NOT exist. Program stopping.");
                return;
            }

            // =========================
            // STRICT FILE LIST
            // =========================
            string[] requiredFiles = new string[]
            {
                "DIM-1r.0.0.mcr",
                "DIM-1r.0.-1.mcr",
                "DIM-1r.-1.0.mcr",
                "DIM-1r.-1.-1.mcr",
                "r.0.0.mcr",
                "r.0.-1.mcr",
                "r.-1.0.mcr",
                "r.-1.-1.mcr",

                @"DIM1\r.0.0.mcr",
                @"DIM1\r.0.-1.mcr",
                @"DIM1\r.-1.0.mcr",
                @"DIM1\r.-1.-1.mcr"
            };

            List<string> foundMcrFiles = new List<string>();

            foreach (var file in requiredFiles)
            {
                string fullPath = Path.Combine(inputFolder, file);

                if (File.Exists(fullPath))
                {
                    foundMcrFiles.Add(fullPath);
                }
                else
                {
                    Console.WriteLine("❌ Missing required file: " + file);
                }
            }

            if (foundMcrFiles.Count != requiredFiles.Length)
            {
                Console.WriteLine("\n❌ Not all required MCR files were found. Program stopping.");
                return;
            }

            Console.WriteLine($"\n✔ All required MCR files found ({foundMcrFiles.Count}). Starting extraction...");

            ExtractMode(inputFolder, foundMcrFiles);

            Console.WriteLine("\n✔ Done!");
            Environment.Exit(0);
        }

        // =========================
        // EXTRACT MODE
        // =========================
        static void ExtractMode(string inputFolder, List<string> mcrFiles)
        {
            string outputRoot = Path.Combine(inputFolder, "MCR_OUTPUT");

            foreach (var mcr in mcrFiles)
            {
                string relative = mcr.Replace(inputFolder, "").TrimStart('\\');

                string dirPart = Path.GetDirectoryName(relative);
                string name = Path.GetFileNameWithoutExtension(mcr);

                string outFolder = string.IsNullOrEmpty(dirPart)
                    ? Path.Combine(outputRoot, name)
                    : Path.Combine(outputRoot, dirPart, name);

                Directory.CreateDirectory(outFolder);

                Console.WriteLine("\nExtracting: " + mcr);

                try
                {
                    ExtractMCR(mcr, outFolder);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Failed: " + ex.Message);
                }
            }
        }

        static void ExtractMCR(string mcrPath, string outFolder)
        {
            byte[] table = new byte[4096];

            using (FileStream fs = new FileStream(mcrPath, FileMode.Open, FileAccess.Read))
            {
                if (fs.Length < 4096)
                {
                    Console.WriteLine("❌ Invalid MCR (too small)");
                    return;
                }

                fs.Read(table, 0, 4096);

                for (int i = 0; i < 1024; i++)
                {
                    int offset = (table[i * 4] << 16) | (table[i * 4 + 1] << 8) | table[i * 4 + 2];
                    int length = table[i * 4 + 3];

                    if (offset <= 0 || length <= 0)
                        continue;

                    long byteOffset = offset * 4096L;
                    long byteLength = length * 4096L;

                    if (byteOffset + byteLength > fs.Length)
                        continue;

                    fs.Position = byteOffset;

                    byte[] raw = new byte[byteLength];
                    fs.Read(raw, 0, raw.Length);

                    // ==============================
                    // CREATE HEADER BIN FILE
                    // ==============================
                    // ==============================
                    // CREATE HEADER BIN (ONLY BYTE 6 & 7)
                    // ==============================
                    string binFile = Path.Combine(outFolder, $"chunk_{i}_header.bin");

                    if (raw.Length > 7)
                    {
                        byte[] headerBytes = new byte[2];
                        headerBytes[0] = raw[6];
                        headerBytes[1] = raw[7];

                        File.WriteAllBytes(binFile, headerBytes);
                    }
                    else
                    {
                        Console.WriteLine($"⚠️ Chunk {i} too small for header bytes.");
                    }

                    // ==============================
                    // CREATE NBT FILE
                    // ==============================
                    byte[] data = DecompressPS3Chunk(raw);

                    string outFile = Path.Combine(outFolder, $"chunk_{i}.nbt");
                    File.WriteAllBytes(outFile, data);

                    Console.WriteLine("✔ Chunk " + i);
                }
            }
        }

        // =========================
        // DECOMPRESS
        // =========================
        static byte[] DecompressPS3Chunk(byte[] raw)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(raw))
                {
                    byte[] header = new byte[12];
                    ms.Read(header, 0, 12);

                    int compSize = GetBEInt(header, 0) & 0xFFFFFF;

                    if (compSize <= 0 || compSize > raw.Length)
                        return new byte[0];

                    byte[] comp = new byte[compSize];
                    ms.Read(comp, 0, compSize);

                    using (DeflateStream ds = new DeflateStream(new MemoryStream(comp), CompressionMode.Decompress))
                    using (MemoryStream outMs = new MemoryStream())
                    {
                        ds.CopyTo(outMs);
                        return outMs.ToArray();
                    }
                }
            }
            catch
            {
                return new byte[0];
            }
        }

        static int GetBEInt(byte[] d, int o)
        {
            byte[] b = new byte[4];
            Array.Copy(d, o, b, 0, 4);
            if (BitConverter.IsLittleEndian) Array.Reverse(b);
            return BitConverter.ToInt32(b, 0);
        }
    }
}