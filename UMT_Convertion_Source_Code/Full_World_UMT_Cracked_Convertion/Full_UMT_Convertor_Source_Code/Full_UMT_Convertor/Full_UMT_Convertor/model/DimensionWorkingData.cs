using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000A6 RID: 166
	public class DimensionWorkingData
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x00002591 File Offset: 0x00000791
		public DimensionWorkingData()
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000558C File Offset: 0x0000378C
		public DimensionWorkingData(string dimension, string path)
		{
			this.dimension = dimension;
			this.path = path;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000055A2 File Offset: 0x000037A2
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x000055AA File Offset: 0x000037AA
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000055B3 File Offset: 0x000037B3
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000055BB File Offset: 0x000037BB
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

		// Token: 0x040004E6 RID: 1254
		private string dimension;

		// Token: 0x040004E7 RID: 1255
		private string path;
	}
}
