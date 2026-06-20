using System;
using System.Collections.Generic;
using System.Text;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F1 RID: 241
	public class BlockChange
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00007431 File Offset: 0x00005631
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00007439 File Offset: 0x00005639
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

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00007442 File Offset: 0x00005642
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x0000744A File Offset: 0x0000564A
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00007453 File Offset: 0x00005653
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x0000745B File Offset: 0x0000565B
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00007464 File Offset: 0x00005664
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x0000746C File Offset: 0x0000566C
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00007475 File Offset: 0x00005675
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x0000747D File Offset: 0x0000567D
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00007486 File Offset: 0x00005686
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0000748E File Offset: 0x0000568E
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

		// Token: 0x06000A48 RID: 2632 RVA: 0x0004E494 File Offset: 0x0004C694
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

		// Token: 0x06000A49 RID: 2633 RVA: 0x0004E52C File Offset: 0x0004C72C
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

		// Token: 0x06000A4A RID: 2634 RVA: 0x0004E61C File Offset: 0x0004C81C
		private string method_0()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int num in this.list_1)
			{
				stringBuilder.Append((stringBuilder.Length > 0) ? ("," + num.ToString()) : num.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0004E6A4 File Offset: 0x0004C8A4
		private string method_1()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int num in this.list_0)
			{
				stringBuilder.Append((stringBuilder.Length > 0) ? (":" + num.ToString()) : num.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0004E72C File Offset: 0x0004C92C
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

		// Token: 0x040006E9 RID: 1769
		private int int_0;

		// Token: 0x040006EA RID: 1770
		private List<int> list_0 = new List<int>
		{
			-1
		};

		// Token: 0x040006EB RID: 1771
		private int int_1;

		// Token: 0x040006EC RID: 1772
		private int int_2;

		// Token: 0x040006ED RID: 1773
		private int int_3 = -1;

		// Token: 0x040006EE RID: 1774
		private List<int> list_1 = new List<int>
		{
			-1
		};
	}
}
