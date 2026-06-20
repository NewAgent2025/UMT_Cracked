using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Full_UMT_Convertor.Events;
using Full_UMT_Convertor.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Save_Manager.model;

namespace Full_UMT_Convertor.Controls
{
	// Token: 0x0200001C RID: 28
	public class PEWorldList : UserControl
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000D9 RID: 217 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		// (remove) Token: 0x060000DA RID: 218 RVA: 0x0000CA30 File Offset: 0x0000AC30
		public event EventHandler WorldSelected
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

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000DB RID: 219 RVA: 0x0000CA68 File Offset: 0x0000AC68
		// (remove) Token: 0x060000DC RID: 220 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		public event EventHandler CancelClick
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000DD RID: 221 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		// (remove) Token: 0x060000DE RID: 222 RVA: 0x0000CB10 File Offset: 0x0000AD10
		public event EventHandler FolderClick
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002B81 File Offset: 0x00000D81
		public PEWorldList()
		{
			this.method_3();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002B8F File Offset: 0x00000D8F
		public void SetDisplayType(GEnum0 displayType)
		{
			this.button_2.Visible = (displayType == GEnum0.Destination);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002BA6 File Offset: 0x00000DA6
		public void LoadWorldList()
		{
			this.LoadPEWorldList();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000CB48 File Offset: 0x0000AD48
		public void LoadPEWorldList()
		{
			/*
An exception occurred when decompiling this method (060000E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.Controls.PEWorldList::LoadPEWorldList()

 ---> System.Exception: Inconsistent stack size at IL_4B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002BAE File Offset: 0x00000DAE
		public void LoadWPDWorldList()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private void method_0(peworldUI_0, PEWorldFolder peworldFolder_0)
		{
			this.OnWorldSelected(this, new PEWorldEventArgs(peworldFolder_0));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private void method_1(peworldUI_0, PEWorldFolder peworldFolder_0)
		{
			this.OnWorldSelected(this, new PEWorldEventArgs(peworldFolder_0));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		protected virtual void OnWorldSelected(object sender, PEWorldEventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		protected virtual void OnCancelClicked(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000CC10 File Offset: 0x0000AE10
		protected virtual void OnFolderClicked(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_2;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002BBF File Offset: 0x00000DBF
		private void button_0_Click(object sender, EventArgs e)
		{
			this.OnFolderClicked(this, new EventArgs());
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002BCD File Offset: 0x00000DCD
		private void button_1_Click(object sender, EventArgs e)
		{
			this.OnCancelClicked(this, new EventArgs());
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000CC30 File Offset: 0x0000AE30
		private void button_2_Click(object sender, EventArgs e)
		{
			FolderNameEntry folderNameEntry = new FolderNameEntry();
			DialogResult dialogResult = folderNameEntry.ShowDialog(this);
			if (dialogResult == DialogResult.OK)
			{
				string path = Utils.smethod_2() + "\\" + folderNameEntry.FolderName;
				this.OnWorldSelected(this, new PEWorldEventArgs(new PEWorldFolder
				{
					Name = folderNameEntry.FolderName,
					Path = path
				}));
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002BDB File Offset: 0x00000DDB
		private void flowLayoutPanel_0_MouseEnter(object sender, EventArgs e)
		{
			this.flowLayoutPanel_0.Focus();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002BDB File Offset: 0x00000DDB
		internal void method_2()
		{
			this.flowLayoutPanel_0.Focus();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002BE9 File Offset: 0x00000DE9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		private void method_3()
		{
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_0 = new Label();
			this.button_2 = new Button();
			this.flowLayoutPanel_0 = new FlowLayoutPanel();
			base.SuspendLayout();
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_0.Location = new Point(5, 417);
			this.button_0.Name = "btnPCFolder";
			this.button_0.Size = new Size(90, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Select Folder";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.Location = new Point(312, 417);
			this.button_1.Name = "btnCancelPCWorld";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Cancel";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.label_0.AutoSize = true;
			this.label_0.Font = new Font("Arial Rounded MT Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(5, 5);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(83, 17);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "PE Worlds";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_2.Location = new Point(101, 417);
			this.button_2.Name = "btnNewFolder";
			this.button_2.Size = new Size(90, 23);
			this.button_2.TabIndex = 4;
			this.button_2.Text = "New World";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.flowLayoutPanel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.flowLayoutPanel_0.AutoScroll = true;
			this.flowLayoutPanel_0.BackColor = Color.White;
			this.flowLayoutPanel_0.BorderStyle = BorderStyle.FixedSingle;
			this.flowLayoutPanel_0.Location = new Point(0, 25);
			this.flowLayoutPanel_0.Name = "worldPackages";
			this.flowLayoutPanel_0.Padding = new Padding(0, 3, 0, 0);
			this.flowLayoutPanel_0.Size = new Size(392, 386);
			this.flowLayoutPanel_0.TabIndex = 5;
			this.flowLayoutPanel_0.MouseEnter += this.flowLayoutPanel_0_MouseEnter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.flowLayoutPanel_0);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Name = "PEWorldList";
			base.Size = new Size(392, 444);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007A RID: 122
		private bool bool_0;

		// Token: 0x0400007B RID: 123
		private EventHandler eventHandler_0;

		// Token: 0x0400007C RID: 124
		private EventHandler eventHandler_1;

		// Token: 0x0400007D RID: 125
		private EventHandler eventHandler_2;

		// Token: 0x0400007E RID: 126
		private IContainer icontainer_0;

		// Token: 0x0400007F RID: 127
		private Button button_0;

		// Token: 0x04000080 RID: 128
		private Button button_1;

		// Token: 0x04000081 RID: 129
		private Label label_0;

		// Token: 0x04000082 RID: 130
		private Button button_2;

		// Token: 0x04000083 RID: 131
		private FlowLayoutPanel flowLayoutPanel_0;
	}
}
