using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using NBTExplorer.Controllers;
using NBTExplorer.Model;
using NBTExplorer.Vendor.MultiSelectTreeView;
using NBTExplorer.Windows;
using NBTModel.Interop;
using Substrate.Nbt;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000034 RID: 52
	public class NBTFrame : UserControl
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600020F RID: 527 RVA: 0x0001222C File Offset: 0x0001042C
		// (remove) Token: 0x06000210 RID: 528 RVA: 0x00012264 File Offset: 0x00010464
		public event EventHandler Event_0
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

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000211 RID: 529 RVA: 0x0001229C File Offset: 0x0001049C
		// (remove) Token: 0x06000212 RID: 530 RVA: 0x000122D4 File Offset: 0x000104D4
		public event EventHandler BlockEditor
		{
			add
			{
				EventHandler eventHandler = this.isCcbcfMyx;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.isCcbcfMyx, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.isCcbcfMyx;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.isCcbcfMyx, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000213 RID: 531 RVA: 0x0001230C File Offset: 0x0001050C
		// (remove) Token: 0x06000214 RID: 532 RVA: 0x00012344 File Offset: 0x00010544
		public event EventHandler MapEditor
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

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000215 RID: 533 RVA: 0x0001237C File Offset: 0x0001057C
		// (remove) Token: 0x06000216 RID: 534 RVA: 0x000123B4 File Offset: 0x000105B4
		public event EventHandler BiomeEditor
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000037F0 File Offset: 0x000019F0
		public NodeTreeController Controller
		{
			get
			{
				return this.nodeTreeController_0;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000037F8 File Offset: 0x000019F8
		public NBTFrame()
		{
			this.method_6();
			if (ControlSupport.IsInRuntimeMode(this))
			{
				this.zTtuPfiKh2();
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000123EC File Offset: 0x000105EC
		private void zTtuPfiKh2()
		{
			FormHandlers.Register();
			NbtClipboardController.Initialize(new NbtClipboardControllerWin());
			this.nodeTreeController_0 = new NodeTreeController(this.multiSelectTreeView_0);
			this.nodeTreeController_0.SelectionInvalidated += this.nodeTreeController_0_SelectionInvalidated;
			this._buttonEdit.Click += this._buttonEdit_Click;
			this._buttonRename.Click += this._buttonRename_Click;
			this._buttonDelete.Click += this._buttonDelete_Click;
			this._buttonCopy.Click += this._buttonCopy_Click;
			this._buttonCut.Click += this._buttonCut_Click;
			this._buttonPaste.Click += this._buttonPaste_Click;
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripButton_10.Click += this.toolStripButton_10_Click;
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.toolStripButton_9.Click += this.toolStripButton_9_Click;
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_8.Click += this.toolStripButton_8_Click;
			this.toolStripButton_11.Click += this.toolStripButton_11_Click;
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003814 File Offset: 0x00001A14
		private void method_0(object sender, MessageBoxEventArgs e)
		{
			if (this.nodeTreeController_0.CheckModifications() && MessageBox.Show("You currently have unsaved changes.  " + e.Message, "Unsaved Changes", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003848 File Offset: 0x00001A48
		private void nodeTreeController_0_SelectionInvalidated(object sender, EventArgs e)
		{
			this.UpdateUI();
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003850 File Offset: 0x00001A50
		public void OpenExistingNode(DataNode node)
		{
			this.nodeTreeController_0.OpenExistingNode(node);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000385E File Offset: 0x00001A5E
		public DataNode GetExistingNode()
		{
			return this.nodeTreeController_0.GetExistingNode();
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000386B File Offset: 0x00001A6B
		private void _buttonEdit_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.EditSelection();
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00003878 File Offset: 0x00001A78
		private void _buttonRename_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.RenameSelection();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00003885 File Offset: 0x00001A85
		private void _buttonDelete_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.DeleteSelection();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00003892 File Offset: 0x00001A92
		private void _buttonCopy_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CopySelection();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000389F File Offset: 0x00001A9F
		private void _buttonCut_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CutSelection();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000038AC File Offset: 0x00001AAC
		private void _buttonPaste_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.PasteIntoSelection();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000038B9 File Offset: 0x00001AB9
		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_BYTE_ARRAY);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000038C7 File Offset: 0x00001AC7
		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_BYTE);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000038D5 File Offset: 0x00001AD5
		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_COMPOUND);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000038E4 File Offset: 0x00001AE4
		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_DOUBLE);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000038F2 File Offset: 0x00001AF2
		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_FLOAT);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00003900 File Offset: 0x00001B00
		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_INT);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000390E File Offset: 0x00001B0E
		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_INT_ARRAY);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000391D File Offset: 0x00001B1D
		private void toolStripButton_9_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_LIST);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000392C File Offset: 0x00001B2C
		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_LONG);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000393A File Offset: 0x00001B3A
		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_SHORT);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003948 File Offset: 0x00001B48
		private void toolStripButton_8_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CreateNode(TagType.TAG_STRING);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00003163 File Offset: 0x00001363
		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00003956 File Offset: 0x00001B56
		private void method_1(object sender, EventArgs e)
		{
			this.nodeTreeController_0.RefreshSelection();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000386B File Offset: 0x00001A6B
		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.EditSelection();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003878 File Offset: 0x00001A78
		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.RenameSelection();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00003885 File Offset: 0x00001A85
		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.DeleteSelection();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003892 File Offset: 0x00001A92
		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CopySelection();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000389F File Offset: 0x00001A9F
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.CutSelection();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000038AC File Offset: 0x00001AAC
		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.nodeTreeController_0.PasteIntoSelection();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003963 File Offset: 0x00001B63
		private void multiSelectTreeView_0_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.nodeTreeController_0.EditNode(e.Node);
			this.UpdateUI();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003848 File Offset: 0x00001A48
		private void multiSelectTreeView_0_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.UpdateUI();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00012658 File Offset: 0x00010858
		public void UpdateUI()
		{
			TreeNode selectedNode = this.multiSelectTreeView_0.SelectedNode;
			if (this.multiSelectTreeView_0.SelectedNodes.Count > 1)
			{
				this.method_5(this.multiSelectTreeView_0.SelectedNodes);
			}
			else if (selectedNode == null || !(selectedNode.Tag is DataNode))
			{
				this.method_2(new ToolStripButton[]
				{
					this.toolStripButton_0,
					this.toolStripButton_6,
					this.toolStripButton_10,
					this.toolStripButton_5,
					this.toolStripButton_4,
					this.toolStripButton_2,
					this.toolStripButton_7,
					this.toolStripButton_9,
					this.toolStripButton_3,
					this.toolStripButton_1,
					this.toolStripButton_8,
					this._buttonCopy,
					this._buttonCut,
					this._buttonDelete,
					this._buttonEdit,
					this._buttonPaste,
					this.toolStripButton_11,
					this._buttonRename
				});
				this.toolStripButton_11.Enabled = false;
				this.method_3(new ToolStripMenuItem[]
				{
					this.toolStripMenuItem_2,
					this.toolStripMenuItem_1,
					this.toolStripMenuItem_6,
					this.toolStripMenuItem_5,
					this.toolStripMenuItem_3,
					this.toolStripMenuItem_4,
					this.toolStripMenuItem_7,
					this.toolStripMenuItem_8
				});
			}
			else
			{
				this.method_4(selectedNode.Tag as DataNode);
			}
			this.vmethod_0();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000127E4 File Offset: 0x000109E4
		private void method_2(params ToolStripButton[] buttons)
		{
			foreach (ToolStripButton toolStripButton in buttons)
			{
				toolStripButton.Enabled = false;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001280C File Offset: 0x00010A0C
		private void method_3(params ToolStripMenuItem[] buttons)
		{
			foreach (ToolStripMenuItem toolStripMenuItem in buttons)
			{
				toolStripMenuItem.Enabled = false;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00012834 File Offset: 0x00010A34
		private void method_4(DataNode dataNode_0)
		{
			if (dataNode_0 == null)
			{
				return;
			}
			this.toolStripButton_0.Enabled = dataNode_0.CanCreateTag(TagType.TAG_BYTE);
			this.toolStripButton_6.Enabled = dataNode_0.CanCreateTag(TagType.TAG_BYTE_ARRAY);
			this.toolStripButton_10.Enabled = dataNode_0.CanCreateTag(TagType.TAG_COMPOUND);
			this.toolStripButton_5.Enabled = dataNode_0.CanCreateTag(TagType.TAG_DOUBLE);
			this.toolStripButton_4.Enabled = dataNode_0.CanCreateTag(TagType.TAG_FLOAT);
			this.toolStripButton_2.Enabled = dataNode_0.CanCreateTag(TagType.TAG_INT);
			this.toolStripButton_7.Enabled = dataNode_0.CanCreateTag(TagType.TAG_INT_ARRAY);
			this.toolStripButton_9.Enabled = dataNode_0.CanCreateTag(TagType.TAG_LIST);
			this.toolStripButton_3.Enabled = dataNode_0.CanCreateTag(TagType.TAG_LONG);
			this.toolStripButton_1.Enabled = dataNode_0.CanCreateTag(TagType.TAG_SHORT);
			this.toolStripButton_8.Enabled = dataNode_0.CanCreateTag(TagType.TAG_STRING);
			this._buttonCopy.Enabled = (dataNode_0.CanCopyNode && NbtClipboardController.IsInitialized);
			this._buttonCut.Enabled = (dataNode_0.CanCutNode && NbtClipboardController.IsInitialized);
			this._buttonDelete.Enabled = dataNode_0.CanDeleteNode;
			this._buttonEdit.Enabled = dataNode_0.CanEditNode;
			this._buttonPaste.Enabled = (dataNode_0.CanPasteIntoNode && NbtClipboardController.IsInitialized);
			this._buttonRename.Enabled = dataNode_0.CanRenameNode;
			this.toolStripButton_11.Enabled = dataNode_0.CanRefreshNode;
			this.toolStripMenuItem_2.Enabled = (dataNode_0.CanCopyNode && NbtClipboardController.IsInitialized);
			this.toolStripMenuItem_1.Enabled = (dataNode_0.CanCutNode && NbtClipboardController.IsInitialized);
			this.toolStripMenuItem_6.Enabled = dataNode_0.CanDeleteNode;
			this.toolStripMenuItem_5.Enabled = dataNode_0.CanEditNode;
			this.toolStripMenuItem_3.Enabled = (dataNode_0.CanPasteIntoNode && NbtClipboardController.IsInitialized);
			this.toolStripMenuItem_4.Enabled = dataNode_0.CanRenameNode;
			this.toolStripMenuItem_7.Enabled = dataNode_0.CanMoveNodeUp;
			this.toolStripMenuItem_8.Enabled = dataNode_0.CanMoveNodeDown;
			this.method_5(this.multiSelectTreeView_0.SelectedNodes);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00012A6C File Offset: 0x00010C6C
		private void method_5(IList<TreeNode> ilist_0)
		{
			if (ilist_0 == null)
			{
				return;
			}
			this.toolStripButton_0.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateByteNodePred));
			this.toolStripButton_1.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateShortNodePred));
			this.toolStripButton_2.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateIntNodePred));
			this.toolStripButton_3.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateLongNodePred));
			this.toolStripButton_4.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateFloatNodePred));
			this.toolStripButton_5.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateDoubleNodePred));
			this.toolStripButton_6.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateByteArrayNodePred));
			this.toolStripButton_7.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateIntArrayNodePred));
			this.toolStripButton_8.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateStringNodePred));
			this.toolStripButton_9.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateListNodePred));
			this.toolStripButton_10.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CreateCompoundNodePred));
			this._buttonRename.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.RenameNodePred));
			this._buttonEdit.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.EditNodePred));
			this._buttonDelete.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.DeleteNodePred));
			this._buttonCut.Enabled = (this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CutNodePred)) && NbtClipboardController.IsInitialized);
			this._buttonCopy.Enabled = (this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.CopyNodePred)) && NbtClipboardController.IsInitialized);
			this._buttonPaste.Enabled = (this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.PasteIntoNodePred)) && NbtClipboardController.IsInitialized);
			this.toolStripButton_11.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.RefreshNodePred));
			this.toolStripMenuItem_4.Enabled = this._buttonRename.Enabled;
			this.toolStripMenuItem_5.Enabled = this._buttonEdit.Enabled;
			this.toolStripMenuItem_6.Enabled = this._buttonDelete.Enabled;
			this.toolStripMenuItem_7.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.MoveNodeUpPred));
			this.toolStripMenuItem_8.Enabled = this.nodeTreeController_0.CanOperateOnSelection(new NodeTreeController.DataNodePredicate(NodeTreeController.Predicates.MoveNodeDownPred));
			this.toolStripMenuItem_1.Enabled = this._buttonCut.Enabled;
			this.toolStripMenuItem_2.Enabled = this._buttonCopy.Enabled;
			this.toolStripMenuItem_3.Enabled = this._buttonPaste.Enabled;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00012DC8 File Offset: 0x00010FC8
		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			TreeNode selectedNode = this.nodeTreeController_0.SelectedNode;
			this.toolStripMenuItem_10.Enabled = (selectedNode != null && selectedNode.Text.StartsWith("Blocks:"));
			this.toolStripMenuItem_12.Enabled = (selectedNode != null && selectedNode.Text.StartsWith("data:"));
			this.toolStripMenuItem_11.Enabled = (selectedNode != null && selectedNode.Text.StartsWith("Biomes:"));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000397C File Offset: 0x00001B7C
		private void toolStripMenuItem_10_Click(object sender, EventArgs e)
		{
			this.OnBlockEditor();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00003984 File Offset: 0x00001B84
		private void toolStripMenuItem_12_Click(object sender, EventArgs e)
		{
			this.OnMapEditor();
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000398C File Offset: 0x00001B8C
		private void toolStripMenuItem_11_Click(object sender, EventArgs e)
		{
			this.OnBiomeEditor();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003994 File Offset: 0x00001B94
		protected virtual void vmethod_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000039AF File Offset: 0x00001BAF
		protected virtual void OnBlockEditor()
		{
			if (this.isCcbcfMyx != null)
			{
				this.isCcbcfMyx(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000039CA File Offset: 0x00001BCA
		protected virtual void OnMapEditor()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000039E5 File Offset: 0x00001BE5
		protected virtual void OnBiomeEditor()
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003A00 File Offset: 0x00001C00
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00012E50 File Offset: 0x00011050
		private void method_6()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NBTFrame));
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.multiSelectTreeView_0 = new MultiSelectTreeView();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripSeparator_5 = new ToolStripSeparator();
			this.toolStripMenuItem_10 = new ToolStripMenuItem();
			this.toolStripMenuItem_11 = new ToolStripMenuItem();
			this.toolStripMenuItem_12 = new ToolStripMenuItem();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.toolStrip_0 = new ToolStrip();
			this._buttonCut = new ToolStripButton();
			this._buttonCopy = new ToolStripButton();
			this._buttonPaste = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this._buttonRename = new ToolStripButton();
			this._buttonEdit = new ToolStripButton();
			this._buttonDelete = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripButton_7 = new ToolStripButton();
			this.toolStripButton_8 = new ToolStripButton();
			this.toolStripButton_9 = new ToolStripButton();
			this.toolStripButton_10 = new ToolStripButton();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripButton_11 = new ToolStripButton();
			this.menuStrip_0 = new MenuStrip();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripSeparator_3 = new ToolStripSeparator();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripSeparator_4 = new ToolStripSeparator();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.tableLayoutPanel_0.SuspendLayout();
			this.contextMenuStrip_0.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			this.menuStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 1;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Controls.Add(this.multiSelectTreeView_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(534, 511);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.multiSelectTreeView_0.BorderStyle = BorderStyle.None;
			this.multiSelectTreeView_0.ContextMenuStrip = this.contextMenuStrip_0;
			this.multiSelectTreeView_0.Dock = DockStyle.Fill;
			this.multiSelectTreeView_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.multiSelectTreeView_0.ImageIndex = 0;
			this.multiSelectTreeView_0.ImageList = this.imageList_0;
			this.multiSelectTreeView_0.Location = new Point(3, 28);
			this.multiSelectTreeView_0.Name = "tvNBTEdit";
			this.multiSelectTreeView_0.SelectedImageIndex = 0;
			this.multiSelectTreeView_0.SelectedNodes = (List<TreeNode>)componentResourceManager.GetObject("tvNBTEdit.SelectedNodes");
			this.multiSelectTreeView_0.Size = new Size(528, 480);
			this.multiSelectTreeView_0.TabIndex = 7;
			this.multiSelectTreeView_0.NodeMouseClick += this.multiSelectTreeView_0_NodeMouseClick;
			this.multiSelectTreeView_0.NodeMouseDoubleClick += this.multiSelectTreeView_0_NodeMouseDoubleClick;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_9,
				this.toolStripSeparator_5,
				this.toolStripMenuItem_10,
				this.toolStripMenuItem_11,
				this.toolStripMenuItem_12
			});
			this.contextMenuStrip_0.Name = "cmsNBTEdit";
			this.contextMenuStrip_0.Size = new Size(159, 98);
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripMenuItem_9.Enabled = false;
			this.toolStripMenuItem_9.Name = "inventoryToolStripMenuItem";
			this.toolStripMenuItem_9.Size = new Size(158, 22);
			this.toolStripMenuItem_9.Text = "Inventory Editor";
			this.toolStripMenuItem_9.Visible = false;
			this.toolStripSeparator_5.Name = "toolStripMenuItem7";
			this.toolStripSeparator_5.Size = new Size(155, 6);
			this.toolStripSeparator_5.Visible = false;
			this.toolStripMenuItem_10.Name = "mnuBlockEditor";
			this.toolStripMenuItem_10.Size = new Size(158, 22);
			this.toolStripMenuItem_10.Text = "Block Editor";
			this.toolStripMenuItem_10.Click += this.toolStripMenuItem_10_Click;
			this.toolStripMenuItem_11.Name = "mnuBiomeEditor";
			this.toolStripMenuItem_11.Size = new Size(158, 22);
			this.toolStripMenuItem_11.Text = "Biome Editor";
			this.toolStripMenuItem_11.Click += this.toolStripMenuItem_11_Click;
			this.toolStripMenuItem_12.Name = "mnuMapManager";
			this.toolStripMenuItem_12.Size = new Size(158, 22);
			this.toolStripMenuItem_12.Text = "Map Manager";
			this.toolStripMenuItem_12.Click += this.toolStripMenuItem_12_Click;
			this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList_0.TransparentColor = Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "document-attribute-b.png");
			this.imageList_0.Images.SetKeyName(1, "document-attribute-s.png");
			this.imageList_0.Images.SetKeyName(2, "document-attribute-i.png");
			this.imageList_0.Images.SetKeyName(3, "document-attribute-l.png");
			this.imageList_0.Images.SetKeyName(4, "document-attribute-f.png");
			this.imageList_0.Images.SetKeyName(5, "document-attribute-d.png");
			this.imageList_0.Images.SetKeyName(6, "edit-code.png");
			this.imageList_0.Images.SetKeyName(7, "edit-small-caps.png");
			this.imageList_0.Images.SetKeyName(8, "edit-list.png");
			this.imageList_0.Images.SetKeyName(9, "box.png");
			this.imageList_0.Images.SetKeyName(10, "folder.png");
			this.imageList_0.Images.SetKeyName(11, "block.png");
			this.imageList_0.Images.SetKeyName(12, "wooden-box.png");
			this.imageList_0.Images.SetKeyName(13, "map.png");
			this.imageList_0.Images.SetKeyName(14, "edit-code-i.png");
			this.imageList_0.Images.SetKeyName(15, "question-white.png");
			this.toolStrip_0.AutoSize = false;
			this.toolStrip_0.Dock = DockStyle.Bottom;
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this._buttonCut,
				this._buttonCopy,
				this._buttonPaste,
				this.toolStripSeparator_0,
				this._buttonRename,
				this._buttonEdit,
				this._buttonDelete,
				this.toolStripSeparator_1,
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripButton_5,
				this.toolStripButton_6,
				this.toolStripButton_7,
				this.toolStripButton_8,
				this.toolStripButton_9,
				this.toolStripButton_10,
				this.toolStripSeparator_2,
				this.toolStripButton_11
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Margin = new Padding(0, 0, 0, 4);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Padding = new Padding(10, 0, 1, 0);
			this.toolStrip_0.Size = new Size(534, 21);
			this.toolStrip_0.Stretch = true;
			this.toolStrip_0.TabIndex = 6;
			this._buttonCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._buttonCut.Image = (Image)componentResourceManager.GetObject("_buttonCut.Image");
			this._buttonCut.ImageTransparentColor = Color.Magenta;
			this._buttonCut.Name = "_buttonCut";
			this._buttonCut.Size = new Size(23, 18);
			this._buttonCut.Text = "Cut";
			this._buttonCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._buttonCopy.Image = (Image)componentResourceManager.GetObject("_buttonCopy.Image");
			this._buttonCopy.ImageTransparentColor = Color.Magenta;
			this._buttonCopy.Name = "_buttonCopy";
			this._buttonCopy.Size = new Size(23, 18);
			this._buttonCopy.Text = "Copy";
			this._buttonPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._buttonPaste.Image = (Image)componentResourceManager.GetObject("_buttonPaste.Image");
			this._buttonPaste.ImageTransparentColor = Color.Magenta;
			this._buttonPaste.Name = "_buttonPaste";
			this._buttonPaste.Size = new Size(23, 18);
			this._buttonPaste.Text = "Paste";
			this.toolStripSeparator_0.Name = "toolStripSeparator6";
			this.toolStripSeparator_0.Size = new Size(6, 21);
			this._buttonRename.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._buttonRename.Image = (Image)componentResourceManager.GetObject("_buttonRename.Image");
			this._buttonRename.ImageTransparentColor = Color.Magenta;
			this._buttonRename.Name = "_buttonRename";
			this._buttonRename.Size = new Size(23, 18);
			this._buttonRename.Text = "Rename Tag";
			this._buttonEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._buttonEdit.Image = (Image)componentResourceManager.GetObject("_buttonEdit.Image");
			this._buttonEdit.ImageTransparentColor = Color.Magenta;
			this._buttonEdit.Name = "_buttonEdit";
			this._buttonEdit.Size = new Size(23, 18);
			this._buttonEdit.Text = "Edit Tag Value";
			this._buttonDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._buttonDelete.Image = (Image)componentResourceManager.GetObject("_buttonDelete.Image");
			this._buttonDelete.ImageTransparentColor = Color.Magenta;
			this._buttonDelete.Name = "_buttonDelete";
			this._buttonDelete.Size = new Size(23, 18);
			this._buttonDelete.Text = "Delete Tag";
			this.toolStripSeparator_1.Name = "toolStripSeparator2";
			this.toolStripSeparator_1.Size = new Size(6, 21);
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("_buttonAddTagByte.Image");
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "_buttonAddTagByte";
			this.toolStripButton_0.Size = new Size(23, 18);
			this.toolStripButton_0.Text = "Add Byte Tag";
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("_buttonAddTagShort.Image");
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "_buttonAddTagShort";
			this.toolStripButton_1.Size = new Size(23, 18);
			this.toolStripButton_1.Text = "Add Short Tag";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("_buttonAddTagInt.Image");
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "_buttonAddTagInt";
			this.toolStripButton_2.Size = new Size(23, 18);
			this.toolStripButton_2.Text = "Add Int Tag";
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = (Image)componentResourceManager.GetObject("_buttonAddTagLong.Image");
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "_buttonAddTagLong";
			this.toolStripButton_3.Size = new Size(23, 18);
			this.toolStripButton_3.Text = "Add Long Tag";
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = (Image)componentResourceManager.GetObject("_buttonAddTagFloat.Image");
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "_buttonAddTagFloat";
			this.toolStripButton_4.Size = new Size(23, 18);
			this.toolStripButton_4.Text = "Add Float Tag";
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = (Image)componentResourceManager.GetObject("_buttonAddTagDouble.Image");
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "_buttonAddTagDouble";
			this.toolStripButton_5.Size = new Size(23, 18);
			this.toolStripButton_5.Text = "Add Double Tag";
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = (Image)componentResourceManager.GetObject("_buttonAddTagByteArray.Image");
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "_buttonAddTagByteArray";
			this.toolStripButton_6.Size = new Size(23, 18);
			this.toolStripButton_6.Text = "Add Byte Array Tag";
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = (Image)componentResourceManager.GetObject("_buttonAddTagIntArray.Image");
			this.toolStripButton_7.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "_buttonAddTagIntArray";
			this.toolStripButton_7.Size = new Size(23, 18);
			this.toolStripButton_7.Text = "Add Int Array Tag";
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = (Image)componentResourceManager.GetObject("_buttonAddTagString.Image");
			this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_8.Name = "_buttonAddTagString";
			this.toolStripButton_8.Size = new Size(23, 18);
			this.toolStripButton_8.Text = "Add String Tag";
			this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_9.Image = (Image)componentResourceManager.GetObject("_buttonAddTagList.Image");
			this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_9.Name = "_buttonAddTagList";
			this.toolStripButton_9.Size = new Size(23, 18);
			this.toolStripButton_9.Text = "Add List Tag";
			this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_10.Image = (Image)componentResourceManager.GetObject("_buttonAddTagCompound.Image");
			this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_10.Name = "_buttonAddTagCompound";
			this.toolStripButton_10.Size = new Size(23, 18);
			this.toolStripButton_10.Text = "Add Compound Tag";
			this.toolStripSeparator_2.Name = "toolStripSeparator1";
			this.toolStripSeparator_2.Size = new Size(6, 21);
			this.toolStripSeparator_2.Visible = false;
			this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_11.Image = (Image)componentResourceManager.GetObject("_buttonFindNext.Image");
			this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_11.Name = "_buttonFindNext";
			this.toolStripButton_11.Size = new Size(23, 18);
			this.toolStripButton_11.Text = "Find / Find Next";
			this.toolStripButton_11.Visible = false;
			this.menuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0
			});
			this.menuStrip_0.Location = new Point(0, 0);
			this.menuStrip_0.Name = "menuStrip1";
			this.menuStrip_0.Size = new Size(600, 24);
			this.menuStrip_0.TabIndex = 1;
			this.menuStrip_0.Text = "menuStrip1";
			this.menuStrip_0.Visible = false;
			this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2,
				this.toolStripMenuItem_3,
				this.toolStripSeparator_3,
				this.toolStripMenuItem_4,
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_6,
				this.toolStripSeparator_4,
				this.toolStripMenuItem_7,
				this.toolStripMenuItem_8
			});
			this.toolStripMenuItem_0.Name = "editToolStripMenuItem";
			this.toolStripMenuItem_0.ShortcutKeys = (Keys.RButton | Keys.MButton | Keys.Space | Keys.Control);
			this.toolStripMenuItem_0.Size = new Size(39, 20);
			this.toolStripMenuItem_0.Text = "&Edit";
			this.toolStripMenuItem_1.Image = (Image)componentResourceManager.GetObject("_menuItemCut.Image");
			this.toolStripMenuItem_1.Name = "_menuItemCut";
			this.toolStripMenuItem_1.ShortcutKeys = (Keys)131160;
			this.toolStripMenuItem_1.Size = new Size(203, 22);
			this.toolStripMenuItem_1.Text = "Cu&t";
			this.toolStripMenuItem_2.Image = (Image)componentResourceManager.GetObject("_menuItemCopy.Image");
			this.toolStripMenuItem_2.Name = "_menuItemCopy";
			this.toolStripMenuItem_2.ShortcutKeys = (Keys)131139;
			this.toolStripMenuItem_2.Size = new Size(203, 22);
			this.toolStripMenuItem_2.Text = "&Copy";
			this.toolStripMenuItem_3.Image = (Image)componentResourceManager.GetObject("_menuItemPaste.Image");
			this.toolStripMenuItem_3.Name = "_menuItemPaste";
			this.toolStripMenuItem_3.ShortcutKeys = (Keys)131158;
			this.toolStripMenuItem_3.Size = new Size(203, 22);
			this.toolStripMenuItem_3.Text = "&Paste";
			this.toolStripSeparator_3.Name = "toolStripSeparator7";
			this.toolStripSeparator_3.Size = new Size(200, 6);
			this.toolStripMenuItem_4.Image = (Image)componentResourceManager.GetObject("_menuItemRename.Image");
			this.toolStripMenuItem_4.Name = "_menuItemRename";
			this.toolStripMenuItem_4.ShortcutKeys = (Keys)131154;
			this.toolStripMenuItem_4.Size = new Size(203, 22);
			this.toolStripMenuItem_4.Text = "&Rename";
			this.toolStripMenuItem_5.Image = (Image)componentResourceManager.GetObject("_menuItemEditValue.Image");
			this.toolStripMenuItem_5.Name = "_menuItemEditValue";
			this.toolStripMenuItem_5.ShortcutKeys = (Keys)131141;
			this.toolStripMenuItem_5.Size = new Size(203, 22);
			this.toolStripMenuItem_5.Text = "&Edit Value";
			this.toolStripMenuItem_6.Image = (Image)componentResourceManager.GetObject("_menuItemDelete.Image");
			this.toolStripMenuItem_6.Name = "_menuItemDelete";
			this.toolStripMenuItem_6.ShortcutKeys = Keys.Delete;
			this.toolStripMenuItem_6.Size = new Size(203, 22);
			this.toolStripMenuItem_6.Text = "&Delete";
			this.toolStripSeparator_4.Name = "toolStripSeparator10";
			this.toolStripSeparator_4.Size = new Size(200, 6);
			this.toolStripMenuItem_7.Image = (Image)componentResourceManager.GetObject("_menuItemMoveUp.Image");
			this.toolStripMenuItem_7.Name = "_menuItemMoveUp";
			this.toolStripMenuItem_7.ShortcutKeys = (Keys.RButton | Keys.MButton | Keys.Space | Keys.Control);
			this.toolStripMenuItem_7.Size = new Size(203, 22);
			this.toolStripMenuItem_7.Text = "Move &Up";
			this.toolStripMenuItem_8.Image = (Image)componentResourceManager.GetObject("_menuItemMoveDown.Image");
			this.toolStripMenuItem_8.Name = "_menuItemMoveDown";
			this.toolStripMenuItem_8.ShortcutKeys = (Keys.Back | Keys.Space | Keys.Control);
			this.toolStripMenuItem_8.Size = new Size(203, 22);
			this.toolStripMenuItem_8.Text = "Move Do&wn";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.menuStrip_0);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "NBTFrame";
			base.Size = new Size(534, 511);
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.contextMenuStrip_0.ResumeLayout(false);
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.menuStrip_0.ResumeLayout(false);
			this.menuStrip_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400012B RID: 299
		private EventHandler eventHandler_0;

		// Token: 0x0400012C RID: 300
		private EventHandler isCcbcfMyx;

		// Token: 0x0400012D RID: 301
		private EventHandler eventHandler_1;

		// Token: 0x0400012E RID: 302
		private EventHandler eventHandler_2;

		// Token: 0x0400012F RID: 303
		private NodeTreeController nodeTreeController_0;

		// Token: 0x04000130 RID: 304
		private IContainer icontainer_0;

		// Token: 0x04000131 RID: 305
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04000132 RID: 306
		private ToolStrip toolStrip_0;

		// Token: 0x04000133 RID: 307
		public ToolStripButton _buttonCut;

		// Token: 0x04000134 RID: 308
		public ToolStripButton _buttonCopy;

		// Token: 0x04000135 RID: 309
		public ToolStripButton _buttonPaste;

		// Token: 0x04000136 RID: 310
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04000137 RID: 311
		public ToolStripButton _buttonRename;

		// Token: 0x04000138 RID: 312
		public ToolStripButton _buttonEdit;

		// Token: 0x04000139 RID: 313
		public ToolStripButton _buttonDelete;

		// Token: 0x0400013A RID: 314
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x0400013B RID: 315
		private ToolStripButton toolStripButton_0;

		// Token: 0x0400013C RID: 316
		private ToolStripButton toolStripButton_1;

		// Token: 0x0400013D RID: 317
		private ToolStripButton toolStripButton_2;

		// Token: 0x0400013E RID: 318
		private ToolStripButton toolStripButton_3;

		// Token: 0x0400013F RID: 319
		private ToolStripButton toolStripButton_4;

		// Token: 0x04000140 RID: 320
		private ToolStripButton toolStripButton_5;

		// Token: 0x04000141 RID: 321
		private ToolStripButton toolStripButton_6;

		// Token: 0x04000142 RID: 322
		private ToolStripButton toolStripButton_7;

		// Token: 0x04000143 RID: 323
		private ToolStripButton toolStripButton_8;

		// Token: 0x04000144 RID: 324
		private ToolStripButton toolStripButton_9;

		// Token: 0x04000145 RID: 325
		private ToolStripButton toolStripButton_10;

		// Token: 0x04000146 RID: 326
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04000147 RID: 327
		private ToolStripButton toolStripButton_11;

		// Token: 0x04000148 RID: 328
		public MultiSelectTreeView multiSelectTreeView_0;

		// Token: 0x04000149 RID: 329
		private MenuStrip menuStrip_0;

		// Token: 0x0400014A RID: 330
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400014B RID: 331
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x0400014C RID: 332
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x0400014D RID: 333
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x0400014E RID: 334
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x0400014F RID: 335
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000150 RID: 336
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04000151 RID: 337
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04000152 RID: 338
		private ToolStripSeparator toolStripSeparator_4;

		// Token: 0x04000153 RID: 339
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04000154 RID: 340
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04000155 RID: 341
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000156 RID: 342
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x04000157 RID: 343
		private ToolStripSeparator toolStripSeparator_5;

		// Token: 0x04000158 RID: 344
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x04000159 RID: 345
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x0400015A RID: 346
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x0400015B RID: 347
		private ImageList imageList_0;
	}
}
