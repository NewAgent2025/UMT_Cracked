using System;
using Substrate.Nbt;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000084 RID: 132
	[Serializable]
	public class ChunkLayer
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x0002A108 File Offset: 0x00028308
		public ChunkLayer()
		{
			for (int i = 0; i < 256; i++)
			{
				this.block_0[i] = new Block();
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000052F0 File Offset: 0x000034F0
		public ChunkLayer(int level) : this()
		{
			this.pvLgvTpem5 = level;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000052FF File Offset: 0x000034FF
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00005307 File Offset: 0x00003507
		public int Layer
		{
			get
			{
				return this.pvLgvTpem5;
			}
			set
			{
				this.pvLgvTpem5 = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00005310 File Offset: 0x00003510
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00005318 File Offset: 0x00003518
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00005321 File Offset: 0x00003521
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00005329 File Offset: 0x00003529
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

		// Token: 0x040003B8 RID: 952
		private int pvLgvTpem5;

		// Token: 0x040003B9 RID: 953
		private Block[] block_0 = new Block[256];

		// Token: 0x040003BA RID: 954
		private TagNodeList tagNodeList_0 = new TagNodeList(TagType.TAG_COMPOUND);
	}
}
