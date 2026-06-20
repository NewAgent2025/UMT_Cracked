using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x0200002F RID: 47
	public class MatchList : UserControl
	{
		// Token: 0x060001DE RID: 478 RVA: 0x000035D4 File Offset: 0x000017D4
		public MatchList()
		{
			this.method_4();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00011320 File Offset: 0x0000F520
		public void AddCondition(condition = null)
		{
			/*
An exception occurred when decompiling this method (060001DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MatchList::AddCondition(<<<NULL>>>)

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

		// Token: 0x060001E0 RID: 480 RVA: 0x000035E2 File Offset: 0x000017E2
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000113AC File Offset: 0x0000F5AC
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

		// Token: 0x060001E2 RID: 482 RVA: 0x000035EA File Offset: 0x000017EA
		private int method_1()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00011484 File Offset: 0x0000F684
		public List GetConditions()
		{
			List list = new List();
			foreach (object obj in this.flowLayoutPanel_0.Controls)
			{
				UserControl userControl = (UserControl)obj;
				MatchEntry matchEntry = userControl as MatchEntry;
				list.Add(matchEntry.GetCondition());
			}
			return list;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00003610 File Offset: 0x00001810
		private void button_1_Click(object sender, EventArgs e)
		{
			this.AddCondition(null);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00003619 File Offset: 0x00001819
		private void method_2(MatchEntry matchEntry_1)
		{
			if (this.matchEntry_0 != null)
			{
				this.matchEntry_0.SetActive(false);
			}
			this.matchEntry_0 = matchEntry_1;
			this.matchEntry_0.SetActive(true);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000114FC File Offset: 0x0000F6FC
		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.matchEntry_0 != null)
			{
				this.flowLayoutPanel_0.Controls.Remove(this.matchEntry_0);
			}
			if (this.flowLayoutPanel_0.Controls.Count > 0)
			{
				((MatchEntry)this.flowLayoutPanel_0.Controls[this.flowLayoutPanel_0.Controls.Count - 1]).method_1();
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00011568 File Offset: 0x0000F768
		internal void method_3(List list_0)
		{
			this.flowLayoutPanel_0.Controls.Clear();
			foreach ( condition in list_0)
			{
				this.AddCondition(condition);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00003642 File Offset: 0x00001842
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000115C8 File Offset: 0x0000F7C8
		private void method_4()
		{
			/*
An exception occurred when decompiling this method (060001E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MatchList::method_4()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x04000110 RID: 272
		private MatchEntry matchEntry_0;

		// Token: 0x04000111 RID: 273
		private IContainer icontainer_0;

		// Token: 0x04000112 RID: 274
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04000113 RID: 275
		private Button button_0;

		// Token: 0x04000114 RID: 276
		private Button button_1;

		// Token: 0x04000115 RID: 277
		private Panel panel_0;

		// Token: 0x04000116 RID: 278
		private Label label_0;

		// Token: 0x04000117 RID: 279
		private Label label_1;

		// Token: 0x04000118 RID: 280
		private Label label_2;
	}
}
