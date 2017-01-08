namespace _02.Students_and_workers
{
	using System;

	public class Student : Human
	{
		private float grade;

		public Student(string firstName, string lastName, float grade) : base(firstName, lastName)
		{
			this.Grade = grade;
		}

		public float Grade
		{
			get
			{
				return this.grade;
			}
			set
			{
				if (value < 2 || value > 6)
				{
					throw new ArgumentException("Grade must be between 2 and 6");
				}
				this.grade = value;
			}
		}

		public string GradeWithWords
		{
			get
			{
				switch ((int)Math.Round(this.Grade))
				{
					case 2: return "Bad";
					case 3: return "Average";
					case 4: return "Good";
					case 5: return "Very Good";
					case 6: return "Excellent";
					default: throw new ArgumentException();
				}
		}
	}
}
}
