using System;

namespace _02.Binary_to_decimal
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


		static void Main()
		{
			string number = Console.ReadLine();
			Console.WriteLine(BinaryToDecimal(number));
		}
	}
}
