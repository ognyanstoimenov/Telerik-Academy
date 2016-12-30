using System;

namespace _05.Larger_than_neighbours
{
	class Program
	{
		static int[] ReadArray(int count)
		{
			int[] arr = new int[count];
			string[] input = Console.ReadLine().Split(' ');
			for (int i = 0; i < count; i++)
			{
				arr[i] = int.Parse(input[i]);
			}
			return arr;
		}

		static int NeighBoursCount(int[] arr)
		{
			int count = 0;
			for(int i = 1; i < arr.Length-1; i++)
			{
				if(arr[i-1] < arr[i] && arr[i+1] < arr[i])
				{
					count++;
				}
			}
			return count;
		}

		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] nums = ReadArray(N);
			Console.WriteLine(NeighBoursCount(nums));

		}
	}
}
