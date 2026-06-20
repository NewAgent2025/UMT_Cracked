using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000046 RID: 70
	public class DropDownItem
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00003A74 File Offset: 0x00001C74
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003A7C File Offset: 0x00001C7C
		public string Value { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00003A85 File Offset: 0x00001C85
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003A8D File Offset: 0x00001C8D
		public string Key { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00003A96 File Offset: 0x00001C96
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003A9E File Offset: 0x00001C9E
		public string Text { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00003AA7 File Offset: 0x00001CA7
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00003AAF File Offset: 0x00001CAF
		public Image Image { get; set; }

		// Token: 0x060002B0 RID: 688 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public DropDownItem() : this("", "", "")
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00018714 File Offset: 0x00016914
		public DropDownItem(string key, string val, string text)
		{
			this.Value = val;
			this.Key = key;
			this.Text = text;
			this.Image = new Bitmap(16, 16);
			using (Graphics graphics = Graphics.FromImage(this.Image))
			{
				using (Brush brush = new SolidBrush(Color.FromName(val)))
				{
					graphics.DrawRectangle(Pens.White, 0, 0, this.Image.Width, this.Image.Height);
					graphics.FillRectangle(brush, 1, 1, this.Image.Width - 1, this.Image.Height - 1);
				}
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000187E0 File Offset: 0x000169E0
		public DropDownItem(int key, int val, string text)
		{
			this.Value = val.ToString();
			this.Key = key.ToString();
			this.Text = text;
			this.Image = new Bitmap(16, 16);
			using (Graphics graphics = Graphics.FromImage(this.Image))
			{
				using (Brush brush = new SolidBrush(Color.FromArgb((int)(4278190080L + (long)val))))
				{
					graphics.DrawRectangle(Pens.White, 0, 0, this.Image.Width, this.Image.Height);
					graphics.FillRectangle(brush, 1, 1, this.Image.Width - 1, this.Image.Height - 1);
				}
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003ACF File Offset: 0x00001CCF
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x040001B1 RID: 433
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001B2 RID: 434
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040001B3 RID: 435
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040001B4 RID: 436
		[CompilerGenerated]
		private Image image_0;
	}
}
