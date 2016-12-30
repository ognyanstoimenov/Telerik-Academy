using System;

namespace _03.English_Digit
{
	class Program
	{
		static string LastDigitAsWord(int a)
		{
			int lastDigit = a % 10;
			switch (lastDigit)
			{
				case 0: return "zero";
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
				default: return null;
			}
		}
		static void Main()
		{
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(LastDigitAsWord(num));
		}
	}
}
