using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Full_UMT_Convertor.Events;
using Full_UMT_Convertor.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.Controls
{
	// Token: 0x0200004E RID: 78
	public class MCWorldList : UserControl
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060002EF RID: 751 RVA: 0x00019A48 File Offset: 0x00017C48
		// (remove) Token: 0x060002F0 RID: 752 RVA: 0x00019A80 File Offset: 0x00017C80
		public event EventHandler WorldSelected
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

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060002F1 RID: 753 RVA: 0x00019AB8 File Offset: 0x00017CB8
		// (remove) Token: 0x060002F2 RID: 754 RVA: 0x00019AF0 File Offset: 0x00017CF0
		public event EventHandler CancelClick
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

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060002F3 RID: 755 RVA: 0x00019B28 File Offset: 0x00017D28
		// (remove) Token: 0x060002F4 RID: 756 RVA: 0x00019B60 File Offset: 0x00017D60
		public event EventHandler FolderClick
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

		// Token: 0x060002F5 RID: 757 RVA: 0x00003DDC File Offset: 0x00001FDC
		public MCWorldList()
		{
			this.method_0();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003DEA File Offset: 0x00001FEA
		public void SetDisplayType(GEnum0 displayType)
		{
			this.HnmaGoHhnX.Visible = (displayType == GEnum0.Destination);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00019B98 File Offset: 0x00017D98
		public void LoadWorldList()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string path = Utils.smethod_0();
			string[] directories = Directory.GetDirectories(path);
			foreach (string text in directories)
			{
				string fileName = Path.GetFileName(text);
				dictionary.Add(fileName, text);
			}
			this.bool_0 = true;
			this.listBox_0.DisplayMember = "Key";
			this.listBox_0.ValueMember = "Value";
			this.listBox_0.DataSource = new BindingSource(dictionary, null);
			this.listBox_0.SelectedIndex = -1;
			this.bool_0 = false;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00019C34 File Offset: 0x00017E34
		protected virtual void OnWorldSelected(object sender, PCWorldEventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00019C54 File Offset: 0x00017E54
		protected virtual void OnCancelClicked(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00019C74 File Offset: 0x00017E74
		protected virtual void OnFolderClicked(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_2;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003E01 File Offset: 0x00002001
		private void button_0_Click(object sender, EventArgs e)
		{
			this.OnFolderClicked(this, new EventArgs());
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003E0F File Offset: 0x0000200F
		private void cOkanNstEc(object sender, EventArgs e)
		{
			this.OnCancelClicked(this, new EventArgs());
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003E1D File Offset: 0x0000201D
		private void wpFaiJyRq1(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.OnWorldSelected(this, new PCWorldEventArgs(this.listBox_0.Text, this.listBox_0.SelectedValue.ToString()));
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00019C94 File Offset: 0x00017E94
		private void HnmaGoHhnX_Click(object sender, EventArgs e)
		{
			FolderNameEntry folderNameEntry = new FolderNameEntry();
			DialogResult dialogResult = folderNameEntry.ShowDialog(this);
			if (dialogResult == DialogResult.OK)
			{
				string folder = Utils.smethod_0() + "\\" + folderNameEntry.FolderName;
				this.OnWorldSelected(this, new PCWorldEventArgs(folderNameEntry.FolderName, folder));
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003E4E File Offset: 0x0000204E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00019CDC File Offset: 0x00017EDC
		private void method_0()
		{
			this.listBox_0 = new ListBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_0 = new Label();
			this.HnmaGoHhnX = new Button();
			base.SuspendLayout();
			this.listBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.listBox_0.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox_0.FormattingEnabled = true;
			this.listBox_0.IntegralHeight = false;
			this.listBox_0.ItemHeight = 18;
			this.listBox_0.Location = new Point(5, 24);
			this.listBox_0.Name = "lbWorldList";
			this.listBox_0.Size = new Size(382, 388);
			this.listBox_0.TabIndex = 0;
			this.listBox_0.SelectedIndexChanged += this.wpFaiJyRq1;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_0.Location = new Point(5, 417);
			this.button_0.Name = "btnPCFolder";
			this.button_0.Size = new Size(90, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Select Folder";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.Location = new Point(312, 417);
			this.button_1.Name = "btnCancelPCWorld";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Cancel";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.cOkanNstEc;
			this.label_0.AutoSize = true;
			this.label_0.Font = new Font("Arial Rounded MT Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.Location = new Point(5, 5);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(84, 17);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "PC Worlds";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.HnmaGoHhnX.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.HnmaGoHhnX.Location = new Point(101, 417);
			this.HnmaGoHhnX.Name = "btnNewFolder";
			this.HnmaGoHhnX.Size = new Size(90, 23);
			this.HnmaGoHhnX.TabIndex = 4;
			this.HnmaGoHhnX.Text = "New World";
			this.HnmaGoHhnX.UseVisualStyleBackColor = true;
			this.HnmaGoHhnX.Click += this.HnmaGoHhnX_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.Controls.Add(this.HnmaGoHhnX);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.listBox_0);
			base.Name = "MCWorldList";
			base.Size = new Size(392, 444);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001D8 RID: 472
		private bool bool_0;

		// Token: 0x040001D9 RID: 473
		private EventHandler eventHandler_0;

		// Token: 0x040001DA RID: 474
		private EventHandler eventHandler_1;

		// Token: 0x040001DB RID: 475
		private EventHandler eventHandler_2;

		// Token: 0x040001DC RID: 476
		private IContainer icontainer_0;

		// Token: 0x040001DD RID: 477
		private ListBox listBox_0;

		// Token: 0x040001DE RID: 478
		private Button button_0;

		// Token: 0x040001DF RID: 479
		private Button button_1;

		// Token: 0x040001E0 RID: 480
		private Label label_0;

		// Token: 0x040001E1 RID: 481
		private Button HnmaGoHhnX;
	}
}
