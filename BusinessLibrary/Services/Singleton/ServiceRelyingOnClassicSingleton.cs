namespace BusinessLibrary.Services.Singleton;

public class ServiceRelyingOnClassicSingleton
{
    public string DoSomethingAfterSayingHello()
    {
        string helloText = MemoryHungryServiceClassic.Instance.SayHello(" ServiceRelyingOnClassicSingleton ");
        string modifiedHelloText = helloText.Replace("hello", "bye", StringComparison.InvariantCultureIgnoreCase);
        return modifiedHelloText;
    }
}