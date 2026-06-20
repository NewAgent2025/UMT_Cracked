using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000A8 RID: 168
	public class EntityLookup
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0000563E File Offset: 0x0000383E
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00005646 File Offset: 0x00003846
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

		// Token: 0x060006DD RID: 1757 RVA: 0x0000564F File Offset: 0x0000384F
		public EntityLookup()
		{
			this.method_0();
			this.method_1();
			this.method_2();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00005669 File Offset: 0x00003869
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00005671 File Offset: 0x00003871
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0000567A File Offset: 0x0000387A
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00005682 File Offset: 0x00003882
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

		// Token: 0x060006E2 RID: 1762 RVA: 0x000402D8 File Offset: 0x0003E4D8
		private void method_0()
		{
			this.dictionary_0 = new Dictionary<string, EntityItem>();
			foreach (EntityItem entityItem in EntityLookup.list_0)
			{
				this.dictionary_0.Add(entityItem.String_0, entityItem);
				this.dictionary_0.Add(entityItem.PCName, entityItem);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00040354 File Offset: 0x0003E554
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

		// Token: 0x060006E4 RID: 1764 RVA: 0x000403D0 File Offset: 0x0003E5D0
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

		// Token: 0x040004ED RID: 1261
		private static List<EntityItem> list_0 = new List<EntityItem>
		{
			new EntityItem("Bat", "Bat", "minecraft:bat", true, EntityCategory.MOB),
			new EntityItem("Blaze", "Blaze", "minecraft:blaze", true, EntityCategory.MOB),
			new EntityItem("CaveSpider", "CaveSpider", "minecraft:cave_spider", true, EntityCategory.MOB),
			new EntityItem("Chicken", "Chicken", "minecraft:chicken", true, EntityCategory.MOB),
			new EntityItem("Cow", "Cow", "minecraft:cow", true, EntityCategory.MOB),
			new EntityItem("Creeper", "Creeper", "minecraft:creeper", true, EntityCategory.MOB),
			new EntityItem("ElderGuardian", "ElderGuardian", "minecraft:elder_guardian", true, EntityCategory.MOB),
			new EntityItem("EnderDragon", "EnderDragon", "minecraft:ender_dragon", true, EntityCategory.MOB),
			new EntityItem("Enderman", "Enderman", "minecraft:enderman", true, EntityCategory.MOB),
			new EntityItem("Endermite", "Endermite", "minecraft:endermite", true, EntityCategory.MOB),
			new EntityItem("Evoker", "Evoker", "minecraft:evocation_illager", true, EntityCategory.MOB),
			new EntityItem("EntityHorse", "EntityHorse", "minecraft:horse", true, EntityCategory.MOB, 0),
			new EntityItem("EntityHorse", "Donkey", "minecraft:donkey", true, EntityCategory.MOB, 1),
			new EntityItem("EntityHorse", "Mule", "minecraft:mule", true, EntityCategory.MOB, 2),
			new EntityItem("EntityHorse", "ZombieHorse", "minecraft:zombie_horse", true, EntityCategory.MOB, 3),
			new EntityItem("EntityHorse", "SkeletonHorse", "minecraft:skeleton_horse", true, EntityCategory.MOB, 4),
			new EntityItem("Ghast", "Ghast", "minecraft:ghast", true, EntityCategory.MOB),
			new EntityItem("Giant", "Giant", "minecraft:giant", true, EntityCategory.MOB),
			new EntityItem("Guardian", "Guardian", "minecraft:guardian", true, EntityCategory.MOB),
			new EntityItem("Husk", "Husk", "minecraft:husk", true, EntityCategory.MOB),
			new EntityItem("Illusioner", "Illusioner", "minecraft:illusion_illager", true, EntityCategory.MOB),
			new EntityItem("LavaSlime", "LavaSlime", "minecraft:lava_slime", true, EntityCategory.MOB),
			new EntityItem("Llama", "Llama", "minecraft:llama", true, EntityCategory.MOB),
			new EntityItem("MagmaCube", "MagmaCube", "minecraft:magma_cube", true, EntityCategory.MOB),
			new EntityItem("MushroomCow", "MushroomCow", "minecraft:mooshroom", true, EntityCategory.MOB),
			new EntityItem("Ozelot", "Ozelot", "minecraft:ozelot", true, EntityCategory.MOB),
			new EntityItem("Parrot", "Parrot", "minecraft:parrot", true, EntityCategory.MOB),
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
			new EntityItem("Vex", "Vex", "minecraft:vex", true, EntityCategory.MOB),
			new EntityItem("Villager", "Villager", "minecraft:villager", true, EntityCategory.MOB),
			new EntityItem("VillagerGolem", "VillagerGolem", "minecraft:villager_golem", true, EntityCategory.MOB),
			new EntityItem("Vindicator", "Vindicator", "minecraft:vindication_illager", true, EntityCategory.MOB),
			new EntityItem("Witch", "Witch", "minecraft:witch", true, EntityCategory.MOB),
			new EntityItem("WitherBoss", "WitherBoss", "minecraft:wither_boss", true, EntityCategory.MOB),
			new EntityItem("Wolf", "Wolf", "minecraft:wolf", true, EntityCategory.MOB),
			new EntityItem("Zombie", "Zombie", "minecraft:zombie", true, EntityCategory.MOB),
			new EntityItem("ZombieVillager", "ZombieVillager", "minecraft:zombie_villager", true, EntityCategory.MOB),
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

		// Token: 0x040004EE RID: 1262
		private Dictionary<string, EntityItem> dictionary_0;

		// Token: 0x040004EF RID: 1263
		private Dictionary<string, EntityItem> dictionary_1;

		// Token: 0x040004F0 RID: 1264
		private Dictionary<int, string> dictionary_2;
	}
}
