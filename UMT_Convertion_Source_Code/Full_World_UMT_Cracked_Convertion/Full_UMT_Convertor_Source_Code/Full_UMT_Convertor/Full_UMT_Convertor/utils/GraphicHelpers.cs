using System;
using System.Drawing;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x0200013F RID: 319
	public class GraphicHelpers
	{
		// Token: 0x06000D8D RID: 3469 RVA: 0x00008D83 File Offset: 0x00006F83
		public static void DrawString(Graphics g, Color color, int x, int y, string text)
		{
			g.DrawString(text, GraphicHelpers.font_0, new SolidBrush(color), (float)(x + 2), (float)(y + 1));
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
		public static void DrawString2(Graphics g, Color color, int x, int y, string text)
		{
			StringFormat format = new StringFormat
			{
				Alignment = StringAlignment.Far,
				LineAlignment = StringAlignment.Far
			};
			g.DrawString(text, GraphicHelpers.font_1, new SolidBrush(color), (float)(44 - x), (float)(44 - y), format);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0005C41C File Offset: 0x0005A61C
		public static void DrawString3(Graphics g, Color color, int x, int y, string text)
		{
			StringFormat format = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
			g.DrawString(text, GraphicHelpers.font_0, new SolidBrush(color), (float)(12 + x), (float)(20 + y), format);
		}

		// Token: 0x0400081C RID: 2076
		private static Font font_0 = new Font(FontFamily.GenericMonospace, 14f, FontStyle.Bold);

		// Token: 0x0400081D RID: 2077
		private static Font font_1 = new Font(FontFamily.GenericMonospace, 16f, FontStyle.Bold);
	}
}
