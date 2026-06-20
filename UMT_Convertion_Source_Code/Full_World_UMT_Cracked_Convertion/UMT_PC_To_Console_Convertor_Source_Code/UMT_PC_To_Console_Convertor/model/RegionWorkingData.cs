using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000091 RID: 145
	public class RegionWorkingData
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x000024C1 File Offset: 0x000006C1
		public RegionWorkingData()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00005984 File Offset: 0x00003B84
		public RegionWorkingData(string path, IndexEntry indexEntry)
		{
			this.path = path;
			this.indexEntry = indexEntry;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0000599A File Offset: 0x00003B9A
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x000059A2 File Offset: 0x00003BA2
		public string Path
		{
			get
			{
				return this.path;
			}
			set
			{
				this.path = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000059AB File Offset: 0x00003BAB
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x000059B3 File Offset: 0x00003BB3
		public IndexEntry IndexEntry
		{
			get
			{
				return this.indexEntry;
			}
			set
			{
				this.indexEntry = value;
			}
		}

		// Token: 0x04000402 RID: 1026
		private string path;

		// Token: 0x04000403 RID: 1027
		private IndexEntry indexEntry;
	}
}
