using System;
using System.Threading;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000A9 RID: 169
	public class ConvertFromPCParameters
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x000024C1 File Offset: 0x000006C1
		public ConvertFromPCParameters()
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00005F3B File Offset: 0x0000413B
		public ConvertFromPCParameters(string regionName, string regionfolder, string pcRegionFolder, string workingFolder, ConvertParameters convertParameters, ManualResetEvent doneEvent)
		{
			this.regionName = regionName;
			this.regionfolder = regionfolder;
			this.pcRegionFolder = pcRegionFolder;
			this.workingFolder = workingFolder;
			this.convertParameters = convertParameters;
			this.doneEvent = doneEvent;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00005F70 File Offset: 0x00004170
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00005F78 File Offset: 0x00004178
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00005F81 File Offset: 0x00004181
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00005F89 File Offset: 0x00004189
		public string RegionName
		{
			get
			{
				return this.regionName;
			}
			set
			{
				this.regionName = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00005F92 File Offset: 0x00004192
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00005F9A File Offset: 0x0000419A
		public string RegionFolder
		{
			get
			{
				return this.regionfolder;
			}
			set
			{
				this.regionfolder = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00005FA3 File Offset: 0x000041A3
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00005FAB File Offset: 0x000041AB
		public string PCRegionFolder
		{
			get
			{
				return this.pcRegionFolder;
			}
			set
			{
				this.pcRegionFolder = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00005FB4 File Offset: 0x000041B4
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00005FBC File Offset: 0x000041BC
		public string WorkingFolder
		{
			get
			{
				return this.workingFolder;
			}
			set
			{
				this.workingFolder = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00005FC5 File Offset: 0x000041C5
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00005FCD File Offset: 0x000041CD
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters;
			}
			set
			{
				this.convertParameters = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00005FD6 File Offset: 0x000041D6
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00005FDE File Offset: 0x000041DE
		public int Count
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00005FE7 File Offset: 0x000041E7
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00005FEF File Offset: 0x000041EF
		public bool ProcessingCompleted
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00005FF8 File Offset: 0x000041F8
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00006000 File Offset: 0x00004200
		public bool Done
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00006009 File Offset: 0x00004209
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00006011 File Offset: 0x00004211
		public int ProcessedChunkCount
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x0000601A File Offset: 0x0000421A
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00006022 File Offset: 0x00004222
		public int MissingChunkCount
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0000602B File Offset: 0x0000422B
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00006033 File Offset: 0x00004233
		public int InvalidChunkCount
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		// Token: 0x04000495 RID: 1173
		private ManualResetEvent doneEvent;

		// Token: 0x04000496 RID: 1174
		private string regionName;

		// Token: 0x04000497 RID: 1175
		private string regionfolder;

		// Token: 0x04000498 RID: 1176
		private string pcRegionFolder;

		// Token: 0x04000499 RID: 1177
		private string workingFolder;

		// Token: 0x0400049A RID: 1178
		private ConvertParameters convertParameters;

		// Token: 0x0400049B RID: 1179
		private int int_0;

		// Token: 0x0400049C RID: 1180
		private bool bool_0;

		// Token: 0x0400049D RID: 1181
		private bool bool_1;

		// Token: 0x0400049E RID: 1182
		private int int_1;

		// Token: 0x0400049F RID: 1183
		private int int_2;

		// Token: 0x040004A0 RID: 1184
		private int int_3;
	}
}
