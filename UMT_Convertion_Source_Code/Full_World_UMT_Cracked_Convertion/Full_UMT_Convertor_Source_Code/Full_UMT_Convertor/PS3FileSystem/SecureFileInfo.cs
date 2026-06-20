using System;
using System.Runtime.CompilerServices;

namespace PS3FileSystem
{
	// Token: 0x02000019 RID: 25
	public class SecureFileInfo
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000C648 File Offset: 0x0000A848
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002AAC File Offset: 0x00000CAC
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public string Name { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002ABD File Offset: 0x00000CBD
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public string[] GameIDs { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002ACE File Offset: 0x00000CCE
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public string SecureFileID { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002ADF File Offset: 0x00000CDF
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002AE7 File Offset: 0x00000CE7
		public string DiscHashKey { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public bool Protected { get; set; }

		// Token: 0x0400006E RID: 110
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400006F RID: 111
		[CompilerGenerated]
		private string[] string_1;

		// Token: 0x04000070 RID: 112
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000071 RID: 113
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04000072 RID: 114
		[CompilerGenerated]
		private bool bool_0;
	}
}
