using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000025 RID: 37
	public class MCCoordinate
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00002E67 File Offset: 0x00001067
		internal MCCoordinate(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002E84 File Offset: 0x00001084
		internal MCCoordinate(int x, int y, int z, int val)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.val = val;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002EA9 File Offset: 0x000010A9
		internal bool method_0(int int_0, int int_1, int int_2)
		{
			return this.x == int_0 && this.y == int_1 && this.z == int_2;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.x.ToString(),
				",",
				this.y.ToString(),
				",",
				this.z.ToString()
			});
		}

		// Token: 0x040000BB RID: 187
		public int x;

		// Token: 0x040000BC RID: 188
		public int y;

		// Token: 0x040000BD RID: 189
		public int z;

		// Token: 0x040000BE RID: 190
		public int val;
	}
}
