using System;
using System.Reflection;

// Token: 0x02000057 RID: 87
internal static class Class9
{
	// Token: 0x06000363 RID: 867 RVA: 0x0001C6EC File Offset: 0x0001A8EC
	public static void smethod_0(this Exception exception_0)
	{
		try
		{
			typeof(Exception).GetMethod("PrepForRemoting", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(exception_0, new object[0]);
		}
		catch (Exception)
		{
		}
	}
}
