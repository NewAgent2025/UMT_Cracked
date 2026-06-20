using System;
using System.IO;
using PS3FileSystem;
using PS3GameResigner.PS3Support;

// Token: 0x0200001B RID: 27
internal class Class2
{
	// Token: 0x060000D1 RID: 209 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
	public Ps3Save_Manager method_0(string string_0)
	{
		return new Ps3Save_Manager(string_0, Class2.byte_0);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
	public void method_1(string string_0)
	{
		Ps3Save_Manager ps3Save_Manager = new Ps3Save_Manager(string_0, Class2.byte_0);
		foreach (Ps3File ps3File in ps3Save_Manager.Files)
		{
			ps3File.Decypt();
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000C830 File Offset: 0x0000AA30
	public void method_2(string string_0)
	{
		Ps3Save_Manager ps3Save_Manager = new Ps3Save_Manager(string_0, Class2.byte_0);
		ps3Save_Manager.ReBuildChanges(true);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000C854 File Offset: 0x0000AA54
	public void method_3(string string_0)
	{
		Crc32 crc = new Crc32();
		string text = string.Empty;
		using (FileStream fileStream = File.Open(string_0 + "/GAMEDATA", FileMode.Open))
		{
			foreach (byte b in crc.ComputeHash(fileStream))
			{
				text += b.ToString("x2").ToLower();
			}
		}
		FileStream fileStream2 = File.Open(string_0 + "/METADATA", FileMode.Open);
		byte[] array2 = Class2.smethod_1(text);
		string string_ = Class2.smethod_0(array2);
		Class2.smethod_1(string_);
		fileStream2.Seek(12L, SeekOrigin.Begin);
		fileStream2.Write(array2, 0, 4);
		byte[] bytes;
		using (FileStream fileStream3 = File.Open(string_0 + "/GAMEDATA", FileMode.Open))
		{
			bytes = BitConverter.GetBytes(fileStream3.Length);
		}
		Array.Reverse(bytes);
		fileStream2.Seek(4L, SeekOrigin.Begin);
		fileStream2.Write(bytes, 4, 4);
		fileStream2.Close();
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000C984 File Offset: 0x0000AB84
	public static string smethod_0(byte[] byte_1)
	{
		if (!BitConverter.IsLittleEndian)
		{
			Array.Reverse(byte_1);
		}
		return BitConverter.ToUInt32(byte_1, 0).ToString("X8").ToLower();
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
	public static byte[] smethod_1(string string_0)
	{
		int length = string_0.Length;
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
		}
		return array;
	}

	// Token: 0x04000079 RID: 121
	private static byte[] byte_0 = new byte[]
	{
		238,
		169,
		55,
		204,
		91,
		212,
		217,
		13,
		85,
		237,
		37,
		49,
		250,
		51,
		189,
		196
	};
}
