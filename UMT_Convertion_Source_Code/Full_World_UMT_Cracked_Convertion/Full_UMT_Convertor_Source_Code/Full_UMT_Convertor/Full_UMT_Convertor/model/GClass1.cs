using System;
using System.Threading;
using Full_UMT_Convertor.workers;
using MCPELevelDBI.workers;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200011F RID: 287
	public class GClass1
	{
		// Token: 0x06000C3C RID: 3132 RVA: 0x00002591 File Offset: 0x00000791
		public GClass1()
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000084A1 File Offset: 0x000066A1
		public GClass1(string dimension, PERegion peRegion, LevelDBWorker dbWorker, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.peRegion = peRegion;
			this.dbWorker = dbWorker;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000084C6 File Offset: 0x000066C6
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000084CE File Offset: 0x000066CE
		public string Dimension
		{
			get
			{
				return this.dimension;
			}
			set
			{
				this.dimension = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000084D7 File Offset: 0x000066D7
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000084DF File Offset: 0x000066DF
		public PERegion PERegion
		{
			get
			{
				return this.peRegion;
			}
			set
			{
				this.peRegion = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000084E8 File Offset: 0x000066E8
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x000084F0 File Offset: 0x000066F0
		public string OutFolderPath
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000084F9 File Offset: 0x000066F9
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00008501 File Offset: 0x00006701
		public LevelDBWorker DBWorker
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0000850A File Offset: 0x0000670A
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00008512 File Offset: 0x00006712
		public bool Completed
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0000851B File Offset: 0x0000671B
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00008523 File Offset: 0x00006723
		public int ChunkProcessedCount
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0000852C File Offset: 0x0000672C
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00008534 File Offset: 0x00006734
		public DirectBitmap BlockImage
		{
			get
			{
				return this.directBitmap_0;
			}
			set
			{
				this.directBitmap_0 = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0000853D File Offset: 0x0000673D
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00008545 File Offset: 0x00006745
		public DirectBitmap BiomeImage
		{
			get
			{
				return this.directBitmap_1;
			}
			set
			{
				this.directBitmap_1 = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0000854E File Offset: 0x0000674E
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x00008556 File Offset: 0x00006756
		public DirectBitmap HeightImage
		{
			get
			{
				return this.directBitmap_2;
			}
			set
			{
				this.directBitmap_2 = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0000855F File Offset: 0x0000675F
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00008567 File Offset: 0x00006767
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

		// Token: 0x040007B7 RID: 1975
		private bool bool_0;

		// Token: 0x040007B8 RID: 1976
		private string dimension;

		// Token: 0x040007B9 RID: 1977
		private PERegion peRegion;

		// Token: 0x040007BA RID: 1978
		private LevelDBWorker dbWorker;

		// Token: 0x040007BB RID: 1979
		private DirectBitmap directBitmap_0;

		// Token: 0x040007BC RID: 1980
		private DirectBitmap directBitmap_1;

		// Token: 0x040007BD RID: 1981
		private DirectBitmap directBitmap_2;

		// Token: 0x040007BE RID: 1982
		private string string_0;

		// Token: 0x040007BF RID: 1983
		private int int_0;

		// Token: 0x040007C0 RID: 1984
		private ManualResetEvent doneEvent;
	}
}
