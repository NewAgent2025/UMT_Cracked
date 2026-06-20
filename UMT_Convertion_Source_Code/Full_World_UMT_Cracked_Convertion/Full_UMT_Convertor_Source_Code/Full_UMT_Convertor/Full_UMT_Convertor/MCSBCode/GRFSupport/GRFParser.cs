using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x020000B8 RID: 184
	public class GRFParser
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00005F95 File Offset: 0x00004195
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00005F9D File Offset: 0x0000419D
		public Dictionary<int, GRFRule> Rules
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00005FA6 File Offset: 0x000041A6
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00005FAE File Offset: 0x000041AE
		public List<GRFRuleItem> RuleItems
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00005FB7 File Offset: 0x000041B7
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00005FBF File Offset: 0x000041BF
		public List<LanguageItem> Languages
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00005FC8 File Offset: 0x000041C8
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00005FD0 File Offset: 0x000041D0
		internal List<LanguageMessages> Messages
		{
			get
			{
				return this.list_2;
			}
			set
			{
				this.list_2 = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00005FD9 File Offset: 0x000041D9
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00005FE1 File Offset: 0x000041E1
		public MemoryStream Stream
		{
			get
			{
				return this.memoryStream_0;
			}
			set
			{
				this.memoryStream_0 = value;
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00041CE0 File Offset: 0x0003FEE0
		public void Parse(byte[] buffer)
		{
			List<GRFRuleDefinition> list = GRFRuleDefinition.ReadUserRuleDefs();
			foreach (GRFRuleDefinition grfruleDefinition in list)
			{
				if (grfruleDefinition.IsContainer && !GRFParser.containerNodes.Contains(grfruleDefinition.Name))
				{
					GRFParser.containerNodes.Add(grfruleDefinition.Name);
				}
			}
			this.dictionary_0 = new Dictionary<int, GRFRule>();
			this.list_1 = new List<GRFRuleItem>();
			int int_ = 0;
			int int_2 = 0;
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(buffer, 0, buffer.Length);
			this.method_3(memoryStream, out int_, out int_2);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			this.method_4(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			this.method_7(int_, int_2, list, memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			this.memoryStream_0 = memoryStream;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00041DE4 File Offset: 0x0003FFE4
		private int method_0(int int_0, byte[] byte_0)
		{
			byte[] value = this.method_2(4, int_0, byte_0);
			return BitConverter.ToInt32(value, 0);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00005FEA File Offset: 0x000041EA
		private byte[] method_1(byte[] byte_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(byte_0);
			}
			return byte_0;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00041E04 File Offset: 0x00040004
		private byte[] method_2(int int_0, int int_1, byte[] byte_0)
		{
			byte[] array = new byte[int_0];
			Array.Copy(byte_0, int_1, array, 0, int_0);
			return array;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00041E24 File Offset: 0x00040024
		private int method_3(MemoryStream memoryStream_1, out int int_0, out int int_1)
		{
			memoryStream_1.Seek(0L, SeekOrigin.Begin);
			int num = this.method_14(memoryStream_1);
			memoryStream_1.Seek((long)(num + 11 + 4), SeekOrigin.Begin);
			int_1 = this.method_14(memoryStream_1);
			int_0 = (int)memoryStream_1.Position;
			return num;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00041E6C File Offset: 0x0004006C
		private void method_4(MemoryStream memoryStream_1)
		{
			memoryStream_1.Seek(8L, SeekOrigin.Begin);
			int int_ = this.method_14(memoryStream_1);
			if (this.method_14(memoryStream_1) == 0)
			{
				memoryStream_1.ReadByte();
				this.string_0 = this.method_13(memoryStream_1);
				this.bool_0 = true;
			}
			else
			{
				memoryStream_1.Seek(-4L, SeekOrigin.Current);
			}
			this.list_0 = this.method_5(int_, memoryStream_1);
			this.list_2 = this.method_6(this.list_0, memoryStream_1);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00041EEC File Offset: 0x000400EC
		private List<LanguageItem> method_5(int int_0, MemoryStream memoryStream_1)
		{
			this.list_0 = new List<LanguageItem>();
			for (int i = 0; i < int_0; i++)
			{
				string language = this.method_13(memoryStream_1);
				int id = this.method_14(memoryStream_1);
				LanguageItem item = new LanguageItem(id, language);
				this.list_0.Add(item);
			}
			return this.list_0;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00041F3C File Offset: 0x0004013C
		private List<LanguageMessages> method_6(List<LanguageItem> list_3, MemoryStream memoryStream_1)
		{
			this.list_2 = new List<LanguageMessages>();
			foreach (LanguageItem languageItem in list_3)
			{
				byte[] array = new byte[languageItem.Length];
				memoryStream_1.Read(array, 0, array.Length);
				MemoryStream memoryStream = new MemoryStream(array);
				this.method_14(memoryStream);
				memoryStream.ReadByte();
				string language = this.method_13(memoryStream);
				int num = this.method_14(memoryStream);
				List<MessageItem> list = new List<MessageItem>();
				for (int i = 0; i < num; i++)
				{
					string messageId = this.string_0;
					if (!this.bool_0)
					{
						messageId = this.method_13(memoryStream);
					}
					string message = this.method_13(memoryStream);
					MessageItem item = new MessageItem(messageId, message);
					list.Add(item);
				}
				LanguageMessages item2 = new LanguageMessages(language, list);
				this.list_2.Add(item2);
			}
			return this.list_2;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00042040 File Offset: 0x00040240
		private void method_7(int int_0, int int_1, List<GRFRuleDefinition> list_3, MemoryStream memoryStream_1)
		{
			this.method_8(int_0, int_1, memoryStream_1);
			int num = this.dictionary_0.Count;
			foreach (GRFRuleDefinition grfruleDefinition in list_3)
			{
				bool flag = false;
				foreach (GRFRule grfrule in this.dictionary_0.Values)
				{
					if (grfrule.Name == grfruleDefinition.Name)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					this.dictionary_0.Add(num, new GRFRule(num, grfruleDefinition.Name));
					num++;
				}
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00042118 File Offset: 0x00040318
		private void method_8(int int_0, int int_1, MemoryStream memoryStream_1)
		{
			memoryStream_1.Seek((long)int_0, SeekOrigin.Begin);
			for (int i = 0; i < int_1; i++)
			{
				string text = this.method_13(memoryStream_1);
				GRFRule value = new GRFRule(i, text);
				this.dictionary_0.Add(i, value);
				if ((text == "" || char.IsUpper(text[0])) && !GRFParser.containerNodes.Contains(text))
				{
					GRFParser.containerNodes.Add(text);
				}
			}
			new List<GRFRuleItem>();
			memoryStream_1.Seek(7L, SeekOrigin.Current);
			this.method_9(memoryStream_1, this.list_1, 0);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000421B4 File Offset: 0x000403B4
		private void method_9(MemoryStream memoryStream_1, List<GRFRuleItem> list_3, int int_0)
		{
			bool flag = false;
			while (!flag && memoryStream_1.Position < memoryStream_1.Length)
			{
				byte b = (byte)memoryStream_1.ReadByte();
				bool flag2 = false;
				if (b == 0)
				{
					int num = this.method_10(memoryStream_1) + 1;
					if (int_0 >= num / 2)
					{
						b = (byte)memoryStream_1.ReadByte();
						return;
					}
					if (num == 4)
					{
						flag2 = true;
					}
					else
					{
						flag = true;
					}
				}
				if (b != 0 || flag2)
				{
					int num2 = (int)b;
					string value = this.method_11(memoryStream_1, num2);
					GRFRuleItem grfruleItem = new GRFRuleItem(num2, value);
					list_3.Add(grfruleItem);
					string name = this.dictionary_0[num2].Name;
					if (GRFParser.containerNodes.Contains(name) && string.IsNullOrWhiteSpace(value))
					{
						grfruleItem.Rules = new List<GRFRuleItem>();
						this.method_9(memoryStream_1, grfruleItem.Rules, int_0 + 1);
					}
				}
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00042294 File Offset: 0x00040494
		private int method_10(MemoryStream memoryStream_1)
		{
			int num = 0;
			long position = memoryStream_1.Position;
			while (memoryStream_1.Position < memoryStream_1.Length && memoryStream_1.ReadByte() == 0)
			{
				num++;
			}
			memoryStream_1.Seek(position, SeekOrigin.Begin);
			return num;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000422D0 File Offset: 0x000404D0
		private string method_11(MemoryStream memoryStream_1, int int_0)
		{
			string result = "";
			byte[] array = this.method_15(2, memoryStream_1);
			bool bool_ = false;
			if (array[0] != 0 || array[1] != 0)
			{
				result = this.method_13(memoryStream_1);
				bool_ = true;
			}
			this.method_12(memoryStream_1, int_0, bool_);
			return result;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0004230C File Offset: 0x0004050C
		private void method_12(MemoryStream memoryStream_1, int int_0, bool bool_1)
		{
			string name = this.dictionary_0[int_0].Name;
			int num = 3;
			for (int i = 0; i < num; i++)
			{
				memoryStream_1.ReadByte();
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00042340 File Offset: 0x00040540
		private string method_13(MemoryStream memoryStream_1)
		{
			byte[] array = new byte[2];
			memoryStream_1.Read(array, 0, 2);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			short num = BitConverter.ToInt16(array, 0);
			byte[] array2 = new byte[(int)num];
			for (int i = 0; i < (int)num; i++)
			{
				byte b = (byte)memoryStream_1.ReadByte();
				array2[i] = b;
			}
			Encoding utf = Encoding.UTF8;
			return utf.GetString(array2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000423A8 File Offset: 0x000405A8
		private int method_14(MemoryStream memoryStream_1)
		{
			byte[] array = new byte[4];
			memoryStream_1.Read(array, 0, array.Length);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000423E0 File Offset: 0x000405E0
		private byte[] method_15(int int_0, MemoryStream memoryStream_1)
		{
			byte[] array = new byte[int_0];
			memoryStream_1.Read(array, 0, int_0);
			memoryStream_1.Seek((long)(-(long)int_0), SeekOrigin.Current);
			return array;
		}

		// Token: 0x04000539 RID: 1337
		private List<LanguageItem> list_0;

		// Token: 0x0400053A RID: 1338
		private Dictionary<int, GRFRule> dictionary_0;

		// Token: 0x0400053B RID: 1339
		private List<GRFRuleItem> list_1;

		// Token: 0x0400053C RID: 1340
		private List<LanguageMessages> list_2;

		// Token: 0x0400053D RID: 1341
		private MemoryStream memoryStream_0;

		// Token: 0x0400053E RID: 1342
		private bool bool_0;

		// Token: 0x0400053F RID: 1343
		private string string_0;

		// Token: 0x04000540 RID: 1344
		public static List<string> containerNodes = new List<string>
		{
			"promptName",
			"descriptionName",
			"itemId"
		};
	}
}
