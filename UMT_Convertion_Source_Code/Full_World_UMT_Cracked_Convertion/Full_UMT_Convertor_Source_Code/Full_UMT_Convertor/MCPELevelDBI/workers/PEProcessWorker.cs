using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.utils;

namespace MCPELevelDBI.workers
{
	// Token: 0x02000134 RID: 308
	public class PEProcessWorker
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x00008A3C File Offset: 0x00006C3C
		public void SaveFromStaging(string originalWorldPath, string workingWorldPath)
		{
			this.method_0(originalWorldPath, workingWorldPath);
			this.method_1(originalWorldPath, workingWorldPath);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00059450 File Offset: 0x00057650
		private void method_0(string string_0, string string_1)
		{
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = FileUtils.smethod_0(Path.Combine(string_1, "level.dat"));
			memoryStream.Write(BitConverter.GetBytes(8), 0, 4);
			memoryStream.Write(BitConverter.GetBytes(array.Length), 0, 4);
			memoryStream.Write(array, 0, array.Length);
			FileUtils.WriteFile(memoryStream.ToArray(), Path.Combine(string_0, "level.dat"));
			if (File.Exists(Path.Combine(string_1, "levelname.txt")))
			{
				File.Copy(Path.Combine(string_1, "levelname.txt"), Path.Combine(string_0, "levelname.txt"), true);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000594E4 File Offset: 0x000576E4
		private void method_1(string string_0, string string_1)
		{
			string path = Path.Combine(string_0, "db");
			Directory.CreateDirectory(path);
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				fileInfo.Delete();
			}
			string path2 = Path.Combine(string_0, "db");
			foreach (string text in Directory.GetFiles(Path.Combine(string_1, "db")))
			{
				File.Copy(text, Path.Combine(path2, Path.GetFileName(text)));
			}
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00059580 File Offset: 0x00057780
		public List<PEDimension> GetAvailableChunks(string path)
		{
			LevelDBWorker levelDBWorker = PEUtility.OpenDBWorker(path);
			List<PEDimension> availableChunks = levelDBWorker.GetAvailableChunks();
			levelDBWorker.CloseDB();
			for (int i = 0; i < 3; i++)
			{
				List<PERegion> list = availableChunks[i].Region.Values.ToList<PERegion>();
				IEnumerable<PERegion> source = list;
				if (PEProcessWorker.func_0 == null)
				{
					PEProcessWorker.func_0 = new Func<PERegion, int>(PEProcessWorker.smethod_0);
				}
				IOrderedEnumerable<PERegion> source2 = source.OrderBy(PEProcessWorker.func_0);
				if (PEProcessWorker.func_1 == null)
				{
					PEProcessWorker.func_1 = new Func<PERegion, int>(PEProcessWorker.smethod_1);
				}
				list = source2.ThenBy(PEProcessWorker.func_1).ToList<PERegion>();
				availableChunks[i].Region.Clear();
				foreach (PERegion peregion in list)
				{
					availableChunks[i].Region.Add(peregion.RX + "." + peregion.RZ, peregion);
				}
			}
			return availableChunks;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0005969C File Offset: 0x0005789C
		public void DeleteAllRegionsInDimension(string dimensionName, string path)
		{
			PEDimension pedimension = PEUtility.GetPEDimension(dimensionName);
			LevelDBWorker levelDBWorker = PEUtility.OpenDBWorker(path);
			foreach (PERegion regionData in pedimension.Region.Values)
			{
				levelDBWorker.DeleteRegionChunks(regionData);
			}
			levelDBWorker.CloseDB();
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00008A4E File Offset: 0x00006C4E
		[CompilerGenerated]
		private static int smethod_0(PERegion peregion_0)
		{
			return peregion_0.RX;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00008A56 File Offset: 0x00006C56
		[CompilerGenerated]
		private static int smethod_1(PERegion peregion_0)
		{
			return peregion_0.RZ;
		}

		// Token: 0x040007FF RID: 2047
		[CompilerGenerated]
		private static Func<PERegion, int> func_0;

		// Token: 0x04000800 RID: 2048
		[CompilerGenerated]
		private static Func<PERegion, int> func_1;
	}
}
