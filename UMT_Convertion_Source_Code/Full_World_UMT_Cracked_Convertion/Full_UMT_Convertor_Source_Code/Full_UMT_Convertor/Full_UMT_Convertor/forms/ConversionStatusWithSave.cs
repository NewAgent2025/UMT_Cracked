using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using MCPELevelDBI.workers;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x0200001E RID: 30
	public partial class ConversionStatusWithSave : Form
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000D048 File Offset: 0x0000B248
		public ConversionStatusWithSave(ConvertStatus convertStatus)
		{
			base.Close();
			this.method_2();
			this.convertStatus = convertStatus;
			this.label_0.Text = "Converted Chunks: " + convertStatus.ProcessedChunkCount.ToString();
			this.label_2.Text = "Missing Chunks: " + convertStatus.MissingChunkCount.ToString();
			this.label_1.Text = "Invalid Chunks: " + convertStatus.InvalidChunkCount.ToString();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002C30 File Offset: 0x00000E30
		private void ConversionStatusWithSave_Load(object sender, EventArgs e)
		{
			base.Close();
			this.method_1();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002C3E File Offset: 0x00000E3E
		private void button_2_Click(object sender, EventArgs e)
		{
			this.method_1();
			base.Close();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		private void method_1()
		{
			string text = Path.Combine(new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				"Pryze Software",
				"Universal Minecraft Tool",
				"CONVERTER",
				"workspaces"
			});
			Directory.CreateDirectory(text);
			string path = Path.GetRandomFileName().Replace(".", "").Substring(0, 5) + ".pe";
			string text2 = Path.Combine(text, path);
			Directory.CreateDirectory(text2);
			FileUtils.CopyFoldersAndFiles(this.convertStatus.SourceFolder, text2);
			new PEProcessWorker().SaveFromStaging(text2, this.convertStatus.WorkingFolder);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000D17C File Offset: 0x0000B37C
		private void method_2()
		{
			this.button_0 = new Button();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.button_2 = new Button();
			base.SuspendLayout();
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(175, 83);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(60, 23);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Close";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Visible = false;
			this.label_0.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(32, 46);
			this.label_0.Name = "lblConvertedChunks";
			this.label_0.Size = new Size(180, 18);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Converted Chunks";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.label_1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_1.Location = new Point(32, 99);
			this.label_1.Name = "lblInvalidChunks";
			this.label_1.Size = new Size(180, 18);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "Invalid Chunks";
			this.label_1.TextAlign = ContentAlignment.MiddleCenter;
			this.label_1.Visible = false;
			this.label_2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_2.Location = new Point(32, 73);
			this.label_2.Name = "lblMissingChunks";
			this.label_2.Size = new Size(180, 18);
			this.label_2.TabIndex = 2;
			this.label_2.Text = "Missing Chunks";
			this.label_2.TextAlign = ContentAlignment.MiddleCenter;
			this.label_2.Visible = false;
			this.label_3.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_3.Location = new Point(26, 16);
			this.label_3.Name = "label1";
			this.label_3.Size = new Size(195, 28);
			this.label_3.TabIndex = 0;
			this.label_3.Text = "Conversion Completed";
			this.label_3.TextAlign = ContentAlignment.MiddleCenter;
			this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_2.Location = new Point(167, 81);
			this.button_2.Name = "btnSaveAs";
			this.button_2.Size = new Size(60, 23);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "Save As";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(236, 112);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConversionStatusWithSave";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Conversion Status";
			base.Load += this.ConversionStatusWithSave_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x04000085 RID: 133
		private ConvertStatus convertStatus;

		// Token: 0x04000087 RID: 135
		private Button button_0;

		// Token: 0x04000088 RID: 136
		private Label label_0;

		// Token: 0x04000089 RID: 137
		private Label label_1;

		// Token: 0x0400008A RID: 138
		private Label label_2;

		// Token: 0x0400008B RID: 139
		private Label label_3;

		// Token: 0x0400008C RID: 140
		private Button button_2;

		// Token: 0x0400008D RID: 141
		private Button button_3;
	}
}
