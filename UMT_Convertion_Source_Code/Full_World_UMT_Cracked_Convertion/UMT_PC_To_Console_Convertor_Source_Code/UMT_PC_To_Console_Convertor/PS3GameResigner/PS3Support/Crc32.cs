using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PS3GameResigner.PS3Support
{
	// Token: 0x02000019 RID: 25
	public sealed class Crc32 : HashAlgorithm
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000029AC File Offset: 0x00000BAC
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009FA8 File Offset: 0x000081A8
		public Crc32(uint polynomial, uint seed)
		{
			this.uint_2 = Crc32.smethod_0(polynomial);
			this.uint_3 = seed;
			this.uint_1 = seed;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000029BA File Offset: 0x00000BBA
		public override void Initialize()
		{
			this.uint_3 = this.uint_1;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000029C8 File Offset: 0x00000BC8
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			this.uint_3 = Crc32.smethod_1(this.uint_2, this.uint_3, buffer, start, length);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00009FD8 File Offset: 0x000081D8
		protected override byte[] HashFinal()
		{
			byte[] array = Crc32.smethod_2(~this.uint_3);
			this.HashValue = array;
			return array;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000029E4 File Offset: 0x00000BE4
		public override int HashSize
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000029E8 File Offset: 0x00000BE8
		public static uint Compute(byte[] buffer)
		{
			return Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000029F1 File Offset: 0x00000BF1
		public static uint Compute(uint seed, byte[] buffer)
		{
			return Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000029FF File Offset: 0x00000BFF
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			return ~Crc32.smethod_1(Crc32.smethod_0(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00009FFC File Offset: 0x000081FC
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

		// Token: 0x060000B4 RID: 180 RVA: 0x0000A078 File Offset: 0x00008278
		private static uint smethod_1(uint[] uint_4, uint uint_5, IList<byte> ilist_0, int int_0, int int_1)
		{
			uint num = uint_5;
			for (int i = int_0; i < int_1 - int_0; i++)
			{
				num = (num >> 8 ^ uint_4[(int)((UIntPtr)((uint)ilist_0[i] ^ (num & 255U)))]);
			}
			return num;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000A0B0 File Offset: 0x000082B0
		private static byte[] smethod_2(uint uint_4)
		{
			byte[] bytes = BitConverter.GetBytes(uint_4);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x04000066 RID: 102
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x04000067 RID: 103
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x04000068 RID: 104
		private static uint[] uint_0;

		// Token: 0x04000069 RID: 105
		private readonly uint uint_1;

		// Token: 0x0400006A RID: 106
		private readonly uint[] uint_2;

		// Token: 0x0400006B RID: 107
		private uint uint_3;
	}
}
