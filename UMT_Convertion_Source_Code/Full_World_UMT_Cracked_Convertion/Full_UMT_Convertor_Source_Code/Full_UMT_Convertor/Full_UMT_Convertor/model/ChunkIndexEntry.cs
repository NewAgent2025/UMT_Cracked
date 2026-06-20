using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000E1 RID: 225
	public class ChunkIndexEntry
	{
		// Token: 0x060009DC RID: 2524 RVA: 0x000070D1 File Offset: 0x000052D1
		public ChunkIndexEntry(int chunkIndex, uint ChunkOffset, byte ChunkLength)
		{
			this.chunkIndex = chunkIndex;
			this.ChunkOffset = ChunkOffset;
			this.ChunkLength = ChunkLength;
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x000070EE File Offset: 0x000052EE
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x000070F6 File Offset: 0x000052F6
		public int ChunkIndex
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000070FF File Offset: 0x000052FF
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00007107 File Offset: 0x00005307
		public uint OldChunkOffset
		{
			get
			{
				return this.ChunkOffset;
			}
			set
			{
				this.ChunkOffset = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00007118 File Offset: 0x00005318
		public byte OldChunkLength
		{
			get
			{
				return this.ChunkLength;
			}
			set
			{
				this.ChunkLength = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00007121 File Offset: 0x00005321
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00007129 File Offset: 0x00005329
		public uint NewChunkOffset
		{
			get
			{
				return this.uint_0;
			}
			set
			{
				this.uint_0 = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00007132 File Offset: 0x00005332
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x0000713A File Offset: 0x0000533A
		public byte NewChunkLength
		{
			get
			{
				return this.yMiHeqvPvsr;
			}
			set
			{
				this.yMiHeqvPvsr = value;
			}
		}

		// Token: 0x04000678 RID: 1656
		private int chunkIndex;

		// Token: 0x04000679 RID: 1657
		private uint ChunkOffset;

		// Token: 0x0400067A RID: 1658
		private byte ChunkLength;

		// Token: 0x0400067B RID: 1659
		private uint uint_0;

		// Token: 0x0400067C RID: 1660
		private byte yMiHeqvPvsr;
	}
}
