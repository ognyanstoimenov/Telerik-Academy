using System;
using System.Collections.Generic;
namespace _13.Merge_sort
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] arr = new int[N + 1];
			int number = 2;
			for (int i = 2; i < N + 1; i++)
			{
				arr[i] = number++;
			}
			for (int i = 2; i * i < N + 1; i++)
			{
				if (arr[i] == 0)
				{
					continue;
				}
				for (int j = i; j < N + 1; j += i)
				{
					if (j == i)
					{
						continue;
					}
					arr[j] = 0;
				}
			}

			for (int i = N; i > 0; i--)
			{
				if (arr[i] != 0)
				{
					Console.WriteLine(arr[i]);
					break;
				}
			}

		}
	}
}
