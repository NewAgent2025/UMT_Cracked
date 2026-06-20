using System;
using System.Windows.Forms;
using Full_UMT_Convertor;

// Token: 0x02000135 RID: 309
internal static class Class44
{
	// Token: 0x06000D05 RID: 3333 RVA: 0x00008A5E File Offset: 0x00006C5E
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new MainForm(args));
	}
}
