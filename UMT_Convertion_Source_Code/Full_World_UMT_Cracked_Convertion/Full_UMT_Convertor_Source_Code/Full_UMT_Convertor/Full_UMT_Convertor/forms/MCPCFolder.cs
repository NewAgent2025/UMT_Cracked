using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.Controls;
using Full_UMT_Convertor.Events;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.Forms
{
	// Token: 0x0200007B RID: 123
	public partial class MCPCFolder : Form
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00004B93 File Offset: 0x00002D93
		public MCPCFolder(GEnum0 displayType)
		{
			this.method_2();
			this.mcworldList_0.SetDisplayType(displayType);
			this.mcworldList_0.LoadWorldList();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00004BC3 File Offset: 0x00002DC3
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00004BCB File Offset: 0x00002DCB
		public string PCWorldFolder
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

		// Token: 0x060004D8 RID: 1240 RVA: 0x00004BD4 File Offset: 0x00002DD4
		internal Enum1 method_0()
		{
			return this.enum1_0;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00004BDC File Offset: 0x00002DDC
		internal void method_1(Enum1 value)
		{
			this.enum1_0 = value;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00004BE5 File Offset: 0x00002DE5
		private void mcworldList_0_WorldSelected(object sender, EventArgs e)
		{
			this.PCWorldFolder = (e as PCWorldEventArgs).Folder;
			this.enum1_0 = (Enum1)0;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00004B57 File Offset: 0x00002D57
		private void mcworldList_0_CancelClick(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00004C0C File Offset: 0x00002E0C
		private void mcworldList_0_FolderClick(object sender, EventArgs e)
		{
			this.enum1_0 = (Enum1)1;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00021F14 File Offset: 0x00020114
		private void MCPCFolder_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060004DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.Forms.MCPCFolder::MCPCFolder_Load(System.Object,System.EventArgs)

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

		// Token: 0x060004DF RID: 1247 RVA: 0x00027C04 File Offset: 0x00025E04
		private void method_2()
		{
			this.mcworldList_0 = new MCWorldList();
			base.SuspendLayout();
			this.mcworldList_0.BackColor = Color.Transparent;
			this.mcworldList_0.Dock = DockStyle.Fill;
			this.mcworldList_0.Location = new Point(0, 0);
			this.mcworldList_0.Name = "PCWorldList";
			this.mcworldList_0.Size = new Size(371, 443);
			this.mcworldList_0.TabIndex = 14;
			this.mcworldList_0.WorldSelected += this.mcworldList_0_WorldSelected;
			this.mcworldList_0.CancelClick += this.mcworldList_0_CancelClick;
			this.mcworldList_0.FolderClick += this.mcworldList_0_FolderClick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(371, 443);
			base.Controls.Add(this.mcworldList_0);
			base.Name = "MCPCFolder";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Minecraft Save Folders";
			base.Load += this.MCPCFolder_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x0400031A RID: 794
		private string string_0 = "";

		// Token: 0x0400031B RID: 795
		private Enum1 enum1_0;

		// Token: 0x0400031D RID: 797
		private MCWorldList mcworldList_0;
	}
}
