using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NBTExplorer.Model;
using NBTExplorer.Windows;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.forms
{
	// Token: 0x0200005A RID: 90
	public partial class MCFindBlock : Form
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		public MCFindBlock(ChunkLookup chunkLookups)
		{
			this.method_32();
			this.comboBox_0.SelectedIndex = 0;
			this.class19_0 = new MCFindBlock.Class19
			{
				watermarkTextBox_0 = this.watermarkTextBox_3,
				LjAoMajwx8 = this.watermarkTextBox_1
			};
			this.class19_1 = new MCFindBlock.Class19
			{
				watermarkTextBox_0 = this.watermarkTextBox_2,
				LjAoMajwx8 = this.watermarkTextBox_0
			};
			this.method_30();
			this.chunkLookups = chunkLookups;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000451E File Offset: 0x0000271E
		public TreeNode Result
		{
			get
			{
				return this.treeNode_0;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001C08C File Offset: 0x0001A28C
		private DataNode method_0(DataNode dataNode_0)
		{
			if (dataNode_0 is DirectoryDataNode)
			{
				DirectoryDataNode directoryDataNode = dataNode_0 as DirectoryDataNode;
				if (!directoryDataNode.IsExpanded)
				{
					directoryDataNode.Expand();
				}
				foreach (DataNode dataNode_ in directoryDataNode.Nodes)
				{
					DataNode dataNode = this.method_0(dataNode_);
					if (dataNode != null)
					{
						return dataNode;
					}
				}
				return null;
			}
			if (dataNode_0 is RegionFileDataNode)
			{
				RegionFileDataNode regionFileDataNode = dataNode_0 as RegionFileDataNode;
				int num;
				int num2;
				if (!RegionFileDataNode.RegionCoordinates(regionFileDataNode.NodePathName, out num, out num2))
				{
					return null;
				}
				if (!regionFileDataNode.IsExpanded)
				{
					regionFileDataNode.Expand();
				}
				foreach (DataNode dataNode_2 in regionFileDataNode.Nodes)
				{
					DataNode dataNode2 = this.method_0(dataNode_2);
					if (dataNode2 != null)
					{
						return dataNode2;
					}
				}
				return null;
			}
			else
			{
				if (dataNode_0 is RegionChunkDataNode)
				{
					return dataNode_0 as RegionChunkDataNode;
				}
				return null;
			}
			DataNode result;
			return result;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00004526 File Offset: 0x00002726
		private int method_1(int int_0, int int_1)
		{
			return (int_0 % int_1 + int_1) % int_1;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001C19C File Offset: 0x0001A39C
		private string method_2(int int_0)
		{
			return (int_0 >> 4 >> 5).ToString();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		private string method_3(int int_0)
		{
			return (int_0 >> 4).ToString();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		private string method_4(int int_0)
		{
			return this.method_1(int_0 >> 4, 32).ToString();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		private string method_5(int int_0)
		{
			return this.method_1(int_0, 16).ToString();
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0001C210 File Offset: 0x0001A410
		private string method_6(int int_0)
		{
			return (int_0 >> 5).ToString();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0001C228 File Offset: 0x0001A428
		private string method_7(int int_0)
		{
			int num = int_0 * 16;
			int num2 = (int_0 + 1) * 16 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001C25C File Offset: 0x0001A45C
		private string method_8(int int_0, int int_1)
		{
			return (int_0 * 16 + int_1).ToString();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001C278 File Offset: 0x0001A478
		private string method_9(int int_0)
		{
			return this.method_1(int_0, 32).ToString();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000452F File Offset: 0x0000272F
		private string method_10(int int_0)
		{
			return "(0 to 15)";
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001C298 File Offset: 0x0001A498
		private string method_11(int int_0)
		{
			int num = int_0 * 32;
			int num2 = (int_0 + 1) * 32 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001C2CC File Offset: 0x0001A4CC
		private string method_12(int int_0)
		{
			int num = int_0 * 32 * 16;
			int num2 = (int_0 + 1) * 32 * 16 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00004536 File Offset: 0x00002736
		private string method_13(int int_0)
		{
			return "(0 to 31)";
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000452F File Offset: 0x0000272F
		private string method_14(int int_0)
		{
			return "(0 to 15)";
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000453D File Offset: 0x0000273D
		private string method_15(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000453D File Offset: 0x0000273D
		private string method_16(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001C304 File Offset: 0x0001A504
		private string method_17(int int_0, int int_1)
		{
			return (int_0 * 32 + int_1).ToString();
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000453D File Offset: 0x0000273D
		private string method_18(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00004544 File Offset: 0x00002744
		private string method_19(int int_0, int int_1)
		{
			return this.method_7(int_0 * 32 + int_1);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000452F File Offset: 0x0000272F
		private string method_20(int int_0)
		{
			return "(0 to 15)";
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000452F File Offset: 0x0000272F
		private string method_21(int int_0, int int_1)
		{
			return "(0 to 15)";
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000453D File Offset: 0x0000273D
		private string method_22(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000453D File Offset: 0x0000273D
		private string method_23(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001C304 File Offset: 0x0001A504
		private string method_24(int int_0, int int_1, int int_2)
		{
			return (int_0 * 32 + int_1).ToString();
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000453D File Offset: 0x0000273D
		private string method_25(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0001C320 File Offset: 0x0001A520
		private string method_26(int int_0, int int_1, int int_2)
		{
			return (int_0 * 32 * 16 + int_1 * 16 + int_2).ToString();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001C344 File Offset: 0x0001A544
		private int? method_27(string string_1)
		{
			int value;
			if (int.TryParse(string_1, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00004552 File Offset: 0x00002752
		private void zeooAjnoCq(WatermarkTextBox watermarkTextBox_4, string string_1, bool bool_1)
		{
			if (bool_1)
			{
				watermarkTextBox_4.ApplyText(string_1);
				return;
			}
			watermarkTextBox_4.ApplyWatermark(string_1);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0001C36C File Offset: 0x0001A56C
		private void method_28(MCFindBlock.Class19 class19_2, string string_1, bool bool_1)
		{
			class19_2.nullable_0 = this.method_27(string_1);
			this.zeooAjnoCq(class19_2.watermarkTextBox_0, string_1, bool_1);
			if (bool_1 && class19_2.nullable_0 != null)
			{
				this.method_29(class19_2, this.method_7(class19_2.nullable_0.Value), false);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
		private void method_29(MCFindBlock.Class19 class19_2, string string_1, bool bool_1)
		{
			class19_2.nullable_1 = this.method_27(string_1);
			this.zeooAjnoCq(class19_2.LjAoMajwx8, string_1, bool_1);
			if (bool_1 && class19_2.nullable_1 != null)
			{
				this.method_28(class19_2, this.method_3(class19_2.nullable_1.Value), false);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004566 File Offset: 0x00002766
		private void method_30()
		{
			if (this.class19_0.nullable_0 == null || this.class19_1.nullable_0 == null)
			{
				this.XgcoNnFveo.Enabled = false;
				return;
			}
			this.XgcoNnFveo.Enabled = true;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001C414 File Offset: 0x0001A614
		private void watermarkTextBox_3_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_3.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_28(this.class19_0, this.watermarkTextBox_3.Text, true);
			this.bool_0 = false;
			this.method_30();
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0001C46C File Offset: 0x0001A66C
		private void watermarkTextBox_2_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_2.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_28(this.class19_1, this.watermarkTextBox_2.Text, true);
			this.bool_0 = false;
			this.method_30();
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		private void watermarkTextBox_1_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_1.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_29(this.class19_0, this.watermarkTextBox_1.Text, true);
			this.bool_0 = false;
			this.method_30();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001C51C File Offset: 0x0001A71C
		private void watermarkTextBox_0_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_0.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_29(this.class19_1, this.watermarkTextBox_0.Text, true);
			this.bool_0 = false;
			this.method_30();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0001C574 File Offset: 0x0001A774
		private void XgcoNnFveo_Click(object sender, EventArgs e)
		{
			MCFindBlock.FindBlockData findBlockData = new MCFindBlock.FindBlockData();
			int.TryParse(this.watermarkTextBox_3.Text, out findBlockData.x);
			int.TryParse(this.watermarkTextBox_2.Text, out findBlockData.z);
			findBlockData.region = this.string_0[this.comboBox_0.SelectedIndex];
			TreeNode treeNode = this.method_31(findBlockData);
			if (treeNode != null)
			{
				this.treeNode_0 = treeNode;
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			MessageBox.Show("Chunk was not found!", "Chunk not found!");
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001C600 File Offset: 0x0001A800
		private TreeNode method_31(MCFindBlock.FindBlockData findBlockData_0)
		{
			TreeNode result = null;
			if (findBlockData_0 != null)
			{
				result = this.chunkLookups.FindChunkNode(findBlockData_0.region, findBlockData_0.x, findBlockData_0.z);
			}
			return result;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000045A5 File Offset: 0x000027A5
		private void button_0_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000045B4 File Offset: 0x000027B4
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.watermarkTextBox_1.Focus();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0001B654 File Offset: 0x00019854
		private void MCFindBlock_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060003D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.forms.MCFindBlock::MCFindBlock_Load(System.Object,System.EventArgs)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0001C634 File Offset: 0x0001A834
		private void method_32()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.groupBox_0 = new GroupBox();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.watermarkTextBox_0 = new WatermarkTextBox();
			this.watermarkTextBox_1 = new WatermarkTextBox();
			this.groupBox_1 = new GroupBox();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.watermarkTextBox_2 = new WatermarkTextBox();
			this.watermarkTextBox_3 = new WatermarkTextBox();
			this.XgcoNnFveo = new Button();
			this.button_0 = new Button();
			this.comboBox_0 = new ComboBox();
			this.label_4 = new Label();
			this.tableLayoutPanel_0.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.00001f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Controls.Add(this.groupBox_0, 1, 0);
			this.tableLayoutPanel_0.Controls.Add(this.groupBox_1, 0, 0);
			this.tableLayoutPanel_0.Location = new Point(7, 50);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 1;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(276, 80);
			this.tableLayoutPanel_0.TabIndex = 1;
			this.groupBox_0.Controls.Add(this.label_0);
			this.groupBox_0.Controls.Add(this.label_1);
			this.groupBox_0.Controls.Add(this.watermarkTextBox_0);
			this.groupBox_0.Controls.Add(this.watermarkTextBox_1);
			this.groupBox_0.Location = new Point(140, 3);
			this.groupBox_0.Name = "groupBox3";
			this.groupBox_0.Size = new Size(133, 70);
			this.groupBox_0.TabIndex = 2;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Block";
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(6, 48);
			this.label_0.Name = "label5";
			this.label_0.Size = new Size(17, 13);
			this.label_0.TabIndex = 7;
			this.label_0.Text = "Z:";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(6, 22);
			this.label_1.Name = "label6";
			this.label_1.Size = new Size(17, 13);
			this.label_1.TabIndex = 6;
			this.label_1.Text = "X:";
			this.watermarkTextBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.watermarkTextBox_0.ForeColor = Color.Gray;
			this.watermarkTextBox_0.Location = new Point(27, 45);
			this.watermarkTextBox_0.Name = "_blockZTextBox";
			this.watermarkTextBox_0.Size = new Size(100, 20);
			this.watermarkTextBox_0.TabIndex = 1;
			this.watermarkTextBox_0.Text = "Type here";
			this.watermarkTextBox_0.WatermarkActive = true;
			this.watermarkTextBox_0.WatermarkText = "Type here";
			this.watermarkTextBox_0.TextChanged += this.watermarkTextBox_0_TextChanged;
			this.watermarkTextBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.watermarkTextBox_1.ForeColor = Color.Gray;
			this.watermarkTextBox_1.Location = new Point(27, 19);
			this.watermarkTextBox_1.Name = "_blockXTextBox";
			this.watermarkTextBox_1.Size = new Size(100, 20);
			this.watermarkTextBox_1.TabIndex = 0;
			this.watermarkTextBox_1.Text = "Type here";
			this.watermarkTextBox_1.WatermarkActive = true;
			this.watermarkTextBox_1.WatermarkText = "Type here";
			this.watermarkTextBox_1.TextChanged += this.watermarkTextBox_1_TextChanged;
			this.groupBox_1.Controls.Add(this.label_2);
			this.groupBox_1.Controls.Add(this.label_3);
			this.groupBox_1.Controls.Add(this.watermarkTextBox_2);
			this.groupBox_1.Controls.Add(this.watermarkTextBox_3);
			this.groupBox_1.Dock = DockStyle.Fill;
			this.groupBox_1.Location = new Point(3, 3);
			this.groupBox_1.Name = "groupBox2";
			this.groupBox_1.Size = new Size(131, 74);
			this.groupBox_1.TabIndex = 2;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Chunk";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(6, 48);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(17, 13);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Z:";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(6, 22);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(17, 13);
			this.label_3.TabIndex = 4;
			this.label_3.Text = "X:";
			this.watermarkTextBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.watermarkTextBox_2.ForeColor = Color.Gray;
			this.watermarkTextBox_2.Location = new Point(25, 45);
			this.watermarkTextBox_2.Name = "_chunkZTextBox";
			this.watermarkTextBox_2.Size = new Size(100, 20);
			this.watermarkTextBox_2.TabIndex = 1;
			this.watermarkTextBox_2.Text = "Type here";
			this.watermarkTextBox_2.WatermarkActive = true;
			this.watermarkTextBox_2.WatermarkText = "Type here";
			this.watermarkTextBox_2.TextChanged += this.watermarkTextBox_2_TextChanged;
			this.watermarkTextBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.watermarkTextBox_3.ForeColor = Color.Gray;
			this.watermarkTextBox_3.Location = new Point(25, 19);
			this.watermarkTextBox_3.Name = "_chunkXTextBox";
			this.watermarkTextBox_3.Size = new Size(100, 20);
			this.watermarkTextBox_3.TabIndex = 0;
			this.watermarkTextBox_3.Text = "Type here";
			this.watermarkTextBox_3.WatermarkActive = true;
			this.watermarkTextBox_3.WatermarkText = "Type here";
			this.watermarkTextBox_3.TextChanged += this.watermarkTextBox_3_TextChanged;
			this.XgcoNnFveo.Location = new Point(121, 141);
			this.XgcoNnFveo.Name = "_findButton";
			this.XgcoNnFveo.Size = new Size(75, 23);
			this.XgcoNnFveo.TabIndex = 2;
			this.XgcoNnFveo.Text = "Find Chunk";
			this.XgcoNnFveo.UseVisualStyleBackColor = true;
			this.XgcoNnFveo.Click += this.XgcoNnFveo_Click;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(205, 141);
			this.button_0.Name = "_cancelButton";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 3;
			this.button_0.Text = "Cancel";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Items.AddRange(new object[]
			{
				"Overworld",
				"Nether",
				"The End"
			});
			this.comboBox_0.Location = new Point(9, 23);
			this.comboBox_0.Name = "cbRegions";
			this.comboBox_0.Size = new Size(132, 21);
			this.comboBox_0.TabIndex = 4;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(9, 6);
			this.label_4.Name = "label1";
			this.label_4.Size = new Size(41, 13);
			this.label_4.TabIndex = 5;
			this.label_4.Text = "Region";
			base.AcceptButton = this.XgcoNnFveo;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(291, 173);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.XgcoNnFveo);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MCFindBlock";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Chunk Finder";
			base.Load += this.MCFindBlock_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000203 RID: 515
		private bool bool_0;

		// Token: 0x04000204 RID: 516
		private MCFindBlock.Class19 class19_0;

		// Token: 0x04000205 RID: 517
		private MCFindBlock.Class19 class19_1;

		// Token: 0x04000206 RID: 518
		private TreeNode treeNode_0;

		// Token: 0x04000207 RID: 519
		private ChunkLookup chunkLookups;

		// Token: 0x04000208 RID: 520
		private string[] string_0 = new string[]
		{
			"region",
			"dim-1",
			"dim1"
		};

		// Token: 0x0400020A RID: 522
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x0400020B RID: 523
		private GroupBox groupBox_0;

		// Token: 0x0400020C RID: 524
		private GroupBox groupBox_1;

		// Token: 0x0400020D RID: 525
		private Label label_0;

		// Token: 0x0400020E RID: 526
		private Label label_1;

		// Token: 0x0400020F RID: 527
		private WatermarkTextBox watermarkTextBox_0;

		// Token: 0x04000210 RID: 528
		private WatermarkTextBox watermarkTextBox_1;

		// Token: 0x04000211 RID: 529
		private Label label_2;

		// Token: 0x04000212 RID: 530
		private Label label_3;

		// Token: 0x04000213 RID: 531
		private WatermarkTextBox watermarkTextBox_2;

		// Token: 0x04000214 RID: 532
		private WatermarkTextBox watermarkTextBox_3;

		// Token: 0x04000215 RID: 533
		private Button XgcoNnFveo;

		// Token: 0x04000216 RID: 534
		private Button button_0;

		// Token: 0x04000217 RID: 535
		private ComboBox comboBox_0;

		// Token: 0x04000218 RID: 536
		private Label label_4;

		// Token: 0x0200005B RID: 91
		public class FindBlockData
		{
			// Token: 0x04000219 RID: 537
			public int x;

			// Token: 0x0400021A RID: 538
			public int z;

			// Token: 0x0400021B RID: 539
			public string region;
		}

		// Token: 0x0200005C RID: 92
		private class Class19
		{
			// Token: 0x0400021C RID: 540
			public int? nullable_0;

			// Token: 0x0400021D RID: 541
			public int? nullable_1;

			// Token: 0x0400021E RID: 542
			public WatermarkTextBox watermarkTextBox_0;

			// Token: 0x0400021F RID: 543
			public WatermarkTextBox LjAoMajwx8;
		}
	}
}
