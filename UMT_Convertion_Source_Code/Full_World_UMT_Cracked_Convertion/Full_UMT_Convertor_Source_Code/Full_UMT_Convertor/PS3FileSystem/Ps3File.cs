using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace PS3FileSystem
{
	// Token: 0x02000015 RID: 21
	public class Ps3File
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002832 File Offset: 0x00000A32
		public Ps3File(string filepath, Param_PFD.PFDEntry entry, Ps3Save_Manager manager)
		{
			this.FilePath = filepath;
			this.PFDEntry = entry;
			this.Manager = manager;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000284F File Offset: 0x00000A4F
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002857 File Offset: 0x00000A57
		public string FilePath { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002860 File Offset: 0x00000A60
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002868 File Offset: 0x00000A68
		public Param_PFD.PFDEntry PFDEntry { get; private set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002871 File Offset: 0x00000A71
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002879 File Offset: 0x00000A79
		public Ps3Save_Manager Manager { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002882 File Offset: 0x00000A82
		public bool IsEncrypted
		{
			get
			{
				return this.Manager.Param_PFD.ValidEntryHash(this.FilePath, false);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000289B File Offset: 0x00000A9B
		public bool Decypt()
		{
			return this.Manager.Param_PFD.Decrypt(this.FilePath);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000028B3 File Offset: 0x00000AB3
		public byte[] DecryptToBytes()
		{
			return this.Manager.Param_PFD.DecryptToBytes(this.FilePath);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000028CB File Offset: 0x00000ACB
		public Stream DecryptToStream()
		{
			return this.Manager.Param_PFD.DecryptToStream(this.FilePath);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000028E3 File Offset: 0x00000AE3
		public bool Encrypt()
		{
			return this.Manager.Param_PFD.Encrypt(this.FilePath);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000028FB File Offset: 0x00000AFB
		public bool Encrypt(byte[] data)
		{
			return this.Manager.Param_PFD.Encrypt(data, this);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000290F File Offset: 0x00000B0F
		public byte[] EncryptToBytes()
		{
			return this.Manager.Param_PFD.EncryptToBytes(this.FilePath);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002927 File Offset: 0x00000B27
		public Stream EncryptToStream()
		{
			return this.Manager.Param_PFD.EncryptToStream(this.FilePath);
		}

		// Token: 0x0400005D RID: 93
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400005E RID: 94
		[CompilerGenerated]
		private Param_PFD.PFDEntry pfdentry_0;

		// Token: 0x0400005F RID: 95
		[CompilerGenerated]
		private Ps3Save_Manager ps3Save_Manager_0;
	}
}
