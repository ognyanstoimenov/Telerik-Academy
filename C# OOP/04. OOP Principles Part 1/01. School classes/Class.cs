namespace _01.School_classes
{
	using System;
	using System.Collections.Generic;

	class Class : ICommentable
	{
		public Class(IList<Teacher> teachers, string id)
		{
			this.Teachers = teachers;
			this.Identifier = id;
		}

		public IList<Teacher> Teachers { get; set; }

		public string Identifier { get; }

		public string Comment { get; set; }
	}
}
