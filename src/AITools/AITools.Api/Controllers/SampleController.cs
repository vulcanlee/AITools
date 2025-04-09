using Microsoft.AspNetCore.Mvc;

namespace csNET9WebApiStandard.Controllers;

[ApiController]
[Route("API/[controller]")]
public class SampleController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<SampleController> _logger;

    public SampleController(ILogger<SampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<string> Get()
    {
        return Enumerable.Range(1, 5).Select(index => Summaries[Random.Shared
            .Next(Summaries.Length)]);
    }
}
