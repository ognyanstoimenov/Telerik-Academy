using System;
using System.Text;

namespace _23.Series_of_letters
{
	class Program
	{

		static StringBuilder Identical(string a)
		{
			StringBuilder result = new StringBuilder();
			char currentLetter = a[0];
			result.Append(currentLetter);
			for (int i = 1; i < a.Length; i++)
			{
				if (!a[i].Equals(currentLetter))
				{
					result.Append(a[i]);
					currentLetter = a[i];
				}
			}
			return result;
		}

		static void Main()
		{
			string input = Console.ReadLine();
			Console.WriteLine(Identical(input));
		}
	}
}
