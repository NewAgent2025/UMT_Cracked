using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Full_UMT_Convertor.controls;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000031 RID: 49
	public partial class ConvertOffsetDisplay : Form
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000031BC File Offset: 0x000013BC
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000031C4 File Offset: 0x000013C4
		public int RxOffset
		{
			get
			{
				return this.rxOffset;
			}
			set
			{
				this.rxOffset = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000031CD File Offset: 0x000013CD
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x000031D5 File Offset: 0x000013D5
		public int RzOffset
		{
			get
			{
				return this.rzOffset;
			}
			set
			{
				this.rzOffset = value;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		public ConvertOffsetDisplay(List<PEDimension> bedrockDims, int rxOffset, int rzOffset)
		{
			this.method_10();
			this.bool_0 = true;
			this.rxOffset = rxOffset;
			this.rzOffset = rzOffset;
			this.numericUpDown_1.Value = rxOffset;
			this.numericUpDown_0.Value = rzOffset;
			int num = this.int_1 * this.int_2;
			this.doubleBufferPanel_0.Width = this.int_0 + num + this.int_0;
			this.doubleBufferPanel_0.Height = this.int_0 + num + this.int_0;
			this.doubleBufferPanel_0.Paint += this.OnPanelPaint;
			this.bedrockDims = bedrockDims;
			this.label_1.BackColor = this.color_0;
			this.label_0.BackColor = this.sIyBiMwvnv;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00010BAC File Offset: 0x0000EDAC
		private void ConvertOffsetDisplay_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ConvertOffsetDisplay::ConvertOffsetDisplay_Load(System.Object,System.EventArgs)

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

		// Token: 0x060001B8 RID: 440 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		protected void OnPanelPaint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			this.bool_0 = true;
			this.method_0(graphics);
			this.method_1(graphics);
			this.bool_0 = false;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00010CD4 File Offset: 0x0000EED4
		private void method_0(Graphics graphics_0)
		{
			int num = this.int_2;
			Pen pen = new Pen(Color.LightGray);
			Point pt = new Point(this.int_0, this.int_0);
			Point pt2 = new Point(this.int_0 + this.int_1 * num, this.int_0);
			for (int i = 0; i < this.int_1 + 1; i++)
			{
				int num2 = i * num;
				pt.Y = this.int_0 + num2;
				pt2.Y = this.int_0 + num2;
				graphics_0.DrawLine(pen, pt, pt2);
			}
			pt.Y = this.int_0;
			pt2.Y = this.int_0 + this.int_1 * num;
			for (int j = 0; j < this.int_1 + 1; j++)
			{
				int num2 = j * num;
				pt.X = this.int_0 + num2;
				pt2.X = this.int_0 + num2;
				graphics_0.DrawLine(pen, pt, pt2);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00010DD4 File Offset: 0x0000EFD4
		private void method_1(Graphics graphics_0)
		{
			int int_ = 5010;
			if (this.checkBox_1.Checked)
			{
				this.method_2(int_, this.list_0, this.sIyBiMwvnv, graphics_0, this.rxOffset, this.rzOffset);
			}
			if (this.checkBox_0.Checked)
			{
				this.method_2(int_, this.list_1, this.color_0, graphics_0, 0, 0);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00010E38 File Offset: 0x0000F038
		private void method_2(int int_3, List<RegionEntry> list_2, Color color_1, Graphics graphics_0, int int_4 = 0, int int_5 = 0)
		{
			if (list_2 == null)
			{
				return;
			}
			SolidBrush brush = new SolidBrush(Color.FromArgb(128, (int)color_1.R, (int)color_1.G, (int)color_1.B));
			foreach (RegionEntry regionEntry in list_2)
			{
				int x = (regionEntry.RX + int_4) * this.int_2 + int_3;
				int y = (regionEntry.RZ + int_5) * this.int_2 + int_3;
				Point point = new Point(x, y);
				graphics_0.FillRectangle(brush, point.X + 1, point.Y + 1, this.int_2 - 1, this.int_2 - 1);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		private List<RegionEntry> method_3(string string_0)
		{
			List<RegionEntry> list = new List<RegionEntry>();
			string text = Path.Combine(string_0, Working.smethod_4(), "region");
			if (FileUtils.CheckFolderExists(text))
			{
				string[] files = Directory.GetFiles(text, "*.mcr");
				for (int i = 0; i < files.Length; i++)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i].ToString());
					string[] array = fileNameWithoutExtension.Split(new char[]
					{
						'.'
					});
					if (array.Length == 3)
					{
						int rX = int.Parse(array[1]);
						int rZ = int.Parse(array[2]);
						RegionEntry item = new RegionEntry(rX, rZ);
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		private List<RegionEntry> method_4(string string_0)
		{
			List<RegionEntry> list = new List<RegionEntry>();
			string text = Path.Combine(string_0, "region");
			if (FileUtils.CheckFolderExists(text))
			{
				string[] files = Directory.GetFiles(text, "*.mca");
				for (int i = 0; i < files.Length; i++)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i].ToString());
					string[] array = fileNameWithoutExtension.Split(new char[]
					{
						'.'
					});
					if (array.Length == 3)
					{
						int rX = int.Parse(array[1]);
						int rZ = int.Parse(array[2]);
						RegionEntry item = new RegionEntry(rX, rZ);
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00010F04 File Offset: 0x0000F104
		private List<RegionEntry> method_5()
		{
			List<RegionEntry> list = new List<RegionEntry>();
			PEDimension pedimension = PEUtility.GetPEDimension("region");
			foreach (PERegion peregion in pedimension.Region.Values)
			{
				RegionEntry item = new RegionEntry(peregion.RX, peregion.RZ);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00010F84 File Offset: 0x0000F184
		private List<RegionEntry> method_6(List<PEDimension> list_2)
		{
			List<RegionEntry> list = new List<RegionEntry>();
			PEDimension pedimension = list_2[0];
			foreach (PERegion peregion in pedimension.Region.Values)
			{
				RegionEntry item = new RegionEntry(peregion.RX, peregion.RZ);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00011000 File Offset: 0x0000F200
		private void label_1_Click(object sender, EventArgs e)
		{
			RegionEntry regionEntry_ = this.method_9(this.list_1);
			this.method_7(regionEntry_, 0, 0);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00011024 File Offset: 0x0000F224
		private void label_0_Click(object sender, EventArgs e)
		{
			RegionEntry regionEntry_ = this.method_9(this.list_0);
			this.method_7(regionEntry_, this.rxOffset, this.rzOffset);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00011054 File Offset: 0x0000F254
		private void method_7(RegionEntry regionEntry_0, int int_3 = 0, int int_4 = 0)
		{
			if (regionEntry_0 != null)
			{
				int num = this.int_0 + this.int_1 * this.int_2 / 2;
				int num2 = (regionEntry_0.RX + int_3) * this.int_2 + num;
				int num3 = (regionEntry_0.RZ + int_4) * this.int_2 + num;
				this.flowLayoutPanel_0.AutoScrollPosition = new Point(num2 - this.flowLayoutPanel_0.ClientRectangle.Width / 2, num3 - this.flowLayoutPanel_0.ClientRectangle.Height / 2);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000110E0 File Offset: 0x0000F2E0
		private void doubleBufferPanel_0_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.label_4.Visible = true;
			int num = this.int_0 + this.int_1 * this.int_2 / 2;
			Point point = this.doubleBufferPanel_0.PointToClient(Cursor.Position);
			int num2 = (point.X - num) / this.int_2;
			int num3 = (point.Y - num) / this.int_2;
			if (point.X < num)
			{
				num2 += -1;
			}
			if (point.Y < num)
			{
				num3 += -1;
			}
			this.label_4.Text = num2.ToString() + "," + num3.ToString();
			this.label_4.Left = e.X - this.label_4.Width / 2;
			this.label_4.Top = e.Y + this.label_4.Height * 2;
			if (e.Button == MouseButtons.Left)
			{
				this.method_8();
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000031DE File Offset: 0x000013DE
		private void doubleBufferPanel_0_MouseLeave(object sender, EventArgs e)
		{
			this.label_4.Visible = false;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000031EC File Offset: 0x000013EC
		private void checkBox_1_CheckedChanged(object sender, EventArgs e)
		{
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000031EC File Offset: 0x000013EC
		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000111DC File Offset: 0x0000F3DC
		private void method_8()
		{
			int num = this.int_0 + this.int_1 * this.int_2 / 2;
			Point point = this.doubleBufferPanel_0.PointToClient(Cursor.Position);
			int num2 = (point.X - num) / this.int_2;
			int num3 = (point.Y - num) / this.int_2;
			if (point.X < num)
			{
				num2 += -1;
			}
			if (point.Y < num)
			{
				num3 += -1;
			}
			RegionEntry regionEntry = this.method_9(this.list_0);
			this.rxOffset = ((regionEntry.RX < num2) ? Math.Abs(num2 - regionEntry.RX) : (Math.Abs(regionEntry.RX - num2) * -1));
			this.rzOffset = ((regionEntry.RZ < num3) ? Math.Abs(num3 - regionEntry.RZ) : (Math.Abs(regionEntry.RZ - num3) * -1));
			this.numericUpDown_1.Value = this.rxOffset;
			this.numericUpDown_0.Value = this.rzOffset;
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000112F4 File Offset: 0x0000F4F4
		private RegionEntry method_9(List<RegionEntry> list_2)
		{
			RegionEntry result = null;
			if (list_2 != null && list_2.Count > 0)
			{
				IEnumerable<RegionEntry> source = list_2;
				if (ConvertOffsetDisplay.func_0 == null)
				{
					ConvertOffsetDisplay.func_0 = new Func<RegionEntry, int>(ConvertOffsetDisplay.smethod_0);
				}
				IOrderedEnumerable<RegionEntry> source2 = source.OrderBy(ConvertOffsetDisplay.func_0);
				if (ConvertOffsetDisplay.func_1 == null)
				{
					ConvertOffsetDisplay.func_1 = new Func<RegionEntry, int>(ConvertOffsetDisplay.smethod_1);
				}
				list_2 = source2.ThenBy(ConvertOffsetDisplay.func_1).ToList<RegionEntry>();
				result = list_2[0];
			}
			return result;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000031F9 File Offset: 0x000013F9
		private void eMbBypxZdu(object sender, EventArgs e)
		{
			this.rxOffset = (int)this.numericUpDown_1.Value;
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000321C File Offset: 0x0000141C
		private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
		{
			this.rzOffset = (int)this.numericUpDown_0.Value;
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002CEE File Offset: 0x00000EEE
		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002CFD File Offset: 0x00000EFD
		private void label_0_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002D0A File Offset: 0x00000F0A
		private void label_0_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002CFD File Offset: 0x00000EFD
		private void label_1_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002D0A File Offset: 0x00000F0A
		private void label_1_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00011364 File Offset: 0x0000F564
		private void button_2_Click(object sender, EventArgs e)
		{
			this.rxOffset = 0;
			this.rzOffset = 0;
			this.numericUpDown_1.Value = this.rxOffset;
			this.numericUpDown_0.Value = this.rzOffset;
			this.method_7(this.method_9(this.list_0), this.rxOffset, this.rzOffset);
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000323F File Offset: 0x0000143F
		private void doubleBufferPanel_0_MouseDown(object sender, MouseEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000113D4 File Offset: 0x0000F5D4
		private void method_10()
		{
			this.flowLayoutPanel_0 = new FlowLayoutPanel();
			this.panel_0 = new Panel();
			this.button_2 = new Button();
			this.label_5 = new Label();
			this.label_6 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.numericUpDown_1 = new NumericUpDown();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.doubleBufferPanel_0 = new DoubleBufferPanel();
			this.label_4 = new Label();
			this.flowLayoutPanel_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			this.doubleBufferPanel_0.SuspendLayout();
			base.SuspendLayout();
			this.flowLayoutPanel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.flowLayoutPanel_0.AutoScroll = true;
			this.flowLayoutPanel_0.BorderStyle = BorderStyle.FixedSingle;
			this.flowLayoutPanel_0.Controls.Add(this.doubleBufferPanel_0);
			this.flowLayoutPanel_0.Location = new Point(247, 12);
			this.flowLayoutPanel_0.Name = "flpRegionsContainer";
			this.flowLayoutPanel_0.Size = new Size(577, 486);
			this.flowLayoutPanel_0.TabIndex = 1;
			this.panel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panel_0.BorderStyle = BorderStyle.FixedSingle;
			this.panel_0.Controls.Add(this.button_2);
			this.panel_0.Controls.Add(this.label_5);
			this.panel_0.Controls.Add(this.label_6);
			this.panel_0.Controls.Add(this.numericUpDown_0);
			this.panel_0.Controls.Add(this.numericUpDown_1);
			this.panel_0.Controls.Add(this.checkBox_0);
			this.panel_0.Controls.Add(this.checkBox_1);
			this.panel_0.Controls.Add(this.label_2);
			this.panel_0.Controls.Add(this.label_3);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.label_1);
			this.panel_0.Location = new Point(12, 12);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(229, 486);
			this.panel_0.TabIndex = 2;
			this.button_2.Location = new Point(17, 306);
			this.button_2.Name = "btnClearOffsets";
			this.button_2.Size = new Size(120, 23);
			this.button_2.TabIndex = 10;
			this.button_2.Text = "Clear Offsets";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(69, 284);
			this.label_5.Name = "label2";
			this.label_5.Size = new Size(45, 13);
			this.label_5.TabIndex = 9;
			this.label_5.Text = "Z Offset";
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(69, 257);
			this.label_6.Name = "label1";
			this.label_6.Size = new Size(45, 13);
			this.label_6.TabIndex = 8;
			this.label_6.Text = "X Offset";
			this.numericUpDown_0.Location = new Point(17, 280);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 500;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Minimum = new decimal(new int[]
			{
				500,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_0.Name = "nudZOffset";
			this.numericUpDown_0.Size = new Size(46, 20);
			this.numericUpDown_0.TabIndex = 7;
			this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
			this.numericUpDown_1.Location = new Point(17, 253);
			NumericUpDown numericUpDown2 = this.numericUpDown_1;
			int[] array2 = new int[4];
			array2[0] = 500;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDown_1.Minimum = new decimal(new int[]
			{
				500,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_1.Name = "nudXOffset";
			this.numericUpDown_1.Size = new Size(46, 20);
			this.numericUpDown_1.TabIndex = 6;
			this.numericUpDown_1.ValueChanged += this.eMbBypxZdu;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(17, 45);
			this.checkBox_0.Name = "cbShowBedrockRegions";
			this.checkBox_0.Size = new Size(138, 17);
			this.checkBox_0.TabIndex = 5;
			this.checkBox_0.Text = "Show Bedrock Regions";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(17, 231);
			this.checkBox_1.Name = "cbShowConsoleRegions";
			this.checkBox_1.Size = new Size(136, 17);
			this.checkBox_1.TabIndex = 4;
			this.checkBox_1.Text = "Show Console Regions";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_1.CheckedChanged += this.checkBox_1_CheckedChanged;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(14, 211);
			this.label_2.Name = "lblConsoleRegionDetails";
			this.label_2.Size = new Size(121, 13);
			this.label_2.TabIndex = 3;
			this.label_2.Text = "lblConsoleRegionDetails";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(14, 26);
			this.label_3.Name = "lblBedrockRegionDetails";
			this.label_3.Size = new Size(123, 13);
			this.label_3.TabIndex = 2;
			this.label_3.Text = "lblBedrockRegionDetails";
			this.label_0.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(0, 185);
			this.label_0.Name = "lblConsoleGroup";
			this.label_0.Padding = new Padding(6, 2, 0, 0);
			this.label_0.Size = new Size(229, 26);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Console Regions";
			this.label_0.Click += this.label_0_Click;
			this.label_0.MouseEnter += this.label_0_MouseEnter;
			this.label_0.MouseLeave += this.label_0_MouseLeave;
			this.label_1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label_1.Location = new Point(0, 0);
			this.label_1.Name = "lblBedrockGroup";
			this.label_1.Padding = new Padding(6, 2, 0, 0);
			this.label_1.Size = new Size(229, 26);
			this.label_1.TabIndex = 0;
			this.label_1.Text = "Bedrock Regions";
			this.label_1.Click += this.label_1_Click;
			this.label_1.MouseEnter += this.label_1_MouseEnter;
			this.label_1.MouseLeave += this.label_1_MouseLeave;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(774, 515);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(50, 23);
			this.button_0.TabIndex = 4;
			this.button_0.Text = "Cancel";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.Location = new Point(715, 515);
			this.button_1.Name = "btnOk";
			this.button_1.Size = new Size(50, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Ok";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.doubleBufferPanel_0.Anchor = AnchorStyles.None;
			this.doubleBufferPanel_0.Controls.Add(this.label_4);
			this.doubleBufferPanel_0.Location = new Point(3, 3);
			this.doubleBufferPanel_0.Name = "pnlRegions";
			this.doubleBufferPanel_0.Size = new Size(487, 417);
			this.doubleBufferPanel_0.TabIndex = 0;
			this.doubleBufferPanel_0.MouseDown += this.doubleBufferPanel_0_MouseDown;
			this.label_4.AutoSize = true;
			this.label_4.BackColor = Color.Transparent;
			this.label_4.Location = new Point(48, 350);
			this.label_4.Name = "lblPosition";
			this.label_4.Size = new Size(35, 13);
			this.label_4.TabIndex = 0;
			this.label_4.Text = "label1";
			this.label_4.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(836, 550);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.flowLayoutPanel_0);
			base.Name = "ConvertOffsetDisplay";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Region Offset";
			base.Load += this.ConvertOffsetDisplay_Load;
			this.flowLayoutPanel_0.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			this.doubleBufferPanel_0.ResumeLayout(false);
			this.doubleBufferPanel_0.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002D3E File Offset: 0x00000F3E
		[CompilerGenerated]
		private static int smethod_0(RegionEntry regionEntry_0)
		{
			return regionEntry_0.RX;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002D46 File Offset: 0x00000F46
		[CompilerGenerated]
		private static int smethod_1(RegionEntry regionEntry_0)
		{
			return regionEntry_0.RZ;
		}

		// Token: 0x040000F0 RID: 240
		private List<RegionEntry> list_0;

		// Token: 0x040000F1 RID: 241
		private List<RegionEntry> list_1;

		// Token: 0x040000F2 RID: 242
		private List<PEDimension> bedrockDims;

		// Token: 0x040000F3 RID: 243
		private int int_0 = 10;

		// Token: 0x040000F4 RID: 244
		private int int_1 = 500;

		// Token: 0x040000F5 RID: 245
		private int int_2 = 20;

		// Token: 0x040000F6 RID: 246
		private bool bool_0;

		// Token: 0x040000F7 RID: 247
		private Color sIyBiMwvnv = Color.LightBlue;

		// Token: 0x040000F8 RID: 248
		private Color color_0 = Color.LightGreen;

		// Token: 0x040000F9 RID: 249
		private int rxOffset;

		// Token: 0x040000FA RID: 250
		private int rzOffset;

		// Token: 0x040000FC RID: 252
		private DoubleBufferPanel doubleBufferPanel_0;

		// Token: 0x040000FD RID: 253
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x040000FE RID: 254
		private Panel panel_0;

		// Token: 0x040000FF RID: 255
		private Label label_0;

		// Token: 0x04000100 RID: 256
		private Label label_1;

		// Token: 0x04000101 RID: 257
		private Label label_2;

		// Token: 0x04000102 RID: 258
		private Label label_3;

		// Token: 0x04000103 RID: 259
		private Label label_4;

		// Token: 0x04000104 RID: 260
		private CheckBox checkBox_0;

		// Token: 0x04000105 RID: 261
		private CheckBox checkBox_1;

		// Token: 0x04000106 RID: 262
		private Label label_5;

		// Token: 0x04000107 RID: 263
		private Label label_6;

		// Token: 0x04000108 RID: 264
		private NumericUpDown numericUpDown_0;

		// Token: 0x04000109 RID: 265
		private NumericUpDown numericUpDown_1;

		// Token: 0x0400010A RID: 266
		private Button button_0;

		// Token: 0x0400010B RID: 267
		private Button button_1;

		// Token: 0x0400010C RID: 268
		private Button button_2;

		// Token: 0x0400010D RID: 269
		[CompilerGenerated]
		private static Func<RegionEntry, int> func_0;

		// Token: 0x0400010E RID: 270
		[CompilerGenerated]
		private static Func<RegionEntry, int> func_1;
	}
}
