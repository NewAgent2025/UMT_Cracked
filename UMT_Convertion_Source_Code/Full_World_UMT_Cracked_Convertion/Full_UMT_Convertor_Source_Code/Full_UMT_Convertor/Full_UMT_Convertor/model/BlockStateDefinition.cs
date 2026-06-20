using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000033 RID: 51
	public class BlockStateDefinition
	{
		// Token: 0x04000111 RID: 273
		public string name;

		// Token: 0x04000112 RID: 274
		public string defaultValue;

		// Token: 0x04000113 RID: 275
		public int javaMask;

		// Token: 0x04000114 RID: 276
		public int bedrockMask;

		// Token: 0x04000115 RID: 277
		public int consoleMask;

		// Token: 0x04000116 RID: 278
		public string bedrockName;

		// Token: 0x04000117 RID: 279
		public string bedrockNbtType;

		// Token: 0x04000118 RID: 280
		public BlockStateValue[] states = new BlockStateValue[0];
	}
}
