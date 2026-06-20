using System;
using Substrate.Data;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000076 RID: 118
	public class MCMap
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x000024C1 File Offset: 0x000006C1
		public MCMap()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public MCMap(int index)
		{
			this.index = index;
			this.name = "map_" + index.ToString();
			this.map = new Map();
			this.mapStatusType_0 = MapStatusType.New;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public MCMap(int index, string name, Map map)
		{
			this.index = index;
			this.name = name;
			this.map = map;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00004D15 File Offset: 0x00002F15
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004D1D File Offset: 0x00002F1D
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00004D26 File Offset: 0x00002F26
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004D2E File Offset: 0x00002F2E
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00004D37 File Offset: 0x00002F37
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004D3F File Offset: 0x00002F3F
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00004D48 File Offset: 0x00002F48
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004D50 File Offset: 0x00002F50
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

		// Token: 0x0400037A RID: 890
		private string name;

		// Token: 0x0400037B RID: 891
		private Map map;

		// Token: 0x0400037C RID: 892
		private int index;

		// Token: 0x0400037D RID: 893
		private MapStatusType mapStatusType_0;
	}
}
