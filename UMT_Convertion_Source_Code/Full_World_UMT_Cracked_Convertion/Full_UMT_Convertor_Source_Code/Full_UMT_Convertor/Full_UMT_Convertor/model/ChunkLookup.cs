using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000FE RID: 254
	public class ChunkLookup
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00054518 File Offset: 0x00052718
		public ChunkLookup()
		{
			this.dictionary_0.Add("region", new Dictionary<string, TreeNode>());
			this.dictionary_0.Add("dim-1", new Dictionary<string, TreeNode>());
			this.dictionary_0.Add("dim1", new Dictionary<string, TreeNode>());
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00054578 File Offset: 0x00052778
		public TreeNode FindChunkNode(string region, int x, int z)
		{
			TreeNode result = null;
			string key = this.method_0(x, z);
			region = region.ToLower();
			if (this.dictionary_0.ContainsKey(region) && this.dictionary_0[region].ContainsKey(key))
			{
				result = this.dictionary_0[region][key];
			}
			return result;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000545D0 File Offset: 0x000527D0
		public void AddChunkNode(string region, TreeNode node, int x, int z)
		{
			string key = this.method_0(x, z);
			region = region.ToLower();
			if (this.dictionary_0.ContainsKey(region) && !this.dictionary_0[region].ContainsKey(key))
			{
				this.dictionary_0[region].Add(key, node);
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00007986 File Offset: 0x00005B86
		private string method_0(int int_0, int int_1)
		{
			return int_0.ToString() + "," + int_1.ToString();
		}

		// Token: 0x04000736 RID: 1846
		private Dictionary<string, Dictionary<string, TreeNode>> dictionary_0 = new Dictionary<string, Dictionary<string, TreeNode>>();
	}
}
