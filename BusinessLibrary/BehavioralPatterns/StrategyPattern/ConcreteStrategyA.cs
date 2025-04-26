namespace BusinessLibrary.BehavioralPatterns.StrategyPattern;

public class ConcreteStrategyA : IStrategy
{
    public void Execute(string destination)
    {
        Console.WriteLine("Flying to " + destination);
    }
}