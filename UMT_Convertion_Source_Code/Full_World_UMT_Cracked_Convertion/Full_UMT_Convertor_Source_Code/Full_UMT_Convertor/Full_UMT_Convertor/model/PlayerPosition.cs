using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000026 RID: 38
	public class PlayerPosition
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002ECA File Offset: 0x000010CA
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002ED2 File Offset: 0x000010D2
		public double X
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002EDB File Offset: 0x000010DB
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002EE3 File Offset: 0x000010E3
		public double Y
		{
			get
			{
				return this.double_1;
			}
			set
			{
				this.double_1 = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002EEC File Offset: 0x000010EC
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002EF4 File Offset: 0x000010F4
		public double Z
		{
			get
			{
				return this.double_2;
			}
			set
			{
				this.double_2 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002EFD File Offset: 0x000010FD
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002F05 File Offset: 0x00001105
		public float RotBody
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002F0E File Offset: 0x0000110E
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002F16 File Offset: 0x00001116
		public float RotHead
		{
			get
			{
				return this.float_1;
			}
			set
			{
				this.float_1 = value;
			}
		}

		// Token: 0x040000BF RID: 191
		private double double_0;

		// Token: 0x040000C0 RID: 192
		private double double_1;

		// Token: 0x040000C1 RID: 193
		private double double_2;

		// Token: 0x040000C2 RID: 194
		private float float_0;

		// Token: 0x040000C3 RID: 195
		private float float_1;
	}
}
