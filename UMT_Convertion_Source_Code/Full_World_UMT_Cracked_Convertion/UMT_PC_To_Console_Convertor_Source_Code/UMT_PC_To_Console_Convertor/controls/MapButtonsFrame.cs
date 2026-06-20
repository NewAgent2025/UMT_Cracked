using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000023 RID: 35
	public class MapButtonsFrame : UserControl
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000100 RID: 256 RVA: 0x0000BD8C File Offset: 0x00009F8C
		// (remove) Token: 0x06000101 RID: 257 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		public event EventHandler MapEditor
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

		// Token: 0x06000102 RID: 258 RVA: 0x00002D74 File Offset: 0x00000F74
		public MapButtonsFrame()
		{
			this.method_0();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002D82 File Offset: 0x00000F82
		protected virtual void OnMapEditor()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002D9D File Offset: 0x00000F9D
		private void button_0_Click(object sender, EventArgs e)
		{
			this.OnMapEditor();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002DA5 File Offset: 0x00000FA5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000BDFC File Offset: 0x00009FFC
		private void method_0()
		{
			this.button_0 = new Button();
			base.SuspendLayout();
			this.button_0.BackColor = Color.LightGray;
			this.button_0.FlatStyle = FlatStyle.Popup;
			this.button_0.Location = new Point(4, 26);
			this.button_0.Name = "btnMapManager";
			this.button_0.Size = new Size(64, 64);
			this.button_0.TabIndex = 3;
			this.button_0.Text = "Map";
			this.button_0.UseVisualStyleBackColor = false;
			this.button_0.Click += this.button_0_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Gainsboro;
			base.Controls.Add(this.button_0);
			base.Name = "MapButtonsFrame";
			base.Size = new Size(72, 470);
			base.ResumeLayout(false);
		}

		// Token: 0x0400009C RID: 156
		private EventHandler eventHandler_0;

		// Token: 0x0400009D RID: 157
		private IContainer icontainer_0;

		// Token: 0x0400009E RID: 158
		private Button button_0;
	}
}
