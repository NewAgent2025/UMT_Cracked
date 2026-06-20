using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Full_UMT_Convertor.Forms;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.utils;
using MCPELevelDBI.workers;
using Substrate.Nbt;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000171 RID: 369
	public partial class ConvertToBedrockUI : Form
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00009694 File Offset: 0x00007894
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0005EB1C File Offset: 0x0005CD1C
		public ConvertToBedrockUI()
		{
			this.method_6();
			this.list_0 = Utils.ReadBiomeChanges(ConvertType.FROM_PC);
			this.list_1 = Utils.ReadBlockChanges(ConvertType.FROM_PC);
			this.checkBox_5.Checked = true;
			this.checkBox_6.Checked = true;
			this.checkBox_7.Checked = true;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0005EB7C File Offset: 0x0005CD7C
		private void button_3_Click(object sender, EventArgs e)
		{
			if (this.list_2 == null)
			{
				string text = this.textBoxWorldPath.Text.Trim();
				if (!Directory.Exists(text))
				{
					MessageBox.Show(this, "Invalid Bedrock world folder.");
					return;
				}
				try
				{
					this.method_4(text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, "Failed to load Bedrock world.\n" + ex.Message);
					return;
				}
			}
			if (!this.method_0())
			{
				MessageBox.Show(this, "No Bedrock world loaded.");
				return;
			}
			this.convertParameters_0.ConvertOverworld = this.checkBox_0.Checked;
			this.convertParameters_0.ConvertNether = this.checkBox_2.Checked;
			this.convertParameters_0.ConvertTheEnd = this.checkBox_1.Checked;
			this.convertParameters_0.ReplaceBiomes = this.checkBox_3.Checked;
			this.convertParameters_0.BiomeChanges = this.list_0;
			this.convertParameters_0.ReplaceBlocks = this.checkBox_4.Checked;
			this.convertParameters_0.BlockChanges = this.list_1;
			this.convertParameters_0.ProcessWorldFolder = FileUtils.CheckFolderSep(this.string_0);
			this.convertParameters_0.ConvertTileEntities = this.checkBox_5.Checked;
			this.convertParameters_0.ConvertEntities = this.checkBox_6.Checked;
			this.convertParameters_0.ItemIdString = this.checkBox_7.Checked;
			this.convertParameters_0.ItemIdString = false;
			this.convertParameters_0.UpdateLevelData = this.checkBox_9.Checked;
			this.convertParameters_0.ModifiedLevelNode = this.tagNodeCompound_0;
			this.convertParameters_0.ConvertInto = this.method_1();
			if (this.checkBox_8.Checked)
			{
				this.convertParameters_0.UseConvertOffsets = true;
				this.convertParameters_0.XRegionOffset = (int)this.numericUpDown_1.Value;
				this.convertParameters_0.ZRegionOffset = (int)this.numericUpDown_0.Value;
			}
			this.convertParameters_0.ConvertToFormat = (this.radioButton_3.Checked ? ConversionFormat.Aquatic : ConversionFormat.PreAquatic);
			this.convertParameters_0.SetPlayPosition = this.checkBox_10.Checked;
			Utils.SaveConvertToBedrockFolder(this.convertParameters_0.ProcessWorldFolder);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0000969C File Offset: 0x0000789C
		private bool method_0()
		{
			return this.list_2 != null;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000096A7 File Offset: 0x000078A7
		private ConvertIntoType method_1()
		{
			if (this.radioButton_2.Checked)
			{
				return ConvertIntoType.EmptyWorld;
			}
			if (this.radioButton_1.Checked)
			{
				return ConvertIntoType.EmptyDimension;
			}
			if (this.radioButton_0.Checked)
			{
				return ConvertIntoType.OccupiedDimension;
			}
			return ConvertIntoType.EmptyWorld;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void ConvertToBedrockUI_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
		private void button_4_Click(object sender, EventArgs e)
		{
			if (this.list_2 == null)
			{
				return;
			}
			ConvertOffsetDisplay convertOffsetDisplay = new ConvertOffsetDisplay(this.list_2, (int)this.numericUpDown_1.Value, (int)this.numericUpDown_0.Value);
			if (convertOffsetDisplay.ShowDialog(this) == DialogResult.OK)
			{
				this.numericUpDown_1.Value = convertOffsetDisplay.RxOffset;
				this.numericUpDown_0.Value = convertOffsetDisplay.RzOffset;
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0005EE48 File Offset: 0x0005D048
		private void button_5_Click(object sender, EventArgs e)
		{
			TagNodeCompound tagNodeCompound = PEUtility.LoadPELevelRaw(this.string_0);
			if (this.tagNodeCompound_0 == null)
			{
				TagNodeCompound tagNodeCompound_ = PEUtility.LoadConsoleLevel(Path.Combine(Working.smethod_5(), Working.smethod_0()));
				MCSupport.smethod_0((TagNodeCompound)tagNodeCompound.Copy(), tagNodeCompound_, this.method_1());
			}
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0005EE98 File Offset: 0x0005D098
		private void method_2()
		{
			if (Directory.Exists(Utils.smethod_2()))
			{
				MCPEFolder mcpefolder = new MCPEFolder(GEnum0.Source);
				if (mcpefolder.ShowDialog(this) == DialogResult.OK)
				{
					if (mcpefolder.method_0() == (Enum3)0)
					{
						this.method_4(mcpefolder.PEWorldFolder.Path);
						return;
					}
					this.method_3();
					return;
				}
			}
			else
			{
				this.method_3();
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0005EEEC File Offset: 0x0005D0EC
		private void method_3()
		{
			string string_ = "Select MCPE World Folder";
			string text = FileUtils.smethod_4(Utils.smethod_2(), string_);
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.method_4(text);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0005EF1C File Offset: 0x0005D11C
		private void method_4(string string_1)
		{
			this.string_0 = string_1;
			this.list_2 = null;
			string path = Path.Combine(string_1, "world_icon.jpeg");
			this.pictureBox_0.Image = null;
			if (File.Exists(path))
			{
				using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
				{
					this.pictureBox_0.BackgroundImage = Image.FromStream(fileStream);
				}
			}
			string text = "";
			string path2 = Path.Combine(string_1, "levelname.txt");
			if (File.Exists(path2))
			{
				text = File.ReadAllText(path2);
			}
			this.label_5.Text = text;
			if (string_1.EndsWith("\\"))
			{
				string_1 = string_1.Substring(0, string_1.Length - 1);
			}
			string fileName = Path.GetFileName(string_1);
			this.label_4.Text = fileName;
			this.method_5();
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0005EFF8 File Offset: 0x0005D1F8
		private void method_5()
		{
			LevelDBWorker levelDBWorker = PEUtility.OpenDBWorker(this.string_0);
			this.list_2 = levelDBWorker.GetAvailableChunks();
			levelDBWorker.CloseDB();
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002BAE File Offset: 0x00000DAE
		private void button_7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0005F024 File Offset: 0x0005D224
		private void method_6()
		{
			this.groupBox_0 = new GroupBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.checkBox_0 = new CheckBox();
			this.checkBox_3 = new CheckBox();
			this.checkBox_4 = new CheckBox();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.groupBox_1 = new GroupBox();
			this.checkBox_5 = new CheckBox();
			this.checkBox_6 = new CheckBox();
			this.checkBox_7 = new CheckBox();
			this.groupBox_2 = new GroupBox();
			this.radioButton_0 = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.radioButton_2 = new RadioButton();
			this.groupBox_3 = new GroupBox();
			this.button_4 = new Button();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.numericUpDown_1 = new NumericUpDown();
			this.checkBox_8 = new CheckBox();
			this.groupBox_4 = new GroupBox();
			this.radioButton_3 = new RadioButton();
			this.radioButton_4 = new RadioButton();
			this.groupBox_5 = new GroupBox();
			this.button_5 = new Button();
			this.checkBox_9 = new CheckBox();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.pictureBox_0 = new PictureBox();
			this.button_6 = new Button();
			this.button_7 = new Button();
			this.checkBox_10 = new CheckBox();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.groupBox_2.SuspendLayout();
			this.groupBox_3.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			this.groupBox_4.SuspendLayout();
			this.groupBox_5.SuspendLayout();
			((ISupportInitialize)this.pictureBox_0).BeginInit();
			base.SuspendLayout();
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Controls.Add(this.checkBox_2);
			this.groupBox_0.Controls.Add(this.checkBox_0);
			this.groupBox_0.Location = new Point(12, 149);
			this.groupBox_0.Name = "groupBox1";
			this.groupBox_0.Size = new Size(125, 101);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Convert Dimension";
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(21, 76);
			this.checkBox_1.Name = "cbTheEnd";
			this.checkBox_1.Size = new Size(67, 17);
			this.checkBox_1.TabIndex = 2;
			this.checkBox_1.Text = "The End";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Checked = true;
			this.checkBox_2.CheckState = CheckState.Checked;
			this.checkBox_2.Location = new Point(21, 49);
			this.checkBox_2.Name = "cbNether";
			this.checkBox_2.Size = new Size(58, 17);
			this.checkBox_2.TabIndex = 1;
			this.checkBox_2.Text = "Nether";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(21, 23);
			this.checkBox_0.Name = "cbOverworld";
			this.checkBox_0.Size = new Size(74, 17);
			this.checkBox_0.TabIndex = 0;
			this.checkBox_0.Text = "Overworld";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(321, 156);
			this.checkBox_3.Name = "cbReplaceBiome";
			this.checkBox_3.Size = new Size(103, 17);
			this.checkBox_3.TabIndex = 1;
			this.checkBox_3.Text = "Replace Biomes";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Location = new Point(321, 209);
			this.checkBox_4.Name = "cbReplaceBlock";
			this.checkBox_4.Size = new Size(101, 17);
			this.checkBox_4.TabIndex = 3;
			this.checkBox_4.Text = "Replace Blocks";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(347, 467);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "Cancel";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_3.Location = new Point(261, 467);
			this.button_3.Name = "btnConvert";
			this.button_3.Size = new Size(75, 23);
			this.button_3.TabIndex = 6;
			this.button_3.Text = "Convert";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += this.button_3_Click;
			this.groupBox_1.Controls.Add(this.checkBox_5);
			this.groupBox_1.Controls.Add(this.checkBox_6);
			this.groupBox_1.Location = new Point(159, 149);
			this.groupBox_1.Name = "groupBox2";
			this.groupBox_1.Size = new Size(125, 101);
			this.groupBox_1.TabIndex = 10;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Include";
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Checked = true;
			this.checkBox_5.CheckState = CheckState.Checked;
			this.checkBox_5.Location = new Point(21, 23);
			this.checkBox_5.Name = "cbTileEntities";
			this.checkBox_5.Size = new Size(90, 17);
			this.checkBox_5.TabIndex = 7;
			this.checkBox_5.Text = "Block Entities";
			this.checkBox_5.UseVisualStyleBackColor = true;
			this.checkBox_6.AutoSize = true;
			this.checkBox_6.Checked = true;
			this.checkBox_6.CheckState = CheckState.Checked;
			this.checkBox_6.Location = new Point(21, 49);
			this.checkBox_6.Name = "cbEntities";
			this.checkBox_6.Size = new Size(60, 17);
			this.checkBox_6.TabIndex = 8;
			this.checkBox_6.Text = "Entities";
			this.checkBox_6.UseVisualStyleBackColor = true;
			this.checkBox_7.AutoSize = true;
			this.checkBox_7.Location = new Point(15, 263);
			this.checkBox_7.Name = "cbItemIdAsString";
			this.checkBox_7.Size = new Size(137, 17);
			this.checkBox_7.TabIndex = 13;
			this.checkBox_7.Text = "Use Strings for Item IDs";
			this.checkBox_7.UseVisualStyleBackColor = true;
			this.checkBox_7.Visible = false;
			this.groupBox_2.Controls.Add(this.radioButton_0);
			this.groupBox_2.Controls.Add(this.radioButton_1);
			this.groupBox_2.Controls.Add(this.radioButton_2);
			this.groupBox_2.Location = new Point(15, 263);
			this.groupBox_2.Name = "groupBox3";
			this.groupBox_2.Size = new Size(171, 94);
			this.groupBox_2.TabIndex = 14;
			this.groupBox_2.TabStop = false;
			this.groupBox_2.Text = "Convert into";
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(21, 65);
			this.radioButton_0.Name = "rbPopulatedRegion";
			this.radioButton_0.Size = new Size(123, 17);
			this.radioButton_0.TabIndex = 17;
			this.radioButton_0.Text = "Occupied Dimension";
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Checked = true;
			this.radioButton_1.Location = new Point(21, 42);
			this.radioButton_1.Name = "rbEmptyRegion";
			this.radioButton_1.Size = new Size(106, 17);
			this.radioButton_1.TabIndex = 16;
			this.radioButton_1.TabStop = true;
			this.radioButton_1.Text = "Empty Dimension";
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.radioButton_2.AutoSize = true;
			this.radioButton_2.Location = new Point(21, 19);
			this.radioButton_2.Name = "rbEmptyWorld";
			this.radioButton_2.Size = new Size(85, 17);
			this.radioButton_2.TabIndex = 15;
			this.radioButton_2.Text = "Empty World";
			this.radioButton_2.UseVisualStyleBackColor = true;
			this.groupBox_3.Controls.Add(this.button_4);
			this.groupBox_3.Controls.Add(this.label_0);
			this.groupBox_3.Controls.Add(this.label_1);
			this.groupBox_3.Controls.Add(this.numericUpDown_0);
			this.groupBox_3.Controls.Add(this.numericUpDown_1);
			this.groupBox_3.Controls.Add(this.checkBox_8);
			this.groupBox_3.Location = new Point(202, 263);
			this.groupBox_3.Name = "groupBox4";
			this.groupBox_3.Size = new Size(183, 94);
			this.groupBox_3.TabIndex = 15;
			this.groupBox_3.TabStop = false;
			this.groupBox_3.Text = "Convert Offset";
			this.button_4.Location = new Point(104, 13);
			this.button_4.Name = "btnOffsets";
			this.button_4.Size = new Size(73, 23);
			this.button_4.TabIndex = 5;
			this.button_4.Text = "Offsets UI";
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.Click += this.button_4_Click;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(75, 66);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(82, 13);
			this.label_0.TabIndex = 4;
			this.label_0.Text = "Z Region Offset";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(75, 42);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(82, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "X Region Offset";
			this.numericUpDown_0.Location = new Point(25, 64);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 10000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Minimum = new decimal(new int[]
			{
				10000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_0.Name = "nudZRegionOffset";
			this.numericUpDown_0.Size = new Size(43, 20);
			this.numericUpDown_0.TabIndex = 2;
			this.numericUpDown_1.Location = new Point(25, 39);
			NumericUpDown numericUpDown2 = this.numericUpDown_1;
			int[] array2 = new int[4];
			array2[0] = 10000;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDown_1.Minimum = new decimal(new int[]
			{
				10000,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_1.Name = "nudXRegionOffset";
			this.numericUpDown_1.Size = new Size(43, 20);
			this.numericUpDown_1.TabIndex = 1;
			this.checkBox_8.AutoSize = true;
			this.checkBox_8.Location = new Point(25, 20);
			this.checkBox_8.Name = "cbUseConversionOffsets";
			this.checkBox_8.Size = new Size(81, 17);
			this.checkBox_8.TabIndex = 0;
			this.checkBox_8.Text = "Use Offsets";
			this.checkBox_8.UseVisualStyleBackColor = true;
			this.groupBox_4.Controls.Add(this.radioButton_3);
			this.groupBox_4.Controls.Add(this.radioButton_4);
			this.groupBox_4.Location = new Point(33, 467);
			this.groupBox_4.Name = "groupBox5";
			this.groupBox_4.Size = new Size(171, 74);
			this.groupBox_4.TabIndex = 18;
			this.groupBox_4.TabStop = false;
			this.groupBox_4.Text = "Convert to";
			this.groupBox_4.Visible = false;
			this.radioButton_3.AutoSize = true;
			this.radioButton_3.Checked = true;
			this.radioButton_3.Location = new Point(21, 19);
			this.radioButton_3.Name = "rbAquaticFormat";
			this.radioButton_3.Size = new Size(96, 17);
			this.radioButton_3.TabIndex = 16;
			this.radioButton_3.TabStop = true;
			this.radioButton_3.Text = "Aquatic Format";
			this.radioButton_3.UseVisualStyleBackColor = true;
			this.radioButton_4.AutoSize = true;
			this.radioButton_4.Location = new Point(21, 42);
			this.radioButton_4.Name = "rbPreAquaticFormat";
			this.radioButton_4.Size = new Size(115, 17);
			this.radioButton_4.TabIndex = 15;
			this.radioButton_4.Text = "Pre-Aquatic Format";
			this.radioButton_4.UseVisualStyleBackColor = true;
			this.groupBox_5.Controls.Add(this.button_7);
			this.groupBox_5.Controls.Add(this.checkBox_10);
			this.groupBox_5.Controls.Add(this.button_5);
			this.groupBox_5.Controls.Add(this.checkBox_9);
			this.groupBox_5.Location = new Point(27, 375);
			this.groupBox_5.Name = "groupBox7";
			this.groupBox_5.Size = new Size(243, 74);
			this.groupBox_5.TabIndex = 21;
			this.groupBox_5.TabStop = false;
			this.groupBox_5.Text = "Update";
			this.button_5.Location = new Point(19, 39);
			this.button_5.Name = "btnEditLevelDat";
			this.button_5.Size = new Size(69, 23);
			this.button_5.TabIndex = 8;
			this.button_5.Text = "level.dat";
			this.button_5.UseVisualStyleBackColor = true;
			this.button_5.Click += this.button_5_Click;
			this.checkBox_9.AutoSize = true;
			this.checkBox_9.Checked = true;
			this.checkBox_9.CheckState = CheckState.Checked;
			this.checkBox_9.Location = new Point(21, 21);
			this.checkBox_9.Name = "cbUpdateLevelDat";
			this.checkBox_9.Size = new Size(70, 17);
			this.checkBox_9.TabIndex = 7;
			this.checkBox_9.Text = "Level.dat";
			this.checkBox_9.UseVisualStyleBackColor = true;
			this.label_2.AutoSize = true;
			this.label_2.ForeColor = Color.DimGray;
			this.label_2.Location = new Point(129, 51);
			this.label_2.Name = "label4";
			this.label_2.Size = new Size(36, 13);
			this.label_2.TabIndex = 30;
			this.label_2.Text = "Folder";
			this.label_3.AutoSize = true;
			this.label_3.ForeColor = Color.DimGray;
			this.label_3.Location = new Point(129, 11);
			this.label_3.Name = "label1";
			this.label_3.Size = new Size(35, 13);
			this.label_3.TabIndex = 29;
			this.label_3.Text = "Name";
			this.label_4.AutoSize = true;
			this.label_4.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_4.Location = new Point(129, 61);
			this.label_4.Name = "lblWorldFolder";
			this.label_4.Size = new Size(24, 17);
			this.label_4.TabIndex = 28;
			this.label_4.Text = "    ";
			this.label_5.AutoSize = true;
			this.label_5.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_5.Location = new Point(129, 22);
			this.label_5.Name = "lblWorldName";
			this.label_5.Size = new Size(24, 17);
			this.label_5.TabIndex = 27;
			this.label_5.Text = "    ";
			this.pictureBox_0.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBox_0.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBox_0.Location = new Point(12, 12);
			this.pictureBox_0.Name = "pbWorldIcon";
			this.pictureBox_0.Size = new Size(110, 64);
			this.pictureBox_0.TabIndex = 26;
			this.pictureBox_0.TabStop = false;
			this.button_6.Location = new Point(12, 82);
			this.button_6.Name = "btnSelectWorld";
			this.button_6.Size = new Size(110, 24);
			this.button_6.TabIndex = 25;
			this.button_6.Text = "Select World";
			this.button_6.UseVisualStyleBackColor = true;
			this.textBoxWorldPath = new TextBox();
			this.textBoxWorldPath.Location = new Point(12, 12);
			this.textBoxWorldPath.Size = new Size(300, 20);
			this.textBoxWorldPath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Pryze Software\\Universal Minecraft Tool\\BLANK_BEDROCK_WORLD");
			this.textBoxWorldPath.KeyDown += this.textBoxWorldPath_KeyDown;
			base.Controls.Add(this.textBoxWorldPath);
			this.button_7.Location = new Point(122, 39);
			this.button_7.Name = "btnSetPlayerPosition";
			this.button_7.Size = new Size(69, 23);
			this.button_7.TabIndex = 12;
			this.button_7.Text = "Position";
			this.button_7.UseVisualStyleBackColor = true;
			this.button_7.Click += this.button_7_Click;
			this.checkBox_10.AutoSize = true;
			this.checkBox_10.Location = new Point(122, 21);
			this.checkBox_10.Name = "cbSetPlayerPos";
			this.checkBox_10.Size = new Size(76, 17);
			this.checkBox_10.TabIndex = 11;
			this.checkBox_10.Text = "Player Pos";
			this.checkBox_10.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button_3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(440, 504);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.pictureBox_0);
			base.Controls.Add(this.button_6);
			base.Controls.Add(this.groupBox_5);
			base.Controls.Add(this.groupBox_4);
			base.Controls.Add(this.groupBox_3);
			base.Controls.Add(this.groupBox_2);
			base.Controls.Add(this.checkBox_7);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.checkBox_4);
			base.Controls.Add(this.checkBox_3);
			base.Controls.Add(this.groupBox_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConvertToBedrockUI";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Convert Console To Bedrock";
			base.Load += this.ConvertToBedrockUI_Load;
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			this.groupBox_2.ResumeLayout(false);
			this.groupBox_2.PerformLayout();
			this.groupBox_3.ResumeLayout(false);
			this.groupBox_3.PerformLayout();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			this.groupBox_4.ResumeLayout(false);
			this.groupBox_4.PerformLayout();
			this.groupBox_5.ResumeLayout(false);
			this.groupBox_5.PerformLayout();
			((ISupportInitialize)this.pictureBox_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000607C8 File Offset: 0x0005E9C8
		private void textBoxWorldPath_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				string text = this.textBoxWorldPath.Text.Trim();
				if (Directory.Exists(text))
				{
					try
					{
						this.method_4(text);
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, "Error occurred while attempting to open PE World." + Environment.NewLine + ex.Message, "Open World Failed");
						return;
					}
				}
				MessageBox.Show(this, "Folder does not exist.");
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00060844 File Offset: 0x0005EA44
		private void textBoxWorldPath_TextChanged(object sender, EventArgs e)
		{
			string text = this.textBoxWorldPath.Text.Trim();
			if (Directory.Exists(text))
			{
				try
				{
					this.method_4(text);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000096F6 File Offset: 0x000078F6
		public bool BedrockRunAutomated()
		{
			this.button_3_Click(null, EventArgs.Empty);
			return base.DialogResult == DialogResult.OK;
		}

		// Token: 0x0400087C RID: 2172
		private TagNodeCompound tagNodeCompound_0;

		// Token: 0x0400087D RID: 2173
		private ConvertParameters convertParameters_0 = new ConvertParameters();

		// Token: 0x0400087E RID: 2174
		private List<BiomeChange> list_0;

		// Token: 0x0400087F RID: 2175
		private List<BlockChange> list_1;

		// Token: 0x04000880 RID: 2176
		private List<PEDimension> list_2;

		// Token: 0x04000881 RID: 2177
		private string string_0;

		// Token: 0x04000883 RID: 2179
		private GroupBox groupBox_0;

		// Token: 0x04000884 RID: 2180
		private CheckBox checkBox_0;

		// Token: 0x04000885 RID: 2181
		private CheckBox checkBox_1;

		// Token: 0x04000886 RID: 2182
		private CheckBox checkBox_2;

		// Token: 0x04000887 RID: 2183
		private CheckBox checkBox_3;

		// Token: 0x04000888 RID: 2184
		private CheckBox checkBox_4;

		// Token: 0x04000889 RID: 2185
		private Button button_2;

		// Token: 0x0400088A RID: 2186
		private Button button_3;

		// Token: 0x0400088B RID: 2187
		private GroupBox groupBox_1;

		// Token: 0x0400088C RID: 2188
		private CheckBox checkBox_5;

		// Token: 0x0400088D RID: 2189
		private CheckBox checkBox_6;

		// Token: 0x0400088E RID: 2190
		private CheckBox checkBox_7;

		// Token: 0x0400088F RID: 2191
		private GroupBox groupBox_2;

		// Token: 0x04000890 RID: 2192
		private RadioButton radioButton_0;

		// Token: 0x04000891 RID: 2193
		private RadioButton radioButton_1;

		// Token: 0x04000892 RID: 2194
		private RadioButton radioButton_2;

		// Token: 0x04000893 RID: 2195
		private GroupBox groupBox_3;

		// Token: 0x04000894 RID: 2196
		private Label label_0;

		// Token: 0x04000895 RID: 2197
		private Label label_1;

		// Token: 0x04000896 RID: 2198
		private NumericUpDown numericUpDown_0;

		// Token: 0x04000897 RID: 2199
		private NumericUpDown numericUpDown_1;

		// Token: 0x04000898 RID: 2200
		private CheckBox checkBox_8;

		// Token: 0x04000899 RID: 2201
		private GroupBox groupBox_4;

		// Token: 0x0400089A RID: 2202
		private RadioButton radioButton_3;

		// Token: 0x0400089B RID: 2203
		private RadioButton radioButton_4;

		// Token: 0x0400089C RID: 2204
		private Button button_4;

		// Token: 0x0400089D RID: 2205
		private GroupBox groupBox_5;

		// Token: 0x0400089E RID: 2206
		private Button button_5;

		// Token: 0x0400089F RID: 2207
		private CheckBox checkBox_9;

		// Token: 0x040008A0 RID: 2208
		private Label label_2;

		// Token: 0x040008A1 RID: 2209
		private Label label_3;

		// Token: 0x040008A2 RID: 2210
		private Label label_4;

		// Token: 0x040008A3 RID: 2211
		private Label label_5;

		// Token: 0x040008A4 RID: 2212
		private PictureBox pictureBox_0;

		// Token: 0x040008A5 RID: 2213
		private Button button_6;

		// Token: 0x040008A6 RID: 2214
		private Button button_7;

		// Token: 0x040008A7 RID: 2215
		private CheckBox checkBox_10;

		// Token: 0x040008A8 RID: 2216
		private TextBox textBoxWorldPath;
	}
}
