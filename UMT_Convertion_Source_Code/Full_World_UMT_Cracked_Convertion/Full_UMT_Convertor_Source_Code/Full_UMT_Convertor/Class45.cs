using System;
using System.Collections.Generic;

// Token: 0x02000138 RID: 312
internal static class Class45
{
	// Token: 0x06000D19 RID: 3353 RVA: 0x0005A6AC File Offset: 0x000588AC
	public static int[] smethod_0(this byte[] byte_0, byte[] byte_1)
	{
		if (Class45.smethod_2(byte_0, byte_1))
		{
			return Class45.int_0;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (Class45.smethod_1(byte_0, i, byte_1))
			{
				list.Add(i);
			}
		}
		if (list.Count != 0)
		{
			return list.ToArray();
		}
		return Class45.int_0;
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0005A704 File Offset: 0x00058904
	private static bool smethod_1(byte[] byte_0, int int_1, byte[] byte_1)
	{
		if (byte_1.Length > byte_0.Length - int_1)
		{
			return false;
		}
		for (int i = 0; i < byte_1.Length; i++)
		{
			if (byte_0[int_1 + i] != byte_1[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00008B5B File Offset: 0x00006D5B
	private static bool smethod_2(byte[] byte_0, byte[] byte_1)
	{
		return byte_0 == null || byte_1 == null || byte_0.Length == 0 || byte_1.Length == 0 || byte_1.Length > byte_0.Length;
	}

	// Token: 0x04000816 RID: 2070
	private static readonly int[] int_0 = new int[0];
}
