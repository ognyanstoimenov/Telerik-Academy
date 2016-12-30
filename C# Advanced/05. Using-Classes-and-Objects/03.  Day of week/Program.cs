using System;

namespace _03.Day_of_week
{
	class Program
	{
		static void Main()
		{
			DateTime currentDate = new DateTime();
			currentDate = DateTime.Now;
			DayOfWeek currentDay = currentDate.DayOfWeek;
			Console.WriteLine(currentDay);

		}
	}
}
