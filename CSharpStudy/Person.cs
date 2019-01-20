using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
	public class Person
	{
		public string firstName;
		public string lastName;

		//private string firstName;
		//private string lastName;

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Show()
		{
			return $"私の名前は{firstName} {lastName}";
		}
	}
}
