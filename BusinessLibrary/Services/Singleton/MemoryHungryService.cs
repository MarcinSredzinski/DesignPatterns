namespace BusinessLibrary.Services.Singleton;

public class MemoryHungryService : ISayHello
{
    public MemoryHungryService()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("DI approach, new instance of Memory Hungry Service was created!");
    }

    public void SayHello(string origin)
    {
        Console.WriteLine($"Hello there! From {origin}");
    }
}