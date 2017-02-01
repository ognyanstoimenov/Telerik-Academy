using System;
using System.Linq;

namespace _08.Sum_integers
{
	class Program
	{

		static long Sum(string n)
		{
			long sum = 0;
			string[] nums = n.Split(' ');
			for (int i = 0; i < nums.Length; i++)
			{
				sum += int.Parse(nums[i]);
			}
			return sum;
		}

		static void Main()
		{
			string input = Console.ReadLine();
			Console.WriteLine(Sum(input));
		}
	}
}
