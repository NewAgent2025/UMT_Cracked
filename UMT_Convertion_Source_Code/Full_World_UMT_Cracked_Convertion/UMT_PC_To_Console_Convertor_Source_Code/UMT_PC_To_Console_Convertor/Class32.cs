using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

// Token: 0x020000B3 RID: 179
internal class Class32
{
	// Token: 0x0600078B RID: 1931 RVA: 0x000063C1 File Offset: 0x000045C1
	public static void smethod_0()
	{
		if (!Class32.bool_0)
		{
			Class32.smethod_5();
			Class32.smethod_6();
			Class32.bool_0 = true;
		}
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x000063DA File Offset: 0x000045DA
	public static string[] smethod_1()
	{
		return Class32.list_0.ToArray();
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x0002F038 File Offset: 0x0002D238
	public static List<LibraryItem> smethod_2(string string_0)
	{
		if (string_0 == "ALL")
		{
			return Class32.list_1;
		}
		return (from p in Class32.list_1
		where p.Category == string_0
		select p).ToList<LibraryItem>();
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x0002F088 File Offset: 0x0002D288
	public static void smethod_3(string string_0)
	{
		foreach (LibraryItem libraryItem in Class32.list_1)
		{
			if (libraryItem.Name.ToLower() == string_0.ToLower())
			{
				Class32.list_1.Remove(libraryItem);
				break;
			}
		}
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x000063E6 File Offset: 0x000045E6
	public static void smethod_4(LibraryItem libraryItem_0)
	{
		Class32.smethod_3(libraryItem_0.Name);
		Class32.list_1.Add(libraryItem_0);
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
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
			if (!string.IsNullOrWhiteSpace(text2) && !Class32.list_0.Contains(text2))
			{
				Class32.list_0.Add(text2);
			}
		}
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x0002F180 File Offset: 0x0002D380
	private static void smethod_6()
	{
		string libraryFolder = Utils.GetLibraryFolder();
		string[] files = Directory.GetFiles(libraryFolder, "*.lbi");
		foreach (string string_ in files)
		{
			LibraryItem libraryItem = Class32.smethod_7(string_);
			if (libraryItem != null)
			{
				Class32.list_1.Add(libraryItem);
				if (!string.IsNullOrWhiteSpace(libraryItem.Category) && !Class32.list_0.Contains(libraryItem.Category))
				{
					string item = libraryItem.Category.Trim();
					Class32.list_0.Add(item);
				}
			}
		}
		IEnumerable<LibraryItem> source = Class32.list_1;
		if (Class32.func_0 == null)
		{
			Class32.func_0 = new Func<LibraryItem, string>(Class32.smethod_8);
		}
		Class32.list_1 = source.OrderBy(Class32.func_0).ToList<LibraryItem>();
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0002F240 File Offset: 0x0002D440
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
				LibraryItem libraryItem2 = text;
				.<<EMPTY_NAME>><LibraryItem>();
				libraryItem = libraryItem2;
				libraryItem.Path = string_0;
			}
			catch (Exception)
			{
			}
		}
		return libraryItem;
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x000063FE File Offset: 0x000045FE
	[CompilerGenerated]
	private static string smethod_8(LibraryItem libraryItem_0)
	{
		return libraryItem_0.Name;
	}

	// Token: 0x040004D3 RID: 1235
	private static List<string> list_0 = new List<string>();

	// Token: 0x040004D4 RID: 1236
	private static List<LibraryItem> list_1 = new List<LibraryItem>();

	// Token: 0x040004D5 RID: 1237
	private static bool bool_0 = false;

	// Token: 0x040004D6 RID: 1238
	[CompilerGenerated]
	private static Func<LibraryItem, string> func_0;
}
