using System;

namespace _11.Interval
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int count = 0;
			for (int i = N + 1; i < M; i++)
			{
				if (i % 5 == 0)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}
