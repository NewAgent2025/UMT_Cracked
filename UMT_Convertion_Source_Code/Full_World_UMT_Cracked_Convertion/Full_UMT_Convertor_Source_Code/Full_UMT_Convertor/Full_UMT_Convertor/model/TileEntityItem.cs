using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D7 RID: 215
	public class TileEntityItem
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00006BFE File Offset: 0x00004DFE
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00006C06 File Offset: 0x00004E06
		public int BlockId
		{
			get
			{
				return this.blockId;
			}
			set
			{
				this.blockId = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00006C0F File Offset: 0x00004E0F
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00006C17 File Offset: 0x00004E17
		public string ConsoleName
		{
			get
			{
				return this.consoleName;
			}
			set
			{
				this.consoleName = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00006C20 File Offset: 0x00004E20
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00006C28 File Offset: 0x00004E28
		public string String_0
		{
			get
			{
				return this.pcOldName;
			}
			set
			{
				this.pcOldName = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00006C31 File Offset: 0x00004E31
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00006C39 File Offset: 0x00004E39
		public string PCName
		{
			get
			{
				return this.pcName;
			}
			set
			{
				this.pcName = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00006C42 File Offset: 0x00004E42
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00006C4A File Offset: 0x00004E4A
		public bool ConsoleSpawner
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00006C53 File Offset: 0x00004E53
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00006C5B File Offset: 0x00004E5B
		public string Label
		{
			get
			{
				return this.label;
			}
			set
			{
				this.label = value;
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002591 File Offset: 0x00000791
		public TileEntityItem()
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00006C64 File Offset: 0x00004E64
		public TileEntityItem(int blockId, string consoleName, string pcOldName, string pcName, string label)
		{
			this.blockId = blockId;
			this.consoleName = consoleName;
			this.pcOldName = pcOldName;
			this.pcName = pcName;
			this.label = label;
		}

		// Token: 0x04000634 RID: 1588
		private int blockId;

		// Token: 0x04000635 RID: 1589
		private string consoleName;

		// Token: 0x04000636 RID: 1590
		private string pcOldName;

		// Token: 0x04000637 RID: 1591
		private string pcName;

		// Token: 0x04000638 RID: 1592
		private bool bool_0;

		// Token: 0x04000639 RID: 1593
		private string label;
	}
}
