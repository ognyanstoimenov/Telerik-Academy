using System;

namespace _08.Binary_short
{
	class Program
	{

		static string ToBinary(short n)
		{
			string result = string.Empty;

			for (int i = 0; i < 16; i++)
			{
				result = ((n & (1 << i)) >> i) + result;
			}
			return result;
		}

		static void Main()
		{
			short N = short.Parse(Console.ReadLine());
			Console.WriteLine(ToBinary(N));
		}
	}
}
