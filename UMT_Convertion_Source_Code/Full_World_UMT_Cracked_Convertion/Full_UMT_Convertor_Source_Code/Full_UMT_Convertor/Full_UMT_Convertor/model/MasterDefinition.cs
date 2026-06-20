using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000116 RID: 278
	public class MasterDefinition
	{
		// Token: 0x06000C04 RID: 3076 RVA: 0x00002591 File Offset: 0x00000791
		public MasterDefinition()
		{
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00008292 File Offset: 0x00006492
		public MasterDefinition(string javaName, string preAquaticName, List<int> dataValues, string entityTag)
		{
			this.javaName = javaName;
			this.preAquaticName = preAquaticName;
			this.dataValues = dataValues;
			this.entityTag = entityTag;
		}

		// Token: 0x04000786 RID: 1926
		public string javaName;

		// Token: 0x04000787 RID: 1927
		public string javaNameOld;

		// Token: 0x04000788 RID: 1928
		public string bedrockName;

		// Token: 0x04000789 RID: 1929
		public string bedrockNameOld;

		// Token: 0x0400078A RID: 1930
		public int javaId;

		// Token: 0x0400078B RID: 1931
		public int bedrockId;

		// Token: 0x0400078C RID: 1932
		public int javaData;

		// Token: 0x0400078D RID: 1933
		public int bedrockData;

		// Token: 0x0400078E RID: 1934
		public string preAquaticName;

		// Token: 0x0400078F RID: 1935
		public List<int> dataValues;

		// Token: 0x04000790 RID: 1936
		public string entityTag;
	}
}
