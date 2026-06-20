using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000A5 RID: 165
	public class DataStateProperty
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x00002591 File Offset: 0x00000791
		public DataStateProperty()
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00005554 File Offset: 0x00003754
		public DataStateProperty(string name, string value)
		{
			this.name = name;
			this.value = value;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0000556A File Offset: 0x0000376A
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00005572 File Offset: 0x00003772
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0000557B File Offset: 0x0000377B
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00005583 File Offset: 0x00003783
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x040004E4 RID: 1252
		private string name;

		// Token: 0x040004E5 RID: 1253
		private string value;
	}
}
