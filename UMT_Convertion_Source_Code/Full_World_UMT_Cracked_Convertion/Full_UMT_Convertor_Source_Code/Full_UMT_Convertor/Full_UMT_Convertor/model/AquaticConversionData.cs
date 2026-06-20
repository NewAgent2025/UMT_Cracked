using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x0200011A RID: 282
	public class AquaticConversionData
	{
		// Token: 0x04000799 RID: 1945
		public static List<string> waterBlocks = new List<string>
		{
			"minecraft:kelp",
			"minecraft:seagrass"
		};

		// Token: 0x0400079A RID: 1946
		public static Dictionary<string, short> bedColorXRef = new Dictionary<string, short>
		{
			{
				"white_bed",
				0
			},
			{
				"orange_bed",
				1
			},
			{
				"magenta_bed",
				2
			},
			{
				"light_blue_bed",
				3
			},
			{
				"yellow_bed",
				4
			},
			{
				"lime_bed",
				5
			},
			{
				"pink_bed",
				6
			},
			{
				"gray_bed",
				7
			},
			{
				"light_gray_bed",
				8
			},
			{
				"cyan_bed",
				9
			},
			{
				"purple_bed",
				10
			},
			{
				"blue_bed",
				11
			},
			{
				"brown_bed",
				12
			},
			{
				"green_bed",
				13
			},
			{
				"red_bed",
				14
			},
			{
				"black_bed",
				15
			}
		};

		// Token: 0x0400079B RID: 1947
		public static Dictionary<string, BlockItem> flowerPotXRef = new Dictionary<string, BlockItem>
		{
			{
				"potted_poppy",
				new BlockItem("minecraft:red_flower", 0)
			},
			{
				"potted_dandelion",
				new BlockItem("minecraft:yellow_flower", 0)
			},
			{
				"potted_oak_sapling",
				new BlockItem("minecraft:sapling", 0)
			},
			{
				"potted_spruce_sapling",
				new BlockItem("minecraft:sapling", 1)
			},
			{
				"potted_birch_sapling",
				new BlockItem("minecraft:sapling", 2)
			},
			{
				"potted_jungle_sapling",
				new BlockItem("minecraft:sapling", 3)
			},
			{
				"potted_red_mushroom",
				new BlockItem("minecraft:red_mushroom", 0)
			},
			{
				"potted_brown_mushroom",
				new BlockItem("minecraft:brown_mushroom", 0)
			},
			{
				"potted_cactus",
				new BlockItem("minecraft:cactus", 0)
			},
			{
				"potted_dead_bush",
				new BlockItem("minecraft:deadbush", 0)
			},
			{
				"potted_fern",
				new BlockItem("minecraft:tallgrass", 2)
			},
			{
				"potted_acacia_sapling",
				new BlockItem("minecraft:sapling", 4)
			},
			{
				"potted_dark_oak_sapling",
				new BlockItem("minecraft:sapling", 5)
			},
			{
				"potted_blue_orchid",
				new BlockItem("minecraft:red_flower", 1)
			},
			{
				"potted_allium",
				new BlockItem("minecraft:red_flower", 2)
			},
			{
				"potted_azure_bluet",
				new BlockItem("minecraft:red_flower", 3)
			},
			{
				"potted_red_tulip",
				new BlockItem("minecraft:red_flower", 4)
			},
			{
				"potted_orange_tulip",
				new BlockItem("minecraft:red_flower", 5)
			},
			{
				"potted_white_tulip",
				new BlockItem("minecraft:red_flower", 6)
			},
			{
				"potted_pink_tulip",
				new BlockItem("minecraft:red_flower", 7)
			},
			{
				"potted_oxeye_daisy",
				new BlockItem("minecraft:red_flower", 8)
			}
		};

		// Token: 0x0400079C RID: 1948
		public static Dictionary<string, BlockItem> dictionary_0 = new Dictionary<string, BlockItem>
		{
			{
				"skeleton_skull",
				new BlockItem("minecraft:skull", 0)
			},
			{
				"skeleton_wall_skull",
				new BlockItem("minecraft:skull", 0)
			},
			{
				"wither_skeleton_skull",
				new BlockItem("minecraft:skull", 1)
			},
			{
				"wither_skeleton_wall_skull",
				new BlockItem("minecraft:skull", 1)
			},
			{
				"zombie_head",
				new BlockItem("minecraft:skull", 2)
			},
			{
				"zombie_wall_head",
				new BlockItem("minecraft:skull", 2)
			},
			{
				"player_head",
				new BlockItem("minecraft:skull", 3)
			},
			{
				"player_wall_head",
				new BlockItem("minecraft:skull", 3)
			},
			{
				"creeper_head",
				new BlockItem("minecraft:skull", 4)
			},
			{
				"creeper_wall_head",
				new BlockItem("minecraft:skull", 4)
			},
			{
				"dragon_head",
				new BlockItem("minecraft:skull", 5)
			},
			{
				"dragon_wall_head",
				new BlockItem("minecraft:skull", 5)
			}
		};
	}
}
