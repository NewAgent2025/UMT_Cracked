using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000123 RID: 291
	public class PEDimension
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x0000863A File Offset: 0x0000683A
		public PEDimension()
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0000864D File Offset: 0x0000684D
		public PEDimension(int dimension)
		{
			this.dimension = dimension;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00008667 File Offset: 0x00006867
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0000866F File Offset: 0x0000686F
		public int Dimension
		{
			get
			{
				return this.dimension;
			}
			set
			{
				this.dimension = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00008678 File Offset: 0x00006878
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00008680 File Offset: 0x00006880
		public Dictionary<string, PERegion> Region
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x040007D4 RID: 2004
		private int dimension;

		// Token: 0x040007D5 RID: 2005
		private Dictionary<string, PERegion> dictionary_0 = new Dictionary<string, PERegion>();
	}
}
