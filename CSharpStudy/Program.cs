using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var bp = new EliteBusinessPerson
			{
				FirstName = "takumi",
				LastName = "kawaguchi"
			};
			Console.WriteLine(bp.Work());
			Console.WriteLine(bp.Show());

			Console.ReadKey();
		}
	}
}
