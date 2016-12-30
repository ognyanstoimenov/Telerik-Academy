using System;

namespace _11.Binary_Search
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] nums = new int[N];

			for (int i = 0; i < N; i++)
			{
				nums[i] = int.Parse(Console.ReadLine());
			}
			int T = int.Parse(Console.ReadLine());
			Array.Sort(nums);

			int left = 0;
			int right = N - 1;
			int middle = new int();
			int searchedIndex = -1;
			for (int i = 1; i < N; i++)
			{
				middle = (left + right) / 2;
				if (T > nums[middle])
				{
					left = middle;
				}
				else if (T < nums[middle])
					right = middle;
				else if (T == nums[middle])
				{
					searchedIndex = middle;
				}
			}
			Console.WriteLine(searchedIndex);
		}
	}
}
