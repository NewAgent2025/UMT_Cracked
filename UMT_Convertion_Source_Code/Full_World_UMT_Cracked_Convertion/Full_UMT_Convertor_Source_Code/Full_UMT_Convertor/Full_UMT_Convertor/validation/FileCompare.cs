using System;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.validation
{
	// Token: 0x0200014D RID: 333
	public class FileCompare
	{
		// Token: 0x06000E15 RID: 3605 RVA: 0x0005DF4C File Offset: 0x0005C14C
		public CompareResult CompareChunkResults(string path)
		{
			string string_ = path + "chunkDebug.dat";
			string string_2 = path + "chunkDebugConverted.dat";
			return this.method_0(string_, string_2);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0005DF7C File Offset: 0x0005C17C
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

		// Token: 0x06000E17 RID: 3607 RVA: 0x0005DFD8 File Offset: 0x0005C1D8
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
