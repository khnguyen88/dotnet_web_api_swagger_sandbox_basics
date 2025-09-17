namespace WebAppSandbox01.Dtos
{
    public class WeatherForcastDto
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int ZipCode { get; set; }
    }
}
