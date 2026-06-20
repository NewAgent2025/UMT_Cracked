using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x0200003B RID: 59
	public class BiomeSelector : UserControl
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000212 RID: 530 RVA: 0x00013344 File Offset: 0x00011544
		// (remove) Token: 0x06000213 RID: 531 RVA: 0x0001337C File Offset: 0x0001157C
		public event EventHandler BiomeChanged
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00003457 File Offset: 0x00001657
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00003469 File Offset: 0x00001669
		public int Biome
		{
			get
			{
				return (int)this.class7_0.SelectedValue;
			}
			set
			{
				this.class7_0.SelectedValue = value.ToString();
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000347D File Offset: 0x0000167D
		public BiomeSelector()
		{
			this.method_1();
			this.method_0();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000133B4 File Offset: 0x000115B4
		private void method_0()
		{
			List<Biome> list = Constants.consoleBiomeList.Values.ToList<Biome>();
			for (int i = 0; i < list.Count; i++)
			{
				Biome biome = list[i];
				DropDownItem item = new DropDownItem(biome.Id, (int)biome.Color, biome.Name);
				this.list_0.Add(item);
			}
			this.class7_0.ValueMember = "Key";
			this.class7_0.DisplayMember = "Text";
			this.class7_0.DataSource = this.list_0;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00013440 File Offset: 0x00011640
		protected virtual void OnBiomeChanged(object sender, e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00013460 File Offset: 0x00011660
		private void class7_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000219)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.BiomeSelector::class7_0_SelectedIndexChanged(System.Object,System.EventArgs)

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

		// Token: 0x0600021A RID: 538 RVA: 0x0000349C File Offset: 0x0000169C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000134A0 File Offset: 0x000116A0
		private void method_1()
		{
			this.class7_0 = new Class7();
			base.SuspendLayout();
			this.class7_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.class7_0.DrawMode = DrawMode.OwnerDrawFixed;
			this.class7_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.class7_0.FormattingEnabled = true;
			this.class7_0.Location = new Point(0, 3);
			this.class7_0.Name = "csBiome";
			this.class7_0.Size = new Size(184, 21);
			this.class7_0.TabIndex = 3;
			this.class7_0.SelectedIndexChanged += this.class7_0_SelectedIndexChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.class7_0);
			base.Name = "BiomeSelector";
			base.Size = new Size(187, 28);
			base.ResumeLayout(false);
		}

		// Token: 0x04000149 RID: 329
		private EventHandler eventHandler_0;

		// Token: 0x0400014A RID: 330
		private List<DropDownItem> list_0 = new List<DropDownItem>();

		// Token: 0x0400014B RID: 331
		private IContainer icontainer_0;

		// Token: 0x0400014C RID: 332
		private Class7 class7_0;
	}
}
