using BusinessLibrary.BehavioralPatterns.CommandPatternExample;

namespace BusinessTests.CommandPattern
{
    /// <summary>
    /// I know this test doesn't test anything. It's just here 
    /// as an example of an usage and entry point for debugging
    /// </summary>
    public class CommandPatternTests
    {
        [Test]
        public void PrepareForInternationalShipment_ShouldPrepareForInternationalShipment()
        {
            // Arrange
            var command = new PrepareOrderForShipment(new InternationalShipment());
            // Act
            command.Execute();
            // Assert
            Assert.Pass();
        }
    }
}
