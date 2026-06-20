using System;
using System.Collections.Generic;
using System.Threading;
using MCPELevelDBI.model;
using MCPELevelDBI.workers;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200011E RID: 286
	public class ConvertToPEFromConsoleParameters
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0000837E File Offset: 0x0000657E
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00008386 File Offset: 0x00006586
		public LevelDBWorker DbWorker
		{
			get
			{
				return this.dbWorker;
			}
			set
			{
				this.dbWorker = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0000838F File Offset: 0x0000658F
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x00008397 File Offset: 0x00006597
		public List<byte[]> Records
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

		// Token: 0x06000C1E RID: 3102 RVA: 0x000083A0 File Offset: 0x000065A0
		public ConvertToPEFromConsoleParameters()
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00055F48 File Offset: 0x00054148
		public ConvertToPEFromConsoleParameters(string dimensionName, string regionName, string pcRegionFolder, string workingFolder, ConvertParameters convertParameters, LevelDBWorker dbWorker, ManualResetEvent doneEvent)
		{
			this.regionName = regionName;
			this.dimensionName = dimensionName;
			this.pcRegionFolder = pcRegionFolder;
			this.workingFolder = workingFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
			this.dbWorker = dbWorker;
			if (dimensionName.ToLower() == "region")
			{
				this.byte_0 = 0;
				return;
			}
			if (dimensionName.ToLower() == "dim-1")
			{
				this.byte_0 = 1;
				return;
			}
			if (dimensionName.ToLower() == "dim1")
			{
				this.byte_0 = 2;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x000083B3 File Offset: 0x000065B3
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x000083BB File Offset: 0x000065BB
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000083C4 File Offset: 0x000065C4
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x000083CC File Offset: 0x000065CC
		public string DimensionName
		{
			get
			{
				return this.dimensionName;
			}
			set
			{
				this.dimensionName = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000083D5 File Offset: 0x000065D5
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x000083DD File Offset: 0x000065DD
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000083E6 File Offset: 0x000065E6
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x000083EE File Offset: 0x000065EE
		public string RegionFolder
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000083F7 File Offset: 0x000065F7
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000083FF File Offset: 0x000065FF
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

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00008408 File Offset: 0x00006608
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x00008410 File Offset: 0x00006610
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00008419 File Offset: 0x00006619
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x00008421 File Offset: 0x00006621
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0000842A File Offset: 0x0000662A
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00008432 File Offset: 0x00006632
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0000843B File Offset: 0x0000663B
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00008443 File Offset: 0x00006643
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0000844C File Offset: 0x0000664C
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00008454 File Offset: 0x00006654
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0000845D File Offset: 0x0000665D
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00008465 File Offset: 0x00006665
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0000846E File Offset: 0x0000666E
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00008476 File Offset: 0x00006676
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0000847F File Offset: 0x0000667F
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00008487 File Offset: 0x00006687
		public byte Byte_0
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00008490 File Offset: 0x00006690
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00008498 File Offset: 0x00006698
		public List<DBRecord> List_0
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

		// Token: 0x040007A7 RID: 1959
		private ManualResetEvent doneEvent;

		// Token: 0x040007A8 RID: 1960
		private string regionName;

		// Token: 0x040007A9 RID: 1961
		private string dimensionName;

		// Token: 0x040007AA RID: 1962
		private string pcRegionFolder;

		// Token: 0x040007AB RID: 1963
		private string workingFolder;

		// Token: 0x040007AC RID: 1964
		private ConvertParameters convertParameters;

		// Token: 0x040007AD RID: 1965
		private int int_0;

		// Token: 0x040007AE RID: 1966
		private bool bool_0;

		// Token: 0x040007AF RID: 1967
		private bool bool_1;

		// Token: 0x040007B0 RID: 1968
		private byte byte_0;

		// Token: 0x040007B1 RID: 1969
		private int int_1;

		// Token: 0x040007B2 RID: 1970
		private int int_2;

		// Token: 0x040007B3 RID: 1971
		private int int_3;

		// Token: 0x040007B4 RID: 1972
		private List<DBRecord> list_0 = new List<DBRecord>();

		// Token: 0x040007B5 RID: 1973
		private List<byte[]> list_1;

		// Token: 0x040007B6 RID: 1974
		private LevelDBWorker dbWorker;
	}
}
