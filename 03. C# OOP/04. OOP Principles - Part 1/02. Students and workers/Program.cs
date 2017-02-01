namespace _02.Students_and_workers
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	class Program
	{
		static List<Student> GetStudents()
		{
			return new List<Student>
			{
				new Student("Miroslav","Nikolov",3.32f),
				new Student("Simona","Marinova",5.45f),
				new Student("Teodor","Ivanov",2.00f),
				new Student("Anton","Todorov",4.49f),
				new Student("Mimi","Mimeva",6.00f),
				new Student("Plamena","Lakova",5.67f),
				new Student("Lora","Stoqnova",2.67f),
				new Student("Martin","Paskalev",2.96f),
				new Student("Serder","Serderov",3.50f),
				new Student("Anton","Zyumbyulev",5.20f)
			};
		}

		static List<Worker> GetWorkers()
		{
			return new List<Worker>
			{
				new Worker("Tsveta","Asenova",250,44),
				new Worker("Yosif","Vanchev",500,41),
				new Worker("Ilarion","Goranov",200,38),
				new Worker("Blagoi","Dimov",449,50),
				new Worker("Roza","Viktorova",600,66),
				new Worker("Radko","Andonov",567,25),
				new Worker("Nikola","Genkov",267,23),
				new Worker("Tereza","Valerieva",296, 11),
				new Worker("Aleksandrina","Filipova",350,48),
				new Worker("Milen","Boyadzhiev",520,50)
			};
		}
		static void Main()
		{
			List<Student> studentsList = GetStudents().OrderBy(x => x.Grade).ToList();
			Console.WriteLine("Students ordered by grade: ");
			studentsList.PrintStudentsAndGrades();
			Console.WriteLine("======================");

			List<Worker> workersList = GetWorkers().OrderByDescending(x => x.MoneyPerHour()).ToList();
			Console.WriteLine("Workers ordered by money per hour (descending): ");
			workersList.PrintWorkersAndMoney();
			Console.WriteLine("======================");

			List<Human> mergedList = new List<Human>(studentsList);
			mergedList.AddRange(workersList);
			mergedList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
			Console.WriteLine("Everybody ordered by first name and then by last name: ");
			foreach (var person in mergedList)
			{
				Console.WriteLine(person);
			}

		}
	}
}
