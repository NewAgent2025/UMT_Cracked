using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.MCSBCode;
using Save_Manager.model;

// Token: 0x0200010B RID: 267
internal class Class39
{
	// Token: 0x06000B53 RID: 2899 RVA: 0x000556E0 File Offset: 0x000538E0
	internal List<XboxPackageData> method_0()
	{
		XboxPackageWorker xboxPackageWorker = new XboxPackageWorker();
		List<XboxPackageData> list = new List<XboxPackageData>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			bool isReady = driveInfo.IsReady;
			if (driveInfo.IsReady && driveInfo.DriveFormat == "FAT32" && driveInfo.DriveType == DriveType.Removable && Directory.Exists(driveInfo.Name + "Content"))
			{
				string[] directories = Directory.GetDirectories(driveInfo.Name + "Content");
				foreach (string text in directories)
				{
					if (Directory.Exists(text + "\\584111F7\\00000001\\"))
					{
						Path.GetFileName(text);
						DirectoryInfo directoryInfo = new DirectoryInfo(text + "\\584111F7\\00000001\\");
						FileInfo[] files = directoryInfo.GetFiles("*.bin");
						foreach (FileInfo fileInfo in files)
						{
							string source = Path.Combine(fileInfo.DirectoryName, fileInfo.Name);
							try
							{
								XboxPackageData item = xboxPackageWorker.DoPackageInfo(source);
								list.Add(item);
							}
							catch (Exception)
							{
								throw;
							}
						}
					}
				}
			}
		}
		return list;
	}
}
