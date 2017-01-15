namespace _03.Animal_hierarchy.Models
{
	using _03.Animal_hierarchy.Interfaces;

	public class Cat : Animal, ISound
	{
		public Cat(string name, int age, Gender gender) : base(name, age, gender)
		{
			this.Sound = "Meow";
		}
	}
}
