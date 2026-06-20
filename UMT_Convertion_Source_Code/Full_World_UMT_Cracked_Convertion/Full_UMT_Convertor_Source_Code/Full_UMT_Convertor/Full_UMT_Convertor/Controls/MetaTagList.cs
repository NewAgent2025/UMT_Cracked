using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000044 RID: 68
	public class MetaTagList : UserControl
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0000393B File Offset: 0x00001B3B
		public MetaTagList()
		{
			this.method_4();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00017E44 File Offset: 0x00016044
		public void AddCondition(condition = null)
		{
			/*
An exception occurred when decompiling this method (06000293)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MetaTagList::AddCondition(<<<NULL>>>)

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

		// Token: 0x06000294 RID: 660 RVA: 0x00003949 File Offset: 0x00001B49
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00017ED0 File Offset: 0x000160D0
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

		// Token: 0x06000296 RID: 662 RVA: 0x00003951 File Offset: 0x00001B51
		private int method_1()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00017FA8 File Offset: 0x000161A8
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

		// Token: 0x06000298 RID: 664 RVA: 0x00003977 File Offset: 0x00001B77
		private void button_1_Click(object sender, EventArgs e)
		{
			this.AddCondition(null);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003980 File Offset: 0x00001B80
		private void method_2(MatchEntry matchEntry_1)
		{
			if (this.matchEntry_0 != null)
			{
				this.matchEntry_0.SetActive(false);
			}
			this.matchEntry_0 = matchEntry_1;
			this.matchEntry_0.SetActive(true);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00018020 File Offset: 0x00016220
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

		// Token: 0x0600029B RID: 667 RVA: 0x0001808C File Offset: 0x0001628C
		internal void method_3(List list_0)
		{
			this.flowLayoutPanel_0.Controls.Clear();
			foreach ( condition in list_0)
			{
				this.AddCondition(condition);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000039A9 File Offset: 0x00001BA9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000180EC File Offset: 0x000162EC
		private void method_4()
		{
			/*
An exception occurred when decompiling this method (0600029D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MetaTagList::method_4()

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

		// Token: 0x040001A4 RID: 420
		private MatchEntry matchEntry_0;

		// Token: 0x040001A5 RID: 421
		private IContainer icontainer_0;

		// Token: 0x040001A6 RID: 422
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x040001A7 RID: 423
		private Button button_0;

		// Token: 0x040001A8 RID: 424
		private Button button_1;

		// Token: 0x040001A9 RID: 425
		private Panel panel_0;

		// Token: 0x040001AA RID: 426
		private Label label_0;

		// Token: 0x040001AB RID: 427
		private Label label_1;

		// Token: 0x040001AC RID: 428
		private Label label_2;
	}
}
