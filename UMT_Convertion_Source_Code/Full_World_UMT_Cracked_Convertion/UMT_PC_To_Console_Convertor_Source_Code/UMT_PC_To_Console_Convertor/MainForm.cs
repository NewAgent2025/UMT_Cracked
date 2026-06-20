using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.forms;
using UMT_PC_To_Console_Convertor.MCSBCode;
using UMT_PC_To_Console_Convertor.MCSBCode.Workers;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.Properties;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor
{
	// Token: 0x0200007E RID: 126
	public partial class MainForm : Form
	{
		// Token: 0x06000569 RID: 1385 RVA: 0x0002942C File Offset: 0x0002762C
		public MainForm(string[] args)
		{
			this.method_1();
			Class20.smethod_7();
			Class29.smethod_3();
			Class29.smethod_4();
			Class29.smethod_5();
			ItemLookups.LoadItemsById();
			Constants.smethod_0();
			this.AllowDrop = true;
			bool flag = false;
			if (args.Length != 0 && (args[0].ToLower().EndsWith("savegame.dat") || args[0].ToLower().EndsWith("gamedata")))
			{
				this.method_5(args[0]);
			}
			if (args.Length >= 5 && args[0].ToLower() == "-c")
			{
				int defaultConsoleType;
				int num;
				if (int.TryParse(args[1], out defaultConsoleType) && int.TryParse(args[3], out num))
				{
					Settings.Default.DefaultConsoleType = defaultConsoleType;
					switch (num)
					{
					case 1:
						this.method_5(args[4]);
						this.method_ConvertFromPC(args[2]);
						base.Close();
						break;
					case 2:
						this.method_5(args[4]);
						this.method_ConvertFromPC(args[2]);
						base.Close();
						break;
					case 3:
						this.method_5(args[4]);
						this.method_ConvertFromPC(args[2]);
						base.Close();
						break;
					default:
						base.Close();
						return;
					}
				}
				else if (args.Length != 0)
				{
					this.method_45((Enum2)1);
					flag = true;
				}
				if (flag)
				{
					base.HandleCreated += delegate(object sender, EventArgs e)
					{
						base.BeginInvoke(new Action(delegate()
						{
							Application.Exit();
						}));
					};
				}
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00029574 File Offset: 0x00027774
		private void method_1()
		{
			try
			{
				if (Settings.Default.UpgradeSettings)
				{
					Settings.Default.Upgrade();
					Settings.Default.UpgradeSettings = false;
					Settings.Default.FromPCBlockTranslations = "";
					Settings.Default.Save();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000509B File Offset: 0x0000329B
		private void method_2()
		{
			if (Settings.Default.DefaultConsoleType == 0)
			{
				this.fiwalixSfN(".dat", "savegame.dat Files|savegame.dat|gamedata Files|gamedata|savegame.wii Files|savegame.wii", "savegame.dat");
				return;
			}
			this.fiwalixSfN("GAMEDATA", "gamedata Files|GAMEDATA|savegame.dat Files|savegame.dat|savegame.wii Files|savegame.wii", "GAMEDATA");
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000050D4 File Offset: 0x000032D4
		private void method_3(string string_0)
		{
			if (!string.IsNullOrWhiteSpace(string_0))
			{
				if (this.method_4(string_0))
				{
					Working.DataChanged = false;
					Working.smethod_6(FileUtils.CheckFolderSep(string_0));
					new MCFileTree();
					return;
				}
				MessageBox.Show("MC working files not found.", "Invalid Folder");
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000510F File Offset: 0x0000330F
		private bool method_4(string string_0)
		{
			return Working.smethod_16(string_0);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00005117 File Offset: 0x00003317
		private void fiwalixSfN(string extension, string filter, string defaultName)
		{
			base.Close();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000295D0 File Offset: 0x000277D0
		private void method_5(string string_0)
		{
			string string_ = Working.smethod_5();
			string text = FileUtils.CheckFolderSep(Path.GetTempPath()) + "Full_UMT_Convertor\\" + Guid.NewGuid().ToString() + "\\";
			if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(text))
			{
				Cursor.Current = Cursors.WaitCursor;
				FileUtils.smethod_9(text);
				Working.smethod_8(string_0);
				Settings.Default.LastOpenFile = string_0;
				Settings.Default.Save();
				new SGExtractDialog(string_0, text, RunTypes.Extract).ShowDialog(this);
				Working.smethod_15(Path.GetFileName(string_0));
				this.method_3(text);
				this.method_6(string_, false);
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00029680 File Offset: 0x00027880
		private void method_6(string string_0, bool bool_1)
		{
			ManualResetEvent manualResetEvent = new ManualResetEvent(false);
			DeleteFolderParameter state = new DeleteFolderParameter(string_0, manualResetEvent);
			ThreadPool.QueueUserWorkItem(new WaitCallback(new DeleteWorkingFolder().DoDelete), state);
			if (bool_1)
			{
				manualResetEvent.WaitOne(0, true);
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000511F File Offset: 0x0000331F
		private void method_7(string string_0)
		{
			if (!string.IsNullOrWhiteSpace(string_0))
			{
				new SGExtractDialog("", string_0, RunTypes.Create).ShowDialog(this);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000296C0 File Offset: 0x000278C0
		private void method_45(Enum2 enum2_0)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				string string_ = "";
				string string_2 = "";
				string string_3 = "";
				if (enum2_0 == (Enum2)1)
				{
					string_ = ".dat";
					string_2 = "savegame.dat Files|savegame.dat";
					string_3 = "savegame.dat";
				}
				else if (enum2_0 == (Enum2)2)
				{
					string_ = "";
					string_2 = "gamedata Files|GAMEDATA";
					string_3 = "GAMEDATA";
				}
				else if (enum2_0 == (Enum2)3)
				{
					string_ = ".wii";
					string_2 = "savegame.wii Files|savegame.wii";
					string_3 = "savegame.wii";
				}
				string text = FileUtils.smethod_3(string_, string_2, null, string_3);
				if (!string.IsNullOrWhiteSpace(text))
				{
					ConvertParameters convertParameters = new ConvertParameters();
					convertParameters.ConvertOverworld = true;
					convertParameters.ConvertNether = true;
					convertParameters.ConvertTheEnd = true;
					convertParameters.PCWorldFolder = text;
					convertParameters.method_1(enum2_0);
					new SGExtractDialog(Working.smethod_5(), convertParameters, RunTypes.ConvertToConsole).ShowDialog(this);
					return;
				}
			}
			else
			{
				MessageBox.Show("Please open world prior to converting.", "Open World");
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0002979C File Offset: 0x0002799C
		private void method_46(ConvertParameters convertParameters_0)
		{
			if (Working.WorldVersionMajor >= 9 && Working.WorldVersionMinor >= 8)
			{
				convertParameters_0.ChunkFormat = ConsoleChunkFormat.TU17;
				if (Working.WorldVersionMinor == 8)
				{
					convertParameters_0.TU17VersionType_0 = TU17VersionType.VERSION_8;
					return;
				}
				if (Working.WorldVersionMinor == 9)
				{
					convertParameters_0.TU17VersionType_0 = TU17VersionType.VERSION_9;
					return;
				}
				if (Working.WorldVersionMinor == 10)
				{
					convertParameters_0.TU17VersionType_0 = TU17VersionType.VERSION_10;
				}
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000297F4 File Offset: 0x000279F4
		private void method_ConvertFromPC(string outputFolder)
		{
			UMT_PC_To_Console_Convertor.forms.ConvertFromPC convertFromPC = new UMT_PC_To_Console_Convertor.forms.ConvertFromPC();
			if (convertFromPC.RunAutomated(outputFolder))
			{
				ConvertParameters convertParameters = convertFromPC.ConvertParameters;
				this.method_46(convertParameters);
				new SGExtractDialog(convertParameters.PCWorldFolder, Working.smethod_5(), convertParameters, RunTypes.ConvertFromPC).ShowDialog(this);
				this.method_3(Working.smethod_5());
				return;
			}
		}
	}
}
