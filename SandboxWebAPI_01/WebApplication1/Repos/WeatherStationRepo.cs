using WebAppSandbox01.Models;

namespace WebAppSandbox01.Repos
{
    public class WeatherStationRepo
    {
        private static List<WeatherForecast> _weatherForcasts;


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherStationRepo()
        {
            _weatherForcasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                ZipCode = Random.Shared.Next(10000, 99999)
            })
            .ToList();
        }

        public async Task AddWeatherForcast(WeatherForecast weatherForcast)
        {
            _weatherForcasts.Add(weatherForcast);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllWeatherForcasts()
        {
            return await Task.FromResult(_weatherForcasts);
        }
    }
}
