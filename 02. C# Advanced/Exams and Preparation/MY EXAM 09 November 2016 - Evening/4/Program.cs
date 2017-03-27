using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace _4
{
	class Program
	{
		static void Main()
	{
			string searchedWord = Console.ReadLine();
			int numberOfLines = int.Parse(Console.ReadLine());
			string[] lines = new string[numberOfLines];
			for (int i = 0; i < numberOfLines; i++)
			{
				lines[i] = Console.ReadLine();
			}
			string fullText = String.Join(" ", lines);
			MatchCollection matches = Regex.Matches(fullText, @"(.*?)(\.|\!)");
			string[] sentances = new string[fullText.Length];
			StringBuilder textToCalculate = new StringBuilder();
			int c = 0;
			foreach (Match m in matches)
			{
				sentances[c] = (m.Groups[1].ToString().Trim() + m.Groups[2].ToString().Trim());
				c++;
			}
			foreach (var sentance in sentances)
			{
				int indexOfWord = sentance.IndexOf(searchedWord);
				if (indexOfWord == -1) continue;
				else
				{
					if (sentance.LastIndexOf(".") != -1)
					{
						textToCalculate.Append(sentance.Substring(indexOfWord + searchedWord.Length, sentance.Length - (indexOfWord + searchedWord.Length)-1));
					}
					else if (sentance.LastIndexOf("!") != -1)
					{
						textToCalculate.Append(sentance.Substring(0, indexOfWord - 1));
					}
					break;
				}
			}
			string noSpaces = Regex.Replace(textToCalculate.ToString(), @"(\s)+", "");
			long result = 0;
			foreach (char letter in noSpaces)
			{
				result += letter * searchedWord.Length;
			}
			Console.WriteLine(result);
		}
	}
}
