namespace _05.Order_students
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
				},
				new Student
				{
					FirstName="Alba",
					LastName="Mironova",
					Age=33
				}
	};
		}

		static void Main()
		{
			List<Student> studentsList = GetStudents();
			
			//LAMBDA
			var result = studentsList
				.OrderByDescending(x => x.FirstName)
				.ThenByDescending(x => x.LastName);
			
			//LINQ
			var resultLINQ =
				from st in studentsList
				orderby st.FirstName descending,st.LastName descending
				select st;

			Console.WriteLine("ORIGINAL:");
			foreach (var item in studentsList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("===========================");

			Console.WriteLine("Ordered:");
			foreach (var item in resultLINQ)
			{
				Console.WriteLine(item);
			}
		}
	}
}
