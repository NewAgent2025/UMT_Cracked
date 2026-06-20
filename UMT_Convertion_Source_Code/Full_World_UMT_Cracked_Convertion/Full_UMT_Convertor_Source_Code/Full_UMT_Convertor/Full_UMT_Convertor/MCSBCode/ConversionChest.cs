using System;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x0200002D RID: 45
	public class ConversionChest
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00003118 File Offset: 0x00001318
		internal ConversionChest(Coord Coord, Coord link)
		{
			this.Coord = Coord;
			this.link = link;
		}

		// Token: 0x040000E1 RID: 225
		public Coord Coord;

		// Token: 0x040000E2 RID: 226
		public Coord link;
	}
}
