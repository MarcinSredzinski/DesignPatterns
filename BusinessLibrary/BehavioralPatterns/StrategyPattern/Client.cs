namespace BusinessLibrary.BehavioralPatterns.StrategyPattern;

public class Client
{
    public void ExecuteExample()
    {
        var context = new Context();
        var planeOrBus = "plane"; //yeah, magic strings etc. Just a demonstration of principle. 
        switch (planeOrBus)
        {
            case "plane":
            {
                var strategy = new ConcreteStrategyA();
                context.Strategy = strategy;
                context.ExecuteStrategy("New York");
                break;
            }
            case "bus":
            {
                var strategy = new ConcreteStrategyB();
                context.Strategy = strategy;
                context.ExecuteStrategy("New York");
                break;
            }
        }
    }
}