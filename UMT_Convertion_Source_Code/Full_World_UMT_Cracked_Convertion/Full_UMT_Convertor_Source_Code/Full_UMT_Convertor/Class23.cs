using System;
using System.Collections.Generic;

// Token: 0x02000089 RID: 137
internal class Class23
{
	// Token: 0x06000558 RID: 1368 RVA: 0x00004DCF File Offset: 0x00002FCF
	public static Dictionary<string, List<int>> smethod_0()
	{
		return Class23.dictionary_0;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00004DD6 File Offset: 0x00002FD6
	public static Dictionary<string, Dictionary<string, List<int>>> smethod_1()
	{
		return Class23.dictionary_6;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00004DDD File Offset: 0x00002FDD
	public static Dictionary<string, Dictionary<string, List<int>>> smethod_2()
	{
		return Class23.dictionary_7;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x000308A8 File Offset: 0x0002EAA8
	private static List<int> smethod_3(int int_0)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < int_0; i++)
		{
			int num = i * 32;
			for (int j = 0; j < int_0; j++)
			{
				list.Add(num);
				num++;
			}
		}
		list.Sort();
		return list;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x000308EC File Offset: 0x0002EAEC
	private static List<int> smethod_4(int int_0)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < int_0; i++)
		{
			int num = 992 - i * 32;
			for (int j = 0; j < int_0; j++)
			{
				list.Add(num);
				num++;
			}
		}
		list.Sort();
		return list;
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00030938 File Offset: 0x0002EB38
	private static List<int> smethod_5(int int_0)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < int_0; i++)
		{
			int num = 31 + i * 32;
			for (int j = 0; j < int_0; j++)
			{
				list.Add(num);
				num--;
			}
		}
		list.Sort();
		return list;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00030980 File Offset: 0x0002EB80
	private static List<int> smethod_6(int int_0)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < int_0; i++)
		{
			int num = 1023 - i * 32;
			for (int j = 0; j < int_0; j++)
			{
				list.Add(num);
				num--;
			}
		}
		list.Sort();
		return list;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x000309CC File Offset: 0x0002EBCC
	private static List<int> smethod_7()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < 1024; i++)
		{
			list.Add(i);
		}
		return list;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000309F8 File Offset: 0x0002EBF8
	public static void smethod_8()
	{
		Class23.dictionary_0 = new Dictionary<string, List<int>>();
		List<int> value = Class23.smethod_3(27);
		Class23.dictionary_0.Add("r.0.0", value);
		value = Class23.smethod_4(27);
		Class23.dictionary_0.Add("r.0.-1", value);
		value = Class23.smethod_5(27);
		Class23.dictionary_0.Add("r.-1.0", value);
		value = Class23.smethod_6(27);
		Class23.dictionary_0.Add("r.-1.-1", value);
		Class23.dictionary_1 = new Dictionary<string, List<int>>();
		value = Class23.smethod_3(9);
		Class23.dictionary_1.Add("r.0.0", value);
		value = Class23.smethod_4(9);
		Class23.dictionary_1.Add("r.0.-1", value);
		value = Class23.smethod_5(9);
		Class23.dictionary_1.Add("r.-1.0", value);
		value = Class23.smethod_6(9);
		Class23.dictionary_1.Add("r.-1.-1", value);
		Class23.dictionary_2 = new Dictionary<string, List<int>>();
		value = Class23.smethod_3(32);
		Class23.dictionary_2.Add("r.0.0", value);
		value = Class23.smethod_4(32);
		Class23.dictionary_2.Add("r.0.-1", value);
		value = Class23.smethod_5(32);
		Class23.dictionary_2.Add("r.-1.0", value);
		value = Class23.smethod_6(32);
		Class23.dictionary_2.Add("r.-1.-1", value);
		Class23.dictionary_6 = new Dictionary<string, Dictionary<string, List<int>>>();
		Class23.dictionary_6.Add("region", Class23.dictionary_0);
		Class23.dictionary_6.Add("DIM-1", Class23.dictionary_1);
		Class23.dictionary_6.Add("DIM1", Class23.dictionary_2);
		Class23.dictionary_3 = new Dictionary<string, List<int>>();
		value = Class23.smethod_7();
		value = Class23.smethod_3(32);
		Class23.dictionary_3.Add("r.0.0", value);
		value = Class23.smethod_4(32);
		Class23.dictionary_3.Add("r.0.-1", value);
		value = Class23.smethod_5(32);
		Class23.dictionary_3.Add("r.-1.0", value);
		value = Class23.smethod_6(32);
		Class23.dictionary_3.Add("r.-1.-1", value);
		Class23.dictionary_3.Add("r.-1.-2", value);
		Class23.dictionary_3.Add("r.0.-2", value);
		Class23.dictionary_3.Add("r.-1.1", value);
		Class23.dictionary_3.Add("r.0.1", value);
		Class23.dictionary_3.Add("r.1.-2", value);
		Class23.dictionary_3.Add("r.1.-1", value);
		Class23.dictionary_3.Add("r.1.0", value);
		Class23.dictionary_3.Add("r.1.1", value);
		Class23.dictionary_3.Add("r.-2.-2", value);
		Class23.dictionary_3.Add("r.-2.-1", value);
		Class23.dictionary_3.Add("r.-2.0", value);
		Class23.dictionary_3.Add("r.-2.1", value);
		Class23.dictionary_4 = new Dictionary<string, List<int>>();
		value = Class23.smethod_3(11);
		Class23.dictionary_4.Add("r.0.0", value);
		value = Class23.smethod_4(11);
		Class23.dictionary_4.Add("r.0.-1", value);
		value = Class23.smethod_5(11);
		Class23.dictionary_4.Add("r.-1.0", value);
		value = Class23.smethod_6(11);
		Class23.dictionary_4.Add("r.-1.-1", value);
		Class23.dictionary_5 = new Dictionary<string, List<int>>();
		value = Class23.smethod_3(32);
		Class23.dictionary_5.Add("r.0.0", value);
		value = Class23.smethod_4(32);
		Class23.dictionary_5.Add("r.0.-1", value);
		value = Class23.smethod_5(32);
		Class23.dictionary_5.Add("r.-1.0", value);
		value = Class23.smethod_6(32);
		Class23.dictionary_5.Add("r.-1.-1", value);
		Class23.dictionary_7 = new Dictionary<string, Dictionary<string, List<int>>>();
		Class23.dictionary_7.Add("region", Class23.dictionary_3);
		Class23.dictionary_7.Add("DIM-1", Class23.dictionary_4);
		Class23.dictionary_7.Add("DIM1", Class23.dictionary_5);
	}

	// Token: 0x04000387 RID: 903
	private static Dictionary<string, List<int>> dictionary_0;

	// Token: 0x04000388 RID: 904
	private static Dictionary<string, List<int>> dictionary_1;

	// Token: 0x04000389 RID: 905
	private static Dictionary<string, List<int>> dictionary_2;

	// Token: 0x0400038A RID: 906
	private static Dictionary<string, List<int>> dictionary_3;

	// Token: 0x0400038B RID: 907
	private static Dictionary<string, List<int>> dictionary_4;

	// Token: 0x0400038C RID: 908
	private static Dictionary<string, List<int>> dictionary_5;

	// Token: 0x0400038D RID: 909
	private static Dictionary<string, Dictionary<string, List<int>>> dictionary_6;

	// Token: 0x0400038E RID: 910
	private static Dictionary<string, Dictionary<string, List<int>>> dictionary_7;
}
