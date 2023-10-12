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
        [TestCase("potatoes", "--------------Hello there! Said hello 0 times, from: potatoes")]
        [TestCase("case 2", "--------------Hello there! Said hello 0 times, from: case 2")]
        [TestCase("AAAAAAAAA", "--------------Hello there! Said hello 0 times, from: AAAAAAAAA")]
        public void SayHelloShouldReturnString(string origin, string expected)
        {
            //Arrange
            var service = MemoryHungryServiceClassic.Instance;
            //Act
            string actual = service.SayHello(origin);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        //Why isn't it passing? 
        #region spoiler
        //Weren't our tests supposed to run on fresh instances of the object?
        #endregion

        [TestCase("--------------bye there! Said bye 0 times, from:  ServiceRelyingOnClassicSingleton ")]
        [TestCase("--------------bye there! Said bye 1 times, from:  ServiceRelyingOnClassicSingleton ")]
        public void DoSomethingAfterSayingHelloShouldReturnString(string expected) 
        {
            //Arrange            
            var service = new ServiceRelyingOnClassicSingleton();
            //Act
            string actual = service.DoSomethingAfterSayingHello();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
