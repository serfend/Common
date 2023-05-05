using System.Drawing;

namespace Common.Extensions
{
	public static class ColorExtensions
	{
		public static string ToHtml(this Color c) => string.Format("#{0:x2}{1:x2}{2:x2}{3:x2}", c.R, c.G, c.B, c.A);

		public static Color ToColor(this string color) => ColorTranslator.FromHtml(color);
	}
}