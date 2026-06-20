using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MCPELevelDBI
{
	// Token: 0x02000110 RID: 272
	public class LevelDBInterop
	{
		// Token: 0x06000B7C RID: 2940 RVA: 0x00055AC0 File Offset: 0x00053CC0
		public static IntPtr leveldb_options_create()
		{
			IntPtr result;
			try
			{
				if (Environment.Is64BitProcess)
				{
					result = LevelDBInterop.leveldb_options_create_1();
				}
				else
				{
					result = LevelDBInterop.leveldb_options_create_2();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("World database failed to open. Verify C++ 2015 runtime is installed.", "Open LevelDB Failed");
				throw;
			}
			return result;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00007E71 File Offset: 0x00006071
		public static void leveldb_options_destroy(IntPtr options)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_options_destroy_1(options);
				return;
			}
			LevelDBInterop.leveldb_options_destroy_2(options);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00007E87 File Offset: 0x00006087
		public static void leveldb_options_set_create_if_missing(IntPtr options, byte o)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_options_set_create_if_missing_1(options, o);
				return;
			}
			LevelDBInterop.leveldb_options_set_create_if_missing_2(options, o);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00007E9F File Offset: 0x0000609F
		public static void leveldb_options_set_compression(IntPtr options, int compressionType)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_options_set_compression_1(options, compressionType);
				return;
			}
			LevelDBInterop.leveldb_options_set_compression_2(options, compressionType);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00007EB7 File Offset: 0x000060B7
		public static IntPtr leveldb_readoptions_create()
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_readoptions_create_1();
			}
			return LevelDBInterop.leveldb_readoptions_create_2();
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00007ECB File Offset: 0x000060CB
		public static void leveldb_readoptions_destroy(IntPtr options)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_readoptions_destroy_1(options);
				return;
			}
			LevelDBInterop.leveldb_readoptions_destroy_2(options);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00007EE1 File Offset: 0x000060E1
		public static void leveldb_readoptions_set_fill_cache(IntPtr options, byte o)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_readoptions_set_fill_cache_1(options, o);
				return;
			}
			LevelDBInterop.leveldb_readoptions_set_fill_cache_2(options, o);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00007EF9 File Offset: 0x000060F9
		public static IntPtr leveldb_writeoptions_create()
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_writeoptions_create_1();
			}
			return LevelDBInterop.leveldb_writeoptions_create_2();
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00007F0D File Offset: 0x0000610D
		public static void leveldb_writeoptions_destroy(IntPtr options)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_writeoptions_destroy_1(options);
				return;
			}
			LevelDBInterop.leveldb_writeoptions_destroy_2(options);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00007F23 File Offset: 0x00006123
		public static void leveldb_writeoptions_set_sync(IntPtr options, byte o)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_writeoptions_set_sync_1(options, o);
				return;
			}
			LevelDBInterop.leveldb_writeoptions_set_sync_2(options, 0);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00007F3B File Offset: 0x0000613B
		public static IntPtr leveldb_open(IntPtr options, string name, out IntPtr error)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_open_1(options, name, out error);
			}
			return LevelDBInterop.leveldb_open_2(options, name, out error);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00007F55 File Offset: 0x00006155
		public static void leveldb_close(IntPtr db)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_close_1(db);
				return;
			}
			LevelDBInterop.leveldb_close_2(db);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00007F6B File Offset: 0x0000616B
		public static IntPtr leveldb_get(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_get_1(db, options, key, keylen, out vallen, out errptr);
			}
			return LevelDBInterop.leveldb_get_4(db, options, key, keylen, out vallen, out errptr);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00007F8F File Offset: 0x0000618F
		public static IntPtr leveldb_get(IntPtr db, IntPtr options, ref int key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_get_2(db, options, ref key, keylen, out vallen, out errptr);
			}
			return LevelDBInterop.leveldb_get_5(db, options, ref key, keylen, out vallen, out errptr);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00007FB3 File Offset: 0x000061B3
		public static IntPtr leveldb_get(IntPtr db, IntPtr options, IntPtr key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_get_3(db, options, key, keylen, out vallen, out errptr);
			}
			return LevelDBInterop.leveldb_get_6(db, options, key, keylen, out vallen, out errptr);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00007FD7 File Offset: 0x000061D7
		public static void leveldb_put(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_put_1(db, options, key, keylen, val, vallen, out errptr);
				return;
			}
			LevelDBInterop.leveldb_put_3(db, options, key, keylen, val, vallen, out errptr);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00007FFF File Offset: 0x000061FF
		public static void leveldb_put(IntPtr db, IntPtr options, ref int key, IntPtr keylen, int[] val, IntPtr vallen, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_put_2(db, options, ref key, keylen, val, vallen, out errptr);
				return;
			}
			LevelDBInterop.leveldb_put_4(db, options, ref key, keylen, val, vallen, out errptr);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00008027 File Offset: 0x00006227
		public static void leveldb_delete(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_delete_1(db, options, key, keylen, out errptr);
				return;
			}
			LevelDBInterop.leveldb_delete_2(db, options, key, keylen, out errptr);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00008047 File Offset: 0x00006247
		public static void leveldb_free(IntPtr ptr)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_free_1(ptr);
				return;
			}
			LevelDBInterop.leveldb_free_2(ptr);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000805D File Offset: 0x0000625D
		public static IntPtr leveldb_create_iterator(IntPtr db, IntPtr options)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_create_iterator_1(db, options);
			}
			return LevelDBInterop.leveldb_create_iterator_2(db, options);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00008075 File Offset: 0x00006275
		public static void leveldb_iter_destroy(IntPtr iterator)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_destroy_1(iterator);
				return;
			}
			LevelDBInterop.leveldb_iter_destroy_2(iterator);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000808B File Offset: 0x0000628B
		public static byte leveldb_iter_valid(IntPtr iterator)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_iter_valid_1(iterator);
			}
			return LevelDBInterop.leveldb_iter_valid_2(iterator);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000080A1 File Offset: 0x000062A1
		public static void leveldb_iter_seek_to_first(IntPtr iterator)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_seek_to_first_1(iterator);
				return;
			}
			LevelDBInterop.leveldb_iter_seek_to_first_2(iterator);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000080B7 File Offset: 0x000062B7
		public static void leveldb_iter_seek_to_last(IntPtr iterator)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_seek_to_last_1(iterator);
				return;
			}
			LevelDBInterop.leveldb_iter_seek_to_last_2(iterator);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000080CD File Offset: 0x000062CD
		public static void leveldb_iter_seek(IntPtr iterator, byte[] key, int length)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_seek_1(iterator, key, length);
				return;
			}
			LevelDBInterop.leveldb_iter_seek_3(iterator, key, length);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000080E7 File Offset: 0x000062E7
		public static void leveldb_iter_seek(IntPtr iterator, ref int key, int length)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_seek_2(iterator, ref key, length);
				return;
			}
			LevelDBInterop.leveldb_iter_seek_4(iterator, ref key, length);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00008101 File Offset: 0x00006301
		public static void leveldb_iter_next(IntPtr iterator)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_next_1(iterator);
				return;
			}
			LevelDBInterop.leveldb_iter_next_2(iterator);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00008117 File Offset: 0x00006317
		public static void leveldb_iter_prev(IntPtr iterator)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_prev_1(iterator);
				return;
			}
			LevelDBInterop.leveldb_iter_prev_2(iterator);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0000812D File Offset: 0x0000632D
		public static IntPtr leveldb_iter_key(IntPtr iterator, out int length)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_iter_key_1(iterator, out length);
			}
			return LevelDBInterop.leveldb_iter_key_2(iterator, out length);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00008145 File Offset: 0x00006345
		public static IntPtr leveldb_iter_value(IntPtr iterator, out int length)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_iter_value_1(iterator, out length);
			}
			return LevelDBInterop.leveldb_iter_value_2(iterator, out length);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0000815D File Offset: 0x0000635D
		public static void leveldb_iter_get_error(IntPtr iterator, out IntPtr error)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_iter_get_error_1(iterator, out error);
				return;
			}
			LevelDBInterop.leveldb_iter_get_error_2(iterator, out error);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00008175 File Offset: 0x00006375
		public static IntPtr leveldb_compact_range(IntPtr db, byte[] start_key, IntPtr start_key_len, byte[] limit_key, IntPtr limit_key_len)
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_compact_range_1(db, start_key, start_key_len, limit_key, limit_key_len);
			}
			return LevelDBInterop.leveldb_compact_range_2(db, start_key, start_key_len, limit_key, limit_key_len);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00008195 File Offset: 0x00006395
		public static IntPtr leveldb_writebatch_create()
		{
			if (Environment.Is64BitProcess)
			{
				return LevelDBInterop.leveldb_writebatch_create_1();
			}
			return LevelDBInterop.leveldb_writebatch_create_2();
		}

		// Token: 0x06000B9D RID: 2973
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_writebatch_create")]
		public static extern IntPtr leveldb_writebatch_create_1();

		// Token: 0x06000B9E RID: 2974
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_writebatch_create")]
		public static extern IntPtr leveldb_writebatch_create_2();

		// Token: 0x06000B9F RID: 2975 RVA: 0x000081A9 File Offset: 0x000063A9
		public static void leveldb_writebatch_destroy(IntPtr writebatch)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_writebatch_destroy_1(writebatch);
				return;
			}
			LevelDBInterop.leveldb_writebatch_destroy_2(writebatch);
		}

		// Token: 0x06000BA0 RID: 2976
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_destroy")]
		public static extern void leveldb_writebatch_destroy_1(IntPtr writebatch);

		// Token: 0x06000BA1 RID: 2977
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_destroy")]
		public static extern void leveldb_writebatch_destroy_2(IntPtr writebatch);

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000081BF File Offset: 0x000063BF
		public static void leveldb_writebatch_clear(IntPtr writebatch)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_writebatch_clear_1(writebatch);
				return;
			}
			LevelDBInterop.leveldb_writebatch_clear_2(writebatch);
		}

		// Token: 0x06000BA3 RID: 2979
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_clear")]
		public static extern void leveldb_writebatch_clear_1(IntPtr writebatch);

		// Token: 0x06000BA4 RID: 2980
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_clear")]
		public static extern void leveldb_writebatch_clear_2(IntPtr writebatch);

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000081D5 File Offset: 0x000063D5
		public static void leveldb_writebatch_delete(IntPtr writebatch, byte[] key, IntPtr keylen)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_writebatch_delete_1(writebatch, key, keylen);
				return;
			}
			LevelDBInterop.leveldb_writebatch_delete_2(writebatch, key, keylen);
		}

		// Token: 0x06000BA6 RID: 2982
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_delete")]
		private static extern void leveldb_writebatch_delete_1(IntPtr intptr_0, byte[] byte_0, IntPtr intptr_1);

		// Token: 0x06000BA7 RID: 2983
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_delete")]
		private static extern void leveldb_writebatch_delete_2(IntPtr intptr_0, byte[] byte_0, IntPtr intptr_1);

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000081EF File Offset: 0x000063EF
		public static void leveldb_write(IntPtr db, IntPtr options, IntPtr writebatch, out IntPtr errptr)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_write_1(db, options, writebatch, out errptr);
				return;
			}
			LevelDBInterop.leveldb_write_2(db, options, writebatch, out errptr);
		}

		// Token: 0x06000BA9 RID: 2985
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_write")]
		private static extern void leveldb_write_1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, out IntPtr intptr_3);

		// Token: 0x06000BAA RID: 2986
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_write")]
		private static extern void leveldb_write_2(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, out IntPtr intptr_3);

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000820B File Offset: 0x0000640B
		public static void leveldb_writebatch_put(IntPtr writebatch, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_writebatch_put_1(writebatch, key, keylen, val, vallen);
				return;
			}
			LevelDBInterop.leveldb_writebatch_put_2(writebatch, key, keylen, val, vallen);
		}

		// Token: 0x06000BAC RID: 2988
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_put")]
		public static extern void leveldb_writebatch_put_1(IntPtr writebatch, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen);

		// Token: 0x06000BAD RID: 2989
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writebatch_put")]
		public static extern void leveldb_writebatch_put_2(IntPtr writebatch, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen);

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000822B File Offset: 0x0000642B
		public static void leveldb_SuspendCompaction(IntPtr db)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_SuspendCompaction_1(db);
				return;
			}
			LevelDBInterop.leveldb_SuspendCompaction_2(db);
		}

		// Token: 0x06000BAF RID: 2991
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_SuspendCompaction")]
		private static extern void leveldb_SuspendCompaction_1(IntPtr intptr_0);

		// Token: 0x06000BB0 RID: 2992
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_SuspendCompaction")]
		private static extern void leveldb_SuspendCompaction_2(IntPtr intptr_0);

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00008241 File Offset: 0x00006441
		public static void leveldb_ResumeCompaction(IntPtr db)
		{
			if (Environment.Is64BitProcess)
			{
				LevelDBInterop.leveldb_ResumeCompaction_1(db);
				return;
			}
			LevelDBInterop.leveldb_ResumeCompaction_2(db);
		}

		// Token: 0x06000BB2 RID: 2994
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_ResumeCompaction")]
		private static extern void leveldb_ResumeCompaction_1(IntPtr intptr_0);

		// Token: 0x06000BB3 RID: 2995
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_ResumeCompaction")]
		private static extern void leveldb_ResumeCompaction_2(IntPtr intptr_0);

		// Token: 0x06000BB4 RID: 2996
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_options_create")]
		public static extern IntPtr leveldb_options_create_1();

		// Token: 0x06000BB5 RID: 2997
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_options_destroy")]
		public static extern void leveldb_options_destroy_1(IntPtr options);

		// Token: 0x06000BB6 RID: 2998
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_options_set_create_if_missing")]
		public static extern void leveldb_options_set_create_if_missing_1(IntPtr options, byte o);

		// Token: 0x06000BB7 RID: 2999
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_options_set_compression")]
		public static extern void leveldb_options_set_compression_1(IntPtr options, int compressionType);

		// Token: 0x06000BB8 RID: 3000
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_readoptions_create")]
		public static extern IntPtr leveldb_readoptions_create_1();

		// Token: 0x06000BB9 RID: 3001
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_readoptions_destroy")]
		public static extern void leveldb_readoptions_destroy_1(IntPtr options);

		// Token: 0x06000BBA RID: 3002
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_readoptions_set_fill_cache")]
		public static extern void leveldb_readoptions_set_fill_cache_1(IntPtr options, byte o);

		// Token: 0x06000BBB RID: 3003
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writeoptions_create")]
		public static extern IntPtr leveldb_writeoptions_create_1();

		// Token: 0x06000BBC RID: 3004
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writeoptions_destroy")]
		public static extern void leveldb_writeoptions_destroy_1(IntPtr options);

		// Token: 0x06000BBD RID: 3005
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writeoptions_set_sync")]
		private static extern void leveldb_writeoptions_set_sync_1(IntPtr intptr_0, byte byte_0);

		// Token: 0x06000BBE RID: 3006
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_open")]
		public static extern IntPtr leveldb_open_1(IntPtr options, string name, out IntPtr error);

		// Token: 0x06000BBF RID: 3007
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_close")]
		public static extern void leveldb_close_1(IntPtr db);

		// Token: 0x06000BC0 RID: 3008
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_get")]
		public static extern IntPtr leveldb_get_1(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BC1 RID: 3009
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_get")]
		public static extern IntPtr leveldb_get_2(IntPtr db, IntPtr options, ref int key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BC2 RID: 3010
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_get")]
		public static extern IntPtr leveldb_get_3(IntPtr db, IntPtr options, IntPtr key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BC3 RID: 3011
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_put")]
		public static extern void leveldb_put_1(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BC4 RID: 3012
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_put")]
		public static extern void leveldb_put_2(IntPtr db, IntPtr options, ref int key, IntPtr keylen, int[] val, IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BC5 RID: 3013
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_delete")]
		private static extern void leveldb_delete_1(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, out IntPtr intptr_3);

		// Token: 0x06000BC6 RID: 3014
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_free")]
		public static extern void leveldb_free_1(IntPtr ptr);

		// Token: 0x06000BC7 RID: 3015
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_create_iterator")]
		public static extern IntPtr leveldb_create_iterator_1(IntPtr db, IntPtr options);

		// Token: 0x06000BC8 RID: 3016
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_destroy")]
		public static extern void leveldb_iter_destroy_1(IntPtr iterator);

		// Token: 0x06000BC9 RID: 3017
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_valid")]
		public static extern byte leveldb_iter_valid_1(IntPtr iterator);

		// Token: 0x06000BCA RID: 3018
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek_to_first")]
		public static extern void leveldb_iter_seek_to_first_1(IntPtr iterator);

		// Token: 0x06000BCB RID: 3019
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek_to_last")]
		public static extern void leveldb_iter_seek_to_last_1(IntPtr iterator);

		// Token: 0x06000BCC RID: 3020
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek")]
		public static extern void leveldb_iter_seek_1(IntPtr iterator, byte[] key, int length);

		// Token: 0x06000BCD RID: 3021
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek")]
		public static extern void leveldb_iter_seek_2(IntPtr iterator, ref int key, int length);

		// Token: 0x06000BCE RID: 3022
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_next")]
		public static extern void leveldb_iter_next_1(IntPtr iterator);

		// Token: 0x06000BCF RID: 3023
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_prev")]
		public static extern void leveldb_iter_prev_1(IntPtr iterator);

		// Token: 0x06000BD0 RID: 3024
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_key")]
		public static extern IntPtr leveldb_iter_key_1(IntPtr iterator, out int length);

		// Token: 0x06000BD1 RID: 3025
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_value")]
		public static extern IntPtr leveldb_iter_value_1(IntPtr iterator, out int length);

		// Token: 0x06000BD2 RID: 3026
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_get_error")]
		public static extern void leveldb_iter_get_error_1(IntPtr iterator, out IntPtr error);

		// Token: 0x06000BD3 RID: 3027
		[DllImport("LevelDB-MCPE-64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_compact_range")]
		public static extern IntPtr leveldb_compact_range_1(IntPtr db, byte[] start_key, IntPtr start_key_len, byte[] limit_key, IntPtr limit_key_len);

		// Token: 0x06000BD4 RID: 3028
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_options_create")]
		public static extern IntPtr leveldb_options_create_2();

		// Token: 0x06000BD5 RID: 3029
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_options_destroy")]
		public static extern void leveldb_options_destroy_2(IntPtr options);

		// Token: 0x06000BD6 RID: 3030
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_options_set_create_if_missing")]
		public static extern void leveldb_options_set_create_if_missing_2(IntPtr options, byte o);

		// Token: 0x06000BD7 RID: 3031
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_options_set_compression")]
		public static extern void leveldb_options_set_compression_2(IntPtr options, int compressionType);

		// Token: 0x06000BD8 RID: 3032
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_readoptions_create")]
		public static extern IntPtr leveldb_readoptions_create_2();

		// Token: 0x06000BD9 RID: 3033
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_readoptions_destroy")]
		public static extern void leveldb_readoptions_destroy_2(IntPtr options);

		// Token: 0x06000BDA RID: 3034
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_readoptions_set_fill_cache")]
		public static extern void leveldb_readoptions_set_fill_cache_2(IntPtr options, byte o);

		// Token: 0x06000BDB RID: 3035
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writeoptions_create")]
		public static extern IntPtr leveldb_writeoptions_create_2();

		// Token: 0x06000BDC RID: 3036
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writeoptions_destroy")]
		public static extern void leveldb_writeoptions_destroy_2(IntPtr options);

		// Token: 0x06000BDD RID: 3037
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_writeoptions_set_sync")]
		private static extern void leveldb_writeoptions_set_sync_2(IntPtr intptr_0, byte byte_0);

		// Token: 0x06000BDE RID: 3038
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_open")]
		public static extern IntPtr leveldb_open_2(IntPtr options, string name, out IntPtr error);

		// Token: 0x06000BDF RID: 3039
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_close")]
		public static extern void leveldb_close_2(IntPtr db);

		// Token: 0x06000BE0 RID: 3040
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_get")]
		public static extern IntPtr leveldb_get_4(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BE1 RID: 3041
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_get")]
		public static extern IntPtr leveldb_get_5(IntPtr db, IntPtr options, ref int key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BE2 RID: 3042
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_get")]
		public static extern IntPtr leveldb_get_6(IntPtr db, IntPtr options, IntPtr key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BE3 RID: 3043
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_put")]
		public static extern void leveldb_put_3(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BE4 RID: 3044
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_put")]
		public static extern void leveldb_put_4(IntPtr db, IntPtr options, ref int key, IntPtr keylen, int[] val, IntPtr vallen, out IntPtr errptr);

		// Token: 0x06000BE5 RID: 3045
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_delete")]
		public static extern void leveldb_delete_2(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr errptr);

		// Token: 0x06000BE6 RID: 3046
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_free")]
		public static extern void leveldb_free_2(IntPtr ptr);

		// Token: 0x06000BE7 RID: 3047
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_create_iterator")]
		public static extern IntPtr leveldb_create_iterator_2(IntPtr db, IntPtr options);

		// Token: 0x06000BE8 RID: 3048
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_destroy")]
		public static extern void leveldb_iter_destroy_2(IntPtr iterator);

		// Token: 0x06000BE9 RID: 3049
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_valid")]
		public static extern byte leveldb_iter_valid_2(IntPtr iterator);

		// Token: 0x06000BEA RID: 3050
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek_to_first")]
		public static extern void leveldb_iter_seek_to_first_2(IntPtr iterator);

		// Token: 0x06000BEB RID: 3051
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek_to_last")]
		public static extern void leveldb_iter_seek_to_last_2(IntPtr iterator);

		// Token: 0x06000BEC RID: 3052
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek")]
		public static extern void leveldb_iter_seek_3(IntPtr iterator, byte[] key, int length);

		// Token: 0x06000BED RID: 3053
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_seek")]
		public static extern void leveldb_iter_seek_4(IntPtr iterator, ref int key, int length);

		// Token: 0x06000BEE RID: 3054
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_next")]
		public static extern void leveldb_iter_next_2(IntPtr iterator);

		// Token: 0x06000BEF RID: 3055
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_prev")]
		public static extern void leveldb_iter_prev_2(IntPtr iterator);

		// Token: 0x06000BF0 RID: 3056
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_key")]
		public static extern IntPtr leveldb_iter_key_2(IntPtr iterator, out int length);

		// Token: 0x06000BF1 RID: 3057
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_value")]
		public static extern IntPtr leveldb_iter_value_2(IntPtr iterator, out int length);

		// Token: 0x06000BF2 RID: 3058
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "leveldb_iter_get_error")]
		public static extern void leveldb_iter_get_error_2(IntPtr iterator, out IntPtr error);

		// Token: 0x06000BF3 RID: 3059
		[DllImport("LevelDB-MCPE-32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "leveldb_compact_range")]
		public static extern IntPtr leveldb_compact_range_2(IntPtr db, byte[] start_key, IntPtr start_key_len, byte[] limit_key, IntPtr limit_key_len);
	}
}
