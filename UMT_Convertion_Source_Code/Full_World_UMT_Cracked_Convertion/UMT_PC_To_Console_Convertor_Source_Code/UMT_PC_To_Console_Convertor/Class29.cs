using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200009B RID: 155
internal class Class29
{
	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00005D68 File Offset: 0x00003F68
	internal static List<Class28> Blocks
	{
		get
		{
			return Class29.list_0;
		}
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00005D6F File Offset: 0x00003F6F
	internal static List<Class28> smethod_0()
	{
		return Class29.list_1;
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00005D76 File Offset: 0x00003F76
	public static Dictionary<int, Class28> smethod_1()
	{
		return Class29.dictionary_0;
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00005D7D File Offset: 0x00003F7D
	public static Dictionary<string, Class28> smethod_2()
	{
		return Class29.dictionary_1;
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0002AD58 File Offset: 0x00028F58
	internal static void smethod_3()
	{
		Class29.list_0 = Class29.list_1.ToList<Class28>();
		Class29.list_0.Remove(Class29.list_0[0]);
		Class29.list_0.Remove(Class29.list_0[Class29.list_0.Count - 1]);
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0002ADAC File Offset: 0x00028FAC
	internal static void smethod_4()
	{
		Class29.dictionary_0 = new Dictionary<int, Class28>();
		foreach (Class28 @class in Class29.list_1)
		{
			Class29.dictionary_0.Add(@class.Id, @class);
		}
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0002AE14 File Offset: 0x00029014
	internal static void smethod_5()
	{
		Class29.dictionary_1 = new Dictionary<string, Class28>();
		foreach (Class28 @class in Class29.list_1)
		{
			Class29.dictionary_1.Add(@class.method_0(), @class);
		}
	}

	// Token: 0x04000431 RID: 1073
	private static List<Class28> list_0 = null;

	// Token: 0x04000432 RID: 1074
	private static Dictionary<int, Class28> dictionary_0 = null;

	// Token: 0x04000433 RID: 1075
	private static Dictionary<string, Class28> dictionary_1 = null;

	// Token: 0x04000434 RID: 1076
	private static List<Class28> list_1 = new List<Class28>
	{
		new Class28(-1, "All Blocks", "All Blocks"),
		new Class28(0, "minecraft:air", "Air"),
		new Class28(1, "minecraft:stone", "Stone"),
		new Class28(2, "minecraft:grass", "Grass Block"),
		new Class28(3, "minecraft:dirt", "Dirt"),
		new Class28(4, "minecraft:cobblestone", "Cobblestone"),
		new Class28(5, "minecraft:planks", "Wood Planks"),
		new Class28(6, "minecraft:sapling", "Sapling"),
		new Class28(7, "minecraft:bedrock", "Bedrock"),
		new Class28(8, "minecraft:flowing_water", "Water"),
		new Class28(9, "minecraft:water", "Stationary Water"),
		new Class28(10, "minecraft:flowing_lava", "Lava"),
		new Class28(11, "minecraft:lava", "Stationary Lava"),
		new Class28(12, "minecraft:sand", "Sand"),
		new Class28(13, "minecraft:gravel", "Gravel"),
		new Class28(14, "minecraft:gold_ore", "Gold Ore"),
		new Class28(15, "minecraft:iron_ore", "Iron Ore"),
		new Class28(16, "minecraft:coal_ore", "Coal Ore"),
		new Class28(17, "minecraft:log", "Wood"),
		new Class28(18, "minecraft:leaves", "Leaves"),
		new Class28(19, "minecraft:sponge", "Sponge"),
		new Class28(20, "minecraft:glass", "Glass"),
		new Class28(21, "minecraft:lapis_ore", "Lapis Lazuli Ore"),
		new Class28(22, "minecraft:lapis_block", "Lapis Lazuli Block"),
		new Class28(23, "minecraft:dispenser", "Dispenser"),
		new Class28(24, "minecraft:sandstone", "Sandstone"),
		new Class28(25, "minecraft:noteblock", "Note Block"),
		new Class28(26, "minecraft:bed", "Bed"),
		new Class28(27, "minecraft:golden_rail", "Powered Rail"),
		new Class28(28, "minecraft:detector_rail", "Detector Rail"),
		new Class28(29, "minecraft:sticky_piston", "Sticky Piston"),
		new Class28(30, "minecraft:web", "Cobweb"),
		new Class28(31, "minecraft:tallgrass", "Grass"),
		new Class28(32, "minecraft:deadbush", "Dead Bush"),
		new Class28(33, "minecraft:piston", "Piston"),
		new Class28(34, "minecraft:piston_head", "Piston Head"),
		new Class28(35, "minecraft:wool", "Wool"),
		new Class28(36, "minecraft:piston_extension", "Block moved by Piston"),
		new Class28(37, "minecraft:yellow_flower", "Dandelion"),
		new Class28(38, "minecraft:red_flower", "Poppy"),
		new Class28(39, "minecraft:brown_mushroom", "Brown Mushroom"),
		new Class28(40, "minecraft:red_mushroom", "Red Mushroom"),
		new Class28(41, "minecraft:gold_block", "Block of Gold"),
		new Class28(42, "minecraft:iron_block", "Block of Iron"),
		new Class28(43, "minecraft:double_stone_slab", "Double Stone Slab"),
		new Class28(44, "minecraft:stone_slab", "Stone Slab"),
		new Class28(45, "minecraft:brick_block", "Bricks"),
		new Class28(46, "minecraft:tnt", "TNT"),
		new Class28(47, "minecraft:bookshelf", "Bookshelf"),
		new Class28(48, "minecraft:mossy_cobblestone", "Moss Stone"),
		new Class28(49, "minecraft:obsidian", "Obsidian"),
		new Class28(50, "minecraft:torch", "Torch"),
		new Class28(51, "minecraft:fire", "Fire", true, false, 388),
		new Class28(52, "minecraft:mob_spawner", "Monster Spawner"),
		new Class28(53, "minecraft:oak_stairs", "Oak Wood Stairs"),
		new Class28(54, "minecraft:chest", "Chest"),
		new Class28(55, "minecraft:redstone_wire", "Redstone Wire"),
		new Class28(56, "minecraft:diamond_ore", "Diamond Ore"),
		new Class28(57, "minecraft:diamond_block", "Block of Diamond"),
		new Class28(58, "minecraft:crafting_table", "Crafting Table"),
		new Class28(59, "minecraft:wheat", "Wheat"),
		new Class28(60, "minecraft:farmland", "Farmland"),
		new Class28(61, "minecraft:furnace", "Furnace"),
		new Class28(62, "minecraft:lit_furnace", "Burning Furnace"),
		new Class28(63, "minecraft:standing_sign", "Standing Sign"),
		new Class28(64, "minecraft:wooden_door", "Oak Door"),
		new Class28(65, "minecraft:ladder", "Ladder"),
		new Class28(66, "minecraft:rail", "Rail"),
		new Class28(67, "minecraft:stone_stairs", "Cobblestone Stairs"),
		new Class28(68, "minecraft:wall_sign", "Wall Sign"),
		new Class28(69, "minecraft:lever", "Lever"),
		new Class28(70, "minecraft:stone_pressure_plate", "Stone Pressure Plate"),
		new Class28(71, "minecraft:iron_door", "Iron Door"),
		new Class28(72, "minecraft:wooden_pressure_plate", "Wooden Pressure Plate"),
		new Class28(73, "minecraft:redstone_ore", "Redstone Ore"),
		new Class28(74, "minecraft:lit_redstone_ore", "Redstone Ore"),
		new Class28(75, "minecraft:unlit_redstone_torch", "Redstone Torch"),
		new Class28(76, "minecraft:redstone_torch", "Redstone Torch"),
		new Class28(77, "minecraft:stone_button", "Stone Button"),
		new Class28(78, "minecraft:snow_layer", "Snow"),
		new Class28(79, "minecraft:ice", "Ice"),
		new Class28(80, "minecraft:snow", "Snow"),
		new Class28(81, "minecraft:cactus", "Cactus"),
		new Class28(82, "minecraft:clay", "Clay"),
		new Class28(83, "minecraft:reeds", "Sugar Cane"),
		new Class28(84, "minecraft:jukebox", "Jukebox"),
		new Class28(85, "minecraft:fence", "Fence"),
		new Class28(86, "minecraft:pumpkin", "Pumpkin"),
		new Class28(87, "minecraft:netherrack", "Netherrack"),
		new Class28(88, "minecraft:soul_sand", "Soul Sand"),
		new Class28(89, "minecraft:glowstone", "Glowstone"),
		new Class28(90, "minecraft:portal", "Portal", true, false, 388),
		new Class28(91, "minecraft:lit_pumpkin", "Jack o'Lantern"),
		new Class28(92, "minecraft:cake", "Cake"),
		new Class28(93, "minecraft:unpowered_repeater", "Redstone Repeater"),
		new Class28(94, "minecraft:powered_repeater", "Redstone Repeater"),
		new Class28(95, "minecraft:stained_glass", "Stained Glass"),
		new Class28(96, "minecraft:trapdoor", "Trapdoor"),
		new Class28(97, "minecraft:monster_egg", "Monster Egg"),
		new Class28(98, "minecraft:stonebrick", "Stone Bricks"),
		new Class28(99, "minecraft:brown_mushroom_block", "Brown Mushroom"),
		new Class28(100, "minecraft:red_mushroom_block", "Red Mushroom"),
		new Class28(101, "minecraft:iron_bars", "Iron Bars"),
		new Class28(102, "minecraft:glass_pane", "Glass Pane"),
		new Class28(103, "minecraft:melon_block", "Melon"),
		new Class28(104, "minecraft:pumpkin_stem", "Pumpkin Stem"),
		new Class28(105, "minecraft:melon_stem", "Melon Stem"),
		new Class28(106, "minecraft:vine", "Vines"),
		new Class28(107, "minecraft:fence_gate", "Fence Gate"),
		new Class28(108, "minecraft:brick_stairs", "Brick Stairs"),
		new Class28(109, "minecraft:stone_brick_stairs", "Stone Brick Stairs"),
		new Class28(110, "minecraft:mycelium", "Mycelium"),
		new Class28(111, "minecraft:waterlily", "Lily Pad"),
		new Class28(112, "minecraft:nether_brick", "Nether Brick"),
		new Class28(113, "minecraft:nether_brick_fence", "Nether Brick Fence"),
		new Class28(114, "minecraft:nether_brick_stairs", "Nether Brick Stairs"),
		new Class28(115, "minecraft:nether_wart", "Nether Wart"),
		new Class28(116, "minecraft:enchanting_table", "Enchantment Table"),
		new Class28(117, "minecraft:brewing_stand", "Brewing Stand"),
		new Class28(118, "minecraft:cauldron", "Cauldron"),
		new Class28(119, "minecraft:end_portal", "End Portal", true, false, 388),
		new Class28(120, "minecraft:end_portal_frame", "End Portal Block"),
		new Class28(121, "minecraft:end_stone", "End Stone"),
		new Class28(122, "minecraft:dragon_egg", "Dragon Egg"),
		new Class28(123, "minecraft:redstone_lamp", "Redstone Lamp"),
		new Class28(124, "minecraft:lit_redstone_lamp", "Redstone Lamp"),
		new Class28(125, "minecraft:double_wooden_slab", "Double Wooden Slab"),
		new Class28(126, "minecraft:wooden_slab", "Wooden Slab"),
		new Class28(127, "minecraft:cocoa", "Cocoa"),
		new Class28(128, "minecraft:sandstone_stairs", "Sandstone Stairs"),
		new Class28(129, "minecraft:emerald_ore", "Emerald Ore"),
		new Class28(130, "minecraft:ender_chest", "Ender Chest"),
		new Class28(131, "minecraft:tripwire_hook", "Tripwire Hook"),
		new Class28(132, "minecraft:tripwire", "Tripwire"),
		new Class28(133, "minecraft:emerald_block", "Block of Emerald"),
		new Class28(134, "minecraft:spruce_stairs", "Spruce Wood Stairs"),
		new Class28(135, "minecraft:birch_stairs", "Birch Wood Stairs"),
		new Class28(136, "minecraft:jungle_stairs", "Jungle Wood Stairs"),
		new Class28(137, "minecraft:command_block", "Command Block"),
		new Class28(138, "minecraft:beacon", "Beacon"),
		new Class28(139, "minecraft:cobblestone_wall", "Cobblestone Wall"),
		new Class28(140, "minecraft:flower_pot", "Flower Pot"),
		new Class28(141, "minecraft:carrots", "Carrot"),
		new Class28(142, "minecraft:potatoes", "Potato"),
		new Class28(143, "minecraft:wooden_button", "Wooden Button"),
		new Class28(144, "minecraft:skull", "Mob head"),
		new Class28(145, "minecraft:anvil", "Anvil"),
		new Class28(146, "minecraft:trapped_chest", "Trapped Chest"),
		new Class28(147, "minecraft:light_weighted_pressure_plate", "Weighted Pressure Plate"),
		new Class28(148, "minecraft:heavy_weighted_pressure_plate", "Weighted Pressure Plate"),
		new Class28(149, "minecraft:unpowered_comparator", "Redstone Comparator"),
		new Class28(150, "minecraft:powered_comparator", "Redstone Comparator"),
		new Class28(151, "minecraft:daylight_detector", "Daylight Sensor"),
		new Class28(152, "minecraft:redstone_block", "Block of Redstone"),
		new Class28(153, "minecraft:quartz_ore", "Nether Quartz Ore"),
		new Class28(154, "minecraft:hopper", "Hopper"),
		new Class28(155, "minecraft:quartz_block", "Block of Quartz"),
		new Class28(156, "minecraft:quartz_stairs", "Quartz Stairs"),
		new Class28(157, "minecraft:activator_rail", "Activator Rail"),
		new Class28(158, "minecraft:dropper", "Dropper"),
		new Class28(159, "minecraft:stained_hardened_clay", "Stained Clay"),
		new Class28(160, "minecraft:stained_glass_pane", "Stained Glass Pane"),
		new Class28(161, "minecraft:leaves2", "Leaves", true, 162),
		new Class28(162, "minecraft:log2", "Wood", true, 161),
		new Class28(163, "minecraft:acacia_stairs", "Acacia Wood Stairs"),
		new Class28(164, "minecraft:dark_oak_stairs", "Dark Oak Wood Stairs"),
		new Class28(165, "minecraft:slime", "Slime Block"),
		new Class28(166, "minecraft:barrier", "Barrier"),
		new Class28(167, "minecraft:iron_trapdoor", "Iron Trapdoor"),
		new Class28(168, "minecraft:prismarine", "Prismarine"),
		new Class28(169, "minecraft:sea_lantern", "Sea Lantern"),
		new Class28(170, "minecraft:hay_block", "Hay Bale"),
		new Class28(171, "minecraft:carpet", "Carpet"),
		new Class28(172, "minecraft:hardened_clay", "Hardened Clay"),
		new Class28(173, "minecraft:coal_block", "Block of Coal"),
		new Class28(174, "minecraft:packed_ice", "Packed Ice"),
		new Class28(175, "minecraft:double_plant", "Large Flowers"),
		new Class28(176, "minecraft:standing_banner", "Banner"),
		new Class28(177, "minecraft:wall_banner", "Banner"),
		new Class28(178, "minecraft:daylight_detector_inverted", "Inverted Daylight Sensor"),
		new Class28(179, "minecraft:red_sandstone", "Red Sandstone"),
		new Class28(180, "minecraft:red_sandstone_stairs", "Red Sandstone Stairs"),
		new Class28(181, "minecraft:double_stone_slab2", "Double Red Sandstone Slab"),
		new Class28(182, "minecraft:stone_slab2", "Red Sandstone Slab"),
		new Class28(183, "minecraft:spruce_fence_gate", "Spruce Fence Gate"),
		new Class28(184, "minecraft:birch_fence_gate", "Birch Fence Gate"),
		new Class28(185, "minecraft:jungle_fence_gate", "Jungle Fence Gate"),
		new Class28(186, "minecraft:dark_oak_fence_gate", "Dark Oak Fence Gate"),
		new Class28(187, "minecraft:acacia_fence_gate", "Acacia Fence Gate"),
		new Class28(188, "minecraft:spruce_fence", "Spruce Fence"),
		new Class28(189, "minecraft:birch_fence", "Birch Fence"),
		new Class28(190, "minecraft:jungle_fence", "Jungle Fence"),
		new Class28(191, "minecraft:dark_oak_fence", "Dark Oak Fence"),
		new Class28(192, "minecraft:acacia_fence", "Acacia Fence"),
		new Class28(193, "minecraft:spruce_door", "Spruce Door"),
		new Class28(194, "minecraft:birch_door", "Birch Door"),
		new Class28(195, "minecraft:jungle_door", "Jungle Door"),
		new Class28(196, "minecraft:acacia_door", "Acacia Door"),
		new Class28(197, "minecraft:dark_oak_door", "Dark Oak Door"),
		new Class28(198, "minecraft:end_rod", "End Rod"),
		new Class28(199, "minecraft:chorus_plant", "Chorus Plant"),
		new Class28(200, "minecraft:chorus_flower", "Chorus Flower"),
		new Class28(201, "minecraft:purpur_block", "Purpur Block"),
		new Class28(202, "minecraft:purpur_pillar", "Purpur Pillar"),
		new Class28(203, "minecraft:purpur_stairs", "Purpur Stairs"),
		new Class28(204, "minecraft:purpur_double_slab", "Purpur Double Slab"),
		new Class28(205, "minecraft:purpur_slab", "Purpur Slab"),
		new Class28(206, "minecraft:end_bricks", "End Stone Bricks"),
		new Class28(207, "minecraft:beetroots", "Beetroot Seeds"),
		new Class28(208, "minecraft:grass_path", "Grass Path"),
		new Class28(209, "minecraft:end_gateway", "End Gateway"),
		new Class28(210, "minecraft:repeating_command_block", "Repeating Command Block", false, 0),
		new Class28(211, "minecraft:chain_command_block", "Chain Command Block", false, 0),
		new Class28(212, "minecraft:frosted_ice", "Frosted Ice"),
		new Class28(213, "minecraft:magma", "Magma Block"),
		new Class28(214, "minecraft:nether_wart_block", "Nether Wart Block"),
		new Class28(215, "minecraft:red_nether_brick", "Red Nether Brick"),
		new Class28(216, "minecraft:bone_block", "Bone Block"),
		new Class28(217, "minecraft:structure_void", "Structure Void", false, 0),
		new Class28(10000, "InvalidBlock", "Invalid Block")
	};
}
