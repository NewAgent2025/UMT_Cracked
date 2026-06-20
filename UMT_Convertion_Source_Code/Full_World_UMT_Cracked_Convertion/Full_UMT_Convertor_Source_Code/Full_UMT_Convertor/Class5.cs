using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Full_UMT_Convertor.utils;

// Token: 0x02000039 RID: 57
internal class Class5
{
	// Token: 0x060001FF RID: 511 RVA: 0x00003359 File Offset: 0x00001559
	public static ImageList smethod_0()
	{
		if (Class5.imageList_0 == null)
		{
			Class5.smethod_4();
		}
		return Class5.imageList_0;
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000336C File Offset: 0x0000156C
	public static void smethod_1(ImageList imageList_1)
	{
		Class5.imageList_0 = imageList_1;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00003374 File Offset: 0x00001574
	internal static Dictionary<string, Class4> smethod_2()
	{
		if (Class5.dictionary_0 == null)
		{
			Class5.smethod_4();
		}
		return Class5.dictionary_0;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00003387 File Offset: 0x00001587
	internal static void smethod_3(Dictionary<string, Class4> dictionary_1)
	{
		Class5.dictionary_0 = dictionary_1;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00012C04 File Offset: 0x00010E04
	public static void smethod_4()
	{
		Class5.dictionary_0 = new Dictionary<string, Class4>();
		Class5.imageList_0 = new ImageList();
		Class5.imageList_0.ColorDepth = ColorDepth.Depth32Bit;
		Class5.imageList_0.TransparentColor = Color.Transparent;
		Class5.imageList_0.ImageSize = new Size(25, 25);
		string str = AppDomain.CurrentDomain.BaseDirectory + "support\\";
		string string_ = str + "blocks.txt";
		string string_2 = str + "blocks.png";
		Class5.smethod_5(string_2, string_);
		string string_3 = str + "items.txt";
		string string_4 = str + "items.png";
		Class5.smethod_5(string_4, string_3);
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00012CA8 File Offset: 0x00010EA8
	private static void smethod_5(string string_0, string string_1)
	{
		int num = 0;
		if (File.Exists(string_1) && File.Exists(string_0))
		{
			Image image_ = Image.FromFile(string_0);
			StreamReader streamReader = new StreamReader(string_1);
			string string_2;
			while ((string_2 = streamReader.ReadLine()) != null)
			{
				Class4 @class = Class5.smethod_6(string_2, num, image_);
				if (@class != null)
				{
					string key = @class.Id.ToString() + ((@class.Data > 0) ? ("-" + @class.Data.ToString()) : "");
					Image image = @class.method_2();
					Class5.imageList_0.Images.Add(key, image);
					Class5.dictionary_0.Add(key, @class);
				}
				num++;
			}
			streamReader.Close();
		}
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00012D70 File Offset: 0x00010F70
	private static Class4 smethod_6(string string_0, int int_0, Image image_0)
	{
		string[] array = string_0.Split(new char[]
		{
			','
		});
		Class4 @class = null;
		if (array.Length != 3)
		{
			if (array.Length != 4)
			{
				return @class;
			}
		}
		Class5.smethod_8(array[0]);
		@class = new Class4();
		@class.Id = Class5.smethod_8(array[0]);
		@class.Data = Class5.smethod_8(array[1]);
		@class.Description = array[2];
		if (array.Length == 4)
		{
			int_0 = Class5.smethod_8(array[3]);
		}
		@class.method_3(Class5.smethod_7(int_0, image_0));
		return @class;
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00012DFC File Offset: 0x00010FFC
	private static Image smethod_7(int int_0, Image image_0)
	{
		int x = int_0 % 16 * 32;
		int y = int_0 / 16 * 32;
		Bitmap bitmap = new Bitmap(32, 32);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.DrawImage(image_0, new Rectangle(0, 0, 32, 32), new Rectangle(x, y, 32, 32), GraphicsUnit.Pixel);
		}
		return bitmap;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00012E68 File Offset: 0x00011068
	private static int smethod_8(string string_0)
	{
		int result;
		int.TryParse(string_0, out result);
		return result;
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00012E80 File Offset: 0x00011080
	public static Image smethod_9(int int_0, int int_1)
	{
		Image result = null;
		string key = int_0.ToString();
		string key2 = int_0.ToString() + "-" + int_1.ToString();
		if (Class5.smethod_2().ContainsKey(key2))
		{
			result = Class5.dictionary_0[key2].method_2();
		}
		else if (Class5.smethod_2().ContainsKey(key))
		{
			result = Class5.dictionary_0[key].method_2();
		}
		return result;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00012EF0 File Offset: 0x000110F0
	public static bool smethod_10(int int_0, int int_1)
	{
		string key = int_0.ToString() + "-" + int_1.ToString();
		return Class5.dictionary_0.ContainsKey(key);
	}

	// Token: 0x0400013F RID: 319
	private static ImageUtils imageUtils_0 = new ImageUtils();

	// Token: 0x04000140 RID: 320
	private static ImageList imageList_0 = null;

	// Token: 0x04000141 RID: 321
	private static Dictionary<string, Class4> dictionary_0 = null;
}
