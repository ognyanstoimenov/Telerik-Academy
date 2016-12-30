using System;

namespace _04.Appearance_count
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
		static int RepeatCount(int[] arr, int searchFor)
		{
			int count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == searchFor) count++;
			}
			return count;
		}
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] array = ReadArray(N);
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine(RepeatCount(array, x));
		}
	}
}
