using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000B8 RID: 184
	public class IndexOffsetData
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0000662D File Offset: 0x0000482D
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00006635 File Offset: 0x00004835
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0000663E File Offset: 0x0000483E
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00006646 File Offset: 0x00004846
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

		// Token: 0x040004F9 RID: 1273
		private uint uint_0;

		// Token: 0x040004FA RID: 1274
		private uint uint_1;
	}
}
