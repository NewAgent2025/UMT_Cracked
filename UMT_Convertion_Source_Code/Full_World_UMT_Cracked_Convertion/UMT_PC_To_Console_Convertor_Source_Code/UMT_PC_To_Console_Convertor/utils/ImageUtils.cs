using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using Substrate.Data;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000C7 RID: 199
	public class ImageUtils
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x00006B23 File Offset: 0x00004D23
		public Bitmap ResizeWithPerspective(Bitmap image, bool interpolate)
		{
			return this.ResizeWithPerspective(image, 128, 128, interpolate);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00032008 File Offset: 0x00030208
		public Bitmap ResizeWithPerspective(Bitmap image, int boxWidth, int boxHeight, bool interpolate)
		{
			double num = (double)image.Width / (double)image.Height;
			Bitmap result;
			if ((int)((double)boxHeight * num) <= boxWidth)
			{
				if (interpolate)
				{
					result = this.ShrinkImage(image, (int)((double)boxHeight * num), boxHeight);
				}
				else
				{
					result = new Bitmap(image, (int)((double)boxHeight * num), boxHeight);
				}
			}
			else if (interpolate)
			{
				result = this.ShrinkImage(image, boxWidth, (int)((double)boxWidth / num));
			}
			else
			{
				result = new Bitmap(image, boxWidth, (int)((double)boxWidth / num));
			}
			return result;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00032074 File Offset: 0x00030274
		public Bitmap EnlargeImage(Bitmap original, int width, int height)
		{
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.Bicubic;
				graphics.DrawImage(original, new Rectangle(Point.Empty, bitmap.Size));
			}
			return bitmap;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000320CC File Offset: 0x000302CC
		public Bitmap ShrinkImage(Bitmap original, int width, int height)
		{
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(original, new Rectangle(Point.Empty, bitmap.Size));
			}
			return bitmap;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00032124 File Offset: 0x00030324
		public Bitmap CopySmallerImage(Bitmap resizedImage)
		{
			Bitmap bitmap = this.NewMapImage();
			if (resizedImage.Width <= 128 || resizedImage.Height <= 128)
			{
				int num = (128 - resizedImage.Width) / 2;
				int num2 = (128 - resizedImage.Height) / 2;
				for (int i = 0; i < resizedImage.Width; i++)
				{
					for (int j = 0; j < resizedImage.Height; j++)
					{
						Color pixel = resizedImage.GetPixel(i, j);
						bitmap.SetPixel(i + num, j + num2, pixel);
					}
				}
			}
			return bitmap;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00006B37 File Offset: 0x00004D37
		public Bitmap NewMapImage()
		{
			return this.NewMapImage(128, 128);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000321B4 File Offset: 0x000303B4
		public Bitmap NewMapImage(int x, int y)
		{
			Color color = Color.FromArgb(0, 0, 0, 0);
			Bitmap bitmap = new Bitmap(x, y);
			Brush brush = new SolidBrush(color);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
			}
			return bitmap;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00032214 File Offset: 0x00030414
		public void SaveImage(Map map, string imagePath)
		{
			if (!string.IsNullOrWhiteSpace(imagePath))
			{
				MapConverter mapConverter = new MapConverter();
				Bitmap bitmap = mapConverter.MapToBitmap(map);
				Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppPArgb);
				using (Graphics graphics = Graphics.FromImage(bitmap2))
				{
					graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap2.Width, bitmap2.Height));
				}
				bitmap2.MakeTransparent(Color.Black);
				Image image = bitmap2;
				image.Save(imagePath, ImageFormat.Png);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000322A8 File Offset: 0x000304A8
		public SortedDictionary<int, MCMap> LoadMaps()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Working.smethod_5() + Working.smethod_4() + "data");
			FileInfo[] files = directoryInfo.GetFiles("map_*.dat");
			SortedDictionary<int, MCMap> sortedDictionary = new SortedDictionary<int, MCMap>();
			FileInfo[] array = files;
			if (ImageUtils.comparison_0 == null)
			{
				ImageUtils.comparison_0 = new Comparison<FileInfo>(ImageUtils.smethod_0);
			}
			Array.Sort<FileInfo>(array, ImageUtils.comparison_0);
			foreach (FileInfo fileInfo in files)
			{
				MCMap mcmap = this.LoadMap(fileInfo.FullName);
				sortedDictionary.Add(mcmap.Index, mcmap);
			}
			return sortedDictionary;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00032340 File Offset: 0x00030540
		public MCMap LoadMap(string path)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
			byte[] buffer = FileUtils.smethod_0(path);
			MemoryStream s = new MemoryStream(buffer);
			NbtTree nbtTree = new NbtTree(s);
			Map map = new Map();
			map = map.LoadTree(nbtTree.Root);
			int index = this.method_0(fileNameWithoutExtension);
			return new MCMap(index, fileNameWithoutExtension, map);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00032394 File Offset: 0x00030594
		private int method_0(string string_0)
		{
			int result = 0;
			int.TryParse(string_0.Substring(4), out result);
			return result;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000323B4 File Offset: 0x000305B4
		[CompilerGenerated]
		private static int smethod_0(FileInfo fileInfo_0, FileInfo fileInfo_1)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo_0.Name);
			string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(fileInfo_1.Name);
			int num;
			int.TryParse(fileNameWithoutExtension.Substring(4), out num);
			int num2;
			int.TryParse(fileNameWithoutExtension2.Substring(4), out num2);
			int result = 0;
			if (num < num2)
			{
				result = -1;
			}
			else if (num > num2)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x04000537 RID: 1335
		[CompilerGenerated]
		private static Comparison<FileInfo> comparison_0;
	}
}
