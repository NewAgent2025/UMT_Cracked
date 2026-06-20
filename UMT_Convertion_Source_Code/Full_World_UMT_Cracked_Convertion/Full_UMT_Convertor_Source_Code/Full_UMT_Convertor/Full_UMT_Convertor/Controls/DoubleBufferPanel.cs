using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000040 RID: 64
	public class DoubleBufferPanel : Panel
	{
		// Token: 0x06000237 RID: 567 RVA: 0x0000360F File Offset: 0x0000180F
		public DoubleBufferPanel()
		{
			this.DoubleBuffered = true;
			this.method_0();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003624 File Offset: 0x00001824
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000362D File Offset: 0x0000182D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000364C File Offset: 0x0000184C
		private void method_0()
		{
			this.icontainer_0 = new Container();
		}

		// Token: 0x04000164 RID: 356
		private IContainer icontainer_0;
	}
}
