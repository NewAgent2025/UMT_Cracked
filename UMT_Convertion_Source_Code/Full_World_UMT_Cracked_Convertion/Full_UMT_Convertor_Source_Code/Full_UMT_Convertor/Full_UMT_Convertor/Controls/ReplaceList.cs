using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000053 RID: 83
	public class ReplaceList : UserControl
	{
		// Token: 0x06000338 RID: 824 RVA: 0x000040FF File Offset: 0x000022FF
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001B754 File Offset: 0x00019954
		private void method_0()
		{
			int width = this.method_1();
			foreach (object obj in this.flowLayoutPanel_0.Controls)
			{
				UserControl userControl = (UserControl)obj;
				userControl.Width = width;
			}
			int width2 = (this.panel_0.Width - 90) / 2;
			this.label_2.Width = width2;
			this.label_1.Width = 95;
			this.label_1.Left = this.label_2.Width;
			this.label_0.Width = width2;
			this.label_0.Left = this.label_1.Width + this.label_1.Left;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00004107 File Offset: 0x00002307
		private int method_1()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001B82C File Offset: 0x00019A2C
		public List GetReplacements()
		{
			List list = new List();
			foreach (object obj in this.flowLayoutPanel_0.Controls)
			{
				UserControl userControl = (UserControl)obj;
				ReplaceEntry replaceEntry = userControl as ReplaceEntry;
				list.Add(replaceEntry.GetReplacement());
			}
			return list;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000412D File Offset: 0x0000232D
		private void button_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600033C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.ReplaceList::button_0_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00004136 File Offset: 0x00002336
		private void method_2(ReplaceEntry replaceEntry_1)
		{
			if (this.replaceEntry_0 != null)
			{
				this.replaceEntry_0.SetActive(false);
			}
			this.replaceEntry_0 = replaceEntry_1;
			this.replaceEntry_0.SetActive(true);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001B8A4 File Offset: 0x00019AA4
		private void button_1_Click(object sender, EventArgs e)
		{
			if (this.replaceEntry_0 != null)
			{
				this.flowLayoutPanel_0.Controls.Remove(this.replaceEntry_0);
			}
			if (this.flowLayoutPanel_0.Controls.Count > 0)
			{
				((ReplaceEntry)this.flowLayoutPanel_0.Controls[this.flowLayoutPanel_0.Controls.Count - 1]).method_1();
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001B910 File Offset: 0x00019B10
		internal void hTyWilQyp5(List list_0)
		{
			/*
An exception occurred when decompiling this method (0600033F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.ReplaceList::hTyWilQyp5(System.Collections.Generic.List`1<<<<NULL>>>>)

 ---> System.Exception: Inconsistent stack size at IL_24
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000415F File Offset: 0x0000235F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000203 RID: 515
		private ReplaceEntry replaceEntry_0;

		// Token: 0x04000204 RID: 516
		private IContainer icontainer_0;

		// Token: 0x04000205 RID: 517
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04000206 RID: 518
		private Button button_0;

		// Token: 0x04000207 RID: 519
		private Button button_1;

		// Token: 0x04000208 RID: 520
		private Panel panel_0;

		// Token: 0x04000209 RID: 521
		private Label label_0;

		// Token: 0x0400020A RID: 522
		private Label label_1;

		// Token: 0x0400020B RID: 523
		private Label label_2;
	}
}
