using System;

namespace _04.Formatting_Numbers
{
	class Program
	{
		static void Main()
		{
			int a = int.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());

			Console.WriteLine("{0,-4:X} {1,4} {2,4:F2} {3,-4:F3}", a, b, c);
		}
	}
}
