using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Data;

namespace Full_UMT_Convertor.MCSBCode.Workers
{
	// Token: 0x0200009A RID: 154
	public class MapConverterWorker
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x00005321 File Offset: 0x00003521
		public MapConverterWorker()
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00005334 File Offset: 0x00003534
		public MapConverterWorker(BackgroundWorker backgroundWorker)
		{
			this.backgroundWorker = backgroundWorker;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0003C654 File Offset: 0x0003A854
		public void ConvertImage(int width, int height, Bitmap inImage, SortedDictionary<int, MCMap> mapList, int index, bool retainPerspective, bool interpolate)
		{
			MapConverter mapConverter = new MapConverter();
			int num = (int)Math.Ceiling(width / 128m);
			int num2 = (int)Math.Ceiling(height / 128m);
			int num3 = num * 128 - width;
			int num4 = num2 * 128 - height;
			this.int_0 = num * num2;
			Bitmap image;
			if (retainPerspective)
			{
				image = this.imageUtils_0.ResizeWithPerspective(inImage, width, height, interpolate);
			}
			else
			{
				image = new Bitmap(inImage, width, height);
			}
			if (num * 128 == width)
			{
				if (num2 * 128 == height)
				{
					goto IL_C4;
				}
			}
			Bitmap bitmap = this.imageUtils_0.NewMapImage(num * 128, num2 * 128);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImage(image, num3 / 2, num4 / 2);
			graphics.Dispose();
			image = bitmap;
			IL_C4:
			int num5 = 0;
			for (int i = 0; i < num2; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Bitmap bitmap2 = this.imageUtils_0.NewMapImage();
					Graphics graphics2 = Graphics.FromImage(bitmap2);
					Rectangle srcRect = new Rectangle(j * 128, i * 128, 128, 128);
					Rectangle destRect = new Rectangle(0, 0, 128, 128);
					graphics2.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);
					graphics2.Dispose();
					int num6 = index + num5;
					if (!mapList.ContainsKey(num6))
					{
						mapList.Add(num6, new MCMap(num6));
					}
					mapConverter.BitmapToMap(mapList[num6].Map, bitmap2);
					if (mapList[num6].MapStatus != MapStatusType.New)
					{
						mapList[num6].MapStatus = MapStatusType.Changed;
					}
					mapList[num6].Map.Dimension = -1;
					num5++;
					this.method_0(num5);
				}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0003C84C File Offset: 0x0003AA4C
		private void method_0(int int_1)
		{
			int int_2 = (int)((float)int_1 / (float)this.int_0 * 100f);
			string string_ = string.Format("Map {0} of {1}", int_1, this.int_0);
			this.method_1(string_, int_2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0000534E File Offset: 0x0000354E
		private void method_1(string string_0, int int_1 = 0)
		{
			if (this.backgroundWorker != null)
			{
				this.backgroundWorker.ReportProgress(int_1, string_0);
			}
		}

		// Token: 0x040004C6 RID: 1222
		private ImageUtils imageUtils_0 = new ImageUtils();

		// Token: 0x040004C7 RID: 1223
		private BackgroundWorker backgroundWorker;

		// Token: 0x040004C8 RID: 1224
		private int int_0;
	}
}
