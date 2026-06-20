using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000021 RID: 33
	public class BlockReplace : UserControl
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002BBA File Offset: 0x00000DBA
		public BlockReplace()
		{
			this.method_4();
			if (ControlSupport.IsInRuntimeMode(this))
			{
				this.method_3();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002BD6 File Offset: 0x00000DD6
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public BlockChange BlockChange
		{
			get
			{
				this.method_0();
				return this.opBpilViCB;
			}
			set
			{
				this.opBpilViCB = value;
				this.method_2();
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		private void method_0()
		{
			this.opBpilViCB.FromBlock = (int)this.comboBox_0.SelectedValue;
			this.opBpilViCB.FromData = IntSringConverter.ConvertFromString(this.textBox_0.Text);
			this.opBpilViCB.ToBlock = (int)this.comboBox_1.SelectedValue;
			this.opBpilViCB.ToData = this.method_1(this.textBox_1.Text);
			this.opBpilViCB.ToBlockLight = (int)this.comboBox_2.SelectedValue;
			this.opBpilViCB.Layers = IntSringConverter.ConvertFromString(this.uiupvAwXiu.Text);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000AB60 File Offset: 0x00008D60
		private int method_1(string string_0)
		{
			int result = 0;
			int.TryParse(string_0, out result);
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000AB7C File Offset: 0x00008D7C
		private void method_2()
		{
			this.comboBox_0.SelectedValue = this.opBpilViCB.FromBlock;
			this.textBox_0.Text = IntSringConverter.ConvertToString(this.opBpilViCB.FromData.ToArray());
			this.comboBox_1.SelectedValue = this.opBpilViCB.ToBlock;
			this.textBox_1.Text = this.opBpilViCB.ToData.ToString();
			this.comboBox_2.SelectedValue = this.opBpilViCB.ToBlockLight;
			this.uiupvAwXiu.Text = IntSringConverter.ConvertToString(this.opBpilViCB.Layers.ToArray());
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000AC38 File Offset: 0x00008E38
		private void method_3()
		{
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "IdName";
			this.comboBox_0.DataSource = Class29.smethod_0();
			this.comboBox_1.ValueMember = "Id";
			this.comboBox_1.DisplayMember = "IdName";
			this.comboBox_1.DataSource = Class29.Blocks;
			this.comboBox_2.ValueMember = "Key";
			this.comboBox_2.DisplayMember = "Value";
			this.comboBox_2.DataSource = new BindingSource(Constants.dictionary_0, null);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002BF3 File Offset: 0x00000DF3
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_0.SelectedValue != null)
			{
				this.textBox_3.Text = this.comboBox_0.SelectedValue.ToString();
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002C1D File Offset: 0x00000E1D
		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedValue != null)
			{
				this.textBox_2.Text = this.comboBox_1.SelectedValue.ToString();
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002C47 File Offset: 0x00000E47
		private void textBox_3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000ACDC File Offset: 0x00008EDC
		private void textBox_3_KeyUp(object sender, KeyEventArgs e)
		{
			int num;
			int.TryParse(this.textBox_3.Text, out num);
			this.comboBox_0.SelectedValue = num;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002C47 File Offset: 0x00000E47
		private void textBox_2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000AD10 File Offset: 0x00008F10
		private void textBox_2_KeyUp(object sender, KeyEventArgs e)
		{
			int num;
			int.TryParse(this.textBox_2.Text, out num);
			this.comboBox_1.SelectedValue = num;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002C6A File Offset: 0x00000E6A
		public bool IsValid()
		{
			return this.comboBox_0.SelectedValue != null && this.comboBox_1.SelectedValue != null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002C8C File Offset: 0x00000E8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000AD44 File Offset: 0x00008F44
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
			this.uiupvAwXiu = new TextBox();
			this.panel_0 = new Panel();
			this.label_5 = new Label();
			this.comboBox_2 = new ComboBox();
			this.panel_1 = new Panel();
			this.textBox_2 = new TextBox();
			this.comboBox_1 = new ComboBox();
			this.panel_2 = new Panel();
			this.textBox_3 = new TextBox();
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
			this.tableLayoutPanel_0.Controls.Add(this.uiupvAwXiu, 1, 3);
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
			this.uiupvAwXiu.Dock = DockStyle.Fill;
			this.uiupvAwXiu.Location = new Point(43, 67);
			this.uiupvAwXiu.Name = "tbLayers";
			this.uiupvAwXiu.Size = new Size(206, 20);
			this.uiupvAwXiu.TabIndex = 13;
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
			this.panel_1.Controls.Add(this.textBox_2);
			this.panel_1.Controls.Add(this.comboBox_1);
			this.panel_1.Dock = DockStyle.Fill;
			this.panel_1.Location = new Point(252, 12);
			this.panel_1.Margin = new Padding(0);
			this.panel_1.Name = "panel2";
			this.panel_1.Size = new Size(213, 26);
			this.panel_1.TabIndex = 6;
			this.textBox_2.Location = new Point(4, 4);
			this.textBox_2.Name = "tbToId";
			this.textBox_2.Size = new Size(30, 20);
			this.textBox_2.TabIndex = 7;
			this.textBox_2.KeyPress += this.textBox_2_KeyPress;
			this.textBox_2.KeyUp += this.textBox_2_KeyUp;
			this.comboBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(35, 3);
			this.comboBox_1.Name = "cbToId";
			this.comboBox_1.Size = new Size(175, 21);
			this.comboBox_1.TabIndex = 8;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.panel_2.Controls.Add(this.textBox_3);
			this.panel_2.Controls.Add(this.comboBox_0);
			this.panel_2.Dock = DockStyle.Fill;
			this.panel_2.Location = new Point(40, 12);
			this.panel_2.Margin = new Padding(0);
			this.panel_2.Name = "panel3";
			this.panel_2.Size = new Size(212, 26);
			this.panel_2.TabIndex = 3;
			this.textBox_3.Location = new Point(4, 4);
			this.textBox_3.Name = "tbFromId";
			this.textBox_3.Size = new Size(30, 20);
			this.textBox_3.TabIndex = 4;
			this.textBox_3.KeyPress += this.textBox_3_KeyPress;
			this.textBox_3.KeyUp += this.textBox_3_KeyUp;
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

		// Token: 0x04000080 RID: 128
		private BlockChange opBpilViCB;

		// Token: 0x04000081 RID: 129
		private IContainer icontainer_0;

		// Token: 0x04000082 RID: 130
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04000083 RID: 131
		private Label label_0;

		// Token: 0x04000084 RID: 132
		private Label label_1;

		// Token: 0x04000085 RID: 133
		private Label label_2;

		// Token: 0x04000086 RID: 134
		private Label label_3;

		// Token: 0x04000087 RID: 135
		private TextBox textBox_0;

		// Token: 0x04000088 RID: 136
		private TextBox textBox_1;

		// Token: 0x04000089 RID: 137
		private ComboBox comboBox_0;

		// Token: 0x0400008A RID: 138
		private ComboBox comboBox_1;

		// Token: 0x0400008B RID: 139
		private TextBox uiupvAwXiu;

		// Token: 0x0400008C RID: 140
		private Label label_4;

		// Token: 0x0400008D RID: 141
		private Panel panel_0;

		// Token: 0x0400008E RID: 142
		private ComboBox comboBox_2;

		// Token: 0x0400008F RID: 143
		private Label label_5;

		// Token: 0x04000090 RID: 144
		private Panel panel_1;

		// Token: 0x04000091 RID: 145
		private TextBox textBox_2;

		// Token: 0x04000092 RID: 146
		private Panel panel_2;

		// Token: 0x04000093 RID: 147
		private TextBox textBox_3;
	}
}
