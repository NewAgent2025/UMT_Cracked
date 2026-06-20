using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

// Token: 0x02000062 RID: 98
internal class Class21
{
	// Token: 0x0600044D RID: 1101 RVA: 0x000024C1 File Offset: 0x000006C1
	public Class21()
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00004828 File Offset: 0x00002A28
	public Class21(BackgroundWorker backgroundWorker_1)
	{
		this.backgroundWorker_0 = backgroundWorker_1;
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x000233F4 File Offset: 0x000215F4
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

	// Token: 0x06000450 RID: 1104 RVA: 0x00023450 File Offset: 0x00021650
	private void method_1(string string_0, bool bool_0)
	{
		string path = string_0 + Working.smethod_1();
		if (File.Exists(path))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				IEnumerable<IndexEntry> source = Class36.smethod_0(binaryReader);
				if (Class21.func_0 == null)
				{
					Class21.func_0 = new Func<IndexEntry, string>(Class21.smethod_0);
				}
				List<IndexEntry> list = source.OrderBy(Class21.func_0).ToList<IndexEntry>();
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

	// Token: 0x06000451 RID: 1105 RVA: 0x0002353C File Offset: 0x0002173C
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

	// Token: 0x06000452 RID: 1106 RVA: 0x000235BC File Offset: 0x000217BC
	private void method_3(string string_0)
	{
		if (string_0.IndexOf("\\") > 0)
		{
			string string_ = string_0.Substring(0, string_0.LastIndexOf('\\'));
			FileUtils.smethod_9(string_);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00004837 File Offset: 0x00002A37
	private void method_4(IndexEntry indexEntry_0, string string_0)
	{
		this.method_3(string_0 + indexEntry_0.FilePath);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x000235F0 File Offset: 0x000217F0
	private void method_5(string string_0)
	{
		foreach (string path in Directory.GetFiles(string_0))
		{
			File.Delete(path);
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x0002361C File Offset: 0x0002181C
	private void method_6(string string_0, string string_1)
	{
		byte[] byte_ = this.method_7(string_0);
		byte[] bytes = Class36.smethod_56(byte_);
		FileUtils.WriteFile(bytes, string_1);
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00023640 File Offset: 0x00021840
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

	// Token: 0x06000457 RID: 1111 RVA: 0x0000484B File Offset: 0x00002A4B
	private void method_8(string string_0, int int_0 = 0)
	{
		if (this.backgroundWorker_0 != null)
		{
			this.backgroundWorker_0.ReportProgress(int_0, string_0);
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00004820 File Offset: 0x00002A20
	[CompilerGenerated]
	private static string smethod_0(IndexEntry indexEntry_0)
	{
		return indexEntry_0.FileExt;
	}

	// Token: 0x04000244 RID: 580
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x04000245 RID: 581
	[CompilerGenerated]
	private static Func<IndexEntry, string> func_0;
}
