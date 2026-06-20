using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000146 RID: 326
	public static class NativeMethods
	{
		// Token: 0x06000DC7 RID: 3527
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0005D1AC File Offset: 0x0005B3AC
		public static void Scroll(this Control control)
		{
			Point point = control.PointToClient(Cursor.Position);
			if (point.Y + 20 > control.Height)
			{
				NativeMethods.SendMessage(control.Handle, 277U, (IntPtr)1, (IntPtr)0);
				return;
			}
			if (point.Y < 20)
			{
				NativeMethods.SendMessage(control.Handle, 277U, (IntPtr)0, (IntPtr)0);
			}
		}
	}
}
