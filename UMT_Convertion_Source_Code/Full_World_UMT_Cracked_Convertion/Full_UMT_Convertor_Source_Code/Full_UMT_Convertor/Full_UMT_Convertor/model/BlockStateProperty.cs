using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000024 RID: 36
	public class BlockStateProperty
	{
		// Token: 0x0600013D RID: 317 RVA: 0x00002591 File Offset: 0x00000791
		public BlockStateProperty()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002E2F File Offset: 0x0000102F
		public BlockStateProperty(string name, string value)
		{
			this.name = name;
			this.value = value;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002E45 File Offset: 0x00001045
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002E4D File Offset: 0x0000104D
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002E56 File Offset: 0x00001056
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002E5E File Offset: 0x0000105E
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x040000B9 RID: 185
		private string name;

		// Token: 0x040000BA RID: 186
		private string value;
	}
}
