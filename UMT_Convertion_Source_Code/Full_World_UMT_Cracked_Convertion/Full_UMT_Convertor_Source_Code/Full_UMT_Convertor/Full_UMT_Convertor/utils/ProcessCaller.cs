using System;
using System.Diagnostics;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x02000148 RID: 328
	public class ProcessCaller
	{
		// Token: 0x06000DD2 RID: 3538 RVA: 0x0005D454 File Offset: 0x0005B654
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

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0005D4D0 File Offset: 0x0005B6D0
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

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00008F4F File Offset: 0x0000714F
		private string method_0()
		{
			return AppDomain.CurrentDomain.BaseDirectory + "\\Supported_Files\\";
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00008F65 File Offset: 0x00007165
		private string method_1(string string_0)
		{
			return this.method_0() + string_0;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00008F73 File Offset: 0x00007173
		private string method_2(string string_0)
		{
			return " \"" + this.method_0() + string_0 + "\"";
		}
	}
}
