using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x0200003C RID: 60
	public class VariableEntry : UserControl
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00003E87 File Offset: 0x00002087
		public VariableEntry(variableEntryActive)
		{
			this.method_4();
			this.variableEntryActive = variableEntryActive;
			this.method_0();
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000170F8 File Offset: 0x000152F8
		public VariableEntry(variableEntryActive, variableValue)
		{
			/*
An exception occurred when decompiling this method (060002B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.VariableEntry::.ctor(<<<NULL>>>,<<<NULL>>>)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00017158 File Offset: 0x00015358
		private void method_0()
		{
			this.comboBox_0.ValueMember = "Key";
			this.comboBox_0.DisplayMember = "Value";
			this.comboBox_0.DataSource = new BindingSource(Constants.variableDataTypes, null);
			this.comboBox_1.ValueMember = "Key";
			this.comboBox_1.DisplayMember = "Value";
			this.comboBox_1.DataSource = new BindingSource(Constants.variableListTypes, null);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003EA2 File Offset: 0x000020A2
		private void VariableEntry_Resize(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000171D4 File Offset: 0x000153D4
		private void method_1()
		{
			this.textBox_1.Width = 160;
			this.comboBox_0.Left = this.textBox_1.Left + this.textBox_1.Width + 5;
			this.comboBox_1.Left = this.comboBox_0.Left + this.comboBox_0.Width + 5;
			string a = this.comboBox_0.SelectedValue as string;
			int left = this.comboBox_0.Left + this.comboBox_0.Width + 5;
			int num = base.Width - (this.textBox_1.Width + this.comboBox_0.Width + 20);
			if (a == "TAG_LIST")
			{
				left = this.comboBox_1.Left + this.comboBox_1.Width + 5;
				num -= this.comboBox_1.Width + 5;
			}
			this.textBox_0.Width = num;
			this.textBox_0.Left = left;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003EAA File Offset: 0x000020AA
		public  GetVariable()
		{
			/*
An exception occurred when decompiling this method (060002B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling <<<NULL>>> UMT_PC_To_Console_Convertor.controls.VariableEntry::GetVariable()

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

		// Token: 0x060002BA RID: 698 RVA: 0x000032C1 File Offset: 0x000014C1
		public void SetActive(bool active)
		{
			if (active)
			{
				this.BackColor = Color.LightBlue;
				return;
			}
			this.BackColor = Control.DefaultBackColor;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003EE7 File Offset: 0x000020E7
		private void VariableEntry_Enter(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060002BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.VariableEntry::VariableEntry_Enter(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003EE7 File Offset: 0x000020E7
		internal void method_2()
		{
			/*
An exception occurred when decompiling this method (060002BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.VariableEntry::method_2()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00003EF5 File Offset: 0x000020F5
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1();
			this.method_3();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000172D8 File Offset: 0x000154D8
		private void method_3()
		{
			string a = this.comboBox_0.SelectedValue as string;
			this.comboBox_1.Visible = (a == "TAG_LIST");
			if (!(a == "NBT_STRING") && !(a == "TAG_BYTE_ARRAY") && !(a == "TAG_INT_ARRAY") && !(a == "TAG_COMPOUND") && !(a == "TAG_LIST"))
			{
				base.Height = 26;
				this.textBox_0.Height = 20;
				this.textBox_0.ScrollBars = ScrollBars.None;
				this.textBox_0.Multiline = false;
				return;
			}
			this.textBox_0.Multiline = true;
			this.textBox_0.ScrollBars = ScrollBars.Vertical;
			base.Height = 92;
			this.textBox_0.Height = 86;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003F03 File Offset: 0x00002103
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000173A8 File Offset: 0x000155A8
		private void method_4()
		{
			this.textBox_0 = new TextBox();
			this.comboBox_0 = new ComboBox();
			this.textBox_1 = new TextBox();
			this.comboBox_1 = new ComboBox();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(335, 3);
			this.textBox_0.Name = "tbVariableValue";
			this.textBox_0.Size = new Size(203, 20);
			this.textBox_0.TabIndex = 9;
			this.textBox_0.Enter += this.VariableEntry_Enter;
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(189, 2);
			this.comboBox_0.Name = "cbDataType";
			this.comboBox_0.Size = new Size(75, 21);
			this.comboBox_0.TabIndex = 8;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.comboBox_0.Enter += this.VariableEntry_Enter;
			this.textBox_1.Location = new Point(4, 3);
			this.textBox_1.Name = "tbVariableName";
			this.textBox_1.Size = new Size(179, 20);
			this.textBox_1.TabIndex = 7;
			this.textBox_1.Enter += this.VariableEntry_Enter;
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(276, 3);
			this.comboBox_1.Name = "cbListType";
			this.comboBox_1.Size = new Size(60, 21);
			this.comboBox_1.TabIndex = 10;
			this.comboBox_1.Enter += this.VariableEntry_Enter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.comboBox_1);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.textBox_1);
			base.Name = "VariableEntry";
			base.Size = new Size(542, 26);
			base.Enter += this.VariableEntry_Enter;
			base.Resize += this.VariableEntry_Resize;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400019B RID: 411
		private  variableEntryActive;

		// Token: 0x0400019C RID: 412
		private IContainer icontainer_0;

		// Token: 0x0400019D RID: 413
		private TextBox textBox_0;

		// Token: 0x0400019E RID: 414
		private ComboBox comboBox_0;

		// Token: 0x0400019F RID: 415
		private TextBox textBox_1;

		// Token: 0x040001A0 RID: 416
		private ComboBox comboBox_1;
	}
}
