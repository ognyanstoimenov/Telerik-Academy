using System;

namespace _09.Sorting_array
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

		static int maximalElement(int[] arr, int startingIndex)
		{
			int maxIndex = startingIndex;
			for (int i = startingIndex; i < arr.Length; i++)
			{
				if (arr[i] > arr[maxIndex])
				{
					maxIndex = i;
				}
			}
			return maxIndex;
		}

		static int[] SortedArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int maxIndex = maximalElement(arr, i);
				int swap = arr[i];
				arr[i] = arr[maxIndex];
				arr[maxIndex] = swap;
			}
			return arr;
		}

		static int[] Reverse(int[] arr)
		{
			int[] reversedNum = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				reversedNum[i] = arr[arr.Length - i - 1];
			}
			return reversedNum;
		}

		static void Main()
		{
			Console.ReadLine();
			int[] nums = ReadArray();
			Console.WriteLine(String.Join(" ", Reverse(SortedArray(nums))));
		}
	}
}
