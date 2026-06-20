using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000FB RID: 251
	public static class Working
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00007712 File Offset: 0x00005912
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00007719 File Offset: 0x00005919
		public static bool mapIsOpen { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00007721 File Offset: 0x00005921
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00007728 File Offset: 0x00005928
		public static bool searchIsOpen { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00007730 File Offset: 0x00005930
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00007737 File Offset: 0x00005937
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0000773F File Offset: 0x0000593F
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00007746 File Offset: 0x00005946
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0000774E File Offset: 0x0000594E
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00007755 File Offset: 0x00005955
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0000775D File Offset: 0x0000595D
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00007764 File Offset: 0x00005964
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

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0000776C File Offset: 0x0000596C
		internal static string smethod_0()
		{
			return Working.string_3[(int)Working.enum2_0];
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00007779 File Offset: 0x00005979
		internal static string smethod_1()
		{
			return Working.string_4[(int)Working.enum2_0];
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00007786 File Offset: 0x00005986
		internal static string smethod_2()
		{
			return Working.string_5[(int)Working.enum2_0];
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00007793 File Offset: 0x00005993
		internal static string smethod_3()
		{
			return Working.string_6[(int)Working.enum2_0];
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000077A0 File Offset: 0x000059A0
		internal static string smethod_4()
		{
			return Working.string_7[(int)Working.enum2_0];
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000077AD File Offset: 0x000059AD
		public static string[] WorkFolders
		{
			get
			{
				return Working.string_7;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000077B4 File Offset: 0x000059B4
		internal static string smethod_5()
		{
			return Working.string_0;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000077BB File Offset: 0x000059BB
		internal static void smethod_6(string value)
		{
			Working.string_0 = value;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000077C3 File Offset: 0x000059C3
		internal static string smethod_7()
		{
			return Working.string_1;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000077CA File Offset: 0x000059CA
		internal static void smethod_8(string value)
		{
			Working.string_1 = value;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000077D2 File Offset: 0x000059D2
		internal static void smethod_9(string value)
		{
			Working.string_2 = value;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000077DA File Offset: 0x000059DA
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x000077E1 File Offset: 0x000059E1
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000077E9 File Offset: 0x000059E9
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x000077F0 File Offset: 0x000059F0
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000077F8 File Offset: 0x000059F8
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000077FF File Offset: 0x000059FF
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

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00007807 File Offset: 0x00005A07
		internal static int smethod_10()
		{
			return Working.int_6;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000780E File Offset: 0x00005A0E
		internal static void smethod_11(int value)
		{
			Working.int_6 = value;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00007816 File Offset: 0x00005A16
		internal static int smethod_12()
		{
			return Working.int_7;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000781D File Offset: 0x00005A1D
		internal static void smethod_13(int value)
		{
			Working.int_7 = value;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00007825 File Offset: 0x00005A25
		internal static string smethod_14()
		{
			return "debug\\";
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00053E60 File Offset: 0x00052060
		internal static bool smethod_15(string string_8)
		{
			string fileName = Path.GetFileName(string_8);
			bool flag = fileName.ToLower() == "savegame.dat";
			bool flag2 = fileName.ToLower() == "gamedata";
			bool flag3 = fileName.ToLower() == "savegame.wii";
			if (!flag && !flag2 && !flag3)
			{
				flag3 = Working.smethod_16(string_8);
			}
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

		// Token: 0x06000ABA RID: 2746 RVA: 0x00053EEC File Offset: 0x000520EC
		private static bool smethod_16(string string_8)
		{
			bool result = false;
			using (FileStream fileStream = new FileStream(string_8, FileMode.Open))
			{
				fileStream.Seek(8L, SeekOrigin.Begin);
				result = (fileStream.ReadByte() == 120);
			}
			return result;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00053F3C File Offset: 0x0005213C
		internal static Enum2 smethod_17(string string_8)
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
			return Working.enum2_0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00053FA8 File Offset: 0x000521A8
		internal static bool smethod_18(string string_8)
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0000782C File Offset: 0x00005A2C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00007833 File Offset: 0x00005A33
		public static bool IsPS3Compressed
		{
			get
			{
				return Working.bool_1;
			}
			set
			{
				Working.bool_1 = value;
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0000783B File Offset: 0x00005A3B
		internal static Dictionary<string, Dictionary<string, List<EntitySearchResult>>> smethod_19()
		{
			return Working.dictionary_0;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00007842 File Offset: 0x00005A42
		internal static void smethod_20(Dictionary<string, Dictionary<string, List<EntitySearchResult>>> value)
		{
			Working.dictionary_0 = value;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0000784A File Offset: 0x00005A4A
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00007851 File Offset: 0x00005A51
		public static List<PlayerMapData> playerMapData { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00007859 File Offset: 0x00005A59
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00007860 File Offset: 0x00005A60
		public static List<PEDimension> PEDimensions
		{
			get
			{
				return Working.list_0;
			}
			set
			{
				Working.list_0 = value;
			}
		}

		// Token: 0x0400070E RID: 1806
		private static int int_0 = Environment.ProcessorCount;

		// Token: 0x0400070F RID: 1807
		private static int int_1 = Working.int_0 * 2;

		// Token: 0x04000710 RID: 1808
		private static int int_2 = 101;

		// Token: 0x04000711 RID: 1809
		private static bool bool_0 = false;

		// Token: 0x04000712 RID: 1810
		private static string string_0 = "";

		// Token: 0x04000713 RID: 1811
		private static string string_1 = "";

		// Token: 0x04000714 RID: 1812
		private static string string_2 = "";

		// Token: 0x04000715 RID: 1813
		private static string[] string_3 = new string[]
		{
			"",
			"XBOX",
			"PS",
			"Wii"
		};

		// Token: 0x04000716 RID: 1814
		private static string[] string_4 = new string[]
		{
			"",
			"savegame_working.dat",
			"gamedata_working",
			"savegame_working.wii"
		};

		// Token: 0x04000717 RID: 1815
		private static string[] string_5 = new string[]
		{
			"",
			"savegame.dat",
			"GAMEDATA",
			"savegame.wii"
		};

		// Token: 0x04000718 RID: 1816
		private static string[] string_6 = new string[]
		{
			"",
			"savegame_new.dat",
			"gamedata_new",
			"savegame_new.wii"
		};

		// Token: 0x04000719 RID: 1817
		private static string[] string_7 = new string[]
		{
			"",
			"XBOX\\",
			"PS\\",
			"WII\\"
		};

		// Token: 0x0400071A RID: 1818
		private static Enum2 enum2_0 = (Enum2)0;

		// Token: 0x0400071B RID: 1819
		private static short short_0 = 0;

		// Token: 0x0400071C RID: 1820
		private static short short_1 = 0;

		// Token: 0x0400071D RID: 1821
		private static int int_3;

		// Token: 0x0400071E RID: 1822
		private static int int_4;

		// Token: 0x0400071F RID: 1823
		private static int int_5;

		// Token: 0x04000720 RID: 1824
		private static int int_6;

		// Token: 0x04000721 RID: 1825
		private static int int_7;

		// Token: 0x04000722 RID: 1826
		private static bool bool_1 = false;

		// Token: 0x04000723 RID: 1827
		private static Dictionary<string, Dictionary<string, List<EntitySearchResult>>> dictionary_0;

		// Token: 0x04000724 RID: 1828
		private static List<PEDimension> list_0 = null;

		// Token: 0x04000725 RID: 1829
		[CompilerGenerated]
		private static bool bool_2;

		// Token: 0x04000726 RID: 1830
		[CompilerGenerated]
		private static bool bool_3;

		// Token: 0x04000727 RID: 1831
		[CompilerGenerated]
		private static List<PlayerMapData> list_1;
	}
}
