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
			t.Height = 10;
			t.Width = 20;

			Console.WriteLine(t.GetArea());

			Console.ReadKey();
		}
	}
}
