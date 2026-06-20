using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000DD RID: 221
	public class BiomeChange
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00006E94 File Offset: 0x00005094
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006E9C File Offset: 0x0000509C
		public int FromBiome
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00006EA5 File Offset: 0x000050A5
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00006EAD File Offset: 0x000050AD
		public int ToBiome
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000483D8 File Offset: 0x000465D8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.int_0.ToString(),
				",",
				this.int_1.ToString(),
				'|'
			});
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00048420 File Offset: 0x00046620
		public static BiomeChange FromString(string changeStr)
		{
			BiomeChange result = null;
			string[] array = changeStr.Split(new char[]
			{
				','
			});
			if (array.Length == 2)
			{
				int fromBiome = 0;
				int toBiome = 0;
				int.TryParse(array[0], out fromBiome);
				int.TryParse(array[1], out toBiome);
				result = new BiomeChange
				{
					FromBiome = fromBiome,
					ToBiome = toBiome
				};
			}
			return result;
		}

		// Token: 0x04000655 RID: 1621
		private int int_0 = 1000;

		// Token: 0x04000656 RID: 1622
		private int int_1;
	}
}
