using System;
using System.Collections.Generic;

namespace Full_UMT_Convertor.model
{
	// Token: 0x020000A0 RID: 160
	public static class AttributeLookup
	{
		// Token: 0x040004CD RID: 1229
		public static Dictionary<string, int> attributesByName = new Dictionary<string, int>
		{
			{
				"generic.maxHealth",
				0
			},
			{
				"generic.followRange",
				1
			},
			{
				"generic.knockbackResistance",
				2
			},
			{
				"generic.movementSpeed",
				3
			},
			{
				"generic.attackDamage",
				4
			},
			{
				"horse.jumpStrength",
				5
			},
			{
				"zombie.spawnReinforcements",
				6
			}
		};

		// Token: 0x040004CE RID: 1230
		public static Dictionary<int, string> attributesById = new Dictionary<int, string>
		{
			{
				0,
				"generic.maxHealth"
			},
			{
				1,
				"generic.followRange"
			},
			{
				2,
				"generic.knockbackResistance"
			},
			{
				3,
				"generic.movementSpeed"
			},
			{
				4,
				"generic.attackDamage"
			},
			{
				5,
				"horse.jumpStrength"
			},
			{
				6,
				"zombie.spawnReinforcements"
			}
		};
	}
}
