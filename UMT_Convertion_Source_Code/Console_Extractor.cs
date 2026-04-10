using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    // =========================
    // ZLIB (WII U)
    // =========================
    [DllImport("zlib1.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int uncompress(byte[] dest, ref uint destLen, byte[] source, uint sourceLen);

    // =========================
    // DECOMPRESSION
    // =========================
    static byte[] DecompressZlibDynamic(byte[] data)
    {
        for (int multiplier = 10; multiplier <= 100; multiplier += 10)
        {
            try
            {
                uint outputSize = (uint)(data.Length * multiplier);
                byte[] output = new byte[outputSize];

                int result = uncompress(output, ref outputSize, data, (uint)data.Length);

                if (result == 0)
                {
                    byte[] final = new byte[outputSize];
                    Array.Copy(output, final, outputSize);
                    Console.WriteLine($"Decompressed x{multiplier}");
                    return final;
                }
            }
            catch { }
        }

        throw new Exception("ZLIB decompression failed.");
    }

    static byte[] HandleZLib(byte[] data)
    {
        for (int i = 0; i < data.Length - 2; i++)
        {
            if (data[i] == 0x78 && (data[i + 1] == 0x9C || data[i + 1] == 0xDA))
            {
                Console.WriteLine($"ZLIB @ 0x{i:X}");

                byte[] sliced = new byte[data.Length - i];
                Array.Copy(data, i, sliced, 0, sliced.Length);

                return DecompressZlibDynamic(sliced);
            }
        }

        throw new Exception("ZLIB not found.");
    }

    // =========================
    // RAW HANDLING
    // =========================
    static FileStream CheckSaveGame(string filePath, string rawDir, out string rawPath)
    {
        rawPath = null;

        byte[] data = File.ReadAllBytes(filePath);

        string hex = BitConverter.ToString(data, 0, Math.Min(16, data.Length))
            .Replace("-", "").ToLower();

        if (hex.Contains("78"))
        {
            Console.WriteLine("Trying Wii U decompress...");

            try
            {
                byte[] decompressed = HandleZLib(data);

                string baseName = Path.GetFileNameWithoutExtension(filePath);
                string newFile = Path.Combine(rawDir, baseName + "_RAW.dat");

                File.WriteAllBytes(newFile, decompressed);

                rawPath = newFile;
                Console.WriteLine("RAW saved: " + newFile);

                return new FileStream(newFile, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                Console.WriteLine("Not ZLIB, using raw...");
            }
        }

        rawPath = filePath;
        return new FileStream(filePath, FileMode.Open, FileAccess.Read);
    }

    // =========================
    // MAIN
    // =========================
    static void Main(string[] args)
    {
        if (args.Length >= 3 && args[0].Equals("-d", StringComparison.OrdinalIgnoreCase))
        {
            if (!int.TryParse(args[1], out int platform) || platform < 1 || platform > 3)
            {
                Console.WriteLine("Invalid platform. Use: 1 = Xbox 360, 2 = PS3, 3 = Wii U");
                return;
            }

            string inputFile = args[2];

            if (!File.Exists(inputFile))
            {
                Console.WriteLine("File not found: " + inputFile);
                return;
            }

            RunCommandLineDecompile(platform, inputFile);
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Minecraft Console Extractor Tool Made By NewAgent ====");
            Console.WriteLine("1. Extractor");
            Console.WriteLine("3. Exit");

            Console.Write("\nChoice: ");
            string choice = Console.ReadLine();

            if (choice == "3") break;

            try
            {
                if (choice == "1") RunExtractor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }

    // =========================
    // COMMAND MODE
    // =========================
    static void RunCommandLineDecompile(int platform, string inputFile)
    {
        string fileName = Path.GetFileNameWithoutExtension(inputFile);
        string safeName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));

        string platformTag;

        switch (platform)
        {
            case 1:
                platformTag = "_X360";
                break;
            case 2:
                platformTag = "_PS3";
                break;
            case 3:
                platformTag = "_Wii";
                break;
            default:
                platformTag = "_UNKNOWN";
                break;
        }

        string baseDir = Path.Combine(
            "UMT_Cracked_Convertion",
            $"{safeName}{platformTag}_{DateTime.Now:yyyyMMdd_HHmmss}"
        );

        Directory.CreateDirectory(baseDir);

        string rawDir = Path.Combine("UMT_Cracked_Convertion", "RAW_Files");
        Directory.CreateDirectory(rawDir);

        Console.WriteLine($"Decompiling for platform {platform} → {baseDir}");

        if (platform == 1)
            RunXboxExtract(inputFile, baseDir, rawDir);
        else if (platform == 2)
            DecodeRaw(inputFile, true, baseDir);
        else if (platform == 3)
            ExtractWiiU(inputFile, baseDir, rawDir);

        Console.WriteLine("Done! Output folder: " + baseDir);
    }

    static void RunExtractor()
    {
        Console.WriteLine("\n1. Xbox 360\n2. PS3\n3. Wii U");
        string platformStr = Console.ReadLine();

        if (!int.TryParse(platformStr, out int platform) || platform < 1 || platform > 3)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Console.Write("Input file: ");
        string inputFile = Console.ReadLine();

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("File not found.");
            return;
        }

        RunCommandLineDecompile(platform, inputFile);
    }

    // =========================
    // XBOX 360
    // =========================
    static void RunXboxExtract(string inputFile, string output, string rawDir)
    {
        string raw = Path.Combine(rawDir, Guid.NewGuid() + ".dat");

        Console.WriteLine("Running X360.exe decompile...");

        var psi = new ProcessStartInfo
        {
            FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "X360.exe"),
            Arguments = $"-d \"{inputFile}\" \"{raw}\"",
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardOutput = false,
            RedirectStandardError = false,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        using (var process = Process.Start(psi))
        {
            process.WaitForExit();
        }

        if (!File.Exists(raw))
        {
            throw new Exception("X360.exe failed to create RAW file.");
        }

        DecodeRaw(raw, true, output);
        File.Delete(raw);
    }

    // =========================
    // WII U
    // =========================
    static void ExtractWiiU(string filePath, string baseDir, string rawDir)
    {
        string rawPath;

        using (FileStream fs = CheckSaveGame(filePath, rawDir, out rawPath))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            ExtractRaw(reader, fs, baseDir, true);
        }

        Console.WriteLine("RAW: " + rawPath);
    }

    // =========================
    // CORE
    // =========================
    static void DecodeRaw(string path, bool big, string output)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open))
        using (BinaryReader r = new BinaryReader(fs))
        {
            ExtractRaw(r, fs, output, big);
        }
    }

    static void ExtractRaw(BinaryReader r, FileStream fs, string output, bool big)
    {
        int offset = ReadInt(r, big);
        int count = ReadInt(r, big);

        fs.Seek(offset, SeekOrigin.Begin);

        for (int i = 0; i < count; i++)
        {
            byte[] e = r.ReadBytes(144);
            if (e.Length < 144) break;

            string name = Encoding.ASCII.GetString(e, 0, 80).Replace("\0", "");

            int size = BitConverter.ToInt32(e, 128);
            int off = BitConverter.ToInt32(e, 132);

            if (big)
            {
                size = Reverse(size);
                off = Reverse(off);
            }

            string full = Path.Combine(output, name.Replace("/", "\\"));
            Directory.CreateDirectory(Path.GetDirectoryName(full));

            long pos = fs.Position;
            fs.Seek(off, SeekOrigin.Begin);
            File.WriteAllBytes(full, r.ReadBytes(size));
            fs.Seek(pos, SeekOrigin.Begin);
        }

        Console.WriteLine("Extracted to: " + output);
    }

    // =========================
    // HELPERS
    // =========================
    static int ReadInt(BinaryReader r, bool big)
    {
        byte[] b = r.ReadBytes(4);
        if (big) Array.Reverse(b);
        return BitConverter.ToInt32(b, 0);
    }

    static int Reverse(int v)
    {
        byte[] b = BitConverter.GetBytes(v);
        Array.Reverse(b);
        return BitConverter.ToInt32(b, 0);
    }
}