using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C9 RID: 201
	public class EntitySearchResult
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x00002591 File Offset: 0x00000791
		public EntitySearchResult()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00046CC8 File Offset: 0x00044EC8
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00006503 File Offset: 0x00004703
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x0000650B File Offset: 0x0000470B
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00006514 File Offset: 0x00004714
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x0000651C File Offset: 0x0000471C
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00006525 File Offset: 0x00004725
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x0000652D File Offset: 0x0000472D
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00006536 File Offset: 0x00004736
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0000653E File Offset: 0x0000473E
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00006547 File Offset: 0x00004747
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0000654F File Offset: 0x0000474F
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00006558 File Offset: 0x00004758
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00006560 File Offset: 0x00004760
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00006569 File Offset: 0x00004769
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00006571 File Offset: 0x00004771
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0000657A File Offset: 0x0000477A
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00006582 File Offset: 0x00004782
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0000658B File Offset: 0x0000478B
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00006593 File Offset: 0x00004793
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0000659C File Offset: 0x0000479C
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x000065A4 File Offset: 0x000047A4
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x000065AD File Offset: 0x000047AD
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x000065B5 File Offset: 0x000047B5
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

		// Token: 0x060008A2 RID: 2210 RVA: 0x00046D30 File Offset: 0x00044F30
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

		// Token: 0x060008A3 RID: 2211 RVA: 0x00046D98 File Offset: 0x00044F98
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

		// Token: 0x060008A4 RID: 2212 RVA: 0x00046DF4 File Offset: 0x00044FF4
		public EntitySearchResult Copy()
		{
			return new EntitySearchResult
			{
				Dimension = this.dimension,
				Region = this.region,
				ChunkIndex = this.chunkIndex,
				ChunkX = this.chunkX,
				ChunkZ = this.chunkZ,
				X = this.x,
				Y = this.y,
				Z = this.z,
				EntityId = this.entityId,
				EntityType = this.entityType,
				Parent = this.parent
			};
		}

		// Token: 0x040005DE RID: 1502
		private string dimension;

		// Token: 0x040005DF RID: 1503
		private string region;

		// Token: 0x040005E0 RID: 1504
		private ChunkIndexEntry chunkIndex;

		// Token: 0x040005E1 RID: 1505
		private int chunkX;

		// Token: 0x040005E2 RID: 1506
		private int chunkZ;

		// Token: 0x040005E3 RID: 1507
		private int x;

		// Token: 0x040005E4 RID: 1508
		private int y;

		// Token: 0x040005E5 RID: 1509
		private int z;

		// Token: 0x040005E6 RID: 1510
		private string entityId;

		// Token: 0x040005E7 RID: 1511
		private EntityType entityType;

		// Token: 0x040005E8 RID: 1512
		private string parent;
	}
}
