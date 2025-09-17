using MediatR;
using WebAppSandbox01.Models;

namespace WebAppSandbox01.Queries
{
    public record GetWeatherForcastsQuery() : IRequest<IEnumerable<WeatherForecast>>;
}
