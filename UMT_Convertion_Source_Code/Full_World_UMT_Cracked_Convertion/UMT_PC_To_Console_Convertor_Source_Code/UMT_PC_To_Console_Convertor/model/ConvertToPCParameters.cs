using System;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000AE RID: 174
	public class ConvertToPCParameters
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x000024C1 File Offset: 0x000006C1
		public ConvertToPCParameters()
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000061DF File Offset: 0x000043DF
		public ConvertToPCParameters(IndexEntry region, string regionName, string regionFolder, string workingFolder, ConvertParameters convertParameters, ManualResetEvent doneEvent)
		{
			this.region = region;
			this.regionName = regionName;
			this.regionFolder = regionFolder;
			this.workingFolder = workingFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00006214 File Offset: 0x00004414
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0000621C File Offset: 0x0000441C
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00006225 File Offset: 0x00004425
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0000622D File Offset: 0x0000442D
		public IndexEntry Region
		{
			get
			{
				return this.region;
			}
			set
			{
				this.region = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00006236 File Offset: 0x00004436
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0000623E File Offset: 0x0000443E
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00006247 File Offset: 0x00004447
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0000624F File Offset: 0x0000444F
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00006258 File Offset: 0x00004458
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00006260 File Offset: 0x00004460
		public string WorkingFolder
		{
			get
			{
				return this.workingFolder;
			}
			set
			{
				this.workingFolder = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00006269 File Offset: 0x00004469
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00006271 File Offset: 0x00004471
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0000627A File Offset: 0x0000447A
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00006282 File Offset: 0x00004482
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0000628B File Offset: 0x0000448B
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00006293 File Offset: 0x00004493
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0000629C File Offset: 0x0000449C
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x000062A4 File Offset: 0x000044A4
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000062AD File Offset: 0x000044AD
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000062B5 File Offset: 0x000044B5
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000062BE File Offset: 0x000044BE
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000062C6 File Offset: 0x000044C6
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

		// Token: 0x040004BF RID: 1215
		private ManualResetEvent doneEvent;

		// Token: 0x040004C0 RID: 1216
		private IndexEntry region;

		// Token: 0x040004C1 RID: 1217
		private string regionName;

		// Token: 0x040004C2 RID: 1218
		private string regionFolder;

		// Token: 0x040004C3 RID: 1219
		private string workingFolder;

		// Token: 0x040004C4 RID: 1220
		private ConvertParameters convertParameters;

		// Token: 0x040004C5 RID: 1221
		private int int_0;

		// Token: 0x040004C6 RID: 1222
		private bool bool_0;

		// Token: 0x040004C7 RID: 1223
		private int int_1;

		// Token: 0x040004C8 RID: 1224
		private int int_2;

		// Token: 0x040004C9 RID: 1225
		private int int_3;
	}
}
