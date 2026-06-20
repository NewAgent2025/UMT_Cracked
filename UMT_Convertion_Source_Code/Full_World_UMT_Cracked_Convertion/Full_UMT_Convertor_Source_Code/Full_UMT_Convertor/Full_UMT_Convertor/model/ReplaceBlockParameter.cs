using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D0 RID: 208
	public class ReplaceBlockParameter
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00002591 File Offset: 0x00000791
		public ReplaceBlockParameter()
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000068E9 File Offset: 0x00004AE9
		public ReplaceBlockParameter(Block replacementBlock, List<BlockSearchResult> replaceBlockList, string outFolderPath)
		{
			this.replacementBlock = replacementBlock;
			this.replaceBlockList = replaceBlockList;
			this.outFolderPath = outFolderPath;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00046F20 File Offset: 0x00045120
		public ReplaceBlockParameter(Block replacementBlock, Dictionary<int, List<BlockSearchResult>> replaceChunkBlockList, string outFolderPath, ManualResetEvent doneEvent)
		{
			if (replaceChunkBlockList.Count > 0)
			{
				int key = replaceChunkBlockList.Keys.First<int>();
				if (replaceChunkBlockList[key].Count > 0)
				{
					this.string_0 = replaceChunkBlockList[key][0].Dimension;
					this.string_1 = replaceChunkBlockList[key][0].Region;
				}
			}
			this.replacementBlock = replacementBlock;
			this.replaceChunkBlockList = replaceChunkBlockList;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00006906 File Offset: 0x00004B06
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0000690E File Offset: 0x00004B0E
		public Block ReplacementBlock
		{
			get
			{
				return this.replacementBlock;
			}
			set
			{
				this.replacementBlock = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00006917 File Offset: 0x00004B17
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0000691F File Offset: 0x00004B1F
		public List<BlockSearchResult> ReplaceBlockList
		{
			get
			{
				return this.replaceBlockList;
			}
			set
			{
				this.replaceBlockList = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00006928 File Offset: 0x00004B28
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00006930 File Offset: 0x00004B30
		public Dictionary<int, List<BlockSearchResult>> ReplaceChunkBlockList
		{
			get
			{
				return this.replaceChunkBlockList;
			}
			set
			{
				this.replaceChunkBlockList = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00006939 File Offset: 0x00004B39
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00006941 File Offset: 0x00004B41
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0000694A File Offset: 0x00004B4A
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00006952 File Offset: 0x00004B52
		public string Dimension
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0000695B File Offset: 0x00004B5B
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00006963 File Offset: 0x00004B63
		public string Region
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0000696C File Offset: 0x00004B6C
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00006974 File Offset: 0x00004B74
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0000697D File Offset: 0x00004B7D
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00006985 File Offset: 0x00004B85
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0000698E File Offset: 0x00004B8E
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00006996 File Offset: 0x00004B96
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

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0000699F File Offset: 0x00004B9F
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000069A7 File Offset: 0x00004BA7
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

		// Token: 0x0400060F RID: 1551
		private Block replacementBlock;

		// Token: 0x04000610 RID: 1552
		private string outFolderPath;

		// Token: 0x04000611 RID: 1553
		private List<BlockSearchResult> replaceBlockList;

		// Token: 0x04000612 RID: 1554
		private Dictionary<int, List<BlockSearchResult>> replaceChunkBlockList;

		// Token: 0x04000613 RID: 1555
		private string string_0;

		// Token: 0x04000614 RID: 1556
		private string string_1;

		// Token: 0x04000615 RID: 1557
		private int int_0;

		// Token: 0x04000616 RID: 1558
		private int int_1;

		// Token: 0x04000617 RID: 1559
		private ProcessStateType processStateType_0;

		// Token: 0x04000618 RID: 1560
		private ManualResetEvent doneEvent;
	}
}
