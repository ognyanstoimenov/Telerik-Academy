using System;

namespace _02.Enter_numbers
{
	class Program
	{
		static public bool exception = false;
		static int ReadNum(int start, int end)
		{
			int a = int.Parse(Console.ReadLine());
			try
			{
				if (a <= start || a >= end)
				{
					throw new Exception();
				}
			}
			catch (Exception)
			{
				exception = true;
			}
			return a;

		}
		static void Main()
		{
			int start = 1;
			int[] nums = new int[10];
			for (int i = 0; i < 10; i++)
			{
				nums[i] = ReadNum(start, 100);
				start = nums[i];
			}
			if (exception == true)
			{
				Console.WriteLine("Exception");
			}
			else
			{
				Console.Write(1 + " < ");
				for (int i = 0; i < 10; i++)
				{
					Console.Write(nums[i] + " < ");
				}
				Console.Write(100);
				Console.WriteLine();
			}
		}
	}
}
