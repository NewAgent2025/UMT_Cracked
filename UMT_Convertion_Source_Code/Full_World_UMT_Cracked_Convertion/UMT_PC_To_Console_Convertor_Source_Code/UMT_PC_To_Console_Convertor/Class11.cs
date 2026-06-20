using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000042 RID: 66
internal class Class11
{
	// Token: 0x060002E8 RID: 744 RVA: 0x000040E8 File Offset: 0x000022E8
	public static Expression smethod_0(Class9 class9_1)
	{
		return new Class11(class9_1).method_0();
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0001806C File Offset: 0x0001626C
	private Class11(Class9 class9_1)
	{
		this.class9_0 = class9_1;
		this.bindingFlags_0 = (class9_1.method_0().method_3() ? BindingFlags.IgnoreCase : BindingFlags.Default);
		this.memberFilter_0 = (class9_1.method_0().method_3() ? Type.FilterNameIgnoreCase : Type.FilterName);
		string text;
		if ((text = class9_1.method_2()) == null)
		{
			text = string.Empty;
		}
		this.string_0 = text;
		this.int_1 = this.string_0.Length;
		this.method_61(0);
		this.method_64();
	}

	// Token: 0x060002EA RID: 746 RVA: 0x000180F4 File Offset: 0x000162F4
	private Expression method_0()
	{
		Expression result = this.method_1(this.class9_0.method_4());
		this.method_68((Enum0)1, "Syntax error");
		return result;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00018120 File Offset: 0x00016320
	private Expression method_1(Type type_0)
	{
		int int_ = this.struct5_0.int_0;
		Expression expression = this.method_2();
		if (type_0 != typeof(void))
		{
			return this.method_30(expression, type_0, int_);
		}
		return expression;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x000040F5 File Offset: 0x000022F5
	private Expression method_2()
	{
		return this.method_3();
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00018160 File Offset: 0x00016360
	private Expression method_3()
	{
		/*
An exception occurred when decompiling this method (060002ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class11::method_3()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060002EE RID: 750 RVA: 0x000181FC File Offset: 0x000163FC
	private Expression method_4()
	{
		int int_ = this.struct5_0.int_0;
		Expression expression = this.method_5();
		if (this.struct5_0.enum0_0 == (Enum0)20)
		{
			this.method_64();
			Expression expression_ = this.method_2();
			this.method_68((Enum0)17, "':' expected");
			this.method_64();
			Expression expression_2 = this.method_2();
			expression = this.method_24(expression, expression_, expression_2, int_);
		}
		return expression;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00018260 File Offset: 0x00016460
	private Expression method_5()
	{
		Expression expression = this.method_6();
		while (this.struct5_0.enum0_0 == (Enum0)29)
		{
			Struct5 @struct = this.struct5_0;
			this.method_64();
			Expression right = this.method_6();
			this.method_39(typeof(Class16.Interface0), @struct.string_0, ref expression, ref right, @struct.int_0);
			expression = Expression.OrElse(expression, right);
		}
		return expression;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x000182C4 File Offset: 0x000164C4
	private Expression method_6()
	{
		Expression expression = this.method_7();
		while (this.struct5_0.enum0_0 == (Enum0)25)
		{
			Struct5 @struct = this.struct5_0;
			this.method_64();
			Expression right = this.method_7();
			this.method_39(typeof(Class16.Interface0), @struct.string_0, ref expression, ref right, @struct.int_0);
			expression = Expression.AndAlso(expression, right);
		}
		return expression;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00018328 File Offset: 0x00016528
	private Expression method_7()
	{
		Expression expression = this.method_8();
		while (this.struct5_0.enum0_0 == (Enum0)27 || this.struct5_0.enum0_0 == (Enum0)24 || this.struct5_0.enum0_0 == (Enum0)19 || this.struct5_0.enum0_0 == (Enum0)28 || this.struct5_0.enum0_0 == (Enum0)18 || this.struct5_0.enum0_0 == (Enum0)26)
		{
			Struct5 @struct = this.struct5_0;
			this.method_64();
			Expression expression_ = this.method_9();
			this.method_39((@struct.enum0_0 == (Enum0)27 || @struct.enum0_0 == (Enum0)24) ? typeof(Class16.Interface3) : typeof(Class16.Interface2), @struct.string_0, ref expression, ref expression_, @struct.int_0);
			switch (@struct.enum0_0)
			{
			case (Enum0)18:
				expression = this.method_54(expression, expression_);
				break;
			case (Enum0)19:
				expression = this.method_52(expression, expression_);
				break;
			case (Enum0)24:
				expression = this.method_51(expression, expression_);
				break;
			case (Enum0)26:
				expression = this.method_55(expression, expression_);
				break;
			case (Enum0)27:
				expression = this.method_50(expression, expression_);
				break;
			case (Enum0)28:
				expression = this.method_53(expression, expression_);
				break;
			}
		}
		return expression;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x000184B0 File Offset: 0x000166B0
	private Expression method_8()
	{
		Expression expression = this.method_9();
		while (this.struct5_0.string_0 == "is" || this.struct5_0.string_0 == "as")
		{
			string a = this.struct5_0.string_0;
			Struct5 @struct = this.struct5_0;
			this.method_64();
			Type type;
			if (!this.class9_0.method_10(this.struct5_0.string_0, out type))
			{
				throw this.method_70(@struct.int_0, "Type identifier expected", new object[0]);
			}
			if (a == "is")
			{
				expression = Expression.TypeIs(expression, type);
			}
			else
			{
				if (!(a == "as"))
				{
					throw this.method_70(this.struct5_0.int_0, "Syntax error", new object[0]);
				}
				expression = Expression.TypeAs(expression, type);
			}
			this.method_64();
		}
		return expression;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00018598 File Offset: 0x00016798
	private Expression method_9()
	{
		Expression expression = this.method_10();
		while (this.struct5_0.enum0_0 == (Enum0)12 || this.struct5_0.enum0_0 == (Enum0)14)
		{
			Struct5 @struct = this.struct5_0;
			this.method_64();
			Expression expression2 = this.method_10();
			switch (@struct.enum0_0)
			{
			case (Enum0)12:
				if (expression.Type == typeof(string) || expression2.Type == typeof(string))
				{
					expression = this.method_58(expression, expression2);
				}
				else
				{
					this.method_39(typeof(Class16.Interface4), @struct.string_0, ref expression, ref expression2, @struct.int_0);
					expression = this.method_56(expression, expression2);
				}
				break;
			case (Enum0)14:
				this.method_39(typeof(Class16.Interface5), @struct.string_0, ref expression, ref expression2, @struct.int_0);
				expression = this.method_57(expression, expression2);
				break;
			}
		}
		return expression;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00018698 File Offset: 0x00016898
	private Expression method_10()
	{
		Expression expression = this.method_11();
		while (this.struct5_0.enum0_0 == (Enum0)11 || this.struct5_0.enum0_0 == (Enum0)16 || this.struct5_0.enum0_0 == (Enum0)8)
		{
			Struct5 @struct = this.struct5_0;
			this.method_64();
			Expression right = this.method_11();
			this.method_39(typeof(Class16.Interface1), @struct.string_0, ref expression, ref right, @struct.int_0);
			Enum0 enum0_ = @struct.enum0_0;
			if (enum0_ != (Enum0)8)
			{
				if (enum0_ != (Enum0)11)
				{
					if (enum0_ == (Enum0)16)
					{
						expression = Expression.Divide(expression, right);
					}
				}
				else
				{
					expression = Expression.Multiply(expression, right);
				}
			}
			else
			{
				expression = Expression.Modulo(expression, right);
			}
		}
		return expression;
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00018750 File Offset: 0x00016950
	private Expression method_11()
	{
		if (this.struct5_0.enum0_0 != (Enum0)14 && this.struct5_0.enum0_0 != (Enum0)7)
		{
			if (this.struct5_0.enum0_0 != (Enum0)12)
			{
				return this.method_12();
			}
		}
		Struct5 @struct = this.struct5_0;
		this.method_64();
		if (this.struct5_0.enum0_0 != (Enum0)5)
		{
			if (this.struct5_0.enum0_0 != (Enum0)6)
			{
				goto IL_4B;
			}
		}
		if (@struct.enum0_0 == (Enum0)14)
		{
			this.struct5_0.string_0 = "-" + this.struct5_0.string_0;
			this.struct5_0.int_0 = @struct.int_0;
			return this.method_12();
		}
		if (@struct.enum0_0 == (Enum0)12)
		{
			this.struct5_0.string_0 = "+" + this.struct5_0.string_0;
			this.struct5_0.int_0 = @struct.int_0;
			return this.method_12();
		}
		IL_4B:
		Expression expression = this.method_11();
		if (@struct.enum0_0 == (Enum0)14)
		{
			this.method_38(typeof(Class16.Interface6), @struct.string_0, ref expression, @struct.int_0);
			expression = Expression.Negate(expression);
		}
		else if (@struct.enum0_0 != (Enum0)12 && @struct.enum0_0 == (Enum0)7)
		{
			this.method_38(typeof(Class16.Interface7), @struct.string_0, ref expression, @struct.int_0);
			expression = Expression.Not(expression);
		}
		return expression;
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x000188E0 File Offset: 0x00016AE0
	private Expression method_12()
	{
		int int_ = this.struct5_0.int_0;
		Expression expression = this.method_13();
		LambdaExpression lambdaExpression;
		for (;;)
		{
			if (this.struct5_0.enum0_0 == (Enum0)15)
			{
				this.method_64();
				expression = this.method_31(null, expression);
			}
			else if (this.struct5_0.enum0_0 == (Enum0)21)
			{
				expression = this.method_37(expression);
			}
			else
			{
				if (this.struct5_0.enum0_0 != (Enum0)9)
				{
					break;
				}
				lambdaExpression = (expression as LambdaExpression);
				if (lambdaExpression != null)
				{
					goto IL_B2;
				}
				if (!typeof(Delegate).IsAssignableFrom(expression.Type))
				{
					goto IL_8F;
				}
				expression = this.method_27(expression, int_);
			}
		}
		return expression;
		IL_8F:
		throw this.method_70(int_, "No applicable method exists in type '{0}'", new object[]
		{
			Class11.smethod_4(expression.Type)
		});
		IL_B2:
		return this.method_26(lambdaExpression, int_);
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x000189A8 File Offset: 0x00016BA8
	private Expression method_13()
	{
		switch (this.struct5_0.enum0_0)
		{
		case (Enum0)1:
			return Expression.Empty();
		case (Enum0)2:
			return this.method_22();
		case (Enum0)3:
			return this.method_14();
		case (Enum0)4:
			return this.method_15();
		case (Enum0)5:
			return this.method_18();
		case (Enum0)6:
			return this.method_19();
		case (Enum0)9:
			return this.method_21();
		}
		throw this.method_70(this.struct5_0.int_0, "Expression expected", new object[0]);
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00018A3C File Offset: 0x00016C3C
	private Expression method_14()
	{
		this.method_69((Enum0)3);
		string text = this.struct5_0.string_0.Substring(1, this.struct5_0.string_0.Length - 2);
		text = this.method_16(text);
		if (text.Length != 1)
		{
			throw this.method_70(this.struct5_0.int_0, "Character literal must contain exactly one character", new object[0]);
		}
		this.method_64();
		return this.method_20(text[0], text);
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00018ABC File Offset: 0x00016CBC
	private Expression method_15()
	{
		this.method_69((Enum0)4);
		string text = this.struct5_0.string_0.Substring(1, this.struct5_0.string_0.Length - 2);
		text = this.method_16(text);
		this.method_64();
		return this.method_20(text, text);
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00018B0C File Offset: 0x00016D0C
	private string method_16(string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < string_1.Length; i++)
		{
			char c = string_1[i];
			if (c == '\\')
			{
				if (i + 1 == string_1.Length)
				{
					throw this.method_70(this.struct5_0.int_0, "Invalid character escape sequence", new object[0]);
				}
				stringBuilder.Append(this.method_17(string_1[++i]));
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00018B94 File Offset: 0x00016D94
	private char method_17(char char_1)
	{
		if (char_1 <= '\\')
		{
			if (char_1 <= '\'')
			{
				if (char_1 == '"')
				{
					return '"';
				}
				if (char_1 == '\'')
				{
					return '\'';
				}
			}
			else
			{
				if (char_1 == '0')
				{
					return '\0';
				}
				if (char_1 == '\\')
				{
					return '\\';
				}
			}
		}
		else if (char_1 <= 'f')
		{
			switch (char_1)
			{
			case 'a':
				return '\a';
			case 'b':
				return '\b';
			default:
				if (char_1 == 'f')
				{
					return '\f';
				}
				break;
			}
		}
		else
		{
			if (char_1 == 'n')
			{
				return '\n';
			}
			switch (char_1)
			{
			case 'r':
				return '\r';
			case 't':
				return '\t';
			case 'v':
				return '\v';
			}
		}
		throw this.method_70(this.struct5_0.int_0, "Invalid character escape sequence", new object[0]);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00018C48 File Offset: 0x00016E48
	private Expression method_18()
	{
		this.method_69((Enum0)5);
		string text = this.struct5_0.string_0;
		if (text[0] != '-')
		{
			ulong num;
			if (!ulong.TryParse(text, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num))
			{
				throw this.method_70(this.struct5_0.int_0, "Invalid integer literal '{0}'", new object[]
				{
					text
				});
			}
			this.method_64();
			if (num <= 2147483647UL)
			{
				return this.method_20((int)num, text);
			}
			if (num <= 4294967295UL)
			{
				return this.method_20((uint)num, text);
			}
			if (num <= 9223372036854775807UL)
			{
				return this.method_20((long)num, text);
			}
			return this.method_20(num, text);
		}
		else
		{
			long num2;
			if (!long.TryParse(text, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num2))
			{
				throw this.method_70(this.struct5_0.int_0, "Invalid integer literal '{0}'", new object[]
				{
					text
				});
			}
			this.method_64();
			if (num2 < -2147483648L || num2 > 2147483647L)
			{
				return this.method_20(num2, text);
			}
			return this.method_20((int)num2, text);
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00018D7C File Offset: 0x00016F7C
	private Expression method_19()
	{
		this.method_69((Enum0)6);
		string text = this.struct5_0.string_0;
		object obj = null;
		char c = text[text.Length - 1];
		if (c != 'F')
		{
			if (c != 'f')
			{
				if (c != 'M')
				{
					if (c != 'm')
					{
						double num;
						if (double.TryParse(text, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class11.cultureInfo_0, out num))
						{
							obj = num;
							goto IL_51;
						}
						goto IL_51;
					}
				}
				decimal num2;
				if (decimal.TryParse(text.Substring(0, text.Length - 1), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class11.cultureInfo_0, out num2))
				{
					obj = num2;
					goto IL_51;
				}
				goto IL_51;
			}
		}
		float num3;
		if (float.TryParse(text.Substring(0, text.Length - 1), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class11.cultureInfo_0, out num3))
		{
			obj = num3;
		}
		IL_51:
		if (obj == null)
		{
			throw this.method_70(this.struct5_0.int_0, "Invalid real literal '{0}'", new object[]
			{
				text
			});
		}
		this.method_64();
		return this.method_20(obj, text);
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00018E74 File Offset: 0x00017074
	private Expression method_20(object object_0, string string_1)
	{
		return Expression.Constant(object_0);
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00018E8C File Offset: 0x0001708C
	private Expression method_21()
	{
		this.method_68((Enum0)9, "'(' expected");
		this.method_64();
		Expression expression = this.method_2();
		this.method_68((Enum0)10, "')' or operator expected");
		ConstantExpression constantExpression = expression as ConstantExpression;
		if (constantExpression == null || !(constantExpression.Value is Type))
		{
			this.method_64();
			return expression;
		}
		this.method_64();
		Expression expression2 = this.method_2();
		return Expression.Convert(expression2, (Type)constantExpression.Value);
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00018F00 File Offset: 0x00017100
	private Expression method_22()
	{
		/*
An exception occurred when decompiling this method (06000300)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class11::method_22()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00018FD4 File Offset: 0x000171D4
	private Expression method_23()
	{
		int int_ = this.struct5_0.int_0;
		this.method_64();
		Expression[] array = this.method_36();
		if (array.Length != 1)
		{
			throw this.method_70(int_, "The 'typeof' keyword requires 1 argument", new object[0]);
		}
		ConstantExpression constantExpression = array[0] as ConstantExpression;
		if (constantExpression.Type == null)
		{
			throw this.method_70(int_, "The 'typeof' keyword requires a type as an argument", new object[0]);
		}
		return constantExpression;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0001903C File Offset: 0x0001723C
	private Expression method_24(Expression expression_0, Expression expression_1, Expression expression_2, int int_2)
	{
		if (expression_0.Type != typeof(bool))
		{
			throw this.method_70(int_2, "The first expression must be of type 'Boolean'", new object[0]);
		}
		if (expression_1.Type != expression_2.Type)
		{
			Expression expression = (expression_2 != Class14.expression_0) ? this.method_48(expression_1, expression_2.Type, true) : null;
			Expression expression2 = (expression_1 != Class14.expression_0) ? this.method_48(expression_2, expression_1.Type, true) : null;
			if (expression == null || expression2 != null)
			{
				if (expression2 == null || expression != null)
				{
					string text = (expression_1 != Class14.expression_0) ? expression_1.Type.Name : "null";
					string text2 = (expression_2 != Class14.expression_0) ? expression_2.Type.Name : "null";
					if (expression == null || expression2 == null)
					{
						throw this.method_70(int_2, "Neither of the types '{0}' and '{1}' converts to the other", new object[]
						{
							text,
							text2
						});
					}
					throw this.method_70(int_2, "Both of the types '{0}' and '{1}' convert to the other", new object[]
					{
						text,
						text2
					});
				}
				else
				{
					expression_2 = expression2;
				}
			}
			else
			{
				expression_1 = expression;
			}
		}
		return Expression.Condition(expression_0, expression_1, expression_2);
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00019168 File Offset: 0x00017368
	private Expression method_25()
	{
		/*
An exception occurred when decompiling this method (06000303)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class11::method_25()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00019238 File Offset: 0x00017438
	private Expression method_26(LambdaExpression lambdaExpression_0, int int_2)
	{
		Expression[] arguments = this.method_36();
		if (!this.method_28(lambdaExpression_0.Type, ref arguments))
		{
			throw this.method_70(int_2, "Argument list incompatible with lambda expression", new object[0]);
		}
		return Expression.Invoke(lambdaExpression_0, arguments);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00019278 File Offset: 0x00017478
	private Expression method_27(Expression expression_0, int int_2)
	{
		Expression[] arguments = this.method_36();
		if (!this.method_28(expression_0.Type, ref arguments))
		{
			throw this.method_70(int_2, "Argument list incompatible with delegate expression", new object[0]);
		}
		return Expression.Invoke(expression_0, arguments);
	}

	// Token: 0x06000306 RID: 774 RVA: 0x000192B8 File Offset: 0x000174B8
	private bool method_28(Type type_0, ref Expression[] expression_0)
	{
		Class11.Class12[] array = this.method_42(type_0, "Invoke", false, expression_0);
		if (array.Length != 1)
		{
			return false;
		}
		expression_0 = array[0].expression_0;
		return true;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x000192EC File Offset: 0x000174EC
	private Expression method_29(Type type_0)
	{
		int int_ = this.struct5_0.int_0;
		this.method_64();
		if (this.struct5_0.enum0_0 == (Enum0)20)
		{
			if (!type_0.IsValueType || Class11.smethod_2(type_0))
			{
				throw this.method_70(int_, "Type '{0}' has no nullable form", new object[]
				{
					Class11.smethod_4(type_0)
				});
			}
			type_0 = typeof(Nullable<>).MakeGenericType(new Type[]
			{
				type_0
			});
			this.method_64();
		}
		if (this.struct5_0.enum0_0 == (Enum0)10)
		{
			return Expression.Constant(type_0);
		}
		this.method_68((Enum0)15, "'.' or '(' expected");
		this.method_64();
		return this.method_31(type_0, null);
	}

	// Token: 0x06000308 RID: 776 RVA: 0x000193A4 File Offset: 0x000175A4
	private Expression method_30(Expression expression_0, Type type_0, int int_2)
	{
		Type type = expression_0.Type;
		if (type == type_0)
		{
			return expression_0;
		}
		Expression result;
		try
		{
			result = Expression.ConvertChecked(expression_0, type_0);
		}
		catch (InvalidOperationException)
		{
			throw this.method_70(int_2, "A value of type '{0}' cannot be converted to type '{1}'", new object[]
			{
				Class11.smethod_4(type),
				Class11.smethod_4(type_0)
			});
		}
		return result;
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00019408 File Offset: 0x00017608
	private Expression method_31(Type type_0, Expression expression_0)
	{
		if (expression_0 != null)
		{
			type_0 = expression_0.Type;
		}
		int int_ = this.struct5_0.int_0;
		string string_ = this.method_66();
		this.method_64();
		if (this.struct5_0.enum0_0 == (Enum0)9)
		{
			return this.method_33(type_0, expression_0, int_, string_);
		}
		return this.method_32(type_0, expression_0, int_, string_);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00019460 File Offset: 0x00017660
	private Expression method_32(Type type_0, Expression expression_0, int int_2, string string_1)
	{
		MemberInfo memberInfo = this.method_41(type_0, string_1, expression_0 == null);
		if (!(memberInfo != null))
		{
			throw this.method_70(int_2, "No property or field '{0}' exists in type '{1}'", new object[]
			{
				string_1,
				Class11.smethod_4(type_0)
			});
		}
		if (!(memberInfo is PropertyInfo))
		{
			return Expression.Field(expression_0, (FieldInfo)memberInfo);
		}
		return Expression.Property(expression_0, (PropertyInfo)memberInfo);
	}

	// Token: 0x0600030B RID: 779 RVA: 0x000194C8 File Offset: 0x000176C8
	private Expression method_33(Type type_0, Expression expression_0, int int_2, string string_1)
	{
		/*
An exception occurred when decompiling this method (0600030B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class11::method_33(System.Type,System.Linq.Expressions.Expression,System.Int32,System.String)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00019514 File Offset: 0x00017714
	private Expression method_34(Type type_0, Expression expression_0, int int_2, string string_1, Expression[] expression_1)
	{
		Expression[] array = new Expression[expression_1.Length + 1];
		array[0] = expression_0;
		expression_1.CopyTo(array, 1);
		Class11.Class12[] array2 = this.method_43(type_0, string_1, array);
		if (array2.Length > 1)
		{
			throw this.method_70(int_2, "Ambiguous invocation of method '{0}' in type '{1}'", new object[]
			{
				string_1,
				Class11.smethod_4(type_0)
			});
		}
		if (array2.Length == 1)
		{
			Class11.Class12 @class = array2[0];
			array = @class.expression_0;
			return Expression.Call((MethodInfo)@class.methodBase_0, array);
		}
		return null;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00019594 File Offset: 0x00017794
	private Expression method_35(Type type_0, Expression expression_0, int int_2, string string_1, Expression[] expression_1)
	{
		Class11.Class12[] array = this.method_42(type_0, string_1, expression_0 == null, expression_1);
		if (array.Length > 1)
		{
			throw this.method_70(int_2, "Ambiguous invocation of method '{0}' in type '{1}'", new object[]
			{
				string_1,
				Class11.smethod_4(type_0)
			});
		}
		if (array.Length == 1)
		{
			Class11.Class12 @class = array[0];
			return Expression.Call(expression_0, (MethodInfo)@class.methodBase_0, @class.expression_0);
		}
		return null;
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00019600 File Offset: 0x00017800
	private static Type smethod_1(Type type_0, Type type_1)
	{
		while (type_1 != null && type_1 != typeof(object))
		{
			if (type_1.IsGenericType && type_1.GetGenericTypeDefinition() == type_0)
			{
				return type_1;
			}
			if (type_0.IsInterface)
			{
				foreach (Type type_2 in type_1.GetInterfaces())
				{
					Type type = Class11.smethod_1(type_0, type_2);
					if (type != null)
					{
						return type;
					}
				}
			}
			type_1 = type_1.BaseType;
		}
		return null;
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0001968C File Offset: 0x0001788C
	private Expression[] method_36()
	{
		this.method_68((Enum0)9, "'(' expected");
		this.method_64();
		Expression[] result = (this.struct5_0.enum0_0 != (Enum0)10) ? this.onakCaTlJn() : new Expression[0];
		this.method_68((Enum0)10, "')' or ',' expected");
		this.method_64();
		return result;
	}

	// Token: 0x06000310 RID: 784 RVA: 0x000196E0 File Offset: 0x000178E0
	private Expression[] onakCaTlJn()
	{
		List<Expression> list = new List<Expression>();
		for (;;)
		{
			list.Add(this.method_2());
			if (this.struct5_0.enum0_0 != (Enum0)13)
			{
				break;
			}
			this.method_64();
		}
		return list.ToArray();
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0001971C File Offset: 0x0001791C
	private Expression method_37(Expression expression_0)
	{
		int int_ = this.struct5_0.int_0;
		this.method_68((Enum0)21, "'(' expected");
		this.method_64();
		Expression[] array = this.onakCaTlJn();
		this.method_68((Enum0)22, "']' or ',' expected");
		this.method_64();
		if (expression_0.Type.IsArray)
		{
			if (expression_0.Type.GetArrayRank() == 1)
			{
				if (array.Length == 1)
				{
					Expression expression = this.method_48(array[0], typeof(int), true);
					if (expression == null)
					{
						throw this.method_70(int_, "Array index must be an integer expression", new object[0]);
					}
					return Expression.ArrayIndex(expression_0, expression);
				}
			}
			throw this.method_70(int_, "Indexing of multi-dimensional arrays is not supported", new object[0]);
		}
		Class11.Class12[] array2 = this.method_44(expression_0.Type, array);
		if (array2.Length == 0)
		{
			throw this.method_70(int_, "No applicable indexer exists in type '{0}'", new object[]
			{
				Class11.smethod_4(expression_0.Type)
			});
		}
		if (array2.Length > 1)
		{
			throw this.method_70(int_, "Ambiguous invocation of indexer in type '{0}'", new object[]
			{
				Class11.smethod_4(expression_0.Type)
			});
		}
		Class11.Class12 @class = array2[0];
		return Expression.Call(expression_0, (MethodInfo)@class.methodBase_0, @class.expression_0);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x000040FD File Offset: 0x000022FD
	private static bool smethod_2(Type type_0)
	{
		return type_0.IsGenericType && type_0.GetGenericTypeDefinition() == typeof(Nullable<>);
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000411E File Offset: 0x0000231E
	private static Type smethod_3(Type type_0)
	{
		if (!Class11.smethod_2(type_0))
		{
			return type_0;
		}
		return type_0.GetGenericArguments()[0];
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00019858 File Offset: 0x00017A58
	private static string smethod_4(Type type_0)
	{
		Type type = Class11.smethod_3(type_0);
		string text = type.Name;
		if (type_0 != type)
		{
			text += '?';
		}
		return text;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00004132 File Offset: 0x00002332
	private static bool smethod_5(Type type_0)
	{
		return Class11.smethod_8(type_0) != 0;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00004140 File Offset: 0x00002340
	private static bool smethod_6(Type type_0)
	{
		return Class11.smethod_8(type_0) == 2;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000414B File Offset: 0x0000234B
	private static bool smethod_7(Type type_0)
	{
		return Class11.smethod_8(type_0) == 3;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0001988C File Offset: 0x00017A8C
	private static int smethod_8(Type type_0)
	{
		type_0 = Class11.smethod_3(type_0);
		if (type_0.IsEnum)
		{
			return 0;
		}
		switch (Type.GetTypeCode(type_0))
		{
		case TypeCode.Char:
		case TypeCode.Single:
		case TypeCode.Double:
		case TypeCode.Decimal:
			return 1;
		case TypeCode.SByte:
		case TypeCode.Int16:
		case TypeCode.Int32:
		case TypeCode.Int64:
			return 2;
		case TypeCode.Byte:
		case TypeCode.UInt16:
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			return 3;
		default:
			return 0;
		}
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00004156 File Offset: 0x00002356
	private static bool smethod_9(Type type_0)
	{
		return Class11.smethod_3(type_0).IsEnum;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x000198F4 File Offset: 0x00017AF4
	private void method_38(Type type_0, string string_1, ref Expression expression_0, int int_2)
	{
		Expression[] array = new Expression[]
		{
			expression_0
		};
		array = this.method_40(type_0, array);
		expression_0 = array[0];
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00019920 File Offset: 0x00017B20
	private void method_39(Type type_0, string string_1, ref Expression expression_0, ref Expression expression_1, int int_2)
	{
		Expression[] array = new Expression[]
		{
			expression_0,
			expression_1
		};
		array = this.method_40(type_0, array);
		expression_0 = array[0];
		expression_1 = array[1];
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00019958 File Offset: 0x00017B58
	private Expression[] method_40(Type type_0, Expression[] expression_0)
	{
		Class11.Class12[] array = this.method_42(type_0, "F", false, expression_0);
		if (array.Length == 1)
		{
			return array[0].expression_0;
		}
		return expression_0;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00019988 File Offset: 0x00017B88
	private MemberInfo method_41(Type type_0, string string_1, bool bool_0)
	{
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (bool_0 ? BindingFlags.Static : BindingFlags.Instance) | this.bindingFlags_0;
		foreach (Type type in Class11.smethod_10(type_0))
		{
			MemberInfo[] array = type.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, this.memberFilter_0, string_1);
			if (array.Length != 0)
			{
				return array[0];
			}
		}
		return null;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00019A04 File Offset: 0x00017C04
	private Class11.Class12[] method_42(Type type_0, string string_1, bool bool_0, Expression[] expression_0)
	{
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (bool_0 ? BindingFlags.Static : BindingFlags.Instance) | this.bindingFlags_0;
		foreach (Type type in Class11.smethod_10(type_0))
		{
			MemberInfo[] source = type.FindMembers(MemberTypes.Method, bindingAttr, this.memberFilter_0, string_1);
			Class11.Class12[] array = this.method_45(source.Cast<MethodBase>(), expression_0);
			if (array.Length > 0)
			{
				return array;
			}
		}
		return new Class11.Class12[0];
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00019A94 File Offset: 0x00017C94
	private Class11.Class12[] method_43(Type type_0, string string_1, Expression[] expression_0)
	{
		IEnumerable<MethodInfo> source = this.class9_0.method_13(string_1);
		return this.method_45(source.Cast<MethodBase>(), expression_0);
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00019ABC File Offset: 0x00017CBC
	private Class11.Class12[] method_44(Type type_0, Expression[] expression_0)
	{
		foreach (Type type in Class11.smethod_10(type_0))
		{
			MemberInfo[] defaultMembers = type.GetDefaultMembers();
			if (defaultMembers.Length != 0)
			{
				IEnumerable<PropertyInfo> source = defaultMembers.OfType<PropertyInfo>();
				if (Class11.func_1 == null)
				{
					Class11.func_1 = new Func<PropertyInfo, MethodBase>(Class11.smethod_18);
				}
				IEnumerable<MethodBase> source2 = source.Select(Class11.func_1);
				if (Class11.func_2 == null)
				{
					Class11.func_2 = new Func<MethodBase, bool>(Class11.smethod_19);
				}
				IEnumerable<MethodBase> ienumerable_ = source2.Where(Class11.func_2);
				Class11.Class12[] array = this.method_45(ienumerable_, expression_0);
				if (array.Length > 0)
				{
					return array;
				}
			}
		}
		return new Class11.Class12[0];
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00019B80 File Offset: 0x00017D80
	private static IEnumerable<Type> smethod_10(Type type_0)
	{
		if (type_0.IsInterface)
		{
			List<Type> list = new List<Type>();
			Class11.smethod_12(list, type_0);
			list.Add(typeof(object));
			return list;
		}
		return Class11.smethod_11(type_0);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00019BBC File Offset: 0x00017DBC
	private static IEnumerable<Type> smethod_11(Type type_0)
	{
		Class11.<SelfAndBaseClasses>d__6 <SelfAndBaseClasses>d__ = new Class11.<SelfAndBaseClasses>d__6(-2);
		<SelfAndBaseClasses>d__.<>3__type = type_0;
		return <SelfAndBaseClasses>d__;
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00019BDC File Offset: 0x00017DDC
	private static void smethod_12(List<Type> list_0, Type type_0)
	{
		if (!list_0.Contains(type_0))
		{
			list_0.Add(type_0);
			foreach (Type type_ in type_0.GetInterfaces())
			{
				Class11.smethod_12(list_0, type_);
			}
		}
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00019C1C File Offset: 0x00017E1C
	private Class11.Class12[] method_45(IEnumerable<MethodBase> ienumerable_0, Expression[] expression_0)
	{
		Class11.<>c__DisplayClass10 CS$<>8__locals1 = new Class11.<>c__DisplayClass10();
		CS$<>8__locals1.args = expression_0;
		CS$<>8__locals1.<>4__this = this;
		Class11.<>c__DisplayClass10 CS$<>8__locals2 = CS$<>8__locals1;
		if (Class11.func_3 == null)
		{
			Class11.func_3 = new Func<MethodBase, Class11.Class12>(Class11.smethod_20);
		}
		CS$<>8__locals2.applicable = (from m in ienumerable_0.Select(Class11.func_3)
		where CS$<>8__locals1.<>4__this.method_46(m, CS$<>8__locals1.args)
		select m).ToArray<Class11.Class12>();
		if (CS$<>8__locals1.applicable.Length > 1)
		{
			CS$<>8__locals1.applicable = CS$<>8__locals1.applicable.Where(delegate(Class11.Class12 m)
			{
				Class11.<>c__DisplayClass10.Class13 @class = new Class11.<>c__DisplayClass10.Class13();
				@class.<>c__DisplayClass10_0 = CS$<>8__locals1;
				@class.class12_0 = m;
				return CS$<>8__locals1.applicable.All(new Func<Class11.Class12, bool>(@class.method_0));
			}).ToArray<Class11.Class12>();
		}
		return CS$<>8__locals1.applicable;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00019CB8 File Offset: 0x00017EB8
	private bool method_46(Class11.Class12 class12_0, Expression[] expression_0)
	{
		if (class12_0.parameterInfo_0.Length > expression_0.Length)
		{
			return false;
		}
		List<Expression> list = new List<Expression>();
		int num = 0;
		Type type = null;
		List<Expression> list2 = null;
		int i = 0;
		while (i < expression_0.Length)
		{
			Expression expression = expression_0[i];
			Type type2;
			if (type != null)
			{
				type2 = type;
			}
			else
			{
				if (num >= class12_0.parameterInfo_0.Length)
				{
					return false;
				}
				ParameterInfo parameterInfo = class12_0.parameterInfo_0[num];
				if (parameterInfo.IsOut)
				{
					return false;
				}
				type2 = parameterInfo.ParameterType;
				if (parameterInfo.IsDefined(typeof(ParamArrayAttribute), false))
				{
					type = type2;
				}
				num++;
			}
			if (list2 != null)
			{
				goto IL_E9;
			}
			if (type2.IsGenericParameter)
			{
				list.Add(expression);
			}
			else
			{
				Expression expression2 = this.method_48(expression, type2, true);
				if (expression2 == null)
				{
					goto IL_E9;
				}
				list.Add(expression2);
			}
			IL_8D:
			i++;
			continue;
			IL_E9:
			if (type != null)
			{
				Expression expression3 = this.method_48(expression, type.GetElementType(), true);
				if (expression3 != null)
				{
					list2 = (list2 ?? new List<Expression>());
					list2.Add(expression3);
					goto IL_8D;
				}
			}
			return false;
		}
		if (list2 != null)
		{
			class12_0.bool_0 = true;
			list.Add(Expression.NewArrayInit(type.GetElementType(), list2));
		}
		class12_0.expression_0 = list.ToArray();
		if (class12_0.methodBase_0.IsGenericMethodDefinition && class12_0.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)class12_0.methodBase_0;
			IEnumerable<ParameterInfo> parameterInfo_ = class12_0.parameterInfo_0;
			if (Class11.func_4 == null)
			{
				Class11.func_4 = new Func<ParameterInfo, Type>(Class11.smethod_21);
			}
			Type[] type_ = parameterInfo_.Select(Class11.func_4).ToArray<Type>();
			IEnumerable<Expression> expression_ = class12_0.expression_0;
			if (Class11.func_5 == null)
			{
				Class11.func_5 = new Func<Expression, Type>(Class11.smethod_22);
			}
			List<Type> list3 = this.method_47(type_, expression_.Select(Class11.func_5).ToArray<Type>());
			class12_0.methodBase_0 = methodInfo.MakeGenericMethod(list3.ToArray());
		}
		return true;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00019EA4 File Offset: 0x000180A4
	private List<Type> method_47(Type[] type_0, Type[] type_1)
	{
		List<Type> list = new List<Type>();
		for (int i = 0; i < type_0.Length; i++)
		{
			Type type = type_0[i];
			Type type2 = type_1[i];
			if (type.IsGenericParameter)
			{
				list.Add(type2);
			}
			else if (type.ContainsGenericParameters)
			{
				List<Type> collection = this.method_47(type.GetGenericArguments(), type2.GetGenericArguments());
				list.AddRange(collection);
			}
		}
		return list;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00019F04 File Offset: 0x00018104
	private Expression method_48(Expression expression_0, Type type_0, bool bool_0)
	{
		if (expression_0.Type == type_0)
		{
			return expression_0;
		}
		if (expression_0 is ConstantExpression)
		{
			ConstantExpression constantExpression = (ConstantExpression)expression_0;
			if (constantExpression == Class14.expression_0 && (!type_0.IsValueType || Class11.smethod_2(type_0)))
			{
				return Expression.Constant(null, type_0);
			}
		}
		if (type_0.IsGenericType)
		{
			Type type = Class11.smethod_14(expression_0.Type, type_0.GetGenericTypeDefinition());
			if (type != null)
			{
				return Expression.Convert(expression_0, type);
			}
		}
		if (!Class11.smethod_13(expression_0.Type, type_0))
		{
			return null;
		}
		if (type_0.IsValueType || bool_0)
		{
			return Expression.Convert(expression_0, type_0);
		}
		return expression_0;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00019FA4 File Offset: 0x000181A4
	private object method_49(string string_1, Type type_0)
	{
		switch (Type.GetTypeCode(Class11.smethod_3(type_0)))
		{
		case TypeCode.SByte:
		{
			sbyte b;
			if (sbyte.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out b))
			{
				return b;
			}
			break;
		}
		case TypeCode.Byte:
		{
			byte b2;
			if (byte.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out b2))
			{
				return b2;
			}
			break;
		}
		case TypeCode.Int16:
		{
			short num;
			if (short.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num))
			{
				return num;
			}
			break;
		}
		case TypeCode.UInt16:
		{
			ushort num2;
			if (ushort.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num2))
			{
				return num2;
			}
			break;
		}
		case TypeCode.Int32:
		{
			int num3;
			if (int.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num3))
			{
				return num3;
			}
			break;
		}
		case TypeCode.UInt32:
		{
			uint num4;
			if (uint.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num4))
			{
				return num4;
			}
			break;
		}
		case TypeCode.Int64:
		{
			long num5;
			if (long.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num5))
			{
				return num5;
			}
			break;
		}
		case TypeCode.UInt64:
		{
			ulong num6;
			if (ulong.TryParse(string_1, NumberStyles.AllowLeadingSign, Class11.cultureInfo_0, out num6))
			{
				return num6;
			}
			break;
		}
		case TypeCode.Single:
		{
			float num7;
			if (float.TryParse(string_1, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class11.cultureInfo_0, out num7))
			{
				return num7;
			}
			break;
		}
		case TypeCode.Double:
		{
			double num8;
			if (double.TryParse(string_1, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class11.cultureInfo_0, out num8))
			{
				return num8;
			}
			break;
		}
		case TypeCode.Decimal:
		{
			decimal num9;
			if (decimal.TryParse(string_1, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class11.cultureInfo_0, out num9))
			{
				return num9;
			}
			break;
		}
		}
		return null;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0001A10C File Offset: 0x0001830C
	private static bool smethod_13(Type type_0, Type type_1)
	{
		if (type_0 == type_1)
		{
			return true;
		}
		if (!type_1.IsValueType)
		{
			return type_1.IsAssignableFrom(type_0);
		}
		Type type = Class11.smethod_3(type_0);
		Type type2 = Class11.smethod_3(type_1);
		if (!(type != type_0) || !(type2 == type_1))
		{
			TypeCode typeCode = type.IsEnum ? TypeCode.Object : Type.GetTypeCode(type);
			TypeCode typeCode2 = type2.IsEnum ? TypeCode.Object : Type.GetTypeCode(type2);
			switch (typeCode)
			{
			case TypeCode.SByte:
				switch (typeCode2)
				{
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.Byte:
				switch (typeCode2)
				{
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.Int16:
				switch (typeCode2)
				{
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.UInt16:
				switch (typeCode2)
				{
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.Int32:
				switch (typeCode2)
				{
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.UInt32:
				switch (typeCode2)
				{
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.Int64:
				switch (typeCode2)
				{
				case TypeCode.Int64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.UInt64:
				switch (typeCode2)
				{
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.Single:
				switch (typeCode2)
				{
				case TypeCode.Single:
				case TypeCode.Double:
					return true;
				}
				break;
			default:
				if (type == type2)
				{
					return true;
				}
				break;
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0001A358 File Offset: 0x00018558
	private static Type smethod_14(Type type_0, Type type_1)
	{
		Type[] interfaces = type_0.GetInterfaces();
		foreach (Type type in interfaces)
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == type_1)
			{
				return type;
			}
		}
		if (type_0.IsGenericType && type_0.GetGenericTypeDefinition() == type_1)
		{
			return type_0;
		}
		Type baseType = type_0.BaseType;
		if (baseType == null)
		{
			return null;
		}
		return Class11.smethod_14(baseType, type_1);
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0001A3D8 File Offset: 0x000185D8
	private static bool smethod_15(Expression[] expression_0, Class11.Class12 class12_0, Class11.Class12 class12_1)
	{
		if (!class12_0.bool_0 && class12_1.bool_0)
		{
			return true;
		}
		if (!class12_0.bool_0 || class12_1.bool_0)
		{
			bool result = false;
			for (int i = 0; i < expression_0.Length; i++)
			{
				int num = Class11.smethod_16(expression_0[i].Type, class12_0.parameterInfo_0[i].ParameterType, class12_1.parameterInfo_0[i].ParameterType);
				if (num < 0)
				{
					return false;
				}
				if (num > 0)
				{
					result = true;
				}
			}
			return result;
		}
		return false;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0001A450 File Offset: 0x00018650
	private static int smethod_16(Type type_0, Type type_1, Type type_2)
	{
		if (type_1 == type_2)
		{
			return 0;
		}
		if (type_0 == type_1)
		{
			return 1;
		}
		if (type_0 == type_2)
		{
			return -1;
		}
		bool flag = type_1.IsAssignableFrom(type_0);
		bool flag2 = type_2.IsAssignableFrom(type_0);
		if (flag && !flag2)
		{
			return 1;
		}
		if (flag2 && !flag)
		{
			return -1;
		}
		bool flag3 = Class11.smethod_13(type_1, type_2);
		bool flag4 = Class11.smethod_13(type_2, type_1);
		if (flag3 && !flag4)
		{
			return 1;
		}
		if (flag4 && !flag3)
		{
			return -1;
		}
		if (Class11.smethod_6(type_1) && Class11.smethod_7(type_2))
		{
			return 1;
		}
		if (!Class11.smethod_6(type_2) || !Class11.smethod_7(type_1))
		{
			return 0;
		}
		return -1;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00004163 File Offset: 0x00002363
	private Expression method_50(Expression expression_0, Expression expression_1)
	{
		return Expression.Equal(expression_0, expression_1);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000416C File Offset: 0x0000236C
	private Expression method_51(Expression expression_0, Expression expression_1)
	{
		return Expression.NotEqual(expression_0, expression_1);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00004175 File Offset: 0x00002375
	private Expression method_52(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.GreaterThan(this.method_60("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.GreaterThan(expression_0, expression_1);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x000041B3 File Offset: 0x000023B3
	private Expression method_53(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.GreaterThanOrEqual(this.method_60("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.GreaterThanOrEqual(expression_0, expression_1);
	}

	// Token: 0x06000331 RID: 817 RVA: 0x000041F1 File Offset: 0x000023F1
	private Expression method_54(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.LessThan(this.method_60("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.LessThan(expression_0, expression_1);
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0000422F File Offset: 0x0000242F
	private Expression method_55(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.LessThanOrEqual(this.method_60("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.LessThanOrEqual(expression_0, expression_1);
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0001A4E4 File Offset: 0x000186E4
	private Expression method_56(Expression expression_0, Expression expression_1)
	{
		if (!(expression_0.Type == typeof(string)) || !(expression_1.Type == typeof(string)))
		{
			return Expression.Add(expression_0, expression_1);
		}
		return this.method_60("Concat", expression_0, expression_1);
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0000426D File Offset: 0x0000246D
	private Expression method_57(Expression expression_0, Expression expression_1)
	{
		return Expression.Subtract(expression_0, expression_1);
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0001A534 File Offset: 0x00018734
	private Expression method_58(Expression expression_0, Expression expression_1)
	{
		return Expression.Call(null, typeof(string).GetMethod("Concat", new Type[]
		{
			typeof(object),
			typeof(object)
		}), new Expression[]
		{
			expression_0,
			expression_1
		});
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0001A590 File Offset: 0x00018790
	private MethodInfo method_59(string string_1, Expression expression_0, Expression expression_1)
	{
		return expression_0.Type.GetMethod(string_1, new Type[]
		{
			expression_0.Type,
			expression_1.Type
		});
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0001A5C4 File Offset: 0x000187C4
	private Expression method_60(string string_1, Expression expression_0, Expression expression_1)
	{
		return Expression.Call(null, this.method_59(string_1, expression_0, expression_1), new Expression[]
		{
			expression_0,
			expression_1
		});
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00004276 File Offset: 0x00002476
	private void method_61(int int_2)
	{
		this.int_0 = int_2;
		this.char_0 = ((this.int_0 < this.int_1) ? this.string_0[this.int_0] : '\0');
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0001A5F0 File Offset: 0x000187F0
	private void method_62()
	{
		if (this.int_0 < this.int_1)
		{
			this.int_0++;
		}
		this.char_0 = ((this.int_0 < this.int_1) ? this.string_0[this.int_0] : '\0');
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000042A7 File Offset: 0x000024A7
	private void method_63()
	{
		this.method_61(this.int_0 - 1);
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0001A644 File Offset: 0x00018844
	private void method_64()
	{
		while (char.IsWhiteSpace(this.char_0))
		{
			this.method_62();
		}
		int num = this.int_0;
		char c = this.char_0;
		Enum0 enum0_;
		switch (c)
		{
		case '!':
			this.method_62();
			if (this.char_0 == '=')
			{
				this.method_62();
				enum0_ = (Enum0)24;
				goto IL_549;
			}
			enum0_ = (Enum0)7;
			goto IL_549;
		case '"':
		{
			this.method_62();
			bool flag = false;
			bool flag2 = this.char_0 == '"';
			while (this.int_0 < this.int_1 && !flag2)
			{
				flag = (this.char_0 == '\\' && !flag);
				this.method_62();
				flag2 = (this.char_0 == '"' && !flag);
			}
			if (this.int_0 == this.int_1)
			{
				throw this.method_70(this.int_0, "Unterminated string literal", new object[0]);
			}
			this.method_62();
			enum0_ = (Enum0)4;
			goto IL_549;
		}
		case '#':
		case '$':
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
		case ';':
			break;
		case '%':
			this.method_62();
			enum0_ = (Enum0)8;
			goto IL_549;
		case '&':
			this.method_62();
			if (this.char_0 == '&')
			{
				this.method_62();
				enum0_ = (Enum0)25;
				goto IL_549;
			}
			throw this.method_70(this.int_0, "Syntax error '{0}'", new object[]
			{
				this.char_0
			});
		case '\'':
		{
			this.method_62();
			bool flag3 = false;
			bool flag4 = false;
			while (this.int_0 < this.int_1 && !flag4)
			{
				flag3 = (this.char_0 == '\\' && !flag3);
				this.method_62();
				flag4 = (this.char_0 == '\'' && !flag3);
			}
			if (this.int_0 == this.int_1)
			{
				throw this.method_70(this.int_0, "Unterminated string literal", new object[0]);
			}
			this.method_62();
			enum0_ = (Enum0)3;
			goto IL_549;
		}
		case '(':
			this.method_62();
			enum0_ = (Enum0)9;
			goto IL_549;
		case ')':
			this.method_62();
			enum0_ = (Enum0)10;
			goto IL_549;
		case '*':
			this.method_62();
			enum0_ = (Enum0)11;
			goto IL_549;
		case '+':
			this.method_62();
			enum0_ = (Enum0)12;
			goto IL_549;
		case ',':
			this.method_62();
			enum0_ = (Enum0)13;
			goto IL_549;
		case '-':
			this.method_62();
			enum0_ = (Enum0)14;
			goto IL_549;
		case '.':
			this.method_62();
			enum0_ = (Enum0)15;
			goto IL_549;
		case '/':
			this.method_62();
			enum0_ = (Enum0)16;
			goto IL_549;
		case ':':
			this.method_62();
			enum0_ = (Enum0)17;
			goto IL_549;
		case '<':
			this.method_62();
			if (this.char_0 == '=')
			{
				this.method_62();
				enum0_ = (Enum0)26;
				goto IL_549;
			}
			enum0_ = (Enum0)18;
			goto IL_549;
		case '=':
			this.method_62();
			if (this.char_0 == '=')
			{
				this.method_62();
				enum0_ = (Enum0)27;
				goto IL_549;
			}
			enum0_ = (Enum0)30;
			goto IL_549;
		case '>':
			this.method_62();
			if (this.char_0 == '=')
			{
				this.method_62();
				enum0_ = (Enum0)28;
				goto IL_549;
			}
			enum0_ = (Enum0)19;
			goto IL_549;
		case '?':
			this.method_62();
			enum0_ = (Enum0)20;
			goto IL_549;
		default:
			switch (c)
			{
			case '[':
				this.method_62();
				enum0_ = (Enum0)21;
				goto IL_549;
			case '\\':
				break;
			case ']':
				this.method_62();
				enum0_ = (Enum0)22;
				goto IL_549;
			default:
				if (c == '|')
				{
					this.method_62();
					if (this.char_0 == '|')
					{
						this.method_62();
						enum0_ = (Enum0)29;
						goto IL_549;
					}
					enum0_ = (Enum0)23;
					goto IL_549;
				}
				break;
			}
			break;
		}
		if (!char.IsLetter(this.char_0) && this.char_0 != '@')
		{
			if (this.char_0 != '_')
			{
				if (char.IsDigit(this.char_0))
				{
					enum0_ = (Enum0)5;
					do
					{
						this.method_62();
					}
					while (char.IsDigit(this.char_0));
					if (this.char_0 == '.')
					{
						this.method_62();
						if (!char.IsDigit(this.char_0))
						{
							this.method_63();
							goto IL_549;
						}
						enum0_ = (Enum0)6;
						do
						{
							this.method_62();
						}
						while (char.IsDigit(this.char_0));
					}
					if (this.char_0 != 'E')
					{
						if (this.char_0 != 'e')
						{
							goto IL_46D;
						}
					}
					enum0_ = (Enum0)6;
					this.method_62();
					if (this.char_0 != '+')
					{
						if (this.char_0 != '-')
						{
							goto IL_454;
						}
					}
					this.method_62();
					IL_454:
					this.method_67();
					do
					{
						this.method_62();
					}
					while (char.IsDigit(this.char_0));
					IL_46D:
					if (this.char_0 != 'F' && this.char_0 != 'f' && this.char_0 != 'M')
					{
						if (this.char_0 != 'm')
						{
							goto IL_549;
						}
					}
					this.method_62();
					goto IL_549;
				}
				if (this.int_0 == this.int_1)
				{
					enum0_ = (Enum0)1;
					goto IL_549;
				}
				throw this.method_70(this.int_0, "Syntax error '{0}'", new object[]
				{
					this.char_0
				});
			}
		}
		do
		{
			this.method_62();
		}
		while (char.IsLetterOrDigit(this.char_0) || this.char_0 == '_');
		enum0_ = (Enum0)2;
		IL_549:
		this.struct5_0.enum0_0 = enum0_;
		this.struct5_0.string_0 = this.string_0.Substring(num, this.int_0 - num);
		this.struct5_0.int_0 = num;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x000042B7 File Offset: 0x000024B7
	private bool method_65(string string_1)
	{
		return this.struct5_0.enum0_0 == (Enum0)2 && string.Equals(string_1, this.struct5_0.string_0, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0001ABD4 File Offset: 0x00018DD4
	private string method_66()
	{
		this.method_68((Enum0)2, "Identifier expected");
		string text = this.struct5_0.string_0;
		if (text.Length > 1 && text[0] == '@')
		{
			text = text.Substring(1);
		}
		return text;
	}

	// Token: 0x0600033E RID: 830 RVA: 0x000042DD File Offset: 0x000024DD
	private void method_67()
	{
		if (!char.IsDigit(this.char_0))
		{
			throw this.method_70(this.int_0, "Digit expected", new object[0]);
		}
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00004304 File Offset: 0x00002504
	private void method_68(Enum0 enum0_0, string string_1)
	{
		if (this.struct5_0.enum0_0 != enum0_0)
		{
			throw this.method_70(this.struct5_0.int_0, string_1, new object[0]);
		}
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0000432D File Offset: 0x0000252D
	private void method_69(Enum0 enum0_0)
	{
		if (this.struct5_0.enum0_0 != enum0_0)
		{
			throw this.method_70(this.struct5_0.int_0, "Syntax error", new object[0]);
		}
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0000435A File Offset: 0x0000255A
	private Exception method_70(int int_2, string string_1, params object[] args)
	{
		/*
An exception occurred when decompiling this method (06000341)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception Class11::method_70(System.Int32,System.String,System.Object[])

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 51
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00004369 File Offset: 0x00002569
	[CompilerGenerated]
	private static Type smethod_17(Expression expression_0)
	{
		return expression_0.Type;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00004371 File Offset: 0x00002571
	[CompilerGenerated]
	private static MethodBase smethod_18(PropertyInfo propertyInfo_0)
	{
		return propertyInfo_0.GetGetMethod();
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00004379 File Offset: 0x00002579
	[CompilerGenerated]
	private static bool smethod_19(MethodBase methodBase_0)
	{
		return methodBase_0 != null;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0001AC18 File Offset: 0x00018E18
	[CompilerGenerated]
	private static Class11.Class12 smethod_20(MethodBase methodBase_0)
	{
		return new Class11.Class12
		{
			methodBase_0 = methodBase_0,
			parameterInfo_0 = methodBase_0.GetParameters()
		};
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00004382 File Offset: 0x00002582
	[CompilerGenerated]
	private static Type smethod_21(ParameterInfo parameterInfo_0)
	{
		return parameterInfo_0.ParameterType;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00004369 File Offset: 0x00002569
	[CompilerGenerated]
	private static Type smethod_22(Expression expression_0)
	{
		return expression_0.Type;
	}

	// Token: 0x040001B6 RID: 438
	private static CultureInfo cultureInfo_0 = CultureInfo.InvariantCulture;

	// Token: 0x040001B7 RID: 439
	private Class9 class9_0;

	// Token: 0x040001B8 RID: 440
	private int int_0;

	// Token: 0x040001B9 RID: 441
	private string string_0;

	// Token: 0x040001BA RID: 442
	private int int_1;

	// Token: 0x040001BB RID: 443
	private char char_0;

	// Token: 0x040001BC RID: 444
	private Struct5 struct5_0;

	// Token: 0x040001BD RID: 445
	private BindingFlags bindingFlags_0;

	// Token: 0x040001BE RID: 446
	private MemberFilter memberFilter_0;

	// Token: 0x040001BF RID: 447
	[CompilerGenerated]
	private static Func<Expression, Type> func_0;

	// Token: 0x040001C0 RID: 448
	[CompilerGenerated]
	private static Func<PropertyInfo, MethodBase> func_1;

	// Token: 0x040001C1 RID: 449
	[CompilerGenerated]
	private static Func<MethodBase, bool> func_2;

	// Token: 0x040001C2 RID: 450
	[CompilerGenerated]
	private static Func<MethodBase, Class11.Class12> func_3;

	// Token: 0x040001C3 RID: 451
	[CompilerGenerated]
	private static Func<ParameterInfo, Type> func_4;

	// Token: 0x040001C4 RID: 452
	[CompilerGenerated]
	private static Func<Expression, Type> func_5;

	// Token: 0x02000043 RID: 67
	private class Class12
	{
		// Token: 0x040001C5 RID: 453
		public MethodBase methodBase_0;

		// Token: 0x040001C6 RID: 454
		public ParameterInfo[] parameterInfo_0;

		// Token: 0x040001C7 RID: 455
		public Expression[] expression_0;

		// Token: 0x040001C8 RID: 456
		public bool bool_0;
	}
}
