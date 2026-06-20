using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace PS3FileSystem
{
	// Token: 0x02000007 RID: 7
	public class Param_PFD
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00007818 File Offset: 0x00005A18
		internal byte[] method_0(int int_0)
		{
			if (int_0 > 3)
			{
				return null;
			}
			switch (int_0)
			{
			case 0:
				return Class1.smethod_8("savegame_param_sfo_key");
			case 1:
				return this.ConsoleID;
			case 2:
				return this.DiscHashKey;
			case 3:
				return this.AuthenticationID;
			default:
				return null;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00007868 File Offset: 0x00005A68
		internal byte[] AdQeLsEmF(byte[] byte_11)
		{
			if (byte_11.Length != 16)
			{
				throw new Exception("SecureFileID must be 16 bytes in length");
			}
			byte[] array = new byte[20];
			Array.Copy(byte_11, 0, array, 0, 16);
			int i = 0;
			int num = 0;
			while (i < array.Length)
			{
				int num2 = i;
				switch (num2)
				{
				case 1:
					array[i] = 11;
					break;
				case 2:
					array[i] = 15;
					break;
				case 3:
				case 4:
					goto IL_79;
				case 5:
					array[i] = 14;
					break;
				default:
					if (num2 != 8)
					{
						goto IL_79;
					}
					array[i] = 10;
					break;
				}
				IL_58:
				i++;
				continue;
				IL_79:
				array[i] = byte_11[num++];
				goto IL_58;
			}
			return array;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000078FC File Offset: 0x00005AFC
		internal byte[] method_1(Param_PFD.PFDEntry pfdentry_0, int int_0)
		{
			string a;
			if ((a = pfdentry_0.string_0.ToLower()) != null)
			{
				if (a == "param.sfo")
				{
					return this.method_0(int_0);
				}
				if (a == "tropsys.dat")
				{
					return Class1.smethod_8("tropsys_dat_key");
				}
				if (a == "tropusr.dat")
				{
					return Class1.smethod_8("tropusr_dat_key");
				}
				if (a == "troptrns.dat")
				{
					return Class1.smethod_8("troptrns_dat_key");
				}
				if (a == "tropconf.sfm")
				{
					return Class1.smethod_8("tropconf_sfm_key");
				}
			}
			return this.AdQeLsEmF(this.SecureFileID);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000799C File Offset: 0x00005B9C
		internal byte[] method_2(Param_PFD.PFDEntry pfdentry_0)
		{
			byte[] array = this.method_1(pfdentry_0, 0);
			return Class1.smethod_5(array, pfdentry_0.byte_2, pfdentry_0.byte_2.Length);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000079C8 File Offset: 0x00005BC8
		internal byte[] method_3()
		{
			byte[] array = Param_PFD.Struct2.smethod_0();
			return Class1.smethod_12(Param_PFD.byte_5, array, 0, array.Length);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000079EC File Offset: 0x00005BEC
		internal byte[] method_4()
		{
			byte[] array = Param_PFD.Struct1.smethod_0();
			return Class1.smethod_12(Param_PFD.byte_5, array, 0, array.Length);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024EC File Offset: 0x000006EC
		internal byte[] method_5()
		{
			return new HMACSHA1(Param_PFD.byte_5).ComputeHash(new byte[0]);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00007A10 File Offset: 0x00005C10
		internal ulong method_6(string string_0)
		{
			int length = string_0.Length;
			ulong num = 0UL;
			for (int i = 0; i < length; i++)
			{
				num = (num << 5) - num + (ulong)((byte)string_0[i]);
			}
			return num % Param_PFD.Struct2.ulong_0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00007A54 File Offset: 0x00005C54
		internal void method_7(Stream stream_0)
		{
			this.method_9("Initializing Param.PFD stream..", MessageType.Info);
			using (BinaryReader binaryReader = new BinaryReader(stream_0))
			{
				Param_PFD.Struct3.ulong_0 = binaryReader.ReadUInt64().smethod_3();
				if (Param_PFD.Struct3.ulong_0 != 1346782274UL)
				{
					this.method_9("Invalid PFD File!", MessageType.Error);
					throw new Exception("Invalid PFD File!");
				}
				Param_PFD.Struct3.ulong_1 = binaryReader.ReadUInt64().smethod_3();
				if (Param_PFD.Struct3.ulong_1 != 3UL && Param_PFD.Struct3.ulong_1 != 4UL)
				{
					this.method_9("Unsupported PFD version!", MessageType.Error);
					throw new Exception("Unsupported PFD version!");
				}
				this.method_9("Allocating Header Data..", MessageType.Info);
				Param_PFD.byte_0 = binaryReader.ReadBytes(16);
				byte[] array = binaryReader.ReadBytes(64);
				array = Class1.smethod_5(Param_PFD.byte_0, array, array.Length);
				Param_PFD.Struct4.byte_0 = new byte[20];
				Array.Copy(array, 0, Param_PFD.Struct4.byte_0, 0, 20);
				Param_PFD.Struct4.byte_1 = new byte[20];
				Array.Copy(array, 20, Param_PFD.Struct4.byte_1, 0, 20);
				Param_PFD.Struct4.byte_2 = new byte[20];
				Array.Copy(array, 40, Param_PFD.Struct4.byte_2, 0, 20);
				Param_PFD.Struct4.byte_3 = new byte[4];
				Array.Copy(array, 60, Param_PFD.Struct4.byte_3, 0, 4);
				if (Param_PFD.Struct3.ulong_1 == 4UL)
				{
					Param_PFD.byte_5 = Class1.smethod_12(Class1.smethod_8("keygen_key"), Param_PFD.Struct4.byte_2, 0, 20);
				}
				else
				{
					Param_PFD.byte_5 = Param_PFD.Struct4.byte_2;
				}
				this.method_9("Reading Entries..", MessageType.Info);
				Param_PFD.Struct2.ulong_0 = binaryReader.ReadUInt64().smethod_3();
				Param_PFD.Struct2.ulong_1 = binaryReader.ReadUInt64().smethod_3();
				Param_PFD.Struct2.ulong_2 = binaryReader.ReadUInt64().smethod_3();
				Param_PFD.Struct2.list_0 = new List<ulong>();
				this.method_9("Reading table capicity (" + Param_PFD.Struct2.ulong_0 + " entries)..", MessageType.Info);
				for (ulong num = 0UL; num < Param_PFD.Struct2.ulong_0; num += 1UL)
				{
					Param_PFD.Struct2.list_0.Add(binaryReader.ReadUInt64().smethod_3());
				}
				Param_PFD.Struct0.list_0 = new List<Param_PFD.PFDEntry>();
				this.method_9("Reading used tables (" + Param_PFD.Struct2.ulong_2 + " entries)..", MessageType.Info);
				for (ulong num2 = 0UL; num2 < Param_PFD.Struct2.ulong_2; num2 += 1UL)
				{
					Param_PFD.PFDEntry pfdentry = new Param_PFD.PFDEntry();
					pfdentry.ulong_0 = binaryReader.ReadUInt64().smethod_3();
					pfdentry.string_0 = Encoding.ASCII.GetString(binaryReader.ReadBytes(65)).Replace("\0", "");
					pfdentry.byte_0 = binaryReader.ReadBytes(7);
					pfdentry.byte_2 = binaryReader.ReadBytes(64);
					pfdentry.list_0 = new List<byte[]>();
					for (int i = 0; i < 4; i++)
					{
						pfdentry.list_0.Add(binaryReader.ReadBytes(20));
					}
					pfdentry.byte_1 = binaryReader.ReadBytes(40);
					pfdentry.ulong_1 = binaryReader.ReadUInt64().smethod_3();
					Param_PFD.Struct0.list_0.Add(pfdentry);
				}
				long position = binaryReader.BaseStream.Position + (long)(272UL * (Param_PFD.Struct2.ulong_1 - Param_PFD.Struct2.ulong_2));
				binaryReader.BaseStream.Position = position;
				Param_PFD.Struct1.list_0 = new List<byte[]>();
				this.method_9("Reading file table hashes (" + Param_PFD.Struct2.ulong_0 + " entries)..", MessageType.Info);
				for (ulong num3 = 0UL; num3 < Param_PFD.Struct2.ulong_0; num3 += 1UL)
				{
					Param_PFD.Struct1.list_0.Add(binaryReader.ReadBytes(20));
				}
				binaryReader.Close();
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002503 File Offset: 0x00000703
		internal static int vjuOqtnly(int int_0)
		{
			return int_0 + 16 - 1 & -16;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00007E4C File Offset: 0x0000604C
		internal byte[] method_8(int int_0)
		{
			if (int_0 >= Param_PFD.Struct0.list_0.Count)
			{
				throw new Exception("entryindex is out of bounds");
			}
			Param_PFD.PFDEntry pfdentry = Param_PFD.Struct0.list_0[int_0];
			ulong num = this.method_6(pfdentry.string_0);
			ulong num2 = Param_PFD.Struct2.list_0[(int)num];
			if (num2 < Param_PFD.Struct2.ulong_1)
			{
				HMACSHA1 hmacsha = new HMACSHA1(Param_PFD.byte_5);
				List<byte> list = new List<byte>();
				while (num2 < Param_PFD.Struct2.ulong_1)
				{
					pfdentry = Param_PFD.Struct0.list_0[(int)num2];
					list.AddRange(pfdentry.method_1());
					num2 = pfdentry.ulong_0;
				}
				hmacsha.ComputeHash(list.ToArray());
				list.Clear();
				return hmacsha.Hash;
			}
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000250E File Offset: 0x0000070E
		private void method_9(string string_0, MessageType messageType_0)
		{
			if (this.ps3Action_0 != null)
			{
				this.ps3Action_0(this, string_0, messageType_0);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024C1 File Offset: 0x000006C1
		public Param_PFD()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002526 File Offset: 0x00000726
		public Param_PFD(string filepath)
		{
			this.method_7(new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000253D File Offset: 0x0000073D
		public Param_PFD(byte[] inputdata)
		{
			this.method_7(new MemoryStream(inputdata));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002551 File Offset: 0x00000751
		public Param_PFD(Stream input)
		{
			this.method_7(input);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007EFC File Offset: 0x000060FC
		public bool ValidTopHash(bool fix)
		{
			byte[] array = this.method_3();
			if (!Class1.smethod_4(array, Param_PFD.Struct4.byte_1))
			{
				if (!fix)
				{
					return false;
				}
				Param_PFD.Struct4.byte_1 = array;
			}
			return true;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007F2C File Offset: 0x0000612C
		public bool ValidBottomHash(bool fix)
		{
			byte[] array = this.method_4();
			if (!Class1.smethod_4(array, Param_PFD.Struct4.byte_0))
			{
				if (!fix)
				{
					return false;
				}
				Param_PFD.Struct4.byte_0 = array;
			}
			return true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007F5C File Offset: 0x0000615C
		public bool ValidFileCID(bool fix)
		{
			byte[] array = this.method_5();
			if (array == null)
			{
				return false;
			}
			List<int> list = new List<int>();
			foreach (Param_PFD.PFDEntry pfdentry in Param_PFD.Struct0.list_0)
			{
				list.Add((int)this.method_6(pfdentry.string_0));
			}
			for (int i = 0; i < Param_PFD.Struct1.list_0.Count; i++)
			{
				if (list.IndexOf(i) <= -1 && !Class1.smethod_4(array, Param_PFD.Struct1.list_0[i]))
				{
					if (!fix)
					{
						return false;
					}
					Param_PFD.Struct1.list_0[i] = array;
				}
			}
			return true;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00008014 File Offset: 0x00006214
		public bool ValidDHKCID2(bool fix)
		{
			for (int i = 0; i < Param_PFD.Struct0.list_0.Count; i++)
			{
				byte[] value = this.method_8(i);
				int index = (int)this.method_6(Param_PFD.Struct0.list_0[i].string_0);
				if (!Class1.smethod_4(value, Param_PFD.Struct1.list_0[index]))
				{
					if (!fix)
					{
						return false;
					}
					Param_PFD.Struct1.list_0[index] = value;
				}
			}
			return true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000807C File Offset: 0x0000627C
		public bool ValidEntryHash(Stream input, string entryname, bool fix)
		{
			if (!input.CanRead || !input.CanWrite)
			{
				throw new Exception("Unable to Access stream");
			}
			input.Position = 0L;
			foreach (Param_PFD.PFDEntry pfdentry in Param_PFD.Struct0.list_0)
			{
				if (entryname.ToLower() == pfdentry.string_0.ToLower())
				{
					if (pfdentry.string_0.ToLower() == "param.sfo")
					{
						Console.WriteLine("Here!");
					}
					for (int i = 0; i < 4; i++)
					{
						if ((!(pfdentry.string_0.ToLower() == "param.sfo") || i == 0) && (Param_PFD.bool_0 || i <= 0))
						{
							byte[] value = this.method_1(pfdentry, i);
							value = Class1.smethod_14(input, value);
							if (!Class1.smethod_4(value, pfdentry.list_0[i]))
							{
								if (!fix)
								{
									return false;
								}
								pfdentry.list_0[i] = value;
							}
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000081A0 File Offset: 0x000063A0
		public bool ValidEntryHash(string filepath, bool fix)
		{
			if (this.SecureFileID == null)
			{
				return false;
			}
			if (!File.Exists(filepath))
			{
				throw new Exception(filepath + " does not exist!");
			}
			string name = new FileInfo(filepath).Name;
			bool result = false;
			using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
			{
				result = this.ValidEntryHash(fileStream, name, fix);
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00008210 File Offset: 0x00006410
		public bool ValidAllEntryHashes(string rootdirectory, bool fix)
		{
			for (int i = 0; i < Param_PFD.Struct0.list_0.Count; i++)
			{
				string text = rootdirectory + "\\" + Param_PFD.Struct0.list_0[i].string_0;
				if (!File.Exists(text))
				{
					return false;
				}
				if (!this.ValidEntryHash(text, fix))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002560 File Offset: 0x00000760
		public bool ValidAllParamHashes(string rootdirectory, bool fix)
		{
			return this.ValidAllEntryHashes(rootdirectory, fix) && this.ValidDHKCID2(fix) && this.ValidFileCID(fix) && this.ValidTopHash(fix) && this.ValidBottomHash(fix);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002590 File Offset: 0x00000790
		public void INIT(string filepath)
		{
			this.method_7(new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00008268 File Offset: 0x00006468
		public bool RebuilParamPFD(string rootdirectory, bool encryptfiles)
		{
			bool result;
			try
			{
				if (!File.Exists(rootdirectory + "\\PARAM.SFO"))
				{
					result = false;
				}
				else
				{
					this.method_9("Rebuilding Param.PFD..", MessageType.Info);
					if (encryptfiles)
					{
						this.method_9("ReEncrypting Files..", MessageType.Info);
						if (this.EncryptAllFiles(rootdirectory) == -1)
						{
							return false;
						}
					}
					this.method_9("Validating Param.PFD Hashes..", MessageType.Info);
					if (!this.ValidAllParamHashes(rootdirectory, true))
					{
						result = false;
					}
					else
					{
						this.method_9("Writing new Param.PFD..", MessageType.Info);
						File.WriteAllBytes(rootdirectory + "\\PARAM.PFD", this.GetParamPFDCombinedData());
						this.method_9("Param.PFD Rebuilding complete! Rebuilded FilePath => " + rootdirectory + "\\PARAM.PFD", MessageType.Info);
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				this.method_9(ex.Message, MessageType.Error);
				result = false;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00008334 File Offset: 0x00006534
		public byte[] GetParamPFDCombinedData()
		{
			byte[] array = null;
			this.method_9("Rebuilding new Param.PFD..", MessageType.Info);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(Param_PFD.Struct3.ulong_0.smethod_3());
					binaryWriter.Write(Param_PFD.Struct3.ulong_1.smethod_3());
					binaryWriter.Write(Param_PFD.byte_0, 0, Param_PFD.byte_0.Length);
					array = Param_PFD.Struct4.smethod_0();
					array = Class1.smethod_6(Param_PFD.byte_0, array, array.Length);
					binaryWriter.Write(array, 0, array.Length);
					array = Param_PFD.Struct2.smethod_0();
					binaryWriter.Write(array, 0, array.Length);
					foreach (Param_PFD.PFDEntry pfdentry in Param_PFD.Struct0.list_0)
					{
						array = pfdentry.method_0();
						binaryWriter.Write(array, 0, array.Length);
					}
					array = new byte[272UL * (Param_PFD.Struct2.ulong_1 - Param_PFD.Struct2.ulong_2)];
					binaryWriter.Write(array, 0, array.Length);
					array = Param_PFD.Struct1.smethod_0();
					binaryWriter.Write(array, 0, array.Length);
					array = new byte[32768L - memoryStream.Length];
					if (array.Length > 0)
					{
						binaryWriter.Write(array, 0, array.Length);
					}
					array = memoryStream.ToArray();
					binaryWriter.Close();
				}
			}
			this.method_9("Rebuild Completed!", MessageType.Info);
			return array;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000084E0 File Offset: 0x000066E0
		public bool EntryExists(string name)
		{
			if (Param_PFD.Struct0.list_0 == null || Param_PFD.Struct0.list_0.Count == 0)
			{
				return false;
			}
			foreach (Param_PFD.PFDEntry pfdentry in Param_PFD.Struct0.list_0)
			{
				if (pfdentry.string_0.ToLower() == name.ToLower())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600003A RID: 58 RVA: 0x00008560 File Offset: 0x00006760
		// (remove) Token: 0x0600003B RID: 59 RVA: 0x00008598 File Offset: 0x00006798
		public event PS3Action ProgressChanged
		{
			add
			{
				PS3Action ps3Action = this.ps3Action_0;
				PS3Action ps3Action2;
				do
				{
					ps3Action2 = ps3Action;
					PS3Action value2 = (PS3Action)Delegate.Combine(ps3Action2, value);
					ps3Action = Interlocked.CompareExchange<PS3Action>(ref this.ps3Action_0, value2, ps3Action2);
				}
				while (ps3Action != ps3Action2);
			}
			remove
			{
				PS3Action ps3Action = this.ps3Action_0;
				PS3Action ps3Action2;
				do
				{
					ps3Action2 = ps3Action;
					PS3Action value2 = (PS3Action)Delegate.Remove(ps3Action2, value);
					ps3Action = Interlocked.CompareExchange<PS3Action>(ref this.ps3Action_0, value2, ps3Action2);
				}
				while (ps3Action != ps3Action2);
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000025A1 File Offset: 0x000007A1
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000025A8 File Offset: 0x000007A8
		public byte[] ConsoleID
		{
			get
			{
				return Param_PFD.byte_6;
			}
			set
			{
				if (value.Length != 32)
				{
					throw new Exception("ConsoleID must be 32 bytes in length");
				}
				Param_PFD.byte_6 = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000025C2 File Offset: 0x000007C2
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000025C9 File Offset: 0x000007C9
		public byte[] DiscHashKey
		{
			get
			{
				return Param_PFD.byte_10;
			}
			set
			{
				if (value.Length != 16)
				{
					throw new Exception("DiscHashKey must be 16 bytes in length");
				}
				Param_PFD.byte_10 = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000025E3 File Offset: 0x000007E3
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000025EA File Offset: 0x000007EA
		public byte[] AuthenticationID
		{
			get
			{
				return Param_PFD.byte_9;
			}
			set
			{
				if (value.Length != 8)
				{
					throw new Exception("AuthenticationID must be 8 bytes in length");
				}
				Param_PFD.byte_9 = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002603 File Offset: 0x00000803
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000260A File Offset: 0x0000080A
		public byte[] SecureFileID
		{
			get
			{
				return Param_PFD.byte_8;
			}
			set
			{
				if (value.Length != 16)
				{
					throw new Exception("SecureFileID must nbe 16 bytes in length");
				}
				Param_PFD.byte_8 = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000262B File Offset: 0x0000082B
		public byte[] UserID
		{
			get
			{
				return Param_PFD.byte_7;
			}
			set
			{
				if (value.Length != 8)
				{
					throw new Exception("UserID must be 8 bytes in length");
				}
				Param_PFD.byte_7 = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002644 File Offset: 0x00000844
		public Param_PFD.PFDEntry[] Entries
		{
			get
			{
				return Param_PFD.Struct0.list_0.ToArray();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000085D0 File Offset: 0x000067D0
		public byte[] Decrypt(Stream stream, string entryname)
		{
			if (this.SecureFileID != null)
			{
				if (this.SecureFileID.Length == 16)
				{
					Param_PFD.PFDEntry pfdentry = new Param_PFD.PFDEntry();
					bool flag = false;
					foreach (Param_PFD.PFDEntry pfdentry2 in Param_PFD.Struct0.list_0)
					{
						if (pfdentry2.string_0.ToLower() == entryname.ToLower())
						{
							pfdentry = pfdentry2;
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						throw new Exception("entryname does not exist inside the initialized Param.PFD");
					}
					if (!stream.CanRead || !stream.CanWrite)
					{
						throw new Exception("Unable to Access stream");
					}
					if (!this.ValidEntryHash(stream, entryname, false))
					{
						throw new Exception("Encrypted data seems to be invalid, a validated file is required for this operation");
					}
					int num = Param_PFD.vjuOqtnly((int)stream.Length);
					this.method_9("Allocating memory (" + num + " bytes)..", MessageType.Info);
					byte[] array = new byte[num];
					stream.Seek(0L, SeekOrigin.Begin);
					stream.Read(array, 0, array.Length);
					this.method_9("Allocating decryption key..", MessageType.Info);
					byte[] array2 = this.method_2(pfdentry);
					this.method_9("Decrypting data (" + num + " bytes)..", MessageType.Info);
					array = Class1.smethod_18(array2, array, num);
					if (array == null)
					{
						throw new Exception("Unable to decrypt data");
					}
					this.method_9("Free memory..", MessageType.Info);
					this.method_9("Resizing data to its original size..", MessageType.Info);
					Array.Resize<byte>(ref array, (int)pfdentry.ulong_1);
					return array;
				}
			}
			this.method_9((this.SecureFileID == null) ? "SecureFileID needed to preform the encryption!" : "SecureFileID is not valid! length must be 16 bytes long (128bit)", MessageType.Error);
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00008778 File Offset: 0x00006978
		public bool Decrypt(ref byte[] inputdata, string entryname)
		{
			bool result;
			try
			{
				byte[] array = this.Decrypt(new MemoryStream(inputdata), entryname);
				if (array == null)
				{
					result = false;
				}
				else
				{
					Array.Resize<byte>(ref inputdata, array.Length);
					Array.Copy(array, 0, inputdata, 0, array.Length);
					result = true;
				}
			}
			catch (Exception ex)
			{
				this.method_9(ex.Message, MessageType.Error);
				result = false;
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000087DC File Offset: 0x000069DC
		public bool Decrypt(string filepath)
		{
			bool result;
			try
			{
				if (!File.Exists(filepath) || !this.ValidEntryHash(filepath, false))
				{
					result = false;
				}
				else
				{
					string name = new FileInfo(filepath).Name;
					byte[] array = null;
					using (FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
					{
						array = this.Decrypt(fileStream, name);
						fileStream.Close();
					}
					if (array != null)
					{
						File.WriteAllBytes(filepath, array);
						array = null;
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				this.method_9(ex.Message, MessageType.Error);
				result = false;
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000887C File Offset: 0x00006A7C
		public bool Decrypt(string filepath, string outpath)
		{
			bool result;
			try
			{
				if (!File.Exists(filepath) || !this.ValidEntryHash(filepath, false))
				{
					result = false;
				}
				else
				{
					string name = new FileInfo(filepath).Name;
					FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
					byte[] bytes = this.Decrypt(fileStream, name);
					fileStream.Close();
					fileStream.Dispose();
					File.WriteAllBytes(outpath, bytes);
					result = true;
				}
			}
			catch (Exception ex)
			{
				this.method_9(ex.Message, MessageType.Error);
				result = false;
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00008900 File Offset: 0x00006B00
		public int DecryptAllFiles(string root)
		{
			int result;
			try
			{
				int num = 0;
				foreach (Param_PFD.PFDEntry pfdentry in Param_PFD.Struct0.list_0)
				{
					if (!(pfdentry.string_0.ToLower() == "param.sfo"))
					{
						string text = root + "\\" + pfdentry.string_0;
						if (File.Exists(text) && this.ValidEntryHash(text, false) && this.Decrypt(text))
						{
							num++;
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				this.method_9(ex.Message, MessageType.Error);
				result = -1;
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000089C0 File Offset: 0x00006BC0
		public byte[] DecryptToBytes(string filepath)
		{
			if (!File.Exists(filepath))
			{
				return null;
			}
			string name = new FileInfo(filepath).Name;
			FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			byte[] result = this.Decrypt(fileStream, name);
			fileStream.Close();
			fileStream.Dispose();
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008A04 File Offset: 0x00006C04
		public Stream DecryptToStream(string filepath)
		{
			byte[] array = this.DecryptToBytes(filepath);
			if (array == null)
			{
				return null;
			}
			return new MemoryStream(array);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00008A24 File Offset: 0x00006C24
		public byte[] Encrypt(Stream stream, string entryname)
		{
			if (this.SecureFileID != null)
			{
				if (this.SecureFileID.Length == 16)
				{
					if (this.ValidEntryHash(stream, entryname, false))
					{
						this.method_9("File already valid, same data will be returned instead", MessageType.Info);
						byte[] array = new byte[stream.Length];
						stream.Seek(0L, SeekOrigin.Begin);
						stream.Read(array, 0, array.Length);
						return array;
					}
					Param_PFD.PFDEntry pfdentry = new Param_PFD.PFDEntry();
					bool flag = false;
					foreach (Param_PFD.PFDEntry pfdentry2 in Param_PFD.Struct0.list_0)
					{
						if (pfdentry2.string_0.ToLower() == entryname.ToLower())
						{
							pfdentry = pfdentry2;
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						throw new Exception("entryname does not exist inside the initialized Param.PFD");
					}
					if (!stream.CanRead || !stream.CanWrite)
					{
						throw new Exception("Unable to Access stream");
					}
					pfdentry.ulong_1 = (ulong)stream.Length;
					stream.Seek(0L, SeekOrigin.Begin);
					int num = Param_PFD.vjuOqtnly((int)stream.Length);
					this.method_9("Allocating memory (" + num + " bytes)..", MessageType.Info);
					byte[] array2 = new byte[num];
					this.method_9("Reading stream into memory..", MessageType.Info);
					stream.Read(array2, 0, (int)stream.Length);
					this.method_9("Allocating encryption key..", MessageType.Info);
					byte[] array3 = this.method_2(pfdentry);
					this.method_9("Encrypting Data (" + num + "bytes)..", MessageType.Info);
					array2 = Class1.smethod_19(array3, array2, array2.Length);
					if (array2 == null)
					{
						throw new Exception("Unable to decrypt data");
					}
					this.method_9("Free allocated memory..", MessageType.Info);
					return array2;
				}
			}
			this.method_9((this.SecureFileID == null) ? "SecureFileID needed to preform the encryption!" : "SecureFileID is not valid! length must be 16 bytes long (128bit)", MessageType.Error);
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008C04 File Offset: 0x00006E04
		public bool Encrypt(byte[] inputdata, Ps3File entry)
		{
			bool result;
			try
			{
				entry.PFDEntry.ulong_1 = (ulong)((long)inputdata.Length);
				byte[] array = this.Encrypt(new MemoryStream(inputdata), entry.PFDEntry.string_0);
				if (array == null)
				{
					result = false;
				}
				else
				{
					File.WriteAllBytes(entry.FilePath, array);
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00008C68 File Offset: 0x00006E68
		public bool Encrypt(string filepath)
		{
			bool result;
			try
			{
				if (!File.Exists(filepath))
				{
					this.method_9(filepath + " Does not exist!", MessageType.Error);
					result = false;
				}
				else
				{
					string name = new FileInfo(filepath).Name;
					if (!this.EntryExists(name))
					{
						this.method_9("There is no \"" + name + "\" inside the PARAM.PFD Entries!", MessageType.Error);
						result = false;
					}
					else
					{
						this.method_9("Initializing file stream..", MessageType.Info);
						byte[] array = null;
						using (FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
						{
							for (int i = 0; i < Param_PFD.Struct0.list_0.Count; i++)
							{
								if (Param_PFD.Struct0.list_0[i].string_0.ToLower() == name.ToLower())
								{
									Param_PFD.PFDEntry pfdentry = Param_PFD.Struct0.list_0[i];
									pfdentry.ulong_1 = (ulong)fileStream.Length;
									Param_PFD.Struct0.list_0[i] = pfdentry;
									break;
								}
							}
							array = this.Encrypt(fileStream, name);
							fileStream.Dispose();
						}
						if (array == null)
						{
							result = false;
						}
						else
						{
							this.method_9("Writing Encrypted data to : " + filepath, MessageType.Info);
							File.WriteAllBytes(filepath, array);
							this.method_9(name + " is succesfully encrypted", MessageType.Info);
							result = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.method_9(ex.Message, MessageType.Error);
				result = false;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public bool Encrypt(string filepath, string newfilepath)
		{
			bool result;
			try
			{
				if (!File.Exists(filepath))
				{
					result = false;
				}
				else
				{
					string name = new FileInfo(filepath).Name;
					this.method_9("Encrypting " + name + "..", MessageType.Info);
					FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
					byte[] bytes = this.Encrypt(fileStream, name);
					fileStream.Close();
					fileStream.Dispose();
					this.method_9("Encrypting " + name + "..", MessageType.Info);
					File.WriteAllBytes(newfilepath, bytes);
					if (filepath == newfilepath)
					{
						result = this.ValidEntryHash(filepath, true);
					}
					else
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00008E8C File Offset: 0x0000708C
		public int EncryptAllFiles(string root)
		{
			int result;
			try
			{
				int num = 0;
				for (int i = 0; i < Param_PFD.Struct0.list_0.Count; i++)
				{
					Param_PFD.PFDEntry pfdentry = Param_PFD.Struct0.list_0[i];
					if (!(pfdentry.string_0.ToLower() == "param.sfo"))
					{
						string text = root + "\\" + pfdentry.string_0;
						if (File.Exists(text) && !this.ValidEntryHash(text, false) && this.Encrypt(text))
						{
							if (!this.ValidEntryHash(text, true))
							{
								return -1;
							}
							num++;
						}
					}
				}
				result = num;
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008F34 File Offset: 0x00007134
		public byte[] EncryptToBytes(string filepath)
		{
			if (!File.Exists(filepath))
			{
				return null;
			}
			string name = new FileInfo(filepath).Name;
			FileStream fileStream = File.Open(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			byte[] result = this.Encrypt(fileStream, name);
			fileStream.Close();
			fileStream.Dispose();
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008F78 File Offset: 0x00007178
		public Stream EncryptToStream(string filepath)
		{
			byte[] array = this.EncryptToBytes(filepath);
			if (array == null)
			{
				return null;
			}
			return new MemoryStream(array);
		}

		// Token: 0x04000008 RID: 8
		internal static bool bool_0 = false;

		// Token: 0x04000009 RID: 9
		internal static byte[] byte_0 = new byte[16];

		// Token: 0x0400000A RID: 10
		internal static byte[] byte_1 = new byte[16];

		// Token: 0x0400000B RID: 11
		internal static byte[] byte_2 = new byte[20];

		// Token: 0x0400000C RID: 12
		internal static byte[] byte_3 = new byte[20];

		// Token: 0x0400000D RID: 13
		internal static byte[] byte_4 = new byte[64];

		// Token: 0x0400000E RID: 14
		internal static byte[] byte_5 = new byte[20];

		// Token: 0x0400000F RID: 15
		internal static byte[] byte_6 = new byte[32];

		// Token: 0x04000010 RID: 16
		internal static byte[] byte_7 = new byte[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1
		};

		// Token: 0x04000011 RID: 17
		internal static byte[] byte_8;

		// Token: 0x04000012 RID: 18
		internal static byte[] byte_9 = new byte[]
		{
			16,
			16,
			0,
			0,
			1,
			0,
			0,
			3
		};

		// Token: 0x04000013 RID: 19
		internal static byte[] byte_10 = new byte[]
		{
			209,
			193,
			225,
			11,
			156,
			84,
			126,
			104,
			155,
			128,
			93,
			205,
			151,
			16,
			206,
			141
		};

		// Token: 0x04000014 RID: 20
		private PS3Action ps3Action_0;

		// Token: 0x02000008 RID: 8
		internal struct Struct0
		{
			// Token: 0x04000015 RID: 21
			internal static List<Param_PFD.PFDEntry> list_0;
		}

		// Token: 0x02000009 RID: 9
		public class PFDEntry
		{
			// Token: 0x06000056 RID: 86 RVA: 0x00009040 File Offset: 0x00007240
			internal byte[] method_0()
			{
				MemoryStream memoryStream = new MemoryStream();
				byte[] result;
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(this.ulong_0.smethod_3());
					byte[] array = new byte[65];
					Array.Copy(Encoding.ASCII.GetBytes(this.string_0), 0, array, 0, this.string_0.Length);
					binaryWriter.Write(array, 0, array.Length);
					binaryWriter.Write(this.byte_0, 0, this.byte_0.Length);
					binaryWriter.Write(this.byte_2, 0, this.byte_2.Length);
					for (int i = 0; i < this.list_0.Count; i++)
					{
						binaryWriter.Write(this.list_0[i], 0, this.list_0[i].Length);
					}
					binaryWriter.Write(this.byte_1, 0, this.byte_1.Length);
					binaryWriter.Write(this.ulong_1.smethod_3());
					result = memoryStream.ToArray();
				}
				return result;
			}

			// Token: 0x06000057 RID: 87 RVA: 0x00009150 File Offset: 0x00007350
			internal byte[] method_1()
			{
				MemoryStream memoryStream = new MemoryStream();
				byte[] result;
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					byte[] array = new byte[65];
					Array.Copy(Encoding.ASCII.GetBytes(this.string_0), 0, array, 0, this.string_0.Length);
					binaryWriter.Write(array, 0, array.Length);
					binaryWriter.Write(this.byte_2, 0, this.byte_2.Length);
					for (int i = 0; i < this.list_0.Count; i++)
					{
						binaryWriter.Write(this.list_0[i], 0, this.list_0[i].Length);
					}
					binaryWriter.Write(this.byte_1, 0, this.byte_1.Length);
					binaryWriter.Write(this.ulong_1.smethod_3());
					result = memoryStream.ToArray();
				}
				return result;
			}

			// Token: 0x04000016 RID: 22
			internal byte[] byte_0;

			// Token: 0x04000017 RID: 23
			internal byte[] byte_1;

			// Token: 0x04000018 RID: 24
			internal ulong ulong_0;

			// Token: 0x04000019 RID: 25
			internal List<byte[]> list_0;

			// Token: 0x0400001A RID: 26
			internal string string_0;

			// Token: 0x0400001B RID: 27
			internal ulong ulong_1;

			// Token: 0x0400001C RID: 28
			internal byte[] byte_2;
		}

		// Token: 0x0200000A RID: 10
		internal struct Struct1
		{
			// Token: 0x06000059 RID: 89 RVA: 0x00009238 File Offset: 0x00007438
			internal static byte[] smethod_0()
			{
				byte[] array = new byte[Param_PFD.Struct1.list_0.Count * 20];
				for (int i = 0; i < Param_PFD.Struct1.list_0.Count; i++)
				{
					Array.Copy(Param_PFD.Struct1.list_0[i], 0, array, i * 20, 20);
				}
				return array;
			}

			// Token: 0x0400001D RID: 29
			internal static List<byte[]> list_0 = new List<byte[]>();
		}

		// Token: 0x0200000B RID: 11
		internal struct Struct2
		{
			// Token: 0x0600005B RID: 91 RVA: 0x00009288 File Offset: 0x00007488
			public static byte[] smethod_0()
			{
				MemoryStream memoryStream = new MemoryStream();
				byte[] result;
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(Param_PFD.Struct2.ulong_0.smethod_3());
					binaryWriter.Write(Param_PFD.Struct2.ulong_1.smethod_3());
					binaryWriter.Write(Param_PFD.Struct2.ulong_2.smethod_3());
					foreach (ulong num in Param_PFD.Struct2.list_0)
					{
						binaryWriter.Write(num.smethod_3());
					}
					result = memoryStream.ToArray();
				}
				return result;
			}

			// Token: 0x0400001E RID: 30
			public static ulong ulong_0 = 0UL;

			// Token: 0x0400001F RID: 31
			public static ulong ulong_1 = 0UL;

			// Token: 0x04000020 RID: 32
			public static ulong ulong_2 = 0UL;

			// Token: 0x04000021 RID: 33
			public static List<ulong> list_0 = new List<ulong>();
		}

		// Token: 0x0200000C RID: 12
		internal struct Struct3
		{
			// Token: 0x04000022 RID: 34
			internal static ulong ulong_0;

			// Token: 0x04000023 RID: 35
			internal static ulong ulong_1;
		}

		// Token: 0x0200000D RID: 13
		internal struct Struct4
		{
			// Token: 0x0600005D RID: 93 RVA: 0x00009340 File Offset: 0x00007540
			internal static byte[] smethod_0()
			{
				byte[] array = new byte[64];
				Array.Copy(Param_PFD.Struct4.byte_0, 0, array, 0, 20);
				Array.Copy(Param_PFD.Struct4.byte_1, 0, array, 20, 20);
				Array.Copy(Param_PFD.Struct4.byte_2, 0, array, 40, 20);
				Array.Copy(Param_PFD.Struct4.byte_3, 0, array, 60, 4);
				return array;
			}

			// Token: 0x04000024 RID: 36
			internal static byte[] byte_0;

			// Token: 0x04000025 RID: 37
			internal static byte[] byte_1;

			// Token: 0x04000026 RID: 38
			internal static byte[] byte_2;

			// Token: 0x04000027 RID: 39
			internal static byte[] byte_3;
		}
	}
}
