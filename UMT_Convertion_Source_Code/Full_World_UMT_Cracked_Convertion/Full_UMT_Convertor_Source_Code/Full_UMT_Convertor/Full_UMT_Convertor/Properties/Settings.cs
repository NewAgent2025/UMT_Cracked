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
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000091D7 File Offset: 0x000073D7
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x000091E9 File Offset: 0x000073E9
		[UserScopedSetting]
		[DebuggerNonUserCode]
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000091F7 File Offset: 0x000073F7
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00009209 File Offset: 0x00007409
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
