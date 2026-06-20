using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x0200002A RID: 42
	public class DimensionDisplay : UserControl
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000188 RID: 392 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		// (remove) Token: 0x06000189 RID: 393 RVA: 0x0000EC14 File Offset: 0x0000CE14
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

		// Token: 0x0600018A RID: 394 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		public DimensionDisplay()
		{
			this.method_12();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000330A File Offset: 0x0000150A
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
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
				if (value != null)
				{
					string text = Constants.dimensionNames[value.Dimension];
					this.label_0.Text = text;
					if (value.Dimension == "region")
					{
						this.int_0 = 27;
					}
					else
					{
						this.int_0 = 9;
					}
					this.method_2(this.dimensionWorkingData_0);
					this.method_5();
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00003312 File Offset: 0x00001512
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000331A File Offset: 0x0000151A
		public List<RegionDisplayChunk[]> ChunkEntries
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

		// Token: 0x0600018F RID: 399 RVA: 0x00003323 File Offset: 0x00001523
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			this.method_0(pe);
			this.method_1(pe);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000ED44 File Offset: 0x0000CF44
		private void method_0(PaintEventArgs paintEventArgs_0)
		{
			Brush brush = new SolidBrush(Color.White);
			paintEventArgs_0.Graphics.FillRectangle(brush, 10, 20, this.int_2, this.int_2);
			Pen pen = new Pen(Color.LightGray);
			Point pt = new Point(10, 20);
			Point pt2 = new Point(10 + this.int_2, 20);
			for (int i = 0; i < this.int_0 * 2 + 1; i++)
			{
				int num = i * this.int_1;
				pt.Y = 20 + num;
				pt2.Y = 20 + num;
				paintEventArgs_0.Graphics.DrawLine(pen, pt, pt2);
			}
			pt.Y = 20;
			pt2.Y = 20 + this.int_2;
			for (int j = 0; j < this.int_0 * 2 + 1; j++)
			{
				int num2 = j * this.int_1;
				pt.X = 10 + num2;
				pt2.X = 10 + num2;
				paintEventArgs_0.Graphics.DrawLine(pen, pt, pt2);
			}
			Pen pen2 = new Pen(Color.Red);
			pt.X = 10;
			pt2.X = 10 + this.int_2;
			pt.Y = 20 + this.int_2 / 2;
			pt2.Y = 20 + this.int_2 / 2;
			paintEventArgs_0.Graphics.DrawLine(pen2, pt, pt2);
			pt.Y = 20;
			pt2.Y = 20 + this.int_2;
			pt.X = 10 + this.int_2 / 2;
			pt2.X = 10 + this.int_2 / 2;
			paintEventArgs_0.Graphics.DrawLine(pen2, pt, pt2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		private void method_1(PaintEventArgs paintEventArgs_0)
		{
			if (this.ChunkEntries == null)
			{
				return;
			}
			for (int i = 0; i < this.int_0 * 2; i++)
			{
				for (int j = 0; j < this.int_0 * 2; j++)
				{
					Point point = new Point(i * this.int_1 + 11, j * this.int_1 + 21);
					if (this.ChunkEntries[i][j].IsPresent)
					{
						Brush brush = new SolidBrush(Color.LightGray);
						paintEventArgs_0.Graphics.FillRectangle(brush, point.X, point.Y, this.int_1 - 2, this.int_1 - 2);
					}
				}
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		private void method_2(DimensionWorkingData dimensionWorkingData_1)
		{
			this.list_0 = new List<RegionDisplayChunk[]>();
			for (int i = 0; i < this.int_0 * 2; i++)
			{
				RegionDisplayChunk[] item = new RegionDisplayChunk[this.int_0 * 2];
				this.list_0.Add(item);
			}
			this.method_3(dimensionWorkingData_1.Dimension, "r.-1.-1", -1, -1, 0, 0, FileUtils.CheckFolderSep(dimensionWorkingData_1.Path) + "r.-1.-1.mcr");
			this.method_3(dimensionWorkingData_1.Dimension, "r.0.-1", 0, -1, this.int_0, 0, FileUtils.CheckFolderSep(dimensionWorkingData_1.Path) + "r.0.-1.mcr");
			this.method_3(dimensionWorkingData_1.Dimension, "r.-1.0", -1, 0, 0, this.int_0, FileUtils.CheckFolderSep(dimensionWorkingData_1.Path) + "r.-1.0.mcr");
			this.method_3(dimensionWorkingData_1.Dimension, "r.0.0", 0, 0, this.int_0, this.int_0, FileUtils.CheckFolderSep(dimensionWorkingData_1.Path) + "r.0.0.mcr");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		private List<RegionDisplayChunk[]> method_3(string string_0, string string_1, int int_5, int int_6, int int_7, int int_8, string string_2)
		{
			List<ChunkIndexEntry> list = Class36.smethod_4(string_2);
			if (list == null)
			{
				list = Class36.smethod_6();
			}
			int num = 32 - this.int_0;
			if (int_5 >= 0)
			{
				for (int i = 0; i < this.int_0; i++)
				{
					if (int_6 >= 0)
					{
						for (int j = 0; j < this.int_0; j++)
						{
							this.method_4(string_0, string_1, int_5, int_6, this.list_0, list, i, j, i + int_7, j + int_8);
						}
					}
					else
					{
						for (int k = this.int_0 - 1; k >= 0; k--)
						{
							this.method_4(string_0, string_1, int_5, int_6, this.list_0, list, i, k + num, i + int_7, k + int_8);
						}
					}
				}
			}
			else
			{
				for (int l = this.int_0 - 1; l >= 0; l--)
				{
					if (int_6 >= 0)
					{
						for (int m = 0; m < this.int_0; m++)
						{
							this.method_4(string_0, string_1, int_5, int_6, this.list_0, list, l + num, m, l + int_7, m + int_8);
						}
					}
					else
					{
						for (int n = this.int_0 - 1; n >= 0; n--)
						{
							this.method_4(string_0, string_1, int_5, int_6, this.list_0, list, l + num, n + num, l + int_7, n + int_8);
						}
					}
				}
			}
			return this.list_0;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000DA08 File Offset: 0x0000BC08
		private void method_4(string string_0, string string_1, int int_5, int int_6, List<RegionDisplayChunk[]> list_1, List<ChunkIndexEntry> list_2, int int_7, int int_8, int int_9, int int_10)
		{
			ChunkIndexEntry chunkIndexEntry = Class36.smethod_16(list_2, int_7, int_8);
			bool isPresent = Class36.smethod_15(list_2, int_7, int_8);
			RegionDisplayChunk regionDisplayChunk = new RegionDisplayChunk
			{
				Dimension = string_0,
				Region = string_1,
				ChunkIndex = chunkIndexEntry.ChunkIndex,
				IsPresent = isPresent,
				RX = int_5,
				RZ = int_6
			};
			list_1[int_9][int_10] = regionDisplayChunk;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000333A File Offset: 0x0000153A
		private void DimensionDisplay_Resize(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		private void method_5()
		{
			int num = (base.Width - 14) / (this.int_0 * 2);
			int num2 = (base.Height - 24) / (this.int_0 * 2);
			this.int_1 = ((num < num2) ? num : num2);
			this.int_2 = this.int_0 * 2 * this.int_1;
			this.label_1.Left = 10 + this.label_0.Left + this.label_0.Width;
			this.label_1.Top = 5;
			base.Invalidate();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003342 File Offset: 0x00001542
		private void DimensionDisplay_MouseMove(object sender, MouseEventArgs e)
		{
			this.method_6(e);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000F28C File Offset: 0x0000D48C
		private void DimensionDisplay_MouseLeave(object sender, EventArgs e)
		{
			this.label_1.Visible = false;
			Graphics graphics_ = base.CreateGraphics();
			this.method_11(this.int_3, this.int_4, this.method_10(this.int_3, this.int_4), graphics_);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000F2D4 File Offset: 0x0000D4D4
		private void method_6(MouseEventArgs mouseEventArgs_0)
		{
			if (this.list_0 == null)
			{
				this.label_1.Visible = false;
				return;
			}
			Graphics graphics_ = base.CreateGraphics();
			this.method_11(this.int_3, this.int_4, this.method_10(this.int_3, this.int_4), graphics_);
			int num = this.int_0 * 2;
			int num2 = mouseEventArgs_0.X;
			int num3 = mouseEventArgs_0.Y;
			if (num2 <= 10 || num3 <= 20)
			{
				this.label_1.Visible = false;
				return;
			}
			num2 -= 10;
			num3 -= 20;
			num2 /= this.int_2 / num;
			num3 /= this.int_2 / num;
			if (num2 >= num || num3 >= num)
			{
				this.label_1.Visible = false;
				return;
			}
			this.int_3 = num2;
			this.int_4 = num3;
			this.method_11(num2, num3, this.solidBrush_1, graphics_);
			RegionDisplayChunk regionDisplayChunk = this.list_0[num2][num3];
			num2 = ((num2 < this.int_0) ? num2 : (num2 - this.int_0));
			num3 = ((num3 < this.int_0) ? num3 : (num3 - this.int_0));
			int num4 = this.method_7(num2, regionDisplayChunk.RX);
			int num5 = this.method_8(num3, regionDisplayChunk.RZ);
			this.label_1.Visible = true;
			this.label_1.Text = string.Concat(new object[]
			{
				regionDisplayChunk.Region,
				"     Chunk [",
				num4,
				", ",
				num5,
				"]"
			});
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000334B File Offset: 0x0000154B
		private int method_7(int int_5, int int_6)
		{
			if (int_6 < 0)
			{
				return (this.int_0 - int_5) * -1;
			}
			return int_5;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000334B File Offset: 0x0000154B
		private int method_8(int int_5, int int_6)
		{
			if (int_6 < 0)
			{
				return (this.int_0 - int_5) * -1;
			}
			return int_5;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000F460 File Offset: 0x0000D660
		private void method_9(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (0600019C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.DimensionDisplay::method_9(System.Windows.Forms.MouseEventArgs)

 ---> System.Exception: Inconsistent stack size at IL_92
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000F504 File Offset: 0x0000D704
		protected virtual void OnChunkSelected(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000335D File Offset: 0x0000155D
		private void DimensionDisplay_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.method_9(e);
			}
			MouseButtons button = e.Button;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000337A File Offset: 0x0000157A
		private SolidBrush method_10(int int_5, int int_6)
		{
			if (!this.ChunkEntries[int_5][int_6].IsPresent)
			{
				return this.solidBrush_2;
			}
			return this.solidBrush_0;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000F524 File Offset: 0x0000D724
		private void method_11(int int_5, int int_6, SolidBrush solidBrush_3, Graphics graphics_0)
		{
			Point point = new Point(int_5 * this.int_1 + 11, int_6 * this.int_1 + 21);
			graphics_0.FillRectangle(solidBrush_3, point.X, point.Y, this.int_1 - 2, this.int_1 - 2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000339E File Offset: 0x0000159E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000F574 File Offset: 0x0000D774
		private void method_12()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(10, 5);
			this.label_0.Name = "lblCaption";
			this.label_0.Size = new Size(35, 13);
			this.label_0.TabIndex = 2;
			this.label_0.Text = "label1";
			this.label_1.Anchor = AnchorStyles.None;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(57, 252);
			this.label_1.MinimumSize = new Size(2, 0);
			this.label_1.Name = "lblPosition";
			this.label_1.Size = new Size(2, 13);
			this.label_1.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Name = "DimensionDisplay";
			base.Size = new Size(425, 311);
			base.MouseDown += this.DimensionDisplay_MouseDown;
			base.MouseLeave += this.DimensionDisplay_MouseLeave;
			base.MouseMove += this.DimensionDisplay_MouseMove;
			base.Resize += this.DimensionDisplay_Resize;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000D4 RID: 212
		private int int_0 = 27;

		// Token: 0x040000D5 RID: 213
		private int int_1 = 25;

		// Token: 0x040000D6 RID: 214
		private int int_2 = 800;

		// Token: 0x040000D7 RID: 215
		private int int_3;

		// Token: 0x040000D8 RID: 216
		private int int_4;

		// Token: 0x040000D9 RID: 217
		private SolidBrush solidBrush_0 = new SolidBrush(Color.LightGray);

		// Token: 0x040000DA RID: 218
		private SolidBrush solidBrush_1 = new SolidBrush(Color.Red);

		// Token: 0x040000DB RID: 219
		private SolidBrush solidBrush_2 = new SolidBrush(Color.White);

		// Token: 0x040000DC RID: 220
		private EventHandler eventHandler_0;

		// Token: 0x040000DD RID: 221
		private DimensionWorkingData dimensionWorkingData_0;

		// Token: 0x040000DE RID: 222
		private List<RegionDisplayChunk[]> list_0;

		// Token: 0x040000DF RID: 223
		private IContainer icontainer_0;

		// Token: 0x040000E0 RID: 224
		private Label label_0;

		// Token: 0x040000E1 RID: 225
		private Label label_1;
	}
}
