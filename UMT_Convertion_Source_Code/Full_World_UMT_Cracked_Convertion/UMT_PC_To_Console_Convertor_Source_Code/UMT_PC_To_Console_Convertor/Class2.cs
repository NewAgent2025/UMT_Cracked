using System;
using System.IO;
using PS3FileSystem;
using PS3GameResigner.PS3Support;

// Token: 0x0200001A RID: 26
internal class Class2
{
	// Token: 0x060000B6 RID: 182 RVA: 0x0000A0D4 File Offset: 0x000082D4
	public Ps3SaveManager method_0(string string_0)
	{
		return new Ps3SaveManager(string_0, Class2.byte_0);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000A0F0 File Offset: 0x000082F0
	public void method_1(string string_0)
	{
		Ps3SaveManager ps3SaveManager = new Ps3SaveManager(string_0, Class2.byte_0);
		foreach (Ps3File ps3File in ps3SaveManager.Files)
		{
			ps3File.Decypt();
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000A12C File Offset: 0x0000832C
	public void method_2(string string_0)
	{
		Ps3SaveManager ps3SaveManager = new Ps3SaveManager(string_0, Class2.byte_0);
		ps3SaveManager.ReBuildChanges(true);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000A150 File Offset: 0x00008350
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

	// Token: 0x060000BA RID: 186 RVA: 0x0000A280 File Offset: 0x00008480
	public static string smethod_0(byte[] byte_1)
	{
		if (!BitConverter.IsLittleEndian)
		{
			Array.Reverse(byte_1);
		}
		return BitConverter.ToUInt32(byte_1, 0).ToString("X8").ToLower();
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000A2B4 File Offset: 0x000084B4
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

	// Token: 0x0400006C RID: 108
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
