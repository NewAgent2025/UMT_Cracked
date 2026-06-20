using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000B0 RID: 176
	public class Item
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x000062D7 File Offset: 0x000044D7
		public Item()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0002D620 File Offset: 0x0002B820
		public Item(int id, string mcName, string name)
		{
			this.id = id;
			this.mcName = mcName;
			this.name = name;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0002D670 File Offset: 0x0002B870
		public Item(int id, string mcName, string name, bool onConsole, int replaceId)
		{
			this.id = id;
			this.mcName = mcName;
			this.name = name;
			this.onConsole = onConsole;
			this.replaceId = replaceId;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00006307 File Offset: 0x00004507
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0000630F File Offset: 0x0000450F
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00006318 File Offset: 0x00004518
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00006320 File Offset: 0x00004520
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00006329 File Offset: 0x00004529
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00006331 File Offset: 0x00004531
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0000633A File Offset: 0x0000453A
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00006342 File Offset: 0x00004542
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0000634B File Offset: 0x0000454B
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00006353 File Offset: 0x00004553
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0000635C File Offset: 0x0000455C
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00006364 File Offset: 0x00004564
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0000636D File Offset: 0x0000456D
		public string IdName
		{
			get
			{
				return "(" + this.id.ToString() + ") " + this.name;
			}
		}

		// Token: 0x040004CA RID: 1226
		private int id;

		// Token: 0x040004CB RID: 1227
		private string mcName = "";

		// Token: 0x040004CC RID: 1228
		private string name = "";

		// Token: 0x040004CD RID: 1229
		private string string_0 = "";

		// Token: 0x040004CE RID: 1230
		private bool onConsole = true;

		// Token: 0x040004CF RID: 1231
		private int replaceId;
	}
}
