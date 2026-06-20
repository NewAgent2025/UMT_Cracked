using System;
using Full_UMT_Convertor.model;
using NBTModel.Interop;
using Substrate.Nbt;

// Token: 0x020000CA RID: 202
[Serializable]
internal class Class30
{
	// Token: 0x060008A5 RID: 2213 RVA: 0x000065BE File Offset: 0x000047BE
	public Class30()
	{
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00046E8C File Offset: 0x0004508C
	public Class30(ChunkLayer chunkLayer_0)
	{
		this.int_0 = chunkLayer_0.Layer;
		this.block_0 = chunkLayer_0.Blocks;
		this.byte_0 = this.method_0(chunkLayer_0.TileEntities);
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000065D6 File Offset: 0x000047D6
	// (set) Token: 0x060008A8 RID: 2216 RVA: 0x000065DE File Offset: 0x000047DE
	public int Layer
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000065E7 File Offset: 0x000047E7
	// (set) Token: 0x060008AA RID: 2218 RVA: 0x000065EF File Offset: 0x000047EF
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

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x060008AB RID: 2219 RVA: 0x000065F8 File Offset: 0x000047F8
	// (set) Token: 0x060008AC RID: 2220 RVA: 0x00006600 File Offset: 0x00004800
	public byte[] TileEntities
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

	// Token: 0x060008AD RID: 2221 RVA: 0x00006609 File Offset: 0x00004809
	private byte[] method_0(TagNodeList tagNodeList_0)
	{
		return NbtClipboardData.SerializeNode(tagNodeList_0);
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00046EDC File Offset: 0x000450DC
	public ChunkLayer method_1()
	{
		ChunkLayer chunkLayer = new ChunkLayer();
		chunkLayer.Layer = this.int_0;
		chunkLayer.Blocks = this.block_0;
		TagNode tagNode = NbtClipboardData.DeserializeNode(this.TileEntities);
		chunkLayer.TileEntities = (tagNode as TagNodeList);
		return chunkLayer;
	}

	// Token: 0x040005E9 RID: 1513
	private int int_0;

	// Token: 0x040005EA RID: 1514
	private Block[] block_0 = new Block[256];

	// Token: 0x040005EB RID: 1515
	private byte[] byte_0;
}
