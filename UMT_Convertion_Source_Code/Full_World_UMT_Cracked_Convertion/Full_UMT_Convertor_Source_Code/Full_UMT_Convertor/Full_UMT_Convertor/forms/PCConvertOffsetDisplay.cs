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
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x0200001F RID: 31
	public partial class PCConvertOffsetDisplay : Form
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002C6B File Offset: 0x00000E6B
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002C73 File Offset: 0x00000E73
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002C7C File Offset: 0x00000E7C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002C84 File Offset: 0x00000E84
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

		// Token: 0x060000FE RID: 254 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		public PCConvertOffsetDisplay(string javaPath, int rxOffset, int rzOffset)
		{
			this.method_7();
			this.bool_0 = true;
			this.rxOffset = rxOffset;
			this.rzOffset = rzOffset;
			this.numericUpDown_1.Value = rxOffset;
			this.numericUpDown_0.Value = rzOffset;
			int num = this.int_1 * this.int_2;
			this.doubleBufferPanel_0.Width = this.int_0 + num + this.int_0;
			this.doubleBufferPanel_0.Height = this.int_0 + num + this.int_0;
			this.doubleBufferPanel_0.Paint += this.OnPanelPaint;
			this.javaPath = javaPath;
			this.JmGkhrlvSy.BackColor = this.color_1;
			this.label_0.BackColor = this.color_0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000D704 File Offset: 0x0000B904
		private void PCConvertOffsetDisplay_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060000FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.PCConvertOffsetDisplay::PCConvertOffsetDisplay_Load(System.Object,System.EventArgs)

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

		// Token: 0x06000100 RID: 256 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		protected void OnPanelPaint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			this.bool_0 = true;
			this.method_0(graphics);
			this.method_1(graphics);
			this.bool_0 = false;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000D82C File Offset: 0x0000BA2C
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

		// Token: 0x06000102 RID: 258 RVA: 0x0000D92C File Offset: 0x0000BB2C
		private void method_1(Graphics graphics_0)
		{
			int int_ = 5010;
			if (this.checkBox_1.Checked)
			{
				this.method_2(int_, this.list_0, this.color_0, graphics_0, 0, 0);
			}
			if (this.checkBox_0.Checked)
			{
				this.method_2(int_, this.list_1, this.color_1, graphics_0, this.rxOffset, this.rzOffset);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D990 File Offset: 0x0000BB90
		private void method_2(int int_3, List<RegionEntry> list_2, Color color_2, Graphics graphics_0, int int_4 = 0, int int_5 = 0)
		{
			if (list_2 == null)
			{
				return;
			}
			SolidBrush brush = new SolidBrush(Color.FromArgb(128, (int)color_2.R, (int)color_2.G, (int)color_2.B));
			foreach (RegionEntry regionEntry in list_2)
			{
				int x = (regionEntry.RX + int_4) * this.int_2 + int_3;
				int y = (regionEntry.RZ + int_5) * this.int_2 + int_3;
				Point point = new Point(x, y);
				graphics_0.FillRectangle(brush, point.X + 1, point.Y + 1, this.int_2 - 1, this.int_2 - 1);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		private List<RegionEntry> method_3(string string_0)
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

		// Token: 0x06000105 RID: 261 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		private List<RegionEntry> okTkFoymZk(string string_0)
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

		// Token: 0x06000106 RID: 262 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
		private void JmGkhrlvSy_Click(object sender, EventArgs e)
		{
			RegionEntry regionEntry_ = this.method_6(this.list_1);
			this.method_4(regionEntry_, this.rxOffset, this.rzOffset);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		private void label_0_Click(object sender, EventArgs e)
		{
			RegionEntry regionEntry_ = this.method_6(this.list_0);
			this.method_4(regionEntry_, 0, 0);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		private void method_4(RegionEntry regionEntry_0, int int_3 = 0, int int_4 = 0)
		{
			if (regionEntry_0 != null)
			{
				int num = this.int_0 + this.int_1 * this.int_2 / 2;
				int num2 = (regionEntry_0.RX + int_3) * this.int_2 + num;
				int num3 = (regionEntry_0.RZ + int_4) * this.int_2 + num;
				this.flowLayoutPanel_0.AutoScrollPosition = new Point(num2 - this.flowLayoutPanel_0.ClientRectangle.Width / 2, num3 - this.flowLayoutPanel_0.ClientRectangle.Height / 2);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000DC84 File Offset: 0x0000BE84
		private void doubleBufferPanel_0_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			this.label_3.Visible = true;
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
			this.label_3.Text = num2.ToString() + "," + num3.ToString();
			this.label_3.Left = e.X - this.label_3.Width / 2;
			this.label_3.Top = e.Y + this.label_3.Height * 2;
			if (e.Button == MouseButtons.Left)
			{
				this.method_5();
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002C8D File Offset: 0x00000E8D
		private void doubleBufferPanel_0_MouseLeave(object sender, EventArgs e)
		{
			this.label_3.Visible = false;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C9B File Offset: 0x00000E9B
		private void checkBox_1_CheckedChanged(object sender, EventArgs e)
		{
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002C9B File Offset: 0x00000E9B
		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000DD80 File Offset: 0x0000BF80
		private void method_5()
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
			RegionEntry regionEntry = this.method_6(this.list_0);
			this.rxOffset = ((regionEntry.RX < num2) ? Math.Abs(num2 - regionEntry.RX) : (Math.Abs(regionEntry.RX - num2) * -1));
			this.rzOffset = ((regionEntry.RZ < num3) ? Math.Abs(num3 - regionEntry.RZ) : (Math.Abs(regionEntry.RZ - num3) * -1));
			this.numericUpDown_1.Value = this.rxOffset;
			this.numericUpDown_0.Value = this.rzOffset;
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000DE98 File Offset: 0x0000C098
		private RegionEntry method_6(List<RegionEntry> list_2)
		{
			RegionEntry result = null;
			if (list_2 != null && list_2.Count > 0)
			{
				IEnumerable<RegionEntry> source = list_2;
				if (PCConvertOffsetDisplay.func_0 == null)
				{
					PCConvertOffsetDisplay.func_0 = new Func<RegionEntry, int>(PCConvertOffsetDisplay.smethod_0);
				}
				IOrderedEnumerable<RegionEntry> source2 = source.OrderBy(PCConvertOffsetDisplay.func_0);
				if (PCConvertOffsetDisplay.func_1 == null)
				{
					PCConvertOffsetDisplay.func_1 = new Func<RegionEntry, int>(PCConvertOffsetDisplay.smethod_1);
				}
				list_2 = source2.ThenBy(PCConvertOffsetDisplay.func_1).ToList<RegionEntry>();
				result = list_2[0];
			}
			return result;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002CA8 File Offset: 0x00000EA8
		private void numericUpDown_1_ValueChanged(object sender, EventArgs e)
		{
			this.rxOffset = (int)this.numericUpDown_1.Value;
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002CCB File Offset: 0x00000ECB
		private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
		{
			this.rzOffset = (int)this.numericUpDown_0.Value;
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002CEE File Offset: 0x00000EEE
		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002CFD File Offset: 0x00000EFD
		private void label_0_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002D0A File Offset: 0x00000F0A
		private void label_0_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002CFD File Offset: 0x00000EFD
		private void HhokKqEuti(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002D0A File Offset: 0x00000F0A
		private void JmGkhrlvSy_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000DF08 File Offset: 0x0000C108
		private void button_2_Click(object sender, EventArgs e)
		{
			this.rxOffset = 0;
			this.rzOffset = 0;
			this.numericUpDown_1.Value = this.rxOffset;
			this.numericUpDown_0.Value = this.rzOffset;
			this.method_4(this.method_6(this.list_1), this.rxOffset, this.rzOffset);
			this.doubleBufferPanel_0.Invalidate();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002D17 File Offset: 0x00000F17
		private void doubleBufferPanel_0_MouseDown(object sender, MouseEventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000DF78 File Offset: 0x0000C178
		private void method_7()
		{
			this.flowLayoutPanel_0 = new FlowLayoutPanel();
			this.doubleBufferPanel_0 = new DoubleBufferPanel();
			this.label_3 = new Label();
			this.panel_0 = new Panel();
			this.button_2 = new Button();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.numericUpDown_1 = new NumericUpDown();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_0 = new Label();
			this.JmGkhrlvSy = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.flowLayoutPanel_0.SuspendLayout();
			this.doubleBufferPanel_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			base.SuspendLayout();
			this.flowLayoutPanel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.flowLayoutPanel_0.AutoScroll = true;
			this.flowLayoutPanel_0.BorderStyle = BorderStyle.FixedSingle;
			this.flowLayoutPanel_0.Controls.Add(this.doubleBufferPanel_0);
			this.flowLayoutPanel_0.Location = new Point(247, 12);
			this.flowLayoutPanel_0.Name = "flpRegionsContainer";
			this.flowLayoutPanel_0.Size = new Size(577, 486);
			this.flowLayoutPanel_0.TabIndex = 1;
			this.doubleBufferPanel_0.Anchor = AnchorStyles.None;
			this.doubleBufferPanel_0.Controls.Add(this.label_3);
			this.doubleBufferPanel_0.Location = new Point(3, 3);
			this.doubleBufferPanel_0.Name = "pnlRegions";
			this.doubleBufferPanel_0.Size = new Size(487, 417);
			this.doubleBufferPanel_0.TabIndex = 0;
			this.doubleBufferPanel_0.MouseDown += this.doubleBufferPanel_0_MouseDown;
			this.label_3.AutoSize = true;
			this.label_3.BackColor = Color.Transparent;
			this.label_3.Location = new Point(48, 350);
			this.label_3.Name = "lblPosition";
			this.label_3.Size = new Size(35, 13);
			this.label_3.TabIndex = 0;
			this.label_3.Text = "label1";
			this.label_3.Visible = false;
			this.panel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panel_0.BorderStyle = BorderStyle.FixedSingle;
			this.panel_0.Controls.Add(this.button_2);
			this.panel_0.Controls.Add(this.label_4);
			this.panel_0.Controls.Add(this.label_5);
			this.panel_0.Controls.Add(this.numericUpDown_0);
			this.panel_0.Controls.Add(this.numericUpDown_1);
			this.panel_0.Controls.Add(this.checkBox_0);
			this.panel_0.Controls.Add(this.checkBox_1);
			this.panel_0.Controls.Add(this.label_1);
			this.panel_0.Controls.Add(this.label_2);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.JmGkhrlvSy);
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
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(69, 284);
			this.label_4.Name = "label2";
			this.label_4.Size = new Size(45, 13);
			this.label_4.TabIndex = 9;
			this.label_4.Text = "Z Offset";
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(69, 257);
			this.label_5.Name = "label1";
			this.label_5.Size = new Size(45, 13);
			this.label_5.TabIndex = 8;
			this.label_5.Text = "X Offset";
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
			this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(16, 231);
			this.checkBox_0.Name = "cbShowConsoleRegions";
			this.checkBox_0.Size = new Size(136, 17);
			this.checkBox_0.TabIndex = 5;
			this.checkBox_0.Text = "Show Console Regions";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(16, 45);
			this.checkBox_1.Name = "cbShowJavaRegions";
			this.checkBox_1.Size = new Size(121, 17);
			this.checkBox_1.TabIndex = 4;
			this.checkBox_1.Text = "Show Java Regions";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_1.CheckedChanged += this.checkBox_1_CheckedChanged;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(13, 25);
			this.label_1.Name = "lblJavaRegionDetails";
			this.label_1.Size = new Size(106, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "lblJavaRegionDetails";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(13, 212);
			this.label_2.Name = "lblConsoleRegionDetails";
			this.label_2.Size = new Size(123, 13);
			this.label_2.TabIndex = 2;
			this.label_2.Text = "lblConsoleRegionDetails";
			this.label_0.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(-1, -1);
			this.label_0.Name = "lblJavaGroup";
			this.label_0.Padding = new Padding(6, 2, 0, 0);
			this.label_0.Size = new Size(229, 26);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Java Regions";
			this.label_0.Click += this.label_0_Click;
			this.label_0.MouseEnter += this.label_0_MouseEnter;
			this.label_0.MouseLeave += this.label_0_MouseLeave;
			this.JmGkhrlvSy.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.JmGkhrlvSy.Location = new Point(-1, 186);
			this.JmGkhrlvSy.Name = "lblConsoleGroup";
			this.JmGkhrlvSy.Padding = new Padding(6, 2, 0, 0);
			this.JmGkhrlvSy.Size = new Size(229, 26);
			this.JmGkhrlvSy.TabIndex = 0;
			this.JmGkhrlvSy.Text = "Console Regions";
			this.JmGkhrlvSy.Click += this.JmGkhrlvSy_Click;
			this.JmGkhrlvSy.MouseEnter += this.HhokKqEuti;
			this.JmGkhrlvSy.MouseLeave += this.JmGkhrlvSy_MouseLeave;
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
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(836, 550);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.flowLayoutPanel_0);
			base.Name = "PCConvertOffsetDisplay";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Region Offset";
			base.Load += this.PCConvertOffsetDisplay_Load;
			this.flowLayoutPanel_0.ResumeLayout(false);
			this.doubleBufferPanel_0.ResumeLayout(false);
			this.doubleBufferPanel_0.PerformLayout();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002D3E File Offset: 0x00000F3E
		[CompilerGenerated]
		private static int smethod_0(RegionEntry regionEntry_0)
		{
			return regionEntry_0.RX;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002D46 File Offset: 0x00000F46
		[CompilerGenerated]
		private static int smethod_1(RegionEntry regionEntry_0)
		{
			return regionEntry_0.RZ;
		}

		// Token: 0x0400008E RID: 142
		private string javaPath = string.Empty;

		// Token: 0x0400008F RID: 143
		private List<RegionEntry> list_0;

		// Token: 0x04000090 RID: 144
		private List<RegionEntry> list_1;

		// Token: 0x04000091 RID: 145
		private int int_0 = 10;

		// Token: 0x04000092 RID: 146
		private int int_1 = 500;

		// Token: 0x04000093 RID: 147
		private int int_2 = 20;

		// Token: 0x04000094 RID: 148
		private bool bool_0;

		// Token: 0x04000095 RID: 149
		private Color color_0 = Color.LightBlue;

		// Token: 0x04000096 RID: 150
		private Color color_1 = Color.LightGreen;

		// Token: 0x04000097 RID: 151
		private int rxOffset;

		// Token: 0x04000098 RID: 152
		private int rzOffset;

		// Token: 0x0400009A RID: 154
		private DoubleBufferPanel doubleBufferPanel_0;

		// Token: 0x0400009B RID: 155
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x0400009C RID: 156
		private Panel panel_0;

		// Token: 0x0400009D RID: 157
		private Label label_0;

		// Token: 0x0400009E RID: 158
		private Label JmGkhrlvSy;

		// Token: 0x0400009F RID: 159
		private Label label_1;

		// Token: 0x040000A0 RID: 160
		private Label label_2;

		// Token: 0x040000A1 RID: 161
		private Label label_3;

		// Token: 0x040000A2 RID: 162
		private CheckBox checkBox_0;

		// Token: 0x040000A3 RID: 163
		private CheckBox checkBox_1;

		// Token: 0x040000A4 RID: 164
		private Label label_4;

		// Token: 0x040000A5 RID: 165
		private Label label_5;

		// Token: 0x040000A6 RID: 166
		private NumericUpDown numericUpDown_0;

		// Token: 0x040000A7 RID: 167
		private NumericUpDown numericUpDown_1;

		// Token: 0x040000A8 RID: 168
		private Button button_0;

		// Token: 0x040000A9 RID: 169
		private Button button_1;

		// Token: 0x040000AA RID: 170
		private Button button_2;

		// Token: 0x040000AB RID: 171
		[CompilerGenerated]
		private static Func<RegionEntry, int> func_0;

		// Token: 0x040000AC RID: 172
		[CompilerGenerated]
		private static Func<RegionEntry, int> func_1;
	}
}
