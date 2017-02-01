using System;

namespace _02.Maximal_Sum
{
	class Program
	{
		static void Main()
		{
			string[] input = Console.ReadLine().Split(' ');
			int N = int.Parse(input[0]);
			int M = int.Parse(input[1]);
			int[,] arr = new int[N, M];
			for (int i = 0; i < N; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				for (int j = 0; j < M; j++)
				{
					arr[i, j] = int.Parse(line[j]);
				}
			}
			int maxsum = int.MinValue;
			int cursum = 0;
			for (int iStart = 0; iStart <= N - 3; iStart++)
			{
				for (int jStart = 0; jStart <= M - 3; jStart++)
				{
					cursum = 0;
					for (int i = iStart, l = 1; l <= 3; i++, l++)
					{
						for (int j = jStart, l1 = 1; l1 <= 3; j++, l1++)
						{
							cursum += arr[i, j];
						}
					}
					if (cursum > maxsum) maxsum = cursum;
				}
			}
			Console.WriteLine(maxsum);
		}
	}
}

