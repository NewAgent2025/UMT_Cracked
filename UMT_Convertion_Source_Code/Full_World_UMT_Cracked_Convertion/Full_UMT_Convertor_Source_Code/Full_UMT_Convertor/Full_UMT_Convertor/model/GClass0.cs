using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000DA RID: 218
	public class GClass0
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00006DEA File Offset: 0x00004FEA
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00006DF2 File Offset: 0x00004FF2
		public byte Index
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00006DFB File Offset: 0x00004FFB
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00006E03 File Offset: 0x00005003
		public byte Multiplier
		{
			get
			{
				return this.byte_1;
			}
			set
			{
				this.byte_1 = value;
			}
		}

		// Token: 0x0400064E RID: 1614
		private byte byte_0;

		// Token: 0x0400064F RID: 1615
		private byte byte_1;
	}
}
