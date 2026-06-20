using System;
using System.Drawing;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000030 RID: 48
	public class ListViewEx : ListView
	{
		// Token: 0x060001EA RID: 490 RVA: 0x00003661 File Offset: 0x00001861
		public ListViewEx()
		{
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00003683 File Offset: 0x00001883
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000368B File Offset: 0x0000188B
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00003694 File Offset: 0x00001894
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000369C File Offset: 0x0000189C
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

		// Token: 0x060001EF RID: 495 RVA: 0x00011A54 File Offset: 0x0000FC54
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

		// Token: 0x060001F0 RID: 496 RVA: 0x00011B20 File Offset: 0x0000FD20
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

		// Token: 0x04000119 RID: 281
		private int int_0 = -1;

		// Token: 0x0400011A RID: 282
		private int int_1 = -1;
	}
}
