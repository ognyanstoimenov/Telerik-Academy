using System;

namespace _1.NumbersFrom1ToN
{
	class Program
	{
		static void Main()
		{
			uint N = uint.Parse(Console.ReadLine());

			for (int i = 1; i <= N; i++)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}
