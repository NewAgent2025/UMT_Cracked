using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000050 RID: 80
	public class ReplaceBiomeConfig : UserControl
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00003E7D File Offset: 0x0000207D
		public List<BiomeChange> BiomeList
		{
			get
			{
				return this.list_0;
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003E85 File Offset: 0x00002085
		public ReplaceBiomeConfig()
		{
			this.method_3();
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0001A19C File Offset: 0x0001839C
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

		// Token: 0x06000307 RID: 775 RVA: 0x0001A1CC File Offset: 0x000183CC
		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			BiomeChange biomeChange_ = new BiomeChange();
			this.method_0(biomeChange_);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001A1E8 File Offset: 0x000183E8
		private void method_0(BiomeChange biomeChange_0)
		{
			BiomeReplace biomeReplace = new BiomeReplace();
			biomeReplace.BiomeChange = biomeChange_0;
			this.flowLayoutPanel_0.Controls.Add(biomeReplace);
			this.method_2();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001A21C File Offset: 0x0001841C
		private int method_1()
		{
			if (!this.flowLayoutPanel_0.VerticalScroll.Visible)
			{
				return this.flowLayoutPanel_0.Size.Width - 10;
			}
			return this.flowLayoutPanel_0.Size.Width - 30;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003E93 File Offset: 0x00002093
		private void ReplaceBiomeConfig_SizeChanged(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0001A268 File Offset: 0x00018468
		private void method_2()
		{
			int width = this.method_1();
			for (int i = 0; i < this.flowLayoutPanel_0.Controls.Count; i++)
			{
				BiomeReplace biomeReplace = this.flowLayoutPanel_0.Controls[i] as BiomeReplace;
				biomeReplace.Width = width;
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0001A2B8 File Offset: 0x000184B8
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

		// Token: 0x0600030D RID: 781 RVA: 0x0001A31C File Offset: 0x0001851C
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

		// Token: 0x0600030E RID: 782 RVA: 0x00003E9B File Offset: 0x0000209B
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (this.biomeReplace_0 != null)
			{
				this.flowLayoutPanel_0.Controls.Remove(this.biomeReplace_0);
				this.biomeReplace_0 = null;
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003EC2 File Offset: 0x000020C2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001A368 File Offset: 0x00018568
		private void method_3()
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

		// Token: 0x040001E2 RID: 482
		private List<BiomeChange> list_0;

		// Token: 0x040001E3 RID: 483
		private BiomeReplace biomeReplace_0;

		// Token: 0x040001E4 RID: 484
		private IContainer icontainer_0;

		// Token: 0x040001E5 RID: 485
		private MenuStrip menuStrip_0;

		// Token: 0x040001E6 RID: 486
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040001E7 RID: 487
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x040001E8 RID: 488
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x040001E9 RID: 489
		private FlowLayoutPanel flowLayoutPanel_0;
	}
}
