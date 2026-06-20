using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PS3GameResigner.PS3Support
{
	// Token: 0x0200001A RID: 26
	public sealed class Crc32 : HashAlgorithm
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00002B01 File Offset: 0x00000D01
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public Crc32(uint polynomial, uint seed)
		{
			this.uint_2 = Crc32.smethod_0(polynomial);
			this.uint_3 = seed;
			this.uint_1 = seed;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002B0F File Offset: 0x00000D0F
		public override void Initialize()
		{
			this.uint_3 = this.uint_1;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002B1D File Offset: 0x00000D1D
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			this.uint_3 = Crc32.smethod_1(this.uint_2, this.uint_3, buffer, start, length);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		protected override byte[] HashFinal()
		{
			byte[] array = Crc32.smethod_2(~this.uint_3);
			this.HashValue = array;
			return array;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002B39 File Offset: 0x00000D39
		public override int HashSize
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002B3D File Offset: 0x00000D3D
		public static uint Compute(byte[] buffer)
		{
			return Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002B46 File Offset: 0x00000D46
		public static uint Compute(uint seed, byte[] buffer)
		{
			return Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002B54 File Offset: 0x00000D54
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			return ~Crc32.smethod_1(Crc32.smethod_0(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000C700 File Offset: 0x0000A900
		private static uint[] smethod_0(uint uint_4)
		{
			if (uint_4 == 3988292384U && Crc32.uint_0 != null)
			{
				return Crc32.uint_0;
			}
			uint[] array = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ uint_4);
					}
					else
					{
						num >>= 1;
					}
				}
				array[i] = num;
			}
			if (uint_4 == 3988292384U)
			{
				Crc32.uint_0 = array;
			}
			return array;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000C77C File Offset: 0x0000A97C
		private static uint smethod_1(uint[] uint_4, uint uint_5, IList<byte> ilist_0, int int_0, int int_1)
		{
			uint num = uint_5;
			for (int i = int_0; i < int_1 - int_0; i++)
			{
				num = (num >> 8 ^ uint_4[(int)((UIntPtr)((uint)ilist_0[i] ^ (num & 255U)))]);
			}
			return num;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000C7B4 File Offset: 0x0000A9B4
		private static byte[] smethod_2(uint uint_4)
		{
			byte[] bytes = BitConverter.GetBytes(uint_4);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x04000073 RID: 115
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x04000074 RID: 116
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x04000075 RID: 117
		private static uint[] uint_0;

		// Token: 0x04000076 RID: 118
		private readonly uint uint_1;

		// Token: 0x04000077 RID: 119
		private readonly uint[] uint_2;

		// Token: 0x04000078 RID: 120
		private uint uint_3;
	}
}
