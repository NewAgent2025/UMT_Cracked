using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000C4 RID: 196
	[Serializable]
	public class Block
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x00002591 File Offset: 0x00000791
		public Block()
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000062F8 File Offset: 0x000044F8
		public Block(int id, int data)
		{
			this.id = id;
			this.data = data;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0000630E File Offset: 0x0000450E
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00006316 File Offset: 0x00004516
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0000631F File Offset: 0x0000451F
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00006327 File Offset: 0x00004527
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00006330 File Offset: 0x00004530
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00006338 File Offset: 0x00004538
		public int Light
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

		// Token: 0x06000854 RID: 2132 RVA: 0x00046A1C File Offset: 0x00044C1C
		public Block Copy()
		{
			return new Block
			{
				id = this.id,
				data = this.data,
				int_0 = this.int_0
			};
		}

		// Token: 0x040005C6 RID: 1478
		private int id;

		// Token: 0x040005C7 RID: 1479
		private int data;

		// Token: 0x040005C8 RID: 1480
		private int int_0;
	}
}
