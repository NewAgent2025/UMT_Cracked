using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000103 RID: 259
	public class RunArgs
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00007A6C File Offset: 0x00005C6C
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00007A74 File Offset: 0x00005C74
		public string FilePath
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00007A7D File Offset: 0x00005C7D
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00007A85 File Offset: 0x00005C85
		public string FolderPath
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00007A8E File Offset: 0x00005C8E
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00007A96 File Offset: 0x00005C96
		public string PcPath
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

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00007A9F File Offset: 0x00005C9F
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00007AA7 File Offset: 0x00005CA7
		public Dictionary<string, ModifiedFile> ModifiedFiles
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00007AB0 File Offset: 0x00005CB0
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
			set
			{
				this.convertParameters_0 = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00007AC1 File Offset: 0x00005CC1
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00007AC9 File Offset: 0x00005CC9
		public RunTypes RunType
		{
			get
			{
				return this.runTypes_0;
			}
			set
			{
				this.runTypes_0 = value;
			}
		}

		// Token: 0x04000751 RID: 1873
		private string string_0;

		// Token: 0x04000752 RID: 1874
		private string string_1;

		// Token: 0x04000753 RID: 1875
		private string string_2;

		// Token: 0x04000754 RID: 1876
		private Dictionary<string, ModifiedFile> dictionary_0;

		// Token: 0x04000755 RID: 1877
		private ConvertParameters convertParameters_0;

		// Token: 0x04000756 RID: 1878
		private RunTypes runTypes_0;
	}
}
