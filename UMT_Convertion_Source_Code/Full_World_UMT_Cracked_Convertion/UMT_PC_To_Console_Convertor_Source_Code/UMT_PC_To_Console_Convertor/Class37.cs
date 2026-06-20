using System;
using System.IO;
using System.Text;

// Token: 0x020000CF RID: 207
internal class Class37
{
	// Token: 0x060008C0 RID: 2240 RVA: 0x00032D9C File Offset: 0x00030F9C
	internal short method_0(Stream stream_0)
	{
		byte[] array = this.method_3(stream_0, 2);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(array);
		}
		return BitConverter.ToInt16(array, 0);
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00032DC8 File Offset: 0x00030FC8
	internal ushort method_1(Stream stream_0)
	{
		byte[] array = this.method_3(stream_0, 2);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(array);
		}
		return BitConverter.ToUInt16(array, 0);
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00032DF4 File Offset: 0x00030FF4
	internal int method_2(Stream stream_0)
	{
		byte[] array = this.method_3(stream_0, 4);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(array);
		}
		return BitConverter.ToInt32(array, 0);
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00032E20 File Offset: 0x00031020
	private byte[] method_3(Stream stream_0, int int_0)
	{
		byte[] array = new byte[int_0];
		stream_0.Read(array, 0, int_0);
		return array;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00032E40 File Offset: 0x00031040
	internal string method_4(Stream stream_0)
	{
		ushort num = this.method_1(stream_0);
		byte[] array = new byte[(int)num];
		for (int i = 0; i < (int)num; i++)
		{
			byte b = (byte)stream_0.ReadByte();
			array[i] = b;
		}
		Encoding utf = Encoding.UTF8;
		return utf.GetString(array);
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00032E88 File Offset: 0x00031088
	internal int method_5(Stream stream_0)
	{
		int result = this.method_2(stream_0);
		stream_0.Seek(-4L, SeekOrigin.Current);
		return result;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00032EB0 File Offset: 0x000310B0
	internal void method_6(short short_0, Stream stream_0)
	{
		byte[] bytes = BitConverter.GetBytes(short_0);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		stream_0.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00032EDC File Offset: 0x000310DC
	internal void method_7(int int_0, Stream stream_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		stream_0.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00032F08 File Offset: 0x00031108
	internal void method_8(string string_0, MemoryStream memoryStream_0)
	{
		Encoding utf = Encoding.UTF8;
		byte[] bytes = utf.GetBytes(string_0);
		this.method_6((short)bytes.Length, memoryStream_0);
		memoryStream_0.Write(bytes, 0, bytes.Length);
	}
}
