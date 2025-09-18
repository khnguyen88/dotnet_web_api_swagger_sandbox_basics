namespace WebAppSandbox01.Dtos
{
    public class WeatherForcastDto
    {
        public int Id { get; set; } = -1;

        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int ZipCode { get; set; }
    }
}
