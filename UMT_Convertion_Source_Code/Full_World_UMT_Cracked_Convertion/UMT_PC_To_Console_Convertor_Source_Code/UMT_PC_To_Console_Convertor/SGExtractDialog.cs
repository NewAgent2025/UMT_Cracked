using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.MCSBCode;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor
{
	// Token: 0x020000C1 RID: 193
	public partial class SGExtractDialog : Form
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		public SGExtractDialog()
		{
			this.method_2();
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.WorkerSupportsCancellation = true;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000067D5 File Offset: 0x000049D5
		public SGExtractDialog(string folderPath, RunTypes runType) : this()
		{
			this.folderPath = folderPath;
			this.runType = runType;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000067EB File Offset: 0x000049EB
		public SGExtractDialog(string folderPath, ConvertParameters convertParameters, RunTypes runType) : this()
		{
			this.folderPath = folderPath;
			this.convertParameters = convertParameters;
			this.runType = runType;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00006808 File Offset: 0x00004A08
		public SGExtractDialog(string pcPath, string folderPath, ConvertParameters convertParameters, RunTypes runType) : this()
		{
			this.pcPath = pcPath;
			this.folderPath = folderPath;
			this.convertParameters = convertParameters;
			this.runType = runType;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0000682D File Offset: 0x00004A2D
		public SGExtractDialog(string filePath, string folderPath, RunTypes runType) : this()
		{
			this.filePath = filePath;
			this.folderPath = folderPath;
			this.runType = runType;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0000684A File Offset: 0x00004A4A
		public SGExtractDialog(string filePath, string folderPath, RunTypes runType, Dictionary<string, ModifiedFile> modifiedFiles) : this(filePath, folderPath, runType)
		{
			this.modifiedFiles = modifiedFiles;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0002FA70 File Offset: 0x0002DC70
		private void SGExtractDialog_Shown(object sender, EventArgs e)
		{
			if (this.runType != RunTypes.ConvertFromPC)
			{
				base.Opacity = 0.0;
				base.ShowInTaskbar = false;
				base.Size = new Size(0, 0);
			}
			this.Text = this.string_0[(int)this.runType];
			RunArgs argument = new RunArgs
			{
				RunType = this.runType,
				FilePath = this.filePath,
				FolderPath = this.folderPath,
				PcPath = this.pcPath,
				ConvertParameters = this.convertParameters,
				ModifiedFiles = this.modifiedFiles
			};
			this.stopwatch = Stopwatch.StartNew();
			this.uiTimer.Start();
			this.backgroundWorker_0.RunWorkerAsync(argument);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker backgroundWorker = sender as BackgroundWorker;
			backgroundWorker.WorkerReportsProgress = true;
			RunArgs runArgs = e.Argument as RunArgs;
			MCSupport mcsupport = new MCSupport(backgroundWorker);
			Class24 @class = new Class24(backgroundWorker);
			Class21 class2 = new Class21(backgroundWorker);
			if (runArgs.RunType == RunTypes.Extract)
			{
				this.method_1();
				if (Working.GameType == (Enum2)1)
				{
					mcsupport.method_21(runArgs.FilePath, runArgs.FolderPath, false);
					return;
				}
				if (Working.GameType == (Enum2)2)
				{
					@class.method_0(runArgs.FilePath, runArgs.FolderPath, false);
					return;
				}
				if (Working.GameType == (Enum2)3)
				{
					class2.method_0(runArgs.FilePath, runArgs.FolderPath, false);
					return;
				}
			}
			else
			{
				if (runArgs.RunType == RunTypes.Create)
				{
					mcsupport.method_9(runArgs.FolderPath, false);
					return;
				}
				if (runArgs.RunType == RunTypes.Save)
				{
					mcsupport.SaveFiles(runArgs.FolderPath, runArgs.ModifiedFiles);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertToPC)
				{
					this.convertStatus_0 = mcsupport.method_25(runArgs.FolderPath, runArgs.ConvertParameters);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertFromPC)
				{
					this.convertStatus_0 = mcsupport.method_36(runArgs.PcPath, runArgs.FolderPath, runArgs.ConvertParameters);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertToConsole)
				{
					this.convertStatus_0 = mcsupport.method_1(runArgs.FolderPath, runArgs.ConvertParameters);
				}
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0002FC6C File Offset: 0x0002DE6C
		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (this.runType == RunTypes.ConvertFromPC)
			{
				this.label_0.Text = (e.UserState as string);
				this.label_0.Refresh();
				if (e.ProgressPercentage > 0 && e.ProgressPercentage < 101)
				{
					this.progressBar_0.Value = e.ProgressPercentage;
					if (e.ProgressPercentage > 0 && this.stopwatch != null)
					{
						long elapsedMilliseconds = this.stopwatch.ElapsedMilliseconds;
						TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(elapsedMilliseconds * 100L / (long)e.ProgressPercentage - elapsedMilliseconds));
						this.lblRemainingTime.Text = string.Format("Remaining Time: {0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
					}
				}
				this.progressBar_0.Refresh();
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0000685D File Offset: 0x00004A5D
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.uiTimer.Stop();
			this.stopwatch.Stop();
			base.Visible = false;
			base.Close();
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00006882 File Offset: 0x00004A82
		private void method_0(object sender, EventArgs e)
		{
			if (this.backgroundWorker_0.WorkerSupportsCancellation)
			{
				this.backgroundWorker_0.CancelAsync();
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0000689C File Offset: 0x00004A9C
		private void SGExtractDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.backgroundWorker_0.IsBusy)
			{
				e.Cancel = true;
				base.Close();
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000068B8 File Offset: 0x00004AB8
		private void method_1()
		{
			Working.smethod_15(Path.GetFileName(this.filePath));
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0002FD38 File Offset: 0x0002DF38
		private void method_2()
		{
			this.backgroundWorker_0 = new BackgroundWorker();
			this.label_0 = new Label();
			this.progressBar_0 = new ProgressBar();
			this.lblElapsedTime = new Label();
			this.lblRemainingTime = new Label();
			this.lblRamUsage = new Label();
			this.lblDimension = new Label();
			this.lblSections = new Label();
			this.lblCoreCount = new Label();
			this.lblAvgChunks = new Label();
			this.uiTimer = new Timer();
			base.SuspendLayout();
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.uiTimer.Interval = 1000;
			this.uiTimer.Tick += this.UiTimer_Tick;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 45);
			this.label_0.Name = "statusLabel";
			this.label_0.Size = new Size(35, 13);
			this.label_0.Text = "Working...";
			this.progressBar_0.Location = new Point(12, 12);
			this.progressBar_0.Name = "progressBar1";
			this.progressBar_0.Size = new Size(420, 23);
			this.lblElapsedTime.Location = new Point(12, 75);
			this.lblElapsedTime.Size = new Size(130, 15);
			this.lblElapsedTime.Text = "Elapsed Time: 00:00";
			this.lblRemainingTime.Location = new Point(150, 75);
			this.lblRemainingTime.Size = new Size(140, 15);
			this.lblRemainingTime.Text = "Remaining Time: --:--";
			this.lblRamUsage.Location = new Point(300, 75);
			this.lblRamUsage.Size = new Size(130, 15);
			this.lblRamUsage.Text = "Ram Usage: 0 MB";
			this.lblDimension.Location = new Point(12, 100);
			this.lblDimension.Size = new Size(130, 15);
			this.lblDimension.Text = "Dimension: Overworld";
			this.lblSections.Location = new Point(150, 100);
			this.lblSections.Size = new Size(140, 15);
			this.lblSections.Text = "Sections: N/A";
			this.lblCoreCount.Location = new Point(300, 100);
			this.lblCoreCount.Size = new Size(130, 15);
			this.lblCoreCount.Text = "Core Count: 0";
			this.lblAvgChunks.Location = new Point(12, 125);
			this.lblAvgChunks.Size = new Size(200, 15);
			this.lblAvgChunks.Text = "Avg. Chunks/Sec: 0.0";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(446, 160);
			base.ControlBox = false;
			base.Controls.Add(this.progressBar_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.lblElapsedTime);
			base.Controls.Add(this.lblRemainingTime);
			base.Controls.Add(this.lblRamUsage);
			base.Controls.Add(this.lblDimension);
			base.Controls.Add(this.lblSections);
			base.Controls.Add(this.lblCoreCount);
			base.Controls.Add(this.lblAvgChunks);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SGExtractDialog";
			this.Text = ".";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			base.FormClosing += this.SGExtractDialog_FormClosing;
			base.Shown += this.SGExtractDialog_Shown;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000301AC File Offset: 0x0002E3AC
		private void UiTimer_Tick(object sender, EventArgs e)
		{
			if (this.runType == RunTypes.ConvertFromPC && this.stopwatch != null)
			{
				TimeSpan elapsed = this.stopwatch.Elapsed;
				this.lblElapsedTime.Text = string.Format("Elapsed Time: {0:D2}:{1:D2}", elapsed.Minutes, elapsed.Seconds);
				if (elapsed.TotalSeconds > 0.0 && !string.IsNullOrEmpty(this.label_0.Text))
				{
					Match match = Regex.Match(this.label_0.Text, "\\d+");
					long num;
					if (match.Success && long.TryParse(match.Value, out num))
					{
						double num2 = (double)num / elapsed.TotalSeconds;
						this.lblAvgChunks.Text = string.Format("Avg. Chunks/Sec: {0:F1}", num2);
					}
				}
			}
			double num3 = (double)Process.GetCurrentProcess().PrivateMemorySize64 / 1048576.0;
			if (this.runType == RunTypes.ConvertFromPC)
			{
				this.lblRamUsage.Text = string.Format("Ram Usage: {0:F1} MB", num3);
				this.lblCoreCount.Text = string.Format("Core Count: {0}", Environment.ProcessorCount);
			}
		}

		// Token: 0x0400051C RID: 1308
		private string pcPath;

		// Token: 0x0400051D RID: 1309
		private string filePath;

		// Token: 0x0400051E RID: 1310
		private string folderPath;

		// Token: 0x0400051F RID: 1311
		private RunTypes runType;

		// Token: 0x04000520 RID: 1312
		private Dictionary<string, ModifiedFile> modifiedFiles;

		// Token: 0x04000521 RID: 1313
		private ConvertParameters convertParameters;

		// Token: 0x04000522 RID: 1314
		private string[] string_0 = new string[]
		{
			"Extract",
			"Create",
			"Save",
			"Console Converting To PC",
			"Converting From PC To Console",
			"Converting Console Worlds To Console",
			"Converting Console To Bedrock",
			"Converting From Bedrock To Console"
		};

		// Token: 0x04000523 RID: 1315
		private ConvertStatus convertStatus_0;

		// Token: 0x04000525 RID: 1317
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04000526 RID: 1318
		private Label label_0;

		// Token: 0x04000527 RID: 1319
		private ProgressBar progressBar_0;

		// Token: 0x04000529 RID: 1321
		private Stopwatch stopwatch;

		// Token: 0x0400052A RID: 1322
		private Label lblElapsedTime;

		// Token: 0x0400052B RID: 1323
		private Label lblRemainingTime;

		// Token: 0x0400052C RID: 1324
		private Label lblRamUsage;

		// Token: 0x0400052D RID: 1325
		private Label lblDimension;

		// Token: 0x0400052E RID: 1326
		private Label lblSections;

		// Token: 0x0400052F RID: 1327
		private Label lblCoreCount;

		// Token: 0x04000530 RID: 1328
		private Label lblAvgChunks;
	}
}
