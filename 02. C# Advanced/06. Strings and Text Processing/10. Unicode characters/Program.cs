using System;
using System.Text;

namespace _10.Unicode_characters
{
	class Program
	{

		static string ToHex(char a)
		{
			string result = "\\u" + ((int)a).ToString("X4");
			return result;
		}

		static void Main()
		{
			string input = Console.ReadLine();
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				result.Append(ToHex(input[i]));
			}
			Console.WriteLine(result);
		}
	}
}
