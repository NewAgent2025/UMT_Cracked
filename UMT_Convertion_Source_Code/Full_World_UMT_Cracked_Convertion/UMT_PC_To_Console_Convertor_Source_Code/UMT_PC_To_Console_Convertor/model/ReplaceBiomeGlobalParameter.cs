using System;
using System.Collections.Generic;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200008C RID: 140
	public class ReplaceBiomeGlobalParameter
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x000024C1 File Offset: 0x000006C1
		public ReplaceBiomeGlobalParameter()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000055FE File Offset: 0x000037FE
		public ReplaceBiomeGlobalParameter(string dimension, List<BiomeChange> replacementBiomeList, string outFolderPath)
		{
			this.dimension = dimension;
			this.replacementBiomeList = replacementBiomeList;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000561B File Offset: 0x0000381B
		public ReplaceBiomeGlobalParameter(string dimension, string region, List<BiomeChange> replacementBiomeList, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.replacementBiomeList = replacementBiomeList;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00005648 File Offset: 0x00003848
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00005650 File Offset: 0x00003850
		public List<BiomeChange> ReplacementBiomeList
		{
			get
			{
				return this.replacementBiomeList;
			}
			set
			{
				this.replacementBiomeList = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00005659 File Offset: 0x00003859
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00005661 File Offset: 0x00003861
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0000566A File Offset: 0x0000386A
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00005672 File Offset: 0x00003872
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0000567B File Offset: 0x0000387B
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00005683 File Offset: 0x00003883
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0000568C File Offset: 0x0000388C
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00005694 File Offset: 0x00003894
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0000569D File Offset: 0x0000389D
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x000056A5 File Offset: 0x000038A5
		public int BiomeProcessedCount
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x000056AE File Offset: 0x000038AE
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x000056B6 File Offset: 0x000038B6
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x000056BF File Offset: 0x000038BF
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x000056C7 File Offset: 0x000038C7
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

		// Token: 0x040003DA RID: 986
		private string outFolderPath;

		// Token: 0x040003DB RID: 987
		private string dimension;

		// Token: 0x040003DC RID: 988
		private string region;

		// Token: 0x040003DD RID: 989
		private List<BiomeChange> replacementBiomeList;

		// Token: 0x040003DE RID: 990
		private int int_0;

		// Token: 0x040003DF RID: 991
		private int int_1;

		// Token: 0x040003E0 RID: 992
		private ProcessStateType processStateType_0;

		// Token: 0x040003E1 RID: 993
		private ManualResetEvent doneEvent;
	}
}
