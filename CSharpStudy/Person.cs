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

		public virtual string Show()
		{
			return $"i am {this.FirstName} {this.LastName}";
		}
	}

	public class BusinessPerson : Person
	{
		public override string Show()
		{
			return $"i am {this.FirstName} {this.LastName}, a business person.";
		}

		public string Work()
		{
			return $"{this.FirstName} {this.LastName} is working now.";
		}
	}
}
