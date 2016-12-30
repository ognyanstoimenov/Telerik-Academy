using System;

namespace _03.Number_of_Pages
{
	class Program
	{
		static void Main()
		{
			int D = int.Parse(Console.ReadLine());
			int N;
			for (N = 1; D > 0; N++)
			{
				int j = N;
				int digits = 0;
				while (j > 0)
				{
					digits++;
					j /= 10;
				}
				D -= digits;

			}
			Console.WriteLine(N-1);
		}
	}
}
