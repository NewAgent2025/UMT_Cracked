using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace PS3FileSystem
{
	// Token: 0x0200000E RID: 14
	public class PARAM_SFO
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00002692 File Offset: 0x00000892
		public PARAM_SFO(string filepath)
		{
			this.method_2(new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000026A9 File Offset: 0x000008A9
		public PARAM_SFO(byte[] inputdata)
		{
			this.method_2(new MemoryStream(inputdata));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000026BD File Offset: 0x000008BD
		public PARAM_SFO(Stream input)
		{
			this.method_2(input);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000026CC File Offset: 0x000008CC
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000026D4 File Offset: 0x000008D4
		public PARAM_SFO.Table[] Tables { get; private set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00009394 File Offset: 0x00007594
		public string AccountID
		{
			get
			{
				if (this.Tables == null)
				{
					return "";
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name.ToLower() == "account_id")
					{
						return table.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000093FC File Offset: 0x000075FC
		public PARAM_SFO.DataTypes DataType
		{
			get
			{
				if (this.Tables == null)
				{
					return PARAM_SFO.DataTypes.None;
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name == "CATEGORY")
					{
						return (PARAM_SFO.DataTypes)BitConverter.ToUInt16(Encoding.UTF8.GetBytes(table.Value), 0);
					}
				}
				return PARAM_SFO.DataTypes.None;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00009470 File Offset: 0x00007670
		public string Detail
		{
			get
			{
				if (this.Tables == null)
				{
					return "";
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name == "DETAIL")
					{
						return table.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000094D4 File Offset: 0x000076D4
		public uint ParentalControl
		{
			get
			{
				if (this.Tables == null)
				{
					return 0U;
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name == "PARENTAL_LEVEL")
					{
						return uint.Parse(table.Value);
					}
				}
				return 0U;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00009534 File Offset: 0x00007734
		public string DirectoryName
		{
			get
			{
				if (this.Tables == null)
				{
					return "";
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name == "SAVEDATA_DIRECTORY")
					{
						return table.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00009598 File Offset: 0x00007798
		public string TitleID
		{
			get
			{
				string directoryName = this.DirectoryName;
				if (directoryName == "")
				{
					return "";
				}
				return directoryName.Split(new char[]
				{
					'-'
				})[0];
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000095D4 File Offset: 0x000077D4
		public string SubTitle
		{
			get
			{
				if (this.Tables == null)
				{
					return "";
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name == "SUB_TITLE")
					{
						return table.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00009638 File Offset: 0x00007838
		public string Title
		{
			get
			{
				if (this.Tables == null)
				{
					return "";
				}
				foreach (PARAM_SFO.Table table in this.Tables)
				{
					if (table.Name == "TITLE")
					{
						return table.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000969C File Offset: 0x0000789C
		private string method_0(BinaryReader binaryReader_0, PARAM_SFO.index_table index_table_0)
		{
			binaryReader_0.BaseStream.Position = (long)((ulong)(PARAM_SFO.Header.DataTableStart + index_table_0.param_data_offset));
			switch (index_table_0.param_data_fmt)
			{
			case PARAM_SFO.FMT.UTF_8:
				return Encoding.UTF8.GetString(binaryReader_0.ReadBytes((int)index_table_0.param_data_max_len)).Replace("\0", "");
			case PARAM_SFO.FMT.ASCII:
				return Encoding.ASCII.GetString(binaryReader_0.ReadBytes((int)index_table_0.param_data_max_len)).Replace("\0", "");
			case PARAM_SFO.FMT.UINT32:
				return binaryReader_0.ReadUInt32().ToString();
			}
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000974C File Offset: 0x0000794C
		private string method_1(BinaryReader binaryReader_0, PARAM_SFO.index_table index_table_0)
		{
			binaryReader_0.BaseStream.Position = (long)((ulong)(PARAM_SFO.Header.KeyTableStart + (uint)index_table_0.param_key_offset));
			string text = "";
			while ((byte)binaryReader_0.PeekChar() != 0)
			{
				text += binaryReader_0.ReadChar();
			}
			binaryReader_0.BaseStream.Position += 1L;
			return text;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000097B4 File Offset: 0x000079B4
		private void method_2(Stream stream_0)
		{
			using (BinaryReader binaryReader = new BinaryReader(stream_0))
			{
				PARAM_SFO.Header.Read(binaryReader);
				if (!Class1.smethod_4(PARAM_SFO.Header.Magic, new byte[]
				{
					0,
					80,
					83,
					70
				}))
				{
					throw new Exception("Invalid PARAM.SFO Header Magic");
				}
				List<PARAM_SFO.index_table> list = new List<PARAM_SFO.index_table>();
				int num = 0;
				while ((long)num < (long)((ulong)PARAM_SFO.Header.IndexTableEntries))
				{
					PARAM_SFO.index_table item = default(PARAM_SFO.index_table);
					item.Read(binaryReader);
					list.Add(item);
					num++;
				}
				List<PARAM_SFO.Table> list2 = new List<PARAM_SFO.Table>();
				int num2 = 0;
				foreach (PARAM_SFO.index_table index_table in list)
				{
					PARAM_SFO.Table item2 = default(PARAM_SFO.Table);
					item2.index = num2;
					item2.Indextable = index_table;
					item2.Name = this.method_1(binaryReader, index_table);
					item2.Value = this.method_0(binaryReader, index_table);
					num2++;
					list2.Add(item2);
				}
				this.Tables = list2.ToArray();
				binaryReader.Close();
			}
		}

		// Token: 0x04000028 RID: 40
		[CompilerGenerated]
		private PARAM_SFO.Table[] table_0;

		// Token: 0x0200000F RID: 15
		public enum DataTypes : uint
		{
			// Token: 0x0400002A RID: 42
			GameData = 18244U,
			// Token: 0x0400002B RID: 43
			SaveData = 21316U,
			// Token: 0x0400002C RID: 44
			AppPhoto = 16720U,
			// Token: 0x0400002D RID: 45
			AppMusic = 16717U,
			// Token: 0x0400002E RID: 46
			AppVideo = 16726U,
			// Token: 0x0400002F RID: 47
			BroadCastVideo = 16982U,
			// Token: 0x04000030 RID: 48
			AppleTV = 4154U,
			// Token: 0x04000031 RID: 49
			WebTV = 5754U,
			// Token: 0x04000032 RID: 50
			CellBE = 17218U,
			// Token: 0x04000033 RID: 51
			Home = 18509U,
			// Token: 0x04000034 RID: 52
			StoreFronted = 21318U,
			// Token: 0x04000035 RID: 53
			HDDGame = 18503U,
			// Token: 0x04000036 RID: 54
			DiscGame = 17479U,
			// Token: 0x04000037 RID: 55
			AutoInstallRoot = 16722U,
			// Token: 0x04000038 RID: 56
			DiscPackage = 17488U,
			// Token: 0x04000039 RID: 57
			ExtraRoot = 22610U,
			// Token: 0x0400003A RID: 58
			VideoRoot = 22098U,
			// Token: 0x0400003B RID: 59
			ThemeRoot = 21586U,
			// Token: 0x0400003C RID: 60
			DiscMovie = 17485U,
			// Token: 0x0400003D RID: 61
			None
		}

		// Token: 0x02000010 RID: 16
		public enum FMT : ushort
		{
			// Token: 0x0400003F RID: 63
			UTF_8 = 1024,
			// Token: 0x04000040 RID: 64
			ASCII = 1026,
			// Token: 0x04000041 RID: 65
			UINT32 = 1028
		}

		// Token: 0x02000011 RID: 17
		public struct Header
		{
			// Token: 0x0600006E RID: 110 RVA: 0x000098E0 File Offset: 0x00007AE0
			private static byte[] aYoDtfyUxu()
			{
				byte[] array = new byte[20];
				Array.Copy(PARAM_SFO.Header.Magic, 0, array, 0, 4);
				Array.Copy(PARAM_SFO.Header.version, 0, array, 4, 4);
				Array.Copy(BitConverter.GetBytes(PARAM_SFO.Header.KeyTableStart), 0, array, 8, 4);
				Array.Copy(BitConverter.GetBytes(PARAM_SFO.Header.DataTableStart), 0, array, 12, 4);
				Array.Copy(BitConverter.GetBytes(PARAM_SFO.Header.IndexTableEntries), 0, array, 16, 4);
				return array;
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00009950 File Offset: 0x00007B50
			public static void Read(BinaryReader input)
			{
				input.BaseStream.Seek(0L, SeekOrigin.Begin);
				input.Read(PARAM_SFO.Header.Magic, 0, 4);
				input.Read(PARAM_SFO.Header.version, 0, 4);
				PARAM_SFO.Header.KeyTableStart = input.ReadUInt32();
				PARAM_SFO.Header.DataTableStart = input.ReadUInt32();
				PARAM_SFO.Header.IndexTableEntries = input.ReadUInt32();
			}

			// Token: 0x06000070 RID: 112 RVA: 0x000099B0 File Offset: 0x00007BB0
			// Note: this type is marked as 'beforefieldinit'.
			static Header()
			{
				byte[] array = new byte[4];
				array[0] = 1;
				array[1] = 1;
				PARAM_SFO.Header.version = array;
				PARAM_SFO.Header.KeyTableStart = 0U;
				PARAM_SFO.Header.DataTableStart = 0U;
				PARAM_SFO.Header.IndexTableEntries = 0U;
			}

			// Token: 0x04000042 RID: 66
			public static byte[] Magic = new byte[]
			{
				0,
				80,
				83,
				70
			};

			// Token: 0x04000043 RID: 67
			public static byte[] version;

			// Token: 0x04000044 RID: 68
			public static uint KeyTableStart;

			// Token: 0x04000045 RID: 69
			public static uint DataTableStart;

			// Token: 0x04000046 RID: 70
			public static uint IndexTableEntries;
		}

		// Token: 0x02000012 RID: 18
		public struct Table
		{
			// Token: 0x06000071 RID: 113 RVA: 0x000099FC File Offset: 0x00007BFC
			private byte[] method_0()
			{
				byte[] array = new byte[this.Name.Length + 1];
				Array.Copy(Encoding.UTF8.GetBytes(this.Name), 0, array, 0, this.Name.Length);
				return array;
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00009A40 File Offset: 0x00007C40
			private byte[] method_1()
			{
				switch (this.Indextable.param_data_fmt)
				{
				case PARAM_SFO.FMT.UTF_8:
				{
					byte[] array = new byte[this.Indextable.param_data_max_len];
					Array.Copy(Encoding.UTF8.GetBytes(this.Value), 0, array, 0, this.Value.Length);
					return array;
				}
				case PARAM_SFO.FMT.ASCII:
				{
					byte[] array = new byte[this.Indextable.param_data_max_len];
					Array.Copy(Encoding.ASCII.GetBytes(this.Value), 0, array, 0, this.Value.Length);
					return array;
				}
				case PARAM_SFO.FMT.UINT32:
					return BitConverter.GetBytes(uint.Parse(this.Value));
				}
				return null;
			}

			// Token: 0x04000047 RID: 71
			public PARAM_SFO.index_table Indextable;

			// Token: 0x04000048 RID: 72
			public string Name;

			// Token: 0x04000049 RID: 73
			public string Value;

			// Token: 0x0400004A RID: 74
			public int index;
		}

		// Token: 0x02000013 RID: 19
		public struct index_table
		{
			// Token: 0x06000073 RID: 115 RVA: 0x00009AFC File Offset: 0x00007CFC
			private byte[] method_0()
			{
				byte[] array = new byte[16];
				Array.Copy(BitConverter.GetBytes(this.param_key_offset), 0, array, 0, 2);
				Array.Copy(BitConverter.GetBytes(((ushort)this.param_data_fmt).smethod_1()), 0, array, 2, 2);
				Array.Copy(BitConverter.GetBytes(this.param_data_len), 0, array, 4, 4);
				Array.Copy(BitConverter.GetBytes(this.param_data_max_len), 0, array, 8, 4);
				Array.Copy(BitConverter.GetBytes(this.param_data_offset), 0, array, 12, 4);
				return array;
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00009B7C File Offset: 0x00007D7C
			public void Read(BinaryReader input)
			{
				this.param_key_offset = input.ReadUInt16();
				this.param_data_fmt = (PARAM_SFO.FMT)input.ReadUInt16().smethod_1();
				this.param_data_len = input.ReadUInt32();
				this.param_data_max_len = input.ReadUInt32();
				this.param_data_offset = input.ReadUInt32();
			}

			// Token: 0x0400004B RID: 75
			public PARAM_SFO.FMT param_data_fmt;

			// Token: 0x0400004C RID: 76
			public uint param_data_len;

			// Token: 0x0400004D RID: 77
			public uint param_data_max_len;

			// Token: 0x0400004E RID: 78
			public uint param_data_offset;

			// Token: 0x0400004F RID: 79
			public ushort param_key_offset;
		}
	}
}
