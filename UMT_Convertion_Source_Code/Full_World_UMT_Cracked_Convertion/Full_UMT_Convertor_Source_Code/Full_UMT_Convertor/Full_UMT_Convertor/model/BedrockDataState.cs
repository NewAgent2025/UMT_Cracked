using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000118 RID: 280
	public class BedrockDataState
	{
		// Token: 0x06000C08 RID: 3080 RVA: 0x00002591 File Offset: 0x00000791
		public BedrockDataState()
		{
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000082CD File Offset: 0x000064CD
		public BedrockDataState(string name, short dataValue)
		{
			this.name = name;
			this.dataValue = dataValue;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000082E3 File Offset: 0x000064E3
		public BedrockDataState(string name, ConvertDataValueDelegate conversion)
		{
			this.name = name;
			this.conversion = conversion;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000082F9 File Offset: 0x000064F9
		public BedrockDataState(string name, short dataValue, ConvertDataValueDelegate conversion)
		{
			this.name = name;
			this.dataValue = dataValue;
			this.conversion = conversion;
		}

		// Token: 0x04000793 RID: 1939
		public string name;

		// Token: 0x04000794 RID: 1940
		public short dataValue;

		// Token: 0x04000795 RID: 1941
		public ConvertDataValueDelegate conversion;
	}
}
