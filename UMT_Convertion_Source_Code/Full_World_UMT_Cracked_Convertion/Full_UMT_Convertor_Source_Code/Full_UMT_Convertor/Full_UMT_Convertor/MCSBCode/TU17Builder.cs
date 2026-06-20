using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000094 RID: 148
	public class TU17Builder
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x00005174 File Offset: 0x00003374
		public TU17Builder()
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00005174 File Offset: 0x00003374
		public TU17Builder(TU17ChunkData tu17Data)
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00038470 File Offset: 0x00036670
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
			this.class47_0.method_9((short)tu17Data.TerrainPopulatedFlags, memoryStream);
			memoryStream.Write(tu17Data.Biomes, 0, tu17Data.HeightMap.Length);
			this.method_18(tu17Data.NBTData, memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0003851C File Offset: 0x0003671C
		private void method_0(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0)
		{
			this.class47_0.method_9((short)tu17ChunkData_1.TU17VersionType_0, memoryStream_0);
			this.class47_0.method_10(tu17ChunkData_1.X, memoryStream_0);
			this.class47_0.method_10(tu17ChunkData_1.Z, memoryStream_0);
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
			else if (tu17ChunkData_1.TU17VersionType_0 == TU17VersionType.VERSION_11)
			{
				num = 16;
			}
			for (int i = 0; i < num; i++)
			{
				memoryStream_0.WriteByte(0);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000385BC File Offset: 0x000367BC
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
							this.method_3(array[num], memoryStream, 0);
							byte[] array4 = this.method_4(array2, array3);
							memoryStream.Write(array4, 0, array4.Length);
							result = true;
						}
						else if (num5 <= 4)
						{
							this.method_3(array[num], memoryStream, 1);
							byte[] array5 = this.method_5(array2, array3);
							memoryStream.Write(array5, 0, array5.Length);
							result = true;
						}
						else if (num5 <= 16)
						{
							this.method_3(array[num], memoryStream, 2);
							byte[] array6 = this.method_6(array2, array3);
							memoryStream.Write(array6, 0, array6.Length);
							result = true;
						}
						else
						{
							this.method_3(array[num], memoryStream, 3);
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

		// Token: 0x0600061A RID: 1562 RVA: 0x00038750 File Offset: 0x00036950
		private void method_2(GClass0[] gclass0_0, MemoryStream memoryStream_0, MemoryStream memoryStream_1)
		{
			int int_ = (int)(1024L + memoryStream_0.Length);
			this.class47_0.method_10(int_, memoryStream_1);
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

		// Token: 0x0600061B RID: 1563 RVA: 0x000387D8 File Offset: 0x000369D8
		private void method_3(GClass0 gclass0_0, MemoryStream memoryStream_0, int int_0)
		{
			if (int_0 == 3)
			{
				int num = (int)(memoryStream_0.Position & 3L);
				for (int i = 0; i < num; i++)
				{
					memoryStream_0.WriteByte(0);
				}
			}
			long position = memoryStream_0.Position;
			gclass0_0.Index = (byte)(position % 128L * 2L + (long)int_0);
			gclass0_0.Multiplier = (byte)(position / 128L);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00038848 File Offset: 0x00036A48
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

		// Token: 0x0600061D RID: 1565 RVA: 0x000388D0 File Offset: 0x00036AD0
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

		// Token: 0x0600061E RID: 1566 RVA: 0x0003892C File Offset: 0x00036B2C
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

		// Token: 0x0600061F RID: 1567 RVA: 0x0003899C File Offset: 0x00036B9C
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

		// Token: 0x06000620 RID: 1568 RVA: 0x000389C8 File Offset: 0x00036BC8
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

		// Token: 0x06000621 RID: 1569 RVA: 0x00038A08 File Offset: 0x00036C08
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

		// Token: 0x06000622 RID: 1570 RVA: 0x00038A44 File Offset: 0x00036C44
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

		// Token: 0x06000623 RID: 1571 RVA: 0x00005187 File Offset: 0x00003387
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

		// Token: 0x06000624 RID: 1572 RVA: 0x00038AB4 File Offset: 0x00036CB4
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

		// Token: 0x06000625 RID: 1573 RVA: 0x000051C2 File Offset: 0x000033C2
		private void method_13(TU17ChunkData tu17ChunkData_1, MemoryStream memoryStream_0, bool bool_0)
		{
			this.method_15(tu17ChunkData_1.BlockLight, 0, 0, memoryStream_0);
			if (bool_0)
			{
				this.method_15(tu17ChunkData_1.BlockLight, 16384, 0, memoryStream_0);
				return;
			}
			this.method_14(tu17ChunkData_1.SkyLight, 16384, 0, memoryStream_0);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00038B08 File Offset: 0x00036D08
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

		// Token: 0x06000627 RID: 1575 RVA: 0x00038B5C File Offset: 0x00036D5C
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

		// Token: 0x06000628 RID: 1576 RVA: 0x000051FD File Offset: 0x000033FD
		private void method_16(int int_0, MemoryStream memoryStream_0)
		{
			this.class47_0.method_10(int_0, memoryStream_0);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00038C34 File Offset: 0x00036E34
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

		// Token: 0x0600062A RID: 1578 RVA: 0x00038C80 File Offset: 0x00036E80
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

		// Token: 0x0600062B RID: 1579 RVA: 0x00004C99 File Offset: 0x00002E99
		private void method_19(string string_0, byte[] byte_0)
		{
			FileUtils.WriteFile(byte_0, Working.smethod_5() + Working.smethod_14() + string_0);
		}

		// Token: 0x040003B8 RID: 952
		private Class47 class47_0 = new Class47();

		// Token: 0x040003B9 RID: 953
		private TU17ChunkData tu17ChunkData_0;
	}
}
