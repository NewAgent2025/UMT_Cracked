using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200003A RID: 58
	public class BiomeReplace : UserControl
	{
		// Token: 0x0600020C RID: 524 RVA: 0x000033A7 File Offset: 0x000015A7
		public BiomeReplace()
		{
			this.method_1();
			this.method_0();
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000033BB File Offset: 0x000015BB
		// (set) Token: 0x0600020E RID: 526 RVA: 0x000033F9 File Offset: 0x000015F9
		public BiomeChange BiomeChange
		{
			get
			{
				this.biomeChange_0.FromBiome = (int)this.comboBox_0.SelectedValue;
				this.biomeChange_0.ToBiome = (int)this.comboBox_1.SelectedValue;
				return this.biomeChange_0;
			}
			set
			{
				this.biomeChange_0 = value;
				this.comboBox_0.SelectedValue = this.biomeChange_0.FromBiome;
				this.comboBox_1.SelectedValue = this.biomeChange_0.ToBiome;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00012F24 File Offset: 0x00011124
		private void method_0()
		{
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.DataSource = Constants.consoleBiomeListPlus.Values.ToList<Biome>();
			this.comboBox_1.ValueMember = "Id";
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.DataSource = Constants.consoleBiomeList.Values.ToList<Biome>();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00003438 File Offset: 0x00001638
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00012FA8 File Offset: 0x000111A8
		private void method_1()
		{
			this.comboBox_0 = new ComboBox();
			this.comboBox_1 = new ComboBox();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.tableLayoutPanel_0.SuspendLayout();
			base.SuspendLayout();
			this.comboBox_0.Dock = DockStyle.Fill;
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(3, 15);
			this.comboBox_0.Name = "cbFromBiome";
			this.comboBox_0.Size = new Size(74, 21);
			this.comboBox_0.TabIndex = 1;
			this.comboBox_1.Dock = DockStyle.Fill;
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(83, 15);
			this.comboBox_1.Name = "cbToBiome";
			this.comboBox_1.Size = new Size(75, 21);
			this.comboBox_1.TabIndex = 3;
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 1, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 12f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(161, 41);
			this.tableLayoutPanel_0.TabIndex = 2;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(3, 0);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(74, 12);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "From Biome";
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(83, 0);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(75, 12);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "To Biome";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "BiomeReplace";
			base.Size = new Size(161, 41);
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000142 RID: 322
		private BiomeChange biomeChange_0;

		// Token: 0x04000143 RID: 323
		private IContainer icontainer_0;

		// Token: 0x04000144 RID: 324
		private ComboBox comboBox_0;

		// Token: 0x04000145 RID: 325
		private ComboBox comboBox_1;

		// Token: 0x04000146 RID: 326
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04000147 RID: 327
		private Label label_0;

		// Token: 0x04000148 RID: 328
		private Label label_1;
	}
}
