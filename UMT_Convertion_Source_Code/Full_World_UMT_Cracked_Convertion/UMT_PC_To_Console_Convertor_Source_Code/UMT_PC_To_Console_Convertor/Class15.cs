using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02000048 RID: 72
internal class Class15
{
	// Token: 0x06000358 RID: 856 RVA: 0x0001AD78 File Offset: 0x00018F78
	public Class15(bool bool_1)
	{
		this.method_4(bool_1);
		this.method_8(this.method_3() ? StringComparer.InvariantCultureIgnoreCase : StringComparer.InvariantCulture);
		this.method_6(this.method_3() ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture);
		this.dictionary_0 = new Dictionary<string>(this.method_7());
		this.dictionary_1 = new Dictionary<string>(this.method_7());
		this.hashSet_0 = new HashSet<MethodInfo>();
		this.method_10(1);
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00004406 File Offset: 0x00002606
	public IDictionary<string> method_0()
	{
		return this.dictionary_1;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0000440E File Offset: 0x0000260E
	public IDictionary<string> method_1()
	{
		return this.dictionary_0;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00004416 File Offset: 0x00002616
	public HashSet<MethodInfo> method_2()
	{
		return this.hashSet_0;
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0000441E File Offset: 0x0000261E
	[CompilerGenerated]
	public bool method_3()
	{
		return this.bool_0;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00004426 File Offset: 0x00002626
	[CompilerGenerated]
	private void method_4(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0000442F File Offset: 0x0000262F
	[CompilerGenerated]
	public StringComparison method_5()
	{
		return this.stringComparison_0;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00004437 File Offset: 0x00002637
	[CompilerGenerated]
	private void method_6(StringComparison stringComparison_1)
	{
		this.stringComparison_0 = stringComparison_1;
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00004440 File Offset: 0x00002640
	[CompilerGenerated]
	public IEqualityComparer<string> method_7()
	{
		return this.iequalityComparer_0;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00004448 File Offset: 0x00002648
	[CompilerGenerated]
	private void method_8(IEqualityComparer<string> iequalityComparer_1)
	{
		this.iequalityComparer_0 = iequalityComparer_1;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00004451 File Offset: 0x00002651
	[CompilerGenerated]
	public  method_9()
	{
		return this.assignmentOperators_0;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00004459 File Offset: 0x00002659
	[CompilerGenerated]
	public void method_10(assignmentOperators_1)
	{
		this.assignmentOperators_0 = assignmentOperators_1;
	}

	// Token: 0x040001D5 RID: 469
	private readonly Dictionary<string> dictionary_0;

	// Token: 0x040001D6 RID: 470
	private readonly Dictionary<string> dictionary_1;

	// Token: 0x040001D7 RID: 471
	private readonly HashSet<MethodInfo> hashSet_0;

	// Token: 0x040001D8 RID: 472
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040001D9 RID: 473
	[CompilerGenerated]
	private StringComparison stringComparison_0;

	// Token: 0x040001DA RID: 474
	[CompilerGenerated]
	private IEqualityComparer<string> iequalityComparer_0;

	// Token: 0x040001DB RID: 475
	[CompilerGenerated]
	private  assignmentOperators_0;
}
