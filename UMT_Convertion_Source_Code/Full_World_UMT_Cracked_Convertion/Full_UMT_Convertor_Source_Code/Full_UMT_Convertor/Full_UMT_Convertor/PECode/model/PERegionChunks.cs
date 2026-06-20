using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.PECode.model
{
	// Token: 0x02000127 RID: 295
	public class PERegionChunks
	{
		// Token: 0x06000C83 RID: 3203 RVA: 0x0000879E File Offset: 0x0000699E
		public PERegionChunks()
		{
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000087B1 File Offset: 0x000069B1
		public PERegionChunks(int dimension, int rx, int rz)
		{
			this.dimension = dimension;
			this.rx = rx;
			this.rz = rz;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000087D9 File Offset: 0x000069D9
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x000087E1 File Offset: 0x000069E1
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000087EA File Offset: 0x000069EA
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000087F2 File Offset: 0x000069F2
		public int RX
		{
			get
			{
				return this.rx;
			}
			set
			{
				this.rx = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000087FB File Offset: 0x000069FB
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00008803 File Offset: 0x00006A03
		public int RZ
		{
			get
			{
				return this.rz;
			}
			set
			{
				this.rz = value;
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0000880C File Offset: 0x00006A0C
		internal Dictionary<string, Class40> method_0()
		{
			return this.dictionary_0;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00008814 File Offset: 0x00006A14
		internal void method_1(Dictionary<string, Class40> value)
		{
			this.dictionary_0 = value;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00056ACC File Offset: 0x00054CCC
		public void AddRecord(int x, int z, int tag, int section, byte[] value)
		{
			string key = string.Format("{0}.{1}", x, z);
			if (!this.dictionary_0.ContainsKey(key))
			{
				this.dictionary_0[key] = new Class40(this.dimension, x, z);
			}
			this.dictionary_0[key].method_4(tag, section, value);
		}

		// Token: 0x040007E1 RID: 2017
		private Dictionary<string, Class40> dictionary_0 = new Dictionary<string, Class40>();

		// Token: 0x040007E2 RID: 2018
		private int dimension;

		// Token: 0x040007E3 RID: 2019
		private int rx;

		// Token: 0x040007E4 RID: 2020
		private int rz;
	}
}
