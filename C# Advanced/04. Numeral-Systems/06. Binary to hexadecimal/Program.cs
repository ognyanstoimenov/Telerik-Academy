using System;

namespace _06.Binary_to_hexadecimal
{
	class Program
	{

		static long BinaryToDecimal(string binary)
		{
			long result = 0;
			foreach (char digit in binary)
			{
				result = result * 2 + (digit - '0');
			}
			return result;
		}

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

		static string BinaryToHex(string N)
		{
			return 
			DecimalToHex(BinaryToDecimal(N));
		}

		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			Console.WriteLine(BinaryToHex(number));
		}

	}
}
