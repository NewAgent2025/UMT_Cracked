using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x0200003D RID: 61
	public class VariableList : UserControl
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00003F22 File Offset: 0x00002122
		public VariableList()
		{
			this.method_5();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00017654 File Offset: 0x00015854
		internal void method_0(List list_0)
		{
			this.flowLayoutPanel_0.Controls.Clear();
			foreach ( searchReplaceVariable_ in list_0)
			{
				this.method_3(searchReplaceVariable_);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000176B4 File Offset: 0x000158B4
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

		// Token: 0x060002C4 RID: 708 RVA: 0x00003F30 File Offset: 0x00002130
		private void flowLayoutPanel_0_Resize(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001772C File Offset: 0x0001592C
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

		// Token: 0x060002C6 RID: 710 RVA: 0x00003F38 File Offset: 0x00002138
		private int method_2()
		{
			return this.flowLayoutPanel_0.Width - (this.flowLayoutPanel_0.VerticalScroll.Visible ? 30 : 10);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003F5E File Offset: 0x0000215E
		private void button_1_Click(object sender, EventArgs e)
		{
			this.method_3(null);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003F67 File Offset: 0x00002167
		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00017820 File Offset: 0x00015A20
		private void method_3(searchReplaceVariable_0 = null)
		{
			/*
An exception occurred when decompiling this method (060002C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.VariableList::method_3(<<<NULL>>>)

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

		// Token: 0x060002CA RID: 714 RVA: 0x00003F6F File Offset: 0x0000216F
		private void axpYhWuVbI(VariableEntry variableEntry_1)
		{
			if (this.variableEntry_0 != null)
			{
				this.variableEntry_0.SetActive(false);
			}
			this.variableEntry_0 = variableEntry_1;
			this.variableEntry_0.SetActive(true);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000178AC File Offset: 0x00015AAC
		private void method_4()
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

		// Token: 0x060002CC RID: 716 RVA: 0x00003F98 File Offset: 0x00002198
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00017918 File Offset: 0x00015B18
		private void method_5()
		{
			/*
An exception occurred when decompiling this method (060002CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.VariableList::method_5()

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

		// Token: 0x040001A1 RID: 417
		private VariableEntry variableEntry_0;

		// Token: 0x040001A2 RID: 418
		private IContainer icontainer_0;

		// Token: 0x040001A3 RID: 419
		private Panel panel_0;

		// Token: 0x040001A4 RID: 420
		private Label label_0;

		// Token: 0x040001A5 RID: 421
		private Label label_1;

		// Token: 0x040001A6 RID: 422
		private Label label_2;

		// Token: 0x040001A7 RID: 423
		private Button button_0;

		// Token: 0x040001A8 RID: 424
		private Button button_1;

		// Token: 0x040001A9 RID: 425
		private FlowLayoutPanel flowLayoutPanel_0;
	}
}
