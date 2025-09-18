using MediatR;
using WebAppSandbox01.Commands;
using WebAppSandbox01.Domain;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Mapper;
using WebAppSandbox01.Models;
using WebAppSandbox01.Services;

namespace WebAppSandbox01.CommandHandlers
{
    public class AddWeatherForcastHandler: IRequestHandler<AddWeatherForcastCommand>
    {
        private readonly WeatherStationService _weatherStationService;

        public AddWeatherForcastHandler(WeatherStationService weatherStation)
        {
            _weatherStationService = weatherStation;
        }

        public async Task Handle(AddWeatherForcastCommand request, CancellationToken cancellationToken)
        {
            await _weatherStationService.AddWeatherForcast(request.WeatherForcastDto);
        }
    }

    // Don't use this handle, just for learning purposes to see how V2 of the command is configured and different from V1
    // I just find it unncessary if we already have a set of DTO classes. Either use DTO classes or Command classes to pass over to different system.
    public class AddWeatherForcast2Handler : IRequestHandler<AddWeatherForcastCommand2>
    {
        private readonly WeatherStationService _weatherStationService;

        public AddWeatherForcast2Handler(WeatherStationService weatherStation)
        {
            _weatherStationService = weatherStation;
        }

        public async Task Handle(AddWeatherForcastCommand2 request, CancellationToken cancellationToken)
        {

            WeatherForcastDto dto = new()
            {
                Date = request.Date,
                Summary = request.Summary,
                TemperatureC = request.TemperatureC,
                ZipCode = request.ZipCode
            };

            await _weatherStationService.AddWeatherForcast(dto);
        }
    }
}
