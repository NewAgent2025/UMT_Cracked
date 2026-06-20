using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ionic.Zlib;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.MCSBCode;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

// Token: 0x020000C6 RID: 198
internal class Class36
{
	// Token: 0x0600083D RID: 2109 RVA: 0x00030C84 File Offset: 0x0002EE84
	public static List<IndexEntry> smethod_0(BinaryReader binaryReader_0)
	{
		IndexOffsetData indexOffsetData_ = Class36.smethod_1(binaryReader_0);
		return Class36.smethod_2(binaryReader_0, indexOffsetData_);
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00030CA8 File Offset: 0x0002EEA8
	private static IndexOffsetData smethod_1(BinaryReader binaryReader_0)
	{
		IndexOffsetData indexOffsetData = new IndexOffsetData();
		binaryReader_0.BaseStream.Seek(0L, SeekOrigin.Begin);
		indexOffsetData.IndexOffset = FileUtils.smethod_6(binaryReader_0, FileUtils.ByteOrder.BigEndian);
		indexOffsetData.FileCount = FileUtils.smethod_6(binaryReader_0, FileUtils.ByteOrder.BigEndian);
		return indexOffsetData;
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00030CEC File Offset: 0x0002EEEC
	private static List<IndexEntry> smethod_2(BinaryReader binaryReader_0, IndexOffsetData indexOffsetData_0)
	{
		List<IndexEntry> list = new List<IndexEntry>();
		long num = binaryReader_0.BaseStream.Length - (long)((ulong)indexOffsetData_0.IndexOffset);
		int num2 = (int)(num / 144L);
		if ((long)num2 == (long)((ulong)indexOffsetData_0.FileCount))
		{
			binaryReader_0.BaseStream.Seek((long)((ulong)indexOffsetData_0.IndexOffset), SeekOrigin.Begin);
			for (int i = 0; i < num2; i++)
			{
				IndexEntry item = Class36.smethod_3(binaryReader_0);
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00030D5C File Offset: 0x0002EF5C
	private static IndexEntry smethod_3(BinaryReader binaryReader_0)
	{
		byte[] array = new byte[144];
		for (int i = 0; i < 144; i++)
		{
			array[i] = binaryReader_0.ReadByte();
		}
		return new IndexEntry(array);
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00030D98 File Offset: 0x0002EF98
	public static List<ChunkIndexEntry> smethod_4(string string_0)
	{
		List<ChunkIndexEntry> result = null;
		if (File.Exists(string_0))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				if (binaryReader.BaseStream.Length >= 4096L)
				{
					result = Class36.smethod_5(binaryReader);
				}
			}
		}
		return result;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00030DF8 File Offset: 0x0002EFF8
	private static List<ChunkIndexEntry> smethod_5(BinaryReader binaryReader_0)
	{
		List<ChunkIndexEntry> list = new List<ChunkIndexEntry>();
		for (int i = 0; i < 1024; i++)
		{
			uint chunkOffset = Class36.smethod_7(binaryReader_0.ReadBytes(3));
			byte chunkLength = binaryReader_0.ReadByte();
			list.Add(new ChunkIndexEntry(i, chunkOffset, chunkLength));
		}
		return list;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00030E40 File Offset: 0x0002F040
	public static List<ChunkIndexEntry> smethod_6()
	{
		List<ChunkIndexEntry> list = new List<ChunkIndexEntry>();
		for (int i = 0; i < 1024; i++)
		{
			list.Add(new ChunkIndexEntry(i, 0U, 0));
		}
		return list;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00030E74 File Offset: 0x0002F074
	private static uint smethod_7(byte[] byte_0)
	{
		byte[] array = new byte[]
		{
			0,
			0,
			0,
			0
		};
		array[2] = byte_0[0];
		array[1] = byte_0[1];
		array[0] = byte_0[2];
		return BitConverter.ToUInt32(array, 0);
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00030EA8 File Offset: 0x0002F0A8
	public static byte[] smethod_8(string string_0, ChunkIndexEntry chunkIndexEntry_0)
	{
		byte[] result = null;
		using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
		{
			result = Class36.smethod_9(binaryReader, chunkIndexEntry_0);
		}
		return result;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00030EEC File Offset: 0x0002F0EC
	public static byte[] smethod_9(BinaryReader binaryReader_0, ChunkIndexEntry chunkIndexEntry_0)
	{
		byte[] array = new byte[(int)chunkIndexEntry_0.OldChunkLength * 4096];
		binaryReader_0.BaseStream.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		binaryReader_0.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00030F34 File Offset: 0x0002F134
	public static byte[] smethod_10(byte[] byte_0, ChunkIndexEntry chunkIndexEntry_0)
	{
		int num = (int)chunkIndexEntry_0.OldChunkLength * 4096;
		uint srcOffset = chunkIndexEntry_0.OldChunkOffset * 4096U;
		byte[] array = new byte[num];
		Buffer.BlockCopy(byte_0, (int)srcOffset, array, 0, num);
		return array;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00030F70 File Offset: 0x0002F170
	public static void smethod_11(byte[] byte_0, ChunkIndexEntry chunkIndexEntry_0, BinaryWriter binaryWriter_0)
	{
		if (byte_0 == null || byte_0.Length <= 0)
		{
			MessageBox.Show("Chunk size zero", "Chunk Error");
			return;
		}
		long num = (long)((byte_0.Length % 4096 != 0) ? (4096 - byte_0.Length % 4096) : 0);
		chunkIndexEntry_0.NewChunkOffset = (uint)(binaryWriter_0.BaseStream.Position / 4096L);
		chunkIndexEntry_0.NewChunkLength = (byte)(((long)byte_0.Length + num) / 4096L);
		binaryWriter_0.Write(byte_0, 0, byte_0.Length);
		int num2 = 0;
		while ((long)num2 < num)
		{
			binaryWriter_0.Write(0);
			num2++;
		}
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0003100C File Offset: 0x0002F20C
	public static void smethod_12(byte[] byte_0, ChunkIndexEntry chunkIndexEntry_0, MemoryStream memoryStream_0)
	{
		if (byte_0 == null || byte_0.Length <= 0)
		{
			MessageBox.Show("Chunk size zero", "Chunk Error");
			return;
		}
		long num = (long)((byte_0.Length % 4096 != 0) ? (4096 - byte_0.Length % 4096) : 0);
		chunkIndexEntry_0.NewChunkOffset = (uint)(memoryStream_0.Position / 4096L);
		chunkIndexEntry_0.NewChunkLength = (byte)(((long)byte_0.Length + num) / 4096L);
		memoryStream_0.Write(byte_0, 0, byte_0.Length);
		int num2 = 0;
		while ((long)num2 < num)
		{
			memoryStream_0.WriteByte(0);
			num2++;
		}
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x000310A4 File Offset: 0x0002F2A4
	public static int smethod_13(int int_0, int int_1)
	{
		int num = 4 * (int_0 % 32 + int_1 % 32 * 32);
		if (num < 0)
		{
			num += 32;
		}
		return num;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x000310CC File Offset: 0x0002F2CC
	public static uint smethod_14(List<ChunkIndexEntry> list_0, int int_0, int int_1)
	{
		uint result = 0U;
		if (list_0 != null)
		{
			ChunkIndexEntry chunkIndexEntry = list_0[int_0 + int_1 * 32];
			if (chunkIndexEntry != null)
			{
				result = list_0[int_0 + int_1 * 32].OldChunkOffset;
			}
		}
		return result;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x000069C1 File Offset: 0x00004BC1
	public static bool smethod_15(List<ChunkIndexEntry> list_0, int int_0, int int_1)
	{
		return Class36.smethod_14(list_0, int_0, int_1) != 0U;
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x000069D1 File Offset: 0x00004BD1
	public static ChunkIndexEntry smethod_16(List<ChunkIndexEntry> list_0, int int_0, int int_1)
	{
		if (list_0 == null || list_0.Count < int_0 + int_1 * 32)
		{
			return null;
		}
		return list_0[int_0 + int_1 * 32];
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x000069F2 File Offset: 0x00004BF2
	public static void smethod_17<T>(T[] gparam_0, int int_0, out T[] gparam_1, out T[] gparam_2)
	{
		gparam_1 = gparam_0.Take(int_0).ToArray<T>();
		gparam_2 = gparam_0.Skip(int_0).ToArray<T>();
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00031104 File Offset: 0x0002F304
	internal static string smethod_18(BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Seek(8L, SeekOrigin.Begin);
		short num = FileUtils.ReadShort(binaryReader_0);
		short num2 = FileUtils.ReadShort(binaryReader_0);
		Working.WorldVersionMajor = num2;
		Working.WorldVersionMinor = num;
		return string.Format(" V:{0}.{1}", num2, num);
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00031158 File Offset: 0x0002F358
	public static void smethod_19(string string_0)
	{
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
		{
			Class36.smethod_20(binaryWriter);
		}
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00031194 File Offset: 0x0002F394
	public static void smethod_20(BinaryWriter binaryWriter_0)
	{
		byte value = 0;
		for (int i = 0; i < 8192; i++)
		{
			binaryWriter_0.Write(value);
		}
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x000311BC File Offset: 0x0002F3BC
	public static void smethod_21(MemoryStream memoryStream_0)
	{
		byte value = 0;
		for (int i = 0; i < 8192; i++)
		{
			memoryStream_0.WriteByte(value);
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x000311E4 File Offset: 0x0002F3E4
	public static void smethod_22(int int_0, byte[] byte_0)
	{
		byte[] array = Class36.smethod_25(int_0);
		byte_0[0] = 128;
		byte_0[1] = array[1];
		byte_0[2] = array[2];
		byte_0[3] = array[3];
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00031214 File Offset: 0x0002F414
	public static void smethod_23(int int_0, byte[] byte_0)
	{
		byte[] array = Class36.smethod_25(int_0);
		byte_0[4] = array[0];
		byte_0[5] = array[1];
		byte_0[6] = array[2];
		byte_0[7] = array[3];
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00031240 File Offset: 0x0002F440
	public static void smethod_24(int int_0, byte[] byte_0)
	{
		byte[] array = Class36.smethod_25(int_0);
		byte_0[8] = array[0];
		byte_0[9] = array[1];
		byte_0[10] = array[2];
		byte_0[11] = array[3];
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00031270 File Offset: 0x0002F470
	public static byte[] smethod_25(int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00031294 File Offset: 0x0002F494
	public static void smethod_26(BinaryWriter binaryWriter_0, List<ChunkIndexEntry> list_0)
	{
		binaryWriter_0.BaseStream.Seek(0L, SeekOrigin.Begin);
		IEnumerable<ChunkIndexEntry> source = list_0;
		if (Class36.func_0 == null)
		{
			Class36.func_0 = new Func<ChunkIndexEntry, int>(Class36.smethod_65);
		}
		list_0 = source.OrderBy(Class36.func_0).ToList<ChunkIndexEntry>();
		foreach (ChunkIndexEntry chunkIndexEntry in list_0)
		{
			uint newChunkOffset = chunkIndexEntry.NewChunkOffset;
			binaryWriter_0.Write((byte)((newChunkOffset & 16711680U) >> 16));
			binaryWriter_0.Write((byte)((newChunkOffset & 65280U) >> 8));
			binaryWriter_0.Write((byte)(newChunkOffset & 255U));
			binaryWriter_0.Write(chunkIndexEntry.NewChunkLength);
		}
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00031360 File Offset: 0x0002F560
	public static void smethod_27(MemoryStream memoryStream_0, List<ChunkIndexEntry> list_0)
	{
		memoryStream_0.Seek(0L, SeekOrigin.Begin);
		IEnumerable<ChunkIndexEntry> source = list_0;
		if (Class36.func_1 == null)
		{
			Class36.func_1 = new Func<ChunkIndexEntry, int>(Class36.smethod_66);
		}
		list_0 = source.OrderBy(Class36.func_1).ToList<ChunkIndexEntry>();
		foreach (ChunkIndexEntry chunkIndexEntry in list_0)
		{
			uint newChunkOffset = chunkIndexEntry.NewChunkOffset;
			memoryStream_0.WriteByte((byte)((newChunkOffset & 16711680U) >> 16));
			memoryStream_0.WriteByte((byte)((newChunkOffset & 65280U) >> 8));
			memoryStream_0.WriteByte((byte)(newChunkOffset & 255U));
			memoryStream_0.WriteByte(chunkIndexEntry.NewChunkLength);
		}
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00031158 File Offset: 0x0002F358
	public static void smethod_28(string string_0)
	{
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
		{
			Class36.smethod_20(binaryWriter);
		}
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00031428 File Offset: 0x0002F628
	public static TagNodeCompound smethod_29(byte[] byte_0)
	{
		TagNodeCompound result = null;
		try
		{
			MemoryStream memoryStream = Class36.smethod_61(byte_0);
			memoryStream.Seek(0L, SeekOrigin.End);
			memoryStream.WriteByte(0);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			NbtTree nbtTree = new NbtTree(memoryStream);
			result = nbtTree.Root;
		}
		catch (Exception)
		{
		}
		return result;
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00006A10 File Offset: 0x00004C10
	public static bool smethod_30(int int_0)
	{
		return Constants.ENTITY_BLOCKS.ContainsKey(int_0);
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00006A1D File Offset: 0x00004C1D
	public static string smethod_31(int int_0)
	{
		if (Constants.ENTITY_BLOCKS.ContainsKey(int_0))
		{
			return Constants.ENTITY_BLOCKS[int_0];
		}
		return string.Empty;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0003148C File Offset: 0x0002F68C
	public static TagNodeCompound FDJFKWMKFG(TagNodeCompound tagNodeCompound_0, int int_0, int int_1, int int_2)
	{
		TagNodeCompound tagNodeCompound = tagNodeCompound_0;
		if (tagNodeCompound.ContainsKey("Level"))
		{
			tagNodeCompound = (tagNodeCompound_0["Level"] as TagNodeCompound);
		}
		if (tagNodeCompound.ContainsKey("TileEntities"))
		{
			TagNodeList tagNodeList_ = tagNodeCompound["TileEntities"] as TagNodeList;
			return Class36.smethod_32(tagNodeList_, int_0, int_1, int_2);
		}
		return null;
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x000314E4 File Offset: 0x0002F6E4
	public static TagNodeCompound smethod_32(TagNodeList tagNodeList_0, int int_0, int int_1, int int_2)
	{
		TagNodeCompound tagNodeCompound = Class36.smethod_33(tagNodeList_0, int_0, int_1, int_2);
		if (tagNodeCompound != null)
		{
			tagNodeList_0.Remove(tagNodeCompound);
		}
		return tagNodeCompound;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00031508 File Offset: 0x0002F708
	public static TagNodeCompound smethod_33(TagNodeList tagNodeList_0, int int_0, int int_1, int int_2)
	{
		for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
		{
			TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
			Class26 @class = Class36.smethod_40(tagNodeCompound);
			if (int_0 == @class.method_2() && int_1 == @class.Y && int_2 == @class.method_0())
			{
				return tagNodeCompound;
			}
		}
		return null;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0003155C File Offset: 0x0002F75C
	public static void smethod_34(int int_0, TagNodeList tagNodeList_0, int int_1, int int_2, int int_3, Dictionary<int, TagNodeCompound> dictionary_0)
	{
		if (tagNodeList_0.Count == 0 && tagNodeList_0.ValueType != TagType.TAG_COMPOUND)
		{
			tagNodeList_0.ChangeValueType(TagType.TAG_COMPOUND);
		}
		TagNodeCompound tagNodeCompound = null;
		if (dictionary_0 == null || !dictionary_0.ContainsKey(int_0))
		{
			if (Constants.entityDefaults.ContainsKey(int_0))
			{
				string string_ = Constants.entityDefaults[int_0];
				tagNodeCompound = (TagNodeCompound)Class36.smethod_36(string_);
				if (dictionary_0 != null)
				{
					dictionary_0[int_0] = tagNodeCompound;
				}
			}
		}
		else
		{
			tagNodeCompound = (dictionary_0[int_0].Copy() as TagNodeCompound);
		}
		if (tagNodeCompound != null)
		{
			Class36.smethod_39(tagNodeCompound, int_1, int_2, int_3);
			tagNodeList_0.Add(tagNodeCompound);
		}
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x000315F8 File Offset: 0x0002F7F8
	public static string smethod_35(string string_0, TagNode tagNode_0)
	{
		NbtTree nbtTree = new NbtTree();
		nbtTree.Root.Add(string_0, tagNode_0);
		MemoryStream memoryStream = new MemoryStream();
		nbtTree.ChildrenWriteTo(memoryStream);
		byte[] array = memoryStream.ToArray();
		return "0a0001" + Utils.ConvertByteToHexString(array[0]) + Utils.ConvertByteArrayToHexString(array) + "00";
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0003164C File Offset: 0x0002F84C
	public static TagNode smethod_36(string string_0)
	{
		TagNode result = null;
		byte[] array = Utils.ConvertHexStringToByteArray(string_0);
		if (array != null && array.Length > 0)
		{
			NbtTree nbtTree = new NbtTree();
			using (MemoryStream memoryStream = new MemoryStream(array))
			{
				try
				{
					nbtTree.ReadFrom(memoryStream);
				}
				catch (Exception)
				{
				}
			}
			if (nbtTree != null && nbtTree.Root != null)
			{
				foreach (string key in nbtTree.Root.Keys)
				{
					TagNode tagNode = nbtTree.Root[key];
					if (tagNode != null)
					{
						if (tagNode is TagNodeCompound)
						{
							result = (tagNode as TagNodeCompound);
							break;
						}
						if (tagNode is TagNodeList)
						{
							result = (tagNode as TagNodeList);
							break;
						}
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00031734 File Offset: 0x0002F934
	public static TagNode smethod_37(string string_0)
	{
		byte[] array = Utils.ConvertHexStringToByteArray(string_0);
		TagNode result = null;
		if (array != null && array.Length > 0)
		{
			NbtTree nbtTree = new NbtTree();
			using (MemoryStream memoryStream = new MemoryStream(array))
			{
				try
				{
					nbtTree.ReadFrom(memoryStream);
					result = nbtTree.Root;
				}
				catch (Exception)
				{
				}
			}
		}
		return result;
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0003179C File Offset: 0x0002F99C
	public static void smethod_38(TagNodeCompound tagNodeCompound_0, string string_0)
	{
		NbtTree nbtTree = new NbtTree(tagNodeCompound_0);
		MemoryStream memoryStream = new MemoryStream();
		nbtTree.WriteTo(memoryStream);
		byte[] array = memoryStream.ToArray();
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
		{
			binaryWriter.Write(array, 0, array.Length);
		}
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00006A3D File Offset: 0x00004C3D
	public static void smethod_39(TagNodeCompound tagNodeCompound_0, int int_0, int int_1, int int_2)
	{
		if (tagNodeCompound_0 != null)
		{
			tagNodeCompound_0["x"] = new TagNodeInt(int_0);
			tagNodeCompound_0["y"] = new TagNodeInt(int_1);
			tagNodeCompound_0["z"] = new TagNodeInt(int_2);
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x000317F8 File Offset: 0x0002F9F8
	public static Class26 smethod_40(TagNodeCompound tagNodeCompound_0)
	{
		Class26 @class = new Class26();
		if (tagNodeCompound_0.ContainsKey("x") && tagNodeCompound_0.ContainsKey("y") && tagNodeCompound_0.ContainsKey("z"))
		{
			@class.method_3((TagNodeInt)tagNodeCompound_0["x"]);
			@class.Y = (TagNodeInt)tagNodeCompound_0["y"];
			@class.method_1((TagNodeInt)tagNodeCompound_0["z"]);
		}
		return @class;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00006A75 File Offset: 0x00004C75
	public static int smethod_41(int int_0)
	{
		return int_0 >> 4;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00031884 File Offset: 0x0002FA84
	public static byte[] smethod_42(ChunkIndexEntry chunkIndexEntry_0, byte[] byte_0)
	{
		byte[] result = null;
		MemoryStream stream_ = new MemoryStream(byte_0);
		if (Working.GameType == (Enum2)1)
		{
			result = Class36.smethod_46(chunkIndexEntry_0, stream_);
		}
		else if (Working.GameType == (Enum2)2)
		{
			result = Class36.smethod_49(chunkIndexEntry_0, stream_);
		}
		else if (Working.GameType == (Enum2)3)
		{
			result = Class36.smethod_52(chunkIndexEntry_0, stream_);
		}
		return result;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x000318D8 File Offset: 0x0002FAD8
	public static byte[] smethod_43(ChunkIndexEntry chunkIndexEntry_0, BinaryReader binaryReader_0)
	{
		byte[] result = null;
		if (Working.GameType == (Enum2)1)
		{
			result = Class36.smethod_45(chunkIndexEntry_0, binaryReader_0);
		}
		else if (Working.GameType == (Enum2)2)
		{
			result = Class36.smethod_48(chunkIndexEntry_0, binaryReader_0);
		}
		else if (Working.GameType == (Enum2)3)
		{
			result = Class36.smethod_51(chunkIndexEntry_0, binaryReader_0);
		}
		return result;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00031924 File Offset: 0x0002FB24
	public static byte[] smethod_44(ChunkIndexEntry chunkIndexEntry_0, string string_0)
	{
		byte[] result = null;
		if (chunkIndexEntry_0.OldChunkOffset > 0U)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				result = Class36.smethod_45(chunkIndexEntry_0, binaryReader);
			}
		}
		return result;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00006A7A File Offset: 0x00004C7A
	public static byte[] smethod_45(ChunkIndexEntry chunkIndexEntry_0, BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		return Class36.smethod_46(chunkIndexEntry_0, binaryReader_0.BaseStream);
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00031970 File Offset: 0x0002FB70
	public static byte[] smethod_46(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		XBOXCompression xboxcompression = new XBOXCompression();
		Class37 @class = new Class37();
		int num = @class.method_2(stream_0) & 16777215;
		int dsize = @class.method_2(stream_0);
		byte[] array = new byte[num];
		stream_0.Read(array, 0, array.Length);
		return xboxcompression.DoDecompress(array, dsize);
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x000319C4 File Offset: 0x0002FBC4
	public static byte[] smethod_47(ChunkIndexEntry chunkIndexEntry_0, string string_0)
	{
		byte[] result = null;
		if (chunkIndexEntry_0.OldChunkOffset > 0U)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				result = Class36.smethod_48(chunkIndexEntry_0, binaryReader);
			}
		}
		return result;
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00006AA0 File Offset: 0x00004CA0
	public static byte[] smethod_48(ChunkIndexEntry chunkIndexEntry_0, BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		return Class36.smethod_49(chunkIndexEntry_0, binaryReader_0.BaseStream);
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00031A10 File Offset: 0x0002FC10
	public static byte[] smethod_49(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		Class37 @class = new Class37();
		int num = @class.method_2(stream_0) & 16777215;
		@class.method_2(stream_0);
		@class.method_2(stream_0);
		byte[] array = new byte[num];
		stream_0.Read(array, 0, array.Length);
		return Class36.smethod_59(array);
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00031A5C File Offset: 0x0002FC5C
	public static byte[] smethod_50(ChunkIndexEntry chunkIndexEntry_0, string string_0)
	{
		byte[] result = null;
		if (chunkIndexEntry_0.OldChunkOffset > 0U)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				result = Class36.smethod_51(chunkIndexEntry_0, binaryReader);
			}
		}
		return result;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00006AC6 File Offset: 0x00004CC6
	public static byte[] smethod_51(ChunkIndexEntry chunkIndexEntry_0, BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		return Class36.smethod_52(chunkIndexEntry_0, binaryReader_0.BaseStream);
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00031AA8 File Offset: 0x0002FCA8
	public static byte[] smethod_52(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		Class37 @class = new Class37();
		int num = @class.method_2(stream_0) & 16777215;
		@class.method_2(stream_0);
		byte[] array = new byte[num];
		stream_0.Read(array, 0, array.Length);
		return Class36.smethod_56(array);
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00031AEC File Offset: 0x0002FCEC
	public static byte[] smethod_53(object object_0, ChunkData chunkData_0)
	{
		byte[] result = null;
		if (object_0 != null)
		{
			MemoryStream memoryStream;
			if (object_0 is TU17ChunkData)
			{
				TU17ChunkData tu17Data = object_0 as TU17ChunkData;
				TU17Builder tu17Builder = new TU17Builder();
				memoryStream = tu17Builder.BuildChunk(tu17Data);
			}
			else
			{
				TagNodeCompound tree = object_0 as TagNodeCompound;
				memoryStream = new MemoryStream();
				NbtTree nbtTree = new NbtTree(tree);
				nbtTree.WriteTo(memoryStream);
			}
			chunkData_0.NewFileSize = (int)memoryStream.Length;
			memoryStream = Class36.smethod_62(memoryStream.ToArray());
			result = Class36.smethod_54(memoryStream.ToArray(), chunkData_0);
		}
		return result;
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00031B68 File Offset: 0x0002FD68
	public static byte[] smethod_54(byte[] byte_0, ChunkData chunkData_0)
	{
		int int_ = byte_0.Length;
		byte[] array = null;
		if (Working.GameType == (Enum2)1)
		{
			XBOXCompression xboxcompression = new XBOXCompression();
			array = xboxcompression.DoCompress(byte_0, 8);
			Class36.smethod_22(array.Length - 8, array);
			Class36.smethod_23(chunkData_0.NewFileSize, array);
		}
		else if (Working.GameType == (Enum2)2)
		{
			array = Class36.smethod_58(byte_0);
			byte[] first = new byte[12];
			array = first.Concat(array).ToArray<byte>();
			Class36.smethod_22(array.Length - 8, array);
			Class36.smethod_23(chunkData_0.NewFileSize, array);
			Class36.smethod_24(int_, array);
		}
		else if (Working.GameType == (Enum2)3)
		{
			array = Class36.smethod_55(byte_0);
			byte[] first2 = new byte[8];
			array = first2.Concat(array).ToArray<byte>();
			Class36.smethod_22(array.Length - 8, array);
			Class36.smethod_23(chunkData_0.NewFileSize, array);
		}
		return array;
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00031C38 File Offset: 0x0002FE38
	public static byte[] smethod_55(byte[] byte_0)
	{
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (ZlibStream zlibStream = new ZlibStream(memoryStream, Ionic.Zlib.CompressionMode.Compress, true))
			{
				zlibStream.Write(byte_0, 0, byte_0.Length);
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00031C9C File Offset: 0x0002FE9C
	public static byte[] smethod_56(byte[] byte_0)
	{
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (ZlibStream zlibStream = new ZlibStream(memoryStream, Ionic.Zlib.CompressionMode.Decompress, true))
			{
				zlibStream.Write(byte_0, 0, byte_0.Length);
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00031D00 File Offset: 0x0002FF00
	public static byte[] smethod_57(byte[] byte_0)
	{
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (MemoryStream memoryStream2 = new MemoryStream(byte_0))
			{
				using (GZipStream gzipStream = new GZipStream(memoryStream2, System.IO.Compression.CompressionMode.Decompress))
				{
					gzipStream.CopyTo(memoryStream);
					result = memoryStream.ToArray();
				}
			}
		}
		return result;
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00031D80 File Offset: 0x0002FF80
	public static byte[] smethod_58(byte[] byte_0)
	{
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream(byte_0))
		{
			using (MemoryStream memoryStream2 = new MemoryStream())
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream2, System.IO.Compression.CompressionMode.Compress))
				{
					memoryStream.CopyTo(deflateStream);
					deflateStream.Close();
					result = memoryStream2.ToArray();
				}
			}
		}
		return result;
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00031E04 File Offset: 0x00030004
	public static byte[] smethod_59(byte[] byte_0)
	{
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (MemoryStream memoryStream2 = new MemoryStream(byte_0))
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream2, System.IO.Compression.CompressionMode.Decompress))
				{
					deflateStream.CopyTo(memoryStream);
					result = memoryStream.ToArray();
				}
			}
		}
		return result;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00031E84 File Offset: 0x00030084
	public static MemoryStream smethod_60(string string_0)
	{
		byte[] byte_ = FileUtils.smethod_0(string_0);
		return Class36.smethod_61(byte_);
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00031EA0 File Offset: 0x000300A0
	public static MemoryStream smethod_61(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		int i = 0;
		while (i < byte_0.Length)
		{
			byte b = byte_0[i++];
			if (b != 255)
			{
				memoryStream.WriteByte(b);
			}
			else
			{
				byte b2 = byte_0[i++];
				byte value = byte.MaxValue;
				if (b2 >= 3)
				{
					value = byte_0[i++];
				}
				for (int j = 0; j <= (int)b2; j++)
				{
					memoryStream.WriteByte(value);
				}
			}
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00031F20 File Offset: 0x00030120
	public static MemoryStream smethod_62(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte b = byte_0[i];
			if (i < byte_0.Length - 1 && b == byte_0[i + 1])
			{
				byte b2 = b;
				int num = 1;
				while (i + 1 < byte_0.Length && byte_0[i + 1] == b2)
				{
					if (num == 256)
					{
						break;
					}
					num++;
					i++;
				}
				if (b2 == 255)
				{
					Class36.smethod_64(num, memoryStream);
				}
				else
				{
					Class36.smethod_63(b2, num, memoryStream);
				}
			}
			else
			{
				memoryStream.WriteByte(b);
				if (b == 255)
				{
					memoryStream.WriteByte(0);
				}
			}
		}
		return memoryStream;
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00031FC4 File Offset: 0x000301C4
	private static void smethod_63(byte byte_0, int int_0, MemoryStream memoryStream_0)
	{
		if (int_0 > 3)
		{
			memoryStream_0.WriteByte(byte.MaxValue);
			memoryStream_0.WriteByte((byte)(int_0 - 1));
			memoryStream_0.WriteByte(byte_0);
			return;
		}
		for (int i = 0; i < int_0; i++)
		{
			memoryStream_0.WriteByte(byte_0);
		}
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x00006AEC File Offset: 0x00004CEC
	private static void smethod_64(int int_0, MemoryStream memoryStream_0)
	{
		memoryStream_0.WriteByte(byte.MaxValue);
		if (int_0 == 1)
		{
			memoryStream_0.WriteByte(0);
		}
		else
		{
			memoryStream_0.WriteByte((byte)(int_0 - 1));
		}
		if (int_0 > 3)
		{
			memoryStream_0.WriteByte(byte.MaxValue);
		}
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0000469B File Offset: 0x0000289B
	[CompilerGenerated]
	private static int smethod_65(ChunkIndexEntry chunkIndexEntry_0)
	{
		return chunkIndexEntry_0.ChunkIndex;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x0000469B File Offset: 0x0000289B
	[CompilerGenerated]
	private static int smethod_66(ChunkIndexEntry chunkIndexEntry_0)
	{
		return chunkIndexEntry_0.ChunkIndex;
	}

	// Token: 0x04000535 RID: 1333
	[CompilerGenerated]
	private static Func<ChunkIndexEntry, int> func_0;

	// Token: 0x04000536 RID: 1334
	[CompilerGenerated]
	private static Func<ChunkIndexEntry, int> func_1;
}
