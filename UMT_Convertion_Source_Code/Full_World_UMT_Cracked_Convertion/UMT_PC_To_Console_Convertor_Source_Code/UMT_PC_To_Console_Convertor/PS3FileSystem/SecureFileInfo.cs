using System;
using System.Runtime.CompilerServices;

namespace PS3FileSystem
{
	// Token: 0x02000018 RID: 24
	public class SecureFileInfo
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00009F44 File Offset: 0x00008144
		public SecureFileInfo(string name, string id, string securefileid, string dischashkey, bool isprotected)
		{
			this.Name = name;
			this.GameIDs = id.Trim(new char[]
			{
				'[',
				']'
			}).Split(new char[]
			{
				'/'
			});
			this.SecureFileID = securefileid;
			this.DiscHashKey = dischashkey;
			this.Protected = isprotected;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002957 File Offset: 0x00000B57
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000295F File Offset: 0x00000B5F
		public string Name { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002968 File Offset: 0x00000B68
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002970 File Offset: 0x00000B70
		public string[] GameIDs { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002979 File Offset: 0x00000B79
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002981 File Offset: 0x00000B81
		public string SecureFileID { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000298A File Offset: 0x00000B8A
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002992 File Offset: 0x00000B92
		public string DiscHashKey { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000299B File Offset: 0x00000B9B
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000029A3 File Offset: 0x00000BA3
		public bool Protected { get; set; }

		// Token: 0x04000061 RID: 97
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private string[] string_1;

		// Token: 0x04000063 RID: 99
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04000065 RID: 101
		[CompilerGenerated]
		private bool bool_0;
	}
}
