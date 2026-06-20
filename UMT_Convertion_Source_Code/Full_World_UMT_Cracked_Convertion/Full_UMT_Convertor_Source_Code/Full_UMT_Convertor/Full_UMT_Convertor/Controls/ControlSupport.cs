using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200003F RID: 63
	public class ControlSupport
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00003604 File Offset: 0x00001804
		public static bool IsInRuntimeMode(IComponent component)
		{
			return !ControlSupport.IsInDesignMode(component);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00014654 File Offset: 0x00012854
		public static bool IsInDesignMode(IComponent component)
		{
			bool result = false;
			if (component != null)
			{
				ISite site = component.Site;
				if (site != null)
				{
					result = site.DesignMode;
				}
				else if (component is Control)
				{
					IComponent parent = ((Control)component).Parent;
					result = ControlSupport.IsInDesignMode(parent);
				}
			}
			return result;
		}
	}
}
