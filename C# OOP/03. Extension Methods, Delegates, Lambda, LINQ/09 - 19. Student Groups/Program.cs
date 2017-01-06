namespace _09___19.Student_Groups
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	class Program
	{

		public static List<Student> GetStudent()
		{
			return new List<Student>
			{
				new Student
				{
					FirstName = "Anton",
					LastName = "Nedyalkov",
					FN = "024207",
					Tel = "0245123455",
					Email = "anton@abv.bg",
					Marks = new List<int>{2 ,2 ,6},
					GroupNumber = 3
				},

				new Student
				{
					FirstName = "Matrin",
					LastName = "Stoqnov",
					FN = "076207",
					Tel = "0234234215",
					Email = "stoqnov@gmail.com",
					Marks = new List<int>{4 ,4 ,4},
					GroupNumber = 2
				},

				new Student
				{
					FirstName = "Lora",
					LastName = "Stoqnova",
					FN = "061115",
					Tel = "0848188611",
					Email = "lora123@gmail.com",
					Marks = new List<int>{3 ,2 ,2},
					GroupNumber = 2
				},

				new Student
				{
					FirstName = "Plamena",
					LastName = "Lakova",
					FN = "073206",
					Tel = "0872654470",
					Email = "plamataxdd@abv.bg",
					Marks = new List<int>{6 ,6 ,6},
					GroupNumber = 2
				},

				new Student
				{
					FirstName = "Denis",
					LastName = "Dimitrov",
					FN = "068705",
					Tel = "0214875744",
					Email = "denidd@abv.bg",
					Marks = new List<int>{4 ,3 ,2},
					GroupNumber = 4
				},
				new Student{
					FirstName = "Mariq",
					LastName = "Ilieva",
					FN = "028306",
					Tel = "08/94314874",
					Email = "denidd@abv.bg",
					Marks = new List<int>{4 ,3 ,2},
					GroupNumber = 4
				},
			};
		}


		static void Main()
		{
			IEnumerable<Student> studentList = GetStudent();
			//09. Student groups (with LINQ)
			var resultLINQ =
				from st in studentList
				where st.GroupNumber == 2
				orderby st.FirstName
				select st;

			//10. Student groups (with Extensions)
			var resultLambda = studentList.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);
			resultLambda.PrintStudents("Students with group number 2: ");

			//11. Extract students by email
			var resultAbvMail =
				from st in studentList
				where st.Email.Contains("abv.bg")
				select st;
			resultAbvMail.PrintStudents("Students with mail in abv.bg");

			//12. Extract students by phone
			var resultPhoneInSofia =
				from st in studentList
				where st.Tel.Substring(0, 2) == "02"
				select st;
			resultPhoneInSofia.PrintStudents("Students with phones in Sofia: ");

			//13. Extract students by marks
			var result6 =
				from st in studentList
				where st.Marks.Contains(6)
				select new { FullName = st.FirstName + " " + st.LastName, Marks = String.Join(", ", st.Marks) };
			result6.PrintStudents("Students with atleast one excellent mark: ");

			//14. Extract students with two marks
			var resultTwoMarks = studentList.Where(x => x.Marks.Where(mark => mark == 2).Count() == 2);
			resultTwoMarks.PrintStudents("Students with exactly two marks '2':");

			//15. Extract marks
			var resultMarks = studentList.Where(x => x.FN.Substring(4, 2) == "06");
			resultMarks.PrintStudents("Students who enrolled in 2006");

			//18. Grouped by
			var grouped =
				from st in studentList
				group st by st.GroupNumber into g
				select new
		}
	}
}
