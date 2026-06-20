using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000FC RID: 252
	public class IndexEntry
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00054184 File Offset: 0x00052384
		public IndexEntry(string filePath, string fileName, string fileExt, string parentName, bool isRegion, int rx, int rz)
		{
			this.filePath = filePath;
			this.fileName = fileName;
			this.fileExt = fileExt;
			this.parentName = parentName;
			this.isRegion = isRegion;
			this.rawData = new byte[144];
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00054204 File Offset: 0x00052404
		public IndexEntry(byte[] rawData)
		{
			this.rawData = rawData;
			this.filePath = this.method_2(rawData);
			this.fileName = this.method_4(this.filePath);
			this.fileExt = this.method_5(this.fileName);
			this.parentName = this.method_6(this.filePath);
			this.uint_1 = this.method_0(rawData, 128);
			this.uint_0 = this.method_0(rawData, 132);
			this.isRegion = this.method_7(this.fileName, out this.int_0, out this.int_1);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000542DC File Offset: 0x000524DC
		private uint method_0(byte[] byte_0, int int_2)
		{
			byte[] array = new byte[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = byte_0[int_2 + (3 - i)];
			}
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00054310 File Offset: 0x00052510
		private void method_1(byte[] byte_0, int int_2, uint uint_2)
		{
			byte[] bytes = BitConverter.GetBytes(uint_2);
			byte_0[int_2] = bytes[3];
			byte_0[int_2 + 1] = bytes[2];
			byte_0[int_2 + 2] = bytes[1];
			byte_0[int_2 + 3] = bytes[0];
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00054344 File Offset: 0x00052544
		private string method_2(byte[] byte_0)
		{
			string text = this.method_3(byte_0);
			text = text.Replace('/', '\\');
			if (text.EndsWith("mcr"))
			{
				if (text.IndexOf("DIM") == -1)
				{
					text = "region\\" + text;
				}
				else
				{
					text = text.Replace("DIM-1", "DIM-1\\");
				}
			}
			if (Working.GameType == (Enum2)2 && (text.StartsWith("P_") || text.StartsWith("N_")))
			{
				text = "players\\" + text;
			}
			return text;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000543D4 File Offset: 0x000525D4
		private string method_3(byte[] byte_0)
		{
			List<byte> list = new List<byte>();
			int num = 0;
			for (int i = 0; i < 128; i++)
			{
				if (this.rawData[i] != 0)
				{
					list.Add(this.rawData[i]);
					num = 0;
				}
				else
				{
					num++;
				}
				if (num > 1)
				{
					break;
				}
			}
			return Encoding.UTF8.GetString(list.ToArray());
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00054430 File Offset: 0x00052630
		private string method_4(string string_0)
		{
			string result = string_0;
			int num = string_0.IndexOf('\\');
			if (num > 0)
			{
				result = string_0.Substring(num + 1);
			}
			return result;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00054458 File Offset: 0x00052658
		private string method_5(string string_0)
		{
			string result = "";
			int num = string_0.LastIndexOf('.');
			if (num > 0)
			{
				result = string_0.Substring(num + 1);
			}
			return result;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00054484 File Offset: 0x00052684
		private string method_6(string string_0)
		{
			string result = null;
			int num = string_0.IndexOf('\\');
			if (num > 0)
			{
				result = string_0.Substring(0, num);
			}
			return result;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000544AC File Offset: 0x000526AC
		private bool method_7(string string_0, out int int_2, out int int_3)
		{
			int_2 = 0;
			int_3 = 0;
			Match match = IndexEntry.regex_0.Match(string_0);
			if (match.Success && match.Groups.Count > 3)
			{
				int_2 = int.Parse(match.Groups[1].Value);
				int_3 = int.Parse(match.Groups[2].Value);
			}
			return match.Success;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00007868 File Offset: 0x00005A68
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00007870 File Offset: 0x00005A70
		public Guid Key
		{
			get
			{
				return this.guid_0;
			}
			set
			{
				this.guid_0 = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00007879 File Offset: 0x00005A79
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00007881 File Offset: 0x00005A81
		public byte[] RawData
		{
			get
			{
				return this.rawData;
			}
			set
			{
				this.rawData = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0000788A File Offset: 0x00005A8A
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00007892 File Offset: 0x00005A92
		public uint FileOffset
		{
			get
			{
				return this.uint_0;
			}
			set
			{
				this.uint_0 = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0000789B File Offset: 0x00005A9B
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x000078A3 File Offset: 0x00005AA3
		public uint FileLength
		{
			get
			{
				return this.uint_1;
			}
			set
			{
				this.uint_1 = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000078AC File Offset: 0x00005AAC
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x000078B4 File Offset: 0x00005AB4
		public string FilePath
		{
			get
			{
				return this.filePath;
			}
			set
			{
				this.filePath = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000078BD File Offset: 0x00005ABD
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x000078C5 File Offset: 0x00005AC5
		public string FileName
		{
			get
			{
				return this.fileName;
			}
			set
			{
				this.fileName = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000078CE File Offset: 0x00005ACE
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000078D6 File Offset: 0x00005AD6
		public string FileExt
		{
			get
			{
				return this.fileExt;
			}
			set
			{
				this.fileExt = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000078DF File Offset: 0x00005ADF
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000078E7 File Offset: 0x00005AE7
		public string ParentName
		{
			get
			{
				return this.parentName;
			}
			set
			{
				this.parentName = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000078F0 File Offset: 0x00005AF0
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000078F8 File Offset: 0x00005AF8
		public bool IsRegion
		{
			get
			{
				return this.isRegion;
			}
			set
			{
				this.isRegion = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00007901 File Offset: 0x00005B01
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00007909 File Offset: 0x00005B09
		public int RX
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00007912 File Offset: 0x00005B12
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x0000791A File Offset: 0x00005B1A
		public int RZ
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00007923 File Offset: 0x00005B23
		public void UpdateRawData()
		{
			this.method_1(this.rawData, 128, this.FileLength);
			this.method_1(this.rawData, 132, this.FileOffset);
		}

		// Token: 0x04000728 RID: 1832
		private static Regex regex_0 = new Regex("^r\\.(-?\\d+)\\.(-?\\d+)\\.(mcr|mca)$");

		// Token: 0x04000729 RID: 1833
		private Guid guid_0 = Guid.NewGuid();

		// Token: 0x0400072A RID: 1834
		private byte[] rawData;

		// Token: 0x0400072B RID: 1835
		private uint uint_0;

		// Token: 0x0400072C RID: 1836
		private uint uint_1;

		// Token: 0x0400072D RID: 1837
		private string filePath = string.Empty;

		// Token: 0x0400072E RID: 1838
		private string fileName = string.Empty;

		// Token: 0x0400072F RID: 1839
		private string fileExt = string.Empty;

		// Token: 0x04000730 RID: 1840
		private string parentName = string.Empty;

		// Token: 0x04000731 RID: 1841
		private bool isRegion;

		// Token: 0x04000732 RID: 1842
		private int int_0;

		// Token: 0x04000733 RID: 1843
		private int int_1;
	}
}
