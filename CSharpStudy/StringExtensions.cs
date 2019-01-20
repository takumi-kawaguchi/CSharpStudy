using System.Text;

namespace CSharpStudy
{
	static class StringExtensions
	{
		public static string Repeat(this string str, int count)
		{
			var builder = new StringBuilder();
			for(var i = 0; i < count; i++)
			{
				builder.Append(str);
			}
			return builder.ToString();
		}
	}
}
