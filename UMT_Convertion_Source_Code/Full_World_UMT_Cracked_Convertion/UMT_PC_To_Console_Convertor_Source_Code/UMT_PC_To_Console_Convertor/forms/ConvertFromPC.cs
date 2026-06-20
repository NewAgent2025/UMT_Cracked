using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.forms
{
	// Token: 0x02000058 RID: 88
	public partial class ConvertFromPC : Form
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000044D4 File Offset: 0x000026D4
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001B358 File Offset: 0x00019558
		public ConvertFromPC()
		{
			this.method_4();
			this.list_0 = Utils.ReadBiomeChanges(ConvertType.FROM_PC);
			this.list_1 = Utils.ReadBlockChanges(ConvertType.FROM_PC);
			this.textBox_0.Text = Utils.ReadMCPCFolder();
			this.checkBox_4.Checked = true;
			this.checkBox_5.Checked = true;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001B3B4 File Offset: 0x000195B4
		private void button_3_Click(object sender, EventArgs e)
		{
			if (!this.method_2(this.textBox_0.Text))
			{
				return;
			}
			this.convertParameters_0 = new ConvertParameters();
			this.convertParameters_0.ConvertOverworld = this.checkBox_0.Checked;
			this.convertParameters_0.ConvertNether = this.checkBox_1.Checked;
			this.convertParameters_0.ConvertTheEnd = this.iMpetgeHpr.Checked;
			this.convertParameters_0.ReplaceBiomes = this.checkBox_2.Checked;
			this.convertParameters_0.BiomeChanges = this.list_0;
			this.convertParameters_0.ReplaceBlocks = this.checkBox_3.Checked;
			this.convertParameters_0.BlockChanges = this.list_1;
			this.convertParameters_0.PCWorldFolder = FileUtils.CheckFolderSep(this.textBox_0.Text);
			this.convertParameters_0.ConvertTileEntities = this.checkBox_4.Checked;
			this.convertParameters_0.ConvertEntities = this.checkBox_5.Checked;
			this.convertParameters_0.DataValidation = this.checkBox_6.Checked;
			this.convertParameters_0.ConvertNewGen = this.checkBox_7.Checked;
			Utils.SaveMCPCFolder(this.convertParameters_0.PCWorldFolder);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001B500 File Offset: 0x00019700
		private string method_1(string string_0)
		{
			return FileUtils.smethod_4(this.textBox_0.Text, string_0);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001B520 File Offset: 0x00019720
		private bool method_2(string string_0)
		{
			bool flag = true;
			StringBuilder stringBuilder = new StringBuilder();
			string folderPath = FileUtils.CheckFolderSep(string_0) + "region";
			string folderPath2 = FileUtils.CheckFolderSep(string_0) + "DIM-1";
			string folderPath3 = FileUtils.CheckFolderSep(string_0) + "DIM1";
			if (!FileUtils.CheckFolderExists(string_0))
			{
				flag = false;
				stringBuilder.AppendLine("Save Folder not found.");
			}
			if (flag)
			{
				if (this.checkBox_0.Checked && !FileUtils.CheckFolderExists(folderPath))
				{
					stringBuilder.AppendLine("region folder not found.");
				}
				if (this.checkBox_1.Checked && !FileUtils.CheckFolderExists(folderPath2))
				{
					stringBuilder.AppendLine("DIM-1 folder not found.");
				}
				if (this.iMpetgeHpr.Checked && !FileUtils.CheckFolderExists(folderPath3))
				{
					stringBuilder.AppendLine("DIM1 folder not found.");
				}
			}
			if (stringBuilder.Length > 0)
			{
				base.Close();
			}
			return stringBuilder.Length == 0;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001B600 File Offset: 0x00019800
		private void method_3(string string_0, string string_1, StringBuilder stringBuilder_0)
		{
			foreach (string text in Constants.regionFileNames)
			{
				string path = FileUtils.CheckFolderSep(string_1) + text + ".mca";
				if (!File.Exists(path))
				{
					stringBuilder_0.AppendLine(string.Format("File {0}.mca was not found in the {1} folder.", text, string_0));
				}
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001B654 File Offset: 0x00019854
		private void ConvertFromPC_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060003A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.forms.ConvertFromPC::ConvertFromPC_Load(System.Object,System.EventArgs)

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

		// Token: 0x060003A5 RID: 933 RVA: 0x0001B66C File Offset: 0x0001986C
		private void method_4()
		{
			new ComponentResourceManager(typeof(ConvertFromPC));
			this.groupBox_0 = new GroupBox();
			this.iMpetgeHpr = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_0 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.checkBox_3 = new CheckBox();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.groupBox_1 = new GroupBox();
			this.checkBox_4 = new CheckBox();
			this.checkBox_5 = new CheckBox();
			this.checkBox_6 = new CheckBox();
			this.checkBox_7 = new CheckBox();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox_0.Controls.Add(this.iMpetgeHpr);
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Controls.Add(this.checkBox_0);
			this.groupBox_0.Location = new Point(12, 68);
			this.groupBox_0.Name = "groupBox1";
			this.groupBox_0.Size = new Size(125, 101);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Convert Region";
			this.iMpetgeHpr.AutoSize = true;
			this.iMpetgeHpr.Checked = true;
			this.iMpetgeHpr.CheckState = CheckState.Checked;
			this.iMpetgeHpr.Location = new Point(21, 76);
			this.iMpetgeHpr.Name = "cbTheEnd";
			this.iMpetgeHpr.Size = new Size(67, 17);
			this.iMpetgeHpr.TabIndex = 2;
			this.iMpetgeHpr.Text = "The End";
			this.iMpetgeHpr.UseVisualStyleBackColor = true;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(21, 49);
			this.checkBox_1.Name = "cbNether";
			this.checkBox_1.Size = new Size(58, 17);
			this.checkBox_1.TabIndex = 1;
			this.checkBox_1.Text = "Nether";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(21, 23);
			this.checkBox_0.Name = "cbOverworld";
			this.checkBox_0.Size = new Size(74, 17);
			this.checkBox_0.TabIndex = 0;
			this.checkBox_0.Text = "Overworld";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Location = new Point(321, 75);
			this.checkBox_2.Name = "cbReplaceBiome";
			this.checkBox_2.Size = new Size(103, 17);
			this.checkBox_2.TabIndex = 1;
			this.checkBox_2.Text = "Replace Biomes";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(321, 128);
			this.checkBox_3.Name = "cbReplaceBlock";
			this.checkBox_3.Size = new Size(101, 17);
			this.checkBox_3.TabIndex = 3;
			this.checkBox_3.Text = "Replace Blocks";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(418, 207);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "Cancel";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_3.Location = new Point(332, 207);
			this.button_3.Name = "btnConvert";
			this.button_3.Size = new Size(75, 23);
			this.button_3.TabIndex = 6;
			this.button_3.Text = "Convert";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += this.button_3_Click;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 17);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(97, 13);
			this.label_0.TabIndex = 7;
			this.label_0.Text = "MC PC world folder";
			this.textBox_0.Location = new Point(12, 30);
			this.textBox_0.Name = "tbMCPCFolder";
			this.textBox_0.Size = new Size(458, 20);
			this.textBox_0.TabIndex = 8;
			this.groupBox_1.Controls.Add(this.checkBox_4);
			this.groupBox_1.Controls.Add(this.checkBox_5);
			this.groupBox_1.Location = new Point(159, 68);
			this.groupBox_1.Name = "groupBox2";
			this.groupBox_1.Size = new Size(125, 101);
			this.groupBox_1.TabIndex = 10;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Include";
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Checked = true;
			this.checkBox_4.CheckState = CheckState.Checked;
			this.checkBox_4.Location = new Point(21, 23);
			this.checkBox_4.Name = "cbTileEntities";
			this.checkBox_4.Size = new Size(90, 17);
			this.checkBox_4.TabIndex = 7;
			this.checkBox_4.Text = "Block Entities";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Checked = true;
			this.checkBox_5.CheckState = CheckState.Checked;
			this.checkBox_5.Location = new Point(21, 51);
			this.checkBox_5.Name = "cbEntities";
			this.checkBox_5.Size = new Size(60, 17);
			this.checkBox_5.TabIndex = 8;
			this.checkBox_5.Text = "Entities";
			this.checkBox_5.UseVisualStyleBackColor = true;
			this.checkBox_6.AutoSize = true;
			this.checkBox_6.Checked = true;
			this.checkBox_6.CheckState = CheckState.Checked;
			this.checkBox_6.Location = new Point(15, 205);
			this.checkBox_6.Name = "cbDataValidation";
			this.checkBox_6.Size = new Size(146, 17);
			this.checkBox_6.TabIndex = 11;
			this.checkBox_6.Text = "Use Advanced Validation";
			this.checkBox_6.UseVisualStyleBackColor = true;
			this.checkBox_7.AutoSize = true;
			this.checkBox_7.Location = new Point(15, 179);
			this.checkBox_7.Name = "cbCnvrtNewGen";
			this.checkBox_7.Size = new Size(171, 17);
			this.checkBox_7.TabIndex = 12;
			this.checkBox_7.Text = "Convert for XBOX ONE or PS4";
			this.checkBox_7.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button_3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(504, 242);
			base.Controls.Add(this.checkBox_7);
			base.Controls.Add(this.checkBox_6);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.checkBox_3);
			base.Controls.Add(this.checkBox_2);
			base.Controls.Add(this.groupBox_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConvertFromPC";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Convert From PC";
			base.Load += this.ConvertFromPC_Load;
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000044FB File Offset: 0x000026FB
		public bool RunAutomated(string outputFolder)
		{
			this.textBox_0.Text = outputFolder;
			this.button_3_Click(null, EventArgs.Empty);
			return base.DialogResult == DialogResult.OK;
		}

		// Token: 0x040001EA RID: 490
		private ConvertParameters convertParameters_0;

		// Token: 0x040001EB RID: 491
		private List<BiomeChange> list_0;

		// Token: 0x040001EC RID: 492
		private List<BlockChange> list_1;

		// Token: 0x040001EE RID: 494
		private GroupBox groupBox_0;

		// Token: 0x040001EF RID: 495
		private CheckBox checkBox_0;

		// Token: 0x040001F0 RID: 496
		private CheckBox iMpetgeHpr;

		// Token: 0x040001F1 RID: 497
		private CheckBox checkBox_1;

		// Token: 0x040001F2 RID: 498
		private CheckBox checkBox_2;

		// Token: 0x040001F3 RID: 499
		private Button button_0;

		// Token: 0x040001F4 RID: 500
		private Button button_1;

		// Token: 0x040001F5 RID: 501
		private CheckBox checkBox_3;

		// Token: 0x040001F6 RID: 502
		private Button button_2;

		// Token: 0x040001F7 RID: 503
		private Button button_3;

		// Token: 0x040001F8 RID: 504
		private Label label_0;

		// Token: 0x040001F9 RID: 505
		private TextBox textBox_0;

		// Token: 0x040001FA RID: 506
		private Button button_4;

		// Token: 0x040001FB RID: 507
		private GroupBox groupBox_1;

		// Token: 0x040001FC RID: 508
		private CheckBox checkBox_4;

		// Token: 0x040001FD RID: 509
		private CheckBox checkBox_5;

		// Token: 0x040001FE RID: 510
		private CheckBox checkBox_6;

		// Token: 0x040001FF RID: 511
		private CheckBox checkBox_7;
	}
}
