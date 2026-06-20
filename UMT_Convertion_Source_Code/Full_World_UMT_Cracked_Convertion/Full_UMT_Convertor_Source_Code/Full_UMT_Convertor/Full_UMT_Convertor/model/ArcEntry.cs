using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200009F RID: 159
	public class ArcEntry
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x00002591 File Offset: 0x00000791
		public ArcEntry()
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00005378 File Offset: 0x00003578
		public ArcEntry(string name, int size, int pos)
		{
			this.name = name;
			this.size = size;
			this.pos = pos;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00005395 File Offset: 0x00003595
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x0000539D File Offset: 0x0000359D
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x000053A6 File Offset: 0x000035A6
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x000053AE File Offset: 0x000035AE
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x000053B7 File Offset: 0x000035B7
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x000053BF File Offset: 0x000035BF
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

		// Token: 0x040004CA RID: 1226
		private string name;

		// Token: 0x040004CB RID: 1227
		private int size;

		// Token: 0x040004CC RID: 1228
		private int pos;
	}
}
