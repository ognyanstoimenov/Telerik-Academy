using System;

namespace _01.Say_Hello
{
	class Program
	{
		static void Name(string name)
		{
			Console.WriteLine("Hello, {0}!",name);
		}
		static void Main()
		{
			string name = Console.ReadLine();
			Name(name);
		}
	}
}
