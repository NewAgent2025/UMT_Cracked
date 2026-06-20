using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Substrate.Nbt;

namespace Full_UMT_Convertor.controls
{
	// Token: 0x02000041 RID: 65
	public partial class EnchantOfferForm : Form
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00003659 File Offset: 0x00001859
		public EnchantOfferForm(enchantmentChanged)
		{
			this.method_3();
			this.enchantmentChanged = enchantmentChanged;
			this.numericUpDown_0.Text = "";
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003689 File Offset: 0x00001889
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			base.CenterToParent();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00014698 File Offset: 0x00012898
		public void Update(OfferItem offerItem)
		{
			this.listView_0.ItemSelectionChanged -= this.listView_0_ItemSelectionChanged;
			this.numericUpDown_0.ValueChanged -= this.numericUpDown_0_ValueChanged;
			this.DlxXbhfhae.SelectedIndexChanged -= this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.ValueChanged -= this.numericUpDown_1_ValueChanged;
			this.offerItem_0 = offerItem;
			this.listView_0.Items.Clear();
			this.numericUpDown_0.Text = "";
			this.DlxXbhfhae.Items.Clear();
			this.numericUpDown_1.Enabled = false;
			this.numericUpDown_1.Value = 0m;
			if (offerItem != null && offerItem != null)
			{
				if (offerItem.Enchantable || offerItem.Enchanted || this.checkBox_0.Checked)
				{
					this.numericUpDown_0.Enabled = this.checkBox_0.Checked;
					Control dlxXbhfhae = this.DlxXbhfhae;
					if (offerItem.Enchantable)
					{
						goto IL_2FD;
					}
					bool enabled = this.checkBox_0.Checked;
					IL_118:
					dlxXbhfhae.Enabled = enabled;
					TagNodeCompound tag = offerItem.Tag;
					short item = Class46.smethod_73(tag);
					foreach (KeyValuePair<int, Enchantment> keyValuePair in Constants.enchantments)
					{
						Enchantment value = keyValuePair.Value;
						if (this.checkBox_0.Checked || value.Items.Contains(item))
						{
							this.DlxXbhfhae.Items.Add(value);
						}
					}
					this.dictionary_0.Clear();
					if (!tag.ContainsKey("tag"))
					{
						goto IL_318;
					}
					TagNodeCompound tagNodeCompound = tag["tag"] as TagNodeCompound;
					if (!tagNodeCompound.ContainsKey("ench"))
					{
						goto IL_318;
					}
					TagNodeList tagNodeList = tagNodeCompound["ench"] as TagNodeList;
					using (IEnumerator<TagNode> enumerator2 = tagNodeList.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							TagNode tagNode = enumerator2.Current;
							TagNodeCompound tagNodeCompound2 = (TagNodeCompound)tagNode;
							short num = Class46.smethod_73(tagNodeCompound2);
							if (this.dictionary_0.ContainsKey(num))
							{
								MessageBox.Show("Duplicate enchantment with ID '" + offerItem + "' discarded.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
							string text;
							if (Constants.enchantments.ContainsKey((int)num))
							{
								text = Constants.enchantments[(int)num].Name;
							}
							else
							{
								text = "Unknown enchantment " + num;
							}
							ListViewItem listViewItem = new ListViewItem(new string[]
							{
								text,
								(tagNodeCompound2["lvl"] as TagNodeShort).ToString()
							});
							listViewItem.Tag = num;
							this.listView_0.Items.Add(listViewItem);
							this.dictionary_0.Add(num, Tuple.Create<TagNodeCompound, ListViewItem>(tagNodeCompound2, listViewItem));
						}
						goto IL_318;
					}
					IL_2FD:
					enabled = true;
					goto IL_118;
				}
			}
			this.numericUpDown_0.Enabled = false;
			this.DlxXbhfhae.Enabled = false;
			IL_318:
			this.listView_0.ItemSelectionChanged += this.listView_0_ItemSelectionChanged;
			this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
			this.DlxXbhfhae.SelectedIndexChanged += this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00014A50 File Offset: 0x00012C50
		private void method_0(short short_0)
		{
			this.listView_0.ItemSelectionChanged -= this.listView_0_ItemSelectionChanged;
			this.numericUpDown_0.ValueChanged -= this.numericUpDown_0_ValueChanged;
			this.DlxXbhfhae.SelectedIndexChanged -= this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.ValueChanged -= this.numericUpDown_1_ValueChanged;
			Enchantment enchantment = null;
			if (Constants.enchantments.ContainsKey((int)short_0))
			{
				enchantment = Constants.enchantments[(int)short_0];
			}
			TagNodeCompound tagNodeCompound = null;
			if (this.dictionary_0.ContainsKey(short_0))
			{
				tagNodeCompound = this.dictionary_0[short_0].Item1;
			}
			this.listView_0.SelectedItems.Clear();
			if (this.dictionary_0.ContainsKey(short_0))
			{
				this.dictionary_0[short_0].Item2.Selected = true;
			}
			this.numericUpDown_0.Value = short_0;
			this.numericUpDown_0.Text = short_0.ToString();
			if (this.enchantment_0 != null)
			{
				this.DlxXbhfhae.Items.Remove(this.enchantment_0);
			}
			if (enchantment == null)
			{
				this.enchantment_0 = new Enchantment(short_0, "Unknown enchantment " + short_0, 0, new List<short>());
				this.DlxXbhfhae.SelectedIndex = this.DlxXbhfhae.Items.Add(this.enchantment_0);
			}
			else if (!this.DlxXbhfhae.Items.Contains(enchantment))
			{
				this.DlxXbhfhae.SelectedIndex = this.DlxXbhfhae.Items.Add(enchantment);
			}
			else
			{
				this.DlxXbhfhae.Text = enchantment.Name;
			}
			short num = 0;
			if (tagNodeCompound != null && tagNodeCompound.ContainsKey("lvl"))
			{
				num = (tagNodeCompound["lvl"] as TagNodeShort);
			}
			this.numericUpDown_1.Enabled = (this.checkBox_0.Checked || (enchantment != null && enchantment.Items.Contains(this.offerItem_0.Id) && (tagNodeCompound == null || (num >= 0 && (int)num <= enchantment.MaxLevel))));
			bool flag = this.checkBox_0.Checked || enchantment == null || (tagNodeCompound != null && num < 0) || (int)num > enchantment.MaxLevel;
			this.numericUpDown_1.Minimum = (flag ? -32768 : 0);
			this.numericUpDown_1.Maximum = (flag ? 32767 : enchantment.MaxLevel);
			this.numericUpDown_1.Value = ((tagNodeCompound != null) ? num : 0);
			this.listView_0.ItemSelectionChanged += this.listView_0_ItemSelectionChanged;
			this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
			this.DlxXbhfhae.SelectedIndexChanged += this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00014D7C File Offset: 0x00012F7C
		private void method_1()
		{
			this.listView_0.ItemSelectionChanged -= this.listView_0_ItemSelectionChanged;
			this.numericUpDown_0.ValueChanged -= this.numericUpDown_0_ValueChanged;
			this.DlxXbhfhae.SelectedIndexChanged -= this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.ValueChanged -= this.numericUpDown_1_ValueChanged;
			this.listView_0.SelectedItems.Clear();
			this.numericUpDown_0.Value = 0m;
			this.numericUpDown_0.Text = "";
			this.DlxXbhfhae.SelectedItem = null;
			this.numericUpDown_1.Enabled = false;
			this.numericUpDown_1.Value = 0m;
			this.listView_0.ItemSelectionChanged += this.listView_0_ItemSelectionChanged;
			this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
			this.DlxXbhfhae.SelectedIndexChanged += this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00014E9C File Offset: 0x0001309C
		private void method_2(short short_0)
		{
			/*
An exception occurred when decompiling this method (06000240)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Full_UMT_Convertor.controls.EnchantOfferForm::method_2(System.Int16)

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

		// Token: 0x06000241 RID: 577 RVA: 0x00003698 File Offset: 0x00001898
		private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
		{
			this.method_0((short)this.numericUpDown_0.Value);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000036B0 File Offset: 0x000018B0
		private void DlxXbhfhae_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.DlxXbhfhae.SelectedItem != null)
			{
				this.method_0(((Enchantment)this.DlxXbhfhae.SelectedItem).Id);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000036DA File Offset: 0x000018DA
		private void listView_0_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
			{
				this.method_0((short)e.Item.Tag);
				return;
			}
			this.method_1();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00003701 File Offset: 0x00001901
		private void numericUpDown_1_ValueChanged(object sender, EventArgs e)
		{
			this.method_2((short)this.numericUpDown_1.Value);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00015364 File Offset: 0x00013564
		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			if (this.offerItem_0 == null)
			{
				return;
			}
			Enchantment enchantment = null;
			if (Constants.enchantments.ContainsKey((int)((short)this.numericUpDown_0.Value)))
			{
				enchantment = Constants.enchantments[(int)((short)this.numericUpDown_0.Value)];
			}
			this.numericUpDown_0.Enabled = this.checkBox_0.Checked;
			if (enchantment == null && this.numericUpDown_1.Value == 0m)
			{
				this.method_1();
				return;
			}
			this.DlxXbhfhae.Enabled = (this.offerItem_0.Enchantable || this.checkBox_0.Checked);
			foreach (KeyValuePair<int, Enchantment> keyValuePair in Constants.enchantments)
			{
				Enchantment value = keyValuePair.Value;
				if (this.checkBox_0.Checked || value.Items.Contains(this.offerItem_0.Id))
				{
					if (!this.DlxXbhfhae.Items.Contains(value))
					{
						this.DlxXbhfhae.Items.Add(value);
					}
				}
				else if (this.DlxXbhfhae.Items.Contains(value) && this.DlxXbhfhae.SelectedItem != value)
				{
					this.DlxXbhfhae.Items.Remove(value);
				}
			}
			if (this.DlxXbhfhae.SelectedItem == null)
			{
				return;
			}
			this.numericUpDown_1.Enabled = (this.checkBox_0.Checked || (enchantment != null && enchantment.Items.Contains(this.offerItem_0.Id) && this.numericUpDown_1.Value >= 0m && this.numericUpDown_1.Value <= enchantment.MaxLevel));
			bool flag = this.checkBox_0.Checked || enchantment == null || this.numericUpDown_1.Value < 0m || this.numericUpDown_1.Value > enchantment.MaxLevel;
			this.numericUpDown_1.Minimum = (flag ? -32768 : 0);
			this.numericUpDown_1.Maximum = (flag ? 32767 : enchantment.MaxLevel);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003719 File Offset: 0x00001919
		private void listView_0_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode & Keys.Delete) == Keys.Delete && this.offerItem_0 != null && this.DlxXbhfhae.SelectedItem != null)
			{
				this.method_2(0);
				this.method_1();
				return;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000374D File Offset: 0x0000194D
		private void listView_0_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = this.listView_0.Columns[e.ColumnIndex].Width;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000155E8 File Offset: 0x000137E8
		private void method_3()
		{
			new ComponentResourceManager(Type.GetTypeFromHandle(ldtoken().Handle));
			this.listView_0 = new ListView();
			this.columnHeader_1 = new ColumnHeader();
			this.columnHeader_0 = new ColumnHeader();
			this.DlxXbhfhae = new ComboBox();
			this.numericUpDown_1 = new NumericUpDown();
			this.numericUpDown_0 = new NumericUpDown();
			this.checkBox_0 = new CheckBox();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			base.SuspendLayout();
			this.listView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.listView_0.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_1,
				this.columnHeader_0
			});
			this.listView_0.FullRowSelect = true;
			this.listView_0.GridLines = true;
			this.listView_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.listView_0.HideSelection = false;
			this.listView_0.Location = new Point(6, 6);
			this.listView_0.MultiSelect = false;
			this.listView_0.Name = "boxEnchantments";
			this.listView_0.Size = new Size(302, 138);
			this.listView_0.TabIndex = 0;
			this.listView_0.UseCompatibleStateImageBehavior = false;
			this.listView_0.View = View.Details;
			this.listView_0.ColumnWidthChanging += this.listView_0_ColumnWidthChanging;
			this.listView_0.ItemSelectionChanged += this.listView_0_ItemSelectionChanged;
			this.listView_0.KeyDown += this.listView_0_KeyDown;
			this.columnHeader_1.Text = "Name";
			this.columnHeader_1.Width = 235;
			this.columnHeader_0.Text = "Level";
			this.columnHeader_0.TextAlign = HorizontalAlignment.Center;
			this.columnHeader_0.Width = 46;
			this.DlxXbhfhae.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.DlxXbhfhae.DropDownStyle = ComboBoxStyle.DropDownList;
			this.DlxXbhfhae.Enabled = false;
			this.DlxXbhfhae.FormattingEnabled = true;
			this.DlxXbhfhae.Location = new Point(72, 151);
			this.DlxXbhfhae.Name = "boxName";
			this.DlxXbhfhae.Size = new Size(170, 21);
			this.DlxXbhfhae.TabIndex = 2;
			this.DlxXbhfhae.SelectedIndexChanged += this.DlxXbhfhae_SelectedIndexChanged;
			this.numericUpDown_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.numericUpDown_1.Enabled = false;
			this.numericUpDown_1.Location = new Point(246, 151);
			this.numericUpDown_1.Name = "editLevel";
			this.numericUpDown_1.Size = new Size(62, 20);
			this.numericUpDown_1.TabIndex = 3;
			this.numericUpDown_1.TextAlign = HorizontalAlignment.Right;
			this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
			this.numericUpDown_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.numericUpDown_0.Enabled = false;
			this.numericUpDown_0.Location = new Point(6, 151);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 32767;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Minimum = new decimal(new int[]
			{
				32768,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown_0.Name = "editId";
			this.numericUpDown_0.Size = new Size(62, 20);
			this.numericUpDown_0.TabIndex = 1;
			this.numericUpDown_0.TextAlign = HorizontalAlignment.Right;
			this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
			this.checkBox_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.checkBox_0.Location = new Point(8, 176);
			this.checkBox_0.Name = "boxAllow";
			this.checkBox_0.Size = new Size(298, 18);
			this.checkBox_0.TabIndex = 4;
			this.checkBox_0.Text = "Allow potentially unsafe enchantments";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(314, 199);
			base.Controls.Add(this.checkBox_0);
			base.Controls.Add(this.numericUpDown_0);
			base.Controls.Add(this.numericUpDown_1);
			base.Controls.Add(this.DlxXbhfhae);
			base.Controls.Add(this.listView_0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EnchantForm";
			base.ShowInTaskbar = false;
			this.Text = "Enchantment Editor";
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000165 RID: 357
		private OfferItem offerItem_0;

		// Token: 0x04000166 RID: 358
		private Dictionary<short, Tuple<TagNodeCompound, ListViewItem>> dictionary_0 = new Dictionary<short, Tuple<TagNodeCompound, ListViewItem>>();

		// Token: 0x04000167 RID: 359
		private  enchantmentChanged;

		// Token: 0x04000168 RID: 360
		private Enchantment enchantment_0;

		// Token: 0x0400016A RID: 362
		private CheckBox checkBox_0;

		// Token: 0x0400016B RID: 363
		private NumericUpDown numericUpDown_0;

		// Token: 0x0400016C RID: 364
		private NumericUpDown numericUpDown_1;

		// Token: 0x0400016D RID: 365
		private ComboBox DlxXbhfhae;

		// Token: 0x0400016E RID: 366
		private ColumnHeader columnHeader_0;

		// Token: 0x0400016F RID: 367
		private ColumnHeader columnHeader_1;

		// Token: 0x04000170 RID: 368
		private ListView listView_0;
	}
}
