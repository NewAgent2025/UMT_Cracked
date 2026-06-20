using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200008E RID: 142
	public class ReplaceBlockParameter
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x000024C1 File Offset: 0x000006C1
		public ReplaceBlockParameter()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000057A2 File Offset: 0x000039A2
		public ReplaceBlockParameter(Block replacementBlock, List<BlockSearchResult> replaceBlockList, string outFolderPath)
		{
			this.replacementBlock = replacementBlock;
			this.replaceBlockList = replaceBlockList;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0002A418 File Offset: 0x00028618
		public ReplaceBlockParameter(Block replacementBlock, Dictionary<int, List<BlockSearchResult>> replaceChunkBlockList, string outFolderPath, ManualResetEvent doneEvent)
		{
			if (replaceChunkBlockList.Count > 0)
			{
				int key = replaceChunkBlockList.Keys.First<int>();
				if (replaceChunkBlockList[key].Count > 0)
				{
					this.string_0 = replaceChunkBlockList[key][0].Dimension;
					this.string_1 = replaceChunkBlockList[key][0].Region;
				}
			}
			this.replacementBlock = replacementBlock;
			this.replaceChunkBlockList = replaceChunkBlockList;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000057BF File Offset: 0x000039BF
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000057C7 File Offset: 0x000039C7
		public Block ReplacementBlock
		{
			get
			{
				return this.replacementBlock;
			}
			set
			{
				this.replacementBlock = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000057D0 File Offset: 0x000039D0
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x000057D8 File Offset: 0x000039D8
		public List<BlockSearchResult> ReplaceBlockList
		{
			get
			{
				return this.replaceBlockList;
			}
			set
			{
				this.replaceBlockList = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000057E1 File Offset: 0x000039E1
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x000057E9 File Offset: 0x000039E9
		public Dictionary<int, List<BlockSearchResult>> ReplaceChunkBlockList
		{
			get
			{
				return this.replaceChunkBlockList;
			}
			set
			{
				this.replaceChunkBlockList = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000057F2 File Offset: 0x000039F2
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x000057FA File Offset: 0x000039FA
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00005803 File Offset: 0x00003A03
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0000580B File Offset: 0x00003A0B
		public string Dimension
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00005814 File Offset: 0x00003A14
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x0000581C File Offset: 0x00003A1C
		public string Region
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00005825 File Offset: 0x00003A25
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0000582D File Offset: 0x00003A2D
		public ProcessStateType ProcessState
		{
			get
			{
				return this.processStateType_0;
			}
			set
			{
				this.processStateType_0 = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00005836 File Offset: 0x00003A36
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0000583E File Offset: 0x00003A3E
		public int BlockProcessedCount
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00005847 File Offset: 0x00003A47
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x0000584F File Offset: 0x00003A4F
		public int ChunkProcessedCount
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00005858 File Offset: 0x00003A58
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00005860 File Offset: 0x00003A60
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

		// Token: 0x040003EA RID: 1002
		private Block replacementBlock;

		// Token: 0x040003EB RID: 1003
		private string outFolderPath;

		// Token: 0x040003EC RID: 1004
		private List<BlockSearchResult> replaceBlockList;

		// Token: 0x040003ED RID: 1005
		private Dictionary<int, List<BlockSearchResult>> replaceChunkBlockList;

		// Token: 0x040003EE RID: 1006
		private string string_0;

		// Token: 0x040003EF RID: 1007
		private string string_1;

		// Token: 0x040003F0 RID: 1008
		private int int_0;

		// Token: 0x040003F1 RID: 1009
		private int int_1;

		// Token: 0x040003F2 RID: 1010
		private ProcessStateType processStateType_0;

		// Token: 0x040003F3 RID: 1011
		private ManualResetEvent doneEvent;
	}
}
