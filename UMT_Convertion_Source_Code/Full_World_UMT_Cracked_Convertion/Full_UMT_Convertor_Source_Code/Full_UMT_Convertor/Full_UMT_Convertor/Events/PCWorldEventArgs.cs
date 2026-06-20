using System;

namespace Full_UMT_Convertor.Events
{
	// Token: 0x0200006E RID: 110
	public class PCWorldEventArgs : EventArgs
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x00002C08 File Offset: 0x00000E08
		public PCWorldEventArgs()
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000047A4 File Offset: 0x000029A4
		public PCWorldEventArgs(string name, string folder)
		{
			this.name = name;
			this.FttxzMwbeW = folder;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000047BA File Offset: 0x000029BA
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x000047C2 File Offset: 0x000029C2
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x000047CB File Offset: 0x000029CB
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x000047D3 File Offset: 0x000029D3
		public string Folder
		{
			get
			{
				return this.FttxzMwbeW;
			}
			set
			{
				this.FttxzMwbeW = value;
			}
		}

		// Token: 0x04000254 RID: 596
		private string name;

		// Token: 0x04000255 RID: 597
		private string FttxzMwbeW;
	}
}
