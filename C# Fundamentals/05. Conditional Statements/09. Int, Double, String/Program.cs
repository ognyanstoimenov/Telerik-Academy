using System;

namespace _09.Int__Double__String
{
	class Program
	{
		static void Main()
		{
			string type = Console.ReadLine();

			switch (type)
			{
				case "integer":
					int n = int.Parse(Console.ReadLine());
					Console.WriteLine(n+1);
					break;
				case "real":
					double t = double.Parse(Console.ReadLine());
					Console.WriteLine("{0:F2}",t+1);
					break;
				case "text":
					string s = Console.ReadLine();
					Console.WriteLine(s + "*");
					break;
			}
		}
	}
}
