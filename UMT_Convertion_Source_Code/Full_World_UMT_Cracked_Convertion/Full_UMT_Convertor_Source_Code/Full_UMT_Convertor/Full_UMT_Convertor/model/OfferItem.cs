using System;
using System.Drawing;
using Substrate.Nbt;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000AF RID: 175
	public class OfferItem
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00005A36 File Offset: 0x00003C36
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00005A3E File Offset: 0x00003C3E
		public TagNodeCompound Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				this.tag = value;
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00005A47 File Offset: 0x00003C47
		public OfferItem()
		{
			this.method_0();
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00005A56 File Offset: 0x00003C56
		public OfferItem(TagNodeCompound tag)
		{
			this.tag = tag;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00040DB0 File Offset: 0x0003EFB0
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00005A65 File Offset: 0x00003C65
		public short Id
		{
			get
			{
				short result = 0;
				if (this.tag["id"] is TagNodeString)
				{
					string key = this.tag["id"] as TagNodeString;
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
					result = (this.tag["id"] as TagNodeShort);
				}
				return result;
			}
			set
			{
				this.tag["id"] = new TagNodeString(Class46.smethod_75(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00005A82 File Offset: 0x00003C82
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00005A9E File Offset: 0x00003C9E
		public byte Count
		{
			get
			{
				return this.method_0()["Count"] as TagNodeByte;
			}
			set
			{
				this.tag["Count"] = new TagNodeByte(value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00005AB6 File Offset: 0x00003CB6
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00005AD2 File Offset: 0x00003CD2
		public short Damage
		{
			get
			{
				return this.method_0()["Damage"] as TagNodeShort;
			}
			set
			{
				this.tag["Damage"] = new TagNodeShort(value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00005AEA File Offset: 0x00003CEA
		public Image Image
		{
			get
			{
				return Class5.smethod_9((int)this.Id, (int)this.Damage);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00005AFD File Offset: 0x00003CFD
		public bool Enchanted
		{
			get
			{
				return this.tag.ContainsKey("tag") && ((TagNodeCompound)this.tag["tag"]).ContainsKey("ench");
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00004C61 File Offset: 0x00002E61
		public bool Enchantable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00005B32 File Offset: 0x00003D32
		private TagNodeCompound method_0()
		{
			if (this.tag == null || this.tag == null)
			{
				this.tag = OfferItem.smethod_0(0, 0, 0);
			}
			return this.tag;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00040E50 File Offset: 0x0003F050
		internal static TagNodeCompound smethod_0(short short_0, byte byte_0, short short_1)
		{
			TagNodeCompound tagNodeCompound = new TagNodeCompound();
			tagNodeCompound["Count"] = new TagNodeByte(byte_0);
			tagNodeCompound["Damage"] = new TagNodeShort(short_1);
			tagNodeCompound["id"] = new TagNodeString(Class46.smethod_75(short_0));
			return tagNodeCompound;
		}

		// Token: 0x0400050F RID: 1295
		private TagNodeCompound tag;
	}
}
