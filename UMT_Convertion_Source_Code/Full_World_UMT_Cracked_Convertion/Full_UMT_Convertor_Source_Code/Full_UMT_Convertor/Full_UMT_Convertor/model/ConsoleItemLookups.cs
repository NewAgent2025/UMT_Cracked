using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F4 RID: 244
	public class ConsoleItemLookups
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00007650 File Offset: 0x00005850
		public static Dictionary<string, Item> ItemsByName
		{
			get
			{
				return ConsoleItemLookups.dictionary_1;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00007657 File Offset: 0x00005857
		public static Dictionary<int, Item> ItemsById
		{
			get
			{
				return ConsoleItemLookups.dictionary_0;
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0004E880 File Offset: 0x0004CA80
		public static void LoadItemsById()
		{
			ConsoleItemLookups.dictionary_0 = new Dictionary<int, Item>();
			foreach (Item item in ConsoleItemLookups.dictionary_1.Values)
			{
				ConsoleItemLookups.dictionary_0.Add(item.Id, item);
			}
		}

		// Token: 0x04000701 RID: 1793
		private static Dictionary<int, Item> dictionary_0 = null;

		// Token: 0x04000702 RID: 1794
		private static Dictionary<string, Item> dictionary_1 = new Dictionary<string, Item>
		{
			{
				"minecraft:iron_shovel",
				new Item(256, "minecraft:iron_shovel", "Iron Shovel")
			},
			{
				"minecraft:iron_pickaxe",
				new Item(257, "minecraft:iron_pickaxe", "Iron Pickaxe")
			},
			{
				"minecraft:iron_axe",
				new Item(258, "minecraft:iron_axe", "Iron Axe")
			},
			{
				"minecraft:flint_and_steel",
				new Item(259, "minecraft:flint_and_steel", "Flint and Steel")
			},
			{
				"minecraft:apple",
				new Item(260, "minecraft:apple", "Apple")
			},
			{
				"minecraft:bow",
				new Item(261, "minecraft:bow", "Bow")
			},
			{
				"minecraft:arrow",
				new Item(262, "minecraft:arrow", "Arrow")
			},
			{
				"minecraft:coal",
				new Item(263, "minecraft:coal", "Coal")
			},
			{
				"minecraft:diamond",
				new Item(264, "minecraft:diamond", "Diamond")
			},
			{
				"minecraft:iron_ingot",
				new Item(265, "minecraft:iron_ingot", "Iron Ingot")
			},
			{
				"minecraft:gold_ingot",
				new Item(266, "minecraft:gold_ingot", "Gold Ingot")
			},
			{
				"minecraft:iron_sword",
				new Item(267, "minecraft:iron_sword", "Iron Sword")
			},
			{
				"minecraft:wooden_sword",
				new Item(268, "minecraft:wooden_sword", "Wooden Sword")
			},
			{
				"minecraft:wooden_shovel",
				new Item(269, "minecraft:wooden_shovel", "Wooden Shovel")
			},
			{
				"minecraft:wooden_pickaxe",
				new Item(270, "minecraft:wooden_pickaxe", "Wooden Pickaxe")
			},
			{
				"minecraft:wooden_axe",
				new Item(271, "minecraft:wooden_axe", "Wooden Axe")
			},
			{
				"minecraft:stone_sword",
				new Item(272, "minecraft:stone_sword", "Stone Sword")
			},
			{
				"minecraft:stone_shovel",
				new Item(273, "minecraft:stone_shovel", "Stone Shovel")
			},
			{
				"minecraft:stone_pickaxe",
				new Item(274, "minecraft:stone_pickaxe", "Stone Pickaxe")
			},
			{
				"minecraft:stone_axe",
				new Item(275, "minecraft:stone_axe", "Stone Axe")
			},
			{
				"minecraft:diamond_sword",
				new Item(276, "minecraft:diamond_sword", "Diamond Sword")
			},
			{
				"minecraft:diamond_shovel",
				new Item(277, "minecraft:diamond_shovel", "Diamond Shovel")
			},
			{
				"minecraft:diamond_pickaxe",
				new Item(278, "minecraft:diamond_pickaxe", "Diamond Pickaxe")
			},
			{
				"minecraft:diamond_axe",
				new Item(279, "minecraft:diamond_axe", "Diamond Axe")
			},
			{
				"minecraft:stick",
				new Item(280, "minecraft:stick", "Stick")
			},
			{
				"minecraft:bowl",
				new Item(281, "minecraft:bowl", "Bowl")
			},
			{
				"minecraft:mushroom_stew",
				new Item(282, "minecraft:mushroom_stew", "Mushroom Stew")
			},
			{
				"minecraft:golden_sword",
				new Item(283, "minecraft:golden_sword", "Golden Sword")
			},
			{
				"minecraft:golden_shovel",
				new Item(284, "minecraft:golden_shovel", "Golden Shovel")
			},
			{
				"minecraft:golden_pickaxe",
				new Item(285, "minecraft:golden_pickaxe", "Golden Pickaxe")
			},
			{
				"minecraft:golden_axe",
				new Item(286, "minecraft:golden_axe", "Golden Axe")
			},
			{
				"minecraft:string",
				new Item(287, "minecraft:string", "String")
			},
			{
				"minecraft:feather",
				new Item(288, "minecraft:feather", "Feather")
			},
			{
				"minecraft:gunpowder",
				new Item(289, "minecraft:gunpowder", "Gunpowder")
			},
			{
				"minecraft:wooden_hoe",
				new Item(290, "minecraft:wooden_hoe", "Wooden Hoe")
			},
			{
				"minecraft:stone_hoe",
				new Item(291, "minecraft:stone_hoe", "Stone Hoe")
			},
			{
				"minecraft:iron_hoe",
				new Item(292, "minecraft:iron_hoe", "Iron Hoe")
			},
			{
				"minecraft:diamond_hoe",
				new Item(293, "minecraft:diamond_hoe", "Diamond Hoe")
			},
			{
				"minecraft:golden_hoe",
				new Item(294, "minecraft:golden_hoe", "Golden Hoe")
			},
			{
				"minecraft:wheat_seeds",
				new Item(295, "minecraft:wheat_seeds", "Seeds")
			},
			{
				"minecraft:wheat",
				new Item(296, "minecraft:wheat", "Wheat")
			},
			{
				"minecraft:bread",
				new Item(297, "minecraft:bread", "Bread")
			},
			{
				"minecraft:leather_helmet",
				new Item(298, "minecraft:leather_helmet", "Leather Cap")
			},
			{
				"minecraft:leather_chestplate",
				new Item(299, "minecraft:leather_chestplate", "Leather Tunic")
			},
			{
				"minecraft:leather_leggings",
				new Item(300, "minecraft:leather_leggings", "Leather Pants")
			},
			{
				"minecraft:leather_boots",
				new Item(301, "minecraft:leather_boots", "Leather Boots")
			},
			{
				"minecraft:chainmail_helmet",
				new Item(302, "minecraft:chainmail_helmet", "Chain Helmet")
			},
			{
				"minecraft:chainmail_chestplate",
				new Item(303, "minecraft:chainmail_chestplate", "Chain Chestplate")
			},
			{
				"minecraft:chainmail_leggings",
				new Item(304, "minecraft:chainmail_leggings", "Chain Leggings")
			},
			{
				"minecraft:chainmail_boots",
				new Item(305, "minecraft:chainmail_boots", "Chain Boots")
			},
			{
				"minecraft:iron_helmet",
				new Item(306, "minecraft:iron_helmet", "Iron Helmet")
			},
			{
				"minecraft:iron_chestplate",
				new Item(307, "minecraft:iron_chestplate", "Iron Chestplate")
			},
			{
				"minecraft:iron_leggings",
				new Item(308, "minecraft:iron_leggings", "Iron Leggings")
			},
			{
				"minecraft:iron_boots",
				new Item(309, "minecraft:iron_boots", "Iron Boots")
			},
			{
				"minecraft:diamond_helmet",
				new Item(310, "minecraft:diamond_helmet", "Diamond Helmet")
			},
			{
				"minecraft:diamond_chestplate",
				new Item(311, "minecraft:diamond_chestplate", "Diamond Chestplate")
			},
			{
				"minecraft:diamond_leggings",
				new Item(312, "minecraft:diamond_leggings", "Diamond Leggings")
			},
			{
				"minecraft:diamond_boots",
				new Item(313, "minecraft:diamond_boots", "Diamond Boots")
			},
			{
				"minecraft:golden_helmet",
				new Item(314, "minecraft:golden_helmet", "Golden Helmet")
			},
			{
				"minecraft:golden_chestplate",
				new Item(315, "minecraft:golden_chestplate", "Golden Chestplate")
			},
			{
				"minecraft:golden_leggings",
				new Item(316, "minecraft:golden_leggings", "Golden Leggings")
			},
			{
				"minecraft:golden_boots",
				new Item(317, "minecraft:golden_boots", "Golden Boots")
			},
			{
				"minecraft:flint",
				new Item(318, "minecraft:flint", "Flint")
			},
			{
				"minecraft:porkchop",
				new Item(319, "minecraft:porkchop", "Raw Porkchop")
			},
			{
				"minecraft:cooked_porkchop",
				new Item(320, "minecraft:cooked_porkchop", "Cooked Porkchop")
			},
			{
				"minecraft:painting",
				new Item(321, "minecraft:painting", "Painting")
			},
			{
				"minecraft:golden_apple",
				new Item(322, "minecraft:golden_apple", "Golden Apple")
			},
			{
				"minecraft:sign",
				new Item(323, "minecraft:sign", "Sign")
			},
			{
				"minecraft:wooden_door",
				new Item(324, "minecraft:wooden_door", "Oak Door")
			},
			{
				"minecraft:bucket",
				new Item(325, "minecraft:bucket", "Bucket")
			},
			{
				"minecraft:water_bucket",
				new Item(326, "minecraft:water_bucket", "Water Bucket")
			},
			{
				"minecraft:lava_bucket",
				new Item(327, "minecraft:lava_bucket", "Lava Bucket")
			},
			{
				"minecraft:minecart",
				new Item(328, "minecraft:minecart", "Minecart")
			},
			{
				"minecraft:saddle",
				new Item(329, "minecraft:saddle", "Saddle")
			},
			{
				"minecraft:iron_door",
				new Item(330, "minecraft:iron_door", "Iron Door")
			},
			{
				"minecraft:redstone",
				new Item(331, "minecraft:redstone", "Redstone")
			},
			{
				"minecraft:snowball",
				new Item(332, "minecraft:snowball", "Snowball")
			},
			{
				"minecraft:boat",
				new Item(333, "minecraft:boat", "Boat")
			},
			{
				"minecraft:leather",
				new Item(334, "minecraft:leather", "Leather")
			},
			{
				"minecraft:milk_bucket",
				new Item(335, "minecraft:milk_bucket", "Milk")
			},
			{
				"minecraft:brick",
				new Item(336, "minecraft:brick", "Brick")
			},
			{
				"minecraft:clay_ball",
				new Item(337, "minecraft:clay_ball", "Clay")
			},
			{
				"minecraft:reeds",
				new Item(338, "minecraft:reeds", "Sugar Cane")
			},
			{
				"minecraft:paper",
				new Item(339, "minecraft:paper", "Paper")
			},
			{
				"minecraft:book",
				new Item(340, "minecraft:book", "Book")
			},
			{
				"minecraft:slime_ball",
				new Item(341, "minecraft:slime_ball", "Slimeball")
			},
			{
				"minecraft:chest_minecart",
				new Item(342, "minecraft:chest_minecart", "Minecart with Chest")
			},
			{
				"minecraft:furnace_minecart",
				new Item(343, "minecraft:furnace_minecart", "Minecart with Furnace")
			},
			{
				"minecraft:egg",
				new Item(344, "minecraft:egg", "Egg")
			},
			{
				"minecraft:compass",
				new Item(345, "minecraft:compass", "Compass")
			},
			{
				"minecraft:fishing_rod",
				new Item(346, "minecraft:fishing_rod", "Fishing Rod")
			},
			{
				"minecraft:clock",
				new Item(347, "minecraft:clock", "Clock")
			},
			{
				"minecraft:glowstone_dust",
				new Item(348, "minecraft:glowstone_dust", "Glowstone Dust")
			},
			{
				"minecraft:fish",
				new Item(349, "minecraft:fish", "Raw Fish")
			},
			{
				"minecraft:cooked_fish",
				new Item(350, "minecraft:cooked_fish", "Cooked Fish")
			},
			{
				"minecraft:dye",
				new Item(351, "minecraft:dye", "Dye")
			},
			{
				"minecraft:bone",
				new Item(352, "minecraft:bone", "Bone")
			},
			{
				"minecraft:sugar",
				new Item(353, "minecraft:sugar", "Sugar")
			},
			{
				"minecraft:cake",
				new Item(354, "minecraft:cake", "Cake")
			},
			{
				"minecraft:bed",
				new Item(355, "minecraft:bed", "Bed")
			},
			{
				"minecraft:repeater",
				new Item(356, "minecraft:repeater", "Redstone Repeater")
			},
			{
				"minecraft:cookie",
				new Item(357, "minecraft:cookie", "Cookie")
			},
			{
				"minecraft:filled_map",
				new Item(358, "minecraft:filled_map", "Map")
			},
			{
				"minecraft:shears",
				new Item(359, "minecraft:shears", "Shears")
			},
			{
				"minecraft:melon",
				new Item(360, "minecraft:melon", "Melon")
			},
			{
				"minecraft:pumpkin_seeds",
				new Item(361, "minecraft:pumpkin_seeds", "Pumpkin Seeds")
			},
			{
				"minecraft:melon_seeds",
				new Item(362, "minecraft:melon_seeds", "Melon Seeds")
			},
			{
				"minecraft:beef",
				new Item(363, "minecraft:beef", "Raw Beef")
			},
			{
				"minecraft:cooked_beef",
				new Item(364, "minecraft:cooked_beef", "Steak")
			},
			{
				"minecraft:chicken",
				new Item(365, "minecraft:chicken", "Raw Chicken")
			},
			{
				"minecraft:cooked_chicken",
				new Item(366, "minecraft:cooked_chicken", "Cooked Chicken")
			},
			{
				"minecraft:rotten_flesh",
				new Item(367, "minecraft:rotten_flesh", "Rotten Flesh")
			},
			{
				"minecraft:ender_pearl",
				new Item(368, "minecraft:ender_pearl", "Ender Pearl")
			},
			{
				"minecraft:blaze_rod",
				new Item(369, "minecraft:blaze_rod", "Blaze Rod")
			},
			{
				"minecraft:ghast_tear",
				new Item(370, "minecraft:ghast_tear", "Ghast Tear")
			},
			{
				"minecraft:gold_nugget",
				new Item(371, "minecraft:gold_nugget", "Gold Nugget")
			},
			{
				"minecraft:nether_wart",
				new Item(372, "minecraft:nether_wart", "Nether Wart")
			},
			{
				"minecraft:potion",
				new Item(373, "minecraft:potion", "Potion")
			},
			{
				"minecraft:glass_bottle",
				new Item(374, "minecraft:glass_bottle", "Glass Bottle")
			},
			{
				"minecraft:spider_eye",
				new Item(375, "minecraft:spider_eye", "Spider Eye")
			},
			{
				"minecraft:fermented_spider_eye",
				new Item(376, "minecraft:fermented_spider_eye", "Fermented Spider Eye")
			},
			{
				"minecraft:blaze_powder",
				new Item(377, "minecraft:blaze_powder", "Blaze Powder")
			},
			{
				"minecraft:magma_cream",
				new Item(378, "minecraft:magma_cream", "Magma Cream")
			},
			{
				"minecraft:brewing_stand",
				new Item(379, "minecraft:brewing_stand", "Brewing Stand")
			},
			{
				"minecraft:cauldron",
				new Item(380, "minecraft:cauldron", "Cauldron")
			},
			{
				"minecraft:ender_eye",
				new Item(381, "minecraft:ender_eye", "Eye of Ender")
			},
			{
				"minecraft:speckled_melon",
				new Item(382, "minecraft:speckled_melon", "Glistering Melon")
			},
			{
				"minecraft:spawn_egg",
				new Item(383, "minecraft:spawn_egg", "Spawn Egg")
			},
			{
				"minecraft:experience_bottle",
				new Item(384, "minecraft:experience_bottle", "Bottle o' Enchanting")
			},
			{
				"minecraft:fire_charge",
				new Item(385, "minecraft:fire_charge", "Fire Charge")
			},
			{
				"minecraft:writable_book",
				new Item(386, "minecraft:writable_book", "Book and Quill")
			},
			{
				"minecraft:written_book",
				new Item(387, "minecraft:written_book", "Written Book")
			},
			{
				"minecraft:emerald",
				new Item(388, "minecraft:emerald", "Emerald")
			},
			{
				"minecraft:item_frame",
				new Item(389, "minecraft:item_frame", "Item Frame")
			},
			{
				"minecraft:flower_pot",
				new Item(390, "minecraft:flower_pot", "Flower Pot")
			},
			{
				"minecraft:carrot",
				new Item(391, "minecraft:carrot", "Carrot")
			},
			{
				"minecraft:potato",
				new Item(392, "minecraft:potato", "Potato")
			},
			{
				"minecraft:baked_potato",
				new Item(393, "minecraft:baked_potato", "Baked Potato")
			},
			{
				"minecraft:poisonous_potato",
				new Item(394, "minecraft:poisonous_potato", "Poisonous Potato")
			},
			{
				"minecraft:map",
				new Item(395, "minecraft:map", "Empty Map")
			},
			{
				"minecraft:golden_carrot",
				new Item(396, "minecraft:golden_carrot", "Golden Carrot")
			},
			{
				"minecraft:skull",
				new Item(397, "minecraft:skull", "Mob head")
			},
			{
				"minecraft:carrot_on_a_stick",
				new Item(398, "minecraft:carrot_on_a_stick", "Carrot on a Stick")
			},
			{
				"minecraft:nether_star",
				new Item(399, "minecraft:nether_star", "Nether Star")
			},
			{
				"minecraft:pumpkin_pie",
				new Item(400, "minecraft:pumpkin_pie", "Pumpkin Pie")
			},
			{
				"minecraft:fireworks",
				new Item(401, "minecraft:fireworks", "Firework Rocket")
			},
			{
				"minecraft:firework_charge",
				new Item(402, "minecraft:firework_charge", "Firework Star")
			},
			{
				"minecraft:enchanted_book",
				new Item(403, "minecraft:enchanted_book", "Enchanted Book")
			},
			{
				"minecraft:comparator",
				new Item(404, "minecraft:comparator", "Redstone Comparator")
			},
			{
				"minecraft:netherbrick",
				new Item(405, "minecraft:netherbrick", "Nether Brick")
			},
			{
				"minecraft:quartz",
				new Item(406, "minecraft:quartz", "Nether Quartz")
			},
			{
				"minecraft:tnt_minecart",
				new Item(407, "minecraft:tnt_minecart", "Minecart with TNT")
			},
			{
				"minecraft:hopper_minecart",
				new Item(408, "minecraft:hopper_minecart", "Minecart with Hopper")
			},
			{
				"minecraft:prismarine_shard",
				new Item(409, "minecraft:prismarine_shard", "Prismarine Shard")
			},
			{
				"minecraft:prismarine_crystals",
				new Item(410, "minecraft:prismarine_crystals", "Prismarine Crystals")
			},
			{
				"minecraft:rabbit",
				new Item(411, "minecraft:rabbit", "Raw Rabbit")
			},
			{
				"minecraft:cooked_rabbit",
				new Item(412, "minecraft:cooked_rabbit", "Cooked Rabbit")
			},
			{
				"minecraft:rabbit_stew",
				new Item(413, "minecraft:rabbit_stew", "Rabbit Stew")
			},
			{
				"minecraft:rabbit_foot",
				new Item(414, "minecraft:rabbit_foot", "Rabbit's Foot")
			},
			{
				"minecraft:rabbit_hide",
				new Item(415, "minecraft:rabbit_hide", "Rabbit Hide")
			},
			{
				"minecraft:armor_stand",
				new Item(416, "minecraft:armor_stand", "Armor Stand")
			},
			{
				"minecraft:iron_horse_armor",
				new Item(417, "minecraft:iron_horse_armor", "Iron Horse Armor")
			},
			{
				"minecraft:golden_horse_armor",
				new Item(418, "minecraft:golden_horse_armor", "Golden Horse Armor")
			},
			{
				"minecraft:diamond_horse_armor",
				new Item(419, "minecraft:diamond_horse_armor", "Diamond Horse Armor")
			},
			{
				"minecraft:lead",
				new Item(420, "minecraft:lead", "Lead")
			},
			{
				"minecraft:name_tag",
				new Item(421, "minecraft:name_tag", "Name Tag")
			},
			{
				"minecraft:command_block_minecart",
				new Item(422, "minecraft:command_block_minecart", "Minecart with Command Block", false, 0)
			},
			{
				"minecraft:mutton",
				new Item(423, "minecraft:mutton", "Raw Mutton")
			},
			{
				"minecraft:cooked_mutton",
				new Item(424, "minecraft:cooked_mutton", "Cooked Mutton")
			},
			{
				"minecraft:banner",
				new Item(425, "minecraft:banner", "Banner")
			},
			{
				"minecraft:end_crystal",
				new Item(426, "minecraft:end_crystal", "End Crystal")
			},
			{
				"minecraft:spruce_door",
				new Item(427, "minecraft:spruce_door", "Spruce Door")
			},
			{
				"minecraft:birch_door",
				new Item(428, "minecraft:birch_door", "Birch Door")
			},
			{
				"minecraft:jungle_door",
				new Item(429, "minecraft:jungle_door", "Jungle Door")
			},
			{
				"minecraft:acacia_door",
				new Item(430, "minecraft:acacia_door", "Acacia Door")
			},
			{
				"minecraft:dark_oak_door",
				new Item(431, "minecraft:dark_oak_door", "Dark Oak Door")
			},
			{
				"minecraft:chorus_fruit",
				new Item(432, "minecraft:chorus_fruit", "Chorus Fruit")
			},
			{
				"minecraft:chorus_fruit_popped",
				new Item(433, "minecraft:chorus_fruit_popped", "Popped Chorus Fruit")
			},
			{
				"minecraft:beetroot",
				new Item(434, "minecraft:beetroot", "Beetroot")
			},
			{
				"minecraft:beetroot_seeds",
				new Item(435, "minecraft:beetroot_seeds", "Beetroot Seeds")
			},
			{
				"minecraft:beetroot_soup",
				new Item(436, "minecraft:beetroot_soup", "Beetroot Soup")
			},
			{
				"minecraft:dragon_breath",
				new Item(437, "minecraft:dragon_breath", "Dragon's Breath")
			},
			{
				"minecraft:splash_potion",
				new Item(438, "minecraft:splash_potion", "Splash Potion")
			},
			{
				"minecraft:spectral_arrow",
				new Item(439, "minecraft:spectral_arrow", "Spectral Arrow", false, 262)
			},
			{
				"minecraft:tipped_arrow",
				new Item(440, "minecraft:tipped_arrow", "Tipped Arrow")
			},
			{
				"minecraft:lingering_potion",
				new Item(441, "minecraft:lingering_potion", "Lingering Potion")
			},
			{
				"minecraft:shield",
				new Item(442, "minecraft:shield", "Shield", false, 0)
			},
			{
				"minecraft:elytra",
				new Item(443, "minecraft:elytra", "Elytra")
			},
			{
				"minecraft:spruce_boat",
				new Item(444, "minecraft:spruce_boat", "Spruce Boat")
			},
			{
				"minecraft:birch_boat",
				new Item(445, "minecraft:birch_boat", "Birch Boat")
			},
			{
				"minecraft:jungle_boat",
				new Item(446, "minecraft:jungle_boat", "Jungle Boat")
			},
			{
				"minecraft:acacia_boat",
				new Item(447, "minecraft:acacia_boat", "Acacia Boat")
			},
			{
				"minecraft:dark_oak_boat",
				new Item(448, "minecraft:dark_oak_boat", "Dark Oak Boat")
			},
			{
				"minecraft:record_13",
				new Item(2256, "minecraft:record_13", "13 Disc")
			},
			{
				"minecraft:record_cat",
				new Item(2257, "minecraft:record_cat", "Cat Disc")
			},
			{
				"minecraft:record_blocks",
				new Item(2258, "minecraft:record_blocks", "Blocks Disc")
			},
			{
				"minecraft:record_chirp",
				new Item(2259, "minecraft:record_chirp", "Chirp Disc")
			},
			{
				"minecraft:record_far",
				new Item(2260, "minecraft:record_far", "Far Disc")
			},
			{
				"minecraft:record_mall",
				new Item(2261, "minecraft:record_mall", "Mall Disc")
			},
			{
				"minecraft:record_mellohi",
				new Item(2262, "minecraft:record_mellohi", "Mellohi Disc")
			},
			{
				"minecraft:record_stal",
				new Item(2263, "minecraft:record_stal", "Stal Disc")
			},
			{
				"minecraft:record_strad",
				new Item(2264, "minecraft:record_strad", "Strad Disc")
			},
			{
				"minecraft:record_ward",
				new Item(2265, "minecraft:record_ward", "Ward Disc")
			},
			{
				"minecraft:record_11",
				new Item(2266, "minecraft:record_11", "11 Disc")
			},
			{
				"minecraft:record_wait",
				new Item(2267, "minecraft:record_wait", "Wait Disc")
			}
		};
	}
}
