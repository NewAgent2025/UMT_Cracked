using System;
using System.Collections.Generic;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200008F RID: 143
	public class SearchBlockParameter
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x000024C1 File Offset: 0x000006C1
		public SearchBlockParameter()
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00005869 File Offset: 0x00003A69
		public SearchBlockParameter(Block searchBlock, string dimension, string region, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.searchBlock = searchBlock;
			this.dimension = dimension;
			this.region = region;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00005896 File Offset: 0x00003A96
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x0000589E File Offset: 0x00003A9E
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000058A7 File Offset: 0x00003AA7
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000058AF File Offset: 0x00003AAF
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000058B8 File Offset: 0x00003AB8
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x000058C0 File Offset: 0x00003AC0
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000058C9 File Offset: 0x00003AC9
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x000058D1 File Offset: 0x00003AD1
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x000058DA File Offset: 0x00003ADA
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000058E2 File Offset: 0x00003AE2
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x000058EB File Offset: 0x00003AEB
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x000058F3 File Offset: 0x00003AF3
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x000058FC File Offset: 0x00003AFC
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00005904 File Offset: 0x00003B04
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0000590D File Offset: 0x00003B0D
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00005915 File Offset: 0x00003B15
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

		// Token: 0x040003F4 RID: 1012
		private bool bool_0;

		// Token: 0x040003F5 RID: 1013
		private Block searchBlock;

		// Token: 0x040003F6 RID: 1014
		private string dimension;

		// Token: 0x040003F7 RID: 1015
		private string region;

		// Token: 0x040003F8 RID: 1016
		private string outFolderPath;

		// Token: 0x040003F9 RID: 1017
		private List<BlockSearchResult> list_0;

		// Token: 0x040003FA RID: 1018
		private int int_0;

		// Token: 0x040003FB RID: 1019
		private ManualResetEvent doneEvent;
	}
}
