using System;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D9 RID: 217
	public class TU17ChunkData
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00006D03 File Offset: 0x00004F03
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00006D0B File Offset: 0x00004F0B
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00006D14 File Offset: 0x00004F14
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00006D1C File Offset: 0x00004F1C
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00006D25 File Offset: 0x00004F25
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00006D2D File Offset: 0x00004F2D
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00006D36 File Offset: 0x00004F36
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00006D3E File Offset: 0x00004F3E
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00006D47 File Offset: 0x00004F47
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00006D4F File Offset: 0x00004F4F
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00006D58 File Offset: 0x00004F58
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00006D60 File Offset: 0x00004F60
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00006D69 File Offset: 0x00004F69
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00006D71 File Offset: 0x00004F71
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00006D7A File Offset: 0x00004F7A
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00006D82 File Offset: 0x00004F82
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00006D8B File Offset: 0x00004F8B
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00006D93 File Offset: 0x00004F93
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00006D9C File Offset: 0x00004F9C
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00006DA4 File Offset: 0x00004FA4
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00006DAD File Offset: 0x00004FAD
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00006DB5 File Offset: 0x00004FB5
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00006DBE File Offset: 0x00004FBE
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00006DC6 File Offset: 0x00004FC6
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

		// Token: 0x04000642 RID: 1602
		private byte[] byte_0;

		// Token: 0x04000643 RID: 1603
		private byte[] byte_1;

		// Token: 0x04000644 RID: 1604
		private byte[] byte_2;

		// Token: 0x04000645 RID: 1605
		private byte[] byte_3;

		// Token: 0x04000646 RID: 1606
		private byte[] byte_4;

		// Token: 0x04000647 RID: 1607
		private byte[] byte_5;

		// Token: 0x04000648 RID: 1608
		private int int_0 = 2046;

		// Token: 0x04000649 RID: 1609
		private int int_1;

		// Token: 0x0400064A RID: 1610
		private int int_2;

		// Token: 0x0400064B RID: 1611
		private TagNodeCompound tagNodeCompound_0;

		// Token: 0x0400064C RID: 1612
		private TU17VersionType tu17VersionType_0 = TU17VersionType.VERSION_9;

		// Token: 0x0400064D RID: 1613
		private int int_3;
	}
}
