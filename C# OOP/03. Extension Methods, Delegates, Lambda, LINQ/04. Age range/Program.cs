namespace _04.Age_range
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class Program
	{

		public static List<Student> GetStudents()
		{
			return new List<Student>
			{
				new Student
				{
					FirstName="Georgi",
					LastName="Malinov",
					Age=16
				},
				new Student
				{
					FirstName="Martin",
					LastName="Atanasov",
					Age=18
				},
				new Student
				{
					FirstName="Teodora",
					LastName="Simeonova",
					Age=20
				},
				new Student
				{
					FirstName="Zinedin",
					LastName="Zidan",
					Age=54
				},
				new Student
				{
					FirstName="Alba",
					LastName="Albova",
					Age=17
				}
	};
		}

		static void Main()
		{
			List<Student> students = GetStudents();

			var resultedStudents =
				from st in students
				where st.Age >= 18 && st.Age <= 24
				select st;

			Console.WriteLine("ALL STUDENTS:");
			foreach (var st in students)
			{
				Console.WriteLine(st);
			}

			Console.WriteLine("===========================");

			Console.WriteLine("Students with age between 18 and 24:");
			foreach (var st in resultedStudents)
			{
				Console.WriteLine(st.FirstName + " " + st.LastName);
			}
		}
	}
}
