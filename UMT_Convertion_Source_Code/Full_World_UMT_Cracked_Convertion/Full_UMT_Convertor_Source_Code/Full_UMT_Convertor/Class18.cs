using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200006C RID: 108
internal static class Class18
{
	// Token: 0x0600041D RID: 1053 RVA: 0x0001F66C File Offset: 0x0001D86C
	public static Class18.Class19 smethod_0(Type type_0, params string[] parametersNames)
	{
		/*
An exception occurred when decompiling this method (0600041D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Class18/Class19 Class18::smethod_0(System.Type,System.String[])

 ---> System.Exception: Inconsistent stack size at IL_77
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0001F728 File Offset: 0x0001D928
	public static IEnumerable<MethodInfo> smethod_1(Type type_0)
	{
		if (type_0.IsSealed && type_0.IsAbstract && !type_0.IsGenericType && !type_0.IsNested)
		{
			IEnumerable<MethodInfo> methods = type_0.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (Class18.func_0 == null)
			{
				Class18.func_0 = new Func<MethodInfo, bool>(Class18.smethod_2);
			}
			return methods.Where(Class18.func_0);
		}
		return Enumerable.Empty<MethodInfo>();
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00004759 File Offset: 0x00002959
	[CompilerGenerated]
	private static bool smethod_2(MethodInfo methodInfo_0)
	{
		return methodInfo_0.IsDefined(typeof(ExtensionAttribute), false);
	}

	// Token: 0x04000251 RID: 593
	[CompilerGenerated]
	private static Func<MethodInfo, bool> func_0;

	// Token: 0x0200006D RID: 109
	public class Class19
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0000476C File Offset: 0x0000296C
		public Class19(Type type_1, [] parameter_1)
		{
			this.method_1(type_1);
			this.method_3(parameter_1);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00004782 File Offset: 0x00002982
		[CompilerGenerated]
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000478A File Offset: 0x0000298A
		[CompilerGenerated]
		private void method_1(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004793 File Offset: 0x00002993
		[CompilerGenerated]
		public [] method_2()
		{
			return this.parameter_0;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000479B File Offset: 0x0000299B
		[CompilerGenerated]
		private void method_3([] parameter_1)
		{
			this.parameter_0 = parameter_1;
		}

		// Token: 0x04000252 RID: 594
		[CompilerGenerated]
		private Type type_0;

		// Token: 0x04000253 RID: 595
		[CompilerGenerated]
		private [] parameter_0;
	}
}
