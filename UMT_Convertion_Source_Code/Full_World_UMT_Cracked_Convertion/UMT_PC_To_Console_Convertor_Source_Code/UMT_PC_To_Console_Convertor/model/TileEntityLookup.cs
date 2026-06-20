using System;
using System.Collections.Generic;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000094 RID: 148
	public class TileEntityLookup
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00005ABE File Offset: 0x00003CBE
		public TileEntityLookup()
		{
			this.method_0();
			this.method_1();
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00005AD2 File Offset: 0x00003CD2
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00005ADA File Offset: 0x00003CDA
		public Dictionary<string, TileEntityItem> Dictionary_0
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00005AE3 File Offset: 0x00003CE3
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00005AEB File Offset: 0x00003CEB
		public Dictionary<string, TileEntityItem> ConsoleEntities
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

		// Token: 0x0600068E RID: 1678 RVA: 0x0002A700 File Offset: 0x00028900
		private void method_0()
		{
			this.dictionary_0 = new Dictionary<string, TileEntityItem>();
			foreach (TileEntityItem tileEntityItem in TileEntityLookup.list_0)
			{
				if (!this.dictionary_0.ContainsKey(tileEntityItem.String_0))
				{
					this.dictionary_0.Add(tileEntityItem.String_0, tileEntityItem);
				}
				if (!this.dictionary_0.ContainsKey(tileEntityItem.PCName))
				{
					this.dictionary_0.Add(tileEntityItem.PCName, tileEntityItem);
				}
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002A7A4 File Offset: 0x000289A4
		private void method_1()
		{
			this.dictionary_1 = new Dictionary<string, TileEntityItem>();
			foreach (TileEntityItem tileEntityItem in TileEntityLookup.list_0)
			{
				if (!this.dictionary_1.ContainsKey(tileEntityItem.ConsoleName))
				{
					this.dictionary_1.Add(tileEntityItem.ConsoleName, tileEntityItem);
				}
			}
		}

		// Token: 0x04000412 RID: 1042
		private static List<TileEntityItem> list_0 = new List<TileEntityItem>
		{
			new TileEntityItem(23, "Trap", "Trap", "minecraft:dispenser"),
			new TileEntityItem(25, "Music", "Music", "minecraft:noteblock"),
			new TileEntityItem(36, "Piston", "Piston", "minecraft:piston"),
			new TileEntityItem(52, "MobSpawner", "MobSpawner", "minecraft:mob_spawner"),
			new TileEntityItem(54, "Chest", "Chest", "minecraft:chest"),
			new TileEntityItem(61, "Furnace", "Furnace", "minecraft:furnace"),
			new TileEntityItem(62, "Furnace", "Furnace", "minecraft:furnace"),
			new TileEntityItem(63, "Sign", "Sign", "minecraft:sign"),
			new TileEntityItem(68, "Sign", "Sign", "minecraft:sign"),
			new TileEntityItem(84, "RecordPlayer", "RecordPlayer", "minecraft:jukebox"),
			new TileEntityItem(116, "EnchantTable", "EnchantTable", "minecraft:enchanting_table"),
			new TileEntityItem(117, "Cauldron", "Cauldron", "minecraft:brewing_stand"),
			new TileEntityItem(118, "Cauldron", "Cauldron", "minecraft:cauldron"),
			new TileEntityItem(119, "Airportal", "Airportal", "minecraft:airportal"),
			new TileEntityItem(130, "EnderChest", "EnderChest", "minecraft:ender_chest"),
			new TileEntityItem(138, "Beacon", "Beacon", "minecraft:beacon"),
			new TileEntityItem(140, "FlowerPot", "FlowerPot", "minecraft:flower_pot"),
			new TileEntityItem(144, "Skull", "Skull", "minecraft:skull"),
			new TileEntityItem(146, "Chest", "Chest", "minecraft:chest"),
			new TileEntityItem(149, "Comparator", "Comparator", "minecraft:comparator"),
			new TileEntityItem(151, "DLDetector", "DLDetector", "minecraft:daylight_detector"),
			new TileEntityItem(154, "Hopper", "Hopper", "minecraft:hopper"),
			new TileEntityItem(158, "Dropper", "Dropper", "minecraft:dropper"),
			new TileEntityItem(176, "Banner", "Banner", "minecraft:banner"),
			new TileEntityItem(177, "Banner", "Banner", "minecraft:banner"),
			new TileEntityItem(209, "EndGateway", "EndGateway", "minecraft:end_gateway")
		};

		// Token: 0x04000413 RID: 1043
		private Dictionary<string, TileEntityItem> dictionary_0;

		// Token: 0x04000414 RID: 1044
		private Dictionary<string, TileEntityItem> dictionary_1;
	}
}
