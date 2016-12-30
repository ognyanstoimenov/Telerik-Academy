using System;

namespace _05.Bobi_Avokadoto
{
	class Program
	{
		static uint setBitsCount(uint a)
		{
			uint count = 0;
			while (a != 0)
			{
				count += a & 1;
				a = a >> 1;
			}
			return count;
		}
		static void Main()
		{
			uint N = uint.Parse(Console.ReadLine());
			int C = int.Parse(Console.ReadLine());
			uint bestComb = 0;
			for (int i = 0; i < C; i++)
			{
				uint currentComb = uint.Parse(Console.ReadLine());
				if ((N ^ currentComb) == (N | currentComb))
				{
					if (setBitsCount(currentComb) > setBitsCount(bestComb))
					{
						bestComb = currentComb;
					}
				}

			}
			Console.WriteLine(bestComb);
		}
	}
}
