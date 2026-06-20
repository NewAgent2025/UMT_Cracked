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
            Console.WriteLine("=== AUTO NBT → BIN BUILDER (PS3 NEWEST ONLY) ===");

            // =========================
            // BASE PATH (EXE LOCATION)
            // =========================
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UMT_Cracked_Convertion");

            Console.WriteLine($"Base Path: {basePath}");

            if (!Directory.Exists(basePath))
            {
                Console.WriteLine("UMT_Cracked_Convertion folder NOT FOUND!");
                return;
            }

            // =========================
            // FIND NEWEST PS3 FOLDER
            // =========================
            var newestFolder = Directory.GetDirectories(basePath, "GAMEDATA*_PS3_*")
                .Select(d => new DirectoryInfo(d))
                .OrderByDescending(d => d.CreationTime)
                .FirstOrDefault();

            if (newestFolder == null)
            {
                Console.WriteLine("No PS3 folders found!");
                return;
            }

            Console.WriteLine($"Using NEWEST folder: {newestFolder.FullName}");

            // =========================
            // FIXED MCR_OUTPUT PATH (INSIDE NEWEST FOLDER)
            // =========================
            string mcrOutput = Path.Combine(newestFolder.FullName, "MCR_OUTPUT");

            Console.WriteLine($"MCR Output: {mcrOutput}");

            if (!Directory.Exists(mcrOutput))
            {
                Console.WriteLine("MCR_OUTPUT folder NOT FOUND inside newest PS3 folder!");
                return;
            }

            // =========================
            // ONLY THESE FOLDERS
            // =========================
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
                        File.WriteAllBytes(outFile, bin);

                        Console.WriteLine($"✔ Converted: {Path.GetFileName(nbtFile)}");
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
                Console.WriteLine("⚠ No NBT files found in allowed folders.");
            }

            Console.WriteLine("DONE.");
            Console.ReadKey();
        }

        // ==================== NBT → BIN ====================
        private static byte[] CompressXboxChunk(byte[] nbt)
        {
            byte[] compressed = xbox.Compress(nbt);

            byte[] result = new byte[8 + compressed.Length];

            int compSize = compressed.Length;
            int uncompressedSize = nbt.Length;

            // Header
            result[0] = 0xC0;
            result[1] = (byte)((compSize >> 16) & 0xFF);
            result[2] = (byte)((compSize >> 8) & 0xFF);
            result[3] = (byte)(compSize & 0xFF);

            result[4] = (byte)((uncompressedSize >> 24) & 0xFF);
            result[5] = (byte)((uncompressedSize >> 16) & 0xFF);
            result[6] = (byte)((uncompressedSize >> 8) & 0xFF);
            result[7] = (byte)(uncompressedSize & 0xFF);

            Buffer.BlockCopy(compressed, 0, result, 8, compressed.Length);

            // =========================
            // 🔥 REMOVE TRAILING 0x00
            // =========================
            int newLength = result.Length;

            while (newLength > 0 && result[newLength - 1] == 0x00)
                newLength--;

            byte[] trimmed = new byte[newLength];
            Buffer.BlockCopy(result, 0, trimmed, 0, newLength);

            return trimmed;
        }
    }
}