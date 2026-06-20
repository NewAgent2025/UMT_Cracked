using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200009D RID: 157
	public class ChunkIndexEntry
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00005E95 File Offset: 0x00004095
		public ChunkIndexEntry(int chunkIndex, uint ChunkOffset, byte ChunkLength)
		{
			this.chunkIndex = chunkIndex;
			this.ChunkOffset = ChunkOffset;
			this.ChunkLength = ChunkLength;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00005EB2 File Offset: 0x000040B2
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00005EBA File Offset: 0x000040BA
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00005EC3 File Offset: 0x000040C3
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00005ECB File Offset: 0x000040CB
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00005ED4 File Offset: 0x000040D4
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00005EDC File Offset: 0x000040DC
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00005EE5 File Offset: 0x000040E5
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00005EED File Offset: 0x000040ED
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00005EF6 File Offset: 0x000040F6
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00005EFE File Offset: 0x000040FE
		public byte NewChunkLength
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x04000442 RID: 1090
		private int chunkIndex;

		// Token: 0x04000443 RID: 1091
		private uint ChunkOffset;

		// Token: 0x04000444 RID: 1092
		private byte ChunkLength;

		// Token: 0x04000445 RID: 1093
		private uint uint_0;

		// Token: 0x04000446 RID: 1094
		private byte byte_0;
	}
}
