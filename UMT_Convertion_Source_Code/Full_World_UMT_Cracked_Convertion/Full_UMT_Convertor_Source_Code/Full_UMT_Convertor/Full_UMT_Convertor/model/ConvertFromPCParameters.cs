using System;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000EB RID: 235
	public class ConvertFromPCParameters
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00002591 File Offset: 0x00000791
		public ConvertFromPCParameters()
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00007143 File Offset: 0x00005343
		public ConvertFromPCParameters(string regionName, string regionfolder, string pcRegionFolder, string workingFolder, ConvertParameters convertParameters, ManualResetEvent doneEvent)
		{
			this.regionName = regionName;
			this.regionfolder = regionfolder;
			this.pcRegionFolder = pcRegionFolder;
			this.workingFolder = workingFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00007178 File Offset: 0x00005378
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00007180 File Offset: 0x00005380
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00007189 File Offset: 0x00005389
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00007191 File Offset: 0x00005391
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0000719A File Offset: 0x0000539A
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x000071A2 File Offset: 0x000053A2
		public string RegionFolder
		{
			get
			{
				return this.regionfolder;
			}
			set
			{
				this.regionfolder = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x000071AB File Offset: 0x000053AB
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x000071B3 File Offset: 0x000053B3
		public string PCRegionFolder
		{
			get
			{
				return this.pcRegionFolder;
			}
			set
			{
				this.pcRegionFolder = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000071BC File Offset: 0x000053BC
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x000071C4 File Offset: 0x000053C4
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000071CD File Offset: 0x000053CD
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x000071D5 File Offset: 0x000053D5
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000071DE File Offset: 0x000053DE
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x000071E6 File Offset: 0x000053E6
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000071EF File Offset: 0x000053EF
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x000071F7 File Offset: 0x000053F7
		public bool ProcessingCompleted
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00007200 File Offset: 0x00005400
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00007208 File Offset: 0x00005408
		public bool Done
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00007211 File Offset: 0x00005411
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00007219 File Offset: 0x00005419
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00007222 File Offset: 0x00005422
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x0000722A File Offset: 0x0000542A
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00007233 File Offset: 0x00005433
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0000723B File Offset: 0x0000543B
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

		// Token: 0x040006B0 RID: 1712
		private ManualResetEvent doneEvent;

		// Token: 0x040006B1 RID: 1713
		private string regionName;

		// Token: 0x040006B2 RID: 1714
		private string regionfolder;

		// Token: 0x040006B3 RID: 1715
		private string pcRegionFolder;

		// Token: 0x040006B4 RID: 1716
		private string workingFolder;

		// Token: 0x040006B5 RID: 1717
		private ConvertParameters convertParameters;

		// Token: 0x040006B6 RID: 1718
		private int int_0;

		// Token: 0x040006B7 RID: 1719
		private bool bool_0;

		// Token: 0x040006B8 RID: 1720
		private bool bool_1;

		// Token: 0x040006B9 RID: 1721
		private int int_1;

		// Token: 0x040006BA RID: 1722
		private int int_2;

		// Token: 0x040006BB RID: 1723
		private int int_3;
	}
}
