using System;

namespace _06.First_larger_than_neighbours
{
	class Program
	{
		static int[] ReadArray()
		{
			string[] input = Console.ReadLine().Split(' ');
			int[] arr = new int[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				arr[i] = int.Parse(input[i]);
			}
			return arr;
		}
		static int FirstLargerNB(int[] arr)
		{
			for(int i = 1; i < arr.Length-1; i++)
			{
				if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i])
				{
					return i;
				}
			}
			return -1;
		}
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] nums = ReadArray();
			Console.WriteLine(FirstLargerNB(nums));


		}
	}
}
