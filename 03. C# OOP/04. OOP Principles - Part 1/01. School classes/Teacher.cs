namespace _01.School_classes
{
	using System.Collections.Generic;

	public class Teacher : Person, ICommentable
	{
		public Teacher(string name, IList<Discipline> disciplines) : base(name)
		{
			this.Disciplines = disciplines;
		}

		public Teacher (string name, IList<Discipline> disciplines, string comment) : this(name,disciplines)
		{
			base.Comment = comment;
		}

		public IList<Discipline> Disciplines { get; }
	}
}

