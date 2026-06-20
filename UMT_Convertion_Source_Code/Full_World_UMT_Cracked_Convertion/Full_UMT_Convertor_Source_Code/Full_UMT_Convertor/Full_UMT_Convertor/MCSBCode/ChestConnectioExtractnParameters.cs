using System;
using System.Collections.Generic;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode.model;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000020 RID: 32
	public class ChestConnectioExtractnParameters
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002D4E File Offset: 0x00000F4E
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002D56 File Offset: 0x00000F56
		public PERegionChunks PeRegion
		{
			get
			{
				return this.peregionChunks_0;
			}
			set
			{
				this.peregionChunks_0 = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002D5F File Offset: 0x00000F5F
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002D67 File Offset: 0x00000F67
		public Dictionary<int, MCCoordinate> Chests
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002D70 File Offset: 0x00000F70
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002D78 File Offset: 0x00000F78
		public bool Done
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x040000AD RID: 173
		private PERegionChunks peregionChunks_0;

		// Token: 0x040000AE RID: 174
		private Dictionary<int, MCCoordinate> dictionary_0;

		// Token: 0x040000AF RID: 175
		private bool bool_0;
	}
}
