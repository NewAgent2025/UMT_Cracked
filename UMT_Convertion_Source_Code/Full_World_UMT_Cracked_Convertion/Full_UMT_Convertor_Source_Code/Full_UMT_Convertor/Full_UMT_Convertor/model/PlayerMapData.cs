using System;
using System.Runtime.CompilerServices;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D3 RID: 211
	public class PlayerMapData
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00002591 File Offset: 0x00000791
		public PlayerMapData()
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00006A9D File Offset: 0x00004C9D
		public PlayerMapData(int x, int y, int z, string name)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.name = name;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00006AC2 File Offset: 0x00004CC2
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00006ACA File Offset: 0x00004CCA
		public int x { get; set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00006AD3 File Offset: 0x00004CD3
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00006ADB File Offset: 0x00004CDB
		public int y { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00006AE4 File Offset: 0x00004CE4
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00006AEC File Offset: 0x00004CEC
		public int z { get; set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00006AF5 File Offset: 0x00004CF5
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00006AFD File Offset: 0x00004CFD
		public string name { get; set; }

		// Token: 0x04000623 RID: 1571
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000624 RID: 1572
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000625 RID: 1573
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04000626 RID: 1574
		[CompilerGenerated]
		private string string_0;
	}
}
