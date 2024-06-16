namespace BusinessLibrary.BehavioralPatterns.CommandPatternExample;

public class PrepareOrderForShipment(IShipment shipment) : ICommand
{
    public void Execute()
    {
        shipment.SendShipment();
    }
}