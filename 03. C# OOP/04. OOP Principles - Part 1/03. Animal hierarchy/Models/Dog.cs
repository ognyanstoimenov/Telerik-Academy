namespace _03.Animal_hierarchy.Models
{
	using System;
	using _03.Animal_hierarchy.Interfaces;

	public class Dog : Animal, ISound
	{
		public Dog(string name, int age, Gender gender) : base(name, age, gender)
		{
			this.Sound = "Bark";
		}
	}
}
