using System;
using Substrate.Nbt;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000095 RID: 149
	public class TU17ChunkData
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00005AF4 File Offset: 0x00003CF4
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00005AFC File Offset: 0x00003CFC
		public byte[] Blocks
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00005B05 File Offset: 0x00003D05
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00005B0D File Offset: 0x00003D0D
		public byte[] BlockData
		{
			get
			{
				return this.byte_1;
			}
			set
			{
				this.byte_1 = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00005B16 File Offset: 0x00003D16
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00005B1E File Offset: 0x00003D1E
		public byte[] BlockLight
		{
			get
			{
				return this.byte_2;
			}
			set
			{
				this.byte_2 = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00005B27 File Offset: 0x00003D27
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00005B2F File Offset: 0x00003D2F
		public byte[] SkyLight
		{
			get
			{
				return this.byte_3;
			}
			set
			{
				this.byte_3 = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00005B38 File Offset: 0x00003D38
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00005B40 File Offset: 0x00003D40
		public byte[] HeightMap
		{
			get
			{
				return this.byte_4;
			}
			set
			{
				this.byte_4 = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00005B49 File Offset: 0x00003D49
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00005B51 File Offset: 0x00003D51
		public byte[] Biomes
		{
			get
			{
				return this.byte_5;
			}
			set
			{
				this.byte_5 = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00005B5A File Offset: 0x00003D5A
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00005B62 File Offset: 0x00003D62
		public int TerrainPopulatedFlags
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00005B6B File Offset: 0x00003D6B
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00005B73 File Offset: 0x00003D73
		public int X
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00005B84 File Offset: 0x00003D84
		public int Z
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00005B8D File Offset: 0x00003D8D
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00005B95 File Offset: 0x00003D95
		public TagNodeCompound NBTData
		{
			get
			{
				return this.tagNodeCompound_0;
			}
			set
			{
				this.tagNodeCompound_0 = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00005B9E File Offset: 0x00003D9E
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00005BA6 File Offset: 0x00003DA6
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00005BAF File Offset: 0x00003DAF
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00005BB7 File Offset: 0x00003DB7
		public int DataGroupCount
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

		// Token: 0x04000415 RID: 1045
		private byte[] byte_0;

		// Token: 0x04000416 RID: 1046
		private byte[] byte_1;

		// Token: 0x04000417 RID: 1047
		private byte[] byte_2;

		// Token: 0x04000418 RID: 1048
		private byte[] byte_3;

		// Token: 0x04000419 RID: 1049
		private byte[] byte_4;

		// Token: 0x0400041A RID: 1050
		private byte[] byte_5;

		// Token: 0x0400041B RID: 1051
		private int int_0 = 2046;

		// Token: 0x0400041C RID: 1052
		private int int_1;

		// Token: 0x0400041D RID: 1053
		private int int_2;

		// Token: 0x0400041E RID: 1054
		private TagNodeCompound tagNodeCompound_0;

		// Token: 0x0400041F RID: 1055
		private TU17VersionType tu17VersionType_0 = TU17VersionType.VERSION_9;

		// Token: 0x04000420 RID: 1056
		private int int_3;
	}
}
