using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000035 RID: 53
	public class ChunkButtonsFrame : UserControl
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000248 RID: 584 RVA: 0x000144E4 File Offset: 0x000126E4
		// (remove) Token: 0x06000249 RID: 585 RVA: 0x0001451C File Offset: 0x0001271C
		public event EventHandler BlockEditor
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

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600024A RID: 586 RVA: 0x00014554 File Offset: 0x00012754
		// (remove) Token: 0x0600024B RID: 587 RVA: 0x0001458C File Offset: 0x0001278C
		public event EventHandler BiomeEditor
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

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600024C RID: 588 RVA: 0x000145C4 File Offset: 0x000127C4
		// (remove) Token: 0x0600024D RID: 589 RVA: 0x000145FC File Offset: 0x000127FC
		public event EventHandler EntityEditor
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

		// Token: 0x0600024E RID: 590 RVA: 0x00003A1F File Offset: 0x00001C1F
		public ChunkButtonsFrame()
		{
			this.method_0();
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003A2D File Offset: 0x00001C2D
		protected virtual void OnBlockEditor()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00003A48 File Offset: 0x00001C48
		protected virtual void OnEntityEditor()
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003A63 File Offset: 0x00001C63
		protected virtual void OnBiomeEditor()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00003A7E File Offset: 0x00001C7E
		private void button_2_Click(object sender, EventArgs e)
		{
			this.OnBlockEditor();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00003A86 File Offset: 0x00001C86
		private void button_0_Click(object sender, EventArgs e)
		{
			this.OnBiomeEditor();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003A8E File Offset: 0x00001C8E
		private void button_1_Click(object sender, EventArgs e)
		{
			this.OnEntityEditor();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00003A96 File Offset: 0x00001C96
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00014634 File Offset: 0x00012834
		private void method_0()
		{
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.button_2 = new Button();
			base.SuspendLayout();
			this.button_0.BackColor = Color.LightGray;
			this.button_0.FlatStyle = FlatStyle.Popup;
			this.button_0.Location = new Point(4, 106);
			this.button_0.Name = "btnBiomeEditor";
			this.button_0.Size = new Size(64, 64);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Biomes";
			this.button_0.UseVisualStyleBackColor = false;
			this.button_0.Click += this.button_0_Click;
			this.button_1.BackColor = Color.LightGray;
			this.button_1.FlatStyle = FlatStyle.Popup;
			this.button_1.Location = new Point(4, 187);
			this.button_1.Name = "btnEntityEditor";
			this.button_1.Size = new Size(64, 64);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Entities";
			this.button_1.UseVisualStyleBackColor = false;
			this.button_1.Visible = false;
			this.button_1.Click += this.button_1_Click;
			this.button_2.BackColor = Color.LightGray;
			this.button_2.FlatStyle = FlatStyle.Popup;
			this.button_2.Location = new Point(4, 26);
			this.button_2.Name = "btnBlockEditor";
			this.button_2.Size = new Size(64, 64);
			this.button_2.TabIndex = 3;
			this.button_2.Text = "Blocks";
			this.button_2.UseVisualStyleBackColor = false;
			this.button_2.Click += this.button_2_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Gainsboro;
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Name = "ChunkButtonsFrame";
			base.Size = new Size(72, 470);
			base.ResumeLayout(false);
		}

		// Token: 0x0400015C RID: 348
		private EventHandler eventHandler_0;

		// Token: 0x0400015D RID: 349
		private EventHandler eventHandler_1;

		// Token: 0x0400015E RID: 350
		private EventHandler eventHandler_2;

		// Token: 0x0400015F RID: 351
		private IContainer icontainer_0;

		// Token: 0x04000160 RID: 352
		private Button button_0;

		// Token: 0x04000161 RID: 353
		private Button button_1;

		// Token: 0x04000162 RID: 354
		private Button button_2;
	}
}
