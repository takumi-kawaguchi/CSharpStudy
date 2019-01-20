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
			var t = new Triangle();
			t.SetWidth(10);
			t.SetHeight(5);

			Console.WriteLine(t.GetArea());
			t.SetHeight(-5);
			Console.ReadKey();
		}
	}
}
