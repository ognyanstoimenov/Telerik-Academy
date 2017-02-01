using System;

namespace _05.Hexadecimal_to_binary
{
	class Program
	{

		static string HexToBinary(string N)
		{
			return DecimalToBinary(HexToDec(N));
		}

		static long HexToDec(string n)
		{
			long result = 0;
			foreach (char num in n)
			{
				int add = num - '0';
				if (add > 9) add = num - 'A' + 10;
				result = result * 16 + add;
			}
			return result;
		}

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
			string number = Console.ReadLine();
			Console.WriteLine(HexToBinary(number));
		}
	}
}
