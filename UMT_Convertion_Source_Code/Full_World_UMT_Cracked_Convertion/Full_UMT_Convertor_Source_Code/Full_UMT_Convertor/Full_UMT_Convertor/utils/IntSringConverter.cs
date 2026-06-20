using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000142 RID: 322
	public static class IntSringConverter
	{
		// Token: 0x06000DA7 RID: 3495 RVA: 0x00008DF2 File Offset: 0x00006FF2
		public static List<int> ConvertFromString(string intstring)
		{
			return IntSringConverter.smethod_0(intstring).ToList<int>();
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00008DFF File Offset: 0x00006FFF
		public static string ConvertToString(int[] numList)
		{
			IEnumerable<Tuple<int, int>> source = IntSringConverter.smethod_1(numList);
			if (IntSringConverter.func_0 == null)
			{
				IntSringConverter.func_0 = new Func<Tuple<int, int>, string>(IntSringConverter.smethod_3);
			}
			return source.Select(IntSringConverter.func_0).Intersperse(",");
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0005CBBC File Offset: 0x0005ADBC
		private static IEnumerable<int> smethod_0(string string_0)
		{
			IntSringConverter.<ParseIntString>d__2 <ParseIntString>d__ = new IntSringConverter.<ParseIntString>d__2(-2);
			<ParseIntString>d__.<>3__intstring = string_0;
			return <ParseIntString>d__;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0005CBDC File Offset: 0x0005ADDC
		private static IEnumerable<Tuple<int, int>> smethod_1(IEnumerable<int> ienumerable_0)
		{
			IntSringConverter.<numListToPossiblyDegenerateRanges>d__11 <numListToPossiblyDegenerateRanges>d__ = new IntSringConverter.<numListToPossiblyDegenerateRanges>d__11(-2);
			<numListToPossiblyDegenerateRanges>d__.<>3__numList = ienumerable_0;
			return <numListToPossiblyDegenerateRanges>d__;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0005CBFC File Offset: 0x0005ADFC
		private static string smethod_2(Tuple<int, int> tuple_0)
		{
			if (tuple_0.Item1 == tuple_0.Item2)
			{
				return tuple_0.Item1.ToString();
			}
			return string.Format("{0}-{1}", tuple_0.Item1, tuple_0.Item2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0005CC48 File Offset: 0x0005AE48
		public static string Intersperse(this IEnumerable<string> items, string interspersand)
		{
			string value = "";
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string value2 in items)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(value2);
				value = interspersand;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00008E33 File Offset: 0x00007033
		[CompilerGenerated]
		private static string smethod_3(Tuple<int, int> tuple_0)
		{
			return IntSringConverter.smethod_2(tuple_0);
		}

		// Token: 0x0400081F RID: 2079
		[CompilerGenerated]
		private static Func<Tuple<int, int>, string> func_0;
	}
}
