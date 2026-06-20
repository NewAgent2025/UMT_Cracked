using System;

namespace Save_Manager.events
{
	// Token: 0x02000105 RID: 261
	public class SaveSelectedEventArgs : EventArgs
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00007AF4 File Offset: 0x00005CF4
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00007AFC File Offset: 0x00005CFC
		public string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00007B05 File Offset: 0x00005D05
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00007B0D File Offset: 0x00005D0D
		public string Path
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00007B16 File Offset: 0x00005D16
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00007B1E File Offset: 0x00005D1E
		public string WorldType
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x04000759 RID: 1881
		private string string_0;

		// Token: 0x0400075A RID: 1882
		private string string_1;

		// Token: 0x0400075B RID: 1883
		private string string_2;
	}
}
