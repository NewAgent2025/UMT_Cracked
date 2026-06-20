using System;
using System.Collections.Generic;

// Token: 0x02000126 RID: 294
internal class Class42
{
	// Token: 0x06000C7A RID: 3194 RVA: 0x00008762 File Offset: 0x00006962
	internal static Dictionary<int, Class41> smethod_0()
	{
		Class42.smethod_6();
		return Class42.dictionary_0;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x0000876E File Offset: 0x0000696E
	internal static void smethod_1(Dictionary<int, Class41> dictionary_3)
	{
		Class42.dictionary_0 = dictionary_3;
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00008776 File Offset: 0x00006976
	internal static Dictionary<int, Class41> smethod_2()
	{
		Class42.smethod_6();
		return Class42.dictionary_1;
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00008782 File Offset: 0x00006982
	internal static void smethod_3(Dictionary<int, Class41> dictionary_3)
	{
		Class42.dictionary_1 = dictionary_3;
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x0000878A File Offset: 0x0000698A
	internal static Dictionary<string, Class41> smethod_4()
	{
		Class42.smethod_6();
		return Class42.dictionary_2;
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00008796 File Offset: 0x00006996
	internal static void smethod_5(Dictionary<string, Class41> dictionary_3)
	{
		Class42.dictionary_2 = dictionary_3;
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x000560CC File Offset: 0x000542CC
	private static void smethod_6()
	{
		if (Class42.dictionary_0 != null && Class42.dictionary_2 != null)
		{
			goto IL_C7;
		}
		IL_11:
		Class42.dictionary_0 = new Dictionary<int, Class41>();
		Class42.dictionary_1 = new Dictionary<int, Class41>();
		Class42.dictionary_2 = new Dictionary<string, Class41>();
		using (List<Class41>.Enumerator enumerator = Class42.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class41 @class = enumerator.Current;
				if (!Class42.dictionary_0.ContainsKey(@class.method_0()))
				{
					Class42.dictionary_0.Add(@class.method_0(), @class);
				}
				if (!Class42.dictionary_1.ContainsKey(@class.method_2()))
				{
					Class42.dictionary_1.Add(@class.method_2(), @class);
				}
				if (!Class42.dictionary_2.ContainsKey(@class.Name))
				{
					Class42.dictionary_2.Add(@class.Name, @class);
				}
			}
			return;
		}
		IL_C7:
		if (Class42.dictionary_1 == null)
		{
			goto IL_11;
		}
	}

	// Token: 0x040007DD RID: 2013
	private static Dictionary<int, Class41> dictionary_0 = null;

	// Token: 0x040007DE RID: 2014
	private static Dictionary<int, Class41> dictionary_1 = null;

	// Token: 0x040007DF RID: 2015
	private static Dictionary<string, Class41> dictionary_2 = null;

	// Token: 0x040007E0 RID: 2016
	public static List<Class41> list_0 = new List<Class41>
	{
		new Class41(56, 312, "minecraft:agent"),
		new Class41(95, 95, "minecraft:area_effect_cloud"),
		new Class41(61, 317, "minecraft:armor_stand"),
		new Class41(80, 12582992, "minecraft:arrow"),
		new Class41(107, 107, "minecraft:balloon"),
		new Class41(19, 33043, "minecraft:bat"),
		new Class41(43, 2859, "minecraft:blaze"),
		new Class41(90, 90, "minecraft:boat"),
		new Class41(75, 21323, "minecraft:cat"),
		new Class41(40, 265000, "minecraft:cave_spider"),
		new Class41(78, 78, "minecraft:chalkboard"),
		new Class41(98, 524386, "minecraft:chest_minecart"),
		new Class41(10, 4874, "minecraft:chicken"),
		new Class41(112, 9072, "minecraft:cod"),
		new Class41(100, 524388, "minecraft:command_block_minecart"),
		new Class41(11, 4875, "minecraft:cow"),
		new Class41(33, 2849, "minecraft:creeper"),
		new Class41(31, 8991, "minecraft:dolphin"),
		new Class41(24, 2118424, "minecraft:donkey"),
		new Class41(79, 4194383, "minecraft:dragon_fireball"),
		new Class41(110, 199534, "minecraft:drowned"),
		new Class41(82, 4194386, "minecraft:egg"),
		new Class41(50, 2866, "minecraft:elder_guardian"),
		new Class41(71, 71, "minecraft:ender_crystal"),
		new Class41(53, 2869, "minecraft:ender_dragon"),
		new Class41(87, 4194391, "minecraft:ender_pearl"),
		new Class41(38, 2854, "minecraft:enderman"),
		new Class41(55, 265015, "minecraft:endermite"),
		new Class41(103, 4194407, "minecraft:evocation_fang"),
		new Class41(104, 2920, "minecraft:evocation_illager"),
		new Class41(70, 70, "minecraft:eye_of_ender_signal"),
		new Class41(66, 66, "minecraft:falling_block"),
		new Class41(85, 4194389, "minecraft:fireball"),
		new Class41(72, 72, "minecraft:fireworks_rocket"),
		new Class41(77, 77, "minecraft:fishing_hook"),
		new Class41(41, 2857, "minecraft:ghast"),
		new Class41(49, 2865, "minecraft:guardian"),
		new Class41(96, 524384, "minecraft:hopper_minecart"),
		new Class41(23, 2118423, "minecraft:horse"),
		new Class41(47, 199471, "minecraft:husk"),
		new Class41(106, 4194410, "minecraft:ice_bomb"),
		new Class41(20, 788, "minecraft:iron_golem"),
		new Class41(64, 64, "minecraft:item"),
		new Class41(88, 88, "minecraft:leash_knot"),
		new Class41(93, 93, "minecraft:lightning_bolt"),
		new Class41(101, 4194405, "minecraft:lingering_potion"),
		new Class41(29, 4893, "minecraft:llama"),
		new Class41(102, 4194406, "minecraft:llama_spit"),
		new Class41(42, 2858, "minecraft:magma_cube"),
		new Class41(84, 524372, "minecraft:minecart"),
		new Class41(16, 4880, "minecraft:mooshroom"),
		new Class41(67, 67, "minecraft:moving_block"),
		new Class41(25, 2118425, "minecraft:mule"),
		new Class41(51, 307, "minecraft:npc"),
		new Class41(22, 21270, "minecraft:ocelot"),
		new Class41(83, 83, "minecraft:painting"),
		new Class41(113, 4977, "minecraft:panda"),
		new Class41(30, 21278, "minecraft:parrot"),
		new Class41(58, 68410, "minecraft:phantom"),
		new Class41(12, 4876, "minecraft:pig"),
		new Class41(114, 2930, "minecraft:pillager"),
		new Class41(63, 319, "minecraft:player"),
		new Class41(28, 4892, "minecraft:polar_bear"),
		new Class41(108, 9068, "minecraft:pufferfish"),
		new Class41(18, 4882, "minecraft:rabbit"),
		new Class41(109, 9069, "minecraft:salmon"),
		new Class41(13, 4877, "minecraft:sheep"),
		new Class41(54, 2870, "minecraft:shulker"),
		new Class41(76, 4194380, "minecraft:shulker_bullet"),
		new Class41(39, 264999, "minecraft:silverfish"),
		new Class41(34, 1116962, "minecraft:skeleton"),
		new Class41(26, 2186010, "minecraft:skeleton_horse"),
		new Class41(37, 2853, "minecraft:slime"),
		new Class41(94, 4194398, "minecraft:small_fireball"),
		new Class41(21, 789, "minecraft:snow_golem"),
		new Class41(81, 4194385, "minecraft:snowball"),
		new Class41(35, 264995, "minecraft:spider"),
		new Class41(86, 4194390, "minecraft:splash_potion"),
		new Class41(17, 8977, "minecraft:squid"),
		new Class41(46, 1116974, "minecraft:stray"),
		new Class41(73, 12582985, "minecraft:thrown_trident"),
		new Class41(65, 65, "minecraft:tnt"),
		new Class41(97, 524385, "minecraft:tnt_minecart"),
		new Class41(62, 318, "minecraft:tripod_camera"),
		new Class41(111, 9071, "minecraft:tropicalfish"),
		new Class41(74, 4938, "minecraft:turtle"),
		new Class41(105, 2921, "minecraft:vex"),
		new Class41(15, 783, "minecraft:villager"),
		new Class41(57, 2873, "minecraft:vindicator"),
		new Class41(45, 2861, "minecraft:witch"),
		new Class41(52, 68404, "minecraft:wither"),
		new Class41(48, 1116976, "minecraft:wither_skeleton"),
		new Class41(89, 4194393, "minecraft:wither_skull"),
		new Class41(91, 4194395, "minecraft:wither_skull_dangerous"),
		new Class41(14, 21262, "minecraft:wolf"),
		new Class41(68, 4194372, "minecraft:xp_bottle"),
		new Class41(69, 69, "minecraft:xp_orb"),
		new Class41(32, 199456, "minecraft:zombie"),
		new Class41(27, 2186011, "minecraft:zombie_horse"),
		new Class41(36, 68388, "minecraft:zombie_pigman"),
		new Class41(44, 199468, "minecraft:zombie_villager")
	};
}
