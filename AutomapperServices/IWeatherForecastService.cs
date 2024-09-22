using AutomapperServices.Dto;

namespace AutomapperServices
{
    public interface IWeatherForecastService
    {
        WeatherForecastDto PostWeatherForecast(CreateWeatherForecastDto createWeatherForecastDto);
    }
}
