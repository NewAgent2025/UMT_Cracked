using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000096 RID: 150
	public class GClass0
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00005BDB File Offset: 0x00003DDB
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00005BE3 File Offset: 0x00003DE3
		public byte Index
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00005BEC File Offset: 0x00003DEC
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public byte Multiplier
		{
			get
			{
				return this.byte_1;
			}
			set
			{
				this.byte_1 = value;
			}
		}

		// Token: 0x04000421 RID: 1057
		private byte byte_0;

		// Token: 0x04000422 RID: 1058
		private byte byte_1;
	}
}
