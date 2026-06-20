using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000124 RID: 292
	public class PERegion
	{
		// Token: 0x06000C67 RID: 3175 RVA: 0x00008689 File Offset: 0x00006889
		public PERegion()
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000086A1 File Offset: 0x000068A1
		public PERegion(int dimension, int x, int z)
		{
			this.dimension = dimension;
			this.x = x;
			this.z = z;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x000086CE File Offset: 0x000068CE
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x000086D6 File Offset: 0x000068D6
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000086DF File Offset: 0x000068DF
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x000086E7 File Offset: 0x000068E7
		public int RX
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000086F0 File Offset: 0x000068F0
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x000086F8 File Offset: 0x000068F8
		public int RZ
		{
			get
			{
				return this.z;
			}
			set
			{
				this.z = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00008701 File Offset: 0x00006901
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00008709 File Offset: 0x00006909
		public byte[] Chunks
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

		// Token: 0x06000C71 RID: 3185 RVA: 0x00056084 File Offset: 0x00054284
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"r.",
				this.RX,
				".",
				this.RZ
			});
		}

		// Token: 0x040007D6 RID: 2006
		private int dimension;

		// Token: 0x040007D7 RID: 2007
		private int x;

		// Token: 0x040007D8 RID: 2008
		private int z;

		// Token: 0x040007D9 RID: 2009
		private byte[] byte_0 = new byte[1024];
	}
}
