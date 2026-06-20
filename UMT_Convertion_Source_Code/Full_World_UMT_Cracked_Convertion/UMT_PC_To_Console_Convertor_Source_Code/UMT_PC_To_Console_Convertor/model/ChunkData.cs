using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200009C RID: 156
	public class ChunkData
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00005D84 File Offset: 0x00003F84
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00005D8C File Offset: 0x00003F8C
		public int XRegionOffset
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00005D95 File Offset: 0x00003F95
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00005D9D File Offset: 0x00003F9D
		public int ZRegionOffset
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00005DA6 File Offset: 0x00003FA6
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00005DAE File Offset: 0x00003FAE
		public int XWorldCoords
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00005DB7 File Offset: 0x00003FB7
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00005DBF File Offset: 0x00003FBF
		public int ZWorldCoords
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00005DC8 File Offset: 0x00003FC8
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public string Path
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00005DD9 File Offset: 0x00003FD9
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00005DE1 File Offset: 0x00003FE1
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00005DEA File Offset: 0x00003FEA
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00005DF2 File Offset: 0x00003FF2
		public string Text
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00005DFB File Offset: 0x00003FFB
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00005E03 File Offset: 0x00004003
		public string Parent
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

		// Token: 0x060006EF RID: 1775 RVA: 0x00005E0C File Offset: 0x0000400C
		internal ChunkIndexEntry method_0()
		{
			return this.chunkIndexEntry_0;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00005E14 File Offset: 0x00004014
		internal void method_1(ChunkIndexEntry value)
		{
			this.chunkIndexEntry_0 = value;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00005E1D File Offset: 0x0000401D
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00005E25 File Offset: 0x00004025
		public IndexEntry RegionIndex
		{
			get
			{
				return this.indexEntry_0;
			}
			set
			{
				this.indexEntry_0 = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00005E2E File Offset: 0x0000402E
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00005E36 File Offset: 0x00004036
		public int OriginalFileSize
		{
			get
			{
				return this.int_4;
			}
			set
			{
				this.int_4 = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00005E3F File Offset: 0x0000403F
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00005E47 File Offset: 0x00004047
		public int OriginalDecompressSize
		{
			get
			{
				return this.int_5;
			}
			set
			{
				this.int_5 = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00005E50 File Offset: 0x00004050
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00005E58 File Offset: 0x00004058
		public int NewFileSize
		{
			get
			{
				return this.ayOjYneSw3;
			}
			set
			{
				this.ayOjYneSw3 = value;
			}
		}

		// Token: 0x04000435 RID: 1077
		private int int_0;

		// Token: 0x04000436 RID: 1078
		private int int_1;

		// Token: 0x04000437 RID: 1079
		private int int_2;

		// Token: 0x04000438 RID: 1080
		private int int_3;

		// Token: 0x04000439 RID: 1081
		private Guid guid_0 = Guid.NewGuid();

		// Token: 0x0400043A RID: 1082
		private string string_0 = string.Empty;

		// Token: 0x0400043B RID: 1083
		private string string_1 = string.Empty;

		// Token: 0x0400043C RID: 1084
		private string string_2 = string.Empty;

		// Token: 0x0400043D RID: 1085
		private ChunkIndexEntry chunkIndexEntry_0;

		// Token: 0x0400043E RID: 1086
		private IndexEntry indexEntry_0;

		// Token: 0x0400043F RID: 1087
		private int int_4;

		// Token: 0x04000440 RID: 1088
		private int int_5;

		// Token: 0x04000441 RID: 1089
		private int ayOjYneSw3;
	}
}
