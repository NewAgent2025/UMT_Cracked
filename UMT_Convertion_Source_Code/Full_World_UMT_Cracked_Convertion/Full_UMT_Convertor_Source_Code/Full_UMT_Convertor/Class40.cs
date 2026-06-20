using System;
using System.Collections.Generic;

// Token: 0x02000120 RID: 288
internal class Class40
{
	// Token: 0x06000C52 RID: 3154 RVA: 0x00008570 File Offset: 0x00006770
	public Class40()
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x0000858E File Offset: 0x0000678E
	public Class40(int int_3, int int_4, int int_5)
	{
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000085C1 File Offset: 0x000067C1
	// (set) Token: 0x06000C55 RID: 3157 RVA: 0x000085C9 File Offset: 0x000067C9
	public int Dimension
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x06000C56 RID: 3158 RVA: 0x000085D2 File Offset: 0x000067D2
	// (set) Token: 0x06000C57 RID: 3159 RVA: 0x000085DA File Offset: 0x000067DA
	public int Z
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000085E3 File Offset: 0x000067E3
	// (set) Token: 0x06000C59 RID: 3161 RVA: 0x000085EB File Offset: 0x000067EB
	public int X
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x000085F4 File Offset: 0x000067F4
	public Dictionary<int, byte[]> method_0()
	{
		return this.dictionary_1;
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x000085FC File Offset: 0x000067FC
	public void method_1(Dictionary<int, byte[]> dictionary_2)
	{
		this.dictionary_1 = dictionary_2;
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00008605 File Offset: 0x00006805
	public Dictionary<int, byte[]> method_2()
	{
		return this.dictionary_0;
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0000860D File Offset: 0x0000680D
	public void method_3(Dictionary<int, byte[]> dictionary_2)
	{
		this.dictionary_0 = dictionary_2;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00008616 File Offset: 0x00006816
	public void method_4(int int_3, int int_4, byte[] byte_0)
	{
		if (int_3 == 47)
		{
			this.dictionary_0[int_4] = byte_0;
			return;
		}
		this.dictionary_1[int_3] = byte_0;
	}

	// Token: 0x040007C1 RID: 1985
	private int int_0;

	// Token: 0x040007C2 RID: 1986
	private int int_1;

	// Token: 0x040007C3 RID: 1987
	private int int_2;

	// Token: 0x040007C4 RID: 1988
	private Dictionary<int, byte[]> dictionary_0 = new Dictionary<int, byte[]>();

	// Token: 0x040007C5 RID: 1989
	private Dictionary<int, byte[]> dictionary_1 = new Dictionary<int, byte[]>();
}
