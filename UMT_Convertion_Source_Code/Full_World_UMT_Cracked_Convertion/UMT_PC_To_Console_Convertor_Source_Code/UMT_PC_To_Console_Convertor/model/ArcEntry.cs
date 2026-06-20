using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200006C RID: 108
	public class ArcEntry
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x000024C1 File Offset: 0x000006C1
		public ArcEntry()
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00004A10 File Offset: 0x00002C10
		public ArcEntry(string name, int size, int pos)
		{
			this.name = name;
			this.size = size;
			this.pos = pos;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00004A2D File Offset: 0x00002C2D
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00004A35 File Offset: 0x00002C35
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00004A3E File Offset: 0x00002C3E
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00004A46 File Offset: 0x00002C46
		public int Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00004A4F File Offset: 0x00002C4F
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00004A57 File Offset: 0x00002C57
		public int Pos
		{
			get
			{
				return this.pos;
			}
			set
			{
				this.pos = value;
			}
		}

		// Token: 0x0400034F RID: 847
		private string name;

		// Token: 0x04000350 RID: 848
		private int size;

		// Token: 0x04000351 RID: 849
		private int pos;
	}
}
