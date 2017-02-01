using System;

namespace _04.Sub_string_in_text
{
	class Program
	{

		static int find(string text,string pattern)
		{
			int count = 0;

			for (int i = 0; i < text.Length; i++)
			{
				int currentIndex = text.IndexOf(pattern, i,StringComparison.CurrentCultureIgnoreCase);
				if (currentIndex == -1) break;
				count++;
				i = currentIndex;
			}

			return count;
		}

		static void Main()
		{
			string pattern = Console.ReadLine();
			string text = Console.ReadLine();
			Console.WriteLine(find(text,pattern));
		}
	}
}
