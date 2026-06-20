using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PS3FileSystem
{
	// Token: 0x02000016 RID: 22
	public class Ps3Save_Manager
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		public Ps3Save_Manager(string savedir, byte[] securefileid)
		{
			Ps3Save_Manager <>4__this = this;
			if (!Directory.Exists(savedir))
			{
				throw new Exception("No such directory exist!");
			}
			if (!File.Exists(savedir + "\\PARAM.PFD"))
			{
				throw new Exception("Rootdirectory does not contain any PARAM.PFD, Please load a valid directory");
			}
			if (!File.Exists(savedir + "\\PARAM.SFO"))
			{
				throw new Exception("Rootdirectory does not contain any PARAM.SFO, Please load a valid directory");
			}
			this.Param_PFD = new Param_PFD(savedir + "\\PARAM.PFD");
			this.Param_SFO = new PARAM_SFO(savedir + "\\PARAM.SFO");
			if (securefileid != null)
			{
				this.Param_PFD.SecureFileID = securefileid;
			}
			this.RootPath = savedir;
			if (File.Exists(savedir + "\\ICON0.PNG"))
			{
				this.SaveImage = Image.FromStream(new MemoryStream(File.ReadAllBytes(savedir + "\\ICON0.PNG")));
			}
			var source = from ent in this.Param_PFD.Entries
			select new
			{
				ent = ent,
				x = new FileInfo(savedir + "\\" + ent.string_0)
			};
			if (Ps3Save_Manager.func_0 == null)
			{
				Ps3Save_Manager.func_0 = new Func<<>f__AnonymousType0<Param_PFD.PFDEntry, FileInfo>, bool>(Ps3Save_Manager.smethod_0);
			}
			this.Files = (from <>h__TransparentIdentifier0 in source.Where(Ps3Save_Manager.func_0)
			select new Ps3File(savedir + "\\" + <>h__TransparentIdentifier0.ent.string_0, <>h__TransparentIdentifier0.ent, <>4__this)).ToArray<Ps3File>();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000293F File Offset: 0x00000B3F
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002947 File Offset: 0x00000B47
		public string RootPath { get; private set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002950 File Offset: 0x00000B50
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002958 File Offset: 0x00000B58
		public Param_PFD Param_PFD { get; private set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002961 File Offset: 0x00000B61
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002969 File Offset: 0x00000B69
		public PARAM_SFO Param_SFO { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002972 File Offset: 0x00000B72
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000297A File Offset: 0x00000B7A
		public Ps3File[] Files { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002983 File Offset: 0x00000B83
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000298B File Offset: 0x00000B8B
		public Image SaveImage { get; private set; }

		// Token: 0x060000AA RID: 170 RVA: 0x0000C448 File Offset: 0x0000A648
		public int DecryptAllFiles()
		{
			int result;
			try
			{
				if (this.Param_PFD == null || !Directory.Exists(this.RootPath))
				{
					result = -1;
				}
				else
				{
					result = this.Param_PFD.DecryptAllFiles(this.RootPath);
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000C49C File Offset: 0x0000A69C
		public int EncryptAllFiles()
		{
			int result;
			try
			{
				if (this.Param_PFD == null || !Directory.Exists(this.RootPath))
				{
					result = -1;
				}
				else
				{
					int num = this.Param_PFD.EncryptAllFiles(this.RootPath);
					if (num <= 0 || !this.Param_PFD.RebuilParamPFD(this.RootPath, false))
					{
						result = -1;
					}
					else
					{
						result = num;
					}
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002994 File Offset: 0x00000B94
		public bool ReBuildChanges()
		{
			return this.Param_PFD.RebuilParamPFD(this.RootPath, false);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000029A8 File Offset: 0x00000BA8
		public bool ReBuildChanges(bool encryptfiles)
		{
			return this.Param_PFD.RebuilParamPFD(this.RootPath, encryptfiles);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000C50C File Offset: 0x0000A70C
		public int LoadGameConfigFile(string filepath)
		{
			int result;
			try
			{
				string text = "";
				using (StreamReader streamReader = new StreamReader(new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read)))
				{
					text = streamReader.ReadToEnd();
					streamReader.Close();
				}
				result = (Ps3Save_Manager.GameConfigList = Class1.smethod_10(text)).Length;
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000C57C File Offset: 0x0000A77C
		private byte[] method_0(string string_1)
		{
			if (Ps3Save_Manager.GameConfigList == null || Ps3Save_Manager.GameConfigList.Length == 0)
			{
				return null;
			}
			IEnumerable<SecureFileInfo> gameConfigList = Ps3Save_Manager.GameConfigList;
			if (Ps3Save_Manager.func_1 == null)
			{
				Ps3Save_Manager.func_1 = new Func<SecureFileInfo, IEnumerable<string>>(Ps3Save_Manager.smethod_1);
			}
			Func<SecureFileInfo, IEnumerable<string>> collectionSelector = Ps3Save_Manager.func_1;
			if (Ps3Save_Manager.func_2 == null)
			{
				Ps3Save_Manager.func_2 = new Func<SecureFileInfo, string, <>f__AnonymousType1<SecureFileInfo, string>>(Ps3Save_Manager.smethod_2);
			}
			var source = from <>h__TransparentIdentifier9 in gameConfigList.SelectMany(collectionSelector, Ps3Save_Manager.func_2)
			where <>h__TransparentIdentifier9.s.ToLower() == string_1.ToLower()
			select <>h__TransparentIdentifier9;
			if (Ps3Save_Manager.func_3 == null)
			{
				Ps3Save_Manager.func_3 = new Func<<>f__AnonymousType1<SecureFileInfo, string>, bool>(Ps3Save_Manager.smethod_3);
			}
			var source2 = source.Where(Ps3Save_Manager.func_3);
			if (Ps3Save_Manager.func_4 == null)
			{
				Ps3Save_Manager.func_4 = new Func<<>f__AnonymousType1<SecureFileInfo, string>, byte[]>(Ps3Save_Manager.smethod_4);
			}
			return source2.Select(Ps3Save_Manager.func_4).FirstOrDefault<byte[]>();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000029BC File Offset: 0x00000BBC
		[CompilerGenerated]
		private static bool smethod_0(<>f__AnonymousType0<Param_PFD.PFDEntry, FileInfo> <>f__AnonymousType0_0)
		{
			return <>f__AnonymousType0_0.x.Extension.ToUpper() != ".PFD" && <>f__AnonymousType0_0.x.Extension.ToUpper() != ".SFO";
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000029F6 File Offset: 0x00000BF6
		[CompilerGenerated]
		private static IEnumerable<string> smethod_1(SecureFileInfo secureFileInfo_0)
		{
			return secureFileInfo_0.GameIDs;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000029FE File Offset: 0x00000BFE
		[CompilerGenerated]
		private static <>f__AnonymousType1<SecureFileInfo, string> smethod_2(SecureFileInfo secureFileInfo_0, string string_1)
		{
			return new
			{
				i = secureFileInfo_0,
				s = string_1
			};
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002A07 File Offset: 0x00000C07
		[CompilerGenerated]
		private static bool smethod_3(<>f__AnonymousType1<SecureFileInfo, string> <>f__AnonymousType1_0)
		{
			return <>f__AnonymousType1_0.i.SecureFileID != null && <>f__AnonymousType1_0.i.SecureFileID.Length == 32;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002A2C File Offset: 0x00000C2C
		[CompilerGenerated]
		private static byte[] smethod_4(<>f__AnonymousType1<SecureFileInfo, string> <>f__AnonymousType1_0)
		{
			return <>f__AnonymousType1_0.i.SecureFileID.smethod_7();
		}

		// Token: 0x04000060 RID: 96
		public static SecureFileInfo[] GameConfigList;

		// Token: 0x04000061 RID: 97
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private Param_PFD param_PFD_0;

		// Token: 0x04000063 RID: 99
		[CompilerGenerated]
		private PARAM_SFO param_SFO_0;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		private Ps3File[] ps3File_0;

		// Token: 0x04000065 RID: 101
		[CompilerGenerated]
		private Image image_0;

		// Token: 0x04000066 RID: 102
		[CompilerGenerated]
		private static Func<<>f__AnonymousType0<Param_PFD.PFDEntry, FileInfo>, bool> func_0;

		// Token: 0x04000067 RID: 103
		[CompilerGenerated]
		private static Func<SecureFileInfo, IEnumerable<string>> func_1;

		// Token: 0x04000068 RID: 104
		[CompilerGenerated]
		private static Func<SecureFileInfo, string, <>f__AnonymousType1<SecureFileInfo, string>> func_2;

		// Token: 0x04000069 RID: 105
		[CompilerGenerated]
		private static Func<<>f__AnonymousType1<SecureFileInfo, string>, bool> func_3;

		// Token: 0x0400006A RID: 106
		[CompilerGenerated]
		private static Func<<>f__AnonymousType1<SecureFileInfo, string>, byte[]> func_4;
	}
}
