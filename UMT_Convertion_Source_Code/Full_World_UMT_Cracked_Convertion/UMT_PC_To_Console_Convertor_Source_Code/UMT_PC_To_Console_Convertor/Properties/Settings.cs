using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UMT_PC_To_Console_Convertor.Properties
{
	// Token: 0x020000D3 RID: 211
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00006D41 File Offset: 0x00004F41
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00006D53 File Offset: 0x00004F53
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public StringCollection RecentFiles
		{
			get
			{
				return (StringCollection)this["RecentFiles"];
			}
			set
			{
				this["RecentFiles"] = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00006D61 File Offset: 0x00004F61
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00006D73 File Offset: 0x00004F73
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public StringCollection RecentDirectories
		{
			get
			{
				return (StringCollection)this["RecentDirectories"];
			}
			set
			{
				this["RecentDirectories"] = value;
			}
		}
	}
}
