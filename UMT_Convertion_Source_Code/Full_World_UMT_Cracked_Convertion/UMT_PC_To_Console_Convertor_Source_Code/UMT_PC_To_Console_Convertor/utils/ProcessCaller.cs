using System;
using System.Diagnostics;

namespace UMT_PC_To_Console_Convertor.utils
{
	// Token: 0x020000CE RID: 206
	public class ProcessCaller
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x00032CA4 File Offset: 0x00030EA4
		public void CallExtractSaveGame(string inFilePath, string outFolderPath)
		{
			string fileName = this.method_1("X360.exe");
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.Arguments = string.Concat(new string[]
			{
				" -d \"",
				inFilePath,
				"\"  \"",
				outFolderPath,
				"\""
			});
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00032D20 File Offset: 0x00030F20
		public void CallCompressSaveGame(string inFilePath, string outFolderPath)
		{
			string fileName = this.method_1("X360.exe");
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.Arguments = string.Concat(new string[]
			{
				" -c \"",
				inFilePath,
				"\"  \"",
				outFolderPath,
				"\""
			});
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00006CA6 File Offset: 0x00004EA6
		private string method_0()
		{
			return AppDomain.CurrentDomain.BaseDirectory + "\\Supported_Files\\";
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00006CBC File Offset: 0x00004EBC
		private string method_1(string string_0)
		{
			return this.method_0() + string_0;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00006CCA File Offset: 0x00004ECA
		private string method_2(string string_0)
		{
			return " \"" + this.method_0() + string_0 + "\"";
		}
	}
}
