using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x0200005F RID: 95
	public class ConvertFromPC
	{
		// Token: 0x060003DD RID: 989 RVA: 0x0001D548 File Offset: 0x0001B748
		public void ExtractPCRegion(object threadContext)
		{
			ConvertFromPCParameters convertFromPCParameters = threadContext as ConvertFromPCParameters;
			if (convertFromPCParameters != null)
			{
				this.convertFromPCParameters_0 = convertFromPCParameters;
				this.ExtractPCRegion(convertFromPCParameters.RegionName, convertFromPCParameters.RegionFolder, convertFromPCParameters.PCRegionFolder, convertFromPCParameters.WorkingFolder, convertFromPCParameters.ConvertParameters);
				convertFromPCParameters.DoneEvent.Set();
				convertFromPCParameters.Done = true;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		public void ExtractPCRegion(string regionName, string regionfolder, string pcRegionFolder, string workingFolder, ConvertParameters convertParameters)
		{
			if (FileUtils.CheckFolderExists(pcRegionFolder))
			{
				if (!(regionfolder.ToLower() == "region"))
				{
					regionfolder + "\\region";
				}
				string text = FileUtils.CheckFolderSep(pcRegionFolder) + regionName + ".mca";
				if (File.Exists(text))
				{
					this.method_0(regionName, regionfolder, text, workingFolder, convertParameters);
					return;
				}
				string string_ = string.Concat(new string[]
				{
					workingFolder,
					Working.smethod_4(),
					FileUtils.CheckFolderSep(regionfolder),
					regionName,
					".mcr"
				});
				Class36.smethod_28(string_);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001D634 File Offset: 0x0001B834
		private void method_0(string string_0, string string_1, string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			XBOXCompression xboxcompression_ = new XBOXCompression();
			List<ChunkIndexEntry> list = null;
			list = Class36.smethod_4(string_2);
			this.bool_0 = Utils.GetQuickBlocksLookup(convertParameters_0);
			this.blockChange_0 = this.method_7(convertParameters_0);
			this.int_0 = Working.smethod_10();
			this.int_1 = Working.smethod_12();
			string text = FileUtils.CheckFolderSep(string_1);
			string text2 = string.Concat(new string[]
			{
				string_3,
				Working.smethod_4(),
				text,
				string_0,
				".mcr"
			});
			string string_4 = string_3 + Working.smethod_4() + text;
			FileUtils.smethod_9(string_4);
			if (list == null || list.Count <= 0)
			{
				if (this.convertFromPCParameters_0 != null)
				{
					this.convertFromPCParameters_0.ProcessingCompleted = true;
				}
				this.int_2 += Constants.regionSizes[string_0];
				Class36.smethod_28(text2);
			}
			else
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (ConvertFromPC.func_0 == null)
				{
					ConvertFromPC.func_0 = new Func<ChunkIndexEntry, int>(ConvertFromPC.smethod_0);
				}
				list = source.OrderBy(ConvertFromPC.func_0).ToList<ChunkIndexEntry>();
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text2, FileMode.Create)))
				{
					Class36.smethod_20(binaryWriter);
					List<int> list2;
					if (!convertParameters_0.ConvertNewGen)
					{
						list2 = Class20.smethod_1()[string_1][string_0];
					}
					else
					{
						list2 = Class20.smethod_2()[string_1][string_0];
					}
					using (BinaryReader binaryReader = new BinaryReader(File.Open(string_2, FileMode.Open)))
					{
						string string_5 = string.Concat(new string[]
						{
							"Converting - ",
							string_1,
							"  ",
							string_0,
							"      Chunk - "
						});
						for (int i = 0; i < list2.Count; i++)
						{
							ChunkData chunkData = new ChunkData();
							chunkData.method_1(list[list2[i]]);
							byte[] array = this.method_3(chunkData, binaryReader, string_5, convertParameters_0);
							if (array != null && array.Length > 0)
							{
								array = this.method_2(array, chunkData, xboxcompression_);
								Class36.smethod_11(array, chunkData.method_0(), binaryWriter);
							}
						}
					}
					Class36.smethod_26(binaryWriter, list);
					if (this.convertFromPCParameters_0 != null)
					{
						this.convertFromPCParameters_0.ProcessingCompleted = true;
					}
				}
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
		private void method_1(string string_0, string string_1, string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			XBOXCompression xboxcompression_ = new XBOXCompression();
			MemoryStream memoryStream = new MemoryStream();
			List<ChunkIndexEntry> list = null;
			list = Class36.smethod_4(string_2);
			this.bool_0 = Utils.GetQuickBlocksLookup(convertParameters_0);
			this.blockChange_0 = this.method_7(convertParameters_0);
			this.int_0 = Working.smethod_10();
			this.int_1 = Working.smethod_12();
			if (list == null || list.Count <= 0)
			{
				if (this.convertFromPCParameters_0 != null)
				{
					this.convertFromPCParameters_0.ProcessingCompleted = true;
				}
				this.int_2 += Constants.regionSizes[string_0];
			}
			else
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (ConvertFromPC.func_1 == null)
				{
					ConvertFromPC.func_1 = new Func<ChunkIndexEntry, int>(ConvertFromPC.smethod_1);
				}
				list = source.OrderBy(ConvertFromPC.func_1).ToList<ChunkIndexEntry>();
				string text = FileUtils.CheckFolderSep(string_1);
				string filename = string.Concat(new string[]
				{
					string_3,
					Working.smethod_4(),
					text,
					string_0,
					".mcr"
				});
				Class36.smethod_21(memoryStream);
				List<int> list2 = Class20.smethod_1()[string_1][string_0];
				using (BinaryReader binaryReader = new BinaryReader(File.Open(string_2, FileMode.Open)))
				{
					string string_4 = string.Concat(new string[]
					{
						"Converting - ",
						string_1,
						"  ",
						string_0,
						"      Chunk - "
					});
					for (int i = 0; i < list2.Count; i++)
					{
						ChunkData chunkData = new ChunkData();
						chunkData.method_1(list[list2[i]]);
						byte[] array = this.method_3(chunkData, binaryReader, string_4, convertParameters_0);
						if (array != null && array.Length > 0)
						{
							array = this.method_2(array, chunkData, xboxcompression_);
							Class36.smethod_12(array, chunkData.method_0(), memoryStream);
						}
					}
				}
				Class36.smethod_27(memoryStream, list);
				FileUtils.WriteFile(memoryStream, filename);
				if (this.convertFromPCParameters_0 != null)
				{
					this.convertFromPCParameters_0.ProcessingCompleted = true;
					return;
				}
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		private byte[] method_2(byte[] byte_0, ChunkData chunkData_0, XBOXCompression xboxcompression_0)
		{
			byte[] array = null;
			if (Working.GameType == (Enum2)1)
			{
				array = xboxcompression_0.DoCompress(byte_0, 8);
				Class36.smethod_22(array.Length - 8, array);
				Class36.smethod_23(chunkData_0.NewFileSize, array);
			}
			else if (Working.GameType == (Enum2)2)
			{
				int num = byte_0.Length;
				array = Class36.smethod_58(byte_0);
				byte[] first = new byte[12];
				array = first.Concat(array).ToArray<byte>();
				Class36.smethod_22(array.Length - 8, array);
				Class36.smethod_23(chunkData_0.NewFileSize, array);
				Class36.smethod_24(num, array);
			}
			else if (Working.GameType == (Enum2)3)
			{
				array = Class36.smethod_55(byte_0);
				byte[] first2 = new byte[8];
				array = first2.Concat(array).ToArray<byte>();
				Class36.smethod_22(array.Length - 8, array);
				Class36.smethod_23(chunkData_0.NewFileSize, array);
			}
			return array;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		private byte[] method_3(ChunkData chunkData_0, BinaryReader binaryReader_0, string string_0, ConvertParameters convertParameters_0)
		{
			byte[] array = null;
			this.method_30(string_0 + chunkData_0.method_0().ChunkIndex.ToString());
			if (chunkData_0.method_0().OldChunkOffset > 0U)
			{
				binaryReader_0.BaseStream.Position = (long)((ulong)(chunkData_0.method_0().OldChunkOffset * 4096U));
				byte[] array2 = new byte[4];
				binaryReader_0.Read(array2, 0, array2.Length);
				if (BitConverter.IsLittleEndian)
				{
					Array.Reverse(array2);
				}
				int num = BitConverter.ToInt32(array2, 0);
				byte b = binaryReader_0.ReadByte();
				array = new byte[num - 1];
				binaryReader_0.Read(array, 0, array.Length);
				if (b == 1)
				{
					array = Class36.smethod_57(array);
				}
				else
				{
					array = Class36.smethod_56(array);
				}
				array = this.method_4(chunkData_0, array, convertParameters_0);
				if (this.convertFromPCParameters_0 != null)
				{
					this.convertFromPCParameters_0.ProcessedChunkCount++;
				}
			}
			else if (chunkData_0 != null && this.convertFromPCParameters_0 != null)
			{
				this.convertFromPCParameters_0.MissingChunkCount++;
			}
			return array;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		private byte[] method_4(ChunkData chunkData_0, byte[] byte_0, ConvertParameters convertParameters_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.WriteByte(0);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			NbtTree nbtTree = new NbtTree(memoryStream);
			int int_ = 65536;
			byte[] array;
			if (convertParameters_0.ChunkFormat == ConsoleChunkFormat.TU16)
			{
				TagNodeCompound tree = this.method_5(nbtTree.Root, int_, convertParameters_0);
				nbtTree = new NbtTree(tree);
				memoryStream = new MemoryStream();
				nbtTree.WriteTo(memoryStream);
				array = memoryStream.ToArray();
			}
			else
			{
				array = this.method_32(nbtTree.Root, int_, convertParameters_0);
			}
			chunkData_0.NewFileSize = array.Length;
			memoryStream = Class36.smethod_62(array);
			return memoryStream.ToArray();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001DD0C File Offset: 0x0001BF0C
		private TagNodeCompound method_5(TagNodeCompound tagNodeCompound_0, int int_4, ConvertParameters convertParameters_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			int num = (TagNodeInt)tagNodeCompound["xPos"];
			int num2 = (TagNodeInt)tagNodeCompound["zPos"];
			int num3 = (num >= 0) ? (num * 16) : ((num + 1) * 16);
			int num4 = (num2 >= 0) ? (num2 * 16) : ((num2 + 1) * 16);
			TagNodeList value;
			if (convertParameters_0.ConvertEntities)
			{
				value = this.method_16(tagNodeCompound, convertParameters_0);
			}
			else
			{
				value = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value2;
			if (convertParameters_0.ConvertTileEntities)
			{
				value2 = this.method_8(tagNodeCompound, convertParameters_0);
			}
			else
			{
				value2 = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value3 = new TagNodeList(TagType.TAG_COMPOUND);
			int num5 = int_4 / 2;
			TagNodeByteArray tagNodeByteArray = new TagNodeByteArray(new byte[int_4]);
			TagNodeByteArray tagNodeByteArray2 = new TagNodeByteArray(new byte[num5]);
			TagNodeByteArray tagNodeByteArray3 = new TagNodeByteArray(new byte[num5]);
			TagNodeByteArray tagNodeByteArray4 = new TagNodeByteArray(new byte[num5]);
			this.method_29(tagNodeByteArray4, byte.MaxValue);
			TagNodeList tagNodeList = tagNodeCompound["Sections"] as TagNodeList;
			for (int i = 0; i < tagNodeList.Count; i++)
			{
				TagNodeCompound tagNodeCompound2 = tagNodeList[i] as TagNodeCompound;
				int num6 = tagNodeCompound2["Y"] as TagNodeByte;
				int num7 = num6;
				int num8 = (num7 < 8) ? 0 : 32768;
				int offset = num8 / 2;
				num7 = ((num7 < 8) ? num7 : (num7 - 8));
				TagNodeByteArray tagNodeByteArray5 = tagNodeCompound2["Blocks"] as TagNodeByteArray;
				TagNodeByteArray b = tagNodeCompound2["Data"] as TagNodeByteArray;
				TagNodeByteArray b2 = tagNodeCompound2["BlockLight"] as TagNodeByteArray;
				TagNodeByteArray b3 = tagNodeCompound2["SkyLight"] as TagNodeByteArray;
				if (tagNodeCompound2.ContainsKey("Add"))
				{
					TagNode tagNode = tagNodeCompound2["Add"];
				}
				for (int j = 0; j < 16; j++)
				{
					int num9 = num6 * 16;
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int index = j << 11 | l << 7 | k + (num7 << 4) + num8;
							int num10 = (int)tagNodeByteArray5[k << 8 | l << 4 | j];
							int num11 = nibbleSetters.AnvilGet(b, j, k, l);
							int val = nibbleSetters.AnvilGet(b2, j, k, l);
							int val2 = nibbleSetters.AnvilGet(b3, j, k, l);
							if (!Class29.smethod_1().ContainsKey(num10))
							{
								num10 = this.blockChange_0.ToBlock;
								num11 = this.blockChange_0.ToData;
							}
							else if (convertParameters_0.ReplaceBlocks && (this.bool_0[num10] || this.bool_0[256]))
							{
								int m = 0;
								while (m < convertParameters_0.BlockChanges.Count)
								{
									if (convertParameters_0.BlockChanges[m].FromBlock == -1)
									{
										goto IL_3E1;
									}
									if (num10 == convertParameters_0.BlockChanges[m].FromBlock)
									{
										goto IL_3E1;
									}
									IL_416:
									m++;
									continue;
									IL_3E1:
									if ((!convertParameters_0.BlockChanges[m].Layers.Contains(num9) && !convertParameters_0.BlockChanges[m].Layers.Contains(-1)) || (!convertParameters_0.BlockChanges[m].FromData.Contains(-1) && !convertParameters_0.BlockChanges[m].FromData.Contains(num11)))
									{
										goto IL_416;
									}
									int num12 = num10;
									num10 = (int)((byte)convertParameters_0.BlockChanges[m].ToBlock);
									if (convertParameters_0.BlockChanges[m].ToData != -1)
									{
										num11 = convertParameters_0.BlockChanges[m].ToData;
									}
									if (convertParameters_0.BlockChanges[m].ToBlockLight != -1)
									{
										val = convertParameters_0.BlockChanges[m].ToBlockLight;
									}
									if (Class36.smethod_30(num12))
									{
										int num13 = num3 + ((num >= 0) ? j : ((16 - j) * -1));
										int num14 = num4 + ((num2 >= 0) ? l : ((16 - l) * -1));
										Class36.FDJFKWMKFG(tagNodeCompound_0, num13, num9, num14);
										break;
									}
									break;
								}
							}
							tagNodeByteArray[index] = (byte)num10;
							int y = k + (num7 << 4);
							nibbleSetters.RegionSet(tagNodeByteArray2, j, y, l, num11, offset);
							nibbleSetters.RegionSet(tagNodeByteArray4, j, y, l, val2, offset);
							nibbleSetters.RegionSet(tagNodeByteArray3, j, y, l, val, offset);
						}
						num9++;
					}
				}
			}
			TagNodeByteArray tagNodeByteArray6 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("HeightMap"))
			{
				TagNodeIntArray tagNodeIntArray = tagNodeCompound["HeightMap"] as TagNodeIntArray;
				for (int n = 0; n < 256; n++)
				{
					tagNodeByteArray6[n] = (byte)tagNodeIntArray[n];
				}
			}
			TagNodeByteArray tagNodeByteArray7 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("Biomes"))
			{
				TagNodeByteArray tagNodeByteArray8 = tagNodeCompound["Biomes"] as TagNodeByteArray;
				for (int num15 = 0; num15 < 16; num15++)
				{
					for (int num16 = 0; num16 < 16; num16++)
					{
						tagNodeByteArray7[num15 << 4 | num16] = tagNodeByteArray8[num16 << 4 | num15];
					}
				}
			}
			this.method_6(tagNodeByteArray7, convertParameters_0);
			TagNodeCompound tagNodeCompound3 = new TagNodeCompound();
			tagNodeCompound3.Add("Blocks", tagNodeByteArray);
			tagNodeCompound3.Add("LastUpdate", new TagNodeLong(12944574L));
			tagNodeCompound3.Add("xPos", tagNodeCompound["xPos"]);
			tagNodeCompound3.Add("Data", tagNodeByteArray2);
			tagNodeCompound3.Add("zPos", tagNodeCompound["zPos"]);
			tagNodeCompound3.Add("HeightMap", tagNodeByteArray6);
			tagNodeCompound3.Add("InhabitedTime", new TagNodeLong(0L));
			tagNodeCompound3.Add("BlockLight", tagNodeByteArray3);
			tagNodeCompound3.Add("SkyLight", tagNodeByteArray4);
			tagNodeCompound3.Add("TerrainPopulatedFlags", new TagNodeShort(2046));
			tagNodeCompound3.Add("Biomes", tagNodeByteArray7);
			tagNodeCompound3.Add("Entities", value);
			tagNodeCompound3.Add("TileEntities", value2);
			tagNodeCompound3.Add("TileTicks", value3);
			return new NbtTree
			{
				Root = 
				{
					{
						"Level",
						tagNodeCompound3
					}
				}
			}.Root;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0001E3D4 File Offset: 0x0001C5D4
		private void method_6(TagNodeByteArray tagNodeByteArray_0, ConvertParameters convertParameters_0)
		{
			if (convertParameters_0.ReplaceBiomes)
			{
				for (int i = 0; i < tagNodeByteArray_0.Length; i++)
				{
					int j = 0;
					while (j < convertParameters_0.BiomeChanges.Count)
					{
						if (convertParameters_0.BiomeChanges[j].FromBiome != 1000)
						{
							if ((int)tagNodeByteArray_0[i] != convertParameters_0.BiomeChanges[j].FromBiome)
							{
								j++;
								continue;
							}
						}
						tagNodeByteArray_0[i] = (byte)convertParameters_0.BiomeChanges[j].ToBiome;
						break;
					}
				}
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001E464 File Offset: 0x0001C664
		private BlockChange method_7(ConvertParameters convertParameters_0)
		{
			if (convertParameters_0.BlockChanges != null)
			{
				for (int i = 0; i < convertParameters_0.BlockChanges.Count; i++)
				{
					if (convertParameters_0.BlockChanges[i].FromBlock == 10000)
					{
						return convertParameters_0.BlockChanges[i];
					}
				}
			}
			return new BlockChange();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001E4BC File Offset: 0x0001C6BC
		private TagNodeList method_8(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			TagNodeList tagNodeList = tagNodeCompound_0.ContainsKey("TileEntities") ? (tagNodeCompound_0["TileEntities"].Copy() as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			int num = 0;
			for (int i = tagNodeList.Count - 1; i >= 0; i--)
			{
				TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
				if (!tagNodeCompound.ContainsKey("id") || !(tagNodeCompound["id"] is TagNodeString))
				{
					tagNodeList.Remove(tagNodeCompound);
				}
				else
				{
					int num2 = tagNodeCompound["x"] as TagNodeInt;
					int num3 = tagNodeCompound["z"] as TagNodeInt;
					string text = (TagNodeString)tagNodeCompound["id"];
					if (!this.dJdnUkfOtt.Dictionary_0.ContainsKey(text))
					{
						tagNodeList.Remove(tagNodeCompound);
					}
					else if (num2 <= 431 && num2 >= -432 && num3 <= 431 && num3 >= -432)
					{
						text = this.dJdnUkfOtt.Dictionary_0[text].ConsoleName;
						tagNodeCompound["id"] = new TagNodeString(text);
						if (text == "MobSpawner")
						{
							string d = "Pig";
							if (tagNodeCompound.ContainsKey("EntityId"))
							{
								if (this.entityLookup_0.Dictionary_0.ContainsKey((TagNodeString)tagNodeCompound["EntityId"]))
								{
									d = new TagNodeString(this.entityLookup_0.Dictionary_0[(TagNodeString)tagNodeCompound["EntityId"]].ConsoleName);
								}
								tagNodeCompound.Remove("EntityId");
							}
							if (tagNodeCompound.ContainsKey("SpawnData"))
							{
								if (((TagNodeCompound)tagNodeCompound["SpawnData"]).ContainsKey("id") && this.entityLookup_0.Dictionary_0.ContainsKey((TagNodeString)((TagNodeCompound)tagNodeCompound["SpawnData"])["id"]))
								{
									d = new TagNodeString(this.entityLookup_0.Dictionary_0[(TagNodeString)((TagNodeCompound)tagNodeCompound["SpawnData"])["id"]].ConsoleName);
								}
								((TagNodeCompound)tagNodeCompound["SpawnData"])["id"] = new TagNodeString(d);
							}
							else
							{
								TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
								tagNodeCompound2["id"] = new TagNodeString(d);
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
											tagNodeCompound4["id"] = new TagNodeString(this.entityLookup_0.Dictionary_0[(TagNodeString)tagNodeCompound4["id"]].ConsoleName);
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
								tagNodeCompound6["id"] = new TagNodeString(d);
								tagNodeList3.Add(tagNodeCompound5);
								tagNodeCompound["SpawnPotentials"] = tagNodeList3;
							}
							tagNodeCompound["Delay"] = new TagNodeShort(20);
							tagNodeCompound["MaxNearbyEntities"] = new TagNodeShort(6);
							tagNodeCompound["MaxSpawnDelay"] = new TagNodeShort(800);
							tagNodeCompound["MinSpawnDelay"] = new TagNodeShort(200);
							tagNodeCompound["RequiredPlayerRange"] = new TagNodeShort(16);
							tagNodeCompound["SpawnCount"] = new TagNodeShort(4);
							tagNodeCompound["SpawnRange"] = new TagNodeShort(4);
							num++;
						}
						else if (text == "Sign")
						{
							this.method_10(tagNodeCompound);
						}
						tagNodeCompound.Remove("Lock");
						if (tagNodeCompound.ContainsKey("Invulnerable"))
						{
							tagNodeCompound["Invulnerable"] = new TagNodeByte(0);
						}
						if (tagNodeCompound.ContainsKey("Item"))
						{
							int d2 = this.method_9(tagNodeCompound["Item"]);
							tagNodeCompound["Item"] = new TagNodeInt(d2);
						}
						if (tagNodeCompound.ContainsKey("Items"))
						{
							this.method_12(tagNodeCompound);
						}
					}
					else
					{
						tagNodeList.Remove(tagNodeCompound);
					}
				}
			}
			return tagNodeList;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001E9C8 File Offset: 0x0001CBC8
		private int method_9(TagNode tagNode_0)
		{
			int result = 0;
			if (tagNode_0 is TagNodeString)
			{
				string data = ((TagNodeString)tagNode_0).Data;
				if (ItemLookups.ItemsByName.ContainsKey(data))
				{
					result = (int)((short)ItemLookups.ItemsByName[data].Id);
				}
				else if (Class29.smethod_2().ContainsKey(data))
				{
					result = (int)((short)Class29.smethod_2()[data].Id);
				}
			}
			else if (tagNode_0 is TagNodeInt)
			{
				int data2 = ((TagNodeInt)tagNode_0).Data;
				if (ItemLookups.ItemsById.ContainsKey(data2) || Class29.smethod_1().ContainsKey(data2))
				{
					result = data2;
				}
			}
			return result;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001EA60 File Offset: 0x0001CC60
		private void method_10(TagNodeCompound tagNodeCompound_0)
		{
			try
			{
				((TagNodeString)tagNodeCompound_0["Text1"]).Data = this.method_11(((TagNodeString)tagNodeCompound_0["Text1"]).Data);
				((TagNodeString)tagNodeCompound_0["Text2"]).Data = this.method_11(((TagNodeString)tagNodeCompound_0["Text2"]).Data);
				((TagNodeString)tagNodeCompound_0["Text3"]).Data = this.method_11(((TagNodeString)tagNodeCompound_0["Text3"]).Data);
				((TagNodeString)tagNodeCompound_0["Text4"]).Data = this.method_11(((TagNodeString)tagNodeCompound_0["Text4"]).Data);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001EB44 File Offset: 0x0001CD44
		private string method_11(string string_0)
		{
			/*
An exception occurred when decompiling this method (060003EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String UMT_PC_To_Console_Convertor.MCSBCode.ConvertFromPC::method_11(System.String)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001EBD4 File Offset: 0x0001CDD4
		private void method_12(TagNodeCompound tagNodeCompound_0)
		{
			if (!tagNodeCompound_0.ContainsKey("Items"))
			{
				return;
			}
			TagNodeList tagNodeList = tagNodeCompound_0["Items"] as TagNodeList;
			if (tagNodeList != null)
			{
				for (int i = tagNodeList.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
					if (tagNodeCompound.ContainsKey("id"))
					{
						string key = this.method_15(tagNodeCompound);
						short num = -1;
						if (ItemLookups.ItemsByName.ContainsKey(key))
						{
							if (!ItemLookups.ItemsByName[key].OnConsole)
							{
								num = (short)((ItemLookups.ItemsByName[key].ReplaceId > 0) ? ItemLookups.ItemsByName[key].ReplaceId : -1);
							}
							else
							{
								num = (short)ItemLookups.ItemsByName[key].Id;
							}
						}
						else if (Class29.smethod_2().ContainsKey(key))
						{
							if (!Class29.smethod_2()[key].method_4())
							{
								num = (short)((Class29.smethod_2()[key].method_6() > 0) ? Class29.smethod_2()[key].method_6() : -1);
							}
							else
							{
								num = (short)Class29.smethod_2()[key].Id;
							}
						}
						if (num >= 0)
						{
							tagNodeCompound.Remove("id");
							tagNodeCompound.Add("id", new TagNodeShort(num));
							if (num != 386)
							{
								if (num != 387)
								{
									goto IL_D4;
								}
							}
							this.method_13(tagNodeCompound);
						}
						else
						{
							tagNodeList.Remove(tagNodeCompound);
						}
					}
					else
					{
						tagNodeList.Remove(tagNodeCompound);
					}
					IL_D4:;
				}
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001ED78 File Offset: 0x0001CF78
		private void method_13(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0 != null && tagNodeCompound_0.ContainsKey("tag"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["tag"] as TagNodeCompound;
				if (tagNodeCompound.ContainsKey("pages"))
				{
					TagNodeList tagNodeList = tagNodeCompound["pages"] as TagNodeList;
					for (int i = 0; i < tagNodeList.Count; i++)
					{
						string text = (TagNodeString)tagNodeList[i];
						text = text.Replace("\\n", "\n");
						text = this.method_14(text);
						tagNodeList[i] = new TagNodeString(text);
					}
				}
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001EE10 File Offset: 0x0001D010
		private string method_14(string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = string.Empty;
			bool flag = false;
			try
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					char c = string_0[i];
					if (c == '\\' && !flag && string_0[i + 1] == 'u')
					{
						flag = true;
					}
					if (!flag)
					{
						stringBuilder.Append(c);
					}
					else
					{
						if (c != '\\')
						{
							text += c;
						}
						if (text.Length == 5)
						{
							byte[] bytes = Utils.ConvertHexStringToByteArray(text.Substring(3));
							string @string = Encoding.ASCII.GetString(bytes);
							stringBuilder.Append(@string);
							flag = false;
							text = string.Empty;
						}
					}
				}
			}
			catch (Exception)
			{
				return string_0;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		private string method_15(TagNodeCompound tagNodeCompound_0)
		{
			string result = string.Empty;
			if (tagNodeCompound_0["id"] is TagNodeString)
			{
				result = (tagNodeCompound_0["id"] as TagNodeString);
			}
			else if (tagNodeCompound_0["id"] is TagNodeShort)
			{
				short key = tagNodeCompound_0["id"] as TagNodeShort;
				if (ItemLookups.ItemsById.ContainsKey((int)key))
				{
					result = ItemLookups.ItemsById[(int)key].MCName;
				}
				else if (Class29.smethod_1().ContainsKey((int)key))
				{
					result = Class29.smethod_1()[(int)key].method_0();
				}
			}
			return result;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001EF88 File Offset: 0x0001D188
		private TagNodeList method_16(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			TagNodeList tagNodeList_ = tagNodeCompound_0.ContainsKey("Entities") ? (tagNodeCompound_0["Entities"] as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			return this.method_17(tagNodeList_);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001EFC4 File Offset: 0x0001D1C4
		private TagNodeList method_17(TagNodeList tagNodeList_0)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
			{
				if (tagNodeList_0[i] is TagNodeCompound)
				{
					TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
					if (tagNodeCompound != null && this.method_18(tagNodeCompound))
					{
						try
						{
							TagNodeCompound tagNodeCompound2 = (TagNodeCompound)tagNodeCompound.Copy();
							this.method_21(tagNodeCompound2);
							if (tagNodeCompound.ContainsKey("Riding"))
							{
								this.method_19(tagNodeCompound2);
							}
							else
							{
								this.method_20(tagNodeCompound2);
							}
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001F060 File Offset: 0x0001D260
		private bool method_18(TagNodeCompound tagNodeCompound_0)
		{
			bool result = false;
			if (tagNodeCompound_0.ContainsKey("id") && tagNodeCompound_0["id"] is TagNodeString)
			{
				string text = (TagNodeString)tagNodeCompound_0["id"];
				if (!(text != "Item") || !(text != "minecraft:item"))
				{
					result = this.method_26(tagNodeCompound_0["Item"] as TagNodeCompound);
				}
				else if (this.entityLookup_0.Dictionary_0.ContainsKey(text))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001F0F0 File Offset: 0x0001D2F0
		private void method_19(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0 != null && tagNodeCompound_0.ContainsKey("Riding"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["Riding"] as TagNodeCompound;
				if (tagNodeCompound == null || !this.method_18(tagNodeCompound))
				{
					tagNodeCompound_0.Remove("Riding");
				}
				else
				{
					TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
					tagNodeCompound_0["Riding"] = tagNodeList;
					tagNodeList.Add(tagNodeCompound);
					this.method_21(tagNodeCompound);
					if (tagNodeCompound.ContainsKey("Riding"))
					{
						this.method_19(tagNodeCompound);
						return;
					}
				}
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001F170 File Offset: 0x0001D370
		private void method_20(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0 != null && tagNodeCompound_0.ContainsKey("Passengers"))
			{
				TagNodeList tagNodeList = tagNodeCompound_0["Passengers"] as TagNodeList;
				tagNodeCompound_0.Remove("Passengers");
				if (tagNodeList != null && tagNodeList.Count > 0)
				{
					tagNodeCompound_0["Riding"] = tagNodeList;
					for (int i = tagNodeList.Count - 1; i >= 0; i--)
					{
						TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
						if (tagNodeCompound == null || !this.method_18(tagNodeCompound))
						{
							tagNodeList.Remove(tagNodeCompound);
						}
						else
						{
							this.method_21(tagNodeCompound);
							if (tagNodeCompound.ContainsKey("Passengers"))
							{
								this.method_20(tagNodeCompound);
							}
						}
					}
				}
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001F21C File Offset: 0x0001D41C
		private void method_21(TagNodeCompound tagNodeCompound_0)
		{
			string text = (TagNodeString)tagNodeCompound_0["id"];
			int d = 0;
			if (!(text != "Item") || !(text != "minecraft:item"))
			{
				text = "Item";
			}
			else
			{
				EntityItem entityItem = this.entityLookup_0.Dictionary_0[text];
				text = entityItem.ConsoleName;
				d = entityItem.EntityType;
			}
			tagNodeCompound_0["id"] = new TagNodeString(text);
			if (text == "EntityHorse")
			{
				tagNodeCompound_0["Type"] = new TagNodeInt(d);
				tagNodeCompound_0["Variant"] = new TagNodeInt(0);
			}
			this.method_24(tagNodeCompound_0);
			if (tagNodeCompound_0.ContainsKey("Equipment"))
			{
				this.method_28(tagNodeCompound_0["Equipment"] as TagNodeList);
			}
			if (tagNodeCompound_0.ContainsKey("Items"))
			{
				this.method_28(tagNodeCompound_0["Items"] as TagNodeList);
			}
			if (tagNodeCompound_0.ContainsKey("Item"))
			{
				this.method_26(tagNodeCompound_0["Item"] as TagNodeCompound);
			}
			else if (tagNodeCompound_0.ContainsKey("SaddleItem"))
			{
				this.method_26(tagNodeCompound_0["SaddleItem"] as TagNodeCompound);
			}
			if (text == "Painting" || text == "ItemFrame")
			{
				this.method_25(tagNodeCompound_0);
			}
			if (text == "Villager" && tagNodeCompound_0.ContainsKey("Offers"))
			{
				this.method_22(tagNodeCompound_0);
			}
			tagNodeCompound_0.Remove("UUIDLeast");
			tagNodeCompound_0.Remove("UUIDMost");
			tagNodeCompound_0.Remove("HurtBy");
			tagNodeCompound_0.Remove("HurtByTimestamp");
			if (tagNodeCompound_0.ContainsKey("Invulnerable"))
			{
				tagNodeCompound_0["Invulnerable"] = new TagNodeByte(0);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001F410 File Offset: 0x0001D610
		private void method_22(TagNodeCompound tagNodeCompound_0)
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
							this.method_23(tagNodeCompound2["buy"] as TagNodeCompound);
						}
						if (tagNodeCompound2.ContainsKey("buyB"))
						{
							this.method_23(tagNodeCompound2["buyB"] as TagNodeCompound);
						}
						if (tagNodeCompound2.ContainsKey("sell"))
						{
							this.method_23(tagNodeCompound2["sell"] as TagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001F504 File Offset: 0x0001D704
		private void method_23(TagNodeCompound tagNodeCompound_0)
		{
			short num = -1;
			bool flag = false;
			if (tagNodeCompound_0.ContainsKey("id"))
			{
				if (tagNodeCompound_0["id"] is TagNodeString)
				{
					string key = tagNodeCompound_0["id"] as TagNodeString;
					if (ItemLookups.ItemsByName.ContainsKey(key))
					{
						num = (short)ItemLookups.ItemsByName[key].Id;
					}
					else if (Class29.smethod_2().ContainsKey(key) && Class29.smethod_2()[key].method_8())
					{
						num = (short)Class29.smethod_2()[key].Id;
					}
				}
				else if (tagNodeCompound_0["id"] is TagNodeShort)
				{
					short num2 = tagNodeCompound_0["id"] as TagNodeShort;
					if (ItemLookups.ItemsById.ContainsKey((int)num2) || (Class29.smethod_1().ContainsKey((int)num2) && Class29.smethod_1()[(int)num2].method_8()))
					{
						num = num2;
					}
				}
				if (num >= 0)
				{
					this.method_27(tagNodeCompound_0, num);
					flag = true;
				}
				else
				{
					this.method_27(tagNodeCompound_0, 388);
				}
			}
			if (flag)
			{
				if (num != 386)
				{
					if (num != 387)
					{
						goto IL_86;
					}
				}
				this.method_13(tagNodeCompound_0);
			}
			IL_86:
			if (flag && tagNodeCompound_0.ContainsKey("tag"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["tag"] as TagNodeCompound;
				if (tagNodeCompound != null && tagNodeCompound.ContainsKey("BlockEntityTag"))
				{
					TagNodeCompound tagNodeCompound2 = tagNodeCompound["BlockEntityTag"] as TagNodeCompound;
					if (tagNodeCompound2 != null && tagNodeCompound2.ContainsKey("Items"))
					{
						this.method_28(tagNodeCompound2["Items"] as TagNodeList);
					}
				}
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		private void method_24(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0.ContainsKey("Attributes"))
			{
				TagNodeList tagNodeList = tagNodeCompound_0["Attributes"] as TagNodeList;
				for (int i = tagNodeList.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
					if (tagNodeCompound.ContainsKey("Modifiers"))
					{
						tagNodeCompound.Remove("Modifiers");
					}
					if (!tagNodeCompound.ContainsKey("Name") || !(tagNodeCompound["Name"] is TagNodeString))
					{
						tagNodeList.Remove(tagNodeCompound);
					}
					else
					{
						string key = tagNodeCompound["Name"].ToTagString();
						if (AttributeLookup.attributesByName.ContainsKey(key))
						{
							tagNodeCompound.Remove("Name");
							tagNodeCompound.Add("ID", new TagNodeInt(AttributeLookup.attributesByName[key]));
						}
						else
						{
							tagNodeList.Remove(tagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001F7C8 File Offset: 0x0001D9C8
		private void method_25(TagNodeCompound tagNodeCompound_0)
		{
			double num = 0.03125;
			if (tagNodeCompound_0.ContainsKey("Facing"))
			{
				byte b = tagNodeCompound_0["Facing"] as TagNodeByte;
				tagNodeCompound_0.Remove("Facing");
				TagNodeList tagNodeList = tagNodeCompound_0["Rotation"] as TagNodeList;
				TagNodeList tagNodeList2 = tagNodeCompound_0["Pos"] as TagNodeList;
				double num2 = tagNodeList2[0] as TagNodeDouble;
				double num3 = tagNodeList2[2] as TagNodeDouble;
				int num4 = tagNodeCompound_0["TileX"] as TagNodeInt;
				int num5 = tagNodeCompound_0["TileZ"] as TagNodeInt;
				if (b == 0)
				{
					tagNodeList[0] = new TagNodeFloat(180f);
					tagNodeCompound_0["Dir"] = new TagNodeByte(2);
					tagNodeCompound_0["Direction"] = new TagNodeByte(0);
					tagNodeCompound_0["TileZ"] = new TagNodeInt(num5 - 1);
					tagNodeList2[2] = new TagNodeDouble(num3 + num);
					return;
				}
				if (b == 1)
				{
					tagNodeCompound_0["Dir"] = new TagNodeByte(1);
					tagNodeCompound_0["Direction"] = new TagNodeByte(1);
					tagNodeCompound_0["TileX"] = new TagNodeInt(num4 + 1);
					tagNodeList2[0] = new TagNodeDouble(num2 - num);
					return;
				}
				if (b == 2)
				{
					tagNodeList[0] = new TagNodeFloat(0f);
					tagNodeCompound_0["Dir"] = new TagNodeByte(0);
					tagNodeCompound_0["Direction"] = new TagNodeByte(2);
					tagNodeCompound_0["TileZ"] = new TagNodeInt(num5 + 1);
					tagNodeList2[2] = new TagNodeDouble(num3 - num);
					return;
				}
				if (b == 3)
				{
					tagNodeCompound_0["Dir"] = new TagNodeByte(3);
					tagNodeCompound_0["Direction"] = new TagNodeByte(3);
					tagNodeCompound_0["TileX"] = new TagNodeInt(num4 - 1);
					tagNodeList2[0] = new TagNodeDouble(num2 + num);
				}
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		private bool method_26(TagNodeCompound tagNodeCompound_0)
		{
			short num = -1;
			bool flag = false;
			if (tagNodeCompound_0.ContainsKey("id"))
			{
				if (tagNodeCompound_0["id"] is TagNodeString)
				{
					string key = tagNodeCompound_0["id"] as TagNodeString;
					if (ItemLookups.ItemsByName.ContainsKey(key))
					{
						num = (short)ItemLookups.ItemsByName[key].Id;
					}
					else if (Class29.smethod_2().ContainsKey(key))
					{
						num = (short)Class29.smethod_2()[key].Id;
					}
					if (num >= 0)
					{
						tagNodeCompound_0.Remove("id");
						tagNodeCompound_0.Add("id", new TagNodeShort(num));
						flag = true;
					}
					else
					{
						this.method_27(tagNodeCompound_0, 0);
					}
				}
				else if (tagNodeCompound_0["id"] is TagNodeShort)
				{
					num = (tagNodeCompound_0["id"] as TagNodeShort);
					if (ItemLookups.ItemsById.ContainsKey((int)num) || Class29.smethod_1().ContainsKey((int)num))
					{
						flag = true;
					}
					else
					{
						this.method_27(tagNodeCompound_0, 0);
					}
				}
				else
				{
					this.method_27(tagNodeCompound_0, 0);
				}
			}
			if (flag)
			{
				if (num != 386)
				{
					if (num != 387)
					{
						return flag;
					}
				}
				this.method_13(tagNodeCompound_0);
			}
			return flag;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00004638 File Offset: 0x00002838
		private void method_27(TagNodeCompound tagNodeCompound_0, short short_0 = 0)
		{
			tagNodeCompound_0.Remove("id");
			tagNodeCompound_0.Add("id", new TagNodeShort(short_0));
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		private void method_28(TagNodeList tagNodeList_0)
		{
			if (tagNodeList_0 != null)
			{
				for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
					if (tagNodeCompound.ContainsKey("id"))
					{
						if (tagNodeCompound["id"] is TagNodeString)
						{
							string key = tagNodeCompound["id"] as TagNodeString;
							short num = -1;
							if (ItemLookups.ItemsByName.ContainsKey(key))
							{
								num = (short)ItemLookups.ItemsByName[key].Id;
							}
							else if (Class29.smethod_2().ContainsKey(key))
							{
								num = (short)Class29.smethod_2()[key].Id;
							}
							if (num >= 0)
							{
								tagNodeCompound.Remove("id");
								tagNodeCompound.Add("id", new TagNodeShort(num));
							}
							else
							{
								tagNodeList_0.Remove(tagNodeCompound);
							}
						}
						else if (tagNodeCompound["id"] is TagNodeShort)
						{
							short key2 = tagNodeCompound["id"] as TagNodeShort;
							if (!ItemLookups.ItemsById.ContainsKey((int)key2) && !Class29.smethod_1().ContainsKey((int)key2))
							{
								tagNodeList_0.Remove(tagNodeCompound);
							}
						}
						else
						{
							tagNodeList_0.Remove(tagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001FC70 File Offset: 0x0001DE70
		private void method_29(TagNodeByteArray tagNodeByteArray_0, byte byte_0)
		{
			for (int i = 0; i < tagNodeByteArray_0.Length; i++)
			{
				tagNodeByteArray_0[i] = byte_0;
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001FC98 File Offset: 0x0001DE98
		private void method_30(string string_0)
		{
			this.int_2++;
			int int_ = (int)((float)(this.int_2 + 1) / (float)this.int_3 * 100f);
			this.method_31(string_0, int_);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004657 File Offset: 0x00002857
		private void method_31(string string_0, int int_4 = 0)
		{
			if (this.convertFromPCParameters_0 != null)
			{
				this.convertFromPCParameters_0.Count = this.int_2;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001FCD4 File Offset: 0x0001DED4
		private byte[] method_32(TagNodeCompound tagNodeCompound_0, int int_4, ConvertParameters convertParameters_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			int num = (TagNodeInt)tagNodeCompound["xPos"];
			int num2 = (TagNodeInt)tagNodeCompound["zPos"];
			int num3 = (num >= 0) ? (num * 16) : ((num + 1) * 16);
			int num4 = (num2 >= 0) ? (num2 * 16) : ((num2 + 1) * 16);
			TagNodeList value;
			if (convertParameters_0.ConvertEntities)
			{
				value = this.method_16(tagNodeCompound, convertParameters_0);
			}
			else
			{
				value = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value2;
			if (convertParameters_0.ConvertTileEntities)
			{
				value2 = this.method_8(tagNodeCompound, convertParameters_0);
			}
			else
			{
				value2 = new TagNodeList(TagType.TAG_COMPOUND);
			}
			TagNodeList value3 = new TagNodeList(TagType.TAG_COMPOUND);
			int num5 = int_4 / 2;
			TagNodeByteArray tagNodeByteArray = new TagNodeByteArray(new byte[int_4]);
			TagNodeByteArray b = new TagNodeByteArray(new byte[num5]);
			TagNodeByteArray b2 = new TagNodeByteArray(new byte[num5]);
			TagNodeByteArray tagNodeByteArray2 = new TagNodeByteArray(new byte[num5]);
			this.method_29(tagNodeByteArray2, byte.MaxValue);
			TagNodeList tagNodeList = tagNodeCompound["Sections"] as TagNodeList;
			for (int i = 0; i < tagNodeList.Count; i++)
			{
				TagNodeCompound tagNodeCompound2 = tagNodeList[i] as TagNodeCompound;
				int num6 = tagNodeCompound2["Y"] as TagNodeByte;
				if (num6 >= 8)
				{
				}
				int num7 = num6 * 4096;
				TagNodeByteArray tagNodeByteArray3 = tagNodeCompound2["Blocks"] as TagNodeByteArray;
				TagNodeByteArray b3 = tagNodeCompound2["Data"] as TagNodeByteArray;
				TagNodeByteArray b4 = tagNodeCompound2["BlockLight"] as TagNodeByteArray;
				TagNodeByteArray b5 = tagNodeCompound2["SkyLight"] as TagNodeByteArray;
				if (tagNodeCompound2.ContainsKey("Add"))
				{
					TagNode tagNode = tagNodeCompound2["Add"];
				}
				for (int j = 0; j < 16; j++)
				{
					int num8 = num6 * 16;
					for (int k = 0; k < 16; k++)
					{
						int num9 = k * 256;
						for (int l = 0; l < 16; l++)
						{
							int num10 = (int)tagNodeByteArray3[k << 8 | l << 4 | j];
							int num11;
							int val;
							if (num10 != 0)
							{
								num11 = nibbleSetters.AnvilGet(b3, j, k, l);
								val = nibbleSetters.AnvilGet(b4, j, k, l);
							}
							else
							{
								num11 = 0;
								val = 0;
							}
							int val2 = nibbleSetters.AnvilGet(b5, j, k, l);
							if (!Class29.smethod_1().ContainsKey(num10))
							{
								num10 = this.blockChange_0.ToBlock;
								num11 = this.blockChange_0.ToData;
							}
							else if (convertParameters_0.ReplaceBlocks && (this.bool_0[num10] || this.bool_0[256]))
							{
								int m = 0;
								while (m < convertParameters_0.BlockChanges.Count)
								{
									if (convertParameters_0.BlockChanges[m].FromBlock == -1)
									{
										goto IL_3DE;
									}
									if (num10 == convertParameters_0.BlockChanges[m].FromBlock)
									{
										goto IL_3DE;
									}
									IL_416:
									m++;
									continue;
									IL_3DE:
									if ((!convertParameters_0.BlockChanges[m].Layers.Contains(num8) && !convertParameters_0.BlockChanges[m].Layers.Contains(-1)) || (!convertParameters_0.BlockChanges[m].FromData.Contains(-1) && !convertParameters_0.BlockChanges[m].FromData.Contains(num11)))
									{
										goto IL_416;
									}
									int num12 = num10;
									num10 = (int)((byte)convertParameters_0.BlockChanges[m].ToBlock);
									if (convertParameters_0.BlockChanges[m].ToData != -1)
									{
										num11 = convertParameters_0.BlockChanges[m].ToData;
									}
									if (convertParameters_0.BlockChanges[m].ToBlockLight != -1)
									{
										val = convertParameters_0.BlockChanges[m].ToBlockLight;
									}
									if (Class36.smethod_30(num12))
									{
										int num13 = num3 + ((num >= 0) ? j : ((16 - j) * -1));
										int num14 = num4 + ((num2 >= 0) ? l : ((16 - l) * -1));
										Class36.FDJFKWMKFG(tagNodeCompound_0, num13, num8, num14);
										break;
									}
									break;
								}
							}
							if (convertParameters_0.DataValidation && num11 > 0)
							{
								if (BlockDataValues.BlockDataList.ContainsKey(num10))
								{
									if (!BlockDataValues.BlockDataList[num10].Contains(num11))
									{
										num11 = BlockDataValues.BlockDataList[num10][0];
									}
								}
								else
								{
									num11 = 0;
								}
							}
							tagNodeByteArray[num7 + num9 + j * 16 + l] = (byte)num10;
							nibbleSetters.TU17Set(b, j, num8, l, num11);
							nibbleSetters.TU17Set(tagNodeByteArray2, j, num8, l, val2);
							nibbleSetters.TU17Set(b2, j, num8, l, val);
						}
						num8++;
					}
				}
			}
			TagNodeByteArray tagNodeByteArray4 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("HeightMap"))
			{
				TagNodeIntArray tagNodeIntArray = tagNodeCompound["HeightMap"] as TagNodeIntArray;
				for (int n = 0; n < 256; n++)
				{
					tagNodeByteArray4[n] = (byte)tagNodeIntArray[n];
				}
			}
			TagNodeByteArray tagNodeByteArray5 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("Biomes"))
			{
				TagNodeByteArray tagNodeByteArray6 = tagNodeCompound["Biomes"] as TagNodeByteArray;
				for (int num15 = 0; num15 < 16; num15++)
				{
					for (int num16 = 0; num16 < 16; num16++)
					{
						tagNodeByteArray5[num15 << 4 | num16] = tagNodeByteArray6[num16 << 4 | num15];
					}
				}
			}
			this.method_6(tagNodeByteArray5, convertParameters_0);
			TagNodeCompound tagNodeCompound3 = new TagNodeCompound();
			tagNodeCompound3.Add("Entities", value);
			tagNodeCompound3.Add("TileEntities", value2);
			tagNodeCompound3.Add("TileTicks", value3);
			TU17ChunkData tu17ChunkData = new TU17ChunkData();
			tu17ChunkData.TU17VersionType_0 = convertParameters_0.TU17VersionType_0;
			tu17ChunkData.Blocks = tagNodeByteArray;
			tu17ChunkData.BlockData = b;
			tu17ChunkData.BlockLight = b2;
			tu17ChunkData.SkyLight = tagNodeByteArray2;
			tu17ChunkData.HeightMap = tagNodeByteArray4;
			tu17ChunkData.Biomes = tagNodeByteArray5;
			tu17ChunkData.X = num;
			tu17ChunkData.Z = num2;
			tu17ChunkData.NBTData = tagNodeCompound3;
			TU17Builder tu17Builder = new TU17Builder();
			return tu17Builder.BuildChunk(tu17ChunkData).ToArray();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000469B File Offset: 0x0000289B
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000469B File Offset: 0x0000289B
		[CompilerGenerated]
		private static int smethod_1(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x04000228 RID: 552
		private Dictionary<int, List<int>> dictionary_0 = new Dictionary<int, List<int>>();

		// Token: 0x04000229 RID: 553
		private ConvertFromPCParameters convertFromPCParameters_0;

		// Token: 0x0400022A RID: 554
		private EntityLookup entityLookup_0 = new EntityLookup();

		// Token: 0x0400022B RID: 555
		private TileEntityLookup dJdnUkfOtt = new TileEntityLookup();

		// Token: 0x0400022C RID: 556
		private bool[] bool_0;

		// Token: 0x0400022D RID: 557
		private int int_0;

		// Token: 0x0400022E RID: 558
		private int int_1;

		// Token: 0x0400022F RID: 559
		private BlockChange blockChange_0;

		// Token: 0x04000230 RID: 560
		private int int_2;

		// Token: 0x04000231 RID: 561
		private int int_3;

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;

		// Token: 0x04000233 RID: 563
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_1;
	}
}
