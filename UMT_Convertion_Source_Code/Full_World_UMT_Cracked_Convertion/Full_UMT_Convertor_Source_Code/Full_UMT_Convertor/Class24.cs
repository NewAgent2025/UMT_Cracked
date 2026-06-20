using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

// Token: 0x0200008C RID: 140
internal class Class24
{
	// Token: 0x060005D0 RID: 1488 RVA: 0x00002591 File Offset: 0x00000791
	public Class24()
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00004FBC File Offset: 0x000031BC
	public Class24(BackgroundWorker backgroundWorker_1)
	{
		this.backgroundWorker_0 = backgroundWorker_1;
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00037400 File Offset: 0x00035600
	internal void method_0(string string_0, string string_1, bool bool_0 = false)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(string_1))
		{
			this.method_8("Extraction started.", 0);
			string_1 = FileUtils.CheckFolderSep(string_1);
			string string_2 = string_1 + Working.smethod_1();
			this.method_6(string_0, string_2);
			this.method_1(string_1, bool_0);
			this.method_8("Extraction completed...", 100);
		}
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0003745C File Offset: 0x0003565C
	private void method_1(string string_0, bool bool_0)
	{
		string path = string_0 + Working.smethod_1();
		if (File.Exists(path))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				IEnumerable<IndexEntry> source = Class46.smethod_1(binaryReader);
				if (Class24.func_0 == null)
				{
					Class24.func_0 = new Func<IndexEntry, string>(Class24.smethod_0);
				}
				List<IndexEntry> list = source.OrderBy(Class24.func_0).ToList<IndexEntry>();
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_8("Extracting file - " + indexEntry.FilePath, int_);
					this.method_2(binaryReader, indexEntry, string_0 + Working.smethod_4());
					indexEntry.FilePath.EndsWith(".grf");
				}
			}
		}
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00037548 File Offset: 0x00035748
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

	// Token: 0x060005D5 RID: 1493 RVA: 0x000375C8 File Offset: 0x000357C8
	private void method_3(string string_0)
	{
		if (string_0.IndexOf("\\") > 0)
		{
			string string_ = string_0.Substring(0, string_0.LastIndexOf('\\'));
			FileUtils.smethod_9(string_);
		}
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00004FCB File Offset: 0x000031CB
	private void method_4(IndexEntry indexEntry_0, string string_0)
	{
		this.method_3(string_0 + indexEntry_0.FilePath);
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x000375FC File Offset: 0x000357FC
	private void method_5(string string_0)
	{
		foreach (string path in Directory.GetFiles(string_0))
		{
			File.Delete(path);
		}
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00037628 File Offset: 0x00035828
	private void method_6(string string_0, string string_1)
	{
		byte[] byte_ = this.method_7(string_0);
		byte[] bytes = Class46.smethod_64(byte_);
		FileUtils.WriteFile(bytes, string_1);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0003764C File Offset: 0x0003584C
	private byte[] method_7(string string_0)
	{
		byte[] array = null;
		if (File.Exists(string_0))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				long length = binaryReader.BaseStream.Length;
				binaryReader.BaseStream.Seek(8L, SeekOrigin.Begin);
				array = new byte[length - 8L];
				binaryReader.Read(array, 0, array.Length);
			}
		}
		return array;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00004FDF File Offset: 0x000031DF
	private void method_8(string string_0, int int_0 = 0)
	{
		if (this.backgroundWorker_0 != null)
		{
			this.backgroundWorker_0.ReportProgress(int_0, string_0);
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00004FB4 File Offset: 0x000031B4
	[CompilerGenerated]
	private static string smethod_0(IndexEntry indexEntry_0)
	{
		return indexEntry_0.FileExt;
	}

	// Token: 0x040003A1 RID: 929
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x040003A2 RID: 930
	[CompilerGenerated]
	private static Func<IndexEntry, string> func_0;
}
