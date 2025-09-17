using Humanizer;
using WebAppSandbox01.Commands;
using WebAppSandbox01.Domain;
using WebAppSandbox01.Dtos;
using WebAppSandbox01.Models;

namespace WebAppSandbox01.Mapper
{
    public class WeatherForcastMapper
    {
        public static WeatherForcast DtoToDomain(WeatherForcastDto dto)
        {
            return new()
            {
                Date = dto.Date,
                TemperatureC = dto.TemperatureC,
                Summary = dto.Summary,
                ZipCode = dto.ZipCode,
            };
        }

        public static WeatherForecastModel DomainToModel(WeatherForcast domain)
        {
            return new() { 
                Date = domain.Date,
                TemperatureC = domain.TemperatureC,
                Summary = domain.Summary,
                ZipCode = domain.ZipCode,
            };
        }

        public static WeatherForcast ModelToDomain(WeatherForecastModel model)
        {
            return new()
            {
                Date = model.Date,
                TemperatureC = model.TemperatureC,
                Summary = model.Summary,
                ZipCode = model.ZipCode,
            };
        }

        public static WeatherForcastDto DomainToDto(WeatherForcast domain)
        {
            return new()
            {
                Date = domain.Date,
                TemperatureC = domain.TemperatureC,
                Summary = domain.Summary,
                ZipCode = domain.ZipCode,
            };
        }
    }
}
