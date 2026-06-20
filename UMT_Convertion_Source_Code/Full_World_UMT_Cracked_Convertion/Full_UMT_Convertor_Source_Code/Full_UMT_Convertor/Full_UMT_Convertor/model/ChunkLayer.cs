using System;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C6 RID: 198
	[Serializable]
	public class ChunkLayer
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x00046BF8 File Offset: 0x00044DF8
		public ChunkLayer()
		{
			for (int i = 0; i < 256; i++)
			{
				this.block_0[i] = new Block();
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000063F3 File Offset: 0x000045F3
		public ChunkLayer(int level) : this()
		{
			this.level = level;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00006402 File Offset: 0x00004602
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x0000640A File Offset: 0x0000460A
		public int Layer
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00006413 File Offset: 0x00004613
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x0000641B File Offset: 0x0000461B
		internal Block[] Blocks
		{
			get
			{
				return this.block_0;
			}
			set
			{
				this.block_0 = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00006424 File Offset: 0x00004624
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x0000642C File Offset: 0x0000462C
		public TagNodeList TileEntities
		{
			get
			{
				return this.tagNodeList_0;
			}
			set
			{
				this.tagNodeList_0 = value;
			}
		}

		// Token: 0x040005D3 RID: 1491
		private int level;

		// Token: 0x040005D4 RID: 1492
		private Block[] block_0 = new Block[256];

		// Token: 0x040005D5 RID: 1493
		private TagNodeList tagNodeList_0 = new TagNodeList(TagType.TAG_COMPOUND);
	}
}
