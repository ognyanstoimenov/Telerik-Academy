using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
	class Program
	{
		static void Main()
		{
			GenericList<int> list = new GenericList<int>(10);
			list.Add(10);
			list.Add(24);
			list.Add(23);
			list.Add(21);
			list.Add(27);
			list.Add(25);
			list.Add(28);
			list.Add(32);
			list.AddAt(3, 90);
			list.Add(50);
			list.Add(50);
			Console.WriteLine(list);

		}
	}
}
