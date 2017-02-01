namespace _09___19.Student_Groups
{
	using System;
	using System.Collections.Generic;

	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FN { get; set; }
		public string Tel { get; set; }
		public string Email { get; set; }
		public IList<int> Marks { get; set; }
		public int GroupNumber { get; set; }

		public override string ToString()
		{
			return this.FirstName + " " + this.LastName;
		}
	
	}
}
