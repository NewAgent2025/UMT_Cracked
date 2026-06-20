using System;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000147 RID: 327
	public class NibbleSetters
	{
		// Token: 0x06000DC9 RID: 3529 RVA: 0x0005D220 File Offset: 0x0005B420
		public int RegionGet(byte[] data, int x, int y, int z, int offset)
		{
			int num = x << this.int_1 | z << this.int_0 | y;
			int num2 = num >> 1;
			int num3 = num & 1;
			num2 += offset;
			if (num3 == 0)
			{
				return (int)(data[num2] & 15);
			}
			return data[num2] >> 4 & 15;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0005D268 File Offset: 0x0005B468
		public void RegionSet(byte[] data, int x, int y, int z, int val, int offset)
		{
			int num = x << this.int_1 | z << this.int_0 | y;
			int num2 = num >> 1;
			int num3 = num & 1;
			num2 += offset;
			if (num3 == 0)
			{
				data[num2] = (byte)((int)(data[num2] & 240) | (val & 15));
				return;
			}
			data[num2] = (byte)((int)(data[num2] & 15) | (val & 15) << 4);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0005D2C8 File Offset: 0x0005B4C8
		public int AnvilGet(byte[] data, int x, int y, int z)
		{
			int num = y << this.int_3 | z << this.int_2 | x;
			int num2 = num >> 1;
			if ((num & 1) == 0)
			{
				return (int)(data[num2] & 15);
			}
			return data[num2] >> 4 & 15;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0005D30C File Offset: 0x0005B50C
		public void AnvilSet(byte[] data, int x, int y, int z, int val)
		{
			int num = y << this.int_3 | z << this.int_2 | x;
			int num2 = num >> 1;
			if ((num & 1) == 0)
			{
				data[num2] = (byte)((int)(data[num2] & 240) | (val & 15));
				return;
			}
			data[num2] = (byte)((int)(data[num2] & 15) | (val & 15) << 4);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0005D368 File Offset: 0x0005B568
		public int TU17Get(byte[] data, int x, int y, int z)
		{
			int num = x * 16 | y * 256 | z;
			int num2 = num >> 1;
			if ((num & 1) == 0)
			{
				return (int)(data[num2] & 15);
			}
			return data[num2] >> 4 & 15;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0005D3A0 File Offset: 0x0005B5A0
		public int method_0(byte[] data, int pos)
		{
			int num = pos >> 1;
			if ((pos & 1) == 0)
			{
				return (int)(data[num] & 15);
			}
			return data[num] >> 4 & 15;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
		public void TU17Set(byte[] data, int x, int y, int z, int val)
		{
			int num = x * 16 | y * 256 | z;
			int num2 = num >> 1;
			if ((num & 1) == 0)
			{
				data[num2] = (byte)((int)(data[num2] & 240) | (val & 15));
				return;
			}
			data[num2] = (byte)((int)(data[num2] & 15) | (val & 15) << 4);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0005D418 File Offset: 0x0005B618
		public void method_1(byte[] data, int pos, int val)
		{
			int num = pos >> 1;
			if ((pos & 1) == 0)
			{
				data[num] = (byte)((int)(data[num] & 240) | (val & 15));
				return;
			}
			data[num] = (byte)((int)(data[num] & 15) | (val & 15) << 4);
		}

		// Token: 0x0400083A RID: 2106
		private int int_0 = 7;

		// Token: 0x0400083B RID: 2107
		private int int_1 = 11;

		// Token: 0x0400083C RID: 2108
		private int int_2 = 4;

		// Token: 0x0400083D RID: 2109
		private int int_3 = 8;
	}
}
