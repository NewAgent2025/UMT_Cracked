using System;
using System.IO;
using Full_UMT_Convertor.model;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode.Workers
{
	// Token: 0x0200009B RID: 155
	public class PartialChunkWorker
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x0003C890 File Offset: 0x0003AA90
		public byte[] RebuildPartialChunk(TagNodeCompound partial, byte[] origChunk, ChunkData chunkData)
		{
			byte[] byte_ = Class46.smethod_69(origChunk).ToArray();
			MemoryStream memoryStream = new MemoryStream();
			NbtTree nbtTree = new NbtTree(partial);
			nbtTree.ChildrenWriteTo(memoryStream);
			byte[] byte_2 = memoryStream.ToArray();
			byte[] array = this.method_0(chunkData, byte_2, byte_);
			chunkData.NewFileSize = array.Length;
			memoryStream = Class46.smethod_70(array);
			return memoryStream.ToArray();
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0003C8E8 File Offset: 0x0003AAE8
		private byte[] method_0(ChunkData chunkData_0, byte[] byte_0, byte[] byte_1)
		{
			int num = (Working.WorldVersionMinor <= 7) ? 2 : 1;
			int[] array = byte_1.smethod_0(Constants.entitiesSearchBytes);
			int[] array2 = byte_1.smethod_0(Constants.TileEntitiesSearchBytes);
			int num2 = 0;
			if (array2.Length > 0)
			{
				num2 = array2[0];
			}
			if (array.Length > 0 && array[0] > 0 && (array[0] < num2 || num2 == 0))
			{
				num2 = array[0];
			}
			if (num2 > 0)
			{
				byte[] array3;
				byte[] array4;
				Class46.smethod_22<byte>(byte_1, num2, out array3, out array4);
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(array3, 0, array3.Length);
				memoryStream.Write(byte_0, 0, byte_0.Length);
				for (int i = 0; i < num; i++)
				{
					memoryStream.WriteByte(0);
				}
				byte_1 = memoryStream.ToArray();
			}
			return byte_1;
		}
	}
}
