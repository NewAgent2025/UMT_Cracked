using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000A7 RID: 167
	public class Constants
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x0002C39C File Offset: 0x0002A59C
		internal static void smethod_0()
		{
			IEnumerable<KeyValuePair<int, Biome>> source = Constants.biomeList;
			if (Constants.func_0 == null)
			{
				Constants.func_0 = new Func<KeyValuePair<int, Biome>, int>(Constants.smethod_1);
			}
			Func<KeyValuePair<int, Biome>, int> keySelector = Constants.func_0;
			if (Constants.func_1 == null)
			{
				Constants.func_1 = new Func<KeyValuePair<int, Biome>, Biome>(Constants.smethod_2);
			}
			Constants.biomeListPlus = source.ToDictionary(keySelector, Constants.func_1);
			Constants.biomeList.Remove(1000);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00005F07 File Offset: 0x00004107
		[CompilerGenerated]
		private static int smethod_1(KeyValuePair<int, Biome> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00005F10 File Offset: 0x00004110
		[CompilerGenerated]
		private static Biome smethod_2(KeyValuePair<int, Biome> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x04000478 RID: 1144
		public const int INDEX_RECORD_LENGTH = 144;

		// Token: 0x04000479 RID: 1145
		public const int INDEX_ENTRY_FILE_LENGTH_POSITION = 128;

		// Token: 0x0400047A RID: 1146
		public const int INDEX_ENTRY_FILE_OFFSET_POSITION = 132;

		// Token: 0x0400047B RID: 1147
		public static byte[] grfIndexEntry = new byte[]
		{
			0,
			114,
			0,
			101,
			0,
			113,
			0,
			117,
			0,
			105,
			0,
			114,
			0,
			101,
			0,
			100,
			0,
			71,
			0,
			97,
			0,
			109,
			0,
			101,
			0,
			82,
			0,
			117,
			0,
			108,
			0,
			101,
			0,
			115,
			0,
			46,
			0,
			103,
			0,
			114,
			0,
			102,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0
		};

		// Token: 0x0400047C RID: 1148
		public static byte[] entitiesSearchBytes = new byte[]
		{
			9,
			0,
			8,
			69,
			110,
			116,
			105,
			116,
			105,
			101,
			115
		};

		// Token: 0x0400047D RID: 1149
		public static byte[] TileEntitiesSearchBytes = new byte[]
		{
			9,
			0,
			12,
			84,
			105,
			108,
			101,
			69,
			110,
			116,
			105,
			116,
			105,
			101,
			115
		};

		// Token: 0x0400047E RID: 1150
		public static byte[] mapOptionsBytes = new byte[]
		{
			0,
			10,
			77,
			97,
			112,
			79,
			112,
			116,
			105,
			111,
			110,
			115
		};

		// Token: 0x0400047F RID: 1151
		public static Dictionary<int, string> ENTITY_BLOCKS = new Dictionary<int, string>
		{
			{
				23,
				"Trap"
			},
			{
				25,
				"Music"
			},
			{
				36,
				"Piston"
			},
			{
				52,
				"MobSpawner"
			},
			{
				54,
				"Chest"
			},
			{
				61,
				"Furnace"
			},
			{
				62,
				"Furnace"
			},
			{
				63,
				"Sign"
			},
			{
				68,
				"Sign"
			},
			{
				84,
				"RecordPlayer"
			},
			{
				116,
				"EnchantTable"
			},
			{
				117,
				"Cauldron"
			},
			{
				119,
				"Airportal"
			},
			{
				130,
				"EnderChest"
			},
			{
				137,
				""
			},
			{
				138,
				"Beacon"
			},
			{
				140,
				"FlowerPot"
			},
			{
				144,
				"Skull"
			},
			{
				146,
				"Chest"
			},
			{
				149,
				"Comparator"
			},
			{
				151,
				"DLDetector"
			},
			{
				154,
				"Hopper"
			},
			{
				158,
				"Dropper"
			},
			{
				176,
				"Banner"
			},
			{
				177,
				"Banner"
			},
			{
				209,
				"EndGateway"
			}
		};

		// Token: 0x04000480 RID: 1152
		public static Dictionary<int, string> entityDefaults = new Dictionary<int, string>
		{
			{
				23,
				"0a00010a0a0000030001790000003c080002696400045472617003000178000000090300017affffffcb0900054974656d730a000000000000"
			},
			{
				25,
				"0a00010a0a00000300017900000004080002696400054d7573696303000178000000020100046e6f7465000300017a000000050000"
			},
			{
				52,
				"0a00010a0a00000800026964000a4d6f62537061776e657202000544656c6179001403000179000000000200114d61784e6561726279456e74697469657300060300017a0000000002000d4d6178537061776e44656c61790320030001780000000009000f537061776e506f74656e7469616c730a000000010a0006456e74697479080002696400065a6f6d62696500030006576569676874000000010002000a537061776e436f756e74000402000d4d696e537061776e44656c617900c802000a537061776e52616e676500040200135265717569726564506c6179657252616e676500100a0009537061776e44617461080002696400065a6f6d626965000000"
			},
			{
				54,
				"0a00010a0a0000010005626f6e757300030001790000000008000269640005436865737403000178000000000300017a000000000900054974656d730a000000000000"
			},
			{
				61,
				"0a00010a0a0000020008436f6f6b54696d650000030001790000000b080002696400074675726e616365030001780000000f0200084275726e54696d6500000300017affffff5401000c43686172636f616c55736564000900054974656d730a000000000000"
			},
			{
				62,
				"0a00010a0a0000020008436f6f6b54696d6500320300017900000004080002696400074675726e61636503000178000000080200084275726e54696d6500320300017a0000000201000c43686172636f616c55736564000900054974656d730a00000003010004536c6f74000200026964000002000644616d6167650000010005436f756e740000010004536c6f74010200026964000002000644616d6167650000010005436f756e740000010004536c6f74020200026964010702000644616d6167650000010005436f756e7440000000"
			},
			{
				63,
				"0a00010a0a000003000178ffffff54080005546578743400000300017900000004080005546578743300000300017a000000b708000554657874320000080002696400045369676e080005546578743100000000"
			},
			{
				68,
				"0a00010a0a000003000178ffffff54080005546578743400000300017900000005080005546578743300000300017a000000b808000554657874320000080002696400045369676e080005546578743100000000"
			},
			{
				84,
				"0a00010a0a0000030001790000005d0800026964000c5265636f7264506c6179657203000178000000660300017affffffae0000"
			},
			{
				116,
				"0a00010a0a000003000179000000440800026964000c456e6368616e745461626c6503000178000000090300017affffffff0000"
			},
			{
				117,
				"0a00010a0a00000200084272657754696d6500000300017900000044080002696400084361756c64726f6e03000178000000050300017afffffff60900054974656d730a00000003010004536c6f74000200026964000002000644616d6167650000010005436f756e740000010004536c6f74010200026964000002000644616d6167650000010005436f756e740000010004536c6f74020200026964000002000644616d6167650000010005436f756e7400000000"
			},
			{
				118,
				"0a00010a0a00000200084272657754696d6500000300017900000044080002696400084361756c64726f6e03000178000000050300017afffffff60900054974656d730a00000003010004536c6f74000200026964000002000644616d6167650000010005436f756e740000010004536c6f74010200026964000002000644616d6167650000010005436f756e740000010004536c6f74020200026964000002000644616d6167650000010005436f756e7400000000"
			},
			{
				119,
				"0a00010a0a0000030001790000000008000269640009416972706f7274616c03000178000000000300017a000000000000"
			},
			{
				130,
				"0a00010a0a000003000179000000440800026964000a456e646572436865737403000178000000020300017affffffd30000"
			},
			{
				138,
				"0a00010a0a0000030001790000004708000269640006426561636f6e03000178000000e80300075072696d617279000000000300017affffff940300095365636f6e64617279000000000300064c6576656c73000000000000"
			},
			{
				140,
				"0a00010a0a0000030001790000000008000269640009466c6f776572506f74030001780000000003000444617461000000000300017a000000000300044974656d000000000000"
			},
			{
				144,
				"0a00010a0a0000030001790000005308000269640005536b756c6c030001780000006a0300017affffffa5010009536b756c6c5479706500010003526f740008000945787472615479706500000000"
			},
			{
				146,
				"0a00010a0a0000010005626f6e757300030001790000000008000269640005436865737403000178000000000300017a000000000900054974656d730a000000000000"
			},
			{
				151,
				"0a00010a0a000003000179000000040800026964000a444c4465746563746f7203000178000000060300017a000000060000"
			},
			{
				154,
				"0a00010a0a0000030001790000003e08000269640006486f7070657203000178000000230300017affffff940900054974656d7301000000000300105472616e73666572436f6f6c646f776e000000000000"
			},
			{
				158,
				"0a00010a0a000003000179000000040800026964000744726f7070657203000178000000060300017a000000080900054974656d7301000000000000"
			},
			{
				176,
				"0a00010a0a000003000442617365000000000300017a00000000030001790000000003000178000000000800026964000642616e6e65720000"
			},
			{
				177,
				"0a00010a0a000003000442617365000000000300017a00000000030001790000000003000178000000000800026964000642616e6e65720000"
			},
			{
				209,
				"0a00010a0a00000a000a45786974506f7274616c0300015a0000000003000159000000000300015800000000000300017a000000000300017900000000030001780000000004000341676500000000000000000800026964000a456e644761746577617901000d457861637454656c65706f7274010000"
			}
		};

		// Token: 0x04000481 RID: 1153
		public static string mapItemFrame = "0a00010a0a0000080002696400094974656d4672616d65090003506f7306000000030000000000000000000000000000000000000000000000000100084f6e47726f756e64000900064d6f74696f6e060000000300000000000000000000000000000000000000000000000003000944696d656e73696f6e00000000020003416972012c010006466163696e6700090008526f746174696f6e0500000002000000000000000005000c46616c6c44697374616e63650000000002000446697265000001000c496e76756c6e657261626c650003000e506f7274616c436f6f6c646f776e000000000800045555494400000a00044974656d080002696400146d696e6563726166743a66696c6c65645f6d617002000644616d6167650000010005436f756e74010001000c4974656d526f746174696f6e0405000e4974656d44726f704368616e63653f80000003000554696c65580000000003000554696c65590000000003000554696c655a000000000000";

		// Token: 0x04000482 RID: 1154
		public static Dictionary<string, int> regionSizes = new Dictionary<string, int>
		{
			{
				"region",
				729
			},
			{
				"DIM-1",
				81
			},
			{
				"DIM1",
				1024
			}
		};

		// Token: 0x04000483 RID: 1155
		public static Dictionary<string, int> regionSizesExt = new Dictionary<string, int>
		{
			{
				"region",
				1024
			},
			{
				"DIM-1",
				121
			},
			{
				"DIM1",
				1024
			}
		};

		// Token: 0x04000484 RID: 1156
		public static string[] regionFolderNames = new string[]
		{
			"region",
			"DIM-1",
			"DIM1"
		};

		// Token: 0x04000485 RID: 1157
		public static string[] regionFileNames = new string[]
		{
			"r.0.0",
			"r.0.-1",
			"r.-1.0",
			"r.-1.-1"
		};

		// Token: 0x04000486 RID: 1158
		public static Dictionary<string, string> dimensionNames = new Dictionary<string, string>
		{
			{
				"region",
				"Overworld"
			},
			{
				"DIM-1",
				"Nether"
			},
			{
				"DIM1",
				"The End"
			}
		};

		// Token: 0x04000487 RID: 1159
		public static Dictionary<int, string> dimensionById = new Dictionary<int, string>
		{
			{
				0,
				"region"
			},
			{
				-1,
				"DIM-1"
			},
			{
				1,
				"DIM1"
			}
		};

		// Token: 0x04000488 RID: 1160
		public static Dictionary<int, Biome> biomeListPlus = null;

		// Token: 0x04000489 RID: 1161
		public static Dictionary<int, Biome> biomeList = new Dictionary<int, Biome>
		{
			{
				1000,
				new Biome(1000, "All Biomes", true)
			},
			{
				0,
				new Biome(0, "Ocean", true)
			},
			{
				1,
				new Biome(1, "Plains", true)
			},
			{
				2,
				new Biome(2, "Desert", true)
			},
			{
				3,
				new Biome(3, "Extreme Hills", true)
			},
			{
				4,
				new Biome(4, "Forest", true)
			},
			{
				5,
				new Biome(5, "Taiga", true)
			},
			{
				6,
				new Biome(6, "Swampland", true)
			},
			{
				7,
				new Biome(7, "River", true)
			},
			{
				8,
				new Biome(8, "Hell", true)
			},
			{
				9,
				new Biome(9, "The End", true)
			},
			{
				10,
				new Biome(10, "FrozenOcean", true)
			},
			{
				11,
				new Biome(11, "FrozenRiver", true)
			},
			{
				12,
				new Biome(12, "Ice Plains", true)
			},
			{
				13,
				new Biome(13, "Ice Mountains", true)
			},
			{
				14,
				new Biome(14, "MushroomIsland", true)
			},
			{
				15,
				new Biome(15, "MushroomIslandShore", true)
			},
			{
				16,
				new Biome(16, "Beach", true)
			},
			{
				17,
				new Biome(17, "DesertHills", true)
			},
			{
				18,
				new Biome(18, "ForestHills", true)
			},
			{
				19,
				new Biome(19, "TaigaHills", true)
			},
			{
				20,
				new Biome(20, "Extreme Hills Edge", true)
			},
			{
				21,
				new Biome(21, "Jungle", true)
			},
			{
				22,
				new Biome(22, "JungleHills", true)
			},
			{
				23,
				new Biome(23, "JungleEdge", true)
			},
			{
				24,
				new Biome(24, "Deep Ocean", true)
			},
			{
				25,
				new Biome(25, "Stone Beach", true)
			},
			{
				26,
				new Biome(26, "Cold Beach", true)
			},
			{
				27,
				new Biome(27, "Birch Forest", true)
			},
			{
				28,
				new Biome(28, "Birch Forest Hills", true)
			},
			{
				29,
				new Biome(29, "Roofed Forest", true)
			},
			{
				30,
				new Biome(30, "Cold Taiga", true)
			},
			{
				31,
				new Biome(31, "Cold Taiga Hills", true)
			},
			{
				32,
				new Biome(32, "Mega Taiga", true)
			},
			{
				33,
				new Biome(33, "Mega Taiga Hills", true)
			},
			{
				34,
				new Biome(34, "Extreme Hills+", true)
			},
			{
				35,
				new Biome(35, "Savanna", true)
			},
			{
				36,
				new Biome(36, "Savanna Plateau", true)
			},
			{
				37,
				new Biome(37, "Mesa", true)
			},
			{
				38,
				new Biome(38, "Mesa Plateau F", true)
			},
			{
				39,
				new Biome(39, "Mesa Plateau", true)
			},
			{
				129,
				new Biome(129, "Sunflower Plains", true)
			},
			{
				130,
				new Biome(130, "Desert M", true)
			},
			{
				131,
				new Biome(131, "Extreme Hills M", true)
			},
			{
				132,
				new Biome(132, "Flower Forest", true)
			},
			{
				133,
				new Biome(133, "Taiga M", true)
			},
			{
				134,
				new Biome(134, "Swampland M", true)
			},
			{
				140,
				new Biome(140, "Ice Plains Spikes", true)
			},
			{
				149,
				new Biome(149, "Jungle M", true)
			},
			{
				151,
				new Biome(151, "JungleEdge M", true)
			},
			{
				155,
				new Biome(155, "Birch Forest M", true)
			},
			{
				156,
				new Biome(156, "Birch Forest Hills M", true)
			},
			{
				157,
				new Biome(157, "Roofed Forest M", true)
			},
			{
				158,
				new Biome(158, "Cold Taiga M", true)
			},
			{
				160,
				new Biome(160, "Mega Spruce Taiga", true)
			},
			{
				161,
				new Biome(161, "Redwood Taiga Hills M", true)
			},
			{
				162,
				new Biome(162, "Extreme Hills+ M", true)
			},
			{
				163,
				new Biome(163, "Savanna M", true)
			},
			{
				164,
				new Biome(164, "Savanna Plateau M", true)
			},
			{
				165,
				new Biome(165, "Mesa (Bryce)", true)
			},
			{
				166,
				new Biome(166, "Mesa Plateau F M", true)
			},
			{
				167,
				new Biome(167, "Mesa Plateau M", true)
			}
		};

		// Token: 0x0400048A RID: 1162
		internal static Dictionary<int, string> dictionary_0 = new Dictionary<int, string>
		{
			{
				-1,
				"From Blocklight"
			},
			{
				0,
				"Blocklight 0"
			},
			{
				1,
				"Blocklight 1"
			},
			{
				2,
				"Blocklight 2"
			},
			{
				3,
				"Blocklight 3"
			},
			{
				4,
				"Blocklight 4"
			},
			{
				5,
				"Blocklight 5"
			},
			{
				6,
				"Blocklight 6"
			},
			{
				7,
				"Blocklight 7"
			},
			{
				8,
				"Blocklight 8"
			},
			{
				9,
				"Blocklight 9"
			},
			{
				10,
				"Blocklight 10"
			},
			{
				11,
				"Blocklight 11"
			},
			{
				12,
				"Blocklight 12"
			},
			{
				13,
				"Blocklight 13"
			},
			{
				14,
				"Blocklight 14"
			},
			{
				15,
				"Blocklight 15"
			}
		};

		// Token: 0x0400048B RID: 1163
		internal static Dictionary<string, Constants.RegionModifier> dictionary_1 = new Dictionary<string, Constants.RegionModifier>
		{
			{
				"r.0.0",
				new Constants.RegionModifier
				{
					X = 0,
					Z = 0
				}
			},
			{
				"r.0.-1",
				new Constants.RegionModifier
				{
					X = 0,
					Z = -1
				}
			},
			{
				"r.-1.0",
				new Constants.RegionModifier
				{
					X = -1,
					Z = 0
				}
			},
			{
				"r.-1.-1",
				new Constants.RegionModifier
				{
					X = -1,
					Z = -1
				}
			}
		};

		// Token: 0x0400048C RID: 1164
		public static Dictionary<string, string> MC_TEXT_CODES = new Dictionary<string, string>
		{
			{
				"u00A7",
				"§"
			},
			{
				"u0027",
				"'"
			}
		};

		// Token: 0x0400048D RID: 1165
		public static Dictionary<string, string> conditionValues = new Dictionary<string, string>
		{
			{
				"EQUAL",
				"Equal"
			},
			{
				"NOT_EQUAL",
				"Not Equal"
			},
			{
				"GREATER_THAN",
				"Greater Than"
			},
			{
				"LESS_THAN",
				"Less Than"
			},
			{
				"EXIST",
				"Exist"
			},
			{
				"NOT_EXIST",
				"Not Exist"
			}
		};

		// Token: 0x0400048E RID: 1166
		public static Dictionary<string, string> replaceNodeTypeValues = new Dictionary<string, string>
		{
			{
				"TAG_BYTE",
				"Byte"
			},
			{
				"TAG_SHORT",
				"Short"
			},
			{
				"TAG_INT",
				"Int"
			},
			{
				"TAG_LONG",
				"Long"
			},
			{
				"TAG_FLOAT",
				"Float"
			},
			{
				"TAG_DOUBLE",
				"Double"
			},
			{
				"TAG_BYTE_ARRAY",
				"Byte Array"
			},
			{
				"TAG_STRING",
				"String"
			},
			{
				"TAG_COMPOUND",
				"Compound"
			},
			{
				"TAG_INT_ARRAY",
				"Int Array"
			},
			{
				"NBT_STRING",
				"NBT"
			}
		};

		// Token: 0x0400048F RID: 1167
		public static Dictionary<string, string> variableDataTypes = new Dictionary<string, string>
		{
			{
				"TAG_BYTE",
				"Byte"
			},
			{
				"TAG_SHORT",
				"Short"
			},
			{
				"TAG_INT",
				"Int"
			},
			{
				"TAG_LONG",
				"Long"
			},
			{
				"TAG_FLOAT",
				"Float"
			},
			{
				"TAG_DOUBLE",
				"Double"
			},
			{
				"TAG_STRING",
				"String"
			},
			{
				"TAG_BYTE_ARRAY",
				"Byte Array"
			},
			{
				"TAG_INT_ARRAY",
				"Int Array"
			},
			{
				"TAG_LIST",
				"List"
			},
			{
				"TAG_COMPOUND",
				"Compound"
			},
			{
				"NBT_STRING",
				"NBT"
			}
		};

		// Token: 0x04000490 RID: 1168
		public static Dictionary<string, string> variableListTypes = new Dictionary<string, string>
		{
			{
				"TAG_BYTE",
				"Byte"
			},
			{
				"TAG_SHORT",
				"Short"
			},
			{
				"TAG_INT",
				"Int"
			},
			{
				"TAG_LONG",
				"Long"
			},
			{
				"TAG_FLOAT",
				"Float"
			},
			{
				"TAG_DOUBLE",
				"Double"
			},
			{
				"TAG_STRING",
				"String"
			}
		};

		// Token: 0x04000491 RID: 1169
		[CompilerGenerated]
		private static Func<KeyValuePair<int, Biome>, int> func_0;

		// Token: 0x04000492 RID: 1170
		[CompilerGenerated]
		private static Func<KeyValuePair<int, Biome>, Biome> func_1;

		// Token: 0x020000A8 RID: 168
		public class RegionModifier
		{
			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600070A RID: 1802 RVA: 0x00005F19 File Offset: 0x00004119
			// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005F21 File Offset: 0x00004121
			public int X
			{
				get
				{
					return this.int_0;
				}
				set
				{
					this.int_0 = value;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x0600070C RID: 1804 RVA: 0x00005F2A File Offset: 0x0000412A
			// (set) Token: 0x0600070D RID: 1805 RVA: 0x00005F32 File Offset: 0x00004132
			public int Z
			{
				get
				{
					return this.int_1;
				}
				set
				{
					this.int_1 = value;
				}
			}

			// Token: 0x04000493 RID: 1171
			private int int_0;

			// Token: 0x04000494 RID: 1172
			private int int_1;
		}
	}
}
