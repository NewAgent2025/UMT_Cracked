using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Full_UMT_Convertor.Properties
{
	// Token: 0x02000156 RID: 342
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000091D0 File Offset: 0x000073D0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00009217 File Offset: 0x00007417
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00009229 File Offset: 0x00007429
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string LastOpenFile
		{
			get
			{
				return (string)this["LastOpenFile"];
			}
			set
			{
				this["LastOpenFile"] = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00009237 File Offset: 0x00007437
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00009249 File Offset: 0x00007449
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LastDirectory
		{
			get
			{
				return (string)this["LastDirectory"];
			}
			set
			{
				this["LastDirectory"] = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00009257 File Offset: 0x00007457
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00009269 File Offset: 0x00007469
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string LibraryPath
		{
			get
			{
				return (string)this["LibraryPath"];
			}
			set
			{
				this["LibraryPath"] = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00009277 File Offset: 0x00007477
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00009289 File Offset: 0x00007489
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool UpgradeSettings
		{
			get
			{
				return (bool)this["UpgradeSettings"];
			}
			set
			{
				this["UpgradeSettings"] = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0000929C File Offset: 0x0000749C
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x000092AE File Offset: 0x000074AE
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string Setting
		{
			get
			{
				return (string)this["Setting"];
			}
			set
			{
				this["Setting"] = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000092BC File Offset: 0x000074BC
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x000092CE File Offset: 0x000074CE
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string ToPCBiomeTranslations
		{
			get
			{
				return (string)this["ToPCBiomeTranslations"];
			}
			set
			{
				this["ToPCBiomeTranslations"] = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x000092DC File Offset: 0x000074DC
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x000092EE File Offset: 0x000074EE
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ToPCBlockTranslations
		{
			get
			{
				return (string)this["ToPCBlockTranslations"];
			}
			set
			{
				this["ToPCBlockTranslations"] = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000092FC File Offset: 0x000074FC
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0000930E File Offset: 0x0000750E
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string FromPCBiomeTranslations
		{
			get
			{
				return (string)this["FromPCBiomeTranslations"];
			}
			set
			{
				this["FromPCBiomeTranslations"] = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0000931C File Offset: 0x0000751C
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0000932E File Offset: 0x0000752E
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string FromPCBlockTranslations
		{
			get
			{
				return (string)this["FromPCBlockTranslations"];
			}
			set
			{
				this["FromPCBlockTranslations"] = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0000933C File Offset: 0x0000753C
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0000934E File Offset: 0x0000754E
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string String_0
		{
			get
			{
				return (string)this["MCPCFolder"];
			}
			set
			{
				this["MCPCFolder"] = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0000935C File Offset: 0x0000755C
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0000936E File Offset: 0x0000756E
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string BRDPath
		{
			get
			{
				return (string)this["BRDPath"];
			}
			set
			{
				this["BRDPath"] = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0000937C File Offset: 0x0000757C
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x0000938E File Offset: 0x0000758E
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string LastEntitySearch
		{
			get
			{
				return (string)this["LastEntitySearch"];
			}
			set
			{
				this["LastEntitySearch"] = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0000939C File Offset: 0x0000759C
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x000093AE File Offset: 0x000075AE
		[DebuggerNonUserCode]
		[DefaultSettingValue("region")]
		[UserScopedSetting]
		public string LastEntitySearchRegion
		{
			get
			{
				return (string)this["LastEntitySearchRegion"];
			}
			set
			{
				this["LastEntitySearchRegion"] = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000093BC File Offset: 0x000075BC
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x000093CE File Offset: 0x000075CE
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int DefaultConsoleType
		{
			get
			{
				return (int)this["DefaultConsoleType"];
			}
			set
			{
				this["DefaultConsoleType"] = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000093E1 File Offset: 0x000075E1
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x000093F3 File Offset: 0x000075F3
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ArchiveGameFile
		{
			get
			{
				return (bool)this["ArchiveGameFile"];
			}
			set
			{
				this["ArchiveGameFile"] = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00009406 File Offset: 0x00007606
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00009418 File Offset: 0x00007618
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string SaviinePath
		{
			get
			{
				return (string)this["SaviinePath"];
			}
			set
			{
				this["SaviinePath"] = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00009426 File Offset: 0x00007626
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00009438 File Offset: 0x00007638
		[DebuggerNonUserCode]
		[DefaultSettingValue("inject")]
		[UserScopedSetting]
		public string SaviineFolder
		{
			get
			{
				return (string)this["SaviineFolder"];
			}
			set
			{
				this["SaviineFolder"] = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00009446 File Offset: 0x00007646
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00009458 File Offset: 0x00007658
		[DebuggerNonUserCode]
		[DefaultSettingValue("65")]
		[UserScopedSetting]
		public int HrybridOpacity
		{
			get
			{
				return (int)this["HrybridOpacity"];
			}
			set
			{
				this["HrybridOpacity"] = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0000946B File Offset: 0x0000766B
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0000947D File Offset: 0x0000767D
		[DebuggerNonUserCode]
		[DefaultSettingValue("light")]
		[UserScopedSetting]
		public string HeightView
		{
			get
			{
				return (string)this["HeightView"];
			}
			set
			{
				this["HeightView"] = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0000948B File Offset: 0x0000768B
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0000949D File Offset: 0x0000769D
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ShowPlayers
		{
			get
			{
				return (bool)this["ShowPlayers"];
			}
			set
			{
				this["ShowPlayers"] = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000094B0 File Offset: 0x000076B0
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x000094C2 File Offset: 0x000076C2
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ShowChunkGrid
		{
			get
			{
				return (bool)this["ShowChunkGrid"];
			}
			set
			{
				this["ShowChunkGrid"] = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x000094D5 File Offset: 0x000076D5
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x000094E7 File Offset: 0x000076E7
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ShowRegionGrid
		{
			get
			{
				return (bool)this["ShowRegionGrid"];
			}
			set
			{
				this["ShowRegionGrid"] = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x000094FA File Offset: 0x000076FA
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0000950C File Offset: 0x0000770C
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ShowSearchResults
		{
			get
			{
				return (bool)this["ShowSearchResults"];
			}
			set
			{
				this["ShowSearchResults"] = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0000951F File Offset: 0x0000771F
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00009531 File Offset: 0x00007731
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string LastEntitySearchConditions
		{
			get
			{
				return (string)this["LastEntitySearchConditions"];
			}
			set
			{
				this["LastEntitySearchConditions"] = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0000953F File Offset: 0x0000773F
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00009551 File Offset: 0x00007751
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string String_1
		{
			get
			{
				return (string)this["ConvertFromPCFolder"];
			}
			set
			{
				this["ConvertFromPCFolder"] = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0000955F File Offset: 0x0000775F
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00009571 File Offset: 0x00007771
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ConvertToPCFolder
		{
			get
			{
				return (string)this["ConvertToPCFolder"];
			}
			set
			{
				this["ConvertToPCFolder"] = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0000957F File Offset: 0x0000777F
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00009591 File Offset: 0x00007791
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool UseFileExplorer
		{
			get
			{
				return (bool)this["UseFileExplorer"];
			}
			set
			{
				this["UseFileExplorer"] = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x000095A4 File Offset: 0x000077A4
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x000095B6 File Offset: 0x000077B6
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ConvertToBedrockFolder
		{
			get
			{
				return (string)this["ConvertToBedrockFolder"];
			}
			set
			{
				this["ConvertToBedrockFolder"] = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000095C4 File Offset: 0x000077C4
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x000095D6 File Offset: 0x000077D6
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool AllowTelemetry
		{
			get
			{
				return (bool)this["AllowTelemetry"];
			}
			set
			{
				this["AllowTelemetry"] = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0000933C File Offset: 0x0000753C
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x0000934E File Offset: 0x0000754E
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string MCPCFolder
		{
			get
			{
				return (string)this["MCPCFolder"];
			}
			set
			{
				this["MCPCFolder"] = value;
			}
		}

		// Token: 0x04000852 RID: 2130
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
