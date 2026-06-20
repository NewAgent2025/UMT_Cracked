using System;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000B4 RID: 180
	public class DeleteFolderParameter
	{
		// Token: 0x06000786 RID: 1926 RVA: 0x00002591 File Offset: 0x00000791
		public DeleteFolderParameter()
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00005EE9 File Offset: 0x000040E9
		public DeleteFolderParameter(string oldFolder, ManualResetEvent doneEvent)
		{
			this.oldFolder = oldFolder;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00005EFF File Offset: 0x000040FF
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00005F07 File Offset: 0x00004107
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00005F10 File Offset: 0x00004110
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00005F18 File Offset: 0x00004118
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

		// Token: 0x0400052E RID: 1326
		private string oldFolder;

		// Token: 0x0400052F RID: 1327
		private ManualResetEvent doneEvent;
	}
}
