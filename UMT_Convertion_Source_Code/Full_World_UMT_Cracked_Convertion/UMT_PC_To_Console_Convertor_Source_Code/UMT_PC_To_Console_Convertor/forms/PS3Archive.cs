using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.MCSBCode.Workers;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.forms
{
	// Token: 0x0200005E RID: 94
	public partial class PS3Archive : Form
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x000045E1 File Offset: 0x000027E1
		public PS3Archive()
		{
			this.method_1();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001B654 File Offset: 0x00019854
		private void PS3Archive_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060003D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.forms.PS3Archive::PS3Archive_Load(System.Object,System.EventArgs)

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

		// Token: 0x060003D8 RID: 984 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
		private void button_0_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.method_0())
				{
					PS3ARCWorker ps3ARCWorker = new PS3ARCWorker();
					ps3ARCWorker.ExtractArchive(this.textBox_0.Text, FileUtils.CheckFolderSep(this.textBox_1.Text));
					MessageBox.Show("Process Completed", "Completed");
				}
				else
				{
					MessageBox.Show("Check Data", "Data Error");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("error", "error");
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001D144 File Offset: 0x0001B344
		private void button_1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.method_0())
				{
					PS3ARCWorker ps3ARCWorker = new PS3ARCWorker();
					ps3ARCWorker.BuildArchive(this.textBox_0.Text, FileUtils.CheckFolderSep(this.textBox_1.Text));
					MessageBox.Show("Process Completed", "Completed");
				}
				else
				{
					MessageBox.Show("Check Data", "Data Error");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("error", "error");
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000045EF File Offset: 0x000027EF
		private bool method_0()
		{
			return this.textBox_0.Text.Length > 0 && this.textBox_1.Text.Length > 0;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
		private void method_1()
		{
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.textBox_1 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(12, 27);
			this.textBox_0.Name = "tbARCFile";
			this.textBox_0.Size = new Size(364, 20);
			this.textBox_0.TabIndex = 0;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(13, 13);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(48, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "ARC File";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(13, 61);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(61, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "ARC Folder";
			this.textBox_1.Location = new Point(12, 75);
			this.textBox_1.Name = "tbARCFolder";
			this.textBox_1.Size = new Size(364, 20);
			this.textBox_1.TabIndex = 2;
			this.button_0.Location = new Point(203, 111);
			this.button_0.Name = "btnUnPack";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 4;
			this.button_0.Text = "UnPack";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(301, 111);
			this.button_1.Name = "btnPack";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 5;
			this.button_1.Text = "Pack";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(392, 147);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.textBox_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PS3Archive";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Archive";
			base.Load += this.PS3Archive_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000222 RID: 546
		private TextBox textBox_0;

		// Token: 0x04000223 RID: 547
		private Label label_0;

		// Token: 0x04000224 RID: 548
		private Label label_1;

		// Token: 0x04000225 RID: 549
		private TextBox textBox_1;

		// Token: 0x04000226 RID: 550
		private Button button_0;

		// Token: 0x04000227 RID: 551
		private Button button_1;
	}
}
