using System;
using System.Text;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000086 RID: 134
	public class ConvertStatus
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000053AB File Offset: 0x000035AB
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000053B3 File Offset: 0x000035B3
		public int ProcessedChunkCount
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x000053BC File Offset: 0x000035BC
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x000053C4 File Offset: 0x000035C4
		public int MissingChunkCount
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000053CD File Offset: 0x000035CD
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x000053D5 File Offset: 0x000035D5
		public int InvalidChunkCount
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

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002A158 File Offset: 0x00028358
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Processed Chunks: " + this.int_0);
			if (this.int_1 > 0)
			{
				stringBuilder.AppendLine("Missing Chunks: " + this.int_1);
			}
			if (this.int_2 > 0)
			{
				stringBuilder.AppendLine("Invalid Chunks: " + this.int_2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040003BE RID: 958
		private int int_0;

		// Token: 0x040003BF RID: 959
		private int int_1;

		// Token: 0x040003C0 RID: 960
		private int int_2;
	}
}
