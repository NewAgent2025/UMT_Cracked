using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NBTExplorer.Model;
using Substrate;
using Substrate.Core;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.Properties;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x02000061 RID: 97
	public class MCSupport
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x000207DC File Offset: 0x0001E9DC
		public void method_0(string srcFile, string dstFile)
		{
			byte[] array = FileUtils.smethod_0(srcFile);
			byte[] array2 = Class36.smethod_55(array);
			FileUtils.WriteFile(array2, dstFile);
			Class37 @class = new Class37();
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(dstFile, FileMode.Create)))
			{
				@class.method_7(0, binaryWriter.BaseStream);
				@class.method_7(array.Length, binaryWriter.BaseStream);
				binaryWriter.Write(array2);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00020850 File Offset: 0x0001EA50
		internal ConvertStatus method_1(string string_2, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			try
			{
				this.InitConsoleConversion(string_2, convertParameters_0, convertStatus);
				this.method_2(string_2, convertParameters_0);
				this.method_11(string_2, convertParameters_0.PCWorldFolder, convertParameters_0.method_0());
				Thread.Sleep(500);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unknown error has occurred." + Environment.NewLine + ex.Message, "Unknown Error");
			}
			return convertStatus;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000208C8 File Offset: 0x0001EAC8
		public void InitConsoleConversion(string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string[] regionFolderNames = Constants.regionFolderNames;
			int i = 0;
			while (i < regionFolderNames.Length)
			{
				string text = regionFolderNames[i];
				if ((text.ToLower() == "region" && convertParameters.ConvertOverworld) || (text.ToLower() == "dim-1" && convertParameters.ConvertNether))
				{
					goto IL_46;
				}
				if (text.ToLower() == "dim1" && convertParameters.ConvertTheEnd)
				{
					goto IL_46;
				}
				IL_58:
				i++;
				continue;
				IL_46:
				this.method_45(text, false);
				this.DoConsoleConversion(text, workingFolder, convertParameters, convertStatus);
				goto IL_58;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00020950 File Offset: 0x0001EB50
		public void DoConsoleConversion(string regionfolder, string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			/*
An exception occurred when decompiling this method (0600040F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.MCSBCode.MCSupport::DoConsoleConversion(System.String,System.String,UMT_PC_To_Console_Convertor.model.ConvertParameters,UMT_PC_To_Console_Convertor.model.ConvertStatus)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00020B98 File Offset: 0x0001ED98
		private void method_2(string string_2, ConvertParameters convertParameters_0)
		{
			string text = Working.WorkFolders[(int)convertParameters_0.method_0()];
			string text2 = Working.smethod_4();
			text = FileUtils.CheckFolderSep(string_2) + FileUtils.CheckFolderSep(text);
			text2 = FileUtils.CheckFolderSep(string_2) + FileUtils.CheckFolderSep(text2);
			Directory.CreateDirectory(text);
			File.Copy(text2 + "level.dat", text + "level.dat", true);
			if (File.Exists(text2 + "requiredGameRules.grf"))
			{
				this.method_3(string_2, text, convertParameters_0);
			}
			text += "data";
			text2 += "data";
			if (Directory.Exists(text2))
			{
				Directory.CreateDirectory(text);
				foreach (string text3 in Directory.GetFiles(text2, "*.*", SearchOption.TopDirectoryOnly))
				{
					File.Copy(text3, text3.Replace(text2, text), true);
				}
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00020C74 File Offset: 0x0001EE74
		private void method_3(string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			/*
An exception occurred when decompiling this method (06000411)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.MCSBCode.MCSupport::method_3(System.String,System.String,UMT_PC_To_Console_Convertor.model.ConvertParameters)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000046B8 File Offset: 0x000028B8
		internal void method_4(string string_2, List<ModifiedFile> list_0, bool bool_0 = false)
		{
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				string_2 = FileUtils.CheckFolderSep(string_2);
				this.method_5(string_2, list_0, bool_0);
				this.method_49("Process completed...", 0);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00020CA4 File Offset: 0x0001EEA4
		private void method_5(string string_2, List<ModifiedFile> list_0, bool bool_0)
		{
			string path = string_2 + Working.smethod_1();
			string text = string_2 + Working.smethod_3();
			string text2 = string_2 + Working.smethod_2();
			byte[] array = new byte[12];
			List<IndexEntry> list = null;
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					binaryReader.Read(array, 0, array.Length);
					list = Class36.smethod_0(binaryReader);
				}
			}
			if (list_0 != null)
			{
				list = this.method_7(list, list_0);
				list = this.method_6(list, list_0);
			}
			if (bool_0)
			{
				array[9] = 7;
				array[11] = 9;
			}
			if (list != null)
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
				{
					binaryWriter.Write(array, 0, array.Length);
				}
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_49("Processing file - " + indexEntry.FilePath, int_);
					if (indexEntry.FilePath.EndsWith(".mcr"))
					{
						this.method_19(indexEntry, string_2);
					}
					else
					{
						this.method_17(indexEntry, string_2);
					}
				}
				long long_ = this.method_15(list, string_2);
				this.method_13(long_, array, list, string_2);
				if (Working.GameType == (Enum2)1)
				{
					ProcessCaller processCaller = new ProcessCaller();
					this.method_49("Compressing savegame.dat", 0);
					processCaller.CallCompressSaveGame(text, text2);
				}
				if (Working.GameType == (Enum2)3)
				{
					this.method_49("Compressing savegame.wii", 0);
					this.method_0(text, text2);
				}
				if (Settings.Default.ArchiveGameFile)
				{
					this.method_47(Working.smethod_7());
				}
				if (Working.GameType != (Enum2)1)
				{
					if (Working.GameType != (Enum2)3)
					{
						File.Copy(text, Working.smethod_7(), true);
						goto IL_12E;
					}
				}
				File.Copy(text2, Working.smethod_7(), true);
			}
			IL_12E:
			FileUtils.smethod_10(path);
			FileUtils.smethod_11(text, path);
			if (Working.GameType == (Enum2)2)
			{
				FileUtils.smethod_12(path, text2);
				this.method_50(Path.GetDirectoryName(Working.smethod_7()));
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		private List<IndexEntry> method_6(List<IndexEntry> list_0, List<ModifiedFile> list_1)
		{
			foreach (ModifiedFile modifiedFile in list_1)
			{
				if (modifiedFile.FileState == FileStateType.ADDED)
				{
					modifiedFile.FileState = FileStateType.PINNED;
					list_0.Add(modifiedFile.Tag as IndexEntry);
				}
			}
			return list_0;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00020F54 File Offset: 0x0001F154
		private List<IndexEntry> method_7(List<IndexEntry> list_0, List<ModifiedFile> list_1)
		{
			List<IndexEntry> list = new List<IndexEntry>();
			foreach (IndexEntry indexEntry in list_0)
			{
				bool flag = false;
				foreach (ModifiedFile modifiedFile in list_1)
				{
					if (modifiedFile.Tag is IndexEntry && modifiedFile.FileState == FileStateType.DELETED && indexEntry.FileName == ((IndexEntry)modifiedFile.Tag).FileName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(indexEntry);
				}
			}
			return list;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00021024 File Offset: 0x0001F224
		public void UpdatedRegionFile(string dimension, string region, List<ModifiedFile> modifiedChunks, string workingFolder)
		{
			List<ChunkIndexEntry> list = null;
			string text = string.Concat(new string[]
			{
				workingFolder,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(dimension),
				region,
				".mcr"
			});
			string path = string.Concat(new string[]
			{
				workingFolder,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(dimension),
				region,
				".new"
			});
			list = Class36.smethod_4(text);
			int num = 0;
			if (list != null && list.Count > 0)
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (MCSupport.func_0 == null)
				{
					MCSupport.func_0 = new Func<ChunkIndexEntry, int>(MCSupport.smethod_2);
				}
				list = source.OrderBy(MCSupport.func_0).ToList<ChunkIndexEntry>();
				IEnumerable<ModifiedFile> source2 = modifiedChunks;
				if (MCSupport.func_1 == null)
				{
					MCSupport.func_1 = new Func<ModifiedFile, int>(MCSupport.smethod_3);
				}
				modifiedChunks = source2.OrderBy(MCSupport.func_1).ToList<ModifiedFile>();
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
				{
					Class36.smethod_20(binaryWriter);
					foreach (ChunkIndexEntry chunkIndexEntry in list)
					{
						this.method_49("Updating Region - " + region + " Chunk - " + chunkIndexEntry.ChunkIndex.ToString(), 0);
						byte[] byte_ = null;
						if (chunkIndexEntry.OldChunkOffset > 0U)
						{
							if (num < modifiedChunks.Count && ((ChunkData)modifiedChunks[num].Tag).method_0().ChunkIndex == chunkIndexEntry.ChunkIndex)
							{
								if (((ChunkData)modifiedChunks[num].Tag).method_0().OldChunkOffset > 0U)
								{
									ModifiedFile modifiedFile_ = modifiedChunks[num];
									byte_ = this.method_8(modifiedFile_);
								}
								else
								{
									chunkIndexEntry.OldChunkOffset = 0U;
									chunkIndexEntry.OldChunkLength = 0;
									chunkIndexEntry.NewChunkOffset = 0U;
									chunkIndexEntry.NewChunkLength = 0;
								}
								num++;
							}
							else
							{
								byte_ = Class36.smethod_8(text, chunkIndexEntry);
							}
							if (chunkIndexEntry.OldChunkOffset > 0U)
							{
								Class36.smethod_11(byte_, chunkIndexEntry, binaryWriter);
							}
						}
					}
					Class36.smethod_26(binaryWriter, list);
				}
				FileUtils.smethod_10(text);
				FileUtils.smethod_11(path, text);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0002128C File Offset: 0x0001F48C
		private byte[] method_8(ModifiedFile modifiedFile_0)
		{
			byte[] result = null;
			if (modifiedFile_0 != null)
			{
				NbtFileDataNode nbtFileDataNode = modifiedFile_0.FileNode as NbtFileDataNode;
				if (nbtFileDataNode != null)
				{
					MemoryStream memoryStream;
					if (Working.WorldVersionMajor < 9 || Working.WorldVersionMinor < 8)
					{
						memoryStream = new MemoryStream();
						nbtFileDataNode.Tree.WriteTo(memoryStream);
					}
					else
					{
						TagNodeCompound root = nbtFileDataNode.Tree.Root;
						TU17Converter tu17Converter = new TU17Converter();
						memoryStream = tu17Converter.ConvertToTU17(root);
					}
					ChunkData chunkData = modifiedFile_0.Tag as ChunkData;
					chunkData.NewFileSize = (int)memoryStream.Length;
					memoryStream = Class36.smethod_62(memoryStream.ToArray());
					int num = (int)memoryStream.Length;
					byte[] array = null;
					if (Working.GameType == (Enum2)1)
					{
						XBOXCompression xboxcompression = new XBOXCompression();
						array = xboxcompression.DoCompress(memoryStream.ToArray(), 8);
						Class36.smethod_22(array.Length - 8, array);
						Class36.smethod_23(chunkData.NewFileSize, array);
					}
					else if (Working.GameType == (Enum2)2)
					{
						array = Class36.smethod_58(memoryStream.ToArray());
						byte[] first = new byte[12];
						array = first.Concat(array).ToArray<byte>();
						Class36.smethod_22(array.Length - 8, array);
						Class36.smethod_23(chunkData.NewFileSize, array);
						Class36.smethod_24(num, array);
					}
					else if (Working.GameType == (Enum2)3)
					{
						array = Class36.smethod_55(memoryStream.ToArray());
						byte[] first2 = new byte[8];
						array = first2.Concat(array).ToArray<byte>();
						Class36.smethod_22(array.Length - 8, array);
						Class36.smethod_23(chunkData.NewFileSize, array);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000046DF File Offset: 0x000028DF
		internal void method_9(string string_2, bool bool_0 = false)
		{
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				string_2 = FileUtils.CheckFolderSep(string_2);
				this.method_10(string_2, bool_0);
				this.method_49("Process completed...", 0);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00021424 File Offset: 0x0001F624
		private void method_10(string string_2, bool bool_0)
		{
			string path = string_2 + Working.smethod_1();
			string text = string_2 + Working.smethod_3();
			string text2 = string_2 + Working.smethod_2();
			byte[] array = new byte[12];
			List<IndexEntry> list = null;
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					binaryReader.Read(array, 0, array.Length);
					list = Class36.smethod_0(binaryReader);
				}
			}
			if (bool_0)
			{
				array[9] = 7;
				array[11] = 9;
			}
			if (list != null)
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
				{
					binaryWriter.Write(array, 0, array.Length);
				}
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_49("Processing file - " + indexEntry.FilePath, int_);
					if (indexEntry.FilePath.EndsWith(".mcr"))
					{
						this.method_19(indexEntry, string_2);
					}
					else
					{
						this.method_17(indexEntry, string_2);
					}
				}
				long long_ = this.method_15(list, string_2);
				this.method_13(long_, array, list, string_2);
				if (Working.GameType == (Enum2)1)
				{
					ProcessCaller processCaller = new ProcessCaller();
					this.method_49("Compressing savegame.dat", 0);
					processCaller.CallCompressSaveGame(text, text2);
				}
				if (Working.GameType == (Enum2)3)
				{
					this.method_49("Compressing savegame.wii", 0);
					this.method_0(text, text2);
				}
				if (Settings.Default.ArchiveGameFile)
				{
					this.method_47(Working.smethod_7());
				}
				if (Working.GameType != (Enum2)1)
				{
					if (Working.GameType != (Enum2)3)
					{
						File.Copy(text, Working.smethod_7(), true);
						goto IL_115;
					}
				}
				File.Copy(text2, Working.smethod_7(), true);
			}
			IL_115:
			FileUtils.smethod_10(path);
			FileUtils.smethod_11(text, path);
			if (Working.GameType == (Enum2)2)
			{
				FileUtils.smethod_12(path, text2);
				this.method_50(Path.GetDirectoryName(Working.smethod_7()));
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00021650 File Offset: 0x0001F850
		internal void method_11(string string_2, string string_3, Enum2 enum2_0)
		{
			string text = "";
			string string_4 = "";
			string string_5 = "";
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				if (enum2_0 == (Enum2)1)
				{
					text = "savegame_working.dat";
					string_4 = "savegame_new.dat";
					string_5 = "savegame.dat";
				}
				else if (enum2_0 == (Enum2)2)
				{
					text = "gamedata_working";
					string_4 = "gamedata_new";
					string_5 = "GAMEDATA";
				}
				else if (enum2_0 == (Enum2)3)
				{
					text = "savegame_working.wii";
					string_4 = "savegame_new.wii";
					string_5 = "savegame.wii";
				}
				string_2 = FileUtils.CheckFolderSep(string_2);
				FileUtils.smethod_12(string_2 + Working.smethod_1(), string_2 + text);
				this.method_12(string_2, text, string_4, string_5, string_3, enum2_0);
				this.method_49("Creation completed...", 0);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00021704 File Offset: 0x0001F904
		private void method_12(string string_2, string string_3, string string_4, string string_5, string string_6, Enum2 enum2_0)
		{
			string string_7 = Working.WorkFolders[(int)enum2_0];
			string path = string_2 + string_3;
			string text = string_2 + string_4;
			string text2 = string_2 + string_5;
			byte[] array = new byte[12];
			List<IndexEntry> list = null;
			List<IndexEntry> list2 = new List<IndexEntry>();
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					binaryReader.Read(array, 0, array.Length);
					list = Class36.smethod_0(binaryReader);
				}
			}
			if (list != null)
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
				{
					binaryWriter.Write(array, 0, array.Length);
				}
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					if ((indexEntry.ParentName == null || indexEntry.ParentName.ToLower() != "players") && !indexEntry.FileName.StartsWith("P_") && !indexEntry.FileName.StartsWith("N_"))
					{
						int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
						this.method_49("Processing file - " + indexEntry.FilePath, int_);
						if (indexEntry.FilePath.EndsWith(".mcr"))
						{
							this.method_20(indexEntry, string_2, string_4, string_7);
						}
						else
						{
							this.method_18(indexEntry, string_2, string_4, string_7);
						}
						list2.Add(indexEntry);
					}
				}
				list = list2;
				long long_ = this.method_16(list, string_2, string_4);
				this.method_14(long_, array, list, string_2, string_4);
				if (enum2_0 == (Enum2)1)
				{
					ProcessCaller processCaller = new ProcessCaller();
					this.method_49("Compressing savegame.dat", 0);
					processCaller.CallCompressSaveGame(text, text2);
				}
				if (enum2_0 == (Enum2)3)
				{
					this.method_49("Compressing savegame.wii", 0);
					this.method_0(text, text2);
				}
				if (Settings.Default.ArchiveGameFile)
				{
					this.method_47(string_6);
				}
				if (enum2_0 != (Enum2)1)
				{
					if (enum2_0 != (Enum2)3)
					{
						File.Copy(text, string_6, true);
						goto IL_10C;
					}
				}
				File.Copy(text2, string_6, true);
			}
			IL_10C:
			FileUtils.smethod_10(text2);
			FileUtils.smethod_10(text);
			FileUtils.smethod_10(path);
			if (enum2_0 == (Enum2)2)
			{
				this.method_50(Path.GetDirectoryName(string_6));
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00004705 File Offset: 0x00002905
		private void method_13(long long_0, byte[] byte_0, List<IndexEntry> list_0, string string_2)
		{
			this.method_14(long_0, byte_0, list_0, string_2, Working.smethod_3());
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00021980 File Offset: 0x0001FB80
		private void method_14(long long_0, byte[] byte_0, List<IndexEntry> list_0, string string_2, string string_3)
		{
			string path = string_2 + string_3;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open)))
				{
					binaryWriter.Seek(0, SeekOrigin.Begin);
					FileUtils.smethod_7(binaryWriter, (uint)long_0, FileUtils.ByteOrder.BigEndian);
					FileUtils.smethod_7(binaryWriter, (uint)list_0.Count, FileUtils.ByteOrder.BigEndian);
					binaryWriter.Write(byte_0[8]);
					binaryWriter.Write(byte_0[9]);
					binaryWriter.Write(byte_0[10]);
					binaryWriter.Write(byte_0[11]);
				}
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00004717 File Offset: 0x00002917
		private long method_15(List<IndexEntry> list_0, string string_2)
		{
			return this.method_16(list_0, string_2, Working.smethod_3());
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00021A10 File Offset: 0x0001FC10
		private long method_16(List<IndexEntry> list_0, string string_2, string string_3)
		{
			string path = string_2 + string_3;
			long result = 0L;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Append)))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					result = binaryWriter.BaseStream.Position;
					foreach (IndexEntry indexEntry in list_0)
					{
						indexEntry.UpdateRawData();
						binaryWriter.Write(indexEntry.RawData, 0, indexEntry.RawData.Length);
					}
				}
			}
			return result;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00004726 File Offset: 0x00002926
		private void method_17(IndexEntry indexEntry_0, string string_2)
		{
			this.method_18(indexEntry_0, string_2, Working.smethod_3(), Working.smethod_4());
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00021ACC File Offset: 0x0001FCCC
		private void method_18(IndexEntry indexEntry_0, string string_2, string string_3, string string_4)
		{
			string path = string_2 + string_3;
			string path2 = string_2 + string_4 + indexEntry_0.FilePath;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Append)))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					indexEntry_0.FileOffset = (uint)binaryWriter.BaseStream.Position;
					using (BinaryReader binaryReader = new BinaryReader(File.Open(path2, FileMode.Open)))
					{
						long length = binaryReader.BaseStream.Length;
						indexEntry_0.FileLength = (uint)length;
						binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
						int num = 0;
						while ((long)num < length)
						{
							binaryWriter.Write(binaryReader.ReadByte());
							num++;
						}
					}
				}
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000473A File Offset: 0x0000293A
		private void method_19(IndexEntry indexEntry_0, string string_2)
		{
			this.method_20(indexEntry_0, string_2, Working.smethod_3(), Working.smethod_4());
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		private void method_20(IndexEntry indexEntry_0, string string_2, string string_3, string string_4)
		{
			string path = string_2 + string_3;
			string path2 = string_2 + string_4 + indexEntry_0.FilePath;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open)))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					indexEntry_0.FileOffset = (uint)binaryWriter.BaseStream.Position;
					if (File.Exists(path2))
					{
						using (BinaryReader binaryReader = new BinaryReader(File.Open(path2, FileMode.Open)))
						{
							long length = binaryReader.BaseStream.Length;
							indexEntry_0.FileLength = (uint)length;
							binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
							int num = 0;
							while ((long)num < length)
							{
								binaryWriter.Write(binaryReader.ReadByte());
								num++;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00021C9C File Offset: 0x0001FE9C
		internal List<IndexEntry> method_21(string string_2, string string_3, bool bool_0 = false)
		{
			List<IndexEntry> result = null;
			if (!string.IsNullOrWhiteSpace(string_2) && !string.IsNullOrWhiteSpace(string_3))
			{
				this.method_49("Extraction started.", 0);
				string_3 = FileUtils.CheckFolderSep(string_3);
				this.method_22(string_2, string_3);
				result = this.method_23(string_3, bool_0);
				this.method_49("Extraction completed...", 100);
			}
			return result;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00021CF0 File Offset: 0x0001FEF0
		private void method_22(string string_2, string string_3)
		{
			if (File.Exists(string_2))
			{
				FileUtils.smethod_9(string_3);
				string outFolderPath = string_3 + Working.smethod_1();
				ProcessCaller processCaller = new ProcessCaller();
				processCaller.CallExtractSaveGame(string_2, outFolderPath);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00021D28 File Offset: 0x0001FF28
		private List<IndexEntry> method_23(string string_2, bool bool_0)
		{
			List<IndexEntry> list = new List<IndexEntry>();
			string path = string_2 + Working.smethod_1();
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					IEnumerable<IndexEntry> source = Class36.smethod_0(binaryReader);
					if (MCSupport.func_2 == null)
					{
						MCSupport.func_2 = new Func<IndexEntry, string>(MCSupport.smethod_4);
					}
					List<IndexEntry> list2 = source.OrderBy(MCSupport.func_2).ToList<IndexEntry>();
					for (int i = 0; i < list2.Count; i++)
					{
						IndexEntry indexEntry = list2[i];
						int int_ = (int)((float)(i + 1) / (float)list2.Count * 100f);
						this.method_49("Extracting file - " + indexEntry.FilePath, int_);
						this.method_24(binaryReader, indexEntry, string_2 + Working.smethod_4());
						if (indexEntry.FilePath.EndsWith(".mcr"))
						{
							list.Add(indexEntry);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00021E28 File Offset: 0x00020028
		private void method_24(BinaryReader binaryReader_0, IndexEntry indexEntry_0, string string_2)
		{
			string text = string_2 + indexEntry_0.FilePath;
			MCSupport.smethod_0(text);
			binaryReader_0.BaseStream.Seek((long)((ulong)indexEntry_0.FileOffset), SeekOrigin.Begin);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
			{
				int num = 0;
				while ((long)num < (long)((ulong)indexEntry_0.FileLength))
				{
					binaryWriter.Write(binaryReader_0.ReadByte());
					num++;
				}
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00021EA4 File Offset: 0x000200A4
		internal ConvertStatus method_25(string string_2, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			try
			{
				this.method_44(convertParameters_0);
				this.method_27(string_2, convertParameters_0, convertStatus);
				this.method_28(convertParameters_0.PCWorldFolder, string_2);
				Thread.Sleep(500);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unknown error has occurred." + Environment.NewLine + ex.Message, "Unknown Error");
			}
			return convertStatus;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00021F14 File Offset: 0x00020114
		private void method_26(string string_2)
		{
			TagNodeCompound tagNodeCompound = this.method_32(string_2 + Working.smethod_4());
			if (tagNodeCompound != null)
			{
				int spawnX = tagNodeCompound["SpawnX"] as TagNodeInt;
				int spawnY = tagNodeCompound["SpawnY"] as TagNodeInt;
				int spawnZ = tagNodeCompound["SpawnZ"] as TagNodeInt;
				Working.SpawnX = spawnX;
				Working.SpawnY = spawnY;
				Working.SpawnZ = spawnZ;
				Working.smethod_11(Class36.smethod_41(spawnX));
				Working.smethod_13(Class36.smethod_41(spawnZ));
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00021FA0 File Offset: 0x000201A0
		private void method_27(string string_2, ConvertParameters convertParameters_0, ConvertStatus convertStatus_0)
		{
			List<IndexEntry> list = null;
			string path = string_2 + Working.smethod_1();
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					Class33.smethod_0(binaryReader);
					list = Class36.smethod_0(binaryReader);
				}
				if (list != null)
				{
					this.method_30(list, string_2, convertParameters_0, convertStatus_0);
				}
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00022008 File Offset: 0x00020208
		private void method_28(string string_2, string string_3)
		{
			string path = string_2 + "level.dat";
			TagNodeCompound tagNodeCompound = Class36.smethod_37(this.string_0) as TagNodeCompound;
			if (tagNodeCompound != null)
			{
				TagNodeCompound tagNodeCompound2 = tagNodeCompound["Data"] as TagNodeCompound;
				TagNodeCompound tagNodeCompound3 = this.method_32(string_3 + Working.smethod_4());
				string fileName = Path.GetFileName(string_2.Substring(0, string_2.Length - 1));
				tagNodeCompound2["LevelName"] = new TagNodeString(fileName);
				if (tagNodeCompound3.ContainsKey("generatorName"))
				{
					tagNodeCompound2["generatorName"] = tagNodeCompound3["generatorName"].Copy();
				}
				if (tagNodeCompound3.ContainsKey("generatorVersion"))
				{
					tagNodeCompound2["generatorVersion"] = tagNodeCompound3["generatorVersion"].Copy();
				}
				if (tagNodeCompound3.ContainsKey("hasBeenInCreative"))
				{
					tagNodeCompound2["allowCommands"] = (((TagNodeByte)tagNodeCompound3["hasBeenInCreative"] == 0) ? 0 : 1);
				}
				if (tagNodeCompound3.ContainsKey("GameType"))
				{
					tagNodeCompound2["GameType"] = tagNodeCompound3["GameType"].Copy();
				}
				if (tagNodeCompound3 != null)
				{
					if (tagNodeCompound3.ContainsKey("DayTime"))
					{
						tagNodeCompound2["DayTime"] = tagNodeCompound3["DayTime"].Copy();
					}
					else
					{
						tagNodeCompound2["DayTime"] = new TagNodeLong(100L);
					}
					if (tagNodeCompound3.ContainsKey("Time"))
					{
						tagNodeCompound2["Time"] = tagNodeCompound3["Time"].Copy();
					}
					tagNodeCompound2["LastPlayed"] = new TagNodeLong(this.method_34());
					if (tagNodeCompound3.ContainsKey("clearWeatherTime"))
					{
						tagNodeCompound2["clearWeatherTime"] = tagNodeCompound3["clearWeatherTime"].Copy();
					}
					if (tagNodeCompound3.ContainsKey("raining"))
					{
						tagNodeCompound2["raining"] = tagNodeCompound3["raining"].Copy();
					}
					if (tagNodeCompound3.ContainsKey("rainTime"))
					{
						tagNodeCompound2["rainTime"] = tagNodeCompound3["rainTime"].Copy();
					}
					if (tagNodeCompound3.ContainsKey("thundering"))
					{
						tagNodeCompound2["thundering"] = tagNodeCompound3["thundering"].Copy();
					}
					if (tagNodeCompound3.ContainsKey("thunderTime"))
					{
						tagNodeCompound2["thunderTime"] = tagNodeCompound3["thunderTime"].Copy();
					}
					tagNodeCompound2["SpawnX"] = tagNodeCompound3["SpawnX"].Copy();
					tagNodeCompound2["SpawnY"] = tagNodeCompound3["SpawnY"].Copy();
					tagNodeCompound2["SpawnZ"] = tagNodeCompound3["SpawnZ"].Copy();
				}
				this.method_31(tagNodeCompound, path);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000222EC File Offset: 0x000204EC
		private int method_29(List<IndexEntry> list_0, ConvertParameters convertParameters_0)
		{
			int num = 0;
			for (int i = 0; i < list_0.Count; i++)
			{
				IndexEntry indexEntry = list_0[i];
				if (indexEntry.FilePath.EndsWith(".mcr"))
				{
					if ((!(indexEntry.ParentName.ToLower() == "region") || !convertParameters_0.ConvertOverworld) && (!(indexEntry.ParentName.ToLower() == "dim-1") || !convertParameters_0.ConvertNether))
					{
						if (!(indexEntry.ParentName.ToLower() == "dim1") || !convertParameters_0.ConvertTheEnd)
						{
							goto IL_4D;
						}
					}
					num++;
				}
				IL_4D:;
			}
			return num;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00022390 File Offset: 0x00020590
		private void method_30(List<IndexEntry> list_0, string string_2, ConvertParameters convertParameters_0, ConvertStatus convertStatus_0)
		{
			/*
An exception occurred when decompiling this method (0600042D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.MCSBCode.MCSupport::method_30(System.Collections.Generic.List`1<UMT_PC_To_Console_Convertor.model.IndexEntry>,System.String,UMT_PC_To_Console_Convertor.model.ConvertParameters,UMT_PC_To_Console_Convertor.model.ConvertStatus)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000225C4 File Offset: 0x000207C4
		public bool method_31(TagNodeCompound level, string path)
		{
			bool result;
			try
			{
				NBTFile nbtfile = new NBTFile(path);
				Stream dataOutputStream = nbtfile.GetDataOutputStream();
				if (dataOutputStream == null)
				{
					NbtIOException ex = new NbtIOException("Failed to initialize compressed NBT stream for output");
					ex.Data["Level"] = level;
					throw ex;
				}
				new NbtTree(level).WriteTo(dataOutputStream);
				dataOutputStream.Close();
				result = true;
			}
			catch (Exception innerException)
			{
				LevelIOException ex2 = new LevelIOException("Could not save level file.", innerException);
				ex2.Data["Level"] = level;
				throw ex2;
			}
			return result;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00022650 File Offset: 0x00020850
		private TagNodeCompound method_32(string string_2)
		{
			byte[] buffer = FileUtils.smethod_0(Path.Combine(string_2, "level.dat"));
			MemoryStream s = new MemoryStream(buffer);
			NbtTree nbtTree = new NbtTree(s);
			return nbtTree.Root["Data"] as TagNodeCompound;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00022694 File Offset: 0x00020894
		private TagNodeCompound method_33(string string_2)
		{
			TagNodeCompound result = null;
			string path = Path.Combine(string_2, "level.dat");
			if (File.Exists(path))
			{
				NBTFile nbtfile = new NBTFile(path);
				Stream dataInputStream = nbtfile.GetDataInputStream();
				if (dataInputStream != null)
				{
					NbtTree nbtTree = new NbtTree(dataInputStream);
					result = (nbtTree.Root["Data"] as TagNodeCompound);
				}
			}
			return result;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000226E8 File Offset: 0x000208E8
		private long method_34()
		{
			double totalMilliseconds = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
			return (long)totalMilliseconds;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0002271C File Offset: 0x0002091C
		private int method_35()
		{
			DateTime now = DateTime.Now;
			return (int)((DateTime.UtcNow - now).Ticks / 10000000L);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00022750 File Offset: 0x00020950
		internal ConvertStatus method_36(string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			try
			{
				this.InitPCConversion(string_2, string_3, convertParameters_0, convertStatus);
				this.method_39(string_2, string_3, convertParameters_0);
				this.method_9(string_3, false);
				Thread.Sleep(500);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unknown error has occurred." + Environment.NewLine + ex.Message, "Unknown Error");
			}
			return convertStatus;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000227C0 File Offset: 0x000209C0
		private void method_37(string string_2)
		{
			TagNodeCompound tagNodeCompound = this.method_33(string_2);
			if (tagNodeCompound != null)
			{
				int num = tagNodeCompound["SpawnX"] as TagNodeInt;
				int spawnY = tagNodeCompound["SpawnY"] as TagNodeInt;
				int num2 = tagNodeCompound["SpawnZ"] as TagNodeInt;
				if (num > 431 || num < -432)
				{
					num = 0;
				}
				if (num2 > 431 || num2 < -432)
				{
					num2 = 0;
				}
				Working.SpawnX = num;
				Working.SpawnY = spawnY;
				Working.SpawnZ = num2;
				Working.smethod_11(Class36.smethod_41(num));
				Working.smethod_13(Class36.smethod_41(num2));
				return;
			}
			Working.SpawnX = 0;
			Working.SpawnY = 64;
			Working.SpawnZ = 0;
			Working.smethod_11(0);
			Working.smethod_13(0);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0002288C File Offset: 0x00020A8C
		public void InitPCConversion(string pcPath, string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string[] regionFolderNames = Constants.regionFolderNames;
			int i = 0;
			while (i < regionFolderNames.Length)
			{
				string text = regionFolderNames[i];
				if ((text.ToLower() == "region" && convertParameters.ConvertOverworld) || (text.ToLower() == "dim-1" && convertParameters.ConvertNether))
				{
					goto IL_46;
				}
				if (text.ToLower() == "dim1" && convertParameters.ConvertTheEnd)
				{
					goto IL_46;
				}
				IL_5F:
				i++;
				continue;
				IL_46:
				this.method_45(text, convertParameters.ConvertNewGen);
				this.InitPCConversion(text, pcPath, workingFolder, convertParameters, convertStatus);
				goto IL_5F;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0002291C File Offset: 0x00020B1C
		public void InitPCConversion(string regionfolder, string pcPath, string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string text = this.method_38(pcPath, regionfolder);
			if (FileUtils.CheckFolderExists(text))
			{
				ManualResetEvent[] array = new ManualResetEvent[4];
				ConvertFromPCParameters[] array2 = new ConvertFromPCParameters[4];
				int num = 0;
				foreach (string regionName in Constants.regionFileNames)
				{
					array[num] = new ManualResetEvent(false);
					ConvertFromPCParameters convertFromPCParameters = new ConvertFromPCParameters(regionName, regionfolder, text, workingFolder, convertParameters, array[num]);
					ConvertFromPC @object = new ConvertFromPC();
					ThreadPool.QueueUserWorkItem(new WaitCallback(@object.ExtractPCRegion), convertFromPCParameters);
					array2[num] = convertFromPCParameters;
					num++;
				}
				bool flag = false;
				bool flag2 = false;
				while (!flag2)
				{
					bool flag3 = true;
					if (!flag)
					{
						this.int_0 = 0;
					}
					flag2 = true;
					for (int j = 0; j < 4; j++)
					{
						if (!flag)
						{
							this.int_0 += array2[j].Count;
						}
						if (!array2[j].Done)
						{
							flag2 = false;
						}
						if (!array2[j].ProcessingCompleted)
						{
							flag3 = false;
						}
					}
					if (!flag && (flag = flag3))
					{
						this.int_0 = 0;
					}
					if (flag)
					{
						this.int_0++;
						if (this.int_0 > 100)
						{
							this.int_0 = 0;
						}
						this.method_49("Compressing " + regionfolder + " chunks", this.int_0);
					}
					else
					{
						this.method_48(string.Concat(new object[]
						{
							"Converting ",
							regionfolder,
							" chunk ",
							this.int_0,
							" of ",
							this.int_1
						}));
					}
					Thread.Sleep(100);
				}
				WaitHandle.WaitAll(array);
				foreach (ConvertFromPCParameters convertFromPCParameters2 in array2)
				{
					convertStatus.ProcessedChunkCount += convertFromPCParameters2.ProcessedChunkCount;
					convertStatus.MissingChunkCount += convertFromPCParameters2.MissingChunkCount;
					convertStatus.InvalidChunkCount += convertFromPCParameters2.InvalidChunkCount;
				}
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00022B2C File Offset: 0x00020D2C
		private string method_38(string string_2, string string_3)
		{
			string text = string_2 + string_3;
			if (string_3.ToLower() != "region" && Utils.GetRegionFileCount(text) == 0)
			{
				int regionFileCount = Utils.GetRegionFileCount(text + this.string_1);
				if (regionFileCount > 0)
				{
					text += this.string_1;
				}
			}
			return FileUtils.CheckFolderSep(text);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00022B88 File Offset: 0x00020D88
		private void method_39(string string_2, string string_3, ConvertParameters convertParameters_0)
		{
			TagNodeCompound tagNodeCompound = this.method_32(string_3 + Working.smethod_4());
			TagNodeCompound tagNodeCompound2 = this.method_33(string_2);
			if (tagNodeCompound != null && tagNodeCompound2 != null)
			{
				string fileName = Path.GetFileName(string_2.Substring(0, string_2.Length - 1));
				tagNodeCompound["LevelName"] = new TagNodeString(fileName);
				if (tagNodeCompound2.ContainsKey("generatorName"))
				{
					tagNodeCompound["generatorName"] = tagNodeCompound2["generatorName"].Copy();
				}
				if (tagNodeCompound2.ContainsKey("generatorVersion"))
				{
					tagNodeCompound["generatorVersion"] = tagNodeCompound2["generatorVersion"].Copy();
				}
				if (tagNodeCompound2.ContainsKey("allowCommands"))
				{
					tagNodeCompound["hasBeenInCreative"] = tagNodeCompound2["allowCommands"].Copy();
				}
				if (tagNodeCompound2.ContainsKey("GameType"))
				{
					tagNodeCompound["GameType"] = tagNodeCompound2["GameType"].Copy();
				}
				tagNodeCompound["spawnBonusChest"] = new TagNodeByte(0);
				if (tagNodeCompound2 != null)
				{
					if (tagNodeCompound2.ContainsKey("DayTime"))
					{
						tagNodeCompound["DayTime"] = tagNodeCompound2["DayTime"].Copy();
					}
					else
					{
						tagNodeCompound["DayTime"] = new TagNodeLong(100L);
					}
					if (tagNodeCompound2.ContainsKey("Time"))
					{
						tagNodeCompound["Time"] = tagNodeCompound2["Time"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("raining"))
					{
						tagNodeCompound["raining"] = tagNodeCompound2["raining"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("rainTime"))
					{
						tagNodeCompound["rainTime"] = tagNodeCompound2["rainTime"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("thundering"))
					{
						tagNodeCompound["thundering"] = tagNodeCompound2["thundering"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("thunderTime"))
					{
						tagNodeCompound["thunderTime"] = tagNodeCompound2["thunderTime"].Copy();
					}
					int num = tagNodeCompound2["SpawnX"] as TagNodeInt;
					int d = tagNodeCompound2["SpawnY"] as TagNodeInt;
					int num2 = tagNodeCompound2["SpawnZ"] as TagNodeInt;
					if (num > 431 || num < -432)
					{
						num = 0;
					}
					if (num2 > 431 || num2 < -432)
					{
						num2 = 0;
					}
					tagNodeCompound["SpawnX"] = new TagNodeInt(num);
					tagNodeCompound["SpawnY"] = new TagNodeInt(d);
					tagNodeCompound["SpawnZ"] = new TagNodeInt(num2);
					if (convertParameters_0.ConvertNewGen)
					{
						tagNodeCompound["XZSize"] = new TagNodeInt(64);
					}
				}
				TagNodeCompound tagNodeCompound3 = new TagNodeCompound();
				tagNodeCompound3["Data"] = tagNodeCompound;
				string text = string_3 + Working.smethod_4() + "level.dat";
				Class36.smethod_38(tagNodeCompound3, text);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000474E File Offset: 0x0000294E
		public void SaveFiles(string workingFolder, Dictionary<string, ModifiedFile> modifiedFiles)
		{
			this.method_49("Processing Files...", 0);
			this.method_40(workingFolder, modifiedFiles);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00022EAC File Offset: 0x000210AC
		private void method_40(string string_2, Dictionary<string, ModifiedFile> dictionary_0)
		{
			List<ModifiedFile> list = new List<ModifiedFile>();
			foreach (string key in dictionary_0.Keys)
			{
				ModifiedFile modifiedFile = dictionary_0[key];
				if (modifiedFile.FileState != FileStateType.PINNED)
				{
					if (modifiedFile.Tag is ChunkData)
					{
						if (modifiedFile.FileState == FileStateType.MODIFIED)
						{
							modifiedFile.FileNode.Save();
						}
						list.Add(modifiedFile);
					}
					else if (modifiedFile.FileState == FileStateType.MODIFIED && modifiedFile.FileNode != null)
					{
						modifiedFile.FileNode.Save();
					}
				}
			}
			if (list.Count > 0)
			{
				this.method_42(list, string_2);
			}
			this.method_4(string_2, dictionary_0.Values.ToList<ModifiedFile>(), false);
			this.method_41(dictionary_0);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00022F84 File Offset: 0x00021184
		private void method_41(Dictionary<string, ModifiedFile> dictionary_0)
		{
			List<string> list = new List<string>();
			foreach (string text in dictionary_0.Keys)
			{
				if (dictionary_0[text].FileState == FileStateType.DELETED)
				{
					list.Add(text);
				}
				else if (dictionary_0[text].FileState == FileStateType.MODIFIED)
				{
					dictionary_0[text].FileState = FileStateType.PINNED;
				}
			}
			foreach (string key in list)
			{
				dictionary_0.Remove(key);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00023050 File Offset: 0x00021250
		private void method_42(List<ModifiedFile> list_0, string string_2)
		{
			new ProcessCaller();
			Dictionary<Guid, List<ModifiedFile>> dictionary = new Dictionary<Guid, List<ModifiedFile>>();
			foreach (ModifiedFile modifiedFile in list_0)
			{
				ChunkData chunkData = modifiedFile.Tag as ChunkData;
				ChunkIndexEntry chunkIndexEntry = chunkData.method_0();
				IndexEntry regionIndex = chunkData.RegionIndex;
				if (modifiedFile.FileState != FileStateType.MODIFIED && modifiedFile.FileState == FileStateType.DELETED)
				{
					chunkIndexEntry.OldChunkOffset = 0U;
					chunkIndexEntry.OldChunkLength = 0;
					chunkIndexEntry.NewChunkOffset = 0U;
					chunkIndexEntry.NewChunkLength = 0;
				}
				if (!dictionary.ContainsKey(regionIndex.Key))
				{
					dictionary[regionIndex.Key] = new List<ModifiedFile>();
				}
				dictionary[regionIndex.Key].Add(modifiedFile);
			}
			this.method_43(string_2, dictionary);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00023130 File Offset: 0x00021330
		private void method_43(string string_2, Dictionary<Guid, List<ModifiedFile>> dictionary_0)
		{
			foreach (Guid key in dictionary_0.Keys)
			{
				List<ModifiedFile> list = dictionary_0[key];
				if (list != null && list.Count > 0)
				{
					ChunkData chunkData = list[0].Tag as ChunkData;
					IndexEntry regionIndex = chunkData.RegionIndex;
					string parentName = regionIndex.ParentName;
					string region = regionIndex.FileName.Substring(0, regionIndex.FileName.LastIndexOf('.'));
					this.UpdatedRegionFile(parentName, region, list, string_2);
				}
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00004764 File Offset: 0x00002964
		public MCSupport()
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00004782 File Offset: 0x00002982
		public MCSupport(BackgroundWorker bw)
		{
			this.bw = bw;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000231DC File Offset: 0x000213DC
		private void method_44(ConvertParameters convertParameters_0)
		{
			int num = 0;
			if (convertParameters_0.ConvertOverworld)
			{
				num += Constants.regionSizes["region"];
			}
			if (convertParameters_0.ConvertNether)
			{
				num += Constants.regionSizes["DIM-1"];
			}
			if (convertParameters_0.ConvertTheEnd)
			{
				num += Constants.regionSizes["DIM1"];
			}
			this.int_1 = num * 4;
			this.int_0 = 0;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0002324C File Offset: 0x0002144C
		private void method_45(string string_2, bool bool_0)
		{
			int num = 0;
			if (bool_0)
			{
				num += Constants.regionSizesExt[string_2];
			}
			else
			{
				num += Constants.regionSizes[string_2];
			}
			this.int_1 = num * 4;
			this.int_0 = 0;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0002328C File Offset: 0x0002148C
		private void method_46(string string_2)
		{
			int num = 0 + Constants.regionSizes[string_2];
			this.int_1 = num;
			this.int_0 = 0;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000232B8 File Offset: 0x000214B8
		internal static void smethod_0(string string_2)
		{
			if (string_2.IndexOf("\\") > 0)
			{
				string text = string_2.Substring(0, string_2.LastIndexOf('\\'));
				FileUtils.smethod_9(text);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000047A7 File Offset: 0x000029A7
		internal static void smethod_1(IndexEntry indexEntry_0, string string_2)
		{
			MCSupport.smethod_0(string_2 + indexEntry_0.FilePath);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000232EC File Offset: 0x000214EC
		private void method_47(string string_2)
		{
			DateTime now = DateTime.Now;
			string text = string_2 + string.Format(".Archive.{0}.{1}.{2}.{3}.{4}.{5}", new object[]
			{
				now.Month,
				now.Day,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
			if (File.Exists(string_2))
			{
				FileUtils.smethod_11(string_2, text);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00023384 File Offset: 0x00021584
		private void method_48(string string_2)
		{
			this.int_0++;
			int int_ = (int)((float)(this.int_0 + 1) / (float)this.int_1 * 100f);
			this.method_49(string_2, int_);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000047BA File Offset: 0x000029BA
		private void method_49(string string_2, int int_2 = 0)
		{
			if (this.bw != null)
			{
				this.bw.ReportProgress(int_2, string_2);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000233C0 File Offset: 0x000215C0
		private void method_50(string string_2)
		{
			if (this.method_51(string_2))
			{
				Class2 @class = new Class2();
				@class.method_1(string_2);
				@class.method_3(string_2);
				@class.method_2(string_2);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000047D1 File Offset: 0x000029D1
		private bool method_51(string string_2)
		{
			return File.Exists(string_2 + "\\GAMEDATA") && File.Exists(string_2 + "\\METADATA") && File.Exists(string_2 + "\\PARAM.PFD");
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000469B File Offset: 0x0000289B
		[CompilerGenerated]
		private static int smethod_2(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00004809 File Offset: 0x00002A09
		[CompilerGenerated]
		private static int smethod_3(ModifiedFile modifiedFile_0)
		{
			return ((ChunkData)modifiedFile_0.Tag).method_0().ChunkIndex;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00004820 File Offset: 0x00002A20
		[CompilerGenerated]
		private static string smethod_4(IndexEntry indexEntry_0)
		{
			return indexEntry_0.FileExt;
		}

		// Token: 0x0400023C RID: 572
		private string string_0 = "0a00010a0a00044461746104000a52616e646f6d53656564b2e82133c8e95fc008000d67656e657261746f724e616d65000764656661756c7406000d426f7264657243656e7465725a000000000000000001000a446966666963756c747902040012426f7264657253697a654c65727054696d6500000000000000000100077261696e696e670104000454696d650000000000c574a703000847616d65547970650000000101000b4d617046656174757265730006000d426f7264657243656e746572580000000000000000060014426f7264657244616d616765506572426c6f636b3fc999999999999a060013426f726465725761726e696e67426c6f636b734014000000000000060014426f7264657253697a654c657270546172676574418c9c380000000004000744617954696d650000000000c62c2301000b696e697469616c697a65640101000d616c6c6f77436f6d6d616e64730104000a53697a654f6e4469736b0000000000000000030006537061776e59000000400300087261696e54696d65000025a003000b7468756e64657254696d650000827f030006537061776e5affffffac01000868617264636f726500010010446966666963756c74794c6f636b656400030006537061776e58ffffffd0030010636c6561725765617468657254696d650000000001000a7468756e646572696e670003001067656e657261746f7256657273696f6e0000000103000776657273696f6e00004abd06000e426f72646572536166655a6f6e65401400000000000008001067656e657261746f724f7074696f6e73000004000a4c617374506c61796564000001507d24f2f1060011426f726465725761726e696e6754696d65402e0000000000000800094c6576656c4e616d65000006000a426f7264657253697a65418c9c38000000000000";

		// Token: 0x0400023D RID: 573
		private string string_1 = "\\region";

		// Token: 0x0400023E RID: 574
		private BackgroundWorker bw;

		// Token: 0x0400023F RID: 575
		private int int_0;

		// Token: 0x04000240 RID: 576
		private int int_1;

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;

		// Token: 0x04000242 RID: 578
		[CompilerGenerated]
		private static Func<ModifiedFile, int> func_1;

		// Token: 0x04000243 RID: 579
		[CompilerGenerated]
		private static Func<IndexEntry, string> func_2;
	}
}
