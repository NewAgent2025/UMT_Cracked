using System;
using System.Drawing;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x02000074 RID: 116
	public class InventoryItem
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00004C16 File Offset: 0x00002E16
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00004C1E File Offset: 0x00002E1E
		public InventoryItem Tag
		{
			get
			{
				return this.inventoryItem_0;
			}
			set
			{
				this.inventoryItem_0 = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00004C27 File Offset: 0x00002E27
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00004C2F File Offset: 0x00002E2F
		public short ID
		{
			get
			{
				return this.short_0;
			}
			set
			{
				this.short_0 = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00004C38 File Offset: 0x00002E38
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00004C40 File Offset: 0x00002E40
		public Image Image
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00004C49 File Offset: 0x00002E49
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00004C51 File Offset: 0x00002E51
		public byte Slot
		{
			get
			{
				return this.byte_0;
			}
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00004C5A File Offset: 0x00002E5A
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004C62 File Offset: 0x00002E62
		public byte Count
		{
			get
			{
				return this.byte_1;
			}
			set
			{
				this.byte_1 = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00004C6B File Offset: 0x00002E6B
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004C73 File Offset: 0x00002E73
		public short Damage
		{
			get
			{
				return this.short_1;
			}
			set
			{
				this.short_1 = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00004C7C File Offset: 0x00002E7C
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004C84 File Offset: 0x00002E84
		public short MaxDamage
		{
			get
			{
				return this.short_2;
			}
			set
			{
				this.short_2 = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00004C8D File Offset: 0x00002E8D
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004C95 File Offset: 0x00002E95
		public bool Alternative
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00004C9E File Offset: 0x00002E9E
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004CA6 File Offset: 0x00002EA6
		public byte Stack
		{
			get
			{
				return this.byte_2;
			}
			set
			{
				this.byte_2 = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00004CAF File Offset: 0x00002EAF
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00004CB7 File Offset: 0x00002EB7
		public bool Enchanted
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00004998 File Offset: 0x00002B98
		public bool Known
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000024C1 File Offset: 0x000006C1
		public InventoryItem()
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000024C1 File Offset: 0x000006C1
		public InventoryItem(InventoryItem item)
		{
		}

		// Token: 0x0400036C RID: 876
		private short short_0;

		// Token: 0x0400036D RID: 877
		private Image image_0;

		// Token: 0x0400036E RID: 878
		private byte byte_0;

		// Token: 0x0400036F RID: 879
		private byte byte_1;

		// Token: 0x04000370 RID: 880
		private short short_1;

		// Token: 0x04000371 RID: 881
		private short short_2;

		// Token: 0x04000372 RID: 882
		private bool bool_0;

		// Token: 0x04000373 RID: 883
		private byte byte_2;

		// Token: 0x04000374 RID: 884
		private bool bool_1;

		// Token: 0x04000375 RID: 885
		private InventoryItem inventoryItem_0;
	}
}
