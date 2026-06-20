using System;
using System.Collections.Generic;
using System.IO;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x02000065 RID: 101
	public class TU17Parser
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00004978 File Offset: 0x00002B78
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00004980 File Offset: 0x00002B80
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

		// Token: 0x0600047C RID: 1148 RVA: 0x000242E4 File Offset: 0x000224E4
		public void ParseChunk(string path)
		{
			MemoryStream stream = Class36.smethod_60(path);
			this.ParseChunk(stream);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00024300 File Offset: 0x00022500
		public TU17ChunkData ParseChunk(byte[] chunkBytes)
		{
			MemoryStream stream = new MemoryStream(chunkBytes);
			return this.ParseChunk(stream);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00004989 File Offset: 0x00002B89
		public TU17ChunkData ParseChunk(MemoryStream stream)
		{
			this.method_0(stream);
			return this.tu17ChunkData_0;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0002431C File Offset: 0x0002251C
		private void method_0(MemoryStream memoryStream_0)
		{
			memoryStream_0.Seek(0L, SeekOrigin.Begin);
			short num = this.class37_0.method_0(memoryStream_0);
			int num2 = 0;
			if (num != 8 && num != 9)
			{
				if (num != 10)
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
			this.tu17ChunkData_0.X = this.class37_0.method_2(memoryStream_0);
			this.tu17ChunkData_0.Z = this.class37_0.method_2(memoryStream_0);
			memoryStream_0.Seek((long)num2, SeekOrigin.Begin);
			this.method_10(memoryStream_0);
			this.method_4(memoryStream_0);
			this.tu17ChunkData_0.HeightMap = this.method_3(memoryStream_0);
			this.tu17ChunkData_0.TerrainPopulatedFlags = (int)this.class37_0.method_0(memoryStream_0);
			this.tu17ChunkData_0.Biomes = this.method_2(memoryStream_0);
			this.tu17ChunkData_0.NBTData = this.method_1(memoryStream_0);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00024454 File Offset: 0x00022654
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

		// Token: 0x06000481 RID: 1153 RVA: 0x000244B4 File Offset: 0x000226B4
		private byte[] method_2(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[256];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000244B4 File Offset: 0x000226B4
		private byte[] method_3(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[256];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000244DC File Offset: 0x000226DC
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

		// Token: 0x06000484 RID: 1156 RVA: 0x00024530 File Offset: 0x00022730
		private byte[] method_5(MemoryStream memoryStream_0)
		{
			int num = this.class37_0.method_2(memoryStream_0);
			byte[] array = new byte[(num + 1) * 128];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00024568 File Offset: 0x00022768
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
				int num = this.int_1[j];
				int num2 = this.int_0[j];
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

		// Token: 0x06000486 RID: 1158 RVA: 0x000246A4 File Offset: 0x000228A4
		private void method_7(byte[] byte_0, int int_2, byte byte_1)
		{
			for (int i = 0; i < 128; i++)
			{
				byte_0[int_2 + i] = byte_1;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000246C8 File Offset: 0x000228C8
		private void method_8(byte[] byte_0, int int_2, byte[] byte_1, int int_3)
		{
			for (int i = 0; i < 128; i++)
			{
				byte_1[int_3 + i] = byte_0[int_2 + i];
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000246F0 File Offset: 0x000228F0
		private byte[] method_9(MemoryStream memoryStream_0)
		{
			this.class37_0.method_2(memoryStream_0);
			byte[] array = new byte[128];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00024724 File Offset: 0x00022924
		private void method_10(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[65536];
			this.method_12(array, 0, memoryStream_0);
			if (this.method_11(memoryStream_0))
			{
				this.class37_0.method_0(memoryStream_0);
				this.method_12(array, 32768, memoryStream_0);
			}
			this.tu17ChunkData_0.Blocks = array;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00004998 File Offset: 0x00002B98
		private bool method_11(MemoryStream memoryStream_0)
		{
			return true;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00024774 File Offset: 0x00022974
		private void method_12(byte[] byte_0, int int_2, MemoryStream memoryStream_0)
		{
			ushort num = this.class37_0.method_1(memoryStream_0);
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
							this.method_13(byte_0, int_2, j / 2, b3);
						}
					}
					else
					{
						uint uint_ = this.method_24(b2, b3);
						uint uint_2 = this.method_22(list, uint_);
						byte byte_2 = b2 & 3;
						byte[] byte_3 = this.method_14(array2, uint_, uint_2);
						this.method_15(byte_0, int_2, j / 2, byte_3, byte_2, uint_);
					}
				}
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00024898 File Offset: 0x00022A98
		private void method_13(byte[] byte_0, int int_2, int int_3, byte byte_1)
		{
			byte[] array = new byte[64];
			int int_4 = this.method_16(int_3);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = byte_1;
			}
			this.method_21(int_4, array, byte_0, int_2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000248D4 File Offset: 0x00022AD4
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

		// Token: 0x0600048E RID: 1166 RVA: 0x00024904 File Offset: 0x00022B04
		private void method_15(byte[] byte_0, int int_2, int int_3, byte[] byte_1, byte byte_2, uint uint_0)
		{
			int num = byte_1.Length;
			int int_4 = this.method_16(int_3);
			if (num == 64)
			{
				this.method_21(int_4, byte_1, byte_0, int_2);
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
					int[] int_5 = this.method_17(byte_3, byte_2, 4, 1, 1);
					byte[] array = this.method_19(byte_1, int_5);
					memoryStream.Write(array, 0, array.Length);
					byte_3 = (byte)(b >> 4);
					int_5 = this.method_17(byte_3, byte_2, 4, 1, 1);
					array = this.method_19(byte_1, int_5);
					memoryStream.Write(array, 0, array.Length);
				}
				this.method_21(int_4, memoryStream.ToArray(), byte_0, int_2);
				return;
			}
			if (num == 20)
			{
				uint num3 = 4U;
				for (int j = 0; j < 16; j++)
				{
					byte byte_4 = byte_1[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)j)))))];
					int[] int_6 = this.method_17(byte_4, byte_2, 4, 2, 3);
					byte[] array = this.method_19(byte_1, int_6);
					memoryStream.Write(array, 0, array.Length);
				}
				this.method_21(int_4, memoryStream.ToArray(), byte_0, int_2);
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
						int[] int_7 = this.method_18(byte_5, byte_6);
						byte[] array = this.method_19(byte_1, int_7);
						memoryStream.Write(array, 0, array.Length);
					}
				}
				this.method_21(int_4, memoryStream.ToArray(), byte_0, int_2);
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00024AAC File Offset: 0x00022CAC
		private int method_16(int int_2)
		{
			int num = int_2 / 32;
			int num2 = int_2 % 32;
			return num / 4 * 64 + num % 4 * 4 + num2 * 1024;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00024AD8 File Offset: 0x00022CD8
		private int[] method_17(byte byte_0, byte byte_1, int int_2, byte byte_2, byte byte_3)
		{
			int[] array = new int[4];
			for (int i = 0; i < int_2; i++)
			{
				array[i] = (byte_0 >> (int)byte_2 * i & (int)byte_3);
			}
			return array;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00024B08 File Offset: 0x00022D08
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

		// Token: 0x06000492 RID: 1170 RVA: 0x00024B38 File Offset: 0x00022D38
		private byte[] method_19(byte[] byte_0, int[] int_2)
		{
			byte[] array = new byte[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = byte_0[int_2[i]];
			}
			return array;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000499B File Offset: 0x00002B9B
		private byte method_20(byte byte_0, byte byte_1)
		{
			return (byte)(byte_0 >> (int)byte_1 & 1);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00024B64 File Offset: 0x00022D64
		private void method_21(int int_2, byte[] byte_0, byte[] byte_1, int int_3)
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						int num2 = int_2 + i * 16 + j + k * 256;
						byte_1[num2 + int_3] = byte_0[num++];
					}
				}
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00024BB8 File Offset: 0x00022DB8
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

		// Token: 0x06000496 RID: 1174 RVA: 0x00024C0C File Offset: 0x00022E0C
		private uint method_23(byte byte_0)
		{
			byte_0 = ((byte_0 <= 3) ? byte_0 : (byte_0 - 4));
			uint result = 0U;
			if (byte_0 == 0)
			{
				result = 10U;
			}
			else if (byte_0 == 1)
			{
				result = 20U;
			}
			else if (byte_0 == 2)
			{
				result = 48U;
			}
			else if (byte_0 == 3)
			{
				result = 64U;
			}
			return result;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000049A6 File Offset: 0x00002BA6
		private uint method_24(byte byte_0, byte byte_1)
		{
			return (uint)((byte_0 & 252) / 2 + byte_1 * 128);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00004960 File Offset: 0x00002B60
		private void method_25(string string_0, byte[] byte_0)
		{
			FileUtils.WriteFile(byte_0, Working.smethod_5() + Working.smethod_14() + string_0);
		}

		// Token: 0x04000249 RID: 585
		private int[] int_0 = new int[]
		{
			0,
			0,
			1,
			1,
			2,
			2
		};

		// Token: 0x0400024A RID: 586
		private int[] int_1 = new int[]
		{
			0,
			16384,
			0,
			16384,
			0,
			16384
		};

		// Token: 0x0400024B RID: 587
		private Class37 class37_0 = new Class37();

		// Token: 0x0400024C RID: 588
		private TU17ChunkData tu17ChunkData_0 = new TU17ChunkData();
	}
}
