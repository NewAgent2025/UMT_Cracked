using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000028 RID: 40
	public class MetaTagList : UserControl
	{
		// Token: 0x06000172 RID: 370 RVA: 0x000031D1 File Offset: 0x000013D1
		public MetaTagList()
		{
			this.method_3();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000E30C File Offset: 0x0000C50C
		public void AddCondition(condition = null)
		{
			/*
An exception occurred when decompiling this method (06000173)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MetaTagList::AddCondition(<<<NULL>>>)

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

		// Token: 0x06000174 RID: 372 RVA: 0x000031DF File Offset: 0x000013DF
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000E398 File Offset: 0x0000C598
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

		// Token: 0x06000176 RID: 374 RVA: 0x000031E7 File Offset: 0x000013E7
		private int method_1()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000E470 File Offset: 0x0000C670
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

		// Token: 0x06000178 RID: 376 RVA: 0x0000320D File Offset: 0x0000140D
		private void button_1_Click(object sender, EventArgs e)
		{
			this.AddCondition(null);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00003216 File Offset: 0x00001416
		private void method_2(MatchEntry matchEntry_1)
		{
			if (this.matchEntry_0 != null)
			{
				this.matchEntry_0.SetActive(false);
			}
			this.matchEntry_0 = matchEntry_1;
			this.matchEntry_0.SetActive(true);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
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

		// Token: 0x0600017B RID: 379 RVA: 0x0000E554 File Offset: 0x0000C754
		internal void uQuHvYgRhu(List list_0)
		{
			this.flowLayoutPanel_0.Controls.Clear();
			foreach ( condition in list_0)
			{
				this.AddCondition(condition);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000323F File Offset: 0x0000143F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		private void method_3()
		{
			/*
An exception occurred when decompiling this method (0600017D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MetaTagList::method_3()

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

		// Token: 0x040000C7 RID: 199
		private MatchEntry matchEntry_0;

		// Token: 0x040000C8 RID: 200
		private IContainer icontainer_0;

		// Token: 0x040000C9 RID: 201
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x040000CA RID: 202
		private Button button_0;

		// Token: 0x040000CB RID: 203
		private Button button_1;

		// Token: 0x040000CC RID: 204
		private Panel panel_0;

		// Token: 0x040000CD RID: 205
		private Label label_0;

		// Token: 0x040000CE RID: 206
		private Label label_1;

		// Token: 0x040000CF RID: 207
		private Label label_2;
	}
}
