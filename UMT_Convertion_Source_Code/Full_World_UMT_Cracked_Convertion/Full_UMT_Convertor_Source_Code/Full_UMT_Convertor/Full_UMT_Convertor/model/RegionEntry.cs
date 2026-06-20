using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D4 RID: 212
	public class RegionEntry
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x00002591 File Offset: 0x00000791
		public RegionEntry()
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00006B06 File Offset: 0x00004D06
		public RegionEntry(int rX, int rZ)
		{
			this.rX = rX;
			this.rZ = rZ;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00006B1C File Offset: 0x00004D1C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00006B24 File Offset: 0x00004D24
		public int RX
		{
			get
			{
				return this.rX;
			}
			set
			{
				this.rX = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00006B2D File Offset: 0x00004D2D
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00006B35 File Offset: 0x00004D35
		public int RZ
		{
			get
			{
				return this.rZ;
			}
			set
			{
				this.rZ = value;
			}
		}

		// Token: 0x04000627 RID: 1575
		private int rX;

		// Token: 0x04000628 RID: 1576
		private int rZ;
	}
}
