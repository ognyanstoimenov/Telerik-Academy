using System;

namespace _07.Selection_Sort
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] arr = new int[N];
			for (int i = 0; i < N; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			for (int j = 0; j < N; j++)
			{
				int indexMin = j;
				for (int i = j+1; i < N;i++)
				{
					if (arr[i] < arr[indexMin])
					{
						indexMin = i;
					}
				}
				int swap = arr[j];
				arr[j] = arr[indexMin];
				arr[indexMin] = swap;
			}
			foreach(var num in arr)
			{
				Console.WriteLine(num);
			}
		}
	}
}
