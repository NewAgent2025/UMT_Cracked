using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000092 RID: 146
	[DataContract]
	public class SignText
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000059BC File Offset: 0x00003BBC
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x000059C4 File Offset: 0x00003BC4
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000059CD File Offset: 0x00003BCD
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x000059D5 File Offset: 0x00003BD5
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000059DE File Offset: 0x00003BDE
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x000059E6 File Offset: 0x00003BE6
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000059EF File Offset: 0x00003BEF
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x000059F7 File Offset: 0x00003BF7
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00005A00 File Offset: 0x00003C00
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00005A08 File Offset: 0x00003C08
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00005A11 File Offset: 0x00003C11
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00005A19 File Offset: 0x00003C19
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00005A22 File Offset: 0x00003C22
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00005A2A File Offset: 0x00003C2A
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00005A33 File Offset: 0x00003C33
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00005A3B File Offset: 0x00003C3B
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

		// Token: 0x06000679 RID: 1657 RVA: 0x0002A49C File Offset: 0x0002869C
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

		// Token: 0x0600067A RID: 1658 RVA: 0x0002A534 File Offset: 0x00028734
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

		// Token: 0x04000404 RID: 1028
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

		// Token: 0x04000405 RID: 1029
		private bool bool_0;

		// Token: 0x04000406 RID: 1030
		private bool bool_1;

		// Token: 0x04000407 RID: 1031
		private bool bool_2;

		// Token: 0x04000408 RID: 1032
		private bool bool_3;

		// Token: 0x04000409 RID: 1033
		private bool bool_4;

		// Token: 0x0400040A RID: 1034
		private string string_0;

		// Token: 0x0400040B RID: 1035
		private string string_1;

		// Token: 0x0400040C RID: 1036
		private List<SignText> list_0;
	}
}
