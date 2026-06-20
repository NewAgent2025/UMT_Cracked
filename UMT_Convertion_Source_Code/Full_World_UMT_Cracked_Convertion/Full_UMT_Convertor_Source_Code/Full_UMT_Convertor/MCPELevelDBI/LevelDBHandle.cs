using System;
using System.Runtime.CompilerServices;

namespace MCPELevelDBI
{
	// Token: 0x0200010E RID: 270
	public abstract class LevelDBHandle : IDisposable
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00007D11 File Offset: 0x00005F11
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00007D08 File Offset: 0x00005F08
		public IntPtr Handle { get; protected set; }

		// Token: 0x06000B63 RID: 2915 RVA: 0x00007D19 File Offset: 0x00005F19
		public void Dispose()
		{
			this.method_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00002BAE File Offset: 0x00000DAE
		protected virtual void FreeManagedObjects()
		{
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00002BAE File Offset: 0x00000DAE
		protected virtual void FreeUnManagedObjects()
		{
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00007D28 File Offset: 0x00005F28
		private void method_0(bool bool_1)
		{
			if (!this.bool_0)
			{
				if (bool_1)
				{
					this.FreeManagedObjects();
				}
				if (this.Handle != IntPtr.Zero)
				{
					this.FreeUnManagedObjects();
					this.Handle = IntPtr.Zero;
				}
				this.bool_0 = true;
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00055984 File Offset: 0x00053B84
		~LevelDBHandle()
		{
			this.method_0(false);
		}

		// Token: 0x0400077D RID: 1917
		private bool bool_0;

		// Token: 0x0400077E RID: 1918
		[CompilerGenerated]
		private IntPtr intptr_0;
	}
}
