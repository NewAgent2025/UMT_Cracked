using System;

// Token: 0x020000DE RID: 222
internal class Class33
{
	// Token: 0x06000999 RID: 2457 RVA: 0x00006EC9 File Offset: 0x000050C9
	public Class33()
	{
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00048484 File Offset: 0x00046684
	public Class33(int int_2, string string_2, string string_3)
	{
		this.int_0 = int_2;
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x000484DC File Offset: 0x000466DC
	public Class33(int int_2, string string_2, string string_3, bool bool_2, int int_3)
	{
		this.int_0 = int_2;
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.bool_0 = bool_2;
		this.int_1 = int_3;
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00048544 File Offset: 0x00046744
	public Class33(int int_2, string string_2, string string_3, bool bool_2, bool bool_3, int int_3)
	{
		this.int_0 = int_2;
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.int_1 = int_3;
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x0600099D RID: 2461 RVA: 0x00006F00 File Offset: 0x00005100
	// (set) Token: 0x0600099E RID: 2462 RVA: 0x00006F08 File Offset: 0x00005108
	public int Id
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

	// Token: 0x0600099F RID: 2463 RVA: 0x00006F11 File Offset: 0x00005111
	public string ApfHbuxQfqb()
	{
		return this.string_0;
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00006F19 File Offset: 0x00005119
	public void method_0(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00006F22 File Offset: 0x00005122
	// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00006F2A File Offset: 0x0000512A
	public string Name
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00006F33 File Offset: 0x00005133
	public string method_1()
	{
		return this.bKpHbgiOsrn;
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00006F3B File Offset: 0x0000513B
	public void method_2(string string_2)
	{
		this.bKpHbgiOsrn = string_2;
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00006F44 File Offset: 0x00005144
	public bool method_3()
	{
		return this.bool_0;
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00006F4C File Offset: 0x0000514C
	public void method_4(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00006F55 File Offset: 0x00005155
	public int method_5()
	{
		return this.int_1;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00006F5D File Offset: 0x0000515D
	public void cYcHbmwUjjV(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00006F66 File Offset: 0x00005166
	public bool method_6()
	{
		return this.bool_1;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00006F6E File Offset: 0x0000516E
	public void method_7(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060009AB RID: 2475 RVA: 0x000485B4 File Offset: 0x000467B4
	public string IdName
	{
		get
		{
			string str = (this.int_0 < 10000) ? this.int_0.ToString() : "???";
			return "(" + str + ") " + this.string_1;
		}
	}

	// Token: 0x04000657 RID: 1623
	private int int_0;

	// Token: 0x04000658 RID: 1624
	private string string_0 = "";

	// Token: 0x04000659 RID: 1625
	private string string_1 = "";

	// Token: 0x0400065A RID: 1626
	private string bKpHbgiOsrn = "";

	// Token: 0x0400065B RID: 1627
	private bool bool_0 = true;

	// Token: 0x0400065C RID: 1628
	private int int_1;

	// Token: 0x0400065D RID: 1629
	private bool bool_1 = true;
}
