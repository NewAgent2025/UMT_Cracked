using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.Properties;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000039 RID: 57
	public class ReplaceBlockConfig : UserControl
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00003BDC File Offset: 0x00001DDC
		public List<BlockChange> BlockList
		{
			get
			{
				return this.list_0;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003BEC File Offset: 0x00001DEC
		public ConvertType ConvertType
		{
			get
			{
				return this.convertType_0;
			}
			set
			{
				this.convertType_0 = value;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public ReplaceBlockConfig()
		{
			this.method_5();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003C03 File Offset: 0x00001E03
		public void SetReset(bool visible)
		{
			this.toolStripMenuItem_4.Visible = visible;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00015900 File Offset: 0x00013B00
		public void DisplayBlockChangeList(List<BlockChange> blockList)
		{
			this.listViewEx_0.Items.Clear();
			if (blockList != null)
			{
				for (int i = 0; i < blockList.Count; i++)
				{
					this.method_0(blockList[i]);
				}
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00015940 File Offset: 0x00013B40
		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			BlockChange blockChange_ = new BlockChange();
			ListViewItem listViewItem = this.method_0(blockChange_);
			this.method_1();
			listViewItem.Selected = true;
			this.method_3();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00015970 File Offset: 0x00013B70
		private ListViewItem method_0(BlockChange blockChange_0)
		{
			ListViewItem listViewItem = new ListViewItem();
			this.method_2(blockChange_0, listViewItem);
			this.listViewEx_0.Items.Add(listViewItem);
			return listViewItem;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000159A0 File Offset: 0x00013BA0
		private void method_1()
		{
			if (this.listViewEx_0.SelectedIndices.Count > 0)
			{
				for (int i = 0; i < this.listViewEx_0.SelectedIndices.Count; i++)
				{
					this.listViewEx_0.Items[this.listViewEx_0.SelectedIndices[i]].Selected = false;
				}
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00015A04 File Offset: 0x00013C04
		private void method_2(BlockChange blockChange_0, ListViewItem listViewItem_1)
		{
			for (int i = listViewItem_1.SubItems.Count; i < 6; i++)
			{
				listViewItem_1.SubItems.Add(string.Empty);
			}
			listViewItem_1.Text = Class29.smethod_1()[blockChange_0.FromBlock].IdName;
			listViewItem_1.SubItems[1].Text = (blockChange_0.FromData.Contains(-1) ? "No Value Check" : IntSringConverter.ConvertToString(blockChange_0.FromData.ToArray()));
			listViewItem_1.SubItems[2].Text = (blockChange_0.Layers.Contains(-1) ? "All Layers" : IntSringConverter.ConvertToString(blockChange_0.Layers.ToArray()));
			listViewItem_1.SubItems[3].Text = Class29.smethod_1()[blockChange_0.ToBlock].IdName;
			listViewItem_1.SubItems[4].Text = ((blockChange_0.ToData == -1) ? "From Data Value" : blockChange_0.ToData.ToString());
			listViewItem_1.SubItems[5].Text = ((blockChange_0.ToBlockLight == -1) ? "From Blocklight Value" : blockChange_0.ToBlockLight.ToString());
			listViewItem_1.Tag = blockChange_0;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00015B58 File Offset: 0x00013D58
		public List<BlockChange> BuildBlockChangeList()
		{
			List<BlockChange> list = new List<BlockChange>();
			for (int i = 0; i < this.listViewEx_0.Items.Count; i++)
			{
				BlockChange blockChange = this.listViewEx_0.Items[i].Tag as BlockChange;
				if (blockChange != null)
				{
					list.Add(blockChange);
				}
			}
			return list;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003C11 File Offset: 0x00001E11
		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			if (this.listViewEx_0.SelectedItems.Count == 0)
			{
				this.toolStripMenuItem_5.Visible = false;
				return;
			}
			this.toolStripMenuItem_5.Visible = true;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003C3E File Offset: 0x00001E3E
		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			if (this.listViewEx_0.SelectedItems.Count == 0)
			{
				return;
			}
			this.listViewEx_0.Items.Remove(this.listViewEx_0.SelectedItems[0]);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003C74 File Offset: 0x00001E74
		private void listViewEx_0_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.method_3();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00015BB0 File Offset: 0x00013DB0
		private void method_3()
		{
			/*
An exception occurred when decompiling this method (0600028F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.ReplaceBlockConfig::method_3()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00003C7C File Offset: 0x00001E7C
		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.listViewEx_0.Items.Clear();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00015C0C File Offset: 0x00013E0C
		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			List<BlockChange> blockList;
			if (this.convertType_0 == ConvertType.FROM_PC)
			{
				blockList = Utils.ConvertBlockReplaceString("3,3:4:5:6:7:8:9:10:11:12:13:14:15,3,0,-1*-1|186,-1,187,-1,-1*-1|187,-1,186,-1,-1*-1|191,-1,192,-1,-1*-1|192,-1,191,-1,-1*-1|10000,-1,0,0,-1*-1|");
			}
			else
			{
				blockList = Utils.ConvertBlockReplaceString("186,-1,187,-1,-1*-1|187,-1,186,-1,-1*-1|191,-1,192,-1,-1*-1|192,-1,191,-1,-1*-1|");
			}
			this.DisplayBlockChangeList(blockList);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003C8E File Offset: 0x00001E8E
		private void listViewEx_0_ItemDrag(object sender, ItemDragEventArgs e)
		{
			base.DoDragDrop(e.Item, DragDropEffects.Link);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003C9E File Offset: 0x00001E9E
		private void listViewEx_0_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00015C44 File Offset: 0x00013E44
		private void listViewEx_0_DragDrop(object sender, DragEventArgs e)
		{
			Point point = this.listViewEx_0.PointToClient(new Point(e.X, e.Y));
			ListViewItem itemAt = this.listViewEx_0.GetItemAt(point.X, point.Y);
			if (itemAt == null)
			{
				return;
			}
			Rectangle bounds = itemAt.GetBounds(ItemBoundsPortion.Entire);
			bool flag = point.Y < bounds.Top + bounds.Height / 2;
			if (this.listViewItem_0 != itemAt)
			{
				if (flag)
				{
					this.listViewEx_0.Items.Remove(this.listViewItem_0);
					this.listViewEx_0.Items.Insert(itemAt.Index, this.listViewItem_0);
				}
				else
				{
					this.listViewEx_0.Items.Remove(this.listViewItem_0);
					this.listViewEx_0.Items.Insert(itemAt.Index + 1, this.listViewItem_0);
				}
			}
			this.listViewItem_0 = null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00015D34 File Offset: 0x00013F34
		private void listViewEx_0_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.listViewItem_0 == null)
			{
				return;
			}
			this.Cursor = Cursors.Hand;
			int y = Math.Min(e.Y, this.listViewEx_0.Items[this.listViewEx_0.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1);
			ListViewItem itemAt = this.listViewEx_0.GetItemAt(0, y);
			if (itemAt == null)
			{
				return;
			}
			Rectangle bounds = itemAt.GetBounds(ItemBoundsPortion.Entire);
			if (e.Y < bounds.Top + bounds.Height / 2)
			{
				this.listViewEx_0.LineBefore = itemAt.Index;
				this.listViewEx_0.LineAfter = -1;
			}
			else
			{
				this.listViewEx_0.LineBefore = -1;
				this.listViewEx_0.LineAfter = itemAt.Index;
			}
			this.listViewEx_0.Invalidate();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003CA7 File Offset: 0x00001EA7
		private void listViewEx_0_MouseDown(object sender, MouseEventArgs e)
		{
			this.listViewItem_0 = this.listViewEx_0.GetItemAt(e.X, e.Y);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003CC6 File Offset: 0x00001EC6
		private void listViewEx_0_MouseUp(object sender, MouseEventArgs e)
		{
			ListViewEx listViewEx = this.listViewEx_0;
			this.listViewEx_0.LineBefore = -1;
			listViewEx.LineAfter = -1;
			this.listViewItem_0 = null;
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00015E10 File Offset: 0x00014010
		private void listViewEx_0_DragOver(object sender, DragEventArgs e)
		{
			if (this.listViewItem_0 == null)
			{
				return;
			}
			this.Cursor = Cursors.Hand;
			Math.Min(e.Y, this.listViewEx_0.Items[this.listViewEx_0.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1);
			Point point = this.listViewEx_0.PointToClient(new Point(e.X, e.Y));
			ListViewItem itemAt = this.listViewEx_0.GetItemAt(point.X, point.Y);
			if (itemAt == null)
			{
				return;
			}
			Rectangle bounds = itemAt.GetBounds(ItemBoundsPortion.Entire);
			if (point.Y < bounds.Top + bounds.Height / 2)
			{
				this.listViewEx_0.LineBefore = itemAt.Index;
				this.listViewEx_0.LineAfter = -1;
			}
			else
			{
				this.listViewEx_0.LineBefore = -1;
				this.listViewEx_0.LineAfter = itemAt.Index;
			}
			this.listViewEx_0.Invalidate();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00015F14 File Offset: 0x00014114
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (!this.method_4())
			{
				return;
			}
			string blockReplaceDefFolder = Utils.GetBlockReplaceDefFolder();
			string text = FileUtils.smethod_1(".brd", "*.brd Files (*.brd)|*.brd", blockReplaceDefFolder, "");
			if (!string.IsNullOrWhiteSpace(text) && text.ToLower().EndsWith(".brd"))
			{
				using (StreamReader streamReader = new StreamReader(text))
				{
					string blockReplaceString = streamReader.ReadToEnd();
					List<BlockChange> blockList = Utils.ConvertBlockReplaceString(blockReplaceString);
					this.DisplayBlockChangeList(blockList);
				}
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00015F9C File Offset: 0x0001419C
		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (!this.method_4())
			{
				return;
			}
			string blockReplaceDefFolder = Utils.GetBlockReplaceDefFolder();
			string text = FileUtils.smethod_3(".brd", "*.brd Files (*.brd)|*.brd", blockReplaceDefFolder, "");
			if (!string.IsNullOrWhiteSpace(text) && text.ToLower().EndsWith(".brd"))
			{
				List<BlockChange> blockChanges = this.BuildBlockChangeList();
				string value = Utils.CreateBlockReplaceString(blockChanges);
				using (StreamWriter streamWriter = new StreamWriter(text, false))
				{
					streamWriter.WriteLine(value);
				}
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00016028 File Offset: 0x00014228
		private bool method_4()
		{
			Settings settings = new Settings();
			string brdpath = settings.BRDPath;
			bool result = false;
			if (string.IsNullOrWhiteSpace(brdpath))
			{
				MessageBox.Show("Block Replacement Definition folder needs to be assigned." + Environment.NewLine + "Goto tools/options to set Block Replacement Definition folder.", "Setup Required");
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003CF2 File Offset: 0x00001EF2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00016070 File Offset: 0x00014270
		private void method_5()
		{
			this.icontainer_0 = new Container();
			this.menuStrip_0 = new MenuStrip();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.listViewEx_0 = new ListViewEx();
			this.columnHeader_0 = new ColumnHeader();
			this.columnHeader_1 = new ColumnHeader();
			this.columnHeader_2 = new ColumnHeader();
			this.columnHeader_3 = new ColumnHeader();
			this.columnHeader_4 = new ColumnHeader();
			this.columnHeader_5 = new ColumnHeader();
			this.menuStrip_0.SuspendLayout();
			this.contextMenuStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_4
			});
			this.menuStrip_0.Location = new Point(0, 0);
			this.menuStrip_0.Name = "menuStrip1";
			this.menuStrip_0.Size = new Size(813, 24);
			this.menuStrip_0.TabIndex = 1;
			this.menuStrip_0.Text = "menuStrip1";
			this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2
			});
			this.toolStripMenuItem_0.Name = "fileToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(37, 20);
			this.toolStripMenuItem_0.Text = "File";
			this.toolStripMenuItem_1.Name = "mnuBRDOpen";
			this.toolStripMenuItem_1.Size = new Size(103, 22);
			this.toolStripMenuItem_1.Text = "Open";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_2.Name = "mnuBRDSave";
			this.toolStripMenuItem_2.Size = new Size(103, 22);
			this.toolStripMenuItem_2.Text = "Save";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_3.Name = "mnuAdd";
			this.toolStripMenuItem_3.Size = new Size(41, 20);
			this.toolStripMenuItem_3.Text = "Add";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripMenuItem_4.Name = "mnuReset";
			this.toolStripMenuItem_4.Size = new Size(47, 20);
			this.toolStripMenuItem_4.Text = "Reset";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_6
			});
			this.contextMenuStrip_0.Name = "contextMenuStrip1";
			this.contextMenuStrip_0.Size = new Size(125, 48);
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripMenuItem_5.Name = "mnuDelete";
			this.toolStripMenuItem_5.Size = new Size(124, 22);
			this.toolStripMenuItem_5.Text = "Delete";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.toolStripMenuItem_6.Name = "mnuDeleteAll";
			this.toolStripMenuItem_6.Size = new Size(124, 22);
			this.toolStripMenuItem_6.Text = "Delete All";
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.listViewEx_0.AllowDrop = true;
			this.listViewEx_0.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4,
				this.columnHeader_5
			});
			this.listViewEx_0.ContextMenuStrip = this.contextMenuStrip_0;
			this.listViewEx_0.Dock = DockStyle.Fill;
			this.listViewEx_0.FullRowSelect = true;
			this.listViewEx_0.LineAfter = -1;
			this.listViewEx_0.LineBefore = -1;
			this.listViewEx_0.Location = new Point(0, 24);
			this.listViewEx_0.Name = "lvBlockList";
			this.listViewEx_0.Size = new Size(813, 360);
			this.listViewEx_0.TabIndex = 6;
			this.listViewEx_0.UseCompatibleStateImageBehavior = false;
			this.listViewEx_0.View = View.Details;
			this.listViewEx_0.ItemDrag += this.listViewEx_0_ItemDrag;
			this.listViewEx_0.DragDrop += this.listViewEx_0_DragDrop;
			this.listViewEx_0.DragEnter += this.listViewEx_0_DragEnter;
			this.listViewEx_0.DragOver += this.listViewEx_0_DragOver;
			this.listViewEx_0.MouseDoubleClick += this.listViewEx_0_MouseDoubleClick;
			this.listViewEx_0.MouseDown += this.listViewEx_0_MouseDown;
			this.listViewEx_0.MouseMove += this.listViewEx_0_MouseMove;
			this.listViewEx_0.MouseUp += this.listViewEx_0_MouseUp;
			this.columnHeader_0.Text = "From Block";
			this.columnHeader_0.Width = 180;
			this.columnHeader_1.Text = "From Data";
			this.columnHeader_1.Width = 100;
			this.columnHeader_2.Text = "Layer";
			this.columnHeader_2.Width = 100;
			this.columnHeader_3.Text = "To Block";
			this.columnHeader_3.Width = 180;
			this.columnHeader_4.Text = "To Data";
			this.columnHeader_4.Width = 100;
			this.columnHeader_5.Text = "To Blocklight";
			this.columnHeader_5.Width = 120;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.listViewEx_0);
			base.Controls.Add(this.menuStrip_0);
			base.Name = "ReplaceBlockConfig";
			base.Size = new Size(813, 384);
			this.menuStrip_0.ResumeLayout(false);
			this.menuStrip_0.PerformLayout();
			this.contextMenuStrip_0.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000179 RID: 377
		private List<BlockChange> list_0;

		// Token: 0x0400017A RID: 378
		private ConvertType convertType_0;

		// Token: 0x0400017B RID: 379
		private ListViewItem listViewItem_0;

		// Token: 0x0400017C RID: 380
		private IContainer icontainer_0;

		// Token: 0x0400017D RID: 381
		private MenuStrip menuStrip_0;

		// Token: 0x0400017E RID: 382
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400017F RID: 383
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000180 RID: 384
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000181 RID: 385
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000182 RID: 386
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000183 RID: 387
		private ListViewEx listViewEx_0;

		// Token: 0x04000184 RID: 388
		private ColumnHeader columnHeader_0;

		// Token: 0x04000185 RID: 389
		private ColumnHeader columnHeader_1;

		// Token: 0x04000186 RID: 390
		private ColumnHeader columnHeader_2;

		// Token: 0x04000187 RID: 391
		private ColumnHeader columnHeader_3;

		// Token: 0x04000188 RID: 392
		private ColumnHeader columnHeader_4;

		// Token: 0x04000189 RID: 393
		private ColumnHeader columnHeader_5;

		// Token: 0x0400018A RID: 394
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x0400018B RID: 395
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x0400018C RID: 396
		private ToolStripMenuItem toolStripMenuItem_6;
	}
}
