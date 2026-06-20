using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.Controls;
using Full_UMT_Convertor.Events;
using Full_UMT_Convertor.model;
using Save_Manager.model;

namespace Full_UMT_Convertor.Forms
{
	// Token: 0x0200010D RID: 269
	public partial class MCPEFolder : Form
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00007C58 File Offset: 0x00005E58
		public MCPEFolder(GEnum0 displayType)
		{
			this.method_2();
			this.peworldList_0.SetDisplayType(displayType);
			this.peworldList_0.LoadWorldList();
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00007C7D File Offset: 0x00005E7D
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00007C85 File Offset: 0x00005E85
		public PEWorldFolder PEWorldFolder
		{
			get
			{
				return this.peworldFolder_0;
			}
			set
			{
				this.peworldFolder_0 = value;
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00007C8E File Offset: 0x00005E8E
		internal Enum3 method_0()
		{
			return this.enum3_0;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00007C96 File Offset: 0x00005E96
		internal void method_1(Enum3 value)
		{
			this.enum3_0 = value;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00007C9F File Offset: 0x00005E9F
		private void peworldList_0_WorldSelected(object sender, EventArgs e)
		{
			this.PEWorldFolder = (e as PEWorldEventArgs).Folder;
			this.enum3_0 = (Enum3)0;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00004B57 File Offset: 0x00002D57
		private void peworldList_0_CancelClick(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00007CC6 File Offset: 0x00005EC6
		private void peworldList_0_FolderClick(object sender, EventArgs e)
		{
			this.enum3_0 = (Enum3)1;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00021F14 File Offset: 0x00020114
		private void MCPEFolder_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000B5D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.Forms.MCPEFolder::MCPEFolder_Load(System.Object,System.EventArgs)

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

		// Token: 0x06000B5E RID: 2910 RVA: 0x00007CDC File Offset: 0x00005EDC
		private void MCPEFolder_Shown(object sender, EventArgs e)
		{
			this.peworldList_0.method_2();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00055830 File Offset: 0x00053A30
		private void method_2()
		{
			this.peworldList_0 = new PEWorldList();
			base.SuspendLayout();
			this.peworldList_0.BackColor = Color.Transparent;
			this.peworldList_0.Dock = DockStyle.Fill;
			this.peworldList_0.Location = new Point(0, 0);
			this.peworldList_0.Name = "PEWorldList";
			this.peworldList_0.Size = new Size(474, 443);
			this.peworldList_0.TabIndex = 14;
			this.peworldList_0.WorldSelected += this.peworldList_0_WorldSelected;
			this.peworldList_0.CancelClick += this.peworldList_0_CancelClick;
			this.peworldList_0.FolderClick += this.peworldList_0_FolderClick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(474, 443);
			base.Controls.Add(this.peworldList_0);
			base.Name = "MCPEFolder";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Minecraft Save Folders";
			base.Load += this.MCPEFolder_Load;
			base.Shown += this.MCPEFolder_Shown;
			base.ResumeLayout(false);
		}

		// Token: 0x04000779 RID: 1913
		private PEWorldFolder peworldFolder_0;

		// Token: 0x0400077A RID: 1914
		private Enum3 enum3_0;

		// Token: 0x0400077C RID: 1916
		private PEWorldList peworldList_0;
	}
}
