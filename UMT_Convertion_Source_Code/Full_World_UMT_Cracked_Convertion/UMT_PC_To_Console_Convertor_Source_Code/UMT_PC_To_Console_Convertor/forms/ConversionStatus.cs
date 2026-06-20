using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.forms
{
	// Token: 0x02000057 RID: 87
	public partial class ConversionStatus : Form
	{
		// Token: 0x06000399 RID: 921 RVA: 0x0001AF10 File Offset: 0x00019110
		public ConversionStatus(ConvertStatus convertStatus)
		{
			this.method_0();
			this.label_0.Text = "Converted Chunks: " + convertStatus.ProcessedChunkCount.ToString();
			this.label_2.Text = "Missing Chunks: " + convertStatus.MissingChunkCount.ToString();
			this.label_1.Text = "Invalid Chunks: " + convertStatus.InvalidChunkCount.ToString();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001AF94 File Offset: 0x00019194
		private void ConversionStatus_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600039A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.forms.ConversionStatus::ConversionStatus_Load(System.Object,System.EventArgs)

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

		// Token: 0x0600039C RID: 924 RVA: 0x0001AFB4 File Offset: 0x000191B4
		private void method_0()
		{
			this.button_0 = new Button();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			base.SuspendLayout();
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(113, 119);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Close";
			this.button_0.UseVisualStyleBackColor = true;
			this.label_0.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(12, 33);
			this.label_0.Name = "lblConvertedChunks";
			this.label_0.Size = new Size(180, 18);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Converted Chunks";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.label_1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_1.Location = new Point(12, 86);
			this.label_1.Name = "lblInvalidChunks";
			this.label_1.Size = new Size(180, 18);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Invalid Chunks";
			this.label_1.TextAlign = ContentAlignment.MiddleCenter;
			this.label_2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_2.Location = new Point(12, 60);
			this.label_2.Name = "lblMissingChunks";
			this.label_2.Size = new Size(180, 18);
			this.label_2.TabIndex = 3;
			this.label_2.Text = "Missing Chunks";
			this.label_2.TextAlign = ContentAlignment.MiddleCenter;
			this.label_3.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_3.Location = new Point(6, 3);
			this.label_3.Name = "label1";
			this.label_3.Size = new Size(195, 28);
			this.label_3.TabIndex = 5;
			this.label_3.Text = "Conversion Completed";
			this.label_3.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(206, 149);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConversionStatus";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Conversion Status";
			base.Load += this.ConversionStatus_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x040001E4 RID: 484
		private Button button_0;

		// Token: 0x040001E5 RID: 485
		private Label label_0;

		// Token: 0x040001E6 RID: 486
		private Label label_1;

		// Token: 0x040001E7 RID: 487
		private Label label_2;

		// Token: 0x040001E8 RID: 488
		private Label PteiXbWxmc;

		// Token: 0x040001E9 RID: 489
		private Label label_3;
	}
}
