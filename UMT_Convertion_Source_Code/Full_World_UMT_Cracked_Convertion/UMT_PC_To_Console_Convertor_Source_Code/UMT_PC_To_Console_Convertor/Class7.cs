using System;
using System.Linq;
using System.Text.RegularExpressions;

// Token: 0x0200003E RID: 62
internal class Class7
{
	// Token: 0x060002CE RID: 718 RVA: 0x00003FB7 File Offset: 0x000021B7
	public Class7(Class15 class15_1)
	{
		this.class15_0 = class15_1;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00017D78 File Offset: 0x00015F78
	public  method_0(string string_0)
	{
		/*
An exception occurred when decompiling this method (060002CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling <<<NULL>>> Class7::method_0(System.String)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00003FC6 File Offset: 0x000021C6
	private string method_1(string string_0)
	{
		string_0 = (string_0 ?? string.Empty);
		string_0 = this.method_2(string_0);
		string_0 = this.method_3(string_0);
		return string_0;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00003FE7 File Offset: 0x000021E7
	private string method_2(string string_0)
	{
		return Class7.regex_1.Replace(string_0, "");
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00003FF9 File Offset: 0x000021F9
	private string method_3(string string_0)
	{
		return Class7.regex_2.Replace(string_0, "");
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000400B File Offset: 0x0000220B
	private bool method_4(string string_0)
	{
		return Class14.string_0.Contains(string_0, this.class15_0.method_7());
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00004023 File Offset: 0x00002223
	private bool method_5(string string_0)
	{
		return this.class15_0.method_1().ContainsKey(string_0) || this.class15_0.method_0().ContainsKey(string_0);
	}

	// Token: 0x040001AA RID: 426
	private readonly Class15 class15_0;

	// Token: 0x040001AB RID: 427
	private static readonly Regex regex_0 = new Regex("([^\\.]|^)\\b(?<id>[a-zA-Z_]\\w*)\\b", RegexOptions.Compiled);

	// Token: 0x040001AC RID: 428
	private static readonly Regex regex_1 = new Regex("(?<!\\\\)?\".*?(?<!\\\\)\"", RegexOptions.Compiled);

	// Token: 0x040001AD RID: 429
	private static readonly Regex regex_2 = new Regex("(?<!\\\\)?'.{1,2}?(?<!\\\\)'", RegexOptions.Compiled);
}
