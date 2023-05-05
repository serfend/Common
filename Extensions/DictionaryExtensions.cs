using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCommon.Extensions
{
	public static class DictionaryExtensions
	{
		public static IDictionary<T, Q> GetOrAdd<T, Q>(this IDictionary<T, Q> v, T key) where T : notnull => GetOrAdd(v, key, () => default(Q));
		public static IDictionary<T, Q> GetOrAdd<T, Q>(this IDictionary<T, Q> v, T key, Func<Q> default_value) where T : notnull
		{
			if (v == null) v = new Dictionary<T, Q>();
			if (!v.ContainsKey(key)) v[key] = default_value();
			return v;
		}
		public static IDictionary<T, Q> ValueModify<T, Q>(this IDictionary<T, Q> v, T key, Func<Q, Q> callback) where T : notnull
		{
			v = v.GetOrAdd(key);
			v[key] = callback(v[key]);
			return v;
		}
		public static IDictionary<T, Q> ValueModify<T, Q>(this IDictionary<T, Q> v, T key, Func<Q, Q> callback, Func<Q> default_value) where T : notnull
		{
			v = v.GetOrAdd(key, default_value);
			v[key] = callback(v[key]);
			return v;
		}

		public static IDictionary<T, Q> ValueModify<T, Q>(this IDictionary<T, Q> v, T key, Action<Q> callback) where T : notnull
		{
			v = v.GetOrAdd(key);
			callback(v[key]);
			return v;
		}

		public static IDictionary<T, Q> ValueModify<T, Q>(this IDictionary<T, Q> v, T key, Action<Q> callback, Func<Q> default_value) where T : notnull
		{
			v = v.GetOrAdd(key, default_value);
			callback(v[key]);
			return v;
		}
	}
}
