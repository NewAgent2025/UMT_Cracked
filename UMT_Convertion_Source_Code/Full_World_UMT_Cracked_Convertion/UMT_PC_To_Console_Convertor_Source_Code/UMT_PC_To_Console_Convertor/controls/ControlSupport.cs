using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x02000026 RID: 38
	public class ControlSupport
	{
		// Token: 0x0600013D RID: 317 RVA: 0x000030C4 File Offset: 0x000012C4
		public static bool IsInRuntimeMode(IComponent component)
		{
			return !ControlSupport.IsInDesignMode(component);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000D154 File Offset: 0x0000B354
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
