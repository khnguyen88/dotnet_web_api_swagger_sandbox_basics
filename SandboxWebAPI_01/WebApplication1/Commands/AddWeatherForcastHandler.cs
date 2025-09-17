using MediatR;
using WebAppSandbox01.Services;

namespace WebAppSandbox01.Commands
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
            await _weatherStationService.AddWeatherForcast(request.WeatherForcast);
        }
    }
}
