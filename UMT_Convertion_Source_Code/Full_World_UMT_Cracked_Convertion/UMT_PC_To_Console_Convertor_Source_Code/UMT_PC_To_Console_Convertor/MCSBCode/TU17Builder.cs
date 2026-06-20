using System;
using System.Collections.Generic;
using System.IO;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x02000064 RID: 100
	public class TU17Builder
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00004891 File Offset: 0x00002A91
		public TU17Builder()
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00004891 File Offset: 0x00002A91
		public TU17Builder(TU17ChunkData tu17Data)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00023AF0 File Offset: 0x00021CF0
		public MemoryStream BuildChunk(TU17ChunkData tu17Data)
		{
			MemoryStream memoryStream = new MemoryStream();
			this.method_0(tu17Data, memoryStream);
			this.method_1(tu17Data, memoryStream, 0);
			bool bool_ = this.method_1(tu17Data, memoryStream, 32768);
			this.method_11(tu17Data, memoryStream, bool_);
			this.method_12(tu17Data, memoryStream, bool_);
			this.method_13(tu17Data, memoryStream, bool_);
			memoryStream.Write(tu17Data.HeightMap, 0, tu17Data.HeightMap.Length);
			this.class37_0.method_6((short)tu17Data.TerrainPopulatedFlags, memoryStream);
			memoryStream.Write(tu17Data.Biomes, 0, tu17Data.HeightMap.Length);
			this.method_18(tu17Data.NBTData, memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00023B9C File Offset: 0x00021D9C
		private void method_0(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0)
		{
			this.class37_0.method_6((short)tu17ChunkData_1.TU17VersionType_0, memoryStream_0);
			this.class37_0.method_7(tu17ChunkData_1.X, memoryStream_0);
			this.class37_0.method_7(tu17ChunkData_1.Z, memoryStream_0);
			int num = 0;
			if (tu17ChunkData_1.TU17VersionType_0 == TU17VersionType.VERSION_8)
			{
				num = 8;
			}
			else if (tu17ChunkData_1.TU17VersionType_0 == TU17VersionType.VERSION_9)
			{
				num = 16;
			}
			else if (tu17ChunkData_1.TU17VersionType_0 == TU17VersionType.VERSION_10)
			{
				num = 16;
			}
			for (int i = 0; i < num; i++)
			{
				memoryStream_0.WriteByte(0);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00023C28 File Offset: 0x00021E28
		private bool method_1(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0, int int_0)
		{
			bool result = false;
			MemoryStream memoryStream = new MemoryStream();
			GClass0[] array = new GClass0[512];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new GClass0();
			}
			int num = 0;
			for (int j = 0; j < 4; j++)
			{
				int num2 = j * 64;
				for (int k = 0; k < 4; k++)
				{
					int num3 = k * 4;
					for (int l = 0; l < 32; l++)
					{
						int num4 = l * 1024;
						byte[] array2 = this.method_10(num2 + num4 + num3 + int_0, tu17ChunkData_1.Blocks);
						byte[] array3 = this.method_9(array2);
						int num5 = array3.Length;
						if (num5 == 1)
						{
							array[num].Index = 7;
							array[num].Multiplier = array3[0];
							if (array3[0] != 0)
							{
								result = true;
							}
						}
						else if (num5 <= 2)
						{
							this.method_3(array[num], memoryStream.Position, 0);
							byte[] array4 = this.method_4(array2, array3);
							memoryStream.Write(array4, 0, array4.Length);
							result = true;
						}
						else if (num5 <= 4)
						{
							this.method_3(array[num], memoryStream.Position, 1);
							byte[] array5 = this.method_5(array2, array3);
							memoryStream.Write(array5, 0, array5.Length);
							result = true;
						}
						else if (num5 <= 16)
						{
							this.method_3(array[num], memoryStream.Position, 2);
							byte[] array6 = this.method_6(array2, array3);
							memoryStream.Write(array6, 0, array6.Length);
							result = true;
						}
						else
						{
							this.method_3(array[num], memoryStream.Position, 3);
							memoryStream.Write(array2, 0, array2.Length);
							result = true;
						}
						num++;
					}
				}
			}
			this.method_2(array, memoryStream, memoryStream_0);
			return result;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00023DD0 File Offset: 0x00021FD0
		private void method_2(GClass0[] gclass0_0, MemoryStream memoryStream_0, MemoryStream memoryStream_1)
		{
			int int_ = (int)(1024L + memoryStream_0.Length);
			this.class37_0.method_7(int_, memoryStream_1);
			for (int i = 0; i < 512; i++)
			{
				memoryStream_1.WriteByte(gclass0_0[i].Index);
				memoryStream_1.WriteByte(gclass0_0[i].Multiplier);
			}
			memoryStream_0.Seek(0L, SeekOrigin.Begin);
			int num = 0;
			while ((long)num < memoryStream_0.Length)
			{
				memoryStream_1.WriteByte((byte)memoryStream_0.ReadByte());
				num++;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000048A4 File Offset: 0x00002AA4
		private void method_3(GClass0 gclass0_0, long long_0, int int_0)
		{
			gclass0_0.Index = (byte)(long_0 % 128L * 2L + (long)int_0);
			gclass0_0.Multiplier = (byte)(long_0 / 128L);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00023E58 File Offset: 0x00022058
		private byte[] method_4(byte[] byte_0, byte[] byte_1)
		{
			byte[] array = this.method_8(byte_1, 2, 8);
			int num = 2;
			for (int i = 0; i < 16; i += 2)
			{
				byte b = 0;
				int num2 = i * 4;
				for (int j = 3; j >= 0; j--)
				{
					int num3 = this.method_7(byte_0[num2 + j + 4], byte_1);
					b = (byte)(((int)b << 1) + num3);
				}
				for (int k = 3; k >= 0; k--)
				{
					int num4 = this.method_7(byte_0[num2 + k], byte_1);
					b = (byte)(((int)b << 1) + num4);
				}
				array[num++] = b;
			}
			return array;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00023EE0 File Offset: 0x000220E0
		private byte[] method_5(byte[] byte_0, byte[] byte_1)
		{
			byte[] array = this.method_8(byte_1, 4, 16);
			int num = 4;
			for (int i = 0; i < 16; i++)
			{
				byte b = 0;
				for (int j = 3; j >= 0; j--)
				{
					int num2 = this.method_7(byte_0[i * 4 + j], byte_1);
					b = (byte)(((int)b << 2) + num2);
				}
				array[num++] = b;
			}
			return array;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00023F3C File Offset: 0x0002213C
		private byte[] method_6(byte[] byte_0, byte[] byte_1)
		{
			byte[] array = this.method_8(byte_1, 16, 32);
			int num = 16;
			for (int i = 0; i < 16; i++)
			{
				int num2 = 0;
				for (int j = 3; j >= 0; j--)
				{
					int num3 = this.method_7(byte_0[i * 4 + j], byte_1);
					num2 = (num2 << 4) + num3;
				}
				array[num++] = (byte)(num2 & 255);
				array[num++] = (byte)(num2 >> 8);
			}
			return array;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00023FAC File Offset: 0x000221AC
		private int method_7(byte byte_0, byte[] byte_1)
		{
			int result = 0;
			for (int i = 0; i < byte_1.Length; i++)
			{
				if (byte_0 == byte_1[i])
				{
					result = i;
					return result;
				}
			}
			return result;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00023FD8 File Offset: 0x000221D8
		private byte[] method_8(byte[] byte_0, int int_0, int int_1)
		{
			byte[] array = new byte[int_0 + int_1];
			for (int i = 0; i < int_0; i++)
			{
				array[i] = byte.MaxValue;
			}
			for (int j = 0; j < byte_0.Length; j++)
			{
				array[j] = byte_0[j];
			}
			return array;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00024018 File Offset: 0x00022218
		private byte[] method_9(byte[] byte_0)
		{
			List<byte> list = new List<byte>();
			for (int i = 0; i < byte_0.Length; i++)
			{
				if (!list.Contains(byte_0[i]))
				{
					list.Add(byte_0[i]);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00024054 File Offset: 0x00022254
		private byte[] method_10(int int_0, byte[] byte_0)
		{
			byte[] array = new byte[64];
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				int num2 = i * 16;
				for (int j = 0; j < 4; j++)
				{
					int num3 = j;
					for (int k = 0; k < 4; k++)
					{
						int num4 = k * 256;
						byte b = byte_0[int_0 + num2 + num4 + num3];
						array[num++] = b;
					}
				}
			}
			return array;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000048D7 File Offset: 0x00002AD7
		private void method_11(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0, bool bool_0)
		{
			this.method_15(tu17ChunkData_1.BlockData, 0, 0, memoryStream_0);
			if (bool_0)
			{
				this.method_15(tu17ChunkData_1.BlockData, 16384, 0, memoryStream_0);
				return;
			}
			this.method_14(tu17ChunkData_1.BlockData, 16384, 0, memoryStream_0);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000240C4 File Offset: 0x000222C4
		private void method_12(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0, bool bool_0)
		{
			this.method_15(tu17ChunkData_1.SkyLight, 0, 255, memoryStream_0);
			if (bool_0)
			{
				this.method_15(tu17ChunkData_1.SkyLight, 16384, 255, memoryStream_0);
				return;
			}
			this.method_14(tu17ChunkData_1.SkyLight, 16384, 255, memoryStream_0);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00004912 File Offset: 0x00002B12
		private void method_13(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0, bool bool_0)
		{
			this.method_15(tu17ChunkData_1.BlockLight, 0, 0, memoryStream_0);
			if (bool_0)
			{
				this.method_15(tu17ChunkData_1.BlockLight, 16384, 0, memoryStream_0);
				return;
			}
			this.method_14(tu17ChunkData_1.SkyLight, 16384, 255, memoryStream_0);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00024118 File Offset: 0x00022318
		private void method_14(byte[] byte_0, int int_0, int int_1, MemoryStream memoryStream_0)
		{
			byte[] array = new byte[128];
			for (int i = 0; i < 128; i++)
			{
				array[i] = ((int_1 == 0) ? 128 : 129);
			}
			this.method_16(0, memoryStream_0);
			memoryStream_0.Write(array, 0, array.Length);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0002416C File Offset: 0x0002236C
		private void method_15(byte[] byte_0, int int_0, int int_1, MemoryStream memoryStream_0)
		{
			byte[] array = new byte[128];
			List<byte[]> list = new List<byte[]>();
			int i = 0;
			while (i < 128)
			{
				int int_2 = int_0 + i * 128;
				bool flag;
				byte[] array2 = this.method_17(byte_0, int_2, int_1, out flag);
				byte b = array2[0];
				if (!flag)
				{
					goto IL_48;
				}
				if (array2[0] != 0)
				{
					if (array2[0] != 255)
					{
						goto IL_48;
					}
				}
				array[i] = ((b == 0) ? 128 : 129);
				IL_5A:
				i++;
				continue;
				IL_48:
				array[i] = (byte)list.Count;
				list.Add(array2);
				goto IL_5A;
			}
			this.method_16(list.Count, memoryStream_0);
			memoryStream_0.Write(array, 0, array.Length);
			for (int j = 0; j < list.Count; j++)
			{
				memoryStream_0.Write(list[j], 0, list[j].Length);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00004951 File Offset: 0x00002B51
		private void method_16(int int_0, MemoryStream memoryStream_0)
		{
			this.class37_0.method_7(int_0, memoryStream_0);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00024244 File Offset: 0x00022444
		private byte[] method_17(byte[] byte_0, int int_0, int int_1, out bool bool_0)
		{
			byte[] array = new byte[128];
			bool_0 = true;
			byte b = byte_0[int_0];
			for (int i = 0; i < 128; i++)
			{
				array[i] = byte_0[int_0 + i];
				if (array[i] != b)
				{
					bool_0 = false;
				}
			}
			return array;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00024290 File Offset: 0x00022490
		private void method_18(TagNodeCompound tagNodeCompound_0, MemoryStream memoryStream_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			NbtTree nbtTree = new NbtTree(tagNodeCompound_0);
			nbtTree.WriteTo(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			int num = 0;
			while ((long)num < memoryStream.Length)
			{
				memoryStream_0.WriteByte((byte)memoryStream.ReadByte());
				num++;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00004960 File Offset: 0x00002B60
		private void method_19(string string_0, byte[] byte_0)
		{
			FileUtils.WriteFile(byte_0, Working.smethod_5() + Working.smethod_14() + string_0);
		}

		// Token: 0x04000247 RID: 583
		private Class37 class37_0 = new Class37();

		// Token: 0x04000248 RID: 584
		private TU17ChunkData tu17ChunkData_0;
	}
}
