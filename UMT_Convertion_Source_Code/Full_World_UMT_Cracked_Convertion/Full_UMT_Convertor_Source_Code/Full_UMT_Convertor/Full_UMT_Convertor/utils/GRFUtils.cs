using System;
using System.IO;
using System.Linq;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000140 RID: 320
	public class GRFUtils
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x0005C460 File Offset: 0x0005A660
		public static byte[] LoadGRF(string workingFolder)
		{
			byte[] byte_ = null;
			string path = workingFolder + Working.smethod_4() + "requiredGameRules.grf";
			using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				if (Working.GameType == (Enum2)1)
				{
					byte_ = GRFUtils.smethod_0(binaryReader.BaseStream);
				}
				else if (Working.GameType == (Enum2)2)
				{
					byte_ = GRFUtils.smethod_1(binaryReader.BaseStream);
				}
				else if (Working.GameType == (Enum2)3)
				{
					byte_ = GRFUtils.smethod_2(binaryReader.BaseStream);
				}
			}
			return Class46.smethod_69(byte_).ToArray();
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0005C4FC File Offset: 0x0005A6FC
		public static byte[] smethod_0(Stream stream)
		{
			XBOXCompression xboxcompression = new XBOXCompression();
			Class47 @class = new Class47();
			stream.Seek(11L, SeekOrigin.Begin);
			int num = @class.method_4(stream);
			int dsize = @class.method_4(stream);
			byte[] array = new byte[num];
			stream.Read(array, 0, array.Length);
			return xboxcompression.DoDecompress(array, dsize);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0005C55C File Offset: 0x0005A75C
		public static byte[] smethod_1(Stream stream)
		{
			Class47 @class = new Class47();
			stream.Seek(11L, SeekOrigin.Begin);
			int num = @class.method_4(stream);
			@class.method_4(stream);
			@class.method_4(stream);
			byte[] array = new byte[num];
			stream.Read(array, 0, array.Length);
			return Class46.smethod_67(array);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0005C5B4 File Offset: 0x0005A7B4
		public static byte[] smethod_2(Stream stream)
		{
			Class47 @class = new Class47();
			stream.Seek(11L, SeekOrigin.Begin);
			int num = @class.method_4(stream);
			@class.method_4(stream);
			byte[] array = new byte[num];
			stream.Read(array, 0, array.Length);
			return Class46.smethod_64(array);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0005C604 File Offset: 0x0005A804
		public static void smethod_3(string workingFolder, byte[] grf)
		{
			string string_ = workingFolder + Working.smethod_4() + "requiredGameRules.grf";
			GRFUtils.smethod_4(grf, string_, Working.GameType);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0005C630 File Offset: 0x0005A830
		internal static void smethod_4(byte[] byte_0, string string_0, Enum2 enum2_0)
		{
			byte[] array = new byte[2];
			byte[] second = array;
			byte[] array2 = null;
			int int_ = byte_0.Length;
			MemoryStream memoryStream = Class46.smethod_70(byte_0);
			int int_2 = (int)memoryStream.Length;
			if (enum2_0 == (Enum2)1)
			{
				XBOXCompression xboxcompression = new XBOXCompression();
				array2 = xboxcompression.DoCompress(memoryStream.ToArray(), 19);
				GRFUtils.smethod_5(enum2_0, array2, 19, int_, 0);
			}
			else if (enum2_0 == (Enum2)2)
			{
				array2 = Class46.smethod_66(memoryStream.ToArray());
				byte[] first = new byte[23];
				array2 = first.Concat(array2).ToArray<byte>();
				array2 = array2.Concat(second).ToArray<byte>();
				GRFUtils.smethod_5(enum2_0, array2, 20, int_, int_2);
			}
			else if (enum2_0 == (Enum2)3)
			{
				array2 = Class46.smethod_63(memoryStream.ToArray());
				byte[] first2 = new byte[19];
				array2 = first2.Concat(array2).ToArray<byte>();
				GRFUtils.smethod_5(enum2_0, array2, 19, int_, 0);
			}
			FileUtils.WriteFile(array2, string_0);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0005C70C File Offset: 0x0005A90C
		private static void smethod_5(Enum2 enum2_0, byte[] byte_0, int int_0, int int_1, int int_2 = 0)
		{
			byte_0[1] = 1;
			byte b = 0;
			if (enum2_0 == (Enum2)1)
			{
				b = 2;
			}
			if (enum2_0 == (Enum2)2)
			{
				b = 4;
			}
			if (enum2_0 == (Enum2)3)
			{
				b = 3;
			}
			byte_0[10] = b;
			byte[] array = Class46.smethod_30(byte_0.Length - int_0);
			byte_0[11] = array[0];
			byte_0[12] = array[1];
			byte_0[13] = array[2];
			byte_0[14] = array[3];
			array = Class46.smethod_30(int_1);
			byte_0[15] = array[0];
			byte_0[16] = array[1];
			byte_0[17] = array[2];
			byte_0[18] = array[3];
			if (int_2 > 0)
			{
				array = Class46.smethod_30(int_2);
				byte_0[19] = array[0];
				byte_0[20] = array[1];
				byte_0[21] = array[2];
				byte_0[22] = array[3];
			}
		}
	}
}
