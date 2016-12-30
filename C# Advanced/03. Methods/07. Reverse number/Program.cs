using System;

namespace _07.Reverse_number
{
	class Program
	{
		static decimal Reverse(decimal n)
		{
			string num = n.ToString();
			string reversedNum = "";
			for (int i = 0; i < num.Length; i++)
			{
				reversedNum += num[num.Length - i - 1];
			}
			return decimal.Parse(reversedNum);
		}
		static void Main()
		{
			decimal num = decimal.Parse(Console.ReadLine());
			Console.WriteLine(Reverse(num));
		}
	}
}
