using System;
using System.Collections.Generic;

namespace Common.Extensions
{
	public static class GuidExtensions
	{
		/// <summary>
		/// 自增初始化Guid
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="callback"></param>
		public static void ListAutoGuid<T>(this IEnumerable<T> list, Action<Guid, T> callback) where T : class
		{
			var id = 0;
			foreach (var i in list)
			{
				callback.Invoke(new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, (byte)(id >> 8), (byte)(id & byte.MaxValue)), i);
				id++;
			}
		}
	}
}