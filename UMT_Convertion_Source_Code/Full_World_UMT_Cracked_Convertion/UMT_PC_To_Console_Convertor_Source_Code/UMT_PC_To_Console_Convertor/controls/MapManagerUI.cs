using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Substrate.Data;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.controls
{
	// Token: 0x0200002D RID: 45
	public class MapManagerUI : UserControl
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060001AE RID: 430 RVA: 0x0000F7EC File Offset: 0x0000D9EC
		// (remove) Token: 0x060001AF RID: 431 RVA: 0x0000F824 File Offset: 0x0000DA24
		public event EventHandler DataChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000F85C File Offset: 0x0000DA5C
		public MapManagerUI()
		{
			byte[] array = new byte[8];
			this.byte_1 = array;
			this.byte_2 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				82,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
			base..ctor();
			this.method_18();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00003420 File Offset: 0x00001620
		public void Clear()
		{
			this.bool_1 = false;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00003429 File Offset: 0x00001629
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00003431 File Offset: 0x00001631
		public bool MapsChanged
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000343A File Offset: 0x0000163A
		private void method_0(MapItem mapItem_0)
		{
			if (mapItem_0 != null)
			{
				this.pictureBox_1.Image = mapItem_0.MapImage;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		public void LoadMaps()
		{
			if (!this.bool_1)
			{
				this.sortedDictionary_0 = this.imageUtils_0.LoadMaps();
				this.mapItemList_0.LoadList(this.sortedDictionary_0.Values.ToList<MCMap>());
				this.method_1();
				this.bool_1 = true;
				this.bool_2 = false;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00003450 File Offset: 0x00001650
		private void method_1()
		{
			this.mapItemList_0.Check();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000345D File Offset: 0x0000165D
		private void method_2(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000345D File Offset: 0x0000165D
		private void method_3(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000F950 File Offset: 0x0000DB50
		private void sfareflwRN(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapManagerUI::sfareflwRN(System.Object,System.EventArgs)

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

		// Token: 0x060001BA RID: 442 RVA: 0x00003465 File Offset: 0x00001665
		private void method_4(MCMap mcmap_1)
		{
			if (mcmap_1 != null)
			{
				this.mcmap_0 = mcmap_1;
				this.label_0.Text = this.mcmap_0.Name;
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000F974 File Offset: 0x0000DB74
		private void kSdrqomFv7(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (array.Length > 0)
			{
				string text = array[0];
				string extension = Path.GetExtension(text);
				if (this.list_0.Contains(extension.ToLower()))
				{
					this.method_6(text);
				}
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00003487 File Offset: 0x00001687
		private void method_5(object sender, DragEventArgs e)
		{
			e.Data.GetFormats();
			e.Effect = DragDropEffects.Copy;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		private void method_6(string string_0)
		{
			this.bool_0 = true;
			if (!string.IsNullOrWhiteSpace(string_0))
			{
				this.bitmap_0 = new Bitmap(string_0);
				Bitmap bitmap;
				if (this.bitmap_0.Width > this.pictureBox_0.Width || this.bitmap_0.Height > this.pictureBox_0.Height)
				{
					bitmap = this.imageUtils_0.ResizeWithPerspective(this.bitmap_0, this.pictureBox_0.Width, this.pictureBox_0.Height, this.checkBox_0.Checked);
				}
				else
				{
					bitmap = this.bitmap_0;
				}
				this.pictureBox_0.Image = bitmap;
				this.checkBox_1.Checked = true;
				this.checkBox_1.Enabled = true;
				this.checkBox_0.Enabled = true;
				this.numericUpDown_1.Value = this.bitmap_0.Width;
				this.numericUpDown_0.Value = this.bitmap_0.Height;
				this.label_5.Text = string.Concat(new object[]
				{
					this.bitmap_0.Width,
					"W ",
					this.bitmap_0.Height,
					"H"
				});
				this.method_7();
				MapConverter mapConverter = new MapConverter();
				this.pictureBox_1.Image = mapConverter.ConvertBitmap(bitmap);
			}
			this.bool_0 = false;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		private void numericUpDown_1_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0 && this.checkBox_1.Checked)
			{
				this.bool_0 = true;
				decimal d = this.bitmap_0.Height / this.bitmap_0.Width;
				int value = (int)(this.numericUpDown_1.Value * d);
				this.numericUpDown_0.Value = value;
				this.bool_0 = false;
			}
			this.method_7();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0 && this.checkBox_1.Checked)
			{
				this.bool_0 = true;
				decimal d = this.bitmap_0.Width / this.bitmap_0.Height;
				int value = (int)(this.numericUpDown_0.Value * d);
				this.numericUpDown_1.Value = value;
				this.bool_0 = false;
			}
			this.method_7();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000FC44 File Offset: 0x0000DE44
		private void method_7()
		{
			decimal value = this.numericUpDown_1.Value;
			decimal value2 = this.numericUpDown_0.Value;
			int num = (int)Math.Ceiling(value / 128m);
			int num2 = (int)Math.Ceiling(value2 / 128m);
			this.label_2.Text = string.Format("Maps Width: {0}  Maps Height: {1}  Border X {2}  Border Y {3}", new object[]
			{
				num,
				num2,
				num * 128 - value,
				num2 * 128 - value2
			});
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000349C File Offset: 0x0000169C
		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000FD08 File Offset: 0x0000DF08
		private void method_8()
		{
			/*
An exception occurred when decompiling this method (060001C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void UMT_PC_To_Console_Convertor.controls.MapManagerUI::method_8()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000034A4 File Offset: 0x000016A4
		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		private void method_9()
		{
			if (this.sortedDictionary_0 != null)
			{
				int num = 0;
				if (this.sortedDictionary_0.Count > 0)
				{
					int[] array = this.sortedDictionary_0.Keys.ToArray<int>();
					num = this.sortedDictionary_0[array[array.Length - 1]].Index + 1;
				}
				MCMap mcmap = new MCMap(num);
				this.sortedDictionary_0.Add(num, mcmap);
				this.mapItemList_0.AddMap(mcmap);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000034AC File Offset: 0x000016AC
		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000FE1C File Offset: 0x0000E01C
		private void method_10()
		{
			string string_ = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp";
			string text = FileUtils.smethod_1("*.png", string_, null, null);
			if (!string.IsNullOrWhiteSpace(text))
			{
				this.method_6(text);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000034B4 File Offset: 0x000016B4
		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.SaveMaps();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public void SaveMaps()
		{
			if (this.sortedDictionary_0 != null)
			{
				this.method_12();
				foreach (MCMap mcmap in this.sortedDictionary_0.Values)
				{
					if (mcmap.MapStatus != MapStatusType.NoChange)
					{
						this.method_11(mcmap.Index, mcmap.Map);
						Working.DataChanged = true;
						mcmap.MapStatus = MapStatusType.NoChange;
					}
				}
			}
			this.bool_2 = false;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		private void method_11(int int_0, Map map_0)
		{
			TagNodeCompound tree = map_0.BuildTree() as TagNodeCompound;
			NbtTree nbtTree = new NbtTree(tree);
			MemoryStream memoryStream = new MemoryStream();
			nbtTree.WriteTo(memoryStream);
			string filename = string.Concat(new string[]
			{
				Working.smethod_5(),
				Working.smethod_4(),
				"data\\map_",
				int_0.ToString(),
				".dat"
			});
			FileUtils.WriteFile(memoryStream, filename);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000FF50 File Offset: 0x0000E150
		private void method_12()
		{
			MemoryStream memoryStream = new MemoryStream();
			string format = "data/map_{0}.dat";
			int num = 0;
			if (this.sortedDictionary_0 != null)
			{
				foreach (MCMap mcmap in this.sortedDictionary_0.Values)
				{
					if (mcmap.MapStatus == MapStatusType.New)
					{
						string s = string.Format(format, mcmap.Index);
						byte[] bytes = Encoding.Unicode.GetBytes(s);
						byte[] array = new byte[144];
						for (int i = 0; i < bytes.Length; i++)
						{
							array[i + 1] = bytes[i];
						}
						memoryStream.Write(array, 0, array.Length);
						num++;
					}
				}
			}
			if (num > 0)
			{
				this.method_13(num, memoryStream);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00010034 File Offset: 0x0000E234
		private void method_13(int int_0, MemoryStream memoryStream_0)
		{
			Class37 @class = new Class37();
			string path = Working.smethod_5() + Working.smethod_1();
			int num = 0;
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					binaryReader.BaseStream.Seek(4L, SeekOrigin.Begin);
					num = @class.method_2(binaryReader.BaseStream);
				}
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open)))
				{
					num += int_0;
					binaryWriter.BaseStream.Seek(4L, SeekOrigin.Begin);
					@class.method_7(num, binaryWriter.BaseStream);
					byte[] array = memoryStream_0.ToArray();
					binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
					binaryWriter.Write(array, 0, array.Length);
				}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00010130 File Offset: 0x0000E330
		private void method_14()
		{
			string path = Working.smethod_5() + Working.smethod_4() + "data\\largeMapDataMappings.dat";
			if (File.Exists(path))
			{
				this.method_16();
				return;
			}
			this.method_15();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00010168 File Offset: 0x0000E368
		private void method_15()
		{
			if (this.sortedDictionary_0 != null && this.sortedDictionary_0.Count > 0)
			{
				new Class37();
				string filename = Working.smethod_5() + Working.smethod_4() + "data\\mapDataMappings.dat";
				MemoryStream memoryStream = new MemoryStream();
				for (int i = 0; i < 264; i++)
				{
					if (this.sortedDictionary_0.ContainsKey(i))
					{
						memoryStream.Write(this.byte_0, 0, this.byte_0.Length);
					}
					else
					{
						memoryStream.Write(this.byte_1, 0, this.byte_1.Length);
					}
				}
				FileUtils.WriteFile(memoryStream, filename);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00010204 File Offset: 0x0000E404
		private void method_16()
		{
			if (this.sortedDictionary_0 != null && this.sortedDictionary_0.Count > 0)
			{
				Class37 @class = new Class37();
				string filename = Working.smethod_5() + Working.smethod_4() + "data\\largeMapDataMappings.dat";
				MemoryStream memoryStream = new MemoryStream();
				@class.method_7(this.sortedDictionary_0.Count, memoryStream);
				memoryStream.Write(this.byte_0, 0, this.byte_0.Length);
				@class.method_7(this.sortedDictionary_0.Count, memoryStream);
				int int_ = 12;
				for (int i = 0; i < this.sortedDictionary_0.Count; i++)
				{
					@class.method_7(0, memoryStream);
					@class.method_7(int_, memoryStream);
					@class.method_7(i, memoryStream);
				}
				memoryStream.Write(this.byte_2, 0, this.byte_2.Length);
				FileUtils.WriteFile(memoryStream, filename);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000034BC File Offset: 0x000016BC
		private void method_17()
		{
			this.bool_2 = true;
			this.OnDataChanged(this);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000102DC File Offset: 0x0000E4DC
		protected virtual void OnDataChanged(object sender)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, null);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000102FC File Offset: 0x0000E4FC
		private void MapManagerUI_Resize(object sender, EventArgs e)
		{
			int num = (base.Width - (this.panel_0.Width + 40)) / 2;
			int num2 = this.mapItemList_0.Top - (this.pictureBox_0.Top + 20);
			int num3 = (num < num2) ? num : num2;
			this.pictureBox_0.Width = num3;
			this.pictureBox_0.Height = num3;
			this.pictureBox_1.Width = num3;
			this.pictureBox_1.Height = num3;
			this.pictureBox_0.Left = 10;
			this.panel_0.Left = this.pictureBox_0.Left + this.pictureBox_0.Width + 10;
			this.pictureBox_1.Left = this.panel_0.Left + this.panel_0.Width + 10;
			this.label_5.Top = this.pictureBox_0.Top + this.pictureBox_0.Height;
			this.label_5.Width = this.pictureBox_0.Width;
			this.label_5.Left = this.pictureBox_0.Left;
			this.label_2.Top = this.pictureBox_1.Top + this.pictureBox_1.Height;
			this.label_2.Width = this.pictureBox_1.Width;
			this.label_2.Left = this.pictureBox_1.Left;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000034CC File Offset: 0x000016CC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00010468 File Offset: 0x0000E668
		private void method_18()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MapManagerUI));
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.label_2 = new Label();
			this.button_0 = new Button();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.numericUpDown_1 = new NumericUpDown();
			this.label_5 = new Label();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.pictureBox_0 = new PictureBox();
			this.pictureBox_1 = new PictureBox();
			this.panel_0 = new Panel();
			this.mapItemList_0 = new MapItemList();
			this.toolStrip_0.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			((ISupportInitialize)this.pictureBox_0).BeginInit();
			((ISupportInitialize)this.pictureBox_1).BeginInit();
			this.panel_0.SuspendLayout();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 180);
			this.label_0.Name = "lblActiveMap";
			this.label_0.Size = new Size(25, 13);
			this.label_0.TabIndex = 40;
			this.label_0.Text = "      ";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 167);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(61, 13);
			this.label_1.TabIndex = 39;
			this.label_1.Text = "Active Map";
			this.toolStrip_0.AutoSize = false;
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_1,
				this.toolStripButton_0,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.RenderMode = ToolStripRenderMode.System;
			this.toolStrip_0.Size = new Size(962, 45);
			this.toolStrip_0.TabIndex = 38;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.AutoSize = false;
			this.toolStripButton_0.BackColor = Color.Transparent;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("btnAddMap.Image");
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "btnAddMap";
			this.toolStripButton_0.Size = new Size(100, 22);
			this.toolStripButton_0.Text = "Add Map";
			this.toolStripButton_0.TextImageRelation = TextImageRelation.Overlay;
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.AutoSize = false;
			this.toolStripButton_1.BackColor = Color.Transparent;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("btnLoadImage.Image");
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "btnLoadImage";
			this.toolStripButton_1.Size = new Size(100, 22);
			this.toolStripButton_1.Text = "Load Image";
			this.toolStripButton_1.TextImageRelation = TextImageRelation.Overlay;
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.AutoSize = false;
			this.toolStripButton_2.BackColor = Color.Transparent;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("btnSave.Image");
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "btnSave";
			this.toolStripButton_2.Size = new Size(100, 22);
			this.toolStripButton_2.Text = "Save Changes";
			this.toolStripButton_2.TextImageRelation = TextImageRelation.Overlay;
			this.toolStripButton_2.Visible = false;
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.label_2.Location = new Point(554, 446);
			this.label_2.Name = "lblBlockSize";
			this.label_2.Size = new Size(387, 12);
			this.label_2.TabIndex = 37;
			this.label_2.TextAlign = ContentAlignment.MiddleLeft;
			this.button_0.Location = new Point(15, 122);
			this.button_0.Name = "btnConvert";
			this.button_0.Size = new Size(105, 23);
			this.button_0.TabIndex = 36;
			this.button_0.Text = "Convert";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(85, 70);
			this.label_3.Name = "label2";
			this.label_3.Size = new Size(38, 13);
			this.label_3.TabIndex = 35;
			this.label_3.Text = "Height";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(85, 48);
			this.label_4.Name = "label1";
			this.label_4.Size = new Size(35, 13);
			this.label_4.TabIndex = 34;
			this.label_4.Text = "Width";
			this.numericUpDown_0.Location = new Point(15, 68);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 8192;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Name = "nudHeight";
			this.numericUpDown_0.Size = new Size(63, 20);
			this.numericUpDown_0.TabIndex = 33;
			this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
			this.numericUpDown_1.Location = new Point(15, 42);
			NumericUpDown numericUpDown2 = this.numericUpDown_1;
			int[] array2 = new int[4];
			array2[0] = 8192;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDown_1.Name = "nudWidth";
			this.numericUpDown_1.Size = new Size(63, 20);
			this.numericUpDown_1.TabIndex = 32;
			this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
			this.label_5.Location = new Point(12, 447);
			this.label_5.Name = "lblImageSize";
			this.label_5.Size = new Size(131, 12);
			this.label_5.TabIndex = 31;
			this.label_5.TextAlign = ContentAlignment.MiddleLeft;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(15, 98);
			this.checkBox_0.Name = "cbInterpolate";
			this.checkBox_0.Size = new Size(76, 17);
			this.checkBox_0.TabIndex = 30;
			this.checkBox_0.Text = "Interpolate";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(15, 14);
			this.checkBox_1.Name = "cbRetainPerspective";
			this.checkBox_1.Size = new Size(113, 17);
			this.checkBox_1.TabIndex = 29;
			this.checkBox_1.Text = "RetainPerspective";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.pictureBox_0.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBox_0.Location = new Point(12, 59);
			this.pictureBox_0.Name = "pbInImage";
			this.pictureBox_0.Size = new Size(384, 384);
			this.pictureBox_0.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox_0.TabIndex = 26;
			this.pictureBox_0.TabStop = false;
			this.pictureBox_1.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBox_1.Location = new Point(557, 59);
			this.pictureBox_1.Name = "pbDstImg";
			this.pictureBox_1.Size = new Size(384, 384);
			this.pictureBox_1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox_1.TabIndex = 27;
			this.pictureBox_1.TabStop = false;
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.checkBox_1);
			this.panel_0.Controls.Add(this.label_1);
			this.panel_0.Controls.Add(this.checkBox_0);
			this.panel_0.Controls.Add(this.numericUpDown_1);
			this.panel_0.Controls.Add(this.numericUpDown_0);
			this.panel_0.Controls.Add(this.label_4);
			this.panel_0.Controls.Add(this.label_3);
			this.panel_0.Location = new Point(402, 59);
			this.panel_0.Name = "pnlControls";
			this.panel_0.Size = new Size(140, 204);
			this.panel_0.TabIndex = 41;
			this.mapItemList_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.mapItemList_0.BorderStyle = BorderStyle.FixedSingle;
			this.mapItemList_0.Location = new Point(12, 471);
			this.mapItemList_0.Name = "mapItemList1";
			this.mapItemList_0.Size = new Size(931, 195);
			this.mapItemList_0.TabIndex = 28;
			this.mapItemList_0.MapActive += this.sfareflwRN;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.toolStrip_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.pictureBox_0);
			base.Controls.Add(this.pictureBox_1);
			base.Controls.Add(this.mapItemList_0);
			base.Name = "MapManagerUI";
			base.Size = new Size(962, 679);
			base.Resize += this.MapManagerUI_Resize;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			((ISupportInitialize)this.pictureBox_0).EndInit();
			((ISupportInitialize)this.pictureBox_1).EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000E9 RID: 233
		private EventHandler eventHandler_0;

		// Token: 0x040000EA RID: 234
		private ImageUtils imageUtils_0 = new ImageUtils();

		// Token: 0x040000EB RID: 235
		private List<string> list_0 = new List<string>
		{
			".png",
			".jpg",
			".gif",
			".bmp"
		};

		// Token: 0x040000EC RID: 236
		private SortedDictionary<int, MCMap> sortedDictionary_0;

		// Token: 0x040000ED RID: 237
		private MCMap mcmap_0;

		// Token: 0x040000EE RID: 238
		private Bitmap bitmap_0;

		// Token: 0x040000EF RID: 239
		private bool bool_0;

		// Token: 0x040000F0 RID: 240
		private bool bool_1;

		// Token: 0x040000F1 RID: 241
		private bool bool_2;

		// Token: 0x040000F2 RID: 242
		private VScrollBar vscrollBar_0;

		// Token: 0x040000F3 RID: 243
		private HScrollBar hscrollBar_0;

		// Token: 0x040000F4 RID: 244
		private byte[] byte_0 = new byte[]
		{
			224,
			0,
			0,
			124,
			174,
			247,
			3,
			73
		};

		// Token: 0x040000F5 RID: 245
		private byte[] byte_1;

		// Token: 0x040000F6 RID: 246
		private byte[] byte_2;

		// Token: 0x040000F7 RID: 247
		private IContainer icontainer_0;

		// Token: 0x040000F8 RID: 248
		private Label label_0;

		// Token: 0x040000F9 RID: 249
		private Label label_1;

		// Token: 0x040000FA RID: 250
		private ToolStrip toolStrip_0;

		// Token: 0x040000FB RID: 251
		private ToolStripButton toolStripButton_0;

		// Token: 0x040000FC RID: 252
		private ToolStripButton toolStripButton_1;

		// Token: 0x040000FD RID: 253
		private ToolStripButton toolStripButton_2;

		// Token: 0x040000FE RID: 254
		private Label label_2;

		// Token: 0x040000FF RID: 255
		private Button button_0;

		// Token: 0x04000100 RID: 256
		private Label label_3;

		// Token: 0x04000101 RID: 257
		private Label label_4;

		// Token: 0x04000102 RID: 258
		private NumericUpDown numericUpDown_0;

		// Token: 0x04000103 RID: 259
		private NumericUpDown numericUpDown_1;

		// Token: 0x04000104 RID: 260
		private Label label_5;

		// Token: 0x04000105 RID: 261
		private CheckBox checkBox_0;

		// Token: 0x04000106 RID: 262
		private CheckBox checkBox_1;

		// Token: 0x04000107 RID: 263
		private PictureBox pictureBox_0;

		// Token: 0x04000108 RID: 264
		private PictureBox pictureBox_1;

		// Token: 0x04000109 RID: 265
		private MapItemList mapItemList_0;

		// Token: 0x0400010A RID: 266
		private Panel panel_0;
	}
}
