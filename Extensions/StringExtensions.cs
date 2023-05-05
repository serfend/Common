using System.Security.Cryptography;
using System.Text;

namespace Common.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// 当content为null值时返回null
		/// </summary>
		/// <param name="content"></param>
		/// <returns></returns>
		public static string Sha256(this byte[] content)
		{
			if (content == null) return null;
			var t = SHA256.Create().ComputeHash(content);
			var builder = new StringBuilder();
			foreach (var c in t)
				builder.Append(c.ToString("x2"));
			return builder.ToString();
		}
	}
}