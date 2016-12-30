using System;

namespace _01.Exchange_Numbers
{
	class Program
	{
		static void Main()
		{
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			double swap;
			if (A > B)
			{
				swap = B;
				B = A;
				A = swap;
			}
			Console.WriteLine(A + " " + B);
		}
	}
}
