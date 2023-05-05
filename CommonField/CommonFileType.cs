using System;

namespace Common.CommonField
{
	/// <summary>
	/// 字段类型
	/// </summary>
	public enum CommonFieldType
	{
		Void = 0,
		Number = 1,
		String = 2,
		Date = 3,
		Datetime = 4,
		File = 5,
		Place = 31,
		User = 81,
		Company = 82,
		PartyGroup = 83,
	}

	/// <summary>
	/// 字段标注
	/// </summary>
	[Flags]
	public enum CommonFieldAttribute
	{
		/// <summary>
		/// 无
		/// </summary>
		None = 0,

		/// <summary>
		/// 必填
		/// </summary>
		Required = 1,

		/// <summary>
		/// 列表
		/// </summary>
		List = 2,

		/// <summary>
		/// 在列表获取时隐藏
		/// </summary>
		HideInSummary = 4,

		/// <summary>
		/// 在详细获取时隐藏
		/// </summary>
		HideInDetail = 8,
	}
}