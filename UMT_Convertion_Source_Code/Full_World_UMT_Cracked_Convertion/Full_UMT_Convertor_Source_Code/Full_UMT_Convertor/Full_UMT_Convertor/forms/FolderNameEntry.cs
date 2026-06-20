using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Full_UMT_Convertor.Forms
{
	// Token: 0x02000075 RID: 117
	public partial class FolderNameEntry : Form
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00004A9B File Offset: 0x00002C9B
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00004AA3 File Offset: 0x00002CA3
		public string FolderName
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00004AAC File Offset: 0x00002CAC
		public FolderNameEntry()
		{
			this.method_0();
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00026854 File Offset: 0x00024A54
		private void button_1_Click(object sender, EventArgs e)
		{
			string text = this.textBox_0.Text;
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.string_0 = text.Trim();
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00021F14 File Offset: 0x00020114
		private void FolderNameEntry_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060004A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.Forms.FolderNameEntry::FolderNameEntry_Load(System.Object,System.EventArgs)

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

		// Token: 0x060004A5 RID: 1189 RVA: 0x00026890 File Offset: 0x00024A90
		private void method_0()
		{
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(13, 36);
			this.textBox_0.Name = "tbFolderName";
			this.textBox_0.Size = new Size(330, 20);
			this.textBox_0.TabIndex = 0;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(13, 19);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(95, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Save Folder Name";
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(272, 68);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(71, 23);
			this.button_0.TabIndex = 15;
			this.button_0.Text = "Cancel";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.Location = new Point(195, 68);
			this.button_1.Name = "btnOk";
			this.button_1.Size = new Size(71, 23);
			this.button_1.TabIndex = 14;
			this.button_1.Text = "Ok";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(355, 100);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.textBox_0);
			base.Name = "FolderNameEntry";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "MC PC Save Folder Name";
			base.Load += this.FolderNameEntry_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002F3 RID: 755
		private string string_0;

		// Token: 0x040002F5 RID: 757
		private TextBox textBox_0;

		// Token: 0x040002F6 RID: 758
		private Label label_0;

		// Token: 0x040002F7 RID: 759
		private Button button_0;

		// Token: 0x040002F8 RID: 760
		private Button button_1;
	}
}
