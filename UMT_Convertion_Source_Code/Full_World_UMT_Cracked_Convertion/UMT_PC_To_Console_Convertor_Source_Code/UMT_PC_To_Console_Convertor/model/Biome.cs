using System;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000081 RID: 129
	public class Biome
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x00005187 File Offset: 0x00003387
		public Biome()
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000519A File Offset: 0x0000339A
		public Biome(int id, string name, bool onConsole)
		{
			this.id = id;
			this.name = name;
			this.onConsole = onConsole;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000051C2 File Offset: 0x000033C2
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x000051CA File Offset: 0x000033CA
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x000051D3 File Offset: 0x000033D3
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x000051DB File Offset: 0x000033DB
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x000051E4 File Offset: 0x000033E4
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x000051EC File Offset: 0x000033EC
		public bool OnConsole
		{
			get
			{
				return this.onConsole;
			}
			set
			{
				this.onConsole = value;
			}
		}

		// Token: 0x040003A8 RID: 936
		private int id;

		// Token: 0x040003A9 RID: 937
		private string name = "";

		// Token: 0x040003AA RID: 938
		private bool onConsole;
	}
}
