using System;

namespace _04.Multiplication_sign
{
	class Program
	{
		static void Main()
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());
			double product = a * b * c;
			if (product > 0)
			{
				Console.WriteLine("+");
			}
			else if(product < 0)
			{
				Console.WriteLine("-");
			}
			else Console.WriteLine(0);
		}
	}
}
