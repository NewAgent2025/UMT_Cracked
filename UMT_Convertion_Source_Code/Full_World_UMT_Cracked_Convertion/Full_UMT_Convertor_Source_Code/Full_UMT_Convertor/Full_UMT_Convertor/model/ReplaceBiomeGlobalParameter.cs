using System;
using System.Collections.Generic;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000CE RID: 206
	public class ReplaceBiomeGlobalParameter
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x00002591 File Offset: 0x00000791
		public ReplaceBiomeGlobalParameter()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00006745 File Offset: 0x00004945
		public ReplaceBiomeGlobalParameter(string dimension, List<BiomeChange> replacementBiomeList, string outFolderPath)
		{
			this.dimension = dimension;
			this.replacementBiomeList = replacementBiomeList;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00006762 File Offset: 0x00004962
		public ReplaceBiomeGlobalParameter(string dimension, string region, List<BiomeChange> replacementBiomeList, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.replacementBiomeList = replacementBiomeList;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0000678F File Offset: 0x0000498F
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00006797 File Offset: 0x00004997
		public List<BiomeChange> ReplacementBiomeList
		{
			get
			{
				return this.replacementBiomeList;
			}
			set
			{
				this.replacementBiomeList = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000067A0 File Offset: 0x000049A0
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x000067A8 File Offset: 0x000049A8
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x000067B1 File Offset: 0x000049B1
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x000067B9 File Offset: 0x000049B9
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000067C2 File Offset: 0x000049C2
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x000067CA File Offset: 0x000049CA
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000067D3 File Offset: 0x000049D3
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000067DB File Offset: 0x000049DB
		public ProcessStateType ProcessState
		{
			get
			{
				return this.processStateType_0;
			}
			set
			{
				this.processStateType_0 = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000067E4 File Offset: 0x000049E4
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000067EC File Offset: 0x000049EC
		public int BiomeProcessedCount
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000067F5 File Offset: 0x000049F5
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000067FD File Offset: 0x000049FD
		public int ChunkProcessedCount
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00006806 File Offset: 0x00004A06
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0000680E File Offset: 0x00004A0E
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

		// Token: 0x040005FF RID: 1535
		private string outFolderPath;

		// Token: 0x04000600 RID: 1536
		private string dimension;

		// Token: 0x04000601 RID: 1537
		private string region;

		// Token: 0x04000602 RID: 1538
		private List<BiomeChange> replacementBiomeList;

		// Token: 0x04000603 RID: 1539
		private int int_0;

		// Token: 0x04000604 RID: 1540
		private int int_1;

		// Token: 0x04000605 RID: 1541
		private ProcessStateType processStateType_0;

		// Token: 0x04000606 RID: 1542
		private ManualResetEvent doneEvent;
	}
}
