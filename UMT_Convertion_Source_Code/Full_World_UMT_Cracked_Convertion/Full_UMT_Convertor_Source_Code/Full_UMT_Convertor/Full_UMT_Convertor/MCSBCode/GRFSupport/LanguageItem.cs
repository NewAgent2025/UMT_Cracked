using System;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x02000091 RID: 145
	public class LanguageItem
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x00002591 File Offset: 0x00000791
		public LanguageItem()
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000050B9 File Offset: 0x000032B9
		public LanguageItem(int id, string language)
		{
			this.id = id;
			this.language = language;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000050CF File Offset: 0x000032CF
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000050D7 File Offset: 0x000032D7
		public int Length
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000050E0 File Offset: 0x000032E0
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000050E8 File Offset: 0x000032E8
		public string Language
		{
			get
			{
				return this.language;
			}
			set
			{
				this.language = value;
			}
		}

		// Token: 0x040003B2 RID: 946
		private int id;

		// Token: 0x040003B3 RID: 947
		private string language;
	}
}
