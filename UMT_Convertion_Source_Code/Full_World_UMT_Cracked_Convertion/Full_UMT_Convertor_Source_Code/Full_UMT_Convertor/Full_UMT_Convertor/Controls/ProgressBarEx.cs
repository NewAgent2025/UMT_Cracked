using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200004F RID: 79
	public class ProgressBarEx : ProgressBar
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00003E6D File Offset: 0x0000206D
		public ProgressBarEx()
		{
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002BAE File Offset: 0x00000DAE
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001A09C File Offset: 0x0001829C
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
