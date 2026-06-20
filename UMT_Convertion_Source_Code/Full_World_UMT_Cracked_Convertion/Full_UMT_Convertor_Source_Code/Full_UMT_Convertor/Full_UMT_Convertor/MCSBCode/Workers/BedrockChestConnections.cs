using System;
using System.Collections.Generic;
using System.IO;
using Full_UMT_Convertor.PECode;
using MCPELevelDBI.workers;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode.Workers
{
	// Token: 0x0200012B RID: 299
	public class BedrockChestConnections
	{
		// Token: 0x06000CAB RID: 3243 RVA: 0x00057630 File Offset: 0x00055830
		public void ProcessChests(int dimension, List<ConversionChest> list, LevelDBWorker dbWorker)
		{
			try
			{
				while (list.Count > 0)
				{
					Coord coord = list[0].Coord;
					Coord coord2 = list[0].link;
					if (coord2 == null)
					{
						coord2 = this.method_1(list, coord);
					}
					if (coord2 != null)
					{
						this.method_4(dimension, coord, coord2, dbWorker);
						this.method_0(list, coord2);
					}
					list.Remove(list[0]);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000576A8 File Offset: 0x000558A8
		private void method_0(List<ConversionChest> list_0, Coord coord_0)
		{
			int num = -1;
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].Coord.x == coord_0.x && list_0[i].Coord.y == coord_0.y && list_0[i].Coord.z == coord_0.z)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				list_0.Remove(list_0[num]);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00057730 File Offset: 0x00055930
		private Coord method_1(List<ConversionChest> list_0, Coord coord_0)
		{
			Coord result = null;
			if (coord_0.val != this.int_0)
			{
				if (coord_0.val != this.int_1)
				{
					if (coord_0.val != this.int_3)
					{
						if (coord_0.val != this.int_2)
						{
							return result;
						}
					}
					int i = 0;
					while (i < list_0.Count)
					{
						int z = coord_0.z;
						if (z - 1 == list_0[i].Coord.z)
						{
							goto IL_77;
						}
						if (z + 1 == list_0[i].Coord.z)
						{
							goto IL_77;
						}
						IL_95:
						i++;
						continue;
						IL_77:
						if (coord_0.y == list_0[i].Coord.y && coord_0.x == list_0[i].Coord.x && coord_0.val == list_0[i].Coord.val)
						{
							result = list_0[i].Coord;
							break;
						}
						goto IL_95;
					}
					return result;
				}
			}
			int j = 0;
			while (j < list_0.Count)
			{
				int x = coord_0.x;
				if (x - 1 == list_0[j].Coord.x)
				{
					goto IL_BA;
				}
				if (x + 1 == list_0[j].Coord.x)
				{
					goto IL_BA;
				}
				IL_D5:
				j++;
				continue;
				IL_BA:
				if (coord_0.y == list_0[j].Coord.y && coord_0.z == list_0[j].Coord.z && coord_0.val == list_0[j].Coord.val)
				{
					result = list_0[j].Coord;
					break;
				}
				goto IL_D5;
			}
			return result;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00008849 File Offset: 0x00006A49
		private int method_2(int int_4)
		{
			return int_4 >> 4;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000578EC File Offset: 0x00055AEC
		private byte[] method_3(int int_4, Coord coord_0)
		{
			return PEUtility.BuildChunkKey(int_4, this.method_2(coord_0.x), this.method_2(coord_0.z), 49, null);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00057924 File Offset: 0x00055B24
		private void method_4(int int_4, Coord coord_0, Coord coord_1, LevelDBWorker levelDBWorker_0)
		{
			byte[] array = this.method_3(int_4, coord_0);
			byte[] array2 = this.method_3(int_4, coord_1);
			byte[] blockEntity = levelDBWorker_0.Get(array);
			TagNodeList tagNodeList = PEUtility.ExtractTileEntities(blockEntity);
			TagNodeList tagNodeList_ = tagNodeList;
			if (array != array2)
			{
				blockEntity = levelDBWorker_0.Get(array2);
				tagNodeList_ = PEUtility.ExtractTileEntities(blockEntity);
			}
			TagNodeCompound tagNodeCompound = this.method_5(coord_0, tagNodeList);
			TagNodeCompound tagNodeCompound2 = this.method_5(coord_1, tagNodeList_);
			if (tagNodeCompound != null && tagNodeCompound2 != null)
			{
				tagNodeCompound["pairlead"] = new TagNodeByte(1);
				tagNodeCompound["pairx"] = tagNodeCompound2["x"].Copy();
				tagNodeCompound["pairz"] = tagNodeCompound2["z"].Copy();
				this.method_7(array, tagNodeList, levelDBWorker_0);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000579E4 File Offset: 0x00055BE4
		private TagNodeCompound method_5(Coord coord_0, TagNodeList tagNodeList_0)
		{
			TagNodeCompound result = null;
			for (int i = 0; i < tagNodeList_0.Count; i++)
			{
				TagNodeCompound tagNodeCompound = tagNodeList_0[i] as TagNodeCompound;
				if (this.method_6(coord_0, tagNodeCompound))
				{
					result = tagNodeCompound;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00057A20 File Offset: 0x00055C20
		private bool method_6(Coord coord_0, TagNodeCompound tagNodeCompound_0)
		{
			int num = tagNodeCompound_0["x"] as TagNodeInt;
			int num2 = tagNodeCompound_0["y"] as TagNodeInt;
			int num3 = tagNodeCompound_0["z"] as TagNodeInt;
			return coord_0.x == num && coord_0.y == num2 && coord_0.z == num3;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00057A90 File Offset: 0x00055C90
		private void method_7(byte[] byte_0, TagNodeList tagNodeList_0, LevelDBWorker levelDBWorker_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			for (int i = 0; i < tagNodeList_0.Count; i++)
			{
				MemoryStream memoryStream2 = new MemoryStream();
				TagNodeCompound tree = tagNodeList_0[i] as TagNodeCompound;
				NbtTree nbtTree = new NbtTree(tree);
				nbtTree.WriteTo(memoryStream2);
				memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			}
			if (memoryStream.Length > 0L)
			{
				levelDBWorker_0.Put(byte_0, memoryStream.ToArray());
			}
		}

		// Token: 0x040007EB RID: 2027
		private int int_0 = 2;

		// Token: 0x040007EC RID: 2028
		private int int_1 = 3;

		// Token: 0x040007ED RID: 2029
		private int int_2 = 5;

		// Token: 0x040007EE RID: 2030
		private int int_3 = 4;
	}
}
