using System;
using System.Collections;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.comparer
{
	// Token: 0x0200001B RID: 27
	public class LayerSorter : IComparer
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0000A2F4 File Offset: 0x000084F4
		public int Compare(object x, object y)
		{
			if (!(x is ListViewItem))
			{
				return 0;
			}
			if (!(y is ListViewItem))
			{
				return 0;
			}
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			float value = float.Parse(listViewItem.SubItems[this.Column].Text);
			float value2 = float.Parse(listViewItem2.SubItems[this.Column].Text);
			if (this.Order == SortOrder.Ascending)
			{
				return value.CompareTo(value2);
			}
			return value2.CompareTo(value);
		}

		// Token: 0x0400006D RID: 109
		public int Column;

		// Token: 0x0400006E RID: 110
		public SortOrder Order = SortOrder.Descending;
	}
}
