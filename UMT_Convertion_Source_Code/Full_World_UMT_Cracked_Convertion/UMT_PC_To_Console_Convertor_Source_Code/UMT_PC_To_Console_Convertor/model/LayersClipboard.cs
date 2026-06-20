using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class LayersClipboard
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x000024C1 File Offset: 0x000006C1
		public LayersClipboard()
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0002A398 File Offset: 0x00028598
		public LayersClipboard(ChunkLayer[] layers)
		{
			this.class25_0 = new Class25[layers.Length];
			for (int i = 0; i < layers.Length; i++)
			{
				this.class25_0[i] = new Class25(layers[i]);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0002A3D8 File Offset: 0x000285D8
		public ChunkLayer[] ToChunkLayers()
		{
			ChunkLayer[] array = new ChunkLayer[this.class25_0.Length];
			for (int i = 0; i < this.class25_0.Length; i++)
			{
				array[i] = this.class25_0[i].method_1();
			}
			return array;
		}

		// Token: 0x040003CF RID: 975
		private Class25[] class25_0;
	}
}
