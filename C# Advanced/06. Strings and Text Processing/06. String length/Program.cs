using System;
using System.Text;

namespace _06.String_length
{
	class Program
	{

		static void Fill(string text)
		{
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < 20; i++)
			{
				if (i < text.Length)
					result.Append(text[i]);
				else result.Append("*");
			}
			Console.WriteLine(result);
		}

		static void Main()
		{
			string text = Console.ReadLine();
			Fill(text);
		}
	}
}
