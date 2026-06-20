using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000115 RID: 277
	public class AquaticDefinition
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00002591 File Offset: 0x00000791
		public AquaticDefinition()
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0000826D File Offset: 0x0000646D
		public AquaticDefinition(string aquaticName, string preAquaticName, List<int> dataValues, string entityTag)
		{
			this.aquaticName = aquaticName;
			this.preAquaticName = preAquaticName;
			this.dataValues = dataValues;
			this.entityTag = entityTag;
		}

		// Token: 0x04000782 RID: 1922
		public string aquaticName;

		// Token: 0x04000783 RID: 1923
		public string preAquaticName;

		// Token: 0x04000784 RID: 1924
		public List<int> dataValues;

		// Token: 0x04000785 RID: 1925
		public string entityTag;
	}
}
