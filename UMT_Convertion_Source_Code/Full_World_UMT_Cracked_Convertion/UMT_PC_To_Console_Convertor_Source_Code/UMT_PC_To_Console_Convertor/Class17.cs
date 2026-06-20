using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02000054 RID: 84
internal static class Class17
{
	// Token: 0x06000390 RID: 912 RVA: 0x0001ADF4 File Offset: 0x00018FF4
	public static Class17.Class18 smethod_0(Type type_0, params string[] parametersNames)
	{
		/*
An exception occurred when decompiling this method (06000390)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Class17/Class18 Class17::smethod_0(System.Type,System.String[])

 ---> System.Exception: Inconsistent stack size at IL_77
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0001AEB0 File Offset: 0x000190B0
	public static IEnumerable<MethodInfo> smethod_1(Type type_0)
	{
		if (type_0.IsSealed && type_0.IsAbstract && !type_0.IsGenericType && !type_0.IsNested)
		{
			IEnumerable<MethodInfo> methods = type_0.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (Class17.func_0 == null)
			{
				Class17.func_0 = new Func<MethodInfo, bool>(Class17.smethod_2);
			}
			return methods.Where(Class17.func_0);
		}
		return Enumerable.Empty<MethodInfo>();
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00004462 File Offset: 0x00002662
	[CompilerGenerated]
	private static bool smethod_2(MethodInfo methodInfo_0)
	{
		return methodInfo_0.IsDefined(typeof(ExtensionAttribute), false);
	}

	// Token: 0x040001E0 RID: 480
	[CompilerGenerated]
	private static Func<MethodInfo, bool> func_0;

	// Token: 0x02000055 RID: 85
	public class Class18
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00004475 File Offset: 0x00002675
		public Class18(Type type_1, [] parameter_1)
		{
			this.method_1(type_1);
			this.method_3(parameter_1);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000448B File Offset: 0x0000268B
		[CompilerGenerated]
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00004493 File Offset: 0x00002693
		[CompilerGenerated]
		private void method_1(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000449C File Offset: 0x0000269C
		[CompilerGenerated]
		public [] method_2()
		{
			return this.parameter_0;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000044A4 File Offset: 0x000026A4
		[CompilerGenerated]
		private void method_3([] parameter_1)
		{
			this.parameter_0 = parameter_1;
		}

		// Token: 0x040001E1 RID: 481
		[CompilerGenerated]
		private Type type_0;

		// Token: 0x040001E2 RID: 482
		[CompilerGenerated]
		private [] parameter_0;
	}
}
