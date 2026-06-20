using System;
using System.Drawing;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.controls;

// Token: 0x02000025 RID: 37
internal class Class6 : ComboBox
{
	// Token: 0x0600013B RID: 315 RVA: 0x000030AE File Offset: 0x000012AE
	public Class6()
	{
		base.DrawMode = DrawMode.OwnerDrawFixed;
		base.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0000D07C File Offset: 0x0000B27C
	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		e.DrawBackground();
		e.DrawFocusRectangle();
		if (e.Index >= 0 && e.Index < base.Items.Count)
		{
			DropDownItem dropDownItem = (DropDownItem)base.Items[e.Index];
			e.Graphics.DrawImage(dropDownItem.Image, e.Bounds.Left, e.Bounds.Top);
			e.Graphics.DrawString(dropDownItem.Text, e.Font, new SolidBrush(e.ForeColor), (float)(e.Bounds.Left + dropDownItem.Image.Width), (float)(e.Bounds.Top + 2));
		}
		base.OnDrawItem(e);
	}
}
