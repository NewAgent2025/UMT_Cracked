using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000087 RID: 135
	public class ConvertConsole
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x0002D57C File Offset: 0x0002B77C
		public void ConvertConsoleRegion(object threadContext)
		{
			ConvertConsoleParameters convertConsoleParameters = threadContext as ConvertConsoleParameters;
			if (convertConsoleParameters != null)
			{
				this.convertConsoleParameters_0 = convertConsoleParameters;
				this.method_0(convertConsoleParameters.RegionFolder, convertConsoleParameters.RegionName, convertConsoleParameters.SrcFolder, convertConsoleParameters.DstFolder, convertConsoleParameters.ConvertParameters);
				convertConsoleParameters.DoneEvent.Set();
				convertConsoleParameters.Done = true;
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002D5D4 File Offset: 0x0002B7D4
		private void method_0(string string_0, string string_1, string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			string text = FileUtils.CheckFolderSep(string_2) + string_1 + ".mcr";
			string path = FileUtils.CheckFolderSep(string_3) + string_1 + ".mcr";
			List<ChunkIndexEntry> list = Class46.smethod_5(text);
			if (list == null || list.Count <= 0)
			{
				if (this.convertConsoleParameters_0 != null)
				{
					this.convertConsoleParameters_0.MissingChunkCount += Class23.smethod_1()[string_0][string_1].Count;
				}
			}
			else
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (ConvertConsole.func_0 == null)
				{
					ConvertConsole.func_0 = new Func<ChunkIndexEntry, int>(ConvertConsole.smethod_0);
				}
				list = source.OrderBy(ConvertConsole.func_0).ToList<ChunkIndexEntry>();
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
				{
					Class46.smethod_25(binaryWriter);
					List<int> list2 = Class23.smethod_1()[string_0][string_1];
					using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
					{
						for (int i = 0; i < list2.Count; i++)
						{
							ChunkIndexEntry chunkIndexEntry = list[list2[i]];
							if (this.convertConsoleParameters_0 != null)
							{
								this.convertConsoleParameters_0.Count++;
							}
							if (chunkIndexEntry.OldChunkOffset > 0U)
							{
								byte[] array = Class46.smethod_51(chunkIndexEntry, binaryReader);
								array = this.method_1(array, convertParameters_0);
								if (array == null || array.Length <= 0)
								{
									if (this.convertConsoleParameters_0 != null)
									{
										this.convertConsoleParameters_0.InvalidChunkCount++;
									}
								}
								else
								{
									long num = (long)((array.Length % 4096 != 0) ? (4096 - array.Length % 4096) : 0);
									chunkIndexEntry.NewChunkOffset = (uint)(binaryWriter.BaseStream.Position / 4096L);
									chunkIndexEntry.NewChunkLength = (byte)(((long)array.Length + num) / 4096L);
									binaryWriter.Write(array, 0, array.Length);
									int num2 = 0;
									while ((long)num2 < num)
									{
										binaryWriter.Write(0);
										num2++;
									}
									if (this.convertConsoleParameters_0 != null)
									{
										this.convertConsoleParameters_0.ProcessedChunkCount++;
									}
								}
							}
							else if (this.convertConsoleParameters_0 != null)
							{
								this.convertConsoleParameters_0.MissingChunkCount++;
							}
						}
					}
					Class46.smethod_31(binaryWriter, list);
				}
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002D854 File Offset: 0x0002BA54
		private byte[] method_1(byte[] byte_0, ConvertParameters convertParameters_0)
		{
			byte[] array = null;
			MemoryStream memoryStream = Class46.smethod_69(byte_0);
			int int_ = (int)memoryStream.Length;
			int int_2 = byte_0.Length;
			if (convertParameters_0.method_0() == (Enum2)1)
			{
				XBOXCompression xboxcompression = new XBOXCompression();
				array = xboxcompression.DoCompress(byte_0, 8);
				Class46.smethod_27(array.Length - 8, array);
				Class46.smethod_28(int_, array);
			}
			else if (convertParameters_0.method_0() == (Enum2)2)
			{
				array = Class46.smethod_66(byte_0);
				byte[] first = new byte[12];
				array = first.Concat(array).ToArray<byte>();
				Class46.smethod_27(array.Length - 8, array);
				Class46.smethod_28(int_, array);
				Class46.smethod_29(int_2, array);
			}
			else if (convertParameters_0.method_0() == (Enum2)3)
			{
				array = Class46.smethod_63(byte_0);
				byte[] first2 = new byte[8];
				array = first2.Concat(array).ToArray<byte>();
				Class46.smethod_27(array.Length - 8, array);
				Class46.smethod_28(int_, array);
			}
			return array;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x04000379 RID: 889
		private ConvertConsoleParameters convertConsoleParameters_0;

		// Token: 0x0400037A RID: 890
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;
	}
}
