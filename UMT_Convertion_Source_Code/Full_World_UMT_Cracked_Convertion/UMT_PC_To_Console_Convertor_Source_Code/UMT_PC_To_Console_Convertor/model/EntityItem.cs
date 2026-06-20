using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000073 RID: 115
	public class EntityItem
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00004B4E File Offset: 0x00002D4E
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004B56 File Offset: 0x00002D56
		public string ConsoleName
		{
			get
			{
				return this.consoleName;
			}
			set
			{
				this.consoleName = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00004B5F File Offset: 0x00002D5F
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004B67 File Offset: 0x00002D67
		public string String_0
		{
			get
			{
				return this.pcOldName;
			}
			set
			{
				this.pcOldName = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00004B70 File Offset: 0x00002D70
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00004B78 File Offset: 0x00002D78
		public string PCName
		{
			get
			{
				return this.pcName;
			}
			set
			{
				this.pcName = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00004B81 File Offset: 0x00002D81
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004B89 File Offset: 0x00002D89
		public bool ConsoleSpawner
		{
			get
			{
				return this.consoleSpawner;
			}
			set
			{
				this.consoleSpawner = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00004B92 File Offset: 0x00002D92
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004B9A File Offset: 0x00002D9A
		public EntityCategory EntityCategory
		{
			get
			{
				return this.entityCategory;
			}
			set
			{
				this.entityCategory = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00004BA3 File Offset: 0x00002DA3
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004BAB File Offset: 0x00002DAB
		public int EntityType
		{
			get
			{
				return this.entityType;
			}
			set
			{
				this.entityType = value;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000024C1 File Offset: 0x000006C1
		public EntityItem()
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public EntityItem(string consoleName, string pcOldName, string pcName, bool consoleSpawner, EntityCategory entityCategory)
		{
			this.consoleName = consoleName;
			this.entityCategory = entityCategory;
			this.pcOldName = pcOldName;
			this.pcName = pcName;
			this.consoleSpawner = consoleSpawner;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00004BE1 File Offset: 0x00002DE1
		public EntityItem(string consoleName, string pcOldName, string pcName, bool consoleSpawner, EntityCategory entityCategory, int entityType)
		{
			this.consoleName = consoleName;
			this.entityCategory = entityCategory;
			this.pcOldName = pcOldName;
			this.consoleSpawner = consoleSpawner;
			this.pcName = pcName;
			this.entityType = entityType;
		}

		// Token: 0x04000366 RID: 870
		private string consoleName;

		// Token: 0x04000367 RID: 871
		private string pcOldName;

		// Token: 0x04000368 RID: 872
		private string pcName;

		// Token: 0x04000369 RID: 873
		private bool consoleSpawner;

		// Token: 0x0400036A RID: 874
		private EntityCategory entityCategory;

		// Token: 0x0400036B RID: 875
		private int entityType;
	}
}
