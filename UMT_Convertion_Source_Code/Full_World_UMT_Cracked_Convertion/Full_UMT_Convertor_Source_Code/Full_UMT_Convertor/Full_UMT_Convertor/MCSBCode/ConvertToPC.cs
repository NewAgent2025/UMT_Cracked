using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x0200008A RID: 138
	public class ConvertToPC
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00030DD8 File Offset: 0x0002EFD8
		public void ConvertRegionFileToPC(object threadContext)
		{
			ConvertToPCParameters convertToPCParameters = threadContext as ConvertToPCParameters;
			if (convertToPCParameters != null)
			{
				this.convertToPCParameters_0 = convertToPCParameters;
				string newRegionName = convertToPCParameters.RegionName;
				if (convertToPCParameters.ConvertParameters.UseConvertOffsets)
				{
					newRegionName = string.Format("r.{0}.{1}", convertToPCParameters.Region.RX + convertToPCParameters.ConvertParameters.XRegionOffset, convertToPCParameters.Region.RZ + convertToPCParameters.ConvertParameters.ZRegionOffset);
				}
				this.ConvertRegionFileToPC(convertToPCParameters.Region, convertToPCParameters.RegionFolder, convertToPCParameters.RegionName, newRegionName, convertToPCParameters.WorkingFolder, convertToPCParameters.ConvertParameters);
				convertToPCParameters.DoneEvent.Set();
				convertToPCParameters.Done = true;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00030E88 File Offset: 0x0002F088
		public void ConvertRegionFileToPC(IndexEntry region, string regionFolder, string origRegionName, string NewRegionName, string workingFolderPath, ConvertParameters convertParameters)
		{
			List<ChunkIndexEntry> list = null;
			string text = workingFolderPath + Working.smethod_4() + region.FilePath;
			string str = (regionFolder.ToLower() == "region") ? regionFolder : (regionFolder + "\\region");
			string text2 = convertParameters.ProcessWorldFolder + str + "\\";
			string text3 = text2 + NewRegionName + ".mca";
			list = Class46.smethod_5(text);
			this.bool_0 = Utils.GetQuickBlocksLookup(convertParameters);
			this.int_0 = Working.smethod_10();
			this.int_1 = Working.smethod_12();
			FileUtils.smethod_9(text2);
			if (list == null || list.Count <= 0)
			{
				if (this.convertToPCParameters_0 != null)
				{
					this.convertToPCParameters_0.MissingChunkCount += Class23.smethod_1()[regionFolder][origRegionName].Count;
				}
				Class46.smethod_33(text3);
			}
			else
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (ConvertToPC.func_0 == null)
				{
					ConvertToPC.func_0 = new Func<ChunkIndexEntry, int>(ConvertToPC.smethod_0);
				}
				list = source.OrderBy(ConvertToPC.func_0).ToList<ChunkIndexEntry>();
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text3, FileMode.Create)))
				{
					Class46.smethod_25(binaryWriter);
					List<int> list2 = Class23.smethod_1()[regionFolder][origRegionName];
					using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
					{
						for (int i = 0; i < list2.Count; i++)
						{
							ChunkIndexEntry chunkIndexEntry = list[list2[i]];
							if (this.convertToPCParameters_0 != null)
							{
								this.convertToPCParameters_0.Count++;
							}
							if (chunkIndexEntry.OldChunkOffset > 0U)
							{
								byte[] array = Class46.smethod_51(chunkIndexEntry, binaryReader);
								array = this.method_0(array, convertParameters);
								if (array == null || array.Length <= 0)
								{
									if (this.convertToPCParameters_0 != null)
									{
										this.convertToPCParameters_0.InvalidChunkCount++;
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
									if (this.convertToPCParameters_0 != null)
									{
										this.convertToPCParameters_0.ProcessedChunkCount++;
									}
								}
							}
							else if (this.convertToPCParameters_0 != null)
							{
								this.convertToPCParameters_0.MissingChunkCount++;
							}
						}
					}
					Class46.smethod_31(binaryWriter, list);
				}
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00031178 File Offset: 0x0002F378
		internal byte[] method_0(byte[] byte_0, ConvertParameters convertParameters_0)
		{
			byte[] array = null;
			try
			{
				MemoryStream memoryStream = Class46.smethod_69(byte_0);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				int num = memoryStream.ReadByte();
				int num2 = memoryStream.ReadByte();
				memoryStream.Seek(0L, SeekOrigin.Begin);
				if (num == 10)
				{
					NbtTree nbtTree = new NbtTree(memoryStream);
					array = this.method_10(nbtTree.Root, convertParameters_0);
				}
				else if (num2 <= 11)
				{
					TU17Parser tu17Parser = new TU17Parser();
					tu17Parser.ParseChunk(memoryStream);
					array = this.method_9(tu17Parser.TU17ChunkData_0, convertParameters_0);
				}
				else
				{
					AquaticParser aquaticParser = new AquaticParser();
					aquaticParser.ParseChunk(memoryStream);
					array = this.method_1(aquaticParser.AquaticChunk, convertParameters_0);
				}
				if (array != null)
				{
					array = Class46.smethod_63(array);
					byte[] bytes = BitConverter.GetBytes(array.Length + 1);
					if (BitConverter.IsLittleEndian)
					{
						Array.Reverse(bytes);
					}
					memoryStream = new MemoryStream();
					memoryStream.Write(bytes, 0, bytes.Length);
					memoryStream.WriteByte(2);
					memoryStream.Write(array, 0, array.Length);
					array = memoryStream.ToArray();
				}
			}
			catch (Exception)
			{
			}
			return array;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00031290 File Offset: 0x0002F490
		private byte[] method_1(AquaticChunkData aquaticChunkData_0, ConvertParameters convertParameters_0)
		{
			TagNodeCompound tagNodeCompound = new TagNodeCompound();
			tagNodeCompound["AIR"] = new TagNodeByteArray(new byte[0]);
			tagNodeCompound["LIQUID"] = new TagNodeByteArray(new byte[0]);
			TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
			tagNodeCompound2["References"] = new TagNodeByteArray(new byte[0]);
			tagNodeCompound2["Starts"] = new TagNodeByteArray(new byte[0]);
			TagNodeCompound value = new TagNodeCompound();
			TagNodeList value2 = new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeList value3 = new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeIntArray tagNodeIntArray = new TagNodeIntArray(new int[256]);
			if (aquaticChunkData_0.Biomes != null)
			{
				for (int i = 0; i < 16; i++)
				{
					for (int j = 0; j < 16; j++)
					{
						tagNodeIntArray[j << 4 | i] = (int)aquaticChunkData_0.Biomes[i * 16 + j];
					}
				}
			}
			if (convertParameters_0.ReplaceBiomes)
			{
				for (int k = 0; k < tagNodeIntArray.Length; k++)
				{
					int l = 0;
					while (l < convertParameters_0.BiomeChanges.Count)
					{
						if (convertParameters_0.BiomeChanges[l].FromBiome != 1000)
						{
							if (tagNodeIntArray[k] != convertParameters_0.BiomeChanges[l].FromBiome)
							{
								l++;
								continue;
							}
						}
						tagNodeIntArray[k] = (int)((byte)convertParameters_0.BiomeChanges[l].ToBiome);
						break;
					}
				}
			}
			int d = aquaticChunkData_0.X;
			int d2 = aquaticChunkData_0.Z;
			if (this.convertToPCParameters_0.ConvertParameters.UseConvertOffsets)
			{
				d = Class46.smethod_76(d, this.convertToPCParameters_0.ConvertParameters.XRegionOffset);
				d2 = Class46.smethod_76(d2, this.convertToPCParameters_0.ConvertParameters.ZRegionOffset);
			}
			TagNodeList value4 = this.method_2(aquaticChunkData_0.Blocks, aquaticChunkData_0.Submerged);
			TagNodeCompound tagNodeCompound3 = new TagNodeCompound();
			tagNodeCompound3.Add("xPos", new TagNodeInt(d));
			tagNodeCompound3.Add("zPos", new TagNodeInt(d2));
			tagNodeCompound3.Add("Heightmaps", value);
			tagNodeCompound3.Add("CarvingMasks", tagNodeCompound);
			tagNodeCompound3.Add("Structures", tagNodeCompound2);
			tagNodeCompound3.Add("Sections", value4);
			tagNodeCompound3.Add("Biomes", tagNodeIntArray);
			tagNodeCompound3.Add("Entities", value3);
			tagNodeCompound3.Add("TileEntities", value2);
			tagNodeCompound3.Add("LastUpdate", new TagNodeLong(0L));
			tagNodeCompound3.Add("InhabitedTime", new TagNodeLong(0L));
			tagNodeCompound3.Add("Status", new TagNodeString("postprocessed"));
			MemoryStream memoryStream = new MemoryStream();
			new NbtTree
			{
				UseBigEndian = true,
				Root = 
				{
					{
						"Level",
						tagNodeCompound3
					},
					{
						"DataVersion",
						new TagNodeInt(1976)
					}
				}
			}.WriteTo(memoryStream);
			return memoryStream.ToArray();
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000315A8 File Offset: 0x0002F7A8
		private TagNodeList method_2(byte[] byte_0, byte[] byte_1)
		{
			ConvertParameters convertParameters = this.convertToPCParameters_0.ConvertParameters;
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			byte[] array = new byte[2048];
			byte_0.Skip(32768).Take(16384).ToArray<byte>();
			for (int i = 0; i < 16; i++)
			{
				new TagNodeList(TagType.TAG_COMPOUND);
				new List<int>();
				List<Class3> list = new List<Class3>();
				list.Add(new Class3("minecraft:air", null));
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				dictionary[0] = 0;
				int[] array2 = new int[4096];
				this.int_3 = i;
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int num = i * 32 + j * 8192 + k * 512 + l * 2;
							int int_ = ((int)byte_0[num + 1] << 4) + ((byte_0[num] & 240) >> 4);
							int num2 = (int)(byte_0[num] & 15);
							int num3 = ((int)byte_1[num + 1] << 4) + ((byte_1[num] & 240) >> 4);
							int num4 = this.method_6(int_, (byte)num2, num3 > 0, j, l, k, byte_0, list, dictionary);
							int num5 = l * 256 + k * 16 + j;
							array2[num5] = num4;
							nibbleSetters.method_1(array, num5, (num2 == 0) ? 15 : 0);
						}
					}
				}
				TagNodeCompound tagNodeCompound = new TagNodeCompound();
				tagNodeCompound["Y"] = new TagNodeByte((byte)i);
				int int_2 = ConvertToPC.JavaPaletteBitsPerBlock(list.Count);
				long[] d = this.method_4(array2, int_2);
				TagNodeList value = this.method_5(list);
				tagNodeCompound["BlockStates"] = new TagNodeLongArray(d);
				tagNodeCompound["BlockLight"] = new TagNodeByteArray(new byte[2048]);
				tagNodeCompound["SkyLight"] = new TagNodeByteArray(array);
				tagNodeCompound["Palette"] = value;
				tagNodeList.Add(tagNodeCompound);
			}
			return tagNodeList;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000317C8 File Offset: 0x0002F9C8
		private void method_3(List<Class3> list_0)
		{
			foreach (Class3 @class in list_0)
			{
				if (@class.Properties != null)
				{
					foreach (string text in @class.Properties.Keys)
					{
						if (text == "waterlogged")
						{
							@class.Properties[text].Value == "true";
						}
					}
				}
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00031884 File Offset: 0x0002FA84
		private long[] method_4(int[] int_5, int int_6)
		{
			List<long> list = new List<long>();
			uint num = (1U << int_6) - 1U;
			long num2 = 0L;
			int num3 = 0;
			for (int i = 0; i < 4096; i++)
			{
				long num4 = (long)int_5[i] & (long)((ulong)num);
				if (num3 + int_6 <= 64)
				{
					num4 <<= num3;
					num2 |= num4;
					num3 += int_6;
					if (num3 >= 64)
					{
						list.Add(num2);
						num2 = 0L;
						num3 = 0;
					}
				}
				else
				{
					int num5 = 64 - num3;
					uint num6 = (1U << num5) - 1U;
					num4 &= (long)((ulong)num6);
					num2 |= num4 << num3;
					list.Add(num2);
					int num7 = int_6 - num5;
					uint num8 = (1U << num7) - 1U;
					num4 = ((long)int_5[i] & (long)((ulong)num));
					num2 = (num4 >> num5 & (long)((ulong)num8));
					num3 = num7;
				}
			}
			if (num3 > 0)
			{
				list.Add(num2);
			}
			return list.ToArray();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00031984 File Offset: 0x0002FB84
		private TagNodeList method_5(List<Class3> list_0)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = 0; i < list_0.Count; i++)
			{
				TagNodeCompound tagNodeCompound = new TagNodeCompound();
				tagNodeCompound["Name"] = new TagNodeString(list_0[i].Name);
				if (list_0[i].Properties != null && list_0[i].Properties.Count > 0)
				{
					TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
					foreach (string key in list_0[i].Properties.Keys)
					{
						tagNodeCompound2[key] = new TagNodeString(list_0[i].Properties[key].Value);
					}
					tagNodeCompound["Properties"] = tagNodeCompound2;
				}
				tagNodeList.Add(tagNodeCompound);
			}
			return tagNodeList;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00031A84 File Offset: 0x0002FC84
		private int method_6(int int_5, byte byte_0, bool bool_1, int int_6, int int_7, int int_8, byte[] byte_1, List<Class3> list_0, Dictionary<int, int> dictionary_1)
		{
			if (int_5 > 255)
			{
				int_5 = 3;
				byte_0 = 0;
			}
			int key = int_5 * 1000 + (int)(byte_0 * 10) + (bool_1 ? 1 : 0);
			if (dictionary_1.ContainsKey(key))
			{
				return dictionary_1[key];
			}
			Class3 @class = this.method_7(int_5, byte_0, int_6, int_7, int_8);
			if (bool_1)
			{
				bool flag = false;
				if (@class.Properties != null && @class.Properties.ContainsKey("waterlogged"))
				{
					@class.Properties["waterlogged"].Value = "true";
				}
				if (!flag)
				{
					@class.Properties.Add("waterlogged", new BlockStateProperty("waterlogged", "true"));
				}
			}
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].Name == @class.Name)
				{
					bool flag2 = true;
					Dictionary<string, BlockStateProperty> properties = list_0[i].Properties;
					if (properties != null || @class.Properties.Count <= 0)
					{
						using (Dictionary<string, BlockStateProperty>.KeyCollection.Enumerator enumerator = @class.Properties.Keys.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								string key2 = enumerator.Current;
								if (!properties.ContainsKey(key2) || properties[key2].Value != @class.Properties[key2].Value)
								{
									flag2 = false;
									break;
								}
							}
							goto IL_133;
						}
						goto IL_12A;
					}
					flag2 = false;
					IL_133:
					if (flag2)
					{
						return i;
					}
				}
				IL_12A:;
			}
			list_0.Add(@class);
			dictionary_1[key] = list_0.Count - 1;
			return list_0.Count - 1;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00031C48 File Offset: 0x0002FE48
		private Class3 method_7(int int_5, byte byte_0, int int_6, int int_7, int int_8)
		{
			Class3 @class = new Class3();
			MasterBlock masterBlockByConsole = BlockMaster.GetMasterBlockByConsole(int_5, (short)byte_0);
			@class.Name = masterBlockByConsole.java.name;
			string blockStates = masterBlockByConsole.blockStates;
			if (!string.IsNullOrWhiteSpace(blockStates) && BlockMaster.DataStates.ContainsKey(blockStates))
			{
				@class.Properties = this.method_8(byte_0, BlockMaster.DataStates[blockStates].blockStates);
			}
			if (blockStates == "chest")
			{
				int num = (this.int_2 >= 0) ? (this.int_2 * 16) : ((this.int_2 + 1) * 16);
				int num2 = (this.int_4 >= 0) ? (this.int_4 * 16) : ((this.int_4 + 1) * 16);
				int x = num + ((this.int_2 >= 0) ? int_6 : ((16 - int_6) * -1));
				int z = num2 + ((this.int_4 >= 0) ? int_8 : ((16 - int_8) * -1));
				x = Class46.smethod_77(x, this.convertToPCParameters_0.ConvertParameters.XRegionOffset);
				z = Class46.smethod_77(z, this.convertToPCParameters_0.ConvertParameters.ZRegionOffset);
				int y = this.int_3 * 16 + int_7;
				string value = JavaChestConnections.ProcessChest(x, y, z, (short)byte_0, this.convertToPCParameters_0.Chests);
				@class.Properties["type"].Value = value;
			}
			return @class;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00031DC4 File Offset: 0x0002FFC4
		private Dictionary<string, BlockStateProperty> method_8(byte byte_0, List<BlockStateDefinition> list_0)
		{
			Dictionary<string, BlockStateProperty> dictionary = new Dictionary<string, BlockStateProperty>();
			foreach (BlockStateDefinition blockStateDefinition in list_0)
			{
				if (string.IsNullOrWhiteSpace(blockStateDefinition.name) || blockStateDefinition.bedrockMask <= 0)
				{
					if (!string.IsNullOrWhiteSpace(blockStateDefinition.name) && blockStateDefinition.bedrockMask == 0 && !dictionary.ContainsKey(blockStateDefinition.name))
					{
						BlockStateProperty value = new BlockStateProperty(blockStateDefinition.name, blockStateDefinition.defaultValue);
						dictionary[blockStateDefinition.name] = value;
					}
				}
				else
				{
					int num = (int)byte_0 & blockStateDefinition.bedrockMask;
					foreach (BlockStateValue blockStateValue in blockStateDefinition.states)
					{
						if (num == blockStateValue.bedrock)
						{
							BlockStateProperty value2 = new BlockStateProperty(blockStateDefinition.name, blockStateValue.javaPropertyValue);
							dictionary[blockStateDefinition.name] = value2;
							break;
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00031ECC File Offset: 0x000300CC
		public static int JavaPaletteBitsPerBlock(int paletteCount)
		{
			int result = 0;
			if (paletteCount <= 16)
			{
				result = 4;
			}
			else if (paletteCount <= 32)
			{
				result = 5;
			}
			else if (paletteCount <= 64)
			{
				result = 6;
			}
			else if (paletteCount <= 128)
			{
				result = 7;
			}
			else if (paletteCount <= 256)
			{
				result = 8;
			}
			else if (paletteCount <= 512)
			{
				result = 9;
			}
			else if (paletteCount <= 1024)
			{
				result = 10;
			}
			else if (paletteCount <= 2048)
			{
				result = 11;
			}
			else if (paletteCount <= 4096)
			{
				result = 12;
			}
			else if (paletteCount <= 8192)
			{
				result = 13;
			}
			else if (paletteCount <= 16384)
			{
				result = 14;
			}
			else if (paletteCount <= 32768)
			{
				result = 15;
			}
			else if (paletteCount <= 65536)
			{
				result = 16;
			}
			return result;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00031F7C File Offset: 0x0003017C
		private byte[] method_9(TU17ChunkData tu17ChunkData_0, ConvertParameters convertParameters_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			int x = tu17ChunkData_0.X;
			int z = tu17ChunkData_0.Z;
			int num = (x >= 0) ? (x * 16) : ((x + 1) * 16);
			int num2 = (z >= 0) ? (z * 16) : ((z + 1) * 16);
			byte[] blocks = tu17ChunkData_0.Blocks;
			byte[] blockData = tu17ChunkData_0.BlockData;
			byte[] blockLight = tu17ChunkData_0.BlockLight;
			byte[] skyLight = tu17ChunkData_0.SkyLight;
			int num3 = (blocks.Length == 65536) ? 16 : 8;
			int i = 0;
			while (i < num3)
			{
				int num4 = i * 4096;
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				int num5 = i * 16;
				AnvilSection anvilSection = new AnvilSection(i);
				for (int j = 0; j < 16; j++)
				{
					int num6 = j * 256;
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							byte b = blocks[num4 + num6 + k * 16 + l];
							int pos = k * 16 | num5 * 256 | l;
							int num7 = nibbleSetters.method_0(blockData, pos);
							int num8 = nibbleSetters.method_0(blockLight, pos);
							int num9 = nibbleSetters.method_0(skyLight, pos);
							if (convertParameters_0.ReplaceBlocks && (this.bool_0[(int)b] || this.bool_0[256]))
							{
								int m = 0;
								while (m < convertParameters_0.BlockChanges.Count)
								{
									if (convertParameters_0.BlockChanges[m].FromBlock == -1)
									{
										goto IL_27B;
									}
									if ((int)b == convertParameters_0.BlockChanges[m].FromBlock)
									{
										goto IL_27B;
									}
									IL_2B0:
									m++;
									continue;
									IL_27B:
									if ((!convertParameters_0.BlockChanges[m].Layers.Contains(num5) && !convertParameters_0.BlockChanges[m].Layers.Contains(-1)) || (!convertParameters_0.BlockChanges[m].FromData.Contains(-1) && !convertParameters_0.BlockChanges[m].FromData.Contains(num7)))
									{
										goto IL_2B0;
									}
									int num10 = (int)b;
									b = (byte)convertParameters_0.BlockChanges[m].ToBlock;
									if (convertParameters_0.BlockChanges[m].ToData != -1)
									{
										num7 = convertParameters_0.BlockChanges[m].ToData;
									}
									if (convertParameters_0.BlockChanges[m].ToBlockLight != -1)
									{
										num8 = convertParameters_0.BlockChanges[m].ToBlockLight;
									}
									if (Class46.smethod_35(num10))
									{
										int num11 = num + ((x >= 0) ? k : ((16 - k) * -1));
										int num12 = num2 + ((z >= 0) ? l : ((16 - l) * -1));
										Class46.smethod_37(tu17ChunkData_0.NBTData, num11, num5, num12);
										break;
									}
									break;
								}
							}
							if (b != 0)
							{
								flag = true;
							}
							if (num9 != 255)
							{
								flag2 = true;
							}
							if (num8 != 0)
							{
								flag3 = true;
							}
							anvilSection.Blocks[num6 | l << 4 | k] = (int)b;
							nibbleSetters.AnvilSet(anvilSection.Data.Data, k, j, l, num7);
							nibbleSetters.AnvilSet(anvilSection.SkyLight.Data, k, j, l, num9);
							nibbleSetters.AnvilSet(anvilSection.BlockLight.Data, k, j, l, num8);
						}
					}
					num5++;
				}
				if (flag || flag2)
				{
					goto IL_107;
				}
				if (flag3)
				{
					goto IL_107;
				}
				IL_114:
				i++;
				continue;
				IL_107:
				tagNodeList.Add(anvilSection.BuildTree());
				goto IL_114;
			}
			TagNodeIntArray tagNodeIntArray = new TagNodeIntArray(new int[256]);
			if (tu17ChunkData_0.HeightMap != null)
			{
				for (int n = 0; n < 256; n++)
				{
					tagNodeIntArray[n] = (int)tu17ChunkData_0.HeightMap[n];
				}
			}
			TagNodeByteArray tagNodeByteArray = new TagNodeByteArray(new byte[256]);
			if (tu17ChunkData_0.Biomes != null)
			{
				for (int num13 = 0; num13 < 16; num13++)
				{
					for (int num14 = 0; num14 < 16; num14++)
					{
						tagNodeByteArray[num14 << 4 | num13] = tu17ChunkData_0.Biomes[num13 * 16 + num14];
					}
				}
			}
			if (convertParameters_0.ReplaceBiomes)
			{
				for (int num15 = 0; num15 < tagNodeByteArray.Length; num15++)
				{
					int num16 = 0;
					while (num16 < convertParameters_0.BiomeChanges.Count)
					{
						if (convertParameters_0.BiomeChanges[num16].FromBiome != 1000)
						{
							if ((int)tagNodeByteArray[num15] != convertParameters_0.BiomeChanges[num16].FromBiome)
							{
								num16++;
								continue;
							}
						}
						tagNodeByteArray[num15] = (byte)convertParameters_0.BiomeChanges[num16].ToBiome;
						break;
					}
				}
			}
			TagNodeList tagNodeList2 = null;
			if (convertParameters_0.ConvertEntities)
			{
				try
				{
					tagNodeList2 = (tu17ChunkData_0.NBTData.ContainsKey("Entities") ? (tu17ChunkData_0.NBTData["Entities"] as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND));
					tagNodeList2 = this.method_15(tagNodeList2);
				}
				catch (Exception)
				{
					tagNodeList2 = new TagNodeList(TagType.TAG_COMPOUND);
				}
			}
			else
			{
				tagNodeList2 = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value;
			if (convertParameters_0.ConvertTileEntities)
			{
				value = this.method_11(tu17ChunkData_0.NBTData);
			}
			else
			{
				value = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value2 = new TagNodeList(TagType.TAG_COMPOUND);
			int d = x;
			int d2 = z;
			if (this.convertToPCParameters_0.ConvertParameters.UseConvertOffsets)
			{
				d = Class46.smethod_76(d, this.convertToPCParameters_0.ConvertParameters.XRegionOffset);
				d2 = Class46.smethod_76(d2, this.convertToPCParameters_0.ConvertParameters.ZRegionOffset);
			}
			TagNodeCompound tagNodeCompound = new TagNodeCompound();
			tagNodeCompound.Add("Sections", tagNodeList);
			tagNodeCompound.Add("HeightMap", tagNodeIntArray);
			tagNodeCompound.Add("Biomes", tagNodeByteArray);
			tagNodeCompound.Add("Entities", tagNodeList2.Copy());
			tagNodeCompound.Add("TileEntities", value);
			tagNodeCompound.Add("TileTicks", value2);
			tagNodeCompound.Add("LastUpdate", new TagNodeLong(0L));
			tagNodeCompound.Add("xPos", new TagNodeInt(d));
			tagNodeCompound.Add("zPos", new TagNodeInt(d2));
			tagNodeCompound.Add("TerrainPopulated", new TagNodeByte(1));
			tagNodeCompound.Add("LightPopulated", new TagNodeByte(1));
			NbtTree nbtTree = new NbtTree();
			nbtTree.Root.Add("Level", tagNodeCompound);
			nbtTree.Root.Add("DataVersion", new TagNodeInt(169));
			MemoryStream memoryStream = new MemoryStream();
			nbtTree.WriteTo(memoryStream);
			return memoryStream.ToArray();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00032664 File Offset: 0x00030864
		private byte[] method_10(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			if (!tagNodeCompound_0.ContainsKey("Level"))
			{
				return null;
			}
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			int num = (TagNodeInt)tagNodeCompound["xPos"];
			int num2 = (TagNodeInt)tagNodeCompound["zPos"];
			int num3 = (num >= 0) ? (num * 16) : ((num + 1) * 16);
			int num4 = (num2 >= 0) ? (num2 * 16) : ((num2 + 1) * 16);
			TagNodeByteArray tagNodeByteArray = tagNodeCompound["Blocks"] as TagNodeByteArray;
			TagNodeByteArray b = tagNodeCompound["Data"] as TagNodeByteArray;
			TagNodeByteArray b2 = tagNodeCompound["BlockLight"] as TagNodeByteArray;
			TagNodeByteArray b3 = tagNodeCompound["SkyLight"] as TagNodeByteArray;
			int num5 = (tagNodeByteArray.Length == 65536) ? 16 : 8;
			int i = 0;
			while (i < num5)
			{
				int num6 = (i < 8) ? 0 : 32768;
				int offset = num6 / 2;
				int num7 = (i < 8) ? i : (i - 8);
				AnvilSection anvilSection = new AnvilSection(i);
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				for (int j = 0; j < 16; j++)
				{
					int num8 = i * 16;
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int index = j << 11 | l << 7 | k + (num7 << 4) + num6;
							byte b4 = tagNodeByteArray[index];
							int num9 = nibbleSetters.RegionGet(b, j, k + (num7 << 4), l, offset);
							int num10 = nibbleSetters.RegionGet(b2, j, k + (num7 << 4), l, offset);
							int num11 = nibbleSetters.RegionGet(b3, j, k + (num7 << 4), l, offset);
							if (convertParameters_0.ReplaceBlocks && (this.bool_0[(int)b4] || this.bool_0[256]))
							{
								int m = 0;
								while (m < convertParameters_0.BlockChanges.Count)
								{
									if (convertParameters_0.BlockChanges[m].FromBlock == -1)
									{
										goto IL_33D;
									}
									if ((int)b4 == convertParameters_0.BlockChanges[m].FromBlock)
									{
										goto IL_33D;
									}
									IL_372:
									m++;
									continue;
									IL_33D:
									if ((!convertParameters_0.BlockChanges[m].Layers.Contains(num8) && !convertParameters_0.BlockChanges[m].Layers.Contains(-1)) || (!convertParameters_0.BlockChanges[m].FromData.Contains(-1) && !convertParameters_0.BlockChanges[m].FromData.Contains(num9)))
									{
										goto IL_372;
									}
									int num12 = (int)b4;
									b4 = (byte)convertParameters_0.BlockChanges[m].ToBlock;
									if (convertParameters_0.BlockChanges[m].ToData != -1)
									{
										num9 = convertParameters_0.BlockChanges[m].ToData;
									}
									if (convertParameters_0.BlockChanges[m].ToBlockLight != -1)
									{
										num10 = convertParameters_0.BlockChanges[m].ToBlockLight;
									}
									if (Class46.smethod_35(num12))
									{
										int num13 = num3 + ((num >= 0) ? j : ((16 - j) * -1));
										int num14 = num4 + ((num2 >= 0) ? l : ((16 - l) * -1));
										Class46.smethod_37(tagNodeCompound_0, num13, num8, num14);
										break;
									}
									break;
								}
							}
							if (b4 != 0)
							{
								flag = true;
							}
							if (num11 != 255)
							{
								flag2 = true;
							}
							if (num10 != 0)
							{
								flag3 = true;
							}
							anvilSection.Blocks[k << 8 | l << 4 | j] = (int)b4;
							nibbleSetters.AnvilSet(anvilSection.Data.Data, j, k, l, num9);
							nibbleSetters.AnvilSet(anvilSection.SkyLight.Data, j, k, l, num11);
							nibbleSetters.AnvilSet(anvilSection.BlockLight.Data, j, k, l, num10);
						}
						num8++;
					}
				}
				if (flag || flag2)
				{
					goto IL_197;
				}
				if (flag3)
				{
					goto IL_197;
				}
				IL_1A4:
				i++;
				continue;
				IL_197:
				tagNodeList.Add(anvilSection.BuildTree());
				goto IL_1A4;
			}
			TagNodeIntArray tagNodeIntArray = new TagNodeIntArray(new int[256]);
			if (tagNodeCompound.ContainsKey("HeightMap"))
			{
				TagNodeByteArray tagNodeByteArray2 = tagNodeCompound["HeightMap"] as TagNodeByteArray;
				for (int n = 0; n < 256; n++)
				{
					tagNodeIntArray[n] = (int)tagNodeByteArray2[n];
				}
			}
			TagNodeByteArray tagNodeByteArray3 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("Biomes"))
			{
				TagNodeByteArray tagNodeByteArray4 = tagNodeCompound["Biomes"] as TagNodeByteArray;
				for (int num15 = 0; num15 < 16; num15++)
				{
					for (int num16 = 0; num16 < 16; num16++)
					{
						tagNodeByteArray3[num16 << 4 | num15] = tagNodeByteArray4[num16 << 4 | num15];
					}
				}
			}
			if (convertParameters_0.ReplaceBiomes)
			{
				for (int num17 = 0; num17 < tagNodeByteArray3.Length; num17++)
				{
					int num18 = 0;
					while (num18 < convertParameters_0.BiomeChanges.Count)
					{
						if (convertParameters_0.BiomeChanges[num18].FromBiome != 1000)
						{
							if ((int)tagNodeByteArray3[num17] != convertParameters_0.BiomeChanges[num18].FromBiome)
							{
								num18++;
								continue;
							}
						}
						tagNodeByteArray3[num17] = (byte)convertParameters_0.BiomeChanges[num18].ToBiome;
						break;
					}
				}
			}
			TagNodeList tagNodeList2 = null;
			if (convertParameters_0.ConvertEntities)
			{
				try
				{
					tagNodeList2 = (tagNodeCompound.ContainsKey("Entities") ? (tagNodeCompound["Entities"] as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND));
					tagNodeList2 = this.method_15(tagNodeList2);
				}
				catch (Exception)
				{
					tagNodeList2 = new TagNodeList(TagType.TAG_COMPOUND);
				}
			}
			else
			{
				tagNodeList2 = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value;
			if (convertParameters_0.ConvertTileEntities)
			{
				value = this.method_11(tagNodeCompound);
			}
			else
			{
				value = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value2 = new TagNodeList(TagType.TAG_COMPOUND);
			int num19 = num;
			int d = num2;
			if (this.convertToPCParameters_0.ConvertParameters.UseConvertOffsets)
			{
				num19 = Class46.smethod_76(num19, this.convertToPCParameters_0.ConvertParameters.XRegionOffset);
				d = Class46.smethod_76(d, this.convertToPCParameters_0.ConvertParameters.ZRegionOffset);
			}
			TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
			tagNodeCompound2.Add("Sections", tagNodeList);
			tagNodeCompound2.Add("HeightMap", tagNodeIntArray);
			tagNodeCompound2.Add("Biomes", tagNodeByteArray3);
			tagNodeCompound2.Add("Entities", tagNodeList2.Copy());
			tagNodeCompound2.Add("TileEntities", value);
			tagNodeCompound2.Add("TileTicks", value2);
			tagNodeCompound2.Add("LastUpdate", new TagNodeLong(0L));
			tagNodeCompound2.Add("xPos", new TagNodeInt(d));
			tagNodeCompound2.Add("zPos", new TagNodeInt(d));
			tagNodeCompound2.Add("TerrainPopulated", new TagNodeByte(1));
			tagNodeCompound2.Add("LightPopulated", new TagNodeByte(1));
			NbtTree nbtTree = new NbtTree();
			nbtTree.Root.Add("Level", tagNodeCompound2);
			nbtTree.Root.Add("DataVersion", new TagNodeInt(169));
			MemoryStream memoryStream = new MemoryStream();
			nbtTree.WriteTo(memoryStream);
			return memoryStream.ToArray();
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00032E10 File Offset: 0x00031010
		private TagNodeList method_11(TagNodeCompound tagNodeCompound_0)
		{
			TagNodeList tagNodeList = tagNodeCompound_0.ContainsKey("TileEntities") ? (tagNodeCompound_0["TileEntities"].Copy() as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = tagNodeList.Count - 1; i >= 0; i--)
			{
				TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
				if (tagNodeCompound.ContainsKey("id") && tagNodeCompound["id"] is TagNodeString)
				{
					string text = this.method_23(tagNodeCompound, "id");
					this.method_24(tagNodeCompound, text);
					if (text == "Sign")
					{
						this.method_12(tagNodeCompound);
						tagNodeCompound.Remove("Censored");
						tagNodeCompound.Remove("CreatedLocally");
						tagNodeCompound.Remove("RemoteCensor");
						tagNodeCompound.Remove("uuid");
						tagNodeCompound.Remove("Verified");
					}
					if (text == "MobSpawner" || text == "minecraft:mob_spawner")
					{
						string string_ = "Pig";
						if (tagNodeCompound.ContainsKey("EntityId"))
						{
							string_ = this.method_23(tagNodeCompound, "EntityId");
							tagNodeCompound.Remove("EntityId");
						}
						if (tagNodeCompound.ContainsKey("SpawnData"))
						{
							string_ = this.method_23(tagNodeCompound["SpawnData"] as TagNodeCompound, "id");
							((TagNodeCompound)tagNodeCompound["SpawnData"])["id"] = new TagNodeString(this.method_25(string_));
						}
						else
						{
							TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
							tagNodeCompound2["id"] = new TagNodeString(this.method_25(string_));
							tagNodeCompound["SpawnData"] = tagNodeCompound2;
						}
						if (tagNodeCompound.ContainsKey("SpawnPotentials"))
						{
							TagNodeList tagNodeList2 = tagNodeCompound["SpawnPotentials"] as TagNodeList;
							for (int j = 0; j < tagNodeList2.Count; j++)
							{
								TagNodeCompound tagNodeCompound3 = tagNodeList2[j] as TagNodeCompound;
								if (tagNodeCompound3.ContainsKey("Entity"))
								{
									TagNodeCompound tagNodeCompound4 = tagNodeCompound3["Entity"] as TagNodeCompound;
									if (tagNodeCompound4.ContainsKey("id"))
									{
										string string_2 = this.method_23(tagNodeCompound4, "id");
										this.method_24(tagNodeCompound4, string_2);
									}
								}
							}
						}
						else
						{
							TagNodeList tagNodeList3 = new TagNodeList(TagType.TAG_COMPOUND);
							TagNodeCompound tagNodeCompound5 = new TagNodeCompound();
							tagNodeCompound5["Weight"] = new TagNodeInt(1);
							TagNodeCompound tagNodeCompound6 = new TagNodeCompound();
							tagNodeCompound5["Entity"] = tagNodeCompound6;
							this.method_24(tagNodeCompound6, string_);
							tagNodeList3.Add(tagNodeCompound5);
							tagNodeCompound["SpawnPotentials"] = tagNodeList3;
						}
					}
				}
				if (tagNodeCompound.ContainsKey("Items"))
				{
					this.method_14(tagNodeCompound);
				}
			}
			return tagNodeList;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000330DC File Offset: 0x000312DC
		private void method_12(TagNodeCompound tagNodeCompound_0)
		{
			try
			{
				((TagNodeString)tagNodeCompound_0["Text1"]).Data = this.method_13((TagNodeString)tagNodeCompound_0["Text1"]);
				((TagNodeString)tagNodeCompound_0["Text2"]).Data = this.method_13((TagNodeString)tagNodeCompound_0["Text2"]);
				((TagNodeString)tagNodeCompound_0["Text3"]).Data = this.method_13((TagNodeString)tagNodeCompound_0["Text3"]);
				((TagNodeString)tagNodeCompound_0["Text4"]).Data = this.method_13((TagNodeString)tagNodeCompound_0["Text4"]);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private string method_13(string string_0)
		{
			if (string.IsNullOrWhiteSpace(string_0))
			{
				string_0 = " ";
			}
			return string.Format("{{\"text\":\"{0}\"}}", string_0);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000331C0 File Offset: 0x000313C0
		private void method_14(TagNodeCompound tagNodeCompound_0)
		{
			TagNodeList tagNodeList = tagNodeCompound_0["Items"] as TagNodeList;
			if (tagNodeList != null)
			{
				for (int i = tagNodeList.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
					if (tagNodeCompound.ContainsKey("id") && tagNodeCompound["id"] is TagNodeShort)
					{
						short num = tagNodeCompound["id"] as TagNodeShort;
						string text = null;
						if (num < 256 && Class34.smethod_1().ContainsKey((int)num))
						{
							text = Class34.smethod_1()[(int)num].ApfHbuxQfqb();
						}
						if (num >= 256 && ConsoleItemLookups.ItemsById.ContainsKey((int)num))
						{
							text = ConsoleItemLookups.ItemsById[(int)num].MCName;
						}
						if (text != null)
						{
							tagNodeCompound.Remove("id");
							tagNodeCompound.Add("id", new TagNodeString(text));
						}
						else
						{
							tagNodeList.Remove(tagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000332C0 File Offset: 0x000314C0
		private TagNodeList method_15(TagNodeList tagNodeList_0)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
			{
				if (tagNodeList_0[i] is TagNodeCompound)
				{
					TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
					if (tagNodeCompound != null && this.method_16(tagNodeCompound))
					{
						try
						{
							TagNodeCompound tagNodeCompound2 = (TagNodeCompound)tagNodeCompound.Copy();
							this.method_18(tagNodeCompound2);
							this.method_17(tagNodeCompound2);
							tagNodeList.Add(tagNodeCompound2);
							goto IL_33;
						}
						catch (Exception)
						{
							goto IL_33;
						}
						break;
					}
				}
				IL_33:;
			}
			return tagNodeList;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00033348 File Offset: 0x00031548
		private bool method_16(TagNodeCompound tagNodeCompound_0)
		{
			bool result = false;
			if (tagNodeCompound_0.ContainsKey("id") && tagNodeCompound_0["id"] is TagNodeString)
			{
				string text = this.method_23(tagNodeCompound_0, "id");
				if (text != "Item")
				{
					if (this.entityLookup_0.ConsoleEntities.ContainsKey(text) || this.entityLookup_0.Dictionary_0.ContainsKey(text))
					{
						result = true;
					}
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000333C0 File Offset: 0x000315C0
		private void method_17(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0 != null && tagNodeCompound_0.ContainsKey("Riding"))
			{
				TagNodeList tagNodeList;
				if (tagNodeCompound_0["Riding"] is TagNodeCompound)
				{
					TagNodeCompound item = tagNodeCompound_0["Riding"] as TagNodeCompound;
					tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
					tagNodeList.Add(item);
				}
				else
				{
					tagNodeList = (tagNodeCompound_0["Riding"] as TagNodeList);
				}
				tagNodeCompound_0.Remove("Riding");
				if (tagNodeList != null && tagNodeList.Count > 0)
				{
					tagNodeCompound_0["Passengers"] = tagNodeList;
					for (int i = tagNodeList.Count - 1; i >= 0; i--)
					{
						TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
						if (tagNodeCompound == null || !this.method_16(tagNodeCompound))
						{
							tagNodeList.Remove(tagNodeCompound);
						}
						else
						{
							this.method_18(tagNodeCompound);
							if (tagNodeCompound.ContainsKey("Riding"))
							{
								this.method_17(tagNodeCompound);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000334A0 File Offset: 0x000316A0
		private void method_18(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0.ContainsKey("id") && tagNodeCompound_0["id"] is TagNodeString)
			{
				string text = this.method_23(tagNodeCompound_0, "id");
				if (text != "Item")
				{
					this.method_24(tagNodeCompound_0, text);
					this.method_19(tagNodeCompound_0);
				}
				if (text == "Villager" || text == "minecraft:villager")
				{
					this.method_20(tagNodeCompound_0);
				}
			}
			tagNodeCompound_0.Remove("UUID");
			if (tagNodeCompound_0.ContainsKey("Glowing"))
			{
				tagNodeCompound_0["Glowing"] = new TagNodeByte(0);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00033544 File Offset: 0x00031744
		private void method_19(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0.ContainsKey("Attributes"))
			{
				TagNodeList tagNodeList = tagNodeCompound_0["Attributes"] as TagNodeList;
				for (int i = tagNodeList.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
					tagNodeCompound.Remove("Modifiers");
					if (!tagNodeCompound.ContainsKey("ID") || !(tagNodeCompound["ID"] is TagNodeInt))
					{
						tagNodeList.Remove(tagNodeCompound);
					}
					else
					{
						int key = tagNodeCompound["ID"].ToTagInt();
						if (AttributeLookup.attributesById.ContainsKey(key))
						{
							tagNodeCompound.Remove("ID");
							tagNodeCompound.Add("Name", new TagNodeString(AttributeLookup.attributesById[key]));
						}
						else
						{
							tagNodeList.Remove(tagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00033620 File Offset: 0x00031820
		private void method_20(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0.ContainsKey("Offers"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["Offers"] as TagNodeCompound;
				if (tagNodeCompound.ContainsKey("Recipes"))
				{
					TagNodeList tagNodeList = tagNodeCompound["Recipes"] as TagNodeList;
					foreach (TagNode tagNode in tagNodeList)
					{
						TagNodeCompound tagNodeCompound2 = (TagNodeCompound)tagNode;
						if (tagNodeCompound2.ContainsKey("buy"))
						{
							this.method_21(tagNodeCompound2["buy"] as TagNodeCompound);
						}
						if (tagNodeCompound2.ContainsKey("buyB"))
						{
							this.method_21(tagNodeCompound2["buyB"] as TagNodeCompound);
						}
						if (tagNodeCompound2.ContainsKey("sell"))
						{
							this.method_21(tagNodeCompound2["sell"] as TagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00033714 File Offset: 0x00031914
		private void method_21(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0.ContainsKey("id") && tagNodeCompound_0["id"] is TagNodeShort)
			{
				string text = this.method_23(tagNodeCompound_0, "id");
				if (text != null)
				{
					this.method_22(tagNodeCompound_0, text);
				}
			}
			if (tagNodeCompound_0.ContainsKey("tag"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["tag"] as TagNodeCompound;
				if (tagNodeCompound != null && tagNodeCompound.ContainsKey("BlockEntityTag"))
				{
					TagNodeCompound tagNodeCompound2 = tagNodeCompound["BlockEntityTag"] as TagNodeCompound;
					if (tagNodeCompound2 != null && tagNodeCompound2.ContainsKey("Items"))
					{
						this.method_14(tagNodeCompound2);
					}
				}
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00004E00 File Offset: 0x00003000
		private void method_22(TagNodeCompound tagNodeCompound_0, string string_0)
		{
			tagNodeCompound_0.Remove("id");
			tagNodeCompound_0.Add("id", new TagNodeString(string_0));
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000337B4 File Offset: 0x000319B4
		private string method_23(TagNodeCompound tagNodeCompound_0, string string_0 = "id")
		{
			string text = "Pig";
			if (tagNodeCompound_0.ContainsKey(string_0))
			{
				if (tagNodeCompound_0[string_0] is TagNodeString)
				{
					text = (tagNodeCompound_0[string_0] as TagNodeString);
					if (this.entityLookup_0.Dictionary_0.ContainsKey(text))
					{
						text = this.entityLookup_0.Dictionary_0[text].ConsoleName;
					}
					else if (this.tileEntityLookup_0.Dictionary_0.ContainsKey(text))
					{
						text = this.tileEntityLookup_0.Dictionary_0[text].ConsoleName;
					}
				}
				else if (tagNodeCompound_0[string_0] is TagNodeShort)
				{
					short key = tagNodeCompound_0[string_0] as TagNodeShort;
					if (ConsoleItemLookups.ItemsById.ContainsKey((int)key))
					{
						text = ConsoleItemLookups.ItemsById[(int)key].MCName;
					}
					else if (Class34.smethod_1().ContainsKey((int)key))
					{
						text = Class34.smethod_1()[(int)key].ApfHbuxQfqb();
					}
				}
			}
			return text;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00004E1F File Offset: 0x0000301F
		private void method_24(TagNodeCompound tagNodeCompound_0, string string_0)
		{
			tagNodeCompound_0["id"] = new TagNodeString(this.method_25(string_0));
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000338B0 File Offset: 0x00031AB0
		private string method_25(string string_0)
		{
			EntityItem entityItem = null;
			TileEntityItem tileEntityItem = null;
			if (this.entityLookup_0.ConsoleEntities.ContainsKey(string_0))
			{
				entityItem = this.entityLookup_0.ConsoleEntities[string_0];
			}
			else if (this.entityLookup_0.Dictionary_0.ContainsKey(string_0))
			{
				entityItem = this.entityLookup_0.Dictionary_0[string_0];
			}
			else if (this.tileEntityLookup_0.ConsoleEntities.ContainsKey(string_0))
			{
				tileEntityItem = this.tileEntityLookup_0.ConsoleEntities[string_0];
			}
			else if (this.tileEntityLookup_0.Dictionary_0.ContainsKey(string_0))
			{
				tileEntityItem = this.tileEntityLookup_0.Dictionary_0[string_0];
			}
			if (entityItem != null)
			{
				if (this.convertToPCParameters_0.ConvertParameters.UseOldEntityNameFormat)
				{
					string_0 = entityItem.String_0;
				}
				else
				{
					string_0 = entityItem.PCName;
				}
			}
			else if (tileEntityItem != null)
			{
				if (this.convertToPCParameters_0.ConvertParameters.UseOldEntityNameFormat)
				{
					string_0 = tileEntityItem.String_0;
				}
				else
				{
					string_0 = tileEntityItem.PCName;
				}
			}
			return string_0;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x0400038F RID: 911
		private Dictionary<int, List<int>> dictionary_0 = new Dictionary<int, List<int>>();

		// Token: 0x04000390 RID: 912
		private ConvertToPCParameters convertToPCParameters_0;

		// Token: 0x04000391 RID: 913
		private EntityLookup entityLookup_0 = new EntityLookup();

		// Token: 0x04000392 RID: 914
		private TileEntityLookup tileEntityLookup_0 = new TileEntityLookup();

		// Token: 0x04000393 RID: 915
		private bool[] bool_0;

		// Token: 0x04000394 RID: 916
		private int int_0;

		// Token: 0x04000395 RID: 917
		private int int_1;

		// Token: 0x04000396 RID: 918
		private int int_2;

		// Token: 0x04000397 RID: 919
		private int int_3;

		// Token: 0x04000398 RID: 920
		private int int_4;

		// Token: 0x04000399 RID: 921
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;
	}
}
