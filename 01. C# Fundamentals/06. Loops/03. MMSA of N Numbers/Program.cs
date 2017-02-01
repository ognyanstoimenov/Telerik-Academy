using System;

namespace _03.MMSA_of_N_Numbers
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			double max = double.Parse(Console.ReadLine());
			double min = max;
			double sum = max;
			for (int i = 1; i < N; i++)
			{
				double a = double.Parse(Console.ReadLine());
				if (a > max)
				{
					max = a;
				}
				if (a < min)
				{
					min = a;
				}
				sum += a;
			}
			double avg = sum / N;
			Console.WriteLine("min={0:F2}", min);
			Console.WriteLine("max={0:F2}", max);
			Console.WriteLine("sum={0:F2}", sum);
			Console.WriteLine("avg={0:F2}", avg);

		}
	}
}
