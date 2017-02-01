namespace _03.First_before_last
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

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
				}
	};
		}

		static void Main()
		{
			List<Student> students = GetStudents();
			var resultedStudents =
				from st in students
				where st.FirstName.CompareTo(st.LastName) < 0
				select st;

			Console.WriteLine("ALL STUDENTS:");
			foreach (var st in students)
			{
				Console.WriteLine(st);
			}

			Console.WriteLine("===========================");

			Console.WriteLine("RESULT:");
			foreach (var st in resultedStudents)
			{
				Console.WriteLine(st);
			}

		}
	}
}
