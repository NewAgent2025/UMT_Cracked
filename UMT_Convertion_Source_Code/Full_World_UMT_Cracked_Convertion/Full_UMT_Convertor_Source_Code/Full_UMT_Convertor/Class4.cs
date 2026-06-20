using System;
using System.Drawing;

// Token: 0x02000038 RID: 56
internal class Class4
{
	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060001F4 RID: 500 RVA: 0x00003304 File Offset: 0x00001504
	// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000330C File Offset: 0x0000150C
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

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060001F6 RID: 502 RVA: 0x00003315 File Offset: 0x00001515
	// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000331D File Offset: 0x0000151D
	public int Data
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

	// Token: 0x060001F8 RID: 504 RVA: 0x00003326 File Offset: 0x00001526
	public int method_0()
	{
		return this.int_2;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000332E File Offset: 0x0000152E
	public void method_1(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060001FA RID: 506 RVA: 0x00003337 File Offset: 0x00001537
	// (set) Token: 0x060001FB RID: 507 RVA: 0x0000333F File Offset: 0x0000153F
	public string Description
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

	// Token: 0x060001FC RID: 508 RVA: 0x00003348 File Offset: 0x00001548
	public Image method_2()
	{
		return this.image_0;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00003350 File Offset: 0x00001550
	public void method_3(Image image_1)
	{
		this.image_0 = image_1;
	}

	// Token: 0x0400013A RID: 314
	private int int_0;

	// Token: 0x0400013B RID: 315
	private int int_1;

	// Token: 0x0400013C RID: 316
	private int int_2;

	// Token: 0x0400013D RID: 317
	private string string_0;

	// Token: 0x0400013E RID: 318
	private Image image_0;
}
