using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Full_UMT_Convertor.controls;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.Properties;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000074 RID: 116
	public partial class DimensionMap : Form
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000489 RID: 1161 RVA: 0x00025A40 File Offset: 0x00023C40
		// (remove) Token: 0x0600048A RID: 1162 RVA: 0x00025A78 File Offset: 0x00023C78
		public event EventHandler ChunkSelected
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00025AB0 File Offset: 0x00023CB0
		public DimensionMap(MainForm parentForm)
		{
			this.method_2();
			this.parentForm = parentForm;
			this.method_0();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00025B14 File Offset: 0x00023D14
		private void method_0()
		{
			/*
An exception occurred when decompiling this method (0600048C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.DimensionMap::method_0()

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

		// Token: 0x0600048D RID: 1165 RVA: 0x000049F3 File Offset: 0x00002BF3
		private void parentForm_ReDrawMap(object sender, EventArgs e)
		{
			this.mapDimension_0.method_28();
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00004A00 File Offset: 0x00002C00
		private void button_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600048E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.DimensionMap::button_0_Click(System.Object,System.EventArgs)

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

		// Token: 0x0600048F RID: 1167 RVA: 0x00004A0D File Offset: 0x00002C0D
		private void DimensionMap_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.parentForm.ChunkSelected -= this.parentForm_ChunkSelected;
			this.parentForm.ReloadMap -= this.button_0_Click;
			Working.mapIsOpen = false;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00025C38 File Offset: 0x00023E38
		private void DimensionMap_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000490)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.DimensionMap::DimensionMap_Load(System.Object,System.EventArgs)

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

		// Token: 0x06000491 RID: 1169 RVA: 0x00025C58 File Offset: 0x00023E58
		private void method_1()
		{
			string dimension = (string)this.comboBox_0.SelectedValue;
			DimensionWorkingData dimensionData = new DimensionWorkingData(dimension, Working.smethod_5());
			this.mapDimension_0.DimensionData = dimensionData;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00004A43 File Offset: 0x00002C43
		private void mapDimension_0_ChunkSelected(object sender, EventArgs e)
		{
			this.OnChunkSelected(this, e as );
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00025C90 File Offset: 0x00023E90
		internal void parentForm_ChunkSelected(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000493)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.DimensionMap::parentForm_ChunkSelected(System.Object,System.EventArgs)

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

		// Token: 0x06000494 RID: 1172 RVA: 0x00025DA4 File Offset: 0x00023FA4
		protected virtual void OnChunkSelected(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00004A52 File Offset: 0x00002C52
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1();
			this.mapDimension_0.Focus();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00025DC4 File Offset: 0x00023FC4
		private void button_1_Click(object sender, EventArgs e)
		{
			string string_ = "PNG Files (PNG Files (*.png)|*.png";
			string text = FileUtils.smethod_3("*.png", string_, null, null);
			if (!string.IsNullOrWhiteSpace(text))
			{
				try
				{
					string directoryName = Path.GetDirectoryName(text);
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					this.SaveImage(this.mapDimension_0.Maps[0], text);
					this.SaveImage(this.mapDimension_0.Maps[1], Path.Combine(directoryName, fileNameWithoutExtension + "_biome.png"));
					this.SaveImage(this.mapDimension_0.Maps[2], Path.Combine(directoryName, fileNameWithoutExtension + "_height.png"));
					this.SaveImage(this.mapDimension_0.Maps[3], Path.Combine(directoryName, fileNameWithoutExtension + "_hybrid.png"));
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unknown error has occurred." + Environment.NewLine + ex.Message, "Unknown Error");
				}
			}
			this.mapDimension_0.Focus();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00004A66 File Offset: 0x00002C66
		public void SaveImage(Bitmap mapImage, string imagePath)
		{
			if (!string.IsNullOrWhiteSpace(imagePath))
			{
				mapImage.Save(imagePath, ImageFormat.Png);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00025EC4 File Offset: 0x000240C4
		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.comboBox_1.SelectedValue is MapViewType)
				{
					MapViewType viewType = (MapViewType)this.comboBox_1.SelectedValue;
					this.mapDimension_0.ViewType = viewType;
					this.mapDimension_0.Focus();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00025F24 File Offset: 0x00024124
		private void checkBox_3_CheckedChanged(object sender, EventArgs e)
		{
			this.mapDimension_0.ShowPlayers = this.checkBox_3.Checked;
			this.mapDimension_0.Focus();
			Settings.Default.ShowPlayers = this.checkBox_3.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00025F74 File Offset: 0x00024174
		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			this.mapDimension_0.ShowChunkGrid = this.checkBox_0.Checked;
			this.mapDimension_0.Focus();
			Settings.Default.ShowChunkGrid = this.checkBox_0.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00025FC4 File Offset: 0x000241C4
		private void checkBox_1_CheckedChanged(object sender, EventArgs e)
		{
			this.mapDimension_0.ShowRegionGrid = this.checkBox_1.Checked;
			this.mapDimension_0.Focus();
			Settings.Default.ShowRegionGrid = this.checkBox_1.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00026014 File Offset: 0x00024214
		private void checkBox_2_CheckedChanged(object sender, EventArgs e)
		{
			this.mapDimension_0.ShowSearchResults = this.checkBox_2.Checked;
			this.mapDimension_0.Focus();
			Settings.Default.ShowSearchResults = this.checkBox_2.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00026064 File Offset: 0x00024264
		private void method_2()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DimensionMap));
			this.checkBox_0 = new CheckBox();
			this.comboBox_0 = new ComboBox();
			this.button_0 = new Button();
			this.comboBox_1 = new ComboBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.checkBox_3 = new CheckBox();
			this.mapDimension_0 = new MapDimension();
			base.SuspendLayout();
			this.checkBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Location = new Point(590, 103);
			this.checkBox_0.Name = "cbShowGrid";
			this.checkBox_0.Size = new Size(109, 17);
			this.checkBox_0.TabIndex = 1;
			this.checkBox_0.TabStop = false;
			this.checkBox_0.Text = "Show Chunk Grid";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(590, 18);
			this.comboBox_0.Name = "cbRegion";
			this.comboBox_0.Size = new Size(118, 21);
			this.comboBox_0.TabIndex = 5;
			this.comboBox_0.TabStop = false;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.button_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_0.Image = (Image)componentResourceManager.GetObject("btnExportImage.Image");
			this.button_0.Location = new Point(630, 181);
			this.button_0.Name = "btnExportImage";
			this.button_0.Size = new Size(38, 38);
			this.button_0.TabIndex = 7;
			this.button_0.TabStop = false;
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.comboBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(590, 45);
			this.comboBox_1.Name = "cbViewType";
			this.comboBox_1.Size = new Size(118, 21);
			this.comboBox_1.TabIndex = 8;
			this.comboBox_1.TabStop = false;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.checkBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(590, 126);
			this.checkBox_1.Name = "cbShowRegionGrid";
			this.checkBox_1.Size = new Size(112, 17);
			this.checkBox_1.TabIndex = 9;
			this.checkBox_1.TabStop = false;
			this.checkBox_1.Text = "Show Region Grid";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_1.CheckedChanged += this.checkBox_1_CheckedChanged;
			this.checkBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Location = new Point(589, 149);
			this.checkBox_2.Name = "cbShowSearchResults";
			this.checkBox_2.Size = new Size(128, 17);
			this.checkBox_2.TabIndex = 14;
			this.checkBox_2.TabStop = false;
			this.checkBox_2.Text = "Show Search Results";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_2.CheckedChanged += this.checkBox_2_CheckedChanged;
			this.button_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_1.Image = (Image)componentResourceManager.GetObject("button2.Image");
			this.button_1.Location = new Point(672, 181);
			this.button_1.Name = "button2";
			this.button_1.Size = new Size(38, 38);
			this.button_1.TabIndex = 16;
			this.button_1.TabStop = false;
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_2.Image = (Image)componentResourceManager.GetObject("button3.Image");
			this.button_2.Location = new Point(588, 181);
			this.button_2.Name = "button3";
			this.button_2.Size = new Size(38, 38);
			this.button_2.TabIndex = 17;
			this.button_2.TabStop = false;
			this.button_2.UseVisualStyleBackColor = true;
			this.checkBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(590, 80);
			this.checkBox_3.Name = "cbShowPlayers";
			this.checkBox_3.Size = new Size(90, 17);
			this.checkBox_3.TabIndex = 18;
			this.checkBox_3.TabStop = false;
			this.checkBox_3.Text = "Show Players";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.checkBox_3.CheckedChanged += this.checkBox_3_CheckedChanged;
			this.mapDimension_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.mapDimension_0.BorderStyle = BorderStyle.FixedSingle;
			this.mapDimension_0.ChunkEntries = null;
			this.mapDimension_0.DimensionData = null;
			this.mapDimension_0.Location = new Point(2, 3);
			this.mapDimension_0.Name = "mapDimension1";
			this.mapDimension_0.ShowChunkGrid = false;
			this.mapDimension_0.ShowPlayers = false;
			this.mapDimension_0.ShowRegionGrid = false;
			this.mapDimension_0.ShowSearchResults = false;
			this.mapDimension_0.Size = new Size(574, 598);
			this.mapDimension_0.TabIndex = 0;
			this.mapDimension_0.ViewType = MapViewType.BlockView;
			this.mapDimension_0.ChunkSelected += this.mapDimension_0_ChunkSelected;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(720, 602);
			base.Controls.Add(this.checkBox_3);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.checkBox_2);
			base.Controls.Add(this.checkBox_1);
			base.Controls.Add(this.comboBox_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.checkBox_0);
			base.Controls.Add(this.mapDimension_0);
			base.Name = "DimensionMap";
			this.Text = "World";
			base.FormClosed += this.DimensionMap_FormClosed;
			base.Load += this.DimensionMap_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002E5 RID: 741
		private Dictionary<MapViewType, string> dictionary_0 = new Dictionary<MapViewType, string>
		{
			{
				MapViewType.BlockView,
				"Block View"
			},
			{
				MapViewType.BiomeView,
				"Biome View"
			},
			{
				MapViewType.HeightView,
				"Height View"
			},
			{
				MapViewType.HybridView,
				"Hybrid View"
			}
		};

		// Token: 0x040002E6 RID: 742
		private EventHandler eventHandler_0;

		// Token: 0x040002E7 RID: 743
		private MainForm parentForm;

		// Token: 0x040002E9 RID: 745
		private MapDimension mapDimension_0;

		// Token: 0x040002EA RID: 746
		private CheckBox checkBox_0;

		// Token: 0x040002EB RID: 747
		private ComboBox comboBox_0;

		// Token: 0x040002EC RID: 748
		private Button button_0;

		// Token: 0x040002ED RID: 749
		private ComboBox comboBox_1;

		// Token: 0x040002EE RID: 750
		private CheckBox checkBox_1;

		// Token: 0x040002EF RID: 751
		private CheckBox checkBox_2;

		// Token: 0x040002F0 RID: 752
		private Button button_1;

		// Token: 0x040002F1 RID: 753
		private Button button_2;

		// Token: 0x040002F2 RID: 754
		private CheckBox checkBox_3;
	}
}
