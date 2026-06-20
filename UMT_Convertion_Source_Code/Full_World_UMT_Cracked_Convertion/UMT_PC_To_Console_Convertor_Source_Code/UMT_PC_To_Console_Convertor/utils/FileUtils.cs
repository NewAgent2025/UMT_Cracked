using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000C4 RID: 196
	public class FileUtils
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x00030960 File Offset: 0x0002EB60
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

		// Token: 0x0600082A RID: 2090 RVA: 0x000309D8 File Offset: 0x0002EBD8
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

		// Token: 0x0600082B RID: 2091 RVA: 0x00030A24 File Offset: 0x0002EC24
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

		// Token: 0x0600082C RID: 2092 RVA: 0x00030A58 File Offset: 0x0002EC58
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

		// Token: 0x0600082D RID: 2093 RVA: 0x00030A9C File Offset: 0x0002EC9C
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

		// Token: 0x0600082E RID: 2094 RVA: 0x00030AFC File Offset: 0x0002ECFC
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

		// Token: 0x0600082F RID: 2095 RVA: 0x00030B3C File Offset: 0x0002ED3C
		public static void WriteFile(MemoryStream stream, string filename)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
			{
				byte[] buffer = stream.ToArray();
				binaryWriter.Write(buffer);
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00030B80 File Offset: 0x0002ED80
		public static void WriteFile(byte[] bytes, string filename)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
			{
				binaryWriter.Write(bytes);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00030BC0 File Offset: 0x0002EDC0
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

		// Token: 0x06000832 RID: 2098 RVA: 0x00030BF4 File Offset: 0x0002EDF4
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

		// Token: 0x06000833 RID: 2099 RVA: 0x00006926 File Offset: 0x00004B26
		public static uint smethod_6(BinaryReader reader, FileUtils.ByteOrder byteOrder)
		{
			if (byteOrder == FileUtils.ByteOrder.LittleEndian)
			{
				return (uint)reader.ReadInt32();
			}
			return BitConverter.ToUInt32(FileUtils.ReadBytes(reader, 4, FileUtils.ByteOrder.BigEndian), 0);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00030C2C File Offset: 0x0002EE2C
		public static void smethod_7(BinaryWriter writer, uint value, FileUtils.ByteOrder byteOrder)
		{
			byte[] array = BitConverter.GetBytes(value);
			if (byteOrder == FileUtils.ByteOrder.BigEndian)
			{
				array = array.Reverse<byte>().ToArray<byte>();
			}
			writer.Write(array);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00030C58 File Offset: 0x0002EE58
		internal static void smethod_8(string string_0)
		{
			foreach (string path in Directory.GetFiles(string_0))
			{
				File.Delete(path);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00006940 File Offset: 0x00004B40
		internal static void smethod_9(string string_0)
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00006951 File Offset: 0x00004B51
		public static string CheckFolderSep(string folderPath)
		{
			if (folderPath != null && !folderPath.EndsWith("\\"))
			{
				folderPath += "\\";
			}
			return folderPath;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00006971 File Offset: 0x00004B71
		public static bool CheckFolderExists(string folderPath)
		{
			folderPath = FileUtils.CheckFolderSep(folderPath);
			return Directory.Exists(folderPath);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00006981 File Offset: 0x00004B81
		internal static void smethod_10(string string_0)
		{
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00006991 File Offset: 0x00004B91
		internal static void smethod_11(string string_0, string string_1)
		{
			if (File.Exists(string_0))
			{
				File.Move(string_0, string_1);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000069A2 File Offset: 0x00004BA2
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

		// Token: 0x020000C5 RID: 197
		public enum ByteOrder
		{
			// Token: 0x04000533 RID: 1331
			LittleEndian,
			// Token: 0x04000534 RID: 1332
			BigEndian
		}
	}
}
