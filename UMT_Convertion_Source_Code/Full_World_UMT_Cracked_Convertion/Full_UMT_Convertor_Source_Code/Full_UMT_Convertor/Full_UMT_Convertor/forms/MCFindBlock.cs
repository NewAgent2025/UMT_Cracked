using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using NBTExplorer.Model;
using NBTExplorer.Windows;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x02000077 RID: 119
	public partial class MCFindBlock : Form
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x00026B2C File Offset: 0x00024D2C
		public MCFindBlock(ChunkLookup chunkLookups)
		{
			this.method_33();
			this.comboBox_0.SelectedIndex = 0;
			this.class20_0 = new MCFindBlock.Class20
			{
				watermarkTextBox_0 = this.watermarkTextBox_3,
				watermarkTextBox_1 = this.watermarkTextBox_1
			};
			this.class20_1 = new MCFindBlock.Class20
			{
				watermarkTextBox_0 = this.watermarkTextBox_2,
				watermarkTextBox_1 = this.watermarkTextBox_0
			};
			this.method_31();
			this.chunkLookups = chunkLookups;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public TreeNode Result
		{
			get
			{
				return this.treeNode_0;
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00026BD0 File Offset: 0x00024DD0
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

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002D81 File Offset: 0x00000F81
		private int method_1(int int_0, int int_1)
		{
			return (int_0 % int_1 + int_1) % int_1;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00026CE0 File Offset: 0x00024EE0
		private string method_2(int int_0)
		{
			return (int_0 >> 4 >> 5).ToString();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00026CFC File Offset: 0x00024EFC
		private string method_3(int int_0)
		{
			return (int_0 >> 4).ToString();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00026D14 File Offset: 0x00024F14
		private string method_4(int int_0)
		{
			return this.method_1(int_0 >> 4, 32).ToString();
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00026D34 File Offset: 0x00024F34
		private string method_5(int int_0)
		{
			return this.method_1(int_0, 16).ToString();
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00026D54 File Offset: 0x00024F54
		private string method_6(int int_0)
		{
			return (int_0 >> 5).ToString();
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00026D6C File Offset: 0x00024F6C
		private string method_7(int int_0)
		{
			int num = int_0 * 16;
			int num2 = (int_0 + 1) * 16 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00026DA0 File Offset: 0x00024FA0
		private string method_8(int int_0, int int_1)
		{
			return (int_0 * 16 + int_1).ToString();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00026DBC File Offset: 0x00024FBC
		private string method_9(int int_0)
		{
			return this.method_1(int_0, 32).ToString();
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00004AE1 File Offset: 0x00002CE1
		private string method_10(int int_0)
		{
			return "(0 to 15)";
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00026DDC File Offset: 0x00024FDC
		private string method_11(int int_0)
		{
			int num = int_0 * 32;
			int num2 = (int_0 + 1) * 32 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00026E10 File Offset: 0x00025010
		private string method_12(int int_0)
		{
			int num = int_0 * 32 * 16;
			int num2 = (int_0 + 1) * 32 * 16 - 1;
			return string.Format("({0} to {1})", num, num2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00004AE8 File Offset: 0x00002CE8
		private string method_13(int int_0)
		{
			return "(0 to 31)";
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00004AE1 File Offset: 0x00002CE1
		private string method_14(int int_0)
		{
			return "(0 to 15)";
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004AEF File Offset: 0x00002CEF
		private string method_15(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004AEF File Offset: 0x00002CEF
		private string method_16(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00026E48 File Offset: 0x00025048
		private string method_17(int int_0, int int_1)
		{
			return (int_0 * 32 + int_1).ToString();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00004AEF File Offset: 0x00002CEF
		private string method_18(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004AF6 File Offset: 0x00002CF6
		private string method_19(int int_0, int int_1)
		{
			return this.method_7(int_0 * 32 + int_1);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00004AE1 File Offset: 0x00002CE1
		private string method_20(int int_0)
		{
			return "(0 to 15)";
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00004AE1 File Offset: 0x00002CE1
		private string method_21(int int_0, int int_1)
		{
			return "(0 to 15)";
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00004AEF File Offset: 0x00002CEF
		private string method_22(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004AEF File Offset: 0x00002CEF
		private string method_23(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00026E48 File Offset: 0x00025048
		private string method_24(int int_0, int int_1, int int_2)
		{
			return (int_0 * 32 + int_1).ToString();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00004AEF File Offset: 0x00002CEF
		private string method_25(int int_0)
		{
			return "(ANY)";
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00026E64 File Offset: 0x00025064
		private string method_26(int int_0, int int_1, int int_2)
		{
			return (int_0 * 32 * 16 + int_1 * 16 + int_2).ToString();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00026E88 File Offset: 0x00025088
		private int? method_27(string string_1)
		{
			int value;
			if (int.TryParse(string_1, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00004B04 File Offset: 0x00002D04
		private void method_28(WatermarkTextBox watermarkTextBox_4, string string_1, bool bool_1)
		{
			if (bool_1)
			{
				watermarkTextBox_4.ApplyText(string_1);
				return;
			}
			watermarkTextBox_4.ApplyWatermark(string_1);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00026EB0 File Offset: 0x000250B0
		private void method_29(MCFindBlock.Class20 class20_2, string string_1, bool bool_1)
		{
			class20_2.nullable_0 = this.method_27(string_1);
			this.method_28(class20_2.watermarkTextBox_0, string_1, bool_1);
			if (bool_1 && class20_2.nullable_0 != null)
			{
				this.method_30(class20_2, this.method_7(class20_2.nullable_0.Value), false);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00026F04 File Offset: 0x00025104
		private void method_30(MCFindBlock.Class20 class20_2, string string_1, bool bool_1)
		{
			class20_2.AmvrWymlkA = this.method_27(string_1);
			this.method_28(class20_2.watermarkTextBox_1, string_1, bool_1);
			if (bool_1 && class20_2.AmvrWymlkA != null)
			{
				this.method_29(class20_2, this.method_3(class20_2.AmvrWymlkA.Value), false);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004B18 File Offset: 0x00002D18
		private void method_31()
		{
			if (this.class20_0.nullable_0 == null || this.class20_1.nullable_0 == null)
			{
				this.button_0.Enabled = false;
				return;
			}
			this.button_0.Enabled = true;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00026F58 File Offset: 0x00025158
		private void watermarkTextBox_3_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_3.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_29(this.class20_0, this.watermarkTextBox_3.Text, true);
			this.bool_0 = false;
			this.method_31();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00026FB0 File Offset: 0x000251B0
		private void watermarkTextBox_2_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_2.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_29(this.class20_1, this.watermarkTextBox_2.Text, true);
			this.bool_0 = false;
			this.method_31();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00027008 File Offset: 0x00025208
		private void watermarkTextBox_1_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_1.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_30(this.class20_0, this.watermarkTextBox_1.Text, true);
			this.bool_0 = false;
			this.method_31();
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00027060 File Offset: 0x00025260
		private void watermarkTextBox_0_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.bool_0 || !int.TryParse(this.watermarkTextBox_0.Text, out num))
			{
				return;
			}
			this.bool_0 = true;
			this.method_30(this.class20_1, this.watermarkTextBox_0.Text, true);
			this.bool_0 = false;
			this.method_31();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000270B8 File Offset: 0x000252B8
		private void button_0_Click(object sender, EventArgs e)
		{
			MCFindBlock.FindBlockData findBlockData = new MCFindBlock.FindBlockData();
			int.TryParse(this.watermarkTextBox_3.Text, out findBlockData.x);
			int.TryParse(this.watermarkTextBox_2.Text, out findBlockData.z);
			findBlockData.region = this.string_0[this.comboBox_0.SelectedIndex];
			TreeNode treeNode = this.method_32(findBlockData);
			if (treeNode != null)
			{
				this.treeNode_0 = treeNode;
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			MessageBox.Show("Chunk was not found!", "Chunk not found!");
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00027144 File Offset: 0x00025344
		private TreeNode method_32(MCFindBlock.FindBlockData findBlockData_0)
		{
			TreeNode result = null;
			if (findBlockData_0 != null)
			{
				result = this.chunkLookups.FindChunkNode(findBlockData_0.region, findBlockData_0.x, findBlockData_0.z);
			}
			return result;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004B57 File Offset: 0x00002D57
		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00004B66 File Offset: 0x00002D66
		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.watermarkTextBox_1.Focus();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00021F14 File Offset: 0x00020114
		private void MCFindBlock_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060004D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.MCFindBlock::MCFindBlock_Load(System.Object,System.EventArgs)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00027178 File Offset: 0x00025378
		private void method_33()
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
			this.button_0 = new Button();
			this.button_1 = new Button();
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
			this.button_0.Location = new Point(121, 141);
			this.button_0.Name = "_findButton";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Find Chunk";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(205, 141);
			this.button_1.Name = "_cancelButton";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Cancel";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
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
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(291, 173);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
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

		// Token: 0x040002FC RID: 764
		private bool bool_0;

		// Token: 0x040002FD RID: 765
		private MCFindBlock.Class20 class20_0;

		// Token: 0x040002FE RID: 766
		private MCFindBlock.Class20 class20_1;

		// Token: 0x040002FF RID: 767
		private TreeNode treeNode_0;

		// Token: 0x04000300 RID: 768
		private ChunkLookup chunkLookups;

		// Token: 0x04000301 RID: 769
		private string[] string_0 = new string[]
		{
			"region",
			"dim-1",
			"dim1"
		};

		// Token: 0x04000303 RID: 771
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04000304 RID: 772
		private GroupBox groupBox_0;

		// Token: 0x04000305 RID: 773
		private GroupBox groupBox_1;

		// Token: 0x04000306 RID: 774
		private Label label_0;

		// Token: 0x04000307 RID: 775
		private Label label_1;

		// Token: 0x04000308 RID: 776
		private WatermarkTextBox watermarkTextBox_0;

		// Token: 0x04000309 RID: 777
		private WatermarkTextBox watermarkTextBox_1;

		// Token: 0x0400030A RID: 778
		private Label label_2;

		// Token: 0x0400030B RID: 779
		private Label label_3;

		// Token: 0x0400030C RID: 780
		private WatermarkTextBox watermarkTextBox_2;

		// Token: 0x0400030D RID: 781
		private WatermarkTextBox watermarkTextBox_3;

		// Token: 0x0400030E RID: 782
		private Button button_0;

		// Token: 0x0400030F RID: 783
		private Button button_1;

		// Token: 0x04000310 RID: 784
		private ComboBox comboBox_0;

		// Token: 0x04000311 RID: 785
		private Label label_4;

		// Token: 0x02000078 RID: 120
		public class FindBlockData
		{
			// Token: 0x04000312 RID: 786
			public int x;

			// Token: 0x04000313 RID: 787
			public int z;

			// Token: 0x04000314 RID: 788
			public string region;
		}

		// Token: 0x02000079 RID: 121
		private class Class20
		{
			// Token: 0x04000315 RID: 789
			public int? nullable_0;

			// Token: 0x04000316 RID: 790
			public int? AmvrWymlkA;

			// Token: 0x04000317 RID: 791
			public WatermarkTextBox watermarkTextBox_0;

			// Token: 0x04000318 RID: 792
			public WatermarkTextBox watermarkTextBox_1;
		}
	}
}
