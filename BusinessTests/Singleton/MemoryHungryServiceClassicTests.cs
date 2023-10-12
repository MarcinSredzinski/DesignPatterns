using BusinessLibrary.Services.Singleton;

namespace BusinessTests.Singleton
{
    public class MemoryHungryServiceClassicTests
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
            var service = MemoryHungryServiceClassic.Instance;
            //Act
            string actual = service.SayHello(origin);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Weren't we supposed to test in isolation?
    }
}
