using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200008B RID: 139
	public class NodeSearchcriterion
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000055BE File Offset: 0x000037BE
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x000055C6 File Offset: 0x000037C6
		public string Node
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000055CF File Offset: 0x000037CF
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x000055D7 File Offset: 0x000037D7
		public string Value
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x040003D8 RID: 984
		private string string_0 = "";

		// Token: 0x040003D9 RID: 985
		private string string_1 = "";
	}
}
