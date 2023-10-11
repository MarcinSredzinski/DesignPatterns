using BusinessLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MemoryHungryService _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, MemoryHungryService memoryHungryService)
        {
            _logger = logger;
            _service = memoryHungryService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _service.SayHello("Using DI");

            MemoryHungryServiceClassic.Instance.SayHello("Using the classic approach");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}