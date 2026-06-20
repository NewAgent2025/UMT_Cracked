using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000B7 RID: 183
	public class IndexEntry
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x0002F4F4 File Offset: 0x0002D6F4
		public IndexEntry(byte[] rawData)
		{
			this.rawData = rawData;
			this.string_0 = this.method_2(rawData);
			this.string_1 = this.method_4(this.string_0);
			this.string_2 = this.method_5(this.string_1);
			this.string_3 = this.method_6(this.string_0);
			this.uint_1 = this.method_0(rawData, 128);
			this.uint_0 = this.method_0(rawData, 132);
			this.bool_0 = this.method_7(this.string_1, out this.int_0, out this.int_1);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		private uint method_0(byte[] byte_0, int int_2)
		{
			byte[] array = new byte[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = byte_0[int_2 + (3 - i)];
			}
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002F600 File Offset: 0x0002D800
		private void method_1(byte[] byte_0, int int_2, uint uint_2)
		{
			byte[] bytes = BitConverter.GetBytes(uint_2);
			byte_0[int_2] = bytes[3];
			byte_0[int_2 + 1] = bytes[2];
			byte_0[int_2 + 2] = bytes[1];
			byte_0[int_2 + 3] = bytes[0];
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002F634 File Offset: 0x0002D834
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

		// Token: 0x060007BD RID: 1981 RVA: 0x0002F6C4 File Offset: 0x0002D8C4
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

		// Token: 0x060007BE RID: 1982 RVA: 0x0002F720 File Offset: 0x0002D920
		private string method_4(string string_4)
		{
			string result = string_4;
			int num = string_4.IndexOf('\\');
			if (num > 0)
			{
				result = string_4.Substring(num + 1);
			}
			return result;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0002F748 File Offset: 0x0002D948
		private string method_5(string string_4)
		{
			string result = "";
			int num = string_4.LastIndexOf('.');
			if (num > 0)
			{
				result = string_4.Substring(num + 1);
			}
			return result;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0002F774 File Offset: 0x0002D974
		private string method_6(string string_4)
		{
			string result = null;
			int num = string_4.IndexOf('\\');
			if (num > 0)
			{
				result = string_4.Substring(0, num);
			}
			return result;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0002F79C File Offset: 0x0002D99C
		private bool method_7(string string_4, out int int_2, out int int_3)
		{
			int_2 = 0;
			int_3 = 0;
			Match match = IndexEntry.regex_0.Match(string_4);
			if (match.Success && match.Groups.Count > 3)
			{
				int_2 = int.Parse(match.Groups[1].Value);
				int_3 = int.Parse(match.Groups[2].Value);
			}
			return match.Success;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00006531 File Offset: 0x00004731
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00006539 File Offset: 0x00004739
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00006542 File Offset: 0x00004742
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0000654A File Offset: 0x0000474A
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00006553 File Offset: 0x00004753
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0000655B File Offset: 0x0000475B
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

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00006564 File Offset: 0x00004764
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0000656C File Offset: 0x0000476C
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00006575 File Offset: 0x00004775
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0000657D File Offset: 0x0000477D
		public string FilePath
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00006586 File Offset: 0x00004786
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0000658E File Offset: 0x0000478E
		public string FileName
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00006597 File Offset: 0x00004797
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0000659F File Offset: 0x0000479F
		public string FileExt
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000065A8 File Offset: 0x000047A8
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000065B0 File Offset: 0x000047B0
		public string ParentName
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000065B9 File Offset: 0x000047B9
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000065C1 File Offset: 0x000047C1
		public bool IsRegion
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x000065CA File Offset: 0x000047CA
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000065D2 File Offset: 0x000047D2
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000065DB File Offset: 0x000047DB
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x000065E3 File Offset: 0x000047E3
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

		// Token: 0x060007D8 RID: 2008 RVA: 0x000065EC File Offset: 0x000047EC
		public void UpdateRawData()
		{
			this.method_1(this.rawData, 128, this.FileLength);
			this.method_1(this.rawData, 132, this.FileOffset);
		}

		// Token: 0x040004ED RID: 1261
		private static Regex regex_0 = new Regex("^r\\.(-?\\d+)\\.(-?\\d+)\\.(mcr|mca)$");

		// Token: 0x040004EE RID: 1262
		private Guid guid_0 = Guid.NewGuid();

		// Token: 0x040004EF RID: 1263
		private byte[] rawData;

		// Token: 0x040004F0 RID: 1264
		private uint uint_0;

		// Token: 0x040004F1 RID: 1265
		private uint uint_1;

		// Token: 0x040004F2 RID: 1266
		private string string_0 = string.Empty;

		// Token: 0x040004F3 RID: 1267
		private string string_1 = string.Empty;

		// Token: 0x040004F4 RID: 1268
		private string string_2 = string.Empty;

		// Token: 0x040004F5 RID: 1269
		private string string_3 = string.Empty;

		// Token: 0x040004F6 RID: 1270
		private bool bool_0;

		// Token: 0x040004F7 RID: 1271
		private int int_0;

		// Token: 0x040004F8 RID: 1272
		private int int_1;
	}
}
