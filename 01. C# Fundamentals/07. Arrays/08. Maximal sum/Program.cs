using System;

namespace _08.Maximal_sum
{
	class Program
	{
		static void Main()
		{
			short N = short.Parse(Console.ReadLine());
			short[] arr = new short[N];
			int currentSum = 0;
			int currentBiggestSum = 0;
			for (int i = 0; i < N; i++)
			{
				arr[i] = short.Parse(Console.ReadLine());
			}
			for (int a = 0; a < N; a++)
			{
				for (int i = 1; i <= N; i++)
				{
					if (currentBiggestSum < currentSum)
					{
						currentBiggestSum = currentSum;
					}
					currentSum = 0;
					for (int j = a; j < i; j++)
					{
						currentSum += arr[j];
					}
				}
			}
			Console.WriteLine(currentBiggestSum);
		}
	}
}