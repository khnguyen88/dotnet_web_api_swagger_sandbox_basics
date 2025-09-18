using MediatR;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Models;

namespace WebAppSandbox01.Queries
{
    public record GetWeatherForcastsQuery() : IRequest<IEnumerable<WeatherForcastDto>>;

    public record GetWeatherForcastByIdQuery(int Id) : IRequest<WeatherForcastDto>;

}
