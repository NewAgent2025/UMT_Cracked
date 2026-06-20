using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Ionic.Zlib;
using Substrate.Nbt;

// Token: 0x0200013E RID: 318
internal class Class46
{
	// Token: 0x06000D3C RID: 3388 RVA: 0x0005AC98 File Offset: 0x00058E98
	public static string smethod_0(int int_0)
	{
		string result = "";
		switch (int_0)
		{
		case 0:
			result = "Survival";
			break;
		case 1:
			result = "Creative";
			break;
		case 2:
			result = "Adventure";
			break;
		case 3:
			result = "Hardcore";
			break;
		case 4:
			result = "Spectator";
			break;
		}
		return result;
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x0005ACF0 File Offset: 0x00058EF0
	public static List<IndexEntry> smethod_1(BinaryReader binaryReader_0)
	{
		IndexOffsetData indexOffsetData_ = Class46.smethod_2(binaryReader_0);
		return Class46.smethod_3(binaryReader_0, indexOffsetData_);
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x0005AD14 File Offset: 0x00058F14
	private static IndexOffsetData smethod_2(BinaryReader binaryReader_0)
	{
		IndexOffsetData indexOffsetData = new IndexOffsetData();
		binaryReader_0.BaseStream.Seek(0L, SeekOrigin.Begin);
		indexOffsetData.IndexOffset = FileUtils.smethod_6(binaryReader_0, FileUtils.ByteOrder.BigEndian);
		indexOffsetData.FileCount = FileUtils.smethod_6(binaryReader_0, FileUtils.ByteOrder.BigEndian);
		return indexOffsetData;
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x0005AD58 File Offset: 0x00058F58
	private static List<IndexEntry> smethod_3(BinaryReader binaryReader_0, IndexOffsetData indexOffsetData_0)
	{
		List<IndexEntry> list = new List<IndexEntry>();
		long num = binaryReader_0.BaseStream.Length - (long)((ulong)indexOffsetData_0.IndexOffset);
		int num2 = (int)(num / 144L);
		if ((long)num2 <= (long)((ulong)indexOffsetData_0.FileCount))
		{
			binaryReader_0.BaseStream.Seek((long)((ulong)indexOffsetData_0.IndexOffset), SeekOrigin.Begin);
			for (int i = 0; i < num2; i++)
			{
				IndexEntry indexEntry = Class46.smethod_4(binaryReader_0);
				if (!string.IsNullOrWhiteSpace(indexEntry.FileName))
				{
					list.Add(indexEntry);
				}
			}
		}
		return list;
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x0005ADD8 File Offset: 0x00058FD8
	private static IndexEntry smethod_4(BinaryReader binaryReader_0)
	{
		byte[] array = new byte[144];
		for (int i = 0; i < 144; i++)
		{
			array[i] = binaryReader_0.ReadByte();
			if (binaryReader_0.BaseStream.Position == binaryReader_0.BaseStream.Length)
			{
				break;
			}
		}
		return new IndexEntry(array);
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x0005AE2C File Offset: 0x0005902C
	public static List<ChunkIndexEntry> smethod_5(string string_0)
	{
		List<ChunkIndexEntry> result = null;
		if (File.Exists(string_0))
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				if (binaryReader.BaseStream.Length >= 4096L)
				{
					result = Class46.smethod_6(binaryReader);
				}
			}
		}
		return result;
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x0005AE8C File Offset: 0x0005908C
	private static List<ChunkIndexEntry> smethod_6(BinaryReader binaryReader_0)
	{
		List<ChunkIndexEntry> list = new List<ChunkIndexEntry>();
		for (int i = 0; i < 1024; i++)
		{
			uint chunkOffset = Class46.smethod_9(binaryReader_0.ReadBytes(3));
			byte chunkLength = binaryReader_0.ReadByte();
			list.Add(new ChunkIndexEntry(i, chunkOffset, chunkLength));
		}
		return list;
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x0005AED4 File Offset: 0x000590D4
	public static List<ChunkIndexEntry> smethod_7(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		List<ChunkIndexEntry> list = new List<ChunkIndexEntry>();
		byte[] array = new byte[3];
		for (int i = 0; i < 1024; i++)
		{
			memoryStream.Read(array, 0, 3);
			uint chunkOffset = Class46.smethod_9(array);
			byte chunkLength = (byte)memoryStream.ReadByte();
			list.Add(new ChunkIndexEntry(i, chunkOffset, chunkLength));
		}
		return list;
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x0005AF34 File Offset: 0x00059134
	public static List<ChunkIndexEntry> smethod_8()
	{
		List<ChunkIndexEntry> list = new List<ChunkIndexEntry>();
		for (int i = 0; i < 1024; i++)
		{
			list.Add(new ChunkIndexEntry(i, 0U, 0));
		}
		return list;
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x0005AF68 File Offset: 0x00059168
	private static uint smethod_9(byte[] byte_0)
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

	// Token: 0x06000D46 RID: 3398 RVA: 0x0005AF9C File Offset: 0x0005919C
	public static byte[] smethod_10(string string_0, ChunkIndexEntry chunkIndexEntry_0)
	{
		byte[] result = null;
		using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
		{
			result = Class46.smethod_11(binaryReader, chunkIndexEntry_0);
		}
		return result;
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x0005AFE0 File Offset: 0x000591E0
	public static byte[] smethod_11(BinaryReader binaryReader_0, ChunkIndexEntry chunkIndexEntry_0)
	{
		byte[] array = new byte[(int)chunkIndexEntry_0.OldChunkLength * 4096];
		binaryReader_0.BaseStream.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		binaryReader_0.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x0005B028 File Offset: 0x00059228
	public static byte[] smethod_12(byte[] byte_0, ChunkIndexEntry chunkIndexEntry_0)
	{
		int num = (int)chunkIndexEntry_0.OldChunkLength * 4096;
		uint srcOffset = chunkIndexEntry_0.OldChunkOffset * 4096U;
		byte[] array = new byte[num];
		Buffer.BlockCopy(byte_0, (int)srcOffset, array, 0, num);
		return array;
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x0005B064 File Offset: 0x00059264
	public static void smethod_13(byte[] byte_0, ChunkIndexEntry chunkIndexEntry_0, BinaryWriter binaryWriter_0)
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

	// Token: 0x06000D4A RID: 3402 RVA: 0x0005B100 File Offset: 0x00059300
	public static void smethod_14(byte[] byte_0, ChunkIndexEntry chunkIndexEntry_0, MemoryStream memoryStream_0)
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

	// Token: 0x06000D4B RID: 3403 RVA: 0x0005B198 File Offset: 0x00059398
	public static int smethod_15(int int_0, int int_1)
	{
		int num = 4 * (int_0 % 32 + int_1 % 32 * 32);
		if (num < 0)
		{
			num += 32;
		}
		return num;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x0005B1C0 File Offset: 0x000593C0
	public static uint smethod_16(List<ChunkIndexEntry> list_0, int int_0, int int_1)
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

	// Token: 0x06000D4D RID: 3405 RVA: 0x0005B1F8 File Offset: 0x000593F8
	public static int smethod_17(int int_0, int int_1)
	{
		return (int_0 & 31) + (int_1 & 31) * 32;
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x00008C1F File Offset: 0x00006E1F
	public static int smethod_18(int int_0, int int_1)
	{
		int_1 = ((int_1 < 0) ? (int_1 + 1) : int_1);
		return int_0 + int_1 * 32;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00008C33 File Offset: 0x00006E33
	public static int smethod_19(int int_0, int int_1)
	{
		if (int_1 < 0)
		{
			return int_0 - 32;
		}
		return int_0;
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00008C3F File Offset: 0x00006E3F
	public static bool smethod_20(List<ChunkIndexEntry> list_0, int int_0, int int_1)
	{
		return Class46.smethod_16(list_0, int_0, int_1) != 0U;
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00008C4F File Offset: 0x00006E4F
	public static ChunkIndexEntry smethod_21(List<ChunkIndexEntry> list_0, int int_0, int int_1)
	{
		if (list_0 == null || list_0.Count < int_0 + int_1 * 32)
		{
			return null;
		}
		return list_0[int_0 + int_1 * 32];
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00008C70 File Offset: 0x00006E70
	public static void smethod_22<T>(T[] gparam_0, int int_0, out T[] gparam_1, out T[] gparam_2)
	{
		gparam_1 = gparam_0.Take(int_0).ToArray<T>();
		gparam_2 = gparam_0.Skip(int_0).ToArray<T>();
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x0005B214 File Offset: 0x00059414
	internal static string smethod_23(BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Seek(8L, SeekOrigin.Begin);
		short num = FileUtils.ReadShort(binaryReader_0);
		short num2 = FileUtils.ReadShort(binaryReader_0);
		Working.WorldVersionMajor = num2;
		Working.WorldVersionMinor = num;
		return string.Format(" V:{0}.{1}", num2, num);
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x0005B268 File Offset: 0x00059468
	public static void smethod_24(string string_0)
	{
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
		{
			Class46.smethod_25(binaryWriter);
		}
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x0005B2A4 File Offset: 0x000594A4
	public static void smethod_25(BinaryWriter binaryWriter_0)
	{
		byte value = 0;
		for (int i = 0; i < 8192; i++)
		{
			binaryWriter_0.Write(value);
		}
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x0005B2CC File Offset: 0x000594CC
	public static void smethod_26(MemoryStream memoryStream_0)
	{
		byte value = 0;
		for (int i = 0; i < 8192; i++)
		{
			memoryStream_0.WriteByte(value);
		}
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0005B2F4 File Offset: 0x000594F4
	public static void smethod_27(int int_0, byte[] byte_0)
	{
		byte[] array = Class46.smethod_30(int_0);
		byte_0[0] = 128;
		byte_0[1] = array[1];
		byte_0[2] = array[2];
		byte_0[3] = array[3];
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x0005B324 File Offset: 0x00059524
	public static void smethod_28(int int_0, byte[] byte_0)
	{
		byte[] array = Class46.smethod_30(int_0);
		byte_0[4] = array[0];
		byte_0[5] = array[1];
		byte_0[6] = array[2];
		byte_0[7] = array[3];
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0005B350 File Offset: 0x00059550
	public static void smethod_29(int int_0, byte[] byte_0)
	{
		byte[] array = Class46.smethod_30(int_0);
		byte_0[8] = array[0];
		byte_0[9] = array[1];
		byte_0[10] = array[2];
		byte_0[11] = array[3];
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0005B380 File Offset: 0x00059580
	public static byte[] smethod_30(int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0005B3A4 File Offset: 0x000595A4
	public static void smethod_31(BinaryWriter binaryWriter_0, List<ChunkIndexEntry> list_0)
	{
		binaryWriter_0.BaseStream.Seek(0L, SeekOrigin.Begin);
		IEnumerable<ChunkIndexEntry> source = list_0;
		if (Class46.func_0 == null)
		{
			Class46.func_0 = new Func<ChunkIndexEntry, int>(Class46.smethod_78);
		}
		list_0 = source.OrderBy(Class46.func_0).ToList<ChunkIndexEntry>();
		foreach (ChunkIndexEntry chunkIndexEntry in list_0)
		{
			uint newChunkOffset = chunkIndexEntry.NewChunkOffset;
			binaryWriter_0.Write((byte)((newChunkOffset & 16711680U) >> 16));
			binaryWriter_0.Write((byte)((newChunkOffset & 65280U) >> 8));
			binaryWriter_0.Write((byte)(newChunkOffset & 255U));
			binaryWriter_0.Write(chunkIndexEntry.NewChunkLength);
		}
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x0005B470 File Offset: 0x00059670
	public static void smethod_32(MemoryStream memoryStream_0, List<ChunkIndexEntry> list_0)
	{
		memoryStream_0.Seek(0L, SeekOrigin.Begin);
		IEnumerable<ChunkIndexEntry> source = list_0;
		if (Class46.func_1 == null)
		{
			Class46.func_1 = new Func<ChunkIndexEntry, int>(Class46.smethod_79);
		}
		list_0 = source.OrderBy(Class46.func_1).ToList<ChunkIndexEntry>();
		foreach (ChunkIndexEntry chunkIndexEntry in list_0)
		{
			uint newChunkOffset = chunkIndexEntry.NewChunkOffset;
			memoryStream_0.WriteByte((byte)((newChunkOffset & 16711680U) >> 16));
			memoryStream_0.WriteByte((byte)((newChunkOffset & 65280U) >> 8));
			memoryStream_0.WriteByte((byte)(newChunkOffset & 255U));
			memoryStream_0.WriteByte(chunkIndexEntry.NewChunkLength);
		}
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0005B268 File Offset: 0x00059468
	public static void smethod_33(string string_0)
	{
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
		{
			Class46.smethod_25(binaryWriter);
		}
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0005B538 File Offset: 0x00059738
	public static TagNodeCompound smethod_34(byte[] byte_0)
	{
		TagNodeCompound result = null;
		try
		{
			MemoryStream memoryStream = Class46.smethod_69(byte_0);
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

	// Token: 0x06000D5F RID: 3423 RVA: 0x00008C8E File Offset: 0x00006E8E
	public static bool smethod_35(int int_0)
	{
		return Constants.CONSOLE_ENTITY_BLOCKS.ContainsKey(int_0);
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00008C9B File Offset: 0x00006E9B
	public static string smethod_36(int int_0)
	{
		if (Constants.CONSOLE_ENTITY_BLOCKS.ContainsKey(int_0))
		{
			return Constants.CONSOLE_ENTITY_BLOCKS[int_0];
		}
		return string.Empty;
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x0005B59C File Offset: 0x0005979C
	public static TagNodeCompound smethod_37(TagNodeCompound tagNodeCompound_0, int int_0, int int_1, int int_2)
	{
		TagNodeCompound tagNodeCompound = tagNodeCompound_0;
		if (tagNodeCompound.ContainsKey("Level"))
		{
			tagNodeCompound = (tagNodeCompound_0["Level"] as TagNodeCompound);
		}
		if (tagNodeCompound.ContainsKey("TileEntities"))
		{
			TagNodeList tagNodeList_ = tagNodeCompound["TileEntities"] as TagNodeList;
			return Class46.smethod_38(tagNodeList_, int_0, int_1, int_2);
		}
		return null;
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x0005B5F4 File Offset: 0x000597F4
	public static TagNodeCompound smethod_38(TagNodeList tagNodeList_0, int int_0, int int_1, int int_2)
	{
		TagNodeCompound tagNodeCompound = Class46.smethod_39(tagNodeList_0, int_0, int_1, int_2);
		if (tagNodeCompound != null)
		{
			tagNodeList_0.Remove(tagNodeCompound);
		}
		return tagNodeCompound;
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0005B618 File Offset: 0x00059818
	public static TagNodeCompound smethod_39(TagNodeList tagNodeList_0, int int_0, int int_1, int int_2)
	{
		for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
		{
			TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
			Class31 @class = Class46.smethod_46(tagNodeCompound);
			if (int_0 == @class.X && int_1 == @class.Y && int_2 == @class.Z)
			{
				return tagNodeCompound;
			}
		}
		return null;
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x0005B66C File Offset: 0x0005986C
	public static void smethod_40(int int_0, TagNodeList tagNodeList_0, int int_1, int int_2, int int_3, Dictionary<int, TagNodeCompound> dictionary_0)
	{
		if (tagNodeList_0.Count == 0 && tagNodeList_0.ValueType != TagType.TAG_COMPOUND)
		{
			tagNodeList_0.ChangeValueType(TagType.TAG_COMPOUND);
		}
		TagNodeCompound tagNodeCompound = null;
		if (dictionary_0 == null || !dictionary_0.ContainsKey(int_0))
		{
			if (Constants.consoleEntityDefaults.ContainsKey(int_0))
			{
				string string_ = Constants.consoleEntityDefaults[int_0];
				tagNodeCompound = (TagNodeCompound)Class46.smethod_42(string_);
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
			Class46.smethod_45(tagNodeCompound, int_1, int_2, int_3);
			tagNodeList_0.Add(tagNodeCompound);
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0005B708 File Offset: 0x00059908
	public static string smethod_41(string string_0, TagNode tagNode_0)
	{
		NbtTree nbtTree = new NbtTree();
		nbtTree.Root.Add(string_0, tagNode_0);
		MemoryStream memoryStream = new MemoryStream();
		nbtTree.ChildrenWriteTo(memoryStream);
		byte[] array = memoryStream.ToArray();
		return "0a0001" + Utils.ConvertByteToHexString(array[0]) + Utils.ConvertByteArrayToHexString(array) + "00";
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x0005B75C File Offset: 0x0005995C
	public static TagNode smethod_42(string string_0)
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

	// Token: 0x06000D67 RID: 3431 RVA: 0x0005B844 File Offset: 0x00059A44
	public static TagNode smethod_43(string string_0)
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

	// Token: 0x06000D68 RID: 3432 RVA: 0x0005B8AC File Offset: 0x00059AAC
	public static void smethod_44(TagNodeCompound tagNodeCompound_0, string string_0)
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

	// Token: 0x06000D69 RID: 3433 RVA: 0x00008CBB File Offset: 0x00006EBB
	public static void smethod_45(TagNodeCompound tagNodeCompound_0, int int_0, int int_1, int int_2)
	{
		if (tagNodeCompound_0 != null)
		{
			tagNodeCompound_0["x"] = new TagNodeInt(int_0);
			tagNodeCompound_0["y"] = new TagNodeInt(int_1);
			tagNodeCompound_0["z"] = new TagNodeInt(int_2);
		}
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x0005B908 File Offset: 0x00059B08
	public static Class31 smethod_46(TagNodeCompound tagNodeCompound_0)
	{
		Class31 @class = new Class31();
		if (tagNodeCompound_0.ContainsKey("x") && tagNodeCompound_0.ContainsKey("y") && tagNodeCompound_0.ContainsKey("z"))
		{
			@class.X = (TagNodeInt)tagNodeCompound_0["x"];
			@class.Y = (TagNodeInt)tagNodeCompound_0["y"];
			@class.Z = (TagNodeInt)tagNodeCompound_0["z"];
		}
		return @class;
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00008CF3 File Offset: 0x00006EF3
	public static int smethod_47(int int_0)
	{
		return int_0 >> 4;
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x0005B994 File Offset: 0x00059B94
	public static byte[] smethod_48(ChunkIndexEntry chunkIndexEntry_0, byte[] byte_0)
	{
		byte[] result = null;
		MemoryStream stream_ = new MemoryStream(byte_0);
		if (Working.GameType == (Enum2)1)
		{
			result = Class46.smethod_54(chunkIndexEntry_0, stream_);
		}
		else if (Working.GameType == (Enum2)2)
		{
			result = Class46.smethod_57(chunkIndexEntry_0, stream_);
		}
		else if (Working.GameType == (Enum2)3)
		{
			result = Class46.smethod_60(chunkIndexEntry_0, stream_);
		}
		return result;
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x0005B9E8 File Offset: 0x00059BE8
	public static TagNodeCompound smethod_49(string string_0)
	{
		byte[] buffer = FileUtils.smethod_0(Path.Combine(string_0, "level.dat"));
		MemoryStream s = new MemoryStream(buffer);
		NbtTree nbtTree = new NbtTree(s);
		return nbtTree.Root["Data"] as TagNodeCompound;
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x0005BA2C File Offset: 0x00059C2C
	public static byte[] smethod_50(ChunkIndexEntry chunkIndexEntry_0, MemoryStream memoryStream_0)
	{
		byte[] result = null;
		if (Working.GameType == (Enum2)1)
		{
			result = Class46.smethod_53(chunkIndexEntry_0, memoryStream_0);
		}
		else if (Working.GameType == (Enum2)2)
		{
			result = Class46.smethod_56(chunkIndexEntry_0, memoryStream_0);
		}
		else if (Working.GameType == (Enum2)3)
		{
			result = Class46.smethod_59(chunkIndexEntry_0, memoryStream_0);
		}
		return result;
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x0005BA78 File Offset: 0x00059C78
	public static byte[] smethod_51(ChunkIndexEntry chunkIndexEntry_0, BinaryReader binaryReader_0)
	{
		byte[] result = null;
		if (Working.GameType == (Enum2)1)
		{
			result = Class46.smethod_53(chunkIndexEntry_0, binaryReader_0.BaseStream);
		}
		else if (Working.GameType == (Enum2)2)
		{
			result = Class46.smethod_56(chunkIndexEntry_0, binaryReader_0.BaseStream);
		}
		else if (Working.GameType == (Enum2)3)
		{
			result = Class46.smethod_59(chunkIndexEntry_0, binaryReader_0.BaseStream);
		}
		return result;
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x0005BAD4 File Offset: 0x00059CD4
	public static byte[] smethod_52(ChunkIndexEntry chunkIndexEntry_0, string string_0)
	{
		byte[] result = null;
		if (chunkIndexEntry_0.OldChunkOffset > 0U)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				result = Class46.smethod_53(chunkIndexEntry_0, binaryReader.BaseStream);
			}
		}
		return result;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00008CF8 File Offset: 0x00006EF8
	public static byte[] smethod_53(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		stream_0.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		return Class46.smethod_54(chunkIndexEntry_0, stream_0);
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x0005BB24 File Offset: 0x00059D24
	public static byte[] smethod_54(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		XBOXCompression xboxcompression = new XBOXCompression();
		Class47 @class = new Class47();
		int num = @class.method_4(stream_0) & 16777215;
		int dsize = @class.method_4(stream_0);
		byte[] array = new byte[num];
		stream_0.Read(array, 0, array.Length);
		return xboxcompression.DoDecompress(array, dsize);
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x0005BB78 File Offset: 0x00059D78
	public static byte[] smethod_55(ChunkIndexEntry chunkIndexEntry_0, string string_0)
	{
		byte[] result = null;
		if (chunkIndexEntry_0.OldChunkOffset > 0U)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				result = Class46.smethod_56(chunkIndexEntry_0, binaryReader.BaseStream);
			}
		}
		return result;
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x00008D14 File Offset: 0x00006F14
	public static byte[] smethod_56(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		stream_0.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		return Class46.smethod_57(chunkIndexEntry_0, stream_0);
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x0005BBC8 File Offset: 0x00059DC8
	public static byte[] smethod_57(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		Class47 @class = new Class47();
		int num = @class.method_4(stream_0) & 16777215;
		@class.method_4(stream_0);
		@class.method_4(stream_0);
		byte[] array = new byte[num];
		stream_0.Read(array, 0, array.Length);
		return Class46.smethod_67(array);
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x0005BC14 File Offset: 0x00059E14
	public static byte[] smethod_58(ChunkIndexEntry chunkIndexEntry_0, string string_0)
	{
		byte[] result = null;
		if (chunkIndexEntry_0.OldChunkOffset > 0U)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
			{
				result = Class46.smethod_59(chunkIndexEntry_0, binaryReader.BaseStream);
			}
		}
		return result;
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00008D30 File Offset: 0x00006F30
	public static byte[] smethod_59(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		stream_0.Position = (long)((ulong)(chunkIndexEntry_0.OldChunkOffset * 4096U));
		return Class46.smethod_60(chunkIndexEntry_0, stream_0);
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x0005BC64 File Offset: 0x00059E64
	public static byte[] smethod_60(ChunkIndexEntry chunkIndexEntry_0, Stream stream_0)
	{
		Class47 @class = new Class47();
		int num = @class.method_4(stream_0) & 16777215;
		@class.method_4(stream_0);
		byte[] array = new byte[num];
		stream_0.Read(array, 0, array.Length);
		return Class46.smethod_64(array);
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x0005BCA8 File Offset: 0x00059EA8
	public static byte[] smethod_61(object object_0, ChunkData chunkData_0)
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
			memoryStream = Class46.smethod_70(memoryStream.ToArray());
			result = Class46.smethod_62(memoryStream.ToArray(), chunkData_0);
		}
		return result;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0005BD24 File Offset: 0x00059F24
	public static byte[] smethod_62(byte[] byte_0, ChunkData chunkData_0)
	{
		int int_ = byte_0.Length;
		byte[] array = null;
		if (Working.GameType == (Enum2)1)
		{
			XBOXCompression xboxcompression = new XBOXCompression();
			array = xboxcompression.DoCompress(byte_0, 8);
			Class46.smethod_27(array.Length - 8, array);
			Class46.smethod_28(chunkData_0.NewFileSize, array);
		}
		else if (Working.GameType == (Enum2)2)
		{
			array = Class46.smethod_66(byte_0);
			byte[] first = new byte[12];
			array = first.Concat(array).ToArray<byte>();
			Class46.smethod_27(array.Length - 8, array);
			Class46.smethod_28(chunkData_0.NewFileSize, array);
			Class46.smethod_29(int_, array);
		}
		else if (Working.GameType == (Enum2)3)
		{
			array = Class46.smethod_63(byte_0);
			byte[] first2 = new byte[8];
			array = first2.Concat(array).ToArray<byte>();
			Class46.smethod_27(array.Length - 8, array);
			Class46.smethod_28(chunkData_0.NewFileSize, array);
		}
		return array;
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x0005BDF4 File Offset: 0x00059FF4
	public static byte[] smethod_63(byte[] byte_0)
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

	// Token: 0x06000D7C RID: 3452 RVA: 0x0005BE58 File Offset: 0x0005A058
	public static byte[] smethod_64(byte[] byte_0)
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

	// Token: 0x06000D7D RID: 3453 RVA: 0x0005BEBC File Offset: 0x0005A0BC
	public static byte[] smethod_65(byte[] byte_0)
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

	// Token: 0x06000D7E RID: 3454 RVA: 0x0005BF3C File Offset: 0x0005A13C
	public static byte[] smethod_66(byte[] byte_0)
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

	// Token: 0x06000D7F RID: 3455 RVA: 0x0005BFC0 File Offset: 0x0005A1C0
	public static byte[] smethod_67(byte[] byte_0)
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

	// Token: 0x06000D80 RID: 3456 RVA: 0x0005C040 File Offset: 0x0005A240
	public static MemoryStream smethod_68(string string_0)
	{
		byte[] byte_ = FileUtils.smethod_0(string_0);
		return Class46.smethod_69(byte_);
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x0005C05C File Offset: 0x0005A25C
	public static MemoryStream smethod_69(byte[] byte_0)
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

	// Token: 0x06000D82 RID: 3458 RVA: 0x0005C0DC File Offset: 0x0005A2DC
	public static MemoryStream smethod_70(byte[] byte_0)
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
					Class46.smethod_72(num, memoryStream);
				}
				else
				{
					Class46.smethod_71(b2, num, memoryStream);
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

	// Token: 0x06000D83 RID: 3459 RVA: 0x0005C180 File Offset: 0x0005A380
	private static void smethod_71(byte byte_0, int int_0, MemoryStream memoryStream_0)
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

	// Token: 0x06000D84 RID: 3460 RVA: 0x00008D4C File Offset: 0x00006F4C
	private static void smethod_72(int int_0, MemoryStream memoryStream_0)
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

	// Token: 0x06000D85 RID: 3461 RVA: 0x0005C1C4 File Offset: 0x0005A3C4
	internal static short smethod_73(TagNodeCompound tagNodeCompound_0)
	{
		short result = 0;
		if (tagNodeCompound_0["id"] is TagNodeString)
		{
			string key = tagNodeCompound_0["id"] as TagNodeString;
			if (Class34.smethod_2().ContainsKey(key))
			{
				result = (short)Class34.smethod_2()[key].Id;
			}
			else if (ConsoleItemLookups.ItemsByName.ContainsKey(key))
			{
				result = (short)ConsoleItemLookups.ItemsByName[key].Id;
			}
		}
		else
		{
			result = (tagNodeCompound_0["id"] as TagNodeShort);
		}
		return result;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0005C254 File Offset: 0x0005A454
	internal static string smethod_74(TagNodeCompound tagNodeCompound_0)
	{
		string result = string.Empty;
		if (tagNodeCompound_0["id"] is TagNodeShort)
		{
			short short_ = tagNodeCompound_0["id"] as TagNodeShort;
			result = Class46.smethod_75(short_);
		}
		else
		{
			result = (tagNodeCompound_0["id"] as TagNodeString);
		}
		return result;
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
	internal static string smethod_75(short short_0)
	{
		string result = string.Empty;
		if (ConsoleItemLookups.ItemsById.ContainsKey((int)short_0))
		{
			result = ConsoleItemLookups.ItemsById[(int)short_0].MCName;
		}
		else if (Class34.smethod_1().ContainsKey((int)short_0))
		{
			result = Class34.smethod_1()[(int)short_0].ApfHbuxQfqb();
		}
		return result;
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0005C304 File Offset: 0x0005A504
	public static int smethod_76(int int_0, int int_1)
	{
		int num = int_0 >> 5;
		int num2 = num + int_1;
		int num3 = int_0 % 32;
		if (num3 == 0 && int_0 < 0)
		{
			num3 = -32;
		}
		if (num >= 0 || num2 < 0)
		{
			if (num >= 0 && num2 < 0)
			{
				num3 = (32 - Math.Abs(num3)) * -1;
			}
		}
		else
		{
			num3 = 32 - Math.Abs(num3);
		}
		if (num2 < 0)
		{
			num2++;
		}
		return num2 * 32 + num3;
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x0005C368 File Offset: 0x0005A568
	public static int smethod_77(int int_0, int int_1)
	{
		if (int_1 == 0)
		{
			return int_0;
		}
		int num = int_0 >> 4;
		int num2 = Class46.smethod_76(num, int_1);
		int num3 = int_0 % 16;
		if (num3 == 0 && int_0 < 0)
		{
			num3 = -16;
		}
		if (num >= 0 || num2 < 0)
		{
			if (num >= 0 && num2 < 0)
			{
				num3 = (16 - Math.Abs(num3)) * -1;
			}
		}
		else
		{
			num3 = 16 - Math.Abs(num3);
		}
		if (num2 < 0)
		{
			num2++;
		}
		return num2 * 16 + num3;
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x000031AC File Offset: 0x000013AC
	[CompilerGenerated]
	private static int smethod_78(ChunkIndexEntry chunkIndexEntry_0)
	{
		return chunkIndexEntry_0.ChunkIndex;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x000031AC File Offset: 0x000013AC
	[CompilerGenerated]
	private static int smethod_79(ChunkIndexEntry chunkIndexEntry_0)
	{
		return chunkIndexEntry_0.ChunkIndex;
	}

	// Token: 0x0400081A RID: 2074
	[CompilerGenerated]
	private static Func<ChunkIndexEntry, int> func_0;

	// Token: 0x0400081B RID: 2075
	[CompilerGenerated]
	private static Func<ChunkIndexEntry, int> func_1;
}
