using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02000060 RID: 96
internal class Class16
{
	// Token: 0x060003E5 RID: 997 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
	public Class16(bool bool_1)
	{
		this.uvuxQwZjcm(bool_1);
		this.method_7(this.method_3() ? StringComparer.InvariantCultureIgnoreCase : StringComparer.InvariantCulture);
		this.method_5(this.method_3() ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture);
		this.dictionary_0 = new Dictionary<string>(this.method_6());
		this.dictionary_1 = new Dictionary<string>(this.method_6());
		this.hashSet_0 = new HashSet<MethodInfo>();
		this.method_9(1);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x000046FD File Offset: 0x000028FD
	public IDictionary<string> method_0()
	{
		return this.dictionary_1;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00004705 File Offset: 0x00002905
	public IDictionary<string> method_1()
	{
		return this.dictionary_0;
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x0000470D File Offset: 0x0000290D
	public HashSet<MethodInfo> method_2()
	{
		return this.hashSet_0;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00004715 File Offset: 0x00002915
	[CompilerGenerated]
	public bool method_3()
	{
		return this.bool_0;
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x0000471D File Offset: 0x0000291D
	[CompilerGenerated]
	private void uvuxQwZjcm(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00004726 File Offset: 0x00002926
	[CompilerGenerated]
	public StringComparison method_4()
	{
		return this.stringComparison_0;
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x0000472E File Offset: 0x0000292E
	[CompilerGenerated]
	private void method_5(StringComparison stringComparison_1)
	{
		this.stringComparison_0 = stringComparison_1;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00004737 File Offset: 0x00002937
	[CompilerGenerated]
	public IEqualityComparer<string> method_6()
	{
		return this.iequalityComparer_0;
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0000473F File Offset: 0x0000293F
	[CompilerGenerated]
	private void method_7(IEqualityComparer<string> iequalityComparer_1)
	{
		this.iequalityComparer_0 = iequalityComparer_1;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00004748 File Offset: 0x00002948
	[CompilerGenerated]
	public  method_8()
	{
		return this.assignmentOperators_0;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00004750 File Offset: 0x00002950
	[CompilerGenerated]
	public void method_9(assignmentOperators_1)
	{
		this.assignmentOperators_0 = assignmentOperators_1;
	}

	// Token: 0x04000246 RID: 582
	private readonly Dictionary<string> dictionary_0;

	// Token: 0x04000247 RID: 583
	private readonly Dictionary<string> dictionary_1;

	// Token: 0x04000248 RID: 584
	private readonly HashSet<MethodInfo> hashSet_0;

	// Token: 0x04000249 RID: 585
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400024A RID: 586
	[CompilerGenerated]
	private StringComparison stringComparison_0;

	// Token: 0x0400024B RID: 587
	[CompilerGenerated]
	private IEqualityComparer<string> iequalityComparer_0;

	// Token: 0x0400024C RID: 588
	[CompilerGenerated]
	private  assignmentOperators_0;
}
