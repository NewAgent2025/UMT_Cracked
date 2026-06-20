using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000139 RID: 313
	public class CallBrowser
	{
		// Token: 0x06000D1D RID: 3357 RVA: 0x0005A73C File Offset: 0x0005893C
		public void Call(string target)
		{
			try
			{
				Process.Start(target);
			}
			catch (Win32Exception ex)
			{
				if (ex.ErrorCode == -2147467259)
				{
					MessageBox.Show(ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message);
			}
		}
	}
}
