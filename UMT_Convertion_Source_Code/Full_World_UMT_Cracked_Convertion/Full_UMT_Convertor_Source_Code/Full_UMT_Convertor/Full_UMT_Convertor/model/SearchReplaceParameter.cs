using System;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000B3 RID: 179
	public class SearchReplaceParameter
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00002591 File Offset: 0x00000791
		public SearchReplaceParameter()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00005E17 File Offset: 0x00004017
		public SearchReplaceParameter(string dimension, group, string outFolderPath)
		{
			this.group = group;
			this.dimension = dimension;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00005E34 File Offset: 0x00004034
		public SearchReplaceParameter(string dimension, string region, group, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.group = group;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00005E61 File Offset: 0x00004061
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00005E69 File Offset: 0x00004069
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00005E72 File Offset: 0x00004072
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005E7A File Offset: 0x0000407A
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00005E83 File Offset: 0x00004083
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005E8B File Offset: 0x0000408B
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00005E94 File Offset: 0x00004094
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00005E9C File Offset: 0x0000409C
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00005EA5 File Offset: 0x000040A5
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00005EAD File Offset: 0x000040AD
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00005EB6 File Offset: 0x000040B6
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00005EBE File Offset: 0x000040BE
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00005EC7 File Offset: 0x000040C7
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00005ECF File Offset: 0x000040CF
		public  Result
		{
			get
			{
				return this.searchReplaceResult_0;
			}
			set
			{
				this.searchReplaceResult_0 = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00005ED8 File Offset: 0x000040D8
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00005EE0 File Offset: 0x000040E0
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

		// Token: 0x04000526 RID: 1318
		private bool bool_0;

		// Token: 0x04000527 RID: 1319
		private  group;

		// Token: 0x04000528 RID: 1320
		private string dimension;

		// Token: 0x04000529 RID: 1321
		private string region;

		// Token: 0x0400052A RID: 1322
		private string outFolderPath;

		// Token: 0x0400052B RID: 1323
		private  searchReplaceResult_0;

		// Token: 0x0400052C RID: 1324
		private int int_0;

		// Token: 0x0400052D RID: 1325
		private ManualResetEvent doneEvent;
	}
}
