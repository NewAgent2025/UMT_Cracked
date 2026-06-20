using System;
using Substrate.Data;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000AE RID: 174
	public class MCMap
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x00002591 File Offset: 0x00000791
		public MCMap()
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000599D File Offset: 0x00003B9D
		public MCMap(int index)
		{
			this.index = index;
			this.name = "map_" + index.ToString();
			this.map = new Map();
			this.mapStatusType_0 = MapStatusType.New;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000059D5 File Offset: 0x00003BD5
		public MCMap(int index, string name, Map map)
		{
			this.index = index;
			this.name = name;
			this.map = map;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000059F2 File Offset: 0x00003BF2
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x000059FA File Offset: 0x00003BFA
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00005A03 File Offset: 0x00003C03
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00005A0B File Offset: 0x00003C0B
		public Map Map
		{
			get
			{
				return this.map;
			}
			set
			{
				this.map = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00005A14 File Offset: 0x00003C14
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00005A1C File Offset: 0x00003C1C
		public int Index
		{
			get
			{
				return this.index;
			}
			set
			{
				this.index = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00005A25 File Offset: 0x00003C25
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00005A2D File Offset: 0x00003C2D
		public MapStatusType MapStatus
		{
			get
			{
				return this.mapStatusType_0;
			}
			set
			{
				this.mapStatusType_0 = value;
			}
		}

		// Token: 0x0400050B RID: 1291
		private string name;

		// Token: 0x0400050C RID: 1292
		private Map map;

		// Token: 0x0400050D RID: 1293
		private int index;

		// Token: 0x0400050E RID: 1294
		private MapStatusType mapStatusType_0;
	}
}
