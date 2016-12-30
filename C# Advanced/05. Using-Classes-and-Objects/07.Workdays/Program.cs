using System;

namespace _07.Workdays
{
	class Program
	{
		static void Main()
		{
			DateTime today = DateTime.Today;
			Console.WriteLine(today);
			DateTime inputDate = new DateTime();
			inputDate = DateTime.Parse(Console.ReadLine());
			TimeSpan difference = inputDate - today;
		}
	}
}
