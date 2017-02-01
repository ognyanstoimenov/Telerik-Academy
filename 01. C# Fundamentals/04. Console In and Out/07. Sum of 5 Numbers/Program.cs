using System;

namespace _07.Sum_of_5_Numbers
{
	class Program
	{
		static void Main()
		{
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				int a = int.Parse(Console.ReadLine());
				sum += a;
			}
			Console.WriteLine(sum);
		}
	}
}
