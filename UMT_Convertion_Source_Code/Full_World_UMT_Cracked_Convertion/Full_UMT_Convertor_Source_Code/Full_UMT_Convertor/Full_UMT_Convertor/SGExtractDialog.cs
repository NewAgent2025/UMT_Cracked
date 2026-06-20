using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.forms;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor
{
	// Token: 0x02000136 RID: 310
	public partial class SGExtractDialog : Form
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x0005970C File Offset: 0x0005790C
		public SGExtractDialog()
		{
			this.upcHajWbhnr();
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.WorkerSupportsCancellation = true;
			this.stopwatch = new Stopwatch();
			this.uiTimer = new Timer();
			this.uiTimer.Interval = 1000;
			this.uiTimer.Tick += this.UiTimer_Tick;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00008A76 File Offset: 0x00006C76
		public SGExtractDialog(string folderPath, RunTypes runType) : this()
		{
			this.folderPath = folderPath;
			this.runType = runType;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00008A8C File Offset: 0x00006C8C
		public SGExtractDialog(string folderPath, ConvertParameters convertParameters, RunTypes runType) : this()
		{
			this.folderPath = folderPath;
			this.convertParameters = convertParameters;
			this.runType = runType;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00008AA9 File Offset: 0x00006CA9
		public SGExtractDialog(string pcPath, string folderPath, ConvertParameters convertParameters, RunTypes runType) : this()
		{
			this.pcPath = pcPath;
			this.folderPath = folderPath;
			this.convertParameters = convertParameters;
			this.runType = runType;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00008ACE File Offset: 0x00006CCE
		public SGExtractDialog(string filePath, string folderPath, RunTypes runType) : this()
		{
			this.filePath = filePath;
			this.folderPath = folderPath;
			this.runType = runType;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00008AEB File Offset: 0x00006CEB
		public SGExtractDialog(string filePath, string folderPath, RunTypes runType, Dictionary<string, ModifiedFile> modifiedFiles) : this(filePath, folderPath, runType)
		{
			this.modifiedFiles = modifiedFiles;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000597C8 File Offset: 0x000579C8
		private void SGExtractDialog_Shown(object sender, EventArgs e)
		{
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
			this.stopwatch.Restart();
			this.uiTimer.Start();
			this.backgroundWorker_0.RunWorkerAsync(argument);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00059858 File Offset: 0x00057A58
		private void afjHahIymNf(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker backgroundWorker = sender as BackgroundWorker;
			backgroundWorker.WorkerReportsProgress = true;
			RunArgs runArgs = e.Argument as RunArgs;
			MCSupport mcsupport = new MCSupport(backgroundWorker);
			Class29 @class = new Class29(backgroundWorker);
			Class24 class2 = new Class24(backgroundWorker);
			if (runArgs.RunType == RunTypes.Extract)
			{
				this.method_1();
				if (Working.GameType == (Enum2)1)
				{
					mcsupport.method_29(runArgs.FilePath, runArgs.FolderPath, false);
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
					mcsupport.method_16(runArgs.FolderPath, false, false);
					return;
				}
				if (runArgs.RunType == RunTypes.Save)
				{
					mcsupport.SaveFiles(runArgs.FolderPath, runArgs.ModifiedFiles);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertToPC)
				{
					this.convertStatus_0 = mcsupport.method_33(runArgs.FolderPath, runArgs.ConvertParameters);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertFromPC)
				{
					this.convertStatus_0 = mcsupport.method_43(runArgs.PcPath, runArgs.FolderPath, runArgs.ConvertParameters);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertToConsole)
				{
					this.convertStatus_0 = mcsupport.method_8(runArgs.FolderPath, runArgs.ConvertParameters);
					return;
				}
				if (runArgs.RunType == RunTypes.ConvertToBedrock)
				{
					this.convertStatus_0 = mcsupport.method_0(runArgs.FolderPath, runArgs.ConvertParameters);
				}
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000599BC File Offset: 0x00057BBC
		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.label_0.Text = (e.UserState as string);
			this.label_0.Refresh();
			int progressPercentage = e.ProgressPercentage;
			if (progressPercentage > 0 && progressPercentage < 101)
			{
				this.progressBar_0.Value = progressPercentage;
				if (progressPercentage > 5 && this.stopwatch.ElapsedMilliseconds > 1000L)
				{
					long elapsedMilliseconds = this.stopwatch.ElapsedMilliseconds;
					TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(elapsedMilliseconds * 100L / (long)progressPercentage - elapsedMilliseconds));
					this.lblRemainingTime.Text = string.Format("Remaining Time: {0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
					double totalSeconds = this.stopwatch.Elapsed.TotalSeconds;
					if (totalSeconds > 0.0)
					{
						double num = (double)(progressPercentage * 160);
						this.lblAvgChunks.Text = string.Format("Avg. Chunks/Sec: {0:F1}", num / totalSeconds);
					}
				}
			}
			this.progressBar_0.Refresh();
			try
			{
				this.lblDimension.Text = "Dimension: " + Working.GameType.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00059B08 File Offset: 0x00057D08
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.uiTimer.Stop();
			this.stopwatch.Stop();
			base.Visible = false;
			if (this.convertStatus_0 != null)
			{
				if (this.runType != RunTypes.ConvertToBedrock)
				{
					new ConversionStatus(this.convertStatus_0).ShowDialog(this);
				}
				else
				{
					new ConversionStatusWithSave(this.convertStatus_0).ShowDialog(this);
				}
			}
			base.Close();
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00008AFE File Offset: 0x00006CFE
		private void method_0(object sender, EventArgs e)
		{
			if (this.backgroundWorker_0.WorkerSupportsCancellation)
			{
				this.backgroundWorker_0.CancelAsync();
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00008B18 File Offset: 0x00006D18
		private void SGExtractDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.backgroundWorker_0.IsBusy)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00008B2E File Offset: 0x00006D2E
		private void method_1()
		{
			Working.smethod_15(this.filePath);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00059B70 File Offset: 0x00057D70
		private void upcHajWbhnr()
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
			base.SuspendLayout();
			this.backgroundWorker_0.DoWork += this.afjHahIymNf;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
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
			this.Text = "Extract";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			base.FormClosing += this.SGExtractDialog_FormClosing;
			base.Shown += this.SGExtractDialog_Shown;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00059FB0 File Offset: 0x000581B0
		private void UiTimer_Tick(object sender, EventArgs e)
		{
			TimeSpan elapsed = this.stopwatch.Elapsed;
			this.lblElapsedTime.Text = string.Format("Elapsed Time: {0:D2}:{1:D2}", elapsed.Minutes, elapsed.Seconds);
			double num = (double)Process.GetCurrentProcess().PrivateMemorySize64 / 1048576.0;
			this.lblRamUsage.Text = string.Format("Ram Usage: {0:F1} MB", num);
			this.lblCoreCount.Text = string.Format("Core Count: {0}", Environment.ProcessorCount);
		}

		// Token: 0x04000801 RID: 2049
		private string pcPath;

		// Token: 0x04000802 RID: 2050
		private string filePath;

		// Token: 0x04000803 RID: 2051
		private string folderPath;

		// Token: 0x04000804 RID: 2052
		private RunTypes runType;

		// Token: 0x04000805 RID: 2053
		private Dictionary<string, ModifiedFile> modifiedFiles;

		// Token: 0x04000806 RID: 2054
		private ConvertParameters convertParameters;

		// Token: 0x04000807 RID: 2055
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

		// Token: 0x04000808 RID: 2056
		private ConvertStatus convertStatus_0;

		// Token: 0x0400080A RID: 2058
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x0400080B RID: 2059
		private Label label_0;

		// Token: 0x0400080C RID: 2060
		private ProgressBar progressBar_0;

		// Token: 0x0400080D RID: 2061
		private Timer uiTimer;

		// Token: 0x0400080E RID: 2062
		private Stopwatch stopwatch;

		// Token: 0x0400080F RID: 2063
		private Label lblElapsedTime;

		// Token: 0x04000810 RID: 2064
		private Label lblRemainingTime;

		// Token: 0x04000811 RID: 2065
		private Label lblRamUsage;

		// Token: 0x04000812 RID: 2066
		private Label lblDimension;

		// Token: 0x04000813 RID: 2067
		private Label lblSections;

		// Token: 0x04000814 RID: 2068
		private Label lblCoreCount;

		// Token: 0x04000815 RID: 2069
		private Label lblAvgChunks;
	}
}
