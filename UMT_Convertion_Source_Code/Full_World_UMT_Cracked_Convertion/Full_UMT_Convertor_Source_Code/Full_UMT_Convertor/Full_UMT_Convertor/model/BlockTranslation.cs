using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200014E RID: 334
	public class BlockTranslation
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000090DF File Offset: 0x000072DF
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x000090E7 File Offset: 0x000072E7
		public int Index
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

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002591 File Offset: 0x00000791
		public BlockTranslation()
		{
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000090F0 File Offset: 0x000072F0
		public BlockTranslation(int id, int data)
		{
			this.id = id;
			this.data = data;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00009106 File Offset: 0x00007306
		public BlockTranslation(int id, int data, MasterBlock masterBlock)
		{
			this.id = id;
			this.data = data;
			this.masterBlock = masterBlock;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0005E008 File Offset: 0x0005C208
		public BlockTranslation Copy()
		{
			return new BlockTranslation
			{
				id = this.id,
				data = this.data,
				masterBlock = this.masterBlock
			};
		}

		// Token: 0x04000842 RID: 2114
		public int id;

		// Token: 0x04000843 RID: 2115
		public int data;

		// Token: 0x04000844 RID: 2116
		public MasterBlock masterBlock;

		// Token: 0x04000845 RID: 2117
		private int int_0;
	}
}
