using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000117 RID: 279
	public class BedrockDataStateResult
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x00002591 File Offset: 0x00000791
		public BedrockDataStateResult()
		{
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000082B7 File Offset: 0x000064B7
		public BedrockDataStateResult(string name, short dataValue)
		{
			this.name = name;
			this.dataValue = dataValue;
		}

		// Token: 0x04000791 RID: 1937
		public string name;

		// Token: 0x04000792 RID: 1938
		public short dataValue;
	}
}
