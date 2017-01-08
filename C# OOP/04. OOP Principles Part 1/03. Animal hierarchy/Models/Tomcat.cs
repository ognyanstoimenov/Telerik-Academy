namespace _03.Animal_hierarchy.Models
{
	using _03.Animal_hierarchy.Interfaces;

	public class Tomcat : Cat, ISound
	{
		public Tomcat(string name, int age) : base(name, age, Gender.Male)
		{
			this.Sound = "Mew";
		}
	}
}
