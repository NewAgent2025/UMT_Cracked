using System;
using System.Drawing;
using System.IO;

namespace Save_Manager.model
{
	// Token: 0x02000029 RID: 41
	public class PEWorldFolder
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002FEC File Offset: 0x000011EC
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002FF4 File Offset: 0x000011F4
		public PEFolderType FolderType
		{
			get
			{
				return this.pefolderType_0;
			}
			set
			{
				this.pefolderType_0 = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002FFD File Offset: 0x000011FD
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00003005 File Offset: 0x00001205
		public string Name
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000300E File Offset: 0x0000120E
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00003016 File Offset: 0x00001216
		public int GameType
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000301F File Offset: 0x0000121F
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00003027 File Offset: 0x00001227
		public byte[] ImageBytes
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
				if (this.byte_0 != null)
				{
					this.ApiSyTqVl5 = new MemoryStream(this.byte_0);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003049 File Offset: 0x00001249
		public Image Image
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600016E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Drawing.Image Save_Manager.model.PEWorldFolder::get_Image()

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
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00003064 File Offset: 0x00001264
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000306C File Offset: 0x0000126C
		public string Path
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00003075 File Offset: 0x00001275
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000307D File Offset: 0x0000127D
		public long Size
		{
			get
			{
				return this.long_0;
			}
			set
			{
				this.long_0 = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003086 File Offset: 0x00001286
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000308E File Offset: 0x0000128E
		public DateTime Date
		{
			get
			{
				return this.dateTime_0;
			}
			set
			{
				this.dateTime_0 = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00003097 File Offset: 0x00001297
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000309F File Offset: 0x0000129F
		public string DeviceId
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000030A8 File Offset: 0x000012A8
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000030B0 File Offset: 0x000012B0
		public string FolderId
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x040000D1 RID: 209
		private PEFolderType pefolderType_0;

		// Token: 0x040000D2 RID: 210
		private string string_0;

		// Token: 0x040000D3 RID: 211
		private int int_0;

		// Token: 0x040000D4 RID: 212
		private string string_1;

		// Token: 0x040000D5 RID: 213
		private byte[] byte_0;

		// Token: 0x040000D6 RID: 214
		private long long_0;

		// Token: 0x040000D7 RID: 215
		private DateTime dateTime_0;

		// Token: 0x040000D8 RID: 216
		private string string_2;

		// Token: 0x040000D9 RID: 217
		private string string_3;

		// Token: 0x040000DA RID: 218
		private MemoryStream ApiSyTqVl5;
	}
}
