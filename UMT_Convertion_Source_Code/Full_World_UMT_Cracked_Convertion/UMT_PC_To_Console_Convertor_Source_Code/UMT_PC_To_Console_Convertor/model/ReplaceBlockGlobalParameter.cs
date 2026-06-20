using System;
using System.Collections.Generic;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200008D RID: 141
	public class ReplaceBlockGlobalParameter
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000024C1 File Offset: 0x000006C1
		public ReplaceBlockGlobalParameter()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000056D0 File Offset: 0x000038D0
		public ReplaceBlockGlobalParameter(string dimension, List<BlockChange> replacementBlockList, string outFolderPath)
		{
			this.dimension = dimension;
			this.replacementBlockList = replacementBlockList;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000056ED File Offset: 0x000038ED
		public ReplaceBlockGlobalParameter(string dimension, string region, List<BlockChange> replacementBlockList, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.replacementBlockList = replacementBlockList;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0000571A File Offset: 0x0000391A
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00005722 File Offset: 0x00003922
		public List<BlockChange> ReplacementBlockList
		{
			get
			{
				return this.replacementBlockList;
			}
			set
			{
				this.replacementBlockList = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0000572B File Offset: 0x0000392B
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00005733 File Offset: 0x00003933
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0000573C File Offset: 0x0000393C
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00005744 File Offset: 0x00003944
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0000574D File Offset: 0x0000394D
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00005755 File Offset: 0x00003955
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0000575E File Offset: 0x0000395E
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00005766 File Offset: 0x00003966
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0000576F File Offset: 0x0000396F
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00005777 File Offset: 0x00003977
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00005780 File Offset: 0x00003980
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005788 File Offset: 0x00003988
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00005791 File Offset: 0x00003991
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005799 File Offset: 0x00003999
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

		// Token: 0x040003E2 RID: 994
		private string outFolderPath;

		// Token: 0x040003E3 RID: 995
		private string dimension;

		// Token: 0x040003E4 RID: 996
		private string region;

		// Token: 0x040003E5 RID: 997
		private List<BlockChange> replacementBlockList;

		// Token: 0x040003E6 RID: 998
		private int int_0;

		// Token: 0x040003E7 RID: 999
		private int int_1;

		// Token: 0x040003E8 RID: 1000
		private ProcessStateType processStateType_0;

		// Token: 0x040003E9 RID: 1001
		private ManualResetEvent doneEvent;
	}
}
