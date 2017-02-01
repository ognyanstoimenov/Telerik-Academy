using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___19.Student_Groups
{
	static class Extension_method
	{
		public static void PrintStudents<T>(this IEnumerable<T> collection, string title,bool final = false)
		{
			Console.WriteLine(title);
			foreach (var item in collection)
			{
				Console.WriteLine(item);
			}
			if (!final)
			{
				Console.WriteLine("=======================");
				Console.WriteLine();
			}
		}
	}
}
