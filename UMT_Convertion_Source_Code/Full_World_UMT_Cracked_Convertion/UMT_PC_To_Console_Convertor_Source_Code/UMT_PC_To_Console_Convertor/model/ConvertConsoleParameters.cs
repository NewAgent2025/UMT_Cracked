using System;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000077 RID: 119
	public class ConvertConsoleParameters
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x000024C1 File Offset: 0x000006C1
		public ConvertConsoleParameters()
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00004D59 File Offset: 0x00002F59
		public ConvertConsoleParameters(string regionName, string regionFolder, string srcFolder, string dstFolder, ConvertParameters convertParameters, ManualResetEvent doneEvent)
		{
			this.regionName = regionName;
			this.regionFolder = regionFolder;
			this.dstFolder = dstFolder;
			this.srcFolder = srcFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00004D8E File Offset: 0x00002F8E
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004D96 File Offset: 0x00002F96
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00004D9F File Offset: 0x00002F9F
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004DA7 File Offset: 0x00002FA7
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00004DB0 File Offset: 0x00002FB0
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004DB8 File Offset: 0x00002FB8
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00004DC1 File Offset: 0x00002FC1
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004DC9 File Offset: 0x00002FC9
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00004DD2 File Offset: 0x00002FD2
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004DDA File Offset: 0x00002FDA
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00004DE3 File Offset: 0x00002FE3
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004DEB File Offset: 0x00002FEB
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00004DF4 File Offset: 0x00002FF4
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00004DFC File Offset: 0x00002FFC
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00004E05 File Offset: 0x00003005
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00004E0D File Offset: 0x0000300D
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00004E16 File Offset: 0x00003016
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00004E1E File Offset: 0x0000301E
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00004E27 File Offset: 0x00003027
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004E2F File Offset: 0x0000302F
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00004E38 File Offset: 0x00003038
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004E40 File Offset: 0x00003040
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00004E49 File Offset: 0x00003049
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00004E51 File Offset: 0x00003051
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

		// Token: 0x0400037E RID: 894
		private ManualResetEvent doneEvent;

		// Token: 0x0400037F RID: 895
		private string regionName;

		// Token: 0x04000380 RID: 896
		private string regionFolder;

		// Token: 0x04000381 RID: 897
		private string srcFolder;

		// Token: 0x04000382 RID: 898
		private string dstFolder;

		// Token: 0x04000383 RID: 899
		private ConvertParameters convertParameters;

		// Token: 0x04000384 RID: 900
		private int int_0;

		// Token: 0x04000385 RID: 901
		private bool bool_0;

		// Token: 0x04000386 RID: 902
		private bool bool_1;

		// Token: 0x04000387 RID: 903
		private int int_1;

		// Token: 0x04000388 RID: 904
		private int int_2;

		// Token: 0x04000389 RID: 905
		private int int_3;
	}
}
