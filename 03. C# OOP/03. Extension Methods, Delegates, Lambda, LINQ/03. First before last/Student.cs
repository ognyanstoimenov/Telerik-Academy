namespace _03.First_before_last
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public override string ToString()
		{
			return this.FirstName + ' ' + this.LastName;
		}
	}

}
