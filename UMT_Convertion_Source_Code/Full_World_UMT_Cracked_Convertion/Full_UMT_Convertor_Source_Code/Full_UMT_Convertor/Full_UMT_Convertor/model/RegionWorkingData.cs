using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D5 RID: 213
	public class RegionWorkingData
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x00002591 File Offset: 0x00000791
		public RegionWorkingData()
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00006B3E File Offset: 0x00004D3E
		public RegionWorkingData(string path, IndexEntry indexEntry)
		{
			this.path = path;
			this.indexEntry = indexEntry;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00006B5C File Offset: 0x00004D5C
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00006B65 File Offset: 0x00004D65
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00006B6D File Offset: 0x00004D6D
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

		// Token: 0x04000629 RID: 1577
		private string path;

		// Token: 0x0400062A RID: 1578
		private IndexEntry indexEntry;
	}
}
