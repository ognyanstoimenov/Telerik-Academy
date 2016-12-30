using System;

namespace _01.Leap_year
{
	class Program
	{
		static void Main()
		{ 
			int year = int.Parse(Console.ReadLine());
			bool isLeap = DateTime.IsLeapYear(year);
			Console.WriteLine(isLeap==true? "Leap" : "Common");
		}
	}
}
