using System;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200007A RID: 122
	public class DeleteFolderParameter
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x000024C1 File Offset: 0x000006C1
		public DeleteFolderParameter()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00004FC8 File Offset: 0x000031C8
		public DeleteFolderParameter(string oldFolder, ManualResetEvent doneEvent)
		{
			this.oldFolder = oldFolder;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00004FDE File Offset: 0x000031DE
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00004FE6 File Offset: 0x000031E6
		public string OldFolderPath
		{
			get
			{
				return this.oldFolder;
			}
			set
			{
				this.oldFolder = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00004FEF File Offset: 0x000031EF
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00004FF7 File Offset: 0x000031F7
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

		// Token: 0x04000399 RID: 921
		private string oldFolder;

		// Token: 0x0400039A RID: 922
		private ManualResetEvent doneEvent;
	}
}
