using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.forms
{
	// Token: 0x0200006F RID: 111
	public partial class ChunkDesigner : Form
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x0001F788 File Offset: 0x0001D988
		public ChunkDesigner()
		{
			this.block_0 = new Block();
			this.block_1 = new Block();
			this.block_2 = new Block();
			this.chunkLayer_1 = new ChunkLayer[256];
			base..ctor();
			this.method_0();
			this.method_10();
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		public ChunkDesigner(byte[] blocks, byte[] data, TagNodeList tileEntities, int chunkX, int chunkZ)
		{
			/*
An exception occurred when decompiling this method (0600042C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::.ctor(System.Byte[],System.Byte[],Substrate.Nbt.TagNodeList,System.Int32,System.Int32)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001F854 File Offset: 0x0001DA54
		private void method_0()
		{
			/*
An exception occurred when decompiling this method (0600042D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::method_0()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001F934 File Offset: 0x0001DB34
		private void method_1()
		{
			this.toolTip_0 = new ToolTip();
			this.toolTip_0.AutoPopDelay = 5000;
			this.toolTip_0.InitialDelay = 750;
			this.toolTip_0.ReshowDelay = 200;
			this.toolTip_0.ShowAlways = true;
			this.toolTip_0.SetToolTip(this.pictureBox_2, "Copy Block");
			this.toolTip_0.SetToolTip(this.blockSettingsUI_1, "Left Mouse");
			this.toolTip_0.SetToolTip(this.blockSettingsUI_0, "Right Mouse");
			this.toolTip_0.SetToolTip(this.pictureBox_0, "Rotate Left");
			this.toolTip_0.SetToolTip(this.pictureBox_1, "Rotate Right");
			this.toolTip_0.SetToolTip(this.pictureBox_4, "Flip Vertical");
			this.toolTip_0.SetToolTip(this.pictureBox_3, "Flip Horizontal");
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000047DC File Offset: 0x000029DC
		internal Block method_2()
		{
			return this.block_1;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000047E4 File Offset: 0x000029E4
		internal void method_3(Block value)
		{
			this.block_1 = value;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000047ED File Offset: 0x000029ED
		internal Block method_4()
		{
			return this.block_0;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000047F5 File Offset: 0x000029F5
		internal void method_5(Block value)
		{
			this.block_0 = value;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000047FE File Offset: 0x000029FE
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00004806 File Offset: 0x00002A06
		public byte[] Blocks
		{
			get
			{
				return this.blocks;
			}
			set
			{
				this.blocks = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000480F File Offset: 0x00002A0F
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00004817 File Offset: 0x00002A17
		public byte[] Data
		{
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00004820 File Offset: 0x00002A20
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00004828 File Offset: 0x00002A28
		public byte[] HeightMap
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00004831 File Offset: 0x00002A31
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00004839 File Offset: 0x00002A39
		public TagNodeList TileEntities
		{
			get
			{
				return this.tileEntities;
			}
			set
			{
				this.tileEntities = value;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001FA24 File Offset: 0x0001DC24
		private void method_6(ListView listView_2, List<Class4> list_0)
		{
			listView_2.Items.Clear();
			listView_2.LargeImageList = Class5.smethod_0();
			listView_2.SmallImageList = Class5.smethod_0();
			foreach (Class4 @class in list_0)
			{
				if (Class34.smethod_1().ContainsKey(@class.Id) && Class34.smethod_1()[@class.Id].method_3())
				{
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.ImageKey = @class.Id.ToString() + ((@class.Data > 0) ? ("-" + @class.Data.ToString()) : "");
					string text = string.Format("({0}:{1}) {2}", @class.Id, @class.Data, @class.Description);
					listViewItem.SubItems.Add(text);
					listViewItem.Tag = @class;
					listView_2.Items.Add(listViewItem);
				}
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0001FB54 File Offset: 0x0001DD54
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			ChunkLayer chunkLayer = new ChunkLayer();
			chunkLayer.Layer = this.listView_1.Items.Count;
			listViewItem.Text = chunkLayer.Layer.ToString();
			listViewItem.Tag = chunkLayer;
			this.listView_1.Items.Add(listViewItem);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		private void listView_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600043D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::listView_1_SelectedIndexChanged(System.Object,System.EventArgs)

 ---> System.Exception: Inconsistent stack size at IL_34
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001FBF8 File Offset: 0x0001DDF8
		private void listView_0_MouseDown(object sender, MouseEventArgs e)
		{
			this.listView_0.PointToClient(new Point(e.X, e.Y));
			ListViewItem itemAt = this.listView_0.GetItemAt(e.X, e.Y);
			foreach (object obj in this.listView_0.SelectedItems)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				listViewItem.Selected = false;
			}
			if (itemAt != null)
			{
				itemAt.Selected = true;
				Class4 @class = itemAt.Tag as Class4;
				Block block;
				if (e.Button == MouseButtons.Left)
				{
					block = this.block_0;
				}
				else
				{
					block = this.block_1;
				}
				block.Id = @class.Id;
				block.Data = @class.Data;
				block.Light = 0;
				this.method_7();
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00004842 File Offset: 0x00002A42
		private void method_7()
		{
			/*
An exception occurred when decompiling this method (0600043F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::method_7()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		private void pictureBox_2_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000440)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::pictureBox_2_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000485A File Offset: 0x00002A5A
		private void pictureBox_0_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000441)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::pictureBox_0_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00004868 File Offset: 0x00002A68
		private void pictureBox_1_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000442)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::pictureBox_1_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00004868 File Offset: 0x00002A68
		private void pictureBox_4_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000443)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::pictureBox_4_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000485A File Offset: 0x00002A5A
		private void pictureBox_3_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000444)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::pictureBox_3_Click(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00004876 File Offset: 0x00002A76
		private void wjdgIwutIc(object sender, EventArgs e)
		{
			this.method_7();
			this.pictureBox_2.BackColor = this.color_0;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001FD40 File Offset: 0x0001DF40
		private void ChunkDesigner_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000446)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::ChunkDesigner_Load(System.Object,System.EventArgs)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001FD60 File Offset: 0x0001DF60
		private void method_8(ChunkLayer[] chunkLayer_2)
		{
			foreach (ChunkLayer chunkLayer in chunkLayer_2)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = chunkLayer.Layer.ToString();
				listViewItem.SubItems.Add(this.method_9(chunkLayer.TileEntities));
				listViewItem.Tag = chunkLayer;
				this.listView_1.Items.Add(listViewItem);
			}
			if (this.listView_1.Items.Count > 0)
			{
				this.listView_1.Items[0].Selected = true;
				this.listView_1.TopItem = this.listView_1.Items[0];
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001FE10 File Offset: 0x0001E010
		private string method_9(TagNodeList tagNodeList_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = tagNodeList_0.Count - 1; i >= 0; i--)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
				stringBuilder.Append(tagNodeCompound["id"].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001FE78 File Offset: 0x0001E078
		private void method_10()
		{
			ChunkLayer[] array = new ChunkLayer[64];
			for (int i = 0; i < 64; i++)
			{
				array[i] = new ChunkLayer
				{
					Layer = i
				};
			}
			this.method_8(array);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		private void method_11(byte[] byte_1, byte[] byte_2)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			for (int i = 0; i < 256; i++)
			{
				ChunkLayer chunkLayer = new ChunkLayer();
				chunkLayer.Layer = i;
				this.chunkLayer_1[i] = chunkLayer;
				int num = (i < 128) ? 0 : 32768;
				int offset = num / 2;
				int num2 = (i < 128) ? i : (i - 128);
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						int num3 = j * 16 + k;
						int num4 = j << 11 | k << 7 | num2 + num;
						byte id = byte_1[num4];
						int num5 = nibbleSetters.RegionGet(byte_2, j, num2, k, offset);
						chunkLayer.Blocks[num3].Id = (int)id;
						chunkLayer.Blocks[num3].Data = num5;
					}
				}
				for (int l = this.tileEntities.Count - 1; l >= 0; l--)
				{
					TagNodeCompound tagNodeCompound = this.tileEntities[l].Copy() as TagNodeCompound;
					Class31 @class = Class46.smethod_46(tagNodeCompound);
					if (@class.Y == i)
					{
						chunkLayer.TileEntities.Add(tagNodeCompound);
						this.tileEntities.Remove(tagNodeCompound);
					}
				}
			}
			this.method_8(this.chunkLayer_1);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00020014 File Offset: 0x0001E214
		private void method_12(byte[] byte_1, byte[] byte_2, TagNodeList tagNodeList_0)
		{
			NibbleSetters nibbleSetters = new NibbleSetters();
			IEnumerable<ChunkLayer> source = this.chunkLayer_1;
			if (ChunkDesigner.func_0 == null)
			{
				ChunkDesigner.func_0 = new Func<ChunkLayer, int>(ChunkDesigner.smethod_0);
			}
			ChunkLayer[] array = source.OrderBy(ChunkDesigner.func_0).ToArray<ChunkLayer>();
			for (int i = 0; i < array.Length; i++)
			{
				ChunkLayer chunkLayer = array[i];
				int num = (i < 128) ? 0 : 32768;
				int offset = num / 2;
				int num2 = (i < 128) ? i : (i - 128);
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						int num3 = j * 16 + k;
						int num4 = j << 11 | k << 7 | num2 + num;
						byte b = (byte)chunkLayer.Blocks[num3].Id;
						byte val = (byte)chunkLayer.Blocks[num3].Data;
						byte_1[num4] = b;
						nibbleSetters.RegionSet(byte_2, j, num2, k, (int)val, offset);
					}
				}
				for (int l = 0; l < chunkLayer.TileEntities.Count; l++)
				{
					tagNodeList_0.Add(chunkLayer.TileEntities[l]);
				}
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00020144 File Offset: 0x0001E344
		private void method_13()
		{
			for (int i = 0; i < 16; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					int num = 256;
					int value;
					do
					{
						num--;
						int num2 = (num >= 128) ? 32768 : 0;
						int num3 = (num < 128) ? num : (num - 128);
						int num4 = i << 11 | j << 7 | num3 + num2;
						value = (int)this.blocks[num4];
					}
					while (num > 0 && Constants.transparentBlocks.Contains(value));
					if (num != 0 && num != 255)
					{
						num++;
					}
					this.byte_0[j * 16 + i] = (byte)num;
				}
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000201F4 File Offset: 0x0001E3F4
		private void button_1_Click(object sender, EventArgs e)
		{
			if (this.blocks == null)
			{
				this.blocks = new byte[32768];
			}
			if (this.data == null)
			{
				this.data = new byte[16384];
			}
			if (this.byte_0 == null)
			{
				this.byte_0 = new byte[256];
			}
			this.tileEntities = new TagNodeList(TagType.TAG_COMPOUND);
			this.method_12(this.blocks, this.data, this.tileEntities);
			this.method_13();
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00020284 File Offset: 0x0001E484
		private void textBox_0_KeyUp(object sender, KeyEventArgs e)
		{
			string value = this.textBox_0.Text.Trim();
			if (string.IsNullOrWhiteSpace(value))
			{
				this.method_6(this.listView_0, Class5.smethod_2().Values.ToList<Class4>());
				return;
			}
			List<Class4> list = new List<Class4>();
			foreach (Class4 @class in Class5.smethod_2().Values)
			{
				if (@class.Description.IndexOf(value, StringComparison.OrdinalIgnoreCase) > 0)
				{
					list.Add(@class);
				}
			}
			this.method_6(this.listView_0, list);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000488F File Offset: 0x00002A8F
		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00004897 File Offset: 0x00002A97
		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.method_15();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00020334 File Offset: 0x0001E534
		private void method_14()
		{
			int num = 0;
			ChunkLayer[] array = null;
			if (this.listView_1.SelectedItems.Count > 0)
			{
				array = new ChunkLayer[this.listView_1.SelectedItems.Count];
				foreach (object obj in this.listView_1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					array[num++] = (listViewItem.Tag as ChunkLayer);
				}
				IEnumerable<ChunkLayer> source = array;
				if (ChunkDesigner.func_1 == null)
				{
					ChunkDesigner.func_1 = new Func<ChunkLayer, int>(ChunkDesigner.smethod_1);
				}
				array = source.OrderBy(ChunkDesigner.func_1).ToArray<ChunkLayer>();
				this.method_16(array);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00020404 File Offset: 0x0001E604
		private void method_15()
		{
			/*
An exception occurred when decompiling this method (06000452)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::method_15()

 ---> System.Exception: Inconsistent stack size at IL_16C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00020600 File Offset: 0x0001E800
		private void method_16(ChunkLayer[] chunkLayer_2)
		{
			/*
An exception occurred when decompiling this method (06000453)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::method_16(Full_UMT_Convertor.model.ChunkLayer[])

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00020638 File Offset: 0x0001E838
		private ChunkLayer[] method_17()
		{
			/*
An exception occurred when decompiling this method (06000454)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Full_UMT_Convertor.model.ChunkLayer[] Full_UMT_Convertor.forms.ChunkDesigner::method_17()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002066C File Offset: 0x0001E86C
		private TagNodeList method_18(ChunkLayer chunkLayer_2, int int_0)
		{
			TagNodeList tagNodeList = new TagNodeList(TagType.TAG_COMPOUND);
			for (int i = chunkLayer_2.TileEntities.Count - 1; i >= 0; i--)
			{
				TagNodeCompound tagNodeCompound = chunkLayer_2.TileEntities[i] as TagNodeCompound;
				if (tagNodeCompound.ContainsKey("y"))
				{
					TagNodeCompound tagNodeCompound2 = (TagNodeCompound)tagNodeCompound.Copy();
					tagNodeCompound2["y"] = new TagNodeInt(int_0);
					tagNodeList.Add(tagNodeCompound2);
				}
			}
			return tagNodeList;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000489F File Offset: 0x00002A9F
		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000456)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::checkBox_0_CheckedChanged(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000489F File Offset: 0x00002A9F
		private void blockSettingsUI_2_BlockChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000457)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::blockSettingsUI_2_BlockChanged(System.Object,System.EventArgs)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000206E0 File Offset: 0x0001E8E0
		private void chunkUI_0_BlockChanged(object sender, EventArgs e)
		{
			if (this.listView_1.SelectedItems.Count > 0)
			{
				ListViewItem listViewItem = this.listView_1.SelectedItems[0];
				ChunkLayer chunkLayer = listViewItem.Tag as ChunkLayer;
				listViewItem.SubItems[1].Text = this.method_9(chunkLayer.TileEntities);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000048B7 File Offset: 0x00002AB7
		private void listView_1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.C && e.Control)
			{
				this.method_14();
				return;
			}
			if (e.KeyCode == Keys.V && e.Control)
			{
				this.method_15();
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0002073C File Offset: 0x0001E93C
		private void method_19()
		{
			/*
An exception occurred when decompiling this method (0600045B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.forms.ChunkDesigner::method_19()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00004911 File Offset: 0x00002B11
		[CompilerGenerated]
		private static int smethod_0(ChunkLayer chunkLayer_2)
		{
			return chunkLayer_2.Layer;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00004911 File Offset: 0x00002B11
		[CompilerGenerated]
		private static int smethod_1(ChunkLayer chunkLayer_2)
		{
			return chunkLayer_2.Layer;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00004911 File Offset: 0x00002B11
		[CompilerGenerated]
		private static int smethod_2(ChunkLayer chunkLayer_2)
		{
			return chunkLayer_2.Layer;
		}

		// Token: 0x04000256 RID: 598
		private ChunkLayer[] chunkLayer_0;

		// Token: 0x04000257 RID: 599
		private Block block_0;

		// Token: 0x04000258 RID: 600
		private Block block_1;

		// Token: 0x04000259 RID: 601
		private Block block_2;

		// Token: 0x0400025A RID: 602
		private TagNodeList tileEntities;

		// Token: 0x0400025B RID: 603
		private Color color_0;

		// Token: 0x0400025C RID: 604
		private byte[] blocks;

		// Token: 0x0400025D RID: 605
		private byte[] data;

		// Token: 0x0400025E RID: 606
		private byte[] byte_0;

		// Token: 0x0400025F RID: 607
		private ChunkLayer[] chunkLayer_1;

		// Token: 0x04000260 RID: 608
		private ToolTip toolTip_0;

		// Token: 0x04000262 RID: 610
		private SplitContainer splitContainer_0;

		// Token: 0x04000263 RID: 611
		private SplitContainer splitContainer_1;

		// Token: 0x04000264 RID: 612
		private ListView listView_0;

		// Token: 0x04000265 RID: 613
		private ListView listView_1;

		// Token: 0x04000266 RID: 614
		private ColumnHeader columnHeader_0;

		// Token: 0x04000267 RID: 615
		private ColumnHeader columnHeader_1;

		// Token: 0x04000268 RID: 616
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000269 RID: 617
		private ContextMenuStrip contextMenuStrip_1;

		// Token: 0x0400026A RID: 618
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400026B RID: 619
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x0400026C RID: 620
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x0400026D RID: 621
		private ColumnHeader columnHeader_2;

		// Token: 0x0400026E RID: 622
		private  chunkUI_0;

		// Token: 0x0400026F RID: 623
		private  blockSettingsUI_0;

		// Token: 0x04000270 RID: 624
		private  blockSettingsUI_1;

		// Token: 0x04000271 RID: 625
		private PictureBox pictureBox_0;

		// Token: 0x04000272 RID: 626
		private PictureBox pictureBox_1;

		// Token: 0x04000273 RID: 627
		private PictureBox pictureBox_2;

		// Token: 0x04000274 RID: 628
		private PictureBox pictureBox_3;

		// Token: 0x04000275 RID: 629
		private PictureBox pictureBox_4;

		// Token: 0x04000276 RID: 630
		private Button button_0;

		// Token: 0x04000277 RID: 631
		private Button button_1;

		// Token: 0x04000278 RID: 632
		private TextBox textBox_0;

		// Token: 0x04000279 RID: 633
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x0400027A RID: 634
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x0400027B RID: 635
		private CheckBox checkBox_0;

		// Token: 0x0400027C RID: 636
		private  blockSettingsUI_2;

		// Token: 0x0400027D RID: 637
		private ColumnHeader columnHeader_3;

		// Token: 0x0400027E RID: 638
		private CheckBox checkBox_1;

		// Token: 0x0400027F RID: 639
		private NumericUpDown numericUpDown_0;

		// Token: 0x04000280 RID: 640
		private Label label_0;

		// Token: 0x04000281 RID: 641
		[CompilerGenerated]
		private static Func<ChunkLayer, int> func_0;

		// Token: 0x04000282 RID: 642
		[CompilerGenerated]
		private static Func<ChunkLayer, int> func_1;

		// Token: 0x04000283 RID: 643
		[CompilerGenerated]
		private static Func<ChunkLayer, int> func_2;
	}
}
