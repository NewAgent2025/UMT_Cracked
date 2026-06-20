using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000D8 RID: 216
	public class TileEntityLookup
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00006C91 File Offset: 0x00004E91
		public TileEntityLookup()
		{
			this.method_0();
			this.method_1();
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00006CA5 File Offset: 0x00004EA5
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00006CAD File Offset: 0x00004EAD
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00006CB6 File Offset: 0x00004EB6
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00006CBE File Offset: 0x00004EBE
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

		// Token: 0x0600095C RID: 2396 RVA: 0x00047208 File Offset: 0x00045408
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
				if (!this.dictionary_0.ContainsKey(tileEntityItem.PCName.Replace("minecraft:", string.Empty)))
				{
					this.dictionary_0.Add(tileEntityItem.PCName.Replace("minecraft:", string.Empty), tileEntityItem);
				}
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000472F4 File Offset: 0x000454F4
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00006CC7 File Offset: 0x00004EC7
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00006CCE File Offset: 0x00004ECE
		public static Dictionary<string, string> BedrockToJava
		{
			get
			{
				return TileEntityLookup.dictionary_2;
			}
			set
			{
				TileEntityLookup.dictionary_2 = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00006CD6 File Offset: 0x00004ED6
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00006CDD File Offset: 0x00004EDD
		public static Dictionary<string, string> Names
		{
			get
			{
				return TileEntityLookup.dictionary_4;
			}
			set
			{
				TileEntityLookup.dictionary_4 = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00006CE5 File Offset: 0x00004EE5
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00006CEC File Offset: 0x00004EEC
		public static Dictionary<string, string> BedrockNames
		{
			get
			{
				return TileEntityLookup.dictionary_5;
			}
			set
			{
				TileEntityLookup.dictionary_5 = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00006CF4 File Offset: 0x00004EF4
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00006CFB File Offset: 0x00004EFB
		public static Dictionary<string, string> JavaNames
		{
			get
			{
				return TileEntityLookup.dictionary_6;
			}
			set
			{
				TileEntityLookup.dictionary_6 = value;
			}
		}

		// Token: 0x0400063A RID: 1594
		private static List<TileEntityItem> list_0 = new List<TileEntityItem>
		{
			new TileEntityItem(23, "Trap", "Trap", "minecraft:dispenser", "Dispenser"),
			new TileEntityItem(25, "Music", "Music", "minecraft:noteblock", "Noteblock"),
			new TileEntityItem(26, "Bed", "Bed", "minecraft:bed", "Bed"),
			new TileEntityItem(36, "Piston", "Piston", "minecraft:piston", "Piston"),
			new TileEntityItem(52, "MobSpawner", "MobSpawner", "minecraft:mob_spawner", "Mob Spawner"),
			new TileEntityItem(54, "Chest", "Chest", "minecraft:chest", "Chest"),
			new TileEntityItem(61, "Furnace", "Furnace", "minecraft:furnace", "Furnace"),
			new TileEntityItem(62, "Furnace", "Furnace", "minecraft:furnace", "Furnace"),
			new TileEntityItem(63, "Sign", "Sign", "minecraft:sign", "Sign"),
			new TileEntityItem(68, "Sign", "Sign", "minecraft:sign", "Sign"),
			new TileEntityItem(84, "RecordPlayer", "RecordPlayer", "minecraft:jukebox", "Jukebox"),
			new TileEntityItem(116, "EnchantTable", "EnchantTable", "minecraft:enchanting_table", "Enchanting Table"),
			new TileEntityItem(117, "Cauldron", "Cauldron", "minecraft:brewing_stand", "Brewing Stand"),
			new TileEntityItem(118, "Cauldron", "Cauldron", "minecraft:cauldron", "Cauldron"),
			new TileEntityItem(119, "Airportal", "Airportal", "minecraft:end_portal", "End Portal"),
			new TileEntityItem(130, "EnderChest", "EnderChest", "minecraft:ender_chest", "Ender Chest"),
			new TileEntityItem(138, "Beacon", "Beacon", "minecraft:beacon", "Beacon"),
			new TileEntityItem(140, "FlowerPot", "FlowerPot", "minecraft:flower_pot", "Flower Pot"),
			new TileEntityItem(144, "Skull", "Skull", "minecraft:skull", "Skull"),
			new TileEntityItem(146, "Chest", "Chest", "minecraft:trapped_chest", "Trapped Chest"),
			new TileEntityItem(149, "Comparator", "Comparator", "minecraft:comparator", "Comparator"),
			new TileEntityItem(151, "DLDetector", "DLDetector", "minecraft:daylight_detector", "Daylight Detector"),
			new TileEntityItem(154, "Hopper", "Hopper", "minecraft:hopper", "Hopper"),
			new TileEntityItem(158, "Dropper", "Dropper", "minecraft:dropper", "Dropper"),
			new TileEntityItem(176, "Banner", "Banner", "minecraft:banner", "Banner"),
			new TileEntityItem(177, "Banner", "Banner", "minecraft:banner", "Banner"),
			new TileEntityItem(209, "EndGateway", "EndGateway", "minecraft:end_gateway", "EndGateway")
		};

		// Token: 0x0400063B RID: 1595
		private Dictionary<string, TileEntityItem> dictionary_0;

		// Token: 0x0400063C RID: 1596
		private Dictionary<string, TileEntityItem> dictionary_1;

		// Token: 0x0400063D RID: 1597
		private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>
		{
			{
				"minecraft:banner",
				"0a10006d696e6563726166743a62616e6e6572030100787c01000003010079040000000301007ac1fcffff080200696410006d696e6563726166743a62616e6e6572030400426173650f00000000"
			},
			{
				"minecraft:beacon",
				"0a10006d696e6563726166743a626561636f6e0309005365636f6e64617279000000000307005072696d61727900000000030100787c01000003010079040000000306004c6576656c73000000000301007ac0fcffff080200696410006d696e6563726166743a626561636f6e0804004c6f636b000000"
			},
			{
				"minecraft:bed",
				"0a0d006d696e6563726166743a626564030500636f6c6f7200000000030100787b01000003010079040000000301007abffcffff08020069640d006d696e6563726166743a62656400"
			},
			{
				"minecraft:brewing_stand",
				"0a17006d696e6563726166743a62726577696e675f7374616e640104004675656c00030100787c01000003010079040000000301007abefcffff0905004974656d730100000000080200696417006d696e6563726166743a62726577696e675f7374616e640208004272657754696d6500000804004c6f636b000000"
			},
			{
				"minecraft:chest",
				"0a0f006d696e6563726166743a6368657374030100787c01000003010079040000000301007abcfcffff0905004974656d73010000000008020069640f006d696e6563726166743a63686573740804004c6f636b000000"
			},
			{
				"minecraft:comparator",
				"0a14006d696e6563726166743a636f6d70617261746f72030100787c01000003010079040000000301007ab9fcffff080200696414006d696e6563726166743a636f6d70617261746f72030c004f75747075745369676e616c0000000000"
			},
			{
				"minecraft:daylight_detector",
				"0a1b006d696e6563726166743a6461796c696768745f6465746563746f72030100787f01000003010079040000000301007ac1fcffff08020069641b006d696e6563726166743a6461796c696768745f6465746563746f7200"
			},
			{
				"minecraft:dispenser",
				"0a13006d696e6563726166743a64697370656e736572030100787f01000003010079040000000301007ac0fcffff0905004974656d730100000000080200696413006d696e6563726166743a64697370656e7365720804004c6f636b000000"
			},
			{
				"minecraft:dropper",
				"0a11006d696e6563726166743a64726f70706572030100787f01000003010079040000000301007abffcffff0905004974656d730100000000080200696411006d696e6563726166743a64726f707065720804004c6f636b000000"
			},
			{
				"minecraft:enchanting_table",
				"0a1a006d696e6563726166743a656e6368616e74696e675f7461626c65030100787f01000003010079040000000301007abefcffff08020069641a006d696e6563726166743a656e6368616e74696e675f7461626c6500"
			},
			{
				"minecraft:ender_chest",
				"0a15006d696e6563726166743a656e6465725f6368657374030100787c01000003010079040000000301007abafcffff080200696415006d696e6563726166743a656e6465725f636865737400"
			},
			{
				"minecraft:furnace",
				"0a11006d696e6563726166743a6675726e616365020800436f6f6b54696d650000030100787f0100000208004275726e54696d65000003010079040000000301007abdfcffff0905004974656d730100000000080200696411006d696e6563726166743a6675726e616365020d00436f6f6b54696d65546f74616c00000804004c6f636b000000"
			},
			{
				"minecraft:hopper",
				"0a10006d696e6563726166743a686f707065720310005472616e73666572436f6f6c646f776e00000000030100787f01000003010079040000000301007abcfcffff0905004974656d730100000000080200696410006d696e6563726166743a686f707065720804004c6f636b000000"
			},
			{
				"minecraft:jukebox",
				"0a11006d696e6563726166743a6a756b65626f78030100787f01000003010079040000000301007abbfcffff080200696411006d696e6563726166743a6a756b65626f7800"
			},
			{
				"minecraft:mob_spawner",
				"0a15006d696e6563726166743a6d6f625f737061776e65720211004d61784e6561726279456e74697469657306000213005265717569726564506c6179657252616e67651000020a00537061776e436f756e7404000a0900537061776e4461746108020069640d006d696e6563726166743a70696700020d004d6178537061776e44656c6179200302050044656c61790000030100788501000003010079040000000301007abbfcffff080200696415006d696e6563726166743a6d6f625f737061776e6572020a00537061776e52616e67650400020d004d696e537061776e44656c6179c800090f00537061776e506f74656e7469616c730a010000000a0600456e7469747908020069640d006d696e6563726166743a70696700030600576569676874010000000000"
			},
			{
				"minecraft:shulker_box",
				"0a15006d696e6563726166743a7368756c6b65725f626f78030100788201000003010079040000000301007ac1fcffff080200696415006d696e6563726166743a7368756c6b65725f626f780804004c6f636b000000"
			},
			{
				"minecraft:sign",
				"0a0e006d696e6563726166743a7369676e030100788201000008050054657874340b007b2274657874223a22227d030100790400000008050054657874330b007b2274657874223a22227d0301007ac0fcffff08050054657874320b007b2274657874223a22227d08020069640e006d696e6563726166743a7369676e08050054657874310b007b2274657874223a22227d00"
			},
			{
				"minecraft:skull",
				"0a0f006d696e6563726166743a736b756c6c010300526f7400030100788601000003010079040000000301007abefcffff08020069640f006d696e6563726166743a736b756c6c010900536b756c6c547970650000"
			},
			{
				"Chest",
				"0a0f006d696e6563726166743a636865737403010078d7faffff03010079040000000301007a29feffff0905004974656d73010000000008020069640f006d696e6563726166743a63686573740804004c6f636b000000"
			},
			{
				"Sign",
				"0a0e006d696e6563726166743a7369676e03010078d5faffff08050054657874340f007b2274657874223a2254657374227d030100790400000008050054657874330f007b2274657874223a2254657374227d0301007a29feffff08050054657874320f007b2274657874223a2254657374227d08020069640e006d696e6563726166743a7369676e08050054657874310f007b2274657874223a2254657374227d00"
			}
		};

		// Token: 0x0400063E RID: 1598
		private static Dictionary<string, string> dictionary_3 = new Dictionary<string, string>
		{
			{
				"minecraft:banner",
				"0a10006d696e6563726166743a62616e6e6572010a006b6565705061636b656400030100780000000003010079040000000301007a02000000080200696410006d696e6563726166743a62616e6e65720908005061747465726e73010000000000"
			},
			{
				"minecraft:beacon",
				"0a10006d696e6563726166743a626561636f6e0309005365636f6e6461727900000000010a006b6565705061636b6564000307005072696d6172790000000003010078ffffffff03010079040000000306004c6576656c73000000000301007a02000000080200696410006d696e6563726166743a626561636f6e0804004c6f636b000000"
			},
			{
				"minecraft:bed",
				"0a0d006d696e6563726166743a626564010a006b6565705061636b65640003010078feffffff03010079040000000301007a0300000008020069640d006d696e6563726166743a62656400"
			},
			{
				"minecraft:brewing_stand",
				"0a17006d696e6563726166743a62726577696e675f7374616e64010a006b6565705061636b6564000104004675656c0003010078fdffffff03010079040000000301007a020000000905004974656d730100000000080200696417006d696e6563726166743a62726577696e675f7374616e640208004272657754696d6500000804004c6f636b000000"
			},
			{
				"minecraft:chest",
				"0a0f006d696e6563726166743a6368657374010a006b6565705061636b65640003010078fbffffff03010079040000000301007a020000000905004974656d73010000000008020069640f006d696e6563726166743a63686573740804004c6f636b000000"
			},
			{
				"minecraft:comparator",
				"0a14006d696e6563726166743a636f6d70617261746f72010a006b6565705061636b65640003010078f8ffffff03010079040000000301007a02000000080200696414006d696e6563726166743a636f6d70617261746f72030c004f75747075745369676e616c0000000000"
			},
			{
				"minecraft:conduit",
				"0a11006d696e6563726166743a636f6e64756974010a006b6565705061636b656400030100780000000003010079040000000301007affffffff080200696411006d696e6563726166743a636f6e6475697400"
			},
			{
				"minecraft:daylight_detector",
				"0a1b006d696e6563726166743a6461796c696768745f6465746563746f72010a006b6565705061636b65640003010078ffffffff03010079040000000301007affffffff08020069641b006d696e6563726166743a6461796c696768745f6465746563746f7200"
			},
			{
				"minecraft:dispenser",
				"0a13006d696e6563726166743a64697370656e736572010a006b6565705061636b65640003010078feffffff03010079040000000301007affffffff0905004974656d730100000000080200696413006d696e6563726166743a64697370656e7365720804004c6f636b000000"
			},
			{
				"minecraft:dropper",
				"0a11006d696e6563726166743a64726f70706572010a006b6565705061636b65640003010078fdffffff03010079040000000301007affffffff0905004974656d730100000000080200696411006d696e6563726166743a64726f707065720804004c6f636b000000"
			},
			{
				"minecraft:enchanting_table",
				"0a1a006d696e6563726166743a656e6368616e74696e675f7461626c65010a006b6565705061636b65640003010078fcffffff03010079040000000301007affffffff08020069641a006d696e6563726166743a656e6368616e74696e675f7461626c6500"
			},
			{
				"minecraft:ender_chest",
				"0a15006d696e6563726166743a656e6465725f6368657374010a006b6565705061636b65640003010078f9ffffff03010079040000000301007a02000000080200696415006d696e6563726166743a656e6465725f636865737400"
			},
			{
				"minecraft:furnace",
				"0a11006d696e6563726166743a6675726e616365020800436f6f6b54696d650000010a006b6565705061636b65640003010078fbffffff0208004275726e54696d65000003010079040000000301007affffffff0905004974656d730100000000020f00526563697065735573656453697a650000080200696411006d696e6563726166743a6675726e616365020d00436f6f6b54696d65546f74616c00000804004c6f636b000000"
			},
			{
				"minecraft:hopper",
				"0a10006d696e6563726166743a686f707065720310005472616e73666572436f6f6c646f776e00000000010a006b6565705061636b65640003010078faffffff03010079040000000301007affffffff0905004974656d730100000000080200696410006d696e6563726166743a686f707065720804004c6f636b000000"
			},
			{
				"minecraft:jukebox",
				"0a11006d696e6563726166743a6a756b65626f78010a006b6565705061636b65640003010078f9ffffff03010079040000000301007affffffff080200696411006d696e6563726166743a6a756b65626f7800"
			},
			{
				"minecraft:shulker_box",
				"0a15006d696e6563726166743a7368756c6b65725f626f78010a006b6565705061636b65640003010078feffffff03010079040000000301007afcffffff080200696415006d696e6563726166743a7368756c6b65725f626f780804004c6f636b000000"
			},
			{
				"minecraft:sign",
				"0a0e006d696e6563726166743a7369676e010a006b6565705061636b65640003010078fdffffff08050054657874340b007b2274657874223a22227d030100790400000008050054657874330b007b2274657874223a22227d0301007afcffffff08050054657874320b007b2274657874223a22227d08020069640e006d696e6563726166743a7369676e08050054657874310b007b2274657874223a22227d00"
			},
			{
				"minecraft:skull",
				"0a0f006d696e6563726166743a736b756c6c010a006b6565705061636b65640003010078fbffffff03010079040000000301007afcffffff08020069640f006d696e6563726166743a736b756c6c00"
			},
			{
				"minecraft:trapped_chest",
				"0a17006d696e6563726166743a747261707065645f6368657374010a006b6565705061636b65640003010078faffffff03010079040000000301007a020000000905004974656d730100000000080200696417006d696e6563726166743a747261707065645f63686573740804004c6f636b000000"
			},
			{
				"Chest",
				"0a0f006d696e6563726166743a636865737403010078d7faffff03010079040000000301007a29feffff0905004974656d73010000000008020069640f006d696e6563726166743a63686573740804004c6f636b000000"
			},
			{
				"Sign",
				"0a0e006d696e6563726166743a7369676e03010078d5faffff08050054657874340f007b2274657874223a2254657374227d030100790400000008050054657874330f007b2274657874223a2254657374227d0301007a29feffff08050054657874320f007b2274657874223a2254657374227d08020069640e006d696e6563726166743a7369676e08050054657874310f007b2274657874223a2254657374227d00"
			}
		};

		// Token: 0x0400063F RID: 1599
		private static Dictionary<string, string> dictionary_4 = new Dictionary<string, string>
		{
			{
				"banner",
				"minecraft:banner"
			},
			{
				"minecraft:banner",
				"minecraft:banner"
			},
			{
				"Banner",
				"minecraft:banner"
			},
			{
				"beacon",
				"minecraft:beacon"
			},
			{
				"minecraft:beacon",
				"minecraft:beacon"
			},
			{
				"Beacon",
				"minecraft:beacon"
			},
			{
				"bed",
				"minecraft:bed"
			},
			{
				"minecraft:bed",
				"minecraft:bed"
			},
			{
				"Bed",
				"minecraft:bed"
			},
			{
				"cauldron",
				"minecraft:cauldron"
			},
			{
				"minecraft:cauldron",
				"minecraft:cauldron"
			},
			{
				"Cauldron",
				"minecraft:cauldron"
			},
			{
				"brewing_stand",
				"minecraft:brewing_stand"
			},
			{
				"minecraft:brewing_stand",
				"minecraft:brewing_stand"
			},
			{
				"BrewingStand",
				"minecraft:brewing_stand"
			},
			{
				"chest",
				"minecraft:chest"
			},
			{
				"minecraft:chest",
				"minecraft:chest"
			},
			{
				"Chest",
				"minecraft:chest"
			},
			{
				"comparator",
				"minecraft:comparator"
			},
			{
				"minecraft:comparator",
				"minecraft:comparator"
			},
			{
				"Comparator",
				"minecraft:comparator"
			},
			{
				"command_block",
				"minecraft:command_block"
			},
			{
				"minecraft:command_block",
				"minecraft:command_block"
			},
			{
				"CommandBlock",
				"minecraft:command_block"
			},
			{
				"Control",
				"minecraft:command_block"
			},
			{
				"daylight_detector",
				"minecraft:daylight_detector"
			},
			{
				"minecraft:daylight_detector",
				"minecraft:daylight_detector"
			},
			{
				"DaylightDetector",
				"minecraft:daylight_detector"
			},
			{
				"DLDetector",
				"minecraft:daylight_detector"
			},
			{
				"dispenser",
				"minecraft:dispenser"
			},
			{
				"minecraft:dispenser",
				"minecraft:dispenser"
			},
			{
				"Dispenser",
				"minecraft:dispenser"
			},
			{
				"dropper",
				"minecraft:dropper"
			},
			{
				"minecraft:dropper",
				"minecraft:dropper"
			},
			{
				"Dropper",
				"minecraft:dropper"
			},
			{
				"enchanting_table",
				"minecraft:enchanting_table"
			},
			{
				"minecraft:enchanting_table",
				"minecraft:enchanting_table"
			},
			{
				"EnchantTable",
				"minecraft:enchanting_table"
			},
			{
				"ender_chest",
				"minecraft:ender_chest"
			},
			{
				"minecraft:ender_chest",
				"minecraft:ender_chest"
			},
			{
				"EnderChest",
				"minecraft:ender_chest"
			},
			{
				"end_gateway",
				"minecraft:end_gateway"
			},
			{
				"minecraft:end_gateway",
				"minecraft:end_gateway"
			},
			{
				"EndGateway",
				"minecraft:end_gateway"
			},
			{
				"end_portal",
				"minecraft:end_portal"
			},
			{
				"minecraft:end_portal",
				"minecraft:end_portal"
			},
			{
				"EndPortal",
				"minecraft:end_portal"
			},
			{
				"flower_pot",
				"minecraft:flower_pot"
			},
			{
				"minecraft:flower_pot",
				"minecraft:flower_pot"
			},
			{
				"FlowerPot",
				"minecraft:flower_pot"
			},
			{
				"furnace",
				"minecraft:furnace"
			},
			{
				"minecraft:furnace",
				"minecraft:furnace"
			},
			{
				"Furnace",
				"minecraft:furnace"
			},
			{
				"hopper",
				"minecraft:hopper"
			},
			{
				"minecraft:hopper",
				"minecraft:hopper"
			},
			{
				"Hopper",
				"minecraft:hopper"
			},
			{
				"jukebox",
				"minecraft:jukebox"
			},
			{
				"minecraft:jukebox",
				"minecraft:jukebox"
			},
			{
				"Jukebox",
				"minecraft:jukebox"
			},
			{
				"RecordPlayer",
				"minecraft:jukebox"
			},
			{
				"mob_spawner",
				"minecraft:mob_spawner"
			},
			{
				"minecraft:mob_spawner",
				"minecraft:mob_spawner"
			},
			{
				"MobSpawner",
				"minecraft:mob_spawner"
			},
			{
				"noteblock",
				"minecraft:noteblock"
			},
			{
				"minecraft:noteblock",
				"minecraft:noteblock"
			},
			{
				"Music",
				"minecraft:noteblock"
			},
			{
				"piston",
				"minecraft:piston"
			},
			{
				"minecraft:piston",
				"minecraft:piston"
			},
			{
				"PistonArm",
				"minecraft:piston_arm"
			},
			{
				"MovingBlock",
				"minecraft:moving_block"
			},
			{
				"sign",
				"minecraft:sign"
			},
			{
				"minecraft:sign",
				"minecraft:sign"
			},
			{
				"Sign",
				"minecraft:sign"
			},
			{
				"skull",
				"minecraft:skull"
			},
			{
				"minecraft:skull",
				"minecraft:skull"
			},
			{
				"Skull",
				"minecraft:skull"
			},
			{
				"structure_block",
				"minecraft:structure_block"
			},
			{
				"minecraft:structure_block",
				"minecraft:structure_block"
			},
			{
				"StructureBlock",
				"minecraft:structure_block"
			},
			{
				"Structure",
				"minecraft:structure_block"
			},
			{
				"shulker_box",
				"minecraft:shulker_box"
			},
			{
				"minecraft:shulker_box",
				"minecraft:shulker_box"
			},
			{
				"ShulkerBox",
				"minecraft:shulker_box"
			},
			{
				"minecraft:trapped_chest",
				"minecraft:trapped_chest"
			},
			{
				"Trap",
				"minecraft:trapped_chest"
			},
			{
				"Trapped Chest",
				"minecraft:trapped_chest"
			},
			{
				"ChalkboardBlock",
				"minecraft:chalk_board_block"
			},
			{
				"NetherReactor",
				"minecraft:nether_reactor"
			},
			{
				"conduit",
				"minecraft:conduit"
			},
			{
				"minecraft:conduit",
				"minecraft:conduit"
			}
		};

		// Token: 0x04000640 RID: 1600
		private static Dictionary<string, string> dictionary_5 = new Dictionary<string, string>
		{
			{
				"minecraft:banner",
				"Banner"
			},
			{
				"minecraft:beacon",
				"Beacon"
			},
			{
				"minecraft:bed",
				"Bed"
			},
			{
				"minecraft:cauldron",
				"Cauldron"
			},
			{
				"minecraft:brewing_stand",
				"BrewingStand"
			},
			{
				"minecraft:chest",
				"Chest"
			},
			{
				"minecraft:comparator",
				"Comparator"
			},
			{
				"minecraft:command_block",
				"CommandBlock"
			},
			{
				"minecraft:daylight_detector",
				"DaylightDetector"
			},
			{
				"minecraft:dispenser",
				"Dispenser"
			},
			{
				"minecraft:dropper",
				"Dropper"
			},
			{
				"minecraft:enchanting_table",
				"EnchantTable"
			},
			{
				"minecraft:ender_chest",
				"EnderChest"
			},
			{
				"minecraft:end_gateway",
				"EndGateway"
			},
			{
				"minecraft:end_portal",
				"EndPortal"
			},
			{
				"minecraft:flower_pot",
				"FlowerPot"
			},
			{
				"minecraft:furnace",
				"Furnace"
			},
			{
				"minecraft:hopper",
				"Hopper"
			},
			{
				"minecraft:jukebox",
				"Jukebox"
			},
			{
				"minecraft:mob_spawner",
				"MobSpawner"
			},
			{
				"minecraft:noteblock",
				"Music"
			},
			{
				"minecraft:piston",
				null
			},
			{
				"minecraft:piston_arm",
				"PistonArm"
			},
			{
				"minecraft:moving_block",
				"MovingBlock"
			},
			{
				"minecraft:sign",
				"Sign"
			},
			{
				"minecraft:skull",
				"Skull"
			},
			{
				"minecraft:structure_block",
				"StructureBlock"
			},
			{
				"minecraft:shulker_box",
				"ShulkerBox"
			},
			{
				"minecraft:trapped_chest",
				"Chest"
			},
			{
				"minecraft:chalk_board_block",
				"ChalkboardBlock"
			},
			{
				"minecraft:nether_reactor",
				"NetherReactor"
			},
			{
				"minecraft:conduit",
				"Conduit"
			}
		};

		// Token: 0x04000641 RID: 1601
		private static Dictionary<string, string> dictionary_6 = new Dictionary<string, string>
		{
			{
				"minecraft:banner",
				"minecraft:banner"
			},
			{
				"minecraft:beacon",
				"minecraft:beacon"
			},
			{
				"minecraft:bed",
				"minecraft:bed"
			},
			{
				"minecraft:cauldron",
				"minecraft:cauldron"
			},
			{
				"minecraft:brewing_stand",
				"minecraft:brewing_stand"
			},
			{
				"minecraft:chest",
				"minecraft:chest"
			},
			{
				"minecraft:comparator",
				"minecraft:comparator"
			},
			{
				"minecraft:command_block",
				"minecraft:command_block"
			},
			{
				"minecraft:daylight_detector",
				"minecraft:daylight_detector"
			},
			{
				"minecraft:dispenser",
				"minecraft:dispenser"
			},
			{
				"minecraft:dropper",
				"minecraft:dropper"
			},
			{
				"minecraft:enchanting_table",
				"minecraft:enchanting_table"
			},
			{
				"minecraft:ender_chest",
				"minecraft:ender_chest"
			},
			{
				"minecraft:end_gateway",
				"minecraft:end_gateway"
			},
			{
				"minecraft:end_portal",
				"minecraft:end_portal"
			},
			{
				"minecraft:flower_pot",
				"minecraft:flower_pot"
			},
			{
				"minecraft:furnace",
				"minecraft:furnace"
			},
			{
				"minecraft:hopper",
				"minecraft:hopper"
			},
			{
				"minecraft:jukebox",
				"minecraft:jukebox"
			},
			{
				"minecraft:mob_spawner",
				"minecraft:mob_spawner"
			},
			{
				"minecraft:noteblock",
				"minecraft:noteblock"
			},
			{
				"minecraft:piston",
				"minecraft:piston"
			},
			{
				"minecraft:piston_arm",
				null
			},
			{
				"minecraft:moving_block",
				null
			},
			{
				"minecraft:sign",
				"minecraft:sign"
			},
			{
				"minecraft:skull",
				"minecraft:skull"
			},
			{
				"minecraft:structure_block",
				"minecraft:structure_block"
			},
			{
				"minecraft:shulker_box",
				"minecraft:shulker_box"
			},
			{
				"minecraft:trapped_chest",
				"minecraft:trapped_chest"
			},
			{
				"minecraft:chalk_board_block",
				null
			},
			{
				"minecraft:nether_reactor",
				null
			},
			{
				"conduit",
				"minecraft:conduit"
			},
			{
				"minecraft:conduit",
				"minecraft:conduit"
			}
		};
	}
}
