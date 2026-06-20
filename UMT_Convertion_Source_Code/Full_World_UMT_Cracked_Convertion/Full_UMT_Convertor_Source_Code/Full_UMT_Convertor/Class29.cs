using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

// Token: 0x020000BA RID: 186
internal class Class29
{
	// Token: 0x060007C8 RID: 1992 RVA: 0x00002591 File Offset: 0x00000791
	public Class29()
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00005FFA File Offset: 0x000041FA
	public Class29(BackgroundWorker backgroundWorker_1)
	{
		this.backgroundWorker_0 = backgroundWorker_1;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x000426FC File Offset: 0x000408FC
	internal void method_0(string string_0, string string_1, bool bool_0 = false)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(string_1))
		{
			this.method_7("Extraction started.", 0);
			string_1 = FileUtils.CheckFolderSep(string_1);
			string text = string_1 + Working.smethod_1();
			FileUtils.smethod_12(string_0, text);
			Working.IsPS3Compressed = false;
			this.method_1(text);
			this.method_2(string_1, bool_0);
			this.method_7("Extraction completed...", 100);
		}
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00042764 File Offset: 0x00040964
	internal void method_1(string string_0)
	{
		byte[] array = FileUtils.smethod_0(string_0);
		Class47 @class = new Class47();
		MemoryStream memoryStream = new MemoryStream(array);
		if (@class.method_4(memoryStream) == 0)
		{
			@class.method_4(memoryStream);
			@class.method_4(memoryStream);
			memoryStream.Read(array, 0, array.Length - 12);
			array = Class46.smethod_67(array);
			FileUtils.WriteFile(array, string_0);
			Working.IsPS3Compressed = true;
		}
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x000427C4 File Offset: 0x000409C4
	private void method_2(string string_0, bool bool_0)
	{
		string path = string_0 + Working.smethod_1();
		if (File.Exists(path))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				IEnumerable<IndexEntry> source = Class46.smethod_1(binaryReader);
				if (Class29.func_0 == null)
				{
					Class29.func_0 = new Func<IndexEntry, string>(Class29.smethod_0);
				}
				List<IndexEntry> list = source.OrderBy(Class29.func_0).ToList<IndexEntry>();
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_7("Extracting file - " + indexEntry.FilePath, int_);
					this.method_3(binaryReader, indexEntry, string_0 + Working.smethod_4());
					indexEntry.FilePath.EndsWith(".grf");
				}
			}
		}
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x000428B0 File Offset: 0x00040AB0
	private void method_3(BinaryReader binaryReader_0, IndexEntry indexEntry_0, string string_0)
	{
		string text = string_0 + indexEntry_0.FilePath;
		this.method_4(text);
		binaryReader_0.BaseStream.Seek((long)((ulong)indexEntry_0.FileOffset), SeekOrigin.Begin);
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
		{
			int num = 0;
			while ((long)num < (long)((ulong)indexEntry_0.FileLength))
			{
				binaryWriter.Write(binaryReader_0.ReadByte());
				num++;
			}
		}
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x000375C8 File Offset: 0x000357C8
	private void method_4(string string_0)
	{
		if (string_0.IndexOf("\\") > 0)
		{
			string string_ = string_0.Substring(0, string_0.LastIndexOf('\\'));
			FileUtils.smethod_9(string_);
		}
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00006009 File Offset: 0x00004209
	private void method_5(IndexEntry indexEntry_0, string string_0)
	{
		this.method_4(string_0 + indexEntry_0.FilePath);
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x000375FC File Offset: 0x000357FC
	private void method_6(string string_0)
	{
		foreach (string path in Directory.GetFiles(string_0))
		{
			File.Delete(path);
		}
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x0000601D File Offset: 0x0000421D
	private void method_7(string string_0, int int_0 = 0)
	{
		if (this.backgroundWorker_0 != null)
		{
			this.backgroundWorker_0.ReportProgress(int_0, string_0);
		}
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00004FB4 File Offset: 0x000031B4
	[CompilerGenerated]
	private static string smethod_0(IndexEntry indexEntry_0)
	{
		return indexEntry_0.FileExt;
	}

	// Token: 0x04000541 RID: 1345
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x04000542 RID: 1346
	[CompilerGenerated]
	private static Func<IndexEntry, string> func_0;
}
