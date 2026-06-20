using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C7 RID: 199
	public class ChunkPattern
	{
		// Token: 0x06000876 RID: 2166 RVA: 0x00006435 File Offset: 0x00004635
		private ChunkPattern()
		{
			this.id = Guid.NewGuid();
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00006453 File Offset: 0x00004653
		private ChunkPattern(Guid id, string name, List<ChunkLayer> levels)
		{
			this.id = id;
			this.name = name;
			this.levels = levels;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0000647B File Offset: 0x0000467B
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00006483 File Offset: 0x00004683
		public Guid Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0000648C File Offset: 0x0000468C
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00006494 File Offset: 0x00004694
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000649D File Offset: 0x0000469D
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000064A5 File Offset: 0x000046A5
		public List<ChunkLayer> Levels
		{
			get
			{
				return this.levels;
			}
			set
			{
				this.levels = value;
			}
		}

		// Token: 0x040005D6 RID: 1494
		private Guid id;

		// Token: 0x040005D7 RID: 1495
		private string name;

		// Token: 0x040005D8 RID: 1496
		private List<ChunkLayer> levels = new List<ChunkLayer>();
	}
}
