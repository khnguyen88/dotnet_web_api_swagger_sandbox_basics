using MediatR;
using System.Drawing.Printing;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Models;
using WebAppSandbox01.Queries;
using WebAppSandbox01.Services;

namespace WebAppSandbox01.QueryHandlers
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

    public class GetWeatherForcastByIdHandler : IRequestHandler<GetWeatherForcastByIdQuery, WeatherForcastDto>
    {
        private readonly WeatherStationService _weatherStationService;

        public GetWeatherForcastByIdHandler(WeatherStationService weatherStationService)
        {
            _weatherStationService = weatherStationService;
        }

        public async Task<WeatherForcastDto> Handle(GetWeatherForcastByIdQuery request, CancellationToken cancellationToken)
        {
            return await _weatherStationService.GetWeatherForcastById(request.Id);
        }
    }
}
