using System;
using System.Reflection;

// Token: 0x020000E0 RID: 224
internal class Class38
{
	// Token: 0x06000923 RID: 2339 RVA: 0x00033958 File Offset: 0x00031B58
	internal static void RxqCXIlleDOb7(int typemdt)
	{
		Type type = Class38.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class38.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x04000571 RID: 1393
	internal static Module module_0 = typeof(Class38).Assembly.ManifestModule;

	// Token: 0x020000E1 RID: 225
	// (Invoke) Token: 0x06000927 RID: 2343
	internal delegate void Delegate0(object o);
}
