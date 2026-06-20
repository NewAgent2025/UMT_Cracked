using System;
using System.Drawing;
using System.Threading;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000B2 RID: 178
	public class MapBlockParameter
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x00002591 File Offset: 0x00000791
		public MapBlockParameter()
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00005D59 File Offset: 0x00003F59
		public MapBlockParameter(string dimension, string region, string outFolderPath, ManualResetEvent doneEvent)
		{
			this.dimension = dimension;
			this.region = region;
			this.outFolderPath = outFolderPath;
			this.doneEvent = doneEvent;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00005D7E File Offset: 0x00003F7E
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00005D86 File Offset: 0x00003F86
		public string Dimension
		{
			get
			{
				return this.dimension;
			}
			set
			{
				this.dimension = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00005D8F File Offset: 0x00003F8F
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00005D97 File Offset: 0x00003F97
		public string Region
		{
			get
			{
				return this.region;
			}
			set
			{
				this.region = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00005DA0 File Offset: 0x00003FA0
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public string OutFolderPath
		{
			get
			{
				return this.outFolderPath;
			}
			set
			{
				this.outFolderPath = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00005DB1 File Offset: 0x00003FB1
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00005DB9 File Offset: 0x00003FB9
		public bool Completed
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00005DC2 File Offset: 0x00003FC2
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00005DCA File Offset: 0x00003FCA
		public int ChunkProcessedCount
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00005DD3 File Offset: 0x00003FD3
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00005DDB File Offset: 0x00003FDB
		public Image BlockImage
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00005DE4 File Offset: 0x00003FE4
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00005DEC File Offset: 0x00003FEC
		public Image BiomeImage
		{
			get
			{
				return this.image_1;
			}
			set
			{
				this.image_1 = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00005DF5 File Offset: 0x00003FF5
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00005DFD File Offset: 0x00003FFD
		public Image HeightImage
		{
			get
			{
				return this.image_2;
			}
			set
			{
				this.image_2 = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00005E06 File Offset: 0x00004006
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00005E0E File Offset: 0x0000400E
		public ManualResetEvent DoneEvent
		{
			get
			{
				return this.doneEvent;
			}
			set
			{
				this.doneEvent = value;
			}
		}

		// Token: 0x0400051D RID: 1309
		private bool bool_0;

		// Token: 0x0400051E RID: 1310
		private string dimension;

		// Token: 0x0400051F RID: 1311
		private string region;

		// Token: 0x04000520 RID: 1312
		private string outFolderPath;

		// Token: 0x04000521 RID: 1313
		private Image image_0;

		// Token: 0x04000522 RID: 1314
		private Image image_1;

		// Token: 0x04000523 RID: 1315
		private Image image_2;

		// Token: 0x04000524 RID: 1316
		private int int_0;

		// Token: 0x04000525 RID: 1317
		private ManualResetEvent doneEvent;
	}
}
