using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000CC RID: 204
	public static class NativeMethods
	{
		// Token: 0x060008AF RID: 2223
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x060008B0 RID: 2224 RVA: 0x000329FC File Offset: 0x00030BFC
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
