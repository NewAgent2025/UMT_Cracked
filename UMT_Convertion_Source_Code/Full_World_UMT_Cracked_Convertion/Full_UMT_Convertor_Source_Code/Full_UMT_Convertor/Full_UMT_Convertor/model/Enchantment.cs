using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000A7 RID: 167
	public class Enchantment
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00002591 File Offset: 0x00000791
		public Enchantment()
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000055C4 File Offset: 0x000037C4
		public Enchantment(short id, string name, int maxLevel, List<short> items)
		{
			this.id = id;
			this.name = name;
			this.maxLevel = maxLevel;
			this.items = items;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000055E9 File Offset: 0x000037E9
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000055F1 File Offset: 0x000037F1
		public short Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000055FA File Offset: 0x000037FA
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00005602 File Offset: 0x00003802
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0000560B File Offset: 0x0000380B
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00005613 File Offset: 0x00003813
		public int MaxLevel
		{
			get
			{
				return this.maxLevel;
			}
			set
			{
				this.maxLevel = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0000561C File Offset: 0x0000381C
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00005624 File Offset: 0x00003824
		public int Weight
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0000562D File Offset: 0x0000382D
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00005635 File Offset: 0x00003835
		public List<short> Items
		{
			get
			{
				return this.items;
			}
			set
			{
				this.items = value;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000055FA File Offset: 0x000037FA
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x040004E8 RID: 1256
		private short id;

		// Token: 0x040004E9 RID: 1257
		private string name;

		// Token: 0x040004EA RID: 1258
		private int maxLevel;

		// Token: 0x040004EB RID: 1259
		private int int_0;

		// Token: 0x040004EC RID: 1260
		private List<short> items;
	}
}
