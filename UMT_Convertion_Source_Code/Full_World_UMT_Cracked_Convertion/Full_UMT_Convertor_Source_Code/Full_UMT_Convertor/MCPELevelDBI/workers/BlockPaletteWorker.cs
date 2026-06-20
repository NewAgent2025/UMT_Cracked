using System;
using System.Collections.Generic;
using Full_UMT_Convertor.model;

namespace MCPELevelDBI.workers
{
	// Token: 0x02000132 RID: 306
	public class BlockPaletteWorker
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x00058B7C File Offset: 0x00056D7C
		public BlockTranslation GetBedrockPaletteEntryByConsole(Dictionary<int, BlockTranslation> palette, int consoleBlock, short consoleData)
		{
			BlockTranslation blockTranslation = null;
			int key = consoleBlock * 1000 + (int)consoleData;
			if (this.dictionary_1.ContainsKey(key))
			{
				blockTranslation = palette[this.dictionary_1[key]];
			}
			if (blockTranslation == null)
			{
				blockTranslation = BlockConversionWorker.smethod_3(consoleBlock, (int)consoleData).Copy();
				int num = blockTranslation.id * 1000 + blockTranslation.data;
				this.dictionary_1[key] = num;
				if (!palette.ContainsKey(num))
				{
					blockTranslation.Index = this.int_0;
					this.int_0++;
					palette[num] = blockTranslation;
				}
				else
				{
					blockTranslation = palette[num];
				}
			}
			return blockTranslation;
		}

		// Token: 0x040007FB RID: 2043
		private static Dictionary<int, SortedDictionary<int, BlockTranslation>> dictionary_0;

		// Token: 0x040007FC RID: 2044
		private Dictionary<int, int> dictionary_1 = new Dictionary<int, int>();

		// Token: 0x040007FD RID: 2045
		private int int_0;
	}
}
