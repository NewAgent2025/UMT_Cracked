using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F5 RID: 245
	public class PCItemLookups
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0000765E File Offset: 0x0000585E
		public static Dictionary<string, Item> ItemsByName
		{
			get
			{
				return PCItemLookups.dictionary_1;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00007665 File Offset: 0x00005865
		public static Dictionary<int, Item> ItemsById
		{
			get
			{
				return PCItemLookups.dictionary_0;
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000501E8 File Offset: 0x0004E3E8
		public static void LoadItemsById()
		{
			try
			{
				PCItemLookups.dictionary_0 = new Dictionary<int, Item>();
				foreach (Item item in PCItemLookups.dictionary_1.Values)
				{
					PCItemLookups.dictionary_0.Add(item.Id, item);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000703 RID: 1795
		private static Dictionary<int, Item> dictionary_0 = null;

		// Token: 0x04000704 RID: 1796
		private static Dictionary<string, Item> dictionary_1 = new Dictionary<string, Item>
		{
			{
				"minecraft:iron_shovel",
				new Item(256, "minecraft:iron_shovel", "Iron Shovel", true, 256)
			},
			{
				"minecraft:iron_pickaxe",
				new Item(257, "minecraft:iron_pickaxe", "Iron Pickaxe", true, 257)
			},
			{
				"minecraft:iron_axe",
				new Item(258, "minecraft:iron_axe", "Iron Axe", true, 258)
			},
			{
				"minecraft:flint_and_steel",
				new Item(259, "minecraft:flint_and_steel", "Flint and Steel", true, 259)
			},
			{
				"minecraft:apple",
				new Item(260, "minecraft:apple", "Apple", true, 260)
			},
			{
				"minecraft:bow",
				new Item(261, "minecraft:bow", "Bow", true, 261)
			},
			{
				"minecraft:arrow",
				new Item(262, "minecraft:arrow", "Arrow", true, 262)
			},
			{
				"minecraft:coal",
				new Item(263, "minecraft:coal", "Coal", true, 263)
			},
			{
				"minecraft:diamond",
				new Item(264, "minecraft:diamond", "Diamond", true, 264)
			},
			{
				"minecraft:iron_ingot",
				new Item(265, "minecraft:iron_ingot", "Iron Ingot", true, 265)
			},
			{
				"minecraft:gold_ingot",
				new Item(266, "minecraft:gold_ingot", "Gold Ingot", true, 266)
			},
			{
				"minecraft:iron_sword",
				new Item(267, "minecraft:iron_sword", "Iron Sword", true, 267)
			},
			{
				"minecraft:wooden_sword",
				new Item(268, "minecraft:wooden_sword", "Wooden Sword", true, 268)
			},
			{
				"minecraft:wooden_shovel",
				new Item(269, "minecraft:wooden_shovel", "Wooden Shovel", true, 269)
			},
			{
				"minecraft:wooden_pickaxe",
				new Item(270, "minecraft:wooden_pickaxe", "Wooden Pickaxe", true, 270)
			},
			{
				"minecraft:wooden_axe",
				new Item(271, "minecraft:wooden_axe", "Wooden Axe", true, 271)
			},
			{
				"minecraft:stone_sword",
				new Item(272, "minecraft:stone_sword", "Stone Sword", true, 272)
			},
			{
				"minecraft:stone_shovel",
				new Item(273, "minecraft:stone_shovel", "Stone Shovel", true, 273)
			},
			{
				"minecraft:stone_pickaxe",
				new Item(274, "minecraft:stone_pickaxe", "Stone Pickaxe", true, 274)
			},
			{
				"minecraft:stone_axe",
				new Item(275, "minecraft:stone_axe", "Stone Axe", true, 275)
			},
			{
				"minecraft:diamond_sword",
				new Item(276, "minecraft:diamond_sword", "Diamond Sword", true, 276)
			},
			{
				"minecraft:diamond_shovel",
				new Item(277, "minecraft:diamond_shovel", "Diamond Shovel", true, 277)
			},
			{
				"minecraft:diamond_pickaxe",
				new Item(278, "minecraft:diamond_pickaxe", "Diamond Pickaxe", true, 278)
			},
			{
				"minecraft:diamond_axe",
				new Item(279, "minecraft:diamond_axe", "Diamond Axe", true, 279)
			},
			{
				"minecraft:stick",
				new Item(280, "minecraft:stick", "Stick", true, 280)
			},
			{
				"minecraft:bowl",
				new Item(281, "minecraft:bowl", "Bowl", true, 281)
			},
			{
				"minecraft:mushroom_stew",
				new Item(282, "minecraft:mushroom_stew", "Mushroom Stew", true, 282)
			},
			{
				"minecraft:golden_sword",
				new Item(283, "minecraft:golden_sword", "Golden Sword", true, 283)
			},
			{
				"minecraft:golden_shovel",
				new Item(284, "minecraft:golden_shovel", "Golden Shovel", true, 284)
			},
			{
				"minecraft:golden_pickaxe",
				new Item(285, "minecraft:golden_pickaxe", "Golden Pickaxe", true, 285)
			},
			{
				"minecraft:golden_axe",
				new Item(286, "minecraft:golden_axe", "Golden Axe", true, 286)
			},
			{
				"minecraft:string",
				new Item(287, "minecraft:string", "String", true, 287)
			},
			{
				"minecraft:feather",
				new Item(288, "minecraft:feather", "Feather", true, 288)
			},
			{
				"minecraft:gunpowder",
				new Item(289, "minecraft:gunpowder", "Gunpowder", true, 289)
			},
			{
				"minecraft:wooden_hoe",
				new Item(290, "minecraft:wooden_hoe", "Wooden Hoe", true, 290)
			},
			{
				"minecraft:stone_hoe",
				new Item(291, "minecraft:stone_hoe", "Stone Hoe", true, 291)
			},
			{
				"minecraft:iron_hoe",
				new Item(292, "minecraft:iron_hoe", "Iron Hoe", true, 292)
			},
			{
				"minecraft:diamond_hoe",
				new Item(293, "minecraft:diamond_hoe", "Diamond Hoe", true, 293)
			},
			{
				"minecraft:golden_hoe",
				new Item(294, "minecraft:golden_hoe", "Golden Hoe", true, 294)
			},
			{
				"minecraft:wheat_seeds",
				new Item(295, "minecraft:wheat_seeds", "Seeds", true, 295)
			},
			{
				"minecraft:wheat",
				new Item(296, "minecraft:wheat", "Wheat", true, 296)
			},
			{
				"minecraft:bread",
				new Item(297, "minecraft:bread", "Bread", true, 297)
			},
			{
				"minecraft:leather_helmet",
				new Item(298, "minecraft:leather_helmet", "Leather Cap", true, 298)
			},
			{
				"minecraft:leather_chestplate",
				new Item(299, "minecraft:leather_chestplate", "Leather Tunic", true, 299)
			},
			{
				"minecraft:leather_leggings",
				new Item(300, "minecraft:leather_leggings", "Leather Pants", true, 300)
			},
			{
				"minecraft:leather_boots",
				new Item(301, "minecraft:leather_boots", "Leather Boots", true, 301)
			},
			{
				"minecraft:chainmail_helmet",
				new Item(302, "minecraft:chainmail_helmet", "Chain Helmet", true, 302)
			},
			{
				"minecraft:chainmail_chestplate",
				new Item(303, "minecraft:chainmail_chestplate", "Chain Chestplate", true, 303)
			},
			{
				"minecraft:chainmail_leggings",
				new Item(304, "minecraft:chainmail_leggings", "Chain Leggings", true, 304)
			},
			{
				"minecraft:chainmail_boots",
				new Item(305, "minecraft:chainmail_boots", "Chain Boots", true, 305)
			},
			{
				"minecraft:iron_helmet",
				new Item(306, "minecraft:iron_helmet", "Iron Helmet", true, 306)
			},
			{
				"minecraft:iron_chestplate",
				new Item(307, "minecraft:iron_chestplate", "Iron Chestplate", true, 307)
			},
			{
				"minecraft:iron_leggings",
				new Item(308, "minecraft:iron_leggings", "Iron Leggings", true, 308)
			},
			{
				"minecraft:iron_boots",
				new Item(309, "minecraft:iron_boots", "Iron Boots", true, 309)
			},
			{
				"minecraft:diamond_helmet",
				new Item(310, "minecraft:diamond_helmet", "Diamond Helmet", true, 310)
			},
			{
				"minecraft:diamond_chestplate",
				new Item(311, "minecraft:diamond_chestplate", "Diamond Chestplate", true, 311)
			},
			{
				"minecraft:diamond_leggings",
				new Item(312, "minecraft:diamond_leggings", "Diamond Leggings", true, 312)
			},
			{
				"minecraft:diamond_boots",
				new Item(313, "minecraft:diamond_boots", "Diamond Boots", true, 313)
			},
			{
				"minecraft:golden_helmet",
				new Item(314, "minecraft:golden_helmet", "Golden Helmet", true, 314)
			},
			{
				"minecraft:golden_chestplate",
				new Item(315, "minecraft:golden_chestplate", "Golden Chestplate", true, 315)
			},
			{
				"minecraft:golden_leggings",
				new Item(316, "minecraft:golden_leggings", "Golden Leggings", true, 316)
			},
			{
				"minecraft:golden_boots",
				new Item(317, "minecraft:golden_boots", "Golden Boots", true, 317)
			},
			{
				"minecraft:flint",
				new Item(318, "minecraft:flint", "Flint", true, 318)
			},
			{
				"minecraft:porkchop",
				new Item(319, "minecraft:porkchop", "Raw Porkchop", true, 319)
			},
			{
				"minecraft:cooked_porkchop",
				new Item(320, "minecraft:cooked_porkchop", "Cooked Porkchop", true, 320)
			},
			{
				"minecraft:painting",
				new Item(321, "minecraft:painting", "Painting", true, 321)
			},
			{
				"minecraft:golden_apple",
				new Item(322, "minecraft:golden_apple", "Golden Apple", true, 322)
			},
			{
				"minecraft:sign",
				new Item(323, "minecraft:sign", "Sign", true, 323)
			},
			{
				"minecraft:wooden_door",
				new Item(324, "minecraft:wooden_door", "Oak Door", true, 324)
			},
			{
				"minecraft:bucket",
				new Item(325, "minecraft:bucket", "Bucket", true, 325)
			},
			{
				"minecraft:water_bucket",
				new Item(326, "minecraft:water_bucket", "Water Bucket", true, 325)
			},
			{
				"minecraft:lava_bucket",
				new Item(327, "minecraft:lava_bucket", "Lava Bucket", true, 325)
			},
			{
				"minecraft:minecart",
				new Item(328, "minecraft:minecart", "Minecart", true, 328)
			},
			{
				"minecraft:saddle",
				new Item(329, "minecraft:saddle", "Saddle", true, 329)
			},
			{
				"minecraft:iron_door",
				new Item(330, "minecraft:iron_door", "Iron Door", true, 330)
			},
			{
				"minecraft:redstone",
				new Item(331, "minecraft:redstone", "Redstone", true, 331)
			},
			{
				"minecraft:snowball",
				new Item(332, "minecraft:snowball", "Snowball", true, 332)
			},
			{
				"minecraft:boat",
				new Item(333, "minecraft:boat", "Boat", true, 333)
			},
			{
				"minecraft:leather",
				new Item(334, "minecraft:leather", "Leather", true, 334)
			},
			{
				"minecraft:milk_bucket",
				new Item(335, "minecraft:milk_bucket", "Milk", true, 325)
			},
			{
				"minecraft:brick",
				new Item(336, "minecraft:brick", "Brick", true, 336)
			},
			{
				"minecraft:clay_ball",
				new Item(337, "minecraft:clay_ball", "Clay", true, 337)
			},
			{
				"minecraft:reeds",
				new Item(338, "minecraft:reeds", "Sugar Cane", true, 338)
			},
			{
				"minecraft:paper",
				new Item(339, "minecraft:paper", "Paper", true, 339)
			},
			{
				"minecraft:book",
				new Item(340, "minecraft:book", "Book", true, 340)
			},
			{
				"minecraft:slime_ball",
				new Item(341, "minecraft:slime_ball", "Slimeball", true, 341)
			},
			{
				"minecraft:chest_minecart",
				new Item(342, "minecraft:chest_minecart", "Minecart with Chest", true, 342)
			},
			{
				"minecraft:furnace_minecart",
				new Item(343, "minecraft:furnace_minecart", "Minecart with Furnace", true, 328)
			},
			{
				"minecraft:egg",
				new Item(344, "minecraft:egg", "Egg", true, 344)
			},
			{
				"minecraft:compass",
				new Item(345, "minecraft:compass", "Compass", true, 345)
			},
			{
				"minecraft:fishing_rod",
				new Item(346, "minecraft:fishing_rod", "Fishing Rod", true, 346)
			},
			{
				"minecraft:clock",
				new Item(347, "minecraft:clock", "Clock", true, 347)
			},
			{
				"minecraft:glowstone_dust",
				new Item(348, "minecraft:glowstone_dust", "Glowstone Dust", true, 348)
			},
			{
				"minecraft:fish",
				new Item(349, "minecraft:fish", "Raw Fish", true, 349)
			},
			{
				"minecraft:cooked_fish",
				new Item(350, "minecraft:cooked_fish", "Cooked Fish", true, 350)
			},
			{
				"minecraft:dye",
				new Item(351, "minecraft:dye", "Dye", true, 351)
			},
			{
				"minecraft:bone",
				new Item(352, "minecraft:bone", "Bone", true, 352)
			},
			{
				"minecraft:sugar",
				new Item(353, "minecraft:sugar", "Sugar", true, 353)
			},
			{
				"minecraft:cake",
				new Item(354, "minecraft:cake", "Cake", true, 354)
			},
			{
				"minecraft:bed",
				new Item(355, "minecraft:bed", "Bed", true, 355)
			},
			{
				"minecraft:repeater",
				new Item(356, "minecraft:repeater", "Redstone Repeater", true, 356)
			},
			{
				"minecraft:cookie",
				new Item(357, "minecraft:cookie", "Cookie", true, 357)
			},
			{
				"minecraft:filled_map",
				new Item(358, "minecraft:filled_map", "Map", true, 358)
			},
			{
				"minecraft:shears",
				new Item(359, "minecraft:shears", "Shears", true, 359)
			},
			{
				"minecraft:melon",
				new Item(360, "minecraft:melon", "Melon", true, 360)
			},
			{
				"minecraft:pumpkin_seeds",
				new Item(361, "minecraft:pumpkin_seeds", "Pumpkin Seeds", true, 361)
			},
			{
				"minecraft:melon_seeds",
				new Item(362, "minecraft:melon_seeds", "Melon Seeds", true, 362)
			},
			{
				"minecraft:beef",
				new Item(363, "minecraft:beef", "Raw Beef", true, 363)
			},
			{
				"minecraft:cooked_beef",
				new Item(364, "minecraft:cooked_beef", "Steak", true, 364)
			},
			{
				"minecraft:chicken",
				new Item(365, "minecraft:chicken", "Raw Chicken", true, 365)
			},
			{
				"minecraft:cooked_chicken",
				new Item(366, "minecraft:cooked_chicken", "Cooked Chicken", true, 366)
			},
			{
				"minecraft:rotten_flesh",
				new Item(367, "minecraft:rotten_flesh", "Rotten Flesh", true, 367)
			},
			{
				"minecraft:ender_pearl",
				new Item(368, "minecraft:ender_pearl", "Ender Pearl", true, 368)
			},
			{
				"minecraft:blaze_rod",
				new Item(369, "minecraft:blaze_rod", "Blaze Rod", true, 369)
			},
			{
				"minecraft:ghast_tear",
				new Item(370, "minecraft:ghast_tear", "Ghast Tear", true, 370)
			},
			{
				"minecraft:gold_nugget",
				new Item(371, "minecraft:gold_nugget", "Gold Nugget", true, 371)
			},
			{
				"minecraft:nether_wart",
				new Item(372, "minecraft:nether_wart", "Nether Wart", true, 372)
			},
			{
				"minecraft:potion",
				new Item(373, "minecraft:potion", "Potion", true, 373)
			},
			{
				"minecraft:glass_bottle",
				new Item(374, "minecraft:glass_bottle", "Glass Bottle", true, 374)
			},
			{
				"minecraft:spider_eye",
				new Item(375, "minecraft:spider_eye", "Spider Eye", true, 375)
			},
			{
				"minecraft:fermented_spider_eye",
				new Item(376, "minecraft:fermented_spider_eye", "Fermented Spider Eye", true, 376)
			},
			{
				"minecraft:blaze_powder",
				new Item(377, "minecraft:blaze_powder", "Blaze Powder", true, 377)
			},
			{
				"minecraft:magma_cream",
				new Item(378, "minecraft:magma_cream", "Magma Cream", true, 378)
			},
			{
				"minecraft:brewing_stand",
				new Item(379, "minecraft:brewing_stand", "Brewing Stand", true, 379)
			},
			{
				"minecraft:cauldron",
				new Item(380, "minecraft:cauldron", "Cauldron", true, 380)
			},
			{
				"minecraft:ender_eye",
				new Item(381, "minecraft:ender_eye", "Eye of Ender", true, 381)
			},
			{
				"minecraft:speckled_melon",
				new Item(382, "minecraft:speckled_melon", "Glistering Melon", true, 382)
			},
			{
				"minecraft:spawn_egg",
				new Item(383, "minecraft:spawn_egg", "Spawn Egg", true, 383)
			},
			{
				"minecraft:experience_bottle",
				new Item(384, "minecraft:experience_bottle", "Bottle o' Enchanting", true, 384)
			},
			{
				"minecraft:fire_charge",
				new Item(385, "minecraft:fire_charge", "Fire Charge", true, 385)
			},
			{
				"minecraft:writable_book",
				new Item(386, "minecraft:writable_book", "Book and Quill", true, 386)
			},
			{
				"minecraft:written_book",
				new Item(387, "minecraft:written_book", "Written Book", true, 387)
			},
			{
				"minecraft:emerald",
				new Item(388, "minecraft:emerald", "Emerald", true, 388)
			},
			{
				"minecraft:item_frame",
				new Item(389, "minecraft:item_frame", "Item Frame", true, 199)
			},
			{
				"minecraft:flower_pot",
				new Item(390, "minecraft:flower_pot", "Flower Pot", true, 390)
			},
			{
				"minecraft:carrot",
				new Item(391, "minecraft:carrot", "Carrot", true, 391)
			},
			{
				"minecraft:potato",
				new Item(392, "minecraft:potato", "Potato", true, 392)
			},
			{
				"minecraft:baked_potato",
				new Item(393, "minecraft:baked_potato", "Baked Potato", true, 393)
			},
			{
				"minecraft:poisonous_potato",
				new Item(394, "minecraft:poisonous_potato", "Poisonous Potato", true, 394)
			},
			{
				"minecraft:map",
				new Item(395, "minecraft:map", "Empty Map", true, 395)
			},
			{
				"minecraft:golden_carrot",
				new Item(396, "minecraft:golden_carrot", "Golden Carrot", true, 396)
			},
			{
				"minecraft:skull",
				new Item(397, "minecraft:skull", "Mob head", true, 397)
			},
			{
				"minecraft:carrot_on_a_stick",
				new Item(398, "minecraft:carrot_on_a_stick", "Carrot on a Stick", true, 398)
			},
			{
				"minecraft:nether_star",
				new Item(399, "minecraft:nether_star", "Nether Star", true, 399)
			},
			{
				"minecraft:pumpkin_pie",
				new Item(400, "minecraft:pumpkin_pie", "Pumpkin Pie", true, 400)
			},
			{
				"minecraft:fireworks",
				new Item(401, "minecraft:fireworks", "Firework Rocket", true, 401)
			},
			{
				"minecraft:firework_charge",
				new Item(402, "minecraft:firework_charge", "Firework Star", true, 402)
			},
			{
				"minecraft:enchanted_book",
				new Item(403, "minecraft:enchanted_book", "Enchanted Book", true, 403)
			},
			{
				"minecraft:comparator",
				new Item(404, "minecraft:comparator", "Redstone Comparator", true, 404)
			},
			{
				"minecraft:netherbrick",
				new Item(405, "minecraft:netherbrick", "Nether Brick", true, 405)
			},
			{
				"minecraft:quartz",
				new Item(406, "minecraft:quartz", "Nether Quartz", true, 406)
			},
			{
				"minecraft:tnt_minecart",
				new Item(407, "minecraft:tnt_minecart", "Minecart with TNT", true, 407)
			},
			{
				"minecraft:hopper_minecart",
				new Item(408, "minecraft:hopper_minecart", "Minecart with Hopper", true, 408)
			},
			{
				"minecraft:prismarine_shard",
				new Item(409, "minecraft:prismarine_shard", "Prismarine Shard", true, 409)
			},
			{
				"minecraft:prismarine_crystals",
				new Item(410, "minecraft:prismarine_crystals", "Prismarine Crystals", true, 422)
			},
			{
				"minecraft:rabbit",
				new Item(411, "minecraft:rabbit", "Raw Rabbit", true, 411)
			},
			{
				"minecraft:cooked_rabbit",
				new Item(412, "minecraft:cooked_rabbit", "Cooked Rabbit", true, 412)
			},
			{
				"minecraft:rabbit_stew",
				new Item(413, "minecraft:rabbit_stew", "Rabbit Stew", true, 413)
			},
			{
				"minecraft:rabbit_foot",
				new Item(414, "minecraft:rabbit_foot", "Rabbit's Foot", true, 414)
			},
			{
				"minecraft:rabbit_hide",
				new Item(415, "minecraft:rabbit_hide", "Rabbit Hide", true, 415)
			},
			{
				"minecraft:armor_stand",
				new Item(416, "minecraft:armor_stand", "Armor Stand", true, 425)
			},
			{
				"minecraft:iron_horse_armor",
				new Item(417, "minecraft:iron_horse_armor", "Iron Horse Armor", true, 417)
			},
			{
				"minecraft:golden_horse_armor",
				new Item(418, "minecraft:golden_horse_armor", "Golden Horse Armor", true, 418)
			},
			{
				"minecraft:diamond_horse_armor",
				new Item(419, "minecraft:diamond_horse_armor", "Diamond Horse Armor", true, 419)
			},
			{
				"minecraft:lead",
				new Item(420, "minecraft:lead", "Lead", true, 420)
			},
			{
				"minecraft:name_tag",
				new Item(421, "minecraft:name_tag", "Name Tag", true, 421)
			},
			{
				"minecraft:command_block_minecart",
				new Item(422, "minecraft:command_block_minecart", "Minecart with Command Block", true, 443)
			},
			{
				"minecraft:mutton",
				new Item(423, "minecraft:mutton", "Raw Mutton", true, 423)
			},
			{
				"minecraft:cooked_mutton",
				new Item(424, "minecraft:cooked_mutton", "Cooked Mutton", true, 424)
			},
			{
				"minecraft:banner",
				new Item(425, "minecraft:banner", "Banner", true, 446)
			},
			{
				"minecraft:end_crystal",
				new Item(426, "minecraft:end_crystal", "End Crystal", true, 426)
			},
			{
				"minecraft:spruce_door",
				new Item(427, "minecraft:spruce_door", "Spruce Door", true, 427)
			},
			{
				"minecraft:birch_door",
				new Item(428, "minecraft:birch_door", "Birch Door", true, 428)
			},
			{
				"minecraft:jungle_door",
				new Item(429, "minecraft:jungle_door", "Jungle Door", true, 429)
			},
			{
				"minecraft:acacia_door",
				new Item(430, "minecraft:acacia_door", "Acacia Door", true, 430)
			},
			{
				"minecraft:dark_oak_door",
				new Item(431, "minecraft:dark_oak_door", "Dark Oak Door", true, 431)
			},
			{
				"minecraft:chorus_fruit",
				new Item(432, "minecraft:chorus_fruit", "Chorus Fruit", true, 432)
			},
			{
				"minecraft:chorus_fruit_popped",
				new Item(433, "minecraft:chorus_fruit_popped", "Popped Chorus Fruit", true, 433)
			},
			{
				"minecraft:beetroot",
				new Item(434, "minecraft:beetroot", "Beetroot", true, 457)
			},
			{
				"minecraft:beetroot_seeds",
				new Item(435, "minecraft:beetroot_seeds", "Beetroot Seeds", true, 458)
			},
			{
				"minecraft:beetroot_soup",
				new Item(436, "minecraft:beetroot_soup", "Beetroot Soup", true, 459)
			},
			{
				"minecraft:dragon_breath",
				new Item(437, "minecraft:dragon_breath", "Dragon's Breath", true, 437)
			},
			{
				"minecraft:splash_potion",
				new Item(438, "minecraft:splash_potion", "Splash Potion", true, 438)
			},
			{
				"minecraft:spectral_arrow",
				new Item(439, "minecraft:spectral_arrow", "Spectral Arrow", true, 262)
			},
			{
				"minecraft:tipped_arrow",
				new Item(440, "minecraft:tipped_arrow", "Tipped Arrow", true, 262)
			},
			{
				"minecraft:lingering_potion",
				new Item(441, "minecraft:lingering_potion", "Lingering Potion", true, 441)
			},
			{
				"minecraft:shield",
				new Item(442, "minecraft:shield", "Shield", false, -1)
			},
			{
				"minecraft:elytra",
				new Item(443, "minecraft:elytra", "Elytra", true, 444)
			},
			{
				"minecraft:spruce_boat",
				new Item(444, "minecraft:spruce_boat", "Spruce Boat", true, 333)
			},
			{
				"minecraft:birch_boat",
				new Item(445, "minecraft:birch_boat", "Birch Boat", true, 333)
			},
			{
				"minecraft:jungle_boat",
				new Item(446, "minecraft:jungle_boat", "Jungle Boat", true, 333)
			},
			{
				"minecraft:acacia_boat",
				new Item(447, "minecraft:acacia_boat", "Acacia Boat", true, 333)
			},
			{
				"minecraft:dark_oak_boat",
				new Item(448, "minecraft:dark_oak_boat", "Dark Oak Boat", true, 333)
			},
			{
				"minecraft:totem_of_undying",
				new Item(449, "minecraft:totem_of_undying", "Totem of Undying", true, 333)
			},
			{
				"minecraft:shulker_shell",
				new Item(450, "minecraft:shulker_shell", "Shulker Shell", true, 445)
			},
			{
				"minecraft:iron_nugget",
				new Item(452, "minecraft:iron_nugget", "Iron Nugget", true, 452)
			},
			{
				"minecraft:record_13",
				new Item(2256, "minecraft:record_13", "13 Disc", true, 500)
			},
			{
				"minecraft:record_cat",
				new Item(2257, "minecraft:record_cat", "Cat Disc", true, 501)
			},
			{
				"minecraft:record_blocks",
				new Item(2258, "minecraft:record_blocks", "Blocks Disc", true, 502)
			},
			{
				"minecraft:record_chirp",
				new Item(2259, "minecraft:record_chirp", "Chirp Disc", true, 503)
			},
			{
				"minecraft:record_far",
				new Item(2260, "minecraft:record_far", "Far Disc", true, 504)
			},
			{
				"minecraft:record_mall",
				new Item(2261, "minecraft:record_mall", "Mall Disc", true, 505)
			},
			{
				"minecraft:record_mellohi",
				new Item(2262, "minecraft:record_mellohi", "Mellohi Disc", true, 506)
			},
			{
				"minecraft:record_stal",
				new Item(2263, "minecraft:record_stal", "Stal Disc", true, 507)
			},
			{
				"minecraft:record_strad",
				new Item(2264, "minecraft:record_strad", "Strad Disc", true, 508)
			},
			{
				"minecraft:record_ward",
				new Item(2265, "minecraft:record_ward", "Ward Disc", true, 509)
			},
			{
				"minecraft:record_11",
				new Item(2266, "minecraft:record_11", "11 Disc", true, 510)
			},
			{
				"minecraft:record_wait",
				new Item(2267, "minecraft:record_wait", "Wait Disc", true, 511)
			}
		};
	}
}
