using System;

namespace _07.Sum_of_5_Numbers
{
	class Program
	{
		static void Main()
		{
			double sum = 0;
			double N = double.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				double a = double.Parse(Console.ReadLine());
				sum += a;
			}
			Console.WriteLine(sum);
		}
	}
}
