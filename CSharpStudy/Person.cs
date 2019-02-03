using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Show()
		{
			return $"私の名前は{FirstName} {LastName}";
		}
	}

	public class BusinessPerson : Person
	{
		public string Work()
		{
			return $"{this.LastName} {this.FirstName} is working.";
		}

		public new string Show()
		{
			return $"会社員の{FirstName} {LastName}です。";
		}
	}

	public class EliteBusinessPerson : BusinessPerson
	{
		public new string Work()
		{
			var result = base.Work();
			return $"{result} always working hard.";
		}
	}
}
