using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.Properties;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000D0 RID: 208
	public class Utils
	{
		// Token: 0x060008CA RID: 2250 RVA: 0x00032F3C File Offset: 0x0003113C
		public static bool IsHex(IEnumerable<char> chars)
		{
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
				return true;
			}
			bool result;
			return result;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00006CE2 File Offset: 0x00004EE2
		public static string ConvertByteToHexString(byte b)
		{
			return string.Format("{0:x2}", b);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00032FB0 File Offset: 0x000311B0
		public static string ConvertByteArrayToHexString(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00032FF4 File Offset: 0x000311F4
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

		// Token: 0x060008CE RID: 2254 RVA: 0x00033060 File Offset: 0x00031260
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

		// Token: 0x060008CF RID: 2255 RVA: 0x000330C0 File Offset: 0x000312C0
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
			foreach (string changeStr in array)
			{
				BiomeChange biomeChange = BiomeChange.FromString(changeStr);
				if (biomeChange != null)
				{
					list.Add(biomeChange);
				}
			}
			return list;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00033140 File Offset: 0x00031340
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

		// Token: 0x060008D1 RID: 2257 RVA: 0x00033174 File Offset: 0x00031374
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

		// Token: 0x060008D2 RID: 2258 RVA: 0x000331C4 File Offset: 0x000313C4
		public static string CreateBlockReplaceString(List<BlockChange> blockChanges)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < blockChanges.Count; i++)
			{
				stringBuilder.Append(blockChanges[i].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00033204 File Offset: 0x00031404
		public static List<BlockChange> ConvertBlockReplaceString(string blockReplaceString)
		{
			List<BlockChange> list = new List<BlockChange>();
			string[] array = blockReplaceString.Split(new char[]
			{
				'|'
			});
			foreach (string changeStr in array)
			{
				BlockChange blockChange = BlockChange.FromString(changeStr);
				if (blockChange != null)
				{
					list.Add(blockChange);
				}
			}
			return list;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0003325C File Offset: 0x0003145C
		public static byte[] AddPreFixPostFix(byte[] buffer)
		{
			byte[] array = new byte[3];
			array[0] = 10;
			byte[] first = array;
			byte[] array2 = new byte[2];
			byte[] second = array2;
			buffer = first.Concat(buffer).ToArray<byte>();
			buffer = buffer.Concat(second).ToArray<byte>();
			return buffer;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public static string smethod_0()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\saves";
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000332A0 File Offset: 0x000314A0
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

		// Token: 0x060008D7 RID: 2263 RVA: 0x00033328 File Offset: 0x00031528
		public static int GetRegionFileCount(string regionPath)
		{
			int num = 0;
			foreach (string str in Constants.regionFileNames)
			{
				string path = FileUtils.CheckFolderSep(regionPath) + str + ".mca";
				if (File.Exists(path))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00033374 File Offset: 0x00031574
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

		// Token: 0x060008D9 RID: 2265 RVA: 0x000333BC File Offset: 0x000315BC
		public static void WriteBlocksUsedInfo(Dictionary<int, List<int>> blocksUsed, string regionName, string workingFolder)
		{
			List<int> list = blocksUsed.Keys.ToList<int>();
			list.Sort();
			using (StreamWriter streamWriter = new StreamWriter(workingFolder + regionName + ".txt"))
			{
				foreach (int key in list)
				{
					string value = Class29.smethod_1()[key].method_0();
					streamWriter.WriteLine(value);
					blocksUsed[key].Sort();
					foreach (int num in blocksUsed[key])
					{
						streamWriter.WriteLine(key.ToString() + " : " + num.ToString());
					}
				}
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000334C8 File Offset: 0x000316C8
		public static string GetLibraryFolder()
		{
			Settings settings = new Settings();
			string libraryPath = settings.LibraryPath;
			return FileUtils.CheckFolderSep(libraryPath);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000334EC File Offset: 0x000316EC
		public static string GetBlockReplaceDefFolder()
		{
			Settings settings = new Settings();
			string brdpath = settings.BRDPath;
			return FileUtils.CheckFolderSep(brdpath);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00033510 File Offset: 0x00031710
		public static void SaveMCPCFolder(string mcpcFolder)
		{
			new Settings
			{
				String_0 = FileUtils.CheckFolderSep(mcpcFolder)
			}.Save();
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00033538 File Offset: 0x00031738
		public static string ReadMCPCFolder()
		{
			Settings settings = new Settings();
			return FileUtils.CheckFolderSep(settings.String_0);
		}
	}
}
