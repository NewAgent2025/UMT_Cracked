using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000087 RID: 135
	public class EntitySearchResult
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x000024C1 File Offset: 0x000006C1
		public EntitySearchResult()
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0002A1D8 File Offset: 0x000283D8
		public EntitySearchResult(string dimension, string region, ChunkIndexEntry chunkIndex, int chunkX, int chunkZ, int x, int y, int z, string entityId, EntityType entityType, string parent = "")
		{
			this.dimension = dimension;
			this.region = region;
			this.chunkIndex = chunkIndex;
			this.chunkX = chunkX;
			this.chunkZ = chunkZ;
			this.x = x;
			this.z = z;
			this.y = y;
			this.entityId = entityId;
			this.entityType = entityType;
			this.parent = parent;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x000053DE File Offset: 0x000035DE
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x000053E6 File Offset: 0x000035E6
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x000053EF File Offset: 0x000035EF
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x000053F7 File Offset: 0x000035F7
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00005400 File Offset: 0x00003600
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00005408 File Offset: 0x00003608
		public ChunkIndexEntry ChunkIndex
		{
			get
			{
				return this.chunkIndex;
			}
			set
			{
				this.chunkIndex = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00005411 File Offset: 0x00003611
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00005419 File Offset: 0x00003619
		public int ChunkX
		{
			get
			{
				return this.chunkX;
			}
			set
			{
				this.chunkX = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00005422 File Offset: 0x00003622
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0000542A File Offset: 0x0000362A
		public int ChunkZ
		{
			get
			{
				return this.chunkZ;
			}
			set
			{
				this.chunkZ = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00005433 File Offset: 0x00003633
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0000543B File Offset: 0x0000363B
		public int X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00005444 File Offset: 0x00003644
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0000544C File Offset: 0x0000364C
		public int Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00005455 File Offset: 0x00003655
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0000545D File Offset: 0x0000365D
		public int Z
		{
			get
			{
				return this.z;
			}
			set
			{
				this.z = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00005466 File Offset: 0x00003666
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x0000546E File Offset: 0x0000366E
		public string EntityId
		{
			get
			{
				return this.entityId;
			}
			set
			{
				this.entityId = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00005477 File Offset: 0x00003677
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0000547F File Offset: 0x0000367F
		public EntityType EntityType
		{
			get
			{
				return this.entityType;
			}
			set
			{
				this.entityType = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00005488 File Offset: 0x00003688
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00005490 File Offset: 0x00003690
		public string Parent
		{
			get
			{
				return this.parent;
			}
			set
			{
				this.parent = value;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0002A240 File Offset: 0x00028440
		public string PositionString()
		{
			return string.Concat(new object[]
			{
				"(",
				this.x,
				", ",
				this.y,
				", ",
				this.z,
				')'
			});
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0002A2A8 File Offset: 0x000284A8
		public string ChunkString()
		{
			return string.Concat(new object[]
			{
				'[',
				(this.x >> 4).ToString(),
				", ",
				(this.z >> 4).ToString(),
				']'
			});
		}

		// Token: 0x040003C1 RID: 961
		private string dimension;

		// Token: 0x040003C2 RID: 962
		private string region;

		// Token: 0x040003C3 RID: 963
		private ChunkIndexEntry chunkIndex;

		// Token: 0x040003C4 RID: 964
		private int chunkX;

		// Token: 0x040003C5 RID: 965
		private int chunkZ;

		// Token: 0x040003C6 RID: 966
		private int x;

		// Token: 0x040003C7 RID: 967
		private int y;

		// Token: 0x040003C8 RID: 968
		private int z;

		// Token: 0x040003C9 RID: 969
		private string entityId;

		// Token: 0x040003CA RID: 970
		private EntityType entityType;

		// Token: 0x040003CB RID: 971
		private string parent;
	}
}
