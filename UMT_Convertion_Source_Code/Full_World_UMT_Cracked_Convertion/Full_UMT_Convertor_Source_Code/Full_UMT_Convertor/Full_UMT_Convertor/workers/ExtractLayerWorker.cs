using System;
using System.Collections.Generic;
using System.Linq;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.workers
{
	// Token: 0x02000152 RID: 338
	public class ExtractLayerWorker
	{
		// Token: 0x06000E3B RID: 3643 RVA: 0x0005E4A8 File Offset: 0x0005C6A8
		public List<ChunkLayer> ExtractLayers(byte[] srcBlocks, byte[] srcData)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			ChunkLayer[] array = new ChunkLayer[256];
			for (int i = 0; i < 256; i++)
			{
				ChunkLayer chunkLayer = new ChunkLayer();
				chunkLayer.Layer = i;
				array[i] = chunkLayer;
				int num = (i < 128) ? 0 : 32768;
				int offset = num / 2;
				int num2 = (i < 128) ? i : (i - 128);
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						int num3 = j * 16 + k;
						int num4 = j << 11 | k << 7 | num2 + num;
						byte id = srcBlocks[num4];
						int data = nibbleSetters.RegionGet(srcData, j, num2, k, offset);
						chunkLayer.Blocks[num3].Id = (int)id;
						chunkLayer.Blocks[num3].Data = data;
					}
				}
			}
			return array.ToList<ChunkLayer>();
		}
	}
}
