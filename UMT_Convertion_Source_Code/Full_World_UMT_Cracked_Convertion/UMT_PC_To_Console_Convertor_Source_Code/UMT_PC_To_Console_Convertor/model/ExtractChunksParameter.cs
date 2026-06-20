using System;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200007B RID: 123
	public class ExtractChunksParameter
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x000024C1 File Offset: 0x000006C1
		public ExtractChunksParameter()
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00005000 File Offset: 0x00003200
		public ExtractChunksParameter(IndexEntry entry, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.entry = entry;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0000501D File Offset: 0x0000321D
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00005025 File Offset: 0x00003225
		public IndexEntry Entry
		{
			get
			{
				return this.entry;
			}
			set
			{
				this.entry = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0000502E File Offset: 0x0000322E
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00005036 File Offset: 0x00003236
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0000503F File Offset: 0x0000323F
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00005047 File Offset: 0x00003247
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00005050 File Offset: 0x00003250
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00005058 File Offset: 0x00003258
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

		// Token: 0x0400039B RID: 923
		private IndexEntry entry;

		// Token: 0x0400039C RID: 924
		private string outFolderPath;

		// Token: 0x0400039D RID: 925
		private ProcessStateType processStateType_0;

		// Token: 0x0400039E RID: 926
		private ManualResetEvent doneEvent;
	}
}
