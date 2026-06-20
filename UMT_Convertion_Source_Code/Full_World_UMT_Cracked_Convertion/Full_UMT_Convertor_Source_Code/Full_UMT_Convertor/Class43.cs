using System;
using System.Runtime.InteropServices;

// Token: 0x0200012C RID: 300
internal class Class43
{
	// Token: 0x06000CB5 RID: 3253
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CopyFileEx(string string_0, string string_1, Class43.Delegate1 delegate1_0, IntPtr intptr_0, ref int int_1, Class43.Enum6 enum6_0);

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00008872 File Offset: 0x00006A72
	public void method_0(string string_0, string string_1)
	{
		Class43.CopyFileEx(string_0, string_1, new Class43.Delegate1(this.method_1), IntPtr.Zero, ref this.int_0, (Class43.Enum6)10U);
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00008895 File Offset: 0x00006A95
	private Class43.Enum4 method_1(long long_0, long long_1, long long_2, long long_3, uint uint_0, Class43.Enum5 enum5_0, IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return (Class43.Enum4)0U;
	}

	// Token: 0x040007EF RID: 2031
	private int int_0;

	// Token: 0x0200012D RID: 301
	// (Invoke) Token: 0x06000CBA RID: 3258
	private delegate Class43.Enum4 Delegate1(long TotalFileSize, long TotalBytesTransferred, long StreamSize, long StreamBytesTransferred, uint dwStreamNumber, Class43.Enum5 dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

	// Token: 0x0200012E RID: 302
	private enum Enum4 : uint
	{

	}

	// Token: 0x0200012F RID: 303
	private enum Enum5 : uint
	{

	}

	// Token: 0x02000130 RID: 304
	[Flags]
	private enum Enum6 : uint
	{

	}
}
