using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000E0 RID: 224
	public class ChunkData
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00006FAF File Offset: 0x000051AF
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00006FB7 File Offset: 0x000051B7
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00006FC0 File Offset: 0x000051C0
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00006FC8 File Offset: 0x000051C8
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00006FD1 File Offset: 0x000051D1
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00006FD9 File Offset: 0x000051D9
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00006FE2 File Offset: 0x000051E2
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00006FEA File Offset: 0x000051EA
		public int ZWorldCoords
		{
			get
			{
				return this.tnhHeRjQay6;
			}
			set
			{
				this.tnhHeRjQay6 = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00006FF3 File Offset: 0x000051F3
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00006FFB File Offset: 0x000051FB
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00007004 File Offset: 0x00005204
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0000700C File Offset: 0x0000520C
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00007015 File Offset: 0x00005215
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0000701D File Offset: 0x0000521D
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00007026 File Offset: 0x00005226
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x0000702E File Offset: 0x0000522E
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

		// Token: 0x060009CF RID: 2511 RVA: 0x00007037 File Offset: 0x00005237
		internal ChunkIndexEntry method_0()
		{
			return this.chunkIndexEntry_0;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0000703F File Offset: 0x0000523F
		internal void method_1(ChunkIndexEntry value)
		{
			this.chunkIndexEntry_0 = value;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00007048 File Offset: 0x00005248
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00007050 File Offset: 0x00005250
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

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00007059 File Offset: 0x00005259
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00007061 File Offset: 0x00005261
		public int OriginalFileSize
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0000706A File Offset: 0x0000526A
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00007072 File Offset: 0x00005272
		public int OriginalDecompressSize
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0000707B File Offset: 0x0000527B
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00007083 File Offset: 0x00005283
		public int NewFileSize
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0000708C File Offset: 0x0000528C
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00007094 File Offset: 0x00005294
		public int Dimension
		{
			get
			{
				return this.int_6;
			}
			set
			{
				this.int_6 = value;
			}
		}

		// Token: 0x0400066A RID: 1642
		private int int_0;

		// Token: 0x0400066B RID: 1643
		private int int_1;

		// Token: 0x0400066C RID: 1644
		private int int_2;

		// Token: 0x0400066D RID: 1645
		private int tnhHeRjQay6;

		// Token: 0x0400066E RID: 1646
		private Guid guid_0 = Guid.NewGuid();

		// Token: 0x0400066F RID: 1647
		private string string_0 = string.Empty;

		// Token: 0x04000670 RID: 1648
		private string string_1 = string.Empty;

		// Token: 0x04000671 RID: 1649
		private string string_2 = string.Empty;

		// Token: 0x04000672 RID: 1650
		private ChunkIndexEntry chunkIndexEntry_0;

		// Token: 0x04000673 RID: 1651
		private IndexEntry indexEntry_0;

		// Token: 0x04000674 RID: 1652
		private int int_3;

		// Token: 0x04000675 RID: 1653
		private int int_4;

		// Token: 0x04000676 RID: 1654
		private int int_5;

		// Token: 0x04000677 RID: 1655
		private int int_6;
	}
}
