using System;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x0200002F RID: 47
	public class Coord
	{
		// Token: 0x06000196 RID: 406 RVA: 0x0000312E File Offset: 0x0000132E
		internal Coord(int x, int y, int z, int val)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.val = val;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003153 File Offset: 0x00001353
		internal bool method_0(int int_0, int int_1, int int_2)
		{
			return this.x == int_0 && this.y == int_1 && this.z == int_2;
		}

		// Token: 0x040000E5 RID: 229
		public int x;

		// Token: 0x040000E6 RID: 230
		public int y;

		// Token: 0x040000E7 RID: 231
		public int z;

		// Token: 0x040000E8 RID: 232
		public int val;
	}
}
