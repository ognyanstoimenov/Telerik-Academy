namespace Academy.Tests.Models.Course
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Academy.Models;
	using System;

	[TestClass]
	public class Course_Constructor_Should
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

		[TestMethod]
		[Ignore]
		public void CorrectlyAssignValues()
		{
			var course = new Course(validName, validLecturesCount, validSDate, validEDate);

			Assert.IsTrue(course.Name == validName);
			Assert.IsTrue(course.LecturesPerWeek == validLecturesCount);
			Assert.IsTrue(course.StartingDate == validSDate);
			Assert.IsTrue(course.EndingDate == validEDate);
		}

		[TestMethod]
		[Ignore]
		public void CorrerlyInitialiseCollections()
		{
			var course = new Course(validName, validLecturesCount, validSDate, validEDate);


			Assert.IsTrue(course.OnlineStudents != null);
			Assert.IsTrue(course.OnsiteStudents != null);
			Assert.IsTrue(course.Lectures != null);
		}

		#region Name Tests
		[TestMethod]
		public void ThrowArgumentException_WhenNameIsTooShort()
		{
			Assert.ThrowsException<ArgumentException>(() => new Course(tooShortName, validLecturesCount, validSDate, validEDate));
		}

		[TestMethod]
		public void ThrowArgumentException_WhenNameIsTooLong()
		{
			Assert.ThrowsException<ArgumentException>(() => new Course(tooLongName, validLecturesCount, validSDate, validEDate));
		}

		[TestMethod]
		public void ThrowArgumentException_WhenNameIsEmpty()
		{
			Assert.ThrowsException<ArgumentException>(() => new Course(nullName, validLecturesCount, validSDate, validEDate));
		}

		[TestMethod]
		public void CorrectlyAssign_ValidName()
		{
			var course = new Course(validName, validLecturesCount, validSDate, validEDate);

			Assert.IsTrue(course.Name == validName);
		}
		#endregion

		#region LecturesPerWeek Tests

		[TestMethod]
		public void ThrowArgumentException_WhenLecturesAmountIsTooLarge()
		{
			Assert.ThrowsException<ArgumentException>(() => new Course(validName, tooManyLectures, validSDate, validEDate));
		}

		[TestMethod]
		public void ThrowArgumentException_WhenLecturesAmountIsTooSmall()
		{
			Assert.ThrowsException<ArgumentException>(() => new Course(validName, tooFewLectures, validSDate, validEDate));
		}

		[TestMethod]
		public void CorrectlyAssign_ValidLecturesAmount()
		{
			var course = new Course(validName, validLecturesCount, validSDate, validEDate);

			Assert.IsTrue(course.LecturesPerWeek == validLecturesCount);
		}
		#endregion

		#region StartingDate and EndingDate Tests
		[TestMethod]
		public void ThrowArgumentException_WhenStartingDateIsNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() => new Course(validName, validLecturesCount, DateTime.Parse(null), validEDate));
		}
		[TestMethod]
		public void ThrowArgumentException_WhenEndingDateIsNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() => new Course(validName, validLecturesCount, validSDate, DateTime.Parse(null)));
		}

		[TestMethod]
		public void CorretlyAssign_ValidDates()
		{
			var course = new Course(validName, validLecturesCount, validSDate, validEDate);

			Assert.IsTrue(course.StartingDate == validSDate);
			Assert.IsTrue(course.EndingDate == validEDate);
		}
		#endregion

	}
}
