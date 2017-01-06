using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerable_extensions
{
	class Program
	{
		static void Main()
		{
			List<int> testList = new List<int>() { 1, 2, 3, 4, 5 };
			Console.WriteLine(testList.Sum());
			Console.WriteLine(testList.Product());
			Console.WriteLine(testList.Min());
			Console.WriteLine(testList.Max());
			Console.WriteLine(testList.Average());

		}
	}
}
