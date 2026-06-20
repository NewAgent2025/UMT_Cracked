using System;
using System.IO;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.MCSBCode.Workers
{
	// Token: 0x0200006A RID: 106
	public class DeleteWorkingFolder
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x000253AC File Offset: 0x000235AC
		public void DoDelete(object threadContext)
		{
			DeleteFolderParameter deleteFolderParameter = threadContext as DeleteFolderParameter;
			if (deleteFolderParameter != null && !string.IsNullOrWhiteSpace(deleteFolderParameter.OldFolderPath))
			{
				try
				{
					Directory.Delete(deleteFolderParameter.OldFolderPath, true);
				}
				catch (Exception)
				{
				}
			}
			deleteFolderParameter.DoneEvent.Set();
		}
	}
}
