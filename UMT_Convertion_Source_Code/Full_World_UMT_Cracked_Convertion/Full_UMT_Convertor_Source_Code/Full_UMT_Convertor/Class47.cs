using System;
using System.IO;
using System.Text;

// Token: 0x02000149 RID: 329
internal class Class47
{
	// Token: 0x06000DD8 RID: 3544 RVA: 0x00008F8B File Offset: 0x0000718B
	public Class47()
	{
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00008F9A File Offset: 0x0000719A
	public Class47(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00008FB0 File Offset: 0x000071B0
	public bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00008FB8 File Offset: 0x000071B8
	public void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x0005D54C File Offset: 0x0005B74C
	internal short method_2(Stream stream_0)
	{
		byte[] array = this.method_6(stream_0, 2);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(array);
		}
		return BitConverter.ToInt16(array, 0);
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x0005D580 File Offset: 0x0005B780
	internal ushort method_3(Stream stream_0)
	{
		byte[] array = this.method_6(stream_0, 2);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(array);
		}
		return BitConverter.ToUInt16(array, 0);
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x0005D5B4 File Offset: 0x0005B7B4
	internal int method_4(Stream stream_0)
	{
		byte[] array = this.method_6(stream_0, 4);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(array);
		}
		return BitConverter.ToInt32(array, 0);
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x0005D5E8 File Offset: 0x0005B7E8
	internal uint method_5(Stream stream_0)
	{
		byte[] array = this.method_6(stream_0, 4);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(array);
		}
		return BitConverter.ToUInt32(array, 0);
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x0005D61C File Offset: 0x0005B81C
	private byte[] method_6(Stream stream_0, int int_0)
	{
		byte[] array = new byte[int_0];
		stream_0.Read(array, 0, int_0);
		return array;
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x0005D63C File Offset: 0x0005B83C
	internal string method_7(Stream stream_0)
	{
		ushort num = this.method_3(stream_0);
		byte[] array = new byte[(int)num];
		for (int i = 0; i < (int)num; i++)
		{
			byte b = (byte)stream_0.ReadByte();
			array[i] = b;
		}
		Encoding utf = Encoding.UTF8;
		return utf.GetString(array);
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x0005D684 File Offset: 0x0005B884
	internal int method_8(Stream stream_0)
	{
		int result = this.method_4(stream_0);
		stream_0.Seek(-4L, SeekOrigin.Current);
		return result;
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x0005D6AC File Offset: 0x0005B8AC
	internal void method_9(short short_0, Stream stream_0)
	{
		byte[] bytes = BitConverter.GetBytes(short_0);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(bytes);
		}
		stream_0.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
	internal void method_10(int int_0, Stream stream_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(bytes);
		}
		stream_0.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0005D714 File Offset: 0x0005B914
	internal void method_11(uint uint_0, Stream stream_0)
	{
		byte[] bytes = BitConverter.GetBytes(uint_0);
		if (BitConverter.IsLittleEndian && this.method_0())
		{
			Array.Reverse(bytes);
		}
		stream_0.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x0005D748 File Offset: 0x0005B948
	internal void method_12(string string_0, MemoryStream memoryStream_0)
	{
		Encoding utf = Encoding.UTF8;
		byte[] bytes = utf.GetBytes(string_0);
		this.method_9((short)bytes.Length, memoryStream_0);
		memoryStream_0.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x0400083E RID: 2110
	private bool bool_0 = true;
}
