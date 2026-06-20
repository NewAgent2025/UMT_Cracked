using System;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x02000093 RID: 147
	[Serializable]
	public class MessageItem
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00005129 File Offset: 0x00003329
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00005131 File Offset: 0x00003331
		public string MessageId
		{
			get
			{
				return this.messageId;
			}
			set
			{
				this.messageId = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0000513A File Offset: 0x0000333A
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00005142 File Offset: 0x00003342
		public string Message
		{
			get
			{
				return this.message;
			}
			set
			{
				this.message = value;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002591 File Offset: 0x00000791
		public MessageItem()
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000514B File Offset: 0x0000334B
		public MessageItem(string messageId, string message)
		{
			this.messageId = messageId;
			this.message = message;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00005161 File Offset: 0x00003361
		public MessageItem Copy()
		{
			return new MessageItem(this.messageId, this.message);
		}

		// Token: 0x040003B6 RID: 950
		private string messageId;

		// Token: 0x040003B7 RID: 951
		private string message;
	}
}
