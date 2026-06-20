using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000090 RID: 144
	public class RegionDisplayChunk
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0000591E File Offset: 0x00003B1E
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00005926 File Offset: 0x00003B26
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0000592F File Offset: 0x00003B2F
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00005937 File Offset: 0x00003B37
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00005940 File Offset: 0x00003B40
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00005948 File Offset: 0x00003B48
		public int ChunkIndex
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00005951 File Offset: 0x00003B51
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00005959 File Offset: 0x00003B59
		public bool IsPresent
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00005962 File Offset: 0x00003B62
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0000596A File Offset: 0x00003B6A
		public int RX
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00005973 File Offset: 0x00003B73
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0000597B File Offset: 0x00003B7B
		public int RZ
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

		// Token: 0x040003FC RID: 1020
		private string string_0;

		// Token: 0x040003FD RID: 1021
		private string string_1;

		// Token: 0x040003FE RID: 1022
		private int int_0;

		// Token: 0x040003FF RID: 1023
		private bool bool_0;

		// Token: 0x04000400 RID: 1024
		private int int_1;

		// Token: 0x04000401 RID: 1025
		private int int_2;
	}
}
