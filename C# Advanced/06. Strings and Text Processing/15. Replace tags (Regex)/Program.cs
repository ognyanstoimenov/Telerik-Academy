using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
	static void Main()
	{
		string text = Console.ReadLine();
		string pattern = "(<upcase>)(.*?)(</upcase>)";
		Console.WriteLine(Regex.Replace(text, pattern, "$2".ToUpper()));
	}

	//static string repcae(Match a)
	//{
	//	string result = a.ToString();
	//	result = result.Replace("<upcase>", "");
	//	result = result.Replace("</upcase>", "");

	//	return result.ToUpper();
	//}

}
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
+