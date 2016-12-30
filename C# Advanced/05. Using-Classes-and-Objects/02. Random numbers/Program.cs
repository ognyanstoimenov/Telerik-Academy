using System;

namespace _02.Random_numbers
{
	class Program
	{
		static void Main()
		{
			Random randomGen = new Random();
			int randomNum;
			for (int i = 0; i < 10; i++)
			{
				randomNum = randomGen.Next(100, 201);
				Console.WriteLine(randomNum);
			}
		}
	}
}
