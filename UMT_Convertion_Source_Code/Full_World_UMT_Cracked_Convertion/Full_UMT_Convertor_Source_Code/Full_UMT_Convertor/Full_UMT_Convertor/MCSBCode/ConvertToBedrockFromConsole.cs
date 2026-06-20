using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.utils;
using MCPELevelDBI.workers;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000030 RID: 48
	public class ConvertToBedrockFromConsole
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0000F988 File Offset: 0x0000DB88
		public void ConvertRegionFileToBedrock(object threadContext)
		{
			ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters = threadContext as ConvertToPEFromConsoleParameters;
			if (convertToPEFromConsoleParameters != null)
			{
				this.convertToPEFromConsoleParameters_0 = convertToPEFromConsoleParameters;
				this.method_0();
				this.ConvertRegionFileToBedrock(convertToPEFromConsoleParameters.RegionFolder, convertToPEFromConsoleParameters.RegionName, convertToPEFromConsoleParameters.WorkingFolder, convertToPEFromConsoleParameters.ConvertParameters);
				convertToPEFromConsoleParameters.Records = this.list_0;
				convertToPEFromConsoleParameters.DoneEvent.Set();
				convertToPEFromConsoleParameters.Done = true;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		private void method_0()
		{
			Dictionary<int, BlockTranslation> dictionary = new Dictionary<int, BlockTranslation>();
			dictionary[0] = new BlockTranslation(0, 0, BlockMaster.MasterBlocksByName[BlockMaster.AIR]);
			dictionary[1] = new BlockTranslation(9, 0, BlockMaster.MasterBlocksByName[BlockMaster.WATER]);
			this.tagNodeList_0 = ConvertToBedrockFromConsole.BuildNBTPalette(dictionary);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000FA48 File Offset: 0x0000DC48
		public void WritePEBatch(object threadContext)
		{
			ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters = threadContext as ConvertToPEFromConsoleParameters;
			if (convertToPEFromConsoleParameters != null)
			{
				try
				{
					LevelDBWorker dbWorker = convertToPEFromConsoleParameters.DbWorker;
					if (convertToPEFromConsoleParameters.Records != null && convertToPEFromConsoleParameters.Records.Count > 0)
					{
						IntPtr batch = dbWorker.CreateWriteBatch();
						for (int i = 0; i < convertToPEFromConsoleParameters.Records.Count; i += 2)
						{
							dbWorker.WriteBatchPut(batch, convertToPEFromConsoleParameters.Records[i], convertToPEFromConsoleParameters.Records[i + 1]);
						}
						dbWorker.WriteBatch(batch);
						dbWorker.DestroyWriteBatch(batch);
						convertToPEFromConsoleParameters.Records.Clear();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
				}
				convertToPEFromConsoleParameters.Done = true;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000FB08 File Offset: 0x0000DD08
		public void ConvertRegionFileToBedrock(string regionFolder, string regionName, string workingFolderPath, ConvertParameters convertParameters)
		{
			List<ChunkIndexEntry> list = null;
			string text = Path.Combine(regionFolder, regionName + ".mcr");
			list = Class46.smethod_5(text);
			if (list == null || list.Count <= 0)
			{
				if (this.convertToPEFromConsoleParameters_0 != null)
				{
					this.convertToPEFromConsoleParameters_0.MissingChunkCount += Class23.smethod_1()[this.convertToPEFromConsoleParameters_0.DimensionName][regionName].Count;
				}
			}
			else
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (ConvertToBedrockFromConsole.func_0 == null)
				{
					ConvertToBedrockFromConsole.func_0 = new Func<ChunkIndexEntry, int>(ConvertToBedrockFromConsole.smethod_0);
				}
				list = source.OrderBy(ConvertToBedrockFromConsole.func_0).ToList<ChunkIndexEntry>();
				List<int> list2 = Class23.smethod_1()[this.convertToPEFromConsoleParameters_0.DimensionName][regionName];
				using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
				{
					for (int i = 0; i < list2.Count; i++)
					{
						ChunkIndexEntry chunkIndexEntry = list[list2[i]];
						if (this.convertToPEFromConsoleParameters_0 != null)
						{
							this.convertToPEFromConsoleParameters_0.Count++;
						}
						if (chunkIndexEntry.OldChunkOffset > 0U)
						{
							byte[] byte_ = Class46.smethod_51(chunkIndexEntry, binaryReader);
							try
							{
								this.method_1(byte_, convertParameters);
								if (this.convertToPEFromConsoleParameters_0 != null)
								{
									this.convertToPEFromConsoleParameters_0.ProcessedChunkCount++;
								}
							}
							catch (Exception)
							{
								if (this.convertToPEFromConsoleParameters_0 != null)
								{
									this.convertToPEFromConsoleParameters_0.InvalidChunkCount++;
								}
							}
						}
						else if (this.convertToPEFromConsoleParameters_0 != null)
						{
							this.convertToPEFromConsoleParameters_0.MissingChunkCount++;
						}
					}
				}
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		internal void method_1(byte[] byte_0, ConvertParameters convertParameters_0)
		{
			try
			{
				MemoryStream memoryStream = Class46.smethod_69(byte_0);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				memoryStream.ReadByte();
				memoryStream.Seek(0L, SeekOrigin.Begin);
				if (byte_0[0] == 10)
				{
					NbtTree nbtTree = new NbtTree(memoryStream);
					this.method_2(nbtTree.Root, convertParameters_0);
				}
				else if (byte_0[1] < 12)
				{
					TU17Parser tu17Parser = new TU17Parser();
					tu17Parser.ParseChunk(memoryStream);
					this.method_4(tu17Parser.TU17ChunkData_0, convertParameters_0);
				}
				else if (byte_0[1] == 12)
				{
					AquaticParser aquaticParser = new AquaticParser();
					aquaticParser.ParseChunk(memoryStream);
					this.method_6(aquaticParser.AquaticChunk, convertParameters_0);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000FD70 File Offset: 0x0000DF70
		private void method_2(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			int num = (TagNodeInt)tagNodeCompound["xPos"];
			int num2 = (TagNodeInt)tagNodeCompound["zPos"];
			TagNodeByteArray b = new TagNodeByteArray(new byte[256]);
			TagNodeByteArray b2 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("Biomes"))
			{
				b = (tagNodeCompound["Biomes"] as TagNodeByteArray);
			}
			if (tagNodeCompound.ContainsKey("HeightMap"))
			{
				b2 = (tagNodeCompound["HeightMap"] as TagNodeByteArray);
			}
			this.method_9((int)this.convertToPEFromConsoleParameters_0.Byte_0, num, num2, b, this.method_16(b2), convertParameters_0);
			TagNodeByteArray b3 = tagNodeCompound["Blocks"] as TagNodeByteArray;
			TagNodeByteArray b4 = tagNodeCompound["Data"] as TagNodeByteArray;
			this.method_3(num, num2, b3, b4);
			this.method_12((int)this.convertToPEFromConsoleParameters_0.Byte_0, num, num2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000FE8C File Offset: 0x0000E08C
		private void method_3(int int_0, int int_1, byte[] byte_0, byte[] byte_1)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			bool flag = false;
			for (int i = 15; i >= 0; i--)
			{
				int[] array = new int[4096];
				Dictionary<int, BlockTranslation> dictionary = new Dictionary<int, BlockTranslation>();
				BlockPaletteWorker blockPaletteWorker = new BlockPaletteWorker();
				int num = (i < 8) ? 0 : 32768;
				int num2 = (i < 8) ? i : (i - 8);
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int num3 = j * 256 + k * 16 + l;
							int num4 = j << 11 | k << 7 | l + (num2 << 4) + num;
							int consoleBlock = (int)byte_0[num4];
							int num5 = nibbleSetters.method_0(byte_1, num4);
							BlockTranslation bedrockPaletteEntryByConsole = blockPaletteWorker.GetBedrockPaletteEntryByConsole(dictionary, consoleBlock, (short)num5);
							if (bedrockPaletteEntryByConsole.id > 0)
							{
								flag = true;
							}
							int index = bedrockPaletteEntryByConsole.Index;
							array[num3] = index;
						}
					}
				}
				if (flag)
				{
					this.method_8(int_0, int_1, i, array, dictionary, false, null);
				}
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
		private void method_4(TU17ChunkData tu17ChunkData_0, ConvertParameters convertParameters_0)
		{
			this.method_9((int)this.convertToPEFromConsoleParameters_0.Byte_0, tu17ChunkData_0.X, tu17ChunkData_0.Z, tu17ChunkData_0.Biomes, this.method_16(tu17ChunkData_0.HeightMap), convertParameters_0);
			this.method_5(tu17ChunkData_0.X, tu17ChunkData_0.Z, tu17ChunkData_0.Blocks, tu17ChunkData_0.BlockData);
			this.method_12((int)this.convertToPEFromConsoleParameters_0.Byte_0, tu17ChunkData_0.X, tu17ChunkData_0.Z);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00010018 File Offset: 0x0000E218
		private void method_5(int int_0, int int_1, byte[] byte_0, byte[] byte_1)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			bool flag = false;
			for (int i = 15; i >= 0; i--)
			{
				int[] array = new int[4096];
				Dictionary<int, BlockTranslation> dictionary = new Dictionary<int, BlockTranslation>();
				BlockPaletteWorker blockPaletteWorker = new BlockPaletteWorker();
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int num = j * 256 + k * 16 + l;
							int num2 = i * 4096 + l * 256 + j * 16 + k;
							int consoleBlock = (int)byte_0[num2];
							int num3 = nibbleSetters.method_0(byte_1, num2);
							BlockTranslation bedrockPaletteEntryByConsole = blockPaletteWorker.GetBedrockPaletteEntryByConsole(dictionary, consoleBlock, (short)num3);
							if (bedrockPaletteEntryByConsole.id > 0)
							{
								flag = true;
							}
							int index = bedrockPaletteEntryByConsole.Index;
							array[num] = index;
						}
					}
				}
				if (flag)
				{
					this.method_8(int_0, int_1, i, array, dictionary, false, null);
				}
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00010114 File Offset: 0x0000E314
		private void method_6(AquaticChunkData aquaticChunkData_0, ConvertParameters convertParameters_0)
		{
			this.method_9((int)this.convertToPEFromConsoleParameters_0.Byte_0, aquaticChunkData_0.X, aquaticChunkData_0.Z, aquaticChunkData_0.Biomes, this.method_16(aquaticChunkData_0.HeightMap), convertParameters_0);
			this.method_7(aquaticChunkData_0.X, aquaticChunkData_0.Z, aquaticChunkData_0.Blocks, aquaticChunkData_0.Submerged);
			this.method_12((int)this.convertToPEFromConsoleParameters_0.Byte_0, aquaticChunkData_0.X, aquaticChunkData_0.Z);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001018C File Offset: 0x0000E38C
		private void method_7(int int_0, int int_1, byte[] byte_0, byte[] byte_1)
		{
			bool flag = false;
			bool bool_ = false;
			for (int i = 15; i >= 0; i--)
			{
				int[] array = new int[4096];
				int[] array2 = new int[4096];
				Dictionary<int, BlockTranslation> dictionary = new Dictionary<int, BlockTranslation>();
				BlockPaletteWorker blockPaletteWorker = new BlockPaletteWorker();
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int num = j * 256 + k * 16 + l;
							int num2 = i * 32 + j * 8192 + k * 512 + l * 2;
							int consoleBlock = ((int)byte_0[num2 + 1] << 4) + ((byte_0[num2] & 240) >> 4);
							int num3 = (int)(byte_0[num2] & 15);
							int num4 = ((int)byte_1[num2 + 1] << 4) + ((byte_1[num2] & 240) >> 4);
							if (num4 > 0)
							{
								bool_ = true;
								array2[num] = 1;
							}
							BlockTranslation bedrockPaletteEntryByConsole = blockPaletteWorker.GetBedrockPaletteEntryByConsole(dictionary, consoleBlock, (short)num3);
							if (bedrockPaletteEntryByConsole.id > 0)
							{
								flag = true;
							}
							int index = bedrockPaletteEntryByConsole.Index;
							array[num] = index;
						}
					}
				}
				if (flag)
				{
					this.method_8(int_0, int_1, i, array, dictionary, bool_, array2);
				}
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000102D0 File Offset: 0x0000E4D0
		private void method_8(int int_0, int int_1, int int_2, int[] int_3, Dictionary<int, BlockTranslation> dictionary_1, bool bool_0, int[] int_4)
		{
			TagNodeCompound tagNodeCompound = new TagNodeCompound();
			tagNodeCompound["Y"] = new TagNodeByte(0);
			tagNodeCompound["Version"] = new TagNodeByte(8);
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
			tagNodeCompound2["Palette"] = ConvertToBedrockFromConsole.BuildNBTPalette(dictionary_1);
			tagNodeCompound2["BlockStates"] = new TagNodeIntArray(int_3);
			tagNodeList.Add(tagNodeCompound2);
			if (bool_0)
			{
				TagNodeCompound tagNodeCompound3 = new TagNodeCompound();
				tagNodeCompound3["Palette"] = this.tagNodeList_0;
				tagNodeCompound3["BlockStates"] = new TagNodeIntArray(int_4);
				tagNodeList.Add(tagNodeCompound3);
			}
			tagNodeCompound["BlockStorage"] = tagNodeList;
			byte[] byte_ = ConvertToBedrockFromConsole.BuildBlockStateChunk(tagNodeCompound);
			byte[] byte_2 = this.method_13((int)this.convertToPEFromConsoleParameters_0.Byte_0, int_0, int_1, 47, new byte?((byte)int_2));
			this.method_14(byte_2, byte_);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000103B0 File Offset: 0x0000E5B0
		public static TagNodeList BuildNBTPalette(Dictionary<int, BlockTranslation> palette)
		{
			List<BlockTranslation> list = palette.Values.ToList<BlockTranslation>();
			IEnumerable<BlockTranslation> source = list;
			if (ConvertToBedrockFromConsole.func_1 == null)
			{
				ConvertToBedrockFromConsole.func_1 = new Func<BlockTranslation, int>(ConvertToBedrockFromConsole.smethod_1);
			}
			list = source.OrderBy(ConvertToBedrockFromConsole.func_1).ToList<BlockTranslation>();
			return ConvertToBedrockFromConsole.BuildNBTPalette(list);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public static TagNodeList BuildNBTPalette(List<BlockTranslation> blockTranslations)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			foreach (BlockTranslation blockTranslation in blockTranslations)
			{
				TagNodeCompound tagNodeCompound = new TagNodeCompound();
				tagNodeCompound["name"] = new TagNodeString(blockTranslation.masterBlock.bedrock.name);
				tagNodeCompound["val"] = new TagNodeShort((short)blockTranslation.data);
				tagNodeList.Add(tagNodeCompound);
			}
			return tagNodeList;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00010490 File Offset: 0x0000E690
		public static byte[] BuildBlockStateChunk(TagNodeCompound node)
		{
			BlockStateLayer[] array = new BlockStateLayer[2];
			if (!node.ContainsKey("BlockStorage") || !(node["BlockStorage"] is TagNodeList))
			{
				return null;
			}
			TagNodeList tagNodeList = node["BlockStorage"] as TagNodeList;
			int count = tagNodeList.Count;
			for (int i = 0; i < count; i++)
			{
				TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
				int count2 = ((TagNodeList)tagNodeCompound["Palette"]).Count;
				int num = PEUtility.PaletteBitsPerBlock(count2);
				int num2 = (int)Math.Floor(32 / num);
				int num3 = (int)Math.Ceiling(4096.0 / (double)num2);
				int num4 = (1 << num) - 1;
				int[] data = ((TagNodeIntArray)tagNodeCompound["BlockStates"]).Data;
				MemoryStream memoryStream = new MemoryStream();
				int num5 = 0;
				for (int j = 0; j < num3; j++)
				{
					uint num6 = 0U;
					List<int> list = new List<int>();
					int num7 = 0;
					while (num7 < num2 && num5 < 4096)
					{
						list.Add(data[num5]);
						num5++;
						num7++;
					}
					for (int k = list.Count - 1; k >= 0; k--)
					{
						num6 <<= num;
						int num8 = list[k];
						num6 |= (uint)(num8 & num4);
					}
					byte[] bytes = BitConverter.GetBytes(num6);
					memoryStream.Write(bytes, 0, bytes.Length);
				}
				array[i] = new BlockStateLayer
				{
					bitsPerBlock = num,
					blocks = memoryStream.ToArray(),
					palette = (TagNodeList)tagNodeCompound["Palette"]
				};
			}
			MemoryStream memoryStream2 = new MemoryStream();
			memoryStream2.WriteByte(8);
			memoryStream2.WriteByte((byte)count);
			memoryStream2.WriteByte((byte)(array[0].bitsPerBlock << 1));
			memoryStream2.Write(array[0].blocks, 0, array[0].blocks.Length);
			PEUtility.WritePaletteEntries(memoryStream2, array[0].palette);
			if (count == 2)
			{
				memoryStream2.WriteByte((byte)(array[1].bitsPerBlock << 1));
				memoryStream2.Write(array[1].blocks, 0, array[1].blocks.Length);
				PEUtility.WritePaletteEntries(memoryStream2, array[1].palette);
			}
			return memoryStream2.ToArray();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000106E8 File Offset: 0x0000E8E8
		private void method_9(int int_0, int int_1, int int_2, byte[] byte_0, int[] int_3, ConvertParameters convertParameters_0)
		{
			Class47 @class = new Class47(false);
			byte[] array = new byte[256];
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num = j << 4 | i;
					int num2 = j << 4 | i;
					byte b = byte_0[num];
					if (b >= 44 && b <= 50)
					{
						b -= 4;
					}
					if (convertParameters_0.ReplaceBiomes)
					{
						int k = 0;
						while (k < convertParameters_0.BiomeChanges.Count)
						{
							if (convertParameters_0.BiomeChanges[k].FromBiome != 1000)
							{
								if (convertParameters_0.BiomeChanges[k].FromBiome != (int)b)
								{
									k++;
									continue;
								}
							}
							b = (byte)convertParameters_0.BiomeChanges[k].ToBiome;
							break;
						}
					}
					array[num2] = b;
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			for (int l = 0; l < 256; l++)
			{
				@class.method_9((short)int_3[l], memoryStream);
			}
			memoryStream.Write(array, 0, array.Length);
			byte[] byte_ = this.method_13(int_0, int_1, int_2, 45, null);
			this.method_14(byte_, memoryStream.ToArray());
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00010824 File Offset: 0x0000EA24
		private void method_10(int int_0, int int_1, int int_2, TagNodeList tagNodeList_1)
		{
			MemoryStream memoryStream = new MemoryStream();
			for (int i = 0; i < tagNodeList_1.Count; i++)
			{
				MemoryStream memoryStream2 = new MemoryStream();
				TagNodeCompound tree = tagNodeList_1[i] as TagNodeCompound;
				new NbtTree(tree)
				{
					UseBigEndian = false
				}.WriteTo(memoryStream2);
				memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			}
			if (memoryStream.Length > 0L)
			{
				byte[] byte_ = this.method_13(int_0, int_1, int_2, 49, null);
				this.method_14(byte_, memoryStream.ToArray());
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000108C0 File Offset: 0x0000EAC0
		private void method_11(int int_0, int int_1, int int_2, TagNodeList tagNodeList_1)
		{
			MemoryStream memoryStream = new MemoryStream();
			for (int i = 0; i < tagNodeList_1.Count; i++)
			{
				MemoryStream memoryStream2 = new MemoryStream();
				TagNodeCompound tree = tagNodeList_1[i] as TagNodeCompound;
				new NbtTree(tree)
				{
					UseBigEndian = false
				}.WriteTo(memoryStream2);
				memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			}
			if (memoryStream.Length > 0L)
			{
				byte[] byte_ = this.method_13(int_0, int_1, int_2, 50, null);
				this.method_14(byte_, memoryStream.ToArray());
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001095C File Offset: 0x0000EB5C
		private void method_12(int int_0, int int_1, int int_2)
		{
			byte[] byte_ = new byte[]
			{
				7
			};
			byte[] byte_2 = this.method_13(int_0, int_1, int_2, 118, null);
			this.method_14(byte_2, byte_);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00010994 File Offset: 0x0000EB94
		private byte[] method_13(int int_0, int int_1, int int_2, byte byte_0, byte? nullable_0 = null)
		{
			if (this.convertToPEFromConsoleParameters_0.ConvertParameters.UseConvertOffsets)
			{
				int_1 = Class46.smethod_76(int_1, this.convertToPEFromConsoleParameters_0.ConvertParameters.XRegionOffset);
				int_2 = Class46.smethod_76(int_2, this.convertToPEFromConsoleParameters_0.ConvertParameters.ZRegionOffset);
			}
			return PEUtility.BuildChunkKey(int_0, int_1, int_2, byte_0, nullable_0);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00003174 File Offset: 0x00001374
		private void method_14(byte[] byte_0, byte[] byte_1)
		{
			this.list_0.Add(byte_0);
			this.list_0.Add(byte_1);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000109F4 File Offset: 0x0000EBF4
		private TagNodeCompound method_15(int int_0, int int_1, int int_2, TagNodeList tagNodeList_1)
		{
			TagNodeCompound result = null;
			for (int i = 0; i < tagNodeList_1.Count; i++)
			{
				TagNodeCompound tagNodeCompound = tagNodeList_1[i] as TagNodeCompound;
				int num = tagNodeCompound["x"] as TagNodeInt;
				int num2 = tagNodeCompound["y"] as TagNodeInt;
				int num3 = tagNodeCompound["z"] as TagNodeInt;
				if (num == int_0 && num2 == int_1 && num3 == int_2)
				{
					result = tagNodeCompound;
					break;
				}
			}
			return result;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00010A7C File Offset: 0x0000EC7C
		private int[] method_16(byte[] byte_0)
		{
			int[] array = new int[byte_0.Length];
			for (int i = 0; i < byte_0.Length; i++)
			{
				array[i] = (int)byte_0[i];
			}
			return array;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000031B4 File Offset: 0x000013B4
		[CompilerGenerated]
		private static int smethod_1(BlockTranslation blockTranslation_0)
		{
			return blockTranslation_0.Index;
		}

		// Token: 0x040000E9 RID: 233
		public static List<ConversionChest> activeChests;

		// Token: 0x040000EA RID: 234
		private List<byte[]> list_0 = new List<byte[]>();

		// Token: 0x040000EB RID: 235
		private ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters_0;

		// Token: 0x040000EC RID: 236
		private Dictionary<int, List<int>> dictionary_0 = new Dictionary<int, List<int>>();

		// Token: 0x040000ED RID: 237
		private TagNodeList tagNodeList_0;

		// Token: 0x040000EE RID: 238
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		private static Func<BlockTranslation, int> func_1;
	}
}
