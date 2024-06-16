namespace BusinessLibrary.BehavioralPatterns.CommandPatternExample;

public class CancelOrder(OrderCancellationService orderCancellationService) : ICommand
{
    public void Execute()
    {
        orderCancellationService.CancelOrder();
    }
}