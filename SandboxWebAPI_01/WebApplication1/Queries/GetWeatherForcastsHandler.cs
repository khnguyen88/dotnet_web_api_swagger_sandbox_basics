using MediatR;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Models;
using WebAppSandbox01.Services;

namespace WebAppSandbox01.Queries
{
    public class GetWeatherForcastsHandler : IRequestHandler<GetWeatherForcastsQuery, IEnumerable<WeatherForcastDto>>
    {
        private readonly WeatherStationService _weatherStationService;

        public GetWeatherForcastsHandler(WeatherStationService weatherStationService)
        {
            _weatherStationService = weatherStationService;
        }

        public async Task<IEnumerable<WeatherForcastDto>> Handle(GetWeatherForcastsQuery request, CancellationToken cancellationToken)
        {
            return await _weatherStationService.GetAllWeatherForcasts();
        }
        
    }
}
