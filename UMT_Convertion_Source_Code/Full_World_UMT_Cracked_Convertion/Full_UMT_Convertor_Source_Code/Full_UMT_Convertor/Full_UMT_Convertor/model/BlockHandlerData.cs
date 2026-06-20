using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000114 RID: 276
	public class BlockHandlerData
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00008257 File Offset: 0x00006457
		public BlockHandlerData(Dictionary<string, DataStateProperty> properties, BlockHandlerz blockHandler)
		{
			this.properties = properties;
			this.blockHandler = blockHandler;
		}

		// Token: 0x04000780 RID: 1920
		public Dictionary<string, DataStateProperty> properties;

		// Token: 0x04000781 RID: 1921
		public BlockHandlerz blockHandler;
	}
}
