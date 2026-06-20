using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C3 RID: 195
	public class Biome
	{
		// Token: 0x06000840 RID: 2112 RVA: 0x00006258 File Offset: 0x00004458
		public Biome()
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000626B File Offset: 0x0000446B
		public Biome(int id, string name, bool onConsole, uint color, uint textColor)
		{
			this.id = id;
			this.name = name;
			this.onConsole = onConsole;
			this.color = color;
			this.textColor = textColor;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000062A3 File Offset: 0x000044A3
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x000062AB File Offset: 0x000044AB
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000062B4 File Offset: 0x000044B4
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x000062BC File Offset: 0x000044BC
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x000062C5 File Offset: 0x000044C5
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x000062CD File Offset: 0x000044CD
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000062D6 File Offset: 0x000044D6
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x000062DE File Offset: 0x000044DE
		public uint Color
		{
			get
			{
				return this.color;
			}
			set
			{
				this.color = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000062E7 File Offset: 0x000044E7
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x000062EF File Offset: 0x000044EF
		public uint TextColor
		{
			get
			{
				return this.textColor;
			}
			set
			{
				this.textColor = value;
			}
		}

		// Token: 0x040005C1 RID: 1473
		private int id;

		// Token: 0x040005C2 RID: 1474
		private string name = "";

		// Token: 0x040005C3 RID: 1475
		private bool onConsole;

		// Token: 0x040005C4 RID: 1476
		private uint color;

		// Token: 0x040005C5 RID: 1477
		private uint textColor;
	}
}
