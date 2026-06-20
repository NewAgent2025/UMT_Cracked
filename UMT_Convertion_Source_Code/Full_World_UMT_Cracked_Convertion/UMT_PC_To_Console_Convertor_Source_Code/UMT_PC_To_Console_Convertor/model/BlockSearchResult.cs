using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000083 RID: 131
	public class BlockSearchResult : Block
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x0000523E File Offset: 0x0000343E
		public BlockSearchResult()
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00029F64 File Offset: 0x00028164
		public BlockSearchResult(Block block, string dimension, string region, ChunkIndexEntry chunkIndex, int chunkX, int chunkZ, int x, int y, int z)
		{
			base.Id = block.Id;
			base.Data = block.Data;
			base.Light = block.Light;
			this.dimension = dimension;
			this.region = region;
			this.afsgehmuYG = chunkIndex;
			this.chunkX = chunkX;
			this.chunkZ = chunkZ;
			this.x = x;
			this.z = z;
			this.y = y;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00029FDC File Offset: 0x000281DC
		public BlockSearchResult(int id, int data, int light, string dimension, string region, ChunkIndexEntry chunkIndex, int chunkX, int chunkZ, int x, int y, int z)
		{
			base.Id = id;
			base.Data = data;
			base.Light = light;
			this.dimension = dimension;
			this.region = region;
			this.afsgehmuYG = chunkIndex;
			this.chunkX = chunkX;
			this.chunkZ = chunkZ;
			this.x = x;
			this.z = z;
			this.y = y;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00005246 File Offset: 0x00003446
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0000524E File Offset: 0x0000344E
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00005257 File Offset: 0x00003457
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0000525F File Offset: 0x0000345F
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00005268 File Offset: 0x00003468
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00005270 File Offset: 0x00003470
		public ChunkIndexEntry ChunkIndex
		{
			get
			{
				return this.afsgehmuYG;
			}
			set
			{
				this.afsgehmuYG = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00005279 File Offset: 0x00003479
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00005281 File Offset: 0x00003481
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0000528A File Offset: 0x0000348A
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00005292 File Offset: 0x00003492
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0000529B File Offset: 0x0000349B
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x000052A3 File Offset: 0x000034A3
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000052AC File Offset: 0x000034AC
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000052B4 File Offset: 0x000034B4
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000052BD File Offset: 0x000034BD
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x000052C5 File Offset: 0x000034C5
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000052CE File Offset: 0x000034CE
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x000052D6 File Offset: 0x000034D6
		public int LocalX
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000052DF File Offset: 0x000034DF
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000052E7 File Offset: 0x000034E7
		public int LocalZ
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0002A044 File Offset: 0x00028244
		public string BlockPositionString()
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

		// Token: 0x060005AF RID: 1455 RVA: 0x0002A0AC File Offset: 0x000282AC
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

		// Token: 0x040003AE RID: 942
		private string dimension;

		// Token: 0x040003AF RID: 943
		private string region;

		// Token: 0x040003B0 RID: 944
		private ChunkIndexEntry afsgehmuYG;

		// Token: 0x040003B1 RID: 945
		private int chunkX;

		// Token: 0x040003B2 RID: 946
		private int chunkZ;

		// Token: 0x040003B3 RID: 947
		private int x;

		// Token: 0x040003B4 RID: 948
		private int y;

		// Token: 0x040003B5 RID: 949
		private int z;

		// Token: 0x040003B6 RID: 950
		private int int_1;

		// Token: 0x040003B7 RID: 951
		private int int_2;
	}
}
