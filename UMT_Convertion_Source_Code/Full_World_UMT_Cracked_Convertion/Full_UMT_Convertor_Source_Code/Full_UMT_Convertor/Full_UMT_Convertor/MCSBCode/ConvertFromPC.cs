using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000088 RID: 136
	public class ConvertFromPC
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x0002D928 File Offset: 0x0002BB28
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

		// Token: 0x06000532 RID: 1330 RVA: 0x0002D980 File Offset: 0x0002BB80
		public void ExtractPCRegion(string regionName, string regionfolder, string pcRegionFolder, string workingFolder, ConvertParameters convertParameters)
		{
			try
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
					}
					else
					{
						string string_ = string.Concat(new string[]
						{
							workingFolder,
							Working.smethod_4(),
							FileUtils.CheckFolderSep(regionfolder),
							regionName,
							".mcr"
						});
						Class46.smethod_33(string_);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002DA28 File Offset: 0x0002BC28
		private void method_0(string string_0, string string_1, string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			XBOXCompression xboxcompression_ = new XBOXCompression();
			List<ChunkIndexEntry> list = null;
			list = Class46.smethod_5(string_2);
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
				this.int_2 += Constants.consoleRegionSizes[string_0];
				Class46.smethod_33(text2);
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
					Class46.smethod_25(binaryWriter);
					List<int> list2;
					if (!convertParameters_0.ConvertNewGen)
					{
						list2 = Class23.smethod_1()[string_1][string_0];
					}
					else
					{
						list2 = Class23.smethod_2()[string_1][string_0];
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
							byte[] array = null;
							try
							{
								array = this.method_3(chunkData, binaryReader, string_5, convertParameters_0);
							}
							catch (Exception)
							{
								array = null;
							}
							if (array != null && array.Length > 0)
							{
								array = this.method_2(array, chunkData, xboxcompression_);
								Class46.smethod_13(array, chunkData.method_0(), binaryWriter);
							}
						}
					}
					Class46.smethod_31(binaryWriter, list);
					if (this.convertFromPCParameters_0 != null)
					{
						this.convertFromPCParameters_0.ProcessingCompleted = true;
					}
				}
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		private void method_1(string string_0, string string_1, string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			XBOXCompression xboxcompression_ = new XBOXCompression();
			MemoryStream memoryStream = new MemoryStream();
			List<ChunkIndexEntry> list = null;
			list = Class46.smethod_5(string_2);
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
				this.int_2 += Constants.consoleRegionSizes[string_0];
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
				Class46.smethod_26(memoryStream);
				List<int> list2 = Class23.smethod_1()[string_1][string_0];
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
							Class46.smethod_14(array, chunkData.method_0(), memoryStream);
						}
					}
				}
				Class46.smethod_32(memoryStream, list);
				FileUtils.WriteFile(memoryStream, filename);
				if (this.convertFromPCParameters_0 != null)
				{
					this.convertFromPCParameters_0.ProcessingCompleted = true;
					return;
				}
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0002DEBC File Offset: 0x0002C0BC
		private byte[] method_2(byte[] byte_0, ChunkData chunkData_0, XBOXCompression xboxcompression_0)
		{
			byte[] array = null;
			if (Working.GameType == (Enum2)1)
			{
				array = xboxcompression_0.DoCompress(byte_0, 8);
				Class46.smethod_27(array.Length - 8, array);
				Class46.smethod_28(chunkData_0.NewFileSize, array);
			}
			else if (Working.GameType == (Enum2)2)
			{
				int num = byte_0.Length;
				array = Class46.smethod_66(byte_0);
				byte[] first = new byte[12];
				array = first.Concat(array).ToArray<byte>();
				Class46.smethod_27(array.Length - 8, array);
				Class46.smethod_28(chunkData_0.NewFileSize, array);
				Class46.smethod_29(num, array);
			}
			else if (Working.GameType == (Enum2)3)
			{
				array = Class46.smethod_63(byte_0);
				byte[] first2 = new byte[8];
				array = first2.Concat(array).ToArray<byte>();
				Class46.smethod_27(array.Length - 8, array);
				Class46.smethod_28(chunkData_0.NewFileSize, array);
			}
			return array;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0002DF84 File Offset: 0x0002C184
		private byte[] method_3(ChunkData chunkData_0, BinaryReader binaryReader_0, string string_0, ConvertParameters convertParameters_0)
		{
			byte[] array = null;
			this.method_31(string_0 + chunkData_0.method_0().ChunkIndex.ToString());
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
				try
				{
					if (b == 1)
					{
						array = Class46.smethod_65(array);
					}
					else
					{
						array = Class46.smethod_64(array);
					}
				}
				catch (Exception)
				{
					throw;
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

		// Token: 0x06000537 RID: 1335 RVA: 0x0002E09C File Offset: 0x0002C29C
		internal byte[] method_4(ChunkData chunkData_0, byte[] byte_0, ConvertParameters convertParameters_0)
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
				array = this.method_33(nbtTree.Root, int_, convertParameters_0);
			}
			chunkData_0.NewFileSize = array.Length;
			memoryStream = Class46.smethod_70(array);
			return memoryStream.ToArray();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0002E13C File Offset: 0x0002C33C
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
			this.method_30(tagNodeByteArray4, byte.MaxValue);
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
							if (!Class34.smethod_1().ContainsKey(num10))
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
									if (Class46.smethod_35(num12))
									{
										int num13 = num3 + ((num >= 0) ? j : ((16 - j) * -1));
										int num14 = num4 + ((num2 >= 0) ? l : ((16 - l) * -1));
										Class46.smethod_37(tagNodeCompound_0, num13, num9, num14);
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

		// Token: 0x06000539 RID: 1337 RVA: 0x0002E804 File Offset: 0x0002CA04
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

		// Token: 0x0600053A RID: 1338 RVA: 0x0002E894 File Offset: 0x0002CA94
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

		// Token: 0x0600053B RID: 1339 RVA: 0x0002E8EC File Offset: 0x0002CAEC
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
					if (!this.tileEntityLookup_0.Dictionary_0.ContainsKey(text))
					{
						tagNodeList.Remove(tagNodeCompound);
					}
					else
					{
						if (!convertParameters_0.ConvertNewGen && this.convertFromPCParameters_0.RegionFolder != "DIM1")
						{
							if (num2 <= 431 && num2 >= -432 && num3 <= 431)
							{
								if (num3 >= -432)
								{
									goto IL_FF;
								}
							}
							tagNodeList.Remove(tagNodeCompound);
							goto IL_74;
						}
						IL_FF:
						if (!convertParameters_0.BlockEntityConversionList.Contains(this.tileEntityLookup_0.Dictionary_0[text].ConsoleName))
						{
							tagNodeList.Remove(tagNodeCompound);
						}
						else
						{
							text = this.tileEntityLookup_0.Dictionary_0[text].ConsoleName;
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
												if (this.entityLookup_0.Dictionary_0.ContainsKey((TagNodeString)tagNodeCompound4["id"]))
												{
													tagNodeCompound4["id"] = new TagNodeString(this.entityLookup_0.Dictionary_0[(TagNodeString)tagNodeCompound4["id"]].ConsoleName);
												}
												else
												{
													tagNodeCompound4["id"] = new TagNodeString("Pig");
												}
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
								if (!convertParameters_0.RetainSpawnerSettings)
								{
									tagNodeCompound["Delay"] = new TagNodeShort(20);
									tagNodeCompound["MaxNearbyEntities"] = new TagNodeShort(6);
									tagNodeCompound["MaxSpawnDelay"] = new TagNodeShort(800);
									tagNodeCompound["MinSpawnDelay"] = new TagNodeShort(200);
									tagNodeCompound["RequiredPlayerRange"] = new TagNodeShort(16);
									tagNodeCompound["SpawnCount"] = new TagNodeShort(4);
									tagNodeCompound["SpawnRange"] = new TagNodeShort(4);
								}
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
								int num4 = this.method_9(tagNodeCompound["Item"]);
								if (this.convertFromPCParameters_0.ConvertParameters.ItemIdString)
								{
									if (ConsoleItemLookups.ItemsById.ContainsKey(num4))
									{
										string mcname = ConsoleItemLookups.ItemsById[num4].MCName;
										tagNodeCompound["Item"] = new TagNodeString(mcname);
									}
									else
									{
										tagNodeCompound["Item"] = new TagNodeString("");
									}
								}
								else
								{
									tagNodeCompound["Item"] = new TagNodeInt(num4);
								}
							}
							if (tagNodeCompound.ContainsKey("Items"))
							{
								this.method_12(tagNodeCompound["Items"] as TagNodeList);
							}
						}
					}
				}
				IL_74:;
			}
			return tagNodeList;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002EF18 File Offset: 0x0002D118
		private int method_9(TagNode tagNode_0)
		{
			int result = 0;
			if (tagNode_0 is TagNodeString)
			{
				string data = ((TagNodeString)tagNode_0).Data;
				if (ConsoleItemLookups.ItemsByName.ContainsKey(data))
				{
					result = (int)((short)ConsoleItemLookups.ItemsByName[data].Id);
				}
				else if (Class34.smethod_2().ContainsKey(data))
				{
					result = (int)((short)Class34.smethod_2()[data].Id);
				}
			}
			else if (tagNode_0 is TagNodeInt)
			{
				int data2 = ((TagNodeInt)tagNode_0).Data;
				if (ConsoleItemLookups.ItemsById.ContainsKey(data2) || Class34.smethod_1().ContainsKey(data2))
				{
					result = data2;
				}
			}
			return result;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
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

		// Token: 0x0600053E RID: 1342 RVA: 0x0002F094 File Offset: 0x0002D294
		private string method_11(string string_0)
		{
			/*
An exception occurred when decompiling this method (0600053E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Full_UMT_Convertor.MCSBCode.ConvertFromPC::method_11(System.String)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0002F124 File Offset: 0x0002D324
		private void method_12(TagNodeList tagNodeList_0)
		{
			if (tagNodeList_0 != null)
			{
				for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
					if (tagNodeCompound.ContainsKey("id"))
					{
						if (!this.method_27(tagNodeCompound, false))
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

		// Token: 0x06000540 RID: 1344 RVA: 0x0002F180 File Offset: 0x0002D380
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

		// Token: 0x06000541 RID: 1345 RVA: 0x0002F218 File Offset: 0x0002D418
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

		// Token: 0x06000542 RID: 1346 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		private string method_15(TagNodeCompound tagNodeCompound_0)
		{
			string text = string.Empty;
			if (tagNodeCompound_0["id"] is TagNodeString)
			{
				text = (tagNodeCompound_0["id"] as TagNodeString);
				if (ConsoleItemLookups.ItemsByName.ContainsKey(text))
				{
					text = ConsoleItemLookups.ItemsByName[text].MCName;
				}
				else if (Class34.smethod_2().ContainsKey(text))
				{
					text = Class34.smethod_2()[text].ApfHbuxQfqb();
				}
			}
			else if (tagNodeCompound_0["id"] is TagNodeShort)
			{
				short key = tagNodeCompound_0["id"] as TagNodeShort;
				if (ConsoleItemLookups.ItemsById.ContainsKey((int)key))
				{
					text = ConsoleItemLookups.ItemsById[(int)key].MCName;
				}
				else if (Class34.smethod_1().ContainsKey((int)key))
				{
					text = Class34.smethod_1()[(int)key].ApfHbuxQfqb();
				}
			}
			return text;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		private TagNodeList method_16(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			TagNodeList tagNodeList_ = tagNodeCompound_0.ContainsKey("Entities") ? (tagNodeCompound_0["Entities"] as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			return this.method_17(tagNodeList_, convertParameters_0);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0002F410 File Offset: 0x0002D610
		private TagNodeList method_17(TagNodeList tagNodeList_0, ConvertParameters convertParameters_0)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
			{
				if (tagNodeList_0[i] is TagNodeCompound)
				{
					TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
					if (tagNodeCompound != null && this.method_19(tagNodeCompound, convertParameters_0))
					{
						try
						{
							TagNodeCompound tagNodeCompound2 = (TagNodeCompound)tagNodeCompound.Copy();
							this.method_22(tagNodeCompound2);
							if (tagNodeCompound.ContainsKey("Riding"))
							{
								this.method_20(tagNodeCompound2, convertParameters_0);
							}
							else
							{
								this.method_21(tagNodeCompound2, convertParameters_0);
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

		// Token: 0x06000545 RID: 1349 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		private void method_18(TagNodeCompound tagNodeCompound_0)
		{
			if (tagNodeCompound_0.ContainsKey("id") && tagNodeCompound_0["id"] is TagNodeString)
			{
				string key = (TagNodeString)tagNodeCompound_0["id"];
				if (this.entityLookup_0.Dictionary_0.ContainsKey(key))
				{
					tagNodeCompound_0["id"] = new TagNodeString(this.entityLookup_0.Dictionary_0[key].PCName);
				}
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002F52C File Offset: 0x0002D72C
		private bool method_19(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			bool flag = false;
			if (tagNodeCompound_0.ContainsKey("id") && tagNodeCompound_0["id"] is TagNodeString)
			{
				string text = (TagNodeString)tagNodeCompound_0["id"];
				if (this.entityLookup_0.Dictionary_0.ContainsKey(text))
				{
					flag = ((text != "Item" && text != "minecraft:item") || this.method_27(tagNodeCompound_0["Item"] as TagNodeCompound, false));
					if (flag && !convertParameters_0.EntityConversionList.Contains(this.entityLookup_0.Dictionary_0[text].ConsoleName))
					{
						flag = false;
					}
				}
			}
			return flag;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002F5EC File Offset: 0x0002D7EC
		private void method_20(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
		{
			if (tagNodeCompound_0 != null && tagNodeCompound_0.ContainsKey("Riding"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["Riding"] as TagNodeCompound;
				if (tagNodeCompound == null || !this.method_19(tagNodeCompound, convertParameters_0))
				{
					tagNodeCompound_0.Remove("Riding");
				}
				else
				{
					TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
					tagNodeCompound_0["Riding"] = tagNodeList;
					tagNodeList.Add(tagNodeCompound);
					this.method_22(tagNodeCompound);
					if (tagNodeCompound.ContainsKey("Riding"))
					{
						this.method_20(tagNodeCompound, convertParameters_0);
						return;
					}
				}
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002F670 File Offset: 0x0002D870
		private void method_21(TagNodeCompound tagNodeCompound_0, ConvertParameters convertParameters_0)
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
						if (tagNodeCompound == null || !this.method_19(tagNodeCompound, convertParameters_0))
						{
							tagNodeList.Remove(tagNodeCompound);
						}
						else
						{
							this.method_22(tagNodeCompound);
							if (tagNodeCompound.ContainsKey("Passengers"))
							{
								this.method_21(tagNodeCompound, convertParameters_0);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0002F71C File Offset: 0x0002D91C
		private void method_22(TagNodeCompound tagNodeCompound_0)
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
			this.method_25(tagNodeCompound_0);
			if (tagNodeCompound_0.ContainsKey("Equipment"))
			{
				this.method_29(tagNodeCompound_0["Equipment"] as TagNodeList);
			}
			if (tagNodeCompound_0.ContainsKey("HandItems"))
			{
				this.method_29(tagNodeCompound_0["HandItems"] as TagNodeList);
			}
			if (tagNodeCompound_0.ContainsKey("ArmorItems"))
			{
				this.method_29(tagNodeCompound_0["ArmorItems"] as TagNodeList);
			}
			if (tagNodeCompound_0.ContainsKey("Items"))
			{
				this.method_29(tagNodeCompound_0["Items"] as TagNodeList);
			}
			if (tagNodeCompound_0.ContainsKey("Item"))
			{
				this.method_27(tagNodeCompound_0["Item"] as TagNodeCompound, false);
			}
			else if (tagNodeCompound_0.ContainsKey("SaddleItem"))
			{
				this.method_27(tagNodeCompound_0["SaddleItem"] as TagNodeCompound, false);
			}
			if (text == "Painting" || text == "ItemFrame")
			{
				this.method_26(tagNodeCompound_0);
			}
			if (text == "Villager" && tagNodeCompound_0.ContainsKey("Offers"))
			{
				this.method_23(tagNodeCompound_0);
			}
			tagNodeCompound_0.Remove("UUIDLeast");
			tagNodeCompound_0.Remove("UUIDMost");
			tagNodeCompound_0.Remove("HurtBy");
			tagNodeCompound_0.Remove("HurtByTimestamp");
			if (tagNodeCompound_0.ContainsKey("Invulnerable"))
			{
				tagNodeCompound_0["Invulnerable"] = new TagNodeByte(0);
			}
			this.method_18(tagNodeCompound_0);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002F960 File Offset: 0x0002DB60
		private void method_23(TagNodeCompound tagNodeCompound_0)
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
							this.method_24(tagNodeCompound2["buy"] as TagNodeCompound);
						}
						if (tagNodeCompound2.ContainsKey("buyB"))
						{
							this.method_24(tagNodeCompound2["buyB"] as TagNodeCompound);
						}
						if (tagNodeCompound2.ContainsKey("sell"))
						{
							this.method_24(tagNodeCompound2["sell"] as TagNodeCompound);
						}
					}
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0002FA54 File Offset: 0x0002DC54
		private void method_24(TagNodeCompound tagNodeCompound_0)
		{
			bool flag = false;
			if (tagNodeCompound_0.ContainsKey("id"))
			{
				flag = this.method_27(tagNodeCompound_0, true);
			}
			if (flag && tagNodeCompound_0.ContainsKey("tag"))
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["tag"] as TagNodeCompound;
				if (tagNodeCompound != null && tagNodeCompound.ContainsKey("BlockEntityTag"))
				{
					TagNodeCompound tagNodeCompound2 = tagNodeCompound["BlockEntityTag"] as TagNodeCompound;
					if (tagNodeCompound2 != null && tagNodeCompound2.ContainsKey("Items"))
					{
						this.method_29(tagNodeCompound2["Items"] as TagNodeList);
					}
				}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002FAE4 File Offset: 0x0002DCE4
		private void method_25(TagNodeCompound tagNodeCompound_0)
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

		// Token: 0x0600054D RID: 1357 RVA: 0x0002FBCC File Offset: 0x0002DDCC
		private void method_26(TagNodeCompound tagNodeCompound_0)
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

		// Token: 0x0600054E RID: 1358 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		private bool method_27(TagNodeCompound tagNodeCompound_0, bool bool_1 = false)
		{
			short num = -1;
			if (tagNodeCompound_0.ContainsKey("id"))
			{
				if (tagNodeCompound_0["id"] is TagNodeString)
				{
					string key = tagNodeCompound_0["id"] as TagNodeString;
					if (ConsoleItemLookups.ItemsByName.ContainsKey(key))
					{
						if (!ConsoleItemLookups.ItemsByName[key].OnConsole)
						{
							num = (short)((ConsoleItemLookups.ItemsByName[key].ReplaceId > 0) ? ConsoleItemLookups.ItemsByName[key].ReplaceId : -1);
						}
						else
						{
							num = (short)ConsoleItemLookups.ItemsByName[key].Id;
						}
					}
					else if (Class34.smethod_2().ContainsKey(key))
					{
						if (!Class34.smethod_2()[key].method_3())
						{
							num = (short)((Class34.smethod_2()[key].method_5() > 0) ? Class34.smethod_2()[key].method_5() : -1);
						}
						else
						{
							num = (short)Class34.smethod_2()[key].Id;
						}
						if (num > 0 && bool_1 && !Class34.smethod_1()[(int)num].method_6())
						{
							num = -1;
						}
					}
				}
				else if (tagNodeCompound_0["id"] is TagNodeShort)
				{
					num = (tagNodeCompound_0["id"] as TagNodeShort);
					if (ConsoleItemLookups.ItemsById.ContainsKey((int)num) || Class34.smethod_1().ContainsKey((int)num))
					{
						if (ConsoleItemLookups.ItemsById.ContainsKey((int)num))
						{
							if (!ConsoleItemLookups.ItemsById[(int)num].OnConsole)
							{
								num = (short)((ConsoleItemLookups.ItemsById[(int)num].ReplaceId > 0) ? ConsoleItemLookups.ItemsById[(int)num].ReplaceId : -1);
							}
						}
						else if (Class34.smethod_1().ContainsKey((int)num) && !Class34.smethod_1()[(int)num].method_3())
						{
							num = (short)((Class34.smethod_1()[(int)num].method_5() > 0) ? Class34.smethod_1()[(int)num].method_5() : -1);
							if (num > 0 && bool_1 && !Class34.smethod_1()[(int)num].method_6())
							{
								num = -1;
							}
						}
					}
					else
					{
						num = -1;
					}
				}
			}
			bool result = num >= 0;
			if (num < 0)
			{
				num = (bool_1 ? 388 : 0);
			}
			this.method_28(tagNodeCompound_0, num);
			if (num != 386)
			{
				if (num != 387)
				{
					return result;
				}
			}
			this.method_13(tagNodeCompound_0);
			return result;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00030080 File Offset: 0x0002E280
		private void method_28(TagNodeCompound tagNodeCompound_0, short short_0 = 0)
		{
			tagNodeCompound_0.Remove("id");
			if (this.convertFromPCParameters_0 != null && this.convertFromPCParameters_0.ConvertParameters != null && this.convertFromPCParameters_0.ConvertParameters.ItemIdString)
			{
				string d = "";
				if (ConsoleItemLookups.ItemsById.ContainsKey((int)short_0))
				{
					d = ConsoleItemLookups.ItemsById[(int)short_0].MCName;
				}
				else if (Class34.smethod_1().ContainsKey((int)short_0))
				{
					d = Class34.smethod_1()[(int)short_0].ApfHbuxQfqb();
				}
				tagNodeCompound_0.Add("id", new TagNodeString(d));
				return;
			}
			tagNodeCompound_0.Add("id", new TagNodeShort(short_0));
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00030128 File Offset: 0x0002E328
		private void method_29(TagNodeList tagNodeList_0)
		{
			if (tagNodeList_0 != null)
			{
				for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
				{
					TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
					if (tagNodeCompound.ContainsKey("id") && !this.method_27(tagNodeCompound, false))
					{
						tagNodeList_0.Remove(tagNodeCompound);
					}
				}
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0003017C File Offset: 0x0002E37C
		private void method_30(TagNodeByteArray tagNodeByteArray_0, byte byte_0)
		{
			for (int i = 0; i < tagNodeByteArray_0.Length; i++)
			{
				tagNodeByteArray_0[i] = byte_0;
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000301A4 File Offset: 0x0002E3A4
		private void method_31(string string_0)
		{
			this.int_2++;
			int int_ = (int)((float)(this.int_2 + 1) / (float)this.int_3 * 100f);
			this.method_32(string_0, int_);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00004D8B File Offset: 0x00002F8B
		private void method_32(string string_0, int int_4 = 0)
		{
			if (this.convertFromPCParameters_0 != null)
			{
				this.convertFromPCParameters_0.Count = this.int_2;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000301E0 File Offset: 0x0002E3E0
		private byte[] method_33(TagNodeCompound tagNodeCompound_0, int int_4, ConvertParameters convertParameters_0)
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
			this.method_30(tagNodeByteArray2, byte.MaxValue);
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
							if (num10 != 0)
							{
								num11 = nibbleSetters.AnvilGet(b3, j, k, l);
							}
							else
							{
								num11 = 0;
							}
							int val = nibbleSetters.AnvilGet(b4, j, k, l);
							int val2 = nibbleSetters.AnvilGet(b5, j, k, l);
							if (!Class34.smethod_1().ContainsKey(num10))
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
										goto IL_3DB;
									}
									if (num10 == convertParameters_0.BlockChanges[m].FromBlock)
									{
										goto IL_3DB;
									}
									IL_413:
									m++;
									continue;
									IL_3DB:
									if ((!convertParameters_0.BlockChanges[m].Layers.Contains(num8) && !convertParameters_0.BlockChanges[m].Layers.Contains(-1)) || (!convertParameters_0.BlockChanges[m].FromData.Contains(-1) && !convertParameters_0.BlockChanges[m].FromData.Contains(num11)))
									{
										goto IL_413;
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

		// Token: 0x06000556 RID: 1366 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_1(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x0400037B RID: 891
		private Dictionary<int, List<int>> dictionary_0 = new Dictionary<int, List<int>>();

		// Token: 0x0400037C RID: 892
		private ConvertFromPCParameters convertFromPCParameters_0;

		// Token: 0x0400037D RID: 893
		private EntityLookup entityLookup_0 = new EntityLookup();

		// Token: 0x0400037E RID: 894
		private TileEntityLookup tileEntityLookup_0 = new TileEntityLookup();

		// Token: 0x0400037F RID: 895
		private bool[] bool_0;

		// Token: 0x04000380 RID: 896
		private int int_0;

		// Token: 0x04000381 RID: 897
		private int int_1;

		// Token: 0x04000382 RID: 898
		private BlockChange blockChange_0;

		// Token: 0x04000383 RID: 899
		private int int_2;

		// Token: 0x04000384 RID: 900
		private int int_3;

		// Token: 0x04000385 RID: 901
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;

		// Token: 0x04000386 RID: 902
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_1;
	}
}
