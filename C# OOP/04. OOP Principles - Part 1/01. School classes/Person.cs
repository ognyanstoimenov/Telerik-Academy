using System;

namespace _01.School_classes
{
    public abstract class Person : ICommentable
    {
		public Person(string name)
		{
			this.Name = name;
		}

		public string Comment { get; set; }

		public string Name { get; }
	}
}
