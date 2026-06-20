using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000070 RID: 112
	public class DimensionWorkingData
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x000024C1 File Offset: 0x000006C1
		public DimensionWorkingData()
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004AC9 File Offset: 0x00002CC9
		public DimensionWorkingData(string dimension, string path)
		{
			this.dimension = dimension;
			this.path = path;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00004ADF File Offset: 0x00002CDF
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004AE7 File Offset: 0x00002CE7
		public string Dimension
		{
			get
			{
				return this.dimension;
			}
			set
			{
				this.dimension = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00004AF0 File Offset: 0x00002CF0
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public string Path
		{
			get
			{
				return this.path;
			}
			set
			{
				this.path = value;
			}
		}

		// Token: 0x04000359 RID: 857
		private string dimension;

		// Token: 0x0400035A RID: 858
		private string path;
	}
}
