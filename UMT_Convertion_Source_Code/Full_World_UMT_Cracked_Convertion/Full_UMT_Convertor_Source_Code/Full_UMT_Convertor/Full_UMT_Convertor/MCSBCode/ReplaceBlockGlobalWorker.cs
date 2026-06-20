using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x020000BD RID: 189
	public class ReplaceBlockGlobalWorker
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x00002591 File Offset: 0x00000791
		public ReplaceBlockGlobalWorker()
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00006091 File Offset: 0x00004291
		public ReplaceBlockGlobalWorker(BackgroundWorker backgroundWorker)
		{
			this.backgroundWorker = backgroundWorker;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000060A0 File Offset: 0x000042A0
		public void DoReplace(string dimension, List<BlockChange> replacementBlockList, string outFolderPath)
		{
			this.method_4(dimension);
			if (replacementBlockList.Count == 0)
			{
				return;
			}
			if (this.Replace(dimension, replacementBlockList, outFolderPath))
			{
				this.method_0(outFolderPath);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00043244 File Offset: 0x00041444
		private void method_0(string string_0)
		{
			MCSupport mcsupport = new MCSupport(this.backgroundWorker);
			mcsupport.method_16(string_0, false, false);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00043268 File Offset: 0x00041468
		public bool Replace(string dimension, List<BlockChange> replacementBlockList, string outFolderPath)
		{
			int num = 4;
			ManualResetEvent[] array = new ManualResetEvent[4];
			ReplaceBlockGlobalParameter[] array2 = new ReplaceBlockGlobalParameter[4];
			int num2 = 0;
			foreach (string region in Constants.regionFileNames)
			{
				array[num2] = new ManualResetEvent(false);
				ReplaceBlockGlobalParameter replaceBlockGlobalParameter = new ReplaceBlockGlobalParameter(dimension, region, replacementBlockList, outFolderPath, array[num2]);
				ReplaceBlocksGlobal @object = new ReplaceBlocksGlobal();
				ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Replace), replaceBlockGlobalParameter);
				array2[num2] = replaceBlockGlobalParameter;
				num2++;
			}
			this.method_1(num, array2);
			this.method_2(num, array2);
			this.method_3(num, array2);
			WaitHandle.WaitAll(array);
			bool result = true;
			for (int j = 0; j < num; j++)
			{
				if (array2[j].ProcessState == ProcessStateType.Error)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00043330 File Offset: 0x00041530
		private void method_1(int int_1, ReplaceBlockGlobalParameter[] replaceBlockGlobalParameter_0)
		{
			bool flag = false;
			while (!flag)
			{
				int num = 0;
				flag = true;
				for (int i = 0; i < int_1; i++)
				{
					if (replaceBlockGlobalParameter_0[i].ProcessState == ProcessStateType.Processing)
					{
						flag = false;
					}
					num += replaceBlockGlobalParameter_0[i].ChunkProcessedCount;
				}
				this.method_5(string.Concat(new object[]
				{
					"Processed ",
					num,
					" of ",
					this.int_0,
					" chunks"
				}), num);
				Thread.Sleep(100);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000433B8 File Offset: 0x000415B8
		private void method_2(int int_1, ReplaceBlockGlobalParameter[] replaceBlockGlobalParameter_0)
		{
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				for (int i = 0; i < int_1; i++)
				{
					if (replaceBlockGlobalParameter_0[i].ProcessState == ProcessStateType.Compressing)
					{
						flag = false;
					}
				}
				this.method_6("Compressing chunks", num);
				if (num >= 100)
				{
					num = 0;
				}
				else
				{
					num++;
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00043410 File Offset: 0x00041610
		private void method_3(int int_1, ReplaceBlockGlobalParameter[] replaceBlockGlobalParameter_0)
		{
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				for (int i = 0; i < int_1; i++)
				{
					if (replaceBlockGlobalParameter_0[i].ProcessState == ProcessStateType.Saving)
					{
						flag = false;
					}
				}
				this.method_6("Rebuilding regions", num);
				if (num >= 100)
				{
					num = 0;
				}
				else
				{
					num++;
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00043468 File Offset: 0x00041668
		private void method_4(string string_0)
		{
			int num = 0 + Constants.consoleRegionSizes[string_0];
			this.int_0 = num * 4;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00043490 File Offset: 0x00041690
		private void method_5(string string_0, int int_1)
		{
			int int_2 = (int)((float)int_1 / (float)this.int_0 * 100f);
			this.method_6(string_0, int_2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000060C4 File Offset: 0x000042C4
		private void method_6(string string_0, int int_1 = 0)
		{
			if (this.backgroundWorker != null)
			{
				this.backgroundWorker.ReportProgress(int_1, string_0);
			}
		}

		// Token: 0x04000548 RID: 1352
		private BackgroundWorker backgroundWorker;

		// Token: 0x04000549 RID: 1353
		private int int_0;
	}
}
