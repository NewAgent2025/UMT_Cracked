using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200014F RID: 335
	public class BlockConversionWorker
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00009123 File Offset: 0x00007323
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x0000912A File Offset: 0x0000732A
		public static Dictionary<int, SortedDictionary<int, BlockTranslation>> ConvertBlocks
		{
			get
			{
				return BlockConversionWorker.dictionary_0;
			}
			set
			{
				BlockConversionWorker.dictionary_0 = value;
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0005E040 File Offset: 0x0005C240
		public static void BuildBlockConversionTable(PlatformType convertTO)
		{
			BlockConversionWorker.dictionary_0[0] = new SortedDictionary<int, BlockTranslation>();
			BlockConversionWorker.dictionary_0[0].Add(0, new BlockTranslation(0, 0, BlockMaster.MasterBlocksByHash[BlockMaster.airHash]));
			List<MasterBlock> blocks = BlockMaster.Blocks;
			for (int i = 0; i < BlockMaster.Blocks.Count; i++)
			{
				MasterBlock masterBlock = blocks[i];
				MasterBlockItem masterBlockItem;
				MasterBlockItem console;
				if (convertTO == PlatformType.PC)
				{
					masterBlockItem = masterBlock.java;
					console = masterBlock.console;
				}
				else
				{
					masterBlockItem = masterBlock.bedrock;
					console = masterBlock.console;
				}
				if (console.id != null && console.id.Value > 0)
				{
					int value = console.id.Value;
					int key = (console.data != null) ? console.data.Value : 0;
					int num = 0;
					int data = 0;
					if (masterBlockItem.id != null)
					{
						num = masterBlockItem.id.Value;
					}
					if (masterBlockItem.data != null)
					{
						data = masterBlockItem.data.Value;
					}
					if (!BlockConversionWorker.dictionary_0.ContainsKey(value))
					{
						BlockConversionWorker.dictionary_0[value] = new SortedDictionary<int, BlockTranslation>();
					}
					BlockConversionWorker.dictionary_0[value][key] = new BlockTranslation(num, data, masterBlock);
					if (BlockMaster.BlockStatesActive(masterBlock))
					{
						if (convertTO == PlatformType.PC)
						{
							BlockConversionWorker.smethod_2(BlockConversionWorker.dictionary_0[value], num, masterBlock);
						}
						else
						{
							BlockConversionWorker.smethod_1(BlockConversionWorker.dictionary_0[value], num, masterBlock);
						}
					}
				}
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00009132 File Offset: 0x00007332
		private static bool smethod_0(string string_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0005E1EC File Offset: 0x0005C3EC
		private static void smethod_1(SortedDictionary<int, BlockTranslation> sortedDictionary_0, int int_0, MasterBlock masterBlock_0)
		{
			for (int i = 0; i < 16; i++)
			{
				if (!sortedDictionary_0.ContainsKey(i))
				{
					int num = BlockMaster.CovertJavaDataToBedrock(masterBlock_0, i);
					if (num >= 0 && !sortedDictionary_0.ContainsKey(i))
					{
						sortedDictionary_0[i] = new BlockTranslation(int_0, num, masterBlock_0);
					}
				}
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0005E238 File Offset: 0x0005C438
		private static void smethod_2(SortedDictionary<int, BlockTranslation> sortedDictionary_0, int int_0, MasterBlock masterBlock_0)
		{
			for (int i = 0; i < 16; i++)
			{
				if (!sortedDictionary_0.ContainsKey(i))
				{
					int num = BlockMaster.CovertBedrockDataToJava(masterBlock_0, i);
					if (num >= 0 && !sortedDictionary_0.ContainsKey(i))
					{
						sortedDictionary_0[i] = new BlockTranslation(int_0, num, masterBlock_0);
					}
				}
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0005E284 File Offset: 0x0005C484
		internal static BlockTranslation smethod_3(int int_0, int int_1)
		{
			if (!BlockConversionWorker.dictionary_0.ContainsKey(int_0))
			{
				return BlockConversionWorker.dictionary_0[0][0];
			}
			if (BlockConversionWorker.dictionary_0[int_0].ContainsKey(int_1))
			{
				return BlockConversionWorker.dictionary_0[int_0][int_1];
			}
			if (BlockConversionWorker.dictionary_0[int_0].Count > 0)
			{
				SortedDictionary<int, BlockTranslation> sortedDictionary = BlockConversionWorker.dictionary_0[int_0];
				return sortedDictionary[sortedDictionary.First<KeyValuePair<int, BlockTranslation>>().Key];
			}
			return BlockConversionWorker.dictionary_0[0][0];
		}

		// Token: 0x04000846 RID: 2118
		private static Dictionary<int, SortedDictionary<int, BlockTranslation>> dictionary_0 = new Dictionary<int, SortedDictionary<int, BlockTranslation>>();
	}
}
