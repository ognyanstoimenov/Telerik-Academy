namespace SchoolSystem.Models
{
    using System;
    using System.Collections.Generic;
    public class School
    {

        public School(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
        }

        public string Name { get; private set; }

        public IList<Student> Students { get; set; }

        public IList<Course> Courses { get; private set; }

        public Student CreateStudent(string name, int id)
        {
            Student student = new Student(name, id);
            Students.Add(student);
            return student;
        }

        public Course CreateCourse(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            Course course = new Course(name);
            Courses.Add(course);
            return course;
        }
    }
}
