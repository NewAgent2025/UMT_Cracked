using System;
using System.Collections.Generic;
using System.Linq;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.utils;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x02000021 RID: 33
	public class JavaChestConnections
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000EB90 File Offset: 0x0000CD90
		public void CreateChestsList(object threadContext)
		{
			ChestConnectioExtractnParameters chestConnectioExtractnParameters = threadContext as ChestConnectioExtractnParameters;
			Dictionary<int, MCCoordinate> dictionary = new Dictionary<int, MCCoordinate>();
			if (chestConnectioExtractnParameters != null)
			{
				this.chestConnectioExtractnParameters_0 = chestConnectioExtractnParameters;
				foreach (Class40 @class in chestConnectioExtractnParameters.PeRegion.method_0().Values)
				{
					if (@class.method_0().ContainsKey(49))
					{
						TagNodeList tagNodeList = PEUtility.ExtractTileEntities(@class.method_0()[49]);
						for (int i = 0; i < tagNodeList.Count; i++)
						{
							TagNodeCompound tagNodeCompound = tagNodeList[i] as TagNodeCompound;
							if (tagNodeCompound.ContainsKey("id") && (TagNodeString)tagNodeCompound["id"] == "Chest")
							{
								int num = (TagNodeInt)tagNodeCompound["x"];
								int num2 = (TagNodeInt)tagNodeCompound["y"];
								int num3 = (TagNodeInt)tagNodeCompound["z"];
								int val = this.method_0(num, num2, num3, @class);
								MCCoordinate mccoordinate = new MCCoordinate(num, num2, num3, val);
								dictionary.Add(mccoordinate.ToString().GetHashCode(), mccoordinate);
							}
						}
					}
				}
				chestConnectioExtractnParameters.Chests = dictionary;
				chestConnectioExtractnParameters.Done = true;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000ED18 File Offset: 0x0000CF18
		private int method_0(int int_3, int int_4, int int_5, Class40 class40_0)
		{
			int num = this.method_4(int_3, 16);
			int num2 = this.method_4(int_5, 16);
			int result;
			if (!class40_0.method_0().ContainsKey(48) || class40_0.method_2().Count != 0)
			{
				result = this.method_1(num, int_4, num2, class40_0);
			}
			else
			{
				int pos = num * 2048 + num2 * 128 + int_4 + 32768;
				byte[] data = class40_0.method_0()[48];
				result = this.nibbleSetters_0.method_0(data, pos);
			}
			return result;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		private int method_1(int int_3, int int_4, int int_5, Class40 class40_0)
		{
			int result = 0;
			int num = int_4 / 16;
			if (class40_0.method_2().ContainsKey(num))
			{
				byte[] array = class40_0.method_2()[num];
				if (array[0] != 1 && array[0] != 8)
				{
					if (array.Length >= 6145)
					{
						byte[] data = array.Skip(4097).Take(2048).ToArray<byte>();
						int pos = int_3 * 256 + int_5 * 16 + (int_4 - num * 16);
						result = this.nibbleSetters_0.method_0(data, pos);
					}
				}
				else
				{
					if (array[0] != 1)
					{
						if (array[0] != 8)
						{
							return result;
						}
					}
					TagNodeList tagNodeList = PEUtility.BlockStorageSection(array);
					TagNodeCompound tagNodeCompound = tagNodeList[0] as TagNodeCompound;
					List<BlockState> list = this.method_2(tagNodeCompound["Palette"] as TagNodeList);
					int[] data2 = ((TagNodeIntArray)tagNodeCompound["BlockStates"]).Data;
					int num2 = (int_4 - num * 16) * 256 + int_5 * 16 + int_3;
					int index = data2[num2];
					result = (int)list[index].data;
				}
			}
			return result;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		private List<BlockState> method_2(TagNodeList tagNodeList_0)
		{
			List<BlockState> list = new List<BlockState>();
			for (int i = 0; i < tagNodeList_0.Count; i++)
			{
				TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
				string name = tagNodeCompound["name"] as TagNodeString;
				short data = 0;
				if (!tagNodeCompound.ContainsKey("version"))
				{
					data = (tagNodeCompound["val"] as TagNodeShort);
				}
				BlockState item = new BlockState
				{
					name = name,
					data = data
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000EF54 File Offset: 0x0000D154
		private string method_3(int int_3)
		{
			return this.method_4(int_3, 16).ToString();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002D81 File Offset: 0x00000F81
		private int method_4(int int_3, int int_4)
		{
			return (int_3 % int_4 + int_4) % int_4;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000EF74 File Offset: 0x0000D174
		public static string ProcessChest(int x, int y, int z, short chestDir, Dictionary<int, MCCoordinate> chests)
		{
			string result = "single";
			lock (JavaChestConnections.object_0)
			{
				result = JavaChestConnections.smethod_0(x, y, z, chestDir, chests);
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
		private static string smethod_0(int int_3, int int_4, int int_5, short short_0, Dictionary<int, MCCoordinate> dictionary_0)
		{
			if (dictionary_0 != null)
			{
				try
				{
					int key;
					if ((int)short_0 != JavaChestConnections.int_0)
					{
						if ((int)short_0 != JavaChestConnections.int_1)
						{
							if ((int)short_0 != JavaChestConnections.int_2)
							{
								if ((int)short_0 != JavaChestConnections.byflgooLa2)
								{
									goto IL_6B;
								}
							}
							key = JavaChestConnections.smethod_1(int_3, int_4, int_5 - 1);
							if (dictionary_0.ContainsKey(key))
							{
								int val = dictionary_0[key].val;
								if ((int)short_0 == val)
								{
									dictionary_0.Remove(key);
									return ((int)short_0 == JavaChestConnections.int_2) ? "left" : "right";
								}
							}
							key = JavaChestConnections.smethod_1(int_3, int_4, int_5 + 1);
							if (!dictionary_0.ContainsKey(key))
							{
								goto IL_6B;
							}
							int val2 = dictionary_0[key].val;
							if ((int)short_0 == val2)
							{
								dictionary_0.Remove(key);
								return ((int)short_0 == JavaChestConnections.int_2) ? "right" : "left";
							}
							goto IL_6B;
						}
					}
					key = JavaChestConnections.smethod_1(int_3 - 1, int_4, int_5);
					if (dictionary_0.ContainsKey(key))
					{
						int val3 = dictionary_0[key].val;
						if ((int)short_0 == val3)
						{
							dictionary_0.Remove(key);
							return ((int)short_0 == JavaChestConnections.int_0) ? "right" : "left";
						}
					}
					key = JavaChestConnections.smethod_1(int_3 + 1, int_4, int_5);
					if (dictionary_0.ContainsKey(key))
					{
						int val4 = dictionary_0[key].val;
						if ((int)short_0 == val4)
						{
							dictionary_0.Remove(key);
							return ((int)short_0 == JavaChestConnections.int_0) ? "left" : "right";
						}
					}
					IL_6B:;
				}
				catch (Exception)
				{
				}
			}
			return "single";
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000F16C File Offset: 0x0000D36C
		private static int smethod_1(int int_3, int int_4, int int_5)
		{
			return string.Concat(new string[]
			{
				int_3.ToString(),
				",",
				int_4.ToString(),
				",",
				int_5.ToString()
			}).GetHashCode();
		}

		// Token: 0x040000B0 RID: 176
		private ChestConnectioExtractnParameters chestConnectioExtractnParameters_0;

		// Token: 0x040000B1 RID: 177
		private static int int_0 = 2;

		// Token: 0x040000B2 RID: 178
		private static int int_1 = 3;

		// Token: 0x040000B3 RID: 179
		private static int byflgooLa2 = 5;

		// Token: 0x040000B4 RID: 180
		private static int int_2 = 4;

		// Token: 0x040000B5 RID: 181
		private NibbleSetters nibbleSetters_0 = new NibbleSetters();

		// Token: 0x040000B6 RID: 182
		private static readonly object object_0 = new object();
	}
}
