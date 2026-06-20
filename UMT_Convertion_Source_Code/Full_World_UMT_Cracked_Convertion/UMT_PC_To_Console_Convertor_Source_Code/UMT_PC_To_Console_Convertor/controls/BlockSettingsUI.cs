using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000022 RID: 34
	public class BlockSettingsUI : UserControl
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000F0 RID: 240 RVA: 0x0000B914 File Offset: 0x00009B14
		// (remove) Token: 0x060000F1 RID: 241 RVA: 0x0000B94C File Offset: 0x00009B4C
		public event EventHandler BlockChanged
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

		// Token: 0x060000F2 RID: 242 RVA: 0x00002CAB File Offset: 0x00000EAB
		public BlockSettingsUI()
		{
			this.xPspUwCsuU();
			this.method_0();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002CBF File Offset: 0x00000EBF
		private void method_0()
		{
			if (Class29.Blocks == null)
			{
				return;
			}
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "IdName";
			this.comboBox_0.DataSource = Class29.Blocks.ToList<Class28>();
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002CFE File Offset: 0x00000EFE
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002D06 File Offset: 0x00000F06
		internal Block Block
		{
			get
			{
				return this.block_0;
			}
			set
			{
				this.block_0 = value;
				this.UpdateSettingsUI();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002D15 File Offset: 0x00000F15
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002D22 File Offset: 0x00000F22
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Bindable(true)]
		public override string Text
		{
			get
			{
				return this.label_1.Text;
			}
			set
			{
				this.label_1.Text = value;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000B984 File Offset: 0x00009B84
		public void UpdateSettingsUI()
		{
			this.UpdateBlockImage();
			this.comboBox_0.SelectedValue = this.block_0.Id;
			this.textBox_0.Text = this.block_0.Data.ToString();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		public void UpdateBlockImage()
		{
			Image image = Class4.smethod_7(this.block_0.Id, this.block_0.Data);
			this.pictureBox_0.Image = image;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000BA08 File Offset: 0x00009C08
		private void method_1()
		{
			int data = 0;
			int.TryParse(this.textBox_0.Text, out data);
			this.block_0.Data = data;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002D30 File Offset: 0x00000F30
		private void textBox_0_KeyUp(object sender, KeyEventArgs e)
		{
			/*
An exception occurred when decompiling this method (060000FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.BlockSettingsUI::textBox_0_KeyUp(System.Object,System.Windows.Forms.KeyEventArgs)

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

		// Token: 0x060000FC RID: 252 RVA: 0x0000BA38 File Offset: 0x00009C38
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060000FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.BlockSettingsUI::comboBox_0_SelectedIndexChanged(System.Object,System.EventArgs)

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

		// Token: 0x060000FD RID: 253 RVA: 0x0000BA88 File Offset: 0x00009C88
		protected virtual void OnBlockChanged(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002D55 File Offset: 0x00000F55
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		private void xPspUwCsuU()
		{
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.pictureBox_0 = new PictureBox();
			this.comboBox_0 = new ComboBox();
			this.label_1 = new Label();
			((ISupportInitialize)this.pictureBox_0).BeginInit();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(33, 45);
			this.textBox_0.Name = "tbData";
			this.textBox_0.Size = new Size(42, 20);
			this.textBox_0.TabIndex = 10;
			this.textBox_0.KeyUp += this.textBox_0_KeyUp;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(1, 49);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(30, 13);
			this.label_0.TabIndex = 9;
			this.label_0.Text = "Data";
			this.pictureBox_0.Location = new Point(3, 19);
			this.pictureBox_0.Name = "pbBlockImage";
			this.pictureBox_0.Size = new Size(25, 25);
			this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox_0.TabIndex = 7;
			this.pictureBox_0.TabStop = false;
			this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(33, 20);
			this.comboBox_0.Name = "cbBlock";
			this.comboBox_0.Size = new Size(114, 21);
			this.comboBox_0.TabIndex = 12;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(3, 2);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(0, 13);
			this.label_1.TabIndex = 13;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.pictureBox_0);
			base.Name = "BlockSettingsUI";
			base.Size = new Size(150, 68);
			((ISupportInitialize)this.pictureBox_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000094 RID: 148
		private EventHandler eventHandler_0;

		// Token: 0x04000095 RID: 149
		private Block block_0;

		// Token: 0x04000096 RID: 150
		private IContainer icontainer_0;

		// Token: 0x04000097 RID: 151
		private TextBox textBox_0;

		// Token: 0x04000098 RID: 152
		private Label label_0;

		// Token: 0x04000099 RID: 153
		private PictureBox pictureBox_0;

		// Token: 0x0400009A RID: 154
		private ComboBox comboBox_0;

		// Token: 0x0400009B RID: 155
		private Label label_1;
	}
}
