namespace _01.School_classes
{
	public class Student : Person, ICommentable
	{
		public Student(string name, int classNum) : base(name)
		{
			this.ClassNumber = classNum;
		}

		public Student(string name, int classNum, string comment) : this(name,classNum)
		{
			this.Comment = comment;
		}

		public int ClassNumber { get; }
	}
}
