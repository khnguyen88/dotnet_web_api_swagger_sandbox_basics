namespace WebAppSandbox01.Domain
{
    public class WeatherForcast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int ZipCode { get; set; }
    }
}
