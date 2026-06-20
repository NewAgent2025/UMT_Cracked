using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x02000090 RID: 144
	[Serializable]
	public class GRFRuleItem
	{
		// Token: 0x060005FA RID: 1530 RVA: 0x00002591 File Offset: 0x00000791
		public GRFRuleItem()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00005070 File Offset: 0x00003270
		public GRFRuleItem(int id, string value)
		{
			this.id = id;
			this.value = value;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00005086 File Offset: 0x00003286
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0000508E File Offset: 0x0000328E
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00005097 File Offset: 0x00003297
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0000509F File Offset: 0x0000329F
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000050A8 File Offset: 0x000032A8
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000050B0 File Offset: 0x000032B0
		public List<GRFRuleItem> Rules
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

		// Token: 0x06000602 RID: 1538 RVA: 0x000383EC File Offset: 0x000365EC
		public GRFRuleItem Copy()
		{
			GRFRuleItem grfruleItem = new GRFRuleItem(this.id, this.value);
			List<GRFRuleItem> list = new List<GRFRuleItem>();
			if (this.list_0 != null)
			{
				foreach (GRFRuleItem grfruleItem2 in this.list_0)
				{
					list.Add(grfruleItem2.Copy());
				}
				grfruleItem.Rules = list;
			}
			return grfruleItem;
		}

		// Token: 0x040003AF RID: 943
		private int id;

		// Token: 0x040003B0 RID: 944
		private string value;

		// Token: 0x040003B1 RID: 945
		private List<GRFRuleItem> list_0;
	}
}
