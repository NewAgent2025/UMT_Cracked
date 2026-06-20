using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Full_UMT_Convertor.utils;
using Save_Manager.model;
using Substrate.Core;
using Substrate.Nbt;

namespace Save_Manager.workers
{
	// Token: 0x0200002B RID: 43
	public class PCFileWorker
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0000F304 File Offset: 0x0000D504
		public List<PCWorldFolder> LoadFileList()
		{
			List<PCWorldFolder> list = new List<PCWorldFolder>();
			string text = string.Empty;
			try
			{
				text = Utils.smethod_1();
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
								PCWorldFolder pcworldFolder = this.method_0(text2);
								if (pcworldFolder != null)
								{
									list.Add(pcworldFolder);
								}
							}
						}
						catch (Exception)
						{
						}
					}
				}
				IEnumerable<PCWorldFolder> source = list;
				if (PCFileWorker.func_0 == null)
				{
					PCFileWorker.func_0 = new Func<PCWorldFolder, string>(PCFileWorker.smethod_0);
				}
				list = source.OrderBy(PCFileWorker.func_0).ToList<PCWorldFolder>();
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

		// Token: 0x06000184 RID: 388 RVA: 0x0000F40C File Offset: 0x0000D60C
		private PCWorldFolder method_0(string string_0)
		{
			PCWorldFolder pcworldFolder = null;
			string path = Path.Combine(string_0, "level.dat");
			if (File.Exists(path))
			{
				pcworldFolder = new PCWorldFolder();
				TagNodeCompound tagNodeCompound = this.method_3(string_0);
				pcworldFolder.Name = (tagNodeCompound["LevelName"] as TagNodeString);
				pcworldFolder.GameType = (tagNodeCompound["GameType"] as TagNodeInt);
				pcworldFolder.Path = string_0;
				long num = tagNodeCompound.ContainsKey("LastPlayed") ? (tagNodeCompound["LastPlayed"] as TagNodeLong) : 0;
				pcworldFolder.Date = PCFileWorker.UnixTimeStampToDateTime((double)num);
				pcworldFolder.ImageBytes = this.method_2(string_0);
			}
			return pcworldFolder;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000030FD File Offset: 0x000012FD
		private long method_1(string string_0)
		{
			return 0L;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		private byte[] method_2(string string_0)
		{
			string path = Path.Combine(string_0, "icon.png");
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

		// Token: 0x06000187 RID: 391 RVA: 0x0000F54C File Offset: 0x0000D74C
		public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			try
			{
				result = result.AddMilliseconds(unixTimeStamp).ToLocalTime();
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000F594 File Offset: 0x0000D794
		private TagNodeCompound method_3(string string_0)
		{
			TagNodeCompound result = null;
			string path = Path.Combine(string_0, "level.dat");
			if (File.Exists(path))
			{
				NBTFile nbtfile = new NBTFile(path);
				Stream dataInputStream = nbtfile.GetDataInputStream();
				if (dataInputStream != null)
				{
					NbtTree nbtTree = new NbtTree();
					nbtTree.UseBigEndian = true;
					nbtTree.ReadFrom(dataInputStream);
					result = (nbtTree.Root["Data"] as TagNodeCompound);
				}
			}
			return result;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
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

		// Token: 0x0600018B RID: 395 RVA: 0x00003108 File Offset: 0x00001308
		[CompilerGenerated]
		private static string smethod_0(PCWorldFolder pcworldFolder_0)
		{
			return pcworldFolder_0.Name;
		}

		// Token: 0x040000DF RID: 223
		[CompilerGenerated]
		private static Func<PCWorldFolder, string> func_0;
	}
}
