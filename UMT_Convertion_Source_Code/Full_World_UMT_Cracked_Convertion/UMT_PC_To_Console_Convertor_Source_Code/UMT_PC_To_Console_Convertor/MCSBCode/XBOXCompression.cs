using System;
using System.Runtime.InteropServices;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x0200006B RID: 107
	public class XBOXCompression
	{
		// Token: 0x060004AC RID: 1196
		[DllImport("XDecompression32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Compress(IntPtr inArray, int inSize, out IntPtr outArray, out int outSize);

		// Token: 0x060004AD RID: 1197
		[DllImport("XDecompression32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Decompress(IntPtr byteArray, int size, out IntPtr outArray, out int outSize);

		// Token: 0x060004AE RID: 1198
		[DllImport("XDecompression32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Release(ref IntPtr array);

		// Token: 0x060004AF RID: 1199
		[DllImport("XDecompression64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Compress")]
		public static extern void Compress_1(IntPtr inArray, int inSize, out IntPtr outArray, out int outSize);

		// Token: 0x060004B0 RID: 1200
		[DllImport("XDecompression64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Decompress")]
		public static extern void Decompress_1(IntPtr byteArray, int size, out IntPtr outArray, out int outSize);

		// Token: 0x060004B1 RID: 1201
		[DllImport("XDecompression64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Release")]
		public static extern void Release_1(ref IntPtr array);

		// Token: 0x060004B2 RID: 1202 RVA: 0x00025400 File Offset: 0x00023600
		public byte[] DoCompress(byte[] data, int prefixLen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(data.Length);
			Marshal.Copy(data, 0, intPtr, data.Length);
			int num = 0;
			IntPtr source;
			if (Environment.Is64BitProcess)
			{
				XBOXCompression.Compress_1(intPtr, data.Length, out source, out num);
			}
			else
			{
				XBOXCompression.Compress(intPtr, data.Length, out source, out num);
			}
			Marshal.FreeHGlobal(intPtr);
			byte[] array = new byte[num + prefixLen];
			Marshal.Copy(source, array, prefixLen, num);
			if (Environment.Is64BitProcess)
			{
				XBOXCompression.Release_1(ref source);
			}
			else
			{
				XBOXCompression.Release(ref source);
			}
			return array;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00025478 File Offset: 0x00023678
		public byte[] DoDecompress(byte[] data, int dsize)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(data.Length);
			Marshal.Copy(data, 0, intPtr, data.Length);
			int num = dsize;
			IntPtr source;
			if (Environment.Is64BitProcess)
			{
				XBOXCompression.Decompress_1(intPtr, data.Length, out source, out num);
			}
			else
			{
				XBOXCompression.Decompress(intPtr, data.Length, out source, out num);
			}
			Marshal.FreeHGlobal(intPtr);
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, num);
			if (Environment.Is64BitProcess)
			{
				XBOXCompression.Release_1(ref source);
			}
			else
			{
				XBOXCompression.Release(ref source);
			}
			return array;
		}
	}
}
