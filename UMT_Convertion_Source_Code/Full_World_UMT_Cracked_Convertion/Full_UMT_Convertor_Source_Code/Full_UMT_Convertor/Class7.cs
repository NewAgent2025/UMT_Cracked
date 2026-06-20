using System;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.controls;

// Token: 0x0200003E RID: 62
internal class Class7 : ComboBox
{
	// Token: 0x06000232 RID: 562 RVA: 0x000035EE File Offset: 0x000017EE
	public Class7()
	{
		base.DrawMode = DrawMode.OwnerDrawFixed;
		base.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0001457C File Offset: 0x0001277C
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
