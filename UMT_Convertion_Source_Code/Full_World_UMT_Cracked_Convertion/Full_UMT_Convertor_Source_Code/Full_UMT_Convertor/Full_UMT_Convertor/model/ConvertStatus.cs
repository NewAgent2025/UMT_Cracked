using System;
using System.Text;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C8 RID: 200
	public class ConvertStatus
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000064AE File Offset: 0x000046AE
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x000064B6 File Offset: 0x000046B6
		public int ProcessedChunkCount
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000064BF File Offset: 0x000046BF
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x000064C7 File Offset: 0x000046C7
		public int MissingChunkCount
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000064D0 File Offset: 0x000046D0
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x000064D8 File Offset: 0x000046D8
		public int InvalidChunkCount
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x000064E1 File Offset: 0x000046E1
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x000064E9 File Offset: 0x000046E9
		public string WorkingFolder
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000064F2 File Offset: 0x000046F2
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000064FA File Offset: 0x000046FA
		public string SourceFolder
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

		// Token: 0x06000888 RID: 2184 RVA: 0x00046C48 File Offset: 0x00044E48
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Processed Chunks: " + this.int_0);
			if (this.int_1 > 0)
			{
				stringBuilder.AppendLine("Missing Chunks: " + this.int_1);
			}
			if (this.int_2 > 0)
			{
				stringBuilder.AppendLine("Invalid Chunks: " + this.int_2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040005D9 RID: 1497
		private int int_0;

		// Token: 0x040005DA RID: 1498
		private int int_1;

		// Token: 0x040005DB RID: 1499
		private int int_2;

		// Token: 0x040005DC RID: 1500
		private string string_0;

		// Token: 0x040005DD RID: 1501
		private string string_1;
	}
}
