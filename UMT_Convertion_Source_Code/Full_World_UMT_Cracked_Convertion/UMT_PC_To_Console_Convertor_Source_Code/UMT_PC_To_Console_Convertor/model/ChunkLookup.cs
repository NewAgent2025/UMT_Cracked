using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000B9 RID: 185
	public class ChunkLookup
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0002F808 File Offset: 0x0002DA08
		public ChunkLookup()
		{
			this.dictionary_0.Add("region", new Dictionary<string, TreeNode>());
			this.dictionary_0.Add("dim-1", new Dictionary<string, TreeNode>());
			this.dictionary_0.Add("dim1", new Dictionary<string, TreeNode>());
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0002F868 File Offset: 0x0002DA68
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

		// Token: 0x060007E1 RID: 2017 RVA: 0x0002F8C0 File Offset: 0x0002DAC0
		public void AddChunkNode(string region, TreeNode node, int x, int z)
		{
			string key = this.method_0(x, z);
			region = region.ToLower();
			if (this.dictionary_0.ContainsKey(region) && !this.dictionary_0[region].ContainsKey(key))
			{
				this.dictionary_0[region].Add(key, node);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000664F File Offset: 0x0000484F
		private string method_0(int int_0, int int_1)
		{
			return int_0.ToString() + "," + int_1.ToString();
		}

		// Token: 0x040004FB RID: 1275
		private Dictionary<string, Dictionary<string, TreeNode>> dictionary_0 = new Dictionary<string, Dictionary<string, TreeNode>>();
	}
}
