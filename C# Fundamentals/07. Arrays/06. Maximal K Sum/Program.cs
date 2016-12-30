using System;

namespace _06.Maximal_K_Sum
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int K = int.Parse(Console.ReadLine());
			int[] arr = new int[N];
			int sum = 0;
			for(int i = 0; i < N; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			for (int j = 0; j < K; j++)
			{
				for (int i = 0; i < N - 1; i++)
				{
					if (arr[i] > arr[i + 1])
					{
						int swap;
						swap = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = swap;
					}
				}
				sum += arr[N-j-1];
			}
			Console.WriteLine(sum);
		}
	}
}
