using System;

namespace _16.Trailing_in_N_
{
	class Program
	{
		static void Main()
		{
			long N = long.Parse(Console.ReadLine());
			long count = 0;
			while (N >= 5)
			{
				N = N / 5;
				count += N;
			}
			Console.WriteLine(count);
		}
	}
}
