using System;
using System.IO;
using Full_UMT_Convertor.utils;

// Token: 0x02000104 RID: 260
internal class Class38
{
	// Token: 0x06000B19 RID: 2841 RVA: 0x00007AD2 File Offset: 0x00005CD2
	public short method_0()
	{
		return this.short_0;
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00007ADA File Offset: 0x00005CDA
	public void method_1(short short_2)
	{
		this.short_0 = short_2;
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00007AE3 File Offset: 0x00005CE3
	public short method_2()
	{
		return this.short_1;
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00007AEB File Offset: 0x00005CEB
	public void method_3(short short_2)
	{
		this.short_1 = short_2;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x000546B8 File Offset: 0x000528B8
	internal static Class38 smethod_0(BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Seek(8L, SeekOrigin.Begin);
		short short_ = FileUtils.ReadShort(binaryReader_0);
		short short_2 = FileUtils.ReadShort(binaryReader_0);
		Class38 @class = new Class38();
		@class.method_1(short_2);
		@class.method_3(short_);
		return @class;
	}

	// Token: 0x04000757 RID: 1879
	private short short_0;

	// Token: 0x04000758 RID: 1880
	private short short_1;
}
