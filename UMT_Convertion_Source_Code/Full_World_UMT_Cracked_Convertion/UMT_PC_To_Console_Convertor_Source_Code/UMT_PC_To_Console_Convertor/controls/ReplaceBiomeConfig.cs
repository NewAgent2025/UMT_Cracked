using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000038 RID: 56
	public class ReplaceBiomeConfig : UserControl
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00003B78 File Offset: 0x00001D78
		public List<BiomeChange> BiomeList
		{
			get
			{
				return this.list_0;
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003B80 File Offset: 0x00001D80
		public ReplaceBiomeConfig()
		{
			this.method_2();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001542C File Offset: 0x0001362C
		public void DisplayBiomeChangeList(List<BiomeChange> biomeList)
		{
			if (biomeList != null)
			{
				for (int i = 0; i < biomeList.Count; i++)
				{
					this.method_0(biomeList[i]);
				}
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001545C File Offset: 0x0001365C
		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			BiomeChange biomeChange_ = new BiomeChange();
			this.method_0(biomeChange_);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00015478 File Offset: 0x00013678
		private void method_0(BiomeChange biomeChange_0)
		{
			BiomeReplace biomeReplace = new BiomeReplace();
			biomeReplace.BiomeChange = biomeChange_0;
			this.flowLayoutPanel_0.Controls.Add(biomeReplace);
			this.method_1();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000154AC File Offset: 0x000136AC
		private int RbxxPlemgO()
		{
			if (!this.flowLayoutPanel_0.VerticalScroll.Visible)
			{
				return this.flowLayoutPanel_0.Size.Width - 10;
			}
			return this.flowLayoutPanel_0.Size.Width - 30;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00003B8E File Offset: 0x00001D8E
		private void ReplaceBiomeConfig_SizeChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000154F8 File Offset: 0x000136F8
		private void method_1()
		{
			int width = this.RbxxPlemgO();
			for (int i = 0; i < this.flowLayoutPanel_0.Controls.Count; i++)
			{
				BiomeReplace biomeReplace = this.flowLayoutPanel_0.Controls[i] as BiomeReplace;
				biomeReplace.Width = width;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00015548 File Offset: 0x00013748
		public List<BiomeChange> BuildBiomeChangeList()
		{
			this.list_0 = new List<BiomeChange>();
			for (int i = 0; i < this.flowLayoutPanel_0.Controls.Count; i++)
			{
				BiomeReplace biomeReplace = this.flowLayoutPanel_0.Controls[i] as BiomeReplace;
				this.list_0.Add(biomeReplace.BiomeChange);
			}
			return this.list_0;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000155AC File Offset: 0x000137AC
		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			Point pt = this.flowLayoutPanel_0.PointToClient(Cursor.Position);
			BiomeReplace biomeReplace = this.flowLayoutPanel_0.GetChildAtPoint(pt) as BiomeReplace;
			if (biomeReplace == null)
			{
				this.biomeReplace_0 = null;
				e.Cancel = true;
				return;
			}
			this.biomeReplace_0 = biomeReplace;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00003B96 File Offset: 0x00001D96
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (this.biomeReplace_0 != null)
			{
				this.flowLayoutPanel_0.Controls.Remove(this.biomeReplace_0);
				this.biomeReplace_0 = null;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003BBD File Offset: 0x00001DBD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000155F8 File Offset: 0x000137F8
		private void method_2()
		{
			this.icontainer_0 = new Container();
			this.menuStrip_0 = new MenuStrip();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.flowLayoutPanel_0 = new FlowLayoutPanel();
			this.menuStrip_0.SuspendLayout();
			this.contextMenuStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0
			});
			this.menuStrip_0.Location = new Point(0, 0);
			this.menuStrip_0.Name = "menuStrip1";
			this.menuStrip_0.Size = new Size(692, 24);
			this.menuStrip_0.TabIndex = 1;
			this.menuStrip_0.Text = "menuStrip1";
			this.toolStripMenuItem_0.Name = "mnuAdd";
			this.toolStripMenuItem_0.Size = new Size(41, 20);
			this.toolStripMenuItem_0.Text = "Add";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1
			});
			this.contextMenuStrip_0.Name = "contextMenuStrip1";
			this.contextMenuStrip_0.Size = new Size(108, 26);
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripMenuItem_1.Name = "mnuDelete";
			this.toolStripMenuItem_1.Size = new Size(152, 22);
			this.toolStripMenuItem_1.Text = "Delete";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.flowLayoutPanel_0.AutoScroll = true;
			this.flowLayoutPanel_0.ContextMenuStrip = this.contextMenuStrip_0;
			this.flowLayoutPanel_0.Dock = DockStyle.Fill;
			this.flowLayoutPanel_0.FlowDirection = FlowDirection.TopDown;
			this.flowLayoutPanel_0.Location = new Point(0, 24);
			this.flowLayoutPanel_0.Name = "flpBiomesList";
			this.flowLayoutPanel_0.Size = new Size(692, 555);
			this.flowLayoutPanel_0.TabIndex = 5;
			this.flowLayoutPanel_0.WrapContents = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.flowLayoutPanel_0);
			base.Controls.Add(this.menuStrip_0);
			base.Name = "ReplaceBiomeConfig";
			base.Size = new Size(692, 579);
			base.SizeChanged += this.ReplaceBiomeConfig_SizeChanged;
			this.menuStrip_0.ResumeLayout(false);
			this.menuStrip_0.PerformLayout();
			this.contextMenuStrip_0.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000171 RID: 369
		private List<BiomeChange> list_0;

		// Token: 0x04000172 RID: 370
		private BiomeReplace biomeReplace_0;

		// Token: 0x04000173 RID: 371
		private IContainer icontainer_0;

		// Token: 0x04000174 RID: 372
		private MenuStrip menuStrip_0;

		// Token: 0x04000175 RID: 373
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000176 RID: 374
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000177 RID: 375
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000178 RID: 376
		private FlowLayoutPanel flowLayoutPanel_0;
	}
}
