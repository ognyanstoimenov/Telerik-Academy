namespace _03.Animal_hierarchy.Models
{
	using _03.Animal_hierarchy.Interfaces;

	public class Kitten : Cat,ISound
	{
		public Kitten(string name, int age) : base(name, age, Gender.Female)
		{
			this.Sound = "Purr";
		}
	}
}
