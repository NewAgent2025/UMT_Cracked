using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Substrate.Data;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000031 RID: 49
	public class MapItem : UserControl
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000036A5 File Offset: 0x000018A5
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000036AD File Offset: 0x000018AD
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000036B6 File Offset: 0x000018B6
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000036BE File Offset: 0x000018BE
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000036C7 File Offset: 0x000018C7
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000036CF File Offset: 0x000018CF
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000036D8 File Offset: 0x000018D8
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000036E0 File Offset: 0x000018E0
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

		// Token: 0x060001F9 RID: 505 RVA: 0x000036E9 File Offset: 0x000018E9
		public MapItem(MCMap mcmap, mapItemSelected)
		{
			this.method_0();
			base.BorderStyle = BorderStyle.None;
			this.map_0 = mcmap.Map;
			this.mcmap = mcmap;
			this.mapItemSelected = mapItemSelected;
			this.LoadMapFile(mcmap.Name);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00011C10 File Offset: 0x0000FE10
		public void LoadMapFile(string name)
		{
			MapConverter mapConverter = new MapConverter();
			this.bitmap_0 = mapConverter.MapToBitmap(this.map_0);
			this.pictureBox_0.Image = this.bitmap_0;
			this.label_0.Text = name;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00003724 File Offset: 0x00001924
		private void MapItem_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapItem::MapItem_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003724 File Offset: 0x00001924
		private void pictureBox_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapItem::pictureBox_0_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00003724 File Offset: 0x00001924
		private void label_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapItem::label_0_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003739 File Offset: 0x00001939
		public void SetActive(bool isActive)
		{
			this.bool_0 = isActive;
			this.Refresh();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00011C54 File Offset: 0x0000FE54
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

		// Token: 0x06000200 RID: 512 RVA: 0x00003748 File Offset: 0x00001948
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00011CA8 File Offset: 0x0000FEA8
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

		// Token: 0x0400011B RID: 283
		private bool bool_0;

		// Token: 0x0400011C RID: 284
		private byte[] byte_0;

		// Token: 0x0400011D RID: 285
		private Bitmap bitmap_0;

		// Token: 0x0400011E RID: 286
		private Map map_0;

		// Token: 0x0400011F RID: 287
		private MCMap mcmap;

		// Token: 0x04000120 RID: 288
		private  mapItemSelected;

		// Token: 0x04000121 RID: 289
		private IContainer icontainer_0;

		// Token: 0x04000122 RID: 290
		private PictureBox pictureBox_0;

		// Token: 0x04000123 RID: 291
		private Label label_0;
	}
}
