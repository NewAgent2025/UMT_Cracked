using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.Properties;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000085 RID: 133
	public class MapBlocks
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		public void MapRegion(object threadContext)
		{
			this.mapBlockParameter_0 = (threadContext as MapBlockParameter);
			this.bitmap_0 = new Bitmap(this.int_0, this.int_0);
			this.bitmap_1 = new Bitmap(this.int_0, this.int_0);
			this.bitmap_2 = new Bitmap(this.int_0, this.int_0);
			this.method_1(this.mapBlockParameter_0.Dimension, this.mapBlockParameter_0.Region, this.mapBlockParameter_0.OutFolderPath);
			this.mapBlockParameter_0.BlockImage = this.bitmap_0;
			this.mapBlockParameter_0.BiomeImage = this.bitmap_1;
			this.mapBlockParameter_0.HeightImage = this.bitmap_2;
			this.mapBlockParameter_0.Completed = true;
			this.mapBlockParameter_0.DoneEvent.Set();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0002CA78 File Offset: 0x0002AC78
		private void method_0(string string_0, string string_1, string string_2)
		{
			string string_3 = string.Concat(new string[]
			{
				string_2,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(string_0),
				string_1,
				".mcr"
			});
			byte[] array = FileUtils.smethod_0(string_3);
			List<ChunkIndexEntry> list = Class46.smethod_7(array.Take(4096).ToArray<byte>());
			MemoryStream memoryStream_ = new MemoryStream(array);
			if (list != null && list.Count > 0)
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (MapBlocks.func_0 == null)
				{
					MapBlocks.func_0 = new Func<ChunkIndexEntry, int>(MapBlocks.smethod_0);
				}
				list = source.OrderBy(MapBlocks.func_0).ToList<ChunkIndexEntry>();
				List<int> list2 = Class23.smethod_1()[string_0][string_1];
				for (int i = 0; i < list2.Count; i++)
				{
					ChunkIndexEntry chunkIndexEntry = list[list2[i]];
					if (chunkIndexEntry.OldChunkOffset > 0U)
					{
						byte[] array2 = Class46.smethod_50(chunkIndexEntry, memoryStream_);
						if (array2[0] == 10)
						{
							TagNodeCompound tagNodeCompound_ = Class46.smethod_34(array2);
							this.method_2(tagNodeCompound_, string_0, string_1, chunkIndexEntry);
						}
						else
						{
							MemoryStream stream = Class46.smethod_69(array2);
							TU17Parser tu17Parser = new TU17Parser();
							TU17ChunkData tu17ChunkData_ = tu17Parser.ParseChunk(stream);
							this.nbRsVyciha(tu17ChunkData_, string_0, string_1, chunkIndexEntry);
						}
					}
					if (this.mapBlockParameter_0 != null)
					{
						this.mapBlockParameter_0.ChunkProcessedCount++;
					}
				}
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		private void method_1(string string_0, string string_1, string string_2)
		{
			string text = string.Concat(new string[]
			{
				string_2,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(string_0),
				string_1,
				".mcr"
			});
			List<ChunkIndexEntry> list = Class46.smethod_5(text);
			if (list != null && list.Count > 0)
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (MapBlocks.func_1 == null)
				{
					MapBlocks.func_1 = new Func<ChunkIndexEntry, int>(MapBlocks.smethod_1);
				}
				list = source.OrderBy(MapBlocks.func_1).ToList<ChunkIndexEntry>();
				using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
				{
					List<int> list2 = Class23.smethod_1()[string_0][string_1];
					for (int i = 0; i < list2.Count; i++)
					{
						ChunkIndexEntry chunkIndexEntry = list[list2[i]];
						if (chunkIndexEntry.OldChunkOffset > 0U)
						{
							byte[] array = Class46.smethod_51(chunkIndexEntry, binaryReader);
							if (array[0] == 10)
							{
								TagNodeCompound tagNodeCompound_ = Class46.smethod_34(array);
								this.method_2(tagNodeCompound_, string_0, string_1, chunkIndexEntry);
							}
							else if (array[1] <= 11)
							{
								MemoryStream stream = Class46.smethod_69(array);
								TU17Parser tu17Parser = new TU17Parser();
								TU17ChunkData tu17ChunkData_ = tu17Parser.ParseChunk(stream);
								this.nbRsVyciha(tu17ChunkData_, string_0, string_1, chunkIndexEntry);
							}
							else
							{
								MemoryStream stream2 = Class46.smethod_69(array);
								AquaticParser aquaticParser = new AquaticParser();
								AquaticChunkData aquaticChunkData_ = aquaticParser.ParseChunk(stream2);
								this.method_3(aquaticChunkData_, string_0, string_1, chunkIndexEntry);
							}
						}
						if (this.mapBlockParameter_0 != null)
						{
							this.mapBlockParameter_0.ChunkProcessedCount++;
						}
					}
				}
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002CD74 File Offset: 0x0002AF74
		private void method_2(TagNodeCompound tagNodeCompound_0, string string_0, string string_1, ChunkIndexEntry chunkIndexEntry_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeCompound tagNodeCompound = tagNodeCompound_0["Level"] as TagNodeCompound;
			TagNodeByteArray tagNodeByteArray = tagNodeCompound["Blocks"] as TagNodeByteArray;
			TagNodeByteArray b = tagNodeCompound["Data"] as TagNodeByteArray;
			TagNodeByteArray tagNodeByteArray2 = tagNodeCompound["HeightMap"] as TagNodeByteArray;
			TagNodeByteArray tagNodeByteArray3 = new TagNodeByteArray(new byte[256]);
			if (tagNodeCompound.ContainsKey("Biomes"))
			{
				tagNodeByteArray3 = (tagNodeCompound["Biomes"] as TagNodeByteArray);
			}
			int num = (TagNodeInt)tagNodeCompound["xPos"];
			int num2 = (TagNodeInt)tagNodeCompound["zPos"];
			int num3 = (num >= 0) ? (num * 16) : ((num + 1) * 16);
			int num4 = (num2 >= 0) ? (num2 * 16) : ((num2 + 1) * 16);
			int length = tagNodeByteArray.Length;
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num5 = (int)tagNodeByteArray2[j * 16 + i];
					int offset;
					int num7;
					byte b2;
					do
					{
						int num6 = (num5 > 127) ? 32768 : 0;
						offset = num6 / 2;
						num7 = 0;
						int index = i << 11 | j << 7 | num5 + 0 + num6;
						b2 = tagNodeByteArray[index];
						num5--;
					}
					while (num5 >= 0 && Constants.transparentBlocks.Contains((int)b2));
					if (num5 < 0)
					{
						num5 = 0;
					}
					int data = nibbleSetters.RegionGet(b, i, num5 + (num7 << 4), j, offset);
					int level = num5 / 64;
					Color color = this.mapConverterII_0.BlockToColor((int)b2, data, level);
					int num8 = num3 + ((num >= 0) ? i : ((16 - i) * -1));
					int num9 = num4 + ((num2 >= 0) ? j : ((16 - j) * -1));
					if (num8 < 0)
					{
						num8 = this.int_0 + num8;
					}
					if (num9 < 0)
					{
						num9 = this.int_0 + num9;
					}
					this.bitmap_0.SetPixel(num8, num9, color);
				}
			}
			this.method_4(tagNodeByteArray3.Data, num, num2);
			this.method_5(tagNodeByteArray2.Data, num, num2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		private void nbRsVyciha(TU17ChunkData tu17ChunkData_0, string string_0, string string_1, ChunkIndexEntry chunkIndexEntry_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			byte[] blocks = tu17ChunkData_0.Blocks;
			byte[] blockData = tu17ChunkData_0.BlockData;
			byte[] heightMap = tu17ChunkData_0.HeightMap;
			int x = tu17ChunkData_0.X;
			int z = tu17ChunkData_0.Z;
			int num = (x >= 0) ? (x * 16) : ((x + 1) * 16);
			int num2 = (z >= 0) ? (z * 16) : ((z + 1) * 16);
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num3 = (int)heightMap[j * 16 + i];
					int num4;
					byte b;
					do
					{
						num4 = num3 * 256 + i * 16 + j;
						b = blocks[num4];
						num3--;
					}
					while (num3 >= 0 && Constants.transparentBlocks.Contains((int)b));
					if (num3 < 0)
					{
					}
					int data = nibbleSetters.method_0(blockData, num4);
					Color color = this.mapConverterII_0.BlockToColor((int)b, data, 2);
					int num5 = num + ((x >= 0) ? i : ((16 - i) * -1));
					int num6 = num2 + ((z >= 0) ? j : ((16 - j) * -1));
					if (num5 < 0)
					{
						num5 = this.int_0 + num5;
					}
					if (num6 < 0)
					{
						num6 = this.int_0 + num6;
					}
					this.bitmap_0.SetPixel(num5, num6, color);
				}
			}
			this.method_4(tu17ChunkData_0.Biomes, x, z);
			this.method_5(tu17ChunkData_0.HeightMap, x, z);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0002D140 File Offset: 0x0002B340
		private void method_3(AquaticChunkData aquaticChunkData_0, string string_0, string string_1, ChunkIndexEntry chunkIndexEntry_0)
		{
			new NibbleSetters();
			byte[] blocks = aquaticChunkData_0.Blocks;
			byte[] heightMap = aquaticChunkData_0.HeightMap;
			int x = aquaticChunkData_0.X;
			int z = aquaticChunkData_0.Z;
			int num = (x >= 0) ? (x * 16) : ((x + 1) * 16);
			int num2 = (z >= 0) ? (z * 16) : ((z + 1) * 16);
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num3 = (int)heightMap[j * 16 + i];
					int num5;
					int data;
					do
					{
						int num4 = num3 * 2 + i * 8192 + j * 512;
						num5 = ((int)blocks[num4 + 1] << 4) + ((blocks[num4] & 240) >> 4);
						data = (int)(blocks[num4] & 15);
						if (num5 > 255)
						{
							num5 = 7;
						}
						num3--;
					}
					while (num3 >= 0 && Constants.transparentBlocks.Contains(num5));
					if (num3 < 0)
					{
					}
					Color color = this.mapConverterII_0.BlockToColor(num5, data, 2);
					int num6 = num + ((x >= 0) ? i : ((16 - i) * -1));
					int num7 = num2 + ((z >= 0) ? j : ((16 - j) * -1));
					if (num6 < 0)
					{
						num6 = this.int_0 + num6;
					}
					if (num7 < 0)
					{
						num7 = this.int_0 + num7;
					}
					this.bitmap_0.SetPixel(num6, num7, color);
				}
			}
			this.method_4(aquaticChunkData_0.Biomes, x, z);
			this.method_5(aquaticChunkData_0.HeightMap, x, z);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		private void method_4(byte[] byte_0, int int_1, int int_2)
		{
			int num = (int_1 >= 0) ? (int_1 * 16) : ((int_1 + 1) * 16);
			int num2 = (int_2 >= 0) ? (int_2 * 16) : ((int_2 + 1) * 16);
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num3 = j * 16 + i;
					int argb = 0;
					if (Constants.consoleBiomeList.ContainsKey((int)byte_0[num3]))
					{
						argb = (int)(4278190080L + (long)Constants.consoleBiomeList[(int)byte_0[num3]].Color);
					}
					Color color = Color.FromArgb(argb);
					int num4 = num + ((int_1 >= 0) ? i : ((16 - i) * -1));
					int num5 = num2 + ((int_2 >= 0) ? j : ((16 - j) * -1));
					if (num4 < 0)
					{
						num4 = this.int_0 + num4;
					}
					if (num5 < 0)
					{
						num5 = this.int_0 + num5;
					}
					this.bitmap_1.SetPixel(num4, num5, color);
				}
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		private void method_5(byte[] byte_0, int int_1, int int_2)
		{
			int num = (int_1 >= 0) ? (int_1 * 16) : ((int_1 + 1) * 16);
			int num2 = (int_2 >= 0) ? (int_2 * 16) : ((int_2 + 1) * 16);
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num3 = j * 16 + i;
					int num4 = (int)byte_0[num3];
					if (Settings.Default.HeightView == "light")
					{
						num4 = 255 - num4;
					}
					Color color = Color.FromArgb(num4, num4, num4);
					int num5 = num + ((int_1 >= 0) ? i : ((16 - i) * -1));
					int num6 = num2 + ((int_2 >= 0) ? j : ((16 - j) * -1));
					if (num5 < 0)
					{
						num5 = this.int_0 + num5;
					}
					if (num6 < 0)
					{
						num6 = this.int_0 + num6;
					}
					this.bitmap_2.SetPixel(num5, num6, color);
				}
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_0(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_1(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x0400036F RID: 879
		private int int_0 = 512;

		// Token: 0x04000370 RID: 880
		private MapConverterII mapConverterII_0 = new MapConverterII();

		// Token: 0x04000371 RID: 881
		private MapBlockParameter mapBlockParameter_0;

		// Token: 0x04000372 RID: 882
		private Bitmap bitmap_0;

		// Token: 0x04000373 RID: 883
		private Bitmap bitmap_1;

		// Token: 0x04000374 RID: 884
		private Bitmap bitmap_2;

		// Token: 0x04000375 RID: 885
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;

		// Token: 0x04000376 RID: 886
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_1;
	}
}
