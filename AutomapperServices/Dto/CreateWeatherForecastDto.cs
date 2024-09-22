namespace AutomapperServices.Dto
{
    public class CreateWeatherForecastDto
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public string? Observation { get; set; }

    }
}
