using BusinessLibrary.Services.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class SingletonExampleController : ControllerBase
{
    private readonly ILogger<SingletonExampleController> _logger;
    private readonly ISayHello _service;

    public SingletonExampleController(ILogger<SingletonExampleController> logger, ISayHello memoryHungryService)
    {
        _logger = logger;
        _service = memoryHungryService;
    }

    [HttpGet(Name = "Get")]
    public IActionResult Get()
    {
        _logger.LogWarning("aaaaaaaaaaaaaaaaaa");
        _service.SayHello("Using DI");

        MemoryHungryServiceClassic.Instance.SayHello("Using the classic approach");

        return Ok();
    }
}