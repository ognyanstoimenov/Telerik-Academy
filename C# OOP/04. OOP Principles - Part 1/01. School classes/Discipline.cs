namespace _01.School_classes
{
	public class Discipline : ICommentable
	{
		public Discipline(string name, int numOfLect, int numOfEx)
		{
			this.Name = name;
			this.NumberOfLectures = numOfLect;
			this.NumberOfExercises = numOfEx;
		}

		public Discipline(string name, int numOfLect, int numOfEx,string comment) : this(name,numOfLect,numOfEx)
		{
			this.Comment = comment;
		}

		public string Name { get; }

		public int NumberOfLectures { get; }

		public int NumberOfExercises { get; }

		public string Comment { get; set; }
	}
}
