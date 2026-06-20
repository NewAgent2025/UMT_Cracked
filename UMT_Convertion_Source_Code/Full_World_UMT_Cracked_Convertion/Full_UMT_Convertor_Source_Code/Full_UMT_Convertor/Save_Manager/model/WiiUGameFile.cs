using System;
using System.Drawing;
using System.IO;

namespace Save_Manager.model
{
	// Token: 0x02000108 RID: 264
	public class WiiUGameFile
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00007BF6 File Offset: 0x00005DF6
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00007BFE File Offset: 0x00005DFE
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00007C07 File Offset: 0x00005E07
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00007C0F File Offset: 0x00005E0F
		public byte[] ImageBytes
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
				this.memoryStream_0 = new MemoryStream(this.byte_0);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00007C29 File Offset: 0x00005E29
		public Image Image
		{
			get
			{
				return Image.FromStream(this.memoryStream_0);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00007C36 File Offset: 0x00005E36
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00007C3E File Offset: 0x00005E3E
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

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00007C47 File Offset: 0x00005E47
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00007C4F File Offset: 0x00005E4F
		public long Size
		{
			get
			{
				return this.long_0;
			}
			set
			{
				this.long_0 = value;
			}
		}

		// Token: 0x04000772 RID: 1906
		private string string_0;

		// Token: 0x04000773 RID: 1907
		private string string_1;

		// Token: 0x04000774 RID: 1908
		private byte[] byte_0;

		// Token: 0x04000775 RID: 1909
		private long long_0;

		// Token: 0x04000776 RID: 1910
		private MemoryStream memoryStream_0;
	}
}
