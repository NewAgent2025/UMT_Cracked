using System;
using System.Drawing;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000078 RID: 120
	public class MapBlockParameter
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x000024C1 File Offset: 0x000006C1
		public MapBlockParameter()
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00004E5A File Offset: 0x0000305A
		public MapBlockParameter(string dimension, string region, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00004E7F File Offset: 0x0000307F
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00004E87 File Offset: 0x00003087
		public string Dimension
		{
			get
			{
				return this.dimension;
			}
			set
			{
				this.dimension = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00004E90 File Offset: 0x00003090
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00004E98 File Offset: 0x00003098
		public string Region
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00004EA1 File Offset: 0x000030A1
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00004EA9 File Offset: 0x000030A9
		public string OutFolderPath
		{
			get
			{
				return this.outFolderPath;
			}
			set
			{
				this.outFolderPath = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00004EB2 File Offset: 0x000030B2
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00004EBA File Offset: 0x000030BA
		public bool Completed
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00004EC3 File Offset: 0x000030C3
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00004ECB File Offset: 0x000030CB
		public int ChunkProcessedCount
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00004ED4 File Offset: 0x000030D4
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00004EDC File Offset: 0x000030DC
		public Image Image
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00004EE5 File Offset: 0x000030E5
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00004EED File Offset: 0x000030ED
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

		// Token: 0x0400038A RID: 906
		private bool bool_0;

		// Token: 0x0400038B RID: 907
		private string dimension;

		// Token: 0x0400038C RID: 908
		private string region;

		// Token: 0x0400038D RID: 909
		private string outFolderPath;

		// Token: 0x0400038E RID: 910
		private Image image_0;

		// Token: 0x0400038F RID: 911
		private int int_0;

		// Token: 0x04000390 RID: 912
		private ManualResetEvent doneEvent;
	}
}
