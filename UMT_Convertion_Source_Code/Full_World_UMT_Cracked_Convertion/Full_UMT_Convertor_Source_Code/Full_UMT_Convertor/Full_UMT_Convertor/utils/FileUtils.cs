using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x0200013C RID: 316
	public class FileUtils
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x0005A8B0 File Offset: 0x00058AB0
		internal static byte[] smethod_0(string string_0)
		{
			byte[] array = null;
			if (File.Exists(string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
				{
					long length = binaryReader.BaseStream.Length;
					binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
					array = new byte[length];
					binaryReader.Read(array, 0, (int)length);
				}
			}
			return array;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0005A928 File Offset: 0x00058B28
		internal static string smethod_1(string string_0, string string_1, string string_2, string string_3 = "")
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string result = null;
			string_2 = FileUtils.smethod_2(string_2);
			openFileDialog.DefaultExt = string_0;
			openFileDialog.Filter = string_1;
			openFileDialog.InitialDirectory = string_2;
			openFileDialog.FileName = string_3;
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
			return result;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0005A974 File Offset: 0x00058B74
		private static string smethod_2(string string_0)
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(string_0))
				{
					string_0 = Path.GetDirectoryName(string_0);
				}
			}
			catch (Exception)
			{
			}
			return string_0;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		internal static string smethod_3(string string_0, string string_1, string string_2, string string_3 = "")
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			string result = null;
			saveFileDialog.DefaultExt = string_0;
			saveFileDialog.Filter = string_1;
			saveFileDialog.InitialDirectory = string_2;
			saveFileDialog.FileName = string_3;
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				result = saveFileDialog.FileName;
			}
			return result;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0005A9EC File Offset: 0x00058BEC
		internal static string smethod_4(string string_0, string string_1 = "Conversion output folder")
		{
			string result = null;
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = string_1;
				folderBrowserDialog.ShowNewFolderButton = true;
				folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
				folderBrowserDialog.SelectedPath = string_0;
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					result = folderBrowserDialog.SelectedPath;
				}
			}
			return result;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0005AA4C File Offset: 0x00058C4C
		internal static string smethod_5(string string_0)
		{
			string text = string_0;
			int num = text.LastIndexOf('\\');
			if (num > 0)
			{
				text = text.Substring(num + 1);
			}
			num = text.LastIndexOf('.');
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0005AA8C File Offset: 0x00058C8C
		public static void WriteFile(MemoryStream stream, string filename)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
			{
				byte[] buffer = stream.ToArray();
				binaryWriter.Write(buffer);
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0005AAD0 File Offset: 0x00058CD0
		public static void WriteFile(byte[] bytes, string filename)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
			{
				binaryWriter.Write(bytes);
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0005AB10 File Offset: 0x00058D10
		public static short ReadShort(BinaryReader reader)
		{
			byte[] array = new byte[2];
			array = reader.ReadBytes(2);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt16(array, 0);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0005AB44 File Offset: 0x00058D44
		public static byte[] ReadBytes(BinaryReader reader, int fieldSize, FileUtils.ByteOrder byteOrder)
		{
			byte[] array = new byte[fieldSize];
			if (byteOrder == FileUtils.ByteOrder.LittleEndian)
			{
				return reader.ReadBytes(fieldSize);
			}
			for (int i = fieldSize - 1; i > -1; i--)
			{
				array[i] = reader.ReadByte();
			}
			return array;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00008B84 File Offset: 0x00006D84
		public static uint smethod_6(BinaryReader reader, FileUtils.ByteOrder byteOrder)
		{
			if (byteOrder == FileUtils.ByteOrder.LittleEndian)
			{
				return (uint)reader.ReadInt32();
			}
			return BitConverter.ToUInt32(FileUtils.ReadBytes(reader, 4, FileUtils.ByteOrder.BigEndian), 0);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0005AB7C File Offset: 0x00058D7C
		public static void smethod_7(BinaryWriter writer, uint value, FileUtils.ByteOrder byteOrder)
		{
			byte[] array = BitConverter.GetBytes(value);
			if (byteOrder == FileUtils.ByteOrder.BigEndian)
			{
				array = array.Reverse<byte>().ToArray<byte>();
			}
			writer.Write(array);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0005ABA8 File Offset: 0x00058DA8
		internal static void smethod_8(string string_0)
		{
			foreach (string path in Directory.GetFiles(string_0))
			{
				File.Delete(path);
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00008B9E File Offset: 0x00006D9E
		internal static void smethod_9(string string_0)
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00008BAF File Offset: 0x00006DAF
		public static string CheckFolderSep(string folderPath)
		{
			if (folderPath != null && !folderPath.EndsWith("\\"))
			{
				folderPath += "\\";
			}
			return folderPath;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00008BCF File Offset: 0x00006DCF
		public static bool CheckFolderExists(string folderPath)
		{
			folderPath = FileUtils.CheckFolderSep(folderPath);
			return Directory.Exists(folderPath);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00008BDF File Offset: 0x00006DDF
		internal static void smethod_10(string string_0)
		{
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00008BEF File Offset: 0x00006DEF
		internal static void smethod_11(string string_0, string string_1)
		{
			if (File.Exists(string_0))
			{
				File.Move(string_0, string_1);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00008C00 File Offset: 0x00006E00
		internal static void smethod_12(string string_0, string string_1)
		{
			if (File.Exists(string_0))
			{
				if (File.Exists(string_1))
				{
					FileUtils.smethod_10(string_1);
				}
				File.Copy(string_0, string_1);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0005ABD4 File Offset: 0x00058DD4
		public static void CopyFoldersAndFiles(string source, string target)
		{
			DirectoryInfo source2 = new DirectoryInfo(source);
			DirectoryInfo target2 = new DirectoryInfo(target);
			FileUtils.CopyFoldersAndFiles(source2, target2);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0005ABF8 File Offset: 0x00058DF8
		public static void CopyFoldersAndFiles(DirectoryInfo source, DirectoryInfo target)
		{
			Class43 @class = new Class43();
			foreach (DirectoryInfo directoryInfo in source.GetDirectories())
			{
				FileUtils.CopyFoldersAndFiles(directoryInfo, target.CreateSubdirectory(directoryInfo.Name));
			}
			foreach (FileInfo fileInfo in source.GetFiles())
			{
				@class.method_0(fileInfo.FullName, Path.Combine(target.FullName, fileInfo.Name));
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0005AC7C File Offset: 0x00058E7C
		internal static long smethod_13(string string_0)
		{
			FileInfo fileInfo = new FileInfo(string_0);
			return fileInfo.Length;
		}

		// Token: 0x0200013D RID: 317
		public enum ByteOrder
		{
			// Token: 0x04000818 RID: 2072
			LittleEndian,
			// Token: 0x04000819 RID: 2073
			BigEndian
		}
	}
}
