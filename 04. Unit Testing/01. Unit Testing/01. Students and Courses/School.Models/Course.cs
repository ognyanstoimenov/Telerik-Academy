namespace SchoolSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Course
    {

        internal Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public string Name { get; private set; }
        public List<Student> Students { get; }

        public void AddStudent(Student student)
        {
            if (this.Students.Count >= 30)
            {
                throw new ArgumentException("Max number of Students exceeded");
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!Students.Any(x => x == student))
            {
                throw new ArgumentException("Student not found");
            }
            this.Students.Remove(student);
        }

        public string AllStudents()
        {
            StringBuilder result = new StringBuilder();

            foreach (var student in this.Students)
            {
                Console.WriteLine(student);
            }

            return result.ToString();
        }
    }
}
