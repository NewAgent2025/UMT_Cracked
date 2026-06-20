using System;
using System.Drawing;
using System.IO;

namespace Save_Manager.model
{
	// Token: 0x02000027 RID: 39
	public class PCWorldFolder
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002F1F File Offset: 0x0000111F
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002F27 File Offset: 0x00001127
		public PEFolderType FolderType
		{
			get
			{
				return this.utHcYiSgl0;
			}
			set
			{
				this.utHcYiSgl0 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002F30 File Offset: 0x00001130
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002F38 File Offset: 0x00001138
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002F41 File Offset: 0x00001141
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002F49 File Offset: 0x00001149
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002F52 File Offset: 0x00001152
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002F5A File Offset: 0x0000115A
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
					this.memoryStream_0 = new MemoryStream(this.byte_0);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002F7C File Offset: 0x0000117C
		public Image Image
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600015A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Drawing.Image Save_Manager.model.PCWorldFolder::get_Image()

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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002F97 File Offset: 0x00001197
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002F9F File Offset: 0x0000119F
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002FA8 File Offset: 0x000011A8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002FB0 File Offset: 0x000011B0
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002FB9 File Offset: 0x000011B9
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002FC1 File Offset: 0x000011C1
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002FCA File Offset: 0x000011CA
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002FD2 File Offset: 0x000011D2
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002FDB File Offset: 0x000011DB
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002FE3 File Offset: 0x000011E3
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

		// Token: 0x040000C4 RID: 196
		private PEFolderType utHcYiSgl0;

		// Token: 0x040000C5 RID: 197
		private string string_0;

		// Token: 0x040000C6 RID: 198
		private int int_0;

		// Token: 0x040000C7 RID: 199
		private string string_1;

		// Token: 0x040000C8 RID: 200
		private byte[] byte_0;

		// Token: 0x040000C9 RID: 201
		private long long_0;

		// Token: 0x040000CA RID: 202
		private DateTime dateTime_0;

		// Token: 0x040000CB RID: 203
		private string string_2;

		// Token: 0x040000CC RID: 204
		private string string_3;

		// Token: 0x040000CD RID: 205
		private MemoryStream memoryStream_0;
	}
}
