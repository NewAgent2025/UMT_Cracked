using System;

// Token: 0x0200009A RID: 154
internal class Class28
{
	// Token: 0x060006C3 RID: 1731 RVA: 0x00005CBA File Offset: 0x00003EBA
	public Class28()
	{
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x0002ABE4 File Offset: 0x00028DE4
	public Class28(int int_2, string string_3, string string_4)
	{
		this.int_0 = int_2;
		this.string_0 = string_3;
		this.string_1 = string_4;
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x0002AC3C File Offset: 0x00028E3C
	public Class28(int int_2, string string_3, string string_4, bool bool_2, int int_3)
	{
		this.int_0 = int_2;
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.bool_0 = bool_2;
		this.int_1 = int_3;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0002ACA4 File Offset: 0x00028EA4
	public Class28(int int_2, string string_3, string string_4, bool bool_2, bool bool_3, int int_3)
	{
		this.int_0 = int_2;
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.int_1 = int_3;
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00005CF1 File Offset: 0x00003EF1
	// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00005CF9 File Offset: 0x00003EF9
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

	// Token: 0x060006C9 RID: 1737 RVA: 0x00005D02 File Offset: 0x00003F02
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00005D0A File Offset: 0x00003F0A
	public void method_1(string string_3)
	{
		this.string_0 = string_3;
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060006CB RID: 1739 RVA: 0x00005D13 File Offset: 0x00003F13
	// (set) Token: 0x060006CC RID: 1740 RVA: 0x00005D1B File Offset: 0x00003F1B
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

	// Token: 0x060006CD RID: 1741 RVA: 0x00005D24 File Offset: 0x00003F24
	public string method_2()
	{
		return this.string_2;
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00005D2C File Offset: 0x00003F2C
	public void method_3(string string_3)
	{
		this.string_2 = string_3;
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00005D35 File Offset: 0x00003F35
	public bool method_4()
	{
		return this.bool_0;
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00005D3D File Offset: 0x00003F3D
	public void method_5(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00005D46 File Offset: 0x00003F46
	public int method_6()
	{
		return this.int_1;
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00005D4E File Offset: 0x00003F4E
	public void method_7(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00005D57 File Offset: 0x00003F57
	public bool method_8()
	{
		return this.bool_1;
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00005D5F File Offset: 0x00003F5F
	public void method_9(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0002AD14 File Offset: 0x00028F14
	public string IdName
	{
		get
		{
			string str = (this.int_0 < 10000) ? this.int_0.ToString() : "???";
			return "(" + str + ") " + this.string_1;
		}
	}

	// Token: 0x0400042A RID: 1066
	private int int_0;

	// Token: 0x0400042B RID: 1067
	private string string_0 = "";

	// Token: 0x0400042C RID: 1068
	private string string_1 = "";

	// Token: 0x0400042D RID: 1069
	private string string_2 = "";

	// Token: 0x0400042E RID: 1070
	private bool bool_0 = true;

	// Token: 0x0400042F RID: 1071
	private int int_1;

	// Token: 0x04000430 RID: 1072
	private bool bool_1 = true;
}
