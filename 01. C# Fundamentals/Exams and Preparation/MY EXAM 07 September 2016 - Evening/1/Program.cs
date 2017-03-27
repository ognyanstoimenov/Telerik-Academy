using System;

namespace _1
{
	class Program
	{
		static void Main()
		{
			double N = double.Parse(Console.ReadLine());
			double first =(int) N / 100;
			double second = (int)(N / 10) % 10;
			double third = (int)N % 10;

			if (second % 2 == 0)
			{
				Console.WriteLine("{0:F2}",(first+second)*third);
			}
			else Console.WriteLine("{0:F2}",(first*second)/third);
		}
	}
}
