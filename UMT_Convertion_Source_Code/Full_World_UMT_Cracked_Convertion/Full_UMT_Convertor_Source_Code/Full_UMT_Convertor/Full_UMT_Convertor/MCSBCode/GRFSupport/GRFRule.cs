using System;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x0200008F RID: 143
	public class GRFRule
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x00002591 File Offset: 0x00000791
		public GRFRule()
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00005038 File Offset: 0x00003238
		public GRFRule(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0000504E File Offset: 0x0000324E
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00005056 File Offset: 0x00003256
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0000505F File Offset: 0x0000325F
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00005067 File Offset: 0x00003267
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

		// Token: 0x040003AD RID: 941
		private int id;

		// Token: 0x040003AE RID: 942
		private string name;
	}
}
