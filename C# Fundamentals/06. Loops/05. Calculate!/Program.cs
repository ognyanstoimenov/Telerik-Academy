using System;

namespace _05.Calculate_
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			double x = double.Parse(Console.ReadLine());
			double sum = 1;
			long fact = 1;
			double divisor;
			for(int i = 1; i <= N; i++)
			{
				fact *= i;
				divisor = Math.Pow(x, i);
				sum += fact / divisor;
			}
			Console.WriteLine("{0:F5}", sum);

		}
	}
}
