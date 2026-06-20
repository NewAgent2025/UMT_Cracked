using System;
using System.Collections.Generic;

// Token: 0x020000C3 RID: 195
internal static class Class35
{
	// Token: 0x06000825 RID: 2085 RVA: 0x000308D0 File Offset: 0x0002EAD0
	public static int[] smethod_0(this byte[] byte_0, byte[] byte_1)
	{
		if (Class35.smethod_2(byte_0, byte_1))
		{
			return Class35.int_0;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (Class35.smethod_1(byte_0, i, byte_1))
			{
				list.Add(i);
			}
		}
		if (list.Count != 0)
		{
			return list.ToArray();
		}
		return Class35.int_0;
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00030928 File Offset: 0x0002EB28
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

	// Token: 0x06000827 RID: 2087 RVA: 0x000068FD File Offset: 0x00004AFD
	private static bool smethod_2(byte[] byte_0, byte[] byte_1)
	{
		return byte_0 == null || byte_1 == null || byte_0.Length == 0 || byte_1.Length == 0 || byte_1.Length > byte_0.Length;
	}

	// Token: 0x04000531 RID: 1329
	private static readonly int[] int_0 = new int[0];
}
