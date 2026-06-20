using System;
using System.Collections.Generic;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200008A RID: 138
	public class SearchEntityParameter
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x000024C1 File Offset: 0x000006C1
		public SearchEntityParameter()
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000054EC File Offset: 0x000036EC
		public SearchEntityParameter(string dimension, List<NodeSearchcriterion> criteria, string outFolderPath)
		{
			this.criteria = criteria;
			this.dimension = dimension;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00005509 File Offset: 0x00003709
		public SearchEntityParameter(string dimension, string region, List<NodeSearchcriterion> criteria, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.criteria = criteria;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00005536 File Offset: 0x00003736
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0000553E File Offset: 0x0000373E
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00005547 File Offset: 0x00003747
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0000554F File Offset: 0x0000374F
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00005558 File Offset: 0x00003758
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00005560 File Offset: 0x00003760
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00005569 File Offset: 0x00003769
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00005571 File Offset: 0x00003771
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0000557A File Offset: 0x0000377A
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00005582 File Offset: 0x00003782
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0000558B File Offset: 0x0000378B
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00005593 File Offset: 0x00003793
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0000559C File Offset: 0x0000379C
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000055A4 File Offset: 0x000037A4
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000055AD File Offset: 0x000037AD
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000055B5 File Offset: 0x000037B5
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

		// Token: 0x040003D0 RID: 976
		private bool bool_0;

		// Token: 0x040003D1 RID: 977
		private List<NodeSearchcriterion> criteria;

		// Token: 0x040003D2 RID: 978
		private string dimension;

		// Token: 0x040003D3 RID: 979
		private string region;

		// Token: 0x040003D4 RID: 980
		private string outFolderPath;

		// Token: 0x040003D5 RID: 981
		private List<EntitySearchResult> list_0;

		// Token: 0x040003D6 RID: 982
		private int int_0;

		// Token: 0x040003D7 RID: 983
		private ManualResetEvent doneEvent;
	}
}
