namespace Academy.Tests.Models
{
    using Academy.Models;
    using Academy.Models.Contracts;
    using Moq;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CourseTests
    {
        const string validName = "Valid Name";
        const string nullName = " ";
        const string tooShortName = "xd";
        readonly string tooLongName = new string('t', 46);

        const int validLecturesCount = 2;
        const int tooFewLectures = 0;
        const int tooManyLectures = 8;

        DateTime validSDate = new DateTime(2016, 04, 12);
        DateTime validEDate = new DateTime(2016, 04, 16);

        public Course CreateValidCourse()
        {
            return new Course(validName, validLecturesCount, validSDate, validEDate);
        }

        [Test]
        [Ignore("")]
        public void CorrectlyAssignValues()
        {
            var course = CreateValidCourse();

            Assert.IsTrue(course.Name == validName);
            Assert.IsTrue(course.LecturesPerWeek == validLecturesCount);
            Assert.IsTrue(course.StartingDate == validSDate);
            Assert.IsTrue(course.EndingDate == validEDate);
        }

        [Test]
        [Ignore("")]
        public void CorrerlyInitialiseCollections()
        {
            var course = CreateValidCourse();

            Assert.IsTrue(course.OnlineStudents != null);
            Assert.IsTrue(course.OnsiteStudents != null);
            Assert.IsTrue(course.Lectures != null);
        }

        #region Name Tests
        [Test]
        public void ThrowArgumentException_WhenNameIsTooShort()
        {
            Assert.Throws<ArgumentException>(() => new Course(tooShortName, validLecturesCount, validSDate, validEDate));
        }

        [Test]
        public void ThrowArgumentException_WhenNameIsTooLong()
        {
            Assert.Throws<ArgumentException>(() => new Course(tooLongName, validLecturesCount, validSDate, validEDate));
        }

        [Test]
        public void ThrowArgumentException_WhenNameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Course(nullName, validLecturesCount, validSDate, validEDate));
        }

        [Test]
        public void CorrectlyAssign_ValidName()
        {
            var course = CreateValidCourse();

            Assert.IsTrue(course.Name == validName);
        }
        #endregion

        #region LecturesPerWeek Tests

        [Test]
        public void ThrowArgumentException_WhenLecturesAmountIsTooLarge()
        {
            Assert.Throws<ArgumentException>(() => new Course(validName, tooManyLectures, validSDate, validEDate));
        }

        [Test]
        public void ThrowArgumentException_WhenLecturesAmountIsTooSmall()
        {
            Assert.Throws<ArgumentException>(() => new Course(validName, tooFewLectures, validSDate, validEDate));
        }

        [Test]
        public void CorrectlyAssign_ValidLecturesAmount()
        {
            var course = new Course(validName, validLecturesCount, validSDate, validEDate);

            Assert.IsTrue(course.LecturesPerWeek == validLecturesCount);
        }
        #endregion

        #region StartingDate and EndingDate Tests
        [Test]
        public void ThrowArgumentException_WhenStartingDateIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Course(validName, validLecturesCount, DateTime.Parse(null), validEDate));
        }
        [Test]
        public void ThrowArgumentException_WhenEndingDateIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Course(validName, validLecturesCount, validSDate, DateTime.Parse(null)));
        }

        [Test]
        public void CorretlyAssign_ValidDates()
        {
            var course = new Course(validName, validLecturesCount, validSDate, validEDate);

            Assert.IsTrue(course.StartingDate == validSDate);
            Assert.IsTrue(course.EndingDate == validEDate);
        }
        #endregion

        #region ToString() Tests
        [Test]
        public void ToStringShould_IterateOverCollection()
        {
            // Arrange
            var course = CreateValidCourse();
            var lectureMock = new Mock<ILecture>();

            lectureMock.Setup(x => x.ToString()).Verifiable();
            course.Lectures.Add(lectureMock.Object);
 
            // Act
            course.ToString();

            // Assert
            lectureMock.Verify(x => x.ToString(), Times.Once());
        }
#endregion
    }
}
