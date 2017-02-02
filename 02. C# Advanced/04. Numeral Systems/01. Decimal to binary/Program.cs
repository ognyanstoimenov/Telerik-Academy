using System;

namespace _01.Decimal_to_binary
{
	class Program
	{	
		static string DecimalToBinary(long N)
		{
			string result = String.Empty;
			while (N > 0)
			{
				result = (N % 2).ToString() + result;
				N = N / 2;
			}
			return result;
		}
	
		static void Main()
		{
			long num = long.Parse(Console.ReadLine());
			Console.WriteLine(DecimalToBinary(num));
		}
	}
}
