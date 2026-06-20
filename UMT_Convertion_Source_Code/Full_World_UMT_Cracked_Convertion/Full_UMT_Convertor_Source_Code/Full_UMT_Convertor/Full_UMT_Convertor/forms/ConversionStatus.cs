using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000070 RID: 112
	public partial class ConversionStatus : Form
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00021AE8 File Offset: 0x0001FCE8
		public ConversionStatus(ConvertStatus convertStatus)
		{
			base.Close();
			this.method_0();
			this.label_0.Text = "Converted Chunks: " + convertStatus.ProcessedChunkCount.ToString();
			this.label_2.Text = "Missing Chunks: " + convertStatus.MissingChunkCount.ToString();
			this.label_1.Text = "Invalid Chunks: " + convertStatus.InvalidChunkCount.ToString();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00004919 File Offset: 0x00002B19
		private void ConversionStatus_Load(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00021B70 File Offset: 0x0001FD70
		private void method_0()
		{
			this.button_0 = new Button();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			base.SuspendLayout();
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(113, 119);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Close";
			this.button_0.UseVisualStyleBackColor = true;
			this.label_0.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(12, 33);
			this.label_0.Name = "lblConvertedChunks";
			this.label_0.Size = new Size(180, 18);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Converted Chunks";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.label_1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_1.Location = new Point(12, 86);
			this.label_1.Name = "lblInvalidChunks";
			this.label_1.Size = new Size(180, 18);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Invalid Chunks";
			this.label_1.TextAlign = ContentAlignment.MiddleCenter;
			this.label_2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_2.Location = new Point(12, 60);
			this.label_2.Name = "lblMissingChunks";
			this.label_2.Size = new Size(180, 18);
			this.label_2.TabIndex = 3;
			this.label_2.Text = "Missing Chunks";
			this.label_2.TextAlign = ContentAlignment.MiddleCenter;
			this.label_3.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_3.Location = new Point(6, 3);
			this.label_3.Name = "label1";
			this.label_3.Size = new Size(195, 28);
			this.label_3.TabIndex = 5;
			this.label_3.Text = "Conversion Completed";
			this.label_3.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(206, 149);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConversionStatus";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Conversion Status";
			base.Load += this.ConversionStatus_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x04000285 RID: 645
		private Button button_0;

		// Token: 0x04000286 RID: 646
		private Label label_0;

		// Token: 0x04000287 RID: 647
		private Label label_1;

		// Token: 0x04000288 RID: 648
		private Label label_2;

		// Token: 0x04000289 RID: 649
		private Label label_3;
	}
}
