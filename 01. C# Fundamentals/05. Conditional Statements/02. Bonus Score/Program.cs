using System;

namespace _02.Bonus_Score
{
	class Program
	{
		static void Main()
		{
			int number = int.Parse(Console.ReadLine());
			if (number >= 1 && number <= 3)
			{
				Console.WriteLine(number * 10);
			}
			else if (number >= 4 && number <= 6)
			{
				Console.WriteLine(number * 100);
			}
			else if (number >= 7 && number <= 9)
			{
				Console.WriteLine(number * 1000);
			}
			else Console.WriteLine("invalid score");
		}
	}
}
