using System;
using Save_Manager.model;

namespace Full_UMT_Convertor.Events
{
	// Token: 0x0200001D RID: 29
	public class PEWorldEventArgs : EventArgs
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00002C08 File Offset: 0x00000E08
		public PEWorldEventArgs()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002C10 File Offset: 0x00000E10
		public PEWorldEventArgs(PEWorldFolder folder)
		{
			this.folder = folder;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002C1F File Offset: 0x00000E1F
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002C27 File Offset: 0x00000E27
		public PEWorldFolder Folder
		{
			get
			{
				return this.folder;
			}
			set
			{
				this.folder = value;
			}
		}

		// Token: 0x04000084 RID: 132
		private PEWorldFolder folder;
	}
}
