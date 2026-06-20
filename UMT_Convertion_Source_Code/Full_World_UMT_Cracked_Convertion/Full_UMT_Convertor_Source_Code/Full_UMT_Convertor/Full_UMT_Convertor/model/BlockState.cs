using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200011B RID: 283
	public class BlockState
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00008316 File Offset: 0x00006516
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0000831E File Offset: 0x0000651E
		public short data
		{
			get
			{
				return this.short_0;
			}
			set
			{
				this.short_0 = value;
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00055EFC File Offset: 0x000540FC
		public BlockState Copy(int paletteIndex)
		{
			return new BlockState
			{
				data = this.data,
				id = this.id,
				name = this.name,
				runtimeID = this.runtimeID,
				paletteIndex = paletteIndex
			};
		}

		// Token: 0x0400079D RID: 1949
		private short short_0;

		// Token: 0x0400079E RID: 1950
		public int? id = null;

		// Token: 0x0400079F RID: 1951
		public string name = string.Empty;

		// Token: 0x040007A0 RID: 1952
		public int runtimeID;

		// Token: 0x040007A1 RID: 1953
		public int paletteIndex;
	}
}
