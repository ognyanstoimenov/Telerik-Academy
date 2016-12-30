using System;

namespace _12.Index_of_letter
{
	class Program
	{
		static void Main()
		{
			char[] alphabet = new char[26];
			for(char i = 'a'; i <= 'z'; i++)
			{
				alphabet[i-'a'] = i;
			}

			string word = Console.ReadLine();
			for (int i = 0; i < word.Length; i++)
			{
				int j = 0;
				while (word[i] != alphabet[j])
				{
					j++;
				}
				Console.WriteLine(j);
			}
		}
	}
}
