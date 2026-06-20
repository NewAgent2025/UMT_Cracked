using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000082 RID: 130
	[Serializable]
	public class Block
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x000024C1 File Offset: 0x000006C1
		public Block()
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000051F5 File Offset: 0x000033F5
		public Block(int id, int data)
		{
			this.id = id;
			this.data = data;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000520B File Offset: 0x0000340B
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00005213 File Offset: 0x00003413
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000521C File Offset: 0x0000341C
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00005224 File Offset: 0x00003424
		public int Data
		{
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0000522D File Offset: 0x0000342D
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00005235 File Offset: 0x00003435
		public int Light
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

		// Token: 0x06000596 RID: 1430 RVA: 0x00029F2C File Offset: 0x0002812C
		public Block Copy()
		{
			return new Block
			{
				id = this.id,
				data = this.data,
				int_0 = this.int_0
			};
		}

		// Token: 0x040003AB RID: 939
		private int id;

		// Token: 0x040003AC RID: 940
		private int data;

		// Token: 0x040003AD RID: 941
		private int int_0;
	}
}
