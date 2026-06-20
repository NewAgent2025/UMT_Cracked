using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace PS3FileSystem
{
	// Token: 0x02000014 RID: 20
	public class Ps3File
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000026DD File Offset: 0x000008DD
		public Ps3File(string filepath, Param_PFD.PFDEntry entry, Ps3SaveManager manager)
		{
			this.FilePath = filepath;
			this.PFDEntry = entry;
			this.Manager = manager;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000026FA File Offset: 0x000008FA
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002702 File Offset: 0x00000902
		public string FilePath { get; private set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000270B File Offset: 0x0000090B
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002713 File Offset: 0x00000913
		public Param_PFD.PFDEntry PFDEntry { get; private set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000271C File Offset: 0x0000091C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002724 File Offset: 0x00000924
		public Ps3SaveManager Manager { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000272D File Offset: 0x0000092D
		public bool IsEncrypted
		{
			get
			{
				return this.Manager.Param_PFD.ValidEntryHash(this.FilePath, false);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002746 File Offset: 0x00000946
		public bool Decypt()
		{
			return this.Manager.Param_PFD.Decrypt(this.FilePath);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000275E File Offset: 0x0000095E
		public byte[] DecryptToBytes()
		{
			return this.Manager.Param_PFD.DecryptToBytes(this.FilePath);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002776 File Offset: 0x00000976
		public Stream DecryptToStream()
		{
			return this.Manager.Param_PFD.DecryptToStream(this.FilePath);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000278E File Offset: 0x0000098E
		public bool Encrypt()
		{
			return this.Manager.Param_PFD.Encrypt(this.FilePath);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000027A6 File Offset: 0x000009A6
		public bool Encrypt(byte[] data)
		{
			return this.Manager.Param_PFD.Encrypt(data, this);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000027BA File Offset: 0x000009BA
		public byte[] EncryptToBytes()
		{
			return this.Manager.Param_PFD.EncryptToBytes(this.FilePath);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000027D2 File Offset: 0x000009D2
		public Stream EncryptToStream()
		{
			return this.Manager.Param_PFD.EncryptToStream(this.FilePath);
		}

		// Token: 0x04000050 RID: 80
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000051 RID: 81
		[CompilerGenerated]
		private Param_PFD.PFDEntry pfdentry_0;

		// Token: 0x04000052 RID: 82
		[CompilerGenerated]
		private Ps3SaveManager ps3SaveManager_0;
	}
}
