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
	// Token: 0x020000BB RID: 187
	public class ReplaceBlocks
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00042930 File Offset: 0x00040B30
		public void Replace(object threadContext)
		{
			this.replaceBlockParameter_0 = (threadContext as ReplaceBlockParameter);
			try
			{
				this.Replace(this.replaceBlockParameter_0.Dimension, this.replaceBlockParameter_0.Region, this.replaceBlockParameter_0.ReplacementBlock, this.replaceBlockParameter_0.ReplaceChunkBlockList, this.replaceBlockParameter_0.OutFolderPath);
				this.replaceBlockParameter_0.ProcessState = ProcessStateType.Completed;
			}
			catch (Exception ex)
			{
				this.replaceBlockParameter_0.ProcessState = ProcessStateType.Error;
				MessageBox.Show(ex.Message, "Unexpected Error");
			}
			this.replaceBlockParameter_0.DoneEvent.Set();
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000429D8 File Offset: 0x00040BD8
		public void Replace(string dimension, string region, Block replacementBlock, Dictionary<int, List<BlockSearchResult>> replaceChunkBlockList, string workingFolder)
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
				if (ReplaceBlocks.func_0 == null)
				{
					ReplaceBlocks.func_0 = new Func<ChunkIndexEntry, int>(ReplaceBlocks.smethod_0);
				}
				list = source.OrderBy(ReplaceBlocks.func_0).ToList<ChunkIndexEntry>();
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
								if (replaceChunkBlockList.ContainsKey(chunkIndexEntry.ChunkIndex))
								{
									bool flag = false;
									byte[] array = Class46.smethod_48(chunkIndexEntry, byte_);
									object object_;
									if (array[0] == 10)
									{
										TagNodeCompound tagNodeCompound = Class46.smethod_34(array);
										flag = this.method_0(tagNodeCompound, replaceChunkBlockList[chunkIndexEntry.ChunkIndex], replacementBlock);
										object_ = tagNodeCompound;
									}
									else
									{
										MemoryStream stream = Class46.smethod_69(array);
										TU17Parser tu17Parser = new TU17Parser();
										TU17ChunkData tu17ChunkData = tu17Parser.ParseChunk(stream);
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
									if (this.replaceBlockParameter_0 != null)
									{
										this.replaceBlockParameter_0.ChunkProcessedCount++;
									}
								}
								else
								{
									Class46.smethod_13(byte_, chunkIndexEntry, binaryWriter);
								}
							}
						}
						Class46.smethod_31(binaryWriter, list);
					}
				}
				FileUtils.smethod_10(text);
				FileUtils.smethod_11(text2, text);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00042C54 File Offset: 0x00040E54
		private bool method_0(TagNodeCompound tagNodeCompound_0, List<BlockSearchResult> list_0, Block block_0)
		{
			bool result = true;
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			TagNodeByteArray tagNodeByteArray = tagNodeCompound["Blocks"] as TagNodeByteArray;
			TagNodeByteArray b = tagNodeCompound["Data"] as TagNodeByteArray;
			TagNode tagNode = tagNodeCompound["BlockLight"];
			TagNodeList tagNodeList_ = tagNodeCompound["TileEntities"] as TagNodeList;
			foreach (BlockSearchResult blockSearchResult in list_0)
			{
				int num = (blockSearchResult.Y < 128) ? 0 : 32768;
				int offset = num / 2;
				int num2 = (blockSearchResult.Y < 128) ? blockSearchResult.Y : (blockSearchResult.Y - 128);
				int localX = blockSearchResult.LocalX;
				int localZ = blockSearchResult.LocalZ;
				int index = localX << 11 | localZ << 7 | num2 + num;
				if ((int)tagNodeByteArray[index] == blockSearchResult.Id)
				{
					tagNodeByteArray[index] = (byte)block_0.Id;
					if (block_0.Data != -1)
					{
						nibbleSetters.RegionSet(b, localX, num2, localZ, block_0.Data, offset);
					}
					if (Class46.smethod_35(blockSearchResult.Id))
					{
						Class46.smethod_37(tagNodeCompound_0, blockSearchResult.X, blockSearchResult.Y, blockSearchResult.Z);
					}
					if (Class46.smethod_35((int)((byte)block_0.Id)))
					{
						Class46.smethod_40((int)((byte)block_0.Id), tagNodeList_, blockSearchResult.X, blockSearchResult.Y, blockSearchResult.Z, this.dictionary_0);
					}
				}
				else
				{
					result = false;
				}
			}
			if (this.replaceBlockParameter_0 != null)
			{
				this.replaceBlockParameter_0.BlockProcessedCount += list_0.Count;
			}
			return result;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00042E4C File Offset: 0x0004104C
		private bool method_1(TU17ChunkData tu17ChunkData_0, List<BlockSearchResult> list_0, Block block_0)
		{
			bool result = true;
			NibbleSetters nibbleSetters = new NibbleSetters();
			byte[] blocks = tu17ChunkData_0.Blocks;
			byte[] blockData = tu17ChunkData_0.BlockData;
			byte[] blockLight = tu17ChunkData_0.BlockLight;
			TagNodeList tagNodeList_ = tu17ChunkData_0.NBTData["TileEntities"] as TagNodeList;
			int x = tu17ChunkData_0.X;
			int z = tu17ChunkData_0.Z;
			foreach (BlockSearchResult blockSearchResult in list_0)
			{
				int localX = blockSearchResult.LocalX;
				int y = blockSearchResult.Y;
				int localZ = blockSearchResult.LocalZ;
				int num = localX * 16 | localZ | y * 256;
				if ((int)blocks[num] == blockSearchResult.Id)
				{
					blocks[num] = (byte)block_0.Id;
					if (block_0.Data != -1)
					{
						nibbleSetters.method_1(blockData, num, block_0.Data);
					}
					if (Class46.smethod_35(blockSearchResult.Id))
					{
						Class46.smethod_37(tu17ChunkData_0.NBTData, blockSearchResult.X, blockSearchResult.Y, blockSearchResult.Z);
					}
					if (Class46.smethod_35((int)((byte)block_0.Id)))
					{
						Class46.smethod_40((int)((byte)block_0.Id), tagNodeList_, blockSearchResult.X, blockSearchResult.Y, blockSearchResult.Z, this.dictionary_0);
					}
				}
				else
				{
					result = false;
				}
			}
			if (this.replaceBlockParameter_0 != null)
			{
				this.replaceBlockParameter_0.BlockProcessedCount += list_0.Count;
			}
			return result;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x04000543 RID: 1347
		private ReplaceBlockParameter replaceBlockParameter_0;

		// Token: 0x04000544 RID: 1348
		private Dictionary<int, TagNodeCompound> dictionary_0 = new Dictionary<int, TagNodeCompound>();

		// Token: 0x04000545 RID: 1349
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;
	}
}
