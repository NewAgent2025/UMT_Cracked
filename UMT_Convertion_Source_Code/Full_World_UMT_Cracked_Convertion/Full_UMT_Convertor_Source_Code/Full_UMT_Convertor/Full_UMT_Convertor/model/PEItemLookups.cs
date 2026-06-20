using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000F6 RID: 246
	public class PEItemLookups
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0000766C File Offset: 0x0000586C
		public static Dictionary<string, Item> ItemsByName
		{
			get
			{
				return PEItemLookups.dictionary_1;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00007673 File Offset: 0x00005873
		public static Dictionary<int, Item> ItemsById
		{
			get
			{
				return PEItemLookups.dictionary_0;
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00052094 File Offset: 0x00050294
		public static void LoadItemsById()
		{
			PEItemLookups.dictionary_0 = new Dictionary<int, Item>();
			foreach (Item item in PEItemLookups.dictionary_1.Values)
			{
				PEItemLookups.dictionary_0.Add(item.Id, item);
			}
		}

		// Token: 0x04000705 RID: 1797
		private static Dictionary<int, Item> dictionary_0 = null;

		// Token: 0x04000706 RID: 1798
		private static Dictionary<string, Item> dictionary_1 = new Dictionary<string, Item>
		{
			{
				"minecraft:iron_shovel",
				new Item(256, "iron_shovel", "Iron Shovel")
			},
			{
				"minecraft:iron_pickaxe",
				new Item(257, "iron_pickaxe", "Iron Pickaxe")
			},
			{
				"minecraft:iron_axe",
				new Item(258, "iron_axe", "Iron Axe")
			},
			{
				"minecraft:flint_and_steel",
				new Item(259, "flint_and_steel", "Flint and Steel")
			},
			{
				"minecraft:apple",
				new Item(260, "apple", "Apple")
			},
			{
				"minecraft:bow",
				new Item(261, "bow", "Bow")
			},
			{
				"minecraft:arrow",
				new Item(262, "arrow", "Arrow")
			},
			{
				"minecraft:coal",
				new Item(263, "coal", "Coal")
			},
			{
				"minecraft:diamond",
				new Item(264, "diamond", "Diamond")
			},
			{
				"minecraft:iron_ingot",
				new Item(265, "iron_ingot", "Iron Ingot")
			},
			{
				"minecraft:gold_ingot",
				new Item(266, "gold_ingot", "Gold Ingot")
			},
			{
				"minecraft:iron_sword",
				new Item(267, "iron_sword", "Iron Sword")
			},
			{
				"minecraft:wooden_sword",
				new Item(268, "wooden_sword", "Wooden Sword")
			},
			{
				"minecraft:wooden_shovel",
				new Item(269, "wooden_shovel", "Wooden Shovel")
			},
			{
				"minecraft:wooden_pickaxe",
				new Item(270, "wooden_pickaxe", "Wooden Pickaxe")
			},
			{
				"minecraft:wooden_axe",
				new Item(271, "wooden_axe", "Wooden Axe")
			},
			{
				"minecraft:stone_sword",
				new Item(272, "stone_sword", "Stone Sword")
			},
			{
				"minecraft:stone_shovel",
				new Item(273, "stone_shovel", "Stone Shovel")
			},
			{
				"minecraft:stone_pickaxe",
				new Item(274, "stone_pickaxe", "Stone Pickaxe")
			},
			{
				"minecraft:stone_axe",
				new Item(275, "stone_axe", "Stone Axe")
			},
			{
				"minecraft:diamond_sword",
				new Item(276, "diamond_sword", "Diamond Sword")
			},
			{
				"minecraft:diamond_shovel",
				new Item(277, "diamond_shovel", "Diamond Shovel")
			},
			{
				"minecraft:diamond_pickaxe",
				new Item(278, "diamond_pickaxe", "Diamond Pickaxe")
			},
			{
				"minecraft:diamond_axe",
				new Item(279, "diamond_axe", "Diamond Axe")
			},
			{
				"minecraft:stick",
				new Item(280, "stick", "Stick")
			},
			{
				"minecraft:bowl",
				new Item(281, "bowl", "Bowl")
			},
			{
				"minecraft:mushroom_stew",
				new Item(282, "mushroom_stew", "Mushroom Stew")
			},
			{
				"minecraft:golden_sword",
				new Item(283, "golden_sword", "Golden Sword")
			},
			{
				"minecraft:golden_shovel",
				new Item(284, "golden_shovel", "Golden Shovel")
			},
			{
				"minecraft:golden_pickaxe",
				new Item(285, "golden_pickaxe", "Golden Pickaxe")
			},
			{
				"minecraft:golden_axe",
				new Item(286, "golden_axe", "Golden Axe")
			},
			{
				"minecraft:string",
				new Item(287, "string", "String")
			},
			{
				"minecraft:feather",
				new Item(288, "feather", "Feather")
			},
			{
				"minecraft:gunpowder",
				new Item(289, "gunpowder", "Gunpowder")
			},
			{
				"minecraft:wooden_hoe",
				new Item(290, "wooden_hoe", "Wooden Hoe")
			},
			{
				"minecraft:stone_hoe",
				new Item(291, "stone_hoe", "Stone Hoe")
			},
			{
				"minecraft:iron_hoe",
				new Item(292, "iron_hoe", "Iron Hoe")
			},
			{
				"minecraft:diamond_hoe",
				new Item(293, "diamond_hoe", "Diamond Hoe")
			},
			{
				"minecraft:golden_hoe",
				new Item(294, "golden_hoe", "Golden Hoe")
			},
			{
				"minecraft:wheat_seeds",
				new Item(295, "wheat_seeds", "Seeds")
			},
			{
				"minecraft:wheat",
				new Item(296, "wheat", "Wheat")
			},
			{
				"minecraft:bread",
				new Item(297, "bread", "Bread")
			},
			{
				"minecraft:leather_helmet",
				new Item(298, "leather_helmet", "Leather Cap")
			},
			{
				"minecraft:leather_chestplate",
				new Item(299, "leather_chestplate", "Leather Tunic")
			},
			{
				"minecraft:leather_leggings",
				new Item(300, "leather_leggings", "Leather Pants")
			},
			{
				"minecraft:leather_boots",
				new Item(301, "leather_boots", "Leather Boots")
			},
			{
				"minecraft:chainmail_helmet",
				new Item(302, "chainmail_helmet", "Chain Helmet")
			},
			{
				"minecraft:chainmail_chestplate",
				new Item(303, "chainmail_chestplate", "Chain Chestplate")
			},
			{
				"minecraft:chainmail_leggings",
				new Item(304, "chainmail_leggings", "Chain Leggings")
			},
			{
				"minecraft:chainmail_boots",
				new Item(305, "chainmail_boots", "Chain Boots")
			},
			{
				"minecraft:iron_helmet",
				new Item(306, "iron_helmet", "Iron Helmet")
			},
			{
				"minecraft:iron_chestplate",
				new Item(307, "iron_chestplate", "Iron Chestplate")
			},
			{
				"minecraft:iron_leggings",
				new Item(308, "iron_leggings", "Iron Leggings")
			},
			{
				"minecraft:iron_boots",
				new Item(309, "iron_boots", "Iron Boots")
			},
			{
				"minecraft:diamond_helmet",
				new Item(310, "diamond_helmet", "Diamond Helmet")
			},
			{
				"minecraft:diamond_chestplate",
				new Item(311, "diamond_chestplate", "Diamond Chestplate")
			},
			{
				"minecraft:diamond_leggings",
				new Item(312, "diamond_leggings", "Diamond Leggings")
			},
			{
				"minecraft:diamond_boots",
				new Item(313, "diamond_boots", "Diamond Boots")
			},
			{
				"minecraft:golden_helmet",
				new Item(314, "golden_helmet", "Golden Helmet")
			},
			{
				"minecraft:golden_chestplate",
				new Item(315, "golden_chestplate", "Golden Chestplate")
			},
			{
				"minecraft:golden_leggings",
				new Item(316, "golden_leggings", "Golden Leggings")
			},
			{
				"minecraft:golden_boots",
				new Item(317, "golden_boots", "Golden Boots")
			},
			{
				"minecraft:flint",
				new Item(318, "flint", "Flint")
			},
			{
				"minecraft:porkchop",
				new Item(319, "porkchop", "Raw Porkchop")
			},
			{
				"minecraft:cooked_porkchop",
				new Item(320, "cooked_porkchop", "Cooked Porkchop")
			},
			{
				"minecraft:painting",
				new Item(321, "painting", "Painting")
			},
			{
				"minecraft:golden_apple",
				new Item(322, "golden_apple", "Golden Apple")
			},
			{
				"minecraft:sign",
				new Item(323, "sign", "Sign")
			},
			{
				"minecraft:wooden_door",
				new Item(324, "wooden_door", "Wooden Door")
			},
			{
				"minecraft:bucket",
				new Item(325, "bucket", "Bucket")
			},
			{
				"minecraft:minecart",
				new Item(328, "minecart", "Minecart")
			},
			{
				"minecraft:saddle",
				new Item(329, "saddle", "Saddle")
			},
			{
				"minecraft:iron_door",
				new Item(330, "iron_door", "Iron Door")
			},
			{
				"minecraft:redstone",
				new Item(331, "redstone", "Redstone")
			},
			{
				"minecraft:snowball",
				new Item(332, "snowball", "Snowball")
			},
			{
				"minecraft:boat",
				new Item(333, "boat", "Boat")
			},
			{
				"minecraft:leather",
				new Item(334, "leather", "Leather")
			},
			{
				"minecraft:kelp",
				new Item(335, "kelp", "Kelp")
			},
			{
				"minecraft:brick",
				new Item(336, "brick", "Brick")
			},
			{
				"minecraft:clay_ball",
				new Item(337, "clay_ball", "Clay")
			},
			{
				"minecraft:reeds",
				new Item(338, "reeds", "Sugar Cane")
			},
			{
				"minecraft:paper",
				new Item(339, "paper", "Paper")
			},
			{
				"minecraft:book",
				new Item(340, "book", "Book")
			},
			{
				"minecraft:slimeball",
				new Item(341, "slimeball", "Slimeball")
			},
			{
				"minecraft:chest_minecart",
				new Item(342, "chest_minecart", "Minecart with Chest")
			},
			{
				"minecraft:egg",
				new Item(344, "egg", "Egg")
			},
			{
				"minecraft:compass",
				new Item(345, "compass", "Compass")
			},
			{
				"minecraft:fishing_rod",
				new Item(346, "fishing_rod", "Fishing Rod")
			},
			{
				"minecraft:clock",
				new Item(347, "clock", "Clock")
			},
			{
				"minecraft:glowstone_dust",
				new Item(348, "glowstone_dust", "Glowstone Dust")
			},
			{
				"minecraft:fish",
				new Item(349, "fish", "Raw Fish")
			},
			{
				"minecraft:cooked_fish",
				new Item(350, "cooked_fish", "Cooked Fish")
			},
			{
				"minecraft:dye",
				new Item(351, "dye", "Dye")
			},
			{
				"minecraft:bone",
				new Item(352, "bone", "Bone")
			},
			{
				"minecraft:sugar",
				new Item(353, "sugar", "Sugar")
			},
			{
				"minecraft:cake",
				new Item(354, "cake", "Cake")
			},
			{
				"minecraft:bed",
				new Item(355, "bed", "Bed")
			},
			{
				"minecraft:repeater",
				new Item(356, "repeater", "Redstone Repeater")
			},
			{
				"minecraft:cookie",
				new Item(357, "cookie", "Cookie")
			},
			{
				"minecraft:map_filled",
				new Item(358, "map_filled", "Filled Map")
			},
			{
				"minecraft:shears",
				new Item(359, "shears", "Shears")
			},
			{
				"minecraft:melon",
				new Item(360, "melon", "Melon")
			},
			{
				"minecraft:pumpkin_seeds",
				new Item(361, "pumpkin_seeds", "Pumpkin Seeds")
			},
			{
				"minecraft:melon_seeds",
				new Item(362, "melon_seeds", "Melon Seeds")
			},
			{
				"minecraft:beef",
				new Item(363, "beef", "Raw Beef")
			},
			{
				"minecraft:cooked_beef",
				new Item(364, "cooked_beef", "Steak")
			},
			{
				"minecraft:chicken",
				new Item(365, "chicken", "Raw Chicken")
			},
			{
				"minecraft:cooked_chicken",
				new Item(366, "cooked_chicken", "Cooked Chicken")
			},
			{
				"minecraft:rotten_flesh",
				new Item(367, "rotten_flesh", "Rotten Flesh")
			},
			{
				"minecraft:ender_pearl",
				new Item(368, "ender_pearl", "Ender Pearl")
			},
			{
				"minecraft:blaze_rod",
				new Item(369, "blaze_rod", "Blaze Rod")
			},
			{
				"minecraft:ghast_tear",
				new Item(370, "ghast_tear", "Ghast Tear")
			},
			{
				"minecraft:gold_nugget",
				new Item(371, "gold_nugget", "Gold Nugget")
			},
			{
				"minecraft:nether_wart",
				new Item(372, "nether_wart", "Nether Wart")
			},
			{
				"minecraft:potion",
				new Item(373, "potion", "Potion")
			},
			{
				"minecraft:glass_bottle",
				new Item(374, "glass_bottle", "Glass Bottle")
			},
			{
				"minecraft:spider_eye",
				new Item(375, "spider_eye", "Spider Eye")
			},
			{
				"minecraft:fermented_spider_eye",
				new Item(376, "fermented_spider_eye", "Fermented Spider Eye")
			},
			{
				"minecraft:blaze_powder",
				new Item(377, "blaze_powder", "Blaze Powder")
			},
			{
				"minecraft:magma_cream",
				new Item(378, "magma_cream", "Magma Cream")
			},
			{
				"minecraft:brewing_stand",
				new Item(379, "brewing_stand", "Brewing Stand")
			},
			{
				"minecraft:cauldron",
				new Item(380, "cauldron", "Cauldron")
			},
			{
				"minecraft:ender_eye",
				new Item(381, "ender_eye", "Eye of Ender")
			},
			{
				"minecraft:speckled_melon",
				new Item(382, "speckled_melon", "Glistering Melon")
			},
			{
				"minecraft:spawn_egg",
				new Item(383, "spawn_egg", "Spawn Egg")
			},
			{
				"minecraft:experience_bottle",
				new Item(384, "experience_bottle", "Bottle o' Enchanting")
			},
			{
				"minecraft:fireball",
				new Item(385, "fireball", "Fire Charge")
			},
			{
				"minecraft:writable_book",
				new Item(386, "writable_book", "Book and Quill")
			},
			{
				"minecraft:written_book",
				new Item(387, "written_book", "Written Book")
			},
			{
				"minecraft:emerald",
				new Item(388, "emerald", "Emerald")
			},
			{
				"minecraft:frame",
				new Item(389, "frame", "Item Frame")
			},
			{
				"minecraft:flower_pot",
				new Item(390, "flower_pot", "Flower Pot")
			},
			{
				"minecraft:carrot",
				new Item(391, "carrot", "Carrot")
			},
			{
				"minecraft:potato",
				new Item(392, "potato", "Potato")
			},
			{
				"minecraft:baked_potato",
				new Item(393, "baked_potato", "Baked Potato")
			},
			{
				"minecraft:poisonous_potato",
				new Item(394, "poisonous_potato", "Poisonous Potato")
			},
			{
				"minecraft:emptymap",
				new Item(395, "emptymap", "Empty Map")
			},
			{
				"minecraft:golden_carrot",
				new Item(396, "golden_carrot", "Golden Carrot")
			},
			{
				"minecraft:skull",
				new Item(397, "skull", "Mob head")
			},
			{
				"minecraft:carrotonastick",
				new Item(398, "carrotonastick", "Carrot on a Stick")
			},
			{
				"minecraft:netherstar",
				new Item(399, "netherstar", "Nether Star")
			},
			{
				"minecraft:pumpkin_pie",
				new Item(400, "pumpkin_pie", "Pumpkin Pie")
			},
			{
				"minecraft:fireworks",
				new Item(401, "fireworks", "Firework Rocket")
			},
			{
				"minecraft:fireworkscharge",
				new Item(402, "fireworkscharge", "Firework Star")
			},
			{
				"minecraft:enchanted_book",
				new Item(403, "enchanted_book", "Enchanted Book")
			},
			{
				"minecraft:comparator",
				new Item(404, "comparator", "Redstone Comparator")
			},
			{
				"minecraft:netherbrick",
				new Item(405, "netherbrick", "Nether Brick")
			},
			{
				"minecraft:quartz",
				new Item(406, "quartz", "Nether Quartz")
			},
			{
				"minecraft:tnt_minecart",
				new Item(407, "tnt_minecart", "Minecart with TNT")
			},
			{
				"minecraft:hopper_minecart",
				new Item(408, "hopper_minecart", "Minecart with Hopper")
			},
			{
				"minecraft:prismarine_shard",
				new Item(409, "prismarine_shard", "Prismarine Shard")
			},
			{
				"minecraft:hopper",
				new Item(410, "hopper", "Hopper")
			},
			{
				"minecraft:rabbit",
				new Item(411, "rabbit", "Raw Rabbit")
			},
			{
				"minecraft:cooked_rabbit",
				new Item(412, "cooked_rabbit", "Cooked Rabbit")
			},
			{
				"minecraft:rabbit_stew",
				new Item(413, "rabbit_stew", "Rabbit Stew")
			},
			{
				"minecraft:rabbit_foot",
				new Item(414, "rabbit_foot", "Rabbit's Foot")
			},
			{
				"minecraft:rabbit_hide",
				new Item(415, "rabbit_hide", "Rabbit Hide")
			},
			{
				"minecraft:horsearmorleather",
				new Item(416, "horsearmorleather", "Leather Horse Armor")
			},
			{
				"minecraft:horsearmoriron",
				new Item(417, "horsearmoriron", "Iron Horse Armor")
			},
			{
				"minecraft:horsearmorgold",
				new Item(418, "horsearmorgold", "Golden Horse Armor")
			},
			{
				"minecraft:horsearmordiamond",
				new Item(419, "horsearmordiamond", "Diamond Horse Armor")
			},
			{
				"minecraft:lead",
				new Item(420, "lead", "Lead")
			},
			{
				"minecraft:nametag",
				new Item(421, "nametag", "Name Tag")
			},
			{
				"minecraft:prismarine_crystals",
				new Item(422, "prismarine_crystals", "Prismarine Crystals")
			},
			{
				"minecraft:muttonraw",
				new Item(423, "muttonraw", "Raw Mutton")
			},
			{
				"minecraft:muttoncooked",
				new Item(424, "muttoncooked", "Cooked Mutton")
			},
			{
				"minecraft:armor_stand",
				new Item(425, "armor_stand", "Armor Stand")
			},
			{
				"minecraft:end_crystal",
				new Item(426, "end_crystal", "End Crystal")
			},
			{
				"minecraft:spruce_door",
				new Item(427, "spruce_door", "Spruce Door")
			},
			{
				"minecraft:birch_door",
				new Item(428, "birch_door", "Birch Door")
			},
			{
				"minecraft:jungle_door",
				new Item(429, "jungle_door", "Jungle Door")
			},
			{
				"minecraft:acacia_door",
				new Item(430, "acacia_door", "Acacia Door")
			},
			{
				"minecraft:dark_oak_door",
				new Item(431, "dark_oak_door", "Dark Oak Door")
			},
			{
				"minecraft:chorus_fruit",
				new Item(432, "chorus_fruit", "Chorus Fruit")
			},
			{
				"minecraft:chorus_fruit_popped",
				new Item(433, "chorus_fruit_popped", "Popped Chorus Fruit")
			},
			{
				"minecraft:dragon_breath",
				new Item(437, "dragon_breath", "Dragon's Breath")
			},
			{
				"minecraft:splash_potion",
				new Item(438, "splash_potion", "Splash Potion")
			},
			{
				"minecraft:lingering_potion",
				new Item(441, "lingering_potion", "Lingering Potion")
			},
			{
				"minecraft:sparkler",
				new Item(442, "sparkler", "Orange Sparkler")
			},
			{
				"minecraft:command_block_minecart",
				new Item(443, "command_block_minecart", "Minecart with Command Block")
			},
			{
				"minecraft:elytra",
				new Item(444, "elytra", "Elytra")
			},
			{
				"minecraft:shulker_shell",
				new Item(445, "shulker_shell", "Shulker Shell")
			},
			{
				"minecraft:banner",
				new Item(446, "banner", "Banner")
			},
			{
				"minecraft:eye_drop",
				new Item(447, "eye_drop", "Eye Drops")
			},
			{
				"minecraft:balloon",
				new Item(448, "balloon", "White Balloon")
			},
			{
				"minecraft:super_fertilizer",
				new Item(449, "super_fertilizer", "Super Fertilizer")
			},
			{
				"minecraft:totem",
				new Item(450, "totem", "Totem of Undying")
			},
			{
				"minecraft:bleach",
				new Item(451, "bleach", "Bleach")
			},
			{
				"minecraft:iron_nugget",
				new Item(452, "iron_nugget", "Iron Nugget")
			},
			{
				"minecraft:ice_bomb",
				new Item(453, "ice_bomb", "Ice Bomb")
			},
			{
				"minecraft:trident",
				new Item(455, "trident", "Trident")
			},
			{
				"minecraft:beetroot",
				new Item(457, "beetroot", "Beetroot")
			},
			{
				"minecraft:beetroot_seeds",
				new Item(458, "beetroot_seeds", "Beetroot Seeds")
			},
			{
				"minecraft:beetroot_soup",
				new Item(459, "beetroot_soup", "Beetroot Soup")
			},
			{
				"minecraft:salmon",
				new Item(460, "salmon", "Raw Salmon")
			},
			{
				"minecraft:clownfish",
				new Item(461, "clownfish", "Clownfish")
			},
			{
				"minecraft:pufferfish",
				new Item(462, "pufferfish", "Pufferfish")
			},
			{
				"minecraft:cooked_salmon",
				new Item(463, "cooked_salmon", "Cooked Salmon")
			},
			{
				"minecraft:dried_kelp",
				new Item(464, "dried_kelp", "Dried Kelp")
			},
			{
				"minecraft:nautilus_shell",
				new Item(465, "nautilus_shell", "Nautilus Shell")
			},
			{
				"minecraft:appleenchanted",
				new Item(466, "appleenchanted", "Enchanted Golden Apple")
			},
			{
				"minecraft:heart_of_the_sea",
				new Item(467, "heart_of_the_sea", "Heart of the Sea")
			},
			{
				"minecraft:scute",
				new Item(468, "scute", "Scute")
			},
			{
				"minecraft:turtle_shell",
				new Item(469, "turtle_shell", "Turtle Shell")
			},
			{
				"minecraft:phantom_membrane",
				new Item(470, "phantom_membrane", "Phantom Membrane")
			},
			{
				"minecraft:compound",
				new Item(499, "compound", "Salt")
			},
			{
				"minecraft:record_13",
				new Item(500, "record_13", "13 Disc")
			},
			{
				"minecraft:record_cat",
				new Item(501, "record_cat", "Cat Disc")
			},
			{
				"minecraft:record_blocks",
				new Item(502, "record_blocks", "Blocks Disc")
			},
			{
				"minecraft:record_chirp",
				new Item(503, "record_chirp", "Chirp Disc")
			},
			{
				"minecraft:record_far",
				new Item(504, "record_far", "Far Disc")
			},
			{
				"minecraft:record_mall",
				new Item(505, "record_mall", "Mall Disc")
			},
			{
				"minecraft:record_mellohi",
				new Item(506, "record_mellohi", "Mellohi Disc")
			},
			{
				"minecraft:record_stal",
				new Item(507, "record_stal", "Stal Disc")
			},
			{
				"minecraft:record_strad",
				new Item(508, "record_strad", "Strad Disc")
			},
			{
				"minecraft:record_ward",
				new Item(509, "record_ward", "Ward Disc")
			},
			{
				"minecraft:record_11",
				new Item(510, "record_11", "11 Disc")
			},
			{
				"minecraft:record_wait",
				new Item(511, "record_wait", "Wait Disc")
			},
			{
				"minecraft:board",
				new Item(454, "board", "Chalkboard")
			},
			{
				"minecraft:portfolio",
				new Item(456, "portfolio", "Portfolio")
			},
			{
				"minecraft:camera",
				new Item(498, "camera", "Camera")
			}
		};
	}
}
