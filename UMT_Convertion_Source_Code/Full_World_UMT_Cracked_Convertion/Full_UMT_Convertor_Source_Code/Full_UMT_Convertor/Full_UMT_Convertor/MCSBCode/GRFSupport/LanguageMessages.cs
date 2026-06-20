using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x02000092 RID: 146
	public class LanguageMessages
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x000050F1 File Offset: 0x000032F1
		public LanguageMessages(string language, List<MessageItem> messages)
		{
			this.language = language;
			this.messages = messages;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00005107 File Offset: 0x00003307
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x0000510F File Offset: 0x0000330F
		public string Language
		{
			get
			{
				return this.language;
			}
			set
			{
				this.language = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00005118 File Offset: 0x00003318
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00005120 File Offset: 0x00003320
		internal List<MessageItem> Messages
		{
			get
			{
				return this.messages;
			}
			set
			{
				this.messages = value;
			}
		}

		// Token: 0x040003B4 RID: 948
		private string language;

		// Token: 0x040003B5 RID: 949
		private List<MessageItem> messages;
	}
}
