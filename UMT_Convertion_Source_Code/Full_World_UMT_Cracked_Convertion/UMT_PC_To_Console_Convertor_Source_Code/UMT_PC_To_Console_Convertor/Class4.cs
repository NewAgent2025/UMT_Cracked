using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.utils;

// Token: 0x0200001E RID: 30
internal class Class4
{
	// Token: 0x060000CE RID: 206 RVA: 0x00002ABC File Offset: 0x00000CBC
	public static ImageList smethod_0()
	{
		if (Class4.imageList_0 == null)
		{
			Class4.smethod_3();
		}
		return Class4.imageList_0;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002ACF File Offset: 0x00000CCF
	public static void pLyXaDwgNg(ImageList imageList_1)
	{
		Class4.imageList_0 = imageList_1;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002AD7 File Offset: 0x00000CD7
	internal static Dictionary<string, Class3> smethod_1()
	{
		if (Class4.dictionary_0 == null)
		{
			Class4.smethod_3();
		}
		return Class4.dictionary_0;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002AEA File Offset: 0x00000CEA
	internal static void smethod_2(Dictionary<string, Class3> dictionary_1)
	{
		Class4.dictionary_0 = dictionary_1;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000A3D4 File Offset: 0x000085D4
	public static void smethod_3()
	{
		int num = 0;
		Class4.imageList_0 = new ImageList();
		Class4.imageList_0.ColorDepth = ColorDepth.Depth32Bit;
		Class4.imageList_0.TransparentColor = Color.Transparent;
		Class4.imageList_0.ImageSize = new Size(25, 25);
		Class4.dictionary_0 = new Dictionary<string, Class3>();
		string str = AppDomain.CurrentDomain.BaseDirectory + "support\\";
		string path = str + "blocks.txt";
		string text = str + "blocks.png";
		if (File.Exists(path) && File.Exists(text))
		{
			Image image_ = Image.FromFile(text);
			StreamReader streamReader = new StreamReader(path);
			string string_;
			while ((string_ = streamReader.ReadLine()) != null)
			{
				Class3 @class = Class4.smethod_4(string_, num, image_);
				if (@class != null)
				{
					string key = @class.Id.ToString() + ((@class.Data > 0) ? ("-" + @class.Data.ToString()) : "");
					Image image = @class.method_2();
					Class4.imageList_0.Images.Add(key, image);
					Class4.dictionary_0.Add(key, @class);
				}
				num++;
			}
			streamReader.Close();
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000A510 File Offset: 0x00008710
	private static Class3 smethod_4(string string_0, int int_0, Image image_0)
	{
		string[] array = string_0.Split(new char[]
		{
			','
		});
		Class3 @class = null;
		if (array.Length == 3)
		{
			int key = Class4.smethod_6(array[0]);
			if (Class29.smethod_1().ContainsKey(key) && Class29.smethod_1()[key].method_4())
			{
				@class = new Class3();
				@class.Id = Class4.smethod_6(array[0]);
				@class.Data = Class4.smethod_6(array[1]);
				@class.Description = array[2];
				@class.method_3(Class4.smethod_5(int_0, image_0));
			}
		}
		return @class;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000A59C File Offset: 0x0000879C
	private static Image smethod_5(int int_0, Image image_0)
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

	// Token: 0x060000D5 RID: 213 RVA: 0x0000A608 File Offset: 0x00008808
	private static int smethod_6(string string_0)
	{
		int result;
		int.TryParse(string_0, out result);
		return result;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000A620 File Offset: 0x00008820
	public static Image smethod_7(int int_0, int int_1)
	{
		Image result = null;
		string key = int_0.ToString();
		string key2 = int_0.ToString() + "-" + int_1.ToString();
		if (Class4.dictionary_0.ContainsKey(key2))
		{
			result = Class4.dictionary_0[key2].method_2();
		}
		else if (Class4.dictionary_0.ContainsKey(key))
		{
			result = Class4.dictionary_0[key].method_2();
		}
		return result;
	}

	// Token: 0x04000076 RID: 118
	private static ImageUtils imageUtils_0 = new ImageUtils();

	// Token: 0x04000077 RID: 119
	private static ImageList imageList_0 = null;

	// Token: 0x04000078 RID: 120
	private static Dictionary<string, Class3> dictionary_0 = null;
}
