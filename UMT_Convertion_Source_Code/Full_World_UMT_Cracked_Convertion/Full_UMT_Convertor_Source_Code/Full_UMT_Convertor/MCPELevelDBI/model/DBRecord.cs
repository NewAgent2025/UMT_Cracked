using System;

namespace MCPELevelDBI.model
{
	// Token: 0x0200011D RID: 285
	public class DBRecord
	{
		// Token: 0x06000C14 RID: 3092 RVA: 0x00002591 File Offset: 0x00000791
		public DBRecord()
		{
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00008346 File Offset: 0x00006546
		public DBRecord(byte[] key, byte[] value)
		{
			this.key = key;
			this.value = value;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0000835C File Offset: 0x0000655C
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00008364 File Offset: 0x00006564
		public byte[] Key
		{
			get
			{
				return this.key;
			}
			set
			{
				this.key = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0000836D File Offset: 0x0000656D
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00008375 File Offset: 0x00006575
		public byte[] Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x040007A5 RID: 1957
		private byte[] key;

		// Token: 0x040007A6 RID: 1958
		private byte[] value;
	}
}
