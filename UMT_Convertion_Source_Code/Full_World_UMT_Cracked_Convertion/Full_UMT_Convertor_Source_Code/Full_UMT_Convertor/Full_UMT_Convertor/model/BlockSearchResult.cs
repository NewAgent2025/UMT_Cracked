using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C5 RID: 197
	public class BlockSearchResult : Block
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x00006341 File Offset: 0x00004541
		public BlockSearchResult()
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00046A54 File Offset: 0x00044C54
		public BlockSearchResult(Block block, string dimension, string region, ChunkIndexEntry chunkIndex, int chunkX, int chunkZ, int x, int y, int z)
		{
			base.Id = block.Id;
			base.Data = block.Data;
			base.Light = block.Light;
			this.dimension = dimension;
			this.region = region;
			this.chunkIndex = chunkIndex;
			this.chunkX = chunkX;
			this.chunkZ = chunkZ;
			this.x = x;
			this.z = z;
			this.y = y;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00046ACC File Offset: 0x00044CCC
		public BlockSearchResult(int id, int data, int light, string dimension, string region, ChunkIndexEntry chunkIndex, int chunkX, int chunkZ, int x, int y, int z)
		{
			base.Id = id;
			base.Data = data;
			base.Light = light;
			this.dimension = dimension;
			this.region = region;
			this.chunkIndex = chunkIndex;
			this.chunkX = chunkX;
			this.chunkZ = chunkZ;
			this.x = x;
			this.z = z;
			this.y = y;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00006349 File Offset: 0x00004549
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00006351 File Offset: 0x00004551
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0000635A File Offset: 0x0000455A
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00006362 File Offset: 0x00004562
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0000636B File Offset: 0x0000456B
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00006373 File Offset: 0x00004573
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0000637C File Offset: 0x0000457C
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00006384 File Offset: 0x00004584
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0000638D File Offset: 0x0000458D
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00006395 File Offset: 0x00004595
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0000639E File Offset: 0x0000459E
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x000063A6 File Offset: 0x000045A6
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000063AF File Offset: 0x000045AF
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000063B7 File Offset: 0x000045B7
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x000063C8 File Offset: 0x000045C8
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x000063D1 File Offset: 0x000045D1
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x000063D9 File Offset: 0x000045D9
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x000063E2 File Offset: 0x000045E2
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x000063EA File Offset: 0x000045EA
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

		// Token: 0x0600086C RID: 2156 RVA: 0x00046B34 File Offset: 0x00044D34
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

		// Token: 0x0600086D RID: 2157 RVA: 0x00046B9C File Offset: 0x00044D9C
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

		// Token: 0x040005C9 RID: 1481
		private string dimension;

		// Token: 0x040005CA RID: 1482
		private string region;

		// Token: 0x040005CB RID: 1483
		private ChunkIndexEntry chunkIndex;

		// Token: 0x040005CC RID: 1484
		private int chunkX;

		// Token: 0x040005CD RID: 1485
		private int chunkZ;

		// Token: 0x040005CE RID: 1486
		private int x;

		// Token: 0x040005CF RID: 1487
		private int y;

		// Token: 0x040005D0 RID: 1488
		private int z;

		// Token: 0x040005D1 RID: 1489
		private int int_1;

		// Token: 0x040005D2 RID: 1490
		private int int_2;
	}
}
