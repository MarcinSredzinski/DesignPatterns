namespace BusinessLibrary.BehavioralPatterns.CommandPatternExample;

public class InternationalShipment : IShipment
{
    public void SendShipment()
    {
        Console.WriteLine("International shipment sent");
    }
}