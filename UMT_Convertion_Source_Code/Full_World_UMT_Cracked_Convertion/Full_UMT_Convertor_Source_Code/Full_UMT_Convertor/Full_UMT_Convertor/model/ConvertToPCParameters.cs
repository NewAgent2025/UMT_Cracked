using System;
using System.Collections.Generic;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F2 RID: 242
	public class ConvertToPCParameters
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x00002591 File Offset: 0x00000791
		public ConvertToPCParameters()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00007497 File Offset: 0x00005697
		public ConvertToPCParameters(IndexEntry region, string regionName, string regionFolder, string workingFolder, ConvertParameters convertParameters, ManualResetEvent doneEvent)
		{
			this.region = region;
			this.regionName = regionName;
			this.regionFolder = regionFolder;
			this.workingFolder = workingFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000074CC File Offset: 0x000056CC
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x000074D4 File Offset: 0x000056D4
		public ManualResetEvent DoneEvent
		{
			get
			{
				return this.doneEvent;
			}
			set
			{
				this.doneEvent = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000074DD File Offset: 0x000056DD
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x000074E5 File Offset: 0x000056E5
		public IndexEntry Region
		{
			get
			{
				return this.region;
			}
			set
			{
				this.region = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000074EE File Offset: 0x000056EE
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x000074F6 File Offset: 0x000056F6
		public string RegionName
		{
			get
			{
				return this.regionName;
			}
			set
			{
				this.regionName = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000074FF File Offset: 0x000056FF
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00007507 File Offset: 0x00005707
		public string RegionFolder
		{
			get
			{
				return this.regionFolder;
			}
			set
			{
				this.regionFolder = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00007510 File Offset: 0x00005710
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00007518 File Offset: 0x00005718
		public string WorkingFolder
		{
			get
			{
				return this.workingFolder;
			}
			set
			{
				this.workingFolder = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00007521 File Offset: 0x00005721
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00007529 File Offset: 0x00005729
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters;
			}
			set
			{
				this.convertParameters = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00007532 File Offset: 0x00005732
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0000753A File Offset: 0x0000573A
		public Dictionary<int, MCCoordinate> Chests
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00007543 File Offset: 0x00005743
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0000754B File Offset: 0x0000574B
		public int Count
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00007554 File Offset: 0x00005754
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0000755C File Offset: 0x0000575C
		public bool Done
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00007565 File Offset: 0x00005765
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0000756D File Offset: 0x0000576D
		public int ProcessedChunkCount
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00007576 File Offset: 0x00005776
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0000757E File Offset: 0x0000577E
		public int MissingChunkCount
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00007587 File Offset: 0x00005787
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x0000758F File Offset: 0x0000578F
		public int InvalidChunkCount
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

		// Token: 0x040006EF RID: 1775
		private Dictionary<int, MCCoordinate> dictionary_0;

		// Token: 0x040006F0 RID: 1776
		private ManualResetEvent doneEvent;

		// Token: 0x040006F1 RID: 1777
		private IndexEntry region;

		// Token: 0x040006F2 RID: 1778
		private string regionName;

		// Token: 0x040006F3 RID: 1779
		private string regionFolder;

		// Token: 0x040006F4 RID: 1780
		private string workingFolder;

		// Token: 0x040006F5 RID: 1781
		private ConvertParameters convertParameters;

		// Token: 0x040006F6 RID: 1782
		private int int_0;

		// Token: 0x040006F7 RID: 1783
		private bool bool_0;

		// Token: 0x040006F8 RID: 1784
		private int int_1;

		// Token: 0x040006F9 RID: 1785
		private int int_2;

		// Token: 0x040006FA RID: 1786
		private int int_3;
	}
}
