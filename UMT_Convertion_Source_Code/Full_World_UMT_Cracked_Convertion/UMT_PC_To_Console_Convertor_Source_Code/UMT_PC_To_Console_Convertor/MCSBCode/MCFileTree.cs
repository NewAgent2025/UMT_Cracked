using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x02000080 RID: 128
	public class MCFileTree
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x00029844 File Offset: 0x00027A44
		public void DisplaySGFiles(string folderPath, TreeView treeView, ChunkLookup chunkLookups, ToolStripStatusLabel versionLabel)
		{
			string path = "";
			this.PojgxasNpb = chunkLookups;
			folderPath = FileUtils.CheckFolderSep(folderPath);
			if (Working.GameType != (Enum2)0)
			{
				path = folderPath + Working.smethod_1();
			}
			List<IndexEntry> list = null;
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					list = Class36.smethod_0(binaryReader);
					Class33 @class = Class33.smethod_0(binaryReader);
					Working.WorldVersionMajor = @class.method_0();
					Working.WorldVersionMinor = @class.method_2();
					versionLabel.Text = string.Format("{0} V:{1}.{2}", Working.smethod_0(), @class.method_0(), @class.method_2());
				}
			}
			if (list != null)
			{
				IEnumerable<IndexEntry> source = list;
				if (MCFileTree.func_0 == null)
				{
					MCFileTree.func_0 = new Func<IndexEntry, string>(MCFileTree.smethod_0);
				}
				IOrderedEnumerable<IndexEntry> source2 = source.OrderBy(MCFileTree.func_0);
				if (MCFileTree.func_1 == null)
				{
					MCFileTree.func_1 = new Func<IndexEntry, string>(MCFileTree.smethod_1);
				}
				IOrderedEnumerable<IndexEntry> source3 = source2.ThenBy(MCFileTree.func_1);
				if (MCFileTree.func_2 == null)
				{
					MCFileTree.func_2 = new Func<IndexEntry, string>(MCFileTree.gJuguflCg6);
				}
				list = source3.ThenBy(MCFileTree.func_2).ToList<IndexEntry>();
				this.method_0(list, folderPath, treeView);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00029978 File Offset: 0x00027B78
		private void method_0(List<IndexEntry> list_0, string string_0, TreeView treeView_0)
		{
			treeView_0.Nodes.Clear();
			treeView_0.BeginUpdate();
			foreach (IndexEntry indexEntry in list_0)
			{
				if (!indexEntry.IsRegion)
				{
					this.DisplayFileItem(indexEntry, string_0, treeView_0);
				}
			}
			foreach (string text in Constants.dimensionNames.Keys)
			{
				TreeNode treeNode = treeView_0.Nodes.Add(text, Constants.dimensionNames[text]);
				string path = string_0 + Working.smethod_4() + FileUtils.CheckFolderSep(text);
				treeNode.Tag = new DimensionWorkingData(text, path);
				this.method_4(treeNode, text);
			}
			foreach (IndexEntry indexEntry2 in list_0)
			{
				if (indexEntry2.IsRegion)
				{
					this.DisplayFileItem(indexEntry2, string_0, treeView_0);
				}
			}
			treeView_0.EndUpdate();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00029AB8 File Offset: 0x00027CB8
		public TreeNode DisplayFileItem(IndexEntry entry, string folderPath, TreeView treeView)
		{
			TreeNode treeNode = this.method_3(entry, treeView);
			string fileName = entry.FileName;
			TreeNode treeNode2;
			if (treeNode != null)
			{
				if (entry.IsRegion)
				{
					string key = fileName.Substring(0, fileName.LastIndexOf('.'));
					treeNode2 = treeNode.Nodes.Add(key, fileName);
				}
				else
				{
					treeNode2 = treeNode.Nodes.Add(fileName);
				}
			}
			else
			{
				treeNode2 = treeView.Nodes.Add(fileName);
			}
			treeNode2.Tag = entry;
			this.method_4(treeNode2, entry.ParentName);
			if (entry.IsRegion)
			{
				string text = folderPath + Working.smethod_4() + entry.FilePath;
				RegionWorkingData tag = new RegionWorkingData(text, entry);
				treeNode2.Tag = tag;
				this.method_1(text, treeNode2, entry);
			}
			return treeNode2;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00029B70 File Offset: 0x00027D70
		public TreeNode CheckFileExists(IndexEntry entry, TreeView treeView)
		{
			TreeNode result = null;
			foreach (object obj in treeView.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				IndexEntry indexEntry = treeNode.Tag as IndexEntry;
				if (indexEntry != null && indexEntry.FileName == entry.FileName)
				{
					result = treeNode;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00029BF0 File Offset: 0x00027DF0
		private void method_1(string string_0, TreeNode treeNode_0, IndexEntry indexEntry_0)
		{
			int rx = indexEntry_0.RX;
			int rz = indexEntry_0.RZ;
			List<ChunkIndexEntry> list_ = Class36.smethod_4(string_0);
			if (indexEntry_0.RX >= 0)
			{
				for (int i = 0; i < 32; i++)
				{
					if (indexEntry_0.RZ >= 0)
					{
						for (int j = 0; j < 32; j++)
						{
							this.method_2(indexEntry_0, treeNode_0, list_, string_0, i, j, i, j);
						}
					}
					else
					{
						for (int k = 31; k >= 0; k--)
						{
							this.method_2(indexEntry_0, treeNode_0, list_, string_0, i, k, i, k - 32);
						}
					}
				}
				return;
			}
			for (int l = 31; l >= 0; l--)
			{
				if (indexEntry_0.RZ >= 0)
				{
					for (int m = 0; m < 32; m++)
					{
						this.method_2(indexEntry_0, treeNode_0, list_, string_0, l, m, l - 32, m);
					}
				}
				else
				{
					for (int n = 31; n >= 0; n--)
					{
						this.method_2(indexEntry_0, treeNode_0, list_, string_0, l, n, l - 32, n - 32);
					}
				}
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00029CEC File Offset: 0x00027EEC
		private void method_2(IndexEntry indexEntry_0, TreeNode treeNode_0, List<ChunkIndexEntry> list_0, string string_0, int int_0, int int_1, int int_2, int int_3)
		{
			if (Class36.smethod_15(list_0, int_0, int_1))
			{
				ChunkIndexEntry chunkIndexEntry = Class36.smethod_16(list_0, int_0, int_1);
				string_0 + chunkIndexEntry.ChunkIndex + ".dat";
				string text = string.Concat(new object[]
				{
					"Chunk [",
					int_2,
					", ",
					int_3,
					"]"
				});
				ChunkData chunkData = new ChunkData();
				chunkData.XRegionOffset = int_0;
				chunkData.ZRegionOffset = int_1;
				chunkData.XWorldCoords = int_2;
				chunkData.ZWorldCoords = int_3;
				chunkData.Path = string_0;
				chunkData.Parent = indexEntry_0.ParentName;
				chunkData.Text = text;
				chunkData.method_1(chunkIndexEntry);
				chunkData.RegionIndex = indexEntry_0;
				ChunkData tag = chunkData;
				TreeNode treeNode = treeNode_0.Nodes.Add(text);
				this.method_4(treeNode, indexEntry_0.ParentName);
				treeNode.Tag = tag;
				this.PojgxasNpb.AddChunkNode(indexEntry_0.ParentName, treeNode, int_2, int_3);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00029E00 File Offset: 0x00028000
		private TreeNode method_3(IndexEntry indexEntry_0, TreeView treeView_0)
		{
			TreeNode treeNode = null;
			string parentName = indexEntry_0.ParentName;
			if (!string.IsNullOrWhiteSpace(parentName))
			{
				TreeNode[] array = treeView_0.Nodes.Find(parentName, true);
				if (array != null && array.Length > 0)
				{
					treeNode = array[0];
				}
				if (treeNode == null)
				{
					string text = parentName;
					if (Constants.dimensionNames.ContainsKey(text))
					{
						text = Constants.dimensionNames[text];
					}
					treeNode = treeView_0.Nodes.Add(parentName, text);
					this.method_4(treeNode, parentName);
				}
			}
			return treeNode;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00029E74 File Offset: 0x00028074
		private void method_4(TreeNode treeNode_0, string string_0)
		{
			int num = this.method_5(string_0);
			treeNode_0.ImageIndex = num;
			treeNode_0.SelectedImageIndex = num;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00029E98 File Offset: 0x00028098
		private int method_5(string string_0)
		{
			int result = 0;
			if (string_0 != null && this.dictionary_0.ContainsKey(string_0.ToLower()))
			{
				result = this.dictionary_0[string_0.ToLower()];
			}
			return result;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004820 File Offset: 0x00002A20
		[CompilerGenerated]
		private static string smethod_0(IndexEntry indexEntry_0)
		{
			return indexEntry_0.FileExt;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00005177 File Offset: 0x00003377
		[CompilerGenerated]
		private static string smethod_1(IndexEntry indexEntry_0)
		{
			return indexEntry_0.ParentName;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000517F File Offset: 0x0000337F
		[CompilerGenerated]
		private static string gJuguflCg6(IndexEntry indexEntry_0)
		{
			return indexEntry_0.FileName;
		}

		// Token: 0x040003A3 RID: 931
		private Dictionary<string, int> dictionary_0 = new Dictionary<string, int>
		{
			{
				"data",
				0
			},
			{
				"dim1",
				4
			},
			{
				"dim-1",
				3
			},
			{
				"region",
				2
			},
			{
				"players",
				1
			}
		};

		// Token: 0x040003A4 RID: 932
		private ChunkLookup PojgxasNpb;

		// Token: 0x040003A5 RID: 933
		[CompilerGenerated]
		private static Func<IndexEntry, string> func_0;

		// Token: 0x040003A6 RID: 934
		[CompilerGenerated]
		private static Func<IndexEntry, string> func_1;

		// Token: 0x040003A7 RID: 935
		[CompilerGenerated]
		private static Func<IndexEntry, string> func_2;
	}
}
