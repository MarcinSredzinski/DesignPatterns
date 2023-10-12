using BusinessLibrary.Services.Singleton;
using Microsoft.Extensions.Logging;
using Moq;

namespace BusinessTests.Singleton
{
    public class MemoryHungryServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("potatoes", "--------------Hello there! potatoes")]
        [TestCase("case 2", "--------------Hello there! case 2")]
        [TestCase("AAAAAAAAA", "--------------Hello there! AAAAAAAAA")]
        public void SayHelloShouldReturnString(string origin, string expected)
        {
            //Arrange
            IMock<ILogger<MemoryHungryService>> loggerMock = new Mock<ILogger<MemoryHungryService>>();
            var service = new MemoryHungryService(loggerMock.Object);
            //Act
            string actual = service.SayHello(origin);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}