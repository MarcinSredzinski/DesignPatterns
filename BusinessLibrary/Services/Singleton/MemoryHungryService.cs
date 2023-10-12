using Microsoft.Extensions.Logging;

namespace BusinessLibrary.Services.Singleton;

public class MemoryHungryService : ISayHello
{
    private readonly ILogger<MemoryHungryService> _logger;
    private int saidHelloCounter = 0;

    public MemoryHungryService(ILogger<MemoryHungryService> logger)
    {
        Task.Delay(1000).Wait();
        _logger = logger;
        _logger.LogDebug("--------------DI approach, new instance of Memory Hungry Service was created!");
        Console.WriteLine("--------------DI approach, new instance of Memory Hungry Service was created!");
    }

    public string SayHello(string origin)
    {
        string hello = string.Format("--------------Hello there! Said hello {0} times, from: {1}", saidHelloCounter, origin);
        saidHelloCounter++;
        _logger.LogDebug("--------------Hello there! {origin}", origin);
        Console.WriteLine(hello);
        return hello;
    }
}