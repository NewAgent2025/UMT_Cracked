using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using MCPELevelDBI.workers;
using Substrate.Nbt;

namespace Full_UMT_Convertor.PECode
{
	// Token: 0x0200012A RID: 298
	public class PEUtility
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x00056BE8 File Offset: 0x00054DE8
		public static LevelDBWorker OpenDBWorker(string path)
		{
			LevelDBWorker levelDBWorker = new LevelDBWorker();
			levelDBWorker.OpenDB(Path.Combine(path, "db"), false);
			return levelDBWorker;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00056C10 File Offset: 0x00054E10
		public static byte[] BuildChunkKey(int dim, int x, int z, byte dataType, byte? subchunk = null)
		{
			MemoryStream memoryStream = new MemoryStream();
			Class47 @class = new Class47(false);
			@class.method_10(x, memoryStream);
			@class.method_10(z, memoryStream);
			if (dim != 0)
			{
				@class.method_10(dim, memoryStream);
			}
			memoryStream.WriteByte(dataType);
			if (subchunk != null)
			{
				memoryStream.WriteByte(subchunk.Value);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00056C68 File Offset: 0x00054E68
		public static TagNodeCompound smethod_0(string levelPath)
		{
			byte[] buffer = FileUtils.smethod_0(Path.Combine(levelPath, "level.dat"));
			MemoryStream s = new MemoryStream(buffer);
			NbtTree.IsFileBigEndian = false;
			NbtTree nbtTree = new NbtTree(s);
			NbtTree.IsFileBigEndian = true;
			return nbtTree.Root;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00056CA8 File Offset: 0x00054EA8
		public static TagNodeCompound LoadPELevelRaw(string levelPath)
		{
			byte[] array = FileUtils.smethod_0(Path.Combine(levelPath, "level.dat"));
			array = array.Skip(8).ToArray<byte>();
			MemoryStream s = new MemoryStream(array);
			NbtTree.IsFileBigEndian = false;
			NbtTree nbtTree = new NbtTree(s);
			NbtTree.IsFileBigEndian = true;
			return nbtTree.Root;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00056CF4 File Offset: 0x00054EF4
		public static void smethod_1(TagNodeCompound level, string levelPath)
		{
			NbtTree nbtTree = new NbtTree(level);
			nbtTree.UseBigEndian = false;
			MemoryStream memoryStream = new MemoryStream();
			nbtTree.WriteTo(memoryStream);
			byte[] array = memoryStream.ToArray();
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(levelPath, FileMode.Create)))
			{
				binaryWriter.Write(array, 0, array.Length);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00056D58 File Offset: 0x00054F58
		public static TagNodeCompound LoadConsoleLevel(string path)
		{
			byte[] buffer = FileUtils.smethod_0(Path.Combine(path, "level.dat"));
			MemoryStream s = new MemoryStream(buffer);
			NbtTree nbtTree = new NbtTree(s);
			return nbtTree.Root;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00056D8C File Offset: 0x00054F8C
		public static void ChangeLevelName(string levelName, string levelPath)
		{
			TagNodeCompound tagNodeCompound = PEUtility.smethod_0(levelPath);
			if (tagNodeCompound != null)
			{
				tagNodeCompound["LevelName"] = new TagNodeString(levelName);
				long d = Utils.DateTimeToUnixTimestamp() / 1000L;
				tagNodeCompound["LastPlayed"] = new TagNodeLong(d);
				string string_ = Path.Combine(levelPath, "level.dat");
				Class46.smethod_44(tagNodeCompound, string_);
			}
			File.WriteAllText(Path.Combine(levelPath, "levelname.txt"), levelName);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00056DFC File Offset: 0x00054FFC
		public static string GetNameFromId(int id)
		{
			string text = "";
			if (Class42.smethod_0().ContainsKey(id))
			{
				text = Class42.smethod_0()[id].Name;
			}
			else if (Class42.smethod_2().ContainsKey(id))
			{
				text = Class42.smethod_2()[id].Name;
			}
			return text.Replace("minecraft:", "");
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00056E60 File Offset: 0x00055060
		public static PEDimension GetPEDimension(string dimension)
		{
			PEDimension result = null;
			if (dimension == "region")
			{
				result = Working.PEDimensions[0];
			}
			else if (dimension == "DIM-1")
			{
				result = Working.PEDimensions[1];
			}
			else if (dimension == "DIM1")
			{
				result = Working.PEDimensions[2];
			}
			return result;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00056EC0 File Offset: 0x000550C0
		public static void RemovePEDimensionRegion(string dimension, string region)
		{
			PEDimension pedimension = null;
			if (dimension == "region")
			{
				pedimension = Working.PEDimensions[0];
			}
			else if (dimension == "DIM-1")
			{
				pedimension = Working.PEDimensions[1];
			}
			else if (dimension == "DIM1")
			{
				pedimension = Working.PEDimensions[2];
			}
			if (pedimension != null)
			{
				pedimension.Region.Remove(region.Remove(0, 2));
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00056F38 File Offset: 0x00055138
		public static void ConvertIDsToPC(TagNodeList entityList)
		{
			for (int i = 0; i < entityList.Count; i++)
			{
				string text = "";
				TagNodeCompound tagNodeCompound = entityList[i] as TagNodeCompound;
				if (tagNodeCompound.ContainsKey("id"))
				{
					if (tagNodeCompound["id"] is TagNodeInt)
					{
						int key = tagNodeCompound["id"] as TagNodeInt;
						if (Class42.smethod_0().ContainsKey(key))
						{
							text = Class42.smethod_0()[key].Name;
						}
						else if (Class42.smethod_2().ContainsKey(key))
						{
							text = Class42.smethod_2()[key].Name;
						}
					}
					else if (tagNodeCompound["id"] is TagNodeString)
					{
						text = (tagNodeCompound["id"] as TagNodeString);
					}
					text = text.Replace("minecraft:", "");
					if (!string.IsNullOrWhiteSpace(text))
					{
						tagNodeCompound["id"] = new TagNodeString(text);
					}
				}
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00057040 File Offset: 0x00055240
		public static void ConvertIDsToPE(TagNodeList entityList)
		{
			for (int i = entityList.Count - 1; i >= 0; i--)
			{
				TagNodeCompound tagNodeCompound = entityList[i] as TagNodeCompound;
				if (tagNodeCompound.ContainsKey("id") && tagNodeCompound["id"] is TagNodeString)
				{
					string text = tagNodeCompound["id"] as TagNodeString;
					text = "minecraft:" + text;
					if (Class42.smethod_4().ContainsKey(text))
					{
						int d = Class42.smethod_4()[text].method_2();
						tagNodeCompound["id"] = new TagNodeInt(d);
					}
					else
					{
						entityList.Remove(tagNodeCompound);
					}
				}
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000570EC File Offset: 0x000552EC
		public static uint ReadWord(byte[] peSection, int index)
		{
			byte[] array = new byte[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = peSection[index + i];
			}
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00057120 File Offset: 0x00055320
		public static TagNodeList ReadPaletteEntries(byte[] PaletteData, out int bytesRead)
		{
			Class47 @class = new Class47();
			@class.method_1(false);
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			MemoryStream memoryStream = new MemoryStream(PaletteData);
			int num = @class.method_4(memoryStream);
			for (int i = 0; i < num; i++)
			{
				NbtTree nbtTree = new NbtTree(memoryStream);
				nbtTree.UseBigEndian = false;
				if (nbtTree.Root != null)
				{
					tagNodeList.Add(nbtTree.Root);
				}
			}
			bytesRead = (int)memoryStream.Position;
			return tagNodeList;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00057194 File Offset: 0x00055394
		public static void WritePaletteEntries(MemoryStream stream, TagNodeList paletteList)
		{
			Class47 @class = new Class47();
			@class.method_1(false);
			@class.method_10(paletteList.Count, stream);
			for (int i = 0; i < paletteList.Count; i++)
			{
				MemoryStream memoryStream = new MemoryStream();
				TagNodeCompound tree = paletteList[i] as TagNodeCompound;
				new NbtTree(tree)
				{
					UseBigEndian = false
				}.WriteTo(memoryStream);
				stream.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0005720C File Offset: 0x0005540C
		public static BlockState[] GetBlockStatesFromPalette(TagNodeList PaletteEntries)
		{
			BlockState[] array = new BlockState[PaletteEntries.Count];
			for (int i = 0; i < PaletteEntries.Count; i++)
			{
				string name = (TagNodeString)((TagNodeCompound)PaletteEntries[i])["name"];
				short val = (TagNodeShort)((TagNodeCompound)PaletteEntries[i])["val"];
				array[i] = BlockMaster.GetBedrockBlockState(name, val);
			}
			return array;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00057284 File Offset: 0x00055484
		public static int PaletteBitsPerBlock(int paletteCount)
		{
			int result = 0;
			if (paletteCount <= 2)
			{
				result = 1;
			}
			else if (paletteCount <= 4)
			{
				result = 2;
			}
			else if (paletteCount <= 8)
			{
				result = 3;
			}
			else if (paletteCount <= 16)
			{
				result = 4;
			}
			else if (paletteCount <= 32)
			{
				result = 5;
			}
			else if (paletteCount <= 64)
			{
				result = 6;
			}
			else if (paletteCount <= 256)
			{
				result = 8;
			}
			else if (paletteCount <= 65023)
			{
				result = 16;
			}
			return result;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000572E0 File Offset: 0x000554E0
		public static TagNodeList BuildNBTPalette(Dictionary<string, Dictionary<short, BlockState>> paletteEntries)
		{
			List<BlockState> list = new List<BlockState>();
			foreach (string key in paletteEntries.Keys)
			{
				foreach (short key2 in paletteEntries[key].Keys)
				{
					list.Add(paletteEntries[key][key2]);
				}
			}
			IEnumerable<BlockState> source = list;
			if (PEUtility.func_0 == null)
			{
				PEUtility.func_0 = new Func<BlockState, int>(PEUtility.smethod_2);
			}
			list = source.OrderBy(PEUtility.func_0).ToList<BlockState>();
			return PEUtility.BuildNBTPalette(list);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000573B8 File Offset: 0x000555B8
		public static TagNodeList BuildNBTPalette(List<BlockState> paletteEntries)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			foreach (BlockState blockState in paletteEntries)
			{
				TagNodeCompound tagNodeCompound = new TagNodeCompound();
				tagNodeCompound["name"] = new TagNodeString(blockState.name);
				tagNodeCompound["val"] = new TagNodeShort(blockState.data);
				tagNodeList.Add(tagNodeCompound);
			}
			return tagNodeList;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00010490 File Offset: 0x0000E690
		public static byte[] BuildBlockStateChunk(TagNodeCompound node)
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
				MemoryStream memoryStream = new MemoryStream();
				int num5 = 0;
				for (int j = 0; j < num3; j++)
				{
					uint num6 = 0U;
					List<int> list = new List<int>();
					int num7 = 0;
					while (num7 < num2 && num5 < 4096)
					{
						list.Add(data[num5]);
						num5++;
						num7++;
					}
					for (int k = list.Count - 1; k >= 0; k--)
					{
						num6 <<= num;
						int num8 = list[k];
						num6 |= (uint)(num8 & num4);
					}
					byte[] bytes = BitConverter.GetBytes(num6);
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

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00057444 File Offset: 0x00055644
		public static TagNodeList BlockStorageSection(byte[] peSection)
		{
			int num = 1;
			int num2 = 1;
			if (peSection[0] == 8)
			{
				num = (int)peSection[1];
				num2++;
			}
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = 0; i < num; i++)
			{
				int[] array = new int[4096];
				num2 = PEUtility.ProcessBlockStorage(peSection, array, num2);
				int num3 = 0;
				byte[] paletteData = peSection.Skip(num2).Take(peSection.Length - num2).ToArray<byte>();
				TagNodeList value = PEUtility.ReadPaletteEntries(paletteData, out num3);
				num2 += num3;
				TagNodeCompound tagNodeCompound = new TagNodeCompound();
				tagNodeCompound["BlockStates"] = new TagNodeIntArray(array);
				tagNodeCompound["Palette"] = value;
				tagNodeList.Add(tagNodeCompound);
			}
			return tagNodeList;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000574F8 File Offset: 0x000556F8
		public static int ProcessBlockStorage(byte[] peSection, int[] blocks, int readPosition)
		{
			new TagNodeCompound();
			int num = peSection[readPosition] >> 1;
			readPosition++;
			int num2 = (int)Math.Floor(32 / num);
			int num3 = (int)Math.Ceiling(4096.0 / (double)num2);
			uint num4 = (1U << num) - 1U;
			int num5 = 0;
			for (int i = 0; i < num3; i++)
			{
				uint num6 = PEUtility.ReadWord(peSection, readPosition);
				int num7 = 0;
				while (num7 < num2 && num5 < 4096)
				{
					int num8 = (int)(num6 >> num7 * num & num4);
					int num9 = num5 >> 8 & 15;
					int num10 = num5 & 15;
					int num11 = num5 >> 4 & 15;
					int num12 = num10 * 256 + num11 * 16 + num9;
					blocks[num12] = num8;
					num5++;
					num7++;
				}
				readPosition += 4;
			}
			return readPosition;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000575C8 File Offset: 0x000557C8
		public static TagNodeList ExtractTileEntities(byte[] BlockEntity)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			try
			{
				if (BlockEntity != null)
				{
					MemoryStream memoryStream = new MemoryStream(BlockEntity);
					while (memoryStream.Position < memoryStream.Length)
					{
						NbtTree nbtTree = new NbtTree(memoryStream);
						nbtTree.UseBigEndian = false;
						if (nbtTree.Root != null)
						{
							tagNodeList.Add(nbtTree.Root);
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return tagNodeList;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00008841 File Offset: 0x00006A41
		[CompilerGenerated]
		private static int smethod_2(BlockState blockState_0)
		{
			return blockState_0.paletteIndex;
		}

		// Token: 0x040007EA RID: 2026
		[CompilerGenerated]
		private static Func<BlockState, int> func_0;
	}
}
