using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
	class Triangle
	{
		private double width;
		private double height;

		public double GetWidth()
		{
			return this.width;
		}

		public void SetWidth(double width)
		{
			if (width <= 0)
			{
				throw new ArgumentException("正数で指定してください");
			}
			this.width = width;
		}

		public double GetHeight()
		{
			return this.height;
		}

		public void SetHeight(double height)
		{
			if (height <= 0)
			{
				throw new ArgumentException("正数で指定してください");
			}
			this.height = height;
		}

		public double GetArea()
		{
			return this.GetWidth() * this.GetHeight() / 2;
		}
	}
}
