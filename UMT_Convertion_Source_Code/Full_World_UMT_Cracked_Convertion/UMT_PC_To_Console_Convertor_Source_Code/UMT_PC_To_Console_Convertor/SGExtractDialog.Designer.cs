namespace UMT_PC_To_Console_Convertor
{
	// Token: 0x020000C1 RID: 193
	public partial class SGExtractDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x000068CB File Offset: 0x00004ACB
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
				if (this.uiTimer != null)
				{
					this.uiTimer.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000524 RID: 1316
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000528 RID: 1320
		private global::System.Windows.Forms.Timer uiTimer;
	}
}
