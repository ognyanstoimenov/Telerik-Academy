using System;

namespace _02.Reverse_string
{
	class Program
	{
		static void Main()
		{
			string input = Console.ReadLine();
			char[] inputArr = input.ToCharArray();
			Array.Reverse(inputArr);
			Console.WriteLine(new string(inputArr));
		}
	}
}
