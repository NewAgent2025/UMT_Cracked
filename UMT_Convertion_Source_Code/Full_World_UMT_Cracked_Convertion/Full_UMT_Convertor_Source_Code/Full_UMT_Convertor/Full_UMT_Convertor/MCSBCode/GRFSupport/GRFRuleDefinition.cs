using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.MCSBCode.GRFSupport
{
	// Token: 0x02000086 RID: 134
	public class GRFRuleDefinition
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00004D69 File Offset: 0x00002F69
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00004D71 File Offset: 0x00002F71
		public string Name
		{
			get
			{
				return this.AgOswnryAp;
			}
			set
			{
				this.AgOswnryAp = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00004D7A File Offset: 0x00002F7A
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00004D82 File Offset: 0x00002F82
		public bool IsContainer
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
		public static List<GRFRuleDefinition> ReadUserRuleDefs()
		{
			List<GRFRuleDefinition> list = new List<GRFRuleDefinition>();
			string path = GRFRuleDefinition.smethod_0();
			if (File.Exists(path))
			{
				StreamReader streamReader = new StreamReader(path);
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					string[] array = text.Split(new char[]
					{
						','
					});
					if (array.Length > 0 && !string.IsNullOrWhiteSpace(array[0].Trim()))
					{
						GRFRuleDefinition grfruleDefinition = new GRFRuleDefinition();
						grfruleDefinition.Name = array[0].Trim();
						if (array.Length > 1)
						{
							grfruleDefinition.IsContainer = (array[1].Trim().ToLower() == "true");
						}
						list.Add(grfruleDefinition);
					}
				}
				streamReader.Close();
			}
			return list;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002D55C File Offset: 0x0002B75C
		private static string smethod_0()
		{
			string libraryFolder = Utils.GetLibraryFolder();
			return libraryFolder + "grfRules.txt";
		}

		// Token: 0x04000377 RID: 887
		private string AgOswnryAp;

		// Token: 0x04000378 RID: 888
		private bool bool_0;
	}
}
