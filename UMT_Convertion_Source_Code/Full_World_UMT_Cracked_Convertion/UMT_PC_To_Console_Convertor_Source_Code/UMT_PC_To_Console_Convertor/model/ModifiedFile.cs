using System;
using System.Windows.Forms;
using NBTExplorer.Model;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x020000BC RID: 188
	public class ModifiedFile
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000066F1 File Offset: 0x000048F1
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x000066F9 File Offset: 0x000048F9
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00006702 File Offset: 0x00004902
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0000670A File Offset: 0x0000490A
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00006713 File Offset: 0x00004913
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0000671B File Offset: 0x0000491B
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

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00006724 File Offset: 0x00004924
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0000672C File Offset: 0x0000492C
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

		// Token: 0x060007FC RID: 2044 RVA: 0x0002F914 File Offset: 0x0002DB14
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

		// Token: 0x04000509 RID: 1289
		private TreeNode treeNode_0;

		// Token: 0x0400050A RID: 1290
		private DataNode dataNode_0;

		// Token: 0x0400050B RID: 1291
		private object object_0;

		// Token: 0x0400050C RID: 1292
		private FileStateType fileStateType_0;
	}
}
