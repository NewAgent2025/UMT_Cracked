using System;

namespace Full_UMT_ConvertorDB.Model
{
	// Token: 0x02000002 RID: 2
	public class NBTLibraryItem
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000024B4 File Offset: 0x000006B4
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000024BC File Offset: 0x000006BC
		public Guid ID
		{
			get
			{
				return this.guid_0;
			}
			set
			{
				this.guid_0 = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000024C5 File Offset: 0x000006C5
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000024CD File Offset: 0x000006CD
		public int Version
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000024D6 File Offset: 0x000006D6
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000024DE File Offset: 0x000006DE
		public string Name
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000024E7 File Offset: 0x000006E7
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000024EF File Offset: 0x000006EF
		public string Author
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000024F8 File Offset: 0x000006F8
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002500 File Offset: 0x00000700
		public string Category
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002509 File Offset: 0x00000709
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002511 File Offset: 0x00000711
		public string Description
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000251A File Offset: 0x0000071A
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002522 File Offset: 0x00000722
		public string Instruction
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000252B File Offset: 0x0000072B
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002533 File Offset: 0x00000733
		public string String_0
		{
			get
			{
				return this.string_5;
			}
			set
			{
				this.string_5 = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000253C File Offset: 0x0000073C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002544 File Offset: 0x00000744
		public string Link
		{
			get
			{
				return this.string_6;
			}
			set
			{
				this.string_6 = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000254D File Offset: 0x0000074D
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002555 File Offset: 0x00000755
		public string Platform
		{
			get
			{
				return this.string_7;
			}
			set
			{
				this.string_7 = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000255E File Offset: 0x0000075E
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002566 File Offset: 0x00000766
		public string EntityType
		{
			get
			{
				return this.string_8;
			}
			set
			{
				this.string_8 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000256F File Offset: 0x0000076F
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002577 File Offset: 0x00000777
		public int Block
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002588 File Offset: 0x00000788
		public int Data
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

		// Token: 0x04000001 RID: 1
		private Guid guid_0;

		// Token: 0x04000002 RID: 2
		private int int_0;

		// Token: 0x04000003 RID: 3
		private string string_0;

		// Token: 0x04000004 RID: 4
		private string string_1;

		// Token: 0x04000005 RID: 5
		private string string_2;

		// Token: 0x04000006 RID: 6
		private string string_3;

		// Token: 0x04000007 RID: 7
		private string string_4;

		// Token: 0x04000008 RID: 8
		private string string_5;

		// Token: 0x04000009 RID: 9
		private string string_6;

		// Token: 0x0400000A RID: 10
		private string string_7;

		// Token: 0x0400000B RID: 11
		private string string_8;

		// Token: 0x0400000C RID: 12
		private int int_1;

		// Token: 0x0400000D RID: 13
		private int int_2;
	}
}
