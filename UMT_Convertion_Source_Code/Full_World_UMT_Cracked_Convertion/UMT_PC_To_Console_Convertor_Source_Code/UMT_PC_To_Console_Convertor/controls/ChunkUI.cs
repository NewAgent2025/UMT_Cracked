using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000024 RID: 36
	public class ChunkUI : UserControl
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000107 RID: 263 RVA: 0x0000BF08 File Offset: 0x0000A108
		// (remove) Token: 0x06000108 RID: 264 RVA: 0x0000BF40 File Offset: 0x0000A140
		public event EventHandler BlockCopied
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

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000109 RID: 265 RVA: 0x0000BF78 File Offset: 0x0000A178
		// (remove) Token: 0x0600010A RID: 266 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		public event EventHandler BlockChanged
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

		// Token: 0x0600010B RID: 267 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public ChunkUI()
		{
			this.method_21();
			this.method_0();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		private void method_0()
		{
			this.label_0.Left = 10;
			this.label_0.Top = 554;
			this.label_1.Left = 554 - this.label_1.Width;
			this.label_1.Top = 554;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public ChunkLayer Level
		{
			get
			{
				return this.chunkLayer_0;
			}
			set
			{
				this.chunkLayer_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002DEF File Offset: 0x00000FEF
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002DF7 File Offset: 0x00000FF7
		public int ChunkX
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				this.int_2 = ((this.int_0 >= 0) ? (this.int_0 * 16) : ((this.int_0 + 1) * 16));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002E25 File Offset: 0x00001025
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002E2D File Offset: 0x0000102D
		public int ChunkZ
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
				this.int_3 = ((this.int_1 >= 0) ? (this.int_1 * 16) : ((this.int_1 + 1) * 16));
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002E5B File Offset: 0x0000105B
		internal Block method_1()
		{
			return this.block_1;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002E63 File Offset: 0x00001063
		internal void method_2(Block value)
		{
			this.block_1 = value;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002E6C File Offset: 0x0000106C
		internal Block method_3()
		{
			return this.block_0;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002E74 File Offset: 0x00001074
		internal void method_4(Block value)
		{
			this.block_0 = value;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002E7D File Offset: 0x0000107D
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002E85 File Offset: 0x00001085
		public bool CopyBlockActive
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002E8E File Offset: 0x0000108E
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002E96 File Offset: 0x00001096
		public Block SearchBlock
		{
			get
			{
				return this.block_3;
			}
			set
			{
				this.block_3 = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002E9F File Offset: 0x0000109F
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002EA7 File Offset: 0x000010A7
		public bool SearchActive
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002EB6 File Offset: 0x000010B6
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			this.method_5(pe);
			this.method_6(pe);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000C040 File Offset: 0x0000A240
		private void method_5(PaintEventArgs paintEventArgs_0)
		{
			Brush brush = new SolidBrush(Color.White);
			paintEventArgs_0.Graphics.FillRectangle(brush, 10, 10, 544, 544);
			Pen pen = new Pen(Color.LightGray);
			Point pt = new Point(10, 10);
			Point pt2 = new Point(554, 10);
			for (int i = 0; i < 17; i++)
			{
				int num = i * 34;
				pt.Y = 10 + num;
				pt2.Y = 10 + num;
				paintEventArgs_0.Graphics.DrawLine(pen, pt, pt2);
			}
			pt.Y = 10;
			pt2.Y = 554;
			for (int j = 0; j < 17; j++)
			{
				int num2 = j * 34;
				pt.X = 10 + num2;
				pt2.X = 10 + num2;
				paintEventArgs_0.Graphics.DrawLine(pen, pt, pt2);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000C128 File Offset: 0x0000A328
		private void method_6(PaintEventArgs paintEventArgs_0)
		{
			if (this.Level == null)
			{
				return;
			}
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					Point point = new Point(i * 34 + 11, j * 34 + 11);
					int num = i * 16 + j;
					if (this.method_7(this.chunkLayer_0.Blocks[num].Id, this.chunkLayer_0.Blocks[num].Data))
					{
						Brush brush = new SolidBrush(Color.Red);
						paintEventArgs_0.Graphics.FillRectangle(brush, point.X, point.Y, 32, 32);
					}
					Image image = Class4.smethod_7(this.chunkLayer_0.Blocks[num].Id, this.chunkLayer_0.Blocks[num].Data);
					if (image != null)
					{
						paintEventArgs_0.Graphics.DrawImage(image, point);
					}
				}
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002ECD File Offset: 0x000010CD
		private bool method_7(int int_4, int int_5)
		{
			return this.SearchActive && int_4 == this.block_3.Id && (int_5 == this.block_3.Data || this.block_3.Data == -1);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000C214 File Offset: 0x0000A414
		private void ChunkUI_MouseDown(object sender, MouseEventArgs e)
		{
			this.block_2 = null;
			if (!this.avpbObpeoo(e))
			{
				return;
			}
			if (Control.ModifierKeys == (Keys.Shift | Keys.Control))
			{
				this.method_20(e);
				return;
			}
			if (!this.bool_0 && Control.ModifierKeys != Keys.Shift && Control.ModifierKeys != Keys.Control)
			{
				if (Control.ModifierKeys != Keys.Alt)
				{
					this.method_8(e);
					return;
				}
			}
			if (e.Button == MouseButtons.Left)
			{
				this.block_2 = this.block_0;
			}
			else
			{
				this.block_2 = this.block_1;
			}
			if (this.bool_0)
			{
				this.method_9(e);
				return;
			}
			if (Control.ModifierKeys == Keys.Shift)
			{
				this.method_14(e);
				this.method_13(e);
				return;
			}
			if (Control.ModifierKeys == Keys.Control)
			{
				this.method_11();
				return;
			}
			if (Control.ModifierKeys == Keys.Alt)
			{
				this.method_10(e);
				return;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000C30C File Offset: 0x0000A50C
		private void method_8(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (06000122)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.ChunkUI::method_8(System.Windows.Forms.MouseEventArgs)

 ---> System.Exception: Inconsistent stack size at IL_BE
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000C448 File Offset: 0x0000A648
		private void method_9(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (06000123)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.ChunkUI::method_9(System.Windows.Forms.MouseEventArgs)

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

		// Token: 0x06000124 RID: 292 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		private void method_10(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (06000124)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.ChunkUI::method_10(System.Windows.Forms.MouseEventArgs)

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

		// Token: 0x06000125 RID: 293 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		private void method_11()
		{
			/*
An exception occurred when decompiling this method (06000125)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.ChunkUI::method_11()

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

		// Token: 0x06000126 RID: 294 RVA: 0x0000C618 File Offset: 0x0000A818
		private void method_12(int int_4, Block block_4)
		{
			int num = int_4 / 16;
			int num2 = int_4 % 16;
			if (Constants.ENTITY_BLOCKS.ContainsKey(this.Level.Blocks[int_4].Id))
			{
				this.aowbeykhvx(this.chunkLayer_0.TileEntities, num, this.chunkLayer_0.Layer, num2);
			}
			this.chunkLayer_0.Blocks[int_4].Id = block_4.Id;
			this.chunkLayer_0.Blocks[int_4].Data = block_4.Data;
			if (Constants.ENTITY_BLOCKS.ContainsKey(block_4.Id))
			{
				this.method_16(block_4.Id, this.chunkLayer_0.TileEntities, num, this.chunkLayer_0.Layer, num2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002F09 File Offset: 0x00001109
		private void ChunkUI_MouseUp(object sender, MouseEventArgs e)
		{
			this.block_2 = null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002F12 File Offset: 0x00001112
		private void ChunkUI_MouseMove(object sender, MouseEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				this.method_14(e);
			}
			this.method_13(e);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		private void method_13(MouseEventArgs mouseEventArgs_0)
		{
			if (!this.avpbObpeoo(mouseEventArgs_0))
			{
				this.label_0.Visible = false;
				this.label_1.Visible = false;
				return;
			}
			int num = this.oAybfjwZs1(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			if (num < 256)
			{
				this.label_0.Visible = true;
				this.label_1.Visible = true;
				if (Class4.smethod_1().ContainsKey(this.Level.Blocks[num].Id.ToString() + "-" + this.Level.Blocks[num].Data.ToString()))
				{
					this.label_0.Text = string.Concat(new object[]
					{
						"(",
						this.Level.Blocks[num].Id.ToString(),
						":",
						this.Level.Blocks[num].Data,
						") ",
						Class4.smethod_1()[this.Level.Blocks[num].Id.ToString() + "-" + this.Level.Blocks[num].Data.ToString()].Description
					});
				}
				else if (Class4.smethod_1().ContainsKey(this.Level.Blocks[num].Id.ToString()))
				{
					this.label_0.Text = string.Concat(new object[]
					{
						"(",
						this.Level.Blocks[num].Id.ToString(),
						":",
						this.Level.Blocks[num].Data,
						") ",
						Class4.smethod_1()[this.Level.Blocks[num].Id.ToString()].Description
					});
				}
				else
				{
					this.label_0.Text = Class29.smethod_1()[this.Level.Blocks[num].Id].IdName + ";" + this.Level.Blocks[num].Data;
				}
				this.label_1.Text = this.method_18(mouseEventArgs_0.X, mouseEventArgs_0.Y);
				this.label_1.Left = 554 - this.label_1.Width;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000C99C File Offset: 0x0000AB9C
		private void method_14(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (0600012A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.ChunkUI::method_14(System.Windows.Forms.MouseEventArgs)

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

		// Token: 0x0600012B RID: 299 RVA: 0x00002F2E File Offset: 0x0000112E
		private TagNodeCompound method_15(TagNodeList tagNodeList_0, int int_4, int int_5, int int_6)
		{
			int_4 = this.method_19(int_4, this.int_2, this.int_0);
			int_6 = this.method_19(int_6, this.int_3, this.int_1);
			return Class36.smethod_33(tagNodeList_0, int_4, int_5, int_6);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002F65 File Offset: 0x00001165
		private TagNodeCompound aowbeykhvx(TagNodeList tagNodeList_0, int int_4, int int_5, int int_6)
		{
			int_4 = this.method_19(int_4, this.int_2, this.int_0);
			int_6 = this.method_19(int_6, this.int_3, this.int_1);
			return Class36.smethod_32(tagNodeList_0, int_4, int_5, int_6);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002F9C File Offset: 0x0000119C
		private void method_16(int int_4, TagNodeList tagNodeList_0, int int_5, int int_6, int int_7)
		{
			int_5 = this.method_19(int_5, this.int_2, this.int_0);
			int_7 = this.method_19(int_7, this.int_3, this.int_1);
			Class36.smethod_34(int_4, tagNodeList_0, int_5, int_6, int_7, null);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002FD6 File Offset: 0x000011D6
		private void method_17(TagNodeCompound tagNodeCompound_0, int int_4, int int_5, int int_6)
		{
			int_4 = this.method_19(int_4, this.int_2, this.int_0);
			int_6 = this.method_19(int_6, this.int_3, this.int_1);
			Class36.smethod_39(tagNodeCompound_0, int_4, int_5, int_6);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000300D File Offset: 0x0000120D
		private int oAybfjwZs1(int int_4, int int_5)
		{
			int_4 -= 10;
			int_5 -= 10;
			return int_4 / 34 * 16 + int_5 / 34;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000CB48 File Offset: 0x0000AD48
		private string method_18(int int_4, int int_5)
		{
			int_4 -= 10;
			int_5 -= 10;
			int_4 /= 34;
			int_5 /= 34;
			int num = this.method_19(int_4, this.int_2, this.int_0);
			int num2 = this.method_19(int_5, this.int_3, this.int_1);
			return string.Concat(new object[]
			{
				num,
				", ",
				this.chunkLayer_0.Layer,
				", ",
				num2
			});
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003027 File Offset: 0x00001227
		private int method_19(int int_4, int int_5, int int_6)
		{
			return int_5 + ((int_6 >= 0) ? int_4 : ((16 - int_4) * -1));
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003038 File Offset: 0x00001238
		private void ChunkUI_MouseLeave(object sender, EventArgs e)
		{
			this.label_0.Visible = false;
			this.label_1.Visible = false;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		public void Rotate(RotateType dir)
		{
			Block[] array = new Block[256];
			Block[] blocks = this.chunkLayer_0.Blocks;
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num = i * 16 + j;
					int num2;
					int num3;
					if (dir == RotateType.Left)
					{
						num2 = j;
						num3 = 15 - i;
					}
					else
					{
						num2 = 15 - j;
						num3 = i;
					}
					int num4 = num2 * 16 + num3;
					array[num4] = blocks[num];
					if (Constants.ENTITY_BLOCKS.ContainsKey(blocks[num].Id))
					{
						TagNodeCompound tagNodeCompound = this.aowbeykhvx(this.chunkLayer_0.TileEntities, i, this.chunkLayer_0.Layer, j);
						if (tagNodeCompound != null)
						{
							this.method_17(tagNodeCompound, num2, this.chunkLayer_0.Layer, num3);
							tagNodeList.Add(tagNodeCompound);
						}
					}
				}
			}
			this.chunkLayer_0.Blocks = array;
			this.chunkLayer_0.TileEntities = tagNodeList;
			base.Invalidate();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public void Flip(FlipType flipType)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			Block[] array = new Block[256];
			Block[] blocks = this.chunkLayer_0.Blocks;
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num = i * 16 + j;
					int num2;
					int num3;
					if (flipType == FlipType.Vertical)
					{
						num2 = i;
						num3 = 15 - j;
					}
					else
					{
						num2 = 15 - i;
						num3 = j;
					}
					int num4 = num2 * 16 + num3;
					array[num4] = blocks[num];
					if (Constants.ENTITY_BLOCKS.ContainsKey(blocks[num].Id))
					{
						TagNodeCompound tagNodeCompound = this.aowbeykhvx(this.chunkLayer_0.TileEntities, i, this.chunkLayer_0.Layer, j);
						if (tagNodeCompound != null)
						{
							this.method_17(tagNodeCompound, num2, this.chunkLayer_0.Layer, num3);
							tagNodeList.Add(tagNodeCompound);
						}
					}
				}
			}
			this.chunkLayer_0.Blocks = array;
			this.chunkLayer_0.TileEntities = tagNodeList;
			base.Invalidate();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		private void method_20(MouseEventArgs mouseEventArgs_0)
		{
			if (!this.avpbObpeoo(mouseEventArgs_0))
			{
				return;
			}
			int num = this.oAybfjwZs1(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			if (num < 256)
			{
				int id = this.chunkLayer_0.Blocks[num].Id;
				int data = this.chunkLayer_0.Blocks[num].Data;
				if (id > 0)
				{
					Class36.smethod_37(Constants.mapItemFrame);
				}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003052 File Offset: 0x00001252
		private bool avpbObpeoo(MouseEventArgs mouseEventArgs_0)
		{
			return this.Level != null && mouseEventArgs_0.X >= 10 && mouseEventArgs_0.X <= 554 && mouseEventArgs_0.Y >= 10 && mouseEventArgs_0.Y <= 553;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000CE4C File Offset: 0x0000B04C
		protected virtual void OnBlockCopied(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000CE6C File Offset: 0x0000B06C
		protected virtual void OnBlockChanged(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000308F File Offset: 0x0000128F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000CE8C File Offset: 0x0000B08C
		private void method_21()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.BorderStyle = BorderStyle.FixedSingle;
			this.label_0.Location = new Point(3, 429);
			this.label_0.Name = "lblBlockInfo";
			this.label_0.Padding = new Padding(4);
			this.label_0.Size = new Size(10, 23);
			this.label_0.TabIndex = 0;
			this.label_0.TextAlign = ContentAlignment.MiddleLeft;
			this.label_0.Visible = false;
			this.label_1.AutoSize = true;
			this.label_1.BorderStyle = BorderStyle.FixedSingle;
			this.label_1.Location = new Point(31, 429);
			this.label_1.Name = "lblXYZ";
			this.label_1.Padding = new Padding(4);
			this.label_1.Size = new Size(10, 23);
			this.label_1.TabIndex = 1;
			this.label_1.TextAlign = ContentAlignment.MiddleRight;
			this.label_1.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Name = "ChunkUI";
			base.Size = new Size(417, 452);
			base.MouseDown += this.ChunkUI_MouseDown;
			base.MouseLeave += this.ChunkUI_MouseLeave;
			base.MouseMove += this.ChunkUI_MouseMove;
			base.MouseUp += this.ChunkUI_MouseUp;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009F RID: 159
		private int int_0;

		// Token: 0x040000A0 RID: 160
		private int int_1;

		// Token: 0x040000A1 RID: 161
		private ChunkLayer chunkLayer_0;

		// Token: 0x040000A2 RID: 162
		private Block block_0;

		// Token: 0x040000A3 RID: 163
		private Block block_1;

		// Token: 0x040000A4 RID: 164
		private Block block_2;

		// Token: 0x040000A5 RID: 165
		private bool bool_0;

		// Token: 0x040000A6 RID: 166
		private Block block_3;

		// Token: 0x040000A7 RID: 167
		private bool bool_1;

		// Token: 0x040000A8 RID: 168
		private int int_2;

		// Token: 0x040000A9 RID: 169
		private int int_3;

		// Token: 0x040000AA RID: 170
		private EventHandler eventHandler_0;

		// Token: 0x040000AB RID: 171
		private EventHandler eventHandler_1;

		// Token: 0x040000AC RID: 172
		private IContainer icontainer_0;

		// Token: 0x040000AD RID: 173
		private Label label_0;

		// Token: 0x040000AE RID: 174
		private Label label_1;
	}
}
