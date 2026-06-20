using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using PS3FileSystem;

// Token: 0x02000005 RID: 5
internal static class Class1
{
	// Token: 0x06000020 RID: 32 RVA: 0x00009710 File Offset: 0x00007910
	public static string[] smethod_0()
	{
		return new string[]
		{
			"syscon_manager_key=D413B89663E1FE9F75143D3BB4565274",
			"keygen_key=6B1ACEA246B745FD8F93763B920594CD53483B82",
			"savegame_param_sfo_key=0C08000E090504040D010F000406020209060D03",
			"trophy_param_sfo_key=5D5B647917024E9BB8D330486B996E795D7F4392",
			"tropsys_dat_key=B080C40FF358643689281736A6BF15892CFEA436",
			"tropusr_dat_key=8711EFF406913F0937F115FAB23DE1A9897A789A",
			"troptrns_dat_key=91EE81555ACC1C4FB5AAE5462CFE1C62A4AF36A5",
			"tropconf_sfm_key=E2ED33C71C444EEBC1E23D635AD8E82F4ECA4E94",
			"fallback_disc_hash_key=D1C1E10B9C547E689B805DCD9710CE8D"
		};
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002599 File Offset: 0x00000799
	public static ushort smethod_1(this ushort ushort_0)
	{
		return (ushort)((int)(ushort_0 & 255) << 8 | (int)((uint)(ushort_0 & 65280) >> 8));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000025AF File Offset: 0x000007AF
	public static uint smethod_2(this uint uint_0)
	{
		return (uint_0 & 255U) << 24 | (uint_0 & 65280U) << 8 | (uint_0 & 16711680U) >> 8 | (uint_0 & 4278190080U) >> 24;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00009770 File Offset: 0x00007970
	public static ulong smethod_3(this ulong ulong_0)
	{
		return (ulong_0 & 18374686479671623680UL) >> 56 | (ulong_0 & 71776119061217280UL) >> 40 | (ulong_0 & 280375465082880UL) >> 24 | (ulong_0 & 1095216660480UL) >> 8 | (ulong_0 & 4278190080UL) << 8 | (ulong_0 & 16711680UL) << 24 | (ulong_0 & 65280UL) << 40 | (ulong_0 & 255UL) << 56;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000097F4 File Offset: 0x000079F4
	public static bool smethod_4(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0.Length != byte_1.Length)
		{
			return false;
		}
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (byte_0[i] != byte_1[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000982C File Offset: 0x00007A2C
	public static byte[] smethod_5(byte[] byte_0, byte[] byte_1, int int_0)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.Zeros;
		byte[] rgbKey = Class1.smethod_8("syscon_manager_key");
		if (byte_0.Length != 16)
		{
			Array.Resize<byte>(ref byte_0, 16);
		}
		return aesCryptoServiceProvider.CreateDecryptor(rgbKey, byte_0).TransformFinalBlock(byte_1, 0, int_0);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00009878 File Offset: 0x00007A78
	public static byte[] smethod_6(byte[] byte_0, byte[] byte_1, int int_0)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.Zeros;
		byte[] rgbKey = Class1.smethod_8("syscon_manager_key");
		if (byte_0.Length != 16)
		{
			Array.Resize<byte>(ref byte_0, 16);
		}
		return aesCryptoServiceProvider.CreateEncryptor(rgbKey, byte_0).TransformFinalBlock(byte_1, 0, int_0);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000098C4 File Offset: 0x00007AC4
	public static byte[] smethod_7(this string string_0)
	{
		if (string_0.Length % 2 != 0)
		{
			string_0 = string_0.PadLeft(string_0.Length + 1, '0');
		}
		IEnumerable<int> source = Enumerable.Range(0, string_0.Length);
		if (Class1.func_0 == null)
		{
			Class1.func_0 = new Func<int, bool>(Class1.smethod_19);
		}
		return (from x in source.Where(Class1.func_0)
		select Convert.ToByte(string_0.Substring(x, 2), 16)).ToArray<byte>();
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00009958 File Offset: 0x00007B58
	public static byte[] smethod_8(string string_0)
	{
		foreach (string text in Class1.smethod_0())
		{
			string text2 = text.Split(new char[]
			{
				'='
			})[0];
			if (text2.ToLower() == string_0.ToLower())
			{
				string string_ = text.Split(new char[]
				{
					'='
				})[1];
				return string_.smethod_7();
			}
		}
		return null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000099D8 File Offset: 0x00007BD8
	private static SecureFileInfo[] smethod_9()
	{
		SecureFileInfo[] result;
		try
		{
			string text = new WebClient().DownloadString("http://ps3tools.aldostools.org/games.conf");
			if (text == null || text.Length < 100)
			{
				result = new SecureFileInfo[0];
			}
			else
			{
				result = Class1.smethod_10(text);
			}
		}
		catch
		{
			result = new SecureFileInfo[0];
		}
		return result;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00009A30 File Offset: 0x00007C30
	public static SecureFileInfo[] smethod_10(string string_0)
	{
		List<SecureFileInfo> list = new List<SecureFileInfo>();
		using (StringReader stringReader = new StringReader(string_0))
		{
			string text = stringReader.ReadLine();
			while (text != null && stringReader.Peek() > -1)
			{
				if (text.Equals("; -- UNPROTECTED GAMES --"))
				{
					break;
				}
				Application.DoEvents();
			}
			string text3;
			string text2 = text3 = stringReader.ReadLine();
			while (text3 != null && stringReader.Peek() > -1 && text3.StartsWith(";"))
			{
				list.Add(new SecureFileInfo(text2.Replace(";", ""), "", "", "", false));
			}
			while (stringReader.Peek() > -1)
			{
				string text4;
				text2 = (text4 = stringReader.ReadLine());
				while (text4 != null && stringReader.Peek() > -1 && text4.StartsWith(";"))
				{
					if (text2 != null)
					{
						string name = text2.Replace(";", "");
						string text5;
						text2 = (text5 = stringReader.ReadLine());
						if (text5 != null && text5.StartsWith("["))
						{
							string id = text2;
							string text6 = stringReader.ReadLine();
							if (text6 != null)
							{
								string dischashkey = text6.Split(new char[]
								{
									'='
								})[1];
								string text7 = text6.Split(new char[]
								{
									'='
								})[1];
								list.Add(new SecureFileInfo(name, id, text7, dischashkey, !string.IsNullOrEmpty(text7) && text7.Length == 32));
							}
						}
					}
				}
			}
			stringReader.Close();
		}
		return list.ToArray();
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00009BF4 File Offset: 0x00007DF4
	public static SecureFileInfo[] smethod_11()
	{
		SecureFileInfo[] x = new SecureFileInfo[0];
		Thread thread = new Thread(delegate()
		{
			x = Class1.smethod_9();
		});
		thread.Start();
		while (thread.ThreadState != ThreadState.Stopped)
		{
			Application.DoEvents();
		}
		return x;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000025DA File Offset: 0x000007DA
	public static byte[] smethod_12(byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		return new HMACSHA1(byte_0).ComputeHash(byte_1, int_0, int_1);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00009C44 File Offset: 0x00007E44
	public static byte[] smethod_13(string string_0, byte[] byte_0)
	{
		byte[] result;
		using (FileStream fileStream = new FileStream(string_0, FileMode.Open))
		{
			result = new HMACSHA1(byte_0).ComputeHash(fileStream);
			fileStream.Close();
		}
		return result;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000025EA File Offset: 0x000007EA
	public static byte[] smethod_14(Stream stream_0, byte[] byte_0)
	{
		return new HMACSHA1(byte_0).ComputeHash(stream_0);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000025F8 File Offset: 0x000007F8
	public static byte[] smethod_15(byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		return new HMACSHA256(byte_0).ComputeHash(byte_1, int_0, int_1);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00009C8C File Offset: 0x00007E8C
	public static byte[] smethod_16(string string_0, byte[] byte_0)
	{
		byte[] result;
		using (FileStream fileStream = new FileStream(string_0, FileMode.Open))
		{
			result = new HMACSHA256(byte_0).ComputeHash(fileStream);
			fileStream.Close();
		}
		return result;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002608 File Offset: 0x00000808
	public static byte[] smethod_17(Stream stream_0, byte[] byte_0)
	{
		return new HMACSHA256(byte_0).ComputeHash(stream_0);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00009CD4 File Offset: 0x00007ED4
	public static byte[] drKtqnluP(byte[] byte_0, byte[] byte_1, int int_0)
	{
		Array.Resize<byte>(ref byte_0, 16);
		Aes aes = Aes.Create();
		aes.Key = byte_0;
		aes.BlockSize = 128;
		aes.Mode = CipherMode.ECB;
		aes.Padding = PaddingMode.Zeros;
		Aes aes2 = Aes.Create();
		aes2.Key = byte_0;
		aes.BlockSize = 128;
		aes2.Mode = CipherMode.ECB;
		aes2.Padding = PaddingMode.Zeros;
		int num = int_0 / 16;
		byte[] array = new byte[int_0];
		for (int i = 0; i < num; i++)
		{
			byte[] array2 = new byte[16];
			Array.Copy(byte_1, i * 16, array2, 0, 16);
			byte[] array3 = new byte[16];
			Array.Copy(BitConverter.GetBytes(((ulong)((long)i)).smethod_3()), 0, array3, 0, 8);
			array3 = aes.CreateEncryptor().TransformFinalBlock(array3, 0, array3.Length);
			array2 = aes2.CreateDecryptor().TransformFinalBlock(array2, 0, array2.Length);
			for (int j = 0; j < 16; j++)
			{
				byte[] array4 = array2;
				int num2 = j;
				array4[num2] ^= array3[j];
			}
			Array.Copy(array2, 0, array, i * 16, 16);
		}
		return array;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00009DF8 File Offset: 0x00007FF8
	public static byte[] smethod_18(byte[] byte_0, byte[] byte_1, int int_0)
	{
		Array.Resize<byte>(ref byte_0, 16);
		Aes aes = Aes.Create();
		aes.Key = byte_0;
		aes.BlockSize = 128;
		aes.Mode = CipherMode.ECB;
		aes.Padding = PaddingMode.Zeros;
		Aes aes2 = Aes.Create();
		aes2.Key = byte_0;
		aes.BlockSize = 128;
		aes2.Mode = CipherMode.ECB;
		aes2.Padding = PaddingMode.Zeros;
		int num = int_0 / 16;
		byte[] array = new byte[int_0];
		for (int i = 0; i < num; i++)
		{
			byte[] array2 = new byte[16];
			Array.Copy(byte_1, i * 16, array2, 0, 16);
			byte[] array3 = new byte[16];
			Array.Copy(BitConverter.GetBytes(((ulong)((long)i)).smethod_3()), 0, array3, 0, 8);
			array3 = aes.CreateEncryptor().TransformFinalBlock(array3, 0, array3.Length);
			for (int j = 0; j < 16; j++)
			{
				byte[] array4 = array2;
				int num2 = j;
				array4[num2] ^= array3[j];
			}
			array2 = aes2.CreateEncryptor().TransformFinalBlock(array2, 0, array2.Length);
			Array.Copy(array2, 0, array, i * 16, 16);
		}
		return array;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002616 File Offset: 0x00000816
	[CompilerGenerated]
	private static bool smethod_19(int int_0)
	{
		return int_0 % 2 == 0;
	}

	// Token: 0x04000012 RID: 18
	[CompilerGenerated]
	private static Func<int, bool> func_0;
}
