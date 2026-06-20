using System;
using System.Collections;
using System.Windows.Forms;

// Token: 0x020000CB RID: 203
public class ListViewColumnSorter : IComparer
{
	// Token: 0x060008A9 RID: 2217 RVA: 0x00006C3E File Offset: 0x00004E3E
	public ListViewColumnSorter()
	{
		this.int_0 = 0;
		this.sortOrder_0 = SortOrder.None;
		this.caseInsensitiveComparer_0 = new CaseInsensitiveComparer();
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x0003298C File Offset: 0x00030B8C
	public int Compare(object x, object y)
	{
		ListViewItem listViewItem = (ListViewItem)x;
		ListViewItem listViewItem2 = (ListViewItem)y;
		int num = this.caseInsensitiveComparer_0.Compare(listViewItem.SubItems[this.int_0].Text, listViewItem2.SubItems[this.int_0].Text);
		if (this.sortOrder_0 == SortOrder.Ascending)
		{
			return num;
		}
		if (this.sortOrder_0 == SortOrder.Descending)
		{
			return -num;
		}
		return 0;
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x060008AC RID: 2220 RVA: 0x00006C68 File Offset: 0x00004E68
	// (set) Token: 0x060008AB RID: 2219 RVA: 0x00006C5F File Offset: 0x00004E5F
	public int SortColumn
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

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x060008AE RID: 2222 RVA: 0x00006C79 File Offset: 0x00004E79
	// (set) Token: 0x060008AD RID: 2221 RVA: 0x00006C70 File Offset: 0x00004E70
	public SortOrder Order
	{
		get
		{
			return this.sortOrder_0;
		}
		set
		{
			this.sortOrder_0 = value;
		}
	}

	// Token: 0x04000550 RID: 1360
	private int int_0;

	// Token: 0x04000551 RID: 1361
	private SortOrder sortOrder_0;

	// Token: 0x04000552 RID: 1362
	private CaseInsensitiveComparer caseInsensitiveComparer_0;
}
