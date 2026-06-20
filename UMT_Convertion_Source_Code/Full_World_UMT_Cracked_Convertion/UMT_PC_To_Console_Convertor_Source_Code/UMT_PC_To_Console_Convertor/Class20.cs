using System;
using System.Collections.Generic;

// Token: 0x02000060 RID: 96
internal class Class20
{
	// Token: 0x06000403 RID: 1027 RVA: 0x000046A3 File Offset: 0x000028A3
	public static Dictionary<string, List<int>> smethod_0()
	{
		return Class20.dictionary_0;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x000046AA File Offset: 0x000028AA
	public static Dictionary<string, Dictionary<string, List<int>>> smethod_1()
	{
		return Class20.CuyJcKiuvt;
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x000046B1 File Offset: 0x000028B1
	public static Dictionary<string, Dictionary<string, List<int>>> smethod_2()
	{
		return Class20.dictionary_6;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x000203A0 File Offset: 0x0001E5A0
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

	// Token: 0x06000407 RID: 1031 RVA: 0x000203E4 File Offset: 0x0001E5E4
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

	// Token: 0x06000408 RID: 1032 RVA: 0x00020430 File Offset: 0x0001E630
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

	// Token: 0x06000409 RID: 1033 RVA: 0x00020478 File Offset: 0x0001E678
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

	// Token: 0x0600040A RID: 1034 RVA: 0x000204C4 File Offset: 0x0001E6C4
	public static void smethod_7()
	{
		Class20.dictionary_0 = new Dictionary<string, List<int>>();
		List<int> value = Class20.smethod_3(27);
		Class20.dictionary_0.Add("r.0.0", value);
		value = Class20.smethod_4(27);
		Class20.dictionary_0.Add("r.0.-1", value);
		value = Class20.smethod_5(27);
		Class20.dictionary_0.Add("r.-1.0", value);
		value = Class20.smethod_6(27);
		Class20.dictionary_0.Add("r.-1.-1", value);
		Class20.dictionary_1 = new Dictionary<string, List<int>>();
		value = Class20.smethod_3(9);
		Class20.dictionary_1.Add("r.0.0", value);
		value = Class20.smethod_4(9);
		Class20.dictionary_1.Add("r.0.-1", value);
		value = Class20.smethod_5(9);
		Class20.dictionary_1.Add("r.-1.0", value);
		value = Class20.smethod_6(9);
		Class20.dictionary_1.Add("r.-1.-1", value);
		Class20.dictionary_2 = new Dictionary<string, List<int>>();
		value = Class20.smethod_3(32);
		Class20.dictionary_2.Add("r.0.0", value);
		value = Class20.smethod_4(32);
		Class20.dictionary_2.Add("r.0.-1", value);
		value = Class20.smethod_5(32);
		Class20.dictionary_2.Add("r.-1.0", value);
		value = Class20.smethod_6(32);
		Class20.dictionary_2.Add("r.-1.-1", value);
		Class20.CuyJcKiuvt = new Dictionary<string, Dictionary<string, List<int>>>();
		Class20.CuyJcKiuvt.Add("region", Class20.dictionary_0);
		Class20.CuyJcKiuvt.Add("DIM-1", Class20.dictionary_1);
		Class20.CuyJcKiuvt.Add("DIM1", Class20.dictionary_2);
		Class20.dictionary_3 = new Dictionary<string, List<int>>();
		value = Class20.smethod_3(32);
		Class20.dictionary_3.Add("r.0.0", value);
		value = Class20.smethod_4(32);
		Class20.dictionary_3.Add("r.0.-1", value);
		value = Class20.smethod_5(32);
		Class20.dictionary_3.Add("r.-1.0", value);
		value = Class20.smethod_6(32);
		Class20.dictionary_3.Add("r.-1.-1", value);
		Class20.dictionary_4 = new Dictionary<string, List<int>>();
		value = Class20.smethod_3(11);
		Class20.dictionary_4.Add("r.0.0", value);
		value = Class20.smethod_4(11);
		Class20.dictionary_4.Add("r.0.-1", value);
		value = Class20.smethod_5(11);
		Class20.dictionary_4.Add("r.-1.0", value);
		value = Class20.smethod_6(11);
		Class20.dictionary_4.Add("r.-1.-1", value);
		Class20.dictionary_5 = new Dictionary<string, List<int>>();
		value = Class20.smethod_3(32);
		Class20.dictionary_5.Add("r.0.0", value);
		value = Class20.smethod_4(32);
		Class20.dictionary_5.Add("r.0.-1", value);
		value = Class20.smethod_5(32);
		Class20.dictionary_5.Add("r.-1.0", value);
		value = Class20.smethod_6(32);
		Class20.dictionary_5.Add("r.-1.-1", value);
		Class20.dictionary_6 = new Dictionary<string, Dictionary<string, List<int>>>();
		Class20.dictionary_6.Add("region", Class20.dictionary_3);
		Class20.dictionary_6.Add("DIM-1", Class20.dictionary_4);
		Class20.dictionary_6.Add("DIM1", Class20.dictionary_5);
	}

	// Token: 0x04000234 RID: 564
	private static Dictionary<string, List<int>> dictionary_0;

	// Token: 0x04000235 RID: 565
	private static Dictionary<string, List<int>> dictionary_1;

	// Token: 0x04000236 RID: 566
	private static Dictionary<string, List<int>> dictionary_2;

	// Token: 0x04000237 RID: 567
	private static Dictionary<string, List<int>> dictionary_3;

	// Token: 0x04000238 RID: 568
	private static Dictionary<string, List<int>> dictionary_4;

	// Token: 0x04000239 RID: 569
	private static Dictionary<string, List<int>> dictionary_5;

	// Token: 0x0400023A RID: 570
	private static Dictionary<string, Dictionary<string, List<int>>> CuyJcKiuvt;

	// Token: 0x0400023B RID: 571
	private static Dictionary<string, Dictionary<string, List<int>>> dictionary_6;
}
