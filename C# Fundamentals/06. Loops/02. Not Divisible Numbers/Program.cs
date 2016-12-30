using System;

namespace _02.Not_Divisible_Numbers
{
	class Program
	{
		static void Main()
		{
			short n = short.Parse(Console.ReadLine());

			for (int i = 0; i <= n; i++)
			{
				if (i % 3 != 0 && i % 7 != 0)
				{
					Console.Write("{0} ",i);
				}
			}
		}
	}
}
