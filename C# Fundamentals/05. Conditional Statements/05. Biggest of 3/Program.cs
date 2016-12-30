using System;

namespace _05.Biggest_of_3
{
	class Program
	{
		static void Main()
		{
			double biggest = double.Parse(Console.ReadLine());
			for (int i = 1; i < 3; i++)
			{
				double a = double.Parse(Console.ReadLine());
				if (a > biggest)
				{
					biggest = a;
				}
			}
			Console.WriteLine(biggest);
		}
	}
}
