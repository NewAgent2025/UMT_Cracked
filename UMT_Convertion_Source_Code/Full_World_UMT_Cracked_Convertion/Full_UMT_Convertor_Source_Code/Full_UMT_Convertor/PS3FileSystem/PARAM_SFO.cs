using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace PS3FileSystem
{
	// Token: 0x0200000F RID: 15
	public class PARAM_SFO
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000027E7 File Offset: 0x000009E7
		public PARAM_SFO(string filepath)
		{
			this.method_2(new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000027FE File Offset: 0x000009FE
		public PARAM_SFO(byte[] inputdata)
		{
			this.method_2(new MemoryStream(inputdata));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002812 File Offset: 0x00000A12
		public PARAM_SFO(Stream input)
		{
			this.method_2(input);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002821 File Offset: 0x00000A21
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002829 File Offset: 0x00000A29
		public PARAM_SFO.Table[] Tables { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000BA98 File Offset: 0x00009C98
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000BB00 File Offset: 0x00009D00
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000BB74 File Offset: 0x00009D74
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000BBD8 File Offset: 0x00009DD8
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000BC38 File Offset: 0x00009E38
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000BC9C File Offset: 0x00009E9C
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000BCD8 File Offset: 0x00009ED8
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000BD3C File Offset: 0x00009F3C
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

		// Token: 0x06000086 RID: 134 RVA: 0x0000BDA0 File Offset: 0x00009FA0
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

		// Token: 0x06000087 RID: 135 RVA: 0x0000BE50 File Offset: 0x0000A050
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

		// Token: 0x06000088 RID: 136 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
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

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		private PARAM_SFO.Table[] table_0;

		// Token: 0x02000010 RID: 16
		public enum DataTypes : uint
		{
			// Token: 0x04000037 RID: 55
			GameData = 18244U,
			// Token: 0x04000038 RID: 56
			SaveData = 21316U,
			// Token: 0x04000039 RID: 57
			AppPhoto = 16720U,
			// Token: 0x0400003A RID: 58
			AppMusic = 16717U,
			// Token: 0x0400003B RID: 59
			AppVideo = 16726U,
			// Token: 0x0400003C RID: 60
			BroadCastVideo = 16982U,
			// Token: 0x0400003D RID: 61
			AppleTV = 4154U,
			// Token: 0x0400003E RID: 62
			WebTV = 5754U,
			// Token: 0x0400003F RID: 63
			CellBE = 17218U,
			// Token: 0x04000040 RID: 64
			Home = 18509U,
			// Token: 0x04000041 RID: 65
			StoreFronted = 21318U,
			// Token: 0x04000042 RID: 66
			HDDGame = 18503U,
			// Token: 0x04000043 RID: 67
			DiscGame = 17479U,
			// Token: 0x04000044 RID: 68
			AutoInstallRoot = 16722U,
			// Token: 0x04000045 RID: 69
			DiscPackage = 17488U,
			// Token: 0x04000046 RID: 70
			ExtraRoot = 22610U,
			// Token: 0x04000047 RID: 71
			VideoRoot = 22098U,
			// Token: 0x04000048 RID: 72
			ThemeRoot = 21586U,
			// Token: 0x04000049 RID: 73
			DiscMovie = 17485U,
			// Token: 0x0400004A RID: 74
			None
		}

		// Token: 0x02000011 RID: 17
		public enum FMT : ushort
		{
			// Token: 0x0400004C RID: 76
			UTF_8 = 1024,
			// Token: 0x0400004D RID: 77
			ASCII = 1026,
			// Token: 0x0400004E RID: 78
			UINT32 = 1028
		}

		// Token: 0x02000012 RID: 18
		public struct Header
		{
			// Token: 0x06000089 RID: 137 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
			private static byte[] uxnHwdequs()
			{
				byte[] array = new byte[20];
				Array.Copy(PARAM_SFO.Header.Magic, 0, array, 0, 4);
				Array.Copy(PARAM_SFO.Header.version, 0, array, 4, 4);
				Array.Copy(BitConverter.GetBytes(PARAM_SFO.Header.KeyTableStart), 0, array, 8, 4);
				Array.Copy(BitConverter.GetBytes(PARAM_SFO.Header.DataTableStart), 0, array, 12, 4);
				Array.Copy(BitConverter.GetBytes(PARAM_SFO.Header.IndexTableEntries), 0, array, 16, 4);
				return array;
			}

			// Token: 0x0600008A RID: 138 RVA: 0x0000C054 File Offset: 0x0000A254
			public static void Read(BinaryReader input)
			{
				input.BaseStream.Seek(0L, SeekOrigin.Begin);
				input.Read(PARAM_SFO.Header.Magic, 0, 4);
				input.Read(PARAM_SFO.Header.version, 0, 4);
				PARAM_SFO.Header.KeyTableStart = input.ReadUInt32();
				PARAM_SFO.Header.DataTableStart = input.ReadUInt32();
				PARAM_SFO.Header.IndexTableEntries = input.ReadUInt32();
			}

			// Token: 0x0600008B RID: 139 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
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

			// Token: 0x0400004F RID: 79
			public static byte[] Magic = new byte[]
			{
				0,
				80,
				83,
				70
			};

			// Token: 0x04000050 RID: 80
			public static byte[] version;

			// Token: 0x04000051 RID: 81
			public static uint KeyTableStart;

			// Token: 0x04000052 RID: 82
			public static uint DataTableStart;

			// Token: 0x04000053 RID: 83
			public static uint IndexTableEntries;
		}

		// Token: 0x02000013 RID: 19
		public struct Table
		{
			// Token: 0x0600008C RID: 140 RVA: 0x0000C100 File Offset: 0x0000A300
			private byte[] method_0()
			{
				byte[] array = new byte[this.Name.Length + 1];
				Array.Copy(Encoding.UTF8.GetBytes(this.Name), 0, array, 0, this.Name.Length);
				return array;
			}

			// Token: 0x0600008D RID: 141 RVA: 0x0000C144 File Offset: 0x0000A344
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

			// Token: 0x04000054 RID: 84
			public PARAM_SFO.index_table Indextable;

			// Token: 0x04000055 RID: 85
			public string Name;

			// Token: 0x04000056 RID: 86
			public string Value;

			// Token: 0x04000057 RID: 87
			public int index;
		}

		// Token: 0x02000014 RID: 20
		public struct index_table
		{
			// Token: 0x0600008E RID: 142 RVA: 0x0000C200 File Offset: 0x0000A400
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

			// Token: 0x0600008F RID: 143 RVA: 0x0000C280 File Offset: 0x0000A480
			public void Read(BinaryReader input)
			{
				this.param_key_offset = input.ReadUInt16();
				this.param_data_fmt = (PARAM_SFO.FMT)input.ReadUInt16().smethod_1();
				this.param_data_len = input.ReadUInt32();
				this.param_data_max_len = input.ReadUInt32();
				this.param_data_offset = input.ReadUInt32();
			}

			// Token: 0x04000058 RID: 88
			public PARAM_SFO.FMT param_data_fmt;

			// Token: 0x04000059 RID: 89
			public uint param_data_len;

			// Token: 0x0400005A RID: 90
			public uint param_data_max_len;

			// Token: 0x0400005B RID: 91
			public uint param_data_offset;

			// Token: 0x0400005C RID: 92
			public ushort param_key_offset;
		}
	}
}
