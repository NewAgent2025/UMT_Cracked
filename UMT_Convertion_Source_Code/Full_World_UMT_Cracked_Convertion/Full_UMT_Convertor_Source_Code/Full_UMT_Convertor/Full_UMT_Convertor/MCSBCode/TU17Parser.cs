using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000095 RID: 149
	public class TU17Parser
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0000520C File Offset: 0x0000340C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00005214 File Offset: 0x00003414
		public TU17ChunkData TU17ChunkData_0
		{
			get
			{
				return this.tu17ChunkData_0;
			}
			set
			{
				this.tu17ChunkData_0 = value;
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00038CD4 File Offset: 0x00036ED4
		public void ParseChunk(string path)
		{
			MemoryStream stream = Class46.smethod_68(path);
			this.ParseChunk(stream);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00038CF0 File Offset: 0x00036EF0
		public TU17ChunkData ParseChunk(byte[] chunkBytes)
		{
			MemoryStream stream = new MemoryStream(chunkBytes);
			return this.ParseChunk(stream);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000521D File Offset: 0x0000341D
		public TU17ChunkData ParseChunk(MemoryStream stream)
		{
			this.method_0(stream);
			return this.tu17ChunkData_0;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00038D0C File Offset: 0x00036F0C
		private void method_0(MemoryStream memoryStream_0)
		{
			memoryStream_0.Seek(0L, SeekOrigin.Begin);
			short num = this.class47_0.method_2(memoryStream_0);
			int num2 = 0;
			if (num != 8 && num != 9 && num != 10)
			{
				if (num != 11)
				{
					return;
				}
			}
			if (num == 8)
			{
				num2 = 20;
				this.tu17ChunkData_0.TU17VersionType_0 = TU17VersionType.VERSION_8;
			}
			else if (num == 9)
			{
				num2 = 28;
				this.tu17ChunkData_0.TU17VersionType_0 = TU17VersionType.VERSION_9;
			}
			else if (num == 10)
			{
				num2 = 28;
				this.tu17ChunkData_0.TU17VersionType_0 = TU17VersionType.VERSION_10;
			}
			else if (num == 11)
			{
				num2 = 28;
				this.tu17ChunkData_0.TU17VersionType_0 = TU17VersionType.VERSION_11;
			}
			this.tu17ChunkData_0.X = this.class47_0.method_4(memoryStream_0);
			this.tu17ChunkData_0.Z = this.class47_0.method_4(memoryStream_0);
			memoryStream_0.Seek((long)num2, SeekOrigin.Begin);
			this.method_10(memoryStream_0);
			this.method_4(memoryStream_0);
			this.tu17ChunkData_0.HeightMap = this.method_3(memoryStream_0);
			this.tu17ChunkData_0.TerrainPopulatedFlags = (int)this.class47_0.method_2(memoryStream_0);
			this.tu17ChunkData_0.Biomes = this.method_2(memoryStream_0);
			this.tu17ChunkData_0.NBTData = this.method_1(memoryStream_0);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000283C8 File Offset: 0x000265C8
		private TagNodeCompound method_1(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[memoryStream_0.Length - memoryStream_0.Position];
			memoryStream_0.Read(array, 0, array.Length);
			TagNodeCompound result;
			if (array[0] == 10)
			{
				Utils.AddPreFixPostFix(array);
				Stream s = new MemoryStream(array);
				NbtTree nbtTree = new NbtTree(s);
				result = nbtTree.Root;
			}
			else
			{
				result = new TagNodeCompound();
			}
			return result;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00028428 File Offset: 0x00026628
		private byte[] method_2(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[256];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00028428 File Offset: 0x00026628
		private byte[] method_3(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[256];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00038E6C File Offset: 0x0003706C
		private void method_4(MemoryStream memoryStream_0)
		{
			List<byte[]> list = new List<byte[]>();
			for (int i = 0; i < 6; i++)
			{
				byte[] item = this.method_5(memoryStream_0);
				list.Add(item);
			}
			this.tu17ChunkData_0.DataGroupCount = list[0].Length + list[1].Length;
			this.method_6(list);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00038EC0 File Offset: 0x000370C0
		private byte[] method_5(MemoryStream memoryStream_0)
		{
			int num = this.class47_0.method_4(memoryStream_0);
			byte[] array = new byte[(num + 1) * 128];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00038EF8 File Offset: 0x000370F8
		private void method_6(List<byte[]> list_0)
		{
			byte[][] array = new byte[][]
			{
				new byte[32768],
				new byte[32768],
				new byte[32768]
			};
			for (int i = 0; i < 32768; i++)
			{
				array[1][i] = byte.MaxValue;
			}
			for (int j = 0; j < list_0.Count; j++)
			{
				int num = this.int_2[j];
				int num2 = this.int_1[j];
				byte[] array2 = list_0[j];
				int k = 0;
				while (k < 128)
				{
					if (array2[k] == 128)
					{
						goto IL_8C;
					}
					if (array2[k] == 129)
					{
						goto IL_8C;
					}
					this.method_8(array2, (int)((array2[k] + 1) * 128), array[num2], k * 128 + num);
					IL_B0:
					k++;
					continue;
					IL_8C:
					this.method_7(array[num2], k * 128 + num, (array2[k] == 128) ? 0 : byte.MaxValue);
					goto IL_B0;
				}
			}
			this.tu17ChunkData_0.BlockData = array[0];
			this.tu17ChunkData_0.SkyLight = array[1];
			this.tu17ChunkData_0.BlockLight = array[2];
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002860C File Offset: 0x0002680C
		private void method_7(byte[] byte_0, int int_3, byte byte_1)
		{
			for (int i = 0; i < 128; i++)
			{
				byte_0[int_3 + i] = byte_1;
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00028630 File Offset: 0x00026830
		private void method_8(byte[] byte_0, int int_3, byte[] byte_1, int int_4)
		{
			for (int i = 0; i < 128; i++)
			{
				byte_1[int_4 + i] = byte_0[int_3 + i];
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00039034 File Offset: 0x00037234
		private byte[] method_9(MemoryStream memoryStream_0)
		{
			this.class47_0.method_4(memoryStream_0);
			byte[] array = new byte[128];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00039068 File Offset: 0x00037268
		private void method_10(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[65536];
			this.method_12(array, 0, memoryStream_0);
			if (this.method_11(memoryStream_0))
			{
				this.class47_0.method_2(memoryStream_0);
				this.method_12(array, 32768, memoryStream_0);
			}
			this.tu17ChunkData_0.Blocks = array;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004C61 File Offset: 0x00002E61
		private bool method_11(MemoryStream memoryStream_0)
		{
			return true;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000390B8 File Offset: 0x000372B8
		private void method_12(byte[] byte_0, int int_3, MemoryStream memoryStream_0)
		{
			ushort num = this.class47_0.method_3(memoryStream_0);
			byte[] array = new byte[1024];
			byte[] array2 = new byte[(int)(num - 1024)];
			memoryStream_0.Read(array, 0, array.Length);
			List<uint> list = new List<uint>();
			list.Add((uint)array2.Length);
			for (int i = 0; i < 1024; i += 2)
			{
				byte b = array[i];
				byte byte_ = array[i + 1];
				if (b != 7)
				{
					uint item = this.method_24(b, byte_);
					list.Add(item);
				}
			}
			list.Sort();
			if (array2.Length > 0)
			{
				memoryStream_0.Read(array2, 0, array2.Length);
				for (int j = 0; j < 1024; j += 2)
				{
					byte b2 = array[j];
					byte b3 = array[j + 1];
					if (b2 == 7)
					{
						if (b3 != 0)
						{
							this.method_13(byte_0, int_3, j / 2, b3);
						}
					}
					else
					{
						uint uint_ = this.method_24(b2, b3);
						uint uint_2 = this.method_23(b2);
						byte byte_2 = b2 & 3;
						byte[] byte_3 = this.method_14(array2, uint_, uint_2);
						this.method_15(byte_0, int_3, j / 2, byte_3, byte_2, uint_);
					}
				}
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000391DC File Offset: 0x000373DC
		private void method_13(byte[] byte_0, int int_3, int int_4, byte byte_1)
		{
			byte[] array = new byte[64];
			int int_5 = this.method_16(int_4);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = byte_1;
			}
			this.method_21(int_5, array, byte_0, int_3);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000288CC File Offset: 0x00026ACC
		private byte[] method_14(byte[] byte_0, uint uint_0, uint uint_1)
		{
			byte[] array = new byte[uint_1];
			int num = 0;
			while ((long)num < (long)((ulong)uint_1))
			{
				array[num] = byte_0[(int)(checked((IntPtr)(unchecked((ulong)uint_0 + (ulong)((long)num)))))];
				num++;
			}
			return array;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00039218 File Offset: 0x00037418
		private void method_15(byte[] byte_0, int int_3, int int_4, byte[] byte_1, byte byte_2, uint uint_0)
		{
			int num = byte_1.Length;
			int int_5 = this.method_16(int_4);
			if (num == 64)
			{
				this.method_21(int_5, byte_1, byte_0, int_3);
				return;
			}
			MemoryStream memoryStream = new MemoryStream();
			if (num == 10)
			{
				uint num2 = 2U;
				for (int i = 0; i < 8; i++)
				{
					byte b = byte_1[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)i)))))];
					byte byte_3 = b & 15;
					int[] int_6 = this.method_17(byte_3, byte_2, 4, 1, 1);
					byte[] array = this.method_19(byte_1, int_6);
					memoryStream.Write(array, 0, array.Length);
					byte_3 = (byte)(b >> 4);
					int_6 = this.method_17(byte_3, byte_2, 4, 1, 1);
					array = this.method_19(byte_1, int_6);
					memoryStream.Write(array, 0, array.Length);
				}
				this.method_21(int_5, memoryStream.ToArray(), byte_0, int_3);
				return;
			}
			if (num == 20)
			{
				uint num3 = 4U;
				for (int j = 0; j < 16; j++)
				{
					byte byte_4 = byte_1[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)j)))))];
					int[] int_7 = this.method_17(byte_4, byte_2, 4, 2, 3);
					byte[] array = this.method_19(byte_1, int_7);
					memoryStream.Write(array, 0, array.Length);
				}
				this.method_21(int_5, memoryStream.ToArray(), byte_0, int_3);
				return;
			}
			if (num == 48)
			{
				uint num4 = 16U;
				for (int k = 0; k < 32; k += 2)
				{
					checked
					{
						byte byte_5 = byte_1[(int)((IntPtr)(unchecked((ulong)num4 + (ulong)((long)k))))];
						byte byte_6 = byte_1[(int)((IntPtr)(unchecked((ulong)num4 + (ulong)((long)k) + 1UL)))];
						int[] int_8 = this.method_18(byte_5, byte_6);
						byte[] array = this.method_19(byte_1, int_8);
						memoryStream.Write(array, 0, array.Length);
					}
				}
				this.method_21(int_5, memoryStream.ToArray(), byte_0, int_3);
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00028DE0 File Offset: 0x00026FE0
		private int method_16(int int_3)
		{
			int num = int_3 / 32;
			int num2 = int_3 % 32;
			return num / 4 * 64 + num % 4 * 4 + num2 * 1024;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000393C0 File Offset: 0x000375C0
		private int[] method_17(byte byte_0, byte byte_1, int int_3, byte byte_2, byte byte_3)
		{
			int[] array = new int[4];
			for (int i = 0; i < int_3; i++)
			{
				array[i] = (byte_0 >> (int)byte_2 * i & (int)byte_3);
			}
			return array;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00028E0C File Offset: 0x0002700C
		private int[] method_18(byte byte_0, byte byte_1)
		{
			return new int[]
			{
				(int)(byte_0 & 15),
				byte_0 >> 4,
				(int)(byte_1 & 15),
				byte_1 >> 4
			};
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000393F0 File Offset: 0x000375F0
		private byte[] method_19(byte[] byte_0, int[] int_3)
		{
			byte[] array = new byte[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = byte_0[int_3[i]];
			}
			return array;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00004C7B File Offset: 0x00002E7B
		private byte method_20(byte byte_0, byte byte_1)
		{
			return (byte)(byte_0 >> (int)byte_1 & 1);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0003941C File Offset: 0x0003761C
		private void method_21(int int_3, byte[] byte_0, byte[] byte_1, int int_4)
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						int num2 = int_3 + i * 16 + j + k * 256;
						byte_1[num2 + int_4] = byte_0[num++];
					}
				}
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00039470 File Offset: 0x00037670
		private uint method_22(List<uint> list_0, uint uint_0)
		{
			uint num = 0U;
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i] == uint_0 && i < list_0.Count - 1)
				{
					num = list_0[i + 1] - list_0[i];
				}
			}
			if (num == 0U)
			{
				num = 0U;
			}
			return num;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000394C4 File Offset: 0x000376C4
		private uint method_23(byte byte_0)
		{
			byte b = byte_0 & 3;
			uint result = 0U;
			if (b == 0)
			{
				result = 10U;
			}
			else if (b == 1)
			{
				result = 20U;
			}
			else if (b == 2)
			{
				result = 48U;
			}
			else if (b == 3)
			{
				result = 64U;
			}
			return result;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00004C86 File Offset: 0x00002E86
		private uint method_24(byte byte_0, byte byte_1)
		{
			return (uint)((byte_0 & 252) / 2 + byte_1 * 128);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004C99 File Offset: 0x00002E99
		private void method_25(string string_0, byte[] byte_0)
		{
			FileUtils.WriteFile(byte_0, Working.smethod_5() + Working.smethod_14() + string_0);
		}

		// Token: 0x040003BA RID: 954
		private int[] int_0 = new int[]
		{
			10,
			20,
			48,
			64
		};

		// Token: 0x040003BB RID: 955
		private int[] int_1 = new int[]
		{
			0,
			0,
			1,
			1,
			2,
			2
		};

		// Token: 0x040003BC RID: 956
		private int[] int_2 = new int[]
		{
			0,
			16384,
			0,
			16384,
			0,
			16384
		};

		// Token: 0x040003BD RID: 957
		private Class47 class47_0 = new Class47();

		// Token: 0x040003BE RID: 958
		private TU17ChunkData tu17ChunkData_0 = new TU17ChunkData();
	}
}
