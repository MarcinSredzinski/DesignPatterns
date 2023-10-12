using Microsoft.Extensions.Logging;

namespace BusinessLibrary.Services.Singleton;

public class MemoryHungryService : ISayHello
{
    private readonly ILogger<MemoryHungryService> _logger;

    public MemoryHungryService(ILogger<MemoryHungryService> logger)
    {
        Task.Delay(1000).Wait();       
        _logger = logger;
        _logger.LogDebug("--------------DI approach, new instance of Memory Hungry Service was created!");
    }

    public void SayHello(string origin)
    {
        _logger.LogDebug("--------------Hello there! {origin}", origin);
    }
}