using System;

namespace _09.Frequent_Number
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] nums = new int[N];
			int mostFrequent = new int();
			int timesRepeated = 1;
			int mostRepeatedTimes = int.MinValue;
			for (int i = 0; i < N; i++)
			{
				nums[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < N; i++)
			{
				for (int j = i + 1; j <= N - 1; j++)
				{
					if (nums[i] == nums[j])
					{
						timesRepeated++;
					}
				}
				if (timesRepeated > mostRepeatedTimes)
				{
					mostRepeatedTimes = timesRepeated;
					mostFrequent = nums[i];
				}
				timesRepeated = 1;
			}
			Console.WriteLine("{0} ({1} times)", mostFrequent, mostRepeatedTimes);

		}
	}
}
