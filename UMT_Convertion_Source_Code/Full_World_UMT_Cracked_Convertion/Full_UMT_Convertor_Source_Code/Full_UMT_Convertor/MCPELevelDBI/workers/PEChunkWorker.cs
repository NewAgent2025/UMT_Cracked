using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace MCPELevelDBI.workers
{
	// Token: 0x02000133 RID: 307
	public class PEChunkWorker
	{
		// Token: 0x06000CF1 RID: 3313 RVA: 0x00058C20 File Offset: 0x00056E20
		public void WriteModifiedChunk(int dimension, TagNodeCompound aChunk, int worldHeight, LevelDBWorker dbWorker)
		{
			new NibbleSetters();
			TagNodeCompound tagNodeCompound = aChunk["Level"] as TagNodeCompound;
			this.levelDBWorker_0 = dbWorker;
			int int_ = (TagNodeInt)tagNodeCompound["xPos"];
			int int_2 = (TagNodeInt)tagNodeCompound["zPos"];
			TagNodeByteArray b = tagNodeCompound["Biomes"] as TagNodeByteArray;
			TagNodeIntArray i = tagNodeCompound["HeightMap"] as TagNodeIntArray;
			this.method_5(dimension, int_, int_2);
			this.method_0(dimension, int_, int_2, b, i);
			TagNodeList tagNodeList_ = tagNodeCompound["TileEntities"] as TagNodeList;
			this.method_1(dimension, int_, int_2, tagNodeList_);
			TagNodeList tagNodeList_2 = tagNodeCompound["Entities"] as TagNodeList;
			this.method_2(dimension, int_, int_2, tagNodeList_2);
			TagNodeList tagNodeList_3 = tagNodeCompound["Sections"] as TagNodeList;
			this.method_3(dimension, int_, int_2, tagNodeList_3);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00058D14 File Offset: 0x00056F14
		private void method_0(int int_0, int int_1, int int_2, byte[] byte_0, int[] int_3)
		{
			Class47 @class = new Class47(false);
			byte[] array = new byte[256];
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num = j << 4 | i;
					int num2 = j << 4 | i;
					array[num2] = byte_0[num];
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			for (int k = 0; k < 256; k++)
			{
				@class.method_9((short)int_3[k], memoryStream);
			}
			memoryStream.Write(array, 0, array.Length);
			byte[] byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 45, null);
			this.method_7(byte_, memoryStream.ToArray());
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00058DC0 File Offset: 0x00056FC0
		private void method_1(int int_0, int int_1, int int_2, TagNodeList tagNodeList_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			for (int i = 0; i < tagNodeList_0.Count; i++)
			{
				MemoryStream memoryStream2 = new MemoryStream();
				TagNodeCompound tree = tagNodeList_0[i] as TagNodeCompound;
				NbtTree nbtTree = new NbtTree(tree);
				nbtTree.WriteTo(memoryStream2);
				memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			}
			if (memoryStream.Length > 0L)
			{
				byte[] byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 49, null);
				this.method_7(byte_, memoryStream.ToArray());
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00058E54 File Offset: 0x00057054
		private void method_2(int int_0, int int_1, int int_2, TagNodeList tagNodeList_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			for (int i = 0; i < tagNodeList_0.Count; i++)
			{
				MemoryStream memoryStream2 = new MemoryStream();
				TagNodeCompound tree = tagNodeList_0[i] as TagNodeCompound;
				NbtTree nbtTree = new NbtTree(tree);
				nbtTree.WriteTo(memoryStream2);
				memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			}
			if (memoryStream.Length > 0L)
			{
				byte[] byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 50, null);
				this.method_7(byte_, memoryStream.ToArray());
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00058EE8 File Offset: 0x000570E8
		private void method_3(int int_0, int int_1, int int_2, TagNodeList tagNodeList_0)
		{
			Dictionary<int, TagNodeCompound> dictionary = new Dictionary<int, TagNodeCompound>();
			int num = 0;
			for (int i = 0; i < tagNodeList_0.Count; i++)
			{
				TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
				byte b = tagNodeCompound["Y"] as TagNodeByte;
				dictionary.Add((int)b, tagNodeCompound);
				if ((int)b > num)
				{
					num = (int)b;
				}
			}
			byte b2 = 0;
			while ((int)b2 <= num)
			{
				byte[] array;
				if (dictionary.ContainsKey((int)b2))
				{
					TagNodeCompound tagNodeCompound2 = dictionary[(int)b2];
					if (tagNodeCompound2.ContainsKey("Blocks"))
					{
						array = this.method_4(tagNodeCompound2);
					}
					else
					{
						array = this.BuildBlockStateChunk(tagNodeCompound2);
					}
				}
				else
				{
					array = this.method_6();
				}
				if (array != null && array.Length > 0)
				{
					byte[] byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 47, new byte?(b2));
					this.method_7(byte_, array);
				}
				b2 += 1;
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00058FC4 File Offset: 0x000571C4
		private byte[] method_4(TagNodeCompound tagNodeCompound_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			tagNodeCompound_0["Y"] as TagNodeByte;
			byte[] array = new byte[4096];
			byte[] array2 = new byte[2048];
			byte[] array3 = tagNodeCompound_0["Blocks"] as TagNodeByteArray;
			byte[] data = tagNodeCompound_0["Data"] as TagNodeByteArray;
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						int num = i * 256 + j * 16 + k;
						int num2 = k * 256 + j * 16 + i;
						byte b = array3[num2];
						int val = nibbleSetters.method_0(data, num2);
						array[num] = b;
						nibbleSetters.method_1(array2, num, val);
					}
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.WriteByte(0);
			memoryStream.Write(array, 0, array.Length);
			memoryStream.Write(array2, 0, array2.Length);
			return memoryStream.ToArray();
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000590DC File Offset: 0x000572DC
		public byte[] BuildBlockStateChunk(TagNodeCompound node)
		{
			BlockStateLayer[] array = new BlockStateLayer[2];
			if (!node.ContainsKey("BlockStorage") || !(node["BlockStorage"] is TagNodeList))
			{
				return null;
			}
			TagNodeList tagNodeList = node["BlockStorage"] as TagNodeList;
			int count = tagNodeList.Count;
			for (int i = 0; i < count; i++)
			{
				TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
				int count2 = ((TagNodeList)tagNodeCompound["Palette"]).Count;
				int num = PEUtility.PaletteBitsPerBlock(count2);
				int num2 = (int)Math.Floor(32 / num);
				int num3 = (int)Math.Ceiling(4096.0 / (double)num2);
				int num4 = (1 << num) - 1;
				int[] data = ((TagNodeIntArray)tagNodeCompound["BlockStates"]).Data;
				int[] array2 = new int[4096];
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						for (int l = 0; l < 16; l++)
						{
							int num5 = j * 256 + k * 16 + l;
							int num6 = l * 256 + k * 16 + j;
							int num7 = data[num6];
							array2[num5] = num7;
						}
					}
				}
				MemoryStream memoryStream = new MemoryStream();
				int num8 = 0;
				for (int m = 0; m < num3; m++)
				{
					uint num9 = 0U;
					List<int> list = new List<int>();
					int num10 = 0;
					while (num10 < num2 && num8 < 4096)
					{
						list.Add(array2[num8]);
						num8++;
						num10++;
					}
					for (int n = list.Count - 1; n >= 0; n--)
					{
						num9 <<= num;
						int num11 = list[n];
						num9 |= (uint)(num11 & num4);
					}
					byte[] bytes = BitConverter.GetBytes(num9);
					memoryStream.Write(bytes, 0, bytes.Length);
				}
				array[i] = new BlockStateLayer
				{
					bitsPerBlock = num,
					blocks = memoryStream.ToArray(),
					palette = (TagNodeList)tagNodeCompound["Palette"]
				};
			}
			MemoryStream memoryStream2 = new MemoryStream();
			memoryStream2.WriteByte(8);
			memoryStream2.WriteByte((byte)count);
			memoryStream2.WriteByte((byte)(array[0].bitsPerBlock << 1));
			memoryStream2.Write(array[0].blocks, 0, array[0].blocks.Length);
			PEUtility.WritePaletteEntries(memoryStream2, array[0].palette);
			if (count == 2)
			{
				memoryStream2.WriteByte((byte)(array[1].bitsPerBlock << 1));
				memoryStream2.Write(array[1].blocks, 0, array[1].blocks.Length);
				PEUtility.WritePaletteEntries(memoryStream2, array[1].palette);
			}
			return memoryStream2.ToArray();
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000593AC File Offset: 0x000575AC
		private void method_5(int int_0, int int_1, int int_2)
		{
			byte[] byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 48, null);
			this.method_8(byte_);
			byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 49, null);
			this.method_8(byte_);
			byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 50, null);
			this.method_8(byte_);
			for (byte b = 0; b < 16; b += 1)
			{
				byte_ = PEUtility.BuildChunkKey(int_0, int_1, int_2, 47, new byte?(b));
				this.method_8(byte_);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00059434 File Offset: 0x00057634
		private byte[] method_6()
		{
			return new byte[10241];
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00008A1F File Offset: 0x00006C1F
		private void method_7(byte[] byte_0, byte[] byte_1)
		{
			this.levelDBWorker_0.Put(byte_0, byte_1);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00008A2E File Offset: 0x00006C2E
		private void method_8(byte[] byte_0)
		{
			this.levelDBWorker_0.Delete(byte_0);
		}

		// Token: 0x040007FE RID: 2046
		private LevelDBWorker levelDBWorker_0;
	}
}
