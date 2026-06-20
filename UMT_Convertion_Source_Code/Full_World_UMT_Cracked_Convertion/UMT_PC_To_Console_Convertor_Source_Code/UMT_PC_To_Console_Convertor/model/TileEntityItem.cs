using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000093 RID: 147
	public class TileEntityItem
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00005A44 File Offset: 0x00003C44
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00005A4C File Offset: 0x00003C4C
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00005A55 File Offset: 0x00003C55
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00005A5D File Offset: 0x00003C5D
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00005A66 File Offset: 0x00003C66
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00005A6E File Offset: 0x00003C6E
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00005A77 File Offset: 0x00003C77
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00005A7F File Offset: 0x00003C7F
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00005A88 File Offset: 0x00003C88
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00005A90 File Offset: 0x00003C90
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

		// Token: 0x06000687 RID: 1671 RVA: 0x000024C1 File Offset: 0x000006C1
		public TileEntityItem()
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00005A99 File Offset: 0x00003C99
		public TileEntityItem(int blockId, string consoleName, string pcOldName, string pcName)
		{
			this.blockId = blockId;
			this.consoleName = consoleName;
			this.pcOldName = pcOldName;
			this.pcName = pcName;
		}

		// Token: 0x0400040D RID: 1037
		private int blockId;

		// Token: 0x0400040E RID: 1038
		private string consoleName;

		// Token: 0x0400040F RID: 1039
		private string pcOldName;

		// Token: 0x04000410 RID: 1040
		private string pcName;

		// Token: 0x04000411 RID: 1041
		private bool bool_0;
	}
}
