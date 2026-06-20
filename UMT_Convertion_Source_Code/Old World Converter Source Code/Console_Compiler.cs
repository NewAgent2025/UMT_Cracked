using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class Program
{
    // =========================
    // ZLIB (WII U)
    // =========================
    [DllImport("zlib1.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int compress(byte[] dest, ref uint destLen, byte[] source, uint sourceLen);

    [STAThread]
    static void Main(string[] args)
    {
        if (args.Length < 2 || args[0].ToLower() != "-c")
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("EXE_NAME.exe -c [1=X360 | 2=PS3 | 3=WiiU]");
            return;
        }

        string platform = args[1];
        string baseDir = Path.Combine(Environment.CurrentDirectory, "UMT_Cracked_Convertion");

        if (!Directory.Exists(baseDir))
        {
            Console.WriteLine("UMT_Cracked_Convertion folder not found.");
            return;
        }

        try
        {
            string newestFolder = GetNewestFolder(baseDir, platform);

            if (string.IsNullOrEmpty(newestFolder))
            {
                Console.WriteLine("No valid folders found for platform.");
                return;
            }

            Console.WriteLine("Selected Folder: " + newestFolder);

            string savePath = ShowSaveDialog(platform);

            if (string.IsNullOrEmpty(savePath))
            {
                Console.WriteLine("Cancelled.");
                return;
            }

            RunCompile(platform, newestFolder, savePath);

            Console.WriteLine("Done.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
    }

    // =========================
    // FIND NEWEST FOLDER
    // =========================
    static string GetNewestFolder(string baseDir, string platform)
    {
        var folders = Directory.GetDirectories(baseDir);

        if (platform == "1") // X360
        {
            return folders
                .Where(f => f.ToUpper().Contains("_X360_"))
                .OrderByDescending(f => Directory.GetCreationTime(f))
                .FirstOrDefault();
        }
        else if (platform == "2") // PS3
        {
            return folders
                .Where(f => f.ToUpper().Contains("_PS3_"))
                .OrderByDescending(f => Directory.GetCreationTime(f))
                .FirstOrDefault();
        }
        else if (platform == "3") // Wii
        {
            return folders
                .Where(f => f.ToUpper().Contains("_WII_"))
                .OrderByDescending(f => Directory.GetCreationTime(f))
                .FirstOrDefault();
        }

        return null;
    }

    // =========================
    // SAVE FILE DIALOG
    // =========================
    static string ShowSaveDialog(string platform)
    {
        SaveFileDialog dialog = new SaveFileDialog();

        if (platform == "1")
            dialog.Filter = "DAT File (*.dat)|*.dat";
        else if (platform == "3")
            dialog.Filter = "WII File (*.wii)|*.wii";
        else
            dialog.Filter = "All Files (*.*)|*.*";

        dialog.Title = "Save Output File";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            string path = dialog.FileName;

            // Ensure extensions
            if (platform == "1" && !path.EndsWith(".dat"))
                path += ".dat";

            if (platform == "3" && !path.EndsWith(".wii"))
                path += ".wii";

            return path;
        }

        return null;
    }

    // =========================
    // MAIN COMPILE
    // =========================
    static void RunCompile(string platform, string folder, string outputPath)
    {
        if (platform == "1") // Xbox
        {
            string temp = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".dat");

            Build(folder, temp);

            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c X360.exe -c \"{temp}\" \"{outputPath}\"",
                CreateNoWindow = true,
                UseShellExecute = false
            })?.WaitForExit();

            if (File.Exists(temp))
                File.Delete(temp);
        }
        else if (platform == "2") // PS3
        {
            Build(folder, outputPath);
        }
        else if (platform == "3") // Wii U
        {
            string tempRaw = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".dat");

            Build(folder, tempRaw);
            BuildWiiUSave(tempRaw, outputPath);

            if (File.Exists(tempRaw))
                File.Delete(tempRaw);
        }
        else
        {
            throw new Exception("Invalid platform.");
        }
    }

    // =========================
    // WII U COMPRESS
    // =========================
    static void BuildWiiUSave(string rawPath, string outputPath)
    {
        byte[] rawData = File.ReadAllBytes(rawPath);
        uint rawSize = (uint)rawData.Length;

        uint compSize = (uint)(rawSize * 1.01 + 1024);
        byte[] compressed = new byte[compSize];

        int result = compress(compressed, ref compSize, rawData, rawSize);

        if (result != 0)
            throw new Exception("Compression failed: " + result);

        Array.Resize(ref compressed, (int)compSize);

        using (BinaryWriter bw = new BinaryWriter(File.Create(outputPath)))
        {
            bw.Write(0u);

            byte[] sizeBytes = BitConverter.GetBytes(rawSize);
            Array.Reverse(sizeBytes);
            bw.Write(sizeBytes);

            bw.Write(compressed);
        }
    }

    // =========================
    // BUILDER
    // =========================
    static void Build(string folderPath, string outputName)
    {
        string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

        using (MemoryStream ms = new MemoryStream())
        {
            ms.Write(new byte[12], 0, 12);

            byte[][] data = files.Select(f => File.ReadAllBytes(f)).ToArray();
            int[] offsets = new int[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                offsets[i] = (int)ms.Position;
                ms.Write(data[i], 0, data[i].Length);
            }

            int indexOffset = (int)ms.Position;

            for (int i = 0; i < files.Length; i++)
            {
                string rel = files[i].Substring(folderPath.Length)
                    .TrimStart('\\', '/')
                    .Replace("\\", "/");

                byte[] entry = new byte[144];

                byte[] name = Encoding.BigEndianUnicode.GetBytes(rel);
                Array.Copy(name, 0, entry, 0, Math.Min(name.Length, 80));

                byte[] size = BitConverter.GetBytes(data[i].Length);
                Array.Reverse(size);
                Array.Copy(size, 0, entry, 128, 4);

                byte[] off = BitConverter.GetBytes(offsets[i]);
                Array.Reverse(off);
                Array.Copy(off, 0, entry, 132, 4);

                ms.Write(entry, 0, 144);
            }

            ms.Seek(0, SeekOrigin.Begin);

            byte[] header = new byte[12];

            byte[] idx = BitConverter.GetBytes(indexOffset);
            Array.Reverse(idx);
            Array.Copy(idx, 0, header, 0, 4);

            byte[] count = BitConverter.GetBytes(files.Length);
            Array.Reverse(count);
            Array.Copy(count, 0, header, 4, 4);

            header[9] = 7;
            header[11] = 9;

            ms.Write(header, 0, 12);

            File.WriteAllBytes(outputName, ms.ToArray());
        }
    }
}