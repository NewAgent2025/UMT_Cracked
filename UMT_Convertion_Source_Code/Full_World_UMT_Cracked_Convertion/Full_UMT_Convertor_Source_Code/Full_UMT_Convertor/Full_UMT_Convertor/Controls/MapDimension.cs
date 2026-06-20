using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000043 RID: 67
	public class MapDimension : UserControl
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600024A RID: 586 RVA: 0x00015B10 File Offset: 0x00013D10
		// (remove) Token: 0x0600024B RID: 587 RVA: 0x00015B48 File Offset: 0x00013D48
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

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600024C RID: 588 RVA: 0x00015B80 File Offset: 0x00013D80
		// (remove) Token: 0x0600024D RID: 589 RVA: 0x00015BB8 File Offset: 0x00013DB8
		public event EventHandler MapUpdated
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

		// Token: 0x0600024E RID: 590 RVA: 0x00015BF0 File Offset: 0x00013DF0
		public void SetChunkSelected(int x, int y)
		{
			Graphics graphics_ = this.panel_0.CreateGraphics();
			if (this.bool_3)
			{
				this.gooOpAxYw8(this.int_5, this.int_6, graphics_);
			}
			this.bool_3 = true;
			this.int_5 = x;
			this.int_6 = y;
			this.method_21(this.int_5, this.int_6, this.solidBrush_1, graphics_);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003796 File Offset: 0x00001996
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000379E File Offset: 0x0000199E
		public MapViewType ViewType
		{
			get
			{
				return this.mapViewType_0;
			}
			set
			{
				this.mapViewType_0 = value;
				this.panel_0.Invalidate();
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000037B2 File Offset: 0x000019B2
		public Bitmap[] Maps
		{
			get
			{
				return (Bitmap[])this.image_0;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00015C54 File Offset: 0x00013E54
		public MapDimension()
		{
			/*
An exception occurred when decompiling this method (06000252)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapDimension::.ctor()

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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000037BF File Offset: 0x000019BF
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000037C7 File Offset: 0x000019C7
		public bool ShowPlayers
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
				this.panel_0.Invalidate();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000037DB File Offset: 0x000019DB
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000037E3 File Offset: 0x000019E3
		public bool ShowChunkGrid
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				this.panel_0.Invalidate();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000037F7 File Offset: 0x000019F7
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000037FF File Offset: 0x000019FF
		public bool ShowRegionGrid
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
				this.panel_0.Invalidate();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00003813 File Offset: 0x00001A13
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000381B File Offset: 0x00001A1B
		public bool ShowSearchResults
		{
			get
			{
				return this.PabIeZfsam;
			}
			set
			{
				this.PabIeZfsam = value;
				this.panel_0.Invalidate();
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000382F File Offset: 0x00001A2F
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00015E7C File Offset: 0x0001407C
		public DimensionWorkingData DimensionData
		{
			get
			{
				return this.dimensionWorkingData_0;
			}
			set
			{
				this.dimensionWorkingData_0 = value;
				this.list_0 = null;
				this.label_0.Text = "";
				this.int_3 = 0;
				this.int_4 = 0;
				this.image_0 = null;
				this.bool_3 = false;
				if (value != null && !this.backgroundWorker_0.IsBusy)
				{
					string text = Constants.dimensionNames[value.Dimension];
					this.label_0.Text = text;
					this.int_0 = this.method_0();
					this.method_8(this.dimensionWorkingData_0);
					this.method_23(this.dimensionWorkingData_0);
				}
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00015F14 File Offset: 0x00014114
		private int method_0()
		{
			int result = 27;
			if (this.dimensionWorkingData_0 != null)
			{
				if (this.dimensionWorkingData_0.Dimension == "region")
				{
					result = 27;
				}
				else if (this.dimensionWorkingData_0.Dimension == "DIM-1")
				{
					result = 9;
				}
				else if (this.dimensionWorkingData_0.Dimension == "DIM1")
				{
					result = 32;
				}
			}
			return result;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00003837 File Offset: 0x00001A37
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000383F File Offset: 0x00001A3F
		public List<[]> ChunkEntries
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00003624 File Offset: 0x00001824
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00015F80 File Offset: 0x00014180
		protected void OnPanelPaint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			this.method_4(graphics);
			this.method_1(graphics);
			this.method_2(graphics);
			this.method_5(graphics);
			if (this.bool_3)
			{
				this.method_21(this.int_5, this.int_6, this.solidBrush_1, graphics);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00015FD4 File Offset: 0x000141D4
		private void method_1(Graphics graphics_0)
		{
			/*
An exception occurred when decompiling this method (06000262)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapDimension::method_1(System.Drawing.Graphics)

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

		// Token: 0x06000263 RID: 611 RVA: 0x000161F0 File Offset: 0x000143F0
		private void method_2(Graphics graphics_0)
		{
			/*
An exception occurred when decompiling this method (06000263)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapDimension::method_2(System.Drawing.Graphics)

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

		// Token: 0x06000264 RID: 612 RVA: 0x00016400 File Offset: 0x00014600
		private int method_3(string string_0)
		{
			/*
An exception occurred when decompiling this method (06000264)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Full_UMT_Convertor.controls.MapDimension::method_3(System.String)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001655C File Offset: 0x0001475C
		private void method_4(Graphics graphics_0)
		{
			if (this.image_0 != null)
			{
				graphics_0.InterpolationMode = InterpolationMode.NearestNeighbor;
				graphics_0.SmoothingMode = SmoothingMode.None;
				graphics_0.PixelOffsetMode = PixelOffsetMode.Half;
				Rectangle r = new Rectangle(80, 80, 864, 864);
				if (this.dimensionWorkingData_0.Dimension == "DIM-1")
				{
					r = new Rectangle(368, 368, 288, 288);
				}
				else if (this.dimensionWorkingData_0.Dimension == "DIM1")
				{
					r = new Rectangle(0, 0, 1024, 1024);
				}
				RectangleF destRect = new RectangleF(1f, 1f, (float)(this.panel_0.Width - 2), (float)(this.panel_0.Height - 2));
				graphics_0.DrawImage(this.image_0[(int)this.mapViewType_0], destRect, r, GraphicsUnit.Pixel);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003848 File Offset: 0x00001A48
		private void method_5(Graphics graphics_0)
		{
			if (this.bool_0)
			{
				this.method_6(graphics_0);
			}
			if (this.bool_1)
			{
				this.method_7(graphics_0);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00016648 File Offset: 0x00014848
		private void method_6(Graphics graphics_0)
		{
			if (this.image_0 == null)
			{
				return;
			}
			this.method_12();
			new SolidBrush(Color.White);
			Pen pen = new Pen(Color.LightGray);
			Point pt = new Point(1, 1);
			Point pt2 = new Point(1 + this.int_2, 1);
			for (int i = 0; i < this.int_0 * 2 + 1; i++)
			{
				int num = i * this.int_1;
				pt.Y = 1 + num;
				pt2.Y = 1 + num;
				graphics_0.DrawLine(pen, pt, pt2);
			}
			pt.Y = 1;
			pt2.Y = 1 + this.int_2;
			for (int j = 0; j < this.int_0 * 2 + 1; j++)
			{
				int num2 = j * this.int_1;
				pt.X = 1 + num2;
				pt2.X = 1 + num2;
				graphics_0.DrawLine(pen, pt, pt2);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001672C File Offset: 0x0001492C
		private void method_7(Graphics graphics_0)
		{
			Pen pen = new Pen(Color.Red);
			Point pt = new Point(1, 1 + this.int_2 / 2);
			Point pt2 = new Point(1 + this.int_2, 1 + this.int_2 / 2);
			graphics_0.DrawLine(pen, pt, pt2);
			pt.Y = 1;
			pt2.Y = 1 + this.int_2;
			pt.X = 1 + this.int_2 / 2;
			pt2.X = 1 + this.int_2 / 2;
			graphics_0.DrawLine(pen, pt, pt2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000167BC File Offset: 0x000149BC
		private void method_8(DimensionWorkingData dimensionWorkingData_1)
		{
			this.list_0 = new List<[]>();
			for (int i = 0; i < this.int_0 * 2; i++)
			{
				[] item = new[this.int_0 * 2];
				this.list_0.Add(item);
			}
			string folderPath = FileUtils.CheckFolderSep(dimensionWorkingData_1.Path) + FileUtils.CheckFolderSep(Working.smethod_4()) + dimensionWorkingData_1.Dimension;
			this.method_9(dimensionWorkingData_1.Dimension, "r.-1.-1", -1, -1, 0, 0, FileUtils.CheckFolderSep(folderPath) + "r.-1.-1.mcr");
			this.method_9(dimensionWorkingData_1.Dimension, "r.0.-1", 0, -1, this.int_0, 0, FileUtils.CheckFolderSep(folderPath) + "r.0.-1.mcr");
			this.method_9(dimensionWorkingData_1.Dimension, "r.-1.0", -1, 0, 0, this.int_0, FileUtils.CheckFolderSep(folderPath) + "r.-1.0.mcr");
			this.method_9(dimensionWorkingData_1.Dimension, "r.0.0", 0, 0, this.int_0, this.int_0, FileUtils.CheckFolderSep(folderPath) + "r.0.0.mcr");
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000168D0 File Offset: 0x00014AD0
		private List<[]> method_9(string string_0, string string_1, int int_10, int int_11, int int_12, int int_13, string string_2)
		{
			List<ChunkIndexEntry> list = Class46.smethod_5(string_2);
			if (list == null)
			{
				list = Class46.smethod_8();
			}
			int num = 32 - this.int_0;
			if (int_10 >= 0)
			{
				for (int i = 0; i < this.int_0; i++)
				{
					if (int_11 >= 0)
					{
						for (int j = 0; j < this.int_0; j++)
						{
							this.method_10(string_0, string_1, int_10, int_11, this.list_0, list, i, j, i + int_12, j + int_13);
						}
					}
					else
					{
						for (int k = this.int_0 - 1; k >= 0; k--)
						{
							this.method_10(string_0, string_1, int_10, int_11, this.list_0, list, i, k + num, i + int_12, k + int_13);
						}
					}
				}
			}
			else
			{
				for (int l = this.int_0 - 1; l >= 0; l--)
				{
					if (int_11 >= 0)
					{
						for (int m = 0; m < this.int_0; m++)
						{
							this.method_10(string_0, string_1, int_10, int_11, this.list_0, list, l + num, m, l + int_12, m + int_13);
						}
					}
					else
					{
						for (int n = this.int_0 - 1; n >= 0; n--)
						{
							this.method_10(string_0, string_1, int_10, int_11, this.list_0, list, l + num, n + num, l + int_12, n + int_13);
						}
					}
				}
			}
			return this.list_0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00016A24 File Offset: 0x00014C24
		private void method_10(string string_0, string string_1, int int_10, int int_11, List<[]> list_2, List<ChunkIndexEntry> list_3, int int_12, int int_13, int int_14, int int_15)
		{
			/*
An exception occurred when decompiling this method (0600026B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapDimension::method_10(System.String,System.String,System.Int32,System.Int32,System.Collections.Generic.List`1<<<<NULL>>>[]>,System.Collections.Generic.List`1<Full_UMT_Convertor.model.ChunkIndexEntry>,System.Int32,System.Int32,System.Int32,System.Int32)

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

		// Token: 0x0600026C RID: 620 RVA: 0x00016A90 File Offset: 0x00014C90
		private void MapDimension_Resize(object sender, EventArgs e)
		{
			int num = base.Height / 2 - this.panel_1.Height;
			if (num < 0)
			{
				num = 0;
			}
			this.panel_1.Top = num;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00003868 File Offset: 0x00001A68
		private void method_11()
		{
			this.int_1 = (this.panel_0.Width - 2) / (this.int_0 * 2);
			this.int_2 = this.panel_0.Width - 2;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003868 File Offset: 0x00001A68
		private void method_12()
		{
			this.int_1 = (this.panel_0.Width - 2) / (this.int_0 * 2);
			this.int_2 = this.panel_0.Width - 2;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void MapDimension_MouseMove(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void MapDimension_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00016AC4 File Offset: 0x00014CC4
		private void method_13(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (06000271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapDimension::method_13(System.Windows.Forms.MouseEventArgs)

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

		// Token: 0x06000272 RID: 626 RVA: 0x00003899 File Offset: 0x00001A99
		private int method_14(int int_10, int int_11)
		{
			if (int_11 < 0)
			{
				return (this.int_0 - int_10) * -1;
			}
			return int_10;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003899 File Offset: 0x00001A99
		private int method_15(int int_10, int int_11)
		{
			if (int_11 < 0)
			{
				return (this.int_0 - int_10) * -1;
			}
			return int_10;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00016D00 File Offset: 0x00014F00
		private void method_16(MouseEventArgs mouseEventArgs_0)
		{
			int num = mouseEventArgs_0.X;
			int num2 = mouseEventArgs_0.Y;
			int num3 = this.int_0 * 2;
			if (num > 1 && num2 > 1)
			{
				num--;
				num2--;
				num /= this.int_2 / num3;
				num2 /= this.int_2 / num3;
				this.method_17(num, num2);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00016D54 File Offset: 0x00014F54
		private void method_17(int int_10, int int_11)
		{
			/*
An exception occurred when decompiling this method (06000275)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.MapDimension::method_17(System.Int32,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_56
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00016DBC File Offset: 0x00014FBC
		protected virtual void OnChunkSelected(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00016DDC File Offset: 0x00014FDC
		protected virtual void OnMapUpdated(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000038AB File Offset: 0x00001AAB
		private void MapDimension_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.method_16(e);
			}
			MouseButtons button = e.Button;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000038C8 File Offset: 0x00001AC8
		private SolidBrush method_18(int int_10, int int_11)
		{
			return this.solidBrush_0;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00016DFC File Offset: 0x00014FFC
		private void gooOpAxYw8(int int_10, int int_11, Graphics graphics_0)
		{
			this.method_19(graphics_0);
			int num = 80;
			if (this.dimensionWorkingData_0.Dimension == "DIM-1")
			{
				num = 368;
			}
			else if (this.dimensionWorkingData_0.Dimension == "DIM1")
			{
				num = 0;
			}
			if (this.bool_0)
			{
				this.method_21(int_10, int_11, this.solidBrush_0, graphics_0);
			}
			else if (this.image_0 != null)
			{
				SolidBrush solidBrush_ = new SolidBrush(this.panel_0.BackColor);
				this.method_21(int_10, int_11, solidBrush_, graphics_0);
				if (int_10 > 0)
				{
					int_10--;
				}
				if (int_11 > 0)
				{
					int_11--;
				}
				Point point = new Point(int_10 * this.int_1 + 1, int_11 * this.int_1 + 1);
				Rectangle srcRect = new Rectangle(int_10 * 16 + num, int_11 * 16 + num, 32, 32);
				Rectangle destRect = new Rectangle(point.X, point.Y, this.int_1 * 2, this.int_1 * 2);
				graphics_0.DrawImage(this.image_0[(int)this.mapViewType_0], destRect, srcRect, GraphicsUnit.Pixel);
				this.method_1(graphics_0);
				this.method_2(graphics_0);
			}
			if (this.bool_1)
			{
				this.method_7(graphics_0);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000038D0 File Offset: 0x00001AD0
		private void method_19(Graphics graphics_0)
		{
			graphics_0.InterpolationMode = InterpolationMode.NearestNeighbor;
			graphics_0.SmoothingMode = SmoothingMode.None;
			graphics_0.PixelOffsetMode = PixelOffsetMode.Half;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00016F30 File Offset: 0x00015130
		private void method_20(int int_10, int int_11, Graphics graphics_0)
		{
			try
			{
				Point p = new Point(int_10 * this.int_1 + 1, int_11 * this.int_1 + 1);
				Point point = this.panel_0.PointToScreen(p);
				this.bitmap_0 = new Bitmap(this.int_1 + 1, this.int_1 + 1);
				Graphics graphics = Graphics.FromImage(this.bitmap_0);
				graphics.CopyFromScreen(point.X, point.Y, 0, 0, this.bitmap_0.Size);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00016FC4 File Offset: 0x000151C4
		private void method_21(int int_10, int int_11, SolidBrush solidBrush_3, Graphics graphics_0)
		{
			this.method_19(graphics_0);
			Point point = new Point(int_10 * this.int_1 + 1, int_11 * this.int_1 + 1);
			Pen pen = new Pen(solidBrush_3);
			graphics_0.DrawRectangle(pen, point.X, point.Y, this.int_1, this.int_1);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00017020 File Offset: 0x00015220
		private void method_22()
		{
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.backgroundWorker_0.WorkerReportsProgress = true;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00017080 File Offset: 0x00015280
		private void method_23(DimensionWorkingData dimensionWorkingData_1)
		{
			if (!this.backgroundWorker_0.IsBusy)
			{
				this.flowLayoutPanel_0.Visible = false;
				this.panel_1.Visible = true;
				string dimension = dimensionWorkingData_1.Dimension;
				MapBlockParameter mapBlockParameter = new MapBlockParameter();
				mapBlockParameter.OutFolderPath = dimensionWorkingData_1.Path;
				mapBlockParameter.Dimension = dimension;
				this.backgroundWorker_0.RunWorkerAsync(mapBlockParameter);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000170E0 File Offset: 0x000152E0
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker backgroundWorker = sender as BackgroundWorker;
			MapBlockParameter mapBlockParameter = e.Argument as MapBlockParameter;
			MapBlockWorker mapBlockWorker = new MapBlockWorker(backgroundWorker);
			Image[] result = mapBlockWorker.MapBlocks(mapBlockParameter.Dimension, mapBlockParameter.OutFolderPath);
			e.Result = result;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00017124 File Offset: 0x00015324
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.image_0 = null;
			if (e.Result != null && e.Result is Image[])
			{
				int num = 542;
				if (this.dimensionWorkingData_0.Dimension == "DIM1")
				{
					num = 642;
				}
				this.image_0 = (e.Result as Image[]);
				this.panel_0.Width = num;
				this.panel_0.Height = num;
				this.method_24();
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000171A0 File Offset: 0x000153A0
		private void method_24()
		{
			try
			{
				this.flowLayoutPanel_0.Visible = true;
				this.panel_1.Visible = false;
				this.method_12();
				this.method_11();
				this.panel_0.Invalidate();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000171F4 File Offset: 0x000153F4
		private void method_25(int int_10)
		{
			int num = this.int_5 + int_10;
			if (num < 0)
			{
				num = 0;
			}
			else if (num > 54)
			{
				num = 54;
			}
			this.method_17(num, this.int_6);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00017228 File Offset: 0x00015428
		private void method_26(int int_10)
		{
			int num = this.int_6 + int_10;
			if (num < 0)
			{
				num = 0;
			}
			else if (num > 54)
			{
				num = 54;
			}
			this.method_17(this.int_5, num);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000038E7 File Offset: 0x00001AE7
		private void MapDimension_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001725C File Offset: 0x0001545C
		protected override bool IsInputKey(Keys keyData)
		{
			bool flag = false;
			if (keyData <= (Keys.Back | Keys.Space | Keys.Shift))
			{
				switch (keyData)
				{
				case Keys.Left:
					this.method_25(-1);
					flag = true;
					break;
				case Keys.Up:
					this.method_26(-1);
					flag = true;
					break;
				case Keys.Right:
					this.method_25(1);
					flag = true;
					break;
				case Keys.Down:
					this.method_26(1);
					flag = true;
					break;
				default:
					switch (keyData)
					{
					case Keys.LButton | Keys.MButton | Keys.Space | Keys.Shift:
					case Keys.RButton | Keys.MButton | Keys.Space | Keys.Shift:
					case Keys.LButton | Keys.RButton | Keys.MButton | Keys.Space | Keys.Shift:
					case Keys.Back | Keys.Space | Keys.Shift:
						return true;
					}
					break;
				}
			}
			else
			{
				switch (keyData)
				{
				case (Keys)131179:
					goto IL_74;
				case (Keys)131180:
					goto IL_30;
				case (Keys)131181:
					break;
				default:
					switch (keyData)
					{
					case Keys.LButton | Keys.RButton | Keys.Back | Keys.ShiftKey | Keys.Space | Keys.F17 | Keys.Control:
						goto IL_74;
					case Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space | Keys.F17 | Keys.Control:
						goto IL_30;
					case Keys.LButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space | Keys.F17 | Keys.Control:
						break;
					default:
						goto IL_30;
					}
					break;
				}
				this.method_27(-1);
				flag = true;
				goto IL_30;
				IL_74:
				this.method_27(1);
				flag = true;
			}
			IL_30:
			return flag || base.IsInputKey(keyData);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00017338 File Offset: 0x00015538
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			switch (e.KeyCode)
			{
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
			{
				bool shift = e.Shift;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000038F0 File Offset: 0x00001AF0
		private void MapDimension_MouseWheel(object sender, MouseEventArgs e)
		{
			this.method_27(e.Delta);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00017378 File Offset: 0x00015578
		private void method_27(int int_10)
		{
			int index = 0;
			if (this.dimensionWorkingData_0.Dimension == "DIM1")
			{
				index = 1;
			}
			if (this.image_0 != null)
			{
				int num = this.list_1[index][0];
				if (this.panel_0.Width > 4096)
				{
					num = this.list_1[index][4];
				}
				else if (this.panel_0.Width > 2048)
				{
					num = this.list_1[index][3];
				}
				else if (this.panel_0.Width > 1024)
				{
					num = this.list_1[index][2];
				}
				else if (this.panel_0.Width > 512)
				{
					num = this.list_1[index][1];
				}
				Image image = this.image_0[(int)this.mapViewType_0];
				float num2 = (float)image.Height / (float)image.Width;
				if (int_10 < 0)
				{
					if (this.panel_0.Width > this.list_1[index][0])
					{
						this.panel_0.Width = this.panel_0.Width - num;
					}
					if (this.panel_0.Width < this.list_1[index][0])
					{
						this.panel_0.Width = this.list_1[index][0] + 2;
					}
					this.panel_0.Height = (int)((float)this.panel_0.Width * num2);
					int num3 = this.flowLayoutPanel_0.HorizontalScroll.Value - num / 2;
					if (num3 < 0)
					{
						num3 = 0;
					}
					this.flowLayoutPanel_0.HorizontalScroll.Value = num3;
					num3 = this.flowLayoutPanel_0.VerticalScroll.Value - num / 2;
					if (num3 < 0)
					{
						num3 = 0;
					}
					this.flowLayoutPanel_0.VerticalScroll.Value = num3;
				}
				else
				{
					this.panel_0.Width = this.panel_0.Width + num;
					this.panel_0.Height = (int)((float)this.panel_0.Width * num2);
					int num4 = num / 2 + this.flowLayoutPanel_0.HorizontalScroll.Value;
					if (num4 > this.flowLayoutPanel_0.HorizontalScroll.Maximum)
					{
						num4 = this.flowLayoutPanel_0.HorizontalScroll.Maximum;
					}
					this.flowLayoutPanel_0.HorizontalScroll.Value = num4;
					num4 = num / 2 + this.flowLayoutPanel_0.VerticalScroll.Value;
					if (num4 > this.flowLayoutPanel_0.VerticalScroll.Maximum)
					{
						num4 = this.flowLayoutPanel_0.VerticalScroll.Maximum;
					}
					this.flowLayoutPanel_0.VerticalScroll.Value = num4;
				}
				this.method_12();
				this.int_3 = -100;
				this.int_4 = -100;
				this.flowLayoutPanel_0.PerformLayout();
				this.panel_0.Invalidate();
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00017660 File Offset: 0x00015860
		private void panel_0_MouseDown(object sender, MouseEventArgs e)
		{
			this.int_8 = this.flowLayoutPanel_0.HorizontalScroll.Value;
			this.int_9 = this.flowLayoutPanel_0.VerticalScroll.Value;
			Point point = base.PointToClient(Cursor.Position);
			this.jfaIwgNyXc = point.X;
			this.int_7 = point.Y;
			if (e.Button == MouseButtons.Left)
			{
				this.Cursor = new Cursor(Cursor.Current.Handle);
			}
			this.bool_4 = false;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000038FE File Offset: 0x00001AFE
		private void panel_0_MouseUp(object sender, MouseEventArgs e)
		{
			if (!this.bool_4)
			{
				this.method_16(e);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000176E8 File Offset: 0x000158E8
		private void panel_0_MouseMove(object sender, MouseEventArgs e)
		{
			int num = this.int_8;
			int num2 = this.int_9;
			if (e.Button == MouseButtons.Left)
			{
				Point point = base.PointToClient(Cursor.Position);
				num = this.int_8 - (point.X - this.jfaIwgNyXc);
				num2 = this.int_9 - (point.Y - this.int_7);
				if (num < 0)
				{
					num = 0;
				}
				if (num > this.flowLayoutPanel_0.HorizontalScroll.Maximum)
				{
					num = this.flowLayoutPanel_0.HorizontalScroll.Maximum;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num2 > this.flowLayoutPanel_0.VerticalScroll.Maximum)
				{
					num2 = this.flowLayoutPanel_0.VerticalScroll.Maximum;
				}
				this.flowLayoutPanel_0.HorizontalScroll.Value = num;
				this.flowLayoutPanel_0.VerticalScroll.Value = num2;
				this.bool_4 = true;
			}
			this.method_13(e);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000177D0 File Offset: 0x000159D0
		private void panel_0_MouseLeave(object sender, EventArgs e)
		{
			this.label_1.Visible = false;
			Graphics graphics_ = this.panel_0.CreateGraphics();
			this.gooOpAxYw8(this.int_3, this.int_4, graphics_);
			this.int_3 = -100;
			this.int_4 = -100;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000390F File Offset: 0x00001B0F
		internal void method_28()
		{
			this.panel_0.Invalidate();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000391C File Offset: 0x00001B1C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00017818 File Offset: 0x00015A18
		private void method_29()
		{
			this.icontainer_0 = new Container();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.flowLayoutPanel_0 = new FlowLayoutPanel();
			this.panel_0 = new Panel();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.JlhIpTiqFp = new ToolStripMenuItem();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.progressBar_0 = new ProgressBar();
			this.panel_1 = new Panel();
			this.label_2 = new Label();
			this.flowLayoutPanel_0.SuspendLayout();
			this.contextMenuStrip_0.SuspendLayout();
			this.panel_1.SuspendLayout();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(1, 5);
			this.label_0.Name = "lblCaption";
			this.label_0.Size = new Size(51, 20);
			this.label_0.TabIndex = 2;
			this.label_0.Text = "label1";
			this.label_1.AutoSize = true;
			this.label_1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_1.Location = new Point(101, 5);
			this.label_1.MinimumSize = new Size(2, 0);
			this.label_1.Name = "lblPosition";
			this.label_1.Size = new Size(51, 20);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "label2";
			this.label_1.Visible = false;
			this.flowLayoutPanel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.flowLayoutPanel_0.AutoScroll = true;
			this.flowLayoutPanel_0.Controls.Add(this.panel_0);
			this.flowLayoutPanel_0.Location = new Point(0, 26);
			this.flowLayoutPanel_0.Name = "flpMapContainer";
			this.flowLayoutPanel_0.Size = new Size(556, 530);
			this.flowLayoutPanel_0.TabIndex = 5;
			this.flowLayoutPanel_0.Visible = false;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "pnlMap";
			this.panel_0.Size = new Size(512, 375);
			this.panel_0.TabIndex = 0;
			this.panel_0.MouseDown += this.panel_0_MouseDown;
			this.panel_0.MouseLeave += this.panel_0_MouseLeave;
			this.panel_0.MouseMove += this.panel_0_MouseMove;
			this.panel_0.MouseUp += this.panel_0_MouseUp;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.JlhIpTiqFp,
				this.toolStripMenuItem_0
			});
			this.contextMenuStrip_0.Name = "cmsActions";
			this.contextMenuStrip_0.Size = new Size(103, 48);
			this.JlhIpTiqFp.Name = "copyToolStripMenuItem";
			this.JlhIpTiqFp.Size = new Size(102, 22);
			this.JlhIpTiqFp.Text = "Copy";
			this.toolStripMenuItem_0.Name = "pasteToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(102, 22);
			this.toolStripMenuItem_0.Text = "Paste";
			this.progressBar_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.progressBar_0.Location = new Point(31, 24);
			this.progressBar_0.Name = "progressBar1";
			this.progressBar_0.Size = new Size(484, 23);
			this.progressBar_0.Style = ProgressBarStyle.Marquee;
			this.progressBar_0.TabIndex = 0;
			this.panel_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_1.Controls.Add(this.label_2);
			this.panel_1.Controls.Add(this.progressBar_0);
			this.panel_1.Location = new Point(0, 456);
			this.panel_1.Name = "pnlLoading";
			this.panel_1.Size = new Size(556, 62);
			this.panel_1.TabIndex = 1;
			this.panel_1.Visible = false;
			this.label_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.label_2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_2.Location = new Point(31, 3);
			this.label_2.Name = "label1";
			this.label_2.Size = new Size(484, 23);
			this.label_2.TabIndex = 1;
			this.label_2.Text = "Creating Maps";
			this.label_2.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.panel_1);
			base.Controls.Add(this.flowLayoutPanel_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Name = "MapDimension";
			base.Size = new Size(559, 556);
			base.KeyDown += this.MapDimension_KeyDown;
			base.MouseDown += this.MapDimension_MouseDown;
			base.MouseLeave += this.MapDimension_MouseLeave;
			base.MouseMove += this.MapDimension_MouseMove;
			base.Resize += this.MapDimension_Resize;
			this.flowLayoutPanel_0.ResumeLayout(false);
			this.contextMenuStrip_0.ResumeLayout(false);
			this.panel_1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000176 RID: 374
		private static ImageList imageList_0;

		// Token: 0x04000177 RID: 375
		private static ImageList imageList_1;

		// Token: 0x04000178 RID: 376
		private static Dictionary<string, int> dictionary_0;

		// Token: 0x04000179 RID: 377
		private Color color_0;

		// Token: 0x0400017A RID: 378
		private Color color_1;

		// Token: 0x0400017B RID: 379
		private MapViewType mapViewType_0;

		// Token: 0x0400017C RID: 380
		private EntityLookup entityLookup_0;

		// Token: 0x0400017D RID: 381
		private bool bool_0;

		// Token: 0x0400017E RID: 382
		private bool bool_1;

		// Token: 0x0400017F RID: 383
		private bool bool_2;

		// Token: 0x04000180 RID: 384
		private bool PabIeZfsam;

		// Token: 0x04000181 RID: 385
		private Image[] image_0;

		// Token: 0x04000182 RID: 386
		private int int_0;

		// Token: 0x04000183 RID: 387
		private int int_1;

		// Token: 0x04000184 RID: 388
		private int int_2;

		// Token: 0x04000185 RID: 389
		private int int_3;

		// Token: 0x04000186 RID: 390
		private int int_4;

		// Token: 0x04000187 RID: 391
		private int int_5;

		// Token: 0x04000188 RID: 392
		private int int_6;

		// Token: 0x04000189 RID: 393
		private bool bool_3;

		// Token: 0x0400018A RID: 394
		private SolidBrush solidBrush_0;

		// Token: 0x0400018B RID: 395
		private SolidBrush solidBrush_1;

		// Token: 0x0400018C RID: 396
		private SolidBrush solidBrush_2;

		// Token: 0x0400018D RID: 397
		private EventHandler eventHandler_0;

		// Token: 0x0400018E RID: 398
		private EventHandler eventHandler_1;

		// Token: 0x0400018F RID: 399
		private DimensionWorkingData dimensionWorkingData_0;

		// Token: 0x04000190 RID: 400
		private List<[]> list_0;

		// Token: 0x04000191 RID: 401
		private Bitmap bitmap_0;

		// Token: 0x04000192 RID: 402
		private List<int[]> list_1;

		// Token: 0x04000193 RID: 403
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04000194 RID: 404
		private bool bool_4;

		// Token: 0x04000195 RID: 405
		private int jfaIwgNyXc;

		// Token: 0x04000196 RID: 406
		private int int_7;

		// Token: 0x04000197 RID: 407
		private int int_8;

		// Token: 0x04000198 RID: 408
		private int int_9;

		// Token: 0x04000199 RID: 409
		private IContainer icontainer_0;

		// Token: 0x0400019A RID: 410
		private Label label_0;

		// Token: 0x0400019B RID: 411
		private Label label_1;

		// Token: 0x0400019C RID: 412
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x0400019D RID: 413
		private Panel panel_0;

		// Token: 0x0400019E RID: 414
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x0400019F RID: 415
		private ToolStripMenuItem JlhIpTiqFp;

		// Token: 0x040001A0 RID: 416
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040001A1 RID: 417
		private ProgressBar progressBar_0;

		// Token: 0x040001A2 RID: 418
		private Panel panel_1;

		// Token: 0x040001A3 RID: 419
		private Label label_2;
	}
}
