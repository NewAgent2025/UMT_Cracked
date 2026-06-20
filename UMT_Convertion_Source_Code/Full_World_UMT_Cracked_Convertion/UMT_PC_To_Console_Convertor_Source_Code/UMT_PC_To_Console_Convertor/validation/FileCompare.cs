using System;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.validation
{
	// Token: 0x020000D2 RID: 210
	public class FileCompare
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00033558 File Offset: 0x00031758
		public CompareResult CompareChunkResults(string path)
		{
			string string_ = path + "chunkDebug.dat";
			string string_2 = path + "chunkDebugConverted.dat";
			return this.method_0(string_, string_2);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00033588 File Offset: 0x00031788
		private CompareResult method_0(string string_0, string string_1)
		{
			CompareResult compareResult = new CompareResult();
			byte[] array = FileUtils.smethod_0(string_0);
			byte[] array2 = FileUtils.smethod_0(string_1);
			compareResult.Int32_0 = array.Length;
			compareResult.Int32_1 = array2.Length;
			if (array.Length <= array2.Length)
			{
				compareResult.ErrorPosition = this.method_1(array, array2);
			}
			else
			{
				compareResult.ErrorPosition = this.method_1(array2, array);
			}
			return compareResult;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000335E4 File Offset: 0x000317E4
		private int method_1(byte[] byte_0, byte[] byte_1)
		{
			int result = -1;
			for (int i = 0; i < byte_0.Length - 5; i++)
			{
				if (byte_0[i] != byte_1[i])
				{
					result = i;
					return result;
				}
			}
			return result;
		}
	}
}
