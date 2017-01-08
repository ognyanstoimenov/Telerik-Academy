namespace _03.Animal_hierarchy.Models
{
	using _03.Animal_hierarchy.Interfaces;
	using System.Collections.Generic;
	using System.Linq;

	public abstract class Animal : ISound
	{
		public string Sound { get; set; }

		public Animal(string name, int age, Gender gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public string Name { get; set; }

		public int Age { get; set; }

		public Gender Gender { get; protected set; }

		public void MakeSound()
		{
			string breed = this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.') + 1, this.GetType().ToString().Length - this.GetType().ToString().LastIndexOf('.') - 1);
			System.Console.WriteLine($"The {breed} {this.Name} said {this.Sound}");
		}
	}
}
