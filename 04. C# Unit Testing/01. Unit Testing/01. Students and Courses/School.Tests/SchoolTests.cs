namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem.Models;
    [TestClass]
    public class SchoolTests
    {

        private School school;
        [TestInitialize]
        public void Init()
        {
            school = new School("81 SOU");
        }

        [TestMethod]
        public void SchoolConstructorShould_CorrectlyInitializeProperties()
        {
            //Arrange
            string testName = "BlaBla";
            var schoolTest = new School(testName);

            //Act and Assert
            Assert.AreEqual(testName, schoolTest.Name);
            Assert.IsTrue(school.Courses.Count == 0);
            Assert.IsTrue(school.Students.Count == 0);

        }

        [TestMethod]
        public void CreateStudentShould_ThrowArgumentException_WhenNameIsInvalid()
        {
            Assert.ThrowsException<ArgumentException>(() => school.CreateStudent("InvalidName", 45321));
        }

        [TestMethod]
        public void CreateStudentShould_ThrowArgumentException_WhenIdIsInvalid()
        {
            Assert.ThrowsException<ArgumentException>(() => school.CreateStudent("Valid Name", 453211));
        }

        [TestMethod]
        public void CreateStudentShould_Pass_WhenAllIsValid()
        {
            var st = school.CreateStudent("Valid Name", 45321);
        }

        [TestMethod]
        public void CreateCourseShould_ThrowArgumentException_WhenCourseWithNoNameIsAdded()
        {
            Assert.ThrowsException<ArgumentException>(() => school.CreateCourse(""));
        }

        [TestMethod]
        public void CreateStudentShould_CorrectlyInitialiseValues()
        {
            //Arrange
            string validName = "Valid Name";
            int validId = 78321;

            //Act
            Student student = school.CreateStudent(validName, validId);

            //Assert
            Assert.AreEqual(student.Name, validName);
            Assert.AreEqual(student.Id, validId);
        }
    }
}
