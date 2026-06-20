using System;
using System.Drawing;
using System.Drawing.Imaging;
using Substrate;
using Substrate.Data;

namespace Full_UMT_Convertor
{
	// Token: 0x02000099 RID: 153
	public class MapConverterII
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x00039934 File Offset: 0x00037B34
		public MapConverterII()
		{
			this.color_1 = new Color[256];
			this.vector3_0 = new Vector3[256];
			MapConverterII.color_0.CopyTo(this.color_1, 0);
			this.RefreshColorCache();
			this.blockColorIndex_0 = new BlockColorIndex[4096];
			for (int i = 0; i < this.blockColorIndex_0.Length; i++)
			{
				this.blockColorIndex_0[i] = new BlockColorIndex();
			}
			this.blockColorIndex_0[0].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[1].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[2].method_0(0, ColorGroup.Grass);
			this.blockColorIndex_0[3].method_0(0, ColorGroup.Dirt);
			this.blockColorIndex_0[4].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[5].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[6].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[7].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[8].method_0(0, ColorGroup.Water);
			this.blockColorIndex_0[9].method_0(0, ColorGroup.Water);
			this.blockColorIndex_0[10].method_0(0, ColorGroup.Lava);
			this.blockColorIndex_0[11].method_0(0, ColorGroup.Lava);
			this.blockColorIndex_0[12].method_0(0, ColorGroup.Sand);
			this.blockColorIndex_0[12].method_0(1, ColorGroup.Red);
			this.blockColorIndex_0[13].method_0(0, ColorGroup.Sand);
			this.blockColorIndex_0[14].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[15].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[16].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[17].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[18].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[19].method_0(0, ColorGroup.Yellow);
			this.blockColorIndex_0[20].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[21].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[22].method_0(0, ColorGroup.Lapis);
			this.blockColorIndex_0[23].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[24].method_0(0, ColorGroup.Sand);
			this.blockColorIndex_0[25].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[26].method_0(0, ColorGroup.Other);
			this.blockColorIndex_0[27].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[28].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[29].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[30].method_0(0, ColorGroup.Other);
			this.blockColorIndex_0[31].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[32].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[33].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[34].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[35].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[35].method_0(1, ColorGroup.Orange);
			this.blockColorIndex_0[35].method_0(2, ColorGroup.Magenta);
			this.blockColorIndex_0[35].method_0(3, ColorGroup.LightBlue);
			this.blockColorIndex_0[35].method_0(4, ColorGroup.Yellow);
			this.blockColorIndex_0[35].method_0(5, ColorGroup.Lime);
			this.blockColorIndex_0[35].method_0(6, ColorGroup.Pink);
			this.blockColorIndex_0[35].method_0(7, ColorGroup.Grey);
			this.blockColorIndex_0[35].method_0(8, ColorGroup.LightGrey);
			this.blockColorIndex_0[35].method_0(9, ColorGroup.Cyan);
			this.blockColorIndex_0[35].method_0(10, ColorGroup.Purple);
			this.blockColorIndex_0[35].method_0(11, ColorGroup.Blue);
			this.blockColorIndex_0[35].method_0(12, ColorGroup.Brown);
			this.blockColorIndex_0[35].method_0(13, ColorGroup.Green);
			this.blockColorIndex_0[35].method_0(14, ColorGroup.Red);
			this.blockColorIndex_0[35].method_0(15, ColorGroup.Black);
			this.blockColorIndex_0[36].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[37].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[38].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[39].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[40].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[41].method_0(0, ColorGroup.Gold);
			this.blockColorIndex_0[42].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[43].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[44].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[45].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[46].method_0(0, ColorGroup.Lava);
			this.blockColorIndex_0[47].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[48].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[49].method_0(0, ColorGroup.Black);
			this.blockColorIndex_0[50].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[51].method_0(0, ColorGroup.Lava);
			this.blockColorIndex_0[52].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[53].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[54].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[55].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[56].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[57].method_0(0, ColorGroup.Diamond);
			this.blockColorIndex_0[58].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[59].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[60].method_0(0, ColorGroup.Dirt);
			this.blockColorIndex_0[61].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[62].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[63].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[64].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[65].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[66].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[67].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[68].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[69].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[70].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[71].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[72].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[73].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[74].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[75].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[76].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[77].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[78].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[79].method_0(0, ColorGroup.Ice);
			this.blockColorIndex_0[80].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[81].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[82].method_0(0, ColorGroup.Clay);
			this.blockColorIndex_0[83].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[84].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[85].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[86].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[87].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[88].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[89].method_0(0, ColorGroup.Sand);
			this.blockColorIndex_0[90].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[91].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[92].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[93].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[94].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[95].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[96].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[97].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[98].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[99].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[100].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[101].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[102].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[103].method_0(0, ColorGroup.Lime);
			this.blockColorIndex_0[104].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[105].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[106].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[107].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[108].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[109].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[110].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[111].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[112].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[113].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[114].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[115].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[116].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[117].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[118].method_0(0, ColorGroup.Grey);
			this.blockColorIndex_0[119].method_0(0, ColorGroup.Black);
			this.blockColorIndex_0[120].method_0(0, ColorGroup.Green);
			this.blockColorIndex_0[121].method_0(0, ColorGroup.Yellow);
			this.blockColorIndex_0[122].method_0(0, ColorGroup.Black);
			this.blockColorIndex_0[123].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[124].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[125].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[126].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[127].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[128].method_0(0, ColorGroup.Sand);
			this.blockColorIndex_0[129].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[130].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[131].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[132].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[133].method_0(0, ColorGroup.Emerald);
			this.blockColorIndex_0[134].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[135].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[136].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[137].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[138].method_0(0, ColorGroup.Diamond);
			this.blockColorIndex_0[139].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[140].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[141].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[142].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[143].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[144].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[145].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[146].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[147].method_0(0, ColorGroup.Gold);
			this.blockColorIndex_0[148].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[149].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[150].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[151].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[152].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[153].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[154].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[155].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[156].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[157].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[158].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[159].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[159].method_0(1, ColorGroup.Orange);
			this.blockColorIndex_0[159].method_0(2, ColorGroup.Magenta);
			this.blockColorIndex_0[159].method_0(3, ColorGroup.LightBlue);
			this.blockColorIndex_0[159].method_0(4, ColorGroup.Yellow);
			this.blockColorIndex_0[159].method_0(5, ColorGroup.Lime);
			this.blockColorIndex_0[159].method_0(6, ColorGroup.Pink);
			this.blockColorIndex_0[159].method_0(7, ColorGroup.Grey);
			this.blockColorIndex_0[159].method_0(8, ColorGroup.LightGrey);
			this.blockColorIndex_0[159].method_0(9, ColorGroup.Cyan);
			this.blockColorIndex_0[159].method_0(10, ColorGroup.Purple);
			this.blockColorIndex_0[159].method_0(11, ColorGroup.Blue);
			this.blockColorIndex_0[159].method_0(12, ColorGroup.Brown);
			this.blockColorIndex_0[159].method_0(13, ColorGroup.Green);
			this.blockColorIndex_0[159].method_0(14, ColorGroup.Red);
			this.blockColorIndex_0[159].method_0(15, ColorGroup.Black);
			this.blockColorIndex_0[160].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[160].method_0(1, ColorGroup.Orange);
			this.blockColorIndex_0[160].method_0(2, ColorGroup.Magenta);
			this.blockColorIndex_0[160].method_0(3, ColorGroup.LightBlue);
			this.blockColorIndex_0[160].method_0(4, ColorGroup.Yellow);
			this.blockColorIndex_0[160].method_0(5, ColorGroup.Lime);
			this.blockColorIndex_0[160].method_0(6, ColorGroup.Pink);
			this.blockColorIndex_0[160].method_0(7, ColorGroup.Grey);
			this.blockColorIndex_0[160].method_0(8, ColorGroup.LightGrey);
			this.blockColorIndex_0[160].method_0(9, ColorGroup.Cyan);
			this.blockColorIndex_0[160].method_0(10, ColorGroup.Purple);
			this.blockColorIndex_0[160].method_0(11, ColorGroup.Blue);
			this.blockColorIndex_0[160].method_0(12, ColorGroup.Brown);
			this.blockColorIndex_0[160].method_0(13, ColorGroup.Green);
			this.blockColorIndex_0[160].method_0(14, ColorGroup.Red);
			this.blockColorIndex_0[160].method_0(15, ColorGroup.Black);
			this.blockColorIndex_0[161].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[162].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[162].method_0(1, ColorGroup.Brown);
			this.blockColorIndex_0[163].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[164].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[165].method_0(0, ColorGroup.Lime);
			this.blockColorIndex_0[166].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[167].method_0(0, ColorGroup.Metal);
			this.blockColorIndex_0[168].method_0(0, ColorGroup.Diamond);
			this.blockColorIndex_0[169].method_0(0, ColorGroup.Diamond);
			this.blockColorIndex_0[170].method_0(0, ColorGroup.Gold);
			this.blockColorIndex_0[171].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[171].method_0(1, ColorGroup.Orange);
			this.blockColorIndex_0[171].method_0(2, ColorGroup.Magenta);
			this.blockColorIndex_0[171].method_0(3, ColorGroup.LightBlue);
			this.blockColorIndex_0[171].method_0(4, ColorGroup.Yellow);
			this.blockColorIndex_0[171].method_0(5, ColorGroup.Lime);
			this.blockColorIndex_0[171].method_0(6, ColorGroup.Pink);
			this.blockColorIndex_0[171].method_0(7, ColorGroup.Grey);
			this.blockColorIndex_0[171].method_0(8, ColorGroup.LightGrey);
			this.blockColorIndex_0[171].method_0(9, ColorGroup.Cyan);
			this.blockColorIndex_0[171].method_0(10, ColorGroup.Purple);
			this.blockColorIndex_0[171].method_0(11, ColorGroup.Blue);
			this.blockColorIndex_0[171].method_0(12, ColorGroup.Brown);
			this.blockColorIndex_0[171].method_0(13, ColorGroup.Green);
			this.blockColorIndex_0[171].method_0(14, ColorGroup.Red);
			this.blockColorIndex_0[171].method_0(15, ColorGroup.Black);
			this.blockColorIndex_0[172].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[173].method_0(0, ColorGroup.Black);
			this.blockColorIndex_0[174].method_0(0, ColorGroup.Ice);
			this.blockColorIndex_0[175].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[176].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[177].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[178].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[179].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[180].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[181].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[182].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[183].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[184].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[185].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[186].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[187].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[188].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[189].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[190].method_0(0, ColorGroup.Wood);
			this.blockColorIndex_0[191].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[192].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[193].method_0(0, ColorGroup.Obsidian);
			this.blockColorIndex_0[194].method_0(0, ColorGroup.Sand);
			this.blockColorIndex_0[195].method_0(0, ColorGroup.Dirt);
			this.blockColorIndex_0[196].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[197].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[198].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[199].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[200].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[201].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[202].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[203].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[204].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[205].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[206].method_0(0, ColorGroup.Lime);
			this.blockColorIndex_0[207].method_0(0, ColorGroup.Plant);
			this.blockColorIndex_0[208].method_0(0, ColorGroup.Grass);
			this.blockColorIndex_0[209].method_0(0, ColorGroup.Other);
			this.blockColorIndex_0[210].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[211].method_0(0, ColorGroup.Green);
			this.blockColorIndex_0[212].method_0(0, ColorGroup.Ice);
			this.blockColorIndex_0[213].method_0(0, ColorGroup.Lava);
			this.blockColorIndex_0[214].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[215].method_0(0, ColorGroup.Netherrack);
			this.blockColorIndex_0[216].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[217].method_0(0, ColorGroup.Unexplored);
			this.blockColorIndex_0[218].method_0(0, ColorGroup.Stone);
			this.blockColorIndex_0[219].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[220].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[221].method_0(0, ColorGroup.Magenta);
			this.blockColorIndex_0[222].method_0(0, ColorGroup.LightBlue);
			this.blockColorIndex_0[223].method_0(0, ColorGroup.Yellow);
			this.blockColorIndex_0[224].method_0(0, ColorGroup.Lime);
			this.blockColorIndex_0[225].method_0(0, ColorGroup.Pink);
			this.blockColorIndex_0[226].method_0(0, ColorGroup.Grey);
			this.blockColorIndex_0[227].method_0(0, ColorGroup.LightGrey);
			this.blockColorIndex_0[228].method_0(0, ColorGroup.Cyan);
			this.blockColorIndex_0[229].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[230].method_0(0, ColorGroup.Blue);
			this.blockColorIndex_0[231].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[232].method_0(0, ColorGroup.Green);
			this.blockColorIndex_0[233].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[234].method_0(0, ColorGroup.Black);
			this.blockColorIndex_0[235].method_0(0, ColorGroup.White);
			this.blockColorIndex_0[236].method_0(0, ColorGroup.Orange);
			this.blockColorIndex_0[237].method_0(0, ColorGroup.Magenta);
			this.blockColorIndex_0[238].method_0(0, ColorGroup.LightBlue);
			this.blockColorIndex_0[239].method_0(0, ColorGroup.Yellow);
			this.blockColorIndex_0[240].method_0(0, ColorGroup.Lime);
			this.blockColorIndex_0[241].method_0(0, ColorGroup.Pink);
			this.blockColorIndex_0[242].method_0(0, ColorGroup.Grey);
			this.blockColorIndex_0[243].method_0(0, ColorGroup.LightGrey);
			this.blockColorIndex_0[244].method_0(0, ColorGroup.Cyan);
			this.blockColorIndex_0[245].method_0(0, ColorGroup.Purple);
			this.blockColorIndex_0[246].method_0(0, ColorGroup.Blue);
			this.blockColorIndex_0[247].method_0(0, ColorGroup.Brown);
			this.blockColorIndex_0[248].method_0(0, ColorGroup.Green);
			this.blockColorIndex_0[249].method_0(0, ColorGroup.Red);
			this.blockColorIndex_0[250].method_0(0, ColorGroup.Black);
			this.blockColorIndex_0[251].method_0(0, ColorGroup.LightGrey);
			this.blockColorIndex_0[252].method_0(0, ColorGroup.LightGrey);
			this.blockColorIndex_0[255].method_0(0, ColorGroup.LightGrey);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0000529F File Offset: 0x0000349F
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x000052A7 File Offset: 0x000034A7
		public int ColorGroupSize
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("The ColorGroupSize property must be a positive number.");
				}
				this.int_0 = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000052BF File Offset: 0x000034BF
		public Color[] ColorIndex
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000052C7 File Offset: 0x000034C7
		public BlockColorIndex[] BlockIndex
		{
			get
			{
				return this.blockColorIndex_0;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000052CF File Offset: 0x000034CF
		public int BlockToColorIndex(int blockId, int data)
		{
			return this.BlockToColorIndex(blockId, data, 0);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0003B074 File Offset: 0x00039274
		public int BlockToColorIndex(int blockId, int data, int level)
		{
			if (level < 0 || level >= this.int_0)
			{
				throw new ArgumentOutOfRangeException("level", level, "Argument 'level' must be in range [0, " + (this.int_0 - 1) + "]");
			}
			if (blockId < 0 || blockId >= 4096)
			{
				throw new ArgumentOutOfRangeException("blockId");
			}
			return (int)(this.blockColorIndex_0[blockId].GetColorIndex(data) * (ColorGroup)this.int_0 + level);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000052DA File Offset: 0x000034DA
		public Color BlockToColor(int blockId, int data)
		{
			return this.BlockToColor(blockId, data, 0);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0003B0EC File Offset: 0x000392EC
		public Color BlockToColor(int blockId, int data, int level)
		{
			int num = this.BlockToColorIndex(blockId, data, level);
			if (num < 0 || num >= 256)
			{
				throw new InvalidOperationException("The specified Block ID mapped to an invalid color index.");
			}
			return this.color_1[num];
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0003B12C File Offset: 0x0003932C
		public ColorGroup ColorIndexToGroup(int colorIndex)
		{
			int num = colorIndex / this.int_0;
			ColorGroup result;
			try
			{
				result = (ColorGroup)num;
			}
			catch
			{
				result = ColorGroup.Other;
			}
			return result;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000052E5 File Offset: 0x000034E5
		public int GroupToColorIndex(ColorGroup group)
		{
			return this.GroupToColorIndex(group, 0);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0003B15C File Offset: 0x0003935C
		public int GroupToColorIndex(ColorGroup group, int level)
		{
			if (level < 0 || level >= this.int_0)
			{
				throw new ArgumentOutOfRangeException("level", level, "Argument 'level' must be in range [0, " + (this.int_0 - 1) + "]");
			}
			return (int)(group * (ColorGroup)this.int_0 + level);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000052EF File Offset: 0x000034EF
		public Color GroupToColor(ColorGroup group)
		{
			return this.GroupToColor(group, 0);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0003B1B0 File Offset: 0x000393B0
		public Color GroupToColor(ColorGroup group, int level)
		{
			int num = this.GroupToColorIndex(group, level);
			if (num < 0 || num >= 256)
			{
				throw new InvalidOperationException("The specified group mapped to an invalid color index.");
			}
			return this.color_1[num];
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0003B1F0 File Offset: 0x000393F0
		public void RefreshColorCache()
		{
			for (int i = 0; i < this.color_1.Length; i++)
			{
				this.vector3_0[i] = this.method_2(this.color_1[i]);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0003B230 File Offset: 0x00039430
		public int NearestColorIndex(Color color)
		{
			double num = double.MaxValue;
			int result = 0;
			Vector3 vector = this.method_2(color);
			for (int i = 0; i < this.color_1.Length; i++)
			{
				if (this.color_1[i].A != 0)
				{
					double num2 = vector.X - this.vector3_0[i].X;
					double num3 = vector.Y - this.vector3_0[i].Y;
					double num4 = vector.Z - this.vector3_0[i].Z;
					double num5 = num2 * num2 + num3 * num3 + num4 * num4;
					if (num5 < num)
					{
						num = num5;
						result = i;
					}
				}
			}
			return result;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000052F9 File Offset: 0x000034F9
		public Color NearestColor(Color color)
		{
			return this.color_1[this.NearestColorIndex(color)];
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0003B2DC File Offset: 0x000394DC
		public void BitmapToMap(Map map, Bitmap bmp)
		{
			if (map.Width == bmp.Width)
			{
				if (map.Height == bmp.Height)
				{
					for (int i = 0; i < map.Width; i++)
					{
						for (int j = 0; j < map.Height; j++)
						{
							Color pixel = bmp.GetPixel(i, j);
							byte value = 0;
							if (pixel.A > 0)
							{
								value = (byte)this.NearestColorIndex(pixel);
							}
							map[i, j] = value;
						}
					}
					return;
				}
			}
			throw new InvalidOperationException("The source map and bitmap must have the same dimensions.");
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0003B360 File Offset: 0x00039560
		public Bitmap MapToBitmap(Map map)
		{
			Bitmap bitmap = new Bitmap(map.Width, map.Height, PixelFormat.Format32bppArgb);
			for (int i = 0; i < map.Width; i++)
			{
				for (int j = 0; j < map.Height; j++)
				{
					Color color = this.color_1[(int)map[i, j]];
					bitmap.SetPixel(i, j, color);
				}
			}
			return bitmap;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0003B3CC File Offset: 0x000395CC
		public Bitmap ConvertBitmap(Bitmap inBmp)
		{
			Bitmap bitmap = new Bitmap(inBmp.Width, inBmp.Height, PixelFormat.Format32bppArgb);
			for (int i = 0; i < inBmp.Width; i++)
			{
				for (int j = 0; j < inBmp.Height; j++)
				{
					Color color = inBmp.GetPixel(i, j);
					byte b = 0;
					if (color.A > 0)
					{
						b = (byte)this.NearestColorIndex(color);
					}
					color = this.color_1[(int)b];
					bitmap.SetPixel(i, j, color);
				}
			}
			return bitmap;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0003B450 File Offset: 0x00039650
		private Vector3 method_0(Color color_2)
		{
			double num = (double)color_2.R / 255.0;
			double num2 = (double)color_2.G / 255.0;
			double num3 = (double)color_2.B / 255.0;
			num = ((num > 0.04045) ? Math.Pow((num + 0.055) / 1.055, 2.4) : (num / 12.92));
			num2 = ((num2 > 0.04045) ? Math.Pow((num2 + 0.055) / 1.055, 2.4) : (num2 / 12.92));
			num3 = ((num3 > 0.04045) ? Math.Pow((num3 + 0.055) / 1.055, 2.4) : (num3 / 12.92));
			num *= 100.0;
			num2 *= 100.0;
			num3 *= 100.0;
			return new Vector3
			{
				X = num * 0.4124 + num2 * 0.3576 + num3 * 0.1805,
				Y = num * 0.2126 + num2 * 0.7152 + num3 * 0.0722,
				Z = num * 0.0193 + num2 * 0.1192 + num3 * 0.9505
			};
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0003B5F4 File Offset: 0x000397F4
		private Vector3 method_1(Vector3 vector3_1)
		{
			double num = vector3_1.X / 95.047;
			double num2 = vector3_1.Y / 100.0;
			double num3 = vector3_1.Z / 108.883;
			num = ((num > 0.008856) ? Math.Pow(num, 0.3333333333333333) : (7.787 * num + 0.13793103448275862));
			num2 = ((num2 > 0.008856) ? Math.Pow(num2, 0.3333333333333333) : (7.787 * num2 + 0.13793103448275862));
			num3 = ((num3 > 0.008856) ? Math.Pow(num3, 0.3333333333333333) : (7.787 * num3 + 0.13793103448275862));
			return new Vector3
			{
				X = 116.0 * num2 - 16.0,
				Y = 500.0 * (num - num2),
				Z = 200.0 * (num2 - num3)
			};
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00005312 File Offset: 0x00003512
		private Vector3 method_2(Color color_2)
		{
			return this.method_1(this.method_0(color_2));
		}

		// Token: 0x040004C1 RID: 1217
		private static Color[] color_0 = new Color[]
		{
			Color.FromArgb(0, 0, 0, 0),
			Color.FromArgb(0, 0, 0, 0),
			Color.FromArgb(0, 0, 0, 0),
			Color.FromArgb(0, 0, 0, 0),
			Color.FromArgb(88, 124, 39),
			Color.FromArgb(108, 151, 47),
			Color.FromArgb(125, 176, 55),
			Color.FromArgb(66, 93, 29),
			Color.FromArgb(172, 162, 114),
			Color.FromArgb(210, 199, 138),
			Color.FromArgb(244, 230, 161),
			Color.FromArgb(128, 122, 85),
			Color.FromArgb(138, 138, 138),
			Color.FromArgb(169, 169, 169),
			Color.FromArgb(197, 197, 197),
			Color.FromArgb(104, 104, 104),
			Color.FromArgb(178, 0, 0),
			Color.FromArgb(217, 0, 0),
			Color.FromArgb(252, 0, 0),
			Color.FromArgb(133, 0, 0),
			Color.FromArgb(111, 111, 178),
			Color.FromArgb(136, 136, 217),
			Color.FromArgb(158, 158, 252),
			Color.FromArgb(83, 83, 133),
			Color.FromArgb(116, 116, 116),
			Color.FromArgb(142, 142, 142),
			Color.FromArgb(165, 165, 165),
			Color.FromArgb(87, 87, 87),
			Color.FromArgb(0, 86, 0),
			Color.FromArgb(0, 105, 0),
			Color.FromArgb(0, 123, 0),
			Color.FromArgb(0, 64, 0),
			Color.FromArgb(178, 178, 178),
			Color.FromArgb(217, 217, 217),
			Color.FromArgb(252, 252, 252),
			Color.FromArgb(133, 133, 133),
			Color.FromArgb(114, 117, 127),
			Color.FromArgb(139, 142, 156),
			Color.FromArgb(162, 166, 182),
			Color.FromArgb(85, 87, 96),
			Color.FromArgb(105, 75, 53),
			Color.FromArgb(128, 93, 65),
			Color.FromArgb(149, 108, 76),
			Color.FromArgb(78, 56, 39),
			Color.FromArgb(78, 78, 78),
			Color.FromArgb(95, 95, 95),
			Color.FromArgb(111, 111, 111),
			Color.FromArgb(58, 58, 58),
			Color.FromArgb(44, 44, 178),
			Color.FromArgb(54, 54, 217),
			Color.FromArgb(63, 63, 252),
			Color.FromArgb(33, 33, 133),
			Color.FromArgb(99, 83, 49),
			Color.FromArgb(122, 101, 61),
			Color.FromArgb(141, 118, 71),
			Color.FromArgb(74, 62, 38),
			Color.FromArgb(178, 175, 170),
			Color.FromArgb(217, 214, 208),
			Color.FromArgb(252, 249, 242),
			Color.FromArgb(133, 131, 127),
			Color.FromArgb(150, 88, 36),
			Color.FromArgb(184, 108, 43),
			Color.FromArgb(213, 125, 50),
			Color.FromArgb(113, 66, 27),
			Color.FromArgb(124, 52, 150),
			Color.FromArgb(151, 64, 184),
			Color.FromArgb(176, 75, 213),
			Color.FromArgb(93, 39, 113),
			Color.FromArgb(71, 107, 150),
			Color.FromArgb(87, 130, 184),
			Color.FromArgb(101, 151, 213),
			Color.FromArgb(53, 80, 113),
			Color.FromArgb(159, 159, 36),
			Color.FromArgb(195, 195, 43),
			Color.FromArgb(226, 226, 50),
			Color.FromArgb(120, 120, 27),
			Color.FromArgb(88, 142, 17),
			Color.FromArgb(108, 174, 21),
			Color.FromArgb(125, 202, 25),
			Color.FromArgb(66, 107, 13),
			Color.FromArgb(168, 88, 115),
			Color.FromArgb(206, 108, 140),
			Color.FromArgb(239, 125, 163),
			Color.FromArgb(126, 66, 86),
			Color.FromArgb(52, 52, 52),
			Color.FromArgb(64, 64, 64),
			Color.FromArgb(75, 75, 75),
			Color.FromArgb(39, 39, 39),
			Color.FromArgb(107, 107, 107),
			Color.FromArgb(130, 130, 130),
			Color.FromArgb(151, 151, 151),
			Color.FromArgb(80, 80, 80),
			Color.FromArgb(52, 88, 107),
			Color.FromArgb(64, 108, 130),
			Color.FromArgb(75, 125, 151),
			Color.FromArgb(39, 66, 80),
			Color.FromArgb(88, 43, 124),
			Color.FromArgb(108, 53, 151),
			Color.FromArgb(125, 62, 176),
			Color.FromArgb(66, 33, 93),
			Color.FromArgb(36, 52, 124),
			Color.FromArgb(43, 64, 151),
			Color.FromArgb(50, 75, 176),
			Color.FromArgb(27, 39, 93),
			Color.FromArgb(71, 52, 36),
			Color.FromArgb(87, 64, 43),
			Color.FromArgb(101, 75, 50),
			Color.FromArgb(53, 39, 27),
			Color.FromArgb(71, 88, 36),
			Color.FromArgb(87, 108, 43),
			Color.FromArgb(101, 125, 50),
			Color.FromArgb(53, 66, 27),
			Color.FromArgb(107, 36, 36),
			Color.FromArgb(130, 43, 43),
			Color.FromArgb(151, 50, 50),
			Color.FromArgb(80, 27, 27),
			Color.FromArgb(17, 17, 17),
			Color.FromArgb(21, 21, 21),
			Color.FromArgb(25, 25, 25),
			Color.FromArgb(13, 13, 13),
			Color.FromArgb(174, 166, 53),
			Color.FromArgb(212, 203, 65),
			Color.FromArgb(247, 235, 76),
			Color.FromArgb(130, 125, 39),
			Color.FromArgb(63, 152, 148),
			Color.FromArgb(78, 186, 181),
			Color.FromArgb(91, 216, 210),
			Color.FromArgb(47, 114, 111),
			Color.FromArgb(51, 89, 178),
			Color.FromArgb(62, 109, 217),
			Color.FromArgb(73, 129, 252),
			Color.FromArgb(39, 66, 133),
			Color.FromArgb(0, 151, 39),
			Color.FromArgb(0, 185, 49),
			Color.FromArgb(0, 214, 57),
			Color.FromArgb(0, 113, 30),
			Color.FromArgb(90, 59, 34),
			Color.FromArgb(110, 73, 41),
			Color.FromArgb(127, 85, 48),
			Color.FromArgb(67, 44, 25),
			Color.FromArgb(78, 1, 0),
			Color.FromArgb(95, 1, 0),
			Color.FromArgb(111, 2, 0),
			Color.FromArgb(58, 1, 0)
		};

		// Token: 0x040004C2 RID: 1218
		private Color[] color_1;

		// Token: 0x040004C3 RID: 1219
		private BlockColorIndex[] blockColorIndex_0;

		// Token: 0x040004C4 RID: 1220
		private int int_0 = 4;

		// Token: 0x040004C5 RID: 1221
		private Vector3[] vector3_0;
	}
}
