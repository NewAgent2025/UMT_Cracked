using System;
using System.Reflection;

// Token: 0x0200003F RID: 63
internal static class Class8
{
	// Token: 0x060002D6 RID: 726 RVA: 0x00017E74 File Offset: 0x00016074
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
