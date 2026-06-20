using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D6 RID: 214
	[DataContract]
	public class SignText
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00006B76 File Offset: 0x00004D76
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00006B7E File Offset: 0x00004D7E
		public bool italic
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00006B87 File Offset: 0x00004D87
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00006B8F File Offset: 0x00004D8F
		public bool underlined
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00006B98 File Offset: 0x00004D98
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public bool strikethrough
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00006BA9 File Offset: 0x00004DA9
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00006BB1 File Offset: 0x00004DB1
		public bool obfuscated
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				this.bool_4 = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00006BBA File Offset: 0x00004DBA
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00006BC2 File Offset: 0x00004DC2
		public bool bold
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00006BCB File Offset: 0x00004DCB
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00006BD3 File Offset: 0x00004DD3
		public string color
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00006BDC File Offset: 0x00004DDC
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00006BE4 File Offset: 0x00004DE4
		public string text
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00006BED File Offset: 0x00004DED
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00006BF5 File Offset: 0x00004DF5
		public List<SignText> extra
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00046FA4 File Offset: 0x000451A4
		public string ToConsole()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.method_0());
			stringBuilder.Append(this.text);
			if (this.extra != null && this.extra.Count > 0)
			{
				foreach (SignText signText in this.extra)
				{
					string value = signText.ToConsole();
					stringBuilder.Append(value);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0004703C File Offset: 0x0004523C
		private string method_0()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.bool_0)
			{
				stringBuilder.Append("§l");
			}
			if (this.bool_1)
			{
				stringBuilder.Append("§o");
			}
			if (this.bool_2)
			{
				stringBuilder.Append("§n");
			}
			if (this.bool_3)
			{
				stringBuilder.Append("§m");
			}
			if (this.bool_4)
			{
				stringBuilder.Append("§k");
			}
			if (this.string_0 != null && SignText.dictionary_0.ContainsKey(this.string_0))
			{
				stringBuilder.Append(SignText.dictionary_0[this.string_0]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400062B RID: 1579
		private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>
		{
			{
				"black",
				"§0"
			},
			{
				"dark_blue",
				"§1"
			},
			{
				"dark_green",
				"§2"
			},
			{
				"dark_aqua",
				"§3"
			},
			{
				"dark_red",
				"§4"
			},
			{
				"dark_purple",
				"§5"
			},
			{
				"gold",
				"§6"
			},
			{
				"gray",
				"§7"
			},
			{
				"dark_gray",
				"§8"
			},
			{
				"blue",
				"§9"
			},
			{
				"green",
				"§a"
			},
			{
				"aqua",
				"§b"
			},
			{
				"red",
				"§c"
			},
			{
				"light_purple",
				"§d"
			},
			{
				"yellow",
				"§e"
			},
			{
				"white",
				"§f"
			}
		};

		// Token: 0x0400062C RID: 1580
		private bool bool_0;

		// Token: 0x0400062D RID: 1581
		private bool bool_1;

		// Token: 0x0400062E RID: 1582
		private bool bool_2;

		// Token: 0x0400062F RID: 1583
		private bool bool_3;

		// Token: 0x04000630 RID: 1584
		private bool bool_4;

		// Token: 0x04000631 RID: 1585
		private string string_0;

		// Token: 0x04000632 RID: 1586
		private string string_1;

		// Token: 0x04000633 RID: 1587
		private List<SignText> list_0;
	}
}
