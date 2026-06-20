using System;
using System.Collections.Generic;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000BE RID: 190
	public class RunArgs
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00006735 File Offset: 0x00004935
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0000673D File Offset: 0x0000493D
		public string FilePath
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

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00006746 File Offset: 0x00004946
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0000674E File Offset: 0x0000494E
		public string FolderPath
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00006757 File Offset: 0x00004957
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0000675F File Offset: 0x0000495F
		public string PcPath
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00006768 File Offset: 0x00004968
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00006770 File Offset: 0x00004970
		public Dictionary<string, ModifiedFile> ModifiedFiles
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00006779 File Offset: 0x00004979
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00006781 File Offset: 0x00004981
		public ConvertParameters ConvertParameters
		{
			get
			{
				return this.convertParameters_0;
			}
			set
			{
				this.convertParameters_0 = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0000678A File Offset: 0x0000498A
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00006792 File Offset: 0x00004992
		public RunTypes RunType
		{
			get
			{
				return this.runTypes_0;
			}
			set
			{
				this.runTypes_0 = value;
			}
		}

		// Token: 0x04000514 RID: 1300
		private string string_0;

		// Token: 0x04000515 RID: 1301
		private string string_1;

		// Token: 0x04000516 RID: 1302
		private string string_2;

		// Token: 0x04000517 RID: 1303
		private Dictionary<string, ModifiedFile> dictionary_0;

		// Token: 0x04000518 RID: 1304
		private ConvertParameters convertParameters_0;

		// Token: 0x04000519 RID: 1305
		private RunTypes runTypes_0;
	}
}
