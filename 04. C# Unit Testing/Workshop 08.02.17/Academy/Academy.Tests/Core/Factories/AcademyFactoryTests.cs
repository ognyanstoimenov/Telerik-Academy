using Academy.Core.Contracts;
using Academy.Core.Factories;
using Academy.Models.Utils.LectureResources;
using Moq;
using NUnit.Framework;
using System;

namespace Academy.Tests.Core.Factories
{
    [TestFixture]
    public class AcademyFactoryTests
    {
        [Test]
        public void CreateLectureResourceShould_ThrowArgumentException_WhenTypeIsInvalid()
        {
            var academyFactory = AcademyFactory.Instance;


            Assert.Throws<ArgumentException>(() =>
            {
                academyFactory.CreateLectureResource("invalid", "validName", "validUrl");
            });

        }
        
        [Test]
        [TestCase("video", typeof(VideoResource))]
        [TestCase("presentation", typeof(PresentationResource))]
        [TestCase("demo", typeof(DemoResource))]
        [TestCase("homework", typeof(HomeworkResource))]
        public void CreateLectureResourceShould_CreateVideoResource_WhenVideoTypeIsPassed(string type, Type expectedType)
        {
            var academyFactory = AcademyFactory.Instance;

            var result = academyFactory.CreateLectureResource(type, "validName", "validUrl");

            Assert.IsInstanceOf(expectedType, result);
        }


    }
}
