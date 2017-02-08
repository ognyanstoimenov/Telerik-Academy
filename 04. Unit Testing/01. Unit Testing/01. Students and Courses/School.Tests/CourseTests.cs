namespace School.Tests.Course
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem.Models;

    [TestClass]
    public class CourseTests
    {
        private const string validName = "Valid Name";
        private const int validId = 15712;
        School school;

        [TestInitialize]
        public void Init()
        {
            school = new School("81SOU");
        }

        [TestMethod]
        public void AddStudentShould_CorrectlyAssignStudent()
        {
            //Arrange
            var course = school.CreateCourse("C# UT");
            var student = school.CreateStudent(validName, validId);

            //Act
            course.AddStudent(student);

            //Assert
            Assert.AreEqual(student, course.Students[0]);
        }

        [TestMethod]
        public void AddStudentShould_ThrowArgumentException_WhenMoreThan30StudentsAdded()
        {
            //Arrange
            var course = school.CreateCourse("C# UT");

            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                for (int i = 0; i <= 30; i++)
                {
                    course.AddStudent(school.CreateStudent(validName, validId));
                }
            });
        }

        [TestMethod]
        public void RemoveStudentShould_ThrowArgumentException_WhenStudentNotFound()
        {
            //Arrange
            var course = school.CreateCourse("C# UT");
            Student student = school.CreateStudent(validName, validId);
            
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => course.RemoveStudent(student));
        }

        [TestMethod]
        public void RemoveStudentShould_Pass_WhenStudentIsFound()
        {
            //Arrange
            var course = school.CreateCourse("C# UT");
            Student student = school.CreateStudent(validName, validId);
            //Act
            course.AddStudent(student);
            course.RemoveStudent(student);
        }
    }
}
