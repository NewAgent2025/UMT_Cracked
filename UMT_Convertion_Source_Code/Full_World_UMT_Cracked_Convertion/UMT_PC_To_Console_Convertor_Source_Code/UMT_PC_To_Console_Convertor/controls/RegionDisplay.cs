using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000037 RID: 55
	public class RegionDisplay : UserControl
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600025A RID: 602 RVA: 0x000149AC File Offset: 0x00012BAC
		// (remove) Token: 0x0600025B RID: 603 RVA: 0x000149E4 File Offset: 0x00012BE4
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

		// Token: 0x0600025C RID: 604 RVA: 0x00014A1C File Offset: 0x00012C1C
		public RegionDisplay()
		{
			this.method_10();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00003AC5 File Offset: 0x00001CC5
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00014A80 File Offset: 0x00012C80
		public RegionWorkingData RegionEntry
		{
			get
			{
				return this.regionWorkingData_0;
			}
			set
			{
				this.regionWorkingData_0 = value;
				this.list_0 = null;
				this.label_1.Text = "";
				this.int_3 = 0;
				this.int_4 = 0;
				if (value != null)
				{
					string str = Constants.dimensionNames[value.IndexEntry.ParentName];
					string str2 = this.regionWorkingData_0.IndexEntry.FileName.Substring(0, this.regionWorkingData_0.IndexEntry.FileName.Length - 4);
					this.label_1.Text = str + "    " + str2;
					if (value.IndexEntry.ParentName == "region")
					{
						this.int_0 = 27;
					}
					else
					{
						this.int_0 = 9;
					}
					this.method_2(this.regionWorkingData_0);
					this.method_3();
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00003ACD File Offset: 0x00001CCD
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003AD5 File Offset: 0x00001CD5
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

		// Token: 0x06000261 RID: 609 RVA: 0x00003ADE File Offset: 0x00001CDE
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			this.method_0(pe);
			this.method_1(pe);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00014B58 File Offset: 0x00012D58
		private void method_0(PaintEventArgs paintEventArgs_0)
		{
			Brush brush = new SolidBrush(Color.White);
			paintEventArgs_0.Graphics.FillRectangle(brush, 10, 20, this.int_2, this.int_2);
			Pen pen = new Pen(Color.LightGray);
			Point pt = new Point(10, 20);
			Point pt2 = new Point(10 + this.int_2, 20);
			for (int i = 0; i < this.int_0 + 1; i++)
			{
				int num = i * this.int_1;
				pt.Y = 20 + num;
				pt2.Y = 20 + num;
				paintEventArgs_0.Graphics.DrawLine(pen, pt, pt2);
			}
			pt.Y = 20;
			pt2.Y = 20 + this.int_2;
			for (int j = 0; j < this.int_0 + 1; j++)
			{
				int num2 = j * this.int_1;
				pt.X = 10 + num2;
				pt2.X = 10 + num2;
				paintEventArgs_0.Graphics.DrawLine(pen, pt, pt2);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00014C60 File Offset: 0x00012E60
		private void method_1(PaintEventArgs paintEventArgs_0)
		{
			if (this.ChunkEntries == null)
			{
				return;
			}
			for (int i = 0; i < this.int_0; i++)
			{
				for (int j = 0; j < this.int_0; j++)
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

		// Token: 0x06000264 RID: 612 RVA: 0x00014D08 File Offset: 0x00012F08
		private List<RegionDisplayChunk[]> method_2(RegionWorkingData regionWorkingData_1)
		{
			int rx = regionWorkingData_1.IndexEntry.RX;
			int rz = regionWorkingData_1.IndexEntry.RZ;
			this.list_0 = new List<RegionDisplayChunk[]>();
			List<ChunkIndexEntry> list = Class36.smethod_4(regionWorkingData_1.Path);
			if (list == null)
			{
				list = Class36.smethod_6();
			}
			int num = 32 - this.int_0;
			for (int i = 0; i < this.int_0; i++)
			{
				RegionDisplayChunk[] item = new RegionDisplayChunk[this.int_0];
				this.list_0.Add(item);
			}
			if (regionWorkingData_1.IndexEntry.RX >= 0)
			{
				for (int j = 0; j < this.int_0; j++)
				{
					if (regionWorkingData_1.IndexEntry.RZ >= 0)
					{
						for (int k = 0; k < this.int_0; k++)
						{
							this.CiscLulYdM(regionWorkingData_1.IndexEntry, list, j, k, j, k);
						}
					}
					else
					{
						for (int l = this.int_0 - 1; l >= 0; l--)
						{
							this.CiscLulYdM(regionWorkingData_1.IndexEntry, list, j, l + num, j, l);
						}
					}
				}
			}
			else
			{
				for (int m = this.int_0 - 1; m >= 0; m--)
				{
					if (regionWorkingData_1.IndexEntry.RZ >= 0)
					{
						for (int n = 0; n < this.int_0; n++)
						{
							this.CiscLulYdM(regionWorkingData_1.IndexEntry, list, m + num, n, m, n);
						}
					}
					else
					{
						for (int num2 = this.int_0 - 1; num2 >= 0; num2--)
						{
							this.CiscLulYdM(regionWorkingData_1.IndexEntry, list, m + num, num2 + num, m, num2);
						}
					}
				}
			}
			return this.list_0;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00014EAC File Offset: 0x000130AC
		private void CiscLulYdM(IndexEntry indexEntry_0, List<ChunkIndexEntry> list_1, int int_5, int int_6, int int_7, int int_8)
		{
			ChunkIndexEntry chunkIndexEntry = Class36.smethod_16(list_1, int_5, int_6);
			bool isPresent = Class36.smethod_15(list_1, int_5, int_6);
			RegionDisplayChunk regionDisplayChunk = new RegionDisplayChunk
			{
				IsPresent = isPresent,
				ChunkIndex = chunkIndexEntry.ChunkIndex
			};
			this.list_0[int_7][int_8] = regionDisplayChunk;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003AF5 File Offset: 0x00001CF5
		private void RegionDisplay_Resize(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00014EFC File Offset: 0x000130FC
		private void method_3()
		{
			int num = (base.Width - 12) / this.int_0;
			int num2 = (base.Height - 20) / this.int_0;
			this.int_1 = ((num < num2) ? num : num2);
			this.int_2 = this.int_0 * this.int_1;
			this.label_0.Left = 10 + this.label_1.Left + this.label_1.Width;
			this.label_0.Top = 5;
			base.Invalidate();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00003AFD File Offset: 0x00001CFD
		private void RegionDisplay_MouseMove(object sender, MouseEventArgs e)
		{
			this.method_4(e);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00014F84 File Offset: 0x00013184
		private void RegionDisplay_MouseLeave(object sender, EventArgs e)
		{
			this.label_0.Visible = false;
			Graphics graphics_ = base.CreateGraphics();
			this.method_9(this.int_3, this.int_4, this.method_8(this.int_3, this.int_4), graphics_);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00014FCC File Offset: 0x000131CC
		private void method_4(MouseEventArgs mouseEventArgs_0)
		{
			if (this.list_0 == null)
			{
				this.label_0.Visible = false;
				return;
			}
			Graphics graphics_ = base.CreateGraphics();
			this.method_9(this.int_3, this.int_4, this.method_8(this.int_3, this.int_4), graphics_);
			int num = mouseEventArgs_0.X;
			int num2 = mouseEventArgs_0.Y;
			if (num <= 10 || num2 <= 20)
			{
				this.label_0.Visible = false;
				return;
			}
			num -= 10;
			num2 -= 20;
			num /= this.int_2 / this.int_0;
			num2 /= this.int_2 / this.int_0;
			if (num >= this.int_0 || num2 >= this.int_0)
			{
				this.label_0.Visible = false;
				return;
			}
			this.int_3 = num;
			this.int_4 = num2;
			this.method_9(num, num2, this.solidBrush_1, graphics_);
			int num3 = this.method_5(num, this.regionWorkingData_0.IndexEntry.RX);
			int num4 = this.method_6(num2, this.regionWorkingData_0.IndexEntry.RZ);
			this.label_0.Visible = true;
			this.label_0.Text = string.Concat(new object[]
			{
				"Chunk [",
				num3,
				", ",
				num4,
				"]"
			});
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00003B06 File Offset: 0x00001D06
		private int method_5(int int_5, int int_6)
		{
			if (int_6 < 0)
			{
				return (this.int_0 - int_5) * -1;
			}
			return int_5;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00003B06 File Offset: 0x00001D06
		private int method_6(int int_5, int int_6)
		{
			if (int_6 < 0)
			{
				return (this.int_0 - int_5) * -1;
			}
			return int_5;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001512C File Offset: 0x0001332C
		private void method_7(MouseEventArgs mouseEventArgs_0)
		{
			/*
An exception occurred when decompiling this method (0600026D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.RegionDisplay::method_7(System.Windows.Forms.MouseEventArgs)

 ---> System.Exception: Inconsistent stack size at IL_D1
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00015210 File Offset: 0x00013410
		protected virtual void OnChunkSelected(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003B18 File Offset: 0x00001D18
		private void RegionDisplay_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.method_7(e);
			}
			MouseButtons button = e.Button;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00003B35 File Offset: 0x00001D35
		private SolidBrush method_8(int int_5, int int_6)
		{
			if (!this.ChunkEntries[int_5][int_6].IsPresent)
			{
				return this.solidBrush_2;
			}
			return this.solidBrush_0;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00015230 File Offset: 0x00013430
		private void method_9(int int_5, int int_6, SolidBrush solidBrush_3, Graphics graphics_0)
		{
			Point point = new Point(int_5 * this.int_1 + 11, int_6 * this.int_1 + 21);
			graphics_0.FillRectangle(solidBrush_3, point.X, point.Y, this.int_1 - 2, this.int_1 - 2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003B59 File Offset: 0x00001D59
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00015280 File Offset: 0x00013480
		private void method_10()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			base.SuspendLayout();
			this.label_0.Anchor = AnchorStyles.None;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(3, 146);
			this.label_0.MinimumSize = new Size(2, 0);
			this.label_0.Name = "lblPosition";
			this.label_0.Size = new Size(2, 13);
			this.label_0.TabIndex = 0;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(10, 5);
			this.label_1.Name = "lblCaption";
			this.label_1.Size = new Size(35, 13);
			this.label_1.TabIndex = 1;
			this.label_1.Text = "label1";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Name = "RegionDisplay";
			base.Size = new Size(150, 165);
			base.MouseDown += this.RegionDisplay_MouseDown;
			base.MouseLeave += this.RegionDisplay_MouseLeave;
			base.MouseMove += this.RegionDisplay_MouseMove;
			base.Resize += this.RegionDisplay_Resize;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000163 RID: 355
		private int int_0 = 27;

		// Token: 0x04000164 RID: 356
		private int int_1 = 25;

		// Token: 0x04000165 RID: 357
		private int int_2 = 800;

		// Token: 0x04000166 RID: 358
		private int int_3;

		// Token: 0x04000167 RID: 359
		private int int_4;

		// Token: 0x04000168 RID: 360
		private SolidBrush solidBrush_0 = new SolidBrush(Color.LightGray);

		// Token: 0x04000169 RID: 361
		private SolidBrush solidBrush_1 = new SolidBrush(Color.Red);

		// Token: 0x0400016A RID: 362
		private SolidBrush solidBrush_2 = new SolidBrush(Color.White);

		// Token: 0x0400016B RID: 363
		private EventHandler eventHandler_0;

		// Token: 0x0400016C RID: 364
		private RegionWorkingData regionWorkingData_0;

		// Token: 0x0400016D RID: 365
		private List<RegionDisplayChunk[]> list_0;

		// Token: 0x0400016E RID: 366
		private IContainer icontainer_0;

		// Token: 0x0400016F RID: 367
		private Label label_0;

		// Token: 0x04000170 RID: 368
		private Label label_1;
	}
}
