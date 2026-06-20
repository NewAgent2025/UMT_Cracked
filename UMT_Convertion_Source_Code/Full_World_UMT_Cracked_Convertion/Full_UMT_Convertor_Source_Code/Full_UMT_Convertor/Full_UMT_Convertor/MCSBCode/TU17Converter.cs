using System;
using System.IO;
using System.Linq;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000137 RID: 311
	public class TU17Converter
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x0005A048 File Offset: 0x00058248
		public MemoryStream ConvertToTU17(TagNodeCompound inChunk)
		{
			if (!inChunk.ContainsKey("Level"))
			{
				return null;
			}
			NibbleSetters nibbleSetters = new NibbleSetters();
			TagNodeCompound tagNodeCompound = inChunk["Level"] as TagNodeCompound;
			int x = (TagNodeInt)tagNodeCompound["xPos"];
			int z = (TagNodeInt)tagNodeCompound["zPos"];
			TagNodeByteArray tagNodeByteArray = tagNodeCompound["Blocks"] as TagNodeByteArray;
			TagNodeByteArray b = tagNodeCompound["Data"] as TagNodeByteArray;
			TagNodeByteArray b2 = tagNodeCompound["BlockLight"] as TagNodeByteArray;
			TagNodeByteArray b3 = tagNodeCompound["SkyLight"] as TagNodeByteArray;
			byte[] array = new byte[65536];
			byte[] array2 = new byte[32768];
			byte[] array3 = new byte[32768];
			byte[] array4 = new byte[32768];
			for (int i = 0; i < 2; i++)
			{
				int num = (i == 0) ? 0 : 32768;
				for (int j = 0; j < 256; j++)
				{
					for (int k = 0; k < 128; k++)
					{
						int num2 = j * 128 + k;
						int num3 = k * 256 + j;
						array[num3 + num] = tagNodeByteArray[num2 + num];
						int val = nibbleSetters.method_0(b, num2 + num);
						int val2 = nibbleSetters.method_0(b2, num2 + num);
						int val3 = nibbleSetters.method_0(b3, num2 + num);
						nibbleSetters.method_1(array2, num3 + num, val);
						nibbleSetters.method_1(array3, num3 + num, val2);
						nibbleSetters.method_1(array4, num3 + num, val3);
					}
				}
			}
			byte[] data = ((TagNodeByteArray)tagNodeCompound["HeightMap"]).Data;
			byte[] data2 = ((TagNodeByteArray)tagNodeCompound["Biomes"]).Data;
			TagNodeList value = tagNodeCompound.ContainsKey("Entities") ? (tagNodeCompound["Entities"].Copy() as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeList value2 = tagNodeCompound.ContainsKey("TileEntities") ? (tagNodeCompound["TileEntities"].Copy() as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeList value3 = new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeCompound tagNodeCompound2 = new TagNodeCompound();
			tagNodeCompound2.Add("Entities", value);
			tagNodeCompound2.Add("TileEntities", value2);
			tagNodeCompound2.Add("TileTicks", value3);
			TU17ChunkData tu17ChunkData = new TU17ChunkData();
			tu17ChunkData.Blocks = array;
			tu17ChunkData.BlockData = array2;
			tu17ChunkData.BlockLight = array3;
			tu17ChunkData.SkyLight = array4;
			tu17ChunkData.HeightMap = data;
			tu17ChunkData.Biomes = data2;
			tu17ChunkData.X = x;
			tu17ChunkData.Z = z;
			tu17ChunkData.NBTData = tagNodeCompound2;
			if (Working.WorldVersionMinor == 8)
			{
				tu17ChunkData.TU17VersionType_0 = TU17VersionType.VERSION_8;
			}
			if (Working.WorldVersionMinor == 9)
			{
				tu17ChunkData.TU17VersionType_0 = TU17VersionType.VERSION_9;
			}
			if (Working.WorldVersionMinor == 10)
			{
				tu17ChunkData.TU17VersionType_0 = TU17VersionType.VERSION_10;
			}
			if (Working.WorldVersionMinor == 11)
			{
				tu17ChunkData.TU17VersionType_0 = TU17VersionType.VERSION_11;
			}
			TU17Builder tu17Builder = new TU17Builder();
			return tu17Builder.BuildChunk(tu17ChunkData);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0005A3B0 File Offset: 0x000585B0
		public TagNodeCompound ConvertFromTU17(MemoryStream stream)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			TU17Parser tu17Parser = new TU17Parser();
			tu17Parser.ParseChunk(stream);
			TU17ChunkData tu17ChunkData_ = tu17Parser.TU17ChunkData_0;
			int x = tu17ChunkData_.X;
			int z = tu17ChunkData_.Z;
			byte[] array = new byte[65536];
			byte[] array2 = new byte[32768];
			byte[] array3 = new byte[32768];
			byte[] array4 = new byte[32768];
			for (int i = 0; i < 2; i++)
			{
				int num = (i == 0) ? 0 : 32768;
				for (int j = 0; j < 256; j++)
				{
					for (int k = 0; k < 128; k++)
					{
						int num2 = k * 256 + j;
						int num3 = j * 128 + k;
						array[num3 + num] = tu17ChunkData_.Blocks[num2 + num];
						int val = nibbleSetters.method_0(tu17ChunkData_.BlockData, num2 + num);
						int val2 = nibbleSetters.method_0(tu17ChunkData_.BlockLight, num2 + num);
						int val3 = nibbleSetters.method_0(tu17ChunkData_.SkyLight, num2 + num);
						nibbleSetters.method_1(array2, num3 + num, val);
						nibbleSetters.method_1(array3, num3 + num, val2);
						nibbleSetters.method_1(array4, num3 + num, val3);
					}
				}
			}
			TagNodeList value = tu17ChunkData_.NBTData.ContainsKey("Entities") ? (tu17ChunkData_.NBTData["Entities"].Copy() as TagNodeList) : new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeList value2 = tu17ChunkData_.NBTData["TileEntities"].Copy() as TagNodeList;
			TagNodeList value3 = new TagNodeList(TagType.TAG_COMPOUND);
			TagNodeByteArray value4 = new TagNodeByteArray(tu17ChunkData_.HeightMap.ToArray<byte>());
			TagNodeByteArray value5 = new TagNodeByteArray(tu17ChunkData_.Biomes.ToArray<byte>());
			TagNodeCompound tagNodeCompound = new TagNodeCompound();
			tagNodeCompound.Add("Blocks", new TagNodeByteArray(array));
			tagNodeCompound.Add("LastUpdate", new TagNodeLong(12944574L));
			tagNodeCompound.Add("xPos", new TagNodeInt(x));
			tagNodeCompound.Add("Data", new TagNodeByteArray(array2));
			tagNodeCompound.Add("zPos", new TagNodeInt(z));
			tagNodeCompound.Add("HeightMap", value4);
			tagNodeCompound.Add("InhabitedTime", new TagNodeLong(0L));
			tagNodeCompound.Add("BlockLight", new TagNodeByteArray(array3));
			tagNodeCompound.Add("SkyLight", new TagNodeByteArray(array4));
			tagNodeCompound.Add("TerrainPopulatedFlags", new TagNodeShort(2046));
			tagNodeCompound.Add("Biomes", value5);
			tagNodeCompound.Add("Entities", value);
			tagNodeCompound.Add("TileEntities", value2);
			tagNodeCompound.Add("TileTicks", value3);
			return new NbtTree
			{
				Root = 
				{
					{
						"Level",
						tagNodeCompound
					}
				}
			}.Root;
		}
	}
}
