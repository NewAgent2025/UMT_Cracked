using System;
using System.Drawing;
using System.IO;

namespace Save_Manager.model
{
	// Token: 0x02000107 RID: 263
	public class PS3GameFile
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00007B94 File Offset: 0x00005D94
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00007B9C File Offset: 0x00005D9C
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00007BA5 File Offset: 0x00005DA5
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00007BAD File Offset: 0x00005DAD
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00007BC7 File Offset: 0x00005DC7
		public Image Image
		{
			get
			{
				return Image.FromStream(this.memoryStream_0);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00007BD4 File Offset: 0x00005DD4
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00007BDC File Offset: 0x00005DDC
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00007BE5 File Offset: 0x00005DE5
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00007BED File Offset: 0x00005DED
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

		// Token: 0x0400076D RID: 1901
		private string string_0;

		// Token: 0x0400076E RID: 1902
		private string string_1;

		// Token: 0x0400076F RID: 1903
		private byte[] byte_0;

		// Token: 0x04000770 RID: 1904
		private long long_0;

		// Token: 0x04000771 RID: 1905
		private MemoryStream memoryStream_0;
	}
}
