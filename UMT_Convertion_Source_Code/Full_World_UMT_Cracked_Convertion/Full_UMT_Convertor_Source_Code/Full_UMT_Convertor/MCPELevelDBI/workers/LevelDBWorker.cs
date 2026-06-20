using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.PECode.model;
using Full_UMT_Convertor.utils;
using MCPELevelDBI.model;

namespace MCPELevelDBI.workers
{
	// Token: 0x02000131 RID: 305
	public class LevelDBWorker
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x00002591 File Offset: 0x00000791
		public LevelDBWorker()
		{
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00008898 File Offset: 0x00006A98
		public LevelDBWorker(BackgroundWorker bw)
		{
			this.bw = bw;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x000088B0 File Offset: 0x00006AB0
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x000088A7 File Offset: 0x00006AA7
		public IntPtr Handle { get; protected set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000088C1 File Offset: 0x00006AC1
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x000088B8 File Offset: 0x00006AB8
		public IntPtr readOptions { get; protected set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000088D2 File Offset: 0x00006AD2
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x000088C9 File Offset: 0x00006AC9
		public IntPtr writeOptions { get; protected set; }

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00057B0C File Offset: 0x00055D0C
		public void OpenDB(string path, bool createIfNotExist = false)
		{
			IntPtr options = LevelDBInterop.leveldb_options_create();
			if (createIfNotExist)
			{
				LevelDBInterop.leveldb_options_set_create_if_missing(options, 1);
			}
			LevelDBInterop.leveldb_options_set_compression(options, 4);
			IntPtr intptr_;
			this.Handle = LevelDBInterop.leveldb_open(options, path, out intptr_);
			LevelDBWorker.smethod_0(intptr_);
			this.readOptions = LevelDBInterop.leveldb_readoptions_create();
			this.writeOptions = LevelDBInterop.leveldb_writeoptions_create();
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000088DA File Offset: 0x00006ADA
		public void CloseDB()
		{
			LevelDBInterop.leveldb_close(this.Handle);
			LevelDBInterop.leveldb_readoptions_destroy(this.readOptions);
			LevelDBInterop.leveldb_writeoptions_destroy(this.writeOptions);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000088FD File Offset: 0x00006AFD
		public byte[] ReadDbValue(string key)
		{
			return this.ReadDbValue(Encoding.ASCII.GetBytes(key));
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00057B5C File Offset: 0x00055D5C
		public byte[] ReadDbValue(byte[] key)
		{
			lock (LevelDBWorker.object_0)
			{
				IntPtr value;
				IntPtr intptr_;
				IntPtr intPtr = LevelDBInterop.leveldb_get(this.Handle, this.readOptions, key, (IntPtr)key.LongLength, out value, out intptr_);
				LevelDBWorker.smethod_0(intptr_);
				if (intPtr != IntPtr.Zero)
				{
					try
					{
						byte[] array = new byte[(long)value];
						Marshal.Copy(intPtr, array, 0, (int)value);
						return array;
					}
					finally
					{
						LevelDBInterop.leveldb_free(intPtr);
					}
				}
				goto IL_7F;
			}
			byte[] result;
			return result;
			IL_7F:
			return null;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00008910 File Offset: 0x00006B10
		public void Put(string key, string value)
		{
			this.Put(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(value));
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00057C08 File Offset: 0x00055E08
		public void Put(byte[] key, byte[] value)
		{
			IntPtr intptr_;
			LevelDBInterop.leveldb_put(this.Handle, this.writeOptions, key, (IntPtr)key.LongLength, value, (IntPtr)value.LongLength, out intptr_);
			LevelDBWorker.smethod_0(intptr_);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00057C48 File Offset: 0x00055E48
		public void Put(int key, int[] value)
		{
			IntPtr intptr_;
			LevelDBInterop.leveldb_put(this.Handle, this.writeOptions, ref key, (IntPtr)4, value, (IntPtr)(checked(value.LongLength * 4L)), out intptr_);
			LevelDBWorker.smethod_0(intptr_);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00057C8C File Offset: 0x00055E8C
		public byte[] Get(byte[] key)
		{
			IntPtr value;
			IntPtr intptr_;
			IntPtr intPtr = LevelDBInterop.leveldb_get(this.Handle, this.readOptions, key, (IntPtr)key.LongLength, out value, out intptr_);
			LevelDBWorker.smethod_0(intptr_);
			if (intPtr != IntPtr.Zero)
			{
				byte[] result;
				try
				{
					byte[] array = new byte[(long)value];
					Marshal.Copy(intPtr, array, 0, (int)value);
					result = array;
				}
				finally
				{
					LevelDBInterop.leveldb_free(intPtr);
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0000892E File Offset: 0x00006B2E
		public void leveldb_compact_range(byte[] start_key, byte[] limit_key)
		{
			LevelDBInterop.leveldb_compact_range(this.Handle, start_key, (IntPtr)0, limit_key, (IntPtr)0);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00057D0C File Offset: 0x00055F0C
		public void Delete(byte[] key)
		{
			IntPtr intptr_;
			LevelDBInterop.leveldb_delete(this.Handle, this.writeOptions, key, (IntPtr)key.LongLength, out intptr_);
			LevelDBWorker.smethod_0(intptr_);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00057D40 File Offset: 0x00055F40
		public IntPtr CreateWriteBatch()
		{
			return LevelDBInterop.leveldb_writebatch_create();
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0000894A File Offset: 0x00006B4A
		public void DestroyWriteBatch(IntPtr batch)
		{
			LevelDBInterop.leveldb_writebatch_destroy(batch);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00057D54 File Offset: 0x00055F54
		public void WriteBatch(IntPtr batch)
		{
			IntPtr intptr_;
			LevelDBInterop.leveldb_write(this.Handle, this.writeOptions, batch, out intptr_);
			LevelDBWorker.smethod_0(intptr_);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00008952 File Offset: 0x00006B52
		public void WriteBatchDelete(IntPtr batch, byte[] key)
		{
			LevelDBInterop.leveldb_writebatch_delete(batch, key, (IntPtr)key.LongLength);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00008966 File Offset: 0x00006B66
		public void WriteBatchPut(IntPtr batch, byte[] key, byte[] value)
		{
			LevelDBInterop.leveldb_writebatch_put(batch, key, (IntPtr)key.LongLength, value, (IntPtr)value.LongLength);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00008986 File Offset: 0x00006B86
		private static void smethod_0(IntPtr intptr_3)
		{
			if (LevelDBWorker.func_0 == null)
			{
				LevelDBWorker.func_0 = new Func<string, Exception>(LevelDBWorker.smethod_2);
			}
			LevelDBWorker.smethod_1(intptr_3, LevelDBWorker.func_0);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00057D7C File Offset: 0x00055F7C
		private static void smethod_1(IntPtr intptr_3, Func<string, Exception> func_1)
		{
			if (intptr_3 != IntPtr.Zero)
			{
				try
				{
					string arg = Marshal.PtrToStringAnsi(intptr_3);
					throw func_1(arg);
				}
				finally
				{
					LevelDBInterop.leveldb_free(intptr_3);
				}
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00057DBC File Offset: 0x00055FBC
		private List<DBRecord> method_0(IntPtr intptr_3)
		{
			List<DBRecord> list = new List<DBRecord>();
			using (Iterator iterator = this.CreateIterator(LevelDBInterop.leveldb_readoptions_create()))
			{
				iterator.SeekToFirst();
				while (iterator.IsValid())
				{
					DBRecord item = new DBRecord(iterator.Key(), iterator.Value());
					list.Add(item);
					iterator.Next();
				}
			}
			return list;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000089AB File Offset: 0x00006BAB
		public Iterator CreateIterator(IntPtr readOptions)
		{
			return new Iterator(LevelDBInterop.leveldb_create_iterator(this.Handle, readOptions));
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00057E28 File Offset: 0x00056028
		public void BuildAnalysis()
		{
			List<DBRecord> list_ = this.method_0(this.readOptions);
			this.method_1(list_);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00057E4C File Offset: 0x0005604C
		private string method_1(List<DBRecord> list_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			foreach (DBRecord dbrecord in list_0)
			{
				byte[] key = dbrecord.Key;
				int num2 = 0;
				int num3 = 0;
				if (key.Length >= 8)
				{
					num2 = BitConverter.ToInt32(key, 0);
					num3 = BitConverter.ToInt32(key, 4);
				}
				int num4 = (int)key[key.Length - 1];
				int num5 = -1;
				int num6 = 0;
				if (key.Length >= 13)
				{
					num6 = BitConverter.ToInt32(key, 8);
				}
				if (num4 <= 15)
				{
					num5 = num4;
					num4 = (int)key[key.Length - 2];
				}
				string text = string.Empty;
				string text2;
				if (!LevelDBWorker.int_0.Contains(num4))
				{
					text = Encoding.ASCII.GetString(key);
					text2 = text;
					try
					{
						FileUtils.WriteFile(dbrecord.Value, "D:\\temp\\MCPE\\Export\\" + num.ToString() + "." + text2);
						goto IL_1AA;
					}
					catch (Exception)
					{
						goto IL_1AA;
					}
					goto IL_1F5;
				}
				if (num4 == 47)
				{
					goto IL_1F5;
				}
				text = string.Format("Key Size:{0} \t\tData Size:{1}  \t\tx:{2}  \tz:{3}    \tdim:{4} \ttype:{5}", new object[]
				{
					key.Length,
					dbrecord.Value.Length,
					num2,
					num3,
					num6,
					num4
				});
				text2 = string.Format("{4}.{0}.{1}.{2}.{3}.dat", new object[]
				{
					num2,
					num3,
					num6,
					num4,
					num
				});
				goto Block_8;
				IL_1AA:
				stringBuilder.AppendLine(text);
				num++;
				continue;
				Block_8:
				try
				{
					IL_151:
					Directory.CreateDirectory("D:\\temp\\MCPE\\Export\\" + num6);
					FileUtils.WriteFile(dbrecord.Value, string.Concat(new object[]
					{
						"D:\\temp\\MCPE\\Export\\",
						num6,
						"\\",
						text2
					}));
				}
				catch (Exception)
				{
				}
				goto IL_1AA;
				IL_1F5:
				text = string.Format("Key Size:{0} \t\tData Size:{1}  \t\tx:{2}  \tz:{3}    \tdim:{4} \ttype:{5}   \tlayer:{6}", new object[]
				{
					key.Length,
					dbrecord.Value.Length,
					num2,
					num3,
					num6,
					num4,
					num5
				});
				text2 = string.Format("{5}.{0}.{1}.{2}.{3}.{4}.dat", new object[]
				{
					num2,
					num3,
					num6,
					num4,
					num5,
					num
				});
				goto IL_151;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00058178 File Offset: 0x00056378
		public List<DBRecord> GetMaps()
		{
			return this.method_2(this.readOptions);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00058194 File Offset: 0x00056394
		private List<DBRecord> method_2(IntPtr intptr_3)
		{
			List<DBRecord> list = new List<DBRecord>();
			using (Iterator iterator = this.CreateIterator(LevelDBInterop.leveldb_readoptions_create()))
			{
				iterator.Seek("map");
				while (iterator.IsValid())
				{
					DBRecord item = new DBRecord(iterator.Key(), iterator.Value());
					if (!iterator.KeyAsString().StartsWith("map"))
					{
						break;
					}
					list.Add(item);
					iterator.Next();
				}
			}
			return list;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00058218 File Offset: 0x00056418
		public List<DBRecord> GetPlayers()
		{
			return this.method_3(this.readOptions);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00058234 File Offset: 0x00056434
		private List<DBRecord> method_3(IntPtr intptr_3)
		{
			List<DBRecord> list = new List<DBRecord>();
			using (Iterator iterator = this.CreateIterator(LevelDBInterop.leveldb_readoptions_create()))
			{
				iterator.Seek("player");
				while (iterator.IsValid())
				{
					DBRecord item = new DBRecord(iterator.Key(), iterator.Value());
					if (!iterator.KeyAsString().StartsWith("player"))
					{
						break;
					}
					list.Add(item);
					iterator.Next();
				}
			}
			return list;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000582B8 File Offset: 0x000564B8
		public List<PEDimension> GetAvailableChunks()
		{
			List<DBRecord> list_ = this.method_5(this.readOptions);
			return this.method_7(list_);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000582DC File Offset: 0x000564DC
		private List<DBRecord> method_4(IntPtr intptr_3, object object_1)
		{
			List<DBRecord> list = new List<DBRecord>();
			IntPtr intPtr = LevelDBInterop.leveldb_readoptions_create();
			LevelDBInterop.leveldb_readoptions_set_fill_cache(intPtr, 0);
			using (Iterator iterator = this.CreateIterator(intPtr))
			{
				iterator.SeekToFirst();
				while (iterator.IsValid())
				{
					byte[] array = iterator.Key();
					if (array[array.Length - 1] == 118)
					{
						DBRecord item = new DBRecord(iterator.Key(), iterator.Value());
						list.Add(item);
					}
					iterator.Next();
				}
			}
			LevelDBInterop.leveldb_readoptions_destroy(intPtr);
			return list;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00058370 File Offset: 0x00056570
		private List<DBRecord> method_5(IntPtr intptr_3)
		{
			List<DBRecord> list = new List<DBRecord>();
			IntPtr intPtr = LevelDBInterop.leveldb_readoptions_create();
			LevelDBInterop.leveldb_readoptions_set_fill_cache(intPtr, 0);
			using (Iterator iterator = this.CreateIterator(intPtr))
			{
				iterator.SeekToFirst();
				while (iterator.IsValid())
				{
					byte[] array = iterator.Key();
					int num = this.method_6(array);
					if (LevelDBWorker.int_0.Contains(num))
					{
						if (num != 118)
						{
							array[array.Length - 1] = 118;
							iterator.Seek(array);
						}
						else
						{
							DBRecord item = new DBRecord(iterator.Key(), null);
							list.Add(item);
							iterator.Next();
						}
					}
					else
					{
						iterator.Next();
					}
				}
			}
			LevelDBInterop.leveldb_readoptions_destroy(intPtr);
			return list;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0005842C File Offset: 0x0005662C
		private int method_6(byte[] byte_1)
		{
			int num = -1;
			if (byte_1.Length >= 8 && byte_1.Length <= 13)
			{
				num = (int)byte_1[byte_1.Length - 1];
				if (num <= 15)
				{
					num = (int)byte_1[byte_1.Length - 2];
				}
			}
			return num;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00058460 File Offset: 0x00056660
		private List<PEDimension> method_7(List<DBRecord> list_0)
		{
			List<PEDimension> list = new List<PEDimension>();
			list.Add(new PEDimension(0));
			list.Add(new PEDimension(1));
			list.Add(new PEDimension(2));
			foreach (DBRecord dbrecord in list_0)
			{
				byte[] key = dbrecord.Key;
				if (key.Length >= 8 && key.Length <= 13 && key[key.Length - 1] == 118)
				{
					int num = 0;
					int num2 = 0;
					if (key.Length >= 8)
					{
						num = BitConverter.ToInt32(key, 0);
						num2 = BitConverter.ToInt32(key, 4);
					}
					int num3 = (int)key[key.Length - 1];
					int num4 = 0;
					if (key.Length >= 13)
					{
						num4 = BitConverter.ToInt32(key, 8);
					}
					if (num3 == 118)
					{
						int x = (int)Math.Floor((double)num / 32.0);
						int z = (int)Math.Floor((double)num2 / 32.0);
						string key2 = x.ToString() + "." + z.ToString();
						if (!list[num4].Region.ContainsKey(key2))
						{
							list[num4].Region[key2] = new PERegion(num4, x, z);
						}
						int num5 = (num & 31) + (num2 & 31) * 32;
						list[num4].Region[key2].Chunks[num5] = 1;
					}
				}
			}
			return list;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000585F4 File Offset: 0x000567F4
		private List<PEDimension> method_8(byte[] byte_1)
		{
			List<PEDimension> list = new List<PEDimension>();
			list.Add(new PEDimension(0));
			list.Add(new PEDimension(1));
			list.Add(new PEDimension(2));
			for (int i = 0; i < byte_1.Length; i += 1024)
			{
				int x = BitConverter.ToInt32(byte_1, i);
				i += 4;
				int z = BitConverter.ToInt32(byte_1, i);
				i += 4;
				int num = BitConverter.ToInt32(byte_1, i);
				i += 4;
				string key = x.ToString() + "." + z.ToString();
				if (!list[num].Region.ContainsKey(key))
				{
					list[num].Region[key] = new PERegion(num, x, z);
				}
				for (int j = 0; j < 1024; j++)
				{
					list[num].Region[key].Chunks[j] = byte_1[i + j];
				}
			}
			return list;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000586F4 File Offset: 0x000568F4
		public PEWorldChunks GetWorldChunks()
		{
			PEWorldChunks peworldChunks = new PEWorldChunks();
			List<DBRecord> list = this.method_0(this.readOptions);
			foreach (DBRecord dbrecord in list)
			{
				if (!this.method_10(dbrecord.Key))
				{
					int dimension = 0;
					int x = 0;
					int z = 0;
					int num = 0;
					int section = 0;
					this.method_9(dbrecord.Key, out dimension, out x, out z, out num, out section);
					if (LevelDBWorker.int_0.Contains(num))
					{
						peworldChunks.AddRecord(dimension, x, z, num, section, dbrecord.Value);
					}
				}
			}
			return peworldChunks;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000587A8 File Offset: 0x000569A8
		private void method_9(byte[] byte_1, out int int_1, out int int_2, out int int_3, out int int_4, out int int_5)
		{
			int_2 = 0;
			int_3 = 0;
			if (byte_1.Length >= 8)
			{
				int_2 = BitConverter.ToInt32(byte_1, 0);
				int_3 = BitConverter.ToInt32(byte_1, 4);
			}
			int_4 = (int)byte_1[byte_1.Length - 1];
			int_5 = -1;
			int_1 = 0;
			if (byte_1.Length >= 13)
			{
				int_1 = BitConverter.ToInt32(byte_1, 8);
			}
			if (int_4 <= 15)
			{
				int_5 = int_4;
				int_4 = (int)byte_1[byte_1.Length - 2];
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00058810 File Offset: 0x00056A10
		private bool method_10(byte[] byte_1)
		{
			int num = (byte_1.Length < LevelDBWorker.byte_0.Length) ? byte_1.Length : LevelDBWorker.byte_0.Length;
			if (byte_1.Length != LevelDBWorker.byte_0.Length + 1)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				if (byte_1[i] != LevelDBWorker.byte_0[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00058868 File Offset: 0x00056A68
		public void DeleteRegionChunks(PERegion regionData)
		{
			LevelDBInterop.leveldb_writeoptions_set_sync(this.writeOptions, 1);
			IntPtr intPtr = LevelDBInterop.leveldb_writebatch_create();
			int num = regionData.RX * 32;
			int num2 = regionData.RZ * 32;
			for (int i = 0; i < 1024; i++)
			{
				if (regionData.Chunks[i] == 1)
				{
					int num3 = i % 32;
					int num4 = i / 32;
					this.method_11(regionData.Dimension, num + num3, num2 + num4, intPtr);
				}
			}
			this.WriteBatch(intPtr);
			LevelDBInterop.leveldb_writebatch_destroy(intPtr);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000588EC File Offset: 0x00056AEC
		public void DeleteRegionChunks(List<ChunkData> deletedChunks)
		{
			LevelDBInterop.leveldb_writeoptions_set_sync(this.writeOptions, 1);
			IntPtr intPtr = LevelDBInterop.leveldb_writebatch_create();
			foreach (ChunkData chunkData in deletedChunks)
			{
				int xworldCoords = chunkData.XWorldCoords;
				int zworldCoords = chunkData.ZWorldCoords;
				this.method_11(chunkData.Dimension, xworldCoords, zworldCoords, intPtr);
			}
			this.WriteBatch(intPtr);
			LevelDBInterop.leveldb_writebatch_destroy(intPtr);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00058974 File Offset: 0x00056B74
		private void method_11(int int_1, int int_2, int int_3, IntPtr intptr_3)
		{
			byte[] array = PEUtility.BuildChunkKey(int_1, int_2, int_3, 0, null);
			foreach (int num in LevelDBWorker.int_0)
			{
				if (num != 47)
				{
					array[array.Length - 1] = (byte)num;
					this.WriteBatchDelete(intptr_3, array);
				}
			}
			array = PEUtility.BuildChunkKey(int_1, int_2, int_3, 47, new byte?(0));
			for (int j = 0; j < 16; j++)
			{
				array[array.Length - 1] = (byte)j;
				this.WriteBatchDelete(intptr_3, array);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00058A04 File Offset: 0x00056C04
		public PEWorldChunks GetWorldChunksForConversion(generatePCFiles)
		{
			return this.method_12(this.readOptions, generatePCFiles);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00058A20 File Offset: 0x00056C20
		private PEWorldChunks method_12(IntPtr intptr_3, generatePCFilesFromPE_0)
		{
			/*
An exception occurred when decompiling this method (06000CEB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Full_UMT_Convertor.PECode.model.PEWorldChunks MCPELevelDBI.workers.LevelDBWorker::method_12(System.IntPtr,<<<NULL>>>)

 ---> System.Exception: Inconsistent stack size at IL_117
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000089BE File Offset: 0x00006BBE
		private void method_13(string string_0)
		{
			if (this.bw != null)
			{
				this.bw.ReportProgress(0, string_0);
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00007E69 File Offset: 0x00006069
		[CompilerGenerated]
		private static Exception smethod_2(string string_0)
		{
			return new Exception(string_0);
		}

		// Token: 0x040007F3 RID: 2035
		private static object object_0 = new object();

		// Token: 0x040007F4 RID: 2036
		private BackgroundWorker bw;

		// Token: 0x040007F5 RID: 2037
		private static byte[] byte_0 = Encoding.ASCII.GetBytes("dimension");

		// Token: 0x040007F6 RID: 2038
		private static int[] int_0 = new int[]
		{
			45,
			46,
			47,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			118
		};

		// Token: 0x040007F7 RID: 2039
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x040007F8 RID: 2040
		[CompilerGenerated]
		private IntPtr intptr_1;

		// Token: 0x040007F9 RID: 2041
		[CompilerGenerated]
		private IntPtr intptr_2;

		// Token: 0x040007FA RID: 2042
		[CompilerGenerated]
		private static Func<string, Exception> func_0;
	}
}
