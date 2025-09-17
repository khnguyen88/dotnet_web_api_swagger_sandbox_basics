using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAppSandbox01.Commands;
using WebAppSandbox01.Models;
using WebAppSandbox01.Queries;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecasts")]
        public async Task<ActionResult> GetWeatherForecasts()
        {
            var weatherForcasts = await _mediator.Send(new GetWeatherForcastsQuery());

            return Ok(weatherForcasts);
        }

        [HttpPost(Name = "AddWeatherForecast")]
        public async Task<ActionResult> AddWeatherForecast([FromBody]WeatherForecast weatherForecast)
        {
            await _mediator.Send(new AddWeatherForcastCommand(weatherForecast));

            return StatusCode(201);
             
        }
    }
}
