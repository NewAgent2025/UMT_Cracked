using System;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000B1 RID: 177
	public class ConvertConsoleParameters
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00002591 File Offset: 0x00000791
		public ConvertConsoleParameters()
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00005C58 File Offset: 0x00003E58
		public ConvertConsoleParameters(string regionName, string regionFolder, string srcFolder, string dstFolder, ConvertParameters convertParameters, ManualResetEvent doneEvent)
		{
			this.regionName = regionName;
			this.regionFolder = regionFolder;
			this.dstFolder = dstFolder;
			this.srcFolder = srcFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00005C8D File Offset: 0x00003E8D
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00005C95 File Offset: 0x00003E95
		public ManualResetEvent DoneEvent
		{
			get
			{
				return this.doneEvent;
			}
			set
			{
				this.doneEvent = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00005C9E File Offset: 0x00003E9E
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00005CA6 File Offset: 0x00003EA6
		public string RegionName
		{
			get
			{
				return this.regionName;
			}
			set
			{
				this.regionName = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00005CAF File Offset: 0x00003EAF
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public string RegionFolder
		{
			get
			{
				return this.regionFolder;
			}
			set
			{
				this.regionFolder = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00005CC0 File Offset: 0x00003EC0
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public string SrcFolder
		{
			get
			{
				return this.srcFolder;
			}
			set
			{
				this.srcFolder = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00005CD1 File Offset: 0x00003ED1
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public string DstFolder
		{
			get
			{
				return this.dstFolder;
			}
			set
			{
				this.dstFolder = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00005CE2 File Offset: 0x00003EE2
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00005CEA File Offset: 0x00003EEA
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters;
			}
			set
			{
				this.convertParameters = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00005CF3 File Offset: 0x00003EF3
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00005CFB File Offset: 0x00003EFB
		public int Count
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00005D04 File Offset: 0x00003F04
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00005D0C File Offset: 0x00003F0C
		public bool ProcessingCompleted
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00005D15 File Offset: 0x00003F15
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00005D1D File Offset: 0x00003F1D
		public bool Done
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00005D26 File Offset: 0x00003F26
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00005D2E File Offset: 0x00003F2E
		public int ProcessedChunkCount
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00005D37 File Offset: 0x00003F37
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00005D3F File Offset: 0x00003F3F
		public int MissingChunkCount
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00005D48 File Offset: 0x00003F48
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00005D50 File Offset: 0x00003F50
		public int InvalidChunkCount
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		// Token: 0x04000511 RID: 1297
		private ManualResetEvent doneEvent;

		// Token: 0x04000512 RID: 1298
		private string regionName;

		// Token: 0x04000513 RID: 1299
		private string regionFolder;

		// Token: 0x04000514 RID: 1300
		private string srcFolder;

		// Token: 0x04000515 RID: 1301
		private string dstFolder;

		// Token: 0x04000516 RID: 1302
		private ConvertParameters convertParameters;

		// Token: 0x04000517 RID: 1303
		private int int_0;

		// Token: 0x04000518 RID: 1304
		private bool bool_0;

		// Token: 0x04000519 RID: 1305
		private bool bool_1;

		// Token: 0x0400051A RID: 1306
		private int int_1;

		// Token: 0x0400051B RID: 1307
		private int int_2;

		// Token: 0x0400051C RID: 1308
		private int int_3;
	}
}
