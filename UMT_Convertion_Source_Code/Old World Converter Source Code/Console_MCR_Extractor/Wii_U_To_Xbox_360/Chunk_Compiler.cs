using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Xbox360MCRTool
{
    class Program
    {
        public class XBOXCompression
        {
            [DllImport("XDecompress32", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Compress(IntPtr inArray, int inSize, out IntPtr outArray, out int outSize);

            [DllImport("XDecompress64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Compress")]
            public static extern void Compress_1(IntPtr inArray, int inSize, out IntPtr outArray, out int outSize);

            [DllImport("XDecompress32", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Decompress(IntPtr byteArray, int size, out IntPtr outArray, out int outSize);

            [DllImport("XDecompress64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Decompress")]
            public static extern void Decompress_1(IntPtr byteArray, int size, out IntPtr outArray, out int outSize);

            [DllImport("XDecompress32", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Release(ref IntPtr array);

            [DllImport("XDecompress64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Release")]
            public static extern void Release_1(ref IntPtr array);

            public byte[] Compress(byte[] data)
            {
                IntPtr inPtr = Marshal.AllocHGlobal(data.Length);
                Marshal.Copy(data, 0, inPtr, data.Length);

                IntPtr outPtr;
                int outSize;

                if (Environment.Is64BitProcess)
                    Compress_1(inPtr, data.Length, out outPtr, out outSize);
                else
                    Compress(inPtr, data.Length, out outPtr, out outSize);

                Marshal.FreeHGlobal(inPtr);

                byte[] result = new byte[outSize];
                Marshal.Copy(outPtr, result, 0, outSize);

                if (Environment.Is64BitProcess)
                    Release_1(ref outPtr);
                else
                    Release(ref outPtr);

                return result;
            }
        }

        static readonly XBOXCompression xbox = new XBOXCompression();

        static void Main(string[] args)
        {
            Console.WriteLine("=== AUTO NBT → BIN BUILDER (HEADER INJECTED + SIZE FIX) ===");

            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UMT_Cracked_Convertion");

            Console.WriteLine($"Base Path: {basePath}");

            if (!Directory.Exists(basePath))
            {
                Console.WriteLine("UMT_Cracked_Convertion folder NOT FOUND!");
                return;
            }

            var newestFolder = Directory.GetDirectories(basePath, "*_Wii_*")
                .Select(d => new DirectoryInfo(d))
                .OrderByDescending(d => d.CreationTime)
                .FirstOrDefault();

            if (newestFolder == null)
            {
                Console.WriteLine("No Wii folders found!");
                return;
            }

            Console.WriteLine($"Using NEWEST folder: {newestFolder.FullName}");

            string mcrOutput = Path.Combine(newestFolder.FullName, "MCR_OUTPUT");

            if (!Directory.Exists(mcrOutput))
            {
                Console.WriteLine("MCR_OUTPUT folder NOT FOUND!");
                return;
            }

            string[] allowedFolders = new string[]
            {
                @"DIM-1r.0.0", @"DIM-1r.0.-1", @"DIM-1r.-1.0", @"DIM-1r.-1.-1",
                @"r.0.0", @"r.0.-1", @"r.-1.0", @"r.-1.-1",
                @"DIM1\r.0.0", @"DIM1\r.0.-1", @"DIM1\r.-1.0", @"DIM1\r.-1.-1"
            };

            bool foundAny = false;

            foreach (var folder in allowedFolders)
            {
                string fullPath = Path.Combine(mcrOutput, folder);

                if (!Directory.Exists(fullPath))
                    continue;

                var nbtFiles = Directory.GetFiles(fullPath, "*.nbt", SearchOption.TopDirectoryOnly);

                Console.WriteLine($"Scanning: {fullPath}");
                Console.WriteLine($"NBT Files Found: {nbtFiles.Length}");

                if (nbtFiles.Length == 0)
                    continue;

                foundAny = true;

                foreach (var nbtFile in nbtFiles)
                {
                    try
                    {
                        byte[] nbt = File.ReadAllBytes(nbtFile);
                        byte[] bin = CompressXboxChunk(nbt);

                        string outFile = Path.ChangeExtension(nbtFile, ".bin");

                        string fileName = Path.GetFileNameWithoutExtension(nbtFile);

                        string headerFile = Path.Combine(
                            Path.GetDirectoryName(nbtFile),
                            fileName + "_header.bin"
                        );

                        // =========================
                        // HEADER INJECTION
                        // =========================
                        if (File.Exists(headerFile))
                        {
                            byte[] headerData = File.ReadAllBytes(headerFile);

                            if (headerData.Length >= 2 && bin.Length >= 8)
                            {
                                bin[6] = headerData[0];
                                bin[7] = headerData[1];

                                Console.WriteLine($"✔ Header injected: {fileName}");
                            }
                            else
                            {
                                Console.WriteLine($"✖ Header too small or BIN too small: {fileName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"⚠ Missing header: {fileName}_header.bin");
                        }

                        // =========================
                        // SIZE FIX (4096 BYTES)
                        // =========================
                        if (bin.Length < 4096)
                        {
                            byte[] padded = new byte[4096];
                            Buffer.BlockCopy(bin, 0, padded, 0, bin.Length);
                            bin = padded;

                            Console.WriteLine($"📦 Padded to 4096 bytes: {fileName}");
                        }
                        else
                        {
                            Console.WriteLine($"📦 Kept original size ({bin.Length} bytes): {fileName}");
                        }

                        // =========================
                        // SAVE FINAL BIN
                        // =========================
                        File.WriteAllBytes(outFile, bin);

                        // =========================
                        // DELETE TEMP FILES
                        // =========================
                        if (File.Exists(headerFile))
                        {
                            File.Delete(headerFile);
                            Console.WriteLine($"🗑 Deleted: {fileName}_header.bin");
                        }

                        if (File.Exists(nbtFile))
                        {
                            File.Delete(nbtFile);
                            Console.WriteLine($"🗑 Deleted: {fileName}.nbt");
                        }

                        Console.WriteLine($"✔ Finalized: {fileName}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"✖ Error: {nbtFile}");
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("⚠ No NBT files found.");
            }

            Console.WriteLine("DONE.");
        }

        // ==================== NBT → BIN ====================
        private static byte[] CompressXboxChunk(byte[] nbt)
        {
            byte[] compressed = xbox.Compress(nbt);

            byte[] result = new byte[8 + compressed.Length];

            int compSize = compressed.Length;
            int uncompressedSize = nbt.Length;

            result[0] = 0xC0;
            result[1] = (byte)((compSize >> 16) & 0xFF);
            result[2] = (byte)((compSize >> 8) & 0xFF);
            result[3] = (byte)(compSize & 0xFF);

            result[4] = (byte)((uncompressedSize >> 24) & 0xFF);
            result[5] = (byte)((uncompressedSize >> 16) & 0xFF);
            result[6] = (byte)((uncompressedSize >> 8) & 0xFF);
            result[7] = (byte)(uncompressedSize & 0xFF);

            Buffer.BlockCopy(compressed, 0, result, 8, compressed.Length);

            // Trim trailing zeros
            int newLength = result.Length;
            while (newLength > 0 && result[newLength - 1] == 0x00)
                newLength--;

            byte[] trimmed = new byte[newLength];
            Buffer.BlockCopy(result, 0, trimmed, 0, newLength);

            return trimmed;
        }
    }
}