using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Substrate.Data;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200004B RID: 75
	public class MapItem : UserControl
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00003C91 File Offset: 0x00001E91
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00003C99 File Offset: 0x00001E99
		public MCMap MapData
		{
			get
			{
				return this.mcmap;
			}
			set
			{
				this.mcmap = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00003CA2 File Offset: 0x00001EA2
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00003CAA File Offset: 0x00001EAA
		public byte[] Colors
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00003CB3 File Offset: 0x00001EB3
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00003CBB File Offset: 0x00001EBB
		public Bitmap MapImage
		{
			get
			{
				return this.bitmap_0;
			}
			set
			{
				this.bitmap_0 = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00003CC4 File Offset: 0x00001EC4
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003CCC File Offset: 0x00001ECC
		public Map Map
		{
			get
			{
				return this.map_0;
			}
			set
			{
				this.map_0 = value;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003CD5 File Offset: 0x00001ED5
		public MapItem(MCMap mcmap, mapItemSelected)
		{
			this.method_0();
			base.BorderStyle = BorderStyle.None;
			this.map_0 = mcmap.Map;
			this.mcmap = mcmap;
			this.mapItemSelected = mapItemSelected;
			this.LoadMapFile(mcmap.Name);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001942C File Offset: 0x0001762C
		public void LoadMapFile(string name)
		{
			MapConverter mapConverter = new MapConverter();
			this.bitmap_0 = mapConverter.MapToBitmap(this.map_0);
			this.pictureBox_0.Image = this.bitmap_0;
			this.label_0.Text = name;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003D10 File Offset: 0x00001F10
		private void MapItem_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060002DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapItem::MapItem_Click(System.Object,System.EventArgs)

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

		// Token: 0x060002DC RID: 732 RVA: 0x00003D10 File Offset: 0x00001F10
		private void pictureBox_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060002DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapItem::pictureBox_0_Click(System.Object,System.EventArgs)

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

		// Token: 0x060002DD RID: 733 RVA: 0x00003D10 File Offset: 0x00001F10
		private void label_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060002DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapItem::label_0_Click(System.Object,System.EventArgs)

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

		// Token: 0x060002DE RID: 734 RVA: 0x00003D25 File Offset: 0x00001F25
		public void SetActive(bool isActive)
		{
			this.bool_0 = isActive;
			this.Refresh();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00019470 File Offset: 0x00017670
		private void MapItem_Paint(object sender, PaintEventArgs e)
		{
			Pen pen;
			if (this.bool_0)
			{
				pen = new Pen(Color.Red);
			}
			else
			{
				pen = new Pen(Color.Black);
			}
			Graphics graphics = e.Graphics;
			graphics.DrawRectangle(pen, new Rectangle(0, 0, base.Width - 1, base.Height - 1));
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003D34 File Offset: 0x00001F34
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000194C4 File Offset: 0x000176C4
		private void method_0()
		{
			this.pictureBox_0 = new PictureBox();
			this.label_0 = new Label();
			((ISupportInitialize)this.pictureBox_0).BeginInit();
			base.SuspendLayout();
			this.pictureBox_0.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBox_0.Location = new Point(4, 4);
			this.pictureBox_0.Name = "pictureBox1";
			this.pictureBox_0.Size = new Size(128, 128);
			this.pictureBox_0.TabIndex = 0;
			this.pictureBox_0.TabStop = false;
			this.pictureBox_0.Click += this.pictureBox_0_Click;
			this.label_0.Location = new Point(4, 131);
			this.label_0.Name = "lblName";
			this.label_0.Size = new Size(128, 18);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Name";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.label_0.Click += this.label_0_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.pictureBox_0);
			base.Controls.Add(this.label_0);
			base.Name = "MapItem";
			base.Size = new Size(136, 156);
			base.Click += this.MapItem_Click;
			base.Paint += this.MapItem_Paint;
			((ISupportInitialize)this.pictureBox_0).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001C8 RID: 456
		private bool bool_0;

		// Token: 0x040001C9 RID: 457
		private byte[] byte_0;

		// Token: 0x040001CA RID: 458
		private Bitmap bitmap_0;

		// Token: 0x040001CB RID: 459
		private Map map_0;

		// Token: 0x040001CC RID: 460
		private MCMap mcmap;

		// Token: 0x040001CD RID: 461
		private  mapItemSelected;

		// Token: 0x040001CE RID: 462
		private IContainer icontainer_0;

		// Token: 0x040001CF RID: 463
		private PictureBox pictureBox_0;

		// Token: 0x040001D0 RID: 464
		private Label label_0;
	}
}
