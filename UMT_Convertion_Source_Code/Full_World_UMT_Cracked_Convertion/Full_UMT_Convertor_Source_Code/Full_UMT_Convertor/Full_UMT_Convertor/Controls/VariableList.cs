using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000055 RID: 85
	public class VariableList : UserControl
	{
		// Token: 0x0600034E RID: 846 RVA: 0x00004219 File Offset: 0x00002419
		public VariableList()
		{
			this.method_6();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001BECC File Offset: 0x0001A0CC
		internal void method_0(List list_0)
		{
			this.flowLayoutPanel_0.Controls.Clear();
			foreach ( searchReplaceVariable_ in list_0)
			{
				this.method_3(searchReplaceVariable_);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001BF2C File Offset: 0x0001A12C
		public List GetVariables()
		{
			List list = new List();
			foreach (object obj in this.flowLayoutPanel_0.Controls)
			{
				UserControl userControl = (UserControl)obj;
				VariableEntry variableEntry = userControl as VariableEntry;
				list.Add(variableEntry.GetVariable());
			}
			return list;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00004227 File Offset: 0x00002427
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		private void method_1()
		{
			int num = this.method_2();
			foreach (object obj in this.flowLayoutPanel_0.Controls)
			{
				UserControl userControl = (UserControl)obj;
				userControl.Width = num;
			}
			int num2 = (this.panel_0.Width - 90) / 2;
			this.label_2.Width = 180;
			this.label_1.Width = 135;
			this.label_1.Left = this.label_2.Width;
			this.label_0.Width = num - (this.label_1.Width + this.label_2.Width);
			this.label_0.Left = this.label_1.Width + this.label_1.Left;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000422F File Offset: 0x0000242F
		private int method_2()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00004255 File Offset: 0x00002455
		private void button_1_Click(object sender, EventArgs e)
		{
			this.method_3(null);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000425E File Offset: 0x0000245E
		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001C098 File Offset: 0x0001A298
		private void method_3(searchReplaceVariable_0 = null)
		{
			/*
An exception occurred when decompiling this method (06000356)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.VariableList::method_3(<<<NULL>>>)

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

		// Token: 0x06000357 RID: 855 RVA: 0x00004266 File Offset: 0x00002466
		private void method_4(VariableEntry variableEntry_1)
		{
			if (this.variableEntry_0 != null)
			{
				this.variableEntry_0.SetActive(false);
			}
			this.variableEntry_0 = variableEntry_1;
			this.variableEntry_0.SetActive(true);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001C124 File Offset: 0x0001A324
		private void method_5()
		{
			if (this.variableEntry_0 != null)
			{
				this.flowLayoutPanel_0.Controls.Remove(this.variableEntry_0);
			}
			if (this.flowLayoutPanel_0.Controls.Count > 0)
			{
				((VariableEntry)this.flowLayoutPanel_0.Controls[this.flowLayoutPanel_0.Controls.Count - 1]).method_2();
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000428F File Offset: 0x0000248F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0001C190 File Offset: 0x0001A390
		private void method_6()
		{
			/*
An exception occurred when decompiling this method (0600035A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.VariableList::method_6()

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

		// Token: 0x04000212 RID: 530
		private VariableEntry variableEntry_0;

		// Token: 0x04000213 RID: 531
		private IContainer icontainer_0;

		// Token: 0x04000214 RID: 532
		private Panel panel_0;

		// Token: 0x04000215 RID: 533
		private Label label_0;

		// Token: 0x04000216 RID: 534
		private Label label_1;

		// Token: 0x04000217 RID: 535
		private Label label_2;

		// Token: 0x04000218 RID: 536
		private Button button_0;

		// Token: 0x04000219 RID: 537
		private Button button_1;

		// Token: 0x0400021A RID: 538
		private FlowLayoutPanel flowLayoutPanel_0;
	}
}
