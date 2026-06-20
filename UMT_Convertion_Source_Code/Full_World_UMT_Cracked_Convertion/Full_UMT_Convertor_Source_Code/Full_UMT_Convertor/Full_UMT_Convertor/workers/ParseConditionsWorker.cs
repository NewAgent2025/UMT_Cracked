using System;
using System.Collections.Generic;
using System.Linq;
using Full_UMT_Convertor.model;

namespace Full_UMT_Convertor.workers
{
	// Token: 0x02000153 RID: 339
	public class ParseConditionsWorker
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x0005E594 File Offset: 0x0005C794
		public List<NodeSearchcriterion> ParseConditions(string cs)
		{
			List<NodeSearchcriterion> list = new List<NodeSearchcriterion>();
			string[] array = cs.Split(new char[]
			{
				','
			});
			foreach (string string_ in array)
			{
				NodeSearchcriterion nodeSearchcriterion = this.method_0(string_);
				if (nodeSearchcriterion != null)
				{
					list.Add(nodeSearchcriterion);
				}
			}
			return list;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0005E5F0 File Offset: 0x0005C7F0
		private NodeSearchcriterion method_0(string string_0)
		{
			NodeSearchcriterion nodeSearchcriterion = null;
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			ParseConditionsWorker.Enum7 @enum = (ParseConditionsWorker.Enum7)0;
			foreach (char c in string_0)
			{
				if (@enum == (ParseConditionsWorker.Enum7)0)
				{
					if (this.char_0.Contains(c))
					{
						text2 = c.ToString();
						@enum = (ParseConditionsWorker.Enum7)1;
					}
					else
					{
						text += c.ToString();
					}
				}
				else if (@enum == (ParseConditionsWorker.Enum7)1)
				{
					if (!this.char_0.Contains(c))
					{
						if (c != ' ')
						{
							text3 = c.ToString();
							@enum = (ParseConditionsWorker.Enum7)2;
						}
					}
					else
					{
						text2 += c.ToString();
					}
				}
				else if (@enum == (ParseConditionsWorker.Enum7)2)
				{
					text3 += c.ToString();
				}
			}
			text = text.Trim();
			text3 = text3.Trim();
			if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2) && this.dictionary_0.ContainsKey(text2))
			{
				nodeSearchcriterion = new NodeSearchcriterion();
				nodeSearchcriterion.Node = text;
				nodeSearchcriterion.Value = text3;
				nodeSearchcriterion.Condition = this.dictionary_0[text2];
			}
			return nodeSearchcriterion;
		}

		// Token: 0x0400084D RID: 2125
		private char[] char_0 = new char[]
		{
			'=',
			'!',
			'<',
			'>'
		};

		// Token: 0x0400084E RID: 2126
		private Dictionary<string, SearchCondition> dictionary_0 = new Dictionary<string, SearchCondition>
		{
			{
				"=",
				SearchCondition.Equal
			},
			{
				"!=",
				SearchCondition.NotEqual
			},
			{
				"<",
				SearchCondition.LessThan
			},
			{
				">",
				SearchCondition.GreaterThan
			},
			{
				"<=",
				SearchCondition.LessThanEqual
			},
			{
				">=",
				SearchCondition.GreaterThanEqual
			}
		};

		// Token: 0x02000154 RID: 340
		private enum Enum7
		{

		}
	}
}
