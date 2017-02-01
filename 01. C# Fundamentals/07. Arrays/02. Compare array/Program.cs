using System;

namespace _02.Compare_array
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] arr1 = new int[N];
			int[] arr2 = new int[N];
			bool equal = false;
			for (int i = 0; i < N; i++)
			{
				arr1[i] = int.Parse(Console.ReadLine());
			}
			for(int i = 0; i < N; i++)
			{
				arr2[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < N; i++)
			{
				if (arr1[i] == arr2[i])
				{
					equal = true;
				}
				else
				{
					equal = false;
					break;
				}
			}
			if (equal == true)
			{
				Console.WriteLine("Equal");
			}
			else Console.WriteLine("Not equal");
		}
	}
}
