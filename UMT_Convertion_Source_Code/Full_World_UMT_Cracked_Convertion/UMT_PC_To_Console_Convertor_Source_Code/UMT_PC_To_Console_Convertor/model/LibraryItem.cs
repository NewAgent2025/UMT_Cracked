using System;
using System.Runtime.Serialization;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000BA RID: 186
	[Serializable]
	public class LibraryItem
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00006669 File Offset: 0x00004869
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00006671 File Offset: 0x00004871
		public string Name
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0000667A File Offset: 0x0000487A
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00006682 File Offset: 0x00004882
		public string Author
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0000668B File Offset: 0x0000488B
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00006693 File Offset: 0x00004893
		public string Category
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0000669C File Offset: 0x0000489C
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x000066A4 File Offset: 0x000048A4
		public string Description
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x000066AD File Offset: 0x000048AD
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000066B5 File Offset: 0x000048B5
		public string Instructions
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000066BE File Offset: 0x000048BE
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x000066C6 File Offset: 0x000048C6
		public string String_0
		{
			get
			{
				return this.string_5;
			}
			set
			{
				this.string_5 = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000066CF File Offset: 0x000048CF
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x000066D7 File Offset: 0x000048D7
		public string Link
		{
			get
			{
				return this.string_6;
			}
			set
			{
				this.string_6 = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000066E0 File Offset: 0x000048E0
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x000066E8 File Offset: 0x000048E8
		[IgnoreDataMember]
		public string Path
		{
			get
			{
				return this.string_7;
			}
			set
			{
				this.string_7 = value;
			}
		}

		// Token: 0x040004FC RID: 1276
		private string string_0;

		// Token: 0x040004FD RID: 1277
		private string string_1;

		// Token: 0x040004FE RID: 1278
		private string string_2;

		// Token: 0x040004FF RID: 1279
		private string string_3;

		// Token: 0x04000500 RID: 1280
		private string string_4;

		// Token: 0x04000501 RID: 1281
		private string string_5;

		// Token: 0x04000502 RID: 1282
		private string string_6;

		// Token: 0x04000503 RID: 1283
		private string string_7;
	}
}
