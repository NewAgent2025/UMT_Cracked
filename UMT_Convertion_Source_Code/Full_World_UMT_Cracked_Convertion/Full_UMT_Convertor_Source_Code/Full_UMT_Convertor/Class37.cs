using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

// Token: 0x020000F8 RID: 248
internal class Class37
{
	// Token: 0x06000A8A RID: 2698 RVA: 0x0000769E File Offset: 0x0000589E
	public static void smethod_0()
	{
		if (!Class37.oadHuyounad)
		{
			Class37.smethod_5();
			Class37.smethod_6();
			Class37.oadHuyounad = true;
		}
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x000076B7 File Offset: 0x000058B7
	public static string[] smethod_1()
	{
		return Class37.list_0.ToArray();
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00053BE4 File Offset: 0x00051DE4
	public static List<LibraryItem> smethod_2(string string_0)
	{
		if (string_0 == "ALL")
		{
			return Class37.list_1;
		}
		return (from p in Class37.list_1
		where p.Category == string_0
		select p).ToList<LibraryItem>();
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00053C34 File Offset: 0x00051E34
	public static void smethod_3(string string_0)
	{
		foreach (LibraryItem libraryItem in Class37.list_1)
		{
			if (libraryItem.Name.ToLower() == string_0.ToLower())
			{
				Class37.list_1.Remove(libraryItem);
				break;
			}
		}
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x000076C3 File Offset: 0x000058C3
	public static void smethod_4(LibraryItem libraryItem_0)
	{
		Class37.smethod_3(libraryItem_0.Name);
		Class37.list_1.Add(libraryItem_0);
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00053CA4 File Offset: 0x00051EA4
	private static void smethod_5()
	{
		string path = Utils.GetLibraryFolder() + "categories.txt";
		if (!File.Exists(path))
		{
			return;
		}
		foreach (string text in File.ReadLines(path))
		{
			string text2 = text.Trim();
			if (!string.IsNullOrWhiteSpace(text2) && !Class37.list_0.Contains(text2))
			{
				Class37.list_0.Add(text2);
			}
		}
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00053D2C File Offset: 0x00051F2C
	private static void smethod_6()
	{
		string libraryFolder = Utils.GetLibraryFolder();
		string[] files = Directory.GetFiles(libraryFolder, "*.lbi");
		foreach (string string_ in files)
		{
			LibraryItem libraryItem = Class37.smethod_7(string_);
			if (libraryItem != null)
			{
				Class37.list_1.Add(libraryItem);
				if (!string.IsNullOrWhiteSpace(libraryItem.Category) && !Class37.list_0.Contains(libraryItem.Category))
				{
					string item = libraryItem.Category.Trim();
					Class37.list_0.Add(item);
				}
			}
		}
		IEnumerable<LibraryItem> source = Class37.list_1;
		if (Class37.func_0 == null)
		{
			Class37.func_0 = new Func<LibraryItem, string>(Class37.smethod_8);
		}
		Class37.list_1 = source.OrderBy(Class37.func_0).ToList<LibraryItem>();
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00053DEC File Offset: 0x00051FEC
	private static LibraryItem smethod_7(string string_0)
	{
		LibraryItem libraryItem = null;
		string text = null;
		if (File.Exists(string_0))
		{
			using (StreamReader streamReader = new StreamReader(File.Open(string_0, FileMode.Open)))
			{
				text = streamReader.ReadToEnd();
			}
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			try
			{
				libraryItem = DataConversion.Deserialize<LibraryItem>(text);
				libraryItem.Path = string_0;
			}
			catch (Exception)
			{
			}
		}
		return libraryItem;
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x000076DB File Offset: 0x000058DB
	[CompilerGenerated]
	private static string smethod_8(LibraryItem libraryItem_0)
	{
		return libraryItem_0.Name;
	}

	// Token: 0x04000708 RID: 1800
	private static List<string> list_0 = new List<string>();

	// Token: 0x04000709 RID: 1801
	private static List<LibraryItem> list_1 = new List<LibraryItem>();

	// Token: 0x0400070A RID: 1802
	private static bool oadHuyounad = false;

	// Token: 0x0400070B RID: 1803
	[CompilerGenerated]
	private static Func<LibraryItem, string> func_0;
}
