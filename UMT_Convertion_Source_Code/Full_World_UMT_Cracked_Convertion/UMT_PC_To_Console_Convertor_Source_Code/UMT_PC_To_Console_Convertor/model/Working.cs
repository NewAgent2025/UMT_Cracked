using System;
using System.IO;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000B6 RID: 182
	public static class Working
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00006435 File Offset: 0x00004635
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0000643C File Offset: 0x0000463C
		public static bool DataChanged
		{
			get
			{
				return Working.bool_0;
			}
			set
			{
				Working.bool_0 = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00006444 File Offset: 0x00004644
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0000644B File Offset: 0x0000464B
		internal static Enum2 GameType
		{
			get
			{
				return Working.enum2_0;
			}
			set
			{
				Working.enum2_0 = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00006453 File Offset: 0x00004653
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0000645A File Offset: 0x0000465A
		public static short WorldVersionMajor
		{
			get
			{
				return Working.short_0;
			}
			set
			{
				Working.short_0 = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00006462 File Offset: 0x00004662
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00006469 File Offset: 0x00004669
		public static short WorldVersionMinor
		{
			get
			{
				return Working.short_1;
			}
			set
			{
				Working.short_1 = value;
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00006471 File Offset: 0x00004671
		internal static string smethod_0()
		{
			return Working.string_3[(int)Working.enum2_0];
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000647E File Offset: 0x0000467E
		internal static string smethod_1()
		{
			return Working.string_4[(int)Working.enum2_0];
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0000648B File Offset: 0x0000468B
		internal static string smethod_2()
		{
			return Working.string_5[(int)Working.enum2_0];
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00006498 File Offset: 0x00004698
		internal static string smethod_3()
		{
			return Working.string_6[(int)Working.enum2_0];
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000064A5 File Offset: 0x000046A5
		internal static string smethod_4()
		{
			return Working.string_7[(int)Working.enum2_0];
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000064B2 File Offset: 0x000046B2
		public static string[] WorkFolders
		{
			get
			{
				return Working.string_7;
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000064B9 File Offset: 0x000046B9
		internal static string smethod_5()
		{
			return Working.string_0;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000064C0 File Offset: 0x000046C0
		internal static void smethod_6(string value)
		{
			Working.string_0 = value;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000064C8 File Offset: 0x000046C8
		internal static string smethod_7()
		{
			return Working.string_1;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000064CF File Offset: 0x000046CF
		internal static void smethod_8(string value)
		{
			Working.string_1 = value;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000064D7 File Offset: 0x000046D7
		internal static void smethod_9(string value)
		{
			Working.string_2 = value;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x000064DF File Offset: 0x000046DF
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x000064E6 File Offset: 0x000046E6
		internal static int SpawnX
		{
			get
			{
				return Working.int_3;
			}
			set
			{
				Working.int_3 = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000064EE File Offset: 0x000046EE
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x000064F5 File Offset: 0x000046F5
		internal static int SpawnY
		{
			get
			{
				return Working.int_4;
			}
			set
			{
				Working.int_4 = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000064FD File Offset: 0x000046FD
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00006504 File Offset: 0x00004704
		internal static int SpawnZ
		{
			get
			{
				return Working.int_5;
			}
			set
			{
				Working.int_5 = value;
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000650C File Offset: 0x0000470C
		internal static int smethod_10()
		{
			return Working.int_6;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00006513 File Offset: 0x00004713
		internal static void smethod_11(int value)
		{
			Working.int_6 = value;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0000651B File Offset: 0x0000471B
		internal static int smethod_12()
		{
			return Working.int_7;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00006522 File Offset: 0x00004722
		internal static void smethod_13(int value)
		{
			Working.int_7 = value;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000652A File Offset: 0x0000472A
		internal static string smethod_14()
		{
			return "debug\\";
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
		internal static bool smethod_15(string string_8)
		{
			bool flag = string_8.ToLower() == "savegame.dat";
			bool flag2 = string_8.ToLower() == "gamedata";
			bool flag3 = string_8.ToLower() == "savegame.wii";
			if (flag)
			{
				Working.GameType = (Enum2)1;
			}
			else if (flag2)
			{
				Working.GameType = (Enum2)2;
			}
			else if (flag3)
			{
				Working.GameType = (Enum2)3;
			}
			else
			{
				Working.GameType = (Enum2)0;
			}
			return flag || flag2 || flag3;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002F324 File Offset: 0x0002D524
		internal static bool smethod_16(string string_8)
		{
			bool flag = File.Exists(FileUtils.CheckFolderSep(string_8) + Working.string_4[1]);
			bool flag2 = File.Exists(FileUtils.CheckFolderSep(string_8) + Working.string_4[2]);
			bool flag3 = File.Exists(FileUtils.CheckFolderSep(string_8) + Working.string_4[3]);
			if (flag)
			{
				Working.GameType = (Enum2)1;
			}
			else if (flag2)
			{
				Working.GameType = (Enum2)2;
			}
			else if (flag3)
			{
				Working.GameType = (Enum2)3;
			}
			else
			{
				Working.GameType = (Enum2)0;
			}
			return flag || flag2 || flag3;
		}

		// Token: 0x040004D9 RID: 1241
		private static int int_0 = Environment.ProcessorCount;

		// Token: 0x040004DA RID: 1242
		private static int int_1 = Working.int_0 * 2;

		// Token: 0x040004DB RID: 1243
		private static int int_2 = 101;

		// Token: 0x040004DC RID: 1244
		private static bool bool_0 = false;

		// Token: 0x040004DD RID: 1245
		private static string string_0 = "";

		// Token: 0x040004DE RID: 1246
		private static string string_1 = "";

		// Token: 0x040004DF RID: 1247
		private static string string_2 = "";

		// Token: 0x040004E0 RID: 1248
		private static string[] string_3 = new string[]
		{
			"",
			"XBOX",
			"PS",
			"Wii"
		};

		// Token: 0x040004E1 RID: 1249
		private static string[] string_4 = new string[]
		{
			"",
			"savegame_working.dat",
			"gamedata_working",
			"savegame_working.wii"
		};

		// Token: 0x040004E2 RID: 1250
		private static string[] string_5 = new string[]
		{
			"",
			"savegame.dat",
			"GAMEDATA",
			"savegame.wii"
		};

		// Token: 0x040004E3 RID: 1251
		private static string[] string_6 = new string[]
		{
			"",
			"savegame_new.dat",
			"gamedata_new",
			"savegame_new.wii"
		};

		// Token: 0x040004E4 RID: 1252
		private static string[] string_7 = new string[]
		{
			"",
			"XBOX\\",
			"PS\\",
			"WII\\"
		};

		// Token: 0x040004E5 RID: 1253
		private static Enum2 enum2_0 = (Enum2)0;

		// Token: 0x040004E6 RID: 1254
		private static short short_0 = 0;

		// Token: 0x040004E7 RID: 1255
		private static short short_1 = 0;

		// Token: 0x040004E8 RID: 1256
		private static int int_3;

		// Token: 0x040004E9 RID: 1257
		private static int int_4;

		// Token: 0x040004EA RID: 1258
		private static int int_5;

		// Token: 0x040004EB RID: 1259
		private static int int_6;

		// Token: 0x040004EC RID: 1260
		private static int int_7;
	}
}
