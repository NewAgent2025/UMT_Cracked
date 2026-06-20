using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000036 RID: 54
	public class ProgressBarEx : ProgressBar
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00003AB5 File Offset: 0x00001CB5
		public ProgressBarEx()
		{
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00003163 File Offset: 0x00001363
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000148AC File Offset: 0x00012AAC
		protected override void OnPaint(PaintEventArgs e)
		{
			using (Image image = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(image))
				{
					Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
					if (ProgressBarRenderer.IsSupported)
					{
						ProgressBarRenderer.DrawHorizontalBar(graphics, rectangle);
					}
					rectangle.Inflate(new Size(-2, -2));
					rectangle.Width = (int)((double)rectangle.Width * ((double)base.Value / (double)base.Maximum));
					if (rectangle.Width == 0)
					{
						rectangle.Width = 1;
					}
					LinearGradientBrush brush = new LinearGradientBrush(rectangle, this.BackColor, this.ForeColor, LinearGradientMode.Vertical);
					graphics.FillRectangle(brush, 2, 2, rectangle.Width, rectangle.Height);
					e.Graphics.DrawImage(image, 0, 0);
					image.Dispose();
				}
			}
		}
	}
}
