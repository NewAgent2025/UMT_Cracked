using System;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000CD RID: 205
	public class NibbleSetters
	{
		// Token: 0x060008B1 RID: 2225 RVA: 0x00032A70 File Offset: 0x00030C70
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

		// Token: 0x060008B2 RID: 2226 RVA: 0x00032AB8 File Offset: 0x00030CB8
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

		// Token: 0x060008B3 RID: 2227 RVA: 0x00032B18 File Offset: 0x00030D18
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

		// Token: 0x060008B4 RID: 2228 RVA: 0x00032B5C File Offset: 0x00030D5C
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

		// Token: 0x060008B5 RID: 2229 RVA: 0x00032BB8 File Offset: 0x00030DB8
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

		// Token: 0x060008B6 RID: 2230 RVA: 0x00032BF0 File Offset: 0x00030DF0
		public int method_0(byte[] data, int pos)
		{
			int num = pos >> 1;
			if ((pos & 1) == 0)
			{
				return (int)(data[num] & 15);
			}
			return data[num] >> 4 & 15;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00032C18 File Offset: 0x00030E18
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

		// Token: 0x060008B8 RID: 2232 RVA: 0x00032C68 File Offset: 0x00030E68
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

		// Token: 0x04000553 RID: 1363
		private int int_0 = 7;

		// Token: 0x04000554 RID: 1364
		private int int_1 = 11;

		// Token: 0x04000555 RID: 1365
		private int int_2 = 4;

		// Token: 0x04000556 RID: 1366
		private int int_3 = 8;
	}
}
