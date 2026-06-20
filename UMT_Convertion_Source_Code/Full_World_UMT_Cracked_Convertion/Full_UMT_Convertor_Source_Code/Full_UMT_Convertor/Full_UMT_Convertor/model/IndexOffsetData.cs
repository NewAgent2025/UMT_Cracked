using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000FD RID: 253
	public class IndexOffsetData
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00007964 File Offset: 0x00005B64
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0000796C File Offset: 0x00005B6C
		public uint IndexOffset
		{
			get
			{
				return this.uint_0;
			}
			set
			{
				this.uint_0 = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00007975 File Offset: 0x00005B75
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x0000797D File Offset: 0x00005B7D
		public uint FileCount
		{
			get
			{
				return this.uint_1;
			}
			set
			{
				this.uint_1 = value;
			}
		}

		// Token: 0x04000734 RID: 1844
		private uint uint_0;

		// Token: 0x04000735 RID: 1845
		private uint uint_1;
	}
}
