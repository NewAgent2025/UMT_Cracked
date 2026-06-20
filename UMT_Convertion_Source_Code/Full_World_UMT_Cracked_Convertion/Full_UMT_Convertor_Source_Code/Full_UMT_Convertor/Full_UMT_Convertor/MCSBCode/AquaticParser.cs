using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x0200007F RID: 127
	public class AquaticParser
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00004C41 File Offset: 0x00002E41
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004C49 File Offset: 0x00002E49
		public AquaticChunkData AquaticChunk
		{
			get
			{
				return this.aquaticChunkData_0;
			}
			set
			{
				this.aquaticChunkData_0 = value;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000282B4 File Offset: 0x000264B4
		public void ParseChunk(string path)
		{
			MemoryStream stream = Class46.smethod_68(path);
			this.ParseChunk(stream);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000282D0 File Offset: 0x000264D0
		public AquaticChunkData ParseChunk(byte[] chunkBytes)
		{
			MemoryStream stream = new MemoryStream(chunkBytes);
			return this.ParseChunk(stream);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00004C52 File Offset: 0x00002E52
		public AquaticChunkData ParseChunk(MemoryStream stream)
		{
			this.method_0(stream);
			return this.aquaticChunkData_0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000282EC File Offset: 0x000264EC
		private void method_0(MemoryStream memoryStream_0)
		{
			memoryStream_0.Seek(0L, SeekOrigin.Begin);
			short num = this.class47_0.method_2(memoryStream_0);
			int num2 = 0;
			if (num == 12)
			{
				if (num == 12)
				{
					num2 = 26;
				}
				this.aquaticChunkData_0.X = this.class47_0.method_4(memoryStream_0);
				this.aquaticChunkData_0.Z = this.class47_0.method_4(memoryStream_0);
				memoryStream_0.Seek((long)num2, SeekOrigin.Begin);
				this.method_10(memoryStream_0);
				this.method_4(memoryStream_0);
				this.aquaticChunkData_0.HeightMap = this.method_3(memoryStream_0);
				this.aquaticChunkData_0.TerrainPopulatedFlags = (int)this.class47_0.method_2(memoryStream_0);
				this.aquaticChunkData_0.Biomes = this.method_2(memoryStream_0);
				this.aquaticChunkData_0.NBTData = this.method_1(memoryStream_0);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000283C8 File Offset: 0x000265C8
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

		// Token: 0x060004EC RID: 1260 RVA: 0x00028428 File Offset: 0x00026628
		private byte[] method_2(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[256];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00028428 File Offset: 0x00026628
		private byte[] method_3(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[256];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00028450 File Offset: 0x00026650
		private void method_4(MemoryStream memoryStream_0)
		{
			List<byte[]> list = new List<byte[]>();
			for (int i = 0; i < 4; i++)
			{
				byte[] item = this.method_5(memoryStream_0);
				list.Add(item);
			}
			this.aquaticChunkData_0.DataGroupCount = list[0].Length + list[1].Length;
			this.method_6(list);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000284A4 File Offset: 0x000266A4
		private byte[] method_5(MemoryStream memoryStream_0)
		{
			int num = this.class47_0.method_4(memoryStream_0);
			byte[] array = new byte[(num + 1) * 128];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000284DC File Offset: 0x000266DC
		private void method_6(List<byte[]> list_1)
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
			for (int j = 0; j < list_1.Count; j++)
			{
				int num = this.int_2[j];
				int num2 = this.int_1[j];
				byte[] array2 = list_1[j];
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
			this.aquaticChunkData_0.SkyLight = array[0];
			this.aquaticChunkData_0.BlockLight = array[1];
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002860C File Offset: 0x0002680C
		private void method_7(byte[] byte_0, int int_3, byte byte_1)
		{
			for (int i = 0; i < 128; i++)
			{
				byte_0[int_3 + i] = byte_1;
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00028630 File Offset: 0x00026830
		private void method_8(byte[] byte_0, int int_3, byte[] byte_1, int int_4)
		{
			for (int i = 0; i < 128; i++)
			{
				byte_1[int_4 + i] = byte_0[int_3 + i];
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00028658 File Offset: 0x00026858
		private byte[] method_9(MemoryStream memoryStream_0)
		{
			this.class47_0.method_4(memoryStream_0);
			byte[] array = new byte[128];
			memoryStream_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002868C File Offset: 0x0002688C
		private void method_10(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[131072];
			byte[] array2 = new byte[131072];
			this.method_12(array, array2, 0, memoryStream_0);
			this.aquaticChunkData_0.Blocks = array;
			this.aquaticChunkData_0.Submerged = array2;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00004C61 File Offset: 0x00002E61
		private bool method_11(MemoryStream memoryStream_0)
		{
			return true;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000286D4 File Offset: 0x000268D4
		private void method_12(byte[] byte_0, byte[] byte_1, int int_3, MemoryStream memoryStream_0)
		{
			this.list_0 = new List<Class22>();
			byte[] array = new byte[4];
			array[2] = (byte)memoryStream_0.ReadByte();
			array[1] = (byte)memoryStream_0.ReadByte();
			array[0] = (byte)memoryStream_0.ReadByte();
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[31];
			memoryStream_0.Read(array2, 0, array2.Length);
			byte[] array3 = new byte[16];
			memoryStream_0.Read(array3, 0, array3.Length);
			if (num == 0)
			{
				return;
			}
			for (int i = 0; i < 16; i++)
			{
				int num2 = num;
				if (i < 15 && array3[i] > 0)
				{
					num2 = (int)array3[i] << 8;
				}
				num -= num2;
				byte[] array4 = new byte[128];
				memoryStream_0.Read(array4, 0, array4.Length);
				byte[] array5 = new byte[num2 - 128];
				memoryStream_0.Read(array5, 0, array5.Length);
				this.method_13(byte_0, array4, array5, i, byte_1);
				if (num == 0)
				{
					return;
				}
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000287C8 File Offset: 0x000269C8
		private void method_13(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_3, byte[] byte_3)
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						byte b = byte_1[num];
						byte b2 = byte_1[num + 1];
						int num2 = (int)(b2 & 15) << 10;
						int int_4 = int_3 * 32 + k * 8 + j * 2048 + i * 32768;
						b2 = (byte)(b2 >> 4);
						if (b2 == 0)
						{
							this.method_15(byte_0, int_4, b, (byte)num2);
						}
						else
						{
							int count = (int)(b * 4) + num2;
							int count2 = this.method_26((int)b2);
							byte[] byte_4 = byte_2.Skip(count).Take(count2).ToArray<byte>();
							this.method_17(byte_0, int_4, byte_4, byte_3);
						}
						num += 2;
					}
				}
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004C64 File Offset: 0x00002E64
		private bool method_14(int int_3)
		{
			return int_3 == 2 || int_3 == 4 || int_3 == 8 || int_3 == 16;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00028894 File Offset: 0x00026A94
		private void method_15(byte[] byte_0, int int_3, byte byte_1, byte byte_2)
		{
			byte[] array = new byte[128];
			for (int i = 0; i < array.Length; i += 2)
			{
				array[i] = byte_1;
				array[i] = byte_1;
			}
			this.method_25(byte_0, array, int_3);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000288CC File Offset: 0x00026ACC
		private byte[] method_16(byte[] byte_0, uint uint_0, uint uint_1)
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

		// Token: 0x060004FB RID: 1275 RVA: 0x000288FC File Offset: 0x00026AFC
		private void method_17(byte[] byte_0, int int_3, byte[] byte_1, byte[] byte_2)
		{
			int num = byte_1.Length;
			if (num >= 256)
			{
				this.method_25(byte_0, byte_1, int_3);
				this.method_25(byte_2, byte_1.Skip(128).ToArray<byte>(), int_3);
				return;
			}
			if (num == 128)
			{
				this.method_25(byte_0, byte_1, int_3);
				return;
			}
			MemoryStream memoryStream = new MemoryStream();
			if (num == 12)
			{
				uint num2 = 4U;
				for (int i = 0; i < 8; i++)
				{
					byte b = byte_1[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)i)))))];
					int[] int_4 = this.method_18(b);
					byte[] array = this.method_24(byte_1, int_4);
					memoryStream.Write(array, 0, array.Length);
					int_4 = this.method_18((byte)(b << 4));
					array = this.method_24(byte_1, int_4);
					memoryStream.Write(array, 0, array.Length);
				}
				this.method_25(byte_0, memoryStream.ToArray(), int_3);
				return;
			}
			if (num == 24)
			{
				uint num3 = 8U;
				for (int j = 0; j < 8; j++)
				{
					byte b2;
					byte b3;
					checked
					{
						b2 = byte_1[(int)((IntPtr)(unchecked((ulong)num3 + (ulong)((long)j))))];
						b3 = byte_1[(int)((IntPtr)(unchecked((ulong)num3 + (ulong)((long)j) + 8UL)))];
					}
					for (int k = 0; k < 2; k++)
					{
						int[] int_5 = this.method_19(b2, b3);
						byte[] array = this.method_24(byte_1, int_5);
						memoryStream.Write(array, 0, array.Length);
						b2 = (byte)(b2 << 4);
						b3 = (byte)(b3 << 4);
					}
				}
				this.method_25(byte_0, memoryStream.ToArray(), int_3);
				return;
			}
			if (num == 40)
			{
				uint num4 = 16U;
				for (int l = 0; l < 8; l++)
				{
					byte b4;
					byte b5;
					byte b6;
					checked
					{
						b4 = byte_1[(int)((IntPtr)(unchecked((ulong)num4 + (ulong)((long)l))))];
						b5 = byte_1[(int)((IntPtr)(unchecked((ulong)num4 + (ulong)((long)l) + 8UL)))];
						b6 = byte_1[(int)((IntPtr)(unchecked((ulong)num4 + (ulong)((long)l) + 16UL)))];
					}
					for (int m = 0; m < 2; m++)
					{
						int[] int_6 = this.method_20((int)b4, (int)b5, (int)b6);
						byte[] array = this.method_24(byte_1, int_6);
						memoryStream.Write(array, 0, array.Length);
						b4 = (byte)(b4 << 4);
						b5 = (byte)(b5 << 4);
						b6 = (byte)(b6 << 4);
					}
				}
				this.method_25(byte_0, memoryStream.ToArray(), int_3);
				return;
			}
			if (num == 64)
			{
				uint num5 = 32U;
				for (int n = 0; n < 8; n++)
				{
					byte b7;
					byte b8;
					byte b9;
					byte b10;
					checked
					{
						b7 = byte_1[(int)((IntPtr)(unchecked((ulong)num5 + (ulong)((long)n))))];
						b8 = byte_1[(int)((IntPtr)(unchecked((ulong)num5 + (ulong)((long)n) + 8UL)))];
						b9 = byte_1[(int)((IntPtr)(unchecked((ulong)num5 + (ulong)((long)n) + 16UL)))];
						b10 = byte_1[(int)((IntPtr)(unchecked((ulong)num5 + (ulong)((long)n) + 24UL)))];
					}
					for (int num6 = 0; num6 < 2; num6++)
					{
						int[] int_7 = this.method_21(b7, b8, b9, b10);
						byte[] array = this.method_24(byte_1, int_7);
						memoryStream.Write(array, 0, array.Length);
						b7 = (byte)(b7 << 4);
						b8 = (byte)(b8 << 4);
						b9 = (byte)(b9 << 4);
						b10 = (byte)(b10 << 4);
					}
				}
				this.method_25(byte_0, memoryStream.ToArray(), int_3);
				return;
			}
			if (num == 96)
			{
				uint num7 = 32U;
				for (int num8 = 0; num8 < 32; num8 += 2)
				{
					checked
					{
						byte byte_3 = byte_1[(int)((IntPtr)(unchecked((ulong)num7 + (ulong)((long)num8))))];
						byte byte_4 = byte_1[(int)((IntPtr)(unchecked((ulong)num7 + (ulong)((long)num8) + 1UL)))];
						int[] int_8 = this.method_23(byte_3, byte_4);
						byte[] array = this.method_24(byte_1, int_8);
						memoryStream.Write(array, 0, array.Length);
					}
				}
				this.method_25(byte_0, memoryStream.ToArray(), int_3);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00028C60 File Offset: 0x00026E60
		private int[] method_18(byte byte_0)
		{
			int[] array = new int[4];
			for (int i = 0; i < 4; i++)
			{
				int num = ((128 & byte_0) > 0) ? 1 : 0;
				array[i] = num;
				byte_0 = (byte)(byte_0 << 1);
			}
			return array;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00028C9C File Offset: 0x00026E9C
		private int[] method_19(byte byte_0, byte byte_1)
		{
			int[] array = new int[4];
			for (int i = 0; i < 4; i++)
			{
				int num = ((128 & byte_0) > 0) ? 1 : 0;
				num += (((128 & byte_1) > 0) ? 2 : 0);
				array[i] = num;
				byte_0 = (byte)(byte_0 << 1);
				byte_1 = (byte)(byte_1 << 1);
			}
			return array;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00028CF0 File Offset: 0x00026EF0
		private int[] method_20(int int_3, int int_4, int int_5)
		{
			int[] array = new int[4];
			for (int i = 0; i < 4; i++)
			{
				int num = ((128 & int_3) > 0) ? 1 : 0;
				num += (((128 & int_4) > 0) ? 2 : 0);
				num += (((128 & int_5) > 0) ? 4 : 0);
				array[i] = num;
				int_3 = (int)((byte)(int_3 << 1));
				int_4 = (int)((byte)(int_4 << 1));
				int_5 = (int)((byte)(int_5 << 1));
			}
			return array;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00028D5C File Offset: 0x00026F5C
		private int[] method_21(byte byte_0, byte byte_1, byte byte_2, byte byte_3)
		{
			int[] array = new int[4];
			for (int i = 0; i < 4; i++)
			{
				int num = ((128 & byte_0) > 0) ? 1 : 0;
				num += (((128 & byte_1) > 0) ? 2 : 0);
				num += (((128 & byte_2) > 0) ? 4 : 0);
				num += (((128 & byte_3) > 0) ? 8 : 0);
				array[i] = num;
				byte_0 = (byte)(byte_0 << 1);
				byte_1 = (byte)(byte_1 << 1);
				byte_2 = (byte)(byte_2 << 1);
				byte_3 = (byte)(byte_3 << 1);
			}
			return array;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00028DE0 File Offset: 0x00026FE0
		private int method_22(int int_3)
		{
			int num = int_3 / 32;
			int num2 = int_3 % 32;
			return num / 4 * 64 + num % 4 * 4 + num2 * 1024;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00028E0C File Offset: 0x0002700C
		private int[] method_23(byte byte_0, byte byte_1)
		{
			return new int[]
			{
				(int)(byte_0 & 15),
				byte_0 >> 4,
				(int)(byte_1 & 15),
				byte_1 >> 4
			};
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00028E3C File Offset: 0x0002703C
		private byte[] method_24(byte[] byte_0, int[] int_3)
		{
			byte[] array = new byte[8];
			for (int i = 0; i < 4; i++)
			{
				int num = int_3[i] * 2;
				array[i * 2] = byte_0[num];
				array[i * 2 + 1] = byte_0[num + 1];
			}
			return array;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004C7B File Offset: 0x00002E7B
		private byte vvbYstrOjH(byte byte_0, byte byte_1)
		{
			return (byte)(byte_0 >> (int)byte_1 & 1);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00028E78 File Offset: 0x00027078
		private void method_25(byte[] byte_0, byte[] byte_1, int int_3)
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						int num2 = i * 8192 + j * 512 + k * 2;
						byte_0[num2 + int_3] = byte_1[num++];
						byte_0[num2 + int_3 + 1] = byte_1[num++];
					}
				}
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00028EDC File Offset: 0x000270DC
		private int method_26(int int_3)
		{
			int result = 0;
			if (int_3 == 2)
			{
				result = 12;
			}
			else if (int_3 == 4)
			{
				result = 24;
			}
			else if (int_3 == 6)
			{
				result = 40;
			}
			else if (int_3 == 7)
			{
				result = 64;
			}
			else if (int_3 == 8)
			{
				result = 64;
			}
			else if (int_3 == 9)
			{
				result = 96;
			}
			else if (int_3 == 14)
			{
				result = 128;
			}
			else if (int_3 == 15)
			{
				result = 256;
			}
			return result;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004C86 File Offset: 0x00002E86
		private uint method_27(byte byte_0, byte byte_1)
		{
			return (uint)((byte_0 & 252) / 2 + byte_1 * 128);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00004C99 File Offset: 0x00002E99
		private void method_28(string string_0, byte[] byte_0)
		{
			FileUtils.WriteFile(byte_0, Working.smethod_5() + Working.smethod_14() + string_0);
		}

		// Token: 0x04000327 RID: 807
		private int[] int_0 = new int[]
		{
			10,
			20,
			48,
			64
		};

		// Token: 0x04000328 RID: 808
		private int[] int_1 = new int[]
		{
			0,
			0,
			1,
			1,
			2,
			2
		};

		// Token: 0x04000329 RID: 809
		private int[] int_2 = new int[]
		{
			0,
			16384,
			0,
			16384,
			0,
			16384
		};

		// Token: 0x0400032A RID: 810
		private Class47 class47_0 = new Class47();

		// Token: 0x0400032B RID: 811
		private AquaticChunkData aquaticChunkData_0 = new AquaticChunkData();

		// Token: 0x0400032C RID: 812
		private List<Class22> list_0 = new List<Class22>();
	}
}
