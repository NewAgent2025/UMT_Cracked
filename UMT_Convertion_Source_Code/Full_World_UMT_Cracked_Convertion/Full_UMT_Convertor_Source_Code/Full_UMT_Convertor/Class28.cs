using System;
using Full_UMT_Convertor.model;
using Substrate.Nbt;

// Token: 0x020000B0 RID: 176
internal class Class28
{
	// Token: 0x06000735 RID: 1845 RVA: 0x00002591 File Offset: 0x00000791
	internal Class28()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00005B58 File Offset: 0x00003D58
	internal Class28(TagNodeCompound tagNodeCompound_1)
	{
		this.tagNodeCompound_0 = tagNodeCompound_1;
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00005B67 File Offset: 0x00003D67
	internal TagNodeCompound method_0()
	{
		return this.tagNodeCompound_0;
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00005B6F File Offset: 0x00003D6F
	internal void method_1(TagNodeCompound tagNodeCompound_1)
	{
		this.tagNodeCompound_0 = tagNodeCompound_1;
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00040E9C File Offset: 0x0003F09C
	internal bool method_2()
	{
		if (!this.tagNodeCompound_0.ContainsKey("rewardExp"))
		{
			this.tagNodeCompound_0["rewardExp"] = new TagNodeByte(1);
		}
		byte b = this.tagNodeCompound_0["rewardExp"] as TagNodeByte;
		return b == 1;
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00005B78 File Offset: 0x00003D78
	internal void method_3(bool bool_0)
	{
		this.tagNodeCompound_0["rewardExp"] = new TagNodeByte(bool_0 ? 1 : 0);
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00005B97 File Offset: 0x00003D97
	internal int method_4()
	{
		return this.tagNodeCompound_0["maxUses"] as TagNodeInt;
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00005BB3 File Offset: 0x00003DB3
	internal void method_5(int int_0)
	{
		this.tagNodeCompound_0["maxUses"] = new TagNodeInt(int_0);
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00005BCB File Offset: 0x00003DCB
	internal int method_6()
	{
		return this.tagNodeCompound_0["uses"] as TagNodeInt;
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00005BE7 File Offset: 0x00003DE7
	internal void method_7(int int_0)
	{
		this.tagNodeCompound_0["uses"] = new TagNodeInt(int_0);
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00040EF8 File Offset: 0x0003F0F8
	internal OfferItem method_8()
	{
		return new OfferItem(this.tagNodeCompound_0["buy"] as TagNodeCompound);
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00040F24 File Offset: 0x0003F124
	internal OfferItem method_9()
	{
		if (!this.tagNodeCompound_0.ContainsKey("buyB"))
		{
			this.tagNodeCompound_0["buyB"] = OfferItem.smethod_0(0, 0, 0);
		}
		return new OfferItem(this.tagNodeCompound_0["buyB"] as TagNodeCompound);
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00040F78 File Offset: 0x0003F178
	internal OfferItem method_10()
	{
		return new OfferItem(this.tagNodeCompound_0["sell"] as TagNodeCompound);
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00005BFF File Offset: 0x00003DFF
	private TagNodeCompound method_11()
	{
		if (this.tagNodeCompound_0 == null || this.tagNodeCompound_0 == null)
		{
			this.tagNodeCompound_0 = Class28.smethod_0(true, 10000, 0);
		}
		return this.tagNodeCompound_0;
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00040FA4 File Offset: 0x0003F1A4
	internal static TagNodeCompound smethod_0(bool bool_0, int int_0, int int_1)
	{
		TagNodeCompound tagNodeCompound = new TagNodeCompound();
		tagNodeCompound["rewardExp"] = new TagNodeByte(bool_0 ? 1 : 0);
		tagNodeCompound["maxUses"] = new TagNodeInt(int_0);
		tagNodeCompound["uses"] = new TagNodeInt(int_1);
		tagNodeCompound["buy"] = OfferItem.smethod_0(263, 1, 0);
		tagNodeCompound["buyB"] = OfferItem.smethod_0(0, 0, 0);
		tagNodeCompound["sell"] = OfferItem.smethod_0(388, 1, 0);
		return tagNodeCompound;
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00005C29 File Offset: 0x00003E29
	internal void method_12()
	{
		if (this.method_9().Id <= 0 || this.method_9().Count <= 0)
		{
			this.tagNodeCompound_0.Remove("buyB");
		}
	}

	// Token: 0x04000510 RID: 1296
	private TagNodeCompound tagNodeCompound_0;
}
