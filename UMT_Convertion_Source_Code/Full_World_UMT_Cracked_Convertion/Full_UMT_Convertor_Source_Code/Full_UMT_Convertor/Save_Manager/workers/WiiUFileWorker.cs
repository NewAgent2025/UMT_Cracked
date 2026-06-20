using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Save_Manager.model;

namespace Save_Manager.workers
{
	// Token: 0x0200010A RID: 266
	public class WiiUFileWorker
	{
		// Token: 0x06000B4B RID: 2891 RVA: 0x000554A0 File Offset: 0x000536A0
		public List<WiiUGameFile> LoadFileList(string saviineFolder, string readFolder)
		{
			List<WiiUGameFile> list = new List<WiiUGameFile>();
			foreach (string str in this.string_0)
			{
				string path = saviineFolder + "saviine_root\\inject\\" + str;
				if (Directory.Exists(path))
				{
					string[] directories = Directory.GetDirectories(path);
					foreach (string string_ in directories)
					{
						this.method_0(list, string_);
					}
				}
			}
			return list;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00055518 File Offset: 0x00053718
		private void method_0(List<WiiUGameFile> list_0, string string_1)
		{
			string[] files = Directory.GetFiles(string_1, "*.ext");
			foreach (string string_2 in files)
			{
				WiiUGameFile wiiUGameFile = this.method_1(string_2);
				if (wiiUGameFile != null)
				{
					list_0.Add(wiiUGameFile);
				}
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0005555C File Offset: 0x0005375C
		private WiiUGameFile method_1(string string_1)
		{
			WiiUGameFile wiiUGameFile = null;
			if (File.Exists(string_1))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(string_1, FileMode.Open)))
				{
					string text = string_1.Substring(0, string_1.Length - 4);
					wiiUGameFile = new WiiUGameFile();
					wiiUGameFile.Name = this.method_2(binaryReader);
					wiiUGameFile.Path = text;
					wiiUGameFile.Size = this.method_4(text);
					wiiUGameFile.ImageBytes = this.method_3(binaryReader);
				}
			}
			return wiiUGameFile;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000555E4 File Offset: 0x000537E4
		private string method_2(BinaryReader binaryReader_0)
		{
			List<byte> list = new List<byte>();
			byte b;
			do
			{
				b = binaryReader_0.ReadByte();
				b = binaryReader_0.ReadByte();
				if (b != 0)
				{
					list.Add(b);
				}
			}
			while (b != 0);
			return Encoding.UTF8.GetString(list.ToArray());
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00055630 File Offset: 0x00053830
		private byte[] method_3(BinaryReader binaryReader_0)
		{
			byte[] array = new byte[binaryReader_0.BaseStream.Length - 256L];
			binaryReader_0.BaseStream.Position = 256L;
			return binaryReader_0.ReadBytes((int)binaryReader_0.BaseStream.Length - 256);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00055688 File Offset: 0x00053888
		private long method_4(string string_1)
		{
			return new FileInfo(string_1).Length;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0005541C File Offset: 0x0005361C
		private byte[] method_5(string string_1)
		{
			string path = string_1 + "THUMB";
			byte[] array = null;
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					long length = binaryReader.BaseStream.Length;
					binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
					array = new byte[length];
					binaryReader.Read(array, 0, (int)length);
				}
			}
			return array;
		}

		// Token: 0x04000777 RID: 1911
		private string[] string_0 = new string[]
		{
			"00050000-101D9D00",
			"00050000-101D7500",
			"00050000-101DBE00"
		};
	}
}
