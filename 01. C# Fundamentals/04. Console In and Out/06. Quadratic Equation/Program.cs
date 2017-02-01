using System;

namespace _06.Quadratic_Equation
{
	class Program
	{
		static void Main()
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());

			double D = (b * b) - 4 * a * c;
			double x1 = (-b + Math.Sqrt(D)) / (2 * a);
			double x2 = (-b - Math.Sqrt(D)) / (2 * a);

			if (D == 0)
			{
				Console.WriteLine("{0:F2}", x1);
			}
			else if (D > 0)
			{
				Console.WriteLine(x1 > x2 ? "{0:F2}\n{1:F2}" : "{1:F2}\n{0:F2}", x2, x1);
			}
			else
			{
				Console.WriteLine("no real roots");
			}

		}
	}
}
