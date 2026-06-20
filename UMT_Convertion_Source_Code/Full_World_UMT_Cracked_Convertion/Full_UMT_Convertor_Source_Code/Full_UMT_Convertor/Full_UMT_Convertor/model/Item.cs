using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F3 RID: 243
	public class Item
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x00007598 File Offset: 0x00005798
		public Item()
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0004E7D0 File Offset: 0x0004C9D0
		public Item(int id, string mcName, string name)
		{
			this.id = id;
			this.mcName = mcName;
			this.name = name;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0004E820 File Offset: 0x0004CA20
		public Item(int id, string mcName, string name, bool onConsole, int replaceId)
		{
			this.id = id;
			this.mcName = mcName;
			this.name = name;
			this.onConsole = onConsole;
			this.replaceId = replaceId;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000075C8 File Offset: 0x000057C8
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x000075D0 File Offset: 0x000057D0
		public int Id
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000075D9 File Offset: 0x000057D9
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x000075E1 File Offset: 0x000057E1
		public string MCName
		{
			get
			{
				return this.mcName;
			}
			set
			{
				this.mcName = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000075EA File Offset: 0x000057EA
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x000075F2 File Offset: 0x000057F2
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x000075FB File Offset: 0x000057FB
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00007603 File Offset: 0x00005803
		public string Image
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0000760C File Offset: 0x0000580C
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00007614 File Offset: 0x00005814
		public bool OnConsole
		{
			get
			{
				return this.onConsole;
			}
			set
			{
				this.onConsole = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0000761D File Offset: 0x0000581D
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00007625 File Offset: 0x00005825
		public int ReplaceId
		{
			get
			{
				return this.replaceId;
			}
			set
			{
				this.replaceId = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0000762E File Offset: 0x0000582E
		public string IdName
		{
			get
			{
				return "(" + this.id.ToString() + ") " + this.name;
			}
		}

		// Token: 0x040006FB RID: 1787
		private int id;

		// Token: 0x040006FC RID: 1788
		private string mcName = "";

		// Token: 0x040006FD RID: 1789
		private string name = "";

		// Token: 0x040006FE RID: 1790
		private string string_0 = "";

		// Token: 0x040006FF RID: 1791
		private bool onConsole = true;

		// Token: 0x04000700 RID: 1792
		private int replaceId;
	}
}
