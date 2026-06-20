using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.Properties;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x0200014A RID: 330
	public class Utils
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x0005D77C File Offset: 0x0005B97C
		public static bool IsHex(IEnumerable<char> chars)
		{
			bool result;
			using (IEnumerator<char> enumerator = chars.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					char c = enumerator.Current;
					if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00008FC1 File Offset: 0x000071C1
		public static string ConvertByteToHexString(byte b)
		{
			return string.Format("{0:x2}", b);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		public static string ConvertByteArrayToHexString(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0005D828 File Offset: 0x0005BA28
		public static byte[] ConvertHexStringToByteArray(string hexString)
		{
			byte[] array = null;
			try
			{
				if (hexString.Length % 2 == 0)
				{
					array = new byte[hexString.Length / 2];
					for (int i = 0; i < array.Length; i++)
					{
						string s = hexString.Substring(i * 2, 2);
						array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
					}
				}
			}
			catch (Exception)
			{
			}
			return array;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0005D894 File Offset: 0x0005BA94
		public static byte[] AddPreFixPostFix(byte[] buffer)
		{
			byte[] array = new byte[3];
			array[0] = 10;
			byte[] second = new byte[2];
			buffer = array.Concat(buffer).ToArray<byte>();
			buffer = buffer.Concat(second).ToArray<byte>();
			return buffer;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
		public static void SaveBiomeChanges(ConvertType converType, List<BiomeChange> biomeChanges)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Settings settings = new Settings();
			for (int i = 0; i < biomeChanges.Count; i++)
			{
				stringBuilder.Append(biomeChanges[i].ToString());
			}
			if (converType == ConvertType.TO_PC)
			{
				settings.ToPCBiomeTranslations = stringBuilder.ToString();
			}
			else
			{
				settings.FromPCBiomeTranslations = stringBuilder.ToString();
			}
			settings.Save();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0005D930 File Offset: 0x0005BB30
		public static List<BiomeChange> ReadBiomeChanges(ConvertType converType)
		{
			List<BiomeChange> list = new List<BiomeChange>();
			Settings settings = new Settings();
			string text;
			if (converType == ConvertType.TO_PC)
			{
				text = settings.ToPCBiomeTranslations;
			}
			else
			{
				text = settings.FromPCBiomeTranslations;
			}
			string[] array = text.Split(new char[]
			{
				'|'
			});
			for (int i = 0; i < array.Length; i++)
			{
				BiomeChange biomeChange = BiomeChange.FromString(array[i]);
				if (biomeChange != null)
				{
					list.Add(biomeChange);
				}
			}
			return list;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0005D998 File Offset: 0x0005BB98
		public static void SaveBlockChanges(ConvertType converType, List<BlockChange> blockChanges)
		{
			Settings settings = new Settings();
			string text = Utils.CreateBlockReplaceString(blockChanges);
			if (converType == ConvertType.TO_PC)
			{
				settings.ToPCBlockTranslations = text;
			}
			else
			{
				settings.FromPCBlockTranslations = text;
			}
			settings.Save();
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0005D9CC File Offset: 0x0005BBCC
		public static List<BlockChange> ReadBlockChanges(ConvertType converType)
		{
			Settings settings = new Settings();
			string text;
			if (converType == ConvertType.TO_PC)
			{
				text = settings.ToPCBlockTranslations;
				if (string.IsNullOrWhiteSpace(text))
				{
					text = "186,-1,187,-1,-1*-1|187,-1,186,-1,-1*-1|191,-1,192,-1,-1*-1|192,-1,191,-1,-1*-1|";
				}
			}
			else
			{
				text = settings.FromPCBlockTranslations;
				if (string.IsNullOrWhiteSpace(text))
				{
					text = "3,3:4:5:6:7:8:9:10:11:12:13:14:15,3,0,-1*-1|186,-1,187,-1,-1*-1|187,-1,186,-1,-1*-1|191,-1,192,-1,-1*-1|192,-1,191,-1,-1*-1|10000,-1,0,0,-1*-1|";
				}
			}
			return Utils.ConvertBlockReplaceString(text);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0005DA14 File Offset: 0x0005BC14
		public static string CreateBlockReplaceString(List<BlockChange> blockChanges)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < blockChanges.Count; i++)
			{
				stringBuilder.Append(blockChanges[i].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0005DA54 File Offset: 0x0005BC54
		public static List<BlockChange> ConvertBlockReplaceString(string blockReplaceString)
		{
			List<BlockChange> list = new List<BlockChange>();
			string[] array = blockReplaceString.Split(new char[]
			{
				'|'
			});
			for (int i = 0; i < array.Length; i++)
			{
				BlockChange blockChange = BlockChange.FromString(array[i]);
				if (blockChange != null)
				{
					list.Add(blockChange);
				}
			}
			return list;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00008FD3 File Offset: 0x000071D3
		public static string smethod_0()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\saves";
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0005DA9C File Offset: 0x0005BC9C
		public static bool[] GetQuickBlocksLookup(ConvertParameters convertParameters)
		{
			bool[] array = new bool[257];
			if (convertParameters.BlockChanges != null)
			{
				for (int i = 0; i < convertParameters.BlockChanges.Count; i++)
				{
					if (convertParameters.BlockChanges[i].FromBlock == -1)
					{
						array[256] = true;
					}
					else if (convertParameters.BlockChanges[i].FromBlock <= 256)
					{
						array[convertParameters.BlockChanges[i].FromBlock] = true;
					}
				}
			}
			return array;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0005DB20 File Offset: 0x0005BD20
		public static int GetRegionFileCount(string regionPath)
		{
			int num = 0;
			foreach (string str in Constants.regionFileNames)
			{
				if (File.Exists(FileUtils.CheckFolderSep(regionPath) + str + ".mca"))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0005DB64 File Offset: 0x0005BD64
		public static int ReadIntFromArray(byte[] array, int startPos)
		{
			byte[] array2 = new byte[]
			{
				array[startPos],
				array[startPos + 1],
				array[startPos + 2],
				array[startPos + 3]
			};
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array2);
			}
			return BitConverter.ToInt32(array2, 0);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0005DBAC File Offset: 0x0005BDAC
		public static void WriteBlocksUsedInfo(Dictionary<int, List<int>> blocksUsed, string regionName, string workingFolder)
		{
			List<int> list = blocksUsed.Keys.ToList<int>();
			list.Sort();
			using (StreamWriter streamWriter = new StreamWriter(Path.Combine(workingFolder, regionName + ".txt")))
			{
				foreach (int key in list)
				{
					string value = Class34.smethod_1()[key].ApfHbuxQfqb();
					streamWriter.WriteLine(value);
					blocksUsed[key].Sort();
					foreach (int num in blocksUsed[key])
					{
						streamWriter.WriteLine(key.ToString() + " : " + num.ToString());
					}
				}
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00008FE6 File Offset: 0x000071E6
		public static string GetLibraryFolder()
		{
			return FileUtils.CheckFolderSep(new Settings().LibraryPath);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00008FF7 File Offset: 0x000071F7
		public static string GetBlockReplaceDefFolder()
		{
			return FileUtils.CheckFolderSep(new Settings().BRDPath);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00009008 File Offset: 0x00007208
		public static void SaveMCPCFolder(string mcpcFolder)
		{
			new Settings
			{
				String_0 = FileUtils.CheckFolderSep(mcpcFolder)
			}.Save();
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00009020 File Offset: 0x00007220
		public static string ReadMCPCFolder()
		{
			return FileUtils.CheckFolderSep(new Settings().String_0);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00009031 File Offset: 0x00007231
		public static void SaveConvertFromPCFolder(string mcpcFolder)
		{
			new Settings
			{
				String_1 = FileUtils.CheckFolderSep(mcpcFolder)
			}.Save();
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00009049 File Offset: 0x00007249
		public static string ReadConvertFromPCFolder()
		{
			return FileUtils.CheckFolderSep(new Settings().String_1);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0000905A File Offset: 0x0000725A
		public static void SaveConvertToPCFolder(string mcpcFolder)
		{
			new Settings
			{
				ConvertToPCFolder = FileUtils.CheckFolderSep(mcpcFolder)
			}.Save();
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00009072 File Offset: 0x00007272
		public static string ReadConvertToPCFolder()
		{
			return FileUtils.CheckFolderSep(new Settings().ConvertToPCFolder);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00009083 File Offset: 0x00007283
		public static string ReadConvertToBedrockFolder()
		{
			return FileUtils.CheckFolderSep(new Settings().ConvertToBedrockFolder);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00009094 File Offset: 0x00007294
		public static void SaveConvertToBedrockFolder(string bedrockFolder)
		{
			new Settings
			{
				ConvertToBedrockFolder = FileUtils.CheckFolderSep(bedrockFolder)
			}.Save();
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00008FD3 File Offset: 0x000071D3
		public static string smethod_1()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\saves";
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0005DCB8 File Offset: 0x0005BEB8
		public static string smethod_2()
		{
			string path = "Local\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\minecraftWorlds";
			return Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), path);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0005DCE0 File Offset: 0x0005BEE0
		public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			try
			{
				result = result.AddSeconds(unixTimeStamp).ToLocalTime();
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0005DD28 File Offset: 0x0005BF28
		public static long DateTimeToUnixTimestamp()
		{
			return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0005DD5C File Offset: 0x0005BF5C
		public static int Timestamp()
		{
			DateTime now = DateTime.Now;
			return (int)((DateTime.UtcNow - now).Ticks / 10000000L);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0005DD8C File Offset: 0x0005BF8C
		public static Color GetBiomeColor(int biomeId)
		{
			uint num = 16777215U;
			if (Constants.consoleBiomeList.ContainsKey(biomeId))
			{
				num = Constants.consoleBiomeList[biomeId].Color;
			}
			num += 4278190080U;
			return Color.FromArgb((int)num);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0005DDCC File Offset: 0x0005BFCC
		public static string LibraryImagePath()
		{
			string text = "Full_UMT_Convertor\\LibraryItemImages\\";
			text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), text);
			Directory.CreateDirectory(text);
			return text;
		}
	}
}
