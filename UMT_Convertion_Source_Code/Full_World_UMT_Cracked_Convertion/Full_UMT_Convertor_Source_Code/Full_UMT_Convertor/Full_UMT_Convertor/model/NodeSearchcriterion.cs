using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000CD RID: 205
	public class NodeSearchcriterion
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000066E3 File Offset: 0x000048E3
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x000066EB File Offset: 0x000048EB
		public string Node
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000066F4 File Offset: 0x000048F4
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x000066FC File Offset: 0x000048FC
		public string Value
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00006705 File Offset: 0x00004905
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0000670D File Offset: 0x0000490D
		public SearchCondition Condition
		{
			get
			{
				return this.searchCondition_0;
			}
			set
			{
				this.searchCondition_0 = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00006716 File Offset: 0x00004916
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0000671E File Offset: 0x0000491E
		public List<NodeSearchcriterion> NodeConditions
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x040005FB RID: 1531
		private string string_0 = "";

		// Token: 0x040005FC RID: 1532
		private string string_1 = "";

		// Token: 0x040005FD RID: 1533
		private SearchCondition searchCondition_0;

		// Token: 0x040005FE RID: 1534
		private List<NodeSearchcriterion> list_0;
	}
}
