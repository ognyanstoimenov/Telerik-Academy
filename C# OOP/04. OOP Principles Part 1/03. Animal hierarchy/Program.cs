namespace _03.Animal_hierarchy
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Models;

	class Program
	{
		static void Main()
		{
			Animal[] Dogs = GetDogs();
			Animal[] Cats = GetCats();
			Animal[] Frogs = GetFrogs();
			Animal[] Kittens = GetKittens();
			Animal[] Tomcats = GetTomcats();

			Dogs[0].MakeSound();
			Console.WriteLine("Average Dog Age: " + Dogs.CalculateAverage());

			Cats[0].MakeSound();
			Console.WriteLine("Average Cat Age: " + Cats.CalculateAverage());

			Frogs[0].MakeSound();
			Console.WriteLine("Average Frog Age: " + Frogs.CalculateAverage());

			Kittens[0].MakeSound();
			Console.WriteLine("Average Kittens Age: " + Kittens.CalculateAverage());

			Tomcats[0].MakeSound();
			Console.WriteLine("Average Tomcat Age: " + Tomcats.CalculateAverage());
		}


		#region GetAnimals
		private static Animal[] GetTomcats()
		{
			return new Tomcat[]
			{
				new Tomcat("Thomas", 8),
				new Tomcat("Yogurt", 9),
				new Tomcat("Wrinkle", 6),
				new Tomcat("Azure", 5)
			};
		}

		private static Animal[] GetKittens()
		{
			return new Kitten[]
			{
				new Kitten("Pixie", 4),
				new Kitten("Sierra", 7),
				new Kitten("Isabelle", 4),
				new Kitten("Pickle", 5)
			};
		}

		private static Animal[] GetFrogs()
		{
			return new Frog[]
			{
				  new Frog("Trevor", 1, Gender.Male),
				  new Frog("Jabba the Hutt", 100, Gender.Female)
			};
		}

		private static Animal[] GetDogs()
		{
			return new Dog[]
			{
				new Dog("Lucky",7,Gender.Male),
				new Dog("Dove",4,Gender.Female),
				new Dog("Fiki",9,Gender.Male),
				new Dog("Pippi",2,Gender.Female)
			};
		}

		private static Animal[] GetCats()
		{
			return new Cat[]
			{
				new Cat("Athena",8,Gender.Male),
				new Cat("Meredith", 6, Gender.Female),
				new Cat("Olivia", 7, Gender.Female),
				new Cat("Lilo", 8, Gender.Male),
				new Cat("Bernie", 7, Gender.Male)
			};
		}
		#endregion
	}
}
