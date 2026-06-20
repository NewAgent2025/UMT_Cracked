using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.MCSBCode.GRFSupport;

// Token: 0x0200008E RID: 142
internal class Class25
{
	// Token: 0x060005EA RID: 1514 RVA: 0x00037FAC File Offset: 0x000361AC
	public byte[] method_0(Dictionary<int, GRFRule> dictionary_0, List<GRFRuleItem> list_0, List<LanguageMessages> list_1, string string_0)
	{
		MemoryStream memoryStream = this.method_1(dictionary_0, list_0, list_1);
		return memoryStream.ToArray();
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00037FCC File Offset: 0x000361CC
	private MemoryStream method_1(Dictionary<int, GRFRule> dictionary_0, List<GRFRuleItem> list_0, List<LanguageMessages> list_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		this.method_5(memoryStream);
		List<byte[]> list_2 = this.method_8(list_1);
		this.method_7(list_1, list_2, memoryStream);
		this.method_6(memoryStream);
		this.method_4(dictionary_0, memoryStream);
		this.method_3(dictionary_0, list_0, memoryStream);
		this.method_2(memoryStream);
		return memoryStream;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00038018 File Offset: 0x00036218
	private void method_2(MemoryStream memoryStream_0)
	{
		for (int i = 0; i < 2088; i++)
		{
			memoryStream_0.WriteByte(0);
		}
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0003803C File Offset: 0x0003623C
	private void method_3(Dictionary<int, GRFRule> dictionary_0, List<GRFRuleItem> list_0, MemoryStream memoryStream_0)
	{
		if (list_0 != null)
		{
			foreach (GRFRuleItem grfruleItem in list_0)
			{
				string name = dictionary_0[grfruleItem.Id].Name;
				string value = grfruleItem.Value;
				memoryStream_0.WriteByte((byte)grfruleItem.Id);
				if (!GRFParser.containerNodes.Contains(name) || !string.IsNullOrWhiteSpace(value))
				{
					if (!string.IsNullOrWhiteSpace(grfruleItem.Value))
					{
						this.class47_0.method_12(grfruleItem.Value, memoryStream_0);
					}
					memoryStream_0.WriteByte(0);
					memoryStream_0.WriteByte(0);
					memoryStream_0.WriteByte(0);
				}
				else
				{
					memoryStream_0.WriteByte(0);
					memoryStream_0.WriteByte(0);
					memoryStream_0.WriteByte(0);
					this.method_3(dictionary_0, grfruleItem.Rules, memoryStream_0);
					memoryStream_0.WriteByte(0);
					memoryStream_0.WriteByte(0);
				}
			}
		}
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00038130 File Offset: 0x00036330
	private void method_4(Dictionary<int, GRFRule> dictionary_0, MemoryStream memoryStream_0)
	{
		byte[] array = new byte[11];
		array[1] = 2;
		byte[] array2 = array;
		byte[] array3 = new byte[7];
		byte[] array4 = array3;
		memoryStream_0.Write(array2, 0, array2.Length);
		this.class47_0.method_10(dictionary_0.Count, memoryStream_0);
		foreach (GRFRule grfrule in dictionary_0.Values)
		{
			this.class47_0.method_12(grfrule.Name, memoryStream_0);
		}
		memoryStream_0.Write(array4, 0, array4.Length);
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00005009 File Offset: 0x00003209
	private void method_5(MemoryStream memoryStream_0)
	{
		this.class47_0.method_10(0, memoryStream_0);
		this.class47_0.method_10(0, memoryStream_0);
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x000381D4 File Offset: 0x000363D4
	private void method_6(MemoryStream memoryStream_0)
	{
		int int_ = (int)memoryStream_0.Length - 4;
		memoryStream_0.Seek(0L, SeekOrigin.Begin);
		this.class47_0.method_10(int_, memoryStream_0);
		memoryStream_0.Seek(0L, SeekOrigin.End);
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0003821C File Offset: 0x0003641C
	private void method_7(List<LanguageMessages> list_0, List<byte[]> list_1, MemoryStream memoryStream_0)
	{
		this.class47_0.method_10(list_0.Count, memoryStream_0);
		if (list_0.Count > 0)
		{
			this.class47_0.method_10(0, memoryStream_0);
			memoryStream_0.WriteByte((byte)list_0[0].Messages.Count);
			this.class47_0.method_12(list_0[0].Messages[0].MessageId, memoryStream_0);
			for (int i = 0; i < list_0.Count; i++)
			{
				this.class47_0.method_12(list_0[i].Language, memoryStream_0);
				this.class47_0.method_10(list_1[i].Length, memoryStream_0);
			}
			for (int j = 0; j < list_1.Count; j++)
			{
				memoryStream_0.Write(list_1[j], 0, list_1[j].Length);
			}
		}
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x000382F8 File Offset: 0x000364F8
	private List<byte[]> method_8(List<LanguageMessages> list_0)
	{
		List<byte[]> list = new List<byte[]>();
		foreach (LanguageMessages languageMessages in list_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			this.class47_0.method_10(2, memoryStream);
			memoryStream.WriteByte(0);
			this.class47_0.method_12(languageMessages.Language, memoryStream);
			this.class47_0.method_10(languageMessages.Messages.Count, memoryStream);
			foreach (MessageItem messageItem in languageMessages.Messages)
			{
				this.class47_0.method_12(messageItem.Message, memoryStream);
			}
			list.Add(memoryStream.ToArray());
		}
		return list;
	}

	// Token: 0x040003AC RID: 940
	private Class47 class47_0 = new Class47();
}
