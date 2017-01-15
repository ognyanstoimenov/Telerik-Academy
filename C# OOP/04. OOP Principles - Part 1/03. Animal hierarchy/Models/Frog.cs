namespace _03.Animal_hierarchy.Models
{
	using _03.Animal_hierarchy.Interfaces;

	public class Frog : Animal, ISound
	{
		public Frog(string name, int age, Gender gender) : base(name, age, gender)
		{
			this.Sound = "Quack";
		}
	}
}
