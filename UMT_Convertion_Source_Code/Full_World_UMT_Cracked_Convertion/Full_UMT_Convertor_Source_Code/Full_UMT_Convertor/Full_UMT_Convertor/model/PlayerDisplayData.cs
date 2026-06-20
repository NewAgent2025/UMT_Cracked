using System;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D2 RID: 210
	public class PlayerDisplayData
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x00006A65 File Offset: 0x00004C65
		public PlayerDisplayData(TagNodeCompound player, string path)
		{
			this.player = player;
			this.path = path;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00006A7B File Offset: 0x00004C7B
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00006A83 File Offset: 0x00004C83
		public TagNodeCompound Player
		{
			get
			{
				return this.player;
			}
			set
			{
				this.player = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00006A8C File Offset: 0x00004C8C
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00006A94 File Offset: 0x00004C94
		public string Path
		{
			get
			{
				return this.path;
			}
			set
			{
				this.path = value;
			}
		}

		// Token: 0x04000621 RID: 1569
		private TagNodeCompound player;

		// Token: 0x04000622 RID: 1570
		private string path;
	}
}
