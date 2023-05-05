using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCommon.Extensions
{
	public static class IEnumerableExtensions
	{
		public static void ForEachItem<T>(this IEnumerable<T> items, Action<T> action) => ForEachItem(items, (i, index) => action(i));
		public static void ForEachItem<T>(this IEnumerable<T> items, Action<T, int> action)
		{
			int index = 0;
			foreach (var item in items)
				action(item, index++);
		}
		public static IEnumerable<Q> MapItem<T, Q>(this IEnumerable<T> items, Func<T, Q> action) => MapItem(items, (i, index) => action(i));
		public static IEnumerable<Q> MapItem<T, Q>(this IEnumerable<T> items, Func<T, int, Q> action)
		{
			if (action == null) throw new ArgumentNullException(nameof(action));
			var result = new List<Q>();
			int index = 0;
			foreach (var item in items)
			{
				result.Add(action(item, index++));
			}
			return result;
		}
	}
}
