using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
	public class Parent
	{
		public Parent()
		{
			Console.WriteLine("親です。");
		}
	}

	public class Child : Parent
	{
		public Child()
		{
			Console.WriteLine("子です。");
		}
	}
}
