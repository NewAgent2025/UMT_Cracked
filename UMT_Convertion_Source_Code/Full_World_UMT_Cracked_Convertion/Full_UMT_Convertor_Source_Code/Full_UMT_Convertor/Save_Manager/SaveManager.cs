using System;
using System.ComponentModel;
using System.Windows.Forms;
using Save_Manager.events;

namespace Save_Manager
{
	// Token: 0x02000106 RID: 262
	public partial class SaveManager : Form
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00007B27 File Offset: 0x00005D27
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00007B2F File Offset: 0x00005D2F
		public SaveSelectedEventArgs SaveSelected
		{
			get
			{
				return this.saveSelectedEventArgs_0;
			}
			set
			{
				this.saveSelectedEventArgs_0 = value;
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00007B38 File Offset: 0x00005D38
		public SaveManager()
		{
			this.method_1();
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00054700 File Offset: 0x00052900
		private void SaveManager_Load(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000B29)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Save_Manager.SaveManager::SaveManager_Load(System.Object,System.EventArgs)

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

		// Token: 0x06000B2A RID: 2858 RVA: 0x00007B46 File Offset: 0x00005D46
		private void GSQHVTXJLEO(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00007B4E File Offset: 0x00005D4E
		private void method_0()
		{
			if (this.saveSelectedEventArgs_0 != null)
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000547EC File Offset: 0x000529EC
		private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000B2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Save_Manager.SaveManager::tabControl_0_SelectedIndexChanged(System.Object,System.EventArgs)

 ---> System.Exception: Inconsistent stack size at IL_6E
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00054874 File Offset: 0x00052A74
		private void wiiUWorldListUI_0_SaveSelected(object sender, EventArgs e)
		{
			SaveSelectedEventArgs saveSelectedEventArgs = e as SaveSelectedEventArgs;
			this.label_0.Text = saveSelectedEventArgs.Name;
			this.saveSelectedEventArgs_0 = saveSelectedEventArgs;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00007B65 File Offset: 0x00005D65
		private void wiiUWorldListUI_0_SaveOpen(object sender, EventArgs e)
		{
			this.wiiUWorldListUI_0_SaveSelected(sender, e);
			this.method_0();
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000548A0 File Offset: 0x00052AA0
		private void method_1()
		{
			/*
An exception occurred when decompiling this method (06000B30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Save_Manager.SaveManager::method_1()

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

		// Token: 0x0400075C RID: 1884
		private SaveSelectedEventArgs saveSelectedEventArgs_0;

		// Token: 0x0400075E RID: 1886
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x0400075F RID: 1887
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04000760 RID: 1888
		private OpenFileDialog openFileDialog_1;

		// Token: 0x04000761 RID: 1889
		private  xbox360PackagesUI_0;

		// Token: 0x04000762 RID: 1890
		private TabControl tabControl_0;

		// Token: 0x04000763 RID: 1891
		private TabPage tabPage_0;

		// Token: 0x04000764 RID: 1892
		private TabPage tabPage_1;

		// Token: 0x04000765 RID: 1893
		private  ps3WorldListUI_0;

		// Token: 0x04000766 RID: 1894
		private TabPage tabPage_2;

		// Token: 0x04000767 RID: 1895
		private  wiiUWorldListUI_0;

		// Token: 0x04000768 RID: 1896
		private Label label_0;

		// Token: 0x04000769 RID: 1897
		private Button button_0;

		// Token: 0x0400076A RID: 1898
		private TabPage tabPage_3;

		// Token: 0x0400076B RID: 1899
		private ImageList imageList_0;

		// Token: 0x0400076C RID: 1900
		private TabPage tabPage_4;
	}
}
