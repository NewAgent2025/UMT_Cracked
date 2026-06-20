using System;

namespace Full_UMT_Convertor.PECode.model
{
	// Token: 0x02000121 RID: 289
	public class PEConsts
	{
		// Token: 0x040007C6 RID: 1990
		public static string[] peFiles = new string[]
		{
			"players\\~local_player",
			"data\\AutonomousEntities",
			"data\\BiomeData",
			"data\\game_flatworldlayers",
			"data\\mVillages",
			"data\\Nether",
			"data\\Overworld",
			"data\\TheEnd",
			"data\\portals",
			"data\\dimension0",
			"data\\dimension1",
			"data\\dimension2",
			"data\\scoreboard"
		};

		// Token: 0x040007C7 RID: 1991
		public static string[] txtFiles = new string[]
		{
			"game_flatworldlayers"
		};

		// Token: 0x02000122 RID: 290
		public enum DBRecordType
		{
			// Token: 0x040007C9 RID: 1993
			Data2D = 45,
			// Token: 0x040007CA RID: 1994
			Data2DLegacy,
			// Token: 0x040007CB RID: 1995
			SubChunkPrefix,
			// Token: 0x040007CC RID: 1996
			LegacyTerrain,
			// Token: 0x040007CD RID: 1997
			BlockEntity,
			// Token: 0x040007CE RID: 1998
			Entity,
			// Token: 0x040007CF RID: 1999
			PendingTicks,
			// Token: 0x040007D0 RID: 2000
			BlockExtraData,
			// Token: 0x040007D1 RID: 2001
			BiomeState,
			// Token: 0x040007D2 RID: 2002
			FinalizedState,
			// Token: 0x040007D3 RID: 2003
			Version = 118
		}
	}
}
