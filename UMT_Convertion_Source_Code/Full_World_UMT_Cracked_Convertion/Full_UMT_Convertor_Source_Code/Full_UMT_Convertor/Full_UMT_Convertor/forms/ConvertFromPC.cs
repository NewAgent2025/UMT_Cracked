using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Full_UMT_Convertor.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000073 RID: 115
	public partial class ConvertFromPC : Form
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000049CC File Offset: 0x00002BCC
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00024630 File Offset: 0x00022830
		public ConvertFromPC()
		{
			this.method_4();
			this.list_0 = Utils.ReadBiomeChanges(ConvertType.FROM_PC);
			this.list_1 = Utils.ReadBlockChanges(ConvertType.FROM_PC);
			this.textBox_0.Text = Utils.ReadMCPCFolder();
			this.checkBox_7.Checked = false;
			this.checkBox_5.Checked = true;
			this.checkBox_6.Checked = true;
			this.checkBox_9.Checked = true;
			this.PopulateEntityLists();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000246C0 File Offset: 0x000228C0
		public void PopulateEntityLists()
		{
			EntityLookup entityLookup = new EntityLookup();
			foreach (EntityItem entityItem in entityLookup.ConsoleEntities.Values)
			{
				this.list_2.Add(entityItem.ConsoleName);
			}
			TileEntityLookup tileEntityLookup = new TileEntityLookup();
			foreach (TileEntityItem tileEntityItem in tileEntityLookup.ConsoleEntities.Values)
			{
				this.list_3.Add(tileEntityItem.ConsoleName);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00024784 File Offset: 0x00022984
		private void button_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600047C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertFromPC::button_0_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000247C0 File Offset: 0x000229C0
		private void button_1_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600047D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertFromPC::button_1_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000247FC File Offset: 0x000229FC
		private void button_3_Click(object sender, EventArgs e)
		{
			if (!this.method_2(FileUtils.CheckFolderSep(this.textBox_0.Text)))
			{
				return;
			}
			this.convertParameters_0 = new ConvertParameters();
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
			this.convertParameters_0.DataValidation = this.checkBox_7.Checked;
			this.convertParameters_0.ConvertNewGen = this.checkBox_8.Checked;
			this.convertParameters_0.ItemIdString = this.checkBox_9.Checked;
			this.convertParameters_0.EntityConversionList = this.list_2;
			this.convertParameters_0.BlockEntityConversionList = this.list_3;
			this.convertParameters_0.RetainSpawnerSettings = this.checkBox_10.Checked;
			Utils.SaveMCPCFolder(this.convertParameters_0.ProcessWorldFolder);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0002499C File Offset: 0x00022B9C
		private void button_4_Click(object sender, EventArgs e)
		{
			string text = this.method_0();
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.textBox_0.Text = FileUtils.CheckFolderSep(text);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000249CC File Offset: 0x00022BCC
		private string method_0()
		{
			string result = string.Empty;
			string string_ = "Select MC PC World Folder";
			if (Directory.Exists(Utils.smethod_0()))
			{
				MCPCFolder mcpcfolder = new MCPCFolder(GEnum0.Source);
				DialogResult dialogResult = mcpcfolder.ShowDialog(this);
				if (dialogResult == DialogResult.OK)
				{
					if (mcpcfolder.method_0() == (Enum1)0)
					{
						result = mcpcfolder.PCWorldFolder;
					}
					else
					{
						result = this.method_1(string_);
					}
				}
			}
			else
			{
				result = this.method_1(string_);
			}
			return result;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00024A2C File Offset: 0x00022C2C
		private string method_1(string string_0)
		{
			return FileUtils.smethod_4(this.textBox_0.Text, string_0);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00024A4C File Offset: 0x00022C4C
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
				if (this.checkBox_2.Checked && !FileUtils.CheckFolderExists(folderPath2))
				{
					stringBuilder.AppendLine("DIM-1 folder not found.");
				}
				if (this.checkBox_1.Checked && !FileUtils.CheckFolderExists(folderPath3))
				{
					stringBuilder.AppendLine("DIM1 folder not found.");
				}
			}
			if (stringBuilder.Length > 0)
			{
				MessageBox.Show("Verify MC World Save folder has been correctly set." + Environment.NewLine + stringBuilder.ToString(), "Verify MC World Folder");
			}
			return stringBuilder.Length == 0;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00024B50 File Offset: 0x00022D50
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

		// Token: 0x06000484 RID: 1156 RVA: 0x00021F14 File Offset: 0x00020114
		private void ConvertFromPC_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000484)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertFromPC::ConvertFromPC_Load(System.Object,System.EventArgs)

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

		// Token: 0x06000485 RID: 1157 RVA: 0x00024BA4 File Offset: 0x00022DA4
		private void button_5_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000485)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertFromPC::button_5_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00024BD8 File Offset: 0x00022DD8
		private void button_6_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000486)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertFromPC::button_6_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00024C0C File Offset: 0x00022E0C
		private void method_4()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ConvertFromPC));
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
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.button_4 = new Button();
			this.groupBox_1 = new GroupBox();
			this.button_5 = new Button();
			this.button_6 = new Button();
			this.checkBox_5 = new CheckBox();
			this.checkBox_6 = new CheckBox();
			this.checkBox_7 = new CheckBox();
			this.checkBox_8 = new CheckBox();
			this.checkBox_9 = new CheckBox();
			this.checkBox_10 = new CheckBox();
			this.groupBox_2 = new GroupBox();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.groupBox_2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Controls.Add(this.checkBox_2);
			this.groupBox_0.Controls.Add(this.checkBox_0);
			this.groupBox_0.Location = new Point(12, 68);
			this.groupBox_0.Name = "groupBox1";
			this.groupBox_0.Size = new Size(125, 130);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Convert Region";
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(21, 76);
			this.checkBox_1.Name = "cbTheEnd";
			this.checkBox_1.Size = new Size(67, 17);
			this.checkBox_1.TabIndex = 2;
			this.checkBox_1.Text = "The End";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Location = new Point(21, 49);
			this.checkBox_2.Name = "cbNether";
			this.checkBox_2.Size = new Size(58, 17);
			this.checkBox_2.TabIndex = 1;
			this.checkBox_2.Text = "Nether";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(21, 23);
			this.checkBox_0.Name = "cbOverworld";
			this.checkBox_0.Size = new Size(74, 17);
			this.checkBox_0.TabIndex = 0;
			this.checkBox_0.Text = "Overworld";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(20, 22);
			this.checkBox_3.Name = "cbReplaceBiome";
			this.checkBox_3.Size = new Size(103, 17);
			this.checkBox_3.TabIndex = 1;
			this.checkBox_3.Text = "Replace Biomes";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.button_0.Location = new Point(20, 40);
			this.button_0.Name = "btnBiome";
			this.button_0.Size = new Size(87, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Biomes";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(20, 93);
			this.button_1.Name = "btnBlock";
			this.button_1.Size = new Size(87, 23);
			this.button_1.TabIndex = 4;
			this.button_1.Text = "Blocks";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Checked = true;
			this.checkBox_4.CheckState = CheckState.Checked;
			this.checkBox_4.Location = new Point(20, 75);
			this.checkBox_4.Name = "cbReplaceBlock";
			this.checkBox_4.Size = new Size(101, 17);
			this.checkBox_4.TabIndex = 3;
			this.checkBox_4.Text = "Replace Blocks";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(417, 327);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "Cancel";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_3.Location = new Point(331, 327);
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
			this.button_4.Image = (Image)componentResourceManager.GetObject("btnMCPCFolder.Image");
			this.button_4.Location = new Point(472, 30);
			this.button_4.Name = "btnMCPCFolder";
			this.button_4.Size = new Size(20, 20);
			this.button_4.TabIndex = 9;
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.Click += this.button_4_Click;
			this.groupBox_1.Controls.Add(this.button_5);
			this.groupBox_1.Controls.Add(this.button_6);
			this.groupBox_1.Controls.Add(this.checkBox_5);
			this.groupBox_1.Controls.Add(this.checkBox_6);
			this.groupBox_1.Location = new Point(159, 68);
			this.groupBox_1.Name = "groupBox2";
			this.groupBox_1.Size = new Size(125, 130);
			this.groupBox_1.TabIndex = 10;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Include";
			this.button_5.Location = new Point(21, 93);
			this.button_5.Name = "btnEntityList";
			this.button_5.Size = new Size(75, 23);
			this.button_5.TabIndex = 10;
			this.button_5.Text = "Change List";
			this.button_5.UseVisualStyleBackColor = true;
			this.button_5.Click += this.button_5_Click;
			this.button_6.Location = new Point(21, 40);
			this.button_6.Name = "btnBlockEntityList";
			this.button_6.Size = new Size(75, 23);
			this.button_6.TabIndex = 9;
			this.button_6.Text = "Change List";
			this.button_6.UseVisualStyleBackColor = true;
			this.button_6.Click += this.button_6_Click;
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Checked = true;
			this.checkBox_5.CheckState = CheckState.Checked;
			this.checkBox_5.Location = new Point(21, 22);
			this.checkBox_5.Name = "cbTileEntities";
			this.checkBox_5.Size = new Size(90, 17);
			this.checkBox_5.TabIndex = 7;
			this.checkBox_5.Text = "Block Entities";
			this.checkBox_5.UseVisualStyleBackColor = true;
			this.checkBox_6.AutoSize = true;
			this.checkBox_6.Checked = true;
			this.checkBox_6.CheckState = CheckState.Checked;
			this.checkBox_6.Location = new Point(21, 75);
			this.checkBox_6.Name = "cbEntities";
			this.checkBox_6.Size = new Size(60, 17);
			this.checkBox_6.TabIndex = 8;
			this.checkBox_6.Text = "Entities";
			this.checkBox_6.UseVisualStyleBackColor = true;
			this.checkBox_7.AutoSize = true;
			this.checkBox_7.Location = new Point(15, 250);
			this.checkBox_7.Name = "cbDataValidation";
			this.checkBox_7.Size = new Size(146, 17);
			this.checkBox_7.TabIndex = 11;
			this.checkBox_7.Text = "Use Advanced Validation";
			this.checkBox_7.UseVisualStyleBackColor = true;
			this.checkBox_8.AutoSize = true;
			this.checkBox_8.Location = new Point(15, 224);
			this.checkBox_8.Name = "cbCnvrtNewGen";
			this.checkBox_8.Size = new Size(171, 17);
			this.checkBox_8.TabIndex = 12;
			this.checkBox_8.Text = "Convert for XBOX ONE or PS4";
			this.checkBox_8.UseVisualStyleBackColor = true;
			this.checkBox_9.AutoSize = true;
			this.checkBox_9.Location = new Point(15, 275);
			this.checkBox_9.Name = "cbItemIdAsString";
			this.checkBox_9.Size = new Size(137, 17);
			this.checkBox_9.TabIndex = 13;
			this.checkBox_9.Text = "Use Strings for Item IDs";
			this.checkBox_9.UseVisualStyleBackColor = true;
			this.checkBox_10.AutoSize = true;
			this.checkBox_10.Location = new Point(15, 300);
			this.checkBox_10.Name = "cbRetainSpawnerSettings";
			this.checkBox_10.Size = new Size(143, 17);
			this.checkBox_10.TabIndex = 14;
			this.checkBox_10.Text = "Retain Spawner Settings";
			this.checkBox_10.UseVisualStyleBackColor = true;
			this.groupBox_2.Controls.Add(this.button_1);
			this.groupBox_2.Controls.Add(this.checkBox_3);
			this.groupBox_2.Controls.Add(this.button_0);
			this.groupBox_2.Controls.Add(this.checkBox_4);
			this.groupBox_2.Location = new Point(309, 68);
			this.groupBox_2.Name = "groupBox3";
			this.groupBox_2.Size = new Size(145, 130);
			this.groupBox_2.TabIndex = 15;
			this.groupBox_2.TabStop = false;
			this.groupBox_2.Text = "Replace";
			base.AcceptButton = this.button_3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(504, 360);
			base.Controls.Add(this.groupBox_2);
			base.Controls.Add(this.checkBox_10);
			base.Controls.Add(this.checkBox_9);
			base.Controls.Add(this.checkBox_8);
			base.Controls.Add(this.checkBox_7);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.button_4);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.button_2);
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
			this.groupBox_2.ResumeLayout(false);
			this.groupBox_2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002C8 RID: 712
		private ConvertParameters convertParameters_0;

		// Token: 0x040002C9 RID: 713
		private List<BiomeChange> list_0;

		// Token: 0x040002CA RID: 714
		private List<BlockChange> list_1;

		// Token: 0x040002CB RID: 715
		private List<string> list_2 = new List<string>();

		// Token: 0x040002CC RID: 716
		private List<string> list_3 = new List<string>();

		// Token: 0x040002CE RID: 718
		private GroupBox groupBox_0;

		// Token: 0x040002CF RID: 719
		private CheckBox checkBox_0;

		// Token: 0x040002D0 RID: 720
		private CheckBox checkBox_1;

		// Token: 0x040002D1 RID: 721
		private CheckBox checkBox_2;

		// Token: 0x040002D2 RID: 722
		private CheckBox checkBox_3;

		// Token: 0x040002D3 RID: 723
		private Button button_0;

		// Token: 0x040002D4 RID: 724
		private Button button_1;

		// Token: 0x040002D5 RID: 725
		private CheckBox checkBox_4;

		// Token: 0x040002D6 RID: 726
		private Button button_2;

		// Token: 0x040002D7 RID: 727
		private Button button_3;

		// Token: 0x040002D8 RID: 728
		private Label label_0;

		// Token: 0x040002D9 RID: 729
		private TextBox textBox_0;

		// Token: 0x040002DA RID: 730
		private Button button_4;

		// Token: 0x040002DB RID: 731
		private GroupBox groupBox_1;

		// Token: 0x040002DC RID: 732
		private CheckBox checkBox_5;

		// Token: 0x040002DD RID: 733
		private CheckBox checkBox_6;

		// Token: 0x040002DE RID: 734
		private CheckBox checkBox_7;

		// Token: 0x040002DF RID: 735
		private CheckBox checkBox_8;

		// Token: 0x040002E0 RID: 736
		private CheckBox checkBox_9;

		// Token: 0x040002E1 RID: 737
		private CheckBox checkBox_10;

		// Token: 0x040002E2 RID: 738
		private Button button_5;

		// Token: 0x040002E3 RID: 739
		private Button button_6;

		// Token: 0x040002E4 RID: 740
		private GroupBox groupBox_2;
	}
}
