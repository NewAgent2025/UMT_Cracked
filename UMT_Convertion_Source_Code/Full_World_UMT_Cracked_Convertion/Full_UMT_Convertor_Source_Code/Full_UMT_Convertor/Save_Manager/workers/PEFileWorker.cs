using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Full_UMT_Convertor.utils;
using Save_Manager.model;
using Substrate.Nbt;

namespace Save_Manager.workers
{
	// Token: 0x0200002C RID: 44
	public class PEFileWorker
	{
		// Token: 0x0600018C RID: 396 RVA: 0x0000F66C File Offset: 0x0000D86C
		public List<PEWorldFolder> LoadFileList()
		{
			List<PEWorldFolder> list = new List<PEWorldFolder>();
			string text = string.Empty;
			try
			{
				text = Utils.smethod_2();
				string[] directories = Directory.GetDirectories(text);
				if (directories != null)
				{
					foreach (string text2 in directories)
					{
						try
						{
							if (!string.IsNullOrWhiteSpace(text2))
							{
								Path.GetFileName(text2);
								PEWorldFolder peworldFolder = this.method_0(text2);
								if (peworldFolder != null)
								{
									list.Add(peworldFolder);
								}
							}
						}
						catch (Exception)
						{
						}
					}
				}
				IEnumerable<PEWorldFolder> source = list;
				if (PEFileWorker.func_0 == null)
				{
					PEFileWorker.func_0 = new Func<PEWorldFolder, DateTime>(PEFileWorker.smethod_0);
				}
				list = source.OrderByDescending(PEFileWorker.func_0).ToList<PEWorldFolder>();
			}
			catch (Exception ex)
			{
				string text3 = string.Concat(new string[]
				{
					"Save Folder : ",
					text,
					Environment.NewLine,
					"Error : ",
					ex.Message
				});
				MessageBox.Show(text3, "Error Encountered");
			}
			return list;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000F774 File Offset: 0x0000D974
		private PEWorldFolder method_0(string string_0)
		{
			PEWorldFolder peworldFolder = null;
			string path = Path.Combine(string_0, "level.dat");
			if (File.Exists(path))
			{
				peworldFolder = new PEWorldFolder();
				DirectoryInfo directoryInfo_ = new DirectoryInfo(string_0);
				TagNodeCompound tagNodeCompound = this.method_3(string_0);
				peworldFolder.Name = (tagNodeCompound["LevelName"] as TagNodeString);
				peworldFolder.GameType = (tagNodeCompound["GameType"] as TagNodeInt);
				peworldFolder.Path = string_0;
				peworldFolder.Size = this.method_4(directoryInfo_);
				long num = tagNodeCompound.ContainsKey("LastPlayed") ? (tagNodeCompound["LastPlayed"] as TagNodeLong) : 0;
				peworldFolder.Date = Utils.UnixTimeStampToDateTime((double)num);
				peworldFolder.ImageBytes = this.method_2(string_0);
			}
			return peworldFolder;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000030FD File Offset: 0x000012FD
		private long method_1(string string_0)
		{
			return 0L;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000F844 File Offset: 0x0000DA44
		private byte[] method_2(string string_0)
		{
			string path = Path.Combine(string_0, "world_icon.jpeg");
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

		// Token: 0x06000190 RID: 400 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		private TagNodeCompound method_3(string string_0)
		{
			byte[] source = FileUtils.smethod_0(Path.Combine(string_0, "level.dat"));
			MemoryStream s = new MemoryStream(source.Skip(8).ToArray<byte>());
			NbtTree nbtTree = new NbtTree();
			nbtTree.UseBigEndian = false;
			nbtTree.ReadFrom(s);
			return nbtTree.Root;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000F914 File Offset: 0x0000DB14
		private long method_4(DirectoryInfo directoryInfo_0)
		{
			long num = 0L;
			FileInfo[] files = directoryInfo_0.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				num += fileInfo.Length;
			}
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo_ in directories)
			{
				num += this.method_4(directoryInfo_);
			}
			return num;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003110 File Offset: 0x00001310
		[CompilerGenerated]
		private static DateTime smethod_0(PEWorldFolder peworldFolder_0)
		{
			return peworldFolder_0.Date;
		}

		// Token: 0x040000E0 RID: 224
		[CompilerGenerated]
		private static Func<PEWorldFolder, DateTime> func_0;
	}
}
