using System;
using System.Collections.Generic;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000AC RID: 172
	public class ConvertParameters
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0000603C File Offset: 0x0000423C
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00006044 File Offset: 0x00004244
		public bool ConvertOverworld
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x0000604D File Offset: 0x0000424D
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00006055 File Offset: 0x00004255
		public bool ConvertNether
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0000605E File Offset: 0x0000425E
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00006066 File Offset: 0x00004266
		public bool ConvertTheEnd
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0000606F File Offset: 0x0000426F
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00006077 File Offset: 0x00004277
		public bool ReplaceBiomes
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00006080 File Offset: 0x00004280
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00006088 File Offset: 0x00004288
		public List<BiomeChange> BiomeChanges
		{
			get
			{
				return this.gpejMwOhho;
			}
			set
			{
				this.gpejMwOhho = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00006091 File Offset: 0x00004291
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00006099 File Offset: 0x00004299
		public bool ReplaceBlocks
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				this.bool_4 = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000060A2 File Offset: 0x000042A2
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x000060AA File Offset: 0x000042AA
		public List<BlockChange> BlockChanges
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x000060B3 File Offset: 0x000042B3
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x000060BB File Offset: 0x000042BB
		public string PCWorldFolder
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000060C4 File Offset: 0x000042C4
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000060CC File Offset: 0x000042CC
		public bool ConvertEntities
		{
			get
			{
				return this.bool_6;
			}
			set
			{
				this.bool_6 = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000060D5 File Offset: 0x000042D5
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x000060DD File Offset: 0x000042DD
		public bool ConvertTileEntities
		{
			get
			{
				return this.bool_5;
			}
			set
			{
				this.bool_5 = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000060E6 File Offset: 0x000042E6
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x000060EE File Offset: 0x000042EE
		public ConsoleChunkFormat ChunkFormat
		{
			get
			{
				return this.consoleChunkFormat_0;
			}
			set
			{
				this.consoleChunkFormat_0 = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x000060F7 File Offset: 0x000042F7
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x000060FF File Offset: 0x000042FF
		public TU17VersionType TU17VersionType_0
		{
			get
			{
				return this.tu17VersionType_0;
			}
			set
			{
				this.tu17VersionType_0 = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00006108 File Offset: 0x00004308
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00006110 File Offset: 0x00004310
		public bool ConvertNewGen
		{
			get
			{
				return this.bool_8;
			}
			set
			{
				this.bool_8 = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00006119 File Offset: 0x00004319
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00006121 File Offset: 0x00004321
		public bool DataValidation
		{
			get
			{
				return this.bool_7;
			}
			set
			{
				this.bool_7 = value;
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000612A File Offset: 0x0000432A
		internal Enum2 method_0()
		{
			return this.enum2_0;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00006132 File Offset: 0x00004332
		internal void method_1(Enum2 value)
		{
			this.enum2_0 = value;
		}

		// Token: 0x040004A9 RID: 1193
		private bool bool_0;

		// Token: 0x040004AA RID: 1194
		private bool bool_1;

		// Token: 0x040004AB RID: 1195
		private bool bool_2;

		// Token: 0x040004AC RID: 1196
		private bool bool_3;

		// Token: 0x040004AD RID: 1197
		private List<BiomeChange> gpejMwOhho;

		// Token: 0x040004AE RID: 1198
		private bool bool_4;

		// Token: 0x040004AF RID: 1199
		private List<BlockChange> list_0;

		// Token: 0x040004B0 RID: 1200
		private string string_0 = "";

		// Token: 0x040004B1 RID: 1201
		private bool bool_5 = true;

		// Token: 0x040004B2 RID: 1202
		private bool bool_6 = true;

		// Token: 0x040004B3 RID: 1203
		private bool ImEjSbGgLp = true;

		// Token: 0x040004B4 RID: 1204
		private ConsoleChunkFormat consoleChunkFormat_0;

		// Token: 0x040004B5 RID: 1205
		private TU17VersionType tu17VersionType_0 = TU17VersionType.VERSION_9;

		// Token: 0x040004B6 RID: 1206
		private bool bool_7 = true;

		// Token: 0x040004B7 RID: 1207
		private bool bool_8 = true;

		// Token: 0x040004B8 RID: 1208
		private Enum2 enum2_0;
	}
}
