using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x020000BC RID: 188
	public class ReplaceBiomeGlobalWorker
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x00002591 File Offset: 0x00000791
		public ReplaceBiomeGlobalWorker()
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00006047 File Offset: 0x00004247
		public ReplaceBiomeGlobalWorker(BackgroundWorker backgroundWorker)
		{
			this.backgroundWorker = backgroundWorker;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00006056 File Offset: 0x00004256
		public void DoReplace(string dimension, List<BiomeChange> replacementBiomeList, string outFolderPath)
		{
			this.method_4(dimension);
			if (replacementBiomeList.Count == 0)
			{
				return;
			}
			if (this.Replace(dimension, replacementBiomeList, outFolderPath))
			{
				this.method_0(outFolderPath);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00042FD0 File Offset: 0x000411D0
		private void method_0(string string_0)
		{
			MCSupport mcsupport = new MCSupport(this.backgroundWorker);
			mcsupport.method_16(string_0, false, false);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00042FF4 File Offset: 0x000411F4
		public bool Replace(string dimension, List<BiomeChange> replacementBiomeList, string outFolderPath)
		{
			int num = 4;
			ManualResetEvent[] array = new ManualResetEvent[4];
			ReplaceBiomeGlobalParameter[] array2 = new ReplaceBiomeGlobalParameter[4];
			int num2 = 0;
			foreach (string region in Constants.regionFileNames)
			{
				array[num2] = new ManualResetEvent(false);
				ReplaceBiomeGlobalParameter replaceBiomeGlobalParameter = new ReplaceBiomeGlobalParameter(dimension, region, replacementBiomeList, outFolderPath, array[num2]);
				ReplaceBiomesGlobal @object = new ReplaceBiomesGlobal();
				ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Replace), replaceBiomeGlobalParameter);
				array2[num2] = replaceBiomeGlobalParameter;
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

		// Token: 0x060007DE RID: 2014 RVA: 0x000430BC File Offset: 0x000412BC
		private void method_1(int int_1, ReplaceBiomeGlobalParameter[] replaceBiomeGlobalParameter_0)
		{
			bool flag = false;
			while (!flag)
			{
				int num = 0;
				flag = true;
				for (int i = 0; i < int_1; i++)
				{
					if (replaceBiomeGlobalParameter_0[i].ProcessState == ProcessStateType.Processing)
					{
						flag = false;
					}
					num += replaceBiomeGlobalParameter_0[i].ChunkProcessedCount;
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

		// Token: 0x060007DF RID: 2015 RVA: 0x00043144 File Offset: 0x00041344
		private void method_2(int int_1, ReplaceBiomeGlobalParameter[] replaceBiomeGlobalParameter_0)
		{
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				for (int i = 0; i < int_1; i++)
				{
					if (replaceBiomeGlobalParameter_0[i].ProcessState == ProcessStateType.Compressing)
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

		// Token: 0x060007E0 RID: 2016 RVA: 0x0004319C File Offset: 0x0004139C
		private void method_3(int int_1, ReplaceBiomeGlobalParameter[] replaceBiomeGlobalParameter_0)
		{
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				flag = true;
				for (int i = 0; i < int_1; i++)
				{
					if (replaceBiomeGlobalParameter_0[i].ProcessState == ProcessStateType.Saving)
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

		// Token: 0x060007E1 RID: 2017 RVA: 0x000431F4 File Offset: 0x000413F4
		private void method_4(string string_0)
		{
			int num = 0 + Constants.consoleRegionSizes[string_0];
			this.int_0 = num * 4;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0004321C File Offset: 0x0004141C
		private void method_5(string string_0, int int_1)
		{
			int int_2 = (int)((float)int_1 / (float)this.int_0 * 100f);
			this.method_6(string_0, int_2);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000607A File Offset: 0x0000427A
		private void method_6(string string_0, int int_1 = 0)
		{
			if (this.backgroundWorker != null)
			{
				this.backgroundWorker.ReportProgress(int_1, string_0);
			}
		}

		// Token: 0x04000546 RID: 1350
		private BackgroundWorker backgroundWorker;

		// Token: 0x04000547 RID: 1351
		private int int_0;
	}
}
