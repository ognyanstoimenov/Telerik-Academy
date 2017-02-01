using System;

namespace _03.Correct_brackets
{
	class Program
	{
		static bool isValid(string s)
		{
			int bracketsCount = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					bracketsCount++;
				}
				if(s[i] == ')')
				{
					bracketsCount--;
				}
			}
			if (bracketsCount == 0 && s[0] != ')' && s[s.Length - 1] != '(')
			{
				return true;
			}
			else return false;
		}

		static void Main()
		{
			string expression = Console.ReadLine();
			Console.WriteLine(isValid(expression)==true? "Correct" : "Incorrect");
		}
	}
}
