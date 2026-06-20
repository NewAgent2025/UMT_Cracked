using System;
using System.Collections.Generic;

namespace UMT_PC_To_Console_Convertor.model
{
	// Token: 0x0200006D RID: 109
	public static class AttributeLookup
	{
		// Token: 0x04000352 RID: 850
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

		// Token: 0x04000353 RID: 851
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
