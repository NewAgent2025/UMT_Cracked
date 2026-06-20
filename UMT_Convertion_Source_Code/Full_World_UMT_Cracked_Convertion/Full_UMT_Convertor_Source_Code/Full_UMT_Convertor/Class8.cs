using System;
using System.Linq;
using System.Text.RegularExpressions;

// Token: 0x02000056 RID: 86
internal class Class8
{
	// Token: 0x0600035B RID: 859 RVA: 0x000042AE File Offset: 0x000024AE
	public Class8(Class16 class16_1)
	{
		this.class16_0 = class16_1;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
	public  method_0(string string_0)
	{
		/*
An exception occurred when decompiling this method (0600035C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling <<<NULL>>> Class8::method_0(System.String)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000042BD File Offset: 0x000024BD
	private string method_1(string string_0)
	{
		string_0 = (string_0 ?? string.Empty);
		string_0 = this.method_2(string_0);
		string_0 = this.method_3(string_0);
		return string_0;
	}

	// Token: 0x0600035E RID: 862 RVA: 0x000042DE File Offset: 0x000024DE
	private string method_2(string string_0)
	{
		return Class8.regex_1.Replace(string_0, "");
	}

	// Token: 0x0600035F RID: 863 RVA: 0x000042F0 File Offset: 0x000024F0
	private string method_3(string string_0)
	{
		return Class8.regex_2.Replace(string_0, "");
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00004302 File Offset: 0x00002502
	private bool method_4(string string_0)
	{
		return Class15.string_0.Contains(string_0, this.class16_0.method_6());
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0000431A File Offset: 0x0000251A
	private bool method_5(string string_0)
	{
		return this.class16_0.method_1().ContainsKey(string_0) || this.class16_0.method_0().ContainsKey(string_0);
	}

	// Token: 0x0400021B RID: 539
	private readonly Class16 class16_0;

	// Token: 0x0400021C RID: 540
	private static readonly Regex regex_0 = new Regex("([^\\.]|^)\\b(?<id>[a-zA-Z_]\\w*)\\b", RegexOptions.Compiled);

	// Token: 0x0400021D RID: 541
	private static readonly Regex regex_1 = new Regex("(?<!\\\\)?\".*?(?<!\\\\)\"", RegexOptions.Compiled);

	// Token: 0x0400021E RID: 542
	private static readonly Regex regex_2 = new Regex("(?<!\\\\)?'.{1,2}?(?<!\\\\)'", RegexOptions.Compiled);
}
