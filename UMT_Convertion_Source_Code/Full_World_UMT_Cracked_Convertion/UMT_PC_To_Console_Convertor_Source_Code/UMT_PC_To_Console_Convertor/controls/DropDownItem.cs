using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x0200002B RID: 43
	public class DropDownItem
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000033BD File Offset: 0x000015BD
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000033C5 File Offset: 0x000015C5
		public string Value { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000033CE File Offset: 0x000015CE
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000033D6 File Offset: 0x000015D6
		public string Key { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000033DF File Offset: 0x000015DF
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x000033E7 File Offset: 0x000015E7
		public string Text { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000033F0 File Offset: 0x000015F0
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000033F8 File Offset: 0x000015F8
		public Image Image { get; set; }

		// Token: 0x060001AB RID: 427 RVA: 0x00003401 File Offset: 0x00001601
		public DropDownItem() : this("", "", "")
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000F720 File Offset: 0x0000D920
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

		// Token: 0x060001AD RID: 429 RVA: 0x00003418 File Offset: 0x00001618
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x040000E2 RID: 226
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000E3 RID: 227
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040000E4 RID: 228
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040000E5 RID: 229
		[CompilerGenerated]
		private Image image_0;
	}
}
