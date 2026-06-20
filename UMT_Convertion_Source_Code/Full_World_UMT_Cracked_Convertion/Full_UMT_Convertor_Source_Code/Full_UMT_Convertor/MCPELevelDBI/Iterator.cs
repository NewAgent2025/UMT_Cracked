using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace MCPELevelDBI
{
	// Token: 0x0200010F RID: 271
	public class Iterator : LevelDBHandle
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00007D65 File Offset: 0x00005F65
		internal Iterator(IntPtr Handle)
		{
			base.Handle = Handle;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00007D74 File Offset: 0x00005F74
		public bool IsValid()
		{
			return LevelDBInterop.leveldb_iter_valid(base.Handle) != 0;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00007D87 File Offset: 0x00005F87
		public void SeekToFirst()
		{
			LevelDBInterop.leveldb_iter_seek_to_first(base.Handle);
			this.method_1();
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00007D9A File Offset: 0x00005F9A
		public void SeekToLast()
		{
			LevelDBInterop.leveldb_iter_seek_to_last(base.Handle);
			this.method_1();
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00007DAD File Offset: 0x00005FAD
		public void Seek(byte[] key)
		{
			LevelDBInterop.leveldb_iter_seek(base.Handle, key, key.Length);
			this.method_1();
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00007DC4 File Offset: 0x00005FC4
		public void Seek(string key)
		{
			this.Seek(Encoding.ASCII.GetBytes(key));
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00007DD7 File Offset: 0x00005FD7
		public void Seek(int key)
		{
			LevelDBInterop.leveldb_iter_seek(base.Handle, ref key, 4);
			this.method_1();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00007DED File Offset: 0x00005FED
		public void Next()
		{
			LevelDBInterop.leveldb_iter_next(base.Handle);
			this.method_1();
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00007E00 File Offset: 0x00006000
		public void Prev()
		{
			LevelDBInterop.leveldb_iter_prev(base.Handle);
			this.method_1();
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000559B4 File Offset: 0x00053BB4
		public int KeyAsInt()
		{
			int num;
			IntPtr ptr = LevelDBInterop.leveldb_iter_key(base.Handle, out num);
			this.method_1();
			if (num != 4)
			{
				throw new Exception("Key is not an integer");
			}
			return Marshal.ReadInt32(ptr);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00007E13 File Offset: 0x00006013
		public string KeyAsString()
		{
			return Encoding.ASCII.GetString(this.Key());
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000559EC File Offset: 0x00053BEC
		public byte[] Key()
		{
			int num;
			IntPtr source = LevelDBInterop.leveldb_iter_key(base.Handle, out num);
			this.method_1();
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, num);
			return array;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00055A20 File Offset: 0x00053C20
		public int[] ValueAsInts()
		{
			int num;
			IntPtr source = LevelDBInterop.leveldb_iter_value(base.Handle, out num);
			this.method_1();
			int[] array = new int[num / 4];
			Marshal.Copy(source, array, 0, num / 4);
			return array;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00007E25 File Offset: 0x00006025
		public string ValueAsString()
		{
			return Encoding.ASCII.GetString(this.Value());
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00055A58 File Offset: 0x00053C58
		public byte[] Value()
		{
			int num;
			IntPtr source = LevelDBInterop.leveldb_iter_value(base.Handle, out num);
			this.method_1();
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, num);
			return array;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00007E37 File Offset: 0x00006037
		private void method_1()
		{
			if (Iterator.func_0 == null)
			{
				Iterator.func_0 = new Func<string, Exception>(Iterator.smethod_0);
			}
			this.method_2(Iterator.func_0);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00055A8C File Offset: 0x00053C8C
		private void method_2(Func<string, Exception> func_1)
		{
			IntPtr intPtr;
			LevelDBInterop.leveldb_iter_get_error(base.Handle, out intPtr);
			if (intPtr != IntPtr.Zero)
			{
				throw func_1(Marshal.PtrToStringAnsi(intPtr));
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00007E5C File Offset: 0x0000605C
		protected override void FreeUnManagedObjects()
		{
			LevelDBInterop.leveldb_iter_destroy(base.Handle);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00007E69 File Offset: 0x00006069
		[CompilerGenerated]
		private static Exception smethod_0(string string_0)
		{
			return new Exception(string_0);
		}

		// Token: 0x0400077F RID: 1919
		[CompilerGenerated]
		private static Func<string, Exception> func_0;
	}
}
