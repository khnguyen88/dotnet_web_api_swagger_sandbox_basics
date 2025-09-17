using MediatR;
using WebAppSandbox01.Models;
using WebAppSandbox01.Services;

namespace WebAppSandbox01.Commands
{
    public record AddWeatherForcastCommand(WeatherForecast WeatherForcast): IRequest;
}
