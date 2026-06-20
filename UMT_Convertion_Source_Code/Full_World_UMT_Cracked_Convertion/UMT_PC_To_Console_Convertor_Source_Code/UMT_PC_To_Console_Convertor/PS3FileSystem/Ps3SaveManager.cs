using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PS3FileSystem
{
	// Token: 0x02000015 RID: 21
	public class Ps3SaveManager
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00009BCC File Offset: 0x00007DCC
		public Ps3SaveManager(string savedir, byte[] securefileid)
		{
			Ps3SaveManager <>4__this = this;
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
			if (Ps3SaveManager.func_0 == null)
			{
				Ps3SaveManager.func_0 = new Func<<>f__AnonymousType0<Param_PFD.PFDEntry, FileInfo>, bool>(Ps3SaveManager.smethod_0);
			}
			this.Files = (from <>h__TransparentIdentifier0 in source.Where(Ps3SaveManager.func_0)
			select new Ps3File(savedir + "\\" + <>h__TransparentIdentifier0.ent.string_0, <>h__TransparentIdentifier0.ent, <>4__this)).ToArray<Ps3File>();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000027EA File Offset: 0x000009EA
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000027F2 File Offset: 0x000009F2
		public string RootPath { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000027FB File Offset: 0x000009FB
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002803 File Offset: 0x00000A03
		public Param_PFD Param_PFD { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000280C File Offset: 0x00000A0C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002814 File Offset: 0x00000A14
		public PARAM_SFO Param_SFO { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000281D File Offset: 0x00000A1D
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002825 File Offset: 0x00000A25
		public Ps3File[] Files { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000282E File Offset: 0x00000A2E
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002836 File Offset: 0x00000A36
		public Image SaveImage { get; private set; }

		// Token: 0x0600008F RID: 143 RVA: 0x00009D44 File Offset: 0x00007F44
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

		// Token: 0x06000090 RID: 144 RVA: 0x00009D98 File Offset: 0x00007F98
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

		// Token: 0x06000091 RID: 145 RVA: 0x0000283F File Offset: 0x00000A3F
		public bool ReBuildChanges()
		{
			return this.Param_PFD.RebuilParamPFD(this.RootPath, false);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002853 File Offset: 0x00000A53
		public bool ReBuildChanges(bool encryptfiles)
		{
			return this.Param_PFD.RebuilParamPFD(this.RootPath, encryptfiles);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009E08 File Offset: 0x00008008
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
				result = (Ps3SaveManager.GameConfigList = Class1.smethod_10(text)).Length;
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009E78 File Offset: 0x00008078
		private byte[] method_0(string string_1)
		{
			if (Ps3SaveManager.GameConfigList == null || Ps3SaveManager.GameConfigList.Length == 0)
			{
				return null;
			}
			IEnumerable<SecureFileInfo> gameConfigList = Ps3SaveManager.GameConfigList;
			if (Ps3SaveManager.func_1 == null)
			{
				Ps3SaveManager.func_1 = new Func<SecureFileInfo, IEnumerable<string>>(Ps3SaveManager.smethod_1);
			}
			Func<SecureFileInfo, IEnumerable<string>> collectionSelector = Ps3SaveManager.func_1;
			if (Ps3SaveManager.func_2 == null)
			{
				Ps3SaveManager.func_2 = new Func<SecureFileInfo, string, <>f__AnonymousType1<SecureFileInfo, string>>(Ps3SaveManager.smethod_2);
			}
			var source = from <>h__TransparentIdentifier9 in gameConfigList.SelectMany(collectionSelector, Ps3SaveManager.func_2)
			where <>h__TransparentIdentifier9.s.ToLower() == string_1.ToLower()
			select <>h__TransparentIdentifier9;
			if (Ps3SaveManager.func_3 == null)
			{
				Ps3SaveManager.func_3 = new Func<<>f__AnonymousType1<SecureFileInfo, string>, bool>(Ps3SaveManager.smethod_3);
			}
			var source2 = source.Where(Ps3SaveManager.func_3);
			if (Ps3SaveManager.func_4 == null)
			{
				Ps3SaveManager.func_4 = new Func<<>f__AnonymousType1<SecureFileInfo, string>, byte[]>(Ps3SaveManager.smethod_4);
			}
			return source2.Select(Ps3SaveManager.func_4).FirstOrDefault<byte[]>();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002867 File Offset: 0x00000A67
		[CompilerGenerated]
		private static bool smethod_0(<>f__AnonymousType0<Param_PFD.PFDEntry, FileInfo> <>f__AnonymousType0_0)
		{
			return <>f__AnonymousType0_0.x.Extension.ToUpper() != ".PFD" && <>f__AnonymousType0_0.x.Extension.ToUpper() != ".SFO";
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000028A1 File Offset: 0x00000AA1
		[CompilerGenerated]
		private static IEnumerable<string> smethod_1(SecureFileInfo secureFileInfo_0)
		{
			return secureFileInfo_0.GameIDs;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000028A9 File Offset: 0x00000AA9
		[CompilerGenerated]
		private static <>f__AnonymousType1<SecureFileInfo, string> smethod_2(SecureFileInfo secureFileInfo_0, string string_1)
		{
			return new
			{
				i = secureFileInfo_0,
				s = string_1
			};
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000028B2 File Offset: 0x00000AB2
		[CompilerGenerated]
		private static bool smethod_3(<>f__AnonymousType1<SecureFileInfo, string> <>f__AnonymousType1_0)
		{
			return <>f__AnonymousType1_0.i.SecureFileID != null && <>f__AnonymousType1_0.i.SecureFileID.Length == 32;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000028D7 File Offset: 0x00000AD7
		[CompilerGenerated]
		private static byte[] smethod_4(<>f__AnonymousType1<SecureFileInfo, string> <>f__AnonymousType1_0)
		{
			return <>f__AnonymousType1_0.i.SecureFileID.smethod_7();
		}

		// Token: 0x04000053 RID: 83
		public static SecureFileInfo[] GameConfigList;

		// Token: 0x04000054 RID: 84
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000055 RID: 85
		[CompilerGenerated]
		private Param_PFD param_PFD_0;

		// Token: 0x04000056 RID: 86
		[CompilerGenerated]
		private PARAM_SFO param_SFO_0;

		// Token: 0x04000057 RID: 87
		[CompilerGenerated]
		private Ps3File[] ps3File_0;

		// Token: 0x04000058 RID: 88
		[CompilerGenerated]
		private Image image_0;

		// Token: 0x04000059 RID: 89
		[CompilerGenerated]
		private static Func<<>f__AnonymousType0<Param_PFD.PFDEntry, FileInfo>, bool> func_0;

		// Token: 0x0400005A RID: 90
		[CompilerGenerated]
		private static Func<SecureFileInfo, IEnumerable<string>> func_1;

		// Token: 0x0400005B RID: 91
		[CompilerGenerated]
		private static Func<SecureFileInfo, string, <>f__AnonymousType1<SecureFileInfo, string>> func_2;

		// Token: 0x0400005C RID: 92
		[CompilerGenerated]
		private static Func<<>f__AnonymousType1<SecureFileInfo, string>, bool> func_3;

		// Token: 0x0400005D RID: 93
		[CompilerGenerated]
		private static Func<<>f__AnonymousType1<SecureFileInfo, string>, byte[]> func_4;
	}
}
