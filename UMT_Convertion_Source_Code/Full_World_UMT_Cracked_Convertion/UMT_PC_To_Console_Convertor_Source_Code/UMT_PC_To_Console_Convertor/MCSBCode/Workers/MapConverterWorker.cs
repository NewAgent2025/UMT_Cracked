using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Substrate.Data;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode.Workers
{
	// Token: 0x02000067 RID: 103
	public class MapConverterWorker
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x000049B9 File Offset: 0x00002BB9
		public MapConverterWorker()
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000049CC File Offset: 0x00002BCC
		public MapConverterWorker(BackgroundWorker backgroundWorker)
		{
			this.backgroundWorker = backgroundWorker;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00024CA8 File Offset: 0x00022EA8
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

		// Token: 0x0600049D RID: 1181 RVA: 0x00024EA0 File Offset: 0x000230A0
		private void method_0(int int_1)
		{
			int int_2 = (int)((float)int_1 / (float)this.int_0 * 100f);
			string string_ = string.Format("Map {0} of {1}", int_1, this.int_0);
			this.method_1(string_, int_2);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000049E6 File Offset: 0x00002BE6
		private void method_1(string string_0, int int_1 = 0)
		{
			if (this.backgroundWorker != null)
			{
				this.backgroundWorker.ReportProgress(int_1, string_0);
			}
		}

		// Token: 0x0400034B RID: 843
		private ImageUtils imageUtils_0 = new ImageUtils();

		// Token: 0x0400034C RID: 844
		private BackgroundWorker backgroundWorker;

		// Token: 0x0400034D RID: 845
		private int int_0;
	}
}
