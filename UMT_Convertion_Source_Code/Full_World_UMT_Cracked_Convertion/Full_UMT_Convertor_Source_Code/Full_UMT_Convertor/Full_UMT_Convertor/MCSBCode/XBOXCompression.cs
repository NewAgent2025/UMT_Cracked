using System;
using System.Runtime.InteropServices;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x0200009E RID: 158
	public class XBOXCompression
	{
		// Token: 0x06000682 RID: 1666
		[DllImport("XDecompression32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Compress(IntPtr inArray, int inSize, out IntPtr outArray, out int outSize);

		// Token: 0x06000683 RID: 1667
		[DllImport("XDecompression32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Decompress(IntPtr byteArray, int size, out IntPtr outArray, out int outSize);

		// Token: 0x06000684 RID: 1668
		[DllImport("XDecompression32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Release(ref IntPtr array);

		// Token: 0x06000685 RID: 1669
		[DllImport("XDecompression64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Compress")]
		public static extern void Compress_1(IntPtr inArray, int inSize, out IntPtr outArray, out int outSize);

		// Token: 0x06000686 RID: 1670
		[DllImport("XDecompression64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Decompress")]
		public static extern void Decompress_1(IntPtr byteArray, int size, out IntPtr outArray, out int outSize);

		// Token: 0x06000687 RID: 1671
		[DllImport("XDecompression64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Release")]
		public static extern void Release_1(ref IntPtr array);

		// Token: 0x06000688 RID: 1672 RVA: 0x0003CDAC File Offset: 0x0003AFAC
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

		// Token: 0x06000689 RID: 1673 RVA: 0x0003CE24 File Offset: 0x0003B024
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
