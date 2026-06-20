using System;
using System.Drawing;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000AB RID: 171
	public class InventoryItem
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00005753 File Offset: 0x00003953
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000575B File Offset: 0x0000395B
		public TagNodeCompound Tag
		{
			get
			{
				return this.method_0();
			}
			set
			{
				this.item = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00040CB4 File Offset: 0x0003EEB4
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00005764 File Offset: 0x00003964
		public short ID
		{
			get
			{
				short result = 0;
				if (this.item["id"] is TagNodeString)
				{
					string key = this.item["id"] as TagNodeString;
					if (Class34.smethod_2().ContainsKey(key))
					{
						result = (short)Class34.smethod_2()[key].Id;
					}
					else if (ConsoleItemLookups.ItemsByName.ContainsKey(key))
					{
						result = (short)ConsoleItemLookups.ItemsByName[key].Id;
					}
				}
				else
				{
					result = (this.item["id"] as TagNodeShort);
				}
				return result;
			}
			set
			{
				this.item["id"] = new TagNodeShort(value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0000577C File Offset: 0x0000397C
		public Image Image
		{
			get
			{
				return Class5.smethod_9((int)this.ID, (int)this.Damage);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0000578F File Offset: 0x0000398F
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x000057AB File Offset: 0x000039AB
		public byte Slot
		{
			get
			{
				return this.item["Slot"] as TagNodeByte;
			}
			set
			{
				this.item["Slot"] = new TagNodeByte(value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000057C3 File Offset: 0x000039C3
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000057DF File Offset: 0x000039DF
		public byte Count
		{
			get
			{
				return this.item["Count"] as TagNodeByte;
			}
			set
			{
				this.item["Count"] = new TagNodeByte(value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x000057F7 File Offset: 0x000039F7
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x00005813 File Offset: 0x00003A13
		public short Damage
		{
			get
			{
				return this.item["Damage"] as TagNodeShort;
			}
			set
			{
				this.item["Damage"] = new TagNodeShort(value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0000582B File Offset: 0x00003A2B
		public short MaxDamage
		{
			get
			{
				if (Constants.itemDamageValues.ContainsKey((int)this.ID))
				{
					return Constants.itemDamageValues[(int)this.ID];
				}
				return 0;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00005851 File Offset: 0x00003A51
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00005859 File Offset: 0x00003A59
		public bool Alternative
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00005862 File Offset: 0x00003A62
		public byte Stack
		{
			get
			{
				if (Constants.InventoryMaxCount.ContainsKey((int)this.ID))
				{
					return Constants.InventoryMaxCount[(int)this.ID];
				}
				return 64;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00005889 File Offset: 0x00003A89
		public bool Enchanted
		{
			get
			{
				return this.item.ContainsKey("tag") && ((TagNodeCompound)this.item["tag"]).ContainsKey("ench");
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00004C61 File Offset: 0x00002E61
		public bool Enchantable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00004C61 File Offset: 0x00002E61
		public bool Known
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000058BE File Offset: 0x00003ABE
		public InventoryItem()
		{
			this.item = this.method_1(0, 0, 0, 0);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000058D6 File Offset: 0x00003AD6
		public InventoryItem(short id, byte count = 1, byte slot = 0, short damage = 0)
		{
			this.item = this.method_1(id, count, slot, damage);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000058EF File Offset: 0x00003AEF
		public InventoryItem(TagNodeCompound item)
		{
			this.item = item;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000058FE File Offset: 0x00003AFE
		private TagNodeCompound method_0()
		{
			if (this.item == null || this.item == null)
			{
				this.item = this.method_1(0, 0, 0, 0);
			}
			return this.item;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00040D54 File Offset: 0x0003EF54
		private TagNodeCompound method_1(short short_0, byte byte_0, byte byte_1, short short_1)
		{
			TagNodeCompound tagNodeCompound = new TagNodeCompound();
			tagNodeCompound["Count"] = new TagNodeByte(byte_0);
			tagNodeCompound["Damage"] = new TagNodeShort(short_1);
			tagNodeCompound["id"] = new TagNodeShort(short_0);
			tagNodeCompound["Slot"] = new TagNodeByte(byte_1);
			return tagNodeCompound;
		}

		// Token: 0x040004FE RID: 1278
		private bool bool_0;

		// Token: 0x040004FF RID: 1279
		private TagNodeCompound item;
	}
}
