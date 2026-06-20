using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000071 RID: 113
	public partial class ConvertToConsole : Form
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00004940 File Offset: 0x00002B40
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00004948 File Offset: 0x00002B48
		public ConvertToConsole()
		{
			this.method_0();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00021F14 File Offset: 0x00020114
		private void ConvertToConsole_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000465)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertToConsole::ConvertToConsole_Load(System.Object,System.EventArgs)

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

		// Token: 0x06000466 RID: 1126 RVA: 0x00021F2C File Offset: 0x0002012C
		private void button_1_Click(object sender, EventArgs e)
		{
			this.convertParameters_0 = new ConvertParameters();
			this.convertParameters_0.ConvertOverworld = this.checkBox_6.Checked;
			this.convertParameters_0.ConvertNether = this.checkBox_5.Checked;
			this.convertParameters_0.ConvertTheEnd = this.checkBox_4.Checked;
			this.convertParameters_0.ProcessWorldFolder = this.textBox_0.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00021FAC File Offset: 0x000201AC
		private void method_0()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ConvertToConsole));
			this.BojEhkqxhb = new GroupBox();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.button_0 = new Button();
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.checkBox_2 = new CheckBox();
			this.button_4 = new Button();
			this.checkBox_3 = new CheckBox();
			this.groupBox_0 = new GroupBox();
			this.checkBox_4 = new CheckBox();
			this.checkBox_5 = new CheckBox();
			this.checkBox_6 = new CheckBox();
			this.BojEhkqxhb.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			base.SuspendLayout();
			this.BojEhkqxhb.Controls.Add(this.checkBox_0);
			this.BojEhkqxhb.Controls.Add(this.checkBox_1);
			this.BojEhkqxhb.Location = new Point(164, 67);
			this.BojEhkqxhb.Name = "groupBox2";
			this.BojEhkqxhb.Size = new Size(125, 101);
			this.BojEhkqxhb.TabIndex = 21;
			this.BojEhkqxhb.TabStop = false;
			this.BojEhkqxhb.Text = "Include";
			this.BojEhkqxhb.Visible = false;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(21, 28);
			this.checkBox_0.Name = "cbTileEntities";
			this.checkBox_0.Size = new Size(90, 17);
			this.checkBox_0.TabIndex = 7;
			this.checkBox_0.Text = "Block Entities";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(21, 56);
			this.checkBox_1.Name = "cbEntities";
			this.checkBox_1.Size = new Size(60, 17);
			this.checkBox_1.TabIndex = 8;
			this.checkBox_1.Text = "Entities";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.button_0.Image = (Image)componentResourceManager.GetObject("btnMCPCFolder.Image");
			this.button_0.Location = new Point(477, 29);
			this.button_0.Name = "btnMCPCFolder";
			this.button_0.Size = new Size(20, 20);
			this.button_0.TabIndex = 20;
			this.button_0.UseVisualStyleBackColor = true;
			this.textBox_0.Location = new Point(17, 29);
			this.textBox_0.Name = "tbMCPCFolder";
			this.textBox_0.Size = new Size(458, 20);
			this.textBox_0.TabIndex = 19;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(17, 16);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(71, 13);
			this.label_0.TabIndex = 18;
			this.label_0.Text = "Output Folder";
			this.button_1.Location = new Point(337, 189);
			this.button_1.Name = "btnConvert";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 17;
			this.button_1.Text = "Convert";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(423, 189);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 16;
			this.button_2.Text = "Cancel";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_3.Location = new Point(326, 145);
			this.button_3.Name = "btnBlock";
			this.button_3.Size = new Size(87, 23);
			this.button_3.TabIndex = 15;
			this.button_3.Text = "Blocks";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Visible = false;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Checked = true;
			this.checkBox_2.CheckState = CheckState.Checked;
			this.checkBox_2.Location = new Point(326, 127);
			this.checkBox_2.Name = "cbReplaceBlock";
			this.checkBox_2.Size = new Size(101, 17);
			this.checkBox_2.TabIndex = 14;
			this.checkBox_2.Text = "Replace Blocks";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_2.Visible = false;
			this.button_4.Location = new Point(326, 92);
			this.button_4.Name = "btnBiome";
			this.button_4.Size = new Size(87, 23);
			this.button_4.TabIndex = 13;
			this.button_4.Text = "Biomes";
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.Visible = false;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(326, 74);
			this.checkBox_3.Name = "cbReplaceBiome";
			this.checkBox_3.Size = new Size(103, 17);
			this.checkBox_3.TabIndex = 12;
			this.checkBox_3.Text = "Replace Biomes";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.checkBox_3.Visible = false;
			this.groupBox_0.Controls.Add(this.checkBox_4);
			this.groupBox_0.Controls.Add(this.checkBox_5);
			this.groupBox_0.Controls.Add(this.checkBox_6);
			this.groupBox_0.Location = new Point(17, 67);
			this.groupBox_0.Name = "groupBox1";
			this.groupBox_0.Size = new Size(125, 117);
			this.groupBox_0.TabIndex = 11;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Convert Region";
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Location = new Point(21, 81);
			this.checkBox_4.Name = "cbTheEnd";
			this.checkBox_4.Size = new Size(67, 17);
			this.checkBox_4.TabIndex = 2;
			this.checkBox_4.Text = "The End";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Location = new Point(21, 54);
			this.checkBox_5.Name = "cbNether";
			this.checkBox_5.Size = new Size(58, 17);
			this.checkBox_5.TabIndex = 1;
			this.checkBox_5.Text = "Nether";
			this.checkBox_5.UseVisualStyleBackColor = true;
			this.checkBox_6.AutoSize = true;
			this.checkBox_6.Checked = true;
			this.checkBox_6.CheckState = CheckState.Checked;
			this.checkBox_6.Location = new Point(21, 28);
			this.checkBox_6.Name = "cbOverworld";
			this.checkBox_6.Size = new Size(74, 17);
			this.checkBox_6.TabIndex = 0;
			this.checkBox_6.Text = "Overworld";
			this.checkBox_6.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(511, 224);
			base.Controls.Add(this.BojEhkqxhb);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.checkBox_2);
			base.Controls.Add(this.button_4);
			base.Controls.Add(this.checkBox_3);
			base.Controls.Add(this.groupBox_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConvertToConsole";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Convert To ";
			base.Load += this.ConvertToConsole_Load;
			this.BojEhkqxhb.ResumeLayout(false);
			this.BojEhkqxhb.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400028A RID: 650
		private ConvertParameters convertParameters_0;

		// Token: 0x0400028C RID: 652
		private GroupBox BojEhkqxhb;

		// Token: 0x0400028D RID: 653
		private CheckBox checkBox_0;

		// Token: 0x0400028E RID: 654
		private CheckBox checkBox_1;

		// Token: 0x0400028F RID: 655
		private Button button_0;

		// Token: 0x04000290 RID: 656
		private TextBox textBox_0;

		// Token: 0x04000291 RID: 657
		private Label label_0;

		// Token: 0x04000292 RID: 658
		private Button button_1;

		// Token: 0x04000293 RID: 659
		private Button button_2;

		// Token: 0x04000294 RID: 660
		private Button button_3;

		// Token: 0x04000295 RID: 661
		private CheckBox checkBox_2;

		// Token: 0x04000296 RID: 662
		private Button button_4;

		// Token: 0x04000297 RID: 663
		private CheckBox checkBox_3;

		// Token: 0x04000298 RID: 664
		private GroupBox groupBox_0;

		// Token: 0x04000299 RID: 665
		private CheckBox checkBox_4;

		// Token: 0x0400029A RID: 666
		private CheckBox checkBox_5;

		// Token: 0x0400029B RID: 667
		private CheckBox checkBox_6;
	}
}
