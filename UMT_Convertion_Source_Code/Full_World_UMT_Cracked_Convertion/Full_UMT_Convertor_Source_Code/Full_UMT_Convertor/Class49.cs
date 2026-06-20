using System;
using System.Reflection;

// Token: 0x02000165 RID: 357
internal class Class49
{
	// Token: 0x06000E9A RID: 3738 RVA: 0x0005EAB0 File Offset: 0x0005CCB0
	internal static void roMArREEMYUiw(int typemdt)
	{
		Type type = Class49.aTtHmaMciiL.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class49.aTtHmaMciiL.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x04000871 RID: 2161
	internal static Module aTtHmaMciiL = typeof(Class49).Assembly.ManifestModule;

	// Token: 0x02000166 RID: 358
	// (Invoke) Token: 0x06000E9E RID: 3742
	internal delegate void Delegate2(object o);
}
