using System;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000AA RID: 170
	public class EntityItem
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0000568B File Offset: 0x0000388B
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00005693 File Offset: 0x00003893
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0000569C File Offset: 0x0000389C
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000056A4 File Offset: 0x000038A4
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000056AD File Offset: 0x000038AD
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000056B5 File Offset: 0x000038B5
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000056BE File Offset: 0x000038BE
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000056C6 File Offset: 0x000038C6
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000056CF File Offset: 0x000038CF
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x000056D7 File Offset: 0x000038D7
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000056E0 File Offset: 0x000038E0
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x000056E8 File Offset: 0x000038E8
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

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002591 File Offset: 0x00000791
		public EntityItem()
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000056F1 File Offset: 0x000038F1
		public EntityItem(string consoleName, string pcOldName, string pcName, bool consoleSpawner, EntityCategory entityCategory)
		{
			this.consoleName = consoleName;
			this.entityCategory = entityCategory;
			this.pcOldName = pcOldName;
			this.pcName = pcName;
			this.consoleSpawner = consoleSpawner;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000571E File Offset: 0x0000391E
		public EntityItem(string consoleName, string pcOldName, string pcName, bool consoleSpawner, EntityCategory entityCategory, int entityType)
		{
			this.consoleName = consoleName;
			this.entityCategory = entityCategory;
			this.pcOldName = pcOldName;
			this.consoleSpawner = consoleSpawner;
			this.pcName = pcName;
			this.entityType = entityType;
		}

		// Token: 0x040004F8 RID: 1272
		private string consoleName;

		// Token: 0x040004F9 RID: 1273
		private string pcOldName;

		// Token: 0x040004FA RID: 1274
		private string pcName;

		// Token: 0x040004FB RID: 1275
		private bool consoleSpawner;

		// Token: 0x040004FC RID: 1276
		private EntityCategory entityCategory;

		// Token: 0x040004FD RID: 1277
		private int entityType;
	}
}
