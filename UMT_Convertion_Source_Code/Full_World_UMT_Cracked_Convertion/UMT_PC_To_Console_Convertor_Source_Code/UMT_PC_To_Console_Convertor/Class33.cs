using System;
using System.IO;
using UMT_PC_To_Console_Convertor.utils;

// Token: 0x020000BF RID: 191
internal class Class33
{
	// Token: 0x0600080B RID: 2059 RVA: 0x0000679B File Offset: 0x0000499B
	public short method_0()
	{
		return this.short_0;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x000067A3 File Offset: 0x000049A3
	public void method_1(short short_2)
	{
		this.short_0 = short_2;
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x000067AC File Offset: 0x000049AC
	public short method_2()
	{
		return this.short_1;
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x000067B4 File Offset: 0x000049B4
	public void method_3(short short_2)
	{
		this.short_1 = short_2;
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0002F9A8 File Offset: 0x0002DBA8
	internal static Class33 smethod_0(BinaryReader binaryReader_0)
	{
		binaryReader_0.BaseStream.Seek(8L, SeekOrigin.Begin);
		short short_ = FileUtils.ReadShort(binaryReader_0);
		short short_2 = FileUtils.ReadShort(binaryReader_0);
		Class33 @class = new Class33();
		@class.method_1(short_2);
		@class.method_3(short_);
		return @class;
	}

	// Token: 0x0400051A RID: 1306
	private short short_0;

	// Token: 0x0400051B RID: 1307
	private short short_1;
}
