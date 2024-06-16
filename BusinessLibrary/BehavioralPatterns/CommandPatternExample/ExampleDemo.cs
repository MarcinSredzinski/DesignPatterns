namespace BusinessLibrary.BehavioralPatterns.CommandPatternExample;

public class ExampleDemo
{
    public void RunExample()
    {
        //example of a command with a concrete receiver.
        ICommand cancelOrder = new CancelOrder(new OrderCancellationService());
        cancelOrder.Execute();

        //example of a command with a receiver with defined interface.
        ICommand prepareForInternationalShipment = new PrepareOrderForShipment(new InternationalShipment());
        prepareForInternationalShipment.Execute();
    }
}
