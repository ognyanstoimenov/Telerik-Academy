using System;
using System.Text;

namespace _15.Replace_tags
{
	class Program
	{

		static string ReplaceTags(string a)
		{
			//StringBuilder b = new StringBuilder();
			string result = a;
			for (int i = 0; i < a.Length; i++)
			{

				const string aTag = @"<a href=""";
				const string aEnd = @""">";
				const string closeA = "</a>";
				int indexHref = a.IndexOf(aTag);
				if (indexHref == -1) break;
				int indexHrefEnd = a.IndexOf(aEnd, indexHref);
				if (indexHrefEnd == -1) break;
				string link = a.Substring(indexHref + aTag.Length, indexHrefEnd - (indexHref + aTag.Length));
				int indexAEnd = a.IndexOf(closeA);
				string title = a.Substring(indexHrefEnd + aEnd.Length, indexAEnd - (indexHrefEnd + aEnd.Length));
				result = result.Replace(aTag + link + aEnd, "[" + title + "]");
				result = result.Replace(title + closeA, ("(" + link + ")"));
				a = a.Substring(indexAEnd + closeA.Length);
			}
			return result;

		}

		static void Main()
		{
			string text = Console.ReadLine();

			Console.WriteLine(	ReplaceTags(text));
		}
	}
}
