using WebAppSandbox01.Domain;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Mapper;
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

        public async Task AddWeatherForcast(WeatherForcastDto weatherForcast)
        {
            var domain = WeatherForcastMapper.DtoToDomain(weatherForcast);
            var model = WeatherForcastMapper.DomainToModel(domain);
            await _weatherStationRepo.AddWeatherForcast(model);
        }

        public async Task<IEnumerable<WeatherForcastDto>> GetAllWeatherForcasts()
        {
            var models = _weatherStationRepo.GetAllWeatherForcasts().Result;
            var domains = models.Select(m => WeatherForcastMapper.ModelToDomain(m)).ToList();
            
            return domains.Select(d => WeatherForcastMapper.DomainToDto(d)).ToList();
        }
    }
}
