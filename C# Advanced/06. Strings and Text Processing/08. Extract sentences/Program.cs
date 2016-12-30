using System;
using System.Text;

namespace _08.Extract_sentences
{
	class Program
	{

		static void SentancesContaining(string text, string search)
		{
			string[] sentances = text.Split('.'); 
			StringBuilder result = new StringBuilder();
			StringBuilder nonLetter = new StringBuilder();
			foreach (var sentance in sentances)
			{
				nonLetter.Clear();
				for (int i = 0; i < sentance.Length; i++)
				{
					if (char.IsLetter(sentance[i]) == false)
					{
						nonLetter.Append(sentance[i]);	
					}
				}
				char[] splitChar = nonLetter.ToString().ToCharArray();
				string[] words = sentance.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
				if (Array.IndexOf(words, search) > -1)
				{
					result.Append(sentance.Trim() + ". ");
				}

			}

			Console.WriteLine(result);

		}

		static void Main()
		{

			string searchedWord = Console.ReadLine();
			string text = Console.ReadLine();
			SentancesContaining(text, searchedWord);
		}
	}
}
