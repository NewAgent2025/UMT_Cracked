using System;
using System.Collections;
using System.Windows.Forms;

// Token: 0x02000145 RID: 325
public class ListViewColumnSorter : IComparer
{
	// Token: 0x06000DC1 RID: 3521 RVA: 0x00008EE7 File Offset: 0x000070E7
	public ListViewColumnSorter()
	{
		this.int_0 = 0;
		this.sortOrder_0 = SortOrder.None;
		this.caseInsensitiveComparer_0 = new CaseInsensitiveComparer();
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x0005D13C File Offset: 0x0005B33C
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

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00008F11 File Offset: 0x00007111
	// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00008F08 File Offset: 0x00007108
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

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00008F22 File Offset: 0x00007122
	// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00008F19 File Offset: 0x00007119
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

	// Token: 0x04000837 RID: 2103
	private int int_0;

	// Token: 0x04000838 RID: 2104
	private SortOrder sortOrder_0;

	// Token: 0x04000839 RID: 2105
	private CaseInsensitiveComparer caseInsensitiveComparer_0;
}
