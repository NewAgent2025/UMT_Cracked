using System;
using System.Drawing;

namespace Save_Manager.model
{
	// Token: 0x0200002A RID: 42
	public class XboxPackageData
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000030B9 File Offset: 0x000012B9
		// (set) Token: 0x0600017B RID: 379 RVA: 0x000030C1 File Offset: 0x000012C1
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000030CA File Offset: 0x000012CA
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000030D2 File Offset: 0x000012D2
		public Image ThumbnailImage
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000030DB File Offset: 0x000012DB
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000030E3 File Offset: 0x000012E3
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000030EC File Offset: 0x000012EC
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000030F4 File Offset: 0x000012F4
		public int Filesize
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		// Token: 0x040000DB RID: 219
		private string string_0;

		// Token: 0x040000DC RID: 220
		private Image image_0;

		// Token: 0x040000DD RID: 221
		private string string_1;

		// Token: 0x040000DE RID: 222
		private int int_0;
	}
}
