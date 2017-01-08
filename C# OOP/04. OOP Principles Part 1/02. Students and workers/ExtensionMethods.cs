namespace _02.Students_and_workers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class ExtensionMethods
	{
		public static void PrintStudentsAndGrades<T>(this IList<T> list) where T : Student
		{
			foreach (var item in list)
			{
				Console.WriteLine(string.Format($@"{item.FirstName} {item.LastName}, Grade: {item.GradeWithWords} ({item.Grade:F2})"));
			}
		}

		public static void PrintWorkersAndMoney<T>(this IList<T> list) where T : Worker
		{
			foreach (var item in list)
			{
				Console.WriteLine(string.Format($@"{item.FirstName} {item.LastName}, Money per hour: ${item.MoneyPerHour():F2}"));
			}
		}
	}
}
