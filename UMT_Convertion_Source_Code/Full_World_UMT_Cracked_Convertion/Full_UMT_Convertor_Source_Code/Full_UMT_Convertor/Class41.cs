using System;

// Token: 0x02000125 RID: 293
internal class Class41
{
	// Token: 0x06000C72 RID: 3186 RVA: 0x00002591 File Offset: 0x00000791
	public Class41()
	{
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00008712 File Offset: 0x00006912
	public Class41(int int_2, int int_3, string string_1)
	{
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.string_0 = string_1;
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x0000872F File Offset: 0x0000692F
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00008737 File Offset: 0x00006937
	public void method_1(int int_2)
	{
		this.int_0 = int_2;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00008740 File Offset: 0x00006940
	public int method_2()
	{
		return this.int_1;
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00008748 File Offset: 0x00006948
	public void method_3(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00008751 File Offset: 0x00006951
	// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00008759 File Offset: 0x00006959
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x040007DA RID: 2010
	private string string_0;

	// Token: 0x040007DB RID: 2011
	private int int_0;

	// Token: 0x040007DC RID: 2012
	private int int_1;
}
