using System;
using NBTModel.Interop;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;

// Token: 0x02000088 RID: 136
[Serializable]
internal class Class25
{
	// Token: 0x060005E2 RID: 1506 RVA: 0x00005499 File Offset: 0x00003699
	public Class25()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0002A304 File Offset: 0x00028504
	public Class25(ChunkLayer chunkLayer_0)
	{
		this.int_0 = chunkLayer_0.Layer;
		this.block_0 = chunkLayer_0.Blocks;
		this.byte_0 = this.method_0(chunkLayer_0.TileEntities);
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000054B1 File Offset: 0x000036B1
	// (set) Token: 0x060005E5 RID: 1509 RVA: 0x000054B9 File Offset: 0x000036B9
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

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000054C2 File Offset: 0x000036C2
	// (set) Token: 0x060005E7 RID: 1511 RVA: 0x000054CA File Offset: 0x000036CA
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

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000054D3 File Offset: 0x000036D3
	// (set) Token: 0x060005E9 RID: 1513 RVA: 0x000054DB File Offset: 0x000036DB
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

	// Token: 0x060005EA RID: 1514 RVA: 0x000054E4 File Offset: 0x000036E4
	private byte[] method_0(TagNodeList tagNodeList_0)
	{
		return NbtClipboardData.SerializeNode(tagNodeList_0);
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0002A354 File Offset: 0x00028554
	public ChunkLayer method_1()
	{
		ChunkLayer chunkLayer = new ChunkLayer();
		chunkLayer.Layer = this.int_0;
		chunkLayer.Blocks = this.block_0;
		TagNode tagNode = NbtClipboardData.DeserializeNode(this.TileEntities);
		chunkLayer.TileEntities = (tagNode as TagNodeList);
		return chunkLayer;
	}

	// Token: 0x040003CC RID: 972
	private int int_0;

	// Token: 0x040003CD RID: 973
	private Block[] block_0 = new Block[256];

	// Token: 0x040003CE RID: 974
	private byte[] byte_0;
}
