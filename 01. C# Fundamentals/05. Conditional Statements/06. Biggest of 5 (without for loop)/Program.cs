using System;

namespace _06.Biggest_of_5__without_for_loop_
{
	class Program
	{
		static void Main()
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			int e = int.Parse(Console.ReadLine());
			int temp;
			if ((a + b) > (b + c))
			{
				if (a > b)
					temp = a;
				else temp = b;
				if (temp > e) Console.WriteLine(temp);
				
			}
			else
		}
	}
}
