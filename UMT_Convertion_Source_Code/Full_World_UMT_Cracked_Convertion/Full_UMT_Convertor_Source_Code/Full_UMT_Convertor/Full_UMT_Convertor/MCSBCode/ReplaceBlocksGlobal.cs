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
	// Token: 0x020000B7 RID: 183
	public class ReplaceBlocksGlobal
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x0004141C File Offset: 0x0003F61C
		public void Replace(object threadContext)
		{
			this.replaceBlockGlobalParameter_0 = (threadContext as ReplaceBlockGlobalParameter);
			try
			{
				this.Replace(this.replaceBlockGlobalParameter_0.Dimension, this.replaceBlockGlobalParameter_0.Region, this.replaceBlockGlobalParameter_0.ReplacementBlockList, this.replaceBlockGlobalParameter_0.OutFolderPath);
				this.replaceBlockGlobalParameter_0.ProcessState = ProcessStateType.Completed;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Unexpected Error");
				this.replaceBlockGlobalParameter_0.ProcessState = ProcessStateType.Error;
			}
			this.replaceBlockGlobalParameter_0.DoneEvent.Set();
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000414B8 File Offset: 0x0003F6B8
		public void Replace(string dimension, string region, List<BlockChange> replacementBlockList, string workingFolder)
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
				if (ReplaceBlocksGlobal.func_0 == null)
				{
					ReplaceBlocksGlobal.func_0 = new Func<ChunkIndexEntry, int>(ReplaceBlocksGlobal.smethod_0);
				}
				list = source.OrderBy(ReplaceBlocksGlobal.func_0).ToList<ChunkIndexEntry>();
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
									flag = this.method_0(tagNodeCompound, replacementBlockList);
									object_ = tagNodeCompound;
								}
								else
								{
									MemoryStream stream = Class46.smethod_69(array);
									TU17Parser tu17Parser = new TU17Parser();
									TU17ChunkData tu17ChunkData = tu17Parser.ParseChunk(stream);
									flag = this.method_1(tu17ChunkData, replacementBlockList);
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
							if (this.replaceBlockGlobalParameter_0 != null)
							{
								this.replaceBlockGlobalParameter_0.ChunkProcessedCount++;
							}
						}
						Class46.smethod_31(binaryWriter, list);
					}
				}
				FileUtils.smethod_10(text);
				FileUtils.smethod_11(text2, text);
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0004171C File Offset: 0x0003F91C
		private bool method_0(TagNodeCompound tagNodeCompound_0, List<BlockChange> list_0)
		{
			bool result = false;
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			TagNodeByteArray tagNodeByteArray = tagNodeCompound["Blocks"] as TagNodeByteArray;
			TagNodeByteArray b = tagNodeCompound["Data"] as TagNodeByteArray;
			TagNodeByteArray b2 = tagNodeCompound["BlockLight"] as TagNodeByteArray;
			TagNodeList tagNodeList_ = tagNodeCompound["TileEntities"] as TagNodeList;
			int num = (TagNodeInt)tagNodeCompound["xPos"];
			int num2 = (TagNodeInt)tagNodeCompound["zPos"];
			int num3 = (num >= 0) ? (num * 16) : ((num + 1) * 16);
			int num4 = (num2 >= 0) ? (num2 * 16) : ((num2 + 1) * 16);
			int num5 = (tagNodeByteArray.Length == 65536) ? 16 : 8;
			for (int i = 0; i < num5; i++)
			{
				int num6 = (i < 8) ? 0 : 32768;
				int offset = num6 / 2;
				int num7 = (i < 8) ? i : (i - 8);
				for (int j = 0; j < 16; j++)
				{
					int num8 = i * 16;
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int index = j << 11 | l << 7 | k + (num7 << 4) + num6;
							byte b3 = tagNodeByteArray[index];
							int item = nibbleSetters.RegionGet(b, j, k + (num7 << 4), l, offset);
							int m = 0;
							while (m < list_0.Count)
							{
								if (list_0[m].FromBlock == -1)
								{
									goto IL_19B;
								}
								if ((int)b3 == list_0[m].FromBlock)
								{
									goto IL_19B;
								}
								IL_1C6:
								m++;
								continue;
								IL_19B:
								if ((list_0[m].Layers.Contains(num8) || list_0[m].Layers.Contains(-1)) && (list_0[m].FromData.Contains(-1) || list_0[m].FromData.Contains(item)))
								{
									tagNodeByteArray[index] = (byte)list_0[m].ToBlock;
									if (list_0[m].ToData != -1)
									{
										nibbleSetters.RegionSet(b, j, k + (num7 << 4), l, list_0[m].ToData, offset);
									}
									if (list_0[m].ToBlockLight != -1)
									{
										nibbleSetters.RegionSet(b2, j, k + (num7 << 4), l, list_0[m].ToBlockLight, offset);
									}
									int num9 = num3 + ((num >= 0) ? j : ((16 - j) * -1));
									int num10 = num4 + ((num2 >= 0) ? l : ((16 - l) * -1));
									if (Class46.smethod_35((int)b3))
									{
										Class46.smethod_37(tagNodeCompound_0, num9, num8, num10);
									}
									if (Class46.smethod_35((int)((byte)list_0[m].ToBlock)))
									{
										Class46.smethod_40((int)((byte)list_0[m].ToBlock), tagNodeList_, num9, num8, num10, this.dictionary_0);
									}
									result = true;
									break;
								}
								goto IL_1C6;
							}
						}
						num8++;
					}
				}
			}
			return result;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00041A68 File Offset: 0x0003FC68
		private bool method_1(TU17ChunkData tu17ChunkData_0, List<BlockChange> list_0)
		{
			bool result = false;
			NibbleSetters nibbleSetters = new NibbleSetters();
			byte[] blocks = tu17ChunkData_0.Blocks;
			byte[] blockData = tu17ChunkData_0.BlockData;
			byte[] blockLight = tu17ChunkData_0.BlockLight;
			TagNodeList tagNodeList_ = tu17ChunkData_0.NBTData["TileEntities"] as TagNodeList;
			int x = tu17ChunkData_0.X;
			int z = tu17ChunkData_0.Z;
			int num = (x >= 0) ? (x * 16) : ((x + 1) * 16);
			int num2 = (z >= 0) ? (z * 16) : ((z + 1) * 16);
			for (int i = 0; i < 256; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						int num3 = i * 256 + j * 16 + k;
						byte b = blocks[num3];
						int item = nibbleSetters.method_0(blockData, num3);
						int l = 0;
						while (l < list_0.Count)
						{
							if (list_0[l].FromBlock == -1)
							{
								goto IL_EA;
							}
							if ((int)b == list_0[l].FromBlock)
							{
								goto IL_EA;
							}
							IL_115:
							l++;
							continue;
							IL_EA:
							if ((list_0[l].Layers.Contains(i) || list_0[l].Layers.Contains(-1)) && (list_0[l].FromData.Contains(-1) || list_0[l].FromData.Contains(item)))
							{
								blocks[num3] = (byte)list_0[l].ToBlock;
								if (list_0[l].ToData != -1)
								{
									nibbleSetters.method_1(blockData, num3, list_0[l].ToData);
								}
								if (list_0[l].ToBlockLight != -1)
								{
									nibbleSetters.method_1(blockLight, num3, list_0[l].ToBlockLight);
								}
								int num4 = num + ((x >= 0) ? j : ((16 - j) * -1));
								int num5 = num2 + ((z >= 0) ? k : ((16 - k) * -1));
								if (Class46.smethod_35((int)b))
								{
									Class46.smethod_37(tu17ChunkData_0.NBTData, num4, i, num5);
								}
								if (Class46.smethod_35((int)((byte)list_0[l].ToBlock)))
								{
									Class46.smethod_40((int)((byte)list_0[l].ToBlock), tagNodeList_, num4, i, num5, this.dictionary_0);
								}
								result = true;
								break;
							}
							goto IL_115;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x04000536 RID: 1334
		private ReplaceBlockGlobalParameter replaceBlockGlobalParameter_0;

		// Token: 0x04000537 RID: 1335
		private Dictionary<int, TagNodeCompound> dictionary_0 = new Dictionary<int, TagNodeCompound>();

		// Token: 0x04000538 RID: 1336
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;
	}
}
