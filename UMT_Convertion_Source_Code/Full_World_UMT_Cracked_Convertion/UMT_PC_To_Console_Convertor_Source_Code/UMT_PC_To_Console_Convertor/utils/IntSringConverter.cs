using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000C8 RID: 200
	public static class IntSringConverter
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x00006B49 File Offset: 0x00004D49
		public static List<int> ConvertFromString(string intstring)
		{
			return IntSringConverter.smethod_0(intstring).ToList<int>();
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00006B56 File Offset: 0x00004D56
		public static string ConvertToString(int[] numList)
		{
			IEnumerable<Tuple<int, int>> source = IntSringConverter.smethod_1(numList);
			if (IntSringConverter.func_0 == null)
			{
				IntSringConverter.func_0 = new Func<Tuple<int, int>, string>(IntSringConverter.smethod_3);
			}
			return source.Select(IntSringConverter.func_0).Intersperse(",");
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0003240C File Offset: 0x0003060C
		private static IEnumerable<int> smethod_0(string string_0)
		{
			IntSringConverter.<ParseIntString>d__2 <ParseIntString>d__ = new IntSringConverter.<ParseIntString>d__2(-2);
			<ParseIntString>d__.<>3__intstring = string_0;
			return <ParseIntString>d__;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0003242C File Offset: 0x0003062C
		private static IEnumerable<Tuple<int, int>> smethod_1(IEnumerable<int> ienumerable_0)
		{
			IntSringConverter.<numListToPossiblyDegenerateRanges>d__11 <numListToPossiblyDegenerateRanges>d__ = new IntSringConverter.<numListToPossiblyDegenerateRanges>d__11(-2);
			<numListToPossiblyDegenerateRanges>d__.<>3__numList = ienumerable_0;
			return <numListToPossiblyDegenerateRanges>d__;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0003244C File Offset: 0x0003064C
		private static string smethod_2(Tuple<int, int> tuple_0)
		{
			if (tuple_0.Item1 == tuple_0.Item2)
			{
				return tuple_0.Item1.ToString();
			}
			return string.Format("{0}-{1}", tuple_0.Item1, tuple_0.Item2);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00032498 File Offset: 0x00030698
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

		// Token: 0x06000895 RID: 2197 RVA: 0x00006B8A File Offset: 0x00004D8A
		[CompilerGenerated]
		private static string smethod_3(Tuple<int, int> tuple_0)
		{
			return IntSringConverter.smethod_2(tuple_0);
		}

		// Token: 0x04000538 RID: 1336
		[CompilerGenerated]
		private static Func<Tuple<int, int>, string> func_0;
	}
}
