using Common.Extensions;
using System;

namespace Common.Attributes
{
	/// <summary>
	/// 字典枚举标注
	/// </summary>

	public class CommonDictionaryMenuAttribute : System.Attribute
	{
		/// <summary>
		/// 跟随类型的名称
		/// </summary>
		public const string AsClass = "##AsClass##";

		/// <summary>
		/// 用于区分创建时间
		/// </summary>
		public DateTime CreateDate { get; set; }

		public CommonDictionaryMenuAttribute(string CreateDate, string Description = null, string Name = null)
		{
			this.CreateDate = DateTime.Parse(CreateDate);
			this.MenuName = MenuName ?? AsClass;
			this.Description = Description;
		}

		public CommonDictionaryMenuAttribute(string CreateDate) : this(CreateDate, null, AsClass)
		{
		}

		public string MenuName { private get; set; }

		public string AttributeName(string attributeName) => AsClass == MenuName ? attributeName : MenuName;

		public string Description { get; set; }
	}

	/// <summary>
	/// 字典枚举项描述
	/// </summary>
	public class CommonDictionaryAttribute : System.Attribute
	{
		/// <summary>
		/// 跟随枚举的名称
		/// </summary>
		public const string AsEnum = "##AsEnum##";

		/// <summary>
		/// 跟随枚举的值
		/// </summary>
		public const int AsValue = -30330300;

		public static readonly CommonDictionaryAttribute Default = new CommonDictionaryAttribute("UnNamed", System.Drawing.Color.Gray.ToString(), -1, "未定义的字典");

		public CommonDictionaryAttribute(string Name = null, string color = null, int value = -1, string Description = null, string Alias = null)
		{
			this.Value = value == -1 ? AsValue : value;
			this.Alias = Alias ?? Name;
			Color = color ?? System.Drawing.Color.Gray.ToHtml();
			this.Name = Name ?? AsEnum;
			this.Description = Description;
		}

		public int Value { private get; set; }
		public string Alias { get; set; }
		public string Color { get; set; }
		public string Name { private get; set; }

		public string AttributeName(string attributeName) => AsEnum == Name ? attributeName : Name;

		public int AttributeValue(int attributeValue) => AsValue == Value ? attributeValue : Value;

		public string Description { get; set; }
	}
}