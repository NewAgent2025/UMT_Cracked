using System;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000B5 RID: 181
	public class ExtractChunksParameter
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00002591 File Offset: 0x00000791
		public ExtractChunksParameter()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00005F21 File Offset: 0x00004121
		public ExtractChunksParameter(IndexEntry entry, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.entry = entry;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00005F3E File Offset: 0x0000413E
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00005F46 File Offset: 0x00004146
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00005F4F File Offset: 0x0000414F
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00005F57 File Offset: 0x00004157
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00005F60 File Offset: 0x00004160
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00005F68 File Offset: 0x00004168
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00005F71 File Offset: 0x00004171
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00005F79 File Offset: 0x00004179
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

		// Token: 0x04000530 RID: 1328
		private IndexEntry entry;

		// Token: 0x04000531 RID: 1329
		private string outFolderPath;

		// Token: 0x04000532 RID: 1330
		private ProcessStateType processStateType_0;

		// Token: 0x04000533 RID: 1331
		private ManualResetEvent doneEvent;
	}
}
