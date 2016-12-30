using System;

namespace _05.Maximal_increasing_sequence
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] arr = new int[N];
			arr[0] = int.Parse(Console.ReadLine());
			int currentDigit = arr[0];
			int longestSeq = 1;
			int currentSeq = 1;
			for (int i = 1; i < N; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
				if (arr[i] > currentDigit)
				{
					currentSeq++;
					currentDigit = arr[i];
				}
				else
				{
					currentDigit = arr[i];
					if (currentSeq >= longestSeq)
					{
						longestSeq = currentSeq;
					}
					currentSeq = 1;
				}
			}
			Console.WriteLine(Math.Max(currentSeq, longestSeq));
		}
	}
}
