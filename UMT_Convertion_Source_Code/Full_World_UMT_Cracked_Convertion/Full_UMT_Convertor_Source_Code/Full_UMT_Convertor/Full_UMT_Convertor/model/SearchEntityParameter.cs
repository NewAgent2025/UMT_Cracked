using System;
using System.Collections.Generic;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000CB RID: 203
	public class SearchEntityParameter
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x00002591 File Offset: 0x00000791
		public SearchEntityParameter()
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00006611 File Offset: 0x00004811
		public SearchEntityParameter(string dimension, List<NodeSearchcriterion> criteria, string outFolderPath)
		{
			this.criteria = criteria;
			this.dimension = dimension;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0000662E File Offset: 0x0000482E
		public SearchEntityParameter(string dimension, string region, List<NodeSearchcriterion> criteria, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.criteria = criteria;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0000665B File Offset: 0x0000485B
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00006663 File Offset: 0x00004863
		public List<NodeSearchcriterion> Criteria
		{
			get
			{
				return this.criteria;
			}
			set
			{
				this.criteria = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0000666C File Offset: 0x0000486C
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00006674 File Offset: 0x00004874
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0000667D File Offset: 0x0000487D
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00006685 File Offset: 0x00004885
		public string Region
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0000668E File Offset: 0x0000488E
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00006696 File Offset: 0x00004896
		public string OutFolderPath
		{
			get
			{
				return this.outFolderPath;
			}
			set
			{
				this.outFolderPath = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0000669F File Offset: 0x0000489F
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x000066A7 File Offset: 0x000048A7
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000066B0 File Offset: 0x000048B0
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x000066B8 File Offset: 0x000048B8
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000066C1 File Offset: 0x000048C1
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000066C9 File Offset: 0x000048C9
		public List<EntitySearchResult> Result
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000066D2 File Offset: 0x000048D2
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000066DA File Offset: 0x000048DA
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

		// Token: 0x040005EC RID: 1516
		private bool bool_0;

		// Token: 0x040005ED RID: 1517
		private List<NodeSearchcriterion> criteria;

		// Token: 0x040005EE RID: 1518
		private string dimension;

		// Token: 0x040005EF RID: 1519
		private string region;

		// Token: 0x040005F0 RID: 1520
		private string outFolderPath;

		// Token: 0x040005F1 RID: 1521
		private List<EntitySearchResult> list_0;

		// Token: 0x040005F2 RID: 1522
		private int int_0;

		// Token: 0x040005F3 RID: 1523
		private ManualResetEvent doneEvent;
	}
}
