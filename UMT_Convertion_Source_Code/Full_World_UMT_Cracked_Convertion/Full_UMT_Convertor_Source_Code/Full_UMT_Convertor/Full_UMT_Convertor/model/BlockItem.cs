using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000080 RID: 128
	public class BlockItem
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public BlockItem()
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public BlockItem(string name, int data)
		{
			this.name = name;
			this.data = data;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00004CE5 File Offset: 0x00002EE5
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00004CED File Offset: 0x00002EED
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00004CF6 File Offset: 0x00002EF6
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00004CFE File Offset: 0x00002EFE
		public int Data
		{
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}

		// Token: 0x0400032D RID: 813
		private string name = "";

		// Token: 0x0400032E RID: 814
		private int data;
	}
}
