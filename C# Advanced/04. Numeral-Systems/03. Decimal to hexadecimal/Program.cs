using System;

namespace _03.Decimal_to_hexadecimal
{
	class Program
	{
		static string DecimalToHex(long n)
		{
			string result = String.Empty;
			while (n > 0)
			{
				long addNum = n % 16;
				if (addNum > 9)
				{
					char letter = (char)(addNum - 10 + 'A');
					result = letter + result;
				}
				else result = addNum + result;
				n /= 16;
			}
			return result;
		}
		static void Main()
		{
			long num = long.Parse(Console.ReadLine());
			Console.WriteLine(DecimalToHex(num));
		}
	}
}
