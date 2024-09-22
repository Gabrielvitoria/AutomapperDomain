namespace AutomapperDomain
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {
            
        }
        public WeatherForecast(DateTime date, int temperatureC, string? summary)
        {
            Id = Guid.NewGuid();
            Date = date;
            TemperatureC = temperatureC;
            TemperatureF = 32 + (int)(TemperatureC / 0.5556);
            Summary = summary;
        }

        public Guid Id { get; set; }

        public DateTime Date { get; private set; }

        public int TemperatureC { get; private set; }

        public int TemperatureF { get; private set; }

        public string? Summary { get; private set; }

        public string Observation { get; private set; }


        public void SetObservation()
        {
            this.Observation = "Set value with SetObservation()";
        }
    }
}
