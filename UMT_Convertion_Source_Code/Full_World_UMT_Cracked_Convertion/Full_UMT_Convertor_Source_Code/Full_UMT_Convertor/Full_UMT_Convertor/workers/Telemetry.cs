using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.workers
{
	// Token: 0x02000155 RID: 341
	public class Telemetry
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000091AB File Offset: 0x000073AB
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x000091B2 File Offset: 0x000073B2
		public static List<int> MissingConsoleBlocks
		{
			get
			{
				return Telemetry.list_0;
			}
			set
			{
				Telemetry.list_0 = value;
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0005E78C File Offset: 0x0005C98C
		public static void AddConsoleMissingBlock(int block)
		{
			lock (Telemetry.object_0)
			{
				if (!Telemetry.list_0.Contains(block))
				{
					Telemetry.list_0.Add(block);
				}
			}
		}

		// Token: 0x04000850 RID: 2128
		private static List<int> list_0 = new List<int>();

		// Token: 0x04000851 RID: 2129
		private static readonly object object_0 = new object();
	}
}
