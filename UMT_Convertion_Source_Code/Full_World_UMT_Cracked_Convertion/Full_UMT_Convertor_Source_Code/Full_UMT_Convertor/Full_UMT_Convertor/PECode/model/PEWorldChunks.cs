using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.PECode.model
{
	// Token: 0x02000128 RID: 296
	public class PEWorldChunks
	{
		// Token: 0x06000C8E RID: 3214 RVA: 0x0000881D File Offset: 0x00006A1D
		internal Dictionary<int, Dictionary<string, PERegionChunks>> method_0()
		{
			return this.dictionary_0;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00008825 File Offset: 0x00006A25
		internal void method_1(Dictionary<int, Dictionary<string, PERegionChunks>> value)
		{
			this.dictionary_0 = value;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00056B30 File Offset: 0x00054D30
		public void AddRecord(int dimension, int x, int z, int tag, int section, byte[] value)
		{
			if (!this.dictionary_0.ContainsKey(dimension))
			{
				this.dictionary_0[dimension] = new Dictionary<string, PERegionChunks>();
			}
			int num = (int)Math.Floor((double)x / 32.0);
			int num2 = (int)Math.Floor((double)z / 32.0);
			string key = string.Format("r.{0}.{1}", num, num2);
			if (!this.dictionary_0[dimension].ContainsKey(key))
			{
				this.dictionary_0[dimension].Add(key, new PERegionChunks(dimension, num, num2));
			}
			this.dictionary_0[dimension][key].AddRecord(x, z, tag, section, value);
		}

		// Token: 0x040007E5 RID: 2021
		private Dictionary<int, Dictionary<string, PERegionChunks>> dictionary_0 = new Dictionary<int, Dictionary<string, PERegionChunks>>();
	}
}
