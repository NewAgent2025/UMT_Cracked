using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200005A RID: 90
internal class Class12
{
	// Token: 0x06000375 RID: 885 RVA: 0x000043DF File Offset: 0x000025DF
	public static Expression smethod_0(Class10 class10_1)
	{
		return new Class12(class10_1).method_0();
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
	private Class12(Class10 class10_1)
	{
		this.class10_0 = class10_1;
		this.bindingFlags_0 = (class10_1.method_0().method_3() ? BindingFlags.IgnoreCase : BindingFlags.Default);
		this.memberFilter_0 = (class10_1.method_0().method_3() ? Type.FilterNameIgnoreCase : Type.FilterName);
		string text;
		if ((text = class10_1.method_2()) == null)
		{
			text = string.Empty;
		}
		this.string_0 = text;
		this.int_0 = this.string_0.Length;
		this.method_60(0);
		this.method_63();
	}

	// Token: 0x06000377 RID: 887 RVA: 0x0001C96C File Offset: 0x0001AB6C
	private Expression method_0()
	{
		Expression result = this.method_1(this.class10_0.method_3());
		this.method_67((Enum0)1, "Syntax error");
		return result;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x0001C998 File Offset: 0x0001AB98
	private Expression method_1(Type type_0)
	{
		int int_ = this.struct5_0.int_0;
		Expression expression = this.method_2();
		if (type_0 != typeof(void))
		{
			return this.method_28(expression, type_0, int_);
		}
		return expression;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x000043EC File Offset: 0x000025EC
	private Expression method_2()
	{
		return this.method_3();
	}

	// Token: 0x0600037A RID: 890 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
	private Expression method_3()
	{
		/*
An exception occurred when decompiling this method (0600037A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class12::method_3()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x0001CA74 File Offset: 0x0001AC74
	private Expression method_4()
	{
		int int_ = this.struct5_0.int_0;
		Expression expression = this.method_5();
		if (this.struct5_0.enum0_0 == (Enum0)20)
		{
			this.method_63();
			Expression expression_ = this.method_2();
			this.method_67((Enum0)17, "':' expected");
			this.method_63();
			Expression expression_2 = this.method_2();
			expression = this.method_23(expression, expression_, expression_2, int_);
		}
		return expression;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
	private Expression method_5()
	{
		Expression expression = this.method_6();
		while (this.struct5_0.enum0_0 == (Enum0)29)
		{
			Struct5 @struct = this.struct5_0;
			this.method_63();
			Expression right = this.method_6();
			this.method_38(typeof(Class17.Interface0), @struct.string_0, ref expression, ref right, @struct.int_0);
			expression = Expression.OrElse(expression, right);
		}
		return expression;
	}

	// Token: 0x0600037D RID: 893 RVA: 0x0001CB3C File Offset: 0x0001AD3C
	private Expression method_6()
	{
		Expression expression = this.method_7();
		while (this.struct5_0.enum0_0 == (Enum0)25)
		{
			Struct5 @struct = this.struct5_0;
			this.method_63();
			Expression right = this.method_7();
			this.method_38(typeof(Class17.Interface0), @struct.string_0, ref expression, ref right, @struct.int_0);
			expression = Expression.AndAlso(expression, right);
		}
		return expression;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
	private Expression method_7()
	{
		Expression expression = this.method_8();
		while (this.struct5_0.enum0_0 == (Enum0)27 || this.struct5_0.enum0_0 == (Enum0)24 || this.struct5_0.enum0_0 == (Enum0)19 || this.struct5_0.enum0_0 == (Enum0)28 || this.struct5_0.enum0_0 == (Enum0)18 || this.struct5_0.enum0_0 == (Enum0)26)
		{
			Struct5 @struct = this.struct5_0;
			this.method_63();
			Expression expression_ = this.method_9();
			this.method_38((@struct.enum0_0 == (Enum0)27 || @struct.enum0_0 == (Enum0)24) ? typeof(Class17.Interface3) : typeof(Class17.Interface2), @struct.string_0, ref expression, ref expression_, @struct.int_0);
			switch (@struct.enum0_0)
			{
			case (Enum0)18:
				expression = this.method_53(expression, expression_);
				break;
			case (Enum0)19:
				expression = this.method_51(expression, expression_);
				break;
			case (Enum0)24:
				expression = this.method_50(expression, expression_);
				break;
			case (Enum0)26:
				expression = this.method_54(expression, expression_);
				break;
			case (Enum0)27:
				expression = this.method_49(expression, expression_);
				break;
			case (Enum0)28:
				expression = this.method_52(expression, expression_);
				break;
			}
		}
		return expression;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0001CD28 File Offset: 0x0001AF28
	private Expression method_8()
	{
		Expression expression = this.method_9();
		while (this.struct5_0.string_0 == "is" || this.struct5_0.string_0 == "as")
		{
			string a = this.struct5_0.string_0;
			Struct5 @struct = this.struct5_0;
			this.method_63();
			Type type;
			if (!this.class10_0.method_9(this.struct5_0.string_0, out type))
			{
				throw this.method_69(@struct.int_0, "Type identifier expected", new object[0]);
			}
			if (a == "is")
			{
				expression = Expression.TypeIs(expression, type);
			}
			else
			{
				if (!(a == "as"))
				{
					throw this.method_69(this.struct5_0.int_0, "Syntax error", new object[0]);
				}
				expression = Expression.TypeAs(expression, type);
			}
			this.method_63();
		}
		return expression;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0001CE10 File Offset: 0x0001B010
	private Expression method_9()
	{
		Expression expression = this.method_10();
		while (this.struct5_0.enum0_0 == (Enum0)12 || this.struct5_0.enum0_0 == (Enum0)14)
		{
			Struct5 @struct = this.struct5_0;
			this.method_63();
			Expression expression2 = this.method_10();
			switch (@struct.enum0_0)
			{
			case (Enum0)12:
				if (expression.Type == typeof(string) || expression2.Type == typeof(string))
				{
					expression = this.method_57(expression, expression2);
				}
				else
				{
					this.method_38(typeof(Class17.Interface4), @struct.string_0, ref expression, ref expression2, @struct.int_0);
					expression = this.method_55(expression, expression2);
				}
				break;
			case (Enum0)14:
				this.method_38(typeof(Class17.Interface5), @struct.string_0, ref expression, ref expression2, @struct.int_0);
				expression = this.method_56(expression, expression2);
				break;
			}
		}
		return expression;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0001CF10 File Offset: 0x0001B110
	private Expression method_10()
	{
		Expression expression = this.method_11();
		while (this.struct5_0.enum0_0 == (Enum0)11 || this.struct5_0.enum0_0 == (Enum0)16 || this.struct5_0.enum0_0 == (Enum0)8)
		{
			Struct5 @struct = this.struct5_0;
			this.method_63();
			Expression right = this.method_11();
			this.method_38(typeof(Class17.Interface1), @struct.string_0, ref expression, ref right, @struct.int_0);
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

	// Token: 0x06000382 RID: 898 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
	private Expression method_11()
	{
		if (this.struct5_0.enum0_0 != (Enum0)14 && this.struct5_0.enum0_0 != (Enum0)7)
		{
			if (this.struct5_0.enum0_0 != (Enum0)12)
			{
				return this.IgDiaMbnlE();
			}
		}
		Struct5 @struct = this.struct5_0;
		this.method_63();
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
			return this.IgDiaMbnlE();
		}
		if (@struct.enum0_0 == (Enum0)12)
		{
			this.struct5_0.string_0 = "+" + this.struct5_0.string_0;
			this.struct5_0.int_0 = @struct.int_0;
			return this.IgDiaMbnlE();
		}
		IL_4B:
		Expression expression = this.method_11();
		if (@struct.enum0_0 == (Enum0)14)
		{
			this.method_37(typeof(Class17.Interface6), @struct.string_0, ref expression, @struct.int_0);
			expression = Expression.Negate(expression);
		}
		else if (@struct.enum0_0 != (Enum0)12 && @struct.enum0_0 == (Enum0)7)
		{
			this.method_37(typeof(Class17.Interface7), @struct.string_0, ref expression, @struct.int_0);
			expression = Expression.Not(expression);
		}
		return expression;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x0001D158 File Offset: 0x0001B358
	private Expression IgDiaMbnlE()
	{
		int int_ = this.struct5_0.int_0;
		Expression expression = this.method_12();
		LambdaExpression lambdaExpression;
		for (;;)
		{
			if (this.struct5_0.enum0_0 == (Enum0)15)
			{
				this.method_63();
				expression = this.method_29(null, expression);
			}
			else if (this.struct5_0.enum0_0 == (Enum0)21)
			{
				expression = this.method_36(expression);
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
				expression = this.method_25(expression, int_);
			}
		}
		return expression;
		IL_8F:
		throw this.method_69(int_, "No applicable method exists in type '{0}'", new object[]
		{
			Class12.YaqifOiZcW(expression.Type)
		});
		IL_B2:
		return this.MrYigLoXu3(lambdaExpression, int_);
	}

	// Token: 0x06000384 RID: 900 RVA: 0x0001D220 File Offset: 0x0001B420
	private Expression method_12()
	{
		switch (this.struct5_0.enum0_0)
		{
		case (Enum0)1:
			return Expression.Empty();
		case (Enum0)2:
			return this.method_21();
		case (Enum0)3:
			return this.method_13();
		case (Enum0)4:
			return this.method_14();
		case (Enum0)5:
			return this.method_17();
		case (Enum0)6:
			return this.method_18();
		case (Enum0)9:
			return this.method_20();
		}
		throw this.method_69(this.struct5_0.int_0, "Expression expected", new object[0]);
	}

	// Token: 0x06000385 RID: 901 RVA: 0x0001D2B4 File Offset: 0x0001B4B4
	private Expression method_13()
	{
		this.method_68((Enum0)3);
		string text = this.struct5_0.string_0.Substring(1, this.struct5_0.string_0.Length - 2);
		text = this.method_15(text);
		if (text.Length != 1)
		{
			throw this.method_69(this.struct5_0.int_0, "Character literal must contain exactly one character", new object[0]);
		}
		this.method_63();
		return this.method_19(text[0], text);
	}

	// Token: 0x06000386 RID: 902 RVA: 0x0001D334 File Offset: 0x0001B534
	private Expression method_14()
	{
		this.method_68((Enum0)4);
		string text = this.struct5_0.string_0.Substring(1, this.struct5_0.string_0.Length - 2);
		text = this.method_15(text);
		this.method_63();
		return this.method_19(text, text);
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0001D384 File Offset: 0x0001B584
	private string method_15(string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < string_1.Length; i++)
		{
			char c = string_1[i];
			if (c == '\\')
			{
				if (i + 1 == string_1.Length)
				{
					throw this.method_69(this.struct5_0.int_0, "Invalid character escape sequence", new object[0]);
				}
				stringBuilder.Append(this.method_16(string_1[++i]));
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0001D40C File Offset: 0x0001B60C
	private char method_16(char char_1)
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
		throw this.method_69(this.struct5_0.int_0, "Invalid character escape sequence", new object[0]);
	}

	// Token: 0x06000389 RID: 905 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
	private Expression method_17()
	{
		this.method_68((Enum0)5);
		string text = this.struct5_0.string_0;
		if (text[0] != '-')
		{
			ulong num;
			if (!ulong.TryParse(text, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num))
			{
				throw this.method_69(this.struct5_0.int_0, "Invalid integer literal '{0}'", new object[]
				{
					text
				});
			}
			this.method_63();
			if (num <= 2147483647UL)
			{
				return this.method_19((int)num, text);
			}
			if (num <= 4294967295UL)
			{
				return this.method_19((uint)num, text);
			}
			if (num <= 9223372036854775807UL)
			{
				return this.method_19((long)num, text);
			}
			return this.method_19(num, text);
		}
		else
		{
			long num2;
			if (!long.TryParse(text, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num2))
			{
				throw this.method_69(this.struct5_0.int_0, "Invalid integer literal '{0}'", new object[]
				{
					text
				});
			}
			this.method_63();
			if (num2 < -2147483648L || num2 > 2147483647L)
			{
				return this.method_19(num2, text);
			}
			return this.method_19((int)num2, text);
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
	private Expression method_18()
	{
		this.method_68((Enum0)6);
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
						if (double.TryParse(text, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class12.cultureInfo_0, out num))
						{
							obj = num;
							goto IL_51;
						}
						goto IL_51;
					}
				}
				decimal num2;
				if (decimal.TryParse(text.Substring(0, text.Length - 1), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class12.cultureInfo_0, out num2))
				{
					obj = num2;
					goto IL_51;
				}
				goto IL_51;
			}
		}
		float num3;
		if (float.TryParse(text.Substring(0, text.Length - 1), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class12.cultureInfo_0, out num3))
		{
			obj = num3;
		}
		IL_51:
		if (obj == null)
		{
			throw this.method_69(this.struct5_0.int_0, "Invalid real literal '{0}'", new object[]
			{
				text
			});
		}
		this.method_63();
		return this.method_19(obj, text);
	}

	// Token: 0x0600038B RID: 907 RVA: 0x0001D6EC File Offset: 0x0001B8EC
	private Expression method_19(object object_0, string string_1)
	{
		return Expression.Constant(object_0);
	}

	// Token: 0x0600038C RID: 908 RVA: 0x0001D704 File Offset: 0x0001B904
	private Expression method_20()
	{
		this.method_67((Enum0)9, "'(' expected");
		this.method_63();
		Expression expression = this.method_2();
		this.method_67((Enum0)10, "')' or operator expected");
		ConstantExpression constantExpression = expression as ConstantExpression;
		if (constantExpression == null || !(constantExpression.Value is Type))
		{
			this.method_63();
			return expression;
		}
		this.method_63();
		Expression expression2 = this.method_2();
		return Expression.Convert(expression2, (Type)constantExpression.Value);
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0001D778 File Offset: 0x0001B978
	private Expression method_21()
	{
		/*
An exception occurred when decompiling this method (0600038D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class12::method_21()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0001D84C File Offset: 0x0001BA4C
	private Expression method_22()
	{
		int int_ = this.struct5_0.int_0;
		this.method_63();
		Expression[] array = this.method_34();
		if (array.Length != 1)
		{
			throw this.method_69(int_, "The 'typeof' keyword requires 1 argument", new object[0]);
		}
		ConstantExpression constantExpression = array[0] as ConstantExpression;
		if (constantExpression.Type == null)
		{
			throw this.method_69(int_, "The 'typeof' keyword requires a type as an argument", new object[0]);
		}
		return constantExpression;
	}

	// Token: 0x0600038F RID: 911 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
	private Expression method_23(Expression expression_0, Expression expression_1, Expression expression_2, int int_1)
	{
		if (expression_0.Type != typeof(bool))
		{
			throw this.method_69(int_1, "The first expression must be of type 'Boolean'", new object[0]);
		}
		if (expression_1.Type != expression_2.Type)
		{
			Expression expression = (expression_2 != Class15.expression_0) ? this.method_47(expression_1, expression_2.Type, true) : null;
			Expression expression2 = (expression_1 != Class15.expression_0) ? this.method_47(expression_2, expression_1.Type, true) : null;
			if (expression == null || expression2 != null)
			{
				if (expression2 == null || expression != null)
				{
					string text = (expression_1 != Class15.expression_0) ? expression_1.Type.Name : "null";
					string text2 = (expression_2 != Class15.expression_0) ? expression_2.Type.Name : "null";
					if (expression == null || expression2 == null)
					{
						throw this.method_69(int_1, "Neither of the types '{0}' and '{1}' converts to the other", new object[]
						{
							text,
							text2
						});
					}
					throw this.method_69(int_1, "Both of the types '{0}' and '{1}' convert to the other", new object[]
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

	// Token: 0x06000390 RID: 912 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
	private Expression method_24()
	{
		/*
An exception occurred when decompiling this method (06000390)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class12::method_24()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0001DAB0 File Offset: 0x0001BCB0
	private Expression MrYigLoXu3(LambdaExpression lambdaExpression_0, int int_1)
	{
		Expression[] arguments = this.method_34();
		if (!this.method_26(lambdaExpression_0.Type, ref arguments))
		{
			throw this.method_69(int_1, "Argument list incompatible with lambda expression", new object[0]);
		}
		return Expression.Invoke(lambdaExpression_0, arguments);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
	private Expression method_25(Expression expression_0, int int_1)
	{
		Expression[] arguments = this.method_34();
		if (!this.method_26(expression_0.Type, ref arguments))
		{
			throw this.method_69(int_1, "Argument list incompatible with delegate expression", new object[0]);
		}
		return Expression.Invoke(expression_0, arguments);
	}

	// Token: 0x06000393 RID: 915 RVA: 0x0001DB30 File Offset: 0x0001BD30
	private bool method_26(Type type_0, ref Expression[] expression_0)
	{
		Class12.Class13[] array = this.method_41(type_0, "Invoke", false, expression_0);
		if (array.Length != 1)
		{
			return false;
		}
		expression_0 = array[0].expression_0;
		return true;
	}

	// Token: 0x06000394 RID: 916 RVA: 0x0001DB64 File Offset: 0x0001BD64
	private Expression method_27(Type type_0)
	{
		int int_ = this.struct5_0.int_0;
		this.method_63();
		if (this.struct5_0.enum0_0 == (Enum0)20)
		{
			if (!type_0.IsValueType || Class12.smethod_2(type_0))
			{
				throw this.method_69(int_, "Type '{0}' has no nullable form", new object[]
				{
					Class12.YaqifOiZcW(type_0)
				});
			}
			type_0 = typeof(Nullable<>).MakeGenericType(new Type[]
			{
				type_0
			});
			this.method_63();
		}
		if (this.struct5_0.enum0_0 == (Enum0)10)
		{
			return Expression.Constant(type_0);
		}
		this.method_67((Enum0)15, "'.' or '(' expected");
		this.method_63();
		return this.method_29(type_0, null);
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0001DC1C File Offset: 0x0001BE1C
	private Expression method_28(Expression expression_0, Type type_0, int int_1)
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
			throw this.method_69(int_1, "A value of type '{0}' cannot be converted to type '{1}'", new object[]
			{
				Class12.YaqifOiZcW(type),
				Class12.YaqifOiZcW(type_0)
			});
		}
		return result;
	}

	// Token: 0x06000396 RID: 918 RVA: 0x0001DC80 File Offset: 0x0001BE80
	private Expression method_29(Type type_0, Expression expression_0)
	{
		if (expression_0 != null)
		{
			type_0 = expression_0.Type;
		}
		int int_ = this.struct5_0.int_0;
		string string_ = this.method_65();
		this.method_63();
		if (this.struct5_0.enum0_0 == (Enum0)9)
		{
			return this.method_31(type_0, expression_0, int_, string_);
		}
		return this.method_30(type_0, expression_0, int_, string_);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0001DCD8 File Offset: 0x0001BED8
	private Expression method_30(Type type_0, Expression expression_0, int int_1, string string_1)
	{
		MemberInfo memberInfo = this.method_40(type_0, string_1, expression_0 == null);
		if (!(memberInfo != null))
		{
			throw this.method_69(int_1, "No property or field '{0}' exists in type '{1}'", new object[]
			{
				string_1,
				Class12.YaqifOiZcW(type_0)
			});
		}
		if (!(memberInfo is PropertyInfo))
		{
			return Expression.Field(expression_0, (FieldInfo)memberInfo);
		}
		return Expression.Property(expression_0, (PropertyInfo)memberInfo);
	}

	// Token: 0x06000398 RID: 920 RVA: 0x0001DD40 File Offset: 0x0001BF40
	private Expression method_31(Type type_0, Expression expression_0, int int_1, string string_1)
	{
		/*
An exception occurred when decompiling this method (06000398)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Expressions.Expression Class12::method_31(System.Type,System.Linq.Expressions.Expression,System.Int32,System.String)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0001DD8C File Offset: 0x0001BF8C
	private Expression method_32(Type type_0, Expression expression_0, int int_1, string string_1, Expression[] expression_1)
	{
		Expression[] array = new Expression[expression_1.Length + 1];
		array[0] = expression_0;
		expression_1.CopyTo(array, 1);
		Class12.Class13[] array2 = this.method_42(type_0, string_1, array);
		if (array2.Length > 1)
		{
			throw this.method_69(int_1, "Ambiguous invocation of method '{0}' in type '{1}'", new object[]
			{
				string_1,
				Class12.YaqifOiZcW(type_0)
			});
		}
		if (array2.Length == 1)
		{
			Class12.Class13 @class = array2[0];
			array = @class.expression_0;
			return Expression.Call((MethodInfo)@class.methodBase_0, array);
		}
		return null;
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0001DE0C File Offset: 0x0001C00C
	private Expression method_33(Type type_0, Expression expression_0, int int_1, string string_1, Expression[] expression_1)
	{
		Class12.Class13[] array = this.method_41(type_0, string_1, expression_0 == null, expression_1);
		if (array.Length > 1)
		{
			throw this.method_69(int_1, "Ambiguous invocation of method '{0}' in type '{1}'", new object[]
			{
				string_1,
				Class12.YaqifOiZcW(type_0)
			});
		}
		if (array.Length == 1)
		{
			Class12.Class13 @class = array[0];
			return Expression.Call(expression_0, (MethodInfo)@class.methodBase_0, @class.expression_0);
		}
		return null;
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0001DE78 File Offset: 0x0001C078
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
					Type type = Class12.smethod_1(type_0, type_2);
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

	// Token: 0x0600039C RID: 924 RVA: 0x0001DF04 File Offset: 0x0001C104
	private Expression[] method_34()
	{
		this.method_67((Enum0)9, "'(' expected");
		this.method_63();
		Expression[] result = (this.struct5_0.enum0_0 != (Enum0)10) ? this.method_35() : new Expression[0];
		this.method_67((Enum0)10, "')' or ',' expected");
		this.method_63();
		return result;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0001DF58 File Offset: 0x0001C158
	private Expression[] method_35()
	{
		List<Expression> list = new List<Expression>();
		for (;;)
		{
			list.Add(this.method_2());
			if (this.struct5_0.enum0_0 != (Enum0)13)
			{
				break;
			}
			this.method_63();
		}
		return list.ToArray();
	}

	// Token: 0x0600039E RID: 926 RVA: 0x0001DF94 File Offset: 0x0001C194
	private Expression method_36(Expression expression_0)
	{
		int int_ = this.struct5_0.int_0;
		this.method_67((Enum0)21, "'(' expected");
		this.method_63();
		Expression[] array = this.method_35();
		this.method_67((Enum0)22, "']' or ',' expected");
		this.method_63();
		if (expression_0.Type.IsArray)
		{
			if (expression_0.Type.GetArrayRank() == 1)
			{
				if (array.Length == 1)
				{
					Expression expression = this.method_47(array[0], typeof(int), true);
					if (expression == null)
					{
						throw this.method_69(int_, "Array index must be an integer expression", new object[0]);
					}
					return Expression.ArrayIndex(expression_0, expression);
				}
			}
			throw this.method_69(int_, "Indexing of multi-dimensional arrays is not supported", new object[0]);
		}
		Class12.Class13[] array2 = this.method_43(expression_0.Type, array);
		if (array2.Length == 0)
		{
			throw this.method_69(int_, "No applicable indexer exists in type '{0}'", new object[]
			{
				Class12.YaqifOiZcW(expression_0.Type)
			});
		}
		if (array2.Length > 1)
		{
			throw this.method_69(int_, "Ambiguous invocation of indexer in type '{0}'", new object[]
			{
				Class12.YaqifOiZcW(expression_0.Type)
			});
		}
		Class12.Class13 @class = array2[0];
		return Expression.Call(expression_0, (MethodInfo)@class.methodBase_0, @class.expression_0);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x000043F4 File Offset: 0x000025F4
	private static bool smethod_2(Type type_0)
	{
		return type_0.IsGenericType && type_0.GetGenericTypeDefinition() == typeof(Nullable<>);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00004415 File Offset: 0x00002615
	private static Type smethod_3(Type type_0)
	{
		if (!Class12.smethod_2(type_0))
		{
			return type_0;
		}
		return type_0.GetGenericArguments()[0];
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x0001E0D0 File Offset: 0x0001C2D0
	private static string YaqifOiZcW(Type type_0)
	{
		Type type = Class12.smethod_3(type_0);
		string text = type.Name;
		if (type_0 != type)
		{
			text += '?';
		}
		return text;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00004429 File Offset: 0x00002629
	private static bool smethod_4(Type type_0)
	{
		return Class12.smethod_7(type_0) != 0;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00004437 File Offset: 0x00002637
	private static bool smethod_5(Type type_0)
	{
		return Class12.smethod_7(type_0) == 2;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00004442 File Offset: 0x00002642
	private static bool smethod_6(Type type_0)
	{
		return Class12.smethod_7(type_0) == 3;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0001E104 File Offset: 0x0001C304
	private static int smethod_7(Type type_0)
	{
		type_0 = Class12.smethod_3(type_0);
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

	// Token: 0x060003A6 RID: 934 RVA: 0x0000444D File Offset: 0x0000264D
	private static bool smethod_8(Type type_0)
	{
		return Class12.smethod_3(type_0).IsEnum;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0001E16C File Offset: 0x0001C36C
	private void method_37(Type type_0, string string_1, ref Expression expression_0, int int_1)
	{
		Expression[] array = new Expression[]
		{
			expression_0
		};
		array = this.method_39(type_0, array);
		expression_0 = array[0];
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0001E198 File Offset: 0x0001C398
	private void method_38(Type type_0, string string_1, ref Expression expression_0, ref Expression expression_1, int int_1)
	{
		Expression[] array = new Expression[]
		{
			expression_0,
			expression_1
		};
		array = this.method_39(type_0, array);
		expression_0 = array[0];
		expression_1 = array[1];
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0001E1D0 File Offset: 0x0001C3D0
	private Expression[] method_39(Type type_0, Expression[] expression_0)
	{
		Class12.Class13[] array = this.method_41(type_0, "F", false, expression_0);
		if (array.Length == 1)
		{
			return array[0].expression_0;
		}
		return expression_0;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0001E200 File Offset: 0x0001C400
	private MemberInfo method_40(Type type_0, string string_1, bool bool_0)
	{
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (bool_0 ? BindingFlags.Static : BindingFlags.Instance) | this.bindingFlags_0;
		foreach (Type type in Class12.smethod_9(type_0))
		{
			MemberInfo[] array = type.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, this.memberFilter_0, string_1);
			if (array.Length != 0)
			{
				return array[0];
			}
		}
		return null;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0001E27C File Offset: 0x0001C47C
	private Class12.Class13[] method_41(Type type_0, string string_1, bool bool_0, Expression[] expression_0)
	{
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (bool_0 ? BindingFlags.Static : BindingFlags.Instance) | this.bindingFlags_0;
		foreach (Type type in Class12.smethod_9(type_0))
		{
			MemberInfo[] source = type.FindMembers(MemberTypes.Method, bindingAttr, this.memberFilter_0, string_1);
			Class12.Class13[] array = this.method_44(source.Cast<MethodBase>(), expression_0);
			if (array.Length > 0)
			{
				return array;
			}
		}
		return new Class12.Class13[0];
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0001E30C File Offset: 0x0001C50C
	private Class12.Class13[] method_42(Type type_0, string string_1, Expression[] expression_0)
	{
		IEnumerable<MethodInfo> source = this.class10_0.method_12(string_1);
		return this.method_44(source.Cast<MethodBase>(), expression_0);
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0001E334 File Offset: 0x0001C534
	private Class12.Class13[] method_43(Type type_0, Expression[] expression_0)
	{
		foreach (Type type in Class12.smethod_9(type_0))
		{
			MemberInfo[] defaultMembers = type.GetDefaultMembers();
			if (defaultMembers.Length != 0)
			{
				IEnumerable<PropertyInfo> source = defaultMembers.OfType<PropertyInfo>();
				if (Class12.func_1 == null)
				{
					Class12.func_1 = new Func<PropertyInfo, MethodBase>(Class12.smethod_17);
				}
				IEnumerable<MethodBase> source2 = source.Select(Class12.func_1);
				if (Class12.func_2 == null)
				{
					Class12.func_2 = new Func<MethodBase, bool>(Class12.smethod_18);
				}
				IEnumerable<MethodBase> ienumerable_ = source2.Where(Class12.func_2);
				Class12.Class13[] array = this.method_44(ienumerable_, expression_0);
				if (array.Length > 0)
				{
					return array;
				}
			}
		}
		return new Class12.Class13[0];
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
	private static IEnumerable<Type> smethod_9(Type type_0)
	{
		if (type_0.IsInterface)
		{
			List<Type> list = new List<Type>();
			Class12.smethod_11(list, type_0);
			list.Add(typeof(object));
			return list;
		}
		return Class12.smethod_10(type_0);
	}

	// Token: 0x060003AF RID: 943 RVA: 0x0001E434 File Offset: 0x0001C634
	private static IEnumerable<Type> smethod_10(Type type_0)
	{
		Class12.<SelfAndBaseClasses>d__6 <SelfAndBaseClasses>d__ = new Class12.<SelfAndBaseClasses>d__6(-2);
		<SelfAndBaseClasses>d__.<>3__type = type_0;
		return <SelfAndBaseClasses>d__;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0001E454 File Offset: 0x0001C654
	private static void smethod_11(List<Type> list_0, Type type_0)
	{
		if (!list_0.Contains(type_0))
		{
			list_0.Add(type_0);
			foreach (Type type_ in type_0.GetInterfaces())
			{
				Class12.smethod_11(list_0, type_);
			}
		}
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x0001E494 File Offset: 0x0001C694
	private Class12.Class13[] method_44(IEnumerable<MethodBase> ienumerable_0, Expression[] expression_0)
	{
		Class12.<>c__DisplayClass10 CS$<>8__locals1 = new Class12.<>c__DisplayClass10();
		CS$<>8__locals1.args = expression_0;
		CS$<>8__locals1.<>4__this = this;
		Class12.<>c__DisplayClass10 CS$<>8__locals2 = CS$<>8__locals1;
		if (Class12.func_3 == null)
		{
			Class12.func_3 = new Func<MethodBase, Class12.Class13>(Class12.smethod_19);
		}
		CS$<>8__locals2.applicable = (from m in ienumerable_0.Select(Class12.func_3)
		where CS$<>8__locals1.<>4__this.method_45(m, CS$<>8__locals1.args)
		select m).ToArray<Class12.Class13>();
		if (CS$<>8__locals1.applicable.Length > 1)
		{
			CS$<>8__locals1.applicable = CS$<>8__locals1.applicable.Where(delegate(Class12.Class13 m)
			{
				Class12.<>c__DisplayClass10.Class14 @class = new Class12.<>c__DisplayClass10.Class14();
				@class.<>c__DisplayClass10_0 = CS$<>8__locals1;
				@class.class13_0 = m;
				return CS$<>8__locals1.applicable.All(new Func<Class12.Class13, bool>(@class.method_0));
			}).ToArray<Class12.Class13>();
		}
		return CS$<>8__locals1.applicable;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x0001E530 File Offset: 0x0001C730
	private bool method_45(Class12.Class13 class13_0, Expression[] expression_0)
	{
		if (class13_0.parameterInfo_0.Length > expression_0.Length)
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
				if (num >= class13_0.parameterInfo_0.Length)
				{
					return false;
				}
				ParameterInfo parameterInfo = class13_0.parameterInfo_0[num];
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
				Expression expression2 = this.method_47(expression, type2, true);
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
				Expression expression3 = this.method_47(expression, type.GetElementType(), true);
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
			class13_0.bool_0 = true;
			list.Add(Expression.NewArrayInit(type.GetElementType(), list2));
		}
		class13_0.expression_0 = list.ToArray();
		if (class13_0.methodBase_0.IsGenericMethodDefinition && class13_0.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)class13_0.methodBase_0;
			IEnumerable<ParameterInfo> parameterInfo_ = class13_0.parameterInfo_0;
			if (Class12.func_4 == null)
			{
				Class12.func_4 = new Func<ParameterInfo, Type>(Class12.smethod_20);
			}
			Type[] type_ = parameterInfo_.Select(Class12.func_4).ToArray<Type>();
			IEnumerable<Expression> expression_ = class13_0.expression_0;
			if (Class12.func_5 == null)
			{
				Class12.func_5 = new Func<Expression, Type>(Class12.smethod_21);
			}
			List<Type> list3 = this.method_46(type_, expression_.Select(Class12.func_5).ToArray<Type>());
			class13_0.methodBase_0 = methodInfo.MakeGenericMethod(list3.ToArray());
		}
		return true;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x0001E71C File Offset: 0x0001C91C
	private List<Type> method_46(Type[] type_0, Type[] type_1)
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
				List<Type> collection = this.method_46(type.GetGenericArguments(), type2.GetGenericArguments());
				list.AddRange(collection);
			}
		}
		return list;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x0001E77C File Offset: 0x0001C97C
	private Expression method_47(Expression expression_0, Type type_0, bool bool_0)
	{
		if (expression_0.Type == type_0)
		{
			return expression_0;
		}
		if (expression_0 is ConstantExpression)
		{
			ConstantExpression constantExpression = (ConstantExpression)expression_0;
			if (constantExpression == Class15.expression_0 && (!type_0.IsValueType || Class12.smethod_2(type_0)))
			{
				return Expression.Constant(null, type_0);
			}
		}
		if (type_0.IsGenericType)
		{
			Type type = Class12.smethod_13(expression_0.Type, type_0.GetGenericTypeDefinition());
			if (type != null)
			{
				return Expression.Convert(expression_0, type);
			}
		}
		if (!Class12.smethod_12(expression_0.Type, type_0))
		{
			return null;
		}
		if (type_0.IsValueType || bool_0)
		{
			return Expression.Convert(expression_0, type_0);
		}
		return expression_0;
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x0001E81C File Offset: 0x0001CA1C
	private object method_48(string string_1, Type type_0)
	{
		switch (Type.GetTypeCode(Class12.smethod_3(type_0)))
		{
		case TypeCode.SByte:
		{
			sbyte b;
			if (sbyte.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out b))
			{
				return b;
			}
			break;
		}
		case TypeCode.Byte:
		{
			byte b2;
			if (byte.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out b2))
			{
				return b2;
			}
			break;
		}
		case TypeCode.Int16:
		{
			short num;
			if (short.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num))
			{
				return num;
			}
			break;
		}
		case TypeCode.UInt16:
		{
			ushort num2;
			if (ushort.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num2))
			{
				return num2;
			}
			break;
		}
		case TypeCode.Int32:
		{
			int num3;
			if (int.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num3))
			{
				return num3;
			}
			break;
		}
		case TypeCode.UInt32:
		{
			uint num4;
			if (uint.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num4))
			{
				return num4;
			}
			break;
		}
		case TypeCode.Int64:
		{
			long num5;
			if (long.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num5))
			{
				return num5;
			}
			break;
		}
		case TypeCode.UInt64:
		{
			ulong num6;
			if (ulong.TryParse(string_1, NumberStyles.AllowLeadingSign, Class12.cultureInfo_0, out num6))
			{
				return num6;
			}
			break;
		}
		case TypeCode.Single:
		{
			float num7;
			if (float.TryParse(string_1, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class12.cultureInfo_0, out num7))
			{
				return num7;
			}
			break;
		}
		case TypeCode.Double:
		{
			double num8;
			if (double.TryParse(string_1, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class12.cultureInfo_0, out num8))
			{
				return num8;
			}
			break;
		}
		case TypeCode.Decimal:
		{
			decimal num9;
			if (decimal.TryParse(string_1, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, Class12.cultureInfo_0, out num9))
			{
				return num9;
			}
			break;
		}
		}
		return null;
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0001E984 File Offset: 0x0001CB84
	private static bool smethod_12(Type type_0, Type type_1)
	{
		if (type_0 == type_1)
		{
			return true;
		}
		if (!type_1.IsValueType)
		{
			return type_1.IsAssignableFrom(type_0);
		}
		Type type = Class12.smethod_3(type_0);
		Type type2 = Class12.smethod_3(type_1);
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

	// Token: 0x060003B7 RID: 951 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
	private static Type smethod_13(Type type_0, Type type_1)
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
		return Class12.smethod_13(baseType, type_1);
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x0001EC50 File Offset: 0x0001CE50
	private static bool smethod_14(Expression[] expression_0, Class12.Class13 class13_0, Class12.Class13 class13_1)
	{
		if (!class13_0.bool_0 && class13_1.bool_0)
		{
			return true;
		}
		if (!class13_0.bool_0 || class13_1.bool_0)
		{
			bool result = false;
			for (int i = 0; i < expression_0.Length; i++)
			{
				int num = Class12.smethod_15(expression_0[i].Type, class13_0.parameterInfo_0[i].ParameterType, class13_1.parameterInfo_0[i].ParameterType);
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

	// Token: 0x060003B9 RID: 953 RVA: 0x0001ECC8 File Offset: 0x0001CEC8
	private static int smethod_15(Type type_0, Type type_1, Type type_2)
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
		bool flag3 = Class12.smethod_12(type_1, type_2);
		bool flag4 = Class12.smethod_12(type_2, type_1);
		if (flag3 && !flag4)
		{
			return 1;
		}
		if (flag4 && !flag3)
		{
			return -1;
		}
		if (Class12.smethod_5(type_1) && Class12.smethod_6(type_2))
		{
			return 1;
		}
		if (!Class12.smethod_5(type_2) || !Class12.smethod_6(type_1))
		{
			return 0;
		}
		return -1;
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0000445A File Offset: 0x0000265A
	private Expression method_49(Expression expression_0, Expression expression_1)
	{
		return Expression.Equal(expression_0, expression_1);
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00004463 File Offset: 0x00002663
	private Expression method_50(Expression expression_0, Expression expression_1)
	{
		return Expression.NotEqual(expression_0, expression_1);
	}

	// Token: 0x060003BC RID: 956 RVA: 0x0000446C File Offset: 0x0000266C
	private Expression method_51(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.GreaterThan(this.method_59("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.GreaterThan(expression_0, expression_1);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x000044AA File Offset: 0x000026AA
	private Expression method_52(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.GreaterThanOrEqual(this.method_59("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.GreaterThanOrEqual(expression_0, expression_1);
	}

	// Token: 0x060003BE RID: 958 RVA: 0x000044E8 File Offset: 0x000026E8
	private Expression method_53(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.LessThan(this.method_59("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.LessThan(expression_0, expression_1);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00004526 File Offset: 0x00002726
	private Expression method_54(Expression expression_0, Expression expression_1)
	{
		if (expression_0.Type == typeof(string))
		{
			return Expression.LessThanOrEqual(this.method_59("Compare", expression_0, expression_1), Expression.Constant(0));
		}
		return Expression.LessThanOrEqual(expression_0, expression_1);
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x0001ED5C File Offset: 0x0001CF5C
	private Expression method_55(Expression expression_0, Expression expression_1)
	{
		if (!(expression_0.Type == typeof(string)) || !(expression_1.Type == typeof(string)))
		{
			return Expression.Add(expression_0, expression_1);
		}
		return this.method_59("Concat", expression_0, expression_1);
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00004564 File Offset: 0x00002764
	private Expression method_56(Expression expression_0, Expression expression_1)
	{
		return Expression.Subtract(expression_0, expression_1);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x0001EDAC File Offset: 0x0001CFAC
	private Expression method_57(Expression expression_0, Expression expression_1)
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

	// Token: 0x060003C3 RID: 963 RVA: 0x0001EE08 File Offset: 0x0001D008
	private MethodInfo method_58(string string_1, Expression expression_0, Expression expression_1)
	{
		return expression_0.Type.GetMethod(string_1, new Type[]
		{
			expression_0.Type,
			expression_1.Type
		});
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0001EE3C File Offset: 0x0001D03C
	private Expression method_59(string string_1, Expression expression_0, Expression expression_1)
	{
		return Expression.Call(null, this.method_58(string_1, expression_0, expression_1), new Expression[]
		{
			expression_0,
			expression_1
		});
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x0000456D File Offset: 0x0000276D
	private void method_60(int int_1)
	{
		this.mgStpiqdd5 = int_1;
		this.char_0 = ((this.mgStpiqdd5 < this.int_0) ? this.string_0[this.mgStpiqdd5] : '\0');
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0001EE68 File Offset: 0x0001D068
	private void method_61()
	{
		if (this.mgStpiqdd5 < this.int_0)
		{
			this.mgStpiqdd5++;
		}
		this.char_0 = ((this.mgStpiqdd5 < this.int_0) ? this.string_0[this.mgStpiqdd5] : '\0');
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x0000459E File Offset: 0x0000279E
	private void method_62()
	{
		this.method_60(this.mgStpiqdd5 - 1);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x0001EEBC File Offset: 0x0001D0BC
	private void method_63()
	{
		while (char.IsWhiteSpace(this.char_0))
		{
			this.method_61();
		}
		int num = this.mgStpiqdd5;
		char c = this.char_0;
		Enum0 enum0_;
		switch (c)
		{
		case '!':
			this.method_61();
			if (this.char_0 == '=')
			{
				this.method_61();
				enum0_ = (Enum0)24;
				goto IL_549;
			}
			enum0_ = (Enum0)7;
			goto IL_549;
		case '"':
		{
			this.method_61();
			bool flag = false;
			bool flag2 = this.char_0 == '"';
			while (this.mgStpiqdd5 < this.int_0 && !flag2)
			{
				flag = (this.char_0 == '\\' && !flag);
				this.method_61();
				flag2 = (this.char_0 == '"' && !flag);
			}
			if (this.mgStpiqdd5 == this.int_0)
			{
				throw this.method_69(this.mgStpiqdd5, "Unterminated string literal", new object[0]);
			}
			this.method_61();
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
			this.method_61();
			enum0_ = (Enum0)8;
			goto IL_549;
		case '&':
			this.method_61();
			if (this.char_0 == '&')
			{
				this.method_61();
				enum0_ = (Enum0)25;
				goto IL_549;
			}
			throw this.method_69(this.mgStpiqdd5, "Syntax error '{0}'", new object[]
			{
				this.char_0
			});
		case '\'':
		{
			this.method_61();
			bool flag3 = false;
			bool flag4 = false;
			while (this.mgStpiqdd5 < this.int_0 && !flag4)
			{
				flag3 = (this.char_0 == '\\' && !flag3);
				this.method_61();
				flag4 = (this.char_0 == '\'' && !flag3);
			}
			if (this.mgStpiqdd5 == this.int_0)
			{
				throw this.method_69(this.mgStpiqdd5, "Unterminated string literal", new object[0]);
			}
			this.method_61();
			enum0_ = (Enum0)3;
			goto IL_549;
		}
		case '(':
			this.method_61();
			enum0_ = (Enum0)9;
			goto IL_549;
		case ')':
			this.method_61();
			enum0_ = (Enum0)10;
			goto IL_549;
		case '*':
			this.method_61();
			enum0_ = (Enum0)11;
			goto IL_549;
		case '+':
			this.method_61();
			enum0_ = (Enum0)12;
			goto IL_549;
		case ',':
			this.method_61();
			enum0_ = (Enum0)13;
			goto IL_549;
		case '-':
			this.method_61();
			enum0_ = (Enum0)14;
			goto IL_549;
		case '.':
			this.method_61();
			enum0_ = (Enum0)15;
			goto IL_549;
		case '/':
			this.method_61();
			enum0_ = (Enum0)16;
			goto IL_549;
		case ':':
			this.method_61();
			enum0_ = (Enum0)17;
			goto IL_549;
		case '<':
			this.method_61();
			if (this.char_0 == '=')
			{
				this.method_61();
				enum0_ = (Enum0)26;
				goto IL_549;
			}
			enum0_ = (Enum0)18;
			goto IL_549;
		case '=':
			this.method_61();
			if (this.char_0 == '=')
			{
				this.method_61();
				enum0_ = (Enum0)27;
				goto IL_549;
			}
			enum0_ = (Enum0)30;
			goto IL_549;
		case '>':
			this.method_61();
			if (this.char_0 == '=')
			{
				this.method_61();
				enum0_ = (Enum0)28;
				goto IL_549;
			}
			enum0_ = (Enum0)19;
			goto IL_549;
		case '?':
			this.method_61();
			enum0_ = (Enum0)20;
			goto IL_549;
		default:
			switch (c)
			{
			case '[':
				this.method_61();
				enum0_ = (Enum0)21;
				goto IL_549;
			case '\\':
				break;
			case ']':
				this.method_61();
				enum0_ = (Enum0)22;
				goto IL_549;
			default:
				if (c == '|')
				{
					this.method_61();
					if (this.char_0 == '|')
					{
						this.method_61();
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
						this.method_61();
					}
					while (char.IsDigit(this.char_0));
					if (this.char_0 == '.')
					{
						this.method_61();
						if (!char.IsDigit(this.char_0))
						{
							this.method_62();
							goto IL_549;
						}
						enum0_ = (Enum0)6;
						do
						{
							this.method_61();
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
					this.method_61();
					if (this.char_0 != '+')
					{
						if (this.char_0 != '-')
						{
							goto IL_454;
						}
					}
					this.method_61();
					IL_454:
					this.method_66();
					do
					{
						this.method_61();
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
					this.method_61();
					goto IL_549;
				}
				if (this.mgStpiqdd5 == this.int_0)
				{
					enum0_ = (Enum0)1;
					goto IL_549;
				}
				throw this.method_69(this.mgStpiqdd5, "Syntax error '{0}'", new object[]
				{
					this.char_0
				});
			}
		}
		do
		{
			this.method_61();
		}
		while (char.IsLetterOrDigit(this.char_0) || this.char_0 == '_');
		enum0_ = (Enum0)2;
		IL_549:
		this.struct5_0.enum0_0 = enum0_;
		this.struct5_0.string_0 = this.string_0.Substring(num, this.mgStpiqdd5 - num);
		this.struct5_0.int_0 = num;
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x000045AE File Offset: 0x000027AE
	private bool method_64(string string_1)
	{
		return this.struct5_0.enum0_0 == (Enum0)2 && string.Equals(string_1, this.struct5_0.string_0, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0001F44C File Offset: 0x0001D64C
	private string method_65()
	{
		this.method_67((Enum0)2, "Identifier expected");
		string text = this.struct5_0.string_0;
		if (text.Length > 1 && text[0] == '@')
		{
			text = text.Substring(1);
		}
		return text;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x000045D4 File Offset: 0x000027D4
	private void method_66()
	{
		if (!char.IsDigit(this.char_0))
		{
			throw this.method_69(this.mgStpiqdd5, "Digit expected", new object[0]);
		}
	}

	// Token: 0x060003CC RID: 972 RVA: 0x000045FB File Offset: 0x000027FB
	private void method_67(Enum0 enum0_0, string string_1)
	{
		if (this.struct5_0.enum0_0 != enum0_0)
		{
			throw this.method_69(this.struct5_0.int_0, string_1, new object[0]);
		}
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00004624 File Offset: 0x00002824
	private void method_68(Enum0 enum0_0)
	{
		if (this.struct5_0.enum0_0 != enum0_0)
		{
			throw this.method_69(this.struct5_0.int_0, "Syntax error", new object[0]);
		}
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00004651 File Offset: 0x00002851
	private Exception method_69(int int_1, string string_1, params object[] args)
	{
		/*
An exception occurred when decompiling this method (060003CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception Class12::method_69(System.Int32,System.String,System.Object[])

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 401
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00004660 File Offset: 0x00002860
	[CompilerGenerated]
	private static Type smethod_16(Expression expression_0)
	{
		return expression_0.Type;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00004668 File Offset: 0x00002868
	[CompilerGenerated]
	private static MethodBase smethod_17(PropertyInfo propertyInfo_0)
	{
		return propertyInfo_0.GetGetMethod();
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00004670 File Offset: 0x00002870
	[CompilerGenerated]
	private static bool smethod_18(MethodBase methodBase_0)
	{
		return methodBase_0 != null;
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x0001F490 File Offset: 0x0001D690
	[CompilerGenerated]
	private static Class12.Class13 smethod_19(MethodBase methodBase_0)
	{
		return new Class12.Class13
		{
			methodBase_0 = methodBase_0,
			parameterInfo_0 = methodBase_0.GetParameters()
		};
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00004679 File Offset: 0x00002879
	[CompilerGenerated]
	private static Type smethod_20(ParameterInfo parameterInfo_0)
	{
		return parameterInfo_0.ParameterType;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00004660 File Offset: 0x00002860
	[CompilerGenerated]
	private static Type smethod_21(Expression expression_0)
	{
		return expression_0.Type;
	}

	// Token: 0x04000227 RID: 551
	private static CultureInfo cultureInfo_0 = CultureInfo.InvariantCulture;

	// Token: 0x04000228 RID: 552
	private Class10 class10_0;

	// Token: 0x04000229 RID: 553
	private int mgStpiqdd5;

	// Token: 0x0400022A RID: 554
	private string string_0;

	// Token: 0x0400022B RID: 555
	private int int_0;

	// Token: 0x0400022C RID: 556
	private char char_0;

	// Token: 0x0400022D RID: 557
	private Struct5 struct5_0;

	// Token: 0x0400022E RID: 558
	private BindingFlags bindingFlags_0;

	// Token: 0x0400022F RID: 559
	private MemberFilter memberFilter_0;

	// Token: 0x04000230 RID: 560
	[CompilerGenerated]
	private static Func<Expression, Type> func_0;

	// Token: 0x04000231 RID: 561
	[CompilerGenerated]
	private static Func<PropertyInfo, MethodBase> func_1;

	// Token: 0x04000232 RID: 562
	[CompilerGenerated]
	private static Func<MethodBase, bool> func_2;

	// Token: 0x04000233 RID: 563
	[CompilerGenerated]
	private static Func<MethodBase, Class12.Class13> func_3;

	// Token: 0x04000234 RID: 564
	[CompilerGenerated]
	private static Func<ParameterInfo, Type> func_4;

	// Token: 0x04000235 RID: 565
	[CompilerGenerated]
	private static Func<Expression, Type> func_5;

	// Token: 0x0200005B RID: 91
	private class Class13
	{
		// Token: 0x04000236 RID: 566
		public MethodBase methodBase_0;

		// Token: 0x04000237 RID: 567
		public ParameterInfo[] parameterInfo_0;

		// Token: 0x04000238 RID: 568
		public Expression[] expression_0;

		// Token: 0x04000239 RID: 569
		public bool bool_0;
	}
}
