using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

// Token: 0x0200007D RID: 125
internal class Class24
{
	// Token: 0x0600055F RID: 1375 RVA: 0x000024C1 File Offset: 0x000006C1
	public Class24()
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00005061 File Offset: 0x00003261
	public Class24(BackgroundWorker backgroundWorker_1)
	{
		this.backgroundWorker_0 = backgroundWorker_1;
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00029264 File Offset: 0x00027464
	internal void method_0(string string_0, string string_1, bool bool_0 = false)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(string_1))
		{
			this.method_6("Extraction started.", 0);
			string_1 = FileUtils.CheckFolderSep(string_1);
			string string_2 = string_1 + Working.smethod_1();
			FileUtils.smethod_12(string_0, string_2);
			this.method_1(string_1, bool_0);
			this.method_6("Extraction completed...", 100);
		}
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x000292C0 File Offset: 0x000274C0
	private void method_1(string string_0, bool bool_0)
	{
		string path = string_0 + Working.smethod_1();
		if (File.Exists(path))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				IEnumerable<IndexEntry> source = Class36.smethod_0(binaryReader);
				if (Class24.func_0 == null)
				{
					Class24.func_0 = new Func<IndexEntry, string>(Class24.smethod_0);
				}
				List<IndexEntry> list = source.OrderBy(Class24.func_0).ToList<IndexEntry>();
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_6("Extracting file - " + indexEntry.FilePath, int_);
					this.method_2(binaryReader, indexEntry, string_0 + Working.smethod_4());
					indexEntry.FilePath.EndsWith(".grf");
				}
			}
		}
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x000293AC File Offset: 0x000275AC
	private void method_2(BinaryReader binaryReader_0, IndexEntry indexEntry_0, string string_0)
	{
		string text = string_0 + indexEntry_0.FilePath;
		this.method_3(text);
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

	// Token: 0x06000564 RID: 1380 RVA: 0x000235BC File Offset: 0x000217BC
	private void method_3(string string_0)
	{
		if (string_0.IndexOf("\\") > 0)
		{
			string string_ = string_0.Substring(0, string_0.LastIndexOf('\\'));
			FileUtils.smethod_9(string_);
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00005070 File Offset: 0x00003270
	private void method_4(IndexEntry indexEntry_0, string string_0)
	{
		this.method_3(string_0 + indexEntry_0.FilePath);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x000235F0 File Offset: 0x000217F0
	private void method_5(string string_0)
	{
		foreach (string path in Directory.GetFiles(string_0))
		{
			File.Delete(path);
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00005084 File Offset: 0x00003284
	private void method_6(string string_0, int int_0 = 0)
	{
		if (this.backgroundWorker_0 != null)
		{
			this.backgroundWorker_0.ReportProgress(int_0, string_0);
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00004820 File Offset: 0x00002A20
	[CompilerGenerated]
	private static string smethod_0(IndexEntry indexEntry_0)
	{
		return indexEntry_0.FileExt;
	}

	// Token: 0x0400039F RID: 927
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x040003A0 RID: 928
	[CompilerGenerated]
	private static Func<IndexEntry, string> func_0;
}
