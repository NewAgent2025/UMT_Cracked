using System;
using System.IO;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.MCSBCode.Workers
{
	// Token: 0x0200009D RID: 157
	public class DeleteWorkingFolder
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x0003CD58 File Offset: 0x0003AF58
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
