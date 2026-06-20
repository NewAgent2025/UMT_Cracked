using System;
using System.Drawing;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200004A RID: 74
	public class ListViewEx : ListView
	{
		// Token: 0x060002CA RID: 714 RVA: 0x00003C4D File Offset: 0x00001E4D
		public ListViewEx()
		{
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00003C6F File Offset: 0x00001E6F
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003C77 File Offset: 0x00001E77
		public int LineBefore
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00003C88 File Offset: 0x00001E88
		public int LineAfter
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00019270 File Offset: 0x00017470
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 15)
			{
				if (this.LineBefore >= 0 && this.LineBefore < base.Items.Count)
				{
					Rectangle bounds = base.Items[this.LineBefore].GetBounds(ItemBoundsPortion.Entire);
					this.method_0(bounds.Left, bounds.Right, bounds.Top);
				}
				if (this.LineAfter >= 0 && this.LineBefore < base.Items.Count)
				{
					Rectangle bounds2 = base.Items[this.LineAfter].GetBounds(ItemBoundsPortion.Entire);
					this.method_0(bounds2.Left, bounds2.Right, bounds2.Bottom);
				}
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001933C File Offset: 0x0001753C
		private void method_0(int int_2, int int_3, int int_4)
		{
			using (Graphics graphics = base.CreateGraphics())
			{
				graphics.DrawLine(Pens.Red, int_2, int_4, int_3 - 1, int_4);
				Point[] points = new Point[]
				{
					new Point(int_2, int_4 - 4),
					new Point(int_2 + 7, int_4),
					new Point(int_2, int_4 + 4)
				};
				Point[] points2 = new Point[]
				{
					new Point(int_3, int_4 - 4),
					new Point(int_3 - 8, int_4),
					new Point(int_3, int_4 + 4)
				};
				graphics.FillPolygon(Brushes.Red, points);
				graphics.FillPolygon(Brushes.Red, points2);
			}
		}

		// Token: 0x040001C6 RID: 454
		private int int_0 = -1;

		// Token: 0x040001C7 RID: 455
		private int int_1 = -1;
	}
}
