using System;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000A4 RID: 164
	public class AquaticChunkData
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00005486 File Offset: 0x00003686
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x0000548E File Offset: 0x0000368E
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00005497 File Offset: 0x00003697
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0000549F File Offset: 0x0000369F
		public byte[] Submerged
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000054A8 File Offset: 0x000036A8
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000054B0 File Offset: 0x000036B0
		public byte[] BlockLight
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000054B9 File Offset: 0x000036B9
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000054C1 File Offset: 0x000036C1
		public byte[] SkyLight
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000054CA File Offset: 0x000036CA
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000054D2 File Offset: 0x000036D2
		public byte[] HeightMap
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x000054DB File Offset: 0x000036DB
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000054E3 File Offset: 0x000036E3
		public byte[] Biomes
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000054EC File Offset: 0x000036EC
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000054F4 File Offset: 0x000036F4
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x000054FD File Offset: 0x000036FD
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00005505 File Offset: 0x00003705
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0000550E File Offset: 0x0000370E
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00005516 File Offset: 0x00003716
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0000551F File Offset: 0x0000371F
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00005527 File Offset: 0x00003727
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00005530 File Offset: 0x00003730
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00005538 File Offset: 0x00003738
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

		// Token: 0x040004D9 RID: 1241
		private byte[] byte_0;

		// Token: 0x040004DA RID: 1242
		private byte[] byte_1;

		// Token: 0x040004DB RID: 1243
		private byte[] byte_2;

		// Token: 0x040004DC RID: 1244
		private byte[] byte_3;

		// Token: 0x040004DD RID: 1245
		private byte[] byte_4;

		// Token: 0x040004DE RID: 1246
		private int int_0 = 2046;

		// Token: 0x040004DF RID: 1247
		private int int_1;

		// Token: 0x040004E0 RID: 1248
		private int int_2;

		// Token: 0x040004E1 RID: 1249
		private TagNodeCompound tagNodeCompound_0;

		// Token: 0x040004E2 RID: 1250
		private int int_3;

		// Token: 0x040004E3 RID: 1251
		private byte[] byte_5;
	}
}
