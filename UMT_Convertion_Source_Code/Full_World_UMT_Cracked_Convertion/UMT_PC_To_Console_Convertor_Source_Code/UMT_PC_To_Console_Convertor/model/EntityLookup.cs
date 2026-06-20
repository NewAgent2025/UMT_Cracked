using System;
using System.Collections.Generic;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000071 RID: 113
	public class EntityLookup
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00004B01 File Offset: 0x00002D01
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00004B09 File Offset: 0x00002D09
		public Dictionary<int, string> HorseEntities
		{
			get
			{
				return this.dictionary_2;
			}
			set
			{
				this.dictionary_2 = value;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004B12 File Offset: 0x00002D12
		public EntityLookup()
		{
			this.method_0();
			this.method_1();
			this.method_2();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00004B2C File Offset: 0x00002D2C
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00004B34 File Offset: 0x00002D34
		public Dictionary<string, EntityItem> Dictionary_0
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00004B3D File Offset: 0x00002D3D
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004B45 File Offset: 0x00002D45
		public Dictionary<string, EntityItem> ConsoleEntities
		{
			get
			{
				return this.dictionary_1;
			}
			set
			{
				this.dictionary_1 = value;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000287F8 File Offset: 0x000269F8
		private void method_0()
		{
			this.dictionary_0 = new Dictionary<string, EntityItem>();
			foreach (EntityItem entityItem in EntityLookup.list_0)
			{
				this.dictionary_0.Add(entityItem.String_0, entityItem);
				this.dictionary_0.Add(entityItem.PCName, entityItem);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00028874 File Offset: 0x00026A74
		private void method_1()
		{
			this.dictionary_1 = new Dictionary<string, EntityItem>();
			foreach (EntityItem entityItem in EntityLookup.list_0)
			{
				if (!this.dictionary_1.ContainsKey(entityItem.ConsoleName))
				{
					this.dictionary_1.Add(entityItem.ConsoleName, entityItem);
				}
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000288F0 File Offset: 0x00026AF0
		private void method_2()
		{
			this.dictionary_2 = new Dictionary<int, string>
			{
				{
					0,
					"EntityHorse"
				},
				{
					1,
					"Donkey"
				},
				{
					2,
					"Mule"
				},
				{
					3,
					"ZombieHorse"
				},
				{
					4,
					"SkeletonHorse"
				}
			};
		}

		// Token: 0x0400035B RID: 859
		private static List<EntityItem> list_0 = new List<EntityItem>
		{
			new EntityItem("Bat", "Bat", "minecraft:bat", true, EntityCategory.MOB),
			new EntityItem("Blaze", "Blaze", "minecraft:blaze", true, EntityCategory.MOB),
			new EntityItem("CaveSpider", "CaveSpider", "minecraft:cave_spider", true, EntityCategory.MOB),
			new EntityItem("Chicken", "Chicken", "minecraft:chicken", true, EntityCategory.MOB),
			new EntityItem("Cow", "Cow", "minecraft:cow", true, EntityCategory.MOB),
			new EntityItem("Creeper", "Creeper", "minecraft:creeper", true, EntityCategory.MOB),
			new EntityItem("EnderDragon", "EnderDragon", "minecraft:ender_dragon", true, EntityCategory.MOB),
			new EntityItem("Enderman", "Enderman", "minecraft:enderman", true, EntityCategory.MOB),
			new EntityItem("Endermite", "Endermite", "minecraft:endermite", true, EntityCategory.MOB),
			new EntityItem("EntityHorse", "EntityHorse", "minecraft:horse", true, EntityCategory.MOB, 0),
			new EntityItem("EntityHorse", "Donkey", "minecraft:donkey", true, EntityCategory.MOB, 1),
			new EntityItem("EntityHorse", "Mule", "minecraft:mule", true, EntityCategory.MOB, 2),
			new EntityItem("EntityHorse", "ZombieHorse", "minecraft:zombie_horse", true, EntityCategory.MOB, 3),
			new EntityItem("EntityHorse", "SkeletonHorse", "minecraft:skeleton_horse", true, EntityCategory.MOB, 4),
			new EntityItem("Ghast", "Ghast", "minecraft:ghast", true, EntityCategory.MOB),
			new EntityItem("Giant", "Giant", "minecraft:giant", true, EntityCategory.MOB),
			new EntityItem("Guardian", "Guardian", "minecraft:guardian", true, EntityCategory.MOB),
			new EntityItem("Husk", "Husk", "minecraft:husk", true, EntityCategory.MOB),
			new EntityItem("LavaSlime", "LavaSlime", "minecraft:lava_slime", true, EntityCategory.MOB),
			new EntityItem("MushroomCow", "MushroomCow", "minecraft:mooshroom", true, EntityCategory.MOB),
			new EntityItem("Ozelot", "Ozelot", "minecraft:ozelot", true, EntityCategory.MOB),
			new EntityItem("Pig", "Pig", "minecraft:pig", true, EntityCategory.MOB),
			new EntityItem("PigZombie", "PigZombie", "minecraft:zombie_pigman", true, EntityCategory.MOB),
			new EntityItem("PolarBear", "PolarBear", "minecraft:polar_bear", true, EntityCategory.MOB),
			new EntityItem("Rabbit", "Rabbit", "minecraft:rabbit", true, EntityCategory.MOB),
			new EntityItem("Sheep", "Sheep", "minecraft:sheep", true, EntityCategory.MOB),
			new EntityItem("Shulker", "Shulker", "minecraft:shulker", true, EntityCategory.MOB),
			new EntityItem("Silverfish", "Silverfish", "minecraft:silverfish", true, EntityCategory.MOB),
			new EntityItem("Skeleton", "Skeleton", "minecraft:skeleton", true, EntityCategory.MOB),
			new EntityItem("Slime", "Slime", "minecraft:slime", true, EntityCategory.MOB),
			new EntityItem("SnowMan", "SnowMan", "minecraft:snowman", true, EntityCategory.MOB),
			new EntityItem("Spider", "Spider", "minecraft:spider", true, EntityCategory.MOB),
			new EntityItem("Squid", "Squid", "minecraft:squid", true, EntityCategory.MOB),
			new EntityItem("Stray", "Stray", "minecraft:stray", true, EntityCategory.MOB),
			new EntityItem("Villager", "Villager", "minecraft:villager", true, EntityCategory.MOB),
			new EntityItem("VillagerGolem", "VillagerGolem", "minecraft:villager_golem", true, EntityCategory.MOB),
			new EntityItem("Witch", "Witch", "minecraft:witch", true, EntityCategory.MOB),
			new EntityItem("WitherBoss", "WitherBoss", "minecraft:wither_boss", true, EntityCategory.MOB),
			new EntityItem("Wolf", "Wolf", "minecraft:wolf", true, EntityCategory.MOB),
			new EntityItem("Zombie", "Zombie", "minecraft:zombie", true, EntityCategory.MOB),
			new EntityItem("MinecartRideable", "MinecartRideable", "minecraft:minecart", true, EntityCategory.VEHICLE),
			new EntityItem("MinecartChest", "MinecartChest", "minecraft:chest_minecart", true, EntityCategory.VEHICLE),
			new EntityItem("MinecartFurnace", "MinecartFurnace", "minecraft:furnace_minecart", true, EntityCategory.VEHICLE),
			new EntityItem("MinecartHopper", "MinecartHopper", "minecraft:hopper_minecart", true, EntityCategory.VEHICLE),
			new EntityItem("MinecartTNT", "MinecartTNT", "minecraft:tnt_minecart", true, EntityCategory.VEHICLE),
			new EntityItem("MinecartSpawner", "MinecartSpawner", "minecraft:spawner_minecart", true, EntityCategory.VEHICLE),
			new EntityItem("Boat", "Boat", "minecraft:boat", true, EntityCategory.VEHICLE),
			new EntityItem("ArmorStand", "ArmorStand", "minecraft:armor_stand", true, EntityCategory.OTHER),
			new EntityItem("EnderCrystal", "EnderCrystal", "minecraft:ender_crystal", true, EntityCategory.OTHER),
			new EntityItem("FireworksRocketEntity", "FireworksRocketEntity", "minecraft:fireworks_rocket", true, EntityCategory.OTHER),
			new EntityItem("ItemFrame", "ItemFrame", "minecraft:item_frame", true, EntityCategory.OTHER),
			new EntityItem("LeashKnot", "LeashKnot", "minecraft:leash_knot", true, EntityCategory.OTHER),
			new EntityItem("Painting", "Painting", "minecraft:painting", true, EntityCategory.OTHER),
			new EntityItem("XPOrb", "XPOrb", "minecraft:xp_orb", true, EntityCategory.OTHER),
			new EntityItem("Item", "Item", "minecraft:item", true, EntityCategory.OTHER),
			new EntityItem("PrimedTNT", "PrimedTNT", "minecraft:tnt", true, EntityCategory.DYNAMIC),
			new EntityItem("FallingSand", "FallingSand", "minecraft:falling_block", true, EntityCategory.DYNAMIC),
			new EntityItem("Arrow", "Arrow", "minecraft:arrow", true, EntityCategory.PROJECTILE),
			new EntityItem("DragonFireball", "DragonFireball", "minecraft:dragon_fireball", true, EntityCategory.PROJECTILE),
			new EntityItem("SmallFireball", "SmallFireball", "minecraft:small_fireball", true, EntityCategory.PROJECTILE),
			new EntityItem("Snowball", "Snowball", "minecraft:snowball", true, EntityCategory.PROJECTILE),
			new EntityItem("SpectralArrow", "SpectralArrow", "minecraft:spectral_arrow", true, EntityCategory.PROJECTILE),
			new EntityItem("ThrownEgg", "ThrownEgg", "minecraft:egg", true, EntityCategory.PROJECTILE),
			new EntityItem("ThrownEnderpearl", "ThrownEnderpearl", "minecraft:ender_pearl", true, EntityCategory.PROJECTILE),
			new EntityItem("ThrownExpBottle", "ThrownExpBottle", "minecraft:xp_bottle", true, EntityCategory.PROJECTILE),
			new EntityItem("ThrownPotion", "ThrownPotion", "minecraft:potion", true, EntityCategory.PROJECTILE),
			new EntityItem("WitherSkull", "WitherSkull", "minecraft:wither_skull", true, EntityCategory.PROJECTILE),
			new EntityItem("AreaEffectCloud", "AreaEffectCloud", "minecraft:area_effect_cloud", true, EntityCategory.PROJECTILE)
		};

		// Token: 0x0400035C RID: 860
		private Dictionary<string, EntityItem> dictionary_0;

		// Token: 0x0400035D RID: 861
		private Dictionary<string, EntityItem> dictionary_1;

		// Token: 0x0400035E RID: 862
		private Dictionary<int, string> dictionary_2;
	}
}
