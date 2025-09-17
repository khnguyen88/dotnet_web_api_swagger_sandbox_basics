using WebAppSandbox01.Models;
using WebAppSandbox01.Repos;

namespace WebAppSandbox01.Services
{
    public class WeatherStationService
    {
        private static WeatherStationRepo _weatherStationRepo;

        public WeatherStationService(WeatherStationRepo weatherStationRepo)
        {
            _weatherStationRepo = weatherStationRepo;
        }

        public async Task AddWeatherForcast(WeatherForecast weatherForcast)
        {
            await _weatherStationRepo.AddWeatherForcast(weatherForcast);
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllWeatherForcasts()
        {
            return await _weatherStationRepo.GetAllWeatherForcasts();
        }
    }
}
