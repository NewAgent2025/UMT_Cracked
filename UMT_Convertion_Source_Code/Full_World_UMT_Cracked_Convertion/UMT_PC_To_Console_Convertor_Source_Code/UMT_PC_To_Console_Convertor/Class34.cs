using System;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor;

// Token: 0x020000C0 RID: 192
internal static class Class34
{
	// Token: 0x06000811 RID: 2065 RVA: 0x000067BD File Offset: 0x000049BD
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new MainForm(args));
	}
}
