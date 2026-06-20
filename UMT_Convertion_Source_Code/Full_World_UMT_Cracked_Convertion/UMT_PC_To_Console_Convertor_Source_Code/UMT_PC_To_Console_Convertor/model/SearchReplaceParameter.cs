using System;
using System.Collections.Generic;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000079 RID: 121
	public class SearchReplaceParameter
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x000024C1 File Offset: 0x000006C1
		public SearchReplaceParameter()
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00004EF6 File Offset: 0x000030F6
		public SearchReplaceParameter(string dimension, group, string outFolderPath)
		{
			this.group = group;
			this.dimension = dimension;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00004F13 File Offset: 0x00003113
		public SearchReplaceParameter(string dimension, string region, group, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.group = group;
			this.outFolderPath = outFolderPath;
			this.KidwgAncMw = doneEvent;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00004F40 File Offset: 0x00003140
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00004F48 File Offset: 0x00003148
		public  Group
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00004F51 File Offset: 0x00003151
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00004F59 File Offset: 0x00003159
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00004F62 File Offset: 0x00003162
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00004F6A File Offset: 0x0000316A
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00004F73 File Offset: 0x00003173
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00004F7B File Offset: 0x0000317B
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00004F84 File Offset: 0x00003184
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00004F8C File Offset: 0x0000318C
		public bool Completed
		{
			get
			{
				return this.PqWwwiNoFO;
			}
			set
			{
				this.PqWwwiNoFO = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00004F95 File Offset: 0x00003195
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00004F9D File Offset: 0x0000319D
		public int ChunkProcessedCount
		{
			get
			{
				return this.BrpwMuaoWj;
			}
			set
			{
				this.BrpwMuaoWj = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00004FA6 File Offset: 0x000031A6
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00004FAE File Offset: 0x000031AE
		public List Result
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00004FB7 File Offset: 0x000031B7
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00004FBF File Offset: 0x000031BF
		public ManualResetEvent DoneEvent
		{
			get
			{
				return this.KidwgAncMw;
			}
			set
			{
				this.KidwgAncMw = value;
			}
		}

		// Token: 0x04000391 RID: 913
		private bool PqWwwiNoFO;

		// Token: 0x04000392 RID: 914
		private  group;

		// Token: 0x04000393 RID: 915
		private string dimension;

		// Token: 0x04000394 RID: 916
		private string region;

		// Token: 0x04000395 RID: 917
		private string outFolderPath;

		// Token: 0x04000396 RID: 918
		private List list_0;

		// Token: 0x04000397 RID: 919
		private int BrpwMuaoWj;

		// Token: 0x04000398 RID: 920
		private ManualResetEvent KidwgAncMw;
	}
}
