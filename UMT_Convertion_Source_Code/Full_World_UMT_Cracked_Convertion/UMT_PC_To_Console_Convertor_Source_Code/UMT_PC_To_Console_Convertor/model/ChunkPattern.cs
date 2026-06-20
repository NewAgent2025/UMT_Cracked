using System;
using System.Collections.Generic;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000085 RID: 133
	public class ChunkPattern
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x00005332 File Offset: 0x00003532
		private ChunkPattern()
		{
			this.id = Guid.NewGuid();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00005350 File Offset: 0x00003550
		private ChunkPattern(Guid id, string name, List<ChunkLayer> levels)
		{
			this.id = id;
			this.name = name;
			this.levels = levels;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00005378 File Offset: 0x00003578
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00005380 File Offset: 0x00003580
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00005389 File Offset: 0x00003589
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00005391 File Offset: 0x00003591
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0000539A File Offset: 0x0000359A
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000053A2 File Offset: 0x000035A2
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

		// Token: 0x040003BB RID: 955
		private Guid id;

		// Token: 0x040003BC RID: 956
		private string name;

		// Token: 0x040003BD RID: 957
		private List<ChunkLayer> levels = new List<ChunkLayer>();
	}
}
