namespace BusinessLibrary.BehavioralPatterns.StrategyPattern;

public class ConcreteStrategyB : IStrategy
{
    public void Execute(string destination)
    {
        Console.WriteLine("Driving to " + destination);
    }
}