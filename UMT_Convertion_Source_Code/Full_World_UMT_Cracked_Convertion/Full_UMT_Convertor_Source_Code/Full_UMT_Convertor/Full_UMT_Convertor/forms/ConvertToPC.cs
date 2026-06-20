using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Full_UMT_Convertor.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000072 RID: 114
	public partial class ConvertToPC : Form
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00004975 File Offset: 0x00002B75
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000229C0 File Offset: 0x00020BC0
		public ConvertToPC()
		{
			this.convertParameters_0 = new ConvertParameters();
			this.method_3();
			this.list_0 = Utils.ReadBiomeChanges(ConvertType.TO_PC);
			this.list_1 = Utils.ReadBlockChanges(ConvertType.TO_PC);
			this.textBox_0.Text = Utils.ReadConvertToPCFolder();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void button_0_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void button_1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00022A0C File Offset: 0x00020C0C
		private void button_3_Click(object sender, EventArgs e)
		{
			if (!this.method_0(this.textBox_0.Text))
			{
				return;
			}
			this.convertParameters_0.ConvertOverworld = this.checkBox_0.Checked;
			this.convertParameters_0.ConvertNether = this.checkBox_2.Checked;
			this.convertParameters_0.ConvertTheEnd = this.checkBox_1.Checked;
			this.convertParameters_0.ReplaceBiomes = this.checkBox_3.Checked;
			this.convertParameters_0.BiomeChanges = this.list_0;
			this.convertParameters_0.ReplaceBlocks = this.checkBox_4.Checked;
			this.convertParameters_0.BlockChanges = this.list_1;
			this.convertParameters_0.ProcessWorldFolder = FileUtils.CheckFolderSep(this.textBox_0.Text);
			this.convertParameters_0.ConvertTileEntities = this.checkBox_5.Checked;
			this.convertParameters_0.ConvertEntities = this.checkBox_6.Checked;
			this.convertParameters_0.UpdateLevelData = this.checkBox_9.Checked;
			this.convertParameters_0.ModifiedLevelNode = this.tagNodeCompound_0;
			if (this.radioButton_1.Checked)
			{
				this.convertParameters_0.ConvertInto = ConvertIntoType.EmptyWorld;
			}
			else if (this.zgiUqPuiST.Checked)
			{
				this.convertParameters_0.ConvertInto = ConvertIntoType.EmptyDimension;
			}
			else if (this.radioButton_0.Checked)
			{
				this.convertParameters_0.ConvertInto = ConvertIntoType.OccupiedDimension;
			}
			if (this.checkBox_7.Checked)
			{
				this.convertParameters_0.UseConvertOffsets = true;
				this.convertParameters_0.XRegionOffset = (int)this.numericUpDown_1.Value;
				this.convertParameters_0.ZRegionOffset = (int)this.numericUpDown_0.Value;
			}
			this.convertParameters_0.ConvertToFormat = (this.radioButton_5.Checked ? ConversionFormat.Aquatic : ConversionFormat.PreAquatic);
			this.convertParameters_0.SetPlayPosition = this.checkBox_10.Checked;
			Utils.SaveConvertToPCFolder(this.convertParameters_0.ProcessWorldFolder);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00022C18 File Offset: 0x00020E18
		private bool method_0(string string_0)
		{
			bool flag = true;
			if (string.IsNullOrWhiteSpace(string_0))
			{
				flag = false;
			}
			if (!flag)
			{
				MessageBox.Show("Verify MC PC World Save folder has been correctly set.", "Verify MC World Save Folder");
			}
			return flag;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00022C48 File Offset: 0x00020E48
		private void button_4_Click(object sender, EventArgs e)
		{
			string text = this.method_1();
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.textBox_0.Text = FileUtils.CheckFolderSep(text);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00022C78 File Offset: 0x00020E78
		private string method_1()
		{
			string result = string.Empty;
			string string_ = "Select MC PC World Folder";
			if (Directory.Exists(Utils.smethod_1()))
			{
				MCPCFolder mcpcfolder = new MCPCFolder(GEnum0.Destination);
				if (mcpcfolder.ShowDialog(this) == DialogResult.OK)
				{
					if (mcpcfolder.method_0() == (Enum1)0)
					{
						result = mcpcfolder.PCWorldFolder;
					}
					else
					{
						result = this.method_2(string_);
					}
				}
			}
			else
			{
				result = this.method_2(string_);
			}
			return result;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000497D File Offset: 0x00002B7D
		private string method_2(string string_0)
		{
			return FileUtils.smethod_4(Utils.smethod_1(), string_0);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void ConvertToPC_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00022CD4 File Offset: 0x00020ED4
		private void button_5_Click(object sender, EventArgs e)
		{
			PCConvertOffsetDisplay pcconvertOffsetDisplay = new PCConvertOffsetDisplay(FileUtils.CheckFolderSep(this.textBox_0.Text), (int)this.numericUpDown_1.Value, (int)this.numericUpDown_0.Value);
			if (pcconvertOffsetDisplay.ShowDialog(this) == DialogResult.OK)
			{
				this.numericUpDown_1.Value = pcconvertOffsetDisplay.RxOffset;
				this.numericUpDown_0.Value = pcconvertOffsetDisplay.RzOffset;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00022D50 File Offset: 0x00020F50
		private void button_6_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000474)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertToPC::button_6_Click(System.Object,System.EventArgs)

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

		// Token: 0x06000475 RID: 1141 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void bikUsHinDo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00022DEC File Offset: 0x00020FEC
		private void method_3()
		{
			new ComponentResourceManager(typeof(ConvertToPC));
			this.groupBox_0 = new GroupBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.checkBox_0 = new CheckBox();
			this.checkBox_3 = new CheckBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.checkBox_4 = new CheckBox();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.checkBox_5 = new CheckBox();
			this.checkBox_6 = new CheckBox();
			this.groupBox_1 = new GroupBox();
			this.button_4 = new Button();
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.groupBox_2 = new GroupBox();
			this.button_5 = new Button();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.numericUpDown_1 = new NumericUpDown();
			this.checkBox_7 = new CheckBox();
			this.groupBox_3 = new GroupBox();
			this.radioButton_0 = new RadioButton();
			this.zgiUqPuiST = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.checkBox_8 = new CheckBox();
			this.groupBox_4 = new GroupBox();
			this.button_6 = new Button();
			this.checkBox_9 = new CheckBox();
			this.radioButton_2 = new RadioButton();
			this.radioButton_3 = new RadioButton();
			this.groupBox_5 = new GroupBox();
			this.radioButton_4 = new RadioButton();
			this.radioButton_5 = new RadioButton();
			this.groupBox_6 = new GroupBox();
			this.checkBox_10 = new CheckBox();
			this.bikUsHinDo = new Button();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.groupBox_2.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			this.groupBox_3.SuspendLayout();
			this.groupBox_4.SuspendLayout();
			this.groupBox_5.SuspendLayout();
			this.groupBox_6.SuspendLayout();
			base.SuspendLayout();
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Controls.Add(this.checkBox_2);
			this.groupBox_0.Controls.Add(this.checkBox_0);
			this.groupBox_0.Location = new Point(14, 66);
			this.groupBox_0.Name = "groupBox1";
			this.groupBox_0.Size = new Size(125, 106);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Convert Dimension";
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(21, 81);
			this.checkBox_1.Name = "cbTheEnd";
			this.checkBox_1.Size = new Size(67, 17);
			this.checkBox_1.TabIndex = 2;
			this.checkBox_1.Text = "The End";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Checked = true;
			this.checkBox_2.CheckState = CheckState.Checked;
			this.checkBox_2.Location = new Point(21, 54);
			this.checkBox_2.Name = "cbNether";
			this.checkBox_2.Size = new Size(58, 17);
			this.checkBox_2.TabIndex = 1;
			this.checkBox_2.Text = "Nether";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(21, 28);
			this.checkBox_0.Name = "cbOverworld";
			this.checkBox_0.Size = new Size(74, 17);
			this.checkBox_0.TabIndex = 0;
			this.checkBox_0.Text = "Overworld";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(314, 73);
			this.checkBox_3.Name = "cbReplaceBiome";
			this.checkBox_3.Size = new Size(103, 17);
			this.checkBox_3.TabIndex = 1;
			this.checkBox_3.Text = "Replace Biomes";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.button_0.Location = new Point(314, 91);
			this.button_0.Name = "btnBiome";
			this.button_0.Size = new Size(101, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Biomes";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(314, 149);
			this.button_1.Name = "btnBlock";
			this.button_1.Size = new Size(101, 23);
			this.button_1.TabIndex = 4;
			this.button_1.Text = "Blocks";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Location = new Point(314, 131);
			this.checkBox_4.Name = "cbReplaceBlock";
			this.checkBox_4.Size = new Size(101, 17);
			this.checkBox_4.TabIndex = 3;
			this.checkBox_4.Text = "Replace Blocks";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(417, 401);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "Cancel";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_3.Location = new Point(330, 400);
			this.button_3.Name = "btnConvert";
			this.button_3.Size = new Size(75, 23);
			this.button_3.TabIndex = 6;
			this.button_3.Text = "Convert";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += this.button_3_Click;
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Checked = true;
			this.checkBox_5.CheckState = CheckState.Checked;
			this.checkBox_5.Location = new Point(21, 28);
			this.checkBox_5.Name = "cbTileEntities";
			this.checkBox_5.Size = new Size(90, 17);
			this.checkBox_5.TabIndex = 7;
			this.checkBox_5.Text = "Block Entities";
			this.checkBox_5.UseVisualStyleBackColor = true;
			this.checkBox_6.AutoSize = true;
			this.checkBox_6.Checked = true;
			this.checkBox_6.CheckState = CheckState.Checked;
			this.checkBox_6.Location = new Point(21, 54);
			this.checkBox_6.Name = "cbEntities";
			this.checkBox_6.Size = new Size(60, 17);
			this.checkBox_6.TabIndex = 8;
			this.checkBox_6.Text = "Entities";
			this.checkBox_6.UseVisualStyleBackColor = true;
			this.groupBox_1.Controls.Add(this.checkBox_5);
			this.groupBox_1.Controls.Add(this.checkBox_6);
			this.groupBox_1.Location = new Point(158, 66);
			this.groupBox_1.Name = "groupBox2";
			this.groupBox_1.Size = new Size(125, 106);
			this.groupBox_1.TabIndex = 9;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Include";
			this.button_4.Location = new Point(472, 29);
			this.button_4.Name = "btnMCPCFolder";
			this.button_4.Size = new Size(20, 20);
			this.button_4.TabIndex = 12;
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.Click += this.button_4_Click;
			this.textBox_0.Location = new Point(12, 29);
			this.textBox_0.Name = "tbMCPCFolder";
			this.textBox_0.Size = new Size(458, 20);
			this.textBox_0.TabIndex = 11;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 16);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(134, 13);
			this.label_0.TabIndex = 10;
			this.label_0.Text = "Minecraft Java world folder";
			this.groupBox_2.Controls.Add(this.button_5);
			this.groupBox_2.Controls.Add(this.label_1);
			this.groupBox_2.Controls.Add(this.label_2);
			this.groupBox_2.Controls.Add(this.numericUpDown_0);
			this.groupBox_2.Controls.Add(this.numericUpDown_1);
			this.groupBox_2.Controls.Add(this.checkBox_7);
			this.groupBox_2.Location = new Point(207, 193);
			this.groupBox_2.Name = "groupBox4";
			this.groupBox_2.Size = new Size(183, 94);
			this.groupBox_2.TabIndex = 18;
			this.groupBox_2.TabStop = false;
			this.groupBox_2.Text = "Convert Offset";
			this.button_5.Location = new Point(104, 13);
			this.button_5.Name = "btnOffsets";
			this.button_5.Size = new Size(73, 23);
			this.button_5.TabIndex = 5;
			this.button_5.Text = "Offsets UI";
			this.button_5.UseVisualStyleBackColor = true;
			this.button_5.Click += this.button_5_Click;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(75, 66);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(82, 13);
			this.label_1.TabIndex = 4;
			this.label_1.Text = "Z Region Offset";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(75, 42);
			this.label_2.Name = "label2";
			this.label_2.Size = new Size(82, 13);
			this.label_2.TabIndex = 3;
			this.label_2.Text = "X Region Offset";
			this.numericUpDown_0.Location = new Point(25, 64);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 10000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Minimum = new decimal(new int[]
			{
				10000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_0.Name = "nudZRegionOffset";
			this.numericUpDown_0.Size = new Size(43, 20);
			this.numericUpDown_0.TabIndex = 2;
			this.numericUpDown_1.Location = new Point(25, 39);
			NumericUpDown numericUpDown2 = this.numericUpDown_1;
			int[] array2 = new int[4];
			array2[0] = 10000;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDown_1.Minimum = new decimal(new int[]
			{
				10000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_1.Name = "nudXRegionOffset";
			this.numericUpDown_1.Size = new Size(43, 20);
			this.numericUpDown_1.TabIndex = 1;
			this.checkBox_7.AutoSize = true;
			this.checkBox_7.Location = new Point(25, 20);
			this.checkBox_7.Name = "cbUseConversionOffsets";
			this.checkBox_7.Size = new Size(81, 17);
			this.checkBox_7.TabIndex = 0;
			this.checkBox_7.Text = "Use Offsets";
			this.checkBox_7.UseVisualStyleBackColor = true;
			this.groupBox_3.Controls.Add(this.radioButton_0);
			this.groupBox_3.Controls.Add(this.zgiUqPuiST);
			this.groupBox_3.Controls.Add(this.radioButton_1);
			this.groupBox_3.Location = new Point(14, 193);
			this.groupBox_3.Name = "groupBox5";
			this.groupBox_3.Size = new Size(171, 94);
			this.groupBox_3.TabIndex = 17;
			this.groupBox_3.TabStop = false;
			this.groupBox_3.Text = "Convert into";
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(21, 65);
			this.radioButton_0.Name = "rbPopulatedRegion";
			this.radioButton_0.Size = new Size(123, 17);
			this.radioButton_0.TabIndex = 17;
			this.radioButton_0.Text = "Occupied Dimension";
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.zgiUqPuiST.AutoSize = true;
			this.zgiUqPuiST.Checked = true;
			this.zgiUqPuiST.Location = new Point(21, 42);
			this.zgiUqPuiST.Name = "rbEmptyRegion";
			this.zgiUqPuiST.Size = new Size(106, 17);
			this.zgiUqPuiST.TabIndex = 16;
			this.zgiUqPuiST.TabStop = true;
			this.zgiUqPuiST.Text = "Empty Dimension";
			this.zgiUqPuiST.UseVisualStyleBackColor = true;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Location = new Point(21, 19);
			this.radioButton_1.Name = "rbEmptyWorld";
			this.radioButton_1.Size = new Size(85, 17);
			this.radioButton_1.TabIndex = 15;
			this.radioButton_1.Text = "Empty World";
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.checkBox_8.AutoSize = true;
			this.checkBox_8.Location = new Point(14, 193);
			this.checkBox_8.Name = "cbItemIdAsString";
			this.checkBox_8.Size = new Size(137, 17);
			this.checkBox_8.TabIndex = 16;
			this.checkBox_8.Text = "Use Strings for Item IDs";
			this.checkBox_8.UseVisualStyleBackColor = true;
			this.checkBox_8.Visible = false;
			this.groupBox_4.Controls.Add(this.bikUsHinDo);
			this.groupBox_4.Controls.Add(this.checkBox_10);
			this.groupBox_4.Controls.Add(this.button_6);
			this.groupBox_4.Controls.Add(this.checkBox_9);
			this.groupBox_4.Location = new Point(14, 312);
			this.groupBox_4.Name = "groupBox7";
			this.groupBox_4.Size = new Size(269, 82);
			this.groupBox_4.TabIndex = 20;
			this.groupBox_4.TabStop = false;
			this.groupBox_4.Text = "Update";
			this.button_6.Location = new Point(19, 39);
			this.button_6.Name = "btnEditLevelDat";
			this.button_6.Size = new Size(69, 23);
			this.button_6.TabIndex = 8;
			this.button_6.Text = "level.dat";
			this.button_6.UseVisualStyleBackColor = true;
			this.button_6.Click += this.button_6_Click;
			this.checkBox_9.AutoSize = true;
			this.checkBox_9.Checked = true;
			this.checkBox_9.CheckState = CheckState.Checked;
			this.checkBox_9.Location = new Point(21, 21);
			this.checkBox_9.Name = "cbUpdateLevelDat";
			this.checkBox_9.Size = new Size(70, 17);
			this.checkBox_9.TabIndex = 7;
			this.checkBox_9.Text = "Level.dat";
			this.checkBox_9.UseVisualStyleBackColor = true;
			this.radioButton_2.AutoSize = true;
			this.radioButton_2.Checked = true;
			this.radioButton_2.Location = new Point(14, 19);
			this.radioButton_2.Name = "rbConvertFast";
			this.radioButton_2.Size = new Size(158, 17);
			this.radioButton_2.TabIndex = 0;
			this.radioButton_2.TabStop = true;
			this.radioButton_2.Text = "Fast: Requires more memory";
			this.radioButton_2.UseVisualStyleBackColor = true;
			this.radioButton_3.AutoSize = true;
			this.radioButton_3.Location = new Point(14, 42);
			this.radioButton_3.Name = "rbConvertSafe";
			this.radioButton_3.Size = new Size(155, 17);
			this.radioButton_3.TabIndex = 1;
			this.radioButton_3.Text = "Safe: Requires less memory";
			this.radioButton_3.UseVisualStyleBackColor = true;
			this.groupBox_5.Controls.Add(this.radioButton_3);
			this.groupBox_5.Controls.Add(this.radioButton_2);
			this.groupBox_5.Location = new Point(247, 532);
			this.groupBox_5.Name = "groupBox3";
			this.groupBox_5.Size = new Size(199, 74);
			this.groupBox_5.TabIndex = 13;
			this.groupBox_5.TabStop = false;
			this.groupBox_5.Text = "Conversion Type";
			this.groupBox_5.Visible = false;
			this.radioButton_4.AutoSize = true;
			this.radioButton_4.Location = new Point(21, 42);
			this.radioButton_4.Name = "rbPreAquaticFormat";
			this.radioButton_4.Size = new Size(81, 17);
			this.radioButton_4.TabIndex = 15;
			this.radioButton_4.Text = "1.12 Format";
			this.radioButton_4.UseVisualStyleBackColor = true;
			this.radioButton_5.AutoSize = true;
			this.radioButton_5.Checked = true;
			this.radioButton_5.Location = new Point(21, 19);
			this.radioButton_5.Name = "rbAquaticFormat";
			this.radioButton_5.Size = new Size(81, 17);
			this.radioButton_5.TabIndex = 16;
			this.radioButton_5.TabStop = true;
			this.radioButton_5.Text = "1.13 Format";
			this.radioButton_5.UseVisualStyleBackColor = true;
			this.groupBox_6.Controls.Add(this.radioButton_5);
			this.groupBox_6.Controls.Add(this.radioButton_4);
			this.groupBox_6.Location = new Point(55, 532);
			this.groupBox_6.Name = "groupBox6";
			this.groupBox_6.Size = new Size(170, 74);
			this.groupBox_6.TabIndex = 19;
			this.groupBox_6.TabStop = false;
			this.groupBox_6.Text = "Convert to";
			this.groupBox_6.Visible = false;
			this.checkBox_10.AutoSize = true;
			this.checkBox_10.Location = new Point(123, 21);
			this.checkBox_10.Name = "cbSetPlayerPos";
			this.checkBox_10.Size = new Size(76, 17);
			this.checkBox_10.TabIndex = 9;
			this.checkBox_10.Text = "Player Pos";
			this.checkBox_10.UseVisualStyleBackColor = true;
			this.bikUsHinDo.Location = new Point(123, 39);
			this.bikUsHinDo.Name = "btnSetPlayerPosition";
			this.bikUsHinDo.Size = new Size(69, 23);
			this.bikUsHinDo.TabIndex = 10;
			this.bikUsHinDo.Text = "Position";
			this.bikUsHinDo.UseVisualStyleBackColor = true;
			this.bikUsHinDo.Click += this.bikUsHinDo_Click;
			base.AcceptButton = this.button_3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(510, 441);
			base.Controls.Add(this.groupBox_4);
			base.Controls.Add(this.groupBox_6);
			base.Controls.Add(this.groupBox_2);
			base.Controls.Add(this.groupBox_3);
			base.Controls.Add(this.checkBox_8);
			base.Controls.Add(this.groupBox_5);
			base.Controls.Add(this.button_4);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.checkBox_4);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.checkBox_3);
			base.Controls.Add(this.groupBox_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConvertToPC";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Convert Console To Java";
			base.Load += this.ConvertToPC_Load;
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			this.groupBox_2.ResumeLayout(false);
			this.groupBox_2.PerformLayout();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			this.groupBox_3.ResumeLayout(false);
			this.groupBox_3.PerformLayout();
			this.groupBox_4.ResumeLayout(false);
			this.groupBox_4.PerformLayout();
			this.groupBox_5.ResumeLayout(false);
			this.groupBox_5.PerformLayout();
			this.groupBox_6.ResumeLayout(false);
			this.groupBox_6.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000049A9 File Offset: 0x00002BA9
		public bool RunAutomated(string outputFolder)
		{
			this.textBox_0.Text = outputFolder;
			this.button_3_Click(null, EventArgs.Empty);
			return base.DialogResult == DialogResult.OK;
		}

		// Token: 0x0400029C RID: 668
		private TagNodeCompound tagNodeCompound_0;

		// Token: 0x0400029D RID: 669
		private ConvertParameters convertParameters_0;

		// Token: 0x0400029E RID: 670
		private List<BiomeChange> list_0;

		// Token: 0x0400029F RID: 671
		private List<BlockChange> list_1;

		// Token: 0x040002A1 RID: 673
		private GroupBox groupBox_0;

		// Token: 0x040002A2 RID: 674
		private CheckBox checkBox_0;

		// Token: 0x040002A3 RID: 675
		private CheckBox checkBox_1;

		// Token: 0x040002A4 RID: 676
		private CheckBox checkBox_2;

		// Token: 0x040002A5 RID: 677
		private CheckBox checkBox_3;

		// Token: 0x040002A6 RID: 678
		private Button button_0;

		// Token: 0x040002A7 RID: 679
		private Button button_1;

		// Token: 0x040002A8 RID: 680
		private CheckBox checkBox_4;

		// Token: 0x040002A9 RID: 681
		private Button button_2;

		// Token: 0x040002AA RID: 682
		private Button button_3;

		// Token: 0x040002AB RID: 683
		private CheckBox checkBox_5;

		// Token: 0x040002AC RID: 684
		private CheckBox checkBox_6;

		// Token: 0x040002AD RID: 685
		private GroupBox groupBox_1;

		// Token: 0x040002AE RID: 686
		private Button button_4;

		// Token: 0x040002AF RID: 687
		private TextBox textBox_0;

		// Token: 0x040002B0 RID: 688
		private Label label_0;

		// Token: 0x040002B1 RID: 689
		private GroupBox groupBox_2;

		// Token: 0x040002B2 RID: 690
		private Button button_5;

		// Token: 0x040002B3 RID: 691
		private Label label_1;

		// Token: 0x040002B4 RID: 692
		private Label label_2;

		// Token: 0x040002B5 RID: 693
		private NumericUpDown numericUpDown_0;

		// Token: 0x040002B6 RID: 694
		private NumericUpDown numericUpDown_1;

		// Token: 0x040002B7 RID: 695
		private CheckBox checkBox_7;

		// Token: 0x040002B8 RID: 696
		private GroupBox groupBox_3;

		// Token: 0x040002B9 RID: 697
		private RadioButton radioButton_0;

		// Token: 0x040002BA RID: 698
		private RadioButton zgiUqPuiST;

		// Token: 0x040002BB RID: 699
		private RadioButton radioButton_1;

		// Token: 0x040002BC RID: 700
		private CheckBox checkBox_8;

		// Token: 0x040002BD RID: 701
		private GroupBox groupBox_4;

		// Token: 0x040002BE RID: 702
		private CheckBox checkBox_9;

		// Token: 0x040002BF RID: 703
		private Button button_6;

		// Token: 0x040002C0 RID: 704
		private RadioButton radioButton_2;

		// Token: 0x040002C1 RID: 705
		private RadioButton radioButton_3;

		// Token: 0x040002C2 RID: 706
		private GroupBox groupBox_5;

		// Token: 0x040002C3 RID: 707
		private RadioButton radioButton_4;

		// Token: 0x040002C4 RID: 708
		private RadioButton radioButton_5;

		// Token: 0x040002C5 RID: 709
		private GroupBox groupBox_6;

		// Token: 0x040002C6 RID: 710
		private Button bikUsHinDo;

		// Token: 0x040002C7 RID: 711
		private CheckBox checkBox_10;
	}
}
