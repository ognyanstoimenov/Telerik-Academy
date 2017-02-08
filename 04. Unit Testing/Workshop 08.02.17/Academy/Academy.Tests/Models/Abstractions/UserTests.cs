namespace Academy.Tests.Models.Abstractions
{
    using Academy.Models;
    using Academy.Models.Abstractions;
    using Moq;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class UserTests
    {
        [Test]
        public void ConstructorShould_CorrectlyAssignValidName()
        {
            // Arrange & Act
            var userMock = new FakeUser("Valid name");

            // Assert
            Assert.IsTrue(userMock.Username == "Valid name");
        }

        [Test]
        public void TooShortNameShould_ThrowArgumentException()
        {
            // Arrange
            string tooShortName = "O";
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new FakeUser(tooShortName));
        }

        public void TooLongNameShould_ThrowArgumentException()
        {
            // Arrange
            string tooLongName = new string('O', 20);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new FakeUser(tooLongName));
        }
    }
}
