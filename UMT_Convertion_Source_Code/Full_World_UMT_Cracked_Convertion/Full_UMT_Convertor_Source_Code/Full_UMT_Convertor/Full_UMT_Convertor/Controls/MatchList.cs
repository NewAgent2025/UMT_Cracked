using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000049 RID: 73
	public class MatchList : UserControl
	{
		// Token: 0x060002BE RID: 702 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public MatchList()
		{
			this.method_4();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00018B3C File Offset: 0x00016D3C
		public void AddCondition(condition = null)
		{
			/*
An exception occurred when decompiling this method (060002BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MatchList::AddCondition(<<<NULL>>>)

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

		// Token: 0x060002C0 RID: 704 RVA: 0x00003BCE File Offset: 0x00001DCE
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00018BC8 File Offset: 0x00016DC8
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

		// Token: 0x060002C2 RID: 706 RVA: 0x00003BD6 File Offset: 0x00001DD6
		private int method_1()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00018CA0 File Offset: 0x00016EA0
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

		// Token: 0x060002C4 RID: 708 RVA: 0x00003BFC File Offset: 0x00001DFC
		private void button_1_Click(object sender, EventArgs e)
		{
			this.AddCondition(null);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003C05 File Offset: 0x00001E05
		private void method_2(MatchEntry matchEntry_1)
		{
			if (this.matchEntry_0 != null)
			{
				this.matchEntry_0.SetActive(false);
			}
			this.matchEntry_0 = matchEntry_1;
			this.matchEntry_0.SetActive(true);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00018D18 File Offset: 0x00016F18
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

		// Token: 0x060002C7 RID: 711 RVA: 0x00018D84 File Offset: 0x00016F84
		internal void method_3(List list_0)
		{
			this.flowLayoutPanel_0.Controls.Clear();
			foreach ( condition in list_0)
			{
				this.AddCondition(condition);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003C2E File Offset: 0x00001E2E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00018DE4 File Offset: 0x00016FE4
		private void method_4()
		{
			/*
An exception occurred when decompiling this method (060002C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MatchList::method_4()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x040001BD RID: 445
		private MatchEntry matchEntry_0;

		// Token: 0x040001BE RID: 446
		private IContainer icontainer_0;

		// Token: 0x040001BF RID: 447
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x040001C0 RID: 448
		private Button button_0;

		// Token: 0x040001C1 RID: 449
		private Button button_1;

		// Token: 0x040001C2 RID: 450
		private Panel panel_0;

		// Token: 0x040001C3 RID: 451
		private Label label_0;

		// Token: 0x040001C4 RID: 452
		private Label label_1;

		// Token: 0x040001C5 RID: 453
		private Label label_2;
	}
}
