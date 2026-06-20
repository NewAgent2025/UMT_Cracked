using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000099 RID: 153
	public class BiomeChange
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00005C85 File Offset: 0x00003E85
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00005C8D File Offset: 0x00003E8D
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00005C96 File Offset: 0x00003E96
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00005C9E File Offset: 0x00003E9E
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

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002AB38 File Offset: 0x00028D38
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

		// Token: 0x060006C1 RID: 1729 RVA: 0x0002AB80 File Offset: 0x00028D80
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

		// Token: 0x04000428 RID: 1064
		private int int_0 = 1000;

		// Token: 0x04000429 RID: 1065
		private int int_1;
	}
}
