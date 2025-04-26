namespace BusinessLibrary.BehavioralPatterns.StrategyPattern;

public class Context
{
    public IStrategy? Strategy { get; set; }
    
    public void ExecuteStrategy(string destination)
    {
        if (Strategy is null)
        {
            throw new Exception(nameof(Strategy) + " is null");
        }
        Strategy.Execute(destination);
    } 
}