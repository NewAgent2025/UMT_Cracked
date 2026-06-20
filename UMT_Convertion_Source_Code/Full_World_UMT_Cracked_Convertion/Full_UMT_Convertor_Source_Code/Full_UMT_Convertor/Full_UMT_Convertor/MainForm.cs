using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Full_UMT_Convertor.forms;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.MCSBCode.Workers;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.Properties;
using Full_UMT_Convertor.utils;
using Full_UMT_Convertor.workers;
using NAppUpdate.Framework;
using NAppUpdate.Framework.Common;
using NBTExplorer.Model;
using NBTModel.Interop;
using Save_Manager;
using Substrate.Nbt;

namespace Full_UMT_Convertor
{
	// Token: 0x020000BE RID: 190
	public partial class MainForm : Form
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x000434B8 File Offset: 0x000416B8
		public MainForm(string[] args)
		{
			this.mcnbttreeSupport_0 = new MCNBTTreeSupport();
			this.dictionary_0 = new Dictionary<string, ModifiedFile>();
			this.method_79();
			this.method_44();
			this.method_1();
			BlockMaster.InitBlockManager();
			Class23.smethod_8();
			Class34.smethod_3();
			Class34.smethod_4();
			Class34.smethod_5();
			ConsoleItemLookups.LoadItemsById();
			Constants.smethod_0();
			this.AllowDrop = true;
			bool flag = false;
			if (args.Length != 0 && (args[0].ToLower().EndsWith("savegame.dat") || args[0].ToLower().EndsWith("gamedata")))
			{
				this.method_6(args[0]);
				return;
			}
			if (args.Length >= 3 && args[0].ToLower() == "-o")
			{
				int defaultConsoleType;
				if (int.TryParse(args[1], out defaultConsoleType))
				{
					Settings.Default.DefaultConsoleType = defaultConsoleType;
					this.method_6(args[2]);
					return;
				}
			}
			else if (args.Length >= 5 && args[0].ToLower() == "-c")
			{
				int defaultConsoleType2;
				int num;
				if (int.TryParse(args[1], out defaultConsoleType2) && int.TryParse(args[3], out num))
				{
					Settings.Default.DefaultConsoleType = defaultConsoleType2;
					this.method_6(args[2]);
					this.commandLineOutputFile = args[4];
					switch (num)
					{
					case 1:
						this.method_48((Enum2)1);
						base.Close();
						break;
					case 2:
						this.method_48((Enum2)2);
						base.Close();
						break;
					case 3:
						this.method_48((Enum2)3);
						base.Close();
						break;
					case 4:
						if (args.Length < 5)
						{
							base.Close();
							return;
						}
						this.method_ConvertToPC(args[4]);
						base.Close();
						break;
					case 5:
						this.method_ConvertToBedrock();
						base.Close();
						break;
					default:
						base.Close();
						return;
					}
				}
				else if (args.Length != 0)
				{
					this.method_6(args[0]);
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

		// Token: 0x060007F0 RID: 2032 RVA: 0x000060DB File Offset: 0x000042DB
		private void MainForm_Load(object sender, EventArgs e)
		{
			base.Close();
			this.method_71();
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00043690 File Offset: 0x00041890
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

		// Token: 0x060007F2 RID: 2034 RVA: 0x000436EC File Offset: 0x000418EC
		private void method_2()
		{
			if (Settings.Default.DefaultConsoleType == 0)
			{
				this.method_5(".dat", "savegame.dat Files|savegame.dat|gamedata Files|gamedata|savegame.wii Files|savegame.wii|Xbox 360 bin Files|*.bin", "savegame.dat");
				return;
			}
			if (Settings.Default.DefaultConsoleType == 1)
			{
				this.method_5("GAMEDATA", "gamedata Files|GAMEDATA|savegame.dat Files|savegame.dat|savegame.wii Files|savegame.wii|Xbox 360 bin Files|*.bin", "GAMEDATA");
				return;
			}
			if (Settings.Default.DefaultConsoleType == 2)
			{
				this.method_5(".wii", "savegame.wii Files|savegame.wii|savegame.dat Files|savegame.dat|gamedata Files|gamedata|Xbox 360 bin Files|*.bin", "savegame.wii");
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00043760 File Offset: 0x00041960
		private void method_3(string string_0)
		{
			if (!string.IsNullOrWhiteSpace(string_0))
			{
				if (this.method_4(string_0))
				{
					Working.DataChanged = false;
					this.toolStripComboBox_0.Items.Clear();
					this.dictionary_0.Clear();
					this.listView_0.Items.Clear();
					this.toolStripStatusLabel_0.Text = "  " + Working.smethod_7();
					this.toolStripStatusLabel_1.Text = "";
					this.toolStripMenuItem_37.PerformClick();
					this.chunkLookup_0 = new ChunkLookup();
					Working.smethod_6(FileUtils.CheckFolderSep(string_0));
					new MCFileTree().DisplaySGFiles(string_0, this.treeView_0, this.chunkLookup_0, this.toolStripStatusLabel_2);
					Working.smethod_20(new Dictionary<string, Dictionary<string, List<EntitySearchResult>>>());
					this.OnReloadMap(this, null);
					return;
				}
				MessageBox.Show("MC working files not found.", "Invalid Folder");
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000060E9 File Offset: 0x000042E9
		private bool method_4(string string_0)
		{
			return Working.smethod_18(string_0);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00043840 File Offset: 0x00041A40
		private void method_5(string string_0, string string_1, string string_2)
		{
			string text = FileUtils.smethod_1(string_0, string_1, Settings.Default.LastOpenFile, string_2);
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.method_6(text);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00043870 File Offset: 0x00041A70
		private void method_6(string string_0)
		{
			string text = null;
			string string_ = Working.smethod_5();
			text = FileUtils.CheckFolderSep(Path.GetTempPath()) + "Full_UMT_Convertor\\" + Guid.NewGuid().ToString() + "\\";
			if (string_0.ToLower().EndsWith(".bin"))
			{
				try
				{
					string_0 = this.method_7(string_0, text);
				}
				catch (Exception)
				{
					MessageBox.Show("An error occurred while extracting savegame.dat file from bin file!" + Environment.NewLine + "Opening the Xbox 360 world has been cancelled because of error.", "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
			if (!string.IsNullOrWhiteSpace(string_0) && !string.IsNullOrWhiteSpace(text))
			{
				Cursor.Current = Cursors.WaitCursor;
				FileUtils.smethod_9(text);
				Working.smethod_8(string_0);
				this.toolStripStatusLabel_0.Text = "  " + Working.smethod_7();
				Settings.Default.LastOpenFile = string_0;
				Settings.Default.Save();
				new SGExtractDialog(string_0, text, RunTypes.Extract)
				{
					WindowState = FormWindowState.Minimized,
					ShowInTaskbar = false,
					Opacity = 0.0
				}.ShowDialog(this);
				Working.smethod_15(string_0);
				this.method_3(text);
				this.method_8(string_, false);
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000439B0 File Offset: 0x00041BB0
		private string method_7(string string_0, string string_1)
		{
			XboxPackageWorker xboxPackageWorker = new XboxPackageWorker();
			string text = Path.Combine(string_1, "extract");
			Directory.CreateDirectory(text);
			string fileName = Path.GetFileName(string_0);
			string text2 = Path.Combine(text, fileName);
			File.Copy(string_0, text2);
			text = Path.Combine(text, "savegame.dat");
			xboxPackageWorker.DoExportFile(text2, text);
			return text;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00043A00 File Offset: 0x00041C00
		private void method_8(string string_0, bool bool_1)
		{
			ManualResetEvent manualResetEvent = new ManualResetEvent(false);
			DeleteFolderParameter state = new DeleteFolderParameter(string_0, manualResetEvent);
			ThreadPool.QueueUserWorkItem(new WaitCallback(new DeleteWorkingFolder().DoDelete), state);
			if (bool_1)
			{
				manualResetEvent.WaitOne(0, true);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000060F1 File Offset: 0x000042F1
		private void MdnHloMfTeA(string string_0)
		{
			if (!string.IsNullOrWhiteSpace(string_0))
			{
				new SGExtractDialog("", string_0, RunTypes.Create).ShowDialog(this);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00026D6C File Offset: 0x00024F6C
		private string method_13(int int_0)
		{
			int num = int_0 * 16;
			int num2 = (int_0 + 1) * 16 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00043A40 File Offset: 0x00041C40
		private void method_19(params ToolStripButton[] buttons)
		{
			for (int i = 0; i < buttons.Length; i++)
			{
				buttons[i].Enabled = false;
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00043A40 File Offset: 0x00041C40
		private void method_20(params ToolStripMenuItem[] buttons)
		{
			for (int i = 0; i < buttons.Length; i++)
			{
				buttons[i].Enabled = false;
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00043A64 File Offset: 0x00041C64
		private void method_21(DataNode dataNode_0)
		{
			if (dataNode_0 == null)
			{
				return;
			}
			this.toolStripMenuItem_16.Enabled = this.toolStripButton_2.Enabled;
			this.toolStripMenuItem_9.Enabled = (dataNode_0.CanCopyNode && NbtClipboardController.IsInitialized);
			this.toolStripMenuItem_8.Enabled = (dataNode_0.CanCutNode && NbtClipboardController.IsInitialized);
			this.toolStripMenuItem_13.Enabled = dataNode_0.CanDeleteNode;
			this.toolStripMenuItem_12.Enabled = dataNode_0.CanEditNode;
			this.toolStripMenuItem_10.Enabled = (dataNode_0.CanPasteIntoNode && NbtClipboardController.IsInitialized);
			this.toolStripMenuItem_11.Enabled = dataNode_0.CanRenameNode;
			this.toolStripMenuItem_14.Enabled = dataNode_0.CanMoveNodeUp;
			this.toolStripMenuItem_15.Enabled = dataNode_0.CanMoveNodeDown;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00043B34 File Offset: 0x00041D34
		private bool method_23()
		{
			bool result = false;
			foreach (string key in this.dictionary_0.Keys)
			{
				if (this.dictionary_0[key].FileState != FileStateType.PINNED)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0000610E File Offset: 0x0000430E
		private void splitContainer_0_SplitterMoved(object sender, SplitterEventArgs e)
		{
			this.method_44();
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00043BA0 File Offset: 0x00041DA0
		private void method_44()
		{
			int width = this.splitContainer_0.Panel1.Width;
			this.toolStripStatusLabel_0.Width = width - 20;
			this.toolStripStatusLabel_1.Width = this.statusStrip_0.Width - (width + this.toolStripStatusLabel_2.Width + 20);
			width = this.toolStrip_0.Width;
			this.toolStripComboBox_0.Width = width - 145;
			this.toolStrip_0.Width = width - 1;
			this.toolStrip_0.Width = width;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00043C2C File Offset: 0x00041E2C
		private void method_45()
		{
			MCFindBlock mcfindBlock = new MCFindBlock(this.chunkLookup_0);
			if (mcfindBlock.ShowDialog(this) == DialogResult.OK)
			{
				TreeNode result = mcfindBlock.Result;
				if (result != null)
				{
					this.toolStripMenuItem_37.PerformClick();
					this.treeView_0.SelectedNode = result;
				}
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00043C70 File Offset: 0x00041E70
		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			ModifiedFile modifiedFile = this.toolStripComboBox_0.SelectedItem as ModifiedFile;
			if (modifiedFile != null)
			{
				this.treeView_0.SelectedNode = modifiedFile.Treenode;
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00043CA4 File Offset: 0x00041EA4
		private void toolStripMenuItem_21_DropDownOpening(object sender, EventArgs e)
		{
			this.toolStripMenuItem_53.Visible = (Working.GameType != (Enum2)2);
			this.toolStripMenuItem_54.Visible = (Working.GameType != (Enum2)3);
			this.toolStripMenuItem_55.Visible = (Working.GameType != (Enum2)1);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00043CF4 File Offset: 0x00041EF4
		private void toolStripMenuItem_22_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				Full_UMT_Convertor.forms.ConvertToPC convertToPC = new Full_UMT_Convertor.forms.ConvertToPC();
				if (convertToPC.ShowDialog(this) == DialogResult.OK)
				{
					ConvertParameters convertParameters = convertToPC.ConvertParameters;
					new SGExtractDialog(Working.smethod_5(), convertParameters, RunTypes.ConvertToPC).ShowDialog(this);
					return;
				}
			}
			else
			{
				MessageBox.Show("Please open world prior to converting.", "Open World");
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00043D48 File Offset: 0x00041F48
		private void toolStripMenuItem_23_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				Full_UMT_Convertor.forms.ConvertFromPC convertFromPC = new Full_UMT_Convertor.forms.ConvertFromPC();
				if (convertFromPC.ShowDialog(this) == DialogResult.OK)
				{
					ConvertParameters convertParameters = convertFromPC.ConvertParameters;
					this.method_49(convertParameters);
					new SGExtractDialog(convertParameters.ProcessWorldFolder, Working.smethod_5(), convertParameters, RunTypes.ConvertFromPC).ShowDialog(this);
					this.method_3(Working.smethod_5());
					return;
				}
			}
			else
			{
				MessageBox.Show("Please open world prior to converting.", "Open World");
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00043DB4 File Offset: 0x00041FB4
		private void toolStripMenuItem_59_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				ConvertToBedrockUI convertToBedrockUI = new ConvertToBedrockUI();
				if (convertToBedrockUI.ShowDialog(this) == DialogResult.OK)
				{
					Telemetry.MissingConsoleBlocks.Clear();
					ConvertParameters convertParameters = convertToBedrockUI.ConvertParameters;
					this.method_49(convertParameters);
					new SGExtractDialog(convertParameters.ProcessWorldFolder, Working.smethod_5(), convertParameters, RunTypes.ConvertToBedrock).ShowDialog(this);
					return;
				}
			}
			else
			{
				MessageBox.Show("Please open world prior to converting.", "Open World");
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00043E20 File Offset: 0x00042020
		private void method_48(Enum2 enum2_0)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				string text;
				if (!string.IsNullOrWhiteSpace(this.commandLineOutputFile))
				{
					text = this.commandLineOutputFile;
				}
				else
				{
					string string_ = "";
					string string_2 = "";
					string string_3 = "";
					if (enum2_0 == (Enum2)1)
					{
						string_ = ".dat";
						string_2 = ".dat Files|.dat";
						string_3 = ".dat";
					}
					else if (enum2_0 == (Enum2)2)
					{
						string_ = "";
						string_2 = "PS3 Files|GAMEDATA";
						string_3 = "GAMEDATA";
					}
					else if (enum2_0 == (Enum2)3)
					{
						string_ = ".wii";
						string_2 = ".wii Files|.wii";
						string_3 = ".wii";
					}
					text = FileUtils.smethod_3(string_, string_2, null, string_3);
				}
				if (!string.IsNullOrWhiteSpace(text))
				{
					ConvertParameters convertParameters = new ConvertParameters();
					convertParameters.ConvertOverworld = true;
					convertParameters.ConvertNether = true;
					convertParameters.ConvertTheEnd = true;
					convertParameters.ProcessWorldFolder = text;
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

		// Token: 0x06000809 RID: 2057 RVA: 0x00043F10 File Offset: 0x00042110
		private void method_49(ConvertParameters convertParameters_0)
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
					return;
				}
				if (Working.WorldVersionMinor == 11)
				{
					convertParameters_0.TU17VersionType_0 = TU17VersionType.VERSION_11;
				}
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00006116 File Offset: 0x00004316
		private void method_50(string string_0)
		{
			MessageBox.Show(string_0, "Roadmap");
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00043F7C File Offset: 0x0004217C
		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			TreeNode selectedNode = this.treeView_0.SelectedNode;
			bool flag = false;
			this.toolStripMenuItem_30.Visible = false;
			this.toolStripMenuItem_40.Visible = false;
			this.toolStripMenuItem_36.Visible = false;
			this.toolStripMenuItem_49.Visible = false;
			this.toolStripSeparator_10.Visible = false;
			if (selectedNode == null || !(selectedNode.Tag is RegionWorkingData))
			{
				if (selectedNode != null && selectedNode.Tag != null)
				{
					this.toolStripSeparator_10.Visible = ((selectedNode.Tag is IndexEntry && ((IndexEntry)selectedNode.Tag).ParentName == "players") || selectedNode.Tag is ChunkData);
					if (selectedNode.Tag is ChunkData)
					{
						this.toolStripMenuItem_30.Visible = true;
						flag = true;
					}
					if (selectedNode.Tag is IndexEntry && ((IndexEntry)selectedNode.Tag).ParentName == "players")
					{
						this.toolStripMenuItem_40.Visible = true;
						flag = true;
					}
					if ((selectedNode.Tag is IndexEntry && (((IndexEntry)selectedNode.Tag).ParentName == "players" || ((IndexEntry)selectedNode.Tag).FileName.ToLower() == "requiredgamerules.grf")) || selectedNode.Tag is ChunkData)
					{
						this.toolStripMenuItem_36.Visible = true;
						flag = true;
					}
					if (selectedNode.Tag is string && (string)selectedNode.Tag == "players")
					{
						this.toolStripMenuItem_49.Visible = true;
						flag = true;
					}
					this.toolStripSeparator_10.Visible = true;
				}
			}
			else
			{
				this.toolStripMenuItem_49.Visible = true;
				flag = true;
			}
			e.Cancel = !flag;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0004414C File Offset: 0x0004234C
		private byte[] method_60(TreeNode treeNode_1)
		{
			foreach (object obj in treeNode_1.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				if (treeNode.Text.StartsWith("Data:"))
				{
					return ((TagNodeByteArray)((TagByteArrayDataNode)treeNode.Tag).Tag).Data;
				}
			}
			return null;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000441D0 File Offset: 0x000423D0
		private bool nyvHcfrvHtr()
		{
			bool result = true;
			if (string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				MessageBox.Show("Please open world .", "Open World");
				result = false;
			}
			return result;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00006124 File Offset: 0x00004324
		private void toolStripMenuItem_38_Click(object sender, EventArgs e)
		{
			this.treeView_0.Visible = false;
			this.listView_0.Visible = true;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000613E File Offset: 0x0000433E
		private void toolStripMenuItem_37_Click(object sender, EventArgs e)
		{
			this.listView_0.Visible = false;
			this.treeView_0.Visible = true;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00006158 File Offset: 0x00004358
		private void method_64(string string_0, Dictionary<string, List<EntitySearchResult>> dictionary_1)
		{
			if (Working.smethod_19() == null)
			{
				Working.smethod_20(new Dictionary<string, Dictionary<string, List<EntitySearchResult>>>());
			}
			Working.smethod_19()[string_0] = dictionary_1;
			this.OnReDrawMap(this, null);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00044200 File Offset: 0x00042400
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				base.Visible = false;
				try
				{
					Directory.Delete(Working.smethod_5(), true);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0000617F File Offset: 0x0000437F
		private void toolStripStatusLabel_3_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				Process.Start(Working.smethod_5());
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00006198 File Offset: 0x00004398
		private void toolStripMenuItem_41_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Working.smethod_5()))
			{
				this.method_68();
				return;
			}
			MessageBox.Show("Please open world prior to GRF file.", "Open World");
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00044240 File Offset: 0x00042440
		private void method_68()
		{
			MCFileTree mcfileTree = new MCFileTree();
			string text = FileUtils.smethod_1(".grf", "*.grf Files (*.grf)|*.grf", null, "");
			if (!string.IsNullOrWhiteSpace(text))
			{
				string folderPath = Working.smethod_5() + Working.smethod_1();
				IndexEntry indexEntry = new IndexEntry(Constants.grfIndexEntry);
				FileStateType fileState = FileStateType.ADDED;
				TreeNode treeNode = mcfileTree.CheckFileExists(indexEntry, this.treeView_0);
				if (treeNode == null)
				{
					treeNode = mcfileTree.DisplayFileItem(indexEntry, folderPath, this.treeView_0);
				}
				else
				{
					indexEntry = (treeNode.Tag as IndexEntry);
					fileState = FileStateType.MODIFIED;
				}
				ModifiedFile modifiedFile = new ModifiedFile();
				modifiedFile.Tag = indexEntry;
				modifiedFile.Treenode = treeNode;
				modifiedFile.FileState = fileState;
				string destFileName = Working.smethod_5() + Working.smethod_4() + "requiredGameRules.grf";
				if (!this.dictionary_0.ContainsKey(indexEntry.FileName))
				{
					this.dictionary_0.Add(indexEntry.FileName, modifiedFile);
				}
				File.Copy(text, destFileName, true);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000061BD File Offset: 0x000043BD
		private void toolStripMenuItem_57_Click(object sender, EventArgs e)
		{
			this.method_69();
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00044330 File Offset: 0x00042530
		private void method_69()
		{
			MCFileTree mcfileTree = new MCFileTree();
			string text = FileUtils.smethod_1(".*", "*.* Files (*.*)|*.*", null, "");
			if (!string.IsNullOrWhiteSpace(text))
			{
				string folderPath = Working.smethod_5() + Working.smethod_1();
				string s = "data/loot_tables/minecraft/entities/zombie.json";
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				byte[] array = new byte[Constants.grfIndexEntry.Length];
				Constants.grfIndexEntry.CopyTo(array, 0);
				int num = 0;
				for (int i = 0; i < bytes.Length; i++)
				{
					array[num++] = 0;
					array[num++] = bytes[i];
				}
				IndexEntry indexEntry = new IndexEntry(array);
				FileStateType fileState = FileStateType.ADDED;
				TreeNode treeNode = mcfileTree.CheckFileExists(indexEntry, this.treeView_0);
				if (treeNode == null)
				{
					treeNode = mcfileTree.DisplayFileItem(indexEntry, folderPath, this.treeView_0);
				}
				else
				{
					indexEntry = (treeNode.Tag as IndexEntry);
					fileState = FileStateType.MODIFIED;
				}
				ModifiedFile modifiedFile = new ModifiedFile();
				modifiedFile.Tag = indexEntry;
				modifiedFile.Treenode = treeNode;
				modifiedFile.FileState = fileState;
				string text2 = Working.smethod_5() + Working.smethod_4() + indexEntry.FilePath;
				this.dictionary_0.Add(indexEntry.FileName, modifiedFile);
				Directory.CreateDirectory(Path.GetDirectoryName(text2));
				File.Copy(text, text2, true);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0004447C File Offset: 0x0004267C
		private void method_71()
		{
			Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
			UpdateManager updateManager = UpdateManager.Instance;
			updateManager.BeginCheckForUpdates(delegate(IAsyncResult asyncResult)
			{
				Action action = new Action(this.method_72);
				if (asyncResult.IsCompleted)
				{
					try
					{
						((UpdateProcessAsyncResult)asyncResult).EndInvoke();
					}
					catch (Exception)
					{
						return;
					}
					if (updateManager.UpdatesAvailable != 0)
					{
						this.bool_0 = true;
						action();
						return;
					}
					return;
				}
			}, null);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void method_72()
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000444CC File Offset: 0x000426CC
		protected void UpdateNow()
		{
			UpdateManager updateManager = UpdateManager.Instance;
			updateManager.BeginPrepareUpdates(delegate(IAsyncResult asyncResult)
			{
				try
				{
					((UpdateProcessAsyncResult)asyncResult).EndInvoke();
				}
				catch (Exception)
				{
					MessageBox.Show("Error downloading updates.");
					return;
				}
				try
				{
					updateManager.ApplyUpdates(true);
					this.bool_0 = false;
				}
				catch
				{
					MessageBox.Show("Could not install updates.");
				}
				updateManager.CleanUp();
			}, null);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000061C5 File Offset: 0x000043C5
		private void toolStripMenuItem_53_Click(object sender, EventArgs e)
		{
			this.method_48((Enum2)2);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000061CE File Offset: 0x000043CE
		private void toolStripMenuItem_54_Click(object sender, EventArgs e)
		{
			this.method_48((Enum2)3);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000061D7 File Offset: 0x000043D7
		private void toolStripMenuItem_55_Click(object sender, EventArgs e)
		{
			this.method_48((Enum2)1);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000061E0 File Offset: 0x000043E0
		private void toolStripMenuItem_20_DropDownOpening(object sender, EventArgs e)
		{
			this.toolStripSeparator_11.Visible = true;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600081E RID: 2078 RVA: 0x0004450C File Offset: 0x0004270C
		// (remove) Token: 0x0600081F RID: 2079 RVA: 0x00044548 File Offset: 0x00042748
		public event EventHandler ChunkSelected
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000820 RID: 2080 RVA: 0x00044584 File Offset: 0x00042784
		// (remove) Token: 0x06000821 RID: 2081 RVA: 0x000445C0 File Offset: 0x000427C0
		public event EventHandler ReloadMap
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000445FC File Offset: 0x000427FC
		protected virtual void OnReloadMap(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000823 RID: 2083 RVA: 0x0004461C File Offset: 0x0004281C
		// (remove) Token: 0x06000824 RID: 2084 RVA: 0x00044658 File Offset: 0x00042858
		public event EventHandler ReDrawMap
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00044694 File Offset: 0x00042894
		protected virtual void OnReDrawMap(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_2;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000446B4 File Offset: 0x000428B4
		private void toolStripMenuItem_58_Click(object sender, EventArgs e)
		{
			SaveManager saveManager = new SaveManager();
			if (saveManager.ShowDialog(this) == DialogResult.OK)
			{
				string path = saveManager.SaveSelected.Path;
				this.method_6(path);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000446E4 File Offset: 0x000428E4
		private void method_79()
		{
			this.icontainer_0 = new Container();
			new ComponentResourceManager(typeof(MainForm));
			this.menuStrip_0 = new MenuStrip();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_16 = new ToolStripMenuItem();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_27 = new ToolStripMenuItem();
			this.toolStripSeparator_7 = new ToolStripSeparator();
			this.toolStripMenuItem_28 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_58 = new ToolStripMenuItem();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripMenuItem_10 = new ToolStripMenuItem();
			this.toolStripSeparator_3 = new ToolStripSeparator();
			this.toolStripMenuItem_11 = new ToolStripMenuItem();
			this.toolStripMenuItem_12 = new ToolStripMenuItem();
			this.toolStripMenuItem_13 = new ToolStripMenuItem();
			this.toolStripSeparator_4 = new ToolStripSeparator();
			this.toolStripMenuItem_14 = new ToolStripMenuItem();
			this.toolStripMenuItem_15 = new ToolStripMenuItem();
			this.toolStripMenuItem_20 = new ToolStripMenuItem();
			this.toolStripMenuItem_21 = new ToolStripMenuItem();
			this.toolStripMenuItem_22 = new ToolStripMenuItem();
			this.toolStripMenuItem_23 = new ToolStripMenuItem();
			this.toolStripSeparator_13 = new ToolStripSeparator();
			this.toolStripMenuItem_59 = new ToolStripMenuItem();
			this.toolStripSeparator_12 = new ToolStripSeparator();
			this.toolStripMenuItem_53 = new ToolStripMenuItem();
			this.toolStripMenuItem_54 = new ToolStripMenuItem();
			this.toolStripMenuItem_55 = new ToolStripMenuItem();
			this.toolStripMenuItem_24 = new ToolStripMenuItem();
			this.toolStripMenuItem_32 = new ToolStripMenuItem();
			this.toolStripMenuItem_33 = new ToolStripMenuItem();
			this.toolStripMenuItem_34 = new ToolStripMenuItem();
			this.toolStripMenuItem_35 = new ToolStripMenuItem();
			this.toolStripMenuItem_56 = new ToolStripMenuItem();
			this.toolStripMenuItem_41 = new ToolStripMenuItem();
			this.toolStripMenuItem_25 = new ToolStripMenuItem();
			this.toolStripSeparator_11 = new ToolStripSeparator();
			this.toolStripMenuItem_52 = new ToolStripMenuItem();
			this.toolStripSeparator_5 = new ToolStripSeparator();
			this.toolStripMenuItem_26 = new ToolStripMenuItem();
			this.toolStripMenuItem_57 = new ToolStripMenuItem();
			this.toolStripMenuItem_42 = new ToolStripMenuItem();
			this.toolStripMenuItem_43 = new ToolStripMenuItem();
			this.toolStripMenuItem_44 = new ToolStripMenuItem();
			this.toolStripMenuItem_45 = new ToolStripMenuItem();
			this.toolStripMenuItem_46 = new ToolStripMenuItem();
			this.toolStripMenuItem_47 = new ToolStripMenuItem();
			this.toolStripMenuItem_48 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripMenuItem_17 = new ToolStripMenuItem();
			this.toolStripMenuItem_18 = new ToolStripMenuItem();
			this.toolStripMenuItem_19 = new ToolStripMenuItem();
			this.toolStripMenuItem_39 = new ToolStripMenuItem();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripMenuItem_29 = new ToolStripMenuItem();
			this.toolStripSeparator_6 = new ToolStripSeparator();
			this.toolStripMenuItem_31 = new ToolStripMenuItem();
			this.toolStripSeparator_8 = new ToolStripSeparator();
			this.treeView_0 = new TreeView();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_40 = new ToolStripMenuItem();
			this.toolStripMenuItem_30 = new ToolStripMenuItem();
			this.toolStripSeparator_10 = new ToolStripSeparator();
			this.toolStripMenuItem_36 = new ToolStripMenuItem();
			this.toolStripMenuItem_49 = new ToolStripMenuItem();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.splitContainer_0 = new SplitContainer();
			this.panel_0 = new Panel();
			this.listView_0 = new ListView();
			this.columnHeader_0 = new ColumnHeader();
			this.columnHeader_1 = new ColumnHeader();
			this.columnHeader_2 = new ColumnHeader();
			this.columnHeader_3 = new ColumnHeader();
			this.columnHeader_4 = new ColumnHeader();
			this.columnHeader_5 = new ColumnHeader();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
			this.toolStripMenuItem_37 = new ToolStripMenuItem();
			this.toolStripMenuItem_38 = new ToolStripMenuItem();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripSeparator_9 = new ToolStripSeparator();
			this.toolStripComboBox_0 = new ToolStripComboBox();
			this.statusStrip_0 = new StatusStrip();
			this.toolStripStatusLabel_0 = new ToolStripStatusLabel();
			this.toolStripStatusLabel_3 = new ToolStripStatusLabel();
			this.toolStripStatusLabel_1 = new ToolStripStatusLabel();
			this.toolStripStatusLabel_2 = new ToolStripStatusLabel();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			this.menuStrip_0.SuspendLayout();
			this.contextMenuStrip_0.SuspendLayout();
			((ISupportInitialize)this.splitContainer_0).BeginInit();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			this.statusStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_7,
				this.toolStripMenuItem_20,
				this.toolStripMenuItem_42,
				this.toolStripMenuItem_45,
				this.toolStripMenuItem_4
			});
			this.menuStrip_0.Location = new Point(0, 0);
			this.menuStrip_0.Name = "menuStrip1";
			this.menuStrip_0.Size = new Size(827, 24);
			this.menuStrip_0.TabIndex = 0;
			this.menuStrip_0.Text = "menuStrip1";
			this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripSeparator_1,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2,
				this.toolStripMenuItem_58
			});
			this.toolStripSeparator_1.Name = "sepFileMenu";
			this.toolStripSeparator_1.Size = new Size(143, 6);
			this.toolStripMenuItem_1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_27,
				this.toolStripSeparator_7,
				this.toolStripMenuItem_28
			});
			this.toolStripMenuItem_58.Name = "mnuSaveManager";
			this.toolStripMenuItem_58.Size = new Size(146, 22);
			this.toolStripMenuItem_58.Text = "Save Explorer";
			this.toolStripMenuItem_58.Click += this.toolStripMenuItem_58_Click;
			this.toolStripMenuItem_7.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_8,
				this.toolStripMenuItem_9,
				this.toolStripMenuItem_10,
				this.toolStripSeparator_3,
				this.toolStripMenuItem_11,
				this.toolStripMenuItem_12,
				this.toolStripMenuItem_13,
				this.toolStripSeparator_4,
				this.toolStripMenuItem_14,
				this.toolStripMenuItem_15
			});
			this.toolStripMenuItem_7.Name = "editToolStripMenuItem";
			this.toolStripMenuItem_7.ShortcutKeys = (Keys.RButton | Keys.MButton | Keys.Space | Keys.Control);
			this.toolStripMenuItem_7.Size = new Size(39, 20);
			this.toolStripMenuItem_7.Text = "Edit";
			this.toolStripMenuItem_8.Name = "_menuItemCut";
			this.toolStripMenuItem_8.ShortcutKeys = (Keys)131160;
			this.toolStripMenuItem_8.Size = new Size(203, 22);
			this.toolStripMenuItem_8.Text = "Cu&t";
			this.toolStripMenuItem_9.Name = "_menuItemCopy";
			this.toolStripMenuItem_9.ShortcutKeys = (Keys)131139;
			this.toolStripMenuItem_9.Size = new Size(203, 22);
			this.toolStripMenuItem_9.Text = "&Copy";
			this.toolStripMenuItem_10.Name = "_menuItemPaste";
			this.toolStripMenuItem_10.ShortcutKeys = (Keys)131158;
			this.toolStripMenuItem_10.Size = new Size(203, 22);
			this.toolStripMenuItem_10.Text = "&Paste";
			this.toolStripSeparator_3.Name = "toolStripSeparator7";
			this.toolStripSeparator_3.Size = new Size(200, 6);
			this.toolStripMenuItem_11.Name = "_menuItemRename";
			this.toolStripMenuItem_11.ShortcutKeys = (Keys)131154;
			this.toolStripMenuItem_11.Size = new Size(203, 22);
			this.toolStripMenuItem_11.Text = "&Rename";
			this.toolStripMenuItem_12.Name = "_menuItemEditValue";
			this.toolStripMenuItem_12.ShortcutKeys = (Keys)131141;
			this.toolStripMenuItem_12.Size = new Size(203, 22);
			this.toolStripMenuItem_12.Text = "&Edit Value";
			this.toolStripMenuItem_13.Name = "_menuItemDelete";
			this.toolStripMenuItem_13.ShortcutKeys = Keys.Delete;
			this.toolStripMenuItem_13.Size = new Size(203, 22);
			this.toolStripMenuItem_13.Text = "&Delete";
			this.toolStripSeparator_4.Name = "toolStripSeparator10";
			this.toolStripSeparator_4.Size = new Size(200, 6);
			this.toolStripMenuItem_20.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_21,
				this.toolStripMenuItem_24,
				this.toolStripMenuItem_32,
				this.toolStripMenuItem_56,
				this.toolStripMenuItem_41,
				this.toolStripMenuItem_25,
				this.toolStripSeparator_11,
				this.toolStripSeparator_5,
				this.toolStripMenuItem_26,
				this.toolStripMenuItem_57
			});
			this.toolStripMenuItem_20.Name = "mnuTools";
			this.toolStripMenuItem_20.Size = new Size(48, 20);
			this.toolStripMenuItem_20.Text = "Tools";
			this.toolStripMenuItem_20.DropDownOpening += this.toolStripMenuItem_20_DropDownOpening;
			this.toolStripMenuItem_21.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_22,
				this.toolStripMenuItem_23,
				this.toolStripSeparator_13,
				this.toolStripMenuItem_59,
				this.toolStripSeparator_12,
				this.toolStripMenuItem_53,
				this.toolStripMenuItem_54,
				this.toolStripMenuItem_55
			});
			this.toolStripMenuItem_21.Name = "mnuConvert";
			this.toolStripMenuItem_21.Size = new Size(152, 22);
			this.toolStripMenuItem_21.Text = "Convert";
			this.toolStripMenuItem_21.DropDownOpening += this.toolStripMenuItem_21_DropDownOpening;
			this.toolStripMenuItem_22.Name = "mnuConvertToPC";
			this.toolStripMenuItem_22.Size = new Size(152, 22);
			this.toolStripMenuItem_22.Text = "Console To Java";
			this.toolStripMenuItem_22.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_23.Name = "mnuConvertFromPC";
			this.toolStripMenuItem_23.Size = new Size(152, 22);
			this.toolStripMenuItem_23.Text = "Java To Console";
			this.toolStripMenuItem_23.Click += this.toolStripMenuItem_23_Click;
			this.toolStripSeparator_13.Name = "toolStripMenuItem2";
			this.toolStripSeparator_13.Size = new Size(149, 6);
			this.toolStripMenuItem_59.Name = "mnuConvertToBedrock";
			this.toolStripMenuItem_59.Size = new Size(152, 22);
			this.toolStripMenuItem_59.Text = "Console To Bedrock";
			this.toolStripMenuItem_59.Click += this.toolStripMenuItem_59_Click;
			this.toolStripSeparator_12.Name = "toolStripMenuItem7";
			this.toolStripSeparator_12.Size = new Size(149, 6);
			this.toolStripMenuItem_53.Name = "mnuCovertConsoleToPS";
			this.toolStripMenuItem_53.Size = new Size(152, 22);
			this.toolStripMenuItem_53.Text = "Convert To PS3";
			this.toolStripMenuItem_53.Click += this.toolStripMenuItem_53_Click;
			this.toolStripMenuItem_54.Name = "mnuCovertConsoleToWII";
			this.toolStripMenuItem_54.Size = new Size(152, 22);
			this.toolStripMenuItem_54.Text = "Convert To Wii U";
			this.toolStripMenuItem_54.Click += this.toolStripMenuItem_54_Click;
			this.toolStripMenuItem_55.Name = "mnuCovertConsoleToXBOX";
			this.toolStripMenuItem_55.Size = new Size(152, 22);
			this.toolStripMenuItem_55.Text = "Convert To XBOX 360";
			this.toolStripMenuItem_55.Click += this.toolStripMenuItem_55_Click;
			this.toolStripMenuItem_41.Name = "mnuAddGRF";
			this.toolStripMenuItem_41.Size = new Size(152, 22);
			this.toolStripMenuItem_41.Text = "Add GRF";
			this.toolStripMenuItem_41.Click += this.toolStripMenuItem_41_Click;
			this.toolStripSeparator_11.Name = "tsmModSep";
			this.toolStripSeparator_11.Size = new Size(149, 6);
			this.toolStripSeparator_11.Visible = false;
			this.toolStripSeparator_5.Name = "toolStripMenuItem3";
			this.toolStripSeparator_5.Size = new Size(149, 6);
			this.toolStripMenuItem_57.Name = "addFileToolStripMenuItem";
			this.toolStripMenuItem_57.Size = new Size(152, 22);
			this.toolStripMenuItem_57.Text = "Add File";
			this.toolStripMenuItem_57.Visible = false;
			this.toolStripMenuItem_57.Click += this.toolStripMenuItem_57_Click;
			this.toolStripMenuItem_42.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_43,
				this.toolStripMenuItem_44
			});
			this.toolStripMenuItem_42.Name = "convertToolStripMenuItem1";
			this.toolStripMenuItem_42.Size = new Size(61, 20);
			this.toolStripMenuItem_42.Text = "Convert";
			this.toolStripMenuItem_42.Visible = false;
			this.toolStripMenuItem_43.Name = "toPCToolStripMenuItem";
			this.toolStripMenuItem_43.Size = new Size(120, 22);
			this.toolStripMenuItem_43.Text = "To PC";
			this.toolStripMenuItem_44.Name = "fromPCToolStripMenuItem";
			this.toolStripMenuItem_44.Size = new Size(120, 22);
			this.toolStripMenuItem_44.Text = "From PC";
			this.toolStripMenuItem_4.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_6,
				this.toolStripSeparator_2,
				this.toolStripMenuItem_29,
				this.toolStripSeparator_6,
				this.toolStripMenuItem_31,
				this.toolStripSeparator_8
			});
			this.toolStripMenuItem_4.Name = "helpToolStripMenuItem";
			this.toolStripMenuItem_4.Size = new Size(44, 20);
			this.toolStripMenuItem_4.Text = "Help";
			this.toolStripMenuItem_6.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_17,
				this.toolStripMenuItem_18,
				this.toolStripMenuItem_19,
				this.toolStripMenuItem_39
			});
			this.toolStripMenuItem_6.Name = "mnuMCReference";
			this.toolStripMenuItem_6.Size = new Size(148, 22);
			this.toolStripMenuItem_6.Text = "MC Reference";
			this.toolStripSeparator_8.Name = "toolStripMenuItem6";
			this.toolStripSeparator_8.Size = new Size(145, 6);
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_40,
				this.toolStripMenuItem_30,
				this.toolStripSeparator_10,
				this.toolStripMenuItem_36,
				this.toolStripMenuItem_49
			});
			this.contextMenuStrip_0.Name = "cmsFiles";
			this.contextMenuStrip_0.Size = new Size(145, 98);
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripSeparator_10.Name = "mnuSep1";
			this.toolStripSeparator_10.Size = new Size(141, 6);
			this.imageList_0.TransparentColor = Color.Transparent;
			this.splitContainer_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.splitContainer_0.Location = new Point(0, 23);
			this.splitContainer_0.Margin = new Padding(4);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Panel1.Controls.Add(this.panel_0);
			this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_0);
			this.splitContainer_0.Size = new Size(830, 630);
			this.splitContainer_0.SplitterDistance = 270;
			this.splitContainer_0.TabIndex = 4;
			this.splitContainer_0.SplitterMoved += this.splitContainer_0_SplitterMoved;
			this.panel_0.Controls.Add(this.listView_0);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(0, 28);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(270, 602);
			this.panel_0.TabIndex = 8;
			this.listView_0.BorderStyle = BorderStyle.None;
			this.listView_0.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4,
				this.columnHeader_5
			});
			this.listView_0.Dock = DockStyle.Fill;
			this.listView_0.FullRowSelect = true;
			this.listView_0.HideSelection = false;
			this.listView_0.Location = new Point(0, 0);
			this.listView_0.MultiSelect = false;
			this.listView_0.Name = "lvSearchResults";
			this.listView_0.Size = new Size(270, 602);
			this.listView_0.TabIndex = 7;
			this.listView_0.UseCompatibleStateImageBehavior = false;
			this.listView_0.View = View.Details;
			this.listView_0.Visible = false;
			this.columnHeader_0.Text = "Id";
			this.columnHeader_0.Width = 127;
			this.columnHeader_1.Text = "Type";
			this.columnHeader_1.Width = 69;
			this.columnHeader_2.Text = "Region";
			this.columnHeader_3.Text = "Chunk X Z";
			this.columnHeader_3.Width = 80;
			this.columnHeader_4.Text = "Entity X Y Z";
			this.columnHeader_4.Width = 85;
			this.columnHeader_5.Text = "Riding";
			this.columnHeader_5.Width = 100;
			this.toolStrip_0.AutoSize = false;
			this.toolStrip_0.GripMargin = new Padding(0);
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripSeparator_0,
				this.toolStripDropDownButton_0,
				this.toolStripButton_4,
				this.toolStripButton_3,
				this.toolStripSeparator_9,
				this.toolStripComboBox_0
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip2";
			this.toolStrip_0.Padding = new Padding(10, 0, 1, 0);
			this.toolStrip_0.Size = new Size(270, 28);
			this.toolStrip_0.Stretch = true;
			this.toolStrip_0.TabIndex = 6;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "_buttonOpen";
			this.toolStripButton_0.Size = new Size(23, 25);
			this.toolStripButton_0.Text = "Open NBT Data Source";
			this.toolStripButton_0.ToolTipText = "Open";
			this.toolStripButton_0.Visible = false;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "_buttonOpenFolder";
			this.toolStripButton_1.Size = new Size(23, 25);
			this.toolStripButton_1.Text = "Open Folder";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "_buttonSave";
			this.toolStripButton_2.Size = new Size(23, 25);
			this.toolStripButton_2.Text = "Save All Modified Tags";
			this.toolStripButton_2.ToolTipText = "Save";
			this.toolStripSeparator_0.Name = "toolStripSeparator8";
			this.toolStripSeparator_0.Size = new Size(6, 28);
			this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_37,
				this.toolStripMenuItem_38
			});
			this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripDropDownButton_0.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton_0.Size = new Size(29, 25);
			this.toolStripDropDownButton_0.Text = "toolStripDropDownButton2";
			this.toolStripDropDownButton_0.ToolTipText = "View";
			this.toolStripDropDownButton_0.Visible = false;
			this.toolStripMenuItem_37.Name = "mnuFileListView";
			this.toolStripMenuItem_37.Size = new Size(149, 22);
			this.toolStripMenuItem_37.Text = "File List";
			this.toolStripMenuItem_37.Click += this.toolStripMenuItem_37_Click;
			this.toolStripMenuItem_38.Name = "mnuSearchResultsView";
			this.toolStripMenuItem_38.Size = new Size(149, 22);
			this.toolStripMenuItem_38.Text = "Search Results";
			this.toolStripMenuItem_38.Click += this.toolStripMenuItem_38_Click;
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "_btnSearch";
			this.toolStripButton_3.Size = new Size(23, 25);
			this.toolStripButton_3.Text = "Find / Find Next";
			this.toolStripButton_3.ToolTipText = "Find";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripSeparator_9.Name = "toolStripSeparator3";
			this.toolStripSeparator_9.Size = new Size(6, 28);
			this.toolStripComboBox_0.AutoSize = false;
			this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_0.DropDownWidth = 100;
			this.toolStripComboBox_0.Margin = new Padding(10, 0, 1, 0);
			this.toolStripComboBox_0.Name = "cbModifiedFiles";
			this.toolStripComboBox_0.Size = new Size(75, 23);
			this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
			this.statusStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripStatusLabel_0,
				this.toolStripStatusLabel_3,
				this.toolStripStatusLabel_1,
				this.toolStripStatusLabel_2
			});
			this.statusStrip_0.Location = new Point(0, 651);
			this.statusStrip_0.Name = "statusDisplay";
			this.statusStrip_0.ShowItemToolTips = true;
			this.statusStrip_0.Size = new Size(827, 24);
			this.statusStrip_0.TabIndex = 5;
			this.statusStrip_0.Text = "statusStrip1";
			this.toolStripStatusLabel_0.AutoSize = false;
			this.toolStripStatusLabel_0.Name = "statusActiveFile";
			this.toolStripStatusLabel_0.Padding = new Padding(20, 0, 0, 0);
			this.toolStripStatusLabel_0.Size = new Size(30, 19);
			this.toolStripStatusLabel_0.TextAlign = ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel_0.ToolTipText = "Active World";
			this.toolStripStatusLabel_3.AutoSize = false;
			this.toolStripStatusLabel_3.BackgroundImageLayout = ImageLayout.None;
			this.toolStripStatusLabel_3.Margin = new Padding(0);
			this.toolStripStatusLabel_3.Name = "statusOpenWorkingFolder";
			this.toolStripStatusLabel_3.Size = new Size(20, 24);
			this.toolStripStatusLabel_3.ToolTipText = "Open Working Folder";
			this.toolStripStatusLabel_3.Click += this.toolStripStatusLabel_3_Click;
			this.toolStripStatusLabel_1.AutoSize = false;
			this.toolStripStatusLabel_1.BorderSides = ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel_1.BorderStyle = Border3DStyle.Etched;
			this.toolStripStatusLabel_1.Name = "statusWorkingFile";
			this.toolStripStatusLabel_1.Padding = new Padding(20, 0, 0, 0);
			this.toolStripStatusLabel_1.Size = new Size(200, 19);
			this.toolStripStatusLabel_1.TextAlign = ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel_1.ToolTipText = "Active file";
			this.toolStripStatusLabel_2.AutoSize = false;
			this.toolStripStatusLabel_2.Name = "statusVersion";
			this.toolStripStatusLabel_2.Size = new Size(75, 19);
			this.toolStripStatusLabel_2.TextAlign = ContentAlignment.MiddleRight;
			this.toolStripStatusLabel_2.ToolTipText = "Console type /  World version";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(827, 675);
			base.Controls.Add(this.statusStrip_0);
			base.Controls.Add(this.splitContainer_0);
			base.Controls.Add(this.menuStrip_0);
			base.MainMenuStrip = this.menuStrip_0;
			base.Name = "MainForm";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Full_UMT_Convertor";
			base.FormClosed += this.MainForm_FormClosed;
			base.Load += this.MainForm_Load;
			this.menuStrip_0.ResumeLayout(false);
			this.menuStrip_0.PerformLayout();
			this.contextMenuStrip_0.ResumeLayout(false);
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			((ISupportInitialize)this.splitContainer_0).EndInit();
			this.splitContainer_0.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.statusStrip_0.ResumeLayout(false);
			this.statusStrip_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000461E4 File Offset: 0x000443E4
		private void method_ConvertToPC(string outputFolder)
		{
			Full_UMT_Convertor.forms.ConvertToPC convertToPC = new Full_UMT_Convertor.forms.ConvertToPC();
			if (convertToPC.RunAutomated(outputFolder))
			{
				ConvertParameters convertParameters = convertToPC.ConvertParameters;
				new SGExtractDialog(Working.smethod_5(), convertParameters, RunTypes.ConvertToPC).ShowDialog(this);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0004621C File Offset: 0x0004441C
		private void method_ConvertToBedrock()
		{
			ConvertToBedrockUI convertToBedrockUI = new ConvertToBedrockUI();
			if (convertToBedrockUI.BedrockRunAutomated())
			{
				ConvertParameters convertParameters = convertToBedrockUI.ConvertParameters;
				new SGExtractDialog(Working.smethod_5(), convertParameters, RunTypes.ConvertToBedrock).ShowDialog(this);
			}
		}

		// Token: 0x0400054A RID: 1354
		private MCNBTTreeSupport mcnbttreeSupport_0;

		// Token: 0x0400054B RID: 1355
		private ChunkLookup chunkLookup_0;

		// Token: 0x0400054C RID: 1356
		private TreeNode treeNode_0;

		// Token: 0x0400054D RID: 1357
		private Dictionary<string, ModifiedFile> dictionary_0;

		// Token: 0x0400054E RID: 1358
		private bool bool_0;

		// Token: 0x0400054F RID: 1359
		private EventHandler eventHandler_0;

		// Token: 0x04000550 RID: 1360
		private EventHandler eventHandler_1;

		// Token: 0x04000551 RID: 1361
		private EventHandler eventHandler_2;

		// Token: 0x04000553 RID: 1363
		private MenuStrip menuStrip_0;

		// Token: 0x04000554 RID: 1364
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000555 RID: 1365
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000556 RID: 1366
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000557 RID: 1367
		private TreeView treeView_0;

		// Token: 0x04000558 RID: 1368
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000559 RID: 1369
		private ImageList imageList_0;

		// Token: 0x0400055A RID: 1370
		private SplitContainer splitContainer_0;

		// Token: 0x0400055B RID: 1371
		private ToolStrip toolStrip_0;

		// Token: 0x0400055C RID: 1372
		private ToolStripButton toolStripButton_0;

		// Token: 0x0400055D RID: 1373
		private ToolStripButton toolStripButton_1;

		// Token: 0x0400055E RID: 1374
		private ToolStripButton toolStripButton_2;

		// Token: 0x0400055F RID: 1375
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04000560 RID: 1376
		private ToolStripButton toolStripButton_3;

		// Token: 0x04000561 RID: 1377
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000562 RID: 1378
		private StatusStrip statusStrip_0;

		// Token: 0x04000563 RID: 1379
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04000564 RID: 1380
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04000565 RID: 1381
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04000566 RID: 1382
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x04000567 RID: 1383
		private ToolStripStatusLabel toolStripStatusLabel_1;

		// Token: 0x04000568 RID: 1384
		private ToolStripStatusLabel toolStripStatusLabel_2;

		// Token: 0x04000569 RID: 1385
		private ToolTip toolTip_0;

		// Token: 0x0400056A RID: 1386
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x0400056B RID: 1387
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x0400056C RID: 1388
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x0400056D RID: 1389
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x0400056E RID: 1390
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x0400056F RID: 1391
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04000570 RID: 1392
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x04000571 RID: 1393
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x04000572 RID: 1394
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x04000573 RID: 1395
		private ToolStripSeparator toolStripSeparator_4;

		// Token: 0x04000574 RID: 1396
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x04000575 RID: 1397
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x04000576 RID: 1398
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x04000577 RID: 1399
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x04000578 RID: 1400
		private ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x04000579 RID: 1401
		private ToolStripMenuItem toolStripMenuItem_19;

		// Token: 0x0400057A RID: 1402
		private ToolStripMenuItem toolStripMenuItem_20;

		// Token: 0x0400057B RID: 1403
		private ToolStripMenuItem toolStripMenuItem_21;

		// Token: 0x0400057C RID: 1404
		private ToolStripMenuItem toolStripMenuItem_22;

		// Token: 0x0400057D RID: 1405
		private ToolStripMenuItem toolStripMenuItem_23;

		// Token: 0x0400057E RID: 1406
		private ToolStripMenuItem toolStripMenuItem_24;

		// Token: 0x0400057F RID: 1407
		private ToolStripMenuItem toolStripMenuItem_25;

		// Token: 0x04000580 RID: 1408
		private ToolStripSeparator toolStripSeparator_5;

		// Token: 0x04000581 RID: 1409
		private ToolStripMenuItem toolStripMenuItem_26;

		// Token: 0x04000582 RID: 1410
		private ToolStripMenuItem toolStripMenuItem_27;

		// Token: 0x04000583 RID: 1411
		private ToolStripMenuItem toolStripMenuItem_28;

		// Token: 0x04000584 RID: 1412
		private ToolStripMenuItem toolStripMenuItem_29;

		// Token: 0x04000585 RID: 1413
		private ToolStripSeparator toolStripSeparator_6;

		// Token: 0x04000586 RID: 1414
		private ToolStripSeparator toolStripSeparator_7;

		// Token: 0x04000587 RID: 1415
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000588 RID: 1416
		private ToolStripMenuItem toolStripMenuItem_30;

		// Token: 0x04000589 RID: 1417
		private ToolStripMenuItem toolStripMenuItem_31;

		// Token: 0x0400058A RID: 1418
		private ToolStripSeparator toolStripSeparator_8;

		// Token: 0x0400058B RID: 1419
		private ToolStripMenuItem toolStripMenuItem_32;

		// Token: 0x0400058C RID: 1420
		private ToolStripMenuItem toolStripMenuItem_33;

		// Token: 0x0400058D RID: 1421
		private ToolStripMenuItem toolStripMenuItem_34;

		// Token: 0x0400058E RID: 1422
		private ToolStripMenuItem toolStripMenuItem_35;

		// Token: 0x0400058F RID: 1423
		private ToolStripMenuItem toolStripMenuItem_36;

		// Token: 0x04000590 RID: 1424
		private ToolStripDropDownButton toolStripDropDownButton_0;

		// Token: 0x04000591 RID: 1425
		private ToolStripMenuItem toolStripMenuItem_37;

		// Token: 0x04000592 RID: 1426
		private ToolStripMenuItem toolStripMenuItem_38;

		// Token: 0x04000593 RID: 1427
		private ToolStripSeparator toolStripSeparator_9;

		// Token: 0x04000594 RID: 1428
		private ListView listView_0;

		// Token: 0x04000595 RID: 1429
		private Panel panel_0;

		// Token: 0x04000596 RID: 1430
		private ColumnHeader columnHeader_0;

		// Token: 0x04000597 RID: 1431
		private ColumnHeader columnHeader_1;

		// Token: 0x04000598 RID: 1432
		private ColumnHeader columnHeader_2;

		// Token: 0x04000599 RID: 1433
		private ColumnHeader columnHeader_3;

		// Token: 0x0400059A RID: 1434
		private ColumnHeader columnHeader_4;

		// Token: 0x0400059B RID: 1435
		private ToolStripMenuItem toolStripMenuItem_39;

		// Token: 0x0400059C RID: 1436
		private ToolStripMenuItem toolStripMenuItem_40;

		// Token: 0x0400059D RID: 1437
		private ToolStripSeparator toolStripSeparator_10;

		// Token: 0x0400059E RID: 1438
		private ColumnHeader columnHeader_5;

		// Token: 0x0400059F RID: 1439
		private ToolStripStatusLabel toolStripStatusLabel_3;

		// Token: 0x040005A0 RID: 1440
		private ToolStripMenuItem toolStripMenuItem_41;

		// Token: 0x040005A1 RID: 1441
		private ToolStripMenuItem toolStripMenuItem_42;

		// Token: 0x040005A2 RID: 1442
		private ToolStripMenuItem toolStripMenuItem_43;

		// Token: 0x040005A3 RID: 1443
		private ToolStripMenuItem toolStripMenuItem_44;

		// Token: 0x040005A4 RID: 1444
		private ToolStripMenuItem toolStripMenuItem_45;

		// Token: 0x040005A5 RID: 1445
		private ToolStripMenuItem toolStripMenuItem_46;

		// Token: 0x040005A6 RID: 1446
		private ToolStripMenuItem toolStripMenuItem_47;

		// Token: 0x040005A7 RID: 1447
		private ToolStripMenuItem toolStripMenuItem_48;

		// Token: 0x040005A8 RID: 1448
		private ToolStripMenuItem toolStripMenuItem_49;

		// Token: 0x040005A9 RID: 1449
		private ToolStripMenuItem toolStripMenuItem_52;

		// Token: 0x040005AA RID: 1450
		private ToolStripSeparator toolStripSeparator_11;

		// Token: 0x040005AB RID: 1451
		private ToolStripMenuItem toolStripMenuItem_53;

		// Token: 0x040005AC RID: 1452
		private ToolStripMenuItem toolStripMenuItem_54;

		// Token: 0x040005AD RID: 1453
		private ToolStripMenuItem toolStripMenuItem_55;

		// Token: 0x040005AE RID: 1454
		private ToolStripSeparator toolStripSeparator_12;

		// Token: 0x040005AF RID: 1455
		private ToolStripMenuItem toolStripMenuItem_56;

		// Token: 0x040005B0 RID: 1456
		private ToolStripMenuItem toolStripMenuItem_57;

		// Token: 0x040005B1 RID: 1457
		private ToolStripMenuItem toolStripMenuItem_58;

		// Token: 0x040005B2 RID: 1458
		private ToolStripButton toolStripButton_4;

		// Token: 0x040005B3 RID: 1459
		private ToolStripSeparator toolStripSeparator_13;

		// Token: 0x040005B4 RID: 1460
		private ToolStripMenuItem toolStripMenuItem_59;

		// Token: 0x040005B5 RID: 1461
		private string commandLineOutputFile;
	}
}
