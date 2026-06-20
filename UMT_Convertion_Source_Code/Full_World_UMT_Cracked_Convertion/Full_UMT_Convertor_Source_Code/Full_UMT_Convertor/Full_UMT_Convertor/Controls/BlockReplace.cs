using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200003C RID: 60
	public class BlockReplace : UserControl
	{
		// Token: 0x0600021C RID: 540 RVA: 0x000034BB File Offset: 0x000016BB
		public BlockReplace()
		{
			this.method_4();
			if (ControlSupport.IsInRuntimeMode(this))
			{
				this.method_3();
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000034D7 File Offset: 0x000016D7
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000034E5 File Offset: 0x000016E5
		public BlockChange BlockChange
		{
			get
			{
				this.method_0();
				return this.blockChange_0;
			}
			set
			{
				this.blockChange_0 = value;
				this.method_2();
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001359C File Offset: 0x0001179C
		private void method_0()
		{
			this.blockChange_0.FromBlock = (int)this.comboBox_0.SelectedValue;
			this.blockChange_0.FromData = IntSringConverter.ConvertFromString(this.textBox_0.Text);
			this.blockChange_0.ToBlock = (int)this.comboBox_1.SelectedValue;
			this.blockChange_0.ToData = this.method_1(this.textBox_1.Text);
			this.blockChange_0.ToBlockLight = (int)this.comboBox_2.SelectedValue;
			this.blockChange_0.Layers = IntSringConverter.ConvertFromString(this.textBox_2.Text);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001364C File Offset: 0x0001184C
		private int method_1(string string_0)
		{
			int result = 0;
			int.TryParse(string_0, out result);
			return result;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00013668 File Offset: 0x00011868
		private void method_2()
		{
			this.comboBox_0.SelectedValue = this.blockChange_0.FromBlock;
			this.textBox_0.Text = IntSringConverter.ConvertToString(this.blockChange_0.FromData.ToArray());
			this.comboBox_1.SelectedValue = this.blockChange_0.ToBlock;
			this.textBox_1.Text = this.blockChange_0.ToData.ToString();
			this.comboBox_2.SelectedValue = this.blockChange_0.ToBlockLight;
			this.textBox_2.Text = IntSringConverter.ConvertToString(this.blockChange_0.Layers.ToArray());
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00013724 File Offset: 0x00011924
		private void method_3()
		{
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "IdName";
			this.comboBox_0.DataSource = Class34.smethod_0();
			this.comboBox_1.ValueMember = "Id";
			this.comboBox_1.DisplayMember = "IdName";
			this.comboBox_1.DataSource = Class34.Blocks;
			this.comboBox_2.ValueMember = "Key";
			this.comboBox_2.DisplayMember = "Value";
			this.comboBox_2.DataSource = new BindingSource(Constants.dictionary_1, null);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000034F4 File Offset: 0x000016F4
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_0.SelectedValue != null)
			{
				this.textBox_4.Text = this.comboBox_0.SelectedValue.ToString();
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000351E File Offset: 0x0000171E
		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedValue != null)
			{
				this.textBox_3.Text = this.comboBox_1.SelectedValue.ToString();
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00003548 File Offset: 0x00001748
		private void textBox_4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000137C8 File Offset: 0x000119C8
		private void textBox_4_KeyUp(object sender, KeyEventArgs e)
		{
			int num;
			int.TryParse(this.textBox_4.Text, out num);
			this.comboBox_0.SelectedValue = num;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003548 File Offset: 0x00001748
		private void textBox_3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000137FC File Offset: 0x000119FC
		private void textBox_3_KeyUp(object sender, KeyEventArgs e)
		{
			int num;
			int.TryParse(this.textBox_3.Text, out num);
			this.comboBox_1.SelectedValue = num;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000356B File Offset: 0x0000176B
		public bool IsValid()
		{
			return this.comboBox_0.SelectedValue != null && this.comboBox_1.SelectedValue != null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000358D File Offset: 0x0000178D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00013830 File Offset: 0x00011A30
		private void method_4()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.label_4 = new Label();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.panel_0 = new Panel();
			this.label_5 = new Label();
			this.comboBox_2 = new ComboBox();
			this.panel_1 = new Panel();
			this.textBox_3 = new TextBox();
			this.comboBox_1 = new ComboBox();
			this.panel_2 = new Panel();
			this.textBox_4 = new TextBox();
			this.comboBox_0 = new ComboBox();
			this.tableLayoutPanel_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.panel_1.SuspendLayout();
			this.panel_2.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 3;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.Controls.Add(this.label_4, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 1, 0);
			this.tableLayoutPanel_0.Controls.Add(this.label_2, 2, 0);
			this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_1, 2, 2);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_2, 1, 3);
			this.tableLayoutPanel_0.Controls.Add(this.panel_0, 2, 3);
			this.tableLayoutPanel_0.Controls.Add(this.panel_1, 2, 1);
			this.tableLayoutPanel_0.Controls.Add(this.panel_2, 1, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 4;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 12f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
			this.tableLayoutPanel_0.Size = new Size(465, 93);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.label_4.AutoSize = true;
			this.label_4.Dock = DockStyle.Fill;
			this.label_4.Location = new Point(3, 64);
			this.label_4.Name = "label7";
			this.label_4.Padding = new Padding(0, 6, 0, 0);
			this.label_4.Size = new Size(34, 29);
			this.label_4.TabIndex = 12;
			this.label_4.Text = "Layer";
			this.label_4.TextAlign = ContentAlignment.TopRight;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(3, 38);
			this.label_0.Name = "label5";
			this.label_0.Padding = new Padding(0, 6, 0, 0);
			this.label_0.Size = new Size(34, 26);
			this.label_0.TabIndex = 9;
			this.label_0.Text = "Data";
			this.label_0.TextAlign = ContentAlignment.TopRight;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(43, 0);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(206, 12);
			this.label_1.TabIndex = 1;
			this.label_1.Text = "From Block";
			this.label_2.AutoSize = true;
			this.label_2.Dock = DockStyle.Fill;
			this.label_2.Location = new Point(255, 0);
			this.label_2.Name = "label2";
			this.label_2.Size = new Size(207, 12);
			this.label_2.TabIndex = 8;
			this.label_2.Text = "To Block";
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 12);
			this.label_3.Name = "label3";
			this.label_3.Padding = new Padding(0, 6, 0, 0);
			this.label_3.Size = new Size(34, 26);
			this.label_3.TabIndex = 2;
			this.label_3.Text = "Id";
			this.label_3.TextAlign = ContentAlignment.TopRight;
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(43, 41);
			this.textBox_0.Name = "tbFromData";
			this.textBox_0.Size = new Size(206, 20);
			this.textBox_0.TabIndex = 10;
			this.textBox_1.Dock = DockStyle.Fill;
			this.textBox_1.Location = new Point(255, 41);
			this.textBox_1.Name = "tbToData";
			this.textBox_1.Size = new Size(207, 20);
			this.textBox_1.TabIndex = 11;
			this.textBox_2.Dock = DockStyle.Fill;
			this.textBox_2.Location = new Point(43, 67);
			this.textBox_2.Name = "tbLayers";
			this.textBox_2.Size = new Size(206, 20);
			this.textBox_2.TabIndex = 13;
			this.panel_0.Controls.Add(this.label_5);
			this.panel_0.Controls.Add(this.comboBox_2);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(255, 67);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(207, 23);
			this.panel_0.TabIndex = 14;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(3, 6);
			this.label_5.Margin = new Padding(0);
			this.label_5.Name = "label6";
			this.label_5.Size = new Size(30, 13);
			this.label_5.TabIndex = 15;
			this.label_5.Text = "Light";
			this.comboBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(35, 1);
			this.comboBox_2.Name = "cbBlocklight";
			this.comboBox_2.Size = new Size(172, 21);
			this.comboBox_2.TabIndex = 16;
			this.panel_1.Controls.Add(this.textBox_3);
			this.panel_1.Controls.Add(this.comboBox_1);
			this.panel_1.Dock = DockStyle.Fill;
			this.panel_1.Location = new Point(252, 12);
			this.panel_1.Margin = new Padding(0);
			this.panel_1.Name = "panel2";
			this.panel_1.Size = new Size(213, 26);
			this.panel_1.TabIndex = 6;
			this.textBox_3.Location = new Point(4, 4);
			this.textBox_3.Name = "tbToId";
			this.textBox_3.Size = new Size(30, 20);
			this.textBox_3.TabIndex = 7;
			this.textBox_3.KeyPress += this.textBox_3_KeyPress;
			this.textBox_3.KeyUp += this.textBox_3_KeyUp;
			this.comboBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(35, 3);
			this.comboBox_1.Name = "cbToId";
			this.comboBox_1.Size = new Size(175, 21);
			this.comboBox_1.TabIndex = 8;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.panel_2.Controls.Add(this.textBox_4);
			this.panel_2.Controls.Add(this.comboBox_0);
			this.panel_2.Dock = DockStyle.Fill;
			this.panel_2.Location = new Point(40, 12);
			this.panel_2.Margin = new Padding(0);
			this.panel_2.Name = "panel3";
			this.panel_2.Size = new Size(212, 26);
			this.panel_2.TabIndex = 3;
			this.textBox_4.Location = new Point(4, 4);
			this.textBox_4.Name = "tbFromId";
			this.textBox_4.Size = new Size(30, 20);
			this.textBox_4.TabIndex = 4;
			this.textBox_4.KeyPress += this.textBox_4_KeyPress;
			this.textBox_4.KeyUp += this.textBox_4_KeyUp;
			this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(35, 3);
			this.comboBox_0.Name = "cbFromId";
			this.comboBox_0.Size = new Size(174, 21);
			this.comboBox_0.TabIndex = 5;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "BlockReplace";
			base.Size = new Size(465, 93);
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			this.panel_1.ResumeLayout(false);
			this.panel_1.PerformLayout();
			this.panel_2.ResumeLayout(false);
			this.panel_2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400014D RID: 333
		private BlockChange blockChange_0;

		// Token: 0x0400014E RID: 334
		private IContainer icontainer_0;

		// Token: 0x0400014F RID: 335
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04000150 RID: 336
		private Label label_0;

		// Token: 0x04000151 RID: 337
		private Label label_1;

		// Token: 0x04000152 RID: 338
		private Label label_2;

		// Token: 0x04000153 RID: 339
		private Label label_3;

		// Token: 0x04000154 RID: 340
		private TextBox textBox_0;

		// Token: 0x04000155 RID: 341
		private TextBox textBox_1;

		// Token: 0x04000156 RID: 342
		private ComboBox comboBox_0;

		// Token: 0x04000157 RID: 343
		private ComboBox comboBox_1;

		// Token: 0x04000158 RID: 344
		private TextBox textBox_2;

		// Token: 0x04000159 RID: 345
		private Label label_4;

		// Token: 0x0400015A RID: 346
		private Panel panel_0;

		// Token: 0x0400015B RID: 347
		private ComboBox comboBox_2;

		// Token: 0x0400015C RID: 348
		private Label label_5;

		// Token: 0x0400015D RID: 349
		private Panel panel_1;

		// Token: 0x0400015E RID: 350
		private TextBox textBox_3;

		// Token: 0x0400015F RID: 351
		private Panel panel_2;

		// Token: 0x04000160 RID: 352
		private TextBox textBox_4;
	}
}
