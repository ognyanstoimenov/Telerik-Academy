using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Divisible_by_7_and_3
{
	class Program
	{
		static void Main()
		{
			int[] nums = { 5, 51, 2, 35, 7, 9, 21, 33, 42 };
			Console.Write("All numbers: ");
			Console.WriteLine(String.Join(" ",nums));
			Console.WriteLine();

			//LAMBDA
			var result = nums.Where(x => x % 7 == 0 && x % 3 == 0);

			//LINQ
			var resultLINQ =
				from num in nums
				where num % 7 == 0 & num % 3 == 0
				select num;

			Console.Write("Numbers divisable by 3&7: ");
			foreach (var num in resultLINQ)
			{
				Console.Write(num);
				Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}
 