using System;
using System.Collections.Generic;
using Full_UMT_Convertor.model;

// Token: 0x02000023 RID: 35
internal class Class3
{
	// Token: 0x06000137 RID: 311 RVA: 0x00002DD9 File Offset: 0x00000FD9
	public Class3()
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002DEC File Offset: 0x00000FEC
	public Class3(string string_1, Dictionary<string, BlockStateProperty> dictionary_1)
	{
		this.string_0 = string_1;
		this.dictionary_0 = dictionary_1;
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000139 RID: 313 RVA: 0x00002E0D File Offset: 0x0000100D
	// (set) Token: 0x0600013A RID: 314 RVA: 0x00002E15 File Offset: 0x00001015
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

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600013B RID: 315 RVA: 0x00002E1E File Offset: 0x0000101E
	// (set) Token: 0x0600013C RID: 316 RVA: 0x00002E26 File Offset: 0x00001026
	public Dictionary<string, BlockStateProperty> Properties
	{
		get
		{
			return this.dictionary_0;
		}
		set
		{
			this.dictionary_0 = value;
		}
	}

	// Token: 0x040000B7 RID: 183
	private string string_0;

	// Token: 0x040000B8 RID: 184
	private Dictionary<string, BlockStateProperty> dictionary_0 = new Dictionary<string, BlockStateProperty>();
}
