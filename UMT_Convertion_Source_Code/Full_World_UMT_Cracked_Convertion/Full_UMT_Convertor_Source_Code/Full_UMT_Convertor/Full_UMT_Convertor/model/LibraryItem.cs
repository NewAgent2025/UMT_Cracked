using System;
using System.Runtime.Serialization;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class LibraryItem
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000079A0 File Offset: 0x00005BA0
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000079A8 File Offset: 0x00005BA8
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

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000079B1 File Offset: 0x00005BB1
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x000079B9 File Offset: 0x00005BB9
		public string Author
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000079C2 File Offset: 0x00005BC2
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x000079CA File Offset: 0x00005BCA
		public string Category
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000079D3 File Offset: 0x00005BD3
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x000079DB File Offset: 0x00005BDB
		public string Description
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000079E4 File Offset: 0x00005BE4
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x000079EC File Offset: 0x00005BEC
		public string Instructions
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000079F5 File Offset: 0x00005BF5
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000079FD File Offset: 0x00005BFD
		public string String_0
		{
			get
			{
				return this.string_5;
			}
			set
			{
				this.string_5 = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00007A06 File Offset: 0x00005C06
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00007A0E File Offset: 0x00005C0E
		public string Link
		{
			get
			{
				return this.string_6;
			}
			set
			{
				this.string_6 = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00007A17 File Offset: 0x00005C17
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00007A1F File Offset: 0x00005C1F
		[IgnoreDataMember]
		public string Path
		{
			get
			{
				return this.string_7;
			}
			set
			{
				this.string_7 = value;
			}
		}

		// Token: 0x04000737 RID: 1847
		private string string_0;

		// Token: 0x04000738 RID: 1848
		private string string_1;

		// Token: 0x04000739 RID: 1849
		private string string_2;

		// Token: 0x0400073A RID: 1850
		private string string_3;

		// Token: 0x0400073B RID: 1851
		private string string_4;

		// Token: 0x0400073C RID: 1852
		private string string_5;

		// Token: 0x0400073D RID: 1853
		private string string_6;

		// Token: 0x0400073E RID: 1854
		private string string_7;
	}
}
