using System;
using System.Collections.Generic;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D1 RID: 209
	public class SearchBlockParameter
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00002591 File Offset: 0x00000791
		public SearchBlockParameter()
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000069B0 File Offset: 0x00004BB0
		public SearchBlockParameter(Block searchBlock, string dimension, string region, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.searchBlock = searchBlock;
			this.dimension = dimension;
			this.region = region;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x000069DD File Offset: 0x00004BDD
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x000069E5 File Offset: 0x00004BE5
		public Block SearchBlock
		{
			get
			{
				return this.searchBlock;
			}
			set
			{
				this.searchBlock = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x000069EE File Offset: 0x00004BEE
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x000069F6 File Offset: 0x00004BF6
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000069FF File Offset: 0x00004BFF
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00006A07 File Offset: 0x00004C07
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00006A10 File Offset: 0x00004C10
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00006A18 File Offset: 0x00004C18
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00006A21 File Offset: 0x00004C21
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00006A29 File Offset: 0x00004C29
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

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00006A32 File Offset: 0x00004C32
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00006A3A File Offset: 0x00004C3A
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00006A43 File Offset: 0x00004C43
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00006A4B File Offset: 0x00004C4B
		public List<BlockSearchResult> Result
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00006A54 File Offset: 0x00004C54
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00006A5C File Offset: 0x00004C5C
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

		// Token: 0x04000619 RID: 1561
		private bool bool_0;

		// Token: 0x0400061A RID: 1562
		private Block searchBlock;

		// Token: 0x0400061B RID: 1563
		private string dimension;

		// Token: 0x0400061C RID: 1564
		private string region;

		// Token: 0x0400061D RID: 1565
		private string outFolderPath;

		// Token: 0x0400061E RID: 1566
		private List<BlockSearchResult> list_0;

		// Token: 0x0400061F RID: 1567
		private int int_0;

		// Token: 0x04000620 RID: 1568
		private ManualResetEvent doneEvent;
	}
}
