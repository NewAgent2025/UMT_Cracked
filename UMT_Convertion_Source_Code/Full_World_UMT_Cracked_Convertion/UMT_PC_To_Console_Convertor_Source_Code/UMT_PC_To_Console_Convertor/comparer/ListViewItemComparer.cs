using System;
using System.Collections;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.comparer
{
	// Token: 0x0200001C RID: 28
	public class ListViewItemComparer : IComparer
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002A3B File Offset: 0x00000C3B
		public ListViewItemComparer()
		{
			this.column = 0;
			this.order = SortOrder.Ascending;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002A51 File Offset: 0x00000C51
		public ListViewItemComparer(int column, SortOrder order)
		{
			this.column = column;
			this.order = order;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000A378 File Offset: 0x00008578
		public int Compare(object x, object y)
		{
			int num = string.Compare(((ListViewItem)x).SubItems[this.column].Text, ((ListViewItem)y).SubItems[this.column].Text);
			if (this.order == SortOrder.Descending)
			{
				num *= -1;
			}
			return num;
		}

		// Token: 0x0400006F RID: 111
		private int column;

		// Token: 0x04000070 RID: 112
		private SortOrder order;
	}
}
