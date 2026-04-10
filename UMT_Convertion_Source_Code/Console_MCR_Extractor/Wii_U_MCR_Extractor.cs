using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WiiUMCRTool
{
    class Program
    {
        [DllImport("zlib1.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int uncompress(byte[] dest, ref uint destLen, byte[] source, uint sourceLen);

        static void Main(string[] args)
        {
            Console.WriteLine("=== Wii U MCR AUTO TOOL ===");

            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "UMT_Cracked_Convertion");

            if (!Directory.Exists(basePath))
            {
                Console.WriteLine("UMT_Cracked_Convertion folder NOT found. Stopping.");
                return;
            }

            // Find latest Wii folder
            var wiiFolders = Directory.GetDirectories(basePath)
                .Where(d => Path.GetFileName(d).Contains("_Wii_"))
                .OrderByDescending(d => d)
                .ToArray();

            if (wiiFolders.Length == 0)
            {
                Console.WriteLine("No Wii folders found. STOPPING.");
                return;
            }

            string latestFolder = wiiFolders[0];
            Console.WriteLine($"Using latest folder: {Path.GetFileName(latestFolder)}");

            string outputRoot = Path.Combine(latestFolder, "MCR_OUTPUT");
            Directory.CreateDirectory(outputRoot);

            string[] targetFiles =
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

            int total = 0;

            foreach (var relPath in targetFiles)
            {
                string fullPath = Path.Combine(latestFolder, relPath);

                if (!File.Exists(fullPath))
                {
                    Console.WriteLine($"Skipping missing: {relPath}");
                    continue;
                }

                Console.WriteLine($"Processing: {relPath}");

                string outFolder = Path.Combine(outputRoot, Path.GetFileNameWithoutExtension(relPath));
                Directory.CreateDirectory(outFolder);

                byte[] mcrData = File.ReadAllBytes(fullPath);

                // PAD ONLY IF SMALLER
                if (mcrData.Length < 4096)
                {
                    Array.Resize(ref mcrData, 4096);
                }

                File.WriteAllBytes(fullPath, mcrData);

                ExtractMCR(fullPath, outFolder);
                total++;
            }

            Console.WriteLine($"\nDONE. Processed {total} files.");
            Console.ReadKey();
        }

        static void ExtractMCR(string path, string outFolder)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] locTable = new byte[4096];
                fs.Read(locTable, 0, 4096);

                for (int i = 0; i < 1024; i++)
                {
                    int offset = (locTable[i * 4] << 16) | (locTable[i * 4 + 1] << 8) | locTable[i * 4 + 2];
                    int sectors = locTable[i * 4 + 3];
                    if (offset == 0 || sectors == 0) continue;

                    long pos = (long)offset * 4096;
                    int length = sectors * 4096;

                    if (pos + length > fs.Length) continue;

                    byte[] rawChunk = new byte[length];
                    fs.Position = pos;
                    fs.Read(rawChunk, 0, length);

                    try
                    {
                        // SAVE HEADER (BYTE 6 & 7 ONLY)
                        byte[] header = new byte[2];
                        header[0] = rawChunk[6];
                        header[1] = rawChunk[7];

                        File.WriteAllBytes(Path.Combine(outFolder, $"chunk_{i}_header.bin"), header);

                        // DECOMPRESS → NBT
                        byte[] nbt = Decompress(rawChunk);

                        if (nbt != null && nbt.Length > 0)
                        {
                            File.WriteAllBytes(Path.Combine(outFolder, $"chunk_{i}.nbt"), nbt);
                        }
                    }
                    catch { }
                }
            }
        }

        static byte[] Decompress(byte[] raw)
        {
            int compSize = (raw[1] << 16) | (raw[2] << 8) | raw[3];

            if (compSize <= 0 || compSize > raw.Length - 8)
                return null;

            byte[] comp = new byte[compSize];
            Array.Copy(raw, 8, comp, 0, compSize);

            uint destLen = (uint)(compSize * 50);
            byte[] dest = new byte[destLen];

            int res = uncompress(dest, ref destLen, comp, (uint)comp.Length);
            if (res != 0) return null;

            byte[] final = new byte[destLen];
            Array.Copy(dest, final, destLen);

            return final;
        }
    }
}