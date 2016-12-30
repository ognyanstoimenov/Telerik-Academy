using System;
using System.Text.RegularExpressions;
namespace _04.Kot_Takoa
{
	class Program
	{

		static string SpacesAndLineBreaks(string a)
		{
			string pattern = @"(\s)+";
			string quotes = @"("")(.*?)("")";
			string quote = Regex.Match(a, quotes).Groups[2].ToString();
			a = Regex.Replace(a, pattern," ");
			string pattern2 = @"("")(.*?)("")";
			a = Regex.Replace(a, pattern2, String.Format("\"{0}\"",quote));
			return a;
		}

		static string MergeVariables(string a)
		{
			string pattern = @"(bool|int|char|string|decimal)(\s)";
			a = Regex.Replace(a, pattern, ",");
			return a;
		}

		static void Main()
		{
			//int linesCount = int.Parse(Console.ReadLine());
			//string[] code = new string[linesCount];
			//string previousType = "";
			//for (int i = 0; i < linesCount; i++)
			//{
			//	code[i] = Console.ReadLine();
			//	string currentType = code[i].Remove(code[i].IndexOf(" "));

			//	if (currentType == "bool" || currentType == "int" || currentType == "char" || currentType == "string" || currentType == "decimal")
			//	{
			//		if (currentType == previousType) MergeVariables(a);
			//		previousType = currentType;
			//	}


			//		if (code[i] == "stopp") break;
			//}
			string a = Console.ReadLine();
			Console.WriteLine(MergeVariables(a));
		}
	}
}
