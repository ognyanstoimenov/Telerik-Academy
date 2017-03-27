using Academy.Commands.Adding;
using Academy.Core.Contracts;
using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Academy.Tests.Commands.Adding
{
    [TestFixture]
    public class AddStudentToSeasonCommandTests
    {
        [Test]
        public void ConstructorShould_ThrowArgumentNullException_WhenFactoryIsNull()
        {
            // Arrange
            var engineStub = new Mock<IEngine>();


            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineStub.Object));
        }

        [Test]
        public void ConstructorShould_ThrowArgumentNullException_WhenEngineIsNull()
        {
            // Arrange
            var factoryStub = new Mock<IAcademyFactory>();


            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(factoryStub.Object, null));
        }

        [Test]
        public void ConstructorShould_CorrectlyAssignValidValues()
        {
            // Arrange
            var factoryStub = new Mock<IAcademyFactory>();
            var engineStub = new Mock<IEngine>();

            // Act
            var fakeCommand = new FakeAddStudentToSeasonCommand(factoryStub.Object, engineStub.Object);

            // Assert
            Assert.AreEqual(factoryStub.Object, fakeCommand.Factory);
            Assert.AreEqual(engineStub.Object, fakeCommand.Engine);
        }

        [Test]
        public void ExecuteShould_ThrowArgumentException_WhenTheStudentIsAlreadyInSeason()
        {
            // Arrange
            var factoryStub = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();

            studentMock.Setup(x => x.Username).Returns("Pesho");
            seasonMock.SetupGet(x => x.Students).Returns(new List<IStudent> { studentMock.Object });

            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent> { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason> { seasonMock.Object });

            var fakeCommand = new AddStudentToSeasonCommand(factoryStub.Object, engineMock.Object);

            var testParams = new List<string> { "Pesho", "0" };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => fakeCommand.Execute(testParams));
        }

        [Test]
        public void ExecuteShould_CorrectlyAddFoundStudents()
        {
            // Arrange
            var factoryStub = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();

            studentMock.Setup(x => x.Username).Returns("Pesho");
            seasonMock.SetupGet(x => x.Students).Returns(new List<IStudent>());

            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent> { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason> { seasonMock.Object });

            var fakeCommand = new AddStudentToSeasonCommand(factoryStub.Object, engineMock.Object);

            var testParams = new List<string> { "Pesho", "0" };

            // Act 
            var result = fakeCommand.Execute(testParams);

            // Assert
            Assert.IsTrue(seasonMock.Object.Students[0] == studentMock.Object);
        }

        [Test]
        public void ExecuteShould_ReturnSuccessMessage_WhenStudentIsAdded()
        {
            var factoryStub = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var studentMock = new Mock<IStudent>();
            var seasonMock = new Mock<ISeason>();

            studentMock.Setup(x => x.Username).Returns("Pesho");
            seasonMock.SetupGet(x => x.Students).Returns(new List<IStudent>());

            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent> { studentMock.Object });
            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason> { seasonMock.Object });

            var fakeCommand = new AddStudentToSeasonCommand(factoryStub.Object, engineMock.Object);

            var testParams = new List<string> { "Pesho", "0" };

            // Act 
            var result = fakeCommand.Execute(testParams);

            StringAssert.Contains("Pesho", result);
            StringAssert.Contains("Season 0", result);
        }

    }
}
