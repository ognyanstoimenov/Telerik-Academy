using System;

namespace _07.Sort_3_Numbers
{
	class Program
	{
		static void Main()
		{
			short a = short.Parse(Console.ReadLine());
			short b = short.Parse(Console.ReadLine());
			short c = short.Parse(Console.ReadLine());

			if (a >= b && a >= c)
			{
				if (b >= c)
				{
					Console.WriteLine("{0} {1} {2}", a, b, c);
				}
				else Console.WriteLine("{0} {1} {2}", a, c, b);
			}
			else if (b >= c && b >= a)
			{
				if (c >= a)
				{
					Console.WriteLine("{0} {1} {2}", b, c, a);
				}
				else Console.WriteLine("{0} {1} {2}", b, a, c);
			}
			else if (c >= b && c >= a)
			{
				if (b >= a)
				{
					Console.WriteLine("{0} {1} {2}", c, b, a);
				}
				else Console.WriteLine("{0} {1} {2}", c, a, b);
			}
		}
	}
}
