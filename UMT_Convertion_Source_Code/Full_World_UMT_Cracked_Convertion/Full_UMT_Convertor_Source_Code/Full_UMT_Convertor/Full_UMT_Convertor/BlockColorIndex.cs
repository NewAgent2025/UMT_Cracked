using System;
using System.Collections.Generic;
using Substrate.Data;

namespace Full_UMT_Convertor
{
	// Token: 0x02000098 RID: 152
	public class BlockColorIndex
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x00005270 File Offset: 0x00003470
		public BlockColorIndex()
		{
			this.dictionary_0.Add(0, ColorGroup.Other);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000398F8 File Offset: 0x00037AF8
		public ColorGroup GetColorIndex(int data)
		{
			ColorGroup result;
			if (this.dictionary_0.ContainsKey(data))
			{
				result = this.dictionary_0[data];
			}
			else
			{
				result = this.dictionary_0[0];
			}
			return result;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00005290 File Offset: 0x00003490
		internal void method_0(int int_0, ColorGroup colorGroup_0)
		{
			this.dictionary_0[int_0] = colorGroup_0;
		}

		// Token: 0x040004C0 RID: 1216
		private Dictionary<int, ColorGroup> dictionary_0 = new Dictionary<int, ColorGroup>();
	}
}
