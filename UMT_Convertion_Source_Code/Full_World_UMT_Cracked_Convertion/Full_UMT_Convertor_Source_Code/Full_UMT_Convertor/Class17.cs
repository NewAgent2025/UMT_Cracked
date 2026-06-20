using System;

// Token: 0x02000061 RID: 97
internal class Class17
{
	// Token: 0x02000062 RID: 98
	public interface Interface0
	{
		// Token: 0x060003F2 RID: 1010
		void imethod_0(bool bool_0, bool bool_1);

		// Token: 0x060003F3 RID: 1011
		void imethod_1(bool? nullable_0, bool? nullable_1);
	}

	// Token: 0x02000063 RID: 99
	public interface Interface1
	{
		// Token: 0x060003F4 RID: 1012
		void imethod_0(int int_0, int int_1);

		// Token: 0x060003F5 RID: 1013
		void imethod_1(uint uint_0, uint uint_1);

		// Token: 0x060003F6 RID: 1014
		void imethod_2(long long_0, long long_1);

		// Token: 0x060003F7 RID: 1015
		void imethod_3(ulong ulong_0, ulong ulong_1);

		// Token: 0x060003F8 RID: 1016
		void imethod_4(float float_0, float float_1);

		// Token: 0x060003F9 RID: 1017
		void imethod_5(double double_0, double double_1);

		// Token: 0x060003FA RID: 1018
		void imethod_6(decimal decimal_0, decimal decimal_1);

		// Token: 0x060003FB RID: 1019
		void imethod_7(int? nullable_0, int? nullable_1);

		// Token: 0x060003FC RID: 1020
		void imethod_8(uint? nullable_0, uint? nullable_1);

		// Token: 0x060003FD RID: 1021
		void imethod_9(long? nullable_0, long? nullable_1);

		// Token: 0x060003FE RID: 1022
		void imethod_10(ulong? nullable_0, ulong? nullable_1);

		// Token: 0x060003FF RID: 1023
		void imethod_11(float? nullable_0, float? nullable_1);

		// Token: 0x06000400 RID: 1024
		void imethod_12(double? nullable_0, double? nullable_1);

		// Token: 0x06000401 RID: 1025
		void imethod_13(decimal? nullable_0, decimal? nullable_1);
	}

	// Token: 0x02000064 RID: 100
	public interface Interface2 : Class17.Interface1
	{
		// Token: 0x06000402 RID: 1026
		void imethod_14(string string_0, string string_1);

		// Token: 0x06000403 RID: 1027
		void imethod_15(char char_0, char char_1);

		// Token: 0x06000404 RID: 1028
		void imethod_16(DateTime dateTime_0, DateTime dateTime_1);

		// Token: 0x06000405 RID: 1029
		void imethod_17(TimeSpan timeSpan_0, TimeSpan timeSpan_1);

		// Token: 0x06000406 RID: 1030
		void imethod_18(char? nullable_0, char? nullable_1);

		// Token: 0x06000407 RID: 1031
		void imethod_19(DateTime? nullable_0, DateTime? nullable_1);

		// Token: 0x06000408 RID: 1032
		void imethod_20(TimeSpan? nullable_0, TimeSpan? nullable_1);
	}

	// Token: 0x02000065 RID: 101
	public interface Interface3 : Class17.Interface2, Class17.Interface1
	{
		// Token: 0x06000409 RID: 1033
		void imethod_21(bool bool_0, bool bool_1);

		// Token: 0x0600040A RID: 1034
		void imethod_22(bool? nullable_0, bool? nullable_1);
	}

	// Token: 0x02000066 RID: 102
	public interface Interface4 : Class17.Interface1
	{
		// Token: 0x0600040B RID: 1035
		void imethod_14(DateTime dateTime_0, TimeSpan timeSpan_0);

		// Token: 0x0600040C RID: 1036
		void imethod_15(TimeSpan timeSpan_0, TimeSpan timeSpan_1);

		// Token: 0x0600040D RID: 1037
		void imethod_16(DateTime? nullable_0, TimeSpan? nullable_1);

		// Token: 0x0600040E RID: 1038
		void imethod_17(TimeSpan? nullable_0, TimeSpan? nullable_1);
	}

	// Token: 0x02000067 RID: 103
	public interface Interface5 : Class17.Interface4, Class17.Interface1
	{
		// Token: 0x0600040F RID: 1039
		void imethod_18(DateTime dateTime_0, DateTime dateTime_1);

		// Token: 0x06000410 RID: 1040
		void imethod_19(DateTime? nullable_0, DateTime? nullable_1);
	}

	// Token: 0x02000068 RID: 104
	public interface Interface6
	{
		// Token: 0x06000411 RID: 1041
		void imethod_0(int int_0);

		// Token: 0x06000412 RID: 1042
		void imethod_1(long long_0);

		// Token: 0x06000413 RID: 1043
		void imethod_2(float float_0);

		// Token: 0x06000414 RID: 1044
		void imethod_3(double double_0);

		// Token: 0x06000415 RID: 1045
		void imethod_4(decimal decimal_0);

		// Token: 0x06000416 RID: 1046
		void imethod_5(int? nullable_0);

		// Token: 0x06000417 RID: 1047
		void imethod_6(long? nullable_0);

		// Token: 0x06000418 RID: 1048
		void imethod_7(float? nullable_0);

		// Token: 0x06000419 RID: 1049
		void imethod_8(double? nullable_0);

		// Token: 0x0600041A RID: 1050
		void imethod_9(decimal? nullable_0);
	}

	// Token: 0x02000069 RID: 105
	public interface Interface7
	{
		// Token: 0x0600041B RID: 1051
		void imethod_0(bool bool_0);

		// Token: 0x0600041C RID: 1052
		void imethod_1(bool? nullable_0);
	}
}
