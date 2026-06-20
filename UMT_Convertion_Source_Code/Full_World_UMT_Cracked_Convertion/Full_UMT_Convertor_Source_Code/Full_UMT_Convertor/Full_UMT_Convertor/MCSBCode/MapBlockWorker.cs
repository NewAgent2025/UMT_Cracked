using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.Properties;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000096 RID: 150
	public class MapBlockWorker
	{
		// Token: 0x0600064C RID: 1612 RVA: 0x0000522C File Offset: 0x0000342C
		public MapBlockWorker()
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000523F File Offset: 0x0000343F
		public MapBlockWorker(BackgroundWorker backgroundWorker)
		{
			this.backgroundWorker = backgroundWorker;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00039570 File Offset: 0x00037770
		public Image[] MapBlocks(string region, string outFolderPath)
		{
			return this.DoMap(region, outFolderPath);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00039588 File Offset: 0x00037788
		public Image[] DoMap(string dimension, string outFolderPath)
		{
			this.method_1(dimension);
			Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
			Dictionary<string, Image> dictionary2 = new Dictionary<string, Image>();
			Dictionary<string, Image> dictionary3 = new Dictionary<string, Image>();
			ManualResetEvent[] array = new ManualResetEvent[4];
			MapBlockParameter[] array2 = new MapBlockParameter[4];
			int num = 0;
			foreach (string region in Constants.regionFileNames)
			{
				array[num] = new ManualResetEvent(false);
				MapBlockParameter mapBlockParameter = new MapBlockParameter(dimension, region, outFolderPath, array[num]);
				MapBlocks @object = new MapBlocks();
				ThreadPool.QueueUserWorkItem(new WaitCallback(@object.MapRegion), mapBlockParameter);
				array2[num] = mapBlockParameter;
				num++;
			}
			bool flag = false;
			while (!flag)
			{
				int num2 = 0;
				flag = true;
				for (int j = 0; j < 4; j++)
				{
					if (!array2[j].Completed)
					{
						flag = false;
					}
					num2 += array2[j].ChunkProcessedCount;
				}
				this.method_2(string.Concat(new object[]
				{
					"Searched ",
					num2,
					" of ",
					this.int_1,
					" chunks"
				}), num2);
				Thread.Sleep(100);
			}
			WaitHandle.WaitAll(array);
			for (int k = 0; k < 4; k++)
			{
				dictionary.Add(array2[k].Region, array2[k].BlockImage);
				dictionary2.Add(array2[k].Region, array2[k].BiomeImage);
				dictionary3.Add(array2[k].Region, array2[k].HeightImage);
			}
			Image image = this.wnBzlEoYbv(dictionary);
			Image image2 = this.wnBzlEoYbv(dictionary2);
			Image image3 = this.wnBzlEoYbv(dictionary3);
			return new Bitmap[]
			{
				image,
				image2,
				image3,
				this.method_0(image, image2)
			};
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00039768 File Offset: 0x00037968
		private Bitmap wnBzlEoYbv(Dictionary<string, Image> dictionary_0)
		{
			Bitmap bitmap = new Bitmap(1024, 1024);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(dictionary_0["r.-1.-1"], 0, 0);
				graphics.DrawImage(dictionary_0["r.0.-1"], this.int_0, 0);
				graphics.DrawImage(dictionary_0["r.-1.0"], 0, this.int_0);
				graphics.DrawImage(dictionary_0["r.0.0"], this.int_0, this.int_0);
			}
			return bitmap;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0003980C File Offset: 0x00037A0C
		private Image method_0(Image image_0, Image image_1)
		{
			Image image = (Image)image_0.Clone();
			float matrix = (float)Settings.Default.HrybridOpacity / 100f;
			ColorMatrix colorMatrix = new ColorMatrix();
			colorMatrix.Matrix33 = matrix;
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			Rectangle destRect = new Rectangle(0, 0, 1024, 1024);
			using (Graphics graphics = Graphics.FromImage(image))
			{
				graphics.DrawImage(image_1, destRect, 0, 0, 1024, 1024, GraphicsUnit.Pixel, imageAttributes);
			}
			return image;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000398A8 File Offset: 0x00037AA8
		private void method_1(string string_0)
		{
			int num = 0 + Constants.consoleRegionSizes[string_0];
			this.int_1 = num * 4;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000398D0 File Offset: 0x00037AD0
		private void method_2(string string_0, int int_2)
		{
			int int_3 = (int)((float)int_2 / (float)this.int_1 * 100f);
			this.method_3(string_0, int_3);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00005259 File Offset: 0x00003459
		private void method_3(string string_0, int int_2 = 0)
		{
			if (this.backgroundWorker != null)
			{
				this.backgroundWorker.ReportProgress(int_2, string_0);
			}
		}

		// Token: 0x040003BF RID: 959
		private int int_0 = 512;

		// Token: 0x040003C0 RID: 960
		private BackgroundWorker backgroundWorker;

		// Token: 0x040003C1 RID: 961
		private int int_1;
	}
}
