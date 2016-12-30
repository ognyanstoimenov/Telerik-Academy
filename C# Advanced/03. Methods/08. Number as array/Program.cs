using System;

namespace _08.Number_as_array
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

		static int[] SumAsArray(int[] a, int[] b)
		{
			int largestLength = Math.Max(a.Length, b.Length);
			int[] result = new int[largestLength];
			int buffer = 0;
			for (int i = 0; i < largestLength; i++)
			{
				int numA = 0;
				if (i < a.Length)
				{
					numA = a[i];
				}

				int numB = 0;
				if (i < b.Length)
				{
					numB = b[i];
				}
				int add = numA + numB + buffer;
				buffer = 0;
				if (add > 9)
				{
					result[i] += add - 10;
					buffer = 1;
				}
				else result[i] += add;
			}
			return result;
		}

		static void Main()
		{
			string input = Console.ReadLine();
			int[] arr1 = ReadArray();
			int[] arr2 = ReadArray();
			int[] meme = SumAsArray(arr1, arr2);
			foreach (var num in meme)
			{
				Console.Write(num);
				Console.Write(" ");
			}
		}
	}
}