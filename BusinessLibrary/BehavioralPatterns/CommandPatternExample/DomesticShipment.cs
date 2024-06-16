namespace BusinessLibrary.BehavioralPatterns.CommandPatternExample;

public class DomesticShipment : IShipment
{
    public void SendShipment()
    {
        Console.WriteLine("Domestic shipment sent");
    }
}