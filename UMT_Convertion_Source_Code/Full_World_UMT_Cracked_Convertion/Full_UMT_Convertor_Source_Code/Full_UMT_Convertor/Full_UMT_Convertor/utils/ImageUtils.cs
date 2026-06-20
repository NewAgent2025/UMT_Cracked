using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Substrate.Data;
using Substrate.Nbt;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000141 RID: 321
	public class ImageUtils
	{
		// Token: 0x06000D9A RID: 3482 RVA: 0x00008DCC File Offset: 0x00006FCC
		public Bitmap ResizeWithPerspective(Bitmap image, bool interpolate)
		{
			return this.ResizeWithPerspective(image, 128, 128, interpolate);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0005C7B8 File Offset: 0x0005A9B8
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

		// Token: 0x06000D9C RID: 3484 RVA: 0x0005C824 File Offset: 0x0005AA24
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

		// Token: 0x06000D9D RID: 3485 RVA: 0x0005C87C File Offset: 0x0005AA7C
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

		// Token: 0x06000D9E RID: 3486 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
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

		// Token: 0x06000D9F RID: 3487 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public Bitmap NewMapImage()
		{
			return this.NewMapImage(128, 128);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0005C964 File Offset: 0x0005AB64
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

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0005C9C4 File Offset: 0x0005ABC4
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

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0005CA58 File Offset: 0x0005AC58
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

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
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

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0005CB44 File Offset: 0x0005AD44
		private int method_0(string string_0)
		{
			int result = 0;
			int.TryParse(string_0.Substring(4), out result);
			return result;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0005CB64 File Offset: 0x0005AD64
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

		// Token: 0x0400081E RID: 2078
		[CompilerGenerated]
		private static Comparison<FileInfo> comparison_0;
	}
}
