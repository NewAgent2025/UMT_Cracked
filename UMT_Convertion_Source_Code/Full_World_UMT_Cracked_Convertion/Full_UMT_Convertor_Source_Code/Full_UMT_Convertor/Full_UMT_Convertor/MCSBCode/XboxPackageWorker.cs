using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Save_Manager.model;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000022 RID: 34
	public class XboxPackageWorker
	{
		// Token: 0x0600012E RID: 302
		[DllImport("XboxHelper32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PackageInfo(string source, out IntPtr nameArray, out int nameSize, out IntPtr imageArray, out int imageSize, out int fileSize);

		// Token: 0x0600012F RID: 303
		[DllImport("XboxHelper32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ExportFile(string source, string target);

		// Token: 0x06000130 RID: 304
		[DllImport("XboxHelper32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Release(ref IntPtr array);

		// Token: 0x06000131 RID: 305
		[DllImport("XboxHelper64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PackageInfo")]
		public static extern void PackageInfo_1(string source, out IntPtr nameArray, out int nameSize, out IntPtr imageArray, out int imageSize, out int fileSize);

		// Token: 0x06000132 RID: 306
		[DllImport("XboxHelper64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ExportFile")]
		public static extern void ExportFile_1(string source, string target);

		// Token: 0x06000133 RID: 307
		[DllImport("XboxHelper64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Release")]
		public static extern void Release_1(ref IntPtr array);

		// Token: 0x06000134 RID: 308 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public void DoExportFile(string source, string target)
		{
			if (Environment.Is64BitProcess)
			{
				XboxPackageWorker.ExportFile_1(source, target);
				return;
			}
			XboxPackageWorker.ExportFile(source, target);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public XboxPackageData DoPackageInfo(string source)
		{
			int num = 0;
			int num2 = 0;
			int filesize = 0;
			IntPtr source2;
			IntPtr source3;
			if (Environment.Is64BitProcess)
			{
				XboxPackageWorker.PackageInfo_1(source, out source2, out num2, out source3, out num, out filesize);
			}
			else
			{
				XboxPackageWorker.PackageInfo(source, out source2, out num2, out source3, out num, out filesize);
			}
			byte[] array = new byte[num];
			Marshal.Copy(source3, array, 0, num);
			byte[] array2 = new byte[num2];
			Marshal.Copy(source2, array2, 0, num2);
			string @string = Encoding.UTF8.GetString(array2, 0, array2.Length);
			Image thumbnailImage = null;
			using (MemoryStream memoryStream = new MemoryStream(array))
			{
				thumbnailImage = Image.FromStream(memoryStream);
			}
			XboxPackageData result = new XboxPackageData
			{
				Name = @string,
				ThumbnailImage = thumbnailImage,
				Path = source,
				Filesize = filesize
			};
			if (Environment.Is64BitProcess)
			{
				XboxPackageWorker.Release_1(ref source3);
			}
			else
			{
				XboxPackageWorker.Release(ref source3);
			}
			return result;
		}
	}
}
