using System.Collections.Generic;
using System.Linq;

namespace Common.Extensions
{
	public static class FlagExtensions
	{
		/// <summary>
		/// 将位运算值解构为数值数组
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static List<int> BinaryFlagsToArray(this int value)
		{
			var result = new List<int>();
			var current = 1;
			while (current < value)
			{
				if ((value & current) > 0) result.Add(current);
				current <<= 1;
			}
			return result;
		}

		/// <summary>
		/// 将数值数组转换为位运算值
		/// </summary>
		/// <param name="array"></param>
		/// <returns></returns>
		public static int ArrayToBinaryFlags(this List<int> array)
		{
			var result = 0;
			foreach (var i in array.Distinct())
				result |= i;
			return result;
		}
	}
}