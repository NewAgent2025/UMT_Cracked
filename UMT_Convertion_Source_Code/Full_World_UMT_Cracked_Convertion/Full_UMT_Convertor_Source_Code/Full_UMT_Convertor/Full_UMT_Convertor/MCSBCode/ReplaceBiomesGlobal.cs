using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x020000B6 RID: 182
	public class ReplaceBiomesGlobal
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x00041034 File Offset: 0x0003F234
		public void Replace(object threadContext)
		{
			this.replaceBiomeGlobalParameter_0 = (threadContext as ReplaceBiomeGlobalParameter);
			try
			{
				this.Replace(this.replaceBiomeGlobalParameter_0.Dimension, this.replaceBiomeGlobalParameter_0.Region, this.replaceBiomeGlobalParameter_0.ReplacementBiomeList, this.replaceBiomeGlobalParameter_0.OutFolderPath);
				this.replaceBiomeGlobalParameter_0.ProcessState = ProcessStateType.Completed;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Unexpected Error");
				this.replaceBiomeGlobalParameter_0.ProcessState = ProcessStateType.Error;
			}
			this.replaceBiomeGlobalParameter_0.DoneEvent.Set();
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000410D0 File Offset: 0x0003F2D0
		public void Replace(string dimension, string region, List<BiomeChange> replacementBiomeList, string workingFolder)
		{
			string text = string.Concat(new string[]
			{
				workingFolder,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(dimension),
				region,
				".mcr"
			});
			string text2 = string.Concat(new string[]
			{
				workingFolder,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(dimension),
				region,
				".new"
			});
			List<ChunkIndexEntry> list = Class46.smethod_5(text);
			if (list != null && list.Count > 0)
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (ReplaceBiomesGlobal.func_0 == null)
				{
					ReplaceBiomesGlobal.func_0 = new Func<ChunkIndexEntry, int>(ReplaceBiomesGlobal.smethod_0);
				}
				list = source.OrderBy(ReplaceBiomesGlobal.func_0).ToList<ChunkIndexEntry>();
				using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text2, FileMode.Create)))
					{
						Class46.smethod_25(binaryWriter);
						List<int> list2 = Class23.smethod_1()[dimension][region];
						for (int i = 0; i < list2.Count; i++)
						{
							ChunkIndexEntry chunkIndexEntry = list[list2[i]];
							if (chunkIndexEntry.OldChunkOffset > 0U)
							{
								byte[] byte_ = Class46.smethod_11(binaryReader, chunkIndexEntry);
								byte[] array = Class46.smethod_48(chunkIndexEntry, byte_);
								bool flag;
								object object_;
								if (array[0] == 10)
								{
									TagNodeCompound tagNodeCompound = Class46.smethod_34(array);
									flag = this.method_0(tagNodeCompound, replacementBiomeList);
									object_ = tagNodeCompound;
								}
								else
								{
									MemoryStream stream = Class46.smethod_69(array);
									TU17Parser tu17Parser = new TU17Parser();
									TU17ChunkData tu17ChunkData = tu17Parser.ParseChunk(stream);
									flag = this.method_1(tu17ChunkData.Biomes, replacementBiomeList);
									object_ = tu17ChunkData;
								}
								if (flag)
								{
									ChunkData chunkData = new ChunkData();
									chunkData.method_1(chunkIndexEntry);
									if (array != null && array.Length > 0)
									{
										array = Class46.smethod_61(object_, chunkData);
										Class46.smethod_13(array, chunkIndexEntry, binaryWriter);
									}
								}
								else
								{
									Class46.smethod_13(byte_, chunkIndexEntry, binaryWriter);
								}
							}
							if (this.replaceBiomeGlobalParameter_0 != null)
							{
								this.replaceBiomeGlobalParameter_0.ChunkProcessedCount++;
							}
						}
						Class46.smethod_31(binaryWriter, list);
					}
				}
				FileUtils.smethod_10(text);
				FileUtils.smethod_11(text2, text);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00041340 File Offset: 0x0003F540
		private bool method_0(TagNodeCompound tagNodeCompound_0, List<BiomeChange> list_0)
		{
			bool result = false;
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			if (tagNodeCompound.ContainsKey("Biomes"))
			{
				TagNodeByteArray b = tagNodeCompound["Biomes"] as TagNodeByteArray;
				result = this.method_1(b, list_0);
			}
			return result;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00041390 File Offset: 0x0003F590
		private bool method_1(byte[] byte_0, List<BiomeChange> list_0)
		{
			bool result = false;
			if (byte_0 != null)
			{
				for (int i = 0; i < byte_0.Length; i++)
				{
					int j = 0;
					while (j < list_0.Count)
					{
						if (list_0[j].FromBiome != 1000)
						{
							if ((int)byte_0[i] != list_0[j].FromBiome)
							{
								j++;
								continue;
							}
						}
						byte_0[i] = (byte)list_0[j].ToBiome;
						result = true;
						if (this.replaceBiomeGlobalParameter_0 != null)
						{
							this.replaceBiomeGlobalParameter_0.BiomeProcessedCount++;
							break;
						}
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x04000534 RID: 1332
		private ReplaceBiomeGlobalParameter replaceBiomeGlobalParameter_0;

		// Token: 0x04000535 RID: 1333
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;
	}
}
