using System;

namespace _04.Hexadecimal_to_decimal
{
	class Program
	{

		static long HexToDec(string n)
		{
			long result = 0;
			foreach(char num in n)
			{
				int add = num - '0';
				if (add > 9)  add = num - 'A' + 10;
				result = result * 16 + add;
			}
			return result;
		}

		static void Main()
		{
			string number = Console.ReadLine();
			Console.WriteLine(HexToDec(number));
		}
	}
}
