using System;

namespace _3
{
	class Program
	{
		static void Main()
		{
			string firstLine = Console.ReadLine();
			string message = string.Empty;
			int lineNumber = 1;
			while (firstLine != "end")
			{
				int E = int.Parse(Console.ReadLine());
				string text = Console.ReadLine();
				int S = Convert.ToInt32(firstLine);
				int increase;
				if (lineNumber % 2 == 0)
				{
					increase = 4;
				}
				else increase = 3;
				if (E < 0) E = text.Length + E;
				if (S < 0) S = text.Length + S;
				for(int i = S; i <= E; i+=increase)
				{
						message += text[i];
				}
				lineNumber++;
				firstLine = Console.ReadLine();
			}
			Console.WriteLine(message);
		}
	}
}
