using System;
using System.Collections.Generic;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000CF RID: 207
	public class ReplaceBlockGlobalParameter
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00002591 File Offset: 0x00000791
		public ReplaceBlockGlobalParameter()
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00006817 File Offset: 0x00004A17
		public ReplaceBlockGlobalParameter(string dimension, List<BlockChange> replacementBlockList, string outFolderPath)
		{
			this.dimension = dimension;
			this.replacementBlockList = replacementBlockList;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00006834 File Offset: 0x00004A34
		public ReplaceBlockGlobalParameter(string dimension, string region, List<BlockChange> replacementBlockList, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.replacementBlockList = replacementBlockList;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00006861 File Offset: 0x00004A61
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00006869 File Offset: 0x00004A69
		public List<BlockChange> ReplacementBlockList
		{
			get
			{
				return this.replacementBlockList;
			}
			set
			{
				this.replacementBlockList = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00006872 File Offset: 0x00004A72
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x0000687A File Offset: 0x00004A7A
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00006883 File Offset: 0x00004A83
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x0000688B File Offset: 0x00004A8B
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00006894 File Offset: 0x00004A94
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0000689C File Offset: 0x00004A9C
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000068A5 File Offset: 0x00004AA5
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x000068AD File Offset: 0x00004AAD
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000068B6 File Offset: 0x00004AB6
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x000068BE File Offset: 0x00004ABE
		public int BlockProcessedCount
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000068C7 File Offset: 0x00004AC7
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x000068CF File Offset: 0x00004ACF
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000068D8 File Offset: 0x00004AD8
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x000068E0 File Offset: 0x00004AE0
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

		// Token: 0x04000607 RID: 1543
		private string outFolderPath;

		// Token: 0x04000608 RID: 1544
		private string dimension;

		// Token: 0x04000609 RID: 1545
		private string region;

		// Token: 0x0400060A RID: 1546
		private List<BlockChange> replacementBlockList;

		// Token: 0x0400060B RID: 1547
		private int int_0;

		// Token: 0x0400060C RID: 1548
		private int int_1;

		// Token: 0x0400060D RID: 1549
		private ProcessStateType processStateType_0;

		// Token: 0x0400060E RID: 1550
		private ManualResetEvent doneEvent;
	}
}
