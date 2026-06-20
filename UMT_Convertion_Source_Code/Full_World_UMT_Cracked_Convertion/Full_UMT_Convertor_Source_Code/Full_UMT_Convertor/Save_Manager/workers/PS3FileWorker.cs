using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Save_Manager.model;

namespace Save_Manager.workers
{
	// Token: 0x02000109 RID: 265
	public class PS3FileWorker
	{
		// Token: 0x06000B45 RID: 2885 RVA: 0x000551EC File Offset: 0x000533EC
		public List<PS3GameFile> LoadFileList()
		{
			List<PS3GameFile> list = new List<PS3GameFile>();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				bool isReady = driveInfo.IsReady;
				if (driveInfo.IsReady && driveInfo.DriveFormat == "FAT32" && driveInfo.DriveType == DriveType.Removable && Directory.Exists(driveInfo.Name + "PS3\\SAVEDATA"))
				{
					string[] directories = Directory.GetDirectories(driveInfo.Name + "PS3\\SAVEDATA");
					foreach (string str in directories)
					{
						string text = str + "\\";
						if (File.Exists(text + "GAMEDATA") && File.Exists(text + "PARAM.SFO"))
						{
							PS3GameFile ps3GameFile = this.method_0(text);
							if (ps3GameFile != null)
							{
								list.Add(ps3GameFile);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000552E8 File Offset: 0x000534E8
		private PS3GameFile method_0(string string_0)
		{
			PS3GameFile ps3GameFile = null;
			string path = string_0 + "PARAM.SFO";
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					binaryReader.BaseStream.Position = 2608L;
					string text = this.method_1(binaryReader);
					if (text.StartsWith("Minecraft"))
					{
						ps3GameFile = new PS3GameFile();
						binaryReader.BaseStream.Position = 2480L;
						string name = this.method_1(binaryReader);
						ps3GameFile.Name = name;
						ps3GameFile.Path = string_0 + "GAMEDATA";
						ps3GameFile.Size = this.method_2(string_0);
						ps3GameFile.ImageBytes = this.method_3(string_0);
					}
				}
			}
			return ps3GameFile;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000553B8 File Offset: 0x000535B8
		private string method_1(BinaryReader binaryReader_0)
		{
			List<byte> list = new List<byte>();
			byte b;
			do
			{
				b = binaryReader_0.ReadByte();
				if (b != 0)
				{
					list.Add(b);
				}
			}
			while (b != 0);
			return Encoding.Default.GetString(list.ToArray());
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000553F4 File Offset: 0x000535F4
		private long method_2(string string_0)
		{
			string fileName = string_0 + "GAMEDATA";
			return new FileInfo(fileName).Length;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0005541C File Offset: 0x0005361C
		private byte[] method_3(string string_0)
		{
			string path = string_0 + "THUMB";
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
	}
}
