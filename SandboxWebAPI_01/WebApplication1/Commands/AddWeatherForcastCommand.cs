using MediatR;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Models;
using WebAppSandbox01.Services;

namespace WebAppSandbox01.Commands
{
    public record AddWeatherForcastCommand(WeatherForcastDto WeatherForcastDto): IRequest;

    public record AddWeatherForcastCommand2 : IRequest
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int ZipCode { get; set; }
    }
}
