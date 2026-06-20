using System;
using System.IO;
using System.Reflection;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x0200013B RID: 315
	public class EmbeddedUtils
	{
		// Token: 0x06000D22 RID: 3362 RVA: 0x0005A830 File Offset: 0x00058A30
		public static string GetResource(string fileName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string result = string.Empty;
			StreamReader streamReader = new StreamReader(executingAssembly.GetManifestResourceStream("Full_UMT_Convertor." + fileName));
			result = streamReader.ReadToEnd();
			streamReader.Close();
			return result;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0005A86C File Offset: 0x00058A6C
		public static byte[] GetResourceBytes(string fileName)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Full_UMT_Convertor." + fileName);
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			manifestResourceStream.Close();
			return array;
		}
	}
}
