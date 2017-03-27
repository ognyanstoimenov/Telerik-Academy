namespace Academy.Tests.Models
{
    using Academy.Models;
    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Moq;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SeasonTests
    {
        #region ListUsers Tests
        [Test]
        public void ListUsersShould_ReturnAListOfStudents()
        {
            // Arrange
            var season = new Season(2016,2017,Initiative.CoderDojo);
            var studentMock = new Mock<IStudent>();
            var trainerMock = new Mock<ITrainer>();
            
            studentMock.Setup(x => x.ToString());
            trainerMock.Setup(x => x.ToString());

            season.Students.Add(studentMock.Object);
            season.Trainers.Add(trainerMock.Object);
            
            // Act
            season.ListUsers();

            // Assert
            studentMock.Verify(x => x.ToString(), Times.Exactly(1));
            trainerMock.Verify(x => x.ToString(), Times.Exactly(1));

        }
        [Test]
        public void ListUsersShould_ReturnMessage_WhenThereAreNoStudentsInTheCourse()
        {
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            Assert.IsTrue(season.ListUsers().IndexOf("No users",StringComparison.OrdinalIgnoreCase) >= 0);
        }
        #endregion

        #region ListCourses
        [Test]
        public void ListCoursesShould_ReturnListOfLectures()
        {
            // Arrange
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            var courseMock = new Mock<ICourse>();
            courseMock.Setup(x => x.ToString());

            // Act
            season.Courses.Add(courseMock.Object);
            season.ListCourses();

            // Assert
            courseMock.Verify(x => x.ToString(), Times.Once);
        }

        [Test]
        public void ListCoursesShould_ReturnMessage_WhenThereAreNoCourses()
        {
            // Arrange
            var season = new Season(2016, 2017, Initiative.CoderDojo);

            // Act
            var result = season.ListCourses();
            
            // Assert
            Assert.IsTrue(result.IndexOf("no courses", StringComparison.OrdinalIgnoreCase) >= 0);
        }
        #endregion


    }
}
