using System;
using System.Collections.Generic;
using System.Text;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000AD RID: 173
	public class BlockChange
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00006179 File Offset: 0x00004379
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00006181 File Offset: 0x00004381
		public int FromBlock
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0000618A File Offset: 0x0000438A
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00006192 File Offset: 0x00004392
		public List<int> FromData
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0000619B File Offset: 0x0000439B
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x000061A3 File Offset: 0x000043A3
		public int ToBlock
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000061AC File Offset: 0x000043AC
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x000061B4 File Offset: 0x000043B4
		public int ToData
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x000061BD File Offset: 0x000043BD
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x000061C5 File Offset: 0x000043C5
		public int ToBlockLight
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x000061CE File Offset: 0x000043CE
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000061D6 File Offset: 0x000043D6
		public List<int> Layers
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0002D2E4 File Offset: 0x0002B4E4
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.int_0.ToString(),
				",",
				this.method_1(),
				",",
				this.int_1.ToString(),
				",",
				this.int_2.ToString(),
				",",
				this.int_3.ToString(),
				"*",
				this.method_0(),
				"|"
			});
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0002D37C File Offset: 0x0002B57C
		public static BlockChange FromString(string changeStr)
		{
			BlockChange blockChange = null;
			string[] array = changeStr.Split(new char[]
			{
				'*'
			});
			string[] array2 = array[0].Split(new char[]
			{
				','
			});
			if (array2.Length >= 4)
			{
				int fromBlock = 0;
				int toBlock = 0;
				int toData = 0;
				int toBlockLight = -1;
				int.TryParse(array2[0], out fromBlock);
				List<int> list = BlockChange.smethod_0(array2[1], ':');
				int.TryParse(array2[2], out toBlock);
				int.TryParse(array2[3], out toData);
				if (array2.Length == 5)
				{
					int.TryParse(array2[4], out toBlockLight);
				}
				blockChange = new BlockChange
				{
					FromBlock = fromBlock,
					list_0 = list,
					ToBlock = toBlock,
					ToData = toData,
					ToBlockLight = toBlockLight
				};
				if (array.Length > 1)
				{
					blockChange.Layers = BlockChange.smethod_0(array[1], ',');
				}
				else
				{
					blockChange.Layers.Add(-1);
				}
			}
			return blockChange;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0002D46C File Offset: 0x0002B66C
		private string method_0()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int num in this.list_1)
			{
				stringBuilder.Append((stringBuilder.Length > 0) ? ("," + num.ToString()) : num.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		private string method_1()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int num in this.list_0)
			{
				stringBuilder.Append((stringBuilder.Length > 0) ? (":" + num.ToString()) : num.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0002D57C File Offset: 0x0002B77C
		private static List<int> smethod_0(string string_0, char char_0)
		{
			List<int> list = new List<int>();
			int item = 0;
			string[] array = string_0.Split(new char[]
			{
				char_0
			});
			foreach (string text in array)
			{
				if (int.TryParse(text.Trim(), out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x040004B9 RID: 1209
		private int int_0;

		// Token: 0x040004BA RID: 1210
		private List<int> list_0 = new List<int>
		{
			-1
		};

		// Token: 0x040004BB RID: 1211
		private int int_1;

		// Token: 0x040004BC RID: 1212
		private int int_2;

		// Token: 0x040004BD RID: 1213
		private int int_3 = -1;

		// Token: 0x040004BE RID: 1214
		private List<int> list_1 = new List<int>
		{
			-1
		};
	}
}
