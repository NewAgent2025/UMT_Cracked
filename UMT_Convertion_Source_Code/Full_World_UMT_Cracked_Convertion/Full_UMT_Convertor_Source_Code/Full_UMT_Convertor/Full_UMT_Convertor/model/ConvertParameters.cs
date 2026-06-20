using System;
using System.Collections.Generic;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F0 RID: 240
	public class ConvertParameters
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00007244 File Offset: 0x00005444
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0000724C File Offset: 0x0000544C
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00007255 File Offset: 0x00005455
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0000725D File Offset: 0x0000545D
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00007266 File Offset: 0x00005466
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0000726E File Offset: 0x0000546E
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00007277 File Offset: 0x00005477
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0000727F File Offset: 0x0000547F
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00007288 File Offset: 0x00005488
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00007290 File Offset: 0x00005490
		public List<BiomeChange> BiomeChanges
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00007299 File Offset: 0x00005499
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x000072A1 File Offset: 0x000054A1
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000072AA File Offset: 0x000054AA
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x000072B2 File Offset: 0x000054B2
		public List<BlockChange> BlockChanges
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000072BB File Offset: 0x000054BB
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000072C3 File Offset: 0x000054C3
		public string ProcessWorldFolder
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000072CC File Offset: 0x000054CC
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x000072D4 File Offset: 0x000054D4
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000072DD File Offset: 0x000054DD
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000072E5 File Offset: 0x000054E5
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000072EE File Offset: 0x000054EE
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x000072F6 File Offset: 0x000054F6
		public bool RetainSpawnerSettings
		{
			get
			{
				return this.bool_9;
			}
			set
			{
				this.bool_9 = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000072FF File Offset: 0x000054FF
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00007307 File Offset: 0x00005507
		public bool UseOldEntityNameFormat
		{
			get
			{
				return this.bool_10;
			}
			set
			{
				this.bool_10 = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00007310 File Offset: 0x00005510
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00007318 File Offset: 0x00005518
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00007321 File Offset: 0x00005521
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00007329 File Offset: 0x00005529
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00007332 File Offset: 0x00005532
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x0000733A File Offset: 0x0000553A
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00007343 File Offset: 0x00005543
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0000734B File Offset: 0x0000554B
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

		// Token: 0x06000A21 RID: 2593 RVA: 0x00007354 File Offset: 0x00005554
		internal Enum2 method_0()
		{
			return this.enum2_0;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0000735C File Offset: 0x0000555C
		internal void method_1(Enum2 value)
		{
			this.enum2_0 = value;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00007365 File Offset: 0x00005565
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x0000736D File Offset: 0x0000556D
		public bool ItemIdString
		{
			get
			{
				return this.bool_11;
			}
			set
			{
				this.bool_11 = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00007376 File Offset: 0x00005576
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0000737E File Offset: 0x0000557E
		public List<string> EntityConversionList
		{
			get
			{
				return this.list_2;
			}
			set
			{
				this.list_2 = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00007387 File Offset: 0x00005587
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0000738F File Offset: 0x0000558F
		public List<string> BlockEntityConversionList
		{
			get
			{
				return this.list_3;
			}
			set
			{
				this.list_3 = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00007398 File Offset: 0x00005598
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000073A0 File Offset: 0x000055A0
		public ConvertIntoType ConvertInto
		{
			get
			{
				return this.convertIntoType_0;
			}
			set
			{
				this.convertIntoType_0 = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000073A9 File Offset: 0x000055A9
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x000073B1 File Offset: 0x000055B1
		public bool UseConvertOffsets
		{
			get
			{
				return this.bool_12;
			}
			set
			{
				this.bool_12 = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x000073BA File Offset: 0x000055BA
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x000073C2 File Offset: 0x000055C2
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000073CB File Offset: 0x000055CB
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000073D3 File Offset: 0x000055D3
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000073DC File Offset: 0x000055DC
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000073E4 File Offset: 0x000055E4
		public ConversionFormat ConvertToFormat
		{
			get
			{
				return this.conversionFormat_0;
			}
			set
			{
				this.conversionFormat_0 = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000073ED File Offset: 0x000055ED
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000073F5 File Offset: 0x000055F5
		public bool UpdateLevelData
		{
			get
			{
				return this.bool_13;
			}
			set
			{
				this.bool_13 = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000073FE File Offset: 0x000055FE
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00007406 File Offset: 0x00005606
		public TagNodeCompound ModifiedLevelNode
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0000740F File Offset: 0x0000560F
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00007417 File Offset: 0x00005617
		public bool SetPlayPosition
		{
			get
			{
				return this.bool_14;
			}
			set
			{
				this.bool_14 = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00007420 File Offset: 0x00005620
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00007428 File Offset: 0x00005628
		public PlayerPosition PlayerPosition
		{
			get
			{
				return this.playerPosition_0;
			}
			set
			{
				this.playerPosition_0 = value;
			}
		}

		// Token: 0x040006CC RID: 1740
		private bool bool_0;

		// Token: 0x040006CD RID: 1741
		private bool bool_1;

		// Token: 0x040006CE RID: 1742
		private bool bool_2;

		// Token: 0x040006CF RID: 1743
		private bool bool_3;

		// Token: 0x040006D0 RID: 1744
		private List<BiomeChange> list_0;

		// Token: 0x040006D1 RID: 1745
		private bool bool_4;

		// Token: 0x040006D2 RID: 1746
		private List<BlockChange> list_1;

		// Token: 0x040006D3 RID: 1747
		private string string_0 = "";

		// Token: 0x040006D4 RID: 1748
		private bool bool_5 = true;

		// Token: 0x040006D5 RID: 1749
		private bool bool_6 = true;

		// Token: 0x040006D6 RID: 1750
		private ConsoleChunkFormat consoleChunkFormat_0;

		// Token: 0x040006D7 RID: 1751
		private TU17VersionType tu17VersionType_0 = TU17VersionType.VERSION_9;

		// Token: 0x040006D8 RID: 1752
		private bool bool_7 = true;

		// Token: 0x040006D9 RID: 1753
		private bool bool_8;

		// Token: 0x040006DA RID: 1754
		private Enum2 enum2_0;

		// Token: 0x040006DB RID: 1755
		private bool bool_9;

		// Token: 0x040006DC RID: 1756
		private bool bool_10;

		// Token: 0x040006DD RID: 1757
		private bool bool_11;

		// Token: 0x040006DE RID: 1758
		private List<string> list_2 = new List<string>();

		// Token: 0x040006DF RID: 1759
		private List<string> list_3 = new List<string>();

		// Token: 0x040006E0 RID: 1760
		private ConvertIntoType convertIntoType_0 = ConvertIntoType.EmptyDimension;

		// Token: 0x040006E1 RID: 1761
		private bool bool_12;

		// Token: 0x040006E2 RID: 1762
		private int int_0;

		// Token: 0x040006E3 RID: 1763
		private int int_1;

		// Token: 0x040006E4 RID: 1764
		private ConversionFormat conversionFormat_0;

		// Token: 0x040006E5 RID: 1765
		private bool bool_13 = true;

		// Token: 0x040006E6 RID: 1766
		private TagNodeCompound tagNodeCompound_0;

		// Token: 0x040006E7 RID: 1767
		private bool bool_14 = true;

		// Token: 0x040006E8 RID: 1768
		private PlayerPosition playerPosition_0 = new PlayerPosition();
	}
}
