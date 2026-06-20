using System;
using System.Windows.Forms;
using NBTExplorer.Model;

namespace Full_UMT_Convertor.model
{
	// Token: 0x02000101 RID: 257
	public class ModifiedFile
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00007A28 File Offset: 0x00005C28
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00007A30 File Offset: 0x00005C30
		public TreeNode Treenode
		{
			get
			{
				return this.treeNode_0;
			}
			set
			{
				this.treeNode_0 = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00007A39 File Offset: 0x00005C39
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00007A41 File Offset: 0x00005C41
		public DataNode FileNode
		{
			get
			{
				return this.dataNode_0;
			}
			set
			{
				this.dataNode_0 = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00007A4A File Offset: 0x00005C4A
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00007A52 File Offset: 0x00005C52
		public object Tag
		{
			get
			{
				return this.object_0;
			}
			set
			{
				this.object_0 = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00007A5B File Offset: 0x00005C5B
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00007A63 File Offset: 0x00005C63
		public FileStateType FileState
		{
			get
			{
				return this.fileStateType_0;
			}
			set
			{
				this.fileStateType_0 = value;
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00054624 File Offset: 0x00052824
		public override string ToString()
		{
			string result = string.Empty;
			if (this.object_0 != null)
			{
				if (this.object_0.GetType() == typeof(ChunkData))
				{
					result = ((ChunkData)this.object_0).Parent + "\\" + ((ChunkData)this.object_0).Text;
				}
				else if (this.object_0.GetType() == typeof(IndexEntry))
				{
					result = ((IndexEntry)this.object_0).FileName;
				}
			}
			return result;
		}

		// Token: 0x04000744 RID: 1860
		private TreeNode treeNode_0;

		// Token: 0x04000745 RID: 1861
		private DataNode dataNode_0;

		// Token: 0x04000746 RID: 1862
		private object object_0;

		// Token: 0x04000747 RID: 1863
		private FileStateType fileStateType_0;
	}
}
