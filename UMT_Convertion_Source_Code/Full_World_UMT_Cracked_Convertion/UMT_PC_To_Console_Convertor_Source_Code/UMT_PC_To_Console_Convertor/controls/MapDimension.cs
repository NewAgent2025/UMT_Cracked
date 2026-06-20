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
	// Token: 0x02000027 RID: 39
	public class MapDimension : UserControl
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000140 RID: 320 RVA: 0x0000D198 File Offset: 0x0000B398
		// (remove) Token: 0x06000141 RID: 321 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
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

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000142 RID: 322 RVA: 0x0000D208 File Offset: 0x0000B408
		// (remove) Token: 0x06000143 RID: 323 RVA: 0x0000D240 File Offset: 0x0000B440
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

		// Token: 0x06000144 RID: 324 RVA: 0x0000D278 File Offset: 0x0000B478
		public void SetChunkSelected(int x, int y)
		{
			Graphics graphics_ = base.CreateGraphics();
			if (this.bool_1)
			{
				this.method_12(this.int_5, this.int_6, graphics_);
			}
			this.bool_1 = true;
			this.int_5 = x;
			this.int_6 = y;
			this.method_14(this.int_5, this.int_6, this.solidBrush_1, graphics_);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000030CF File Offset: 0x000012CF
		public Bitmap Map
		{
			get
			{
				return (Bitmap)this.image_0;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public MapDimension()
		{
			this.VbuGsehKwa();
			this.method_15();
			this.timer_0 = new System.Windows.Forms.Timer();
			this.timer_0.Interval = 200;
			this.timer_0.Tick += this.timer_0_Tick;
			base.MouseWheel += this.MapDimension_MouseWheel;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.timer_0.Stop();
			if (this.bool_2)
			{
				this.method_13();
			}
			if (this.bool_1)
			{
				Graphics graphics_ = base.CreateGraphics();
				this.method_14(this.int_5, this.int_6, this.solidBrush_1, graphics_);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000030DC File Offset: 0x000012DC
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000030E4 File Offset: 0x000012E4
		public bool ShowGrid
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				this.bool_2 = true;
				base.Invalidate();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000030FA File Offset: 0x000012FA
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000D400 File Offset: 0x0000B600
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
				this.bool_1 = false;
				if (value != null)
				{
					string text = Constants.dimensionNames[value.Dimension];
					this.label_0.Text = text;
					if (value.Dimension == "region")
					{
						this.int_0 = 27;
					}
					else if (value.Dimension == "DIM-1")
					{
						this.int_0 = 9;
					}
					else if (value.Dimension == "DIM1")
					{
						this.int_0 = 32;
					}
					this.method_2(this.dimensionWorkingData_0);
					this.method_5();
					this.method_16(this.dimensionWorkingData_0);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00003102 File Offset: 0x00001302
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000310A File Offset: 0x0000130A
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

		// Token: 0x0600014E RID: 334 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			this.method_0(pe);
			if (this.bool_0)
			{
				this.method_1(pe);
			}
			if (this.bool_1 && !this.bool_2)
			{
				this.method_14(this.int_5, this.int_6, this.solidBrush_1, pe.Graphics);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000D534 File Offset: 0x0000B734
		private void method_0(PaintEventArgs paintEventArgs_0)
		{
			this.timer_0.Stop();
			if (this.image_0 != null)
			{
				Rectangle r = new Rectangle(80, 80, 864, 864);
				if (this.dimensionWorkingData_0.Dimension == "DIM-1")
				{
					r = new Rectangle(368, 368, 288, 288);
				}
				else if (this.dimensionWorkingData_0.Dimension == "DIM1")
				{
					r = new Rectangle(0, 0, 1024, 1024);
				}
				RectangleF destRect = new RectangleF(10f, 20f, (float)this.int_2, (float)this.int_2);
				paintEventArgs_0.Graphics.DrawImage(this.image_0, destRect, r, GraphicsUnit.Pixel);
			}
			if (this.bool_2)
			{
				this.timer_0.Start();
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000D614 File Offset: 0x0000B814
		private void method_1(PaintEventArgs paintEventArgs_0)
		{
			new SolidBrush(Color.White);
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

		// Token: 0x06000151 RID: 337 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		private void method_2(DimensionWorkingData dimensionWorkingData_1)
		{
			this.list_0 = new List<RegionDisplayChunk[]>();
			for (int i = 0; i < this.int_0 * 2; i++)
			{
				RegionDisplayChunk[] item = new RegionDisplayChunk[this.int_0 * 2];
				this.list_0.Add(item);
			}
			string folderPath = FileUtils.CheckFolderSep(dimensionWorkingData_1.Path) + FileUtils.CheckFolderSep(Working.smethod_4()) + dimensionWorkingData_1.Dimension;
			this.method_3(dimensionWorkingData_1.Dimension, "r.-1.-1", -1, -1, 0, 0, FileUtils.CheckFolderSep(folderPath) + "r.-1.-1.mcr");
			this.method_3(dimensionWorkingData_1.Dimension, "r.0.-1", 0, -1, this.int_0, 0, FileUtils.CheckFolderSep(folderPath) + "r.0.-1.mcr");
			this.method_3(dimensionWorkingData_1.Dimension, "r.-1.0", -1, 0, 0, this.int_0, FileUtils.CheckFolderSep(folderPath) + "r.-1.0.mcr");
			this.method_3(dimensionWorkingData_1.Dimension, "r.0.0", 0, 0, this.int_0, this.int_0, FileUtils.CheckFolderSep(folderPath) + "r.0.0.mcr");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		private List<RegionDisplayChunk[]> method_3(string string_0, string string_1, int int_7, int int_8, int int_9, int int_10, string string_2)
		{
			List<ChunkIndexEntry> list = Class36.smethod_4(string_2);
			if (list == null)
			{
				list = Class36.smethod_6();
			}
			int num = 32 - this.int_0;
			if (int_7 >= 0)
			{
				for (int i = 0; i < this.int_0; i++)
				{
					if (int_8 >= 0)
					{
						for (int j = 0; j < this.int_0; j++)
						{
							this.method_4(string_0, string_1, int_7, int_8, this.list_0, list, i, j, i + int_9, j + int_10);
						}
					}
					else
					{
						for (int k = this.int_0 - 1; k >= 0; k--)
						{
							this.method_4(string_0, string_1, int_7, int_8, this.list_0, list, i, k + num, i + int_9, k + int_10);
						}
					}
				}
			}
			else
			{
				for (int l = this.int_0 - 1; l >= 0; l--)
				{
					if (int_8 >= 0)
					{
						for (int m = 0; m < this.int_0; m++)
						{
							this.method_4(string_0, string_1, int_7, int_8, this.list_0, list, l + num, m, l + int_9, m + int_10);
						}
					}
					else
					{
						for (int n = this.int_0 - 1; n >= 0; n--)
						{
							this.method_4(string_0, string_1, int_7, int_8, this.list_0, list, l + num, n + num, l + int_9, n + int_10);
						}
					}
				}
			}
			return this.list_0;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000DA08 File Offset: 0x0000BC08
		private void method_4(string string_0, string string_1, int int_7, int int_8, List<RegionDisplayChunk[]> list_1, List<ChunkIndexEntry> list_2, int int_9, int int_10, int int_11, int int_12)
		{
			ChunkIndexEntry chunkIndexEntry = Class36.smethod_16(list_2, int_9, int_10);
			bool isPresent = Class36.smethod_15(list_2, int_9, int_10);
			RegionDisplayChunk regionDisplayChunk = new RegionDisplayChunk
			{
				Dimension = string_0,
				Region = string_1,
				ChunkIndex = chunkIndexEntry.ChunkIndex,
				IsPresent = isPresent,
				RX = int_7,
				RZ = int_8
			};
			list_1[int_11][int_12] = regionDisplayChunk;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003113 File Offset: 0x00001313
		private void MapDimension_Resize(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000DA74 File Offset: 0x0000BC74
		private void method_5()
		{
			int num = (base.Width - 14) / (this.int_0 * 2);
			int num2 = (base.Height - 24) / (this.int_0 * 2);
			this.int_1 = ((num < num2) ? num : num2);
			this.int_2 = this.int_0 * 2 * this.int_1;
			this.label_1.Left = 10 + this.label_0.Left + this.label_0.Width;
			this.label_1.Top = 5;
			this.bool_2 = true;
			base.Invalidate();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000311B File Offset: 0x0000131B
		private void MapDimension_MouseMove(object sender, MouseEventArgs e)
		{
			if (!this.bool_2)
			{
				this.method_6(e);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000DB08 File Offset: 0x0000BD08
		private void qgahzOnAe1(object sender, EventArgs e)
		{
			this.label_1.Visible = false;
			Graphics graphics_ = base.CreateGraphics();
			this.method_12(this.int_3, this.int_4, graphics_);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		private void method_6(MouseEventArgs mouseEventArgs_0)
		{
			if (this.list_0 == null)
			{
				this.label_1.Visible = false;
				return;
			}
			Graphics graphics_ = base.CreateGraphics();
			if (this.int_5 == this.int_3)
			{
				if (this.int_6 == this.int_4)
				{
					goto IL_3F;
				}
			}
			this.method_12(this.int_3, this.int_4, graphics_);
			IL_3F:
			if (this.bool_1)
			{
				this.method_14(this.int_5, this.int_6, this.solidBrush_1, graphics_);
			}
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
			this.method_14(num2, num3, this.solidBrush_1, graphics_);
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

		// Token: 0x06000159 RID: 345 RVA: 0x0000312C File Offset: 0x0000132C
		private int method_7(int int_7, int int_8)
		{
			if (int_8 < 0)
			{
				return (this.int_0 - int_7) * -1;
			}
			return int_7;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000312C File Offset: 0x0000132C
		private int method_8(int int_7, int int_8)
		{
			if (int_8 < 0)
			{
				return (this.int_0 - int_7) * -1;
			}
			return int_7;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		private void method_9(MouseEventArgs mouseEventArgs_0)
		{
			int num = mouseEventArgs_0.X;
			int num2 = mouseEventArgs_0.Y;
			int num3 = this.int_0 * 2;
			if (num > 10 && num2 > 20)
			{
				num -= 10;
				num2 -= 20;
				num /= this.int_2 / num3;
				num2 /= this.int_2 / num3;
				this.method_10(num, num2);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000DD50 File Offset: 0x0000BF50
		private void method_10(int int_7, int int_8)
		{
			/*
An exception occurred when decompiling this method (0600015C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapDimension::method_10(System.Int32,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_56
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		protected virtual void OnChunkSelected(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		protected virtual void OnMapUpdated(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000313E File Offset: 0x0000133E
		private void MapDimension_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.method_9(e);
			}
			MouseButtons button = e.Button;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000315B File Offset: 0x0000135B
		private SolidBrush method_11(int int_7, int int_8)
		{
			return this.solidBrush_0;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		private void method_12(int int_7, int int_8, Graphics graphics_0)
		{
			Rectangle rectangle = new Rectangle(int_7 * this.int_1 + 9, int_8 * this.int_1 + 19, this.int_1 + 2, this.int_1 + 2);
			graphics_0.DrawImage(this.bitmap_0, rectangle, rectangle, GraphicsUnit.Pixel);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000DE44 File Offset: 0x0000C044
		private void method_13()
		{
			if (base.Width > this.bitmap_0.Width || base.Height > this.bitmap_0.Height)
			{
				goto IL_5B;
			}
			try
			{
				IL_26:
				base.DrawToBitmap(this.bitmap_0, new Rectangle(0, 0, this.bitmap_0.Width, this.bitmap_0.Height));
				this.bool_2 = false;
				return;
			}
			catch (Exception)
			{
				return;
			}
			IL_5B:
			this.bitmap_0 = new Bitmap(base.Width, this.bitmap_0.Height);
			goto IL_26;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000DEDC File Offset: 0x0000C0DC
		private void method_14(int int_7, int int_8, SolidBrush solidBrush_3, Graphics graphics_0)
		{
			Point point = new Point(int_7 * this.int_1 + 11, int_8 * this.int_1 + 21);
			Pen pen = new Pen(solidBrush_3);
			graphics_0.DrawRectangle(pen, point.X - 1, point.Y - 1, this.int_1, this.int_1);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000DF34 File Offset: 0x0000C134
		private void method_15()
		{
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.backgroundWorker_0.WorkerReportsProgress = true;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000DF94 File Offset: 0x0000C194
		private void method_16(DimensionWorkingData dimensionWorkingData_1)
		{
			if (!this.backgroundWorker_0.IsBusy)
			{
				string dimension = dimensionWorkingData_1.Dimension;
				MapBlockParameter mapBlockParameter = new MapBlockParameter();
				mapBlockParameter.OutFolderPath = dimensionWorkingData_1.Path;
				mapBlockParameter.Dimension = dimension;
				this.backgroundWorker_0.RunWorkerAsync(mapBlockParameter);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000166)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapDimension::backgroundWorker_0_DoWork(System.Object,System.ComponentModel.DoWorkEventArgs)

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

		// Token: 0x06000167 RID: 359 RVA: 0x00003163 File Offset: 0x00001363
		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003165 File Offset: 0x00001365
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.image_0 = null;
			if (e.Result != null && e.Result is Image)
			{
				this.image_0 = (e.Result as Image);
				this.method_17();
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000319A File Offset: 0x0000139A
		private void method_17()
		{
			this.bool_2 = true;
			base.Invalidate();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000E020 File Offset: 0x0000C220
		private void method_18(int int_7)
		{
			int num = this.int_5 + int_7;
			if (num < 0)
			{
				num = 0;
			}
			else if (num > 54)
			{
				num = 54;
			}
			this.method_10(num, this.int_6);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000E054 File Offset: 0x0000C254
		private void method_19(int int_7)
		{
			int num = this.int_6 + int_7;
			if (num < 0)
			{
				num = 0;
			}
			else if (num > 54)
			{
				num = 54;
			}
			this.method_10(this.int_5, num);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000031A9 File Offset: 0x000013A9
		private void MapDimension_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000E088 File Offset: 0x0000C288
		protected override bool IsInputKey(Keys keyData)
		{
			bool flag = false;
			switch (keyData)
			{
			case Keys.Left:
				this.method_18(-1);
				flag = true;
				break;
			case Keys.Up:
				this.method_19(-1);
				flag = true;
				break;
			case Keys.Right:
				this.method_18(1);
				flag = true;
				break;
			case Keys.Down:
				this.method_19(1);
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
			return flag || base.IsInputKey(keyData);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000E10C File Offset: 0x0000C30C
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

		// Token: 0x0600016F RID: 367 RVA: 0x00003163 File Offset: 0x00001363
		private void MapDimension_MouseWheel(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000031B2 File Offset: 0x000013B2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000E14C File Offset: 0x0000C34C
		private void VbuGsehKwa()
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
			this.label_1.Location = new Point(92, 307);
			this.label_1.MinimumSize = new Size(2, 0);
			this.label_1.Name = "lblPosition";
			this.label_1.Size = new Size(2, 13);
			this.label_1.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Name = "MapDimension";
			base.Size = new Size(495, 420);
			base.KeyDown += this.MapDimension_KeyDown;
			base.MouseDown += this.MapDimension_MouseDown;
			base.MouseLeave += this.qgahzOnAe1;
			base.MouseMove += this.MapDimension_MouseMove;
			base.Resize += this.MapDimension_Resize;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000AF RID: 175
		private bool bool_0 = true;

		// Token: 0x040000B0 RID: 176
		private Image image_0;

		// Token: 0x040000B1 RID: 177
		private int int_0 = 27;

		// Token: 0x040000B2 RID: 178
		private int int_1 = 25;

		// Token: 0x040000B3 RID: 179
		private int int_2 = 800;

		// Token: 0x040000B4 RID: 180
		private int int_3;

		// Token: 0x040000B5 RID: 181
		private int int_4;

		// Token: 0x040000B6 RID: 182
		private int int_5;

		// Token: 0x040000B7 RID: 183
		private int int_6;

		// Token: 0x040000B8 RID: 184
		private bool bool_1;

		// Token: 0x040000B9 RID: 185
		private SolidBrush solidBrush_0 = new SolidBrush(Color.LightGray);

		// Token: 0x040000BA RID: 186
		private SolidBrush solidBrush_1 = new SolidBrush(Color.Red);

		// Token: 0x040000BB RID: 187
		private SolidBrush solidBrush_2 = new SolidBrush(Color.White);

		// Token: 0x040000BC RID: 188
		private EventHandler eventHandler_0;

		// Token: 0x040000BD RID: 189
		private EventHandler eventHandler_1;

		// Token: 0x040000BE RID: 190
		private DimensionWorkingData dimensionWorkingData_0;

		// Token: 0x040000BF RID: 191
		private List<RegionDisplayChunk[]> list_0;

		// Token: 0x040000C0 RID: 192
		private Bitmap bitmap_0 = new Bitmap(1024, 1024);

		// Token: 0x040000C1 RID: 193
		private bool bool_2;

		// Token: 0x040000C2 RID: 194
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x040000C3 RID: 195
		private BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

		// Token: 0x040000C4 RID: 196
		private IContainer icontainer_0;

		// Token: 0x040000C5 RID: 197
		private Label label_0;

		// Token: 0x040000C6 RID: 198
		private Label label_1;
	}
}
