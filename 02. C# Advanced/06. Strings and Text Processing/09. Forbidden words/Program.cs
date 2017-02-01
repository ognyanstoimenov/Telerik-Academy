using System;

namespace _09.Forbidden_words
{
	class Program
	{

		static string Replace(string text,string[] remove)
		{
			int[] indexes = new int[remove.Length];
			string result = text;

			//for (int i = 0; i < remove.Length; i++)
			//{
			//	indexes[i] = text.IndexOf(remove[i]);
			//}
			for (int i = 0; i < remove.Length; i++)
			{
				text = result;
				for (int j = 0; j < text.Length; j++)
				{
					int indexOf = text.IndexOf(remove[i]);
					if (indexOf == -1) break;
					string word = text.Substring(indexOf, remove[i].Length);
					result = result.Replace(word, new String('*', word.Length));
					text = text.Substring(indexOf + word.Length);
				}
			}
			return result;
		}

		static void Main()
		{
			string text = Console.ReadLine();
			string[] forbidden = Console.ReadLine().Split(' ');
			Console.WriteLine(Replace(text,forbidden));
		}
	}
}
