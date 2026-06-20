using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Full_UMT_Convertor.workers;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000037 RID: 55
	public class BlockMaster
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000328D File Offset: 0x0000148D
		public static int NewBlockId
		{
			get
			{
				return BlockMaster.int_0++;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000329C File Offset: 0x0000149C
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000032A3 File Offset: 0x000014A3
		public static Dictionary<int, MasterBlock> MasterBlocksByHash
		{
			get
			{
				return BlockMaster.dictionary_7;
			}
			set
			{
				BlockMaster.dictionary_7 = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000032AB File Offset: 0x000014AB
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000032B2 File Offset: 0x000014B2
		public static Dictionary<string, MasterBlock> MasterBlocksByName
		{
			get
			{
				return BlockMaster.dictionary_0;
			}
			set
			{
				BlockMaster.dictionary_0 = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000032BA File Offset: 0x000014BA
		public static List<MasterBlock> Blocks
		{
			get
			{
				return BlockMaster.dictionary_0.Values.ToList<MasterBlock>();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000032CB File Offset: 0x000014CB
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000032D2 File Offset: 0x000014D2
		public static Dictionary<string, BlockStateGroup> DataStates
		{
			get
			{
				return BlockMaster.dictionary_1;
			}
			set
			{
				BlockMaster.dictionary_1 = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000032DA File Offset: 0x000014DA
		public static Dictionary<int, MasterBlock> PCBlocksById
		{
			get
			{
				return BlockMaster.dictionary_2;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000032E1 File Offset: 0x000014E1
		public static Dictionary<string, MasterBlock> PCBlocksByName
		{
			get
			{
				return BlockMaster.dictionary_3;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000032E8 File Offset: 0x000014E8
		public static Dictionary<int, MasterBlock> PEBlocksById
		{
			get
			{
				return BlockMaster.dictionary_5;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000032EF File Offset: 0x000014EF
		public static Dictionary<string, MasterBlock> PEBlocksByName
		{
			get
			{
				return BlockMaster.dictionary_6;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000032F6 File Offset: 0x000014F6
		public static Dictionary<int, Dictionary<short, BlockState>> BlockStatesById
		{
			get
			{
				return BlockMaster.dictionary_10;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000032FD File Offset: 0x000014FD
		public static Dictionary<string, Dictionary<short, BlockState>> BlockStatesByName
		{
			get
			{
				return BlockMaster.dictionary_9;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00011FF0 File Offset: 0x000101F0
		public static void InitBlockManager()
		{
			BlockMaster.airHash = "minecraft:air".GetHashCode();
			string path = AppDomain.CurrentDomain.BaseDirectory + "support\\";
			string path2 = Path.Combine(path, "blocks.json");
			string json = File.ReadAllText(path2);
			BlockMaster.dictionary_0 = JsonDataConversion.Deserialize<Dictionary<string, MasterBlock>>(json);
			string path3 = Path.Combine(path, "blockStates.json");
			string json2 = File.ReadAllText(path3);
			BlockMaster.dictionary_1 = JsonDataConversion.Deserialize<Dictionary<string, BlockStateGroup>>(json2);
			BlockMaster.dictionary_7 = new Dictionary<int, MasterBlock>();
			BlockMaster.dictionary_2 = new Dictionary<int, MasterBlock>();
			BlockMaster.dictionary_3 = new Dictionary<string, MasterBlock>();
			BlockMaster.dictionary_4 = new Dictionary<string, MasterBlock>();
			BlockMaster.dictionary_5 = new Dictionary<int, MasterBlock>();
			BlockMaster.dictionary_6 = new Dictionary<string, MasterBlock>();
			BlockMaster.dictionary_8 = new Dictionary<int, SortedDictionary<short, MasterBlock>>();
			foreach (string text in BlockMaster.dictionary_0.Keys)
			{
				MasterBlock masterBlock = BlockMaster.dictionary_0[text];
				if (masterBlock.java.id != null && !BlockMaster.dictionary_2.ContainsKey(masterBlock.java.id.Value))
				{
					BlockMaster.dictionary_2.Add(masterBlock.java.id.Value, masterBlock);
				}
				if (!string.IsNullOrWhiteSpace(masterBlock.java.name) && !BlockMaster.dictionary_3.ContainsKey(masterBlock.java.name))
				{
					BlockMaster.dictionary_3.Add(masterBlock.java.name, masterBlock);
				}
				if (!string.IsNullOrWhiteSpace(masterBlock.java.nameOld) && !BlockMaster.dictionary_4.ContainsKey(masterBlock.java.nameOld))
				{
					BlockMaster.dictionary_4.Add(masterBlock.java.nameOld, masterBlock);
				}
				if (masterBlock.bedrock.id != null && !BlockMaster.dictionary_5.ContainsKey(masterBlock.bedrock.id.Value))
				{
					BlockMaster.dictionary_5.Add(masterBlock.bedrock.id.Value, masterBlock);
				}
				if (!string.IsNullOrWhiteSpace(masterBlock.bedrock.name) && !BlockMaster.dictionary_6.ContainsKey(masterBlock.bedrock.name))
				{
					BlockMaster.dictionary_6.Add(masterBlock.bedrock.name, masterBlock);
				}
				if (masterBlock.console.id != null && masterBlock.console.id.Value > 0)
				{
					if (!BlockMaster.dictionary_8.ContainsKey(masterBlock.console.id.Value))
					{
						BlockMaster.dictionary_8[masterBlock.console.id.Value] = new SortedDictionary<short, MasterBlock>();
					}
					short key = (short)((masterBlock.console.data != null) ? masterBlock.console.data.Value : 0);
					if (!BlockMaster.dictionary_8[masterBlock.console.id.Value].ContainsKey(key))
					{
						BlockMaster.dictionary_8[masterBlock.console.id.Value][key] = masterBlock;
					}
				}
				int hashCode = text.GetHashCode();
				if (!BlockMaster.dictionary_7.ContainsKey(hashCode))
				{
					BlockMaster.dictionary_7.Add(hashCode, masterBlock);
				}
			}
			BlockMaster.dictionary_8[0] = new SortedDictionary<short, MasterBlock>();
			BlockMaster.dictionary_8[0][0] = BlockMaster.dictionary_7[BlockMaster.airHash];
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000123D4 File Offset: 0x000105D4
		private static void smethod_0()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			BlockMaster.dictionary_9 = new Dictionary<string, Dictionary<short, BlockState>>();
			BlockMaster.dictionary_10 = new Dictionary<int, Dictionary<short, BlockState>>();
			BlockMaster.list_2 = new List<BlockState>();
			BlockMaster.list_2.Add(new BlockState
			{
				name = "minecraft:air",
				id = new int?(0),
				data = 0
			});
			foreach (MasterBlock masterBlock in BlockMaster.dictionary_0.Values)
			{
				if (!string.IsNullOrWhiteSpace(masterBlock.bedrock.name))
				{
					BlockState blockState = new BlockState
					{
						name = masterBlock.bedrock.name,
						id = masterBlock.bedrock.id,
						data = (short)((masterBlock.bedrock.data != null) ? masterBlock.bedrock.data.Value : 0)
					};
					if (blockState.id == null)
					{
						if (!dictionary.ContainsKey(blockState.name))
						{
							dictionary[blockState.name] = BlockMaster.NewBlockId;
						}
						blockState.id = new int?(dictionary[blockState.name]);
					}
					int value = blockState.id.Value;
					if (!BlockMaster.dictionary_9.ContainsKey(blockState.name))
					{
						BlockMaster.dictionary_9.Add(blockState.name, new Dictionary<short, BlockState>());
					}
					if (!BlockMaster.dictionary_9[blockState.name].ContainsKey(blockState.data))
					{
						BlockMaster.dictionary_9[blockState.name].Add(blockState.data, blockState);
					}
					if (!BlockMaster.dictionary_10.ContainsKey(value))
					{
						BlockMaster.dictionary_10.Add(value, new Dictionary<short, BlockState>());
					}
					if (!BlockMaster.dictionary_10[value].ContainsKey(blockState.data))
					{
						BlockMaster.dictionary_10[value].Add(blockState.data, blockState);
					}
					if (!string.IsNullOrWhiteSpace(masterBlock.blockStates))
					{
						for (int i = 0; i < 16; i++)
						{
							int num = BlockMaster.IsBedrockData(masterBlock, i);
							if (num >= 0)
							{
								blockState = new BlockState
								{
									name = masterBlock.bedrock.name,
									id = masterBlock.bedrock.id,
									data = (short)num
								};
								if (!BlockMaster.dictionary_9[blockState.name].ContainsKey((short)num))
								{
									BlockMaster.dictionary_9[blockState.name].Add((short)num, blockState);
								}
								if (!BlockMaster.dictionary_10[value].ContainsKey((short)num))
								{
									BlockMaster.dictionary_10[value].Add((short)num, blockState);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000126EC File Offset: 0x000108EC
		public static MasterBlock GetMasterBlockByConsole(int id, short val)
		{
			if (BlockMaster.dictionary_8.ContainsKey(id))
			{
				if (BlockMaster.dictionary_8[id].ContainsKey(val))
				{
					return BlockMaster.dictionary_8[id][val];
				}
				if (BlockMaster.dictionary_8[id].Count > 0)
				{
					return BlockMaster.dictionary_8[id].Values.First<MasterBlock>();
				}
			}
			Telemetry.AddConsoleMissingBlock(id);
			return BlockMaster.dictionary_7[BlockMaster.airHash];
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001276C File Offset: 0x0001096C
		public static BlockState GetBedrockBlockState(string name, short val)
		{
			if (!name.StartsWith("minecraft:"))
			{
				name = "minecraft:" + name;
			}
			if (BlockMaster.dictionary_9.ContainsKey(name))
			{
				if (BlockMaster.dictionary_9[name].ContainsKey(val))
				{
					return BlockMaster.dictionary_9[name][val];
				}
				if (BlockMaster.dictionary_9[name].ContainsKey(0))
				{
					return BlockMaster.dictionary_9[name][0];
				}
			}
			return BlockMaster.list_2[0];
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000127F8 File Offset: 0x000109F8
		public static BlockState GetBedrockBlockState(int id, short val)
		{
			if (BlockMaster.dictionary_10.ContainsKey(id))
			{
				if (BlockMaster.dictionary_10[id].ContainsKey(val))
				{
					return BlockMaster.dictionary_10[id][val];
				}
				if (BlockMaster.dictionary_10[id].ContainsKey(0))
				{
					return BlockMaster.dictionary_10[id][0];
				}
			}
			return BlockMaster.list_2[0];
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00012868 File Offset: 0x00010A68
		public static int IsBedrockData(MasterBlock mb, int data)
		{
			int num = -1;
			if (BlockMaster.dictionary_1.ContainsKey(mb.blockStates))
			{
				List<BlockStateDefinition> blockStates = BlockMaster.dictionary_1[mb.blockStates].blockStates;
				foreach (BlockStateDefinition blockStateDefinition in blockStates)
				{
					if (blockStateDefinition.bedrockMask > 0)
					{
						int num2 = data & blockStateDefinition.bedrockMask;
						for (int i = 0; i < blockStateDefinition.states.Length; i++)
						{
							if (num2 == blockStateDefinition.states[i].bedrock)
							{
								num = ((num >= 0) ? (num | num2) : num2);
								break;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00012928 File Offset: 0x00010B28
		public static bool BlockStatesActive(MasterBlock mb)
		{
			if (!string.IsNullOrWhiteSpace(mb.blockStates) && BlockMaster.dictionary_1.ContainsKey(mb.blockStates))
			{
				List<BlockStateDefinition> blockStates = BlockMaster.dictionary_1[mb.blockStates].blockStates;
				using (List<BlockStateDefinition>.Enumerator enumerator = blockStates.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						BlockStateDefinition blockStateDefinition = enumerator.Current;
						if (blockStateDefinition.bedrockMask > 0 || blockStateDefinition.javaMask > 0)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000129BC File Offset: 0x00010BBC
		public static int CovertBedrockDataToJava(MasterBlock mb, int data)
		{
			int num = -1;
			if (BlockMaster.dictionary_1.ContainsKey(mb.blockStates))
			{
				List<BlockStateDefinition> blockStates = BlockMaster.dictionary_1[mb.blockStates].blockStates;
				foreach (BlockStateDefinition blockStateDefinition in blockStates)
				{
					if (blockStateDefinition.bedrockMask > 0)
					{
						int num2 = data & blockStateDefinition.bedrockMask;
						for (int i = 0; i < blockStateDefinition.states.Length; i++)
						{
							if (num2 == blockStateDefinition.states[i].bedrock)
							{
								num = ((num >= 0) ? (num | blockStateDefinition.states[i].java) : blockStateDefinition.states[i].java);
								break;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00012A98 File Offset: 0x00010C98
		public static int CovertJavaDataToBedrock(MasterBlock mb, int data)
		{
			int num = -1;
			if (BlockMaster.dictionary_1.ContainsKey(mb.blockStates))
			{
				List<BlockStateDefinition> blockStates = BlockMaster.dictionary_1[mb.blockStates].blockStates;
				foreach (BlockStateDefinition blockStateDefinition in blockStates)
				{
					if (blockStateDefinition.javaMask > 0)
					{
						int num2 = data & blockStateDefinition.javaMask;
						for (int i = 0; i < blockStateDefinition.states.Length; i++)
						{
							if (num2 == blockStateDefinition.states[i].java)
							{
								num = ((num >= 0) ? (num | blockStateDefinition.states[i].bedrock) : blockStateDefinition.states[i].bedrock);
								break;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x04000128 RID: 296
		public static string AIR = "minecraft:air";

		// Token: 0x04000129 RID: 297
		public static string WATER = "minecraft:water";

		// Token: 0x0400012A RID: 298
		public static int airHash = 0;

		// Token: 0x0400012B RID: 299
		private static Dictionary<string, MasterBlock> dictionary_0 = new Dictionary<string, MasterBlock>();

		// Token: 0x0400012C RID: 300
		private static Dictionary<string, BlockStateGroup> dictionary_1 = new Dictionary<string, BlockStateGroup>();

		// Token: 0x0400012D RID: 301
		private static List<MasterBlock> list_0 = null;

		// Token: 0x0400012E RID: 302
		private static Dictionary<int, MasterBlock> dictionary_2 = null;

		// Token: 0x0400012F RID: 303
		private static Dictionary<string, MasterBlock> dictionary_3 = null;

		// Token: 0x04000130 RID: 304
		private static Dictionary<string, MasterBlock> dictionary_4 = null;

		// Token: 0x04000131 RID: 305
		private static List<MasterBlock> list_1 = null;

		// Token: 0x04000132 RID: 306
		private static Dictionary<int, MasterBlock> dictionary_5 = null;

		// Token: 0x04000133 RID: 307
		private static Dictionary<string, MasterBlock> dictionary_6 = null;

		// Token: 0x04000134 RID: 308
		private static Dictionary<int, MasterBlock> dictionary_7 = null;

		// Token: 0x04000135 RID: 309
		private static Dictionary<int, SortedDictionary<short, MasterBlock>> dictionary_8 = null;

		// Token: 0x04000136 RID: 310
		private static List<BlockState> list_2 = null;

		// Token: 0x04000137 RID: 311
		private static Dictionary<string, Dictionary<short, BlockState>> dictionary_9 = null;

		// Token: 0x04000138 RID: 312
		private static Dictionary<int, Dictionary<short, BlockState>> dictionary_10 = null;

		// Token: 0x04000139 RID: 313
		private static int int_0 = 256;
	}
}
